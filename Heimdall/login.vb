
Public Class login
    Dim master_pass = My.Settings.master.ToString

    Private Sub auto_check_login_Tick(sender As Object, e As EventArgs) Handles auto_check_login.Tick
        If password.Text.Length = 10 Then
            If password.Text = master_pass Then
                password.Text = ""
                MsgBox("Master KEY Doğrulandı!")
            Else
                password.Text = ""
                MsgBox("Hatalı Master KEY!")





            End If
        Else

        End If

    End Sub

    Private Sub GunaLabel3_Click(sender As Object, e As EventArgs) Handles GunaLabel3.Click
        Try
            My.Settings.master = "0123456789"
            My.Settings.Save()
            MsgBox("OK")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class
