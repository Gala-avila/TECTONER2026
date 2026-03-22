<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.TBUSUARIO = New System.Windows.Forms.TextBox()
        Me.TBCONTRASENA = New System.Windows.Forms.TextBox()
        Me.BOTONCONTINUAR = New System.Windows.Forms.Button()
        Me.BOTONVER = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBUSUARIO
        '
        Me.TBUSUARIO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBUSUARIO.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBUSUARIO.Location = New System.Drawing.Point(488, 276)
        Me.TBUSUARIO.MaxLength = 15
        Me.TBUSUARIO.Name = "TBUSUARIO"
        Me.TBUSUARIO.Size = New System.Drawing.Size(260, 19)
        Me.TBUSUARIO.TabIndex = 0
        '
        'TBCONTRASENA
        '
        Me.TBCONTRASENA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBCONTRASENA.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCONTRASENA.Location = New System.Drawing.Point(488, 367)
        Me.TBCONTRASENA.MaxLength = 15
        Me.TBCONTRASENA.Name = "TBCONTRASENA"
        Me.TBCONTRASENA.Size = New System.Drawing.Size(260, 19)
        Me.TBCONTRASENA.TabIndex = 1
        Me.TBCONTRASENA.UseSystemPasswordChar = True
        '
        'BOTONCONTINUAR
        '
        Me.BOTONCONTINUAR.BackColor = System.Drawing.Color.Transparent
        Me.BOTONCONTINUAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BOTONCONTINUAR.FlatAppearance.BorderSize = 0
        Me.BOTONCONTINUAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BOTONCONTINUAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BOTONCONTINUAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOTONCONTINUAR.ForeColor = System.Drawing.Color.Transparent
        Me.BOTONCONTINUAR.Location = New System.Drawing.Point(344, 298)
        Me.BOTONCONTINUAR.Name = "BOTONCONTINUAR"
        Me.BOTONCONTINUAR.Size = New System.Drawing.Size(107, 60)
        Me.BOTONCONTINUAR.TabIndex = 2
        Me.BOTONCONTINUAR.UseVisualStyleBackColor = False
        '
        'BOTONVER
        '
        Me.BOTONVER.BackColor = System.Drawing.Color.Transparent
        Me.BOTONVER.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BOTONVER.FlatAppearance.BorderSize = 0
        Me.BOTONVER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BOTONVER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BOTONVER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOTONVER.ForeColor = System.Drawing.Color.Transparent
        Me.BOTONVER.Location = New System.Drawing.Point(707, 318)
        Me.BOTONVER.Name = "BOTONVER"
        Me.BOTONVER.Size = New System.Drawing.Size(49, 26)
        Me.BOTONVER.TabIndex = 3
        Me.BOTONVER.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.BOTONVER)
        Me.Controls.Add(Me.BOTONCONTINUAR)
        Me.Controls.Add(Me.TBCONTRASENA)
        Me.Controls.Add(Me.TBUSUARIO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INICIO DE SESIÓN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBUSUARIO As TextBox
    Friend WithEvents TBCONTRASENA As TextBox
    Friend WithEvents BOTONCONTINUAR As Button
    Friend WithEvents BOTONVER As Button
End Class
