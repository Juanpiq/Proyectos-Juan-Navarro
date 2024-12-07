Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmAdminEliminar
    Private sqlconn As New SqlConnection
    Private sqlcomm1, sqlcomm2 As SqlCommand
    Private sdr As New SqlDataAdapter
    Private dt As New DataTable

    Private Function ValidarCedula() As DataTable
        Dim mainconn = ConfigurationManager.ConnectionStrings("PF_Eq11_Matricula.My.MySettings.RegistroUTPConnectionString").ConnectionString
        sqlconn = New SqlConnection(mainconn)

        Dim sqlquery1 As String = "SELECT COUNT(*) est_cedula FROM Estudiante
                     WHERE est_cedula = @est_cedula"
        sqlcomm1 = New SqlCommand(sqlquery1, sqlconn)
        sqlcomm1.Parameters.AddWithValue("@est_cedula", txtCedula.Text.Trim())

        sqlconn.Open()
        Dim cant1 = Convert.ToInt32(sqlcomm1.ExecuteScalar())

        'Consulta para contar cuántas teléfonos tiene la cédula
        If cant1 = 1 Then
            sqlquery1 = "SELECT COUNT(*) cedula_est FROM Telefono_est
                         WHERE cedula_est = @cedula_est"
            sqlcomm1 = New SqlCommand(sqlquery1, sqlconn)
            sqlcomm1.Parameters.AddWithValue("@cedula_est", txtCedula.Text.Trim())

            Dim cant2 = Convert.ToInt32(sqlcomm1.ExecuteScalar())

            If cant2 >= 1 Then
                sqlquery1 = "SELECT e.est_cedula, e.est_nombre, e.est_apellido, e.est_correo, e.contraseña, e.nacionalidad,  
                         e.direccion, e.año_cursado, e.indice, e.matriculado, e.facCodigo, t.est_telefono
                        FROM Estudiante e
                        INNER JOIN Telefono_est t
	                        ON e.est_cedula = t.cedula_est
                        WHERE est_cedula = @est_cedula"

            ElseIf cant2 = 0 Then
                sqlquery1 = "SELECT * FROM Estudiante e
                            WHERE est_cedula = @est_cedula"
            End If


            sqlcomm1 = New SqlCommand(sqlquery1, sqlconn)
            sqlcomm1.Parameters.AddWithValue("@est_cedula", txtCedula.Text.Trim())

            sdr = New SqlDataAdapter(sqlcomm1)
            dt = New DataTable()
            sdr.Fill(dt)

            'Pasar datos de DataTable a TextBox
            txtCedula.Text = dt.Rows(0)(0).ToString()
            txtNombre.Text = dt.Rows(0)(1).ToString()
            txtApellido.Text = dt.Rows(0)(2).ToString()
            txtCorreo.Text = dt.Rows(0)(3).ToString()
            txtContraseña.Text = dt.Rows(0)(4).ToString()
            txtNacionalidad.Text = dt.Rows(0)(5).ToString()
            txtDireccion.Text = dt.Rows(0)(6).ToString()
            txtACurso.Text = dt.Rows(0)(7).ToString()
            txtIndice.Text = dt.Rows(0)(8).ToString()
            txtMatr.Text = dt.Rows(0)(9).ToString()
            txtFac.Text = dt.Rows(0)(10).ToString()

            If cant2 = 1 Then
                txtTel1.Text = dt.Rows(0)(11).ToString()
            ElseIf cant2 = 2 Then
                txtTel1.Text = dt.Rows(0)(11).ToString()
                txtTel2.Text = dt.Rows(1)(11).ToString()
            End If

        Else
            MessageBox.Show("No validado la cédula", "Registro UTP", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return dt
    End Function

    Private Function EliminarRegistro() As DataTable
        Dim mainconn = ConfigurationManager.ConnectionStrings("PF_Eq11_Matricula.My.MySettings.RegistroUTPConnectionString").ConnectionString
        sqlconn = New SqlConnection(mainconn)

        'Consulta para eliminar teléfonos
        Dim sqlquery As String = "DELETE FROM Telefono_est
                                WHERE cedula_est = @cedula_est"
        sqlcomm1 = New SqlCommand(sqlquery, sqlconn)
        sqlcomm1.Parameters.AddWithValue("@cedula_est", txtCedula.Text.Trim())

        sqlconn.Open()
        sqlcomm1.ExecuteNonQuery()

        'Consulta para eliminar datos de tabla Estudiante
        sqlquery = "DELETE FROM Estudiante 
                    WHERE est_cedula = @est_cedula"
        sqlcomm1 = New SqlCommand(sqlquery, sqlconn)
        sqlcomm1.Parameters.AddWithValue("@est_cedula", txtCedula.Text.Trim())

        sdr = New SqlDataAdapter(sqlcomm1)
        dt = New DataTable()
        sdr.Fill(dt)

        Return dt
    End Function
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("¿Seguro que desea cancelar? Se perderán los cambios no guardados", "Registro UTP", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            Me.Hide()
            txtNombre.Clear()
            txtCedula.Clear()
            txtApellido.Clear()
            txtCorreo.Clear()
            txtContraseña.Clear()
            txtNacionalidad.Clear()
            txtDireccion.Clear()
            txtTel1.Clear()
            txtTel2.Clear()
            txtFac.Clear()
            txtACurso.Clear()
            txtIndice.Clear()
            txtMatr.Clear()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtCedula.Text = "" Then
            MessageBox.Show("No validado la cédula", "Registro UTP", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf MessageBox.Show("¿Seguro que desea eliminar este registro? No lo podrá recuperar después", "UTP", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            If MessageBox.Show("Se ha eliminado el registro con éxito", "Registro UTP", MessageBoxButtons.OK, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
                Me.EliminarRegistro()
            End If
            txtNombre.Clear()
            txtCedula.Clear()
            txtApellido.Clear()
            txtCorreo.Clear()
            txtContraseña.Clear()
            txtNacionalidad.Clear()
            txtDireccion.Clear()
            txtTel1.Clear()
            txtTel2.Clear()
            txtFac.Clear()
            txtACurso.Clear()
            txtIndice.Clear()
            txtMatr.Clear()
        End If
    End Sub

    Private Sub frmAdminEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        If txtCedula.Text = "" Then
            MessageBox.Show("Debe ingresar una cédula para validar", "Registro UTP", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            frmAdminMatriculas.dgvAdminMatriculas.DataSource = Me.ValidarCedula
        End If
    End Sub
End Class