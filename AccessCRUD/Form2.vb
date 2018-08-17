Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbAccessDataSet.tblUser' table. You can move, or remove it, as needed.
        Me.TblUserTableAdapter.Fill(Me.DbAccessDataSet.tblUser)

    End Sub
End Class