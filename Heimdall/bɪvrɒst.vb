Imports System.ComponentModel
Imports System.IO
Public NotInheritable Class bɪvrɒst
    Dim app_path As String
    Dim herald_path As String
    Dim herald_prefix As String = "herald:"
    Dim herald_message As String
    Private Sub bɪvrɒst_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim location As String = System.Environment.GetCommandLineArgs()(0)
        Dim appName As String = System.IO.Path.GetFileName(location)
        app_path = AppDomain.CurrentDomain.BaseDirectory + appName.ToString

        herald_path = "E:\HBR\Herald.lnk"

        Dim go_herald = New ProcessStartInfo(herald_path)
        herald_message = "Bu bir test mesajıdır."
        go_herald.Arguments = herald_prefix + herald_message
        Process.Start(go_herald).
    End Sub

    Private Sub Hǫfuð_Tick(sender As Object, e As EventArgs) Handles Hǫfuð.Tick
        Me.Hide()
        Heimdall.Show()
        Hǫfuð.Stop()
    End Sub

    Private Sub Víðarr_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Víðarr.DoWork

    End Sub

    Private Sub Víðarr_Disposed(sender As Object, e As EventArgs) Handles Víðarr.Disposed

    End Sub

    Private Sub bɪvrɒst_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Restart()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
