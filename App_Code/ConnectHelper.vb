Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Data.SqlClient

Module ConnectHelper
    Public Const SQL_NEED_DATA As Integer = 99
    Public Const SQL_SUCCESS As Integer = 0
    <DllImport("odbc32.dll", SetLastError:=True)> _
    Public Function SQLAllocConnect(ByVal hEnv As Integer, ByRef phdbc As Integer) As Short
    End Function
    <DllImport("odbc32.dll", SetLastError:=True)> _
    Public Function SQLAllocEnv(ByRef phenv As Integer) As Short
    End Function
    <DllImport("odbc32.dll", SetLastError:=True)> _
    Public Function SQLBrowseConnect(ByVal hdbc As Integer, ByVal inConnectionString As String, ByVal stringLength1 As Short, ByVal outConnectionString As StringBuilder, ByVal stringLength2 As Short, ByRef stringLengt2hPtr As Short) As Short
    End Function
    <DllImport("odbc32.dll", SetLastError:=True)> _
    Public Function SQLDisconnect(ByVal hdbc As Integer) As Short
    End Function
    <DllImport("odbc32.dll", SetLastError:=True)> _
    Public Function SQLFreeEnv(ByVal henv As Integer) As Short
    End Function
    <DllImport("odbc32.dll", SetLastError:=True)> _
    Public Function SQLFreeConnect(ByVal hdbc As Integer) As Short
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function GetAvailableServers() As String()
        Dim rc As Short
        Dim henv As Integer = 0
        Dim hdbc As Integer = 0
        Dim servers As String() = Nothing
        SQLAllocEnv(henv)
        SQLAllocConnect(henv, hdbc)
        Dim connectionString As String = "DRIVER={SQL Server}"
        '10k should be way enough
        Dim outString As New StringBuilder(10000)
        Dim realLength As Short = 0
        rc = SQLBrowseConnect(hdbc, connectionString, CInt(connectionString.Length), outString, CInt(outString.Capacity + 1), realLength)
        If rc = SQL_SUCCESS OrElse rc = SQL_NEED_DATA Then
            Dim serverString As String = outString.ToString()
            Dim i As Integer = serverString.ToLower().IndexOf("server={") + 8
            Dim pos As Integer = serverString.IndexOf("}"c, i)
            serverString = serverString.Substring(i, pos - i)
            servers = serverString.Split(","c)
        End If
        SQLDisconnect(hdbc)
        SQLFreeConnect(hdbc)
        SQLFreeEnv(henv)
        Return servers
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="serverName"></param>
    ''' <param name="integratedSecurity"></param>
    ''' <param name="userName"></param>
    ''' <param name="password"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDatabases(ByVal serverName As String, ByVal integratedSecurity As Boolean, ByVal userName As String, ByVal password As String) As String()
        Dim connectionString As String = String.Empty
        If integratedSecurity Then
            connectionString = [String].Format("initial catalog=master; Data Source={0};{1}pooling=false", serverName, (If(integratedSecurity, "integrated security=SSPI;", [String].Format("user id={0}; password={1};", userName, password))))
        Else
            connectionString = String.Format("Data Source={0};Network Library=DBMSSOCN;Initial Catalog={1};User ID={2};Password={3};", serverName, "master", userName, password)
        End If

        Dim adapter As New SqlDataAdapter("SELECT name FROM dbo.sysdatabases ORDER BY name", connectionString)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)
        Dim j As Integer = dataTable.Rows.Count
        Dim databases As String() = New String(j - 1) {}
        For i As Integer = 0 To (j - 1)
            Select Case dataTable.Rows(i)("name").ToString.Trim.ToUpper()
                Case "MASTER", "MODEL", "MSDB", "TEMPDB"
                    Exit Select
                Case Else
                    databases(i) = DirectCast(dataTable.Rows(i)("name"), String)
            End Select
        Next
        dataTable.Dispose()
        adapter.Dispose()
        Return databases
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="serverName"></param>
    ''' <param name="integratedSecurity"></param>
    ''' <param name="userName"></param>
    ''' <param name="password"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetCollations(ByVal serverName As String, ByVal integratedSecurity As Boolean, ByVal userName As String, ByVal password As String) As String()
        Dim collations As String() = Nothing
        Try
            Dim connectionString As String = [String].Format("initial catalog=master; Data Source={0};{1}pooling=false", serverName, (If(integratedSecurity, "integrated security=SSPI;", [String].Format("user id={0}; password={1};", userName, password))))
            Using adapter As New SqlDataAdapter("SELECT name FROM ::fn_helpcollations() order by name", connectionString)
                Using dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Dim j As Integer = dataTable.Rows.Count
                    collations = New String(j - 1) {}
                    For i As Integer = 0 To j - 1
                        collations(i) = DirectCast(dataTable.Rows(i)("name"), String)
                    Next
                End Using
            End Using
        Catch
        End Try
        Return collations
    End Function

    Public Function TestConnectToDatabase() As Boolean
        Try
            Try
                Return FreeSQLSuport.SimpleSql.Query("Select * from LICENSE ", SQLSERVERConnection.ConnectStringControls.ConnectionString(), SQLSERVERConnection.ConnectStringControls.Privider).FetchDataSet().Tables(0).Rows.Count > 0
            Catch ex As Exception
                Return False
            End Try
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    Public Function TestConnectToServer() As Boolean
        Try
            Try
                Return FreeSQLSuport.SimpleSql.Query("select database_id,name from sys.databases where name = 'master' and state = 0 ", SQLSERVERConnection.ConnectStringControls.ConnectionString(), SQLSERVERConnection.ConnectStringControls.Privider).FetchDataSet().Tables(0).Rows.Count > 0
            Catch ex As Exception
                Return False
            End Try
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    Public Function ValidateDatabaseName(ByVal nameData As String) As Boolean
        Try
            Try
                Return FreeSQLSuport.SimpleSql.Query(String.Format("select database_id,name from sys.databases where name = N'{0}' and state = 0 ", nameData), SQLSERVERConnection.ConnectStringControls.ConnectionString(), SQLSERVERConnection.ConnectStringControls.Privider).FetchDataSet().Tables(0).Rows.Count > 0
            Catch ex As Exception
                Return False
            End Try
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    Public Function ExcuteScriptSQL(ByVal sqlscript As String) As Boolean
        Try
            FreeSQLSuport.SimpleSql.Query(sqlscript, SQLSERVERConnection.ConnectStringControls.ConnectionString(), SQLSERVERConnection.ConnectStringControls.Privider).Execute()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module
