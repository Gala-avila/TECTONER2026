Public Class Form3
    Private Sub BOTONIRAGUARDAR_Click(sender As Object, e As EventArgs) Handles BOTONIRAGUARDAR.Click
        Dim f4 As New Form4()
        f4.Show()
        Me.Close()

    End Sub

    Private Sub BOTONIRAVER_Click(sender As Object, e As EventArgs) Handles BOTONIRAVER.Click

        ' Abrir el formulario donde guardamos los datos
        Dim f5 As New Form5()
        f5.Show()
        Me.Close()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class