Imports System.Data.SqlClient
Imports ZalligatePOS.DatabaseConnection
Public Class Product
    Dim Con = New SqlConnection(DatabaseConnection.Con)
    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Total()
        Display()


    End Sub

    Sub Total()

        Dim Sales As String = "SELECT COUNT(*) FROM product"

        Con.Open()
        Using command As New SqlCommand(Sales, Con)
            Dim sum As Object = command.ExecuteScalar()
            If Not Convert.IsDBNull(sum) Then
                lblTotal.Text = sum.ToString()
            Else
                lblTotal.Text = "No Data"
            End If
        End Using
        Con.Close()

    End Sub

    Sub Display()
        Con.Open()
        Dim query = "SELECT * FROM product ORDER BY ID DESC"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ProductsDGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        Dim frm As New NewProdPopUp
        frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
        TransaparentBG.ShowForm(frm)


    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Category.Show()
        Me.Hide()

    End Sub

    Private Sub btnPOSForm_Click(sender As Object, e As EventArgs) Handles btnPOSForm.Click
        Dashboard.Show()
        Me.Hide()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim frm As New DeleteProdPopUp
        frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
        TransaparentBG.ShowForm(frm)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim frm As New UpdateProdPopUp
        frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
        TransaparentBG.ShowForm(frm)

    End Sub
End Class