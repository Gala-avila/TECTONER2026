<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.TBNOMBRE = New System.Windows.Forms.TextBox()
        Me.TBAPELLIDO = New System.Windows.Forms.TextBox()
        Me.TBBIRTH = New System.Windows.Forms.TextBox()
        Me.TBGENERO = New System.Windows.Forms.TextBox()
        Me.TBTELEFONO = New System.Windows.Forms.TextBox()
        Me.TBDIRECCION = New System.Windows.Forms.TextBox()
        Me.TBNOTAS = New System.Windows.Forms.TextBox()
        Me.TBREGISTRO = New System.Windows.Forms.TextBox()
        Me.TBEMAIL = New System.Windows.Forms.TextBox()
        Me.LOGOUT = New System.Windows.Forms.Button()
        Me.BOTONVACIAR = New System.Windows.Forms.Button()
        Me.BOTONELIMINAR = New System.Windows.Forms.Button()
        Me.BOTONEDITAR = New System.Windows.Forms.Button()
        Me.BOTONBUSCAR = New System.Windows.Forms.Button()
        Me.BOTONVOLVERATRAS = New System.Windows.Forms.Button()
        Me.BUSCARNOMBRE = New System.Windows.Forms.TextBox()
        Me.BUSCARTEL = New System.Windows.Forms.TextBox()
        Me.BUSCARID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TBNOMBRE
        '
        Me.TBNOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBNOMBRE.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNOMBRE.Location = New System.Drawing.Point(54, 331)
        Me.TBNOMBRE.MaxLength = 30
        Me.TBNOMBRE.Name = "TBNOMBRE"
        Me.TBNOMBRE.Size = New System.Drawing.Size(160, 19)
        Me.TBNOMBRE.TabIndex = 2
        Me.TBNOMBRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBAPELLIDO
        '
        Me.TBAPELLIDO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBAPELLIDO.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBAPELLIDO.Location = New System.Drawing.Point(246, 331)
        Me.TBAPELLIDO.MaxLength = 30
        Me.TBAPELLIDO.Name = "TBAPELLIDO"
        Me.TBAPELLIDO.Size = New System.Drawing.Size(160, 19)
        Me.TBAPELLIDO.TabIndex = 3
        Me.TBAPELLIDO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBBIRTH
        '
        Me.TBBIRTH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBBIRTH.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBIRTH.Location = New System.Drawing.Point(148, 391)
        Me.TBBIRTH.MaxLength = 15
        Me.TBBIRTH.Name = "TBBIRTH"
        Me.TBBIRTH.Size = New System.Drawing.Size(160, 19)
        Me.TBBIRTH.TabIndex = 4
        Me.TBBIRTH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBGENERO
        '
        Me.TBGENERO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBGENERO.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBGENERO.Location = New System.Drawing.Point(72, 450)
        Me.TBGENERO.MaxLength = 20
        Me.TBGENERO.Name = "TBGENERO"
        Me.TBGENERO.Size = New System.Drawing.Size(323, 19)
        Me.TBGENERO.TabIndex = 5
        Me.TBGENERO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBTELEFONO
        '
        Me.TBTELEFONO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBTELEFONO.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTELEFONO.Location = New System.Drawing.Point(57, 511)
        Me.TBTELEFONO.MaxLength = 20
        Me.TBTELEFONO.Name = "TBTELEFONO"
        Me.TBTELEFONO.Size = New System.Drawing.Size(350, 19)
        Me.TBTELEFONO.TabIndex = 6
        Me.TBTELEFONO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBDIRECCION
        '
        Me.TBDIRECCION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBDIRECCION.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDIRECCION.Location = New System.Drawing.Point(58, 568)
        Me.TBDIRECCION.MaxLength = 100
        Me.TBDIRECCION.Name = "TBDIRECCION"
        Me.TBDIRECCION.Size = New System.Drawing.Size(251, 19)
        Me.TBDIRECCION.TabIndex = 7
        Me.TBDIRECCION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBNOTAS
        '
        Me.TBNOTAS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBNOTAS.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNOTAS.Location = New System.Drawing.Point(521, 456)
        Me.TBNOTAS.MaxLength = 200
        Me.TBNOTAS.Multiline = True
        Me.TBNOTAS.Name = "TBNOTAS"
        Me.TBNOTAS.Size = New System.Drawing.Size(230, 99)
        Me.TBNOTAS.TabIndex = 10
        Me.TBNOTAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBREGISTRO
        '
        Me.TBREGISTRO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBREGISTRO.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBREGISTRO.Location = New System.Drawing.Point(545, 391)
        Me.TBREGISTRO.MaxLength = 15
        Me.TBREGISTRO.Name = "TBREGISTRO"
        Me.TBREGISTRO.Size = New System.Drawing.Size(185, 19)
        Me.TBREGISTRO.TabIndex = 11
        Me.TBREGISTRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBEMAIL
        '
        Me.TBEMAIL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBEMAIL.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBEMAIL.Location = New System.Drawing.Point(530, 328)
        Me.TBEMAIL.MaxLength = 30
        Me.TBEMAIL.Name = "TBEMAIL"
        Me.TBEMAIL.Size = New System.Drawing.Size(213, 19)
        Me.TBEMAIL.TabIndex = 12
        Me.TBEMAIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.LOGOUT.Location = New System.Drawing.Point(719, 36)
        Me.LOGOUT.Name = "LOGOUT"
        Me.LOGOUT.Size = New System.Drawing.Size(44, 40)
        Me.LOGOUT.TabIndex = 13
        Me.LOGOUT.UseVisualStyleBackColor = False
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
        Me.BOTONVACIAR.Location = New System.Drawing.Point(578, 209)
        Me.BOTONVACIAR.Name = "BOTONVACIAR"
        Me.BOTONVACIAR.Size = New System.Drawing.Size(44, 40)
        Me.BOTONVACIAR.TabIndex = 14
        Me.BOTONVACIAR.UseVisualStyleBackColor = False
        '
        'BOTONELIMINAR
        '
        Me.BOTONELIMINAR.BackColor = System.Drawing.Color.Transparent
        Me.BOTONELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BOTONELIMINAR.FlatAppearance.BorderSize = 0
        Me.BOTONELIMINAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BOTONELIMINAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BOTONELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOTONELIMINAR.ForeColor = System.Drawing.Color.Transparent
        Me.BOTONELIMINAR.Location = New System.Drawing.Point(239, 201)
        Me.BOTONELIMINAR.Name = "BOTONELIMINAR"
        Me.BOTONELIMINAR.Size = New System.Drawing.Size(83, 55)
        Me.BOTONELIMINAR.TabIndex = 15
        Me.BOTONELIMINAR.UseVisualStyleBackColor = False
        '
        'BOTONEDITAR
        '
        Me.BOTONEDITAR.BackColor = System.Drawing.Color.Transparent
        Me.BOTONEDITAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BOTONEDITAR.FlatAppearance.BorderSize = 0
        Me.BOTONEDITAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BOTONEDITAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BOTONEDITAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOTONEDITAR.ForeColor = System.Drawing.Color.Transparent
        Me.BOTONEDITAR.Location = New System.Drawing.Point(478, 201)
        Me.BOTONEDITAR.Name = "BOTONEDITAR"
        Me.BOTONEDITAR.Size = New System.Drawing.Size(83, 55)
        Me.BOTONEDITAR.TabIndex = 16
        Me.BOTONEDITAR.UseVisualStyleBackColor = False
        '
        'BOTONBUSCAR
        '
        Me.BOTONBUSCAR.BackColor = System.Drawing.Color.Transparent
        Me.BOTONBUSCAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BOTONBUSCAR.FlatAppearance.BorderSize = 0
        Me.BOTONBUSCAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BOTONBUSCAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BOTONBUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOTONBUSCAR.ForeColor = System.Drawing.Color.Transparent
        Me.BOTONBUSCAR.Location = New System.Drawing.Point(360, 199)
        Me.BOTONBUSCAR.Name = "BOTONBUSCAR"
        Me.BOTONBUSCAR.Size = New System.Drawing.Size(83, 65)
        Me.BOTONBUSCAR.TabIndex = 17
        Me.BOTONBUSCAR.UseVisualStyleBackColor = False
        '
        'BOTONVOLVERATRAS
        '
        Me.BOTONVOLVERATRAS.BackColor = System.Drawing.Color.Transparent
        Me.BOTONVOLVERATRAS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BOTONVOLVERATRAS.FlatAppearance.BorderSize = 0
        Me.BOTONVOLVERATRAS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BOTONVOLVERATRAS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BOTONVOLVERATRAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOTONVOLVERATRAS.ForeColor = System.Drawing.Color.Transparent
        Me.BOTONVOLVERATRAS.Location = New System.Drawing.Point(617, 42)
        Me.BOTONVOLVERATRAS.Name = "BOTONVOLVERATRAS"
        Me.BOTONVOLVERATRAS.Size = New System.Drawing.Size(83, 33)
        Me.BOTONVOLVERATRAS.TabIndex = 18
        Me.BOTONVOLVERATRAS.UseVisualStyleBackColor = False
        '
        'BUSCARNOMBRE
        '
        Me.BUSCARNOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BUSCARNOMBRE.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUSCARNOMBRE.Location = New System.Drawing.Point(72, 140)
        Me.BUSCARNOMBRE.MaxLength = 30
        Me.BUSCARNOMBRE.Name = "BUSCARNOMBRE"
        Me.BUSCARNOMBRE.Size = New System.Drawing.Size(265, 19)
        Me.BUSCARNOMBRE.TabIndex = 19
        Me.BUSCARNOMBRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BUSCARTEL
        '
        Me.BUSCARTEL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BUSCARTEL.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUSCARTEL.Location = New System.Drawing.Point(465, 142)
        Me.BUSCARTEL.MaxLength = 30
        Me.BUSCARTEL.Name = "BUSCARTEL"
        Me.BUSCARTEL.Size = New System.Drawing.Size(265, 19)
        Me.BUSCARTEL.TabIndex = 20
        Me.BUSCARTEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BUSCARID
        '
        Me.BUSCARID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BUSCARID.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUSCARID.Location = New System.Drawing.Point(382, 142)
        Me.BUSCARID.MaxLength = 15
        Me.BUSCARID.Name = "BUSCARID"
        Me.BUSCARID.Size = New System.Drawing.Size(37, 19)
        Me.BUSCARID.TabIndex = 3
        Me.BUSCARID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(784, 591)
        Me.Controls.Add(Me.BUSCARID)
        Me.Controls.Add(Me.BUSCARTEL)
        Me.Controls.Add(Me.BUSCARNOMBRE)
        Me.Controls.Add(Me.BOTONVOLVERATRAS)
        Me.Controls.Add(Me.BOTONBUSCAR)
        Me.Controls.Add(Me.BOTONEDITAR)
        Me.Controls.Add(Me.BOTONELIMINAR)
        Me.Controls.Add(Me.BOTONVACIAR)
        Me.Controls.Add(Me.LOGOUT)
        Me.Controls.Add(Me.TBEMAIL)
        Me.Controls.Add(Me.TBREGISTRO)
        Me.Controls.Add(Me.TBNOTAS)
        Me.Controls.Add(Me.TBDIRECCION)
        Me.Controls.Add(Me.TBTELEFONO)
        Me.Controls.Add(Me.TBGENERO)
        Me.Controls.Add(Me.TBBIRTH)
        Me.Controls.Add(Me.TBAPELLIDO)
        Me.Controls.Add(Me.TBNOMBRE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BUSCAR DATOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBNOMBRE As TextBox
    Friend WithEvents TBAPELLIDO As TextBox
    Friend WithEvents TBBIRTH As TextBox
    Friend WithEvents TBGENERO As TextBox
    Friend WithEvents TBTELEFONO As TextBox
    Friend WithEvents TBDIRECCION As TextBox
    Friend WithEvents TBNOTAS As TextBox
    Friend WithEvents TBREGISTRO As TextBox
    Friend WithEvents TBEMAIL As TextBox
    Friend WithEvents LOGOUT As Button
    Friend WithEvents BOTONVACIAR As Button
    Friend WithEvents BOTONELIMINAR As Button
    Friend WithEvents BOTONEDITAR As Button
    Friend WithEvents BOTONBUSCAR As Button
    Friend WithEvents BOTONVOLVERATRAS As Button
    Friend WithEvents BUSCARNOMBRE As TextBox
    Friend WithEvents BUSCARTEL As TextBox
    Friend WithEvents BUSCARID As TextBox
End Class
