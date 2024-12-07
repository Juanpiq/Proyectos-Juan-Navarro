Public Class Presentacion
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
    End Sub

    Private Sub Presentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblPC.Text = Environ("COMPUTERNAME")
        LblUsuario.Text = Environ("USERNAME")
    End Sub
End Class