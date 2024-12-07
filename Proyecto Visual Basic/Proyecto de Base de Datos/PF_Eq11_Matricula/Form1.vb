Public Class Form1

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Me.Hide()
        frmAdminIni.Show()
    End Sub

    Private Sub PresentacionDelCursoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentacionDelCursoToolStripMenuItem.Click
        Presentacion.Show()
    End Sub

    Private Sub PresentacionAplicacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentacionAplicacionToolStripMenuItem.Click
        PresentacionAplicacion.Show()
    End Sub

    Private Sub ContactenosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactenosToolStripMenuItem.Click
        frmContactenos.Show()
    End Sub
End Class
