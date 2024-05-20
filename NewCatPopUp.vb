Imports System.Data.SqlClient
Imports ZalligatePOS.DatabaseConnection
Public Class NewCatPopUp
    Dim Con = New SqlConnection(DatabaseConnection.Con)
    Dim WorkingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
    Dim YLocation As Integer = (WorkingArea.Height - Me.Height) / 3

    Sub AutoID()

        Dim cmd As New SqlCommand
        Dim adp As New SqlDataAdapter
        Dim dset As New DataSet()
        Try
            Con.Open()
            Dim query = "SELECT TOP 1 ID, CatID FROM category ORDER BY ID DESC"
            cmd = New SqlCommand(query, Con)
            adp = New SqlDataAdapter(cmd)
            adp.Fill(dset)

            If (dset.Tables(0).Rows.Count > 0) Then
                Dim tmp_id = dset.Tables(0).Rows(0)("CatID").ToString().Substring(4, 5)
                Dim new_id As Integer = CInt(tmp_id) + 1
                lblCatID.Text = "CAT-" & new_id.ToString("00000")

            Else
                lblCatID.Text = "CAT-00001"

            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message, "ZalliGate PLC Systems")

        Finally

            Con.Close

        End Try

    End Sub



    Private Sub NewCatPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoID()
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

        If txtCatName.Text = "" Or txtCatDesc.Text = "" Then
            MessageBox.Show("KIndly Fill In All The Input Fields Provided", "ZalliGate PLC Systems")

        Else
            Try
                Con.Open()

                Dim query = "INSERT INTO category(CatID, CatName, CatDescription) VALUES('" & lblCatID.Text & "','" & txtCatName.Text & "', '" & txtCatDesc.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                Con.Close()
                MessageBox.Show("Category Added To The Database Successfully ", "ZalliGate PLC Systems")
                txtCatName.Text = ""
                txtCatDesc.Text = ""

                AutoID()
                Category.Total()
                Category.Display()





            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If

    End Sub
End Class