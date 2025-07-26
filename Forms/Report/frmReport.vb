Imports System
Imports System.Data
Imports CrystalLibrary
Imports UNET.Utility
Imports System.Data.SqlClient
Imports UNET.DataAdapter

Public Class frmReport
    Public Const CONST_ReportPathKey As String = "ReportPath"

    Private _reportQuery As String
    Private _reportTableName As String
    Private _statusbarVisible As Boolean
    Private _toolbarVisible As Boolean
    Private _reportDataset As DataSet
    Private _reportTitle As String
    Private _reportWindowTitle As String
    Private _reportFilename As String
    Private _crystalHelper As New CrystalLibrary.CrystalHelper
    Private _reportDestination As Integer = 0
    Private _reportWindowState As System.Windows.Forms.FormWindowState

#Region "Properties"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportTableName() As String
        Get
            Return _reportTableName
        End Get
        Set(ByVal value As String)
            _reportTableName = value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportQuery() As String
        Get
            Return _reportQuery
        End Get
        Set(ByVal value As String)
            _reportQuery = value
            ReportDataset = ExecSQLReturnDSrp(_reportQuery, _reportTableName)
            _crystalHelper.DataSource = ReportDataset
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportWindowTitle() As String
        Get
            _reportWindowTitle = Me.Text
            Return _reportWindowTitle
        End Get
        Set(ByVal value As String)
            _reportWindowTitle = value
            Me.Text = _reportWindowTitle
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportWindowState() As System.Windows.Forms.FormWindowState
        Get
            _reportWindowState = Me.WindowState
            Return _reportWindowState
        End Get
        Set(ByVal value As System.Windows.Forms.FormWindowState)
            Me.WindowState = value
        End Set
    End Property
    
    ''' <summary>
    ''' Get or set Crystal report report destinsation
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportDestination() As Integer
        Get
            Return _reportDestination
        End Get
        Set(ByVal value As Integer)
            _reportDestination = value
        End Set
    End Property
    ''' <summary>
    ''' Get or set Crystal report report filename
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportFilename() As String
        Get
            Return _reportFilename
        End Get
        Set(ByVal value As String)
            _reportFilename = getReportFullPath(value)
            'InitForm(_reportTitle, _reportQuery, _reportTableName, _reportTitle)
        End Set
    End Property
    ''' <summary>
    ''' Get or set Crystal report helper object
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CrystalHelper() As CrystalLibrary.CrystalHelper
        Get
            If _crystalHelper Is Nothing Then
                _crystalHelper = New CrystalLibrary.CrystalHelper
            End If
            Return _crystalHelper
        End Get
        Set(ByVal value As CrystalLibrary.CrystalHelper)
            _crystalHelper = value
        End Set
    End Property
    ''' <summary>
    ''' Get or set status visible
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property StatusBarVisible() As Boolean
        Get
            Return _statusbarVisible
        End Get
        Set(ByVal value As Boolean)

            _statusbarVisible = value
        End Set
    End Property
    ''' <summary>
    ''' Get or set tab visible
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ToolBarVisible() As Boolean
        Get
            Return _toolbarVisible
        End Get
        Set(ByVal value As Boolean)

            _toolbarVisible = value
        End Set
    End Property
    ''' <summary>
    ''' Get or set status report dataset
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportDataset() As DataSet
        Get
            Return _reportDataset
        End Get
        Set(ByVal value As DataSet)

            _reportDataset = value
        End Set
    End Property
    ''' <summary>
    ''' Get or set status report title
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportTitle() As String
        Get
            Return _reportTitle
        End Get
        Set(ByVal value As String)

            _reportTitle = value
        End Set
    End Property
#End Region

