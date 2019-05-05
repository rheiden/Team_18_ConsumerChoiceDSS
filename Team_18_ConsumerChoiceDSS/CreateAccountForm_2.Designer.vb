<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeam18NewUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTeam18NewUserTitle = New System.Windows.Forms.Label()
        Me.lblTeam18NewUsername = New System.Windows.Forms.Label()
        Me.lblTeam18NewPassword = New System.Windows.Forms.Label()
        Me.tblTeam18UserInfo = New System.Windows.Forms.TableLayoutPanel()
        Me.txtTeam18Email = New System.Windows.Forms.TextBox()
        Me.txtTeam18LName = New System.Windows.Forms.TextBox()
        Me.lblTeam18LName = New System.Windows.Forms.Label()
        Me.lblTeam18Email = New System.Windows.Forms.Label()
        Me.txtTeam18Fname = New System.Windows.Forms.TextBox()
        Me.txtTeam18Phone = New System.Windows.Forms.TextBox()
        Me.lblTeam18Phone = New System.Windows.Forms.Label()
        Me.lblTeam18FName = New System.Windows.Forms.Label()
        Me.txtTeam18NewUsername = New System.Windows.Forms.TextBox()
        Me.txtTeam18NewPass = New System.Windows.Forms.TextBox()
        Me.btnTeam18ExitNewUser = New System.Windows.Forms.Button()
        Me.btnTeam18CreateAccount = New System.Windows.Forms.Button()
        Me.btnTeam18GoBackNewUser = New System.Windows.Forms.Button()
        Me.txtTeam18Budget = New System.Windows.Forms.TextBox()
        Me.lblTeam18Budget = New System.Windows.Forms.Label()
        Me.tblTeam18UserInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTeam18NewUserTitle
        '
        Me.lblTeam18NewUserTitle.AutoSize = True
        Me.lblTeam18NewUserTitle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18NewUserTitle.Location = New System.Drawing.Point(101, 9)
        Me.lblTeam18NewUserTitle.Name = "lblTeam18NewUserTitle"
        Me.lblTeam18NewUserTitle.Size = New System.Drawing.Size(242, 19)
        Me.lblTeam18NewUserTitle.TabIndex = 0
        Me.lblTeam18NewUserTitle.Text = "Please Enter The Following Fields: "
        '
        'lblTeam18NewUsername
        '
        Me.lblTeam18NewUsername.AutoSize = True
        Me.lblTeam18NewUsername.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18NewUsername.Location = New System.Drawing.Point(163, 61)
        Me.lblTeam18NewUsername.Name = "lblTeam18NewUsername"
        Me.lblTeam18NewUsername.Size = New System.Drawing.Size(70, 15)
        Me.lblTeam18NewUsername.TabIndex = 1
        Me.lblTeam18NewUsername.Text = "Username: "
        '
        'lblTeam18NewPassword
        '
        Me.lblTeam18NewPassword.AutoSize = True
        Me.lblTeam18NewPassword.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18NewPassword.Location = New System.Drawing.Point(167, 87)
        Me.lblTeam18NewPassword.Name = "lblTeam18NewPassword"
        Me.lblTeam18NewPassword.Size = New System.Drawing.Size(66, 15)
        Me.lblTeam18NewPassword.TabIndex = 2
        Me.lblTeam18NewPassword.Text = "Password: "
        '
        'tblTeam18UserInfo
        '
        Me.tblTeam18UserInfo.ColumnCount = 2
        Me.tblTeam18UserInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTeam18UserInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTeam18UserInfo.Controls.Add(Me.txtTeam18Email, 1, 2)
        Me.tblTeam18UserInfo.Controls.Add(Me.txtTeam18LName, 1, 1)
        Me.tblTeam18UserInfo.Controls.Add(Me.lblTeam18LName, 0, 1)
        Me.tblTeam18UserInfo.Controls.Add(Me.lblTeam18Email, 0, 2)
        Me.tblTeam18UserInfo.Controls.Add(Me.txtTeam18Fname, 1, 0)
        Me.tblTeam18UserInfo.Controls.Add(Me.txtTeam18Phone, 1, 3)
        Me.tblTeam18UserInfo.Controls.Add(Me.lblTeam18Phone, 0, 3)
        Me.tblTeam18UserInfo.Controls.Add(Me.lblTeam18FName, 0, 0)
        Me.tblTeam18UserInfo.Location = New System.Drawing.Point(68, 148)
        Me.tblTeam18UserInfo.Name = "tblTeam18UserInfo"
        Me.tblTeam18UserInfo.RowCount = 4
        Me.tblTeam18UserInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblTeam18UserInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblTeam18UserInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblTeam18UserInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblTeam18UserInfo.Size = New System.Drawing.Size(345, 167)
        Me.tblTeam18UserInfo.TabIndex = 3
        '
        'txtTeam18Email
        '
        Me.txtTeam18Email.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtTeam18Email.Location = New System.Drawing.Point(175, 92)
        Me.txtTeam18Email.Name = "txtTeam18Email"
        Me.txtTeam18Email.Size = New System.Drawing.Size(148, 20)
        Me.txtTeam18Email.TabIndex = 4
        '
        'txtTeam18LName
        '
        Me.txtTeam18LName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtTeam18LName.Location = New System.Drawing.Point(175, 51)
        Me.txtTeam18LName.Name = "txtTeam18LName"
        Me.txtTeam18LName.Size = New System.Drawing.Size(125, 20)
        Me.txtTeam18LName.TabIndex = 3
        '
        'lblTeam18LName
        '
        Me.lblTeam18LName.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18LName.AutoSize = True
        Me.lblTeam18LName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18LName.Location = New System.Drawing.Point(97, 54)
        Me.lblTeam18LName.Name = "lblTeam18LName"
        Me.lblTeam18LName.Size = New System.Drawing.Size(72, 15)
        Me.lblTeam18LName.TabIndex = 5
        Me.lblTeam18LName.Text = "Last Name: "
        '
        'lblTeam18Email
        '
        Me.lblTeam18Email.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18Email.AutoSize = True
        Me.lblTeam18Email.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18Email.Location = New System.Drawing.Point(79, 95)
        Me.lblTeam18Email.Name = "lblTeam18Email"
        Me.lblTeam18Email.Size = New System.Drawing.Size(90, 15)
        Me.lblTeam18Email.TabIndex = 6
        Me.lblTeam18Email.Text = "Email Address: "
        '
        'txtTeam18Fname
        '
        Me.txtTeam18Fname.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtTeam18Fname.Location = New System.Drawing.Point(175, 10)
        Me.txtTeam18Fname.Name = "txtTeam18Fname"
        Me.txtTeam18Fname.Size = New System.Drawing.Size(113, 20)
        Me.txtTeam18Fname.TabIndex = 2
        '
        'txtTeam18Phone
        '
        Me.txtTeam18Phone.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtTeam18Phone.Location = New System.Drawing.Point(175, 135)
        Me.txtTeam18Phone.Name = "txtTeam18Phone"
        Me.txtTeam18Phone.Size = New System.Drawing.Size(148, 20)
        Me.txtTeam18Phone.TabIndex = 5
        '
        'lblTeam18Phone
        '
        Me.lblTeam18Phone.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18Phone.AutoSize = True
        Me.lblTeam18Phone.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18Phone.Location = New System.Drawing.Point(71, 137)
        Me.lblTeam18Phone.Name = "lblTeam18Phone"
        Me.lblTeam18Phone.Size = New System.Drawing.Size(98, 15)
        Me.lblTeam18Phone.TabIndex = 10
        Me.lblTeam18Phone.Text = "Phone Number: "
        '
        'lblTeam18FName
        '
        Me.lblTeam18FName.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18FName.AutoSize = True
        Me.lblTeam18FName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18FName.Location = New System.Drawing.Point(95, 13)
        Me.lblTeam18FName.Name = "lblTeam18FName"
        Me.lblTeam18FName.Size = New System.Drawing.Size(74, 15)
        Me.lblTeam18FName.TabIndex = 4
        Me.lblTeam18FName.Text = "First Name: "
        '
        'txtTeam18NewUsername
        '
        Me.txtTeam18NewUsername.Location = New System.Drawing.Point(243, 59)
        Me.txtTeam18NewUsername.Name = "txtTeam18NewUsername"
        Me.txtTeam18NewUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtTeam18NewUsername.TabIndex = 0
        '
        'txtTeam18NewPass
        '
        Me.txtTeam18NewPass.Location = New System.Drawing.Point(243, 85)
        Me.txtTeam18NewPass.Name = "txtTeam18NewPass"
        Me.txtTeam18NewPass.Size = New System.Drawing.Size(100, 20)
        Me.txtTeam18NewPass.TabIndex = 1
        '
        'btnTeam18ExitNewUser
        '
        Me.btnTeam18ExitNewUser.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeam18ExitNewUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTeam18ExitNewUser.Location = New System.Drawing.Point(12, 358)
        Me.btnTeam18ExitNewUser.Name = "btnTeam18ExitNewUser"
        Me.btnTeam18ExitNewUser.Size = New System.Drawing.Size(75, 34)
        Me.btnTeam18ExitNewUser.TabIndex = 6
        Me.btnTeam18ExitNewUser.Text = "Exit"
        Me.btnTeam18ExitNewUser.UseVisualStyleBackColor = True
        '
        'btnTeam18CreateAccount
        '
        Me.btnTeam18CreateAccount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeam18CreateAccount.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnTeam18CreateAccount.Location = New System.Drawing.Point(184, 358)
        Me.btnTeam18CreateAccount.Name = "btnTeam18CreateAccount"
        Me.btnTeam18CreateAccount.Size = New System.Drawing.Size(100, 34)
        Me.btnTeam18CreateAccount.TabIndex = 7
        Me.btnTeam18CreateAccount.Text = "Create Account"
        Me.btnTeam18CreateAccount.UseVisualStyleBackColor = True
        '
        'btnTeam18GoBackNewUser
        '
        Me.btnTeam18GoBackNewUser.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeam18GoBackNewUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTeam18GoBackNewUser.Location = New System.Drawing.Point(2, 2)
        Me.btnTeam18GoBackNewUser.Name = "btnTeam18GoBackNewUser"
        Me.btnTeam18GoBackNewUser.Size = New System.Drawing.Size(85, 34)
        Me.btnTeam18GoBackNewUser.TabIndex = 8
        Me.btnTeam18GoBackNewUser.Text = "<--- Go Back"
        Me.btnTeam18GoBackNewUser.UseVisualStyleBackColor = True
        '
        'txtTeam18Budget
        '
        Me.txtTeam18Budget.Location = New System.Drawing.Point(243, 111)
        Me.txtTeam18Budget.Name = "txtTeam18Budget"
        Me.txtTeam18Budget.Size = New System.Drawing.Size(100, 20)
        Me.txtTeam18Budget.TabIndex = 10
        '
        'lblTeam18Budget
        '
        Me.lblTeam18Budget.AutoSize = True
        Me.lblTeam18Budget.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18Budget.Location = New System.Drawing.Point(173, 113)
        Me.lblTeam18Budget.Name = "lblTeam18Budget"
        Me.lblTeam18Budget.Size = New System.Drawing.Size(60, 15)
        Me.lblTeam18Budget.TabIndex = 9
        Me.lblTeam18Budget.Text = "Budget: $"
        '
        'frmTeam18NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(495, 404)
        Me.Controls.Add(Me.txtTeam18Budget)
        Me.Controls.Add(Me.lblTeam18Budget)
        Me.Controls.Add(Me.btnTeam18GoBackNewUser)
        Me.Controls.Add(Me.btnTeam18CreateAccount)
        Me.Controls.Add(Me.btnTeam18ExitNewUser)
        Me.Controls.Add(Me.txtTeam18NewPass)
        Me.Controls.Add(Me.txtTeam18NewUsername)
        Me.Controls.Add(Me.tblTeam18UserInfo)
        Me.Controls.Add(Me.lblTeam18NewPassword)
        Me.Controls.Add(Me.lblTeam18NewUsername)
        Me.Controls.Add(Me.lblTeam18NewUserTitle)
        Me.Name = "frmTeam18NewUser"
        Me.Text = "Create Account"
        Me.tblTeam18UserInfo.ResumeLayout(False)
        Me.tblTeam18UserInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTeam18NewUserTitle As Label
    Friend WithEvents lblTeam18NewUsername As Label
    Friend WithEvents lblTeam18NewPassword As Label
    Friend WithEvents tblTeam18UserInfo As TableLayoutPanel
    Friend WithEvents txtTeam18Email As TextBox
    Friend WithEvents txtTeam18LName As TextBox
    Friend WithEvents lblTeam18FName As Label
    Friend WithEvents lblTeam18LName As Label
    Friend WithEvents lblTeam18Email As Label
    Friend WithEvents txtTeam18Fname As TextBox
    Friend WithEvents txtTeam18NewUsername As TextBox
    Friend WithEvents txtTeam18NewPass As TextBox
    Friend WithEvents txtTeam18Phone As TextBox
    Friend WithEvents lblTeam18Phone As Label
    Friend WithEvents btnTeam18ExitNewUser As Button
    Friend WithEvents btnTeam18CreateAccount As Button
    Friend WithEvents btnTeam18GoBackNewUser As Button
    Friend WithEvents txtTeam18Budget As TextBox
    Friend WithEvents lblTeam18Budget As Label
End Class
