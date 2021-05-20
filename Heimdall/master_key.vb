Public Class master_key
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If password.Text.Length = 10 Then
            My.Settings.master = password.Text
            My.Settings.Save()
            MsgBox("Master KEY Başarıyla güncellendi! yeni Master KEY: " + My.Settings.master.ToString)
        Else
            MsgBox("Catched!")
        End If

    End Sub
End Class