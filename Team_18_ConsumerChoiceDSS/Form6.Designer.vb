<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRCHResults
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
        Me.gbxRCHCar = New System.Windows.Forms.GroupBox()
        Me.tblRCHCarInfo = New System.Windows.Forms.TableLayoutPanel()
        Me.rbxRCHModel = New System.Windows.Forms.RichTextBox()
        Me.lblRCHModel = New System.Windows.Forms.Label()
        Me.lblRCHMake = New System.Windows.Forms.Label()
        Me.rbxRCHMake = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lblRCHCost = New System.Windows.Forms.Label()
        Me.grpRCHSpecs = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.rtxRCHBodyType = New System.Windows.Forms.RichTextBox()
        Me.rtxRCHFuelEfficiency = New System.Windows.Forms.RichTextBox()
        Me.rtxRCHEngine = New System.Windows.Forms.RichTextBox()
        Me.rtxRCHTransmission = New System.Windows.Forms.RichTextBox()
        Me.rtxRCHCarType = New System.Windows.Forms.RichTextBox()
        Me.lblRCHBodyType = New System.Windows.Forms.Label()
        Me.lblRCHCarType = New System.Windows.Forms.Label()
        Me.lblRCHTransmission = New System.Windows.Forms.Label()
        Me.lblRCHFuelEfficiency = New System.Windows.Forms.Label()
        Me.lblRCHEngine = New System.Windows.Forms.Label()
        Me.btnRCHGoBackResults = New System.Windows.Forms.Button()
        Me.btnRCHAccept = New System.Windows.Forms.Button()
        Me.gbxRCHCar.SuspendLayout()
        Me.tblRCHCarInfo.SuspendLayout()
        Me.grpRCHSpecs.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxRCHCar
        '
        Me.gbxRCHCar.Controls.Add(Me.tblRCHCarInfo)
        Me.gbxRCHCar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxRCHCar.Location = New System.Drawing.Point(22, 45)
        Me.gbxRCHCar.Name = "gbxRCHCar"
        Me.gbxRCHCar.Size = New System.Drawing.Size(301, 130)
        Me.gbxRCHCar.TabIndex = 0
        Me.gbxRCHCar.TabStop = False
        Me.gbxRCHCar.Text = "Car Information"
        '
        'tblRCHCarInfo
        '
        Me.tblRCHCarInfo.ColumnCount = 2
        Me.tblRCHCarInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblRCHCarInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblRCHCarInfo.Controls.Add(Me.rbxRCHModel, 1, 1)
        Me.tblRCHCarInfo.Controls.Add(Me.lblRCHModel, 0, 1)
        Me.tblRCHCarInfo.Controls.Add(Me.lblRCHMake, 0, 0)
        Me.tblRCHCarInfo.Controls.Add(Me.rbxRCHMake, 1, 0)
        Me.tblRCHCarInfo.Controls.Add(Me.RichTextBox1, 1, 2)
        Me.tblRCHCarInfo.Controls.Add(Me.lblRCHCost, 0, 2)
        Me.tblRCHCarInfo.Location = New System.Drawing.Point(16, 17)
        Me.tblRCHCarInfo.Name = "tblRCHCarInfo"
        Me.tblRCHCarInfo.RowCount = 3
        Me.tblRCHCarInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblRCHCarInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblRCHCarInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblRCHCarInfo.Size = New System.Drawing.Size(271, 97)
        Me.tblRCHCarInfo.TabIndex = 0
        '
        'rbxRCHModel
        '
        Me.rbxRCHModel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbxRCHModel.Location = New System.Drawing.Point(138, 37)
        Me.rbxRCHModel.Name = "rbxRCHModel"
        Me.rbxRCHModel.Size = New System.Drawing.Size(130, 21)
        Me.rbxRCHModel.TabIndex = 3
        Me.rbxRCHModel.Text = ""
        '
        'lblRCHModel
        '
        Me.lblRCHModel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRCHModel.AutoSize = True
        Me.lblRCHModel.Location = New System.Drawing.Point(83, 40)
        Me.lblRCHModel.Name = "lblRCHModel"
        Me.lblRCHModel.Size = New System.Drawing.Size(49, 15)
        Me.lblRCHModel.TabIndex = 1
        Me.lblRCHModel.Text = "Model: "
        '
        'lblRCHMake
        '
        Me.lblRCHMake.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRCHMake.AutoSize = True
        Me.lblRCHMake.Location = New System.Drawing.Point(88, 8)
        Me.lblRCHMake.Name = "lblRCHMake"
        Me.lblRCHMake.Size = New System.Drawing.Size(44, 15)
        Me.lblRCHMake.TabIndex = 0
        Me.lblRCHMake.Text = "Make: "
        '
        'rbxRCHMake
        '
        Me.rbxRCHMake.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbxRCHMake.Location = New System.Drawing.Point(138, 5)
        Me.rbxRCHMake.Name = "rbxRCHMake"
        Me.rbxRCHMake.Size = New System.Drawing.Size(130, 21)
        Me.rbxRCHMake.TabIndex = 2
        Me.rbxRCHMake.Text = ""
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RichTextBox1.Location = New System.Drawing.Point(138, 70)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(130, 21)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'lblRCHCost
        '
        Me.lblRCHCost.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRCHCost.AutoSize = True
        Me.lblRCHCost.Location = New System.Drawing.Point(97, 73)
        Me.lblRCHCost.Name = "lblRCHCost"
        Me.lblRCHCost.Size = New System.Drawing.Size(35, 15)
        Me.lblRCHCost.TabIndex = 4
        Me.lblRCHCost.Text = "Cost:"
        '
        'grpRCHSpecs
        '
        Me.grpRCHSpecs.Controls.Add(Me.TableLayoutPanel1)
        Me.grpRCHSpecs.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRCHSpecs.Location = New System.Drawing.Point(22, 181)
        Me.grpRCHSpecs.Name = "grpRCHSpecs"
        Me.grpRCHSpecs.Size = New System.Drawing.Size(287, 201)
        Me.grpRCHSpecs.TabIndex = 1
        Me.grpRCHSpecs.TabStop = False
        Me.grpRCHSpecs.Text = "Car Specs"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.rtxRCHBodyType, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.rtxRCHFuelEfficiency, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.rtxRCHEngine, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.rtxRCHTransmission, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.rtxRCHCarType, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRCHBodyType, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRCHCarType, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRCHTransmission, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRCHFuelEfficiency, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRCHEngine, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(16, 22)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(256, 173)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'rtxRCHBodyType
        '
        Me.rtxRCHBodyType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rtxRCHBodyType.Location = New System.Drawing.Point(131, 144)
        Me.rtxRCHBodyType.Name = "rtxRCHBodyType"
        Me.rtxRCHBodyType.Size = New System.Drawing.Size(117, 20)
        Me.rtxRCHBodyType.TabIndex = 12
        Me.rtxRCHBodyType.Text = ""
        '
        'rtxRCHFuelEfficiency
        '
        Me.rtxRCHFuelEfficiency.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rtxRCHFuelEfficiency.Location = New System.Drawing.Point(131, 109)
        Me.rtxRCHFuelEfficiency.Name = "rtxRCHFuelEfficiency"
        Me.rtxRCHFuelEfficiency.Size = New System.Drawing.Size(117, 20)
        Me.rtxRCHFuelEfficiency.TabIndex = 11
        Me.rtxRCHFuelEfficiency.Text = ""
        '
        'rtxRCHEngine
        '
        Me.rtxRCHEngine.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rtxRCHEngine.Location = New System.Drawing.Point(131, 75)
        Me.rtxRCHEngine.Name = "rtxRCHEngine"
        Me.rtxRCHEngine.Size = New System.Drawing.Size(117, 20)
        Me.rtxRCHEngine.TabIndex = 10
        Me.rtxRCHEngine.Text = ""
        '
        'rtxRCHTransmission
        '
        Me.rtxRCHTransmission.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rtxRCHTransmission.Location = New System.Drawing.Point(131, 41)
        Me.rtxRCHTransmission.Name = "rtxRCHTransmission"
        Me.rtxRCHTransmission.Size = New System.Drawing.Size(117, 20)
        Me.rtxRCHTransmission.TabIndex = 9
        Me.rtxRCHTransmission.Text = ""
        '
        'rtxRCHCarType
        '
        Me.rtxRCHCarType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rtxRCHCarType.Location = New System.Drawing.Point(131, 6)
        Me.rtxRCHCarType.Name = "rtxRCHCarType"
        Me.rtxRCHCarType.Size = New System.Drawing.Size(117, 21)
        Me.rtxRCHCarType.TabIndex = 4
        Me.rtxRCHCarType.Text = ""
        '
        'lblRCHBodyType
        '
        Me.lblRCHBodyType.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRCHBodyType.AutoSize = True
        Me.lblRCHBodyType.Location = New System.Drawing.Point(55, 147)
        Me.lblRCHBodyType.Name = "lblRCHBodyType"
        Me.lblRCHBodyType.Size = New System.Drawing.Size(70, 15)
        Me.lblRCHBodyType.TabIndex = 8
        Me.lblRCHBodyType.Text = "Body Type: "
        '
        'lblRCHCarType
        '
        Me.lblRCHCarType.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRCHCarType.AutoSize = True
        Me.lblRCHCarType.Location = New System.Drawing.Point(64, 9)
        Me.lblRCHCarType.Name = "lblRCHCarType"
        Me.lblRCHCarType.Size = New System.Drawing.Size(61, 15)
        Me.lblRCHCarType.TabIndex = 4
        Me.lblRCHCarType.Text = "Car Type: "
        '
        'lblRCHTransmission
        '
        Me.lblRCHTransmission.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRCHTransmission.AutoSize = True
        Me.lblRCHTransmission.Location = New System.Drawing.Point(42, 43)
        Me.lblRCHTransmission.Name = "lblRCHTransmission"
        Me.lblRCHTransmission.Size = New System.Drawing.Size(83, 15)
        Me.lblRCHTransmission.TabIndex = 6
        Me.lblRCHTransmission.Text = "Transmission: "
        '
        'lblRCHFuelEfficiency
        '
        Me.lblRCHFuelEfficiency.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRCHFuelEfficiency.AutoSize = True
        Me.lblRCHFuelEfficiency.Location = New System.Drawing.Point(35, 111)
        Me.lblRCHFuelEfficiency.Name = "lblRCHFuelEfficiency"
        Me.lblRCHFuelEfficiency.Size = New System.Drawing.Size(90, 15)
        Me.lblRCHFuelEfficiency.TabIndex = 7
        Me.lblRCHFuelEfficiency.Text = "Fuel Efficiency: "
        '
        'lblRCHEngine
        '
        Me.lblRCHEngine.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRCHEngine.AutoSize = True
        Me.lblRCHEngine.Location = New System.Drawing.Point(75, 77)
        Me.lblRCHEngine.Name = "lblRCHEngine"
        Me.lblRCHEngine.Size = New System.Drawing.Size(50, 15)
        Me.lblRCHEngine.TabIndex = 5
        Me.lblRCHEngine.Text = "Engine: "
        '
        'btnRCHGoBackResults
        '
        Me.btnRCHGoBackResults.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRCHGoBackResults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRCHGoBackResults.Location = New System.Drawing.Point(3, 5)
        Me.btnRCHGoBackResults.Name = "btnRCHGoBackResults"
        Me.btnRCHGoBackResults.Size = New System.Drawing.Size(87, 34)
        Me.btnRCHGoBackResults.TabIndex = 9
        Me.btnRCHGoBackResults.Text = "<--- Go Back"
        Me.btnRCHGoBackResults.UseVisualStyleBackColor = True
        '
        'btnRCHAccept
        '
        Me.btnRCHAccept.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRCHAccept.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnRCHAccept.Location = New System.Drawing.Point(358, 350)
        Me.btnRCHAccept.Name = "btnRCHAccept"
        Me.btnRCHAccept.Size = New System.Drawing.Size(87, 34)
        Me.btnRCHAccept.TabIndex = 10
        Me.btnRCHAccept.Text = "Accept"
        Me.btnRCHAccept.UseVisualStyleBackColor = True
        '
        'frmRCHResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(495, 394)
        Me.Controls.Add(Me.btnRCHAccept)
        Me.Controls.Add(Me.btnRCHGoBackResults)
        Me.Controls.Add(Me.grpRCHSpecs)
        Me.Controls.Add(Me.gbxRCHCar)
        Me.Name = "frmRCHResults"
        Me.Text = "Results"
        Me.gbxRCHCar.ResumeLayout(False)
        Me.tblRCHCarInfo.ResumeLayout(False)
        Me.tblRCHCarInfo.PerformLayout()
        Me.grpRCHSpecs.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxRCHCar As GroupBox
    Friend WithEvents rbxRCHModel As RichTextBox
    Friend WithEvents rbxRCHMake As RichTextBox
    Friend WithEvents lblRCHModel As Label
    Friend WithEvents lblRCHMake As Label
    Friend WithEvents grpRCHSpecs As GroupBox
    Friend WithEvents lblRCHFuelEfficiency As Label
    Friend WithEvents lblRCHTransmission As Label
    Friend WithEvents lblRCHEngine As Label
    Friend WithEvents lblRCHCarType As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblRCHBodyType As Label
    Friend WithEvents tblRCHCarInfo As TableLayoutPanel
    Friend WithEvents rtxRCHBodyType As RichTextBox
    Friend WithEvents rtxRCHFuelEfficiency As RichTextBox
    Friend WithEvents rtxRCHEngine As RichTextBox
    Friend WithEvents rtxRCHTransmission As RichTextBox
    Friend WithEvents rtxRCHCarType As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents lblRCHCost As Label
    Friend WithEvents btnRCHGoBackResults As Button
    Friend WithEvents btnRCHAccept As Button
End Class
