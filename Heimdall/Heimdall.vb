Imports MySql.Data.MySqlClient
Imports System.Threading
Imports System.IO

Public Class Heimdall
    Dim cn As New MySqlConnection("server=193.164.7.250;userid=heimdall;password=Ryzen_8782$;database=heimdall;port=3306;SslMode=None;charset=utf8;")
    Dim db As New MySqlDataAdapter
    Dim rd As MySqlDataReader
    Dim cmd As New MySqlCommand
    Private Sub Heimdall_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
