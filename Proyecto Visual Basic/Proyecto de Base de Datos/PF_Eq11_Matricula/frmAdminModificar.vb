Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmAdminModificar
    Private sqlconn As New SqlConnection
    Private sqlcomm1, sqlcomm2 As SqlCommand
    Private sdr As New SqlDataAdapter
    Private dt As New DataTable
    Public tel1Viejo As String
    Public tel2Viejo As String
    Private Function ValidarCedula() As DataTable
        Dim mainconn = ConfigurationManager.ConnectionStrings("PF_Eq11_Matricula.My.MySettings.RegistroUTPConnectionString").ConnectionString
        sqlconn = New SqlConnection(mainconn)

        'Verificar si existe la cédula o no
        Dim sqlquery1 As String = "SELECT COUNT(*) est_cedula FROM Estudiante
                                    WHERE est_cedula = @est_cedula"
        sqlcomm1 = New SqlCommand(sqlquery1, sqlconn)
        sqlcomm1.Parameters.AddWithValue("@est_cedula", txtCedula.Text.Trim())

        sqlconn.Open()
        Dim cant1 = Convert.ToInt32(sqlcomm1.ExecuteScalar())
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
            cboNacionalidad.Text = dt.Rows(0)(5).ToString()
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

            tel1Viejo = txtTel1.Text
            tel2Viejo = txtTel2.Text
        Else
            MessageBox.Show("No validado la cédula", "Registro UTP", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return dt
    End Function

    Private Function ModificarRegistro() As DataTable
        Dim mainconn = ConfigurationManager.ConnectionStrings("PF_Eq11_Matricula.My.MySettings.RegistroUTPConnectionString").ConnectionString
        sqlconn = New SqlConnection(mainconn)

        Dim sqlquery As String = "UPDATE Estudiante
                                    SET contraseña = @contraseña, direccion = @direccion, nacionalidad = @nacionalidad
                                    WHERE est_cedula = @est_cedula"
        sqlcomm1 = New SqlCommand(sqlquery, sqlconn)
        sqlcomm1.Parameters.AddWithValue("@est_cedula", txtCedula.Text.Trim())
        sqlcomm1.Parameters.AddWithValue("@contraseña", txtContraseña.Text.Trim())
        sqlcomm1.Parameters.AddWithValue("@direccion", txtDireccion.Text.Trim())
        sqlcomm1.Parameters.AddWithValue("@nacionalidad", cboNacionalidad.Text)

        sdr = New SqlDataAdapter(sqlcomm1)
        dt = New DataTable()
        sdr.Fill(dt)

        'Consulta para modificar números de teléfono
        Dim tel1Nuevo As String = txtTel1.Text.Trim()
        Dim tel2Nuevo As String = txtTel2.Text.Trim()

        sqlquery = "UPDATE Telefono_est
                    SET est_telefono = @est_telefonoNuevo
                    WHERE est_telefono = @est_telefonoViejo"
        sqlcomm1 = New SqlCommand(sqlquery, sqlconn)
        sqlcomm1.Parameters.AddWithValue("@est_telefonoNuevo", tel1Nuevo)
        sqlcomm1.Parameters.AddWithValue("@est_telefonoViejo", tel1Viejo)

        sqlconn.Open()
        sqlcomm1.ExecuteNonQuery()

        sqlcomm1 = New SqlCommand(sqlquery, sqlconn)
        sqlcomm1.Parameters.AddWithValue("@est_telefonoNuevo", tel2Nuevo)
        sqlcomm1.Parameters.AddWithValue("@est_telefonoViejo", tel2Viejo)

        sqlcomm1.ExecuteNonQuery()

        Return dt
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("¿Seguro que desea cancelar? Se perderán los cambios no guardados", "UTP", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            Me.Hide()

            txtApellido.ReadOnly = True
            txtNombre.ReadOnly = True
            txtTel1.ReadOnly = True
            txtTel2.ReadOnly = True
            txtDireccion.ReadOnly = True
            txtContraseña.ReadOnly = True

            txtApellido.Clear()
            txtNombre.Clear()
            txtTel1.Clear()
            txtTel2.Clear()
            txtDireccion.Clear()
            txtContraseña.Clear()
            txtCedula.Clear()

            btnActualizar.Enabled = False
        End If
    End Sub

    Private Sub frmAdminModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboNacionalidad.SelectedIndex = 0
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        If txtCedula.Text = "" Then
            MessageBox.Show("Debe ingresar una cédula para validar", "Registro UTP", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            txtApellido.ReadOnly = False
            txtNombre.ReadOnly = False
            txtTel1.ReadOnly = False
            txtTel2.ReadOnly = False
            txtDireccion.ReadOnly = False
            txtContraseña.ReadOnly = False
            btnActualizar.Enabled = True
            frmAdminMatriculas.dgvAdminMatriculas.DataSource = Me.ValidarCedula
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If (txtTel1.Text = txtTel2.Text) Then
            MessageBox.Show("No puede ingresar 2 números de teléfonos iguales", "Registro UTP", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Me.ModificarRegistro()
            MessageBox.Show("Los datos han sido actualizados", "Registro UTP", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtApellido.ReadOnly = True
            txtNombre.ReadOnly = True
            txtTel1.ReadOnly = True
            txtTel2.ReadOnly = True
            txtDireccion.ReadOnly = True
            txtContraseña.ReadOnly = True

            txtApellido.Clear()
            txtNombre.Clear()
            txtTel1.Clear()
            txtTel2.Clear()
            txtDireccion.Clear()
            txtContraseña.Clear()
            txtCedula.Clear()
            txtCorreo.Clear()

            btnActualizar.Enabled = False
        End If
    End Sub
End Class