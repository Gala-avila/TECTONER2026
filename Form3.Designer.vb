<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.BOTONIRAGUARDAR = New System.Windows.Forms.Button()
        Me.BOTONIRAVER = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BOTONIRAGUARDAR
        '
        Me.BOTONIRAGUARDAR.BackColor = System.Drawing.Color.Transparent
        Me.BOTONIRAGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BOTONIRAGUARDAR.FlatAppearance.BorderSize = 0
        Me.BOTONIRAGUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BOTONIRAGUARDAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BOTONIRAGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOTONIRAGUARDAR.ForeColor = System.Drawing.Color.Transparent
        Me.BOTONIRAGUARDAR.Location = New System.Drawing.Point(462, 136)
        Me.BOTONIRAGUARDAR.Name = "BOTONIRAGUARDAR"
        Me.BOTONIRAGUARDAR.Size = New System.Drawing.Size(280, 86)
        Me.BOTONIRAGUARDAR.TabIndex = 3
        Me.BOTONIRAGUARDAR.UseVisualStyleBackColor = False
        '
        'BOTONIRAVER
        '
        Me.BOTONIRAVER.BackColor = System.Drawing.Color.Transparent
        Me.BOTONIRAVER.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BOTONIRAVER.FlatAppearance.BorderSize = 0
        Me.BOTONIRAVER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BOTONIRAVER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BOTONIRAVER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOTONIRAVER.ForeColor = System.Drawing.Color.Transparent
        Me.BOTONIRAVER.Location = New System.Drawing.Point(462, 286)
        Me.BOTONIRAVER.Name = "BOTONIRAVER"
        Me.BOTONIRAVER.Size = New System.Drawing.Size(280, 81)
        Me.BOTONIRAVER.TabIndex = 4
        Me.BOTONIRAVER.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.BOTONIRAVER)
        Me.Controls.Add(Me.BOTONIRAGUARDAR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BOTONIRAGUARDAR As Button
    Friend WithEvents BOTONIRAVER As Button
End Class
