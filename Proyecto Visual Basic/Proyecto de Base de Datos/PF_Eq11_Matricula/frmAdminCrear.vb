Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmAdminCrear
    Private sqlconn As New SqlConnection
    Private sqlcomm1, sqlcomm2 As SqlCommand
    Private sdr As New SqlDataAdapter
    Private dt As New DataTable
    Private Function CrearRegistro() As DataTable
        Dim mainconn = ConfigurationManager.ConnectionStrings("PF_Eq11_Matricula.My.MySettings.RegistroUTPConnectionString").ConnectionString
        sqlconn = New SqlConnection(mainconn)

        'Consulta 1
        Dim sqlquery1 As String = "SELECT COUNT(*) FROM Estudiante
                                    WHERE est_nombre = @est_nombre AND est_apellido = @est_apellido"
        sqlcomm1 = New SqlCommand(sqlquery1, sqlconn)
        sqlcomm1.Parameters.AddWithValue("@est_nombre", txtNombre.Text.Trim())
        sqlcomm1.Parameters.AddWithValue("@est_apellido", txtApellido.Text.Trim())

        'Consulta 2
        Dim sqlquery2 As String = "INSERT INTO Estudiante 
                                  VALUES (@est_cedula, @est_nombre, @est_apellido, @est_correo, @contraseña,  
                                  @nacionalidad, @direccion, @año_cursado, @indice, @matriculado, @facCodigo)"
        sqlcomm2 = New SqlCommand(sqlquery2, sqlconn)
        sqlcomm2.Parameters.AddWithValue("@est_cedula", txtCedula.Text.Trim())
        sqlcomm2.Parameters.AddWithValue("@est_nombre", txtNombre.Text.Trim())
        sqlcomm2.Parameters.AddWithValue("@est_apellido", txtApellido.Text.Trim())
        sqlcomm2.Parameters.AddWithValue("@contraseña", txtContraseña.Text.Trim())
        sqlcomm2.Parameters.AddWithValue("@nacionalidad", cboNacionalidad.Text)
        sqlcomm2.Parameters.AddWithValue("@direccion", txtDireccion.Text.Trim())
        sqlcomm2.Parameters.AddWithValue("@año_cursado", txtACurso.Text)
        sqlcomm2.Parameters.AddWithValue("@indice", txtIndice.Text)
        sqlcomm2.Parameters.AddWithValue("@matriculado", txtMatr.Text)
        sqlcomm2.Parameters.AddWithValue("@facCodigo", cboFac.Text)


        'Para generar correo institucional
        sqlconn.Open()
        Dim cant = Convert.ToInt32(sqlcomm1.ExecuteScalar())
        Dim correoMinus As String
        Dim lblCorreo = "@utp.ac.pa"
        If cant > 0 Then
            correoMinus = txtNombre.Text + "." + txtApellido.Text + cant.ToString
        Else
            correoMinus = txtNombre.Text + "." + txtApellido.Text
        End If
        txtCorreo.Text = correoMinus.ToLower() + lblCorreo

        sqlcomm2.Parameters.AddWithValue("@est_correo", txtCorreo.Text.Trim())

        sdr = New SqlDataAdapter(sqlcomm2)
        dt = New DataTable()
        sdr.Fill(dt)

        'Consultas para números de teléfono
        sqlquery1 = "INSERT INTO Telefono_est VALUES (@est_telefono, @cedula_est)"
        If txtTel1.Text <> "" Then
            sqlcomm1 = New SqlCommand(sqlquery1, sqlconn)
            sqlcomm1.Parameters.AddWithValue("@est_telefono", txtTel1.Text.Trim())
            sqlcomm1.Parameters.AddWithValue("@cedula_est", txtCedula.Text.Trim())

            sqlcomm1.ExecuteNonQuery()
        End If

        If txtTel2.Text <> "" Then
            sqlcomm1 = New SqlCommand(sqlquery1, sqlconn)
            sqlcomm1.Parameters.AddWithValue("@est_telefono", txtTel2.Text.Trim())
            sqlcomm1.Parameters.AddWithValue("@cedula_est", txtCedula.Text.Trim())

            sqlcomm1.ExecuteNonQuery()
        End If

        Return dt
    End Function

    Private Sub frmAdminCrear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboFac.SelectedIndex = 0
        cboNacionalidad.SelectedIndex = 0
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("¿Seguro que desea cancelar? Se perderán los cambios no guardados", "Registro UTP", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            Me.Hide()
            txtCedula.Text = ""
            txtNombre.Text = ""
            txtApellido.Text = ""
            txtContraseña.Text = ""
            cboNacionalidad.SelectedIndex = 0
            cboFac.SelectedIndex = 0
            txtDireccion.Text = ""
            txtTel1.Text = ""
            txtTel2.Text = ""
        End If
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        If (txtCedula.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or txtContraseña.Text = "" Or cboNacionalidad.SelectedIndex = 0 Or cboFac.SelectedIndex = 0) Then
            MsgBox("No ha llenado todos los campos", vbCritical)

        ElseIf (txtTel1.Text = txtTel2.Text) Then
            MessageBox.Show("No puede ingresar 2 números de teléfonos iguales", "Registro UTP", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            frmAdminMatriculas.dgvAdminMatriculas.DataSource = Me.CrearRegistro
            MessageBox.Show("Se ha creado el nuevo registro con éxito", "Registro UTP", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtCorreo.Text = ""
            txtCedula.Text = ""
            txtNombre.Text = ""
            txtApellido.Text = ""
            txtContraseña.Text = ""
            cboNacionalidad.SelectedIndex = 0
            cboFac.SelectedIndex = 0
            txtDireccion.Text = ""
            txtTel1.Text = ""
            txtTel2.Text = ""
        End If
    End Sub
End Class