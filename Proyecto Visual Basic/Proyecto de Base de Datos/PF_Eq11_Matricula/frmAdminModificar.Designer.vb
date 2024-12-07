<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminModificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminModificar))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtFac = New System.Windows.Forms.TextBox()
        Me.txtMatr = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIndice = New System.Windows.Forms.TextBox()
        Me.txtACurso = New System.Windows.Forms.TextBox()
        Me.lblIndice = New System.Windows.Forms.Label()
        Me.lblEM = New System.Windows.Forms.Label()
        Me.lblAC = New System.Windows.Forms.Label()
        Me.lblFacultad = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cboNacionalidad = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTel2 = New System.Windows.Forms.TextBox()
        Me.txtTel1 = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblTel1 = New System.Windows.Forms.Label()
        Me.lblTel2 = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNacionalidad = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.btnActualizar = New System.Windows.Forms.Button()
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
        lblApellido.Location = New System.Drawing.Point(420, 28)
        lblApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblApellido.Name = "lblApellido"
        lblApellido.Size = New System.Drawing.Size(89, 24)
        lblApellido.TabIndex = 72
        lblApellido.Text = "Apellido"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.txtFac)
        Me.Panel4.Controls.Add(Me.txtMatr)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtIndice)
        Me.Panel4.Controls.Add(Me.txtACurso)
        Me.Panel4.Controls.Add(Me.lblIndice)
        Me.Panel4.Controls.Add(Me.lblEM)
        Me.Panel4.Controls.Add(Me.lblAC)
        Me.Panel4.Controls.Add(Me.lblFacultad)
        Me.Panel4.Location = New System.Drawing.Point(24, 552)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(972, 92)
        Me.Panel4.TabIndex = 120
        '
        'txtFac
        '
        Me.txtFac.Location = New System.Drawing.Point(140, 25)
        Me.txtFac.Name = "txtFac"
        Me.txtFac.ReadOnly = True
        Me.txtFac.Size = New System.Drawing.Size(138, 26)
        Me.txtFac.TabIndex = 130
        '
        'txtMatr
        '
        Me.txtMatr.Location = New System.Drawing.Point(880, 28)
        Me.txtMatr.Name = "txtMatr"
        Me.txtMatr.ReadOnly = True
        Me.txtMatr.Size = New System.Drawing.Size(62, 26)
        Me.txtMatr.TabIndex = 129
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(21, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 24)
        Me.Label6.TabIndex = 127
        Me.Label6.Text = "*"
        '
        'txtIndice
        '
        Me.txtIndice.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIndice.Location = New System.Drawing.Point(584, 22)
        Me.txtIndice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIndice.Name = "txtIndice"
        Me.txtIndice.ReadOnly = True
        Me.txtIndice.Size = New System.Drawing.Size(61, 32)
        Me.txtIndice.TabIndex = 105
        Me.txtIndice.Text = "3.00"
        Me.txtIndice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtACurso
        '
        Me.txtACurso.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACurso.Location = New System.Drawing.Point(438, 23)
        Me.txtACurso.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtACurso.Name = "txtACurso"
        Me.txtACurso.ReadOnly = True
        Me.txtACurso.Size = New System.Drawing.Size(36, 32)
        Me.txtACurso.TabIndex = 104
        Me.txtACurso.Text = "1"
        Me.txtACurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblIndice
        '
        Me.lblIndice.AutoSize = True
        Me.lblIndice.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndice.Location = New System.Drawing.Point(504, 26)
        Me.lblIndice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIndice.Name = "lblIndice"
        Me.lblIndice.Size = New System.Drawing.Size(66, 24)
        Me.lblIndice.TabIndex = 101
        Me.lblIndice.Text = "Índice"
        '
        'lblEM
        '
        Me.lblEM.AutoSize = True
        Me.lblEM.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEM.Location = New System.Drawing.Point(669, 28)
        Me.lblEM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEM.Name = "lblEM"
        Me.lblEM.Size = New System.Drawing.Size(189, 24)
        Me.lblEM.TabIndex = 100
        Me.lblEM.Text = "Estado de Matrícula"
        '
        'lblAC
        '
        Me.lblAC.AutoSize = True
        Me.lblAC.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAC.Location = New System.Drawing.Point(290, 29)
        Me.lblAC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAC.Name = "lblAC"
        Me.lblAC.Size = New System.Drawing.Size(129, 24)
        Me.lblAC.TabIndex = 99
        Me.lblAC.Text = "Año Cursado"
        '
        'lblFacultad
        '
        Me.lblFacultad.AutoSize = True
        Me.lblFacultad.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacultad.Location = New System.Drawing.Point(44, 28)
        Me.lblFacultad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFacultad.Name = "lblFacultad"
        Me.lblFacultad.Size = New System.Drawing.Size(87, 24)
        Me.lblFacultad.TabIndex = 98
        Me.lblFacultad.Text = "Facultad"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.cboNacionalidad)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtTel2)
        Me.Panel3.Controls.Add(Me.txtTel1)
        Me.Panel3.Controls.Add(Me.txtDireccion)
        Me.Panel3.Controls.Add(Me.lblTel1)
        Me.Panel3.Controls.Add(Me.lblTel2)
        Me.Panel3.Controls.Add(Me.lblDireccion)
        Me.Panel3.Controls.Add(Me.lblNacionalidad)
        Me.Panel3.Location = New System.Drawing.Point(22, 365)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(973, 152)
        Me.Panel3.TabIndex = 119
        '
        'cboNacionalidad
        '
        Me.cboNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNacionalidad.FormattingEnabled = True
        Me.cboNacionalidad.Items.AddRange(New Object() {"-ESCOJA UNA OPCIÓN-", "PANAMEÑA", "EXTRANJERA"})
        Me.cboNacionalidad.Location = New System.Drawing.Point(196, 28)
        Me.cboNacionalidad.Name = "cboNacionalidad"
        Me.cboNacionalidad.Size = New System.Drawing.Size(385, 28)
        Me.cboNacionalidad.TabIndex = 126
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(22, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 24)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "*"
        '
        'txtTel2
        '
        Me.txtTel2.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel2.Location = New System.Drawing.Point(730, 94)
        Me.txtTel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.Size = New System.Drawing.Size(214, 32)
        Me.txtTel2.TabIndex = 86
        '
        'txtTel1
        '
        Me.txtTel1.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel1.Location = New System.Drawing.Point(730, 23)
        Me.txtTel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.Size = New System.Drawing.Size(214, 32)
        Me.txtTel1.TabIndex = 85
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(194, 94)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(388, 32)
        Me.txtDireccion.TabIndex = 84
        '
        'lblTel1
        '
        Me.lblTel1.AutoSize = True
        Me.lblTel1.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel1.Location = New System.Drawing.Point(615, 28)
        Me.lblTel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTel1.Name = "lblTel1"
        Me.lblTel1.Size = New System.Drawing.Size(99, 24)
        Me.lblTel1.TabIndex = 82
        Me.lblTel1.Text = "Teléfono1"
        '
        'lblTel2
        '
        Me.lblTel2.AutoSize = True
        Me.lblTel2.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel2.Location = New System.Drawing.Point(615, 98)
        Me.lblTel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTel2.Name = "lblTel2"
        Me.lblTel2.Size = New System.Drawing.Size(99, 24)
        Me.lblTel2.TabIndex = 81
        Me.lblTel2.Text = "Teléfono2"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(45, 98)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(96, 24)
        Me.lblDireccion.TabIndex = 80
        Me.lblDireccion.Text = "Dirección"
        '
        'lblNacionalidad
        '
        Me.lblNacionalidad.AutoSize = True
        Me.lblNacionalidad.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacionalidad.Location = New System.Drawing.Point(45, 28)
        Me.lblNacionalidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNacionalidad.Name = "lblNacionalidad"
        Me.lblNacionalidad.Size = New System.Drawing.Size(131, 24)
        Me.lblNacionalidad.TabIndex = 79
        Me.lblNacionalidad.Text = "Nacionalidad"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtContraseña)
        Me.Panel2.Controls.Add(Me.lblContraseña)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtApellido)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(lblApellido)
        Me.Panel2.Controls.Add(Me.lblNombre)
        Me.Panel2.Controls.Add(Me.txtCorreo)
        Me.Panel2.Controls.Add(Me.lblCorreo)
        Me.Panel2.Location = New System.Drawing.Point(26, 197)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(970, 142)
        Me.Panel2.TabIndex = 118
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(404, 88)
        Me.Label8.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 24)
        Me.Label8.TabIndex = 127
        Me.Label8.Text = "*"
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(552, 83)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(254, 32)
        Me.txtContraseña.TabIndex = 126
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.Location = New System.Drawing.Point(420, 88)
        Me.lblContraseña.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(112, 24)
        Me.lblContraseña.TabIndex = 125
        Me.lblContraseña.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(404, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 24)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(20, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 24)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "*"
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(552, 23)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.ReadOnly = True
        Me.txtApellido.Size = New System.Drawing.Size(254, 32)
        Me.txtApellido.TabIndex = 74
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(142, 23)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(247, 32)
        Me.txtNombre.TabIndex = 73
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(42, 28)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(85, 24)
        Me.lblNombre.TabIndex = 71
        Me.lblNombre.Text = "Nombre"
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(142, 83)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.ReadOnly = True
        Me.txtCorreo.Size = New System.Drawing.Size(247, 32)
        Me.txtCorreo.TabIndex = 103
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(42, 88)
        Me.lblCorreo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(72, 24)
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
        Me.Panel1.Location = New System.Drawing.Point(26, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(970, 86)
        Me.Panel1.TabIndex = 117
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(20, 29)
        Me.Label10.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 24)
        Me.Label10.TabIndex = 122
        Me.Label10.Text = "*"
        '
        'btnValidar
        '
        Me.btnValidar.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidar.Location = New System.Drawing.Point(362, 22)
        Me.btnValidar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(112, 40)
        Me.btnValidar.TabIndex = 95
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(142, 25)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(182, 32)
        Me.txtCedula.TabIndex = 94
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(42, 29)
        Me.lblCedula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(74, 24)
        Me.lblCedula.TabIndex = 93
        Me.lblCedula.Text = "Cédula"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(586, 669)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(150, 54)
        Me.btnCancelar.TabIndex = 116
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnActualizar.Enabled = False
        Me.btnActualizar.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(247, 669)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(158, 54)
        Me.btnActualizar.TabIndex = 115
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'lblModificar
        '
        Me.lblModificar.AutoSize = True
        Me.lblModificar.Font = New System.Drawing.Font("Book Antiqua", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificar.Location = New System.Drawing.Point(18, 14)
        Me.lblModificar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModificar.Name = "lblModificar"
        Me.lblModificar.Size = New System.Drawing.Size(317, 45)
        Me.lblModificar.TabIndex = 114
        Me.lblModificar.Text = "Modificar Registro"
        '
        'frmAdminModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1035, 740)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.lblModificar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdminModificar"
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
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIndice As TextBox
    Friend WithEvents txtACurso As TextBox
    Friend WithEvents lblIndice As Label
    Friend WithEvents lblEM As Label
    Friend WithEvents lblAC As Label
    Friend WithEvents lblFacultad As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTel2 As TextBox
    Friend WithEvents txtTel1 As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblTel1 As Label
    Friend WithEvents lblTel2 As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblNacionalidad As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
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
    Friend WithEvents btnActualizar As Button
    Friend WithEvents lblModificar As Label
    Friend WithEvents cboNacionalidad As ComboBox
    Friend WithEvents txtFac As TextBox
    Friend WithEvents txtMatr As TextBox
End Class
