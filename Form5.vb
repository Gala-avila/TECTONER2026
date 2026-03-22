Imports System.Data.SqlClient

Public Class Form5
    Private ReadOnly connString As String = "Server=(localdb)\ProjectModels;Database=GestionPacientes;Integrated Security=True;TrustServerCertificate=True"

    Private Sub BOTONBUSCAR_Click(sender As Object, e As EventArgs) Handles BOTONBUSCAR.Click
        ' Prioridad: BUSCARID, luego BUSCARTEL, luego BUSCARNOMBRE
        If Not String.IsNullOrWhiteSpace(BUSCARID.Text) Then
            Dim id As Integer
            If Integer.TryParse(BUSCARID.Text.Trim(), id) Then
                SearchById(id)
                Return
            Else
                MessageBox.Show("ID inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        If Not String.IsNullOrWhiteSpace(BUSCARTEL.Text) Then
            SearchByPhone(BUSCARTEL.Text.Trim())
            Return
        End If

        If Not String.IsNullOrWhiteSpace(BUSCARNOMBRE.Text) Then
            Dim text = BUSCARNOMBRE.Text.Trim()
            Dim prefix = If(text.Length >= 6, text.Substring(0, 6), text)
            SearchByNamePrefix(prefix)
            Return
        End If

        MessageBox.Show("Introduce un ID, teléfono o nombre para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BOTONELIMINAR_Click(sender As Object, e As EventArgs) Handles BOTONELIMINAR.Click
        If String.IsNullOrWhiteSpace(BUSCARID.Text) Then
            MessageBox.Show("No hay ID seleccionado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim resp = MessageBox.Show("¿Estás seguro que quieres realizar esta acción?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp <> DialogResult.Yes Then Return

        Dim id As Integer
        If Not Integer.TryParse(BUSCARID.Text.Trim(), id) Then
            MessageBox.Show("ID inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As New SqlConnection(connString)
                Using cmd As New SqlCommand("DELETE FROM PacientesPersonas WHERE id_paciente = @id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    conn.Open()
                    Dim rows = cmd.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show("Registro eliminado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearFields()
                    Else
                        MessageBox.Show("No se encontró el registro para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BOTONEDITAR_Click(sender As Object, e As EventArgs) Handles BOTONEDITAR.Click
        If String.IsNullOrWhiteSpace(BUSCARID.Text) Then
            MessageBox.Show("No hay ID seleccionado para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim resp = MessageBox.Show("¿Estás seguro que quieres realizar esta acción?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp <> DialogResult.Yes Then Return

        Dim id As Integer
        If Not Integer.TryParse(BUSCARID.Text.Trim(), id) Then
            MessageBox.Show("ID inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As New SqlConnection(connString)
                Using cmd As New SqlCommand(
                    "UPDATE PacientesPersonas SET nombre=@nombre, apellido=@apellido, fecha_nacimiento=@fecha_nacimiento, genero=@genero, telefono=@telefono, correo_electronico=@correo_electronico, direccion=@direccion, observaciones=@observaciones WHERE id_paciente=@id", conn)

                    cmd.Parameters.AddWithValue("@nombre", TBNOMBRE.Text.Trim())
                    cmd.Parameters.AddWithValue("@apellido", If(String.IsNullOrWhiteSpace(TBAPELLIDO.Text), CType(DBNull.Value, Object), CType(TBAPELLIDO.Text.Trim(), Object)))

                    Dim fechaNacimiento As Object = DBNull.Value
                    If Not String.IsNullOrWhiteSpace(TBBIRTH.Text) Then
                        Dim dt As DateTime
                        If DateTime.TryParse(TBBIRTH.Text, dt) Then
                            fechaNacimiento = dt.Date
                        Else
                            fechaNacimiento = DBNull.Value
                        End If
                    End If
                    cmd.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento)

                    cmd.Parameters.AddWithValue("@genero", If(String.IsNullOrWhiteSpace(TBGENERO.Text), CType(DBNull.Value, Object), CType(TBGENERO.Text.Trim(), Object)))
                    cmd.Parameters.AddWithValue("@telefono", If(String.IsNullOrWhiteSpace(TBTELEFONO.Text), CType(DBNull.Value, Object), CType(TBTELEFONO.Text.Trim(), Object)))
                    cmd.Parameters.AddWithValue("@correo_electronico", If(String.IsNullOrWhiteSpace(TBEMAIL.Text), CType(DBNull.Value, Object), CType(TBEMAIL.Text.Trim(), Object)))
                    cmd.Parameters.AddWithValue("@direccion", If(String.IsNullOrWhiteSpace(TBDIRECCION.Text), CType(DBNull.Value, Object), CType(TBDIRECCION.Text.Trim(), Object)))
                    cmd.Parameters.AddWithValue("@observaciones", If(String.IsNullOrWhiteSpace(TBNOTAS.Text), CType(DBNull.Value, Object), CType(TBNOTAS.Text.Trim(), Object)))
                    cmd.Parameters.AddWithValue("@id", id)

                    conn.Open()
                    Dim rows = cmd.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show("Registro modificado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se pudo encontrar este registro, no se pudo modificar", "Revisa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchById(id As Integer)
        Try
            Using conn As New SqlConnection(connString)
                Using cmd As New SqlCommand("SELECT * FROM PacientesPersonas WHERE id_paciente = @id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    conn.Open()
                    Using rdr = cmd.ExecuteReader()
                        If rdr.Read() Then
                            FillFieldsFromReader(rdr)
                        Else
                            MessageBox.Show("No se encontró un registro con ese ID.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error en búsqueda: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchByPhone(phone As String)
        Try
            Using conn As New SqlConnection(connString)
                Using cmd As New SqlCommand("SELECT TOP 1 * FROM PacientesPersonas WHERE telefono LIKE @phone", conn)
                    cmd.Parameters.AddWithValue("@phone", "%" & phone & "%")
                    conn.Open()
                    Using rdr = cmd.ExecuteReader()
                        If rdr.Read() Then
                            FillFieldsFromReader(rdr)
                        Else
                            MessageBox.Show("No se encontró registro con ese teléfono.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error en búsqueda: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchByNamePrefix(prefix As String)
        Try
            Using conn As New SqlConnection(connString)
                Using cmd As New SqlCommand("SELECT TOP 1 * FROM PacientesPersonas WHERE LEFT(nombre, @len) = @pref", conn)
                    cmd.Parameters.AddWithValue("@pref", prefix)
                    cmd.Parameters.AddWithValue("@len", prefix.Length)
                    conn.Open()
                    Using rdr = cmd.ExecuteReader()
                        If rdr.Read() Then
                            FillFieldsFromReader(rdr)
                        Else
                            MessageBox.Show("No se encontró registro con ese prefijo de nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error en búsqueda: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FillFieldsFromReader(rdr As SqlDataReader)
        BUSCARID.Text = If(IsDBNull(rdr("id_paciente")), "", rdr("id_paciente").ToString())
        TBNOMBRE.Text = If(IsDBNull(rdr("nombre")), "", rdr("nombre").ToString())
        TBAPELLIDO.Text = If(IsDBNull(rdr("apellido")), "", rdr("apellido").ToString())
        If IsDBNull(rdr("fecha_nacimiento")) Then
            TBBIRTH.Text = String.Empty
        Else
            TBBIRTH.Text = Convert.ToDateTime(rdr("fecha_nacimiento")).ToString("yyyy-MM-dd")
        End If
        TBGENERO.Text = If(IsDBNull(rdr("genero")), "", rdr("genero").ToString())
        TBTELEFONO.Text = If(IsDBNull(rdr("telefono")), "", rdr("telefono").ToString())
        TBEMAIL.Text = If(IsDBNull(rdr("correo_electronico")), "", rdr("correo_electronico").ToString())
        TBDIRECCION.Text = If(IsDBNull(rdr("direccion")), "", rdr("direccion").ToString())
        TBNOTAS.Text = If(IsDBNull(rdr("observaciones")), "", rdr("observaciones").ToString())
    End Sub

    Private Sub ClearFields()
        BUSCARID.Text = String.Empty
        BUSCARNOMBRE.Text = String.Empty
        BUSCARTEL.Text = String.Empty
        TBNOMBRE.Text = String.Empty
        TBAPELLIDO.Text = String.Empty
        TBBIRTH.Text = String.Empty
        TBGENERO.Text = String.Empty
        TBTELEFONO.Text = String.Empty
        TBEMAIL.Text = String.Empty
        TBDIRECCION.Text = String.Empty
        TBNOTAS.Text = String.Empty
    End Sub

    Private Sub BOTONVACIAR_Click(sender As Object, e As EventArgs) Handles BOTONVACIAR.Click
        ClearFields()
    End Sub

    Private Sub BOTONVOLVERATRAS_Click(sender As Object, e As EventArgs) Handles BOTONVOLVERATRAS.Click
        Dim f4 As New Form4()
        f4.Show()
        Me.Close()

    End Sub

    Private Sub LOGOUT_Click(sender As Object, e As EventArgs) Handles LOGOUT.Click
        Dim resp = MessageBox.Show("¿Deseas reiniciar la sesión?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = DialogResult.Yes Then
            Dim f2 As New Form2()
            f2.Show()
            Me.Close()
        End If
    End Sub
End Class
