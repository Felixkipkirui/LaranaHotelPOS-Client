Imports System.Data.SqlClient
Imports ZalligatePOS.DatabaseConnection
Public Class Login
    Dim Con = New SqlConnection(DatabaseConnection.Con)

    Private Sub ClosePic_Click(sender As Object, e As EventArgs) Handles ClosePic.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show(" Confirm if you want to exit the system", "ZalliGate PLC Systems", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim cmd As SqlCommand
        Dim rdr As SqlDataReader

        If txtUsername.Text = "" Then
            MessageBox.Show("Kindly Enter Your Username ", "ZalliGate PLC Systems")
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Kindly Enter your Password ", "ZalliGate PLC Systems")
        Else
            Try
                Con.Open()
                cmd = New SqlCommand("SELECT * FROM systemadmin WHERE Username='" & txtUsername.Text & "' AND Password='" & txtPassword.Text & "' ", Con)
                rdr = cmd.ExecuteReader()
                If (rdr.Read()) Then
                    MessageBox.Show("Login Successful", "ZalliGate PLC Systems")

                    Dashboard.Show()



                    Me.Hide()



                Else
                    MessageBox.Show("Credential Mismatch!! Kindly Provide The Correct Credetials ", "ZalliGate PLC Systems")
                    txtPassword.Text = ""
                    txtUsername.Text = ""
                End If

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                Con.Close()

            End Try

        End If
    End Sub


End Class