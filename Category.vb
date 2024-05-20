Imports System.Data.SqlClient
Imports ZalligatePOS.DatabaseConnection
Public Class Category
    Dim Con = New SqlConnection(DatabaseConnection.Con)

    Sub Total()

        Dim Sales As String = "SELECT COUNT(*) FROM category"

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
        Dim query = "SELECT * FROM category"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        CategoriesDGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        NewCatPopUp.AutoID()


        Dim frm As New NewCatPopUp
        frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
        TransaparentBG.ShowForm(frm)


    End Sub

    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Total()
        Display()


    End Sub

    Private Sub btnPOSForm_Click(sender As Object, e As EventArgs) Handles btnPOSForm.Click
        Dashboard.Show()
        Me.Hide()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim frm As New DeleteCatPopUp
        frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
        TransaparentBG.ShowForm(frm)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim frm As New UpdateCatPopUp
        frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
        TransaparentBG.ShowForm(frm)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Product.Show()
        Me.Hide()

    End Sub
End Class