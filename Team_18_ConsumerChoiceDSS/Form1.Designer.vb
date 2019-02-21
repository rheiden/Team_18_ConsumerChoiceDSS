<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRCHWelcome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRCHWelcome))
        Me.lblRCHWelcome = New System.Windows.Forms.Label()
        Me.lblRCHUsername = New System.Windows.Forms.Label()
        Me.txtRCHUsername = New System.Windows.Forms.TextBox()
        Me.lblRCHPassword = New System.Windows.Forms.Label()
        Me.txtRCHPassword = New System.Windows.Forms.TextBox()
        Me.btnRCHLogin = New System.Windows.Forms.Button()
        Me.btnRCHExitWelcome = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRCHCreateAccountWelcome = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRCHWelcome
        '
        Me.lblRCHWelcome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRCHWelcome.AutoSize = True
        Me.lblRCHWelcome.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCHWelcome.Location = New System.Drawing.Point(137, 11)
        Me.lblRCHWelcome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRCHWelcome.Name = "lblRCHWelcome"
        Me.lblRCHWelcome.Size = New System.Drawing.Size(94, 24)
        Me.lblRCHWelcome.TabIndex = 2
        Me.lblRCHWelcome.Text = "Welcome!"
        '
        'lblRCHUsername
        '
        Me.lblRCHUsername.AutoSize = True
        Me.lblRCHUsername.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCHUsername.Location = New System.Drawing.Point(41, 91)
        Me.lblRCHUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRCHUsername.Name = "lblRCHUsername"
        Me.lblRCHUsername.Size = New System.Drawing.Size(92, 21)
        Me.lblRCHUsername.TabIndex = 3
        Me.lblRCHUsername.Text = "Username: "
        '
        'txtRCHUsername
        '
        Me.txtRCHUsername.Location = New System.Drawing.Point(172, 90)
        Me.txtRCHUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRCHUsername.Name = "txtRCHUsername"
        Me.txtRCHUsername.Size = New System.Drawing.Size(143, 22)
        Me.txtRCHUsername.TabIndex = 0
        '
        'lblRCHPassword
        '
        Me.lblRCHPassword.AutoSize = True
        Me.lblRCHPassword.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCHPassword.Location = New System.Drawing.Point(51, 148)
        Me.lblRCHPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRCHPassword.Name = "lblRCHPassword"
        Me.lblRCHPassword.Size = New System.Drawing.Size(83, 21)
        Me.lblRCHPassword.TabIndex = 5
        Me.lblRCHPassword.Text = "Password:"
        '
        'txtRCHPassword
        '
        Me.txtRCHPassword.Location = New System.Drawing.Point(143, 145)
        Me.txtRCHPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRCHPassword.Name = "txtRCHPassword"
        Me.txtRCHPassword.Size = New System.Drawing.Size(143, 22)
        Me.txtRCHPassword.TabIndex = 1
        '
        'btnRCHLogin
        '
        Me.btnRCHLogin.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRCHLogin.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnRCHLogin.Location = New System.Drawing.Point(133, 193)
        Me.btnRCHLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRCHLogin.Name = "btnRCHLogin"
        Me.btnRCHLogin.Size = New System.Drawing.Size(100, 42)
        Me.btnRCHLogin.TabIndex = 7
        Me.btnRCHLogin.Text = "Login"
        Me.btnRCHLogin.UseVisualStyleBackColor = True
        '
        'btnRCHExitWelcome
        '
        Me.btnRCHExitWelcome.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRCHExitWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRCHExitWelcome.Location = New System.Drawing.Point(133, 255)
        Me.btnRCHExitWelcome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRCHExitWelcome.Name = "btnRCHExitWelcome"
        Me.btnRCHExitWelcome.Size = New System.Drawing.Size(100, 42)
        Me.btnRCHExitWelcome.TabIndex = 8
        Me.btnRCHExitWelcome.Text = "Exit"
        Me.btnRCHExitWelcome.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(89, 327)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 175)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Dont Have an Account?: "
        '
        'btnRCHCreateAccountWelcome
        '
        Me.btnRCHCreateAccountWelcome.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRCHCreateAccountWelcome.ForeColor = System.Drawing.Color.Red
        Me.btnRCHCreateAccountWelcome.Location = New System.Drawing.Point(181, 43)
        Me.btnRCHCreateAccountWelcome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRCHCreateAccountWelcome.Name = "btnRCHCreateAccountWelcome"
        Me.btnRCHCreateAccountWelcome.Size = New System.Drawing.Size(164, 30)
        Me.btnRCHCreateAccountWelcome.TabIndex = 12
        Me.btnRCHCreateAccountWelcome.Text = "Create New Account"
        Me.btnRCHCreateAccountWelcome.UseVisualStyleBackColor = True
        '
        'frmRCHWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(373, 496)
        Me.Controls.Add(Me.btnRCHCreateAccountWelcome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRCHExitWelcome)
        Me.Controls.Add(Me.btnRCHLogin)
        Me.Controls.Add(Me.txtRCHPassword)
        Me.Controls.Add(Me.lblRCHPassword)
        Me.Controls.Add(Me.txtRCHUsername)
        Me.Controls.Add(Me.lblRCHUsername)
        Me.Controls.Add(Me.lblRCHWelcome)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmRCHWelcome"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRCHWelcome As Label
    Friend WithEvents lblRCHUsername As Label
    Friend WithEvents txtRCHUsername As TextBox
    Friend WithEvents lblRCHPassword As Label
    Friend WithEvents txtRCHPassword As TextBox
    Friend WithEvents btnRCHLogin As Button
    Friend WithEvents btnRCHExitWelcome As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRCHCreateAccountWelcome As Button
End Class
