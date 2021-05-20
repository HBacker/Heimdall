
Public Class login
    Dim master_pass = My.Settings.master.ToString
    Private Sub auto_check_login_Tick(sender As Object, e As EventArgs) Handles auto_check_login.Tick
        If password.Text.Length = 10 Then
            If password.Text = master_pass Then
                MsgBox("Master KEY Doğrulandı!")
            Else
                MsgBox("Hatalı Master KEY!")
            End If
        Else

        End If
    End Sub
End Class
