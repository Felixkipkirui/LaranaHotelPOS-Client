Imports System.Data.SqlClient
Imports ZalligatePOS.DatabaseConnection
Public Class POS
    Dim Con = New SqlConnection(DatabaseConnection.Con)

    Sub AutoID()

        Dim cmd As New SqlCommand
        Dim adp As New SqlDataAdapter
        Dim dset As New DataSet()
        Try
            Con.Open()
            Dim query = "SELECT TOP 1 ID, TransactionID FROM orders ORDER BY ID DESC"
            cmd = New SqlCommand(query, Con)
            adp = New SqlDataAdapter(cmd)
            adp.Fill(dset)

            If (dset.Tables(0).Rows.Count > 0) Then
                Dim tmp_id = dset.Tables(0).Rows(0)("TransactionID").ToString().Substring(3, 9)
                Dim new_id As Integer = CInt(tmp_id) + 1
                lblTransactionID.Text = "INV" & new_id.ToString("000000000")

            Else
                lblTransactionID.Text = "INV000000001"

            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message, "Larana Hotel POS System")

        Finally

            Con.Close

        End Try

    End Sub

    Sub Staff()

        Dim query As String = "SELECT Name FROM staff"
        Dim command As New SqlCommand(query, Con)
        Con.Open()
        Dim reader As SqlDataReader = command.ExecuteReader()
        While reader.Read()
            Dim fullName As String = reader("Name").ToString()
            cmbServedBy.Items.Add(fullName)
        End While
        reader.Close()
        Con.Close()

    End Sub
    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        DatePicker.Value = Date.Now

        AutoID()

        Staff()
        Try
            Con.Open()
            Dim query = "SELECT ProdName FROM product"
            Dim cmd As SqlCommand
            Dim rdr As SqlDataReader
            cmd = New SqlCommand(query, Con)
            rdr = cmd.ExecuteReader()
            Dim mydata As AutoCompleteStringCollection = New AutoCompleteStringCollection()
            While rdr.Read()
                mydata.Add(rdr.GetString(0))
            End While
            txtProductName.AutoCompleteCustomSource = mydata

            Con.Close()
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Larana Hotel POS System ")

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DatePicker.Value = Date.Now
    End Sub

    Private Sub txtProductName_TextChanged(sender As Object, e As EventArgs) Handles txtProductName.TextChanged
        Try
            Con.Open()
            Dim cmd As New SqlCommand
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter
            Dim query = "SELECT ProdID, ProdName, ProdCategory, UnitPrice FROM product WHERE ProdName LIKE '%" & txtProductName.Text & "%'"
            cmd.Connection = Con
            cmd.CommandText = query
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                txtUnitPrice.Text = dt.Rows(0).Item("UnitPrice").ToString

            End If
            Dim builder = New SqlCommandBuilder(da)
            Dim ds As DataSet
            ds = New DataSet
            da.Fill(ds)
            ProductsDGV.DataSource = ds.Tables(0)

            Con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Larana Hotel POS System ")

        End Try
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        txtTotal.Text = Val(txtUnitPrice.Text) * Val(txtQuantity.Text)
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        If txtProductName.Text = "" Or txtQuantity.Text = "" Or txtUnitPrice.Text = "" Then

            MessageBox.Show("Missing Information", "Larana Hotel POS System")
        Else
            Dim newRow As DataGridViewRow = CartDGV.Rows(CartDGV.Rows.Add())

            newRow.Cells("Column1").Value = txtProductName.Text
            newRow.Cells("Column2").Value = txtUnitPrice.Text
            newRow.Cells("Column3").Value = txtQuantity.Text
            newRow.Cells("Column4").Value = txtTotal.Text

            Dim Sum As Decimal = 0
            For i = 0 To CartDGV.Rows.Count - 1
                Sum += CartDGV.Rows(i).Cells(3).Value
            Next

            txtSubTotal.Text = Sum
            txtQuantity.Text = ""



        End If
    End Sub

    Private Sub txtSubTotal_TextChanged(sender As Object, e As EventArgs) Handles txtSubTotal.TextChanged
        txtNetTotal.Text = Val(txtSubTotal.Text) + 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbServedBy.Text = "" Or txtSubTotal.Text = "" Then
            MessageBox.Show("Kindly Fill In All The Neccesary Fields ", "The Larana Hotel POS System")

        Else
            Try
                Con.Open()
                For Each row As DataGridViewRow In CartDGV.Rows
                    If Not row.IsNewRow Then
                        Dim value1 As String = lblTransactionID.Text
                        Dim value2 As String = row.Cells("Column1").Value.ToString()
                        Dim value3 As String = row.Cells("Column2").Value.ToString()
                        Dim value4 As String = row.Cells("Column3").Value.ToString()
                        Dim value5 As String = row.Cells("Column4").Value.ToString()

                        Dim selectedDate As DateTime = DatePicker.Value
                        Dim formattedDate As String = selectedDate.ToString("yyyy-MM-dd")



                        Dim query As String = "INSERT INTO orders(TransactionID, Product, UnitPrice, Quantity, Total, ServedBy, Date) VALUES(@value1, @value2, @value3, @value4, @value5, '" & cmbServedBy.Text & "', '" & formattedDate & "' )"
                        Using cmd As New SqlCommand(query, Con)
                            cmd.Parameters.AddWithValue("@value1", value1)
                            cmd.Parameters.AddWithValue("@value2", value2)
                            cmd.Parameters.AddWithValue("@value3", value3)
                            cmd.Parameters.AddWithValue("@value4", value4)
                            cmd.Parameters.AddWithValue("@value5", value5)

                            cmd.ExecuteNonQuery()
                        End Using
                    End If

                Next

                Con.Close()
                MessageBox.Show("Sale Saved Successfully You can Now Checkout The Order ", "The Larana Hotel POS System")
                AutoID()




                CartDGV.Rows.Clear()
                txtSubTotal.Text = ""
                txtTotal.Text = ""
                txtProductName.Text = ""
                txtNetTotal.Text = ""
                cmbServedBy.Text = ""

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        CartDGV.Rows.Clear()
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Dim frm As New CheckOut
        frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
        TransaparentBG.ShowForm(frm)
    End Sub
End Class