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



Public Class Reference


    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Private _version As String = ""
    Friend Property Version As String
        Get
            Return _version
        End Get
        Set(value As String)
            _version = value
        End Set
    End Property

    Private _book As String = ""
    Friend Property Book As String
        Get
            Return _book
        End Get
        Set(value As String)
            _book = value
        End Set
    End Property

    Private _chapter As String = ""
    Friend Property Chapter As String
        Get
            Return _chapter
        End Get
        Set(value As String)
            _chapter = value
        End Set
    End Property

    Friend ReadOnly Property VerseNumbers As String()
        Get
            Dim verseNums(Verses.Count - 1) As String
            For i As Integer = 0 To Verses.Count - 1
                verseNums(i) = Verses(i).Number
            Next
            Return verseNums
        End Get
    End Property

    Private _verses As New List(Of Verse)
    Friend Property Verses As List(Of Verse)
        Get
            Return _verses
        End Get
        Set(ByVal value As List(Of Verse))
            _verses = value
        End Set
    End Property

End Class
