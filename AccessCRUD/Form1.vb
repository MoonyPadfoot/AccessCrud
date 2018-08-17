Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try
        'conOpen()
        'rs.Open("SELECT * FROM tblUsers WHERE userName = '" & TextBox1.Text & "' AND passWord = '" & TextBox2.Text & "'", con, 3, 3)
        'If rs.RecordCount > 0 Then
        'MessageBox.Show("success")
        'End If
        'rs.Close()
        'con.Close()
        'Catch
        'MessageBox.Show("Error")
        ' Finally

        'con = Nothing

        'End Try
        Dim user As New ClassQuery

        user.UName = Me.TextBox1.Text
        user.PWord = Me.TextBox2.Text

        If user.Login = True Then
            Transact.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Username or Password")

        End If
    End Sub

End Class
