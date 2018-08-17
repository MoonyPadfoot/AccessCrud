Public Class ClassQuery
    Public Property UName
    Public Property PWord
    Public Function Login() As Boolean
        Try
            Dim count As Integer = 0
            openCon()

            sql = "SELECT * FROM dbAccess.tblUser WHERE userName = '" & UName & "' AND passWord = '" & PWord & "' "
            Dim command As New OleDb.OleDbCommand(sql, con)
            reader = command.ExecuteReader

            If reader.HasRows Then
                While reader.Read
                    count = 1
                End While
            End If

            If count = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False

        Finally
            closeCon()

        End Try

    End Function
    '  Public Function Save() As Boolean
    ' Try
    ''        openCon()
    '       sql = "INSERT INTO dbAccess.tblUser (userName, passWord) "
    '       sql &= "VALUES ('" & UName & "', '" & PWord & "')"
    '      command = New OleDb.OleDbCommand(sql, con)
    '      command.ExecuteNonQuery()

    'Return True
    ' Catch ex As Exception
    '       Return False
    ' Finally
    '        closeCon()
    ' End Try
    ' End Function
    Public Sub DataGLoad()
        openCon()
        sql = "SELECT * FROM dbAccess.tblUser"
        Dim da As New OleDb.OleDbDataAdapter(sql, con)
        Dim ds As New DataSet
        ds.Clear()
        'Give it a name.
        da.Fill(ds, "tblUser")

        con.Close()

        'Populate the DataGridView
        Transact.DataGridView1.DataSource = ds.Tables("tblUser")
    End Sub
End Class
