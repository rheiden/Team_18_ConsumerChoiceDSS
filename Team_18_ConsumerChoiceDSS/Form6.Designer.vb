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
        Me.gbxTeam18Car = New System.Windows.Forms.GroupBox()
        Me.tblTeam18CarInfo = New System.Windows.Forms.TableLayoutPanel()
        Me.rbxTeam18Model = New System.Windows.Forms.RichTextBox()
        Me.lblRCHModel = New System.Windows.Forms.Label()
        Me.lblTeam18Make = New System.Windows.Forms.Label()
        Me.rbxTeam18Make = New System.Windows.Forms.RichTextBox()
        Me.rbxTeam18Cost = New System.Windows.Forms.RichTextBox()
        Me.lblTeam18Cost = New System.Windows.Forms.Label()
        Me.grpTeam18Specs = New System.Windows.Forms.GroupBox()
        Me.tblTeam18CarSpecs = New System.Windows.Forms.TableLayoutPanel()
        Me.rtxTeam18BodyType = New System.Windows.Forms.RichTextBox()
        Me.rtxTeam18FuelEfficiency = New System.Windows.Forms.RichTextBox()
        Me.rtxTeam18Engine = New System.Windows.Forms.RichTextBox()
        Me.rtxTeam18Transmission = New System.Windows.Forms.RichTextBox()
        Me.rtxTeam18CarType = New System.Windows.Forms.RichTextBox()
        Me.lblTeam18BodyType = New System.Windows.Forms.Label()
        Me.lblTeam18CarType = New System.Windows.Forms.Label()
        Me.lblTeam18Transmission = New System.Windows.Forms.Label()
        Me.lblTeam18FuelEfficiency = New System.Windows.Forms.Label()
        Me.lblTeam18Engine = New System.Windows.Forms.Label()
        Me.btnTeam18GoBackResults = New System.Windows.Forms.Button()
        Me.btnTeam18Accept = New System.Windows.Forms.Button()
        Me.gbxTeam18Car.SuspendLayout()
        Me.tblTeam18CarInfo.SuspendLayout()
        Me.grpTeam18Specs.SuspendLayout()
        Me.tblTeam18CarSpecs.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxTeam18Car
        '
        Me.gbxTeam18Car.Controls.Add(Me.tblTeam18CarInfo)
        Me.gbxTeam18Car.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxTeam18Car.Location = New System.Drawing.Point(22, 45)
        Me.gbxTeam18Car.Name = "gbxTeam18Car"
        Me.gbxTeam18Car.Size = New System.Drawing.Size(301, 130)
        Me.gbxTeam18Car.TabIndex = 0
        Me.gbxTeam18Car.TabStop = False
        Me.gbxTeam18Car.Text = "Car Information"
        '
        'tblTeam18CarInfo
        '
        Me.tblTeam18CarInfo.ColumnCount = 2
        Me.tblTeam18CarInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTeam18CarInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTeam18CarInfo.Controls.Add(Me.rbxTeam18Model, 1, 1)
        Me.tblTeam18CarInfo.Controls.Add(Me.lblRCHModel, 0, 1)
        Me.tblTeam18CarInfo.Controls.Add(Me.lblTeam18Make, 0, 0)
        Me.tblTeam18CarInfo.Controls.Add(Me.rbxTeam18Make, 1, 0)
        Me.tblTeam18CarInfo.Controls.Add(Me.rbxTeam18Cost, 1, 2)
        Me.tblTeam18CarInfo.Controls.Add(Me.lblTeam18Cost, 0, 2)
        Me.tblTeam18CarInfo.Location = New System.Drawing.Point(16, 17)
        Me.tblTeam18CarInfo.Name = "tblTeam18CarInfo"
        Me.tblTeam18CarInfo.RowCount = 3
        Me.tblTeam18CarInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblTeam18CarInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblTeam18CarInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblTeam18CarInfo.Size = New System.Drawing.Size(271, 97)
        Me.tblTeam18CarInfo.TabIndex = 0
        '
        'rbxTeam18Model
        '
        Me.rbxTeam18Model.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbxTeam18Model.Location = New System.Drawing.Point(138, 37)
        Me.rbxTeam18Model.Name = "rbxTeam18Model"
        Me.rbxTeam18Model.Size = New System.Drawing.Size(130, 21)
        Me.rbxTeam18Model.TabIndex = 3
        Me.rbxTeam18Model.Text = ""
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
        'lblTeam18Make
        '
        Me.lblTeam18Make.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18Make.AutoSize = True
        Me.lblTeam18Make.Location = New System.Drawing.Point(88, 8)
        Me.lblTeam18Make.Name = "lblTeam18Make"
        Me.lblTeam18Make.Size = New System.Drawing.Size(44, 15)
        Me.lblTeam18Make.TabIndex = 0
        Me.lblTeam18Make.Text = "Make: "
        '
        'rbxTeam18Make
        '
        Me.rbxTeam18Make.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbxTeam18Make.Location = New System.Drawing.Point(138, 5)
        Me.rbxTeam18Make.Name = "rbxTeam18Make"
        Me.rbxTeam18Make.Size = New System.Drawing.Size(130, 21)
        Me.rbxTeam18Make.TabIndex = 2
        Me.rbxTeam18Make.Text = ""
        '
        'rbxTeam18Cost
        '
        Me.rbxTeam18Cost.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbxTeam18Cost.Location = New System.Drawing.Point(138, 70)
        Me.rbxTeam18Cost.Name = "rbxTeam18Cost"
        Me.rbxTeam18Cost.Size = New System.Drawing.Size(130, 21)
        Me.rbxTeam18Cost.TabIndex = 5
        Me.rbxTeam18Cost.Text = ""
        '
        'lblTeam18Cost
        '
        Me.lblTeam18Cost.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18Cost.AutoSize = True
        Me.lblTeam18Cost.Location = New System.Drawing.Point(97, 73)
        Me.lblTeam18Cost.Name = "lblTeam18Cost"
        Me.lblTeam18Cost.Size = New System.Drawing.Size(35, 15)
        Me.lblTeam18Cost.TabIndex = 4
        Me.lblTeam18Cost.Text = "Cost:"
        '
        'grpTeam18Specs
        '
        Me.grpTeam18Specs.Controls.Add(Me.tblTeam18CarSpecs)
        Me.grpTeam18Specs.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTeam18Specs.Location = New System.Drawing.Point(22, 181)
        Me.grpTeam18Specs.Name = "grpTeam18Specs"
        Me.grpTeam18Specs.Size = New System.Drawing.Size(287, 201)
        Me.grpTeam18Specs.TabIndex = 1
        Me.grpTeam18Specs.TabStop = False
        Me.grpTeam18Specs.Text = "Car Specs"
        '
        'tblTeam18CarSpecs
        '
        Me.tblTeam18CarSpecs.ColumnCount = 2
        Me.tblTeam18CarSpecs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTeam18CarSpecs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTeam18CarSpecs.Controls.Add(Me.rtxTeam18BodyType, 1, 4)
        Me.tblTeam18CarSpecs.Controls.Add(Me.rtxTeam18FuelEfficiency, 1, 3)
        Me.tblTeam18CarSpecs.Controls.Add(Me.rtxTeam18Engine, 1, 2)
        Me.tblTeam18CarSpecs.Controls.Add(Me.rtxTeam18Transmission, 1, 1)
        Me.tblTeam18CarSpecs.Controls.Add(Me.rtxTeam18CarType, 1, 0)
        Me.tblTeam18CarSpecs.Controls.Add(Me.lblTeam18BodyType, 0, 4)
        Me.tblTeam18CarSpecs.Controls.Add(Me.lblTeam18CarType, 0, 0)
        Me.tblTeam18CarSpecs.Controls.Add(Me.lblTeam18Transmission, 0, 1)
        Me.tblTeam18CarSpecs.Controls.Add(Me.lblTeam18FuelEfficiency, 0, 3)
        Me.tblTeam18CarSpecs.Controls.Add(Me.lblTeam18Engine, 0, 2)
        Me.tblTeam18CarSpecs.Location = New System.Drawing.Point(16, 22)
        Me.tblTeam18CarSpecs.Name = "tblTeam18CarSpecs"
        Me.tblTeam18CarSpecs.RowCount = 5
        Me.tblTeam18CarSpecs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblTeam18CarSpecs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblTeam18CarSpecs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblTeam18CarSpecs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblTeam18CarSpecs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblTeam18CarSpecs.Size = New System.Drawing.Size(256, 173)
        Me.tblTeam18CarSpecs.TabIndex = 0
        '
        'rtxTeam18BodyType
        '
        Me.rtxTeam18BodyType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rtxTeam18BodyType.Location = New System.Drawing.Point(131, 144)
        Me.rtxTeam18BodyType.Name = "rtxTeam18BodyType"
        Me.rtxTeam18BodyType.Size = New System.Drawing.Size(117, 20)
        Me.rtxTeam18BodyType.TabIndex = 12
        Me.rtxTeam18BodyType.Text = ""
        '
        'rtxTeam18FuelEfficiency
        '
        Me.rtxTeam18FuelEfficiency.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rtxTeam18FuelEfficiency.Location = New System.Drawing.Point(131, 109)
        Me.rtxTeam18FuelEfficiency.Name = "rtxTeam18FuelEfficiency"
        Me.rtxTeam18FuelEfficiency.Size = New System.Drawing.Size(117, 20)
        Me.rtxTeam18FuelEfficiency.TabIndex = 11
        Me.rtxTeam18FuelEfficiency.Text = ""
        '
        'rtxTeam18Engine
        '
        Me.rtxTeam18Engine.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rtxTeam18Engine.Location = New System.Drawing.Point(131, 75)
        Me.rtxTeam18Engine.Name = "rtxTeam18Engine"
        Me.rtxTeam18Engine.Size = New System.Drawing.Size(117, 20)
        Me.rtxTeam18Engine.TabIndex = 10
        Me.rtxTeam18Engine.Text = ""
        '
        'rtxTeam18Transmission
        '
        Me.rtxTeam18Transmission.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rtxTeam18Transmission.Location = New System.Drawing.Point(131, 41)
        Me.rtxTeam18Transmission.Name = "rtxTeam18Transmission"
        Me.rtxTeam18Transmission.Size = New System.Drawing.Size(117, 20)
        Me.rtxTeam18Transmission.TabIndex = 9
        Me.rtxTeam18Transmission.Text = ""
        '
        'rtxTeam18CarType
        '
        Me.rtxTeam18CarType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rtxTeam18CarType.Location = New System.Drawing.Point(131, 6)
        Me.rtxTeam18CarType.Name = "rtxTeam18CarType"
        Me.rtxTeam18CarType.Size = New System.Drawing.Size(117, 21)
        Me.rtxTeam18CarType.TabIndex = 4
        Me.rtxTeam18CarType.Text = ""
        '
        'lblTeam18BodyType
        '
        Me.lblTeam18BodyType.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18BodyType.AutoSize = True
        Me.lblTeam18BodyType.Location = New System.Drawing.Point(55, 147)
        Me.lblTeam18BodyType.Name = "lblTeam18BodyType"
        Me.lblTeam18BodyType.Size = New System.Drawing.Size(70, 15)
        Me.lblTeam18BodyType.TabIndex = 8
        Me.lblTeam18BodyType.Text = "Body Type: "
        '
        'lblTeam18CarType
        '
        Me.lblTeam18CarType.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18CarType.AutoSize = True
        Me.lblTeam18CarType.Location = New System.Drawing.Point(64, 9)
        Me.lblTeam18CarType.Name = "lblTeam18CarType"
        Me.lblTeam18CarType.Size = New System.Drawing.Size(61, 15)
        Me.lblTeam18CarType.TabIndex = 4
        Me.lblTeam18CarType.Text = "Car Type: "
        '
        'lblTeam18Transmission
        '
        Me.lblTeam18Transmission.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18Transmission.AutoSize = True
        Me.lblTeam18Transmission.Location = New System.Drawing.Point(42, 43)
        Me.lblTeam18Transmission.Name = "lblTeam18Transmission"
        Me.lblTeam18Transmission.Size = New System.Drawing.Size(83, 15)
        Me.lblTeam18Transmission.TabIndex = 6
        Me.lblTeam18Transmission.Text = "Transmission: "
        '
        'lblTeam18FuelEfficiency
        '
        Me.lblTeam18FuelEfficiency.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18FuelEfficiency.AutoSize = True
        Me.lblTeam18FuelEfficiency.Location = New System.Drawing.Point(35, 111)
        Me.lblTeam18FuelEfficiency.Name = "lblTeam18FuelEfficiency"
        Me.lblTeam18FuelEfficiency.Size = New System.Drawing.Size(90, 15)
        Me.lblTeam18FuelEfficiency.TabIndex = 7
        Me.lblTeam18FuelEfficiency.Text = "Fuel Efficiency: "
        '
        'lblTeam18Engine
        '
        Me.lblTeam18Engine.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18Engine.AutoSize = True
        Me.lblTeam18Engine.Location = New System.Drawing.Point(75, 77)
        Me.lblTeam18Engine.Name = "lblTeam18Engine"
        Me.lblTeam18Engine.Size = New System.Drawing.Size(50, 15)
        Me.lblTeam18Engine.TabIndex = 5
        Me.lblTeam18Engine.Text = "Engine: "
        '
        'btnTeam18GoBackResults
        '
        Me.btnTeam18GoBackResults.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeam18GoBackResults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTeam18GoBackResults.Location = New System.Drawing.Point(3, 5)
        Me.btnTeam18GoBackResults.Name = "btnTeam18GoBackResults"
        Me.btnTeam18GoBackResults.Size = New System.Drawing.Size(87, 34)
        Me.btnTeam18GoBackResults.TabIndex = 9
        Me.btnTeam18GoBackResults.Text = "<--- Go Back"
        Me.btnTeam18GoBackResults.UseVisualStyleBackColor = True
        '
        'btnTeam18Accept
        '
        Me.btnTeam18Accept.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeam18Accept.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnTeam18Accept.Location = New System.Drawing.Point(358, 350)
        Me.btnTeam18Accept.Name = "btnTeam18Accept"
        Me.btnTeam18Accept.Size = New System.Drawing.Size(87, 34)
        Me.btnTeam18Accept.TabIndex = 10
        Me.btnTeam18Accept.Text = "Accept"
        Me.btnTeam18Accept.UseVisualStyleBackColor = True
        '
        'frmRCHResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(495, 394)
        Me.Controls.Add(Me.btnTeam18Accept)
        Me.Controls.Add(Me.btnTeam18GoBackResults)
        Me.Controls.Add(Me.grpTeam18Specs)
        Me.Controls.Add(Me.gbxTeam18Car)
        Me.Name = "frmRCHResults"
        Me.Text = "Results"
        Me.gbxTeam18Car.ResumeLayout(False)
        Me.tblTeam18CarInfo.ResumeLayout(False)
        Me.tblTeam18CarInfo.PerformLayout()
        Me.grpTeam18Specs.ResumeLayout(False)
        Me.tblTeam18CarSpecs.ResumeLayout(False)
        Me.tblTeam18CarSpecs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxTeam18Car As GroupBox
    Friend WithEvents rbxTeam18Model As RichTextBox
    Friend WithEvents rbxTeam18Make As RichTextBox
    Friend WithEvents lblRCHModel As Label
    Friend WithEvents lblTeam18Make As Label
    Friend WithEvents grpTeam18Specs As GroupBox
    Friend WithEvents lblTeam18FuelEfficiency As Label
    Friend WithEvents lblTeam18Transmission As Label
    Friend WithEvents lblTeam18Engine As Label
    Friend WithEvents lblTeam18CarType As Label
    Friend WithEvents tblTeam18CarSpecs As TableLayoutPanel
    Friend WithEvents lblTeam18BodyType As Label
    Friend WithEvents tblTeam18CarInfo As TableLayoutPanel
    Friend WithEvents rtxTeam18BodyType As RichTextBox
    Friend WithEvents rtxTeam18FuelEfficiency As RichTextBox
    Friend WithEvents rtxTeam18Engine As RichTextBox
    Friend WithEvents rtxTeam18Transmission As RichTextBox
    Friend WithEvents rtxTeam18CarType As RichTextBox
    Friend WithEvents rbxTeam18Cost As RichTextBox
    Friend WithEvents lblTeam18Cost As Label
    Friend WithEvents btnTeam18GoBackResults As Button
    Friend WithEvents btnTeam18Accept As Button
End Class
