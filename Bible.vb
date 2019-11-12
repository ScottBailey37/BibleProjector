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



Public Class Bible
    Private _Book As New Book

    Sub New(ByVal name As String)
        Me._Book.Name = name
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

    Private _books As New List(Of Book)
    Friend Property Books As List(Of Book)
        Get
            Return _books
        End Get
        Set(ByVal value As List(Of Book))
            _books = value
        End Set
    End Property
End Class
