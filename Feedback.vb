Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports System.Net.Mail

Public Class Feedback

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        If tbName.Text <> "" And tbEmail.Text <> "" And tbSubject.Text <> "" And tbDescription.Text <> "" And _
           cbOS.Text <> "" And cbOS.Text <> "[Select OS]" Then

            If EmailValid(tbEmail.Text) Then
                Dim body As String = "FROM: " + tbName.Text + Chr(13) + "COMPANY: " + tbCompany.Text + Chr(13) + _
                    "PHONE: " + tbPhone.Text + Chr(13) + "EMAIL: " + tbEmail.Text + Chr(13) + _
                    "SUBJECT: " + tbSubject.Text + Chr(13) + "OPERATING SYSTEM: " + cbOS.Text + Chr(13) + _
                    Chr(13) + "MESSAGE: " + tbDescription.Text
                Dim subject As String = "[BUG REPORT] - " + tbSubject.Text + " - " + My.Application.Info.AssemblyName
                Dim mail As New MailMessage(tbEmail.Text, "rscottb31@gmail.com", subject, body)
                Dim client As New SmtpClient

                client.UseDefaultCredentials = False

                ' This uses an app password provided by google for authentification
                ' It will only work with this software so there is no harm in storing
                ' it in the code.
                client.Credentials = New Net.NetworkCredential("rscottb31@gmail.com", "goipulmumayqctlm")
                client.Port = 587
                client.EnableSsl = True
                client.Host = "smtp.gmail.com"

                Try
                    client.Send(mail)
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK

                    Me.Close()

                    MsgBox("Thank you for your feedback.")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Please enter a valid email.")
            End If
        Else
            MsgBox("Fields marked with '*' are required.")
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function EmailValid(email As String) As Boolean
        Try
            Dim mail As New MailAddress(email)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
End Class
