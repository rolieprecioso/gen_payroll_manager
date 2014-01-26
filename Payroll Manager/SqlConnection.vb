Public Class SqlConnectionDBase
    Private _connectionString As String
    Public Property connectionString() As String
        Get
            Return _connectionString
        End Get
        Set(ByVal value As String)
            _connectionString = value
        End Set
    End Property

    Private _sqlCon As System.Data.SqlClient.SqlConnection
    Public Property sqlCon() As System.Data.SqlClient.SqlConnection
        Get
            Return _sqlCon
        End Get
        Set(ByVal value As System.Data.SqlClient.SqlConnection)
            _sqlCon = value
        End Set
    End Property

    Private _serverName As String
    Public Property serverName() As String
        Get
            Return _serverName
        End Get
        Set(ByVal value As String)
            _serverName = value
        End Set
    End Property

    Private _userName As String
    Public Property userName() As String
        Get
            Return _userName
        End Get
        Set(ByVal value As String)
            _userName = value
        End Set
    End Property

    Private _passWord As String
    Public Property passWord() As String
        Get
            Return _passWord
        End Get
        Set(ByVal value As String)
            _passWord = value
        End Set
    End Property

    Private _databaseName As String
    Public Property databaseName() As String
        Get
            Return _databaseName
        End Get
        Set(ByVal value As String)
            _databaseName = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(_serverName As String, _databaseName As String, _userName As String, _passWord As String, isIntegratedSec As Boolean)
        serverName = _serverName
        databaseName = _databaseName
        userName = _userName
        passWord = _passWord

        If isIntegratedSec = False Then
            connectionString = "Data Source=" & serverName & ";Initial Catalog=" & databaseName & ";User ID=" & userName & ";Password=" & passWord & ";MultipleActiveResultSets=True"
        Else
            connectionString = "Data Source=" & serverName & ";Initial Catalog=" & databaseName & "; Integrated Security=True;MultipleActiveResultSets=True"
        End If

    End Sub

    Public Function openConnection() As String
        sqlCon = New SqlClient.SqlConnection(connectionString)
        Try
            sqlCon.Open()
            MyConnection = sqlCon
            Return "Connection Opened!"
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function
End Class
