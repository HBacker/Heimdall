<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bɪvrɒst
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.splash_text_bifröst = New Guna.UI.WinForms.GunaLabel()
        Me.splash_text_bifröst_mini = New System.Windows.Forms.Label()
        Me.splash_text_label_mini = New Guna.UI.WinForms.GunaLabel()
        Me.splash_text_heimdall = New Guna.UI.WinForms.GunaLabel()
        Me.Hǫfuð = New System.Windows.Forms.Timer(Me.components)
        Me.Víðarr = New System.ComponentModel.BackgroundWorker()
        Me.heimdall_eye = New System.Windows.Forms.PictureBox()
        Me.player = New System.Windows.Forms.Timer(Me.components)
        CType(Me.heimdall_eye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splash_text_bifröst
        '
        Me.splash_text_bifröst.AutoSize = True
        Me.splash_text_bifröst.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.splash_text_bifröst.Font = New System.Drawing.Font("Akrobat Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.splash_text_bifröst.ForeColor = System.Drawing.Color.White
        Me.splash_text_bifröst.Location = New System.Drawing.Point(19, 188)
        Me.splash_text_bifröst.Name = "splash_text_bifröst"
        Me.splash_text_bifröst.Size = New System.Drawing.Size(140, 58)
        Me.splash_text_bifröst.TabIndex = 1
        Me.splash_text_bifröst.Text = "Bifröst"
        '
        'splash_text_bifröst_mini
        '
        Me.splash_text_bifröst_mini.AutoSize = True
        Me.splash_text_bifröst_mini.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.splash_text_bifröst_mini.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.splash_text_bifröst_mini.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.splash_text_bifröst_mini.Location = New System.Drawing.Point(25, 242)
        Me.splash_text_bifröst_mini.Name = "splash_text_bifröst_mini"
        Me.splash_text_bifröst_mini.Size = New System.Drawing.Size(53, 20)
        Me.splash_text_bifröst_mini.TabIndex = 2
        Me.splash_text_bifröst_mini.Text = "bɪvrɒst"
        '
        'splash_text_label_mini
        '
        Me.splash_text_label_mini.AutoSize = True
        Me.splash_text_label_mini.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.splash_text_label_mini.Font = New System.Drawing.Font("Arimo", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.splash_text_label_mini.ForeColor = System.Drawing.Color.White
        Me.splash_text_label_mini.Location = New System.Drawing.Point(75, 246)
        Me.splash_text_label_mini.Name = "splash_text_label_mini"
        Me.splash_text_label_mini.Size = New System.Drawing.Size(79, 14)
        Me.splash_text_label_mini.TabIndex = 3
        Me.splash_text_label_mini.Text = "bridge opened."
        '
        'splash_text_heimdall
        '
        Me.splash_text_heimdall.AutoSize = True
        Me.splash_text_heimdall.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.splash_text_heimdall.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.splash_text_heimdall.ForeColor = System.Drawing.Color.White
        Me.splash_text_heimdall.Location = New System.Drawing.Point(25, 163)
        Me.splash_text_heimdall.Name = "splash_text_heimdall"
        Me.splash_text_heimdall.Size = New System.Drawing.Size(123, 35)
        Me.splash_text_heimdall.TabIndex = 1
        Me.splash_text_heimdall.Text = "Heimdall"
        '
        'Hǫfuð
        '
        Me.Hǫfuð.Enabled = True
        Me.Hǫfuð.Interval = 10000
        '
        'Víðarr
        '
        '
        'heimdall_eye
        '
        Me.heimdall_eye.Dock = System.Windows.Forms.DockStyle.Fill
        Me.heimdall_eye.Image = Global.Heimdall.My.Resources.Resources.eye
        Me.heimdall_eye.Location = New System.Drawing.Point(0, 0)
        Me.heimdall_eye.Name = "heimdall_eye"
        Me.heimdall_eye.Size = New System.Drawing.Size(610, 331)
        Me.heimdall_eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.heimdall_eye.TabIndex = 0
        Me.heimdall_eye.TabStop = False
        '
        'player
        '
        Me.player.Enabled = True
        Me.player.Interval = 1000
        '
        'bɪvrɒst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 331)
        Me.ControlBox = False
        Me.Controls.Add(Me.splash_text_label_mini)
        Me.Controls.Add(Me.splash_text_bifröst_mini)
        Me.Controls.Add(Me.splash_text_heimdall)
        Me.Controls.Add(Me.splash_text_bifröst)
        Me.Controls.Add(Me.heimdall_eye)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "bɪvrɒst"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.heimdall_eye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents heimdall_eye As PictureBox
    Friend WithEvents splash_text_bifröst As Guna.UI.WinForms.GunaLabel
    Friend WithEvents splash_text_bifröst_mini As Label
    Friend WithEvents splash_text_label_mini As Guna.UI.WinForms.GunaLabel
    Friend WithEvents splash_text_heimdall As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Hǫfuð As Timer
    Friend WithEvents Víðarr As System.ComponentModel.BackgroundWorker
    Friend WithEvents player As Timer
End Class
