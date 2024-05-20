Imports System.Data.SqlClient
Public Class CustomerInvoice
    Dim Con = New SqlConnection("Data Source=DESKTOP-N1QK2H5\SQLEXPRESS;Initial Catalog=LaranaHotel;Integrated Security=True")


    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Con.Open()
        Dim cmd As New SqlCommand("SELECT * FROM Sales WHERE TransactionID = '" & POS.lblTransactionID.Text & "' ", Con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        Con.Close()

        Dim report As New CustomerInvoiceReport
        report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()

        POS.AutoID()


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        POS.AutoID()


    End Sub

    Private Sub CustomerInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub
End Class