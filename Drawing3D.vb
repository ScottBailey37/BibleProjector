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


Friend Module Drawing3D


    Private _outlinesize As Integer = 4
    ''' <summary>
    ''' Size of the pen used to outline text
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property OutlineSize() As Integer
        Get
            Return _outlinesize
        End Get
        Set(ByVal value As Integer)
            _outlinesize = value
        End Set
    End Property

    Private _shadowoffset As New Point(6, 6)
    ''' <summary>
    ''' The offset of the shadow when shadows are enabled.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ShadowOffset() As Point
        Get
            Return _shadowoffset
        End Get
        Set(ByVal value As Point)
            _shadowoffset = value
        End Set
    End Property

    Private _shadowsenabled As Boolean = True
    ''' <summary>
    ''' Gets or sets a value if text shadows are enabled.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ShadowsEnabled() As Boolean
        Get
            Return _shadowsenabled
        End Get
        Set(ByVal value As Boolean)
            _shadowsenabled = value
        End Set
    End Property


#Region "Color Properties"
    Private _shadowcolor As Color = Color.Black
    ''' <summary>
    ''' Gets or sets the color of the text shadow.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ShadowColor() As Color
        Get
            Return _shadowcolor
        End Get
        Set(ByVal value As Color)
            _shadowcolor = value
        End Set
    End Property

    'Private _textcolor As Color = Color.Blue
    ' ''' <summary>
    ' ''' Gets or sets the color of the text.
    ' ''' </summary>
    ' ''' <value></value>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Public Property TextColor() As Color
    '    Get
    '        Return _textcolor
    '    End Get
    '    Set(ByVal value As Color)
    '        _textcolor = value
    '    End Set
    'End Property

    Private _outlinecolor As Color = Color.Teal
    ''' <summary>
    ''' Gets or sets the color of the text outline.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property OutlineColor() As Color
        Get
            Return _outlinecolor
        End Get
        Set(ByVal value As Color)
            _outlinecolor = value
        End Set
    End Property
#End Region

    Private _outlineenabled As Boolean = True
    ''' <summary>
    ''' Gets or sets a value if text outlining is enabled.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property OutlineEnabled As Boolean
        Get
            Return _outlineenabled
        End Get
        Set(value As Boolean)
            _outlineenabled = value
        End Set
    End Property


    'Private _textfont As Font = New Font("Arial", 58, FontStyle.Regular)
    'Public Property TextFont() As Font
    '    Get
    '        Return _textfont
    '    End Get
    '    Set(ByVal value As Font)
    '        _textfont = value
    '    End Set
    'End Property

#Region "Drawing Routines"
    'Private Sub OutlineText(g As Graphics, text As String, coords As Point)
    '    If OutlineEnabled Then
    '        g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
    '        Dim gpOutline As New Drawing2D.GraphicsPath
    '        gpOutline.AddString(text, TextFont.FontFamily, TextFont.Style, TextFont.Size, coords, StringFormat.GenericDefault)

    '        ' OUTLINE PATH
    '        Dim p As New Pen(OutlineColor, OutlineSize)
    '        g.DrawPath(p, gpOutline)
    '        p.Dispose()
    '        gpOutline.Dispose()
    '    End If
    'End Sub

    'Private Sub DrawShadows(g As Graphics, text As String, coords As Point)
    '    If ShadowsEnabled Then
    '        ' SHADOW PATH
    '        g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
    '        Dim gpShadow As New Drawing2D.GraphicsPath
    '        gpShadow.AddString(text, TextFont.FontFamily, TextFont.Style, TextFont.Size, New Point(coords.X + ShadowOffset.X, coords.Y + ShadowOffset.Y), StringFormat.GenericDefault)
    '        ' DRAW THE SHADOW
    '        g.FillPath(New SolidBrush(ShadowColor), gpShadow)
    '        gpShadow.Dispose()
    '    End If
    'End Sub

    Private Sub OutlineText(g As Graphics, text As String, font As Font, coords As Rectangle)
        If OutlineEnabled Then
            ' GraphicsPath.AddString expects a font size in pixel format
            ' whereas our graphics object expects em size. This makes our
            ' font smaller in the graphics path. A little conversion solves this.
            Dim emSize As Single = g.DpiY * font.Size / 72

            Dim gpOutline As New Drawing2D.GraphicsPath
            gpOutline.AddString(text, font.FontFamily, font.Style, emSize, coords, StringFormat.GenericDefault)

            ' OUTLINE PATH
            Dim p As New Pen(OutlineColor, OutlineSize)
            g.DrawPath(p, gpOutline)
            p.Dispose()
            gpOutline.Dispose()
        End If
    End Sub

    Private Sub DrawShadows(g As Graphics, text As String, font As Font, coords As Rectangle)
        If ShadowsEnabled Then
            ' SHADOW PATH
            ' GraphicsPath.AddString expects a font size in pixel format
            ' whereas our graphics object expects em size. This makes our
            ' font smaller in the graphics path. A little conversion solves this.
            Dim emSize As Single = g.DpiY * font.Size / 72

            Dim gpShadow As New Drawing2D.GraphicsPath
            'gpShadow.AddString(text, TextFont.FontFamily, TextFont.Style, TextFont.Size, New Point(coords.X + ShadowOffset.X, coords.Y + ShadowOffset.Y), StringFormat.GenericDefault)
            gpShadow.AddString(text, font.FontFamily, font.Style, emSize, New Rectangle(coords.X + ShadowOffset.X, coords.Y + ShadowOffset.Y, coords.Width, coords.Height), StringFormat.GenericDefault)

            ' DRAW THE SHADOW
            g.FillPath(New SolidBrush(ShadowColor), gpShadow)
            gpShadow.Dispose()


            '' Fill the path with a gradient.
            'g.FillPath(New System.Drawing.Drawing2D.LinearGradientBrush(New Point(5, 5), New Point(50, 50), _
            '        Color.Red, _
            '        Color.Blue), _
            '     gpShadow)

            '' Outline the path.
            'g.DrawPath(Pens.Black, gpShadow)





        End If
    End Sub


    Private Sub DrawText(g As Graphics, text As String, font As Font, fontcolor As Color, coords As Rectangle) 'coords As Point
        ' GraphicsPath.AddString expects a font size in pixel format
        ' whereas our graphics object expects em size. This makes our
        ' font smaller in the graphics path. A little conversion solves this.
        Dim emSize As Single = g.DpiY * font.Size / 72

        Dim gpText As New Drawing2D.GraphicsPath
        gpText.AddString(text, font.FontFamily, font.Style, emSize, coords, StringFormat.GenericDefault)
        g.FillPath(New SolidBrush(fontcolor), gpText)
    End Sub

    'Public Sub Draw(g As Graphics, text As String, coords As Point)
    '    ' Draw shadows first
    '    DrawShadows(g, text, coords)
    '    ' Draw outline second
    '    OutlineText(g, text, coords)
    '    ' Finally draw text
    '    DrawText(g, text, coords)
    'End Sub

    Public Sub Draw(g As Graphics, text As String, font As Font, fontcolor As Color, coords As Rectangle)
        ' Draw shadows first
        DrawShadows(g, text, font, coords)
        ' Draw outline second
        OutlineText(g, text, font, coords)
        ' Finally draw text
        DrawText(g, text, font, fontcolor, coords)
    End Sub
#End Region

End Module

