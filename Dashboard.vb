Public Class Dashboard
    Private Sub btnPOSForm_Click(sender As Object, e As EventArgs) Handles btnPOSForm.Click
        Category.Show()
        Me.Hide()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Product.Show()
        Me.Hide()

    End Sub
End Class