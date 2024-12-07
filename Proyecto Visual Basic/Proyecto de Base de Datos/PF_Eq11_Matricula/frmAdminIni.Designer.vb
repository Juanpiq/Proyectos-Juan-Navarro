<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminIni
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminIni))
        Me.btnSesion = New System.Windows.Forms.Button()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblInstruccion = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.MnuAdmin = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactenosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentacionDelCursoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentacionAplicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pctInvisible = New System.Windows.Forms.PictureBox()
        Me.pctVisible = New System.Windows.Forms.PictureBox()
        Me.pctContra = New System.Windows.Forms.PictureBox()
        Me.pctUsuario = New System.Windows.Forms.PictureBox()
        Me.pctHora = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MnuAdmin.SuspendLayout()
        CType(Me.pctInvisible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctVisible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctContra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctHora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSesion
        '
        Me.btnSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSesion.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSesion.Location = New System.Drawing.Point(41, 252)
        Me.btnSesion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSesion.Name = "btnSesion"
        Me.btnSesion.Size = New System.Drawing.Size(123, 26)
        Me.btnSesion.TabIndex = 34
        Me.btnSesion.Text = "Iniciar Sesión"
        Me.btnSesion.UseVisualStyleBackColor = False
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(135, 192)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(177, 20)
        Me.txtContraseña.TabIndex = 29
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(135, 149)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(177, 20)
        Me.txtCedula.TabIndex = 28
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.Location = New System.Drawing.Point(24, 194)
        Me.lblContraseña.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(80, 18)
        Me.lblContraseña.TabIndex = 27
        Me.lblContraseña.Text = "Contraseña"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(27, 149)
        Me.lblCedula.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(53, 18)
        Me.lblCedula.TabIndex = 26
        Me.lblCedula.Text = "Cédula"
        '
        'lblInstruccion
        '
        Me.lblInstruccion.AutoSize = True
        Me.lblInstruccion.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruccion.Location = New System.Drawing.Point(27, 99)
        Me.lblInstruccion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInstruccion.Name = "lblInstruccion"
        Me.lblInstruccion.Size = New System.Drawing.Size(346, 18)
        Me.lblInstruccion.TabIndex = 25
        Me.lblInstruccion.Text = "Introduzca su cédula y clave para ingresar al sistema."
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Book Antiqua", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(178, 40)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(221, 37)
        Me.lblTitulo.TabIndex = 24
        Me.lblTitulo.Text = "Administrativo"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblHora.Location = New System.Drawing.Point(496, 9)
        Me.lblHora.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(39, 13)
        Me.lblHora.TabIndex = 23
        Me.lblHora.Text = "Label1"
        '
        'MnuAdmin
        '
        Me.MnuAdmin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MnuAdmin.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MnuAdmin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.ContactenosToolStripMenuItem, Me.PresentacionToolStripMenuItem})
        Me.MnuAdmin.Location = New System.Drawing.Point(0, 0)
        Me.MnuAdmin.Name = "MnuAdmin"
        Me.MnuAdmin.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MnuAdmin.Size = New System.Drawing.Size(588, 30)
        Me.MnuAdmin.TabIndex = 21
        Me.MnuAdmin.Text = "Sistema de Matricula"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Image = CType(resources.GetObject("InicioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(72, 28)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'ContactenosToolStripMenuItem
        '
        Me.ContactenosToolStripMenuItem.Image = CType(resources.GetObject("ContactenosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContactenosToolStripMenuItem.Name = "ContactenosToolStripMenuItem"
        Me.ContactenosToolStripMenuItem.Size = New System.Drawing.Size(110, 28)
        Me.ContactenosToolStripMenuItem.Text = "Contactenos"
        '
        'PresentacionToolStripMenuItem
        '
        Me.PresentacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PresentacionDelCursoToolStripMenuItem, Me.PresentacionAplicacionToolStripMenuItem})
        Me.PresentacionToolStripMenuItem.Image = CType(resources.GetObject("PresentacionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PresentacionToolStripMenuItem.Name = "PresentacionToolStripMenuItem"
        Me.PresentacionToolStripMenuItem.Size = New System.Drawing.Size(111, 28)
        Me.PresentacionToolStripMenuItem.Text = "Presentacion"
        '
        'PresentacionDelCursoToolStripMenuItem
        '
        Me.PresentacionDelCursoToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.PresentacionDelCursoToolStripMenuItem.Name = "PresentacionDelCursoToolStripMenuItem"
        Me.PresentacionDelCursoToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.PresentacionDelCursoToolStripMenuItem.Text = "Presentacion del Curso"
        '
        'PresentacionAplicacionToolStripMenuItem
        '
        Me.PresentacionAplicacionToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.PresentacionAplicacionToolStripMenuItem.Name = "PresentacionAplicacionToolStripMenuItem"
        Me.PresentacionAplicacionToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.PresentacionAplicacionToolStripMenuItem.Text = "Presentacion Aplicacion"
        '
        'pctInvisible
        '
        Me.pctInvisible.Image = CType(resources.GetObject("pctInvisible.Image"), System.Drawing.Image)
        Me.pctInvisible.Location = New System.Drawing.Point(288, 194)
        Me.pctInvisible.Margin = New System.Windows.Forms.Padding(2)
        Me.pctInvisible.Name = "pctInvisible"
        Me.pctInvisible.Size = New System.Drawing.Size(16, 14)
        Me.pctInvisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctInvisible.TabIndex = 35
        Me.pctInvisible.TabStop = False
        '
        'pctVisible
        '
        Me.pctVisible.Image = CType(resources.GetObject("pctVisible.Image"), System.Drawing.Image)
        Me.pctVisible.Location = New System.Drawing.Point(288, 196)
        Me.pctVisible.Margin = New System.Windows.Forms.Padding(2)
        Me.pctVisible.Name = "pctVisible"
        Me.pctVisible.Size = New System.Drawing.Size(15, 13)
        Me.pctVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctVisible.TabIndex = 33
        Me.pctVisible.TabStop = False
        Me.pctVisible.Visible = False
        '
        'pctContra
        '
        Me.pctContra.Image = CType(resources.GetObject("pctContra.Image"), System.Drawing.Image)
        Me.pctContra.Location = New System.Drawing.Point(103, 192)
        Me.pctContra.Margin = New System.Windows.Forms.Padding(2)
        Me.pctContra.Name = "pctContra"
        Me.pctContra.Size = New System.Drawing.Size(15, 20)
        Me.pctContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctContra.TabIndex = 32
        Me.pctContra.TabStop = False
        '
        'pctUsuario
        '
        Me.pctUsuario.Image = CType(resources.GetObject("pctUsuario.Image"), System.Drawing.Image)
        Me.pctUsuario.Location = New System.Drawing.Point(103, 149)
        Me.pctUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.pctUsuario.Name = "pctUsuario"
        Me.pctUsuario.Size = New System.Drawing.Size(15, 20)
        Me.pctUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctUsuario.TabIndex = 31
        Me.pctUsuario.TabStop = False
        '
        'pctHora
        '
        Me.pctHora.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pctHora.Image = CType(resources.GetObject("pctHora.Image"), System.Drawing.Image)
        Me.pctHora.Location = New System.Drawing.Point(470, 6)
        Me.pctHora.Margin = New System.Windows.Forms.Padding(2)
        Me.pctHora.Name = "pctHora"
        Me.pctHora.Size = New System.Drawing.Size(22, 17)
        Me.pctHora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHora.TabIndex = 30
        Me.pctHora.TabStop = False
        '
        'Timer1
        '
        '
        'frmAdminIni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(588, 292)
        Me.Controls.Add(Me.pctInvisible)
        Me.Controls.Add(Me.btnSesion)
        Me.Controls.Add(Me.pctVisible)
        Me.Controls.Add(Me.pctContra)
        Me.Controls.Add(Me.pctUsuario)
        Me.Controls.Add(Me.pctHora)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblInstruccion)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.MnuAdmin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAdminIni"
        Me.Text = "Administración"
        Me.MnuAdmin.ResumeLayout(False)
        Me.MnuAdmin.PerformLayout()
        CType(Me.pctInvisible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctVisible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctContra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctHora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctInvisible As PictureBox
    Friend WithEvents btnSesion As Button
    Friend WithEvents pctVisible As PictureBox
    Friend WithEvents pctContra As PictureBox
    Friend WithEvents pctUsuario As PictureBox
    Friend WithEvents pctHora As PictureBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblInstruccion As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents MnuAdmin As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactenosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PresentacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PresentacionDelCursoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PresentacionAplicacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
End Class
