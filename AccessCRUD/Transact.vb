Public Class Transact
    Dim user As New ClassQuery
    Private Sub Transact_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        user.DataGLoad()

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    ' user.UName = Me.TextBox1.Text
    'user.PWord = Me.TextBox2.Text

    ' If user.Save = True Then
    ' MessageBox.Show("saved")
    ' Transact_Load()
    'Else
    ' MessageBox.Show("failed")
    ' End If
    'End Sub
End Class