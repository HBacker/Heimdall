<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.UserControl

    'UserControl, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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
        Me.FormSkin1 = New Global.Heimdall.FormSkin()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.Víðarr = New System.ComponentModel.BackgroundWorker()
        Me.elipse_heimdall = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.password = New Guna.UI.WinForms.GunaLineTextBox()
        Me.elipse_password = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.auto_check_login = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.GunaCirclePictureBox1)
        Me.FormSkin1.Controls.Add(Me.GunaLabel3)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(356, 52)
        Me.FormSkin1.TabIndex = 4
        Me.FormSkin1.Text = "FormSkin1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(195, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "password"
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCirclePictureBox1.Image = Global.Heimdall.My.Resources.Resources.icons8_eye_64
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(96, 9)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 1
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(137, 9)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(123, 35)
        Me.GunaLabel3.TabIndex = 2
        Me.GunaLabel3.Text = "Heimdall"
        '
        'elipse_heimdall
        '
        Me.elipse_heimdall.Radius = 5
        Me.elipse_heimdall.TargetControl = Me
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaElipsePanel1.Controls.Add(Me.password)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(-1, 49)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(369, 166)
        Me.GunaElipsePanel1.TabIndex = 5
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(118, 27)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(125, 35)
        Me.GunaLabel1.TabIndex = 4
        Me.GunaLabel1.Text = "Password"
        '
        'password
        '
        Me.password.Animated = True
        Me.password.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password.Font = New System.Drawing.Font("Bahnschrift Light", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password.LineColor = System.Drawing.Color.Indigo
        Me.password.Location = New System.Drawing.Point(21, 78)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.password.Size = New System.Drawing.Size(309, 56)
        Me.password.TabIndex = 0
        Me.password.Text = "12345678900"
        Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.password.UseSystemPasswordChar = True
        '
        'elipse_password
        '
        Me.elipse_password.Radius = 3
        Me.elipse_password.TargetControl = Me.password
        '
        'auto_check_login
        '
        Me.auto_check_login.Enabled = True
        Me.auto_check_login.Interval = 500
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FormSkin1)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Name = "login"
        Me.Size = New System.Drawing.Size(356, 215)
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As Global.Heimdall.FormSkin
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Víðarr As System.ComponentModel.BackgroundWorker
    Friend WithEvents elipse_heimdall As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents password As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents elipse_password As Guna.UI.WinForms.GunaElipse
    Friend WithEvents auto_check_login As Timer
End Class
