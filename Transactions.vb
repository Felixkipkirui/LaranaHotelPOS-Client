Imports System.Data.SqlClient

Imports ZalligatePOS.DatabaseConnection
Public Class Transactions
    Dim Con = New SqlConnection(DatabaseConnection.Con)
    Private Sub Display()
        Con.Open()
        Dim query = "SELECT * FROM transactions ORDER BY ID DESC"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        TransactionsDGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        StartDatePicker.Value = Date.Now
        EndDatePicker.Value = Date.Now

    End Sub

    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
        StartDatePicker.Value = Date.Now
        EndDatePicker.Value = Date.Now
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim sselectedDate As DateTime = StartDatePicker.Value
        Dim sformattedDate As String = sselectedDate.ToString("yyyy-MM-dd")

        Dim eselectedDate As DateTime = EndDatePicker.Value
        Dim eformattedDate As String = eselectedDate.ToString("yyyy-MM-dd")

        Dim Sumquery As String = "SELECT SUM(Total) FROM transactions WHERE Date BETWEEN '" & sformattedDate & "' AND '" & eformattedDate & "' "
        Dim maxquery As String = "SELECT MAX(Total) FROM transactions WHERE Date BETWEEN '" & sformattedDate & "' AND '" & eformattedDate & "' "
        Dim minquery As String = "SELECT MIN(Total) FROM transactions WHERE Date BETWEEN '" & sformattedDate & "' AND '" & eformattedDate & "' "
        Dim avgquery As String = "SELECT AVG(Total) FROM transactions WHERE Date BETWEEN '" & sformattedDate & "' AND '" & eformattedDate & "' "



        Try
            Con.Open()
            Using command As New SqlCommand(Sumquery, Con)
                Dim sum As Object = command.ExecuteScalar()
                If Not Convert.IsDBNull(sum) Then
                    lblSum.Text = sum.ToString()
                Else
                    lblSum.Text = "No Data"
                End If
            End Using

            Using command As New SqlCommand(maxquery, Con)
                Dim max As Object = command.ExecuteScalar()
                If Not Convert.IsDBNull(max) Then
                    lblMax.Text = max.ToString()
                Else
                    lblMax.Text = "No Data"
                End If
            End Using

            Using command As New SqlCommand(minquery, Con)
                Dim min As Object = command.ExecuteScalar()
                If Not Convert.IsDBNull(min) Then
                    lblMin.Text = min.ToString()
                Else
                    lblMin.Text = "No Data"
                End If
            End Using

            Using command As New SqlCommand(avgquery, Con)
                Dim avg As Object = command.ExecuteScalar()
                If Not Convert.IsDBNull(avg) Then
                    lblAVG.Text = avg.ToString()
                Else
                    lblAVG.Text = "No Data"
                End If
            End Using

            Dim query = "SELECT * FROM Transactions WHERE Date BETWEEN '" & sformattedDate & "' AND '" & eformattedDate & "' "
            Dim adapter As SqlDataAdapter
            Dim cmd = New SqlCommand(query, Con)
            adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            TransactionsDGV.DataSource = ds.Tables(0)

            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
    End Sub
End Class