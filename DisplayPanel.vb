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



Imports System.Drawing.Drawing2D


Public Class DisplayPanel
    Inherits Panel


    ' Friend AllReferences As New List(Of Reference)
    Friend CurrentSlide As New Slide

    Friend sermonTitle As String = ""


    Friend Structure DisplayMargins
        Dim Left As Integer
        Dim Right As Integer
        Dim Top As Integer
        Dim Bottom As Integer
    End Structure

    Friend Enum Alignment
        Left = 0
        Center = 1
        Right = 2
    End Enum


    Sub New()
        Me.DoubleBuffered = True
        Me.Font = New Font(Me.Font.FontFamily, 47)
    End Sub


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Try
            Dim verseTextRect As Rectangle = Me.DisplayRectangle
            Dim verseNumRect As Rectangle = Me.DisplayRectangle
            Dim refRect As Rectangle = Me.DisplayRectangle

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality

            If CurrentSlide.Reference.Verses.Count > 0 Then
                ' DRAW THE REFERENCE VERSION, BOOK, CHAPTER, VERSE(S)



                ' *********************************** FORMAT THE REFERENCE ***********************************
                Dim numbers(CurrentSlide.Reference.Verses.Count - 1) As Integer
                Dim ref As String = ""
                For i As Integer = 0 To CurrentSlide.Reference.Verses.Count - 1
                    numbers(i) = CInt(CurrentSlide.Reference.Verses(i).Number)
                Next
                ref = CurrentSlide.Reference.Verses(0).Book + "  " + CurrentSlide.Reference.Verses(0).Chapter + ":" + FormatReferenceSequence(numbers)
                ' ********************************************************************************************

                ' ********* SETUP DISPLAY COORDINATES FOR THE REFERENCE, VERSE NUMBER, AND VERSE TEXT *********
                refRect.Y += TopMargin  ' THE Y-POSITION OF THE REFERENCE ONLY
                verseNumRect.Y += (TopMargin + SpaceBelowReference) ' THE Y-POSITION OF THE VERSE NUMBER ONLY
                verseNumRect.X += LeftMargin ' THE X-POSITION OF THE VERSE NUMBER ONLY
                verseTextRect.X += (LeftMargin + NumberVerseSpacing) ' THE X-POSITION OF THE VERSE TEXT ONLY
                verseTextRect.Y += (TopMargin + SpaceBelowReference) ' THE Y-POSITION OF THE VERSE TEXT ONLY
                verseTextRect.Width -= (verseTextRect.X + RightMargin) ' THE RIGHT MARGIN FOR THE VERSE TEXT ONLY
                ' *********************************************************************************************

                ' If the user has turned on the display title
                ' then we need to adjust everything so that it
                ' doesn't get drawn over by the title
                If sermonTitle <> "" Then
                    refRect.Y += 75 ' Value of 100 needs changed to a variable that can be set in options
                    verseNumRect.Y += 75
                    verseTextRect.Y += 75
                End If

                ' If a title has been made available then draw it 
                If sermonTitle <> "" Then
                    ' Dim bannerHeight As Integer = Me.Font.Size * 2
                    Dim f As Font = Me.Font '.FontFamily, Me.Font.Size + 5)
                    Dim bmp As New Bitmap(Me.DisplayRectangle.Width, 75)
                    Dim bmpRect As New Rectangle(0, 0, bmp.Width, bmp.Height)
                    Dim titleSize As SizeF = e.Graphics.MeasureString(sermonTitle, f, bmpRect.Width, StringFormat.GenericTypographic)

                    Dim x As Integer = (bmpRect.Width / 2) - (titleSize.Width / 2)
                    e.Graphics.FillRectangle(New SolidBrush(MainForm.lblBannerColor.BackColor), bmpRect)
                    e.Graphics.DrawRectangle(New Pen(MainForm.lblBannerBorderColor.BackColor, MainForm.nudBannerBorderSize.Value), bmpRect)



                    bmpRect = New Rectangle(x, 0, bmp.Width, bmp.Height)

                    'If MainForm.Use3DRendering Then
                    'Drawing3D.Draw(e.Graphics, sermonTitle, f, MainForm.lblTitleColor.BackColor, bmpRect)
                    'Else
                    e.Graphics.DrawString(sermonTitle, f, New SolidBrush(MainForm.lblTitleColor.BackColor), bmpRect)
                    'End If

                End If

                ' ***************** DRAW THE REFERENCE ACCORDING TO ALIGNMENT *****************
                If PositionOfReference = Alignment.Left Then ' ** LEFT **
                    ' e.Graphics.DrawString(ref, Me.Font, New SolidBrush(Color.Black), refRect)
                ElseIf PositionOfReference = Alignment.Center Then ' ** CENTER **
                    Dim posX As Integer = (refRect.Width / 2) - (e.Graphics.MeasureString(ref, Me.Font).Width / 2)
                    refRect = New Rectangle(posX, refRect.Y, refRect.Width, refRect.Height)
                    ' e.Graphics.DrawString(ref, Me.Font, New SolidBrush(Color.Black), New Rectangle(posX, refRect.Y, refRect.Width, refRect.Height))
                ElseIf PositionOfReference = Alignment.Right Then ' ** RIGHT **
                    Dim posX As Integer = refRect.Width - e.Graphics.MeasureString(ref, Me.Font).Width
                    refRect = New Rectangle(posX, refRect.Y, refRect.Width, refRect.Height)
                    ' e.Graphics.DrawString(ref, Me.Font, New SolidBrush(Color.Black), New Rectangle(posX, refRect.Y, refRect.Width, refRect.Height))
                End If

                If MainForm.Use3DRendering Then
                    Drawing3D.Draw(e.Graphics, ref, Me.Font, Me.ForeColor, refRect)
                Else
                    e.Graphics.DrawString(ref, Me.Font, New SolidBrush(Me.ForeColor), refRect)
                End If
                ' ******************************************************************************



                ' ******************** DRAW ALL VERSE NUMBERS AND VERSE TEXT ********************
                Dim verseSize As SizeF
                Dim text As String = ""
                Dim num As String = ""

                For i As Integer = 0 To CurrentSlide.Reference.Verses.Count - 1
                    text = CurrentSlide.Reference.Verses(i).Text
                    num = CurrentSlide.Reference.Verses(i).Number + "."

                    ' MEASURE THE WIDTH OF THE VERSE TEXT IN PIXELS
                    verseSize = e.Graphics.MeasureString(text, Me.Font, verseTextRect.Width)

                    ' DRAW THE CURRENT VERSE NUMBER
                    If MainForm.Use3DRendering Then
                        Drawing3D.Draw(e.Graphics, num, Me.Font, Me.ForeColor, verseNumRect)
                    Else
                        e.Graphics.DrawString(num, Me.Font, New SolidBrush(Me.ForeColor), verseNumRect)
                    End If

                    ' DRAW THE CURRENT VERSE TEXT
                    If MainForm.Use3DRendering Then
                        Drawing3D.Draw(e.Graphics, text, Me.Font, Me.ForeColor, verseTextRect)
                    Else
                        e.Graphics.DrawString(text, Me.Font, New SolidBrush(Me.ForeColor), verseTextRect)
                    End If


                    ' MOVE THE RECTANGLE DOWN PAST THE PREVIOUS VERSE HEIGHT
                    verseNumRect = New Rectangle(verseNumRect.X, verseNumRect.Y + verseSize.Height, verseNumRect.Width, verseNumRect.Height)
                    verseTextRect = New Rectangle(verseTextRect.X, verseTextRect.Y + verseSize.Height, verseTextRect.Width, verseTextRect.Height)

                Next
            Else


            End If

           
        Catch ex As Exception
            MsgBox(System.Reflection.MethodInfo.GetCurrentMethod.Name + Environment.NewLine + ex.Message)
        End Try
    End Sub


    Private _numberversespacing As Integer = 150
    ''' <summary>
    ''' The space, in pixels, between the verse number and the verse text.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property NumberVerseSpacing As Integer
        Get
            Return _numberversespacing
        End Get
        Set(value As Integer)
            _numberversespacing = value
        End Set
    End Property

    Private _spacebelowreference As Integer = 100
    ''' <summary>
    ''' The space, in pixels, to put below the reference
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property SpaceBelowReference As Integer
        Get
            Return _spacebelowreference
        End Get
        Set(value As Integer)
            _spacebelowreference = value
        End Set
    End Property

    ''' <summary>
    ''' Returns a rectangle of the verse display minus all margins.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend ReadOnly Property VerseDisplayRectangle As Rectangle
        Get
            Dim x, y, w, h As Integer
            x = (LeftMargin + NumberVerseSpacing)
            y = TopMargin
            w = (ExtendedScreenBounds.Width - (RightMargin + (LeftMargin + NumberVerseSpacing)))
            h = (ExtendedScreenBounds.Height - (BottomMargin + TopMargin))
            Return New Rectangle(x, y, w, h)
        End Get
    End Property


    Private _leftmargin As Integer = 0
    Friend Property LeftMargin As Integer
        Get
            Return _leftmargin
        End Get
        Set(value As Integer)
            _leftmargin = value
        End Set
    End Property

    Private _rightmargin As Integer = 25
    Friend Property RightMargin As Integer
        Get
            Return _rightmargin
        End Get
        Set(value As Integer)
            _rightmargin = value
        End Set
    End Property

    Private _topmargin As Integer = 0
    Friend Property TopMargin As Integer
        Get
            Return _topmargin
        End Get
        Set(value As Integer)
            _topmargin = value
        End Set
    End Property

    Private _bottommargin As Integer = 10
    Friend Property BottomMargin As Integer
        Get
            Return _bottommargin
        End Get
        Set(value As Integer)
            _bottommargin = value
        End Set
    End Property

    Private _positionofreference As Alignment = Alignment.Center
    ''' <summary>
    ''' Gets or sets a ReferencePosition enum value of where to position the reference.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property PositionOfReference As Alignment
        Get
            Return _positionofreference
        End Get
        Set(value As Alignment)
            _positionofreference = value
        End Set
    End Property



    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'DisplayPanel
        '
        Me.BackColor = System.Drawing.Color.Black
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.ResumeLayout(False)

    End Sub



End Class
