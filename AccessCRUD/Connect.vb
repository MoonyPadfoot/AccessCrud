Module Connect
    'Public con As New ADODB.Connection
    'Public rs As New ADODB.Recordset


    'Public Sub conOpen()
    'Dim path As String = Application.StartupPath & "\dbAccess.mdb"
    '   con.open("Provider=MICROSOFT.jet.OLEDB.4.0;datasource=" & path)

    'End Sub
    Public con As New OleDb.OleDbConnection
    'Public command As New OleDb.OleDbCommand
    Public reader As OleDb.OleDbDataReader
    ' Public da As OleDb.OleDbDataAdapter
    Public sql As String
    'Public ds As New DataSet
    Public Sub openCon()
        Dim dbProvider As String
        Dim dbSource As String
        Dim dbPathAndFilename As String

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;" ' MDB 2003     
        'dbProvider = "PROVIDER=Microsoft.Ace.OLEDB.12.0;" 'ACCDB 2007 ^
        dbSource = "Data Source="

        dbPathAndFilename = "c:\Users\tahah\dbBackUp\dbAccess.mdb"
        con.ConnectionString = dbProvider & dbSource & dbPathAndFilename
        con.Open()

    End Sub
    Public Sub closeCon()
        con.Close()
        con.Dispose()
    End Sub

End Module
