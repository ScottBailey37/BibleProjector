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
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Net.Mail

Public Class MainForm

    Private _Bible As New Bible("KJV")
    Private Playlist As New List(Of Slide)
    Private previewScreenBackgroundImage As Bitmap
    Friend Use3DRendering As Boolean = True
    Private backgroundImagesPath As String = My.Application.Info.DirectoryPath
    Private delimiter As String = vbTab

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ReferenceHelp.RichTextBox1.Rtf = My.Resources.ReferenceFormatString

        ' Load user settings first
        LoadSettings()
        pbPreviewScreen.AllowDrop = True



        Dim exScrBounds As Rectangle = ExtendedScreenBounds() ' Get the bounds of the extended or seperate display if any

        ' How many displays do we have?
        If ScreenCount() > 1 Then

            ' Center the preview screen inside its container
            ProjectionScreen.Size = New Size(exScrBounds.Width, exScrBounds.Height)
            pbPreviewScreen.Size = New Size(Convert.ToInt32(exScrBounds.Width * 0.2), Convert.ToInt32(exScrBounds.Height * 0.2))
            Dim y As Integer = ((SplitContainer3.Panel1.Height / 2) - pbPreviewScreen.Height / 2) + (ToolStrip2.Height / 2)
            pbPreviewScreen.Location = New Point((SplitContainer3.Panel1.Width \ 2 - pbPreviewScreen.Width \ 2), y) 'pbPreviewScreen.Location.Y)
        Else
            MsgBox("Extended display does not exist." + Environment.NewLine + "However, the preview screen is still available." + Chr(13) + Chr(13) + _
                   "Any display changes will take effect on the next restart.", MsgBoxStyle.Information)

            ' Center the preview screen inside its container
            ProjectionScreen.Size = New Size(exScrBounds.Width, exScrBounds.Height)
            pbPreviewScreen.Size = New Size(Convert.ToInt32(exScrBounds.Width * 0.2), Convert.ToInt32(exScrBounds.Height * 0.2))
            Dim y As Integer = ((SplitContainer3.Panel1.Height / 2) - pbPreviewScreen.Height / 2) + (ToolStrip2.Height / 2)
            pbPreviewScreen.Location = New Point((SplitContainer3.Panel1.Width \ 2 - pbPreviewScreen.Width \ 2), y) 'pbPreviewScreen.Location.Y)


            ' There is only a single display so disable the Go Live button
            tsbGoLive.Enabled = False
        End If

        ' *****************
        ' TODO: For now we are only using the 'KJV' of the bible so the below
        ' statement will suffice but future plans are to include several translations
        ' with the software in which case the code below will have to be rewritten to
        ' search for and successfully load any authentic translations it finds.
        ' ******************

        ' Load the bible and setup its books, chapters, and verses.
        If LoadBible(My.Application.Info.DirectoryPath + "\KJV.txt") = True Then
            LoadBooks()
            Loadchapters()
            lbBooks.SelectedIndex = 0
            lbChapters.SelectedIndex = 0

            ' Load any background images that are available
            LoadImages(backgroundImagesPath)
        Else
            'TODO:  
            '       IF WE CANT LOAD A BIBLE THEN PROBABLY EXIT APPLICATION
        End If

        ' ToolStrip1.ImageScalingSize = New Size(60, 60)
    End Sub


#Region "Control Events"

