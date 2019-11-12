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



Public Class ProjectionScreen


    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ProjectionScreen_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ' If user closes the projection through another method besides
        ' the GoLive button then that button backcolor doesn't get updated.
        ' This is the workaround for that.
        MainForm.tsbGoLive.BackColor = SystemColors.ControlLight
    End Sub
End Class