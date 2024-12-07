Public Class frmAdminIni
    Private usuario As String = "anna"
    Private clave As String = "1234"
    Private Sub pctVisible_Click(sender As Object, e As EventArgs) Handles pctVisible.Click
        txtContraseña.UseSystemPasswordChar = True
        pctVisible.Visible = False
        pctInvisible.Visible = True
    End Sub

    Private Sub pctInvisible_Click(sender As Object, e As EventArgs) Handles pctInvisible.Click
        txtContraseña.UseSystemPasswordChar = False
        pctInvisible.Visible = False
        pctVisible.Visible = True
    End Sub

    Private Sub btnSesion_Click(sender As Object, e As EventArgs) Handles btnSesion.Click
        If (txtCedula.Text = "" Or txtContraseña.Text = "") Then
            MsgBox("Ingrese la cédula y contraseña")
            txtCedula.Text = ""
            txtContraseña.Text = ""
        Else
            If txtCedula.Text = usuario And txtContraseña.Text = clave Then
                Me.Hide()
                frmAdminRegistro.Show()
            Else
                MessageBox.Show("Usuario y contraseña inválidas.", "Registro UTP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ContactenosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactenosToolStripMenuItem.Click
        frmContactenos.Show()
    End Sub

    Private Sub PresentacionDelCursoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentacionDelCursoToolStripMenuItem.Click
        Presentacion.Show()
    End Sub

    Private Sub PresentacionAplicacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentacionAplicacionToolStripMenuItem.Click
        PresentacionAplicacion.Show()
    End Sub

    Private Sub frmAdminIni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = TimeOfDay.ToString("T")
    End Sub
End Class