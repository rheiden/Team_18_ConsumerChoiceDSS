<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRCHCarInfo
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
        Me.lblRCHTitleCarInfo = New System.Windows.Forms.Label()
        Me.lblRCHBudget = New System.Windows.Forms.Label()
        Me.lblRCHUsedNew = New System.Windows.Forms.Label()
        Me.lblRCHEngine = New System.Windows.Forms.Label()
        Me.lblRCHTransmission = New System.Windows.Forms.Label()
        Me.lblRCHFuel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtRCHFuelEfficiency = New System.Windows.Forms.TextBox()
        Me.cbxRCHModel = New System.Windows.Forms.ComboBox()
        Me.cbxRCHTransmission = New System.Windows.Forms.ComboBox()
        Me.cbxRCHEngine = New System.Windows.Forms.ComboBox()
        Me.lblRCHModel = New System.Windows.Forms.Label()
        Me.cbxRCHUsedNew = New System.Windows.Forms.ComboBox()
        Me.txtRCHBudget = New System.Windows.Forms.TextBox()
        Me.btnRCHGoBackCarInfo = New System.Windows.Forms.Button()
        Me.btnRCHConfirmInfo = New System.Windows.Forms.Button()
        Me.btnRCHExitCarInfo = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRCHTitleCarInfo
        '
        Me.lblRCHTitleCarInfo.AutoSize = True
        Me.lblRCHTitleCarInfo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCHTitleCarInfo.Location = New System.Drawing.Point(99, 9)
        Me.lblRCHTitleCarInfo.Name = "lblRCHTitleCarInfo"
        Me.lblRCHTitleCarInfo.Size = New System.Drawing.Size(283, 19)
        Me.lblRCHTitleCarInfo.TabIndex = 0
        Me.lblRCHTitleCarInfo.Text = "Please Enter the Following Information: "
        '
        'lblRCHBudget
        '
        Me.lblRCHBudget.AutoSize = True
        Me.lblRCHBudget.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCHBudget.Location = New System.Drawing.Point(191, 57)
        Me.lblRCHBudget.Name = "lblRCHBudget"
        Me.lblRCHBudget.Size = New System.Drawing.Size(60, 15)
        Me.lblRCHBudget.TabIndex = 1
        Me.lblRCHBudget.Text = "Budget: $"
        '
        'lblRCHUsedNew
        '
        Me.lblRCHUsedNew.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRCHUsedNew.AutoSize = True
        Me.lblRCHUsedNew.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCHUsedNew.Location = New System.Drawing.Point(97, 13)
        Me.lblRCHUsedNew.Name = "lblRCHUsedNew"
        Me.lblRCHUsedNew.Size = New System.Drawing.Size(73, 15)
        Me.lblRCHUsedNew.TabIndex = 2
        Me.lblRCHUsedNew.Text = "Used/New: "
        '
        'lblRCHEngine
        '
        Me.lblRCHEngine.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRCHEngine.AutoSize = True
        Me.lblRCHEngine.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCHEngine.Location = New System.Drawing.Point(120, 54)
        Me.lblRCHEngine.Name = "lblRCHEngine"
        Me.lblRCHEngine.Size = New System.Drawing.Size(50, 15)
        Me.lblRCHEngine.TabIndex = 3
        Me.lblRCHEngine.Text = "Engine: "
        '
        'lblRCHTransmission
        '
        Me.lblRCHTransmission.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRCHTransmission.AutoSize = True
        Me.lblRCHTransmission.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCHTransmission.Location = New System.Drawing.Point(87, 95)
        Me.lblRCHTransmission.Name = "lblRCHTransmission"
        Me.lblRCHTransmission.Size = New System.Drawing.Size(83, 15)
        Me.lblRCHTransmission.TabIndex = 4
        Me.lblRCHTransmission.Text = "Transmission: "
        '
        'lblRCHFuel
        '
        Me.lblRCHFuel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRCHFuel.AutoSize = True
        Me.lblRCHFuel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCHFuel.Location = New System.Drawing.Point(80, 136)
        Me.lblRCHFuel.Name = "lblRCHFuel"
        Me.lblRCHFuel.Size = New System.Drawing.Size(90, 15)
        Me.lblRCHFuel.TabIndex = 5
        Me.lblRCHFuel.Text = "Fuel Efficiency: "
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtRCHFuelEfficiency, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cbxRCHModel, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cbxRCHTransmission, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cbxRCHEngine, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRCHUsedNew, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRCHFuel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRCHEngine, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRCHTransmission, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRCHModel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cbxRCHUsedNew, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(74, 114)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(346, 207)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'txtRCHFuelEfficiency
        '
        Me.txtRCHFuelEfficiency.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtRCHFuelEfficiency.Location = New System.Drawing.Point(176, 133)
        Me.txtRCHFuelEfficiency.Name = "txtRCHFuelEfficiency"
        Me.txtRCHFuelEfficiency.Size = New System.Drawing.Size(121, 20)
        Me.txtRCHFuelEfficiency.TabIndex = 8
        '
        'cbxRCHModel
        '
        Me.cbxRCHModel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxRCHModel.FormattingEnabled = True
        Me.cbxRCHModel.Items.AddRange(New Object() {"Sedan", "SUV", "Sports", "Truck"})
        Me.cbxRCHModel.Location = New System.Drawing.Point(176, 175)
        Me.cbxRCHModel.Name = "cbxRCHModel"
        Me.cbxRCHModel.Size = New System.Drawing.Size(121, 21)
        Me.cbxRCHModel.TabIndex = 11
        '
        'cbxRCHTransmission
        '
        Me.cbxRCHTransmission.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxRCHTransmission.FormattingEnabled = True
        Me.cbxRCHTransmission.Items.AddRange(New Object() {"5-Speed", "6-Speed", "Automatic"})
        Me.cbxRCHTransmission.Location = New System.Drawing.Point(176, 92)
        Me.cbxRCHTransmission.Name = "cbxRCHTransmission"
        Me.cbxRCHTransmission.Size = New System.Drawing.Size(121, 21)
        Me.cbxRCHTransmission.TabIndex = 9
        '
        'cbxRCHEngine
        '
        Me.cbxRCHEngine.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxRCHEngine.FormattingEnabled = True
        Me.cbxRCHEngine.Items.AddRange(New Object() {"Gas", "Hybrid", "Electric"})
        Me.cbxRCHEngine.Location = New System.Drawing.Point(176, 51)
        Me.cbxRCHEngine.Name = "cbxRCHEngine"
        Me.cbxRCHEngine.Size = New System.Drawing.Size(121, 21)
        Me.cbxRCHEngine.TabIndex = 8
        '
        'lblRCHModel
        '
        Me.lblRCHModel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRCHModel.AutoSize = True
        Me.lblRCHModel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCHModel.Location = New System.Drawing.Point(100, 178)
        Me.lblRCHModel.Name = "lblRCHModel"
        Me.lblRCHModel.Size = New System.Drawing.Size(70, 15)
        Me.lblRCHModel.TabIndex = 6
        Me.lblRCHModel.Text = "Body Type: "
        '
        'cbxRCHUsedNew
        '
        Me.cbxRCHUsedNew.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxRCHUsedNew.FormattingEnabled = True
        Me.cbxRCHUsedNew.Items.AddRange(New Object() {"Used", "New"})
        Me.cbxRCHUsedNew.Location = New System.Drawing.Point(176, 10)
        Me.cbxRCHUsedNew.Name = "cbxRCHUsedNew"
        Me.cbxRCHUsedNew.Size = New System.Drawing.Size(121, 21)
        Me.cbxRCHUsedNew.TabIndex = 7
        '
        'txtRCHBudget
        '
        Me.txtRCHBudget.Location = New System.Drawing.Point(250, 55)
        Me.txtRCHBudget.Name = "txtRCHBudget"
        Me.txtRCHBudget.Size = New System.Drawing.Size(100, 20)
        Me.txtRCHBudget.TabIndex = 7
        '
        'btnRCHGoBackCarInfo
        '
        Me.btnRCHGoBackCarInfo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRCHGoBackCarInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRCHGoBackCarInfo.Location = New System.Drawing.Point(0, 2)
        Me.btnRCHGoBackCarInfo.Name = "btnRCHGoBackCarInfo"
        Me.btnRCHGoBackCarInfo.Size = New System.Drawing.Size(87, 34)
        Me.btnRCHGoBackCarInfo.TabIndex = 8
        Me.btnRCHGoBackCarInfo.Text = "<--- Go Back"
        Me.btnRCHGoBackCarInfo.UseVisualStyleBackColor = True
        '
        'btnRCHConfirmInfo
        '
        Me.btnRCHConfirmInfo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRCHConfirmInfo.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnRCHConfirmInfo.Location = New System.Drawing.Point(209, 348)
        Me.btnRCHConfirmInfo.Name = "btnRCHConfirmInfo"
        Me.btnRCHConfirmInfo.Size = New System.Drawing.Size(75, 34)
        Me.btnRCHConfirmInfo.TabIndex = 9
        Me.btnRCHConfirmInfo.Text = "Confirm"
        Me.btnRCHConfirmInfo.UseVisualStyleBackColor = True
        '
        'btnRCHExitCarInfo
        '
        Me.btnRCHExitCarInfo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRCHExitCarInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRCHExitCarInfo.Location = New System.Drawing.Point(12, 348)
        Me.btnRCHExitCarInfo.Name = "btnRCHExitCarInfo"
        Me.btnRCHExitCarInfo.Size = New System.Drawing.Size(75, 34)
        Me.btnRCHExitCarInfo.TabIndex = 10
        Me.btnRCHExitCarInfo.Text = "Exit"
        Me.btnRCHExitCarInfo.UseVisualStyleBackColor = True
        '
        'frmRCHCarInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(495, 394)
        Me.Controls.Add(Me.btnRCHExitCarInfo)
        Me.Controls.Add(Me.btnRCHConfirmInfo)
        Me.Controls.Add(Me.btnRCHGoBackCarInfo)
        Me.Controls.Add(Me.txtRCHBudget)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblRCHBudget)
        Me.Controls.Add(Me.lblRCHTitleCarInfo)
        Me.Name = "frmRCHCarInfo"
        Me.Text = "Car Information"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRCHTitleCarInfo As Label
    Friend WithEvents lblRCHBudget As Label
    Friend WithEvents lblRCHUsedNew As Label
    Friend WithEvents lblRCHEngine As Label
    Friend WithEvents lblRCHTransmission As Label
    Friend WithEvents lblRCHFuel As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblRCHModel As Label
    Friend WithEvents txtRCHBudget As TextBox
    Friend WithEvents cbxRCHEngine As ComboBox
    Friend WithEvents cbxRCHUsedNew As ComboBox
    Friend WithEvents cbxRCHTransmission As ComboBox
    Friend WithEvents txtRCHFuelEfficiency As TextBox
    Friend WithEvents cbxRCHModel As ComboBox
    Friend WithEvents btnRCHGoBackCarInfo As Button
    Friend WithEvents btnRCHConfirmInfo As Button
    Friend WithEvents btnRCHExitCarInfo As Button
End Class
