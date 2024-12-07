<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.mnuUTP = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactenosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentacionDelCursoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentacionAplicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mnuUTP.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuUTP
        '
        Me.mnuUTP.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mnuUTP.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuUTP.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuUTP.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.ContactenosToolStripMenuItem, Me.PresentacionToolStripMenuItem})
        Me.mnuUTP.Location = New System.Drawing.Point(0, 0)
        Me.mnuUTP.Name = "mnuUTP"
        Me.mnuUTP.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.mnuUTP.Size = New System.Drawing.Size(769, 30)
        Me.mnuUTP.TabIndex = 0
        Me.mnuUTP.Text = "Sistema de Matricula"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Image = CType(resources.GetObject("InicioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(79, 28)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'ContactenosToolStripMenuItem
        '
        Me.ContactenosToolStripMenuItem.Image = CType(resources.GetObject("ContactenosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContactenosToolStripMenuItem.Name = "ContactenosToolStripMenuItem"
        Me.ContactenosToolStripMenuItem.Size = New System.Drawing.Size(122, 28)
        Me.ContactenosToolStripMenuItem.Text = "Contactenos"
        '
        'PresentacionToolStripMenuItem
        '
        Me.PresentacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PresentacionDelCursoToolStripMenuItem, Me.PresentacionAplicacionToolStripMenuItem})
        Me.PresentacionToolStripMenuItem.Image = CType(resources.GetObject("PresentacionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PresentacionToolStripMenuItem.Name = "PresentacionToolStripMenuItem"
        Me.PresentacionToolStripMenuItem.Size = New System.Drawing.Size(124, 28)
        Me.PresentacionToolStripMenuItem.Text = "Presentacion"
        '
        'PresentacionDelCursoToolStripMenuItem
        '
        Me.PresentacionDelCursoToolStripMenuItem.Name = "PresentacionDelCursoToolStripMenuItem"
        Me.PresentacionDelCursoToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.PresentacionDelCursoToolStripMenuItem.Text = "Presentacion del Curso"
        '
        'PresentacionAplicacionToolStripMenuItem
        '
        Me.PresentacionAplicacionToolStripMenuItem.Name = "PresentacionAplicacionToolStripMenuItem"
        Me.PresentacionAplicacionToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.PresentacionAplicacionToolStripMenuItem.Text = "Presentacion Aplicacion"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(682, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 30)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sistema de Matricula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(277, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Universidad Tecnologica de Panama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(299, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Campus Victor Levi Sasso"
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdmin.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.Location = New System.Drawing.Point(317, 312)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(128, 45)
        Me.btnAdmin.TabIndex = 10
        Me.btnAdmin.Text = "Administrativo"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(317, 165)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 129)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(769, 369)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.mnuUTP)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuUTP
        Me.Name = "Form1"
        Me.Text = "UTP"
        Me.mnuUTP.ResumeLayout(False)
        Me.mnuUTP.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuUTP As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactenosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PresentacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAdmin As Button
    Friend WithEvents PresentacionDelCursoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PresentacionAplicacionToolStripMenuItem As ToolStripMenuItem
End Class
