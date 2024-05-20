Imports System.Data.SqlClient
Imports ZalligatePOS.DatabaseConnection
Public Class NewProdPopUp
    Dim Con = New SqlConnection(DatabaseConnection.Con)
    Dim WorkingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
    Dim YLocation As Integer = (WorkingArea.Height - Me.Height) / 3

    Sub AutoID()

        Dim cmd As New SqlCommand
        Dim adp As New SqlDataAdapter
        Dim dset As New DataSet()
        Try
            Con.Open()
            Dim query = "SELECT TOP 1 ID, ProdID FROM product ORDER BY ID DESC"
            cmd = New SqlCommand(query, Con)
            adp = New SqlDataAdapter(cmd)
            adp.Fill(dset)

            If (dset.Tables(0).Rows.Count > 0) Then
                Dim tmp_id = dset.Tables(0).Rows(0)("ProdID").ToString().Substring(5, 7)
                Dim new_id As Integer = CInt(tmp_id) + 1
                lblProdID.Text = "PROD-" & new_id.ToString("0000000")

            Else
                lblProdID.Text = "PROD-0000001"

            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message, "ZalliGate PLC Systems")

        Finally

            Con.Close

        End Try

    End Sub

    Private Sub NewProdPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Category()
        AutoID()



    End Sub

    Sub Category()

        Dim query As String = "SELECT CatName FROM category"
        Dim command As New SqlCommand(query, Con)
        Con.Open()
        Dim reader As SqlDataReader = command.ExecuteReader()
        While reader.Read()

            cmbCategory.Items.Add(reader("CatName").ToString())
        End While
        reader.Close()
        Con.Close()

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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtProdName.Text = "" Or cmbCategory.Text = "" Or txtUnitPrice.Text = "" Or txtProdDescription.Text = "" Then
            MessageBox.Show("KIndly Fill In All The Input Fields Provided", "ZalliGate PLC Systems")

        Else
            Try
                Con.Open()

                Dim query = "INSERT INTO product(ProdID, ProdName, ProdCategory, UnitPrice, ProdDescription) VALUES('" & lblProdID.Text & "','" & txtProdName.Text & "', '" & cmbCategory.Text & "', '" & txtUnitPrice.Text & "', '" & txtProdDescription.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                Con.Close()
                MessageBox.Show("Product Added To The Database Successfully ", "ZalliGate PLC Systems")

                txtProdName.Text = ""
                cmbCategory.Text = ""
                txtProdDescription.Text = ""
                txtUnitPrice.Text = ""


                AutoID()
                Product.Total()
                Product.Display()


            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub
End Class