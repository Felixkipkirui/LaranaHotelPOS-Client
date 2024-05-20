Imports System.Data.SqlClient
Imports ZalligatePOS.DatabaseConnection
Public Class CheckOut
    Dim Con = New SqlConnection(DatabaseConnection.Con)
    Dim WorkingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
    Dim YLocation As Integer = (WorkingArea.Height - Me.Height) / 3
    Private Sub OrderDetailsDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrderDetailsDGV.CellContentClick

    End Sub

    Private Sub txtTransactionNumber_TextChanged(sender As Object, e As EventArgs) Handles txtTransactionNumber.TextChanged
        Try
            Con.Open()
            Dim cmd As New SqlCommand
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter
            Dim query = "SELECT * FROM orders WHERE TransactionID LIKE '%" & txtTransactionNumber.Text & "%' "
            cmd.Connection = Con
            cmd.CommandText = query
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                'txtUnitPrice.Text = dt.Rows(0).Item("UnitPrice").ToString

            End If
            Con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Larana Hotel POS System ")

        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        DatePicker.Value = Date.Now

    End Sub

    Private Sub CheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatePicker.Value = Date.Now
        Timer2.Start()

        Try
            Con.Open()
            Dim query = "SELECT TOP 1 TransactionID FROM orders ORDER BY TransactionID DESC"
            Dim cmd As SqlCommand
            Dim rdr As SqlDataReader
            cmd = New SqlCommand(query, Con)
            rdr = cmd.ExecuteReader()
            Dim mydata As AutoCompleteStringCollection = New AutoCompleteStringCollection()
            While rdr.Read()
                mydata.Add(rdr.GetString(0))
            End While
            txtTransactionNumber.AutoCompleteCustomSource = mydata
            Con.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Larana Hotel POS System ")


        End Try
    End Sub

    Private Sub txtSubTotal_TextChanged(sender As Object, e As EventArgs) Handles txtSubTotal.TextChanged
        txtTotal.Text = Val(txtSubTotal.Text) + 0
    End Sub

    Private Sub txtRecieved_TextChanged(sender As Object, e As EventArgs) Handles txtRecieved.TextChanged
        txtBalance.Text = Val(txtRecieved.Text) - Val(txtTotal.Text)
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        If txtSubTotal.Text = "" Or txtTotal.Text = "" Or txtRecieved.Text = "" Or txtRecievedBy.Text = "" Then
            MessageBox.Show("Kindly Ensure The Necessary Input Fields Are Provided!!!! ", "Larana Hotel POS System")



        ElseIf Val(txtRecieved.Text) < Val(txtSubTotal.Text) Then
            MessageBox.Show("Insufficient Funds to service the Order", "The Larana POS System")

        Else
            Try
                Con.Open()

                Dim selectedDate As DateTime = DatePicker.Value
                Dim formattedDate As String = selectedDate.ToString("yyyy-MM-dd")

                Dim adapter As New SqlDataAdapter()
                Dim ds As New DataSet()
                Dim query = "INSERT INTO transactions (TransactionID, SubTotal, Total, Recieved, Balance, PaymentMode, Description, RecievedBy, Date) 
                             VALUES('" & txtTransactionNumber.Text & "', '" & txtSubTotal.Text & "', '" & txtTotal.Text & "', '" & txtRecieved.Text & "','" & txtBalance.Text & "',
                             '" & cmbMode.Text & "', '" & txtDescription.Text & "', '" & txtRecievedBy.Text & "', '" & formattedDate & "')"
                adapter.SelectCommand = New SqlCommand(query, Con)
                adapter.SelectCommand.ExecuteNonQuery()
                Con.Close()
                MessageBox.Show("Order " & txtTransactionNumber.Text & " Checked Out Successfully. You Can Create a New Order", "Larana Hotel POS System")
                txtSubTotal.Text = ""
                txtRecieved.Text = ""
                cmbMode.Text = ""
                txtDescription.Text = ""




            Catch ex As Exception
                MessageBox.Show(ex.Message, "Larana Hotel POS System")

            End Try
        End If



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Location.Y >= YLocation Then
            Timer1.Stop()
        Else
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 10)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If txtTransactionNumber.Text = "" Then

            MessageBox.Show("Kindly Provide TransactionID For Processing ", "Larana Hotel POS System ")
        Else
            Try
                Con.Open()
                Dim cmd As New SqlCommand
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter
                Dim query = "SELECT Product, UnitPrice, Quantity, Total, ServedBy FROM orders WHERE TransactionID LIKE '" & txtTransactionNumber.Text & "'"
                cmd.Connection = Con
                cmd.CommandText = query
                da.SelectCommand = cmd
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    txtServedBy.Text = dt.Rows(0).Item("ServedBy").ToString

                End If
                Dim builder = New SqlCommandBuilder(da)
                Dim ds As DataSet
                ds = New DataSet
                da.Fill(ds)
                OrderDetailsDGV.DataSource = ds.Tables(0)

                Con.Close()

                Dim Sum As Decimal = 0
                For i = 0 To OrderDetailsDGV.Rows.Count - 1
                    Sum += OrderDetailsDGV.Rows(i).Cells(3).Value
                Next

                txtSubTotal.Text = Sum


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Larana Hotel POS System ")
            End Try


        End If

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        CustomerRecieptForm.Show()
        Me.Hide()


    End Sub
End Class