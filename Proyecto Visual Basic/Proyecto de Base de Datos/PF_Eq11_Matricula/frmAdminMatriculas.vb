Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmAdminMatriculas
    Private sqlconn As New SqlConnection
    Private sqlcomm As SqlCommand
    Private sdr As New SqlDataAdapter
    Private dt As New DataTable

    Private Function BuscarAdminMatriculas() As DataTable
        Dim mainconn = ConfigurationManager.ConnectionStrings("PF_Eq11_Matricula.My.MySettings.RegistroUTPConnectionString").ConnectionString
        sqlconn = New SqlConnection(mainconn)
        Dim sqlquery As String = "SELECT a.asig_nombre 'ASIGNATURA', a.codAsig 'CODASIG', c.codHora 'CODHORA', e.est_cedula 'CÉDULA', 
                                    e.est_nombre + ' ' + e.est_apellido 'NOMBRE', e.est_correo 'CORREO', e.facCodigo 'FACULTAD', 
                                    c.grup 'GRUPO', d.doc_apellido  + ', ' + d.doc_nombre'PROFESOR'
                                    FROM Estudiante e 
                                    JOIN Cursa c
                                        ON e.est_cedula = c.cedula_est
                                    JOIN Asignatura a
                                        ON c.asigCodigo = a.codAsig
                                    JOIN Imparte i
                                        ON i.asigCodigo = a.codAsig
                                    JOIN Docente d
                                        On d.doc_cedula = i.cedula_doc"
        sqlquery &= " WHERE a.asig_nombre LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR a.codAsig LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR e.est_cedula LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR e.est_nombre + ' ' + e.est_apellido LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR e.est_correo LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR e.facCodigo LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR c.grup LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR d.doc_apellido + ', ' + d.doc_nombre LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR d.doc_nombre  + ' ' + d.doc_apellido LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR @parm1='' "

        sqlcomm = New SqlCommand(sqlquery, sqlconn)
        sqlcomm.Parameters.AddWithValue("@parm1", txtBuscar.Text.Trim())
        sdr = New SqlDataAdapter(sqlcomm)
        dt = New DataTable()
        sdr.Fill(dt)

        Return dt
    End Function

    Private Sub VerMatriculasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmAdminRegistro.Show()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Me.Hide()
        frmAdminRegistro.Show()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("¿Seguro que desea cerrar sesión?", "UTP", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            Me.Hide()
            frmAdminIni.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = TimeOfDay.ToString("T")
    End Sub

    Private Sub frmAdminMatriculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        dgvAdminMatriculas.DataSource = Me.BuscarAdminMatriculas
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        dgvAdminMatriculas.DataSource = Me.BuscarAdminMatriculas
    End Sub
End Class