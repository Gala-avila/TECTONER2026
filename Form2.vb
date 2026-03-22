Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BOTONCONTINUAR_Click(sender As Object, e As EventArgs) Handles BOTONCONTINUAR.Click
        ' Checar si los campos están vacíos
        If String.IsNullOrWhiteSpace(TBUSUARIO.Text) OrElse String.IsNullOrWhiteSpace(TBCONTRASENA.Text) Then
            MessageBox.Show("¡Faltan campos por llenar!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning) 'Esto es para el icono pequeño que sale en el mensaje
            Return
        End If

        ' Verificar el admin
        If TBUSUARIO.Text = "Admin" AndAlso TBCONTRASENA.Text = "AdminKey" Then
            Dim f3 As New Form3()
            f3.Show()
            Me.Close()
        Else
            MessageBox.Show("Algun dato no coincide", "Datos erróneos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BOTONVER_Click(sender As Object, e As EventArgs) Handles BOTONVER.Click

    End Sub

    Private Sub BOTONVER_MouseDown(sender As Object, e As MouseEventArgs) Handles BOTONVER.MouseDown
        ' Al mantener presionado el botón, mostrar la contraseña
        TBCONTRASENA.UseSystemPasswordChar = False
    End Sub

    Private Sub BOTONVER_MouseUp(sender As Object, e As MouseEventArgs) Handles BOTONVER.MouseUp
        ' Al soltar el botón, volver a ocultar la contraseña
        TBCONTRASENA.UseSystemPasswordChar = True
    End Sub

    Private Sub BOTONVER_MouseLeave(sender As Object, e As EventArgs) Handles BOTONVER.MouseLeave
        ' Si el cursor sale del botón mientras está presionado, asegurar que se oculte
        TBCONTRASENA.UseSystemPasswordChar = True
    End Sub
End Class