Public Class Form1
    Private WithEvents tiempo As New System.Windows.Forms.Timer()
    Private rnd As New System.Random()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Asegurarse que la barra empiece en cero
        Barradeprogreso.Value = 0

        ' Configurar y arrancar el timer
        tiempo.Interval = 200 ' milisegundos entre pasos (ajustable)
        tiempo.Start()
    End Sub

    Private Sub t_Tick(sender As Object, e As EventArgs) Handles tiempo.Tick
        ' Añadir entre 3 y 7 (Random.Next upper bound es exclusivo)
        Dim paso As Integer = rnd.Next(3, 8)

        ' Incrementar sin pasarse del máximo
        Dim nuevo As Integer = Math.Min(Barradeprogreso.Maximum, Barradeprogreso.Value + paso)
        Barradeprogreso.Value = nuevo

        ' Cuando se llene, detener y abrir Form2 cerrando este formulario
        If Barradeprogreso.Value >= Barradeprogreso.Maximum Then
            tiempo.Stop()
            Dim f2 As New Form2()
            f2.Show()

            Me.Hide()
        End If
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub Form1_AutoSizeChanged(sender As Object, e As EventArgs) Handles Me.AutoSizeChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