#Region "Main Menu"
    Private Sub PreferencesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PreferencesToolStripMenuItem.Click
        Preferences.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub AddBackgroundImagesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddBackgroundImagesToolStripMenuItem.Click
        Try
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                If File.Exists(OpenFileDialog1.FileName) Then
                    IO.File.Copy(OpenFileDialog1.FileName, backgroundImagesPath + "\" + OpenFileDialog1.SafeFileName, True)


                    Dim bmp As Bitmap = Image.FromFile(backgroundImagesPath + "\" + OpenFileDialog1.SafeFileName)
                    ImageListFullSize.Images.Add(backgroundImagesPath + "\" + OpenFileDialog1.SafeFileName, bmp)
                    ImageList1.Images.Add(backgroundImagesPath + "\" + OpenFileDialog1.SafeFileName, bmp)

                    lvBackgroundImages.Items.Add("Image " + (lvBackgroundImages.Items.Count + 1).ToString, lvBackgroundImages.Items.Count)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DonateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DonateToolStripMenuItem.Click
        If My.Computer.Network.IsAvailable Then
            Dim url As String = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=CHXJ4H5FNLPQ4"
            Process.Start(url)
        Else
            MsgBox("There is no network connection.")
        End If
    End Sub
#End Region

#Region "Context Menus"
#Region "Context Menu 1 Events"
    Private Sub ctx1AddVerses_Click(sender As System.Object, e As System.EventArgs) Handles ctx1AddVerses.Click
        AddToPlaylist()
    End Sub

    Private Sub ctx1SelectAll_Click(sender As System.Object, e As System.EventArgs) Handles ctx1SelectAll.Click
        SelectAllVerses()
    End Sub

    Private Sub SelectAllVerses()
        Try
            For i As Integer = 0 To lbVerses.Items.Count - 1
                lbVerses.SetSelected(i, True)
            Next
        Catch ex As Exception
            MsgBox("SelectAllVerses:" + Chr(13) + ex.Message)
        End Try

    End Sub
#End Region

#Region "Context Menu 2 Events"

    Private Sub ctx2DeleteSelected_Click(sender As System.Object, e As System.EventArgs) Handles ctx2DeleteSelected.Click
        If lvPlaylist.SelectedItems.Count > 0 Then
            Playlist.RemoveAt(lvPlaylist.SelectedItems.Item(0).Index)
            lvPlaylist.Items.RemoveAt(lvPlaylist.SelectedItems.Item(0).Index)

            ' If the user deletes the last item with the context menu 
            ' then disable the 'ClearAll' button (it gets enabled when they add more items)
            If lvPlaylist.Items.Count = 0 Then
                btnClearAllPlaylist.Enabled = False
            End If
        End If
    End Sub

#End Region
#End Region

#Region "Toolstrips"
    Private Sub tsbClearText_Click(sender As System.Object, e As System.EventArgs) Handles tsbClearText.Click
        Try
            ' lvPlaylist.SelectedItems.Clear()

            ProjectionScreen.DisplayPanel1.CurrentSlide = New Slide
            ProjectionScreen.DisplayPanel1.Invalidate()
            ProjectionScreen.DisplayPanel1.Update()

            ' Update the preview screen
            PreviewScreenDraw()
        Catch ex As Exception
            MsgBox(System.Reflection.MethodInfo.GetCurrentMethod.Name + Environment.NewLine + ex.Message)
        End Try
    End Sub

    Private Sub tsbAddToPlaylist_Click(sender As System.Object, e As System.EventArgs) Handles tsbAddToPlaylist.Click
        AddToPlaylist()
    End Sub

    Private Sub tsbGoLive_Click(sender As System.Object, e As System.EventArgs) Handles tsbGoLive.Click
        GoLive() ' Show the projection screen
        Me.Focus() ' Set focus back to the parent form
    End Sub

    Private Sub tsbClearScreenImage_Click(sender As System.Object, e As System.EventArgs) Handles tsbClearScreenImage.Click
        pbPreviewScreen.BackgroundImage = Nothing
        ProjectionScreen.DisplayPanel1.BackgroundImage = Nothing
    End Sub

    Private Sub tsbClearVerses_Click(sender As System.Object, e As System.EventArgs)
        'ProjectionScreen.DisplayPanel1.CurrentSlide.Reference.Verses.Clear()
    End Sub
#End Region

#Region "ListBox Events"
    Private Sub lbBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbBooks.SelectedIndexChanged
        lbChapters.Items.Clear()
        Dim index As Integer
        For Each b As Book In _Bible.Books
            If lbBooks.SelectedItem = b.Name Then
                For Each chp As Chapter In _Bible.Books(index).Chapters
                    lbChapters.Items.Add(chp.ChapterNumber.ToString)
                Next
            End If
            index += 1
        Next

        ' Select the first chapter of the book
        lbChapters.SelectedIndex = 0
    End Sub

    Private Sub lbChapters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbChapters.SelectedIndexChanged
        If lbChapters.SelectedItem IsNot Nothing Then
            LoadVerses(lbBooks.SelectedIndex, lbChapters.SelectedIndex)
            lbVerses.SetSelected(0, True)
        End If
    End Sub

    Private Sub lbVerses_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lbVerses.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If lbVerses.SelectedItems.Count > 0 Then
                ContextMenuStrip1.Enabled = True
            Else
                ContextMenuStrip1.Enabled = False
            End If
        End If
    End Sub

#End Region

#Region "ListView Events"

    Private Sub lvPlaylist_ItemSelectionChanged(sender As System.Object, e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvPlaylist.ItemSelectionChanged
        ' Only allow the left mouse button and default keys
        Select Case Control.MouseButtons
            Case Windows.Forms.MouseButtons.Left ' User clicked the Left mouse button
                ChangeSlide()
            Case Windows.Forms.MouseButtons.None ' User pressed a key
                ChangeSlide()
        End Select
    End Sub

    Private Sub lvPlaylist_ItemChecked(sender As System.Object, e As System.Windows.Forms.ItemCheckedEventArgs) Handles lvPlaylist.ItemChecked
        If lvPlaylist.CheckedItems.Count > 0 Then
            btnDeleteSelectedRef.Enabled = True
        Else
            btnDeleteSelectedRef.Enabled = False
        End If
    End Sub

    Private Sub lvPlaylist_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lvPlaylist.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then ' Right button only
            If lvPlaylist.FocusedItem IsNot Nothing Then ' Prevent no instance exception if there isn't an item selected
                If lvPlaylist.FocusedItem.Bounds.Contains(e.Location) Then ' Only allow context menu when clicking actual item
                    ContextMenuStrip2.Show(Cursor.Position) ' Show the context menu at the mouse cursor position
                End If
            End If
        End If
    End Sub

    Private Sub lvBackgroundImages_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lvBackgroundImages.MouseDoubleClick
        If lvBackgroundImages.SelectedItems.Count > 0 Then
            'Panel1.BackgroundImage = Image.FromFile(ImageListFullSize.Images.Keys(lvBackgroundImages.FocusedItem.Index))

            ' previewBackgroundImage = Image.FromFile(ImageListFullSize.Images.Keys(lvBackgroundImages.FocusedItem.Index))
            pbPreviewScreen.BackgroundImageLayout = ImageLayout.Stretch
            pbPreviewScreen.BackgroundImage = Image.FromFile(ImageListFullSize.Images.Keys(lvBackgroundImages.FocusedItem.Index))


            ProjectionScreen.DisplayPanel1.BackgroundImageLayout = ImageLayout.Stretch
            ProjectionScreen.DisplayPanel1.BackgroundImage = Image.FromFile(ImageListFullSize.Images.Keys(lvBackgroundImages.FocusedItem.Index))
        End If
    End Sub

#End Region

#Region "SplitContainer Events"
    Private Sub SplitContainer2_SplitterMoving(sender As System.Object, e As System.Windows.Forms.SplitterCancelEventArgs) Handles SplitContainer2.SplitterMoving
        CenterPreviewScreen()
    End Sub

    Private Sub SplitContainer1_SplitterMoving(sender As System.Object, e As System.Windows.Forms.SplitterCancelEventArgs) Handles SplitContainer1.SplitterMoving
        CenterPreviewScreen()
    End Sub

#End Region

#Region "Button Events"

    Private Sub btnClearAllPlaylist_Click(sender As System.Object, e As System.EventArgs) Handles btnClearAllPlaylist.Click

        If MsgBox("Clear all references from playlist?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Playlist.Clear()
            lvPlaylist.Clear()
            ProjectionScreen.DisplayPanel1.CurrentSlide.Reference.Verses.Clear()

            PreviewScreenDraw()

            ProjectionScreen.DisplayPanel1.Invalidate()
            ProjectionScreen.DisplayPanel1.Update()

            ' Since there are no more references disable btnClearAllPlaylist and btnDeleteSelectedRef
            btnClearAllPlaylist.Enabled = False
            btnDeleteSelectedRef.Enabled = False
        End If

    End Sub

    Private Sub btnDeleteSelectedRef_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteSelectedRef.Click
        DeleteSelectedPlaylistReference()
    End Sub

    Private Sub btnRefGo_Click(sender As System.Object, e As System.EventArgs) Handles btnRefGo.Click
        LoadReference(tbReference.Text)
    End Sub

#End Region

#Region "Label Events"

    Private Sub lblTitleColor_Click(sender As System.Object, e As System.EventArgs) Handles lblTitleColor.Click
        ColorDialog1.Color = lblTitleColor.BackColor
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblTitleColor.BackColor = ColorDialog1.Color

            PreviewScreenDraw()
            ProjectionScreen.DisplayPanel1.Invalidate()
            ProjectionScreen.DisplayPanel1.Update()
        End If
    End Sub

    Private Sub lblBannerColor_Click(sender As System.Object, e As System.EventArgs) Handles lblBannerColor.Click
        ColorDialog1.Color = lblBannerColor.BackColor
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblBannerColor.BackColor = ColorDialog1.Color

            PreviewScreenDraw()
            ProjectionScreen.DisplayPanel1.Invalidate()
            ProjectionScreen.DisplayPanel1.Update()
        End If
    End Sub

    Private Sub lblBannerBorderColor_Click(sender As System.Object, e As System.EventArgs) Handles lblBannerBorderColor.Click
        ColorDialog1.Color = lblBannerBorderColor.BackColor
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblBannerBorderColor.BackColor = ColorDialog1.Color

            PreviewScreenDraw()
            ProjectionScreen.DisplayPanel1.Invalidate()
            ProjectionScreen.DisplayPanel1.Update()
        End If
    End Sub

    Private Sub lblRefInfo_Click(sender As System.Object, e As System.EventArgs) Handles lblRefInfo.Click
        ReferenceHelp.ShowDialog()
    End Sub

#End Region

#Region "NumerUpDown Events"

    Private Sub nudBannerBorderSize_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudBannerBorderSize.ValueChanged
        PreviewScreenDraw()
        ProjectionScreen.DisplayPanel1.Invalidate()
        ProjectionScreen.DisplayPanel1.Update()
    End Sub

#End Region

#Region "Main Form Events"

    Private Sub MainForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' Save all settings upon exit
        My.Settings.RefAlign = ProjectionScreen.DisplayPanel1.PositionOfReference
        My.Settings.TextFont = ProjectionScreen.DisplayPanel1.Font
        My.Settings.TextColor = ProjectionScreen.DisplayPanel1.ForeColor
        My.Settings.NumberVerseSpacing = ProjectionScreen.DisplayPanel1.NumberVerseSpacing
        My.Settings.MarginsLeft = ProjectionScreen.DisplayPanel1.LeftMargin
        My.Settings.MarginsRight = ProjectionScreen.DisplayPanel1.RightMargin
        My.Settings.MarginsTop = ProjectionScreen.DisplayPanel1.TopMargin
        My.Settings.MarginsBottom = ProjectionScreen.DisplayPanel1.BottomMargin
        My.Settings.Use3DRendering = Me.Use3DRendering
        My.Settings.EnableShadows = Drawing3D.ShadowsEnabled
        My.Settings.EnableOutline = Drawing3D.OutlineEnabled
        My.Settings.ShadowColor = Drawing3D.ShadowColor
        My.Settings.OutlineColor = Drawing3D.OutlineColor
        My.Settings.ShadowOffsetX = Drawing3D.ShadowOffset.X
        My.Settings.ShadowOffsetY = Drawing3D.ShadowOffset.Y
        My.Settings.OutlineSize = Drawing3D.OutlineSize
        My.Settings.SpaceBelowRef = ProjectionScreen.DisplayPanel1.SpaceBelowReference
    End Sub

    Private Sub MainForm_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        ' ************* CHECK FOR SHORTCUT KEYS ****************



        ' *********************** GLOBAL KEYS ***********************
        ' Enter a reference
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.R Then
            tbReference.Select()
            tbReference.SelectAll()
        End If

        ' Add to playlist
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.P Then
            Me.tsbAddToPlaylist.PerformClick()
        End If

        ' Go Live 
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.L Then
            Me.tsbGoLive.PerformClick()
        End If

        ' Options Dialog 
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.O Then
            Me.PreferencesToolStripMenuItem.PerformClick()
        End If

        ' Add image Dialog 
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.I Then
            Me.AddBackgroundImagesToolStripMenuItem.PerformClick()
        End If
        ' ***********************************************************



        ' The Select All shortcut for the verses
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.A Then
            ' Only all selection if the verses control has focus
            If lbVerses.Focused Then
                SelectAllVerses()
            End If
        End If
    End Sub

#End Region

#Region "TextBox Events"

    Private Sub tbTitle_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbTitle.TextChanged
        If tbTitle.Text <> "" Then
            cbShowTitle.Enabled = True
        Else
            cbShowTitle.Enabled = False
        End If
    End Sub

    Private Sub tbReference_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbReference.KeyPress
        Dim DisallowedCharacters As String = """<>/\?_=*@!#$%&()'~`{}^¨|°¬+[]^¨"
        If InStr(DisallowedCharacters, e.KeyChar) > 0 Then
            'MsgBox("Invalid key.")
            e.Handled = True
        End If
    End Sub

    Private Sub tbReference_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbReference.TextChanged
        If tbReference.Text <> "" Then
            btnRefGo.Enabled = True
        Else
            btnRefGo.Enabled = False
        End If
    End Sub

    Private Sub tbReference_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles tbReference.KeyDown
        If tbReference.Text <> "" Then
            If e.KeyCode = Keys.Enter Then
                LoadReference(tbReference.Text)
            End If
        End If
    End Sub

#End Region

#Region "CheckBox Events"

    Private Sub cbShowTitle_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbShowTitle.CheckedChanged
        If cbShowTitle.CheckState = CheckState.Checked Then
            ProjectionScreen.DisplayPanel1.sermonTitle = tbTitle.Text
            tbTitle.Enabled = False
        Else
            ProjectionScreen.DisplayPanel1.sermonTitle = ""
            tbTitle.Enabled = True
        End If

        PreviewScreenDraw()
        ProjectionScreen.DisplayPanel1.Invalidate()
        ProjectionScreen.DisplayPanel1.Update()
    End Sub

#End Region

#End Region

#Region "Subroutines"
    Friend Sub GoLive()
        Try
            If ProjectionScreen.Visible = False Then
                tsbGoLive.BackColor = Color.Red
                Dim b As Rectangle = ExtendedScreenBounds()
                ProjectionScreen.SetBounds(b.X, b.Y, b.Width, b.Height)
                ProjectionScreen.Show()
            Else
                ProjectionScreen.Hide()
                tsbGoLive.BackColor = SystemColors.ControlLight
            End If
        Catch ex As Exception
            MsgBox(System.Reflection.MethodInfo.GetCurrentMethod.Name + Environment.NewLine + ex.Message)
        End Try
    End Sub

    Private Sub LoadBooks()
        For Each b As Book In _Bible.Books
            lbBooks.Items.Add(b.Name)
        Next
    End Sub

    Private Sub Loadchapters(Optional ByVal bookNumber As Integer = 0)
        ' Get the chapters of the first book "Genesis"
        For Each chp As Chapter In _Bible.Books(bookNumber).Chapters
            lbChapters.Items.Add(chp.ChapterNumber.ToString)
        Next
    End Sub

    Private Sub LoadVerses(Optional ByVal bookNumber As Integer = 0, Optional ByVal chapterNumber As Integer = 0)
        lbVerses.Items.Clear()
        'lbVerses.Items.Clear()

        For Each v As Verse In _Bible.Books(bookNumber).Chapters(chapterNumber).Verses
            ' lbVerses.Items.Add("(" + v.Number.ToString + ")" + "  " + v.Text.Trim("""") + Chr(13))
            lbVerses.Items.Add(v.Number.ToString + ".   " + v.Text.Trim("""") + Chr(13))
        Next
    End Sub

    ''' <summary>
    ''' Formats and adds the selected bible verses to the playlist.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AddToPlaylist()
        Try
            If lbVerses.SelectedItems.Count > 0 Then
                ' Get the verse numbers of all selected verses so that we can format the reference string.
                Dim numbers(lbVerses.SelectedIndices.Count - 1) As Integer
                For i As Integer = 0 To lbVerses.SelectedIndices.Count - 1
                    numbers(i) = lbVerses.SelectedIndices(i) + 1
                Next
                ' Get all verses selected in the verses listbox and 
                ' add each one as a reference to 'Playlist'
                Dim refStr As String = ""
                Dim Ref As New Reference
                Dim slide As New Slide

                Dim g As Graphics = Me.CreateGraphics
                Dim f As Font = ProjectionScreen.DisplayPanel1.Font
                Dim totalVerseHeight As Integer
                Dim verseDisplayRect As Rectangle = ProjectionScreen.DisplayPanel1.VerseDisplayRectangle
                Dim verseSz As SizeF
                Dim refSz As SizeF
                Dim maxHeight As Integer

                Dim v As New Verse
                Dim frmtdVerse() As String
                'Dim verseNum As Integer

                For i As Integer = 0 To lbVerses.SelectedItems.Count - 1
                    v = New Verse
                    v.Version = "KJV"
                    v.Book = lbBooks.SelectedItem
                    v.Chapter = lbChapters.SelectedItem
                    frmtdVerse = FormatVerse(lbVerses.SelectedItems(i))

                    v.Number = frmtdVerse(0).Trim(".")
                    v.Text = frmtdVerse(1)

                    ' Format the reference string 
                    refStr = v.Book + "  " + v.Chapter + ":" + FormatReferenceSequence(numbers)

                    refSz = g.MeasureString(refStr, f, verseDisplayRect.Width)
                    maxHeight = (verseDisplayRect.Height - ProjectionScreen.DisplayPanel1.SpaceBelowReference) - refSz.Height
                    verseSz = g.MeasureString(v.Text, f, verseDisplayRect.Width)

                    'verseNum += 1

                    ' *** IF THE VERSE IS LARGER THAN THE DISPLAY AND WONT FIT ***
                    If (totalVerseHeight + verseSz.Height) >= maxHeight Then
                        slide.Reference.Version = v.Version
                        slide.Reference.Book = v.Book
                        slide.Reference.Chapter = v.Chapter

                        Playlist.Add(slide)

                        ' ***************************************************************************************************
                        ' ** THERE IS A BUG HERE IF USER SELECTS ONLY 1 VERSE AND THAT VERSE IS LARGER THAN THE DISPLAY. **
                        Dim n(slide.Reference.Verses.Count - 1) As Integer
                        For j As Integer = 0 To slide.Reference.Verses.Count - 1

                            n(j) = CInt(slide.Reference.Verses(j).Number)
                        Next
                        'Dim n(lbVerses.SelectedIndices.Count - 1) As Integer
                        'For J As Integer = 0 To lbVerses.SelectedIndices.Count - 1
                        '    n(i) = lbVerses.SelectedIndices(i) + 1
                        'Next

                        Dim subRefStr As String = v.Book + "  " + v.Chapter + ":" + FormatReferenceSequence(n)

                        slide = New Slide
                        totalVerseHeight = 0
                        totalVerseHeight += verseSz.Height
                        slide.Reference.Verses.Add(v)


                        lvPlaylist.Items.Add(subRefStr)
                        'MsgBox("One or more of the selected versers will not fit on the display." + Chr(13) + _
                        '       "Change your font to a smaller size and trya again.")


                    Else
                        ' THE VERSE WILL FIT ON THE DISPLAY
                        totalVerseHeight += verseSz.Height
                        slide.Reference.Verses.Add(v)
                    End If

                Next

                Playlist.Add(slide)

                Dim m(slide.Reference.Verses.Count - 1) As Integer
                For j As Integer = 0 To slide.Reference.Verses.Count - 1
                    m(j) = CInt(slide.Reference.Verses(j).Number)
                Next

                Dim lastRefStr As String = v.Book + "  " + v.Chapter + ":" + FormatReferenceSequence(m)
                lvPlaylist.Items.Add(lastRefStr)


                ' Reset the Clear all playlist button as well as the context menu delete 
                btnClearAllPlaylist.Enabled = True
                ctx2DeleteSelected.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(System.Reflection.MethodInfo.GetCurrentMethod.Name + Environment.NewLine + ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Retrieves the settings located in the application settings file
    ''' and updates the application controls.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadSettings()
        ProjectionScreen.DisplayPanel1.PositionOfReference = My.Settings.RefAlign
        ProjectionScreen.DisplayPanel1.Font = My.Settings.TextFont
        ProjectionScreen.DisplayPanel1.ForeColor = My.Settings.TextColor
        ProjectionScreen.DisplayPanel1.NumberVerseSpacing = My.Settings.NumberVerseSpacing
        ProjectionScreen.DisplayPanel1.LeftMargin = My.Settings.MarginsLeft
        ProjectionScreen.DisplayPanel1.RightMargin = My.Settings.MarginsRight
        ProjectionScreen.DisplayPanel1.TopMargin = My.Settings.MarginsTop
        ProjectionScreen.DisplayPanel1.BottomMargin = My.Settings.MarginsBottom
        Me.Use3DRendering = My.Settings.Use3DRendering
        Drawing3D.ShadowsEnabled = My.Settings.EnableShadows
        Drawing3D.OutlineEnabled = My.Settings.EnableOutline
        Drawing3D.ShadowColor = My.Settings.ShadowColor
        Drawing3D.OutlineColor = My.Settings.OutlineColor
        Drawing3D.ShadowOffset = New Point(My.Settings.ShadowOffsetX, My.Settings.ShadowOffsetY)
        Drawing3D.OutlineSize = My.Settings.OutlineSize
        ProjectionScreen.DisplayPanel1.SpaceBelowReference = My.Settings.SpaceBelowRef

    End Sub

    ''' <summary>
    ''' Centers the preview screen horizontally and vertically with its container.
    ''' This gets called whenever the user resizes the form or controls.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CenterPreviewScreen()
        Try
            Dim x As Integer = SplitContainer3.Panel1.Width / 2 - pbPreviewScreen.Width / 2
            pbPreviewScreen.Location = New Point(x, pbPreviewScreen.Location.Y)
        Catch ex As Exception
            MsgBox(System.Reflection.MethodInfo.GetCurrentMethod.Name + Environment.NewLine + ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' The drawing for the preview screen.
    ''' </summary>
    ''' <remarks></remarks>
    Friend Sub PreviewScreenDraw()
        Dim destBitmap As New Bitmap(ProjectionScreen.DisplayPanel1.DisplayRectangle.Width, ProjectionScreen.DisplayPanel1.DisplayRectangle.Height)
        Dim grfx As Graphics = Graphics.FromImage(destBitmap)


        Try
            Dim verseTextRect As Rectangle = ProjectionScreen.DisplayPanel1.DisplayRectangle
            Dim verseNumRect As Rectangle = ProjectionScreen.DisplayPanel1.DisplayRectangle
            Dim refRect As Rectangle = ProjectionScreen.DisplayPanel1.DisplayRectangle

            If ProjectionScreen.DisplayPanel1.CurrentSlide.Reference.Verses.Count > 0 Then
                ' DRAW THE REFERENCE VERSION, BOOK, CHAPTER, VERSE(S)


                ' *********************************** FORMAT THE REFERENCE ***********************************
                Dim ref As String = ""
                ' If more than 1 verse is to be displayed then we need to show that in the reference.
                ' i.e (Genesis 1:1-4)
                Dim numbers(ProjectionScreen.DisplayPanel1.CurrentSlide.Reference.Verses.Count - 1) As Integer
                For i As Integer = 0 To ProjectionScreen.DisplayPanel1.CurrentSlide.Reference.Verses.Count - 1
                    numbers(i) = CInt(ProjectionScreen.DisplayPanel1.CurrentSlide.Reference.Verses(i).Number)
                Next
                ref = ProjectionScreen.DisplayPanel1.CurrentSlide.Reference.Verses(0).Book + "  " + ProjectionScreen.DisplayPanel1.CurrentSlide.Reference.Verses(0).Chapter + ":" + FormatReferenceSequence(numbers)
                ' ********************************************************************************************

                ' **************************************** REFERENCE *********************************************
                refRect.Y += ProjectionScreen.DisplayPanel1.TopMargin  ' THE Y-POSITION OF THE REFERENCE ONLY

                ' If the user has turned on the sermon title
                ' then we need to adjust everything so that the
                ' reference doesn't get drawn over by the sermon title
                ' as well as move the verse numbers and text down
                If ProjectionScreen.DisplayPanel1.sermonTitle <> "" Then
                    refRect.Y += 75 ' Value of 100 needs changed to a variable that can be set in options
                    verseNumRect.Y += 75
                    verseTextRect.Y += 75
                End If

                ' If a title has been made available then draw it 
                If ProjectionScreen.DisplayPanel1.sermonTitle <> "" Then
                    Dim f As Font = ProjectionScreen.DisplayPanel1.Font ', 54) ' NEED A DYNAMIC USER SUPPLIED FONT SIZE
                    Dim bmp As New Bitmap(ProjectionScreen.DisplayPanel1.Width, 75)
                    Dim bmpRect As New Rectangle(0, 0, bmp.Width, bmp.Height)
                    Dim titleSize As SizeF = grfx.MeasureString(ProjectionScreen.DisplayPanel1.sermonTitle, f, bmpRect.Width, StringFormat.GenericTypographic)

                    Dim x As Integer = (bmpRect.Width / 2) - (titleSize.Width / 2)
                    grfx.FillRectangle(New SolidBrush(Me.lblBannerColor.BackColor), bmpRect)
                    grfx.DrawRectangle(New Pen(Me.lblBannerBorderColor.BackColor, Me.nudBannerBorderSize.Value), bmpRect)



                    bmpRect = New Rectangle(x, 0, bmp.Width, bmp.Height)

                    'If MainForm.Use3DRendering Then
                    'Drawing3D.Draw(e.Graphics, sermonTitle, f, MainForm.lblTitleColor.BackColor, bmpRect)
                    'Else
                    grfx.DrawString(ProjectionScreen.DisplayPanel1.sermonTitle, f, New SolidBrush(Me.lblTitleColor.BackColor), bmpRect)
                    'End If

                End If

                ' DRAW THE REFERENCE ACCORDING TO ALIGNMENT
                If ProjectionScreen.DisplayPanel1.PositionOfReference = DisplayPanel.Alignment.Left Then ' ** LEFT **
                    ' ***** Do nothing because refRect is already setup for Left alignment. *****
                ElseIf ProjectionScreen.DisplayPanel1.PositionOfReference = DisplayPanel.Alignment.Center Then ' ** CENTER **
                    Dim posX As Integer = (refRect.Width / 2) - (grfx.MeasureString(ref, ProjectionScreen.DisplayPanel1.Font).Width / 2)
                    refRect = New Rectangle(posX, refRect.Y, refRect.Width, refRect.Height)
                    ' e.Graphics.DrawString(ref, Me.Font, New SolidBrush(Color.Black), New Rectangle(posX, refRect.Y, refRect.Width, refRect.Height))
                ElseIf ProjectionScreen.DisplayPanel1.PositionOfReference = DisplayPanel.Alignment.Right Then ' ** RIGHT **
                    Dim posX As Integer = refRect.Width - grfx.MeasureString(ref, ProjectionScreen.DisplayPanel1.Font).Width
                    refRect = New Rectangle(posX, refRect.Y, refRect.Width, refRect.Height)
                    ' e.Graphics.DrawString(ref, Me.Font, New SolidBrush(Color.Black), New Rectangle(posX, refRect.Y, refRect.Width, refRect.Height))
                End If

                If Use3DRendering Then
                    Drawing3D.Draw(grfx, ref, ProjectionScreen.DisplayPanel1.Font, ProjectionScreen.DisplayPanel1.ForeColor, refRect)
                Else
                    grfx.DrawString(ref, ProjectionScreen.DisplayPanel1.Font, New SolidBrush(ProjectionScreen.DisplayPanel1.ForeColor), refRect)
                End If


                ' *************************************************************************************************



                ' ********* SETUP DISPLAY COORDINATES FOR THE REFERENCE, VERSE NUMBER, AND VERSE TEXT *********
                verseTextRect.X += ProjectionScreen.DisplayPanel1.NumberVerseSpacing ' THE X-POSITION OF THE VERSE TEXT ONLY
                verseTextRect.Y += (ProjectionScreen.DisplayPanel1.TopMargin + ProjectionScreen.DisplayPanel1.SpaceBelowReference) ' THE Y-POSITION OF THE VERSE TEXT ONLY
                verseNumRect.Y += (ProjectionScreen.DisplayPanel1.TopMargin + ProjectionScreen.DisplayPanel1.SpaceBelowReference) ' THE Y-POSITION OF THE VERSE NUMBER ONLY
                verseTextRect.Width -= (verseTextRect.X + ProjectionScreen.DisplayPanel1.RightMargin) '100 ' THE RIGHT MARGIN FOR THE VERSE TEXT ONLY
                ' *********************************************************************************************



                ' ******************** DRAW ALL VERSE NUMBERS AND VERSE TEXT ********************
                Dim verseSize As SizeF
                Dim text As String = ""
                Dim num As String = ""

                For i As Integer = 0 To ProjectionScreen.DisplayPanel1.CurrentSlide.Reference.Verses.Count - 1
                    text = ProjectionScreen.DisplayPanel1.CurrentSlide.Reference.Verses(i).Text
                    num = ProjectionScreen.DisplayPanel1.CurrentSlide.Reference.Verses(i).Number + "."

                    '' MEASURE THE WIDTH OF THE VERSE TEXT IN PIXELS
                    verseSize = grfx.MeasureString(text, ProjectionScreen.DisplayPanel1.Font, verseTextRect.Width)


                    ' DRAW THE CURRENT VERSE NUMBER
                    If Use3DRendering Then
                        Drawing3D.Draw(grfx, num, ProjectionScreen.DisplayPanel1.Font, ProjectionScreen.DisplayPanel1.ForeColor, verseNumRect)
                    Else
                        grfx.DrawString(num, ProjectionScreen.DisplayPanel1.Font, New SolidBrush(ProjectionScreen.DisplayPanel1.ForeColor), verseNumRect)
                    End If

                    ' DRAW THE CURRENT VERSE TEXT
                    If Use3DRendering Then
                        Drawing3D.Draw(grfx, text, ProjectionScreen.DisplayPanel1.Font, ProjectionScreen.DisplayPanel1.ForeColor, verseTextRect)
                    Else
                        grfx.DrawString(text, ProjectionScreen.DisplayPanel1.Font, New SolidBrush(ProjectionScreen.DisplayPanel1.ForeColor), verseTextRect)
                    End If


                    ' MOVE THE RECTANGLE DOWN PAST THE PREVIOUS VERSE HEIGHT
                    verseNumRect = New Rectangle(verseNumRect.X, verseNumRect.Y + verseSize.Height, verseNumRect.Width, verseNumRect.Height)
                    verseTextRect = New Rectangle(verseTextRect.X, verseTextRect.Y + verseSize.Height, verseTextRect.Width, verseTextRect.Height)

                Next
            End If



            'PictureBox1.Size = New Size(Convert.ToInt32(ProjectionScreen.DisplayPanel1.Width * 0.2), Convert.ToInt32(ProjectionScreen.DisplayPanel1.Height * 0.2))
            pbPreviewScreen.Image = destBitmap
            pbPreviewScreen.Invalidate()
            pbPreviewScreen.Update()
        Catch ex As Exception
            MsgBox(System.Reflection.MethodInfo.GetCurrentMethod.Name + Environment.NewLine + ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Self-explanatory.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DeleteSelectedPlaylistReference()
        Try
            ' Delete all checked items
            If lvPlaylist.CheckedItems.Count > 0 Then
                If MsgBox("Delete selected reference(s)?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim index As Integer
                    For i As Integer = (lvPlaylist.CheckedItems.Count - 1) To 0 Step -1
                        index = lvPlaylist.CheckedItems(i).Index
                        Playlist.RemoveAt(lvPlaylist.CheckedItems(i).Index)
                        lvPlaylist.Items.RemoveAt(lvPlaylist.CheckedItems(i).Index)
                    Next
                    ' Since all checked item were deleted, nothing is checked so disable the Delete button
                    btnDeleteSelectedRef.Enabled = False
                    ' If the last reference has been deleted then disable btnClearAllPlaylist
                    If lvPlaylist.Items.Count = 0 Then
                        btnClearAllPlaylist.Enabled = False
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(System.Reflection.MethodInfo.GetCurrentMethod.Name + Environment.NewLine + ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Loads the background images from the specified directory into the image listview.
    ''' </summary>
    ''' <param name="filepath"></param>
    ''' <remarks></remarks>
    Private Sub LoadImages(filepath As String)
        Try
            If lvBackgroundImages.Items.Count > 0 Then
                lvBackgroundImages.Clear()
            End If

            Dim imgTypes() As String = {"*.gif", "*.jpg", "*.bmp", "*.png"}
            Dim allImages As ObjectModel.ReadOnlyCollection(Of String) = My.Computer.FileSystem.GetFiles(filepath, FileIO.SearchOption.SearchAllSubDirectories, imgTypes)

            Dim bmp As Bitmap

            ' Load the images into the image lists
            For i As Integer = 0 To allImages.Count - 1
                bmp = Image.FromFile(allImages(i))
                ImageListFullSize.Images.Add(allImages(i), bmp)
                ImageList1.Images.Add(allImages(i), bmp)
            Next

            'LoadImagesIntoCustomPanel(ImageList1)

            ' Add a label or empty string
            For i As Integer = 0 To ImageList1.Images.Count - 1
                lvBackgroundImages.Items.Add("", i) '"Image " + (i + 1).ToString
            Next
        Catch ex As Exception
            MsgBox(System.Reflection.MethodInfo.GetCurrentMethod.Name + Environment.NewLine + ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' The main algorithm behind the reference search.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadReference(reference As String)
        Try
            Dim bookname As String = ""
            Dim bookIndex As Integer = -1
            Dim chapter As String = ""
            Dim chapterIndex As Integer = -1

            ' The reference MUST begin with the book name
            If Regex.IsMatch(reference, "[a-zA-Z]") Then
                ' It does so
                ' Get the supplied book name
                bookname = GetBookName(reference)

                bookname = bookname.Replace(" ", "")
                ' Can we find a match in the Bible
                Dim tempBook As String = "" ' Tempory bookname string
                For i As Integer = 0 To _Bible.Books.Count - 1
                    ' We need to remove the space from the bookname incase
                    ' the user supplied a book such as 1pet or 3john
                    tempBook = _Bible.Books(i).Name
                    If tempBook.StartsWith(bookname, StringComparison.OrdinalIgnoreCase) Then
                        ' We found a match so
                        ' Get the match's index number and exit loop
                        bookIndex = i
                        Exit For
                    End If
                Next

                ' Verify that we found a match for the supplied book
                If bookIndex > -1 Then
                    ' Yes the book exists

                    ' *** REMOVE THE BOOKNAME *** 
                    Dim rg As New Regex("^(" + bookname + ")", RegexOptions.IgnorePatternWhitespace)
                    Dim tempRef As String = reference.Replace(" ", "")
                    Dim s As String = rg.Replace(tempRef, "")
                    s = s.TrimStart

                    ' Is a chapter supplied?
                    If Regex.IsMatch(s, "\d") Then
                        ' Yes there are numbers in the string
                        ' Extract the chapter number

                        For Each c As Char In s
                            If Char.IsNumber(c) Then
                                chapter += c.ToString
                            ElseIf Not Char.IsNumber(c) And Not Char.IsLetter(c) And chapter <> "" Then
                                ' We have extracted the chapter
                                ' Exit the loop
                                Exit For
                            End If
                        Next

                        ' We extracted the book and verified its existence in the Bible
                        ' We extracted what we think is the chapter from the string
                        ' Now, verify that the chapter exists
                        For i As Integer = 0 To _Bible.Books(bookIndex).Chapters.Count - 1
                            ' Does the chapter exist?
                            If _Bible.Books(bookIndex).Chapters(i).ChapterNumber = CLng(chapter) Then ' Convert to Long in case user uses to many numbers
                                ' We found a match
                                '   MsgBox("Found chapter " + chapter + " in " + bookname + ".")
                                ' Set the index of the chapter
                                ' and exit the loop
                                chapterIndex = i
                                Exit For

                                ' Have we reached the end without finding a match?
                            ElseIf _Bible.Books(bookIndex).Chapters(i).ChapterNumber = _Bible.Books(bookIndex).Chapters.Count Then
                                '  MsgBox("Could not find chapter " + chapter + " in " + bookname + "." + Chr(13) + "Loading chapter 1 instead.")
                                ' We searched and could not find a chapter match
                                ' But we do have a valid book so just load the book to chapter 1

                                ' *********************** LOAD REFERENCE ***********************
                                ChangeReference(bookIndex, chapterIndex)
                                Exit Sub
                            End If
                        Next

                        ' Remove the book and chapter section of the reference
                        Dim startIndex As Integer = reference.IndexOf(":") + 1
                        Dim length As Integer = reference.Length - startIndex
                        Dim versesOnly As String = reference.Substring(startIndex, length)
                        Dim verses() As String

                        ' We extracted and found a book match
                        ' We extracted and found a chapter match within the book
                        ' Now, did the user supply any verses?
                        verses = GetVerses(versesOnly)
                        If verses.Length = 0 Then
                            ' There were no verses supplied so
                            ' We will just load the matched book and matched chapter
                            ' But will not select any verses
                            ' MsgBox("No verses were supplied." + Chr(13) + "Loading the book and chapter supplied.")

                            ' *********************** LOAD REFERENCE ***********************
                            ChangeReference(bookIndex, chapterIndex)

                        Else
                            ' We have found some verses
                            ' Do the verses exist?
                            ' What we do here is verify that the largest valu verse number exists
                            ' If it doesn't then remove it and verify the next lowest value
                            ' Continue until they all match or none left to remove

                            ' First, remove any duplicates found
                            verses = strArrRemoveDuplicate(verses)
                            Dim versesFinal As New List(Of Integer)
                            For Each vs As String In verses
                                For i As Integer = 0 To _Bible.Books(bookIndex).Chapters(chapterIndex).Verses.Count - 1
                                    If _Bible.Books(bookIndex).Chapters(chapterIndex).Verses.Item(i).Number = vs Then
                                        ' We found a match
                                        ' Exit the loop
                                        versesFinal.Add(CInt(vs))
                                        Exit For
                                    End If
                                Next
                            Next

                            ' Do we have any valid verses?
                            If versesFinal.Count > 0 Then
                                ' Yes, so
                                ' Load the matched book, matched chapter, and select all of the verses
                                'MsgBox("Found the book, chapter, and verse number(s) " + allVersesStr + "." + Chr(13) + _
                                '       "Loading the book, chapter, and selecting the verses.")

                                ' *********************** LOAD REFERENCE ***********************
                                ChangeReference(bookIndex, chapterIndex, versesFinal)
                            Else
                                ' No, so
                                ' Load the matched book and the matched chapter but don't select any verses

                                'MsgBox("Found the book and chapter but no verses." + Chr(13) + "Loading the book and chapter supplied.")
                                ' *********************** LOAD REFERENCE ***********************
                                ChangeReference(bookIndex, chapterIndex, versesFinal)
                            End If
                        End If
                    Else
                        ' We found a book match but no chapters so
                        ' Load the supplied book and just set it to chapter 1
                        'MsgBox("Found the book " + bookname + "(" + _Bible.Books(bookIndex).Name + ") but did not find the chapter or none was supplied." + Chr(13) + _
                        '       "Loading chapter 1 instead.")
                        ' *********************** LOAD REFERENCE ***********************
                        ChangeReference(bookIndex, chapterIndex)
                    End If
                Else
                    ' The book does NOT exist, there is no use continuing
                    ' Give an error and exit
                    ' MsgBox("The supplied book '" + bookname + "' does not exist.")
                    Exit Sub
                End If

            Else
                ' Reference does not start with letters so
                ' Give error message and exit
                ' MsgBox("Your reference must begin with the book name.")
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("There is an error in your reference format.")
        End Try
    End Sub

    ''' <summary>
    ''' Changes the reference to the one in the reference box if applicable.
    ''' </summary>
    ''' <param name="bookIndex"></param>
    ''' <param name="chapterIndex"></param>
    ''' <param name="verses"></param>
    ''' <remarks></remarks>
    Private Sub ChangeReference(bookIndex As Integer, chapterIndex As Integer, Optional verses As List(Of Integer) = Nothing)
        Try
            lbBooks.SelectedIndex = bookIndex

            If chapterIndex > -1 Then
                lbChapters.SelectedIndex = chapterIndex
            End If

            If verses IsNot Nothing Then
                If verses.Count > 0 Then
                    lbVerses.SelectedIndices.Clear()
                    For Each vs As Integer In verses
                        lbVerses.SelectedIndices.Add(vs - 1)
                    Next
                End If
            Else
                lbVerses.SelectedIndices.Clear()
                lbVerses.SelectedIndices.Add(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Changes the slide to the next or previous slide when user presses the up or down arrow keys.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ChangeSlide()
        If lvPlaylist.SelectedItems.Count > 0 Then
            Try
                Dim ref As Reference = Playlist(lvPlaylist.SelectedIndices(0)).Reference

                ProjectionScreen.DisplayPanel1.CurrentSlide.Reference = ref
                ProjectionScreen.DisplayPanel1.Invalidate()
                ProjectionScreen.DisplayPanel1.Update()

                ' Update the preview screen
                PreviewScreenDraw()
            Catch ex As Exception
                MsgBox(System.Reflection.MethodInfo.GetCurrentMethod.Name + Environment.NewLine + ex.Message)
            End Try
        End If
    End Sub

#End Region

#Region "Functions"
    Function LoadBible(ByVal filepath As String) As Boolean
        Dim index As Integer
        Dim line As String = ""
        Dim currentBook As String = "Genesis"
        Dim chapterNum As String = "1"
        Try
            Dim sr As New IO.StreamReader(filepath)
            Dim version As String = ""
            Dim verseNum As String = "1"
            Dim verseText As String = ""
            Dim c As Char() = {CChar(delimiter)}
            Dim subStrings As String() = {}
            Dim _Book As New Book
            Dim _Chapter As New Chapter

            While Not sr.EndOfStream
                line = sr.ReadLine
                index += 1

                If index = 1 And line.StartsWith("Version=") Then
                    version = line.Replace("Version=", "")
                ElseIf index = 1 And Not line.StartsWith("Version=") Then
                    MsgBox("No version information found for current bible.")
                End If

                If Not line.StartsWith("[End Book]") Then
                    subStrings = line.Split(c, 4)
                End If

                If Not line.StartsWith("Version=") Then
                    _Book.Name = currentBook

                    If line <> "[End Book]" Then
                        ' Get the Book name, Chapter number, Verse number and the Verse
                        currentBook = subStrings.GetValue(0)
                        chapterNum = subStrings.GetValue(1)
                        verseNum = subStrings.GetValue(2)
                        verseText = subStrings.GetValue(3)
                    End If

                    If line.StartsWith("[End Book]") Then ' We have reached the end of the book
                        ' Add the chapter to the book
                        _Book.BookNumber = _Bible.Books.Count + 1
                        _Book.Chapters.Add(_Chapter)

                        ' Add the book to the bible
                        _Bible.Books.Add(_Book)

                        ' Reinitialize to a new book and chapter
                        _Book = New Book
                        _Chapter = New Chapter
                    ElseIf Not line.StartsWith("[End Book]") And _
                         _Chapter.ChapterNumber <> "0" And _
                          _Chapter.ChapterNumber <> chapterNum Then ' The chapter has changed

                        ' We haved switched chapters so
                        ' Add the previous chapter to the current book
                        _Book.Chapters.Add(_Chapter)

                        ' Reinitialize the _Chapter
                        _Chapter = New Chapter
                        _Chapter.Verses.Add(New Verse(version, _Book.Name, _Chapter.ChapterNumber.ToString, verseNum, verseText))
                        _Chapter.ChapterNumber = chapterNum
                    Else ' We are still in the same book and chapter
                        _Chapter.Verses.Add(New Verse(version, _Book.Name, _Chapter.ChapterNumber.ToString, verseNum, verseText))
                        _Chapter.ChapterNumber = chapterNum
                    End If
                End If
            End While

            ' Show the bible version in the Bible tab
            tabctrlBible.TabPages("tabpageBible").Text += (" - " + version.Replace("""", ""))

            sr.Close()
        Catch ex As Exception
            MsgBox(System.Reflection.MethodInfo.GetCurrentMethod.Name + Environment.NewLine + ex.Message)
            Return False
        End Try

        Return True
    End Function

    Friend Function GetBookName(reference As String) As String
        Dim book As String = ""
        Dim foundLetter As Boolean
        Try
            ' The book name should be at the beginning of the reference
            ' However, we need to get its length so we will move forward
            ' until we reach a non-alphabetic character
            Dim rg As New Regex("[ ]{2,}", RegexOptions.None)
            Dim s As String = rg.Replace(reference, " ")
            For Each c As Char In reference
                If Char.IsNumber(c) And foundLetter = False Then
                    book += c.ToString
                ElseIf Char.IsLetter(c) And foundLetter = False Then
                    book += " " + c.ToString
                    foundLetter = True
                ElseIf Char.IsLetter(c) And foundLetter = True Then
                    book += c.ToString
                ElseIf Char.IsNumber(c) And foundLetter = True Then
                    ' We have reached the end of the book name so exit loop
                    Exit For
                End If
            Next

        Catch ex As Exception
            MsgBox("Error in the chapter section of your reference.")
        End Try
        Return book
    End Function

    Friend Function GetVerses(reference As String) As String()
        Dim trimChars() As Char = {" ", ":"} ', ","} ', ".", ","
        Dim verseNums() As String = {}
        Dim splitChars() As Char = {",", "."}
        Dim finalVerseArray() As String = {}

        ' First remove any leading or trailing punctuation
        Dim PunctuationSymbols() As Char = {",", ".", "/", ";", "'", "[", "]", "\", "`", "-", "=", "<", ">", "?", ":", """", "{", "}", "|", "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+"}

        reference = reference.TrimStart(PunctuationSymbols)
        reference = reference.TrimEnd(PunctuationSymbols)

        ' **********************************************************************************************
        ' THE SPLIT REFERENCE SHOULD CONTAIN 3 ENTRIES
        ' THE FIRST OR 0 IS THE BOOKNAME. THE SECOND OR 1
        ' IS THE CHAPTER, AND FINALLY THE LAST ONE OR 2 IS
        ' THE CHAPTERS.
        Dim splitRef() As String = reference.Split(trimChars)
        ' **********************************************************************************************

        verseNums = reference.Split(splitChars)

        If verseNums.Length <= 1 And Not verseNums(0).Contains("-") Then
            Return verseNums
        End If

        Dim coll As New List(Of String)
        ' Search through the array for our marker, in this case the "-"
        For i As Integer = 0 To verseNums.Length - 1
            ' Do we need to get missing consecutive numbers?
            If verseNums(i).Contains("-") Then
                coll.AddRange(FindMissingNumbers(verseNums(i)))
                ' Add the the numbers on either side of the "-"
                Dim nums() As String = verseNums(i).Split("-")

                coll.AddRange(nums)
            Else
                ' A Non-consecutive number so just add it to the list
                coll.Add(verseNums(i))
            End If
        Next


        Dim output() As String = coll.GetRange(0, coll.Count).ToArray()
        Dim newIntArray(output.Length - 1) As Integer


        For i As Integer = 0 To output.Length - 1
            newIntArray(i) = Integer.Parse(output(i))
        Next

        Array.Sort(newIntArray)

        ReDim finalVerseArray(newIntArray.Length - 1) 'As String
        For i As Integer = newIntArray.Count - 1 To 0 Step -1
            finalVerseArray(i) = newIntArray(i).ToString()
        Next

        Return finalVerseArray
    End Function

    Public Function strArrRemoveDuplicate(ByRef StringArray() As String) As String()
        Dim LowBound As Long, UpBound As Long
        Dim TempArray() As String, Cur As Long
        Dim A As Long, B As Long

        'check for empty array
        If StringArray.Length = 0 Then Return Nothing

        'we need these often
        LowBound = LBound(StringArray)
        UpBound = UBound(StringArray)

        'reserve check buffer
        ReDim TempArray(UpBound)

        'set first item
        Cur = LowBound
        TempArray(Cur) = StringArray(LowBound)



        'loop through all items
        For A = LowBound + 1 To UpBound
            'make a comparison against all items
            For B = LowBound To Cur
                'if is a duplicate, exit array
                If Len(TempArray(B)) = Len(StringArray(A)) Then
                    If InStr(1, StringArray(A), TempArray(B), vbBinaryCompare) = 1 Then Exit For
                End If
            Next B
            'check if the loop was exited: add new item to check buffer if not
            If B > Cur Then Cur = B : TempArray(Cur) = StringArray(A)
        Next A

        'fix size
        ReDim Preserve TempArray(Cur)
        'copy
        StringArray = TempArray

        Return TempArray
    End Function

    ''' <summary>
    ''' Returns the missing numbers in a sequence.   
    ''' </summary>   
    ''' <param name="strNumbers">Expects a string of comma-delimited numbers. ex: "1,2,4,6,7"</param>   
    ''' <returns></returns>   
    ''' <remarks></remarks>   
    Public Function FindMissingNumbers(ByVal strNumbers As String) As List(Of String)
        Dim MissingNumbers As New List(Of String)
        Dim arNumbers() As String
        arNumbers = Split(strNumbers, "-")
        arNumbers = SortNumbers(arNumbers)
        For I = 0 To UBound(arNumbers) - 1
            If CLng(arNumbers(I)) + 1 <> CLng(arNumbers(I + 1)) Then
                For J = 1 To (CLng(arNumbers(I + 1)) - CLng(arNumbers(I))) - 1
                    MissingNumbers.Add(CStr(CLng(arNumbers(I)) + J))
                Next
            End If
        Next

        Return MissingNumbers
    End Function

    ''' <summary>  
    ''' Sorts the array of numbers in value order, least to greatest.  
    ''' </summary>  
    ''' <param name="arNumbers">Send in a string() array of numbers</param>  
    ''' <returns></returns>  
    ''' <remarks></remarks>  
    Private Function SortNumbers(ByVal arNumbers() As String) As String()
        Dim tmpNumber As String
        For J = 0 To UBound(arNumbers) - 1
            For I = J + 1 To UBound(arNumbers)
                If arNumbers(I) - arNumbers(J) < 0 Then
                    tmpNumber = arNumbers(J)
                    arNumbers(J) = arNumbers(J)
                    arNumbers(I) = tmpNumber
                End If
            Next
        Next

        Return arNumbers
    End Function

    Private Function SortNumbers(ByVal arNumbers As List(Of String)) As List(Of String)
        Dim tmpNumber As String
        For J = 0 To arNumbers.Count - 1
            For I = J + 1 To arNumbers.Count - 1
                If arNumbers(I) - arNumbers(J) < 0 Then
                    tmpNumber = arNumbers(J)
                    arNumbers(J) = arNumbers(J)
                    arNumbers(I) = tmpNumber
                End If
            Next
        Next

        Return arNumbers
    End Function
#End Region


    Private Sub SubmitBugReportFeedbackToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SubmitBugReportFeedbackToolStripMenuItem.Click
        If Feedback.ShowDialog = Windows.Forms.DialogResult.OK Then
           

        End If
    End Sub
End Class
