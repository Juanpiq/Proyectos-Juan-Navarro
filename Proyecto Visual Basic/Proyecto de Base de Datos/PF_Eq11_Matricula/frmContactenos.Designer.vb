<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContactenos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContactenos))
        Me.lblContáctenos = New System.Windows.Forms.Label()
        Me.pctRegresar = New System.Windows.Forms.PictureBox()
        Me.dgvFacultad = New System.Windows.Forms.DataGridView()
        Me.CodFacultadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaccorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorarioatencionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumedificioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumpisoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacultadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroUTPDataSet = New PF_Eq11_Matricula.RegistroUTPDataSet()
        Me.mnuUTP = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacultadTableAdapter = New PF_Eq11_Matricula.RegistroUTPDataSetTableAdapters.FacultadTableAdapter()
        CType(Me.pctRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFacultad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacultadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroUTPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuUTP.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblContáctenos
        '
        Me.lblContáctenos.AutoSize = True
        Me.lblContáctenos.Font = New System.Drawing.Font("Book Antiqua", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContáctenos.Location = New System.Drawing.Point(405, 78)
        Me.lblContáctenos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContáctenos.Name = "lblContáctenos"
        Me.lblContáctenos.Size = New System.Drawing.Size(221, 43)
        Me.lblContáctenos.TabIndex = 71
        Me.lblContáctenos.Text = "Contáctenos"
        '
        'pctRegresar
        '
        Me.pctRegresar.Image = CType(resources.GetObject("pctRegresar.Image"), System.Drawing.Image)
        Me.pctRegresar.Location = New System.Drawing.Point(51, 78)
        Me.pctRegresar.Name = "pctRegresar"
        Me.pctRegresar.Size = New System.Drawing.Size(58, 57)
        Me.pctRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctRegresar.TabIndex = 73
        Me.pctRegresar.TabStop = False
        '
        'dgvFacultad
        '
        Me.dgvFacultad.AllowUserToAddRows = False
        Me.dgvFacultad.AllowUserToDeleteRows = False
        Me.dgvFacultad.AutoGenerateColumns = False
        Me.dgvFacultad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacultad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodFacultadDataGridViewTextBoxColumn, Me.FaccorreoDataGridViewTextBoxColumn, Me.HorarioatencionDataGridViewTextBoxColumn, Me.NumedificioDataGridViewTextBoxColumn, Me.NumpisoDataGridViewTextBoxColumn})
        Me.dgvFacultad.DataSource = Me.FacultadBindingSource
        Me.dgvFacultad.Location = New System.Drawing.Point(96, 166)
        Me.dgvFacultad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvFacultad.Name = "dgvFacultad"
        Me.dgvFacultad.ReadOnly = True
        Me.dgvFacultad.RowHeadersWidth = 62
        Me.dgvFacultad.Size = New System.Drawing.Size(816, 252)
        Me.dgvFacultad.TabIndex = 74
        '
        'CodFacultadDataGridViewTextBoxColumn
        '
        Me.CodFacultadDataGridViewTextBoxColumn.DataPropertyName = "codFacultad"
        Me.CodFacultadDataGridViewTextBoxColumn.HeaderText = "codFacultad"
        Me.CodFacultadDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CodFacultadDataGridViewTextBoxColumn.Name = "CodFacultadDataGridViewTextBoxColumn"
        Me.CodFacultadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodFacultadDataGridViewTextBoxColumn.Width = 150
        '
        'FaccorreoDataGridViewTextBoxColumn
        '
        Me.FaccorreoDataGridViewTextBoxColumn.DataPropertyName = "fac_correo"
        Me.FaccorreoDataGridViewTextBoxColumn.HeaderText = "fac_correo"
        Me.FaccorreoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FaccorreoDataGridViewTextBoxColumn.Name = "FaccorreoDataGridViewTextBoxColumn"
        Me.FaccorreoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FaccorreoDataGridViewTextBoxColumn.Width = 150
        '
        'HorarioatencionDataGridViewTextBoxColumn
        '
        Me.HorarioatencionDataGridViewTextBoxColumn.DataPropertyName = "horario_atencion"
        Me.HorarioatencionDataGridViewTextBoxColumn.HeaderText = "horario_atencion"
        Me.HorarioatencionDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.HorarioatencionDataGridViewTextBoxColumn.Name = "HorarioatencionDataGridViewTextBoxColumn"
        Me.HorarioatencionDataGridViewTextBoxColumn.ReadOnly = True
        Me.HorarioatencionDataGridViewTextBoxColumn.Width = 150
        '
        'NumedificioDataGridViewTextBoxColumn
        '
        Me.NumedificioDataGridViewTextBoxColumn.DataPropertyName = "num_edificio"
        Me.NumedificioDataGridViewTextBoxColumn.HeaderText = "num_edificio"
        Me.NumedificioDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NumedificioDataGridViewTextBoxColumn.Name = "NumedificioDataGridViewTextBoxColumn"
        Me.NumedificioDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumedificioDataGridViewTextBoxColumn.Width = 150
        '
        'NumpisoDataGridViewTextBoxColumn
        '
        Me.NumpisoDataGridViewTextBoxColumn.DataPropertyName = "num_piso"
        Me.NumpisoDataGridViewTextBoxColumn.HeaderText = "num_piso"
        Me.NumpisoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NumpisoDataGridViewTextBoxColumn.Name = "NumpisoDataGridViewTextBoxColumn"
        Me.NumpisoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumpisoDataGridViewTextBoxColumn.Width = 150
        '
        'FacultadBindingSource
        '
        Me.FacultadBindingSource.DataMember = "Facultad"
        Me.FacultadBindingSource.DataSource = Me.RegistroUTPDataSet
        '
        'RegistroUTPDataSet
        '
        Me.RegistroUTPDataSet.DataSetName = "RegistroUTPDataSet"
        Me.RegistroUTPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mnuUTP
        '
        Me.mnuUTP.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mnuUTP.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuUTP.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuUTP.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuUTP.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem})
        Me.mnuUTP.Location = New System.Drawing.Point(0, 0)
        Me.mnuUTP.Name = "mnuUTP"
        Me.mnuUTP.Padding = New System.Windows.Forms.Padding(6, 2, 0, 2)
        Me.mnuUTP.Size = New System.Drawing.Size(1000, 32)
        Me.mnuUTP.TabIndex = 75
        Me.mnuUTP.Text = "Sistema de Matricula"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Image = CType(resources.GetObject("InicioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(101, 28)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'FacultadTableAdapter
        '
        Me.FacultadTableAdapter.ClearBeforeFill = True
        '
        'frmContactenos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1000, 522)
        Me.Controls.Add(Me.mnuUTP)
        Me.Controls.Add(Me.dgvFacultad)
        Me.Controls.Add(Me.pctRegresar)
        Me.Controls.Add(Me.lblContáctenos)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmContactenos"
        Me.Text = "frmContactenos"
        CType(Me.pctRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFacultad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacultadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroUTPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuUTP.ResumeLayout(False)
        Me.mnuUTP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblContáctenos As Label
    Friend WithEvents pctRegresar As PictureBox
    Friend WithEvents dgvFacultad As DataGridView
    Friend WithEvents mnuUTP As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroUTPDataSet As RegistroUTPDataSet
    Friend WithEvents FacultadBindingSource As BindingSource
    Friend WithEvents FacultadTableAdapter As RegistroUTPDataSetTableAdapters.FacultadTableAdapter
    Friend WithEvents CodFacultadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FaccorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HorarioatencionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumedificioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumpisoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
