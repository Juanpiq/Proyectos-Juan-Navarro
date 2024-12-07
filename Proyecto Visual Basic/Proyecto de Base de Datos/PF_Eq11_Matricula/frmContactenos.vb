Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmContactenos
    Private sqlconn As New SqlConnection
    Private sqlcomm As SqlCommand
    Private sdr As New SqlDataAdapter
    Private dt As New DataTable

    Private Sub pctRegresar_Click(sender As Object, e As EventArgs) Handles pctRegresar.Click
        Me.Hide()
    End Sub

    Private Sub frmContactenos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FacultadTableAdapter.Fill(Me.RegistroUTPDataSet.Facultad)
    End Sub
End Class