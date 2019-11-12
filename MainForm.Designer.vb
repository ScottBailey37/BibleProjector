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
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnRefGo = New System.Windows.Forms.Button()
        Me.lblRefInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbReference = New System.Windows.Forms.TextBox()
        Me.tabctrlBible = New System.Windows.Forms.TabControl()
        Me.tabpageBible = New System.Windows.Forms.TabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbAddToPlaylist = New System.Windows.Forms.ToolStripButton()
        Me.lbVerses = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctx1AddVerses = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ctx1SelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbChapters = New System.Windows.Forms.ListBox()
        Me.lbBooks = New System.Windows.Forms.ListBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblBannerBorderColor = New System.Windows.Forms.Label()
        Me.lblTitleColor = New System.Windows.Forms.Label()
        Me.lblBannerColor = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudBannerBorderSize = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbShowTitle = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTitle = New System.Windows.Forms.TextBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.btnDeleteSelectedRef = New System.Windows.Forms.Button()
        Me.btnClearAllPlaylist = New System.Windows.Forms.Button()
        Me.lvPlaylist = New System.Windows.Forms.ListView()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGoLive = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbClearScreenImage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbClearText = New System.Windows.Forms.ToolStripButton()
        Me.pbPreviewScreen = New System.Windows.Forms.PictureBox()
        Me.lvBackgroundImages = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctx2DeleteSelected = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBackgroundImagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShortcutKeysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoLiveCTRLLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToPlaylistCTRLAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindReferenceCTRLRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsCTRLOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddImageCTRLIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubmitBugReportFeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ImageListFullSize = New System.Windows.Forms.ImageList(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.tabctrlBible.SuspendLayout()
        Me.tabpageBible.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudBannerBorderSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.pbPreviewScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 27)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRefGo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblRefInfo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tbReference)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tabctrlBible)
        Me.SplitContainer1.Panel1MinSize = 300
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2MinSize = 500
        Me.SplitContainer1.Size = New System.Drawing.Size(1042, 597)
        Me.SplitContainer1.SplitterDistance = 438
        Me.SplitContainer1.TabIndex = 0
        '
        'btnRefGo
        '
        Me.btnRefGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefGo.AutoSize = True
        Me.btnRefGo.Enabled = False
        Me.btnRefGo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefGo.Location = New System.Drawing.Point(390, 20)
        Me.btnRefGo.Name = "btnRefGo"
        Me.btnRefGo.Size = New System.Drawing.Size(40, 27)
        Me.btnRefGo.TabIndex = 6
        Me.btnRefGo.Text = "Go"
        Me.btnRefGo.UseVisualStyleBackColor = True
        '
        'lblRefInfo
        '
        Me.lblRefInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRefInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRefInfo.Image = Global.WordofGodBibleProjector.My.Resources.Resources.information_white_icon
        Me.lblRefInfo.Location = New System.Drawing.Point(171, 21)
        Me.lblRefInfo.Name = "lblRefInfo"
        Me.lblRefInfo.Size = New System.Drawing.Size(19, 20)
        Me.lblRefInfo.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.lblRefInfo, "Format:  Bookname chapter:verse(s)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click for more information." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(193, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Find reference:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tbReference
        '
        Me.tbReference.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbReference.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbReference.Location = New System.Drawing.Point(196, 21)
        Me.tbReference.Name = "tbReference"
        Me.tbReference.Size = New System.Drawing.Size(188, 25)
        Me.tbReference.TabIndex = 2
        '
        'tabctrlBible
        '
        Me.tabctrlBible.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabctrlBible.Controls.Add(Me.tabpageBible)
        Me.tabctrlBible.Controls.Add(Me.TabPage1)
        Me.tabctrlBible.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabctrlBible.Location = New System.Drawing.Point(2, 44)
        Me.tabctrlBible.Name = "tabctrlBible"
        Me.tabctrlBible.Padding = New System.Drawing.Point(10, 6)
        Me.tabctrlBible.SelectedIndex = 0
        Me.tabctrlBible.Size = New System.Drawing.Size(432, 548)
        Me.tabctrlBible.TabIndex = 1
        '
        'tabpageBible
        '
        Me.tabpageBible.Controls.Add(Me.ToolStrip1)
        Me.tabpageBible.Controls.Add(Me.lbVerses)
        Me.tabpageBible.Controls.Add(Me.lbChapters)
        Me.tabpageBible.Controls.Add(Me.lbBooks)
        Me.tabpageBible.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpageBible.Location = New System.Drawing.Point(4, 32)
        Me.tabpageBible.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.tabpageBible.Name = "tabpageBible"
        Me.tabpageBible.Padding = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.tabpageBible.Size = New System.Drawing.Size(424, 512)
        Me.tabpageBible.TabIndex = 1
        Me.tabpageBible.Text = "Bible"
        Me.tabpageBible.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAddToPlaylist})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(381, 299)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.ShowItemToolTips = False
        Me.ToolStrip1.Size = New System.Drawing.Size(40, 67)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbAddToPlaylist
        '
        Me.tsbAddToPlaylist.AutoSize = False
        Me.tsbAddToPlaylist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAddToPlaylist.Image = Global.WordofGodBibleProjector.My.Resources.Resources.Enter_104px
        Me.tsbAddToPlaylist.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddToPlaylist.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.tsbAddToPlaylist.Name = "tsbAddToPlaylist"
        Me.tsbAddToPlaylist.Size = New System.Drawing.Size(32, 32)
        Me.tsbAddToPlaylist.Text = "Add to playlist."
        '
        'lbVerses
        '
        Me.lbVerses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbVerses.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbVerses.Font = New System.Drawing.Font("Cardo", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVerses.FormattingEnabled = True
        Me.lbVerses.HorizontalExtent = 4000
        Me.lbVerses.HorizontalScrollbar = True
        Me.lbVerses.ItemHeight = 20
        Me.lbVerses.Location = New System.Drawing.Point(7, 299)
        Me.lbVerses.Name = "lbVerses"
        Me.lbVerses.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbVerses.Size = New System.Drawing.Size(371, 204)
        Me.lbVerses.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctx1AddVerses, Me.ToolStripSeparator1, Me.ctx1SelectAll})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(229, 54)
        '
        'ctx1AddVerses
        '
        Me.ctx1AddVerses.Name = "ctx1AddVerses"
        Me.ctx1AddVerses.ShortcutKeyDisplayString = "[CTRL + P]"
        Me.ctx1AddVerses.Size = New System.Drawing.Size(228, 22)
        Me.ctx1AddVerses.Text = "Add Verses To Playlist"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(225, 6)
        '
        'ctx1SelectAll
        '
        Me.ctx1SelectAll.Name = "ctx1SelectAll"
        Me.ctx1SelectAll.ShortcutKeyDisplayString = "[CTRL + A]"
        Me.ctx1SelectAll.Size = New System.Drawing.Size(228, 22)
        Me.ctx1SelectAll.Text = "Select All"
        '
        'lbChapters
        '
        Me.lbChapters.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbChapters.ColumnWidth = 30
        Me.lbChapters.FormattingEnabled = True
        Me.lbChapters.ItemHeight = 17
        Me.lbChapters.Location = New System.Drawing.Point(276, 6)
        Me.lbChapters.MultiColumn = True
        Me.lbChapters.Name = "lbChapters"
        Me.lbChapters.Size = New System.Drawing.Size(142, 276)
        Me.lbChapters.TabIndex = 1
        '
        'lbBooks
        '
        Me.lbBooks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbBooks.ColumnWidth = 90
        Me.lbBooks.FormattingEnabled = True
        Me.lbBooks.ItemHeight = 17
        Me.lbBooks.Location = New System.Drawing.Point(7, 6)
        Me.lbBooks.MultiColumn = True
        Me.lbBooks.Name = "lbBooks"
        Me.lbBooks.Size = New System.Drawing.Size(263, 276)
        Me.lbBooks.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.cbShowTitle)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.tbTitle)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(424, 512)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Title"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblBannerBorderColor)
        Me.GroupBox1.Controls.Add(Me.lblTitleColor)
        Me.GroupBox1.Controls.Add(Me.lblBannerColor)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.nudBannerBorderSize)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 132)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Colors && Size"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(184, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Border size:"
        '
        'lblBannerBorderColor
        '
        Me.lblBannerBorderColor.BackColor = System.Drawing.Color.Black
        Me.lblBannerBorderColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBannerBorderColor.Location = New System.Drawing.Point(131, 57)
        Me.lblBannerBorderColor.Name = "lblBannerBorderColor"
        Me.lblBannerBorderColor.Size = New System.Drawing.Size(42, 42)
        Me.lblBannerBorderColor.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.lblBannerBorderColor, "Choose the banner border color.")
        '
        'lblTitleColor
        '
        Me.lblTitleColor.BackColor = System.Drawing.Color.Blue
        Me.lblTitleColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitleColor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitleColor.Location = New System.Drawing.Point(19, 57)
        Me.lblTitleColor.Name = "lblTitleColor"
        Me.lblTitleColor.Size = New System.Drawing.Size(42, 42)
        Me.lblTitleColor.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.lblTitleColor, "Choose the title text color.")
        '
        'lblBannerColor
        '
        Me.lblBannerColor.BackColor = System.Drawing.Color.White
        Me.lblBannerColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBannerColor.Location = New System.Drawing.Point(75, 57)
        Me.lblBannerColor.Name = "lblBannerColor"
        Me.lblBannerColor.Size = New System.Drawing.Size(42, 42)
        Me.lblBannerColor.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.lblBannerColor, "Choose the banner fill color.")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(130, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Border:"
        '
        'nudBannerBorderSize
        '
        Me.nudBannerBorderSize.Location = New System.Drawing.Point(187, 74)
        Me.nudBannerBorderSize.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudBannerBorderSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudBannerBorderSize.Name = "nudBannerBorderSize"
        Me.nudBannerBorderSize.Size = New System.Drawing.Size(61, 25)
        Me.nudBannerBorderSize.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.nudBannerBorderSize, "Change the size of the banner border.")
        Me.nudBannerBorderSize.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(74, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Banner:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Title:"
        '
        'cbShowTitle
        '
        Me.cbShowTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbShowTitle.AutoSize = True
        Me.cbShowTitle.Enabled = False
        Me.cbShowTitle.Location = New System.Drawing.Point(356, 50)
        Me.cbShowTitle.Name = "cbShowTitle"
        Me.cbShowTitle.Size = New System.Drawing.Size(58, 21)
        Me.cbShowTitle.TabIndex = 14
        Me.cbShowTitle.Text = "Show"
        Me.ToolTip1.SetToolTip(Me.cbShowTitle, "Displays the sermon title.")
        Me.cbShowTitle.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Add a title to the top of the screen:"
        '
        'tbTitle
        '
        Me.tbTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTitle.Location = New System.Drawing.Point(7, 48)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.Size = New System.Drawing.Size(341, 22)
        Me.tbTitle.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnDeleteSelectedRef)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnClearAllPlaylist)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lvPlaylist)
        Me.SplitContainer2.Panel1MinSize = 175
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.SplitContainer2.Panel2MinSize = 300
        Me.SplitContainer2.Size = New System.Drawing.Size(600, 597)
        Me.SplitContainer2.SplitterDistance = 222
        Me.SplitContainer2.TabIndex = 0
        '
        'btnDeleteSelectedRef
        '
        Me.btnDeleteSelectedRef.Enabled = False
        Me.btnDeleteSelectedRef.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSelectedRef.ForeColor = System.Drawing.Color.Red
        Me.btnDeleteSelectedRef.Location = New System.Drawing.Point(72, 2)
        Me.btnDeleteSelectedRef.Name = "btnDeleteSelectedRef"
        Me.btnDeleteSelectedRef.Size = New System.Drawing.Size(34, 25)
        Me.btnDeleteSelectedRef.TabIndex = 5
        Me.btnDeleteSelectedRef.Text = "X"
        Me.ToolTip1.SetToolTip(Me.btnDeleteSelectedRef, "Deletes the checked reference(s).")
        Me.btnDeleteSelectedRef.UseVisualStyleBackColor = True
        '
        'btnClearAllPlaylist
        '
        Me.btnClearAllPlaylist.AutoSize = True
        Me.btnClearAllPlaylist.Enabled = False
        Me.btnClearAllPlaylist.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAllPlaylist.Location = New System.Drawing.Point(3, 2)
        Me.btnClearAllPlaylist.Name = "btnClearAllPlaylist"
        Me.btnClearAllPlaylist.Size = New System.Drawing.Size(63, 25)
        Me.btnClearAllPlaylist.TabIndex = 4
        Me.btnClearAllPlaylist.Text = "Clear All"
        Me.ToolTip1.SetToolTip(Me.btnClearAllPlaylist, "Clears all references from the playlist.")
        Me.btnClearAllPlaylist.UseVisualStyleBackColor = True
        '
        'lvPlaylist
        '
        Me.lvPlaylist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvPlaylist.CheckBoxes = True
        Me.lvPlaylist.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPlaylist.FullRowSelect = True
        Me.lvPlaylist.GridLines = True
        ListViewGroup1.Header = "ListViewGroup"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "ListViewGroup"
        ListViewGroup2.Name = "ListViewGroup2"
        Me.lvPlaylist.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.lvPlaylist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvPlaylist.HideSelection = False
        Me.lvPlaylist.Location = New System.Drawing.Point(3, 31)
        Me.lvPlaylist.MultiSelect = False
        Me.lvPlaylist.Name = "lvPlaylist"
        Me.lvPlaylist.ShowGroups = False
        Me.lvPlaylist.Size = New System.Drawing.Size(244, 560)
        Me.lvPlaylist.TabIndex = 4
        Me.lvPlaylist.UseCompatibleStateImageBehavior = False
        Me.lvPlaylist.View = System.Windows.Forms.View.List
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer3.Panel1.Controls.Add(Me.pbPreviewScreen)
        Me.SplitContainer3.Panel1MinSize = 250
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.lvBackgroundImages)
        Me.SplitContainer3.Panel2MinSize = 200
        Me.SplitContainer3.Size = New System.Drawing.Size(358, 587)
        Me.SplitContainer3.SplitterDistance = 285
        Me.SplitContainer3.TabIndex = 4
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGoLive, Me.ToolStripSeparator2, Me.tsbClearScreenImage, Me.ToolStripSeparator4, Me.tsbClearText})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(356, 32)
        Me.ToolStrip2.TabIndex = 3
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbGoLive
        '
        Me.tsbGoLive.AutoSize = False
        Me.tsbGoLive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGoLive.Image = CType(resources.GetObject("tsbGoLive.Image"), System.Drawing.Image)
        Me.tsbGoLive.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGoLive.Name = "tsbGoLive"
        Me.tsbGoLive.Size = New System.Drawing.Size(62, 28)
        Me.tsbGoLive.Text = "Go Live"
        Me.tsbGoLive.ToolTipText = "Displays the screen live."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'tsbClearScreenImage
        '
        Me.tsbClearScreenImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbClearScreenImage.Image = CType(resources.GetObject("tsbClearScreenImage.Image"), System.Drawing.Image)
        Me.tsbClearScreenImage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbClearScreenImage.Name = "tsbClearScreenImage"
        Me.tsbClearScreenImage.Size = New System.Drawing.Size(74, 29)
        Me.tsbClearScreenImage.Text = "Clear Image"
        Me.tsbClearScreenImage.ToolTipText = "Clears the background image."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 32)
        '
        'tsbClearText
        '
        Me.tsbClearText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbClearText.Image = CType(resources.GetObject("tsbClearText.Image"), System.Drawing.Image)
        Me.tsbClearText.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbClearText.Name = "tsbClearText"
        Me.tsbClearText.Size = New System.Drawing.Size(63, 29)
        Me.tsbClearText.Text = "Clear Text"
        Me.tsbClearText.ToolTipText = "Clears the text."
        '
        'pbPreviewScreen
        '
        Me.pbPreviewScreen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbPreviewScreen.BackColor = System.Drawing.SystemColors.WindowText
        Me.pbPreviewScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbPreviewScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPreviewScreen.Location = New System.Drawing.Point(3, 42)
        Me.pbPreviewScreen.Name = "pbPreviewScreen"
        Me.pbPreviewScreen.Size = New System.Drawing.Size(350, 238)
        Me.pbPreviewScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPreviewScreen.TabIndex = 0
        Me.pbPreviewScreen.TabStop = False
        '
        'lvBackgroundImages
        '
        Me.lvBackgroundImages.BackColor = System.Drawing.SystemColors.Window
        Me.lvBackgroundImages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvBackgroundImages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvBackgroundImages.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvBackgroundImages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvBackgroundImages.HideSelection = False
        Me.lvBackgroundImages.LargeImageList = Me.ImageList1
        Me.lvBackgroundImages.Location = New System.Drawing.Point(0, 0)
        Me.lvBackgroundImages.MultiSelect = False
        Me.lvBackgroundImages.Name = "lvBackgroundImages"
        Me.lvBackgroundImages.ShowGroups = False
        Me.lvBackgroundImages.Size = New System.Drawing.Size(356, 296)
        Me.lvBackgroundImages.SmallImageList = Me.ImageList1
        Me.lvBackgroundImages.TabIndex = 3
        Me.lvBackgroundImages.TileSize = New System.Drawing.Size(64, 64)
        Me.lvBackgroundImages.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(89, 72)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctx2DeleteSelected})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip2.ShowImageMargin = False
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(130, 26)
        '
        'ctx2DeleteSelected
        '
        Me.ctx2DeleteSelected.Name = "ctx2DeleteSelected"
        Me.ctx2DeleteSelected.Size = New System.Drawing.Size(129, 22)
        Me.ctx2DeleteSelected.Text = "Delete Selected"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1042, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.WordofGodBibleProjector.My.Resources.Resources.exitLight
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 38)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBackgroundImagesToolStripMenuItem, Me.ToolStripSeparator5, Me.PreferencesToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(52, 21)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'AddBackgroundImagesToolStripMenuItem
        '
        Me.AddBackgroundImagesToolStripMenuItem.Image = Global.WordofGodBibleProjector.My.Resources.Resources.addImageLight
        Me.AddBackgroundImagesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddBackgroundImagesToolStripMenuItem.Name = "AddBackgroundImagesToolStripMenuItem"
        Me.AddBackgroundImagesToolStripMenuItem.Size = New System.Drawing.Size(236, 38)
        Me.AddBackgroundImagesToolStripMenuItem.Text = "&Add background images"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(233, 6)
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Image = Global.WordofGodBibleProjector.My.Resources.Resources.settingsLight
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(236, 38)
        Me.PreferencesToolStripMenuItem.Text = "&Preferences"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShortcutKeysToolStripMenuItem, Me.ToolStripSeparator6, Me.AboutToolStripMenuItem, Me.SubmitBugReportFeedbackToolStripMenuItem, Me.ToolStripSeparator3, Me.DonateToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(47, 21)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ShortcutKeysToolStripMenuItem
        '
        Me.ShortcutKeysToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoLiveCTRLLToolStripMenuItem, Me.AddToPlaylistCTRLAToolStripMenuItem, Me.FindReferenceCTRLRToolStripMenuItem, Me.OptionsCTRLOToolStripMenuItem, Me.AddImageCTRLIToolStripMenuItem})
        Me.ShortcutKeysToolStripMenuItem.Image = Global.WordofGodBibleProjector.My.Resources.Resources.keyboardLight
        Me.ShortcutKeysToolStripMenuItem.Name = "ShortcutKeysToolStripMenuItem"
        Me.ShortcutKeysToolStripMenuItem.Size = New System.Drawing.Size(262, 38)
        Me.ShortcutKeysToolStripMenuItem.Text = "&Global Shortcut Keys"
        '
        'GoLiveCTRLLToolStripMenuItem
        '
        Me.GoLiveCTRLLToolStripMenuItem.Enabled = False
        Me.GoLiveCTRLLToolStripMenuItem.Name = "GoLiveCTRLLToolStripMenuItem"
        Me.GoLiveCTRLLToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.GoLiveCTRLLToolStripMenuItem.Text = "Go Live = CTRL + L"
        '
        'AddToPlaylistCTRLAToolStripMenuItem
        '
        Me.AddToPlaylistCTRLAToolStripMenuItem.Enabled = False
        Me.AddToPlaylistCTRLAToolStripMenuItem.Name = "AddToPlaylistCTRLAToolStripMenuItem"
        Me.AddToPlaylistCTRLAToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.AddToPlaylistCTRLAToolStripMenuItem.Text = "Add to playlist = CTRL + P"
        '
        'FindReferenceCTRLRToolStripMenuItem
        '
        Me.FindReferenceCTRLRToolStripMenuItem.Enabled = False
        Me.FindReferenceCTRLRToolStripMenuItem.Name = "FindReferenceCTRLRToolStripMenuItem"
        Me.FindReferenceCTRLRToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.FindReferenceCTRLRToolStripMenuItem.Text = "Find reference = CTRL + R"
        '
        'OptionsCTRLOToolStripMenuItem
        '
        Me.OptionsCTRLOToolStripMenuItem.Enabled = False
        Me.OptionsCTRLOToolStripMenuItem.Name = "OptionsCTRLOToolStripMenuItem"
        Me.OptionsCTRLOToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.OptionsCTRLOToolStripMenuItem.Text = "Options = CTRL + O"
        '
        'AddImageCTRLIToolStripMenuItem
        '
        Me.AddImageCTRLIToolStripMenuItem.Enabled = False
        Me.AddImageCTRLIToolStripMenuItem.Name = "AddImageCTRLIToolStripMenuItem"
        Me.AddImageCTRLIToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.AddImageCTRLIToolStripMenuItem.Text = "Add image = CTRL + I"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(259, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.WordofGodBibleProjector.My.Resources.Resources.aboutLight
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(262, 38)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'SubmitBugReportFeedbackToolStripMenuItem
        '
        Me.SubmitBugReportFeedbackToolStripMenuItem.Image = Global.WordofGodBibleProjector.My.Resources.Resources.bug100
        Me.SubmitBugReportFeedbackToolStripMenuItem.Name = "SubmitBugReportFeedbackToolStripMenuItem"
        Me.SubmitBugReportFeedbackToolStripMenuItem.Size = New System.Drawing.Size(262, 38)
        Me.SubmitBugReportFeedbackToolStripMenuItem.Text = "&Submit Bug Report/Feedback"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(259, 6)
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Image = Global.WordofGodBibleProjector.My.Resources.Resources.donatePaypalLight
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(262, 38)
        Me.DonateToolStripMenuItem.Text = "&Donate"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 7000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 20
        '
        'ImageListFullSize
        '
        Me.ImageListFullSize.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageListFullSize.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageListFullSize.TransparentColor = System.Drawing.Color.Transparent
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "All images|*.gif; *.jpg; *.bmp; *.png"
        '
        'MainForm
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 624)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Word of GOD -  Bible Projector  -  [Alpha Release]"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.tabctrlBible.ResumeLayout(False)
        Me.tabpageBible.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudBannerBorderSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.pbPreviewScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents tabctrlBible As System.Windows.Forms.TabControl
    Friend WithEvents tabpageBible As System.Windows.Forms.TabPage
    Friend WithEvents lbVerses As System.Windows.Forms.ListBox
    Friend WithEvents lbChapters As System.Windows.Forms.ListBox
    Friend WithEvents lbBooks As System.Windows.Forms.ListBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ctx1AddVerses As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lvPlaylist As System.Windows.Forms.ListView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pbPreviewScreen As System.Windows.Forms.PictureBox
    Friend WithEvents btnClearAllPlaylist As System.Windows.Forms.Button
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lvBackgroundImages As System.Windows.Forms.ListView
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents ImageListFullSize As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ctx1SelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDeleteSelectedRef As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAddToPlaylist As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGoLive As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbClearScreenImage As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbReference As System.Windows.Forms.TextBox
    Friend WithEvents lblRefInfo As System.Windows.Forms.Label
    Friend WithEvents btnRefGo As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblTitleColor As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents lblBannerColor As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblBannerBorderColor As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nudBannerBorderSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbShowTitle As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbClearText As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ctx2DeleteSelected As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ShortcutKeysToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindReferenceCTRLRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToPlaylistCTRLAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoLiveCTRLLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsCTRLOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddBackgroundImagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DonateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddImageCTRLIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SubmitBugReportFeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator

End Class