#Region "Construction"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub InitForm(ByVal ReportFile As String, ByVal Query As String, ByVal TableNames As String, Optional ByRef xem As Integer = 1)
        InitForm(ReportFile, Query, TableNames, "Báo cáo", xem)
    End Sub
    
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks> 
    Sub InitForm(ByVal ReportFile As String, ByVal Query As String, ByVal TableNames As String, ByVal ReportTitle As String, Optional ByRef xem As Integer = 1)
        Cursor = Cursors.WaitCursor
        _statusbarVisible = True
        _toolbarVisible = True
        _reportTitle = ReportTitle
        _reportDestination = 1 - xem  'window port
        _reportQuery = Query
        _reportTableName = TableNames

        _reportDataset = New DataSet


        ReportFile = getReportFullPath(ReportFile)
        If Not RptOK(ReportFile, 0) Then
            myUMessager.mWarning("Mẫu báo cáo đã bị thay đổi!", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If File.Exists(ReportFile) Then
            _reportFilename = ReportFile

            Dim _IntegratedSecurity As Boolean = True
            _IntegratedSecurity = (SQLSERVERConnection.ConnectStringControls.SqlAuthentication = False)
            _crystalHelper = New CrystalHelper(_reportFilename) With {.ServerName = SQLSERVERConnection.ConnectStringControls.DataSource, .DatabaseName = SQLSERVERConnection.ConnectStringControls.Database, .UserId = SQLSERVERConnection.ConnectStringControls.UserName, .Password = SQLSERVERConnection.ConnectStringControls.Password, .IntegratedSecurity = _IntegratedSecurity}

            'Get data
            _reportDataset = ExecSQLReturnDSrp(Query, TableNames)
            _crystalHelper.DataSource = ReportDataset

            If xem = 1 Then _crystalHelper.Open()
            Text = My.Application.Info.Title
        Else
            myUMessager.mError(String.Format("Không tìm thấy mẫu báo cáo ""{0}""{1}\nXin kiểm tra lai đường dẫn bên dưới hoặc liên hệ nhà cung cấp {1}Đường dẫn: {2}", _
                                    Path.GetFileNameWithoutExtension(ReportFilename), _
                                    vbCrLf, _
                                    ReportFilename), _
                "Không tìm thấy mẫu báo cáo", _
                MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End If
        Cursor = Cursors.Default
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getReportFullPath(ByVal reportTemplateFilename As String) As String
        If reportTemplateFilename IsNot Nothing Then
            If reportTemplateFilename.IndexOf("\") = -1 Then
                reportTemplateFilename = System.IO.Path.Combine(GetReportFolder(), reportTemplateFilename)
            End If
        End If
        Return reportTemplateFilename
    End Function
    ''' <summary>
    ''' Set report parameter
    ''' </summary>
    ''' <param name="pIndex"></param>
    ''' <param name="pValue"></param>
    ''' <remarks></remarks>
    Public Sub SetParameterValue(ByVal pIndex As Integer, ByVal pValue As String)
        Try
            ' _crystalHelper.ReportSource.SetFormulas(pIndex, pValue)
            CrystalHelper.ReportSource.DataDefinition.ParameterFields(pIndex).PromptText = pValue
        Catch ex As Exception
        End Try
    End Sub


    ' Set report parameter

    Public Sub SetParameterValue(ByVal pName As String, ByVal pValue As String)
        Try
            CrystalHelper.ReportSource.DataDefinition.ParameterFields(pName).PromptText = pValue
        Catch ex As Exception
        End Try
    End Sub

    ' Set report fomulars

    Public Sub SetFormulas(ByVal fValue As String)
        Try
            Dim fName As String = ""
            Dim fIndex As Integer = -1
            Try
                Dim fTemp() As String = fValue.Split("=")
                fName = ConvertToDblSafe(fTemp(0), -1)
                fValue = fTemp(1).Trim
                For Each fField As FormulaFieldDefinition In CrystalHelper.ReportSource.DataDefinition.FormulaFields
                    fIndex += 1
                    If fField.Name = fName Then
                        Exit For
                    End If
                Next
            Catch ex As Exception
            End Try

            If fIndex > -1 Then
                SetFormulas(fIndex, fValue)
            End If
        Catch ex As Exception
        End Try
    End Sub
    ''' <summary>
    ''' Set report fomulars
    ''' </summary>
    ''' <param name="fIndex"></param>
    ''' <param name="fValue"></param>
    ''' <remarks></remarks>
    Public Sub SetFormulas(ByVal fIndex As Integer, ByVal fValue As String)
        Try
            Dim fField As CrystalDecisions.CrystalReports.Engine.FormulaFieldDefinition
            fField = CrystalHelper.ReportSource.DataDefinition.FormulaFields(fIndex)

            fField.Text = fValue
        Catch ex As Exception
        End Try
    End Sub

    ' Set report fomulars

    Public Sub SetFormulas(ByVal fName As String, ByVal fValue As String)
        Try
            'If fValue <> "''" Then
            fValue = String.Format("'{0}'", fValue).Replace("''", "'")
            'End If

            CrystalHelper.ReportSource.DataDefinition.FormulaFields(fName).Text = fValue
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SetFormulas(ByVal fName As String, ByVal fValue As Date)
        Try
            CrystalHelper.ReportSource.DataDefinition.FormulaFields(fName).Text = fValue
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SetFormulas(ByVal fName As String, ByVal fValue As Double)
        Try
            'If fValue <> "''" Then
            fValue = String.Format("{0}", fValue).Replace("'", "")
            'End If

            CrystalHelper.ReportSource.DataDefinition.FormulaFields(fName).Text = fValue
        Catch ex As Exception
        End Try
    End Sub

    ' Set report fomulars

    Public Function GetFormulas(ByVal fName As String) As String
        Try
            For Each formularItem As CrystalDecisions.CrystalReports.Engine.FormulaFieldDefinition In _crystalHelper.ReportSource.DataDefinition.FormulaFields
                If UCase(formularItem.Name) = UCase(fName) Then
                    Return formularItem.Text
                    Exit For
                End If
            Next
        Catch ex As Exception
            Return String.Empty
        End Try
        Return String.Empty
    End Function

    ' Set report fomulars

    Public Function GetFormulas(ByVal fIndex As Integer) As String
        Try
            Return CrystalHelper.ReportSource.DataDefinition.FormulaFields(fIndex).Text
        Catch ex As Exception
            Return String.Empty
        End Try
        Return String.Empty
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub fixReportObjectsFont()
        'Dim rcd As CrystalDecisions.ReportAppServer.ClientDoc.ISCDReportClientDocument
        'rcd = _crystalHelper.ReportSource.ReportClientDocument

        'For Each area As CrystalDecisions.CrystalReports.Engine.Area In _crystalHelper.ReportSource.ReportDefinition.Areas
        '    For Each section As CrystalDecisions.CrystalReports.Engine.Section In area.Sections
        '        For Each obj As CrystalDecisions.CrystalReports.Engine.ReportObject In section.ReportObjects
        '            If obj.Kind = CrystalDecisions.Shared.ReportObjectKind.FieldObject Then
        '                'Dim objField As CrystalDecisions.ReportAppServer.ReportDefModel.FieldObject = CType(rcd.ReportDefController.ReportObjectController.GetAllReportObjects().Item(obj.Name), CrystalDecisions.ReportAppServer.ReportDefModel.FieldObject)
        '                'objField.FontColor.Font.Name = "Times New Roman"
        '                'rcd.ReportDefController.ReportObjectController.Modify(CType(rcd.ReportDefController.ReportObjectController.GetAllReportObjects().Item(obj.Name), CrystalDecisions.ReportAppServer.ReportDefModel.FieldObject), objField)
        '            ElseIf obj.Kind = CrystalDecisions.Shared.ReportObjectKind.TextObject Then
        '                Dim objText As CrystalDecisions.ReportAppServer.ReportDefModel.TextObject = CType(rcd.ReportDefController.ReportObjectController.GetAllReportObjects().Item(obj.Name), CrystalDecisions.ReportAppServer.ReportDefModel.TextObject)
        '                ' If objText.Text.IndexOf("@") > -1 Then
        '                objText.FontColor.Font.Name = "Times New Roman"
        '                rcd.ReportDefController.ReportObjectController.Modify(CType(rcd.ReportDefController.ReportObjectController.GetAllReportObjects().Item(obj.Name), CrystalDecisions.ReportAppServer.ReportDefModel.TextObject), objText)
        '                'End If
        '            End If
        '        Next
        '    Next
        'Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetReportFolder() As String
        Dim settingReportFolder As String = String.Empty
        'settingReportFolder = ConfigurationManager.ConnectionStrings(CONST_ReportPathKey).ConnectionString

        If String.IsNullOrEmpty(settingReportFolder) Then
            settingReportFolder = String.Format("{0}\{1}Reports", Path.GetFullPath(Application.StartupPath), IIf(pNN = 1, "E", "")).Replace("\\", "\")
        Else
            settingReportFolder = Path.GetFullPath(settingReportFolder)
        End If

        Return settingReportFolder
    End Function

    Public Function copyReportObject(ByRef _object) As frmReport
        Dim reportNew As New frmReport()
        reportNew._crystalHelper = Me._crystalHelper
        reportNew._reportDataset = Me._reportDataset
        reportNew._reportDestination = Me._reportDestination
        reportNew._reportFilename = Me._reportFilename
        reportNew._reportQuery = Me._reportQuery
        reportNew._reportTableName = Me._reportTableName
        reportNew._reportTitle = Me._reportTitle
        reportNew._reportWindowState = Me._reportWindowState
        reportNew._reportWindowTitle = Me._reportWindowTitle
        reportNew._statusbarVisible = Me._statusbarVisible
        reportNew._toolbarVisible = Me._toolbarVisible
        copyReportObject = reportNew
    End Function

    ''' <summary>
    ''' Show - print or export report
    ''' </summary>
    ''' <remarks></remarks>
    Public Function DoReport() As String
        Cursor = Cursors.WaitCursor
        Try
            With CrystalReportViewer1
                .DisplayToolbar = ToolBarVisible
                .DisplayStatusBar = StatusBarVisible
                .ReportSource = CrystalHelper.ReportSource
                '.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

            End With

            Select Case ReportDestination
                Case 0
                    'ShowDialog()
                    Show()
                    Me.Activate()
                    Exit Select
                Case 1
                    CrystalHelper.Print()
                    Exit Select
                Case -1
                    Dim dlg As New SaveFileDialog()
                    dlg.Filter = CrystalHelper.ExportFilter
                    If dlg.ShowDialog(Me) = DialogResult.OK Then
                        _crystalHelper.Export(dlg.FileName)
                    End If
                    Exit Select
            End Select
            Return String.Empty
        Catch ex As Exception
            myUMessager.mError(String.Format("Mô tả lỗi: {0}{1}", Environment.NewLine, ex), _
                String.Format("{0} - Lỗi", ReportTitle), _
                MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
            Return ex.ToString
        Finally
            Cursor = Cursors.Default
            MemoryHelper.ReleaseMemory()
        End Try
    End Function
#End Region

    Private Sub frmReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class