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


Public Class Verse

    Sub New()

    End Sub

    Sub New(version As String, book As String, chapter As String, verseNum As String, text As String)
        Me.Version = version
        Me.Book = book
        Me.Chapter = chapter
        Me.Number = verseNum
        Me.Text = text
    End Sub

    Private _version As String = ""
    ''' <summary>
    ''' The bible version of the verse, i.e "KJV", "ASV", etc.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property Version As String
        Get
            Return _version
        End Get
        Set(value As String)
            _version = value
        End Set
    End Property

    Private _book As String = ""
    ''' <summary>
    ''' The book the verse is found in.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property Book As String
        Get
            Return _book
        End Get
        Set(value As String)
            _book = value
        End Set
    End Property

    Private _chapter As String = ""
    ''' <summary>
    ''' The chapter number in relation to the Book.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property Chapter As String
        Get
            Return _chapter
        End Get
        Set(value As String)
            _chapter = value
        End Set
    End Property

    Private _number As String = ""
    ''' <summary>
    ''' The verse number in relation to the book and chapter.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property Number As String
        Get
            Return _number
        End Get
        Set(value As String)
            _number = value
        End Set
    End Property

    Private _text As String = ""
    ''' <summary>
    ''' The text of the verse.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property Text As String
        Get
            Return _text
        End Get
        Set(value As String)
            _text = value
        End Set
    End Property


End Class
