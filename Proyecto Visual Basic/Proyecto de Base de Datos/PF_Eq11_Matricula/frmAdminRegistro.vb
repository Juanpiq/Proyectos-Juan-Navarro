Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmAdminRegistro
    Private sqlconn As New SqlConnection
    Private sqlcomm As SqlCommand
    Private sdr As New SqlDataAdapter
    Private dt As New DataTable

    Private Function BuscarRegistro() As DataTable
        Dim mainconn = ConfigurationManager.ConnectionStrings("PF_Eq11_Matricula.My.MySettings.RegistroUTPConnectionString").ConnectionString
        sqlconn = New SqlConnection(mainconn)
        Dim sqlquery As String = "SELECT est_cedula 'CÉDULA', est_nombre + ' ' + est_apellido 'NOMBRE', est_correo 'CORREO', contraseña 'CONTRASEÑA', 
                                nacionalidad 'NACIONALIDAD', direccion 'DIRECCIÓN', año_cursado 'AÑO CURSADO', indice 'ÍNDICE', matriculado 'MATRICULADO', facCodigo 'FACULTAD'
                                FROM Estudiante"
        sqlquery &= " WHERE est_cedula LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR est_nombre LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR est_apellido LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR est_correo LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR contraseña LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR nacionalidad LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR direccion LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR año_cursado LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR indice LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR matriculado LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR facCodigo LIKE '%' + @parm1 + '%' "
        sqlquery &= " OR @parm1='' "

        sqlcomm = New SqlCommand(sqlquery, sqlconn)
        sqlcomm.Parameters.AddWithValue("@parm1", txtBuscar.Text.Trim())
        sdr = New SqlDataAdapter(sqlcomm)
        dt = New DataTable()
        sdr.Fill(dt)

        Return dt
    End Function

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        If MessageBox.Show("¿Seguro que desea cerrar sesión?", "UTP", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            Me.Hide()
            frmAdminIni.Show()
        End If
    End Sub

    Private Sub CrearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearToolStripMenuItem.Click
        frmAdminCrear.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        frmAdminModificar.Show()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        frmAdminEliminar.Show()
    End Sub

    Private Sub VerMatriculasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerMatriculasToolStripMenuItem.Click
        Me.Hide()
        frmAdminMatriculas.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = TimeOfDay.ToString("T")
    End Sub

    Private Sub lblHora_Click(sender As Object, e As EventArgs) Handles lblHora.Click

    End Sub

    Private Sub frmAdminRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        dgvAdminRegistro.DataSource = Me.BuscarRegistro
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        dgvAdminRegistro.DataSource = Me.BuscarRegistro
    End Sub
End Class