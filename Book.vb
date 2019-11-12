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



Public Class Book

    Private _booknumber As Integer
    Friend Property BookNumber As Integer
        Get
            Return _booknumber
        End Get
        Set(ByVal value As Integer)
            _booknumber = value
        End Set
    End Property

    Private _bookname As String = ""
    Friend Property Name As String
        Get
            Return _bookname
        End Get
        Set(ByVal value As String)
            _bookname = value
        End Set
    End Property

    Private _chapters As New List(Of Chapter)
    Friend Property Chapters As List(Of Chapter)
        Get
            Return _chapters
        End Get
        Set(ByVal value As List(Of Chapter))
            _chapters = value
        End Set
    End Property

End Class
