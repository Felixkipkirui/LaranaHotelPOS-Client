Imports System.Data.SqlClient
Imports ZalligatePOS.DatabaseConnection
Public Class CustomerRecieptForm
    Dim Con = New SqlConnection(DatabaseConnection.Con)

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim Con = New SqlConnection(DatabaseConnection.Con)
        Con.Open()
        Dim cmd As New SqlCommand("SELECT * FROM orders WHERE TransactionID='INV000000007' ", Con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        Con.Close()

        Dim report As New CustomerRecieptReport
        report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
    End Sub
End Class