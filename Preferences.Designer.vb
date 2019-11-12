'*******************************************************************************************
' Copyright © 2016 Scott Bailey 
' 17351 W US 60 Olive Hill, KY 41164 
' rscottb31@gmail.com
' All Rights Reserved Worldwide.

'  NOTICE:  All information contained herein is, and remains
' the property of the above proprietor Scott Bailey. The intellectual 
' and technical concepts contained herein are proprietary to the above
' stated and may be covered by U.S. and Foreign Patents, patents in process, 
' and are protected by trade secret or copyright law.
' Dissemination of this information or reproduction of this material
' is strictly forbidden unless prior written permission is obtained
' from the above stated.

' Unless otherwise stated all code is written by Scott Bailey <rscottb31@gmail.com>
'*******************************************************************************************



<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preferences
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbMarginRight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbMarginLeft = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbMarginTop = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbMarginBottom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudNumVerseSpace = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdoTopRight = New System.Windows.Forms.RadioButton()
        Me.rdoTopLeft = New System.Windows.Forms.RadioButton()
        Me.rdoTopCenter = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cbUse3DRendering = New System.Windows.Forms.CheckBox()
        Me.gbOutlining = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbEnableOutline = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnOutlineColor = New System.Windows.Forms.Button()
        Me.nudOutlineSize = New System.Windows.Forms.NumericUpDown()
        Me.gbShadows = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.nudShadowOffsetY = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudShadowOffsetX = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbEnableShadows = New System.Windows.Forms.CheckBox()
        Me.btnShadowColor = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialogText = New System.Windows.Forms.ColorDialog()
        Me.ColorDialogShadow = New System.Windows.Forms.ColorDialog()
        Me.ColorDialogOutline = New System.Windows.Forms.ColorDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nudNumVerseSpace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gbOutlining.SuspendLayout()
        CType(Me.nudOutlineSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbShadows.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.nudShadowOffsetY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudShadowOffsetX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(247, 309)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(376, 262)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Display Screen"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.nudNumVerseSpace)
        Me.GroupBox1.Location = New System.Drawing.Point(157, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 229)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Spacing and Margins"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.tbMarginRight)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.tbMarginLeft)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.tbMarginTop)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.tbMarginBottom)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 68)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(175, 155)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Margins"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 26)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Sets the display margins for " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " the page."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(84, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Bottom:"
        '
        'tbMarginRight
        '
        Me.tbMarginRight.Location = New System.Drawing.Point(87, 79)
        Me.tbMarginRight.Name = "tbMarginRight"
        Me.tbMarginRight.ShortcutsEnabled = False
        Me.tbMarginRight.Size = New System.Drawing.Size(53, 20)
        Me.tbMarginRight.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Top:"
        '
        'tbMarginLeft
        '
        Me.tbMarginLeft.Location = New System.Drawing.Point(28, 79)
        Me.tbMarginLeft.Name = "tbMarginLeft"
        Me.tbMarginLeft.ShortcutsEnabled = False
        Me.tbMarginLeft.Size = New System.Drawing.Size(53, 20)
        Me.tbMarginLeft.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Right:"
        '
        'tbMarginTop
        '
        Me.tbMarginTop.Location = New System.Drawing.Point(28, 118)
        Me.tbMarginTop.Name = "tbMarginTop"
        Me.tbMarginTop.ShortcutsEnabled = False
        Me.tbMarginTop.Size = New System.Drawing.Size(53, 20)
        Me.tbMarginTop.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Left:"
        '
        'tbMarginBottom
        '
        Me.tbMarginBottom.Location = New System.Drawing.Point(87, 118)
        Me.tbMarginBottom.Name = "tbMarginBottom"
        Me.tbMarginBottom.ShortcutsEnabled = False
        Me.tbMarginBottom.Size = New System.Drawing.Size(53, 20)
        Me.tbMarginBottom.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Space between number and verse."
        '
        'nudNumVerseSpace
        '
        Me.nudNumVerseSpace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNumVerseSpace.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudNumVerseSpace.Location = New System.Drawing.Point(18, 42)
        Me.nudNumVerseSpace.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudNumVerseSpace.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumVerseSpace.Name = "nudNumVerseSpace"
        Me.nudNumVerseSpace.Size = New System.Drawing.Size(170, 20)
        Me.nudNumVerseSpace.TabIndex = 0
        Me.nudNumVerseSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudNumVerseSpace.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.btnColor)
        Me.GroupBox2.Controls.Add(Me.btnFont)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.rdoTopRight)
        Me.GroupBox2.Controls.Add(Me.rdoTopLeft)
        Me.GroupBox2.Controls.Add(Me.rdoTopCenter)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 229)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reference and Verses"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 26)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Selects the font and color " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " for the display text."
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(20, 189)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(78, 23)
        Me.btnColor.TabIndex = 15
        Me.btnColor.Text = "Display Color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'btnFont
        '
        Me.btnFont.Location = New System.Drawing.Point(20, 160)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(78, 23)
        Me.btnFont.TabIndex = 7
        Me.btnFont.Text = "Display Font"
        Me.btnFont.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Reference Alignment:"
        '
        'rdoTopRight
        '
        Me.rdoTopRight.AutoSize = True
        Me.rdoTopRight.Location = New System.Drawing.Point(20, 88)
        Me.rdoTopRight.Name = "rdoTopRight"
        Me.rdoTopRight.Size = New System.Drawing.Size(72, 17)
        Me.rdoTopRight.TabIndex = 3
        Me.rdoTopRight.Text = "Top Right"
        Me.rdoTopRight.UseVisualStyleBackColor = True
        '
        'rdoTopLeft
        '
        Me.rdoTopLeft.AutoSize = True
        Me.rdoTopLeft.Checked = True
        Me.rdoTopLeft.Location = New System.Drawing.Point(20, 42)
        Me.rdoTopLeft.Name = "rdoTopLeft"
        Me.rdoTopLeft.Size = New System.Drawing.Size(65, 17)
        Me.rdoTopLeft.TabIndex = 2
        Me.rdoTopLeft.TabStop = True
        Me.rdoTopLeft.Text = "Top Left"
        Me.rdoTopLeft.UseVisualStyleBackColor = True
        '
        'rdoTopCenter
        '
        Me.rdoTopCenter.AutoSize = True
        Me.rdoTopCenter.Location = New System.Drawing.Point(20, 65)
        Me.rdoTopCenter.Name = "rdoTopCenter"
        Me.rdoTopCenter.Size = New System.Drawing.Size(78, 17)
        Me.rdoTopCenter.TabIndex = 3
        Me.rdoTopCenter.Text = "Top Center"
        Me.rdoTopCenter.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(384, 288)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cbUse3DRendering)
        Me.TabPage2.Controls.Add(Me.gbOutlining)
        Me.TabPage2.Controls.Add(Me.gbShadows)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(376, 262)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "3D Rendering"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cbUse3DRendering
        '
        Me.cbUse3DRendering.AutoSize = True
        Me.cbUse3DRendering.Location = New System.Drawing.Point(3, 13)
        Me.cbUse3DRendering.Name = "cbUse3DRendering"
        Me.cbUse3DRendering.Size = New System.Drawing.Size(114, 17)
        Me.cbUse3DRendering.TabIndex = 18
        Me.cbUse3DRendering.Text = "Use 3D Rendering"
        Me.cbUse3DRendering.UseVisualStyleBackColor = True
        '
        'gbOutlining
        '
        Me.gbOutlining.Controls.Add(Me.Label11)
        Me.gbOutlining.Controls.Add(Me.cbEnableOutline)
        Me.gbOutlining.Controls.Add(Me.Label7)
        Me.gbOutlining.Controls.Add(Me.btnOutlineColor)
        Me.gbOutlining.Controls.Add(Me.nudOutlineSize)
        Me.gbOutlining.Enabled = False
        Me.gbOutlining.Location = New System.Drawing.Point(223, 36)
        Me.gbOutlining.Name = "gbOutlining"
        Me.gbOutlining.Size = New System.Drawing.Size(141, 196)
        Me.gbOutlining.TabIndex = 17
        Me.gbOutlining.TabStop = False
        Me.gbOutlining.Text = "Outlining"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Location = New System.Drawing.Point(6, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 26)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Sets the outline size of the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "text from 1-10."
        '
        'cbEnableOutline
        '
        Me.cbEnableOutline.AutoSize = True
        Me.cbEnableOutline.Location = New System.Drawing.Point(6, 25)
        Me.cbEnableOutline.Name = "cbEnableOutline"
        Me.cbEnableOutline.Size = New System.Drawing.Size(103, 17)
        Me.cbEnableOutline.TabIndex = 12
        Me.cbEnableOutline.Text = "Enable Outlining"
        Me.cbEnableOutline.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Size"
        '
        'btnOutlineColor
        '
        Me.btnOutlineColor.Enabled = False
        Me.btnOutlineColor.Location = New System.Drawing.Point(28, 48)
        Me.btnOutlineColor.Name = "btnOutlineColor"
        Me.btnOutlineColor.Size = New System.Drawing.Size(90, 23)
        Me.btnOutlineColor.TabIndex = 14
        Me.btnOutlineColor.Text = "Outline Color"
        Me.btnOutlineColor.UseVisualStyleBackColor = True
        '
        'nudOutlineSize
        '
        Me.nudOutlineSize.Enabled = False
        Me.nudOutlineSize.Location = New System.Drawing.Point(43, 145)
        Me.nudOutlineSize.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudOutlineSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudOutlineSize.Name = "nudOutlineSize"
        Me.nudOutlineSize.Size = New System.Drawing.Size(53, 20)
        Me.nudOutlineSize.TabIndex = 9
        Me.nudOutlineSize.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'gbShadows
        '
        Me.gbShadows.Controls.Add(Me.GroupBox5)
        Me.gbShadows.Controls.Add(Me.cbEnableShadows)
        Me.gbShadows.Controls.Add(Me.btnShadowColor)
        Me.gbShadows.Enabled = False
        Me.gbShadows.Location = New System.Drawing.Point(22, 36)
        Me.gbShadows.Name = "gbShadows"
        Me.gbShadows.Size = New System.Drawing.Size(195, 196)
        Me.gbShadows.TabIndex = 9
        Me.gbShadows.TabStop = False
        Me.gbShadows.Text = "Shadows"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.nudShadowOffsetY)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.nudShadowOffsetX)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Enabled = False
        Me.GroupBox5.Location = New System.Drawing.Point(6, 92)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(182, 98)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Offset"
        '
        'nudShadowOffsetY
        '
        Me.nudShadowOffsetY.Location = New System.Drawing.Point(121, 61)
        Me.nudShadowOffsetY.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudShadowOffsetY.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudShadowOffsetY.Name = "nudShadowOffsetY"
        Me.nudShadowOffsetY.Size = New System.Drawing.Size(53, 20)
        Me.nudShadowOffsetY.TabIndex = 18
        Me.nudShadowOffsetY.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 26)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Sets the x,y coordinates in pixels " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the text shadow."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "X:"
        '
        'nudShadowOffsetX
        '
        Me.nudShadowOffsetX.Location = New System.Drawing.Point(33, 61)
        Me.nudShadowOffsetX.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudShadowOffsetX.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudShadowOffsetX.Name = "nudShadowOffsetX"
        Me.nudShadowOffsetX.Size = New System.Drawing.Size(53, 20)
        Me.nudShadowOffsetX.TabIndex = 16
        Me.nudShadowOffsetX.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(96, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Y:"
        '
        'cbEnableShadows
        '
        Me.cbEnableShadows.AutoSize = True
        Me.cbEnableShadows.Location = New System.Drawing.Point(6, 25)
        Me.cbEnableShadows.Name = "cbEnableShadows"
        Me.cbEnableShadows.Size = New System.Drawing.Size(106, 17)
        Me.cbEnableShadows.TabIndex = 11
        Me.cbEnableShadows.Text = "Enable Shadows"
        Me.cbEnableShadows.UseVisualStyleBackColor = True
        '
        'btnShadowColor
        '
        Me.btnShadowColor.Enabled = False
        Me.btnShadowColor.Location = New System.Drawing.Point(28, 48)
        Me.btnShadowColor.Name = "btnShadowColor"
        Me.btnShadowColor.Size = New System.Drawing.Size(90, 23)
        Me.btnShadowColor.TabIndex = 13
        Me.btnShadowColor.Text = "Shadow Color"
        Me.btnShadowColor.UseVisualStyleBackColor = True
        '
        'FontDialog1
        '
        Me.FontDialog1.AllowScriptChange = False
        Me.FontDialog1.AllowVectorFonts = False
        Me.FontDialog1.AllowVerticalFonts = False
        Me.FontDialog1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FontDialog1.FontMustExist = True
        Me.FontDialog1.MaxSize = 80
        Me.FontDialog1.MinSize = 10
        '
        'Preferences
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(405, 350)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Preferences"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Preferences"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nudNumVerseSpace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.gbOutlining.ResumeLayout(False)
        Me.gbOutlining.PerformLayout()
        CType(Me.nudOutlineSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbShadows.ResumeLayout(False)
        Me.gbShadows.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.nudShadowOffsetY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudShadowOffsetX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdoTopRight As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTopLeft As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTopCenter As System.Windows.Forms.RadioButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents nudNumVerseSpace As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbMarginRight As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbMarginLeft As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbMarginTop As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbMarginBottom As System.Windows.Forms.TextBox
    Friend WithEvents btnFont As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents btnColor As System.Windows.Forms.Button
    Friend WithEvents ColorDialogText As System.Windows.Forms.ColorDialog
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cbUse3DRendering As System.Windows.Forms.CheckBox
    Friend WithEvents gbOutlining As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbEnableOutline As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnOutlineColor As System.Windows.Forms.Button
    Friend WithEvents nudOutlineSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents gbShadows As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents nudShadowOffsetY As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nudShadowOffsetX As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbEnableShadows As System.Windows.Forms.CheckBox
    Friend WithEvents btnShadowColor As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ColorDialogShadow As System.Windows.Forms.ColorDialog
    Friend WithEvents ColorDialogOutline As System.Windows.Forms.ColorDialog

End Class
