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


Module Functions


    Friend Function FormatVerse(ParamArray verses() As String) As String()

        Dim verseNum As String = ""
        Dim verseText As String = ""
        Dim formatted(1) As String
        For Each Verse As String In verses
            verseNum = Verse.Substring(0, Verse.IndexOf(" "))
            verseText = (Verse.Substring(Verse.IndexOf(" "), Verse.Length - (Verse.IndexOf(" ")))).Trim
            'verseText = verseText.Trim
            formatted(0) = verseNum.Trim("(", ")")
            formatted(1) = verseText

        Next
        Return formatted
    End Function

    Friend Function FormatReferenceSequence(ByVal ParamArray numbers() As Integer) As String
        Dim result As String = ""
        If numbers.Length > 0 Then
            Dim first As Integer = numbers(0)
            Dim last As Integer = numbers(0)


            For i As Integer = 1 To numbers.Length - 1
                ' As long as entries are consecutive, move end forward
                If numbers(i) = (numbers(i - 1) + 1) Then
                    last = numbers(i)
                Else
                    ' When no longer consecutive, add group to result
                    ' depending on whether start=end (single item) or not
                    If first = last Then
                        result += first.ToString + ","
                    Else
                        result += first.ToString + "-" + last.ToString + ","
                    End If
                    first = numbers(i)
                    last = numbers(i)
                End If
            Next

            ' Handle the final group
            If first = last Then
                result += first.ToString
            Else
                result += first.ToString + "-" + last.ToString
            End If
        Else
            MsgBox("There seem to be errors in adding the selected verse(s) to your playlist." + Chr(13) + Chr(13) + _
                   "Reason: Font size is too high. Verse(s) will not fit properly on the screen." + Chr(13) + _
                     "Solution: Lower the font size until the problem is solved.", MsgBoxStyle.Exclamation)
            Return ""
        End If

        Return result
    End Function

    Friend Function FormatReferenceSequence(ByVal ParamArray numbers() As String) As String
        Dim first As Integer = CInt(numbers(0))
        Dim last As Integer = CInt(numbers(0))
        Dim result As String = ""

        For i As Integer = 1 To numbers.Length - 1
            ' As long as entries are consecutive, move end forward
            If numbers(i) = (numbers(i - 1) + 1) Then
                last = numbers(i)
            Else
                ' When no longer consecutive, add group to result
                ' depending on whether start=end (single item) or not
                If first = last Then
                    result += first.ToString + ","
                Else
                    result += first.ToString + "-" + last.ToString + ","
                End If
                first = numbers(i)
                last = numbers(i)
            End If
        Next

        ' Handle the final group
        If first = last Then
            result += first.ToString
        Else
            result += first.ToString + "-" + last.ToString
        End If

        Return result
    End Function

    Function ScreenCount() As Integer
        Return System.Windows.Forms.Screen.AllScreens.Count
    End Function

    Function ExtendedScreenBounds() As Rectangle
        If ScreenCount() > 1 Then
            Dim screens As System.Windows.Forms.Screen() = System.Windows.Forms.Screen.AllScreens
            Return screens(1).Bounds
        Else
            Dim screens As System.Windows.Forms.Screen() = System.Windows.Forms.Screen.AllScreens
            Return screens(0).Bounds
        End If
    End Function

End Module
