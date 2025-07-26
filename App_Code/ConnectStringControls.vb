Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace SQLSERVERConnection
    Public Class ConnectStringControls
        Private Shared _sqlAuthentication As Boolean = False

        Public Shared Property SqlAuthentication() As Boolean
            Get
                Return ConnectStringControls._sqlAuthentication
            End Get
            Set(ByVal value As Boolean)
                ConnectStringControls._sqlAuthentication = value
            End Set
        End Property

        Private Shared _dataSource As String

        Public Shared Property DataSource() As String
            Get
                Return ConnectStringControls._dataSource
            End Get
            Set(ByVal value As String)
                ConnectStringControls._dataSource = value
            End Set
        End Property

        Private Shared _database As String

        Public Shared Property Database() As String
            Get
                Return ConnectStringControls._database
            End Get
            Set(ByVal value As String)
                ConnectStringControls._database = value
            End Set
        End Property

        Private Shared _userName As String

        Public Shared Property UserName() As String
            Get
                Return ConnectStringControls._userName
            End Get
            Set(ByVal value As String)
                ConnectStringControls._userName = value
            End Set
        End Property

        Private Shared _password As String

        Public Shared Property Password() As String
            Get
                Return ConnectStringControls._password
            End Get
            Set(ByVal value As String)
                ConnectStringControls._password = value
            End Set
        End Property

        Private Shared _privider As String = "System.Data.SqlClient"

        Public Shared Property Privider() As String
            Get
                Return ConnectStringControls._privider
            End Get
            Set(ByVal value As String)
                ConnectStringControls._privider = value
            End Set
        End Property

        Public Shared Function ConnectionString() As String
            Dim _connectionString As String = String.Empty

            If _sqlAuthentication Then
                _connectionString = String.Format("Data Source={0};Initial Catalog={1};Network Library=DBMSSOCN;User ID={2};Password={3}", _dataSource, _database, _userName, _password) 'Integrated Security=SSPI
            Else
                _connectionString = String.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", _dataSource, _database)
            End If

            Return _connectionString
        End Function
    End Class
End Namespace
