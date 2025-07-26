Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports FreeSQLSuport
Imports FreeSQLSuport.SimpleSql
Imports UNET.SQLSERVERConnection


Public Class DataAdapter

    Public Shared Function ExecSQLNonQueryByStoreProcedure(ByVal spName As String, ByVal listParameter() As String, ByVal listValues() As String) As Integer
        Dim result As Integer = 0
        Try
            If listParameter.Length = 1 Then
                SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)).Execute()
            ElseIf listParameter.Length = 2 Then
                SimpleSql.StoredProcedure(spName).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)).Execute()
            ElseIf listParameter.Length = 3 Then
                SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)).Execute()
            ElseIf listParameter.Length = 4 Then
                SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)) _
                .AddParameter(listParameter(3), listValues(3)).Execute()
            ElseIf listParameter.Length = 5 Then
                SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)) _
                .AddParameter(listParameter(3), listValues(3)) _
                .AddParameter(listParameter(4), listValues(4)).Execute()
            ElseIf listParameter.Length = 6 Then
                SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)) _
                .AddParameter(listParameter(3), listValues(3)) _
                .AddParameter(listParameter(4), listValues(4)) _
                .AddParameter(listParameter(5), listValues(5)).Execute()
            ElseIf listParameter.Length = 7 Then
                SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)) _
                .AddParameter(listParameter(3), listValues(3)) _
                .AddParameter(listParameter(4), listValues(4)) _
                .AddParameter(listParameter(5), listValues(5)) _
                .AddParameter(listParameter(6), listValues(6)).Execute()
            ElseIf listParameter.Length = 8 Then
                SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)) _
                .AddParameter(listParameter(3), listValues(3)) _
                .AddParameter(listParameter(4), listValues(4)) _
                .AddParameter(listParameter(5), listValues(5)) _
                .AddParameter(listParameter(6), listValues(6)) _
                .AddParameter(listParameter(7), listValues(7)).Execute()
            ElseIf listParameter.Length = 9 Then
                SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)) _
                .AddParameter(listParameter(3), listValues(3)) _
                .AddParameter(listParameter(4), listValues(4)) _
                .AddParameter(listParameter(5), listValues(5)) _
                .AddParameter(listParameter(6), listValues(6)) _
                .AddParameter(listParameter(7), listValues(7)) _
                .AddParameter(listParameter(8), listValues(8)).Execute()
            ElseIf listParameter.Length = 10 Then
                SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)) _
                .AddParameter(listParameter(3), listValues(3)) _
                .AddParameter(listParameter(4), listValues(4)) _
                .AddParameter(listParameter(5), listValues(5)) _
                .AddParameter(listParameter(6), listValues(6)) _
                .AddParameter(listParameter(7), listValues(7)) _
                .AddParameter(listParameter(8), listValues(8)) _
                .AddParameter(listParameter(9), listValues(9)).Execute()
            ElseIf listParameter.Length = 11 Then
                SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)) _
                .AddParameter(listParameter(3), listValues(3)) _
                .AddParameter(listParameter(4), listValues(4)) _
                .AddParameter(listParameter(5), listValues(5)) _
                .AddParameter(listParameter(6), listValues(6)) _
                .AddParameter(listParameter(7), listValues(7)) _
                .AddParameter(listParameter(8), listValues(8)) _
                .AddParameter(listParameter(9), listValues(9)) _
                .AddParameter(listParameter(10), listValues(10)).Execute()
            ElseIf listParameter.Length = 12 Then
                SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)) _
                .AddParameter(listParameter(3), listValues(3)) _
                .AddParameter(listParameter(4), listValues(4)) _
                .AddParameter(listParameter(5), listValues(5)) _
                .AddParameter(listParameter(6), listValues(6)) _
                .AddParameter(listParameter(7), listValues(7)) _
                .AddParameter(listParameter(8), listValues(8)) _
                .AddParameter(listParameter(9), listValues(9)) _
                .AddParameter(listParameter(10), listValues(10)) _
                .AddParameter(listParameter(11), listValues(11)).Execute()
            End If
        Catch ex As Exception
            result = Information.Err().Number
            Throw New System.Exception(ex.Message)
        End Try
        Return result
    End Function

    '
    Public Shared Function ExecSQLNonQueryByStoreProcedure(ByVal spName As String) As Integer
        Dim result As Integer = 0
        Try
            SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).Execute()
        Catch ex As Exception
            result = Information.Err().Number
            Throw New System.Exception(ex.Message)
        End Try
        Return result
    End Function

    '''

    Public Shared Function ExecSQLReturnDTByStoreProcedure(ByVal spName As String, ByVal listParameter() As String, ByVal listValues() As String) As DataTable
        Dim result As DataTable
        Try
            If listParameter.Length = 1 Then
                result = SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)).FetchDataSet.Tables(0)
            ElseIf listParameter.Length = 2 Then
                result = SimpleSql.StoredProcedure(spName).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)).FetchDataSet.Tables(0)
            ElseIf listParameter.Length = 3 Then
                result = SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)).FetchDataSet.Tables(0)
            ElseIf listParameter.Length = 4 Then
                result = SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)) _
                .AddParameter(listParameter(3), listValues(3)).FetchDataSet.Tables(0)
            ElseIf listParameter.Length = 5 Then
                result = SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)) _
                .AddParameter(listParameter(3), listValues(3)) _
                .AddParameter(listParameter(4), listValues(4)).FetchDataSet.Tables(0)
            ElseIf listParameter.Length = 6 Then
                result = SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)) _
                .AddParameter(listParameter(3), listValues(3)) _
                .AddParameter(listParameter(4), listValues(4)) _
                .AddParameter(listParameter(5), listValues(5)).FetchDataSet.Tables(0)
            ElseIf listParameter.Length = 7 Then
                result = SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)) _
                .AddParameter(listParameter(3), listValues(3)) _
                .AddParameter(listParameter(4), listValues(4)) _
                .AddParameter(listParameter(5), listValues(5)) _
                .AddParameter(listParameter(6), listValues(6)).FetchDataSet.Tables(0)
            ElseIf listParameter.Length = 8 Then
                result = SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)) _
                .AddParameter(listParameter(3), listValues(3)) _
                .AddParameter(listParameter(4), listValues(4)) _
                .AddParameter(listParameter(5), listValues(5)) _
                .AddParameter(listParameter(6), listValues(6)) _
                .AddParameter(listParameter(7), listValues(7)).FetchDataSet.Tables(0)
            ElseIf listParameter.Length = 9 Then
                result = SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)) _
                .AddParameter(listParameter(3), listValues(3)) _
                .AddParameter(listParameter(4), listValues(4)) _
                .AddParameter(listParameter(5), listValues(5)) _
                .AddParameter(listParameter(6), listValues(6)) _
                .AddParameter(listParameter(7), listValues(7)) _
                .AddParameter(listParameter(8), listValues(8)).FetchDataSet.Tables(0)
            ElseIf listParameter.Length = 10 Then
                result = SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)) _
                .AddParameter(listParameter(3), listValues(3)) _
                .AddParameter(listParameter(4), listValues(4)) _
                .AddParameter(listParameter(5), listValues(5)) _
                .AddParameter(listParameter(6), listValues(6)) _
                .AddParameter(listParameter(7), listValues(7)) _
                .AddParameter(listParameter(8), listValues(8)) _
                .AddParameter(listParameter(9), listValues(9)).FetchDataSet.Tables(0)
            ElseIf listParameter.Length = 11 Then
                result = SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)) _
                .AddParameter(listParameter(3), listValues(3)) _
                .AddParameter(listParameter(4), listValues(4)) _
                .AddParameter(listParameter(5), listValues(5)) _
                .AddParameter(listParameter(6), listValues(6)) _
                .AddParameter(listParameter(7), listValues(7)) _
                .AddParameter(listParameter(8), listValues(8)) _
                .AddParameter(listParameter(9), listValues(9)) _
                .AddParameter(listParameter(10), listValues(10)).FetchDataSet.Tables(0)
            ElseIf listParameter.Length = 12 Then
                result = SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).AddParameter(listParameter(0), listValues(0)) _
                .AddParameter(listParameter(1), listValues(1)) _
                .AddParameter(listParameter(2), listValues(2)) _
                .AddParameter(listParameter(3), listValues(3)) _
                .AddParameter(listParameter(4), listValues(4)) _
                .AddParameter(listParameter(5), listValues(5)) _
                .AddParameter(listParameter(6), listValues(6)) _
                .AddParameter(listParameter(7), listValues(7)) _
                .AddParameter(listParameter(8), listValues(8)) _
                .AddParameter(listParameter(9), listValues(9)) _
                .AddParameter(listParameter(10), listValues(10)) _
                .AddParameter(listParameter(11), listValues(11)).FetchDataSet.Tables(0)
            End If
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
        Return result
    End Function

    Public Shared Function ExecSQLReturnDTByStoreProcedure(ByVal spName As String) As DataTable
        Dim result As DataTable
        Try
            result = SimpleSql.StoredProcedure(spName, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).FetchDataSet.Tables(0)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
        Return result
    End Function

    ''' <summary>
    ''' Execute Sql command text non query
    ''' </summary>
    ''' <param name="SQLCommandText">SQL command text</param>
    ''' <remarks></remarks>
    Public Shared Function ExecSQLNonQuery(ByVal SQLCommandText As String) As Integer
        Dim result As Integer = 0
        Try
            SimpleSql.Query(SQLCommandText, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).Execute()
        Catch ex As Exception
            result = Information.Err().Number
            Throw New System.Exception(ex.Message)
        End Try
        Return result
    End Function

    ''' <summary>
    ''' Execute Sql command text non query
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Function ExecSQLNonQuery(ByVal sql As String, ByVal msg As Boolean) As Integer
        Dim result As Integer = -1
        Try
            SimpleSql.Query(sql, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).Execute()
            result = 0
        Catch ex As Exception
            result = Information.Err().Number
            If msg Then
                Dim messageSt As String = ex.ToString
                Select Case result
                    Case 5
                        messageSt = "Trùng lặp số hiệu, tên... !"
                End Select
                If Not String.IsNullOrEmpty(messageSt) Then
                    myUMessager.mError(messageSt, _
                     My.Computer.Name, _
                     MessageBoxButtons.OK, _
                     MessageBoxIcon.Exclamation)
                End If

            End If
        End Try
        Return result
    End Function

    '''
    ' ExecSQLNonQueryUpdateInsertDeleteQuery
    '''
    Public Shared Function ExecSQLNonQueryUpdateInsertDeleteQuery(ByVal SQLCommandText As String) As Integer
        Dim result As Integer = -1
        Using con As New SqlConnection   'Create object connection
            Try
                con.ConnectionString = ConnectStringControls.ConnectionString() 'Set ConnectionString                
                con.Open()  'Open the connection
                Using cmd As New SqlCommand  'Create command object
                    cmd.CommandText = SQLCommandText 'Set commandText
                    cmd.CommandType = CommandType.Text 'Set the commandType
                    cmd.Connection = con  'Set the connection object that will be used
                    result = cmd.ExecuteNonQuery() 'Execute the query
                End Using
            Catch ex As Exception
                result = -1
            Finally
                If con.State = ConnectionState.Open Or con.State = ConnectionState.Connecting Then
                    con.Close()
                End If
            End Try
        End Using
        Return result
    End Function

    ''' <summary>
    ''' Execute Sql command text non query
    ''' </summary>
    ''' <param name="SQLCommandText">SQL command text</param>
    ''' <remarks></remarks>
    Public Shared Function ExecSQLNonQueryRF(ByVal SQLCommandText As String) As Integer
        Dim result As Integer = -1
        Try
            SimpleSql.Query(SQLCommandText, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).Execute()
            result = 0
        Catch ex As Exception
            result = -1
        End Try
        Return result
    End Function
    ''' <summary>
    ''' Execute Sql command text AND return Data TABLE
    ''' </summary>
    ''' <param name="SQLCommandText">SQL command text</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ExecSQLReturnDT(ByVal SQLCommandText As String) As DataTable
        Dim dt As DataTable = New DataTable()
        Try
            If SQLCommandText <> String.Empty Then
                dt = SimpleSql.Query(SQLCommandText, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).FetchDataSet().Tables(0)
            End If
        Catch ex As Exception
            Throw New ApplicationException(ex.Message)
        End Try
        Return dt
    End Function
    ''' <summary>
    ''' Execute Sql command text AND return Data SET
    ''' </summary>
    ''' <param name="SQLCommandText">SQL command text</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ExecSQLReturnDS(ByVal SQLCommandText As String) As DataSet
        Try
            Return SimpleSql.Query(SQLCommandText, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).FetchDataSet()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return Nothing
    End Function
    ''' <summary>
    ''' Execute Sql command text AND return Data SET
    ''' </summary>
    ''' <param name="SQLCommandText">SQL command text</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ExecSQLReturnDSrp(ByVal SQLCommandText As String, ByVal TableNames As String) As DataSet

        Try
            Dim ds As DataSet = SimpleSql.Query(SQLCommandText, ConnectStringControls.ConnectionString(), ConnectStringControls.Privider).FetchDataSet()
            ds.Tables(0).TableName = TableNames
            Return ds
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return Nothing
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="SoPhu"></param>
    ''' <param name="SoPhu2"></param>
    ''' <param name="SoPhu3"></param>
    ''' <param name="SoPhu4"></param>
    ''' <param name="SoPhu5"></param>
    ''' <param name="SoPhu6"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetSelectValueDB(ByVal connecstring As String, _
            ByVal sql As String, _
            Optional ByRef SoPhu As Object = Nothing, _
            Optional ByRef SoPhu2 As Object = Nothing, _
            Optional ByRef SoPhu3 As Object = Nothing, _
            Optional ByRef SoPhu4 As Object = Nothing, _
            Optional ByRef SoPhu5 As Object = Nothing, _
            Optional ByRef SoPhu6 As Object = Nothing, _
            Optional ByRef SoPhu7 As Object = Nothing, _
            Optional ByRef SoPhu8 As Object = Nothing, _
            Optional ByRef SoPhu9 As Object = Nothing, _
            Optional ByRef SoPhu10 As Object = Nothing) As Object
        Dim result As Object = 0
        If Not TypeOf (SoPhu) Is DateTime Then SoPhu = 0
        If Not TypeOf (SoPhu2) Is DateTime Then SoPhu2 = 0
        If Not TypeOf (SoPhu3) Is DateTime Then SoPhu3 = 0
        If Not TypeOf (SoPhu4) Is DateTime Then SoPhu4 = 0
        If Not TypeOf (SoPhu5) Is DateTime Then SoPhu5 = 0
        If Not TypeOf (SoPhu6) Is DateTime Then SoPhu6 = 0
        If Not TypeOf (SoPhu7) Is DateTime Then SoPhu7 = 0
        If Not TypeOf (SoPhu8) Is DateTime Then SoPhu8 = 0
        If Not TypeOf (SoPhu9) Is DateTime Then SoPhu9 = 0
        If Not TypeOf (SoPhu10) Is DateTime Then SoPhu10 = 0
        Try
            Dim returnDT As DataTable = ExecSQLReturnDT(sql)
            If returnDT.Rows.Count > 0 Then
                Try
                    If Not IsDBNull(returnDT.Rows(0)("F1")) Then
                        result = returnDT.Rows(0)("F1")
                        If returnDT.Columns("F2") IsNot Nothing Then
                            SoPhu = returnDT.Rows(0)("F2")
                        End If

                        If returnDT.Columns("F3") IsNot Nothing Then
                            SoPhu2 = returnDT.Rows(0)("F3")
                        End If

                        If returnDT.Columns("F4") IsNot Nothing Then
                            SoPhu3 = returnDT.Rows(0)("F4")
                        End If

                        If returnDT.Columns("F5") IsNot Nothing Then
                            SoPhu4 = returnDT.Rows(0)("F5")
                        End If

                        If returnDT.Columns("F6") IsNot Nothing Then
                            SoPhu5 = returnDT.Rows(0)("F6")
                        End If

                        If returnDT.Columns("F7") IsNot Nothing Then
                            SoPhu6 = returnDT.Rows(0)("F7")
                        End If

                        If returnDT.Columns("F8") IsNot Nothing Then
                            SoPhu7 = returnDT.Rows(0)("F8")
                        End If

                        If returnDT.Columns("F9") IsNot Nothing Then
                            SoPhu8 = returnDT.Rows(0)("F9")
                        End If

                        If returnDT.Columns("F10") IsNot Nothing Then
                            SoPhu9 = returnDT.Rows(0)("F10")
                        End If

                        If returnDT.Columns("F11") IsNot Nothing Then
                            SoPhu10 = returnDT.Rows(0)("F11")
                        End If

                    End If
                Catch ex As Exception

                End Try
            End If
            returnDT = Nothing
        Catch ex As Exception

        End Try

        Return result
    End Function

    Public Shared Function GetSelectValue(ByVal sql As String, _
                Optional ByRef SoPhu As Object = Nothing, _
                Optional ByRef SoPhu2 As Object = Nothing, _
                Optional ByRef SoPhu3 As Object = Nothing, _
                Optional ByRef SoPhu4 As Object = Nothing, _
                Optional ByRef SoPhu5 As Object = Nothing, _
                Optional ByRef SoPhu6 As Object = Nothing, _
                Optional ByRef SoPhu7 As Object = Nothing, _
                Optional ByRef SoPhu8 As Object = Nothing, _
                Optional ByRef SoPhu9 As Object = Nothing, _
                Optional ByRef SoPhu10 As Object = Nothing) As Object
        Dim result As Object = 0
        If Not TypeOf (SoPhu) Is DateTime Then SoPhu = 0
        If Not TypeOf (SoPhu2) Is DateTime Then SoPhu2 = 0
        If Not TypeOf (SoPhu3) Is DateTime Then SoPhu3 = 0
        If Not TypeOf (SoPhu4) Is DateTime Then SoPhu4 = 0
        If Not TypeOf (SoPhu5) Is DateTime Then SoPhu5 = 0
        If Not TypeOf (SoPhu6) Is DateTime Then SoPhu6 = 0
        If Not TypeOf (SoPhu7) Is DateTime Then SoPhu7 = 0
        If Not TypeOf (SoPhu8) Is DateTime Then SoPhu8 = 0
        If Not TypeOf (SoPhu9) Is DateTime Then SoPhu9 = 0
        If Not TypeOf (SoPhu10) Is DateTime Then SoPhu10 = 0
        Try
            Dim returnDT As DataTable = ExecSQLReturnDT(sql)

            If returnDT.Rows.Count > 0 Then
                Try
                    If Not IsDBNull(returnDT.Rows(0)("F1")) Then
                        result = returnDT.Rows(0)("F1")
                        If returnDT.Columns("F2") IsNot Nothing Then
                            SoPhu = returnDT.Rows(0)("F2")
                        End If

                        If returnDT.Columns("F3") IsNot Nothing Then
                            SoPhu2 = returnDT.Rows(0)("F3")
                        End If

                        If returnDT.Columns("F4") IsNot Nothing Then
                            SoPhu3 = returnDT.Rows(0)("F4")
                        End If

                        If returnDT.Columns("F5") IsNot Nothing Then
                            SoPhu4 = returnDT.Rows(0)("F5")
                        End If

                        If returnDT.Columns("F6") IsNot Nothing Then
                            SoPhu5 = returnDT.Rows(0)("F6")
                        End If

                        If returnDT.Columns("F7") IsNot Nothing Then
                            SoPhu6 = returnDT.Rows(0)("F7")
                        End If

                        If returnDT.Columns("F8") IsNot Nothing Then
                            SoPhu7 = returnDT.Rows(0)("F8")
                        End If

                        If returnDT.Columns("F9") IsNot Nothing Then
                            SoPhu8 = returnDT.Rows(0)("F9")
                        End If

                        If returnDT.Columns("F10") IsNot Nothing Then
                            SoPhu9 = returnDT.Rows(0)("F10")
                        End If

                        If returnDT.Columns("F11") IsNot Nothing Then
                            SoPhu10 = returnDT.Rows(0)("F11")
                        End If

                    End If
                Catch ex As Exception

                End Try
            End If
            returnDT.Dispose()
            returnDT = Nothing
        Catch ex As Exception

        End Try

        Return result
    End Function

    Public Sub EX_PA(ByVal sql As String, ByVal pa As SqlParameter())

    End Sub
End Class
