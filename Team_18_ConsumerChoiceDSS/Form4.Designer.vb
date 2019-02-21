<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRCHNewUser
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
        Me.lblRCHNewUserTitle = New System.Windows.Forms.Label()
        Me.lblRCHNewUsername = New System.Windows.Forms.Label()
        Me.lblRCHNewPassword = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtRCHEmail = New System.Windows.Forms.TextBox()
        Me.txtRCHLName = New System.Windows.Forms.TextBox()
        Me.lblRCHLName = New System.Windows.Forms.Label()
        Me.lblRCHEmail = New System.Windows.Forms.Label()
        Me.txtRCHFname = New System.Windows.Forms.TextBox()
        Me.txtRCHPhone = New System.Windows.Forms.TextBox()
        Me.lblRCHPhone = New System.Windows.Forms.Label()
        Me.lblRCHFName = New System.Windows.Forms.Label()
        Me.txtRCHNewUsername = New System.Windows.Forms.TextBox()
        Me.txtRCHNewPass = New System.Windows.Forms.TextBox()
        Me.btnRCHExitNewUser = New System.Windows.Forms.Button()
        Me.btnRCHCreateAccount = New System.Windows.Forms.Button()
        Me.btnRCHGoBackNewUser = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRCHNewUserTitle
        '
        Me.lblRCHNewUserTitle.AutoSize = True
        Me.lblRCHNewUserTitle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCHNewUserTitle.Location = New System.Drawing.Point(101, 9)
        Me.lblRCHNewUserTitle.Name = "lblRCHNewUserTitle"
        Me.lblRCHNewUserTitle.Size = New System.Drawing.Size(242, 19)
        Me.lblRCHNewUserTitle.TabIndex = 0
        Me.lblRCHNewUserTitle.Text = "Please Enter The Following Fields: "
        '
        'lblRCHNewUsername
        '
        Me.lblRCHNewUsername.AutoSize = True
        Me.lblRCHNewUsername.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCHNewUsername.Location = New System.Drawing.Point(163, 61)
        Me.lblRCHNewUsername.Name = "lblRCHNewUsername"
        Me.lblRCHNewUsername.Size = New System.Drawing.Size(70, 15)
        Me.lblRCHNewUsername.TabIndex = 1
        Me.lblRCHNewUsername.Text = "Username: "
        '
        'lblRCHNewPassword
        '
        Me.lblRCHNewPassword.AutoSize = True
        Me.lblRCHNewPassword.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCHNewPassword.Location = New System.Drawing.Point(167, 104)
        Me.lblRCHNewPassword.Name = "lblRCHNewPassword"
        Me.lblRCHNewPassword.Size = New System.Drawing.Size(66, 15)
        Me.lblRCHNewPassword.TabIndex = 2
        Me.lblRCHNewPassword.Text = "Password: "
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtRCHEmail, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtRCHLName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRCHLName, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRCHEmail, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtRCHFname, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtRCHPhone, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRCHPhone, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRCHFName, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(68, 148)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(345, 167)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'txtRCHEmail
        '
        Me.txtRCHEmail.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtRCHEmail.Location = New System.Drawing.Point(175, 92)
        Me.txtRCHEmail.Name = "txtRCHEmail"
        Me.txtRCHEmail.Size = New System.Drawing.Size(148, 20)
        Me.txtRCHEmail.TabIndex = 4
        '
        'txtRCHLName
        '
        Me.txtRCHLName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtRCHLName.Location = New System.Drawing.Point(175, 51)
        Me.txtRCHLName.Name = "txtRCHLName"
        Me.txtRCHLName.Size = New System.Drawing.Size(125, 20)
        Me.txtRCHLName.TabIndex = 3
        '
        'lblRCHLName
        '
        Me.lblRCHLName.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRCHLName.AutoSize = True
        Me.lblRCHLName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCHLName.Location = New System.Drawing.Point(97, 54)
        Me.lblRCHLName.Name = "lblRCHLName"
        Me.lblRCHLName.Size = New System.Drawing.Size(72, 15)
        Me.lblRCHLName.TabIndex = 5
        Me.lblRCHLName.Text = "Last Name: "
        '
        'lblRCHEmail
        '
        Me.lblRCHEmail.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRCHEmail.AutoSize = True
        Me.lblRCHEmail.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCHEmail.Location = New System.Drawing.Point(79, 95)
        Me.lblRCHEmail.Name = "lblRCHEmail"
        Me.lblRCHEmail.Size = New System.Drawing.Size(90, 15)
        Me.lblRCHEmail.TabIndex = 6
        Me.lblRCHEmail.Text = "Email Address: "
        '
        'txtRCHFname
        '
        Me.txtRCHFname.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtRCHFname.Location = New System.Drawing.Point(175, 10)
        Me.txtRCHFname.Name = "txtRCHFname"
        Me.txtRCHFname.Size = New System.Drawing.Size(113, 20)
        Me.txtRCHFname.TabIndex = 2
        '
        'txtRCHPhone
        '
        Me.txtRCHPhone.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtRCHPhone.Location = New System.Drawing.Point(175, 135)
        Me.txtRCHPhone.Name = "txtRCHPhone"
        Me.txtRCHPhone.Size = New System.Drawing.Size(148, 20)
        Me.txtRCHPhone.TabIndex = 5
        '
        'lblRCHPhone
        '
        Me.lblRCHPhone.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRCHPhone.AutoSize = True
        Me.lblRCHPhone.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCHPhone.Location = New System.Drawing.Point(71, 137)
        Me.lblRCHPhone.Name = "lblRCHPhone"
        Me.lblRCHPhone.Size = New System.Drawing.Size(98, 15)
        Me.lblRCHPhone.TabIndex = 10
        Me.lblRCHPhone.Text = "Phone Number: "
        '
        'lblRCHFName
        '
        Me.lblRCHFName.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRCHFName.AutoSize = True
        Me.lblRCHFName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCHFName.Location = New System.Drawing.Point(95, 13)
        Me.lblRCHFName.Name = "lblRCHFName"
        Me.lblRCHFName.Size = New System.Drawing.Size(74, 15)
        Me.lblRCHFName.TabIndex = 4
        Me.lblRCHFName.Text = "First Name: "
        '
        'txtRCHNewUsername
        '
        Me.txtRCHNewUsername.Location = New System.Drawing.Point(243, 59)
        Me.txtRCHNewUsername.Name = "txtRCHNewUsername"
        Me.txtRCHNewUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtRCHNewUsername.TabIndex = 0
        '
        'txtRCHNewPass
        '
        Me.txtRCHNewPass.Location = New System.Drawing.Point(243, 102)
        Me.txtRCHNewPass.Name = "txtRCHNewPass"
        Me.txtRCHNewPass.Size = New System.Drawing.Size(100, 20)
        Me.txtRCHNewPass.TabIndex = 1
        '
        'btnRCHExitNewUser
        '
        Me.btnRCHExitNewUser.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRCHExitNewUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRCHExitNewUser.Location = New System.Drawing.Point(12, 358)
        Me.btnRCHExitNewUser.Name = "btnRCHExitNewUser"
        Me.btnRCHExitNewUser.Size = New System.Drawing.Size(75, 34)
        Me.btnRCHExitNewUser.TabIndex = 6
        Me.btnRCHExitNewUser.Text = "Exit"
        Me.btnRCHExitNewUser.UseVisualStyleBackColor = True
        '
        'btnRCHCreateAccount
        '
        Me.btnRCHCreateAccount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRCHCreateAccount.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnRCHCreateAccount.Location = New System.Drawing.Point(184, 358)
        Me.btnRCHCreateAccount.Name = "btnRCHCreateAccount"
        Me.btnRCHCreateAccount.Size = New System.Drawing.Size(100, 34)
        Me.btnRCHCreateAccount.TabIndex = 7
        Me.btnRCHCreateAccount.Text = "Create Account"
        Me.btnRCHCreateAccount.UseVisualStyleBackColor = True
        '
        'btnRCHGoBackNewUser
        '
        Me.btnRCHGoBackNewUser.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRCHGoBackNewUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRCHGoBackNewUser.Location = New System.Drawing.Point(2, 2)
        Me.btnRCHGoBackNewUser.Name = "btnRCHGoBackNewUser"
        Me.btnRCHGoBackNewUser.Size = New System.Drawing.Size(85, 34)
        Me.btnRCHGoBackNewUser.TabIndex = 8
        Me.btnRCHGoBackNewUser.Text = "<--- Go Back"
        Me.btnRCHGoBackNewUser.UseVisualStyleBackColor = True
        '
        'frmRCHNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(495, 404)
        Me.Controls.Add(Me.btnRCHGoBackNewUser)
        Me.Controls.Add(Me.btnRCHCreateAccount)
        Me.Controls.Add(Me.btnRCHExitNewUser)
        Me.Controls.Add(Me.txtRCHNewPass)
        Me.Controls.Add(Me.txtRCHNewUsername)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblRCHNewPassword)
        Me.Controls.Add(Me.lblRCHNewUsername)
        Me.Controls.Add(Me.lblRCHNewUserTitle)
        Me.Name = "frmRCHNewUser"
        Me.Text = "Create Account"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRCHNewUserTitle As Label
    Friend WithEvents lblRCHNewUsername As Label
    Friend WithEvents lblRCHNewPassword As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtRCHEmail As TextBox
    Friend WithEvents txtRCHLName As TextBox
    Friend WithEvents lblRCHFName As Label
    Friend WithEvents lblRCHLName As Label
    Friend WithEvents lblRCHEmail As Label
    Friend WithEvents txtRCHFname As TextBox
    Friend WithEvents txtRCHNewUsername As TextBox
    Friend WithEvents txtRCHNewPass As TextBox
    Friend WithEvents txtRCHPhone As TextBox
    Friend WithEvents lblRCHPhone As Label
    Friend WithEvents btnRCHExitNewUser As Button
    Friend WithEvents btnRCHCreateAccount As Button
    Friend WithEvents btnRCHGoBackNewUser As Button
End Class
