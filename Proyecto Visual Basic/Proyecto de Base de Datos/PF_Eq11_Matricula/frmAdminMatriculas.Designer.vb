<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminMatriculas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminMatriculas))
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pctBuscar = New System.Windows.Forms.PictureBox()
        Me.MnuAdmin = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pctHora = New System.Windows.Forms.PictureBox()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dgvAdminMatriculas = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.pctBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MnuAdmin.SuspendLayout()
        CType(Me.pctHora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAdminMatriculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(467, 98)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(150, 20)
        Me.txtBuscar.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(383, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 28)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Matrículas Realizadas"
        '
        'pctBuscar
        '
        Me.pctBuscar.Image = CType(resources.GetObject("pctBuscar.Image"), System.Drawing.Image)
        Me.pctBuscar.Location = New System.Drawing.Point(444, 99)
        Me.pctBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.pctBuscar.Name = "pctBuscar"
        Me.pctBuscar.Size = New System.Drawing.Size(18, 16)
        Me.pctBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBuscar.TabIndex = 33
        Me.pctBuscar.TabStop = False
        '
        'MnuAdmin
        '
        Me.MnuAdmin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MnuAdmin.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MnuAdmin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem})
        Me.MnuAdmin.Location = New System.Drawing.Point(0, 0)
        Me.MnuAdmin.Name = "MnuAdmin"
        Me.MnuAdmin.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MnuAdmin.Size = New System.Drawing.Size(1036, 30)
        Me.MnuAdmin.TabIndex = 34
        Me.MnuAdmin.Text = "Sistema de Matricula"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InicioToolStripMenuItem.Image = CType(resources.GetObject("InicioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(130, 28)
        Me.InicioToolStripMenuItem.Text = "Ver Registros"
        '
        'pctHora
        '
        Me.pctHora.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pctHora.Image = CType(resources.GetObject("pctHora.Image"), System.Drawing.Image)
        Me.pctHora.Location = New System.Drawing.Point(809, 7)
        Me.pctHora.Margin = New System.Windows.Forms.Padding(2)
        Me.pctHora.Name = "pctHora"
        Me.pctHora.Size = New System.Drawing.Size(22, 17)
        Me.pctHora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHora.TabIndex = 36
        Me.pctHora.TabStop = False
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblHora.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(835, 7)
        Me.lblHora.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(50, 18)
        Me.lblHora.TabIndex = 35
        Me.lblHora.Text = "Label1"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCerrar.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(914, 1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(119, 29)
        Me.btnCerrar.TabIndex = 37
        Me.btnCerrar.Text = "Cerrar Sesion"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'dgvAdminMatriculas
        '
        Me.dgvAdminMatriculas.AllowUserToAddRows = False
        Me.dgvAdminMatriculas.AllowUserToDeleteRows = False
        Me.dgvAdminMatriculas.AllowUserToOrderColumns = True
        Me.dgvAdminMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdminMatriculas.Location = New System.Drawing.Point(35, 143)
        Me.dgvAdminMatriculas.Name = "dgvAdminMatriculas"
        Me.dgvAdminMatriculas.ReadOnly = True
        Me.dgvAdminMatriculas.Size = New System.Drawing.Size(961, 289)
        Me.dgvAdminMatriculas.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(390, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 18)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Buscar"
        '
        'frmAdminMatriculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1036, 463)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvAdminMatriculas)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.pctHora)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.pctBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MnuAdmin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAdminMatriculas"
        Me.Text = "Registro UTP"
        CType(Me.pctBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MnuAdmin.ResumeLayout(False)
        Me.MnuAdmin.PerformLayout()
        CType(Me.pctHora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAdminMatriculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pctBuscar As PictureBox
    Friend WithEvents MnuAdmin As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pctHora As PictureBox
    Friend WithEvents lblHora As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dgvAdminMatriculas As DataGridView
    Friend WithEvents Label2 As Label
End Class
