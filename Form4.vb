Imports System.Data.SqlClient

Public Class Form4
    Private Sub BOTONGUARDAR_Click(sender As Object, e As EventArgs) Handles BOTONGUARDAR.Click
        ' Mensaje de que el campo de nombre es obligatorio
        If String.IsNullOrWhiteSpace(TBNOMBRE.Text) Then
            MessageBox.Show("Necesitas insertar un nombre como mínimo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBNOMBRE.Focus()
            Return
        End If

        Dim connString As String = "Server=(localdb)\ProjectModels;Database=GestionPacientes;Integrated Security=True;TrustServerCertificate=True"

        Try
            Using conn As New SqlConnection(connString)
                Using cmd As New SqlCommand(
                    "INSERT INTO PacientesPersonas (nombre, apellido, fecha_nacimiento, genero, telefono, correo_electronico, direccion, fecha_registro, observaciones) " &
                    "VALUES (@nombre, @apellido, @fecha_nacimiento, @genero, @telefono, @correo_electronico, @direccion, @fecha_registro, @observaciones)", conn)

                    cmd.Parameters.AddWithValue("@nombre", TBNOMBRE.Text.Trim())
                    cmd.Parameters.AddWithValue("@apellido", If(String.IsNullOrWhiteSpace(TBAPELLIDO.Text), CType(DBNull.Value, Object), CType(TBAPELLIDO.Text.Trim(), Object)))

                    ' fecha_nacimiento: opcional
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
                    cmd.Parameters.AddWithValue("@fecha_registro", DateTime.Now)
                    cmd.Parameters.AddWithValue("@observaciones", If(String.IsNullOrWhiteSpace(TBNOTAS.Text), CType(DBNull.Value, Object), CType(TBNOTAS.Text.Trim(), Object)))

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Datos almacenados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BOTONVACIAR_Click(sender As Object, e As EventArgs) Handles BOTONVACIAR.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        If Not Me.IsHandleCreated Then Return

        TBNOMBRE.Text = String.Empty
        TBAPELLIDO.Text = String.Empty
        TBBIRTH.Text = String.Empty
        TBGENERO.Text = String.Empty
        TBTELEFONO.Text = String.Empty
        TBEMAIL.Text = String.Empty
        TBDIRECCION.Text = String.Empty
        TBNOTAS.Text = String.Empty
        TBNOMBRE.Focus()
    End Sub

    Private Sub LOGOUT_Click(sender As Object, e As EventArgs) Handles LOGOUT.Click

        Dim resp = MessageBox.Show("¿Deseas reiniciar la sesión?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = DialogResult.Yes Then
            Dim f2 As New Form2()
            f2.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TBAPELLIDO_TextChanged(sender As Object, e As EventArgs) Handles TBAPELLIDO.TextChanged

    End Sub

    Private Sub TBBIRTH_TextChanged(sender As Object, e As EventArgs) Handles TBBIRTH.TextChanged

    End Sub

    Private Sub TBGENERO_TextChanged(sender As Object, e As EventArgs) Handles TBGENERO.TextChanged

    End Sub

    Private Sub TBTELEFONO_TextChanged(sender As Object, e As EventArgs) Handles TBTELEFONO.TextChanged

    End Sub

    Private Sub TBREGISTRO_TextChanged(sender As Object, e As EventArgs) Handles TBREGISTRO.TextChanged

    End Sub

    Private Sub TBDIRECCION_TextChanged(sender As Object, e As EventArgs) Handles TBDIRECCION.TextChanged

    End Sub

    Private Sub TBNOTAS_TextChanged(sender As Object, e As EventArgs) Handles TBNOTAS.TextChanged

    End Sub

    Private Sub TBNOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TBNOMBRE.TextChanged

    End Sub

    Private Sub TBEMAIL_TextChanged(sender As Object, e As EventArgs) Handles TBEMAIL.TextChanged

    End Sub

    Private Sub BOTONIRABUSCAR_Click(sender As Object, e As EventArgs) Handles BOTONIRABUSCAR.Click

        ' Ir al formulario donde buscamos los datos
        Dim f5 As New Form5()
        f5.Show()
        Me.Close()

    End Sub
End Class
