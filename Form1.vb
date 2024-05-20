Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Pbar.Value = Pbar.Value + 1
        If Pbar.Value >= 50 Then
            Timer1.Stop()
            Login.Show()
            Me.Hide()

        End If
    End Sub

End Class
