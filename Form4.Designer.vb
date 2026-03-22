<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.TBNOMBRE = New System.Windows.Forms.TextBox()
        Me.TBAPELLIDO = New System.Windows.Forms.TextBox()
        Me.TBBIRTH = New System.Windows.Forms.TextBox()
        Me.TBGENERO = New System.Windows.Forms.TextBox()
        Me.TBTELEFONO = New System.Windows.Forms.TextBox()
        Me.TBDIRECCION = New System.Windows.Forms.TextBox()
        Me.TBEMAIL = New System.Windows.Forms.TextBox()
        Me.TBREGISTRO = New System.Windows.Forms.TextBox()
        Me.TBNOTAS = New System.Windows.Forms.TextBox()
        Me.BOTONGUARDAR = New System.Windows.Forms.Button()
        Me.BOTONVACIAR = New System.Windows.Forms.Button()
        Me.LOGOUT = New System.Windows.Forms.Button()
        Me.BOTONIRABUSCAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBNOMBRE
        '
        Me.TBNOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBNOMBRE.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNOMBRE.Location = New System.Drawing.Point(57, 149)
        Me.TBNOMBRE.MaxLength = 30
        Me.TBNOMBRE.Name = "TBNOMBRE"
        Me.TBNOMBRE.Size = New System.Drawing.Size(160, 19)
        Me.TBNOMBRE.TabIndex = 1
        Me.TBNOMBRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBAPELLIDO
        '
        Me.TBAPELLIDO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBAPELLIDO.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBAPELLIDO.Location = New System.Drawing.Point(247, 149)
        Me.TBAPELLIDO.MaxLength = 30
        Me.TBAPELLIDO.Name = "TBAPELLIDO"
        Me.TBAPELLIDO.Size = New System.Drawing.Size(160, 19)
        Me.TBAPELLIDO.TabIndex = 2
        Me.TBAPELLIDO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBBIRTH
        '
        Me.TBBIRTH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBBIRTH.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBIRTH.Location = New System.Drawing.Point(148, 208)
        Me.TBBIRTH.MaxLength = 15
        Me.TBBIRTH.Name = "TBBIRTH"
        Me.TBBIRTH.Size = New System.Drawing.Size(160, 19)
        Me.TBBIRTH.TabIndex = 3
        Me.TBBIRTH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBGENERO
        '
        Me.TBGENERO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBGENERO.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBGENERO.Location = New System.Drawing.Point(71, 268)
        Me.TBGENERO.MaxLength = 20
        Me.TBGENERO.Name = "TBGENERO"
        Me.TBGENERO.Size = New System.Drawing.Size(323, 19)
        Me.TBGENERO.TabIndex = 4
        Me.TBGENERO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBTELEFONO
        '
        Me.TBTELEFONO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBTELEFONO.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTELEFONO.Location = New System.Drawing.Point(57, 328)
        Me.TBTELEFONO.MaxLength = 20
        Me.TBTELEFONO.Name = "TBTELEFONO"
        Me.TBTELEFONO.Size = New System.Drawing.Size(350, 19)
        Me.TBTELEFONO.TabIndex = 5
        Me.TBTELEFONO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBDIRECCION
        '
        Me.TBDIRECCION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBDIRECCION.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDIRECCION.Location = New System.Drawing.Point(57, 385)
        Me.TBDIRECCION.MaxLength = 100
        Me.TBDIRECCION.Name = "TBDIRECCION"
        Me.TBDIRECCION.Size = New System.Drawing.Size(251, 19)
        Me.TBDIRECCION.TabIndex = 6
        Me.TBDIRECCION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBEMAIL
        '
        Me.TBEMAIL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBEMAIL.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBEMAIL.Location = New System.Drawing.Point(530, 145)
        Me.TBEMAIL.MaxLength = 30
        Me.TBEMAIL.Name = "TBEMAIL"
        Me.TBEMAIL.Size = New System.Drawing.Size(213, 19)
        Me.TBEMAIL.TabIndex = 7
        Me.TBEMAIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBREGISTRO
        '
        Me.TBREGISTRO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBREGISTRO.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBREGISTRO.Location = New System.Drawing.Point(545, 208)
        Me.TBREGISTRO.MaxLength = 15
        Me.TBREGISTRO.Name = "TBREGISTRO"
        Me.TBREGISTRO.Size = New System.Drawing.Size(185, 19)
        Me.TBREGISTRO.TabIndex = 8
        Me.TBREGISTRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBNOTAS
        '
        Me.TBNOTAS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBNOTAS.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNOTAS.Location = New System.Drawing.Point(523, 275)
        Me.TBNOTAS.MaxLength = 200
        Me.TBNOTAS.Multiline = True
        Me.TBNOTAS.Name = "TBNOTAS"
        Me.TBNOTAS.Size = New System.Drawing.Size(230, 99)
        Me.TBNOTAS.TabIndex = 9
        Me.TBNOTAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BOTONGUARDAR
        '
        Me.BOTONGUARDAR.BackColor = System.Drawing.Color.Transparent
        Me.BOTONGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BOTONGUARDAR.FlatAppearance.BorderSize = 0
        Me.BOTONGUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BOTONGUARDAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BOTONGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOTONGUARDAR.ForeColor = System.Drawing.Color.Transparent
        Me.BOTONGUARDAR.Location = New System.Drawing.Point(356, 373)
        Me.BOTONGUARDAR.Name = "BOTONGUARDAR"
        Me.BOTONGUARDAR.Size = New System.Drawing.Size(86, 43)
        Me.BOTONGUARDAR.TabIndex = 10
        Me.BOTONGUARDAR.UseVisualStyleBackColor = False
        '
        'BOTONVACIAR
        '
        Me.BOTONVACIAR.BackColor = System.Drawing.Color.Transparent
        Me.BOTONVACIAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BOTONVACIAR.FlatAppearance.BorderSize = 0
        Me.BOTONVACIAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BOTONVACIAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BOTONVACIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOTONVACIAR.ForeColor = System.Drawing.Color.Transparent
        Me.BOTONVACIAR.Location = New System.Drawing.Point(455, 377)
        Me.BOTONVACIAR.Name = "BOTONVACIAR"
        Me.BOTONVACIAR.Size = New System.Drawing.Size(44, 40)
        Me.BOTONVACIAR.TabIndex = 11
        Me.BOTONVACIAR.UseVisualStyleBackColor = False
        '
        'LOGOUT
        '
        Me.LOGOUT.BackColor = System.Drawing.Color.Transparent
        Me.LOGOUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LOGOUT.FlatAppearance.BorderSize = 0
        Me.LOGOUT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.LOGOUT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.LOGOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LOGOUT.ForeColor = System.Drawing.Color.Transparent
        Me.LOGOUT.Location = New System.Drawing.Point(719, 35)
        Me.LOGOUT.Name = "LOGOUT"
        Me.LOGOUT.Size = New System.Drawing.Size(44, 40)
        Me.LOGOUT.TabIndex = 12
        Me.LOGOUT.UseVisualStyleBackColor = False
        '
        'BOTONIRABUSCAR
        '
        Me.BOTONIRABUSCAR.BackColor = System.Drawing.Color.Transparent
        Me.BOTONIRABUSCAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BOTONIRABUSCAR.FlatAppearance.BorderSize = 0
        Me.BOTONIRABUSCAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BOTONIRABUSCAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BOTONIRABUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOTONIRABUSCAR.ForeColor = System.Drawing.Color.Transparent
        Me.BOTONIRABUSCAR.Location = New System.Drawing.Point(545, 386)
        Me.BOTONIRABUSCAR.Name = "BOTONIRABUSCAR"
        Me.BOTONIRABUSCAR.Size = New System.Drawing.Size(86, 43)
        Me.BOTONIRABUSCAR.TabIndex = 13
        Me.BOTONIRABUSCAR.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.BOTONIRABUSCAR)
        Me.Controls.Add(Me.LOGOUT)
        Me.Controls.Add(Me.BOTONVACIAR)
        Me.Controls.Add(Me.BOTONGUARDAR)
        Me.Controls.Add(Me.TBNOTAS)
        Me.Controls.Add(Me.TBREGISTRO)
        Me.Controls.Add(Me.TBEMAIL)
        Me.Controls.Add(Me.TBDIRECCION)
        Me.Controls.Add(Me.TBTELEFONO)
        Me.Controls.Add(Me.TBGENERO)
        Me.Controls.Add(Me.TBBIRTH)
        Me.Controls.Add(Me.TBAPELLIDO)
        Me.Controls.Add(Me.TBNOMBRE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BASE DE DATOS * GUARDAR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBNOMBRE As TextBox
    Friend WithEvents TBAPELLIDO As TextBox
    Friend WithEvents TBBIRTH As TextBox
    Friend WithEvents TBGENERO As TextBox
    Friend WithEvents TBTELEFONO As TextBox
    Friend WithEvents TBDIRECCION As TextBox
    Friend WithEvents TBEMAIL As TextBox
    Friend WithEvents TBREGISTRO As TextBox
    Friend WithEvents TBNOTAS As TextBox
    Friend WithEvents BOTONGUARDAR As Button
    Friend WithEvents BOTONVACIAR As Button
    Friend WithEvents LOGOUT As Button
    Friend WithEvents BOTONIRABUSCAR As Button
End Class
