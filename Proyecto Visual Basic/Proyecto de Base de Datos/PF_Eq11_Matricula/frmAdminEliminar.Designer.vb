<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminEliminar
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
        Dim lblApellido As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminEliminar))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtMatr = New System.Windows.Forms.TextBox()
        Me.txtFac = New System.Windows.Forms.TextBox()
        Me.txtIndice = New System.Windows.Forms.TextBox()
        Me.txtACurso = New System.Windows.Forms.TextBox()
        Me.lblIndice = New System.Windows.Forms.Label()
        Me.lblEM = New System.Windows.Forms.Label()
        Me.lblAC = New System.Windows.Forms.Label()
        Me.lblFacultad = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTel2 = New System.Windows.Forms.TextBox()
        Me.txtTel1 = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.lblTel1 = New System.Windows.Forms.Label()
        Me.lblTel2 = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNacionalidad = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblModificar = New System.Windows.Forms.Label()
        lblApellido = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblApellido
        '
        lblApellido.AutoSize = True
        lblApellido.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblApellido.Location = New System.Drawing.Point(280, 18)
        lblApellido.Name = "lblApellido"
        lblApellido.Size = New System.Drawing.Size(63, 18)
        lblApellido.TabIndex = 72
        lblApellido.Text = "Apellido"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.txtMatr)
        Me.Panel4.Controls.Add(Me.txtFac)
        Me.Panel4.Controls.Add(Me.txtIndice)
        Me.Panel4.Controls.Add(Me.txtACurso)
        Me.Panel4.Controls.Add(Me.lblIndice)
        Me.Panel4.Controls.Add(Me.lblEM)
        Me.Panel4.Controls.Add(Me.lblAC)
        Me.Panel4.Controls.Add(Me.lblFacultad)
        Me.Panel4.Location = New System.Drawing.Point(15, 359)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(649, 61)
        Me.Panel4.TabIndex = 112
        '
        'txtMatr
        '
        Me.txtMatr.Location = New System.Drawing.Point(589, 17)
        Me.txtMatr.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMatr.Name = "txtMatr"
        Me.txtMatr.ReadOnly = True
        Me.txtMatr.Size = New System.Drawing.Size(41, 20)
        Me.txtMatr.TabIndex = 108
        '
        'txtFac
        '
        Me.txtFac.Location = New System.Drawing.Point(93, 18)
        Me.txtFac.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFac.Name = "txtFac"
        Me.txtFac.ReadOnly = True
        Me.txtFac.Size = New System.Drawing.Size(86, 20)
        Me.txtFac.TabIndex = 107
        '
        'txtIndice
        '
        Me.txtIndice.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIndice.Location = New System.Drawing.Point(369, 15)
        Me.txtIndice.Name = "txtIndice"
        Me.txtIndice.ReadOnly = True
        Me.txtIndice.Size = New System.Drawing.Size(42, 24)
        Me.txtIndice.TabIndex = 105
        '
        'txtACurso
        '
        Me.txtACurso.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACurso.Location = New System.Drawing.Point(275, 15)
        Me.txtACurso.Name = "txtACurso"
        Me.txtACurso.ReadOnly = True
        Me.txtACurso.Size = New System.Drawing.Size(24, 24)
        Me.txtACurso.TabIndex = 104
        '
        'lblIndice
        '
        Me.lblIndice.AutoSize = True
        Me.lblIndice.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndice.Location = New System.Drawing.Point(322, 17)
        Me.lblIndice.Name = "lblIndice"
        Me.lblIndice.Size = New System.Drawing.Size(47, 18)
        Me.lblIndice.TabIndex = 101
        Me.lblIndice.Text = "Índice"
        '
        'lblEM
        '
        Me.lblEM.AutoSize = True
        Me.lblEM.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEM.Location = New System.Drawing.Point(435, 18)
        Me.lblEM.Name = "lblEM"
        Me.lblEM.Size = New System.Drawing.Size(136, 18)
        Me.lblEM.TabIndex = 100
        Me.lblEM.Text = "Estado de Matrícula"
        '
        'lblAC
        '
        Me.lblAC.AutoSize = True
        Me.lblAC.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAC.Location = New System.Drawing.Point(182, 17)
        Me.lblAC.Name = "lblAC"
        Me.lblAC.Size = New System.Drawing.Size(93, 18)
        Me.lblAC.TabIndex = 99
        Me.lblAC.Text = "Año Cursado"
        '
        'lblFacultad
        '
        Me.lblFacultad.AutoSize = True
        Me.lblFacultad.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacultad.Location = New System.Drawing.Point(29, 18)
        Me.lblFacultad.Name = "lblFacultad"
        Me.lblFacultad.Size = New System.Drawing.Size(62, 18)
        Me.lblFacultad.TabIndex = 98
        Me.lblFacultad.Text = "Facultad"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtTel2)
        Me.Panel3.Controls.Add(Me.txtTel1)
        Me.Panel3.Controls.Add(Me.txtDireccion)
        Me.Panel3.Controls.Add(Me.txtNacionalidad)
        Me.Panel3.Controls.Add(Me.lblTel1)
        Me.Panel3.Controls.Add(Me.lblTel2)
        Me.Panel3.Controls.Add(Me.lblDireccion)
        Me.Panel3.Controls.Add(Me.lblNacionalidad)
        Me.Panel3.Location = New System.Drawing.Point(14, 237)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(650, 100)
        Me.Panel3.TabIndex = 111
        '
        'txtTel2
        '
        Me.txtTel2.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel2.Location = New System.Drawing.Point(487, 61)
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.ReadOnly = True
        Me.txtTel2.Size = New System.Drawing.Size(144, 24)
        Me.txtTel2.TabIndex = 86
        '
        'txtTel1
        '
        Me.txtTel1.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel1.Location = New System.Drawing.Point(487, 15)
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.ReadOnly = True
        Me.txtTel1.Size = New System.Drawing.Size(144, 24)
        Me.txtTel1.TabIndex = 85
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(129, 61)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(260, 24)
        Me.txtDireccion.TabIndex = 84
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNacionalidad.Location = New System.Drawing.Point(129, 15)
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.ReadOnly = True
        Me.txtNacionalidad.Size = New System.Drawing.Size(260, 24)
        Me.txtNacionalidad.TabIndex = 83
        '
        'lblTel1
        '
        Me.lblTel1.AutoSize = True
        Me.lblTel1.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel1.Location = New System.Drawing.Point(410, 18)
        Me.lblTel1.Name = "lblTel1"
        Me.lblTel1.Size = New System.Drawing.Size(71, 18)
        Me.lblTel1.TabIndex = 82
        Me.lblTel1.Text = "Teléfono1"
        '
        'lblTel2
        '
        Me.lblTel2.AutoSize = True
        Me.lblTel2.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel2.Location = New System.Drawing.Point(410, 64)
        Me.lblTel2.Name = "lblTel2"
        Me.lblTel2.Size = New System.Drawing.Size(71, 18)
        Me.lblTel2.TabIndex = 81
        Me.lblTel2.Text = "Teléfono2"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(30, 64)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(68, 18)
        Me.lblDireccion.TabIndex = 80
        Me.lblDireccion.Text = "Dirección"
        '
        'lblNacionalidad
        '
        Me.lblNacionalidad.AutoSize = True
        Me.lblNacionalidad.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacionalidad.Location = New System.Drawing.Point(30, 18)
        Me.lblNacionalidad.Name = "lblNacionalidad"
        Me.lblNacionalidad.Size = New System.Drawing.Size(93, 18)
        Me.lblNacionalidad.TabIndex = 79
        Me.lblNacionalidad.Text = "Nacionalidad"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtContraseña)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtApellido)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(lblApellido)
        Me.Panel2.Controls.Add(Me.lblNombre)
        Me.Panel2.Controls.Add(Me.txtCorreo)
        Me.Panel2.Controls.Add(Me.lblCorreo)
        Me.Panel2.Location = New System.Drawing.Point(16, 128)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(648, 94)
        Me.Panel2.TabIndex = 110
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(368, 54)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.ReadOnly = True
        Me.txtContraseña.Size = New System.Drawing.Size(171, 24)
        Me.txtContraseña.TabIndex = 126
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(280, 57)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Contraseña"
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(368, 15)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.ReadOnly = True
        Me.txtApellido.Size = New System.Drawing.Size(171, 24)
        Me.txtApellido.TabIndex = 74
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(95, 15)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(166, 24)
        Me.txtNombre.TabIndex = 73
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(28, 18)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(61, 18)
        Me.lblNombre.TabIndex = 71
        Me.lblNombre.Text = "Nombre"
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(95, 54)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.ReadOnly = True
        Me.txtCorreo.Size = New System.Drawing.Size(166, 24)
        Me.txtCorreo.TabIndex = 103
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(28, 57)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(53, 18)
        Me.lblCorreo.TabIndex = 97
        Me.lblCorreo.Text = "Correo"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btnValidar)
        Me.Panel1.Controls.Add(Me.txtCedula)
        Me.Panel1.Controls.Add(Me.lblCedula)
        Me.Panel1.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(16, 51)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 57)
        Me.Panel1.TabIndex = 109
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(13, 19)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 17)
        Me.Label10.TabIndex = 122
        Me.Label10.Text = "*"
        '
        'btnValidar
        '
        Me.btnValidar.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidar.Location = New System.Drawing.Point(241, 14)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(75, 26)
        Me.btnValidar.TabIndex = 95
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(95, 16)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(123, 24)
        Me.txtCedula.TabIndex = 94
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(28, 19)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(53, 18)
        Me.lblCedula.TabIndex = 93
        Me.lblCedula.Text = "Cédula"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(386, 440)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 35)
        Me.btnCancelar.TabIndex = 108
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(164, 440)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(105, 35)
        Me.btnEliminar.TabIndex = 107
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'lblModificar
        '
        Me.lblModificar.AutoSize = True
        Me.lblModificar.Font = New System.Drawing.Font("Book Antiqua", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificar.Location = New System.Drawing.Point(12, 6)
        Me.lblModificar.Name = "lblModificar"
        Me.lblModificar.Size = New System.Drawing.Size(198, 28)
        Me.lblModificar.TabIndex = 106
        Me.lblModificar.Text = "Eliminar Registro"
        '
        'frmAdminEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(687, 487)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblModificar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAdminEliminar"
        Me.Text = "Registro UTP"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtIndice As TextBox
    Friend WithEvents txtACurso As TextBox
    Friend WithEvents lblIndice As Label
    Friend WithEvents lblEM As Label
    Friend WithEvents lblAC As Label
    Friend WithEvents lblFacultad As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtTel2 As TextBox
    Friend WithEvents txtTel1 As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNacionalidad As TextBox
    Friend WithEvents lblTel1 As Label
    Friend WithEvents lblTel2 As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblNacionalidad As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents btnValidar As Button
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents lblCedula As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents lblModificar As Label
    Friend WithEvents txtMatr As TextBox
    Friend WithEvents txtFac As TextBox
End Class
