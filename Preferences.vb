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


Imports System.Windows.Forms

Public Class Preferences

    Dim Backspace As Boolean

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        If rdoTopLeft.Checked Then
            ProjectionScreen.DisplayPanel1.PositionOfReference = DisplayPanel.Alignment.Left
        ElseIf rdoTopCenter.Checked Then
            ProjectionScreen.DisplayPanel1.PositionOfReference = DisplayPanel.Alignment.Center
        ElseIf rdoTopRight.Checked Then
            ProjectionScreen.DisplayPanel1.PositionOfReference = DisplayPanel.Alignment.Right
        End If

        ProjectionScreen.DisplayPanel1.NumberVerseSpacing = nudNumVerseSpace.Value

        ProjectionScreen.DisplayPanel1.ForeColor = ColorDialogText.Color
        Drawing3D.ShadowColor = ColorDialogShadow.Color
        Drawing3D.OutlineColor = ColorDialogOutline.Color
        Drawing3D.OutlineSize = nudOutlineSize.Value
        Drawing3D.ShadowOffset = New Point(nudShadowOffsetX.Value, Drawing3D.ShadowOffset.Y)
        Drawing3D.ShadowOffset = New Point(Drawing3D.ShadowOffset.X, nudShadowOffsetY.Value)

        ProjectionScreen.DisplayPanel1.Font = FontDialog1.Font

        MainForm.PreviewScreenDraw()
        ProjectionScreen.DisplayPanel1.Invalidate()
        ProjectionScreen.DisplayPanel1.Update()


        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



    Private Sub Margin_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbMarginTop.TextChanged, tbMarginRight.TextChanged, tbMarginLeft.TextChanged, tbMarginBottom.TextChanged
        If sender.Text <> "" Then
            Select Case sender.Name
                Case "tbMarginLeft"
                    ProjectionScreen.DisplayPanel1.LeftMargin = tbMarginLeft.Text
                Case "tbMarginRight"
                    ProjectionScreen.DisplayPanel1.RightMargin = tbMarginRight.Text
                Case "tbMarginTop"
                    ProjectionScreen.DisplayPanel1.TopMargin = tbMarginTop.Text
                Case "tbMarginBottom"
                    ProjectionScreen.DisplayPanel1.BottomMargin = tbMarginBottom.Text
            End Select
            MainForm.PreviewScreenDraw()
            ProjectionScreen.DisplayPanel1.Invalidate()
            ProjectionScreen.DisplayPanel1.Update()
        End If
    End Sub

    Private Sub Margin_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles tbMarginTop.KeyDown, tbMarginRight.KeyDown, tbMarginLeft.KeyDown, tbMarginBottom.KeyDown
        If e.KeyCode = Keys.Back Then
            Backspace = True
        Else
            Backspace = False
        End If
    End Sub

    Private Sub Margin_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbMarginTop.KeyPress, tbMarginRight.KeyPress, tbMarginLeft.KeyPress, tbMarginBottom.KeyPress
        If Backspace = False Then
            Dim allowedChars As String = "0123456789"
            If allowedChars.IndexOf(e.KeyChar) = -1 OrElse sender.Text.Length > 2 Then
                e.Handled = True
                Return
            End If
        End If
    End Sub

    Private Sub Options_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Select Case ProjectionScreen.DisplayPanel1.PositionOfReference
            Case DisplayPanel.Alignment.Left
                rdoTopLeft.Checked = True
            Case DisplayPanel.Alignment.Center
                rdoTopCenter.Checked = True
            Case DisplayPanel.Alignment.Right
                rdoTopRight.Checked = True
        End Select

        ' Assign our font and color dialog boxes the respective displaypanel settings
        FontDialog1.Font = ProjectionScreen.DisplayPanel1.Font

        ' Populate our margin controls
        tbMarginLeft.Text = ProjectionScreen.DisplayPanel1.LeftMargin
        tbMarginRight.Text = ProjectionScreen.DisplayPanel1.RightMargin
        tbMarginTop.Text = ProjectionScreen.DisplayPanel1.TopMargin
        tbMarginBottom.Text = ProjectionScreen.DisplayPanel1.BottomMargin

        ' Set all our color dialogs to the current color drawing colors
        ColorDialogText.Color = ProjectionScreen.DisplayPanel1.ForeColor
        ColorDialogShadow.Color = Drawing3D.ShadowColor
        ColorDialogOutline.Color = Drawing3D.OutlineColor

        ' Populate shadow offset controls with x,y values
        nudShadowOffsetX.Value = Drawing3D.ShadowOffset.X
        nudShadowOffsetY.Value = Drawing3D.ShadowOffset.Y

        ' Setup boolean values for shadows and outline
        cbEnableShadows.Checked = Drawing3D.ShadowsEnabled
        cbEnableOutline.Checked = Drawing3D.OutlineEnabled

        ' Make our checkbox checked if 'Use3DRendering' is set to True.
        cbUse3DRendering.Checked = MainForm.Use3DRendering

        nudNumVerseSpace.Value = ProjectionScreen.DisplayPanel1.NumberVerseSpacing
        nudOutlineSize.Value = Drawing3D.OutlineSize

    End Sub


    Private Sub cbUse3DRendering_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbUse3DRendering.CheckedChanged
        If cbUse3DRendering.CheckState = CheckState.Checked Then
            MainForm.Use3DRendering = True
            gbShadows.Enabled = True
            gbOutlining.Enabled = True
        Else
            MainForm.Use3DRendering = False
            gbShadows.Enabled = False
            gbOutlining.Enabled = False
        End If
    End Sub

    Private Sub cbEnableShadows_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles cbEnableShadows.CheckedChanged
        If cbEnableShadows.CheckState = CheckState.Checked Then
            Drawing3D.ShadowsEnabled = True
            btnShadowColor.Enabled = True
            GroupBox5.Enabled = True
        Else
            Drawing3D.ShadowsEnabled = False
            btnShadowColor.Enabled = False
            GroupBox5.Enabled = False
        End If
    End Sub

    Private Sub cbEnableOutline_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles cbEnableOutline.CheckedChanged
        If cbEnableOutline.CheckState = CheckState.Checked Then
            Drawing3D.OutlineEnabled = True
            btnOutlineColor.Enabled = True
            Label11.Enabled = True
            nudOutlineSize.Enabled = True
            Label7.Enabled = True
        Else
            Drawing3D.OutlineEnabled = False
            btnOutlineColor.Enabled = False
            Label11.Enabled = False
            nudOutlineSize.Enabled = False
            Label7.Enabled = False
        End If
    End Sub

    Private Sub btnShadowColor_Click_1(sender As System.Object, e As System.EventArgs) Handles btnShadowColor.Click
        ColorDialogShadow.ShowDialog()
    End Sub

    Private Sub btnOutlineColor_Click_1(sender As System.Object, e As System.EventArgs) Handles btnOutlineColor.Click
        ColorDialogOutline.ShowDialog()
    End Sub

    'Private Sub nudOutlineSize_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudOutlineSize.ValueChanged
    '    Drawing3D.OutlineSize = nudOutlineSize.Value
    'End Sub

    'Private Sub nudShadowOffsetX_ValueChanged_1(sender As System.Object, e As System.EventArgs) Handles nudShadowOffsetX.ValueChanged
    '    Drawing3D.ShadowOffset = New Point(nudShadowOffsetX.Value, Drawing3D.ShadowOffset.Y)
    'End Sub

    'Private Sub nudShadowOffsetY_ValueChanged_1(sender As System.Object, e As System.EventArgs) Handles nudShadowOffsetY.ValueChanged
    '    Drawing3D.ShadowOffset = New Point(Drawing3D.ShadowOffset.X, nudShadowOffsetY.Value)
    'End Sub

    Private Sub btnFont_Click(sender As System.Object, e As System.EventArgs) Handles btnFont.Click
        FontDialog1.ShowDialog()
    End Sub

    Private Sub btnColor_Click(sender As System.Object, e As System.EventArgs) Handles btnColor.Click
        ColorDialogText.ShowDialog()
    End Sub

    Private Sub nudNumVerseSpace_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudNumVerseSpace.ValueChanged
        ' ProjectionScreen.DisplayPanel1.NumberVerseSpacing = nudNumVerseSpace.Value
    End Sub
End Class
