Imports System
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmMNHoadontuin
    Public Shared chonnut As Integer = -1
    Private Sub Cmd1_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Cmd1_0.Click, _Cmd1_1.Click, _Cmd1_2.Click, _Cmd1_3.Click, _Cmd1_4.Click, _Cmd1_5.Click
        Dim Index As Integer = Array.IndexOf(Cmd1, eventSender)
        Select Case Index
            Case 0
                FrmQuyetdinhapdunghoadontuin.ShowDialog()
            Case 1
                chonnut = 1
                Dim sql As String = "select count(name) as [Tontai] from sysobjects where Name = N'MAUHOADON'"
                Dim dt As DataTable
                Try
                    dt = ExecSQLReturnDT(sql)
                    If dt.Rows(0)("Tontai").ToString = 0 Then
                        sql = ""
                        sql += " CREATE TABLE [dbo].[MAUHOADON]"
                        sql += " ("
                        sql += " [id] [nvarchar](10) NOT NULL,"
                        sql += " [name] [nvarchar](50) NULL,"
                        sql += " [typebillID] [nvarchar](15) NULL,"
                        sql += " [path] [nvarchar](200) NULL,"
                        sql += " [numcontact] [int] NULL,"
                        sql += " [dong] [int] NULL,"
                        sql += " [Kyhieu] [nvarchar](15) NULL,"
                        sql += " [LoaiHD] [int] NULL,"
                        sql += " CONSTRAINT [PK_MAUHOADON] PRIMARY KEY CLUSTERED "
                        sql += " ("
                        sql += "              [id] ASC"
                        sql += " )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                        sql += " ) ON [PRIMARY]"
                        ExecSQLNonQuery(sql)
                        sql = "Alter table HoaDon add Status [bit]"
                        ExecSQLNonQuery(sql)
                        sql = "Update HoaDon set [Status] = 0"
                        ExecSQLNonQuery(sql)
                        sql = "Alter table HoaDon add LoaiHD [int]"
                        ExecSQLNonQuery(sql)
                        sql = "Update HoaDon set LoaiHD= 0"
                        ExecSQLNonQuery(sql)
                        sql = "Alter table HoaDon add Xuatkhau [int]"
                        ExecSQLNonQuery(sql)
                        sql = "Update HoaDon set Xuatkhau = 0"
                        ExecSQLNonQuery(sql)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Lỗi tạo bảng MAUHOADON " + ex.Message)
                End Try

                Dim sql_1 As String = "select count(name) as [Tontai] from sysobjects  where Name = N'CT_MAUHOADON'"
                Dim dt_1 As DataTable
                Try
                    dt_1 = ExecSQLReturnDT(sql_1)
                    If dt_1.Rows(0)("Tontai").ToString = 0 Then
                        Dim sql_3 As String = "CREATE TABLE [dbo].[CT_MAUHOADON]("
                        sql_3 += "[id] [nvarchar](10) NOT NULL,"
                        sql_3 += "[Mucdich] [nvarchar](50) NULL,"
                        sql_3 += "[Mau] [nvarchar](50) NULL,"
                        sql_3 += "[Lien] [int] NOT NULL,"
                        sql_3 += "[hinh_logo] [image] NULL,"
                        sql_3 += "[logo_nen] [image] NULL,"
                        sql_3 += "[hinh_nen] [image] NULL,"
                        sql_3 += " [size] [float] NULL,"
                        sql_3 += " [font] [nvarchar](30) NULL,"
                        sql_3 += "CONSTRAINT [PK_CT_MAUHOADON] PRIMARY KEY CLUSTERED ( [id] ASC, [Lien] ASC"
                        sql_3 += " )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ) ON [PRIMARY]"
                        ExecSQLNonQuery(sql_3)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Lỗi tạo bảng CT_MAUHOADON " + ex.Message)
                End Try
                'IF0005.ShowDialog()
                chonnut = -1
            Case 2
                FrmThongbaophathanhhoadon.ShowDialog()
            Case 3
                FrmQuanlydudunghoadon.ShowDialog()
            Case 4
                FrmMNBaocaobh.ShowDialog()
            Case 5
                frmSLHoaDon.ShowDialog()
        End Select
    End Sub
 
    Private Sub FrmHoadontuin_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub FrmHoadontuin_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub


    'Mau hoa don
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmLoaiHoaDon.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub sb_in_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sb_in.Click
        'FrmIN.ShowDialog()
    End Sub

    Private Sub FrmHoadontuin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If User_Right = 0 Then
            _Cmd1_1.Enabled = True
        Else
            _Cmd1_1.Enabled = False
        End If
        sb_in.Enabled = (GetSelectValue("select VT as f1 from users where maso=" + CStr(UserID)) Mod 10000000000) \ 1000000000 = 1
        SetFont(Me)
    End Sub
End Class
