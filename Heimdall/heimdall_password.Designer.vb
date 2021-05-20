<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class heimdall_password
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Víðarr = New System.ComponentModel.BackgroundWorker()
        Me.elipse_heimdall = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.elipse_password = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.master_login = New Global.Heimdall.login()
        Me.SuspendLayout()
        '
        'elipse_heimdall
        '
        Me.elipse_heimdall.Radius = 5
        Me.elipse_heimdall.TargetControl = Me
        '
        'elipse_password
        '
        Me.elipse_password.Radius = 3
        Me.elipse_password.TargetControl = Me
        '
        'master_login
        '
        Me.master_login.Location = New System.Drawing.Point(0, 0)
        Me.master_login.Name = "master_login"
        Me.master_login.Size = New System.Drawing.Size(348, 215)
        Me.master_login.TabIndex = 0
        '
        'heimdall_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 215)
        Me.Controls.Add(Me.master_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "heimdall_password"
        Me.Text = "heimdall_password"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Víðarr As System.ComponentModel.BackgroundWorker
    Friend WithEvents elipse_heimdall As Guna.UI.WinForms.GunaElipse
    Friend WithEvents elipse_password As Guna.UI.WinForms.GunaElipse
    Friend WithEvents master_login As Global.Heimdall.login
End Class
