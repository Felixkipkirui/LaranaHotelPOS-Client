Imports System.Data.SqlClient
Imports ZalligatePOS.DatabaseConnection
Public Class UpdateProdPopUp
    Dim Con = New SqlConnection(DatabaseConnection.Con)
    Dim WorkingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
    Dim YLocation As Integer = (WorkingArea.Height - Me.Height) / 3
    Private Sub UpdateProdPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            txtProdName.AutoCompleteCustomSource = mydata
            Con.Close()
        Catch ex As Exception


            MessageBox.Show(ex.Message, "ZalliGate PLC Systems")


        End Try

        txtProdName.Text = ""
    End Sub

    Private Sub txtProdName_TextChanged(sender As Object, e As EventArgs) Handles txtProdName.TextChanged
        Try
            Con.Open()
            Dim cmd As New SqlCommand
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter
            Dim query = "SELECT * FROM product WHERE ProdName LIKE '%" & txtProdName.Text & "%'"
            cmd.Connection = Con
            cmd.CommandText = query
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then

                txtProdID.Text = dt.Rows(0).Item("ProdID").ToString
                txtUnitPrice.Text = dt.Rows(0).Item("UnitPrice").ToString
                txtProdDesc.Text = dt.Rows(0).Item("ProdDescription").ToString



            End If
            Con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ZalliGate PLC Systems")

        End Try
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtProdID.Text = "" Or txtProdName.Text = "" Or txtUnitPrice.Text = "" Or txtProdDesc.Text = "" Then
            MessageBox.Show("Kindly Ensure The Necessary Input Fields Are Provided!!!! ", "ZalliGate PLC Systems")

        Else
            Try
                Con.Open()
                Dim cmd As SqlCommand
                cmd = New SqlCommand("UPDATE product SET ProdID = '" & txtProdID.Text & "', ProdName = '" & txtProdName.Text & "',  UnitPrice = '" & txtUnitPrice.Text & "', ProdDescription = '" & txtProdDesc.Text & "' WHERE ProdID =  '" & txtProdID.Text & "' ", Con)
                cmd.ExecuteNonQuery()
                Con.Close()

                MessageBox.Show("Information Has Been Updated Successfully ", "ZalliGate PLC Systems")
                Product.Display()
                Product.Total()

                txtProdID.Text = ""
                txtProdName.Text = ""
                txtUnitPrice.Text = ""

                txtProdDesc.Text = ""

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub
End Class