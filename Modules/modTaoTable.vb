Imports System
Imports System.Data
Imports UNET.Utility
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Module modTaoTable

    Private sql As String = String.Empty

    Sub UpdateChungtu()
        If Not TruongDaCo("ChungTu", "NgayNo") Then
            ExecSQLNonQuery("ALTER TABLE ChungTu add NgayNo [datetime] null")
            ExecSQLNonQuery("UPDATE chungtu SET ngayno=ngayct")
        End If
        If Not TruongDaCo("ChungTu2", "NgayNo") Then
            ExecSQLNonQuery("ALTER TABLE ChungTu2 add NgayNo [datetime] null")
            ExecSQLNonQuery("UPDATE chungtu2 SET ngayno=ngayct")
        End If
    End Sub

    Sub Updatelicense()
        If Not TruongDaCo("license", "tncn") Then
            ExecSQLNonQuery("ALTER TABLE license ADD tncn NUMERIC NULL, giacanh NUMERIC NULL")
            ExecSQLNonQuery("UPDATE license SET tncn=4000000, giacanh=1600000")
            ExecSQLNonQuery("ALTER TABLE ChamCong ADD tncn NUMERIC NULL, giacanh NUMERIC NULL")
            ExecSQLNonQuery("UPDATE ChamCong SET tncn=4000000, giacanh=1600000")
            ExecSQLNonQuery("ALTER TABLE Bangluong ADD tncn NUMERIC NULL, giacanh NUMERIC NULL")
            ExecSQLNonQuery("UPDATE Bangluong SET tncn=4000000, giacanh=1600000")
        End If
    End Sub

    Sub Updateuser()
        If Not TruongDaCo("users", "UP") Then
            ExecSQLNonQuery("ALTER TABLE users ADD UP NUMERIC NULL")
            ExecSQLNonQuery("UPDATE users SET up=0")
        End If
    End Sub

    Sub CreateDangky()
        If Not BangDaCo("dangky") Then
            sql = "CREATE TABLE [dbo].[dangky]( [DateContract] [nvarchar](50) NULL,	[TypePro] [nvarchar](50) NULL,[IDContract] [nvarchar](50) NULL,	[TaxCode] [nvarchar](50) NULL,	[Customer] [nvarchar](50) NULL,	[License] [nvarchar](50) NULL, [License_temp] [nvarchar](50) NULL, [DateRegister] [nvarchar](50) NULL, [DaysRemain] [nvarchar](50) NULL) ON [PRIMARY]"
            ExecSQLNonQuery(sql)
        End If
    End Sub

    Sub CreateDangkynew()
        If Not BangDaCo("dangkynew") Then
            'sql = String.Format("CREATE TABLE [dbo].[dangkynew] ( "  _
            '                                 "  [NoCompid] [nvarchar] (50)  NOT NULL , "  _
            '                                 "  [MSP] [nvarchar] (30)  NOT NULL ,"  _
            '                                 "  [Smay] [nvarchar] (30)  NOT NULL ,"  _
            '                                 "  [NameCty] [nvarchar] (300)  NOT NULL ,"  _
            '                                 "  [MST] [nvarchar] (300)  NOT NULL ,"  _
            '                                 "  [AddressCty] [nvarchar] (300)  NOT NULL,"  _
            '                                 "  [Day_u] [nvarchar] (50)  NOT NULL,"  _
            '                                 "  [Month_u] [nvarchar] (50)  NOT NULL,"  _
            '                                 "  [Year_u] [nvarchar] (50)  NOT NULL,"  _
            '                                 "  [License] [nvarchar] (300)  NOT NULL,"  _
            '                                 "  [ActiveKey] [nvarchar] (300)  NULL,"  _
            '                                 "  [Trail] [nvarchar] (300)  NOT NULL,"  _
            '                                 "  [MaMay] [nvarchar] (300)  NOT NULL"  _
            '                                 "  [MaMayChu] [nvarchar] (300)  NOT NULL"  _
            '                                 " ) ON [PRIMARY]")
            ExecSQLNonQuery(sql)
        End If
    End Sub

    Sub Capnhatquyeninhoadon()
        If TruongDaCo("users", "VT") Then
            ExecSQLNonQuery("ALTER TABLE users ALTER COLUMN VT NUMERIC NULL")
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub CreateTableLuuChuyen()
        Dim sql As String
        On Error GoTo Err_CreateTable
        If Not BangDaCo("LuuChuyen") Then
            sql = "CREATE TABLE [dbo].[LuuChuyen]([MaSo] [numeric] not null,[MaCT] [numeric] not null, [MauSo] [nvarchar](255) null, [KyHieu] [nvarchar](255) null, [DieuLenh] [nvarchar](255) null, [Ngay] [datetime] null, [Cua] [nvarchar](255) null, [Veviec] [nvarchar](255) null, [NguoiVanChuyen] [nvarchar](255) null, [HopDong] [nvarchar](255) null, [PhuongTien] [nvarchar](255) null)"
            ExecSQLNonQuery(sql)
        End If
Err_CreateTable:
    End Sub
    Sub Quyetdinh()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("Quyetdinh1") Then
                sql = "CREATE TABLE [dbo].[Quyetdinh1]( [MaSo] [int] NOT NULL, [So] [NVARCHAR](20) NULL, [Ngay] [datetime] NULL, [Tendonvi] [NVARCHAR](255) NULL, [SoDKKD] [NVARCHAR](20) NULL, [Ngayad] [datetime] NULL, [Ngayhl] [datetime] NULL, [Giamdoc] [NVARCHAR](100) NULL, [Denghi] [NVARCHAR](100) NULL, [Quanly] [NVARCHAR](255) NULL, [Cungcap] [NVARCHAR](255) NULL, CONSTRAINT [aaaaaQuyetdinh1_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
        Try
            If Not BangDaCo("Quyetdinh2") Then
                sql = "CREATE TABLE [dbo].[Quyetdinh2]( [MaSo] [int] NOT NULL, [maqd] [int] NULL, [ten] [NVARCHAR](255) NULL, [thongso] [NVARCHAR](255) NULL, CONSTRAINT [aaaaaQuyetdinh2_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
        Try
            If Not BangDaCo("Quyetdinh3") Then
                sql = "CREATE TABLE [dbo].[Quyetdinh3]( [MaSo] [int] NOT NULL, [maqd] [int] NULL, [loai] [NVARCHAR](255) NULL, [Mauso] [NVARCHAR](50) NULL, [mucdich] [NVARCHAR](255) NULL, CONSTRAINT [aaaaaQuyetdinh3_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
        Try
            If Not BangDaCo("Quyetdinh4") Then
                sql = "CREATE TABLE [dbo].[Quyetdinh4]( [MaSo] [int] NOT NULL, [maqd] [int] NULL, [ten] [NVARCHAR](255) NULL, [trachnhiem] [NVARCHAR](255) NULL, CONSTRAINT [aaaaaQuyetdinh4_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Thongbaophathanh()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("Thongtinphathanh") Then
                sql = "CREATE TABLE [dbo].[Thongtinphathanh]( [MaSo] [int] NOT NULL, [So] [NVARCHAR](20) NULL, [Ngay] [datetime] NULL, [Tiepnhan] [NVARCHAR](255) NULL, [Daidien] [NVARCHAR](100) NULL, CONSTRAINT [aaaaaThongtinphathanh_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
        Try
            If Not BangDaCo("Chitietphathanh") Then
                sql = "CREATE TABLE [dbo].[Chitietphathanh]( [MaSo] [int] NOT NULL, [Mathongtin] [int] NULL, [ten] [NVARCHAR](255) NULL, [Mau] [NVARCHAR](20) NULL, [Kyhieu] [NVARCHAR](20) NULL, [Tuso] [NVARCHAR](20) NULL, [Denso] [NVARCHAR](20) NULL, [Soluong] [int] NULL, [Ngaysudung] [datetime] NULL, [Tenin] [NVARCHAR](255) NULL, [MST] [NVARCHAR](20) NULL, [Soin] [NVARCHAR](20) NULL, [Ngayin] [datetime] NULL, CONSTRAINT [aaaaaChitietphathanh_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Huymatchayhong()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("Thongtinhuy") Then
                sql = "CREATE TABLE [dbo].[Thongtinhuy]( [MaSo] [int] NOT NULL, [Loaihuy] [int] NULL, [So] [NVARCHAR](20) NULL, [Ngay] [datetime] NULL, [Thongbaophathien] [NVARCHAR](255) NULL, [Nhanthongbao] [NVARCHAR](255) NULL, [Phuongphaplydo] [NVARCHAR](255) NULL, [Daidien] [NVARCHAR](255) NULL, [Gio] [int] NULL, [ngay1] [datetime] NULL, CONSTRAINT [aaaaaThongtinhuy_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
        Try
            If Not BangDaCo("Chitiethuy") Then
                sql = "CREATE TABLE [dbo].[Chitiethuy]( [MaSo] [int] NOT NULL, [Mathongtin] [int] NULL, [ten] [NVARCHAR](100) NULL, [mau] [NVARCHAR](50) NULL, [Kyhieu] [NVARCHAR](20) NULL, [Tuso] [NVARCHAR](20) NULL, [Denso] [NVARCHAR](20) NULL, [Soluong] [int] NULL, [Lien] [int] NULL, [ghichu] [NVARCHAR](255) NULL, CONSTRAINT [aaaaaChitiethuy_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Banhang()
        If Not TruongDaCo("license", "BanHang") Then
            ExecSQLNonQuery("ALTER TABLE license ADD Banhang INTEGER NULL")
            ExecSQLNonQuery("UPDATE license SET Banhang=100")
        End If
        If Timten("maso", "1423", "sohieu", "hethongtk").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO hethongtk (maso,sohieu,cap,ten,kieu,loai,tk_id,tkcha0,tkcha1,matc,capduoi,ngaykc,ngayht) VALUES ({0},'1423',2,'Chi phí nhập hàng nội địa',-1,1,0,{1},{2},{3},1, N'{4}', N'{4}')", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "hethongtk") + 1), _
                                    Timten("maso", "142", "sohieu", "hethongtk"), _
                                    Timten("tkcha0", "142", "sohieu", "hethongtk"), _
                                    ConvertToStrSafe(Lng_MaxValue("matc", "hethongtk") + 1), _
                                    Format(DateTime.Today, Mask_DB)))
                ExecSQLNonQuery("UPDATE hethongtk SET ten = 'Chi phí nhập hàng nhập khẩu' WHERE sohieu = '142'")
            Catch
            End Try
        End If
        'OpenDB(pDataPath)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Themsohoadonmat()
        If Not TruongDaCo("slhoadon", "somat") Then
            ExecSQLNonQuery("ALTER TABLE slhoadon ADD somat INTEGER NULL,thangmat INTEGER NULL")
            ExecSQLNonQuery("UPDATE slhoadon SET somat=0, thangmat=0")
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub ThemGiatheokhach()
        If Not TruongDaCo("license", "giatheokhach") Then
            ExecSQLNonQuery("ALTER TABLE license ADD giatheokhach INTEGER NULL")
            ExecSQLNonQuery("UPDATE license SET giatheokhach=0")
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Khongxuatam()
        If Not TruongDaCo("license", "khongxuatam") Then
            ExecSQLNonQuery("ALTER TABLE license add khongxuatam integer null")
            ExecSQLNonQuery("UPDATE license SET khongxuatam=0")
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub UpdateThanhphamdd()
        If Not TruongDaCo("thanhphamdd", "phantram") Then
            ExecSQLNonQuery("ALTER TABLE thanhphamdd add phantram MONEY null")
            ExecSQLNonQuery("UPDATE thanhphamdd SET phantram=0")
        End If
        If Not TruongDaCo("thanhpham", "phantramdk") Then
            ExecSQLNonQuery("ALTER TABLE thanhpham add phantramdk MONEY null,phantramck MONEY null")
            ExecSQLNonQuery("UPDATE thanhpham SET phantramdk=0,phantramck=0")
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub CreateTableThueDanhNghiep()
        If Not TruongDaCo("license", "ky") Then
            ExecSQLNonQuery("ALTER TABLE license add ky string null,nghe string null,giahan integer null,A1 MONEY null,B1 MONEY null,B2 MONEY null,B3 MONEY null,B4 MONEY null,B5 MONEY null,B6 MONEY null,B7 MONEY null,B8 MONEY null,B9 MONEY null,B10 MONEY null," & "B11 MONEY null,B12 MONEY null,B13 MONEY null,B14 MONEY null,B15 MONEY null,B16 MONEY null,B17 MONEY null,B18 MONEY null,B19 MONEY null,B20 MONEY null," & "B21 MONEY null,B22 MONEY null,B23 MONEY null,B24 MONEY null,B25 MONEY null,B26 MONEY null,B27 MONEY null,B28 MONEY null,B29 MONEY null,B30 MONEY null,B31 MONEY null," & "C1 MONEY null,C2 MONEY null,C3 MONEY null,C4 MONEY null,C5 MONEY null,C6 MONEY null,C7 MONEY null,C8 MONEY null,C9 MONEY null,C10 MONEY null," & "K1 integer null,K2 integer null,K3 integer null,K4 integer null,K5 integer null,K6 integer null,tyle0 integer null,tyle1 integer null,tyle2 integer null")
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub CreateTablePLKQKD()
        Dim sql As String = String.Empty
        Try
            Dim MasoPLKQKD As Integer = Lng_MaxValue("maso", "PLKQKD") + 1
            Dim MasoPLKQKD3 As Integer = Timten("maso", "3", "masopl", "PLKQKD")
            Dim MasoPLKQKD9 As Integer = Timten("maso", "9", "masopl", "PLKQKD")
            If BangDaCo("PLKQKD") Then
                sql = "CREATE TABLE [dbo].[PLKQKD]( [Maso] [int] NOT NULL, [MaSoPL] [int] NULL DEFAULT ((0)), [cap] [int] NULL DEFAULT ((0)), [sohieu] [NVARCHAR](10) NULL DEFAULT ('...'), [ten] [NVARCHAR](255) NULL DEFAULT ('...'), [Sotien] [float] NULL DEFAULT ((0)), [TKCha] [int] NULL DEFAULT ((0)), [upsize_ts] [timestamp] NULL, CONSTRAINT [aaaaaPLKQKD_PK] PRIMARY KEY NONCLUSTERED ( [Maso] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},1,0,'511','Doanh thu bán hàng và cung cấp dịch vụ',0,0)", MasoPLKQKD))
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},2,1,'0','Trong đó: - Doanh thu bán hàng hoá, dịch vụ xuất khẩu',0,{1})", MasoPLKQKD, Timten("maso", "1", "masopl", "PLKQKD")))
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},3,0,'0','Các khoản giảm trừ doanh thu ([03]=[04]+[05]+[06]+[07])',0,0)", MasoPLKQKD))
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},4,1,'5211','Chiết khấu thương mại',0,{1})", MasoPLKQKD, MasoPLKQKD3))
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},5,1,'5213','Giảm giá hàng bán',0,{1})", MasoPLKQKD, MasoPLKQKD3))
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},6,1,'5212','Giá trị hàng bán bị trả lại',0,{1})", MasoPLKQKD, MasoPLKQKD3))
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},7,1,'0','Thuế tiêu thụ đặt biệt, thuế xuất khẩu, thuế giá trị gia tăng theo phương pháp trực tiếp phải nộp',0,{1})", MasoPLKQKD, MasoPLKQKD3))
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},8,0,'515','Doanh thu hoạt động tài chính',0,0)", MasoPLKQKD))
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},9,0,'0','Chi phí sản xuất, kinh doanh hàng hoá, dịch vụ ([09]=[10]+[11]+[12])',0,0)", MasoPLKQKD))
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},10,1,'632','Giá vốn hàng bán',0,{1})", MasoPLKQKD, MasoPLKQKD9))
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},11,1,'6421','Chi phí bán hàng',0,{1})", MasoPLKQKD, MasoPLKQKD9))
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},12,1,'6422','Chi phí quản lý doanh nghiệp',0,{1})", MasoPLKQKD, MasoPLKQKD9))
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},13,0,'635','Chi phí tài chính',0,0)", MasoPLKQKD))
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},14,1,'0','Trong đó: - Chi phí lãi tiến vay dùng cho sản xuất, kinh doanh',0,{1})", MasoPLKQKD, Timten("maso", "13", "masopl", "PLKQKD")))
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},15,0,'0','Lợi nhuận thuần từ hoạt động kinh doanh ([15]=[01]-[03]+[08]-[09]-[13])',0,0)", MasoPLKQKD))
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},16,0,'711','Thu nhập khác',0,0)", MasoPLKQKD))
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},17,0,'811','Chi phí khác',0,0)", MasoPLKQKD))
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},18,0,'0','Lợi nhuận khác ([18]=[16]-[17])',0,0)", MasoPLKQKD))
            ExecSQLNonQuery(String.Format("INSERT INTO PLKQKD (MaSo,MaSoPL,cap,sohieu,Ten,Sotien,TKCha) VALUES ({0},19,0,'0','Tổng lợi nhuận kế toán thuế thu nhập doanh nghiệp ([19]=[15]+[18])',0,0)", MasoPLKQKD))
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub CreateTableGiaVTKH()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("GiaVTKH") Then
                sql = "CREATE TABLE [dbo].[GiaVTKH]( [Maso] [int] NOT NULL, [SoHieuKH] [NVARCHAR](20) NULL DEFAULT ('...'), [SoHieuVT] [NVARCHAR](20) NULL DEFAULT ('...'), [Giaban] [int] NULL DEFAULT ((0)), CONSTRAINT [aaaaaGiaVTKH_PK] PRIMARY KEY NONCLUSTERED ( [Maso] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Createtaikhoantudong()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("Taikhoantudong") Then
                sql = "CREATE TABLE [dbo].[Taikhoantudong]( [MaSo] [int] NOT NULL, [tk1] [int] NULL DEFAULT ((0)), [tk2] [int] NULL DEFAULT ((0)), [loai] [int] NULL DEFAULT ((0)), [loai1] [int] NULL DEFAULT ((0)), [loaino] [int] NULL DEFAULT ((0)), CONSTRAINT [aaaaaTaikhoantudong_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateTNCN()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("LuongKCN") Then
                sql = "CREATE TABLE [dbo].[LuongKCN]( [MaSo] [int] NOT NULL, [manv] [int] NULL DEFAULT ((0)), [thang] [int] NULL DEFAULT ((0)), [LKCN] [float] NULL DEFAULT ((0)), [upsize_ts] [timestamp] NULL, CONSTRAINT [aaaaaLuongKCN_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateBangiaocongviec()
        If Not TruongDaCo("license", "bgthang") Then
            ExecSQLNonQuery("ALTER TABLE license add bgthang string null,bgnam string null,bgxuly string null,bgnoidung1 string null,bglydo1 string null,bgthoigian1 string null,bgkiemtra string null,bgnoidung2 string null,bglydo2 string null,bgthoigian2 string null,bgnguoigiao string null,bgnguoinhan string null")
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Updatephucap()
        If Not TruongDaCo("Phucap", "tamung") Then
            ExecSQLNonQuery("ALTER TABLE phucap add tamung MONEY null,trukhac MONEY null,trukhac1 MONEY null,trukhac2 MONEY null")
            ExecSQLNonQuery("UPDATE phucap SET tamung=0, trukhac=0, trukhac1=0, trukhac2=0")
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateBangLuongTable()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("BangLuong") Then
                sql = "CREATE TABLE [dbo].[BangLuong]( [MaSo] [int] NOT NULL, [manv] [int] NULL DEFAULT ((0)), [loainv] [int] NULL DEFAULT ((0)), [thang] [int] NULL DEFAULT ((0)), [ngaycong] [float] NULL DEFAULT ((0)), [luongcoban] [float] NULL DEFAULT ((0)), [luongchinh] [float] NULL DEFAULT ((0)), [thunhapkhac] [float] NULL DEFAULT ((0)), [tongthunhap] [float] NULL DEFAULT ((0)), [BHXH] [float] NULL DEFAULT ((0)), [BHYT] [float] NULL DEFAULT ((0)), [BHTN] [float] NULL DEFAULT ((0)), [tamung] [float] NULL DEFAULT ((0)), [trukhac] [float] NULL DEFAULT ((0)), [thuclanh] [float] NULL DEFAULT ((0)), [phuthuoc] [int] NULL DEFAULT ((0)), [sothang] [int] NULL DEFAULT ((0)), [thuephainop] [float] NULL DEFAULT ((0)), [TinhGiam] [float] NULL DEFAULT ((0)), [Thuephainop1] [float] NULL DEFAULT ((0)), [upsize_ts] [timestamp] NULL, CONSTRAINT [aaaaaBangLuong_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
        If Not TruongDaCo("BangLuong", "TinhGiam") Then
            ExecSQLNonQuery("ALTER TABLE BangLuong add TinhGiam MONEY null,Thuephainop1 MONEY null")
            ExecSQLNonQuery("UPDATE BangLuong SET TinhGiam=0,Thuephainop1=0")
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateGiaCanhTable()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("GiaCanh") Then
                sql = "CREATE TABLE [dbo].[GiaCanh]( [MaSo] [int] NOT NULL, [manv] [int] NULL DEFAULT ((0)), [ten] [NVARCHAR](50) NULL DEFAULT ('...'), [ngaysinh] [NVARCHAR](10) NULL DEFAULT ('...'), [mst] [NVARCHAR](20) NULL DEFAULT ('...'), [cmnd] [NVARCHAR](20) NULL DEFAULT ('...'), [quanhe] [NVARCHAR](50) NULL DEFAULT ('...'), [tuthang] [NVARCHAR](10) NULL DEFAULT ('...'), [denthang] [NVARCHAR](10) NULL DEFAULT ('...'), CONSTRAINT [aaaaaGiaCanh_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateTuThienTable()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("") Then
                sql = "CREATE TABLE [dbo].[TuThien]( [MaSo] [int] NOT NULL, [manv] [int] NULL DEFAULT ((0)), [thang] [int] NULL DEFAULT ((0)), [tuthien] [float] NULL DEFAULT ((0)), [nhandao] [float] NULL DEFAULT ((0)), [khuyenhoc] [float] NULL DEFAULT ((0)), [nop] [float] NULL DEFAULT ((0)), [upsize_ts] [timestamp] NULL, CONSTRAINT [aaaaaTuThien_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Themdatbo()
        'Công nợ
        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET TK_ID={0} WHERE SoHieu LIKE '311%'", TKCNKH_ID))
        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET TK_ID={0} WHERE SoHieu LIKE '1311%'", TKCNKH_ID))
        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET TK_ID={0} WHERE SoHieu LIKE '3311%'", TKCNPT_ID))
        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET TK_ID={0} WHERE SoHieu LIKE '3411%'", TKCNPT_ID))
        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET TK_ID={0} WHERE SoHieu LIKE '3412%'", TKCNPT_ID))
        'Chi phí
        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET TK_ID2={0} WHERE SoHieu LIKE '1543%'", TKCPSX_ID))
        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET TK_ID2={0} WHERE SoHieu LIKE '6421%'", TKCPSX_ID))
        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET TK_ID2={0} WHERE SoHieu LIKE '6422%'", TKCPSX_ID))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateHethongtaikhoan()
        CreateTablePLKQKD()
        CreateTableGiaVTKH()
        CreateTNCN()
        UpdateBangiaocongviec()
        Updatephucap()
        Themdatbo()
        CreateTuThienTable()
        CreateGiaCanhTable()
        CreateBangLuongTable()
        Dim loai As Integer
        If Not TruongDaCo("quanlynhanvien", "MST") Then
            ExecSQLNonQuery("ALTER TABLE quanlynhanvien add MST varchar(20) null")
            ExecSQLNonQuery("UPDATE quanlynhanvien SET mst='...'")
        End If
        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET TKcha0={0} WHERE sohieu='351' OR sohieu='352'", ConvertToStrSafe(GetSelectValue("SELECT tkcha0 AS f1 FROM hethongtk WHERE sohieu='333'"))))
        ExecSQLNonQuery("UPDATE HethongTK SET sohieu='3389' WHERE sohieu='3385'")
        Dim cha0 As Integer = ConvertToDblSafe(GetSelectValue("SELECT tkcha0 AS f1,loai AS f2 FROM hethongtk WHERE sohieu='333'", loai))
        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET sohieu='353',TKcha0={0},loai={1} WHERE sohieu='431'", _
                            cha0, _
                            ConvertToStrSafe(loai)))
        Dim cha1 As Integer = ConvertToDblSafe(GetSelectValue("SELECT maso AS f1 FROM hethongtk WHERE sohieu='353'"))
        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET sohieu='3531',TKcha0={0},TKcha1={1},loai={2} WHERE sohieu='4311'", _
                            cha1, _
                            ConvertToStrSafe(cha0), _
                            ConvertToStrSafe(loai)))
        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET sohieu='3532',TKcha0={0},TKcha1={1},loai={2} WHERE sohieu='4312'", _
                            cha1, _
                            ConvertToStrSafe(cha0), _
                            ConvertToStrSafe(loai)))
        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET sohieu='3534',TKcha0={0},TKcha1={1},Ten='Quỹ thưởng ban quản lý điều hành Cty',TKCon=0,cap=2,loai={2} WHERE sohieu='418'", _
                            cha1, _
                            ConvertToStrSafe(cha0), _
                            ConvertToStrSafe(loai)))
        If ConvertToDblSafe(GetSelectValue("SELECT count(maso) AS f1 FROM hethongtk WHERE sohieu='356'")) = 0 Then
            ExecSQLNonQuery(String.Format("INSERT INTO HethongTK (MaSo,SoHieu,Cap,Ten,Loai,Kieu,TkCha0, MaTC) VALUES ({0},'356',1,'Quỹ phát triển khoa học và công nghệ',3,1,{1},{2})", _
                                Lng_MaxValue("maso", "hethongtk") + 1, _
                                ConvertToStrSafe(cha0), _
                                ConvertToStrSafe(Lng_MaxValue("maso", "hethongtk") + 1)))
        End If
        If ConvertToDblSafe(GetSelectValue("SELECT count(maso) AS f1 FROM hethongtk WHERE sohieu='3561'")) = 0 Then
            ExecSQLNonQuery(String.Format("INSERT INTO HethongTK (MaSo,SoHieu,Cap,Ten,Loai,Kieu,TkCha0, TkCha1, MaTC,TK_ID) VALUES ({0},'3561',2,'Quỹ phát triển khoa học và công nghệ',3,1,{1},{2},{3},0)", _
                                Lng_MaxValue("maso", "hethongtk") + 1, _
                                ConvertToStrSafe(Lng_MaxValue("maso", "hethongtk")), _
                                ConvertToStrSafe(cha0), _
                                ConvertToStrSafe(Lng_MaxValue("maso", "hethongtk") + 1)))
        End If
        If ConvertToDblSafe(GetSelectValue("SELECT count(maso) AS f1 FROM hethongtk WHERE sohieu='3562'")) = 0 Then
            ExecSQLNonQuery(String.Format("INSERT INTO HethongTK (MaSo,SoHieu,Cap,Ten,Loai,Kieu,TkCha0, TkCha1, MaTC,TK_ID) VALUES ({0},'3562',2,'Quỹ phát triển khoa học và công nghệ đã hình thành TSCĐ',3,1,{1},{2},{3},0)", _
                                Lng_MaxValue("maso", "hethongtk") + 1, _
                                ConvertToStrSafe(Lng_MaxValue("maso", "hethongtk") - 1), _
                                ConvertToStrSafe(cha0), _
                                ConvertToStrSafe(Lng_MaxValue("maso", "hethongtk") + 1)))
        End If
        If ConvertToDblSafe(GetSelectValue("SELECT count(maso) AS f1 FROM hethongtk WHERE sohieu='3533'")) = 0 Then
            ExecSQLNonQuery(String.Format("INSERT INTO HethongTK (MaSo,SoHieu,Cap,Ten,Loai,Kieu,TkCha0, TkCha1, MaTC,TK_ID) VALUES ({0},'3533',2,'Quỹ phúc lợi đã hình thành TSCĐ',3,1,{1},{2},{3},0)", _
                                Lng_MaxValue("maso", "hethongtk") + 1, _
                                ConvertToStrSafe(cha1), _
                                ConvertToStrSafe(cha0), _
                                ConvertToStrSafe(Lng_MaxValue("maso", "hethongtk") + 1)))
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateHoaDonTable()
        If Not TruongDaCo("hoadon", "den") Then
            ExecSQLNonQuery("ALTER TABLE hoadon ADD den INTEGER NULL, tim INTEGER NULL, hong INTEGER NULL, xanh INTEGER NULL, xanhnoidia INTEGER NULL, sohopdong string NULL, ngayhopdong  DATETIME NULL, diadiemgiaohang string NULL, diadiemnhanhang string NULL, sovandon string NULL, socontainer string NULL, tenvanchuyen string NULL")
            ExecSQLNonQuery("UPDATE hoadon SET den = 0, tim = 0, hong = 0, xanh = 0, xanhnoidia = 0, sohopdong = '...', ngayhopdong = '01/01/1890', diadiemgiaohang = '...', diadiemnhanhang = '...', sovandon = '...', socontainer = '...', tenvanchuyen = '...'")
        End If
        If Not TruongDaCo("HoaDon", "NLTS") Then
            ExecSQLNonQuery("ALTER TABLE HoaDon add NLTS Integer null,DN integer null")
            ExecSQLNonQuery("UPDATE HoaDon SET NLTS=0, DN=0")
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateBacThue()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("BacThue") Then
                sql = "CREATE TABLE [dbo].[BacThue]( [MaSo] [int] IDENTITY(1,1) NOT NULL, [Bac] [int] NULL CONSTRAINT [DF__BacThue__Bac__324172E1] DEFAULT ((0)), [Von] [float] NULL CONSTRAINT [DF__BacThue__Von__3335971A] DEFAULT ((0)), [Thue] [int] NULL CONSTRAINT [DF__BacThue__Thue__3429BB53] DEFAULT ((0)), CONSTRAINT [aaaaaBacThue_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
            ExecSQLNonQuery("INSERT INTO BacThue(Maso,Bac,Von,Thue) VALUES(1,1,10000000000,3000000)")
            ExecSQLNonQuery("INSERT INTO BacThue(Maso,Bac,Von,Thue) VALUES(2,2,5000000000,2000000)")
            ExecSQLNonQuery("INSERT INTO BacThue(Maso,Bac,Von,Thue) VALUES(3,3,2000000000,1500000)")
            ExecSQLNonQuery("INSERT INTO BacThue(Maso,Bac,Von,Thue) VALUES(4,4,1,1000000)")
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub BaoHiemCan()
        CreateTKBHXH1Table()
        CreateTKBHXH2Table()
        CreateHSCNTable()
        CreateBHXH01ATable()
        CreateBHXH02ATable()
        CreateBHXH03ATable()
        CreateBHXH03BTable()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateQuanlynhanvienTable()
        If Not TruongDaCo("Quanlynhanvien", "SoBHXH") Then
            ExecSQLNonQuery("ALTER TABLE Quanlynhanvien add SoBHXH varchar(20) null,SoBHYT varchar(20) null")
        End If
        If Not TruongDaCo("Quanlynhanvien", "The") Then
            ExecSQLNonQuery("ALTER TABLE Quanlynhanvien add The integer null,Tu integer null,Den integer null,TangBH integer null,ThangtangBH integer null")
        End If
        If Not TruongDaCo("Chamcong", "DNBHXH") Then
            ExecSQLNonQuery("ALTER TABLE Chamcong add DNBHXH integer null,DNBHYT integer null,DNBHTN integer null,NVBHXH integer null,NVBHYT integer null,NVBHTN integer null")
        End If
        'OpenDB(pDataPath)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateBHXH03ATable()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("BHXH03A") Then
                sql = "CREATE TABLE [dbo].[BHXH03A]( [MaSo] [int] NOT NULL, [Hoten] [NVARCHAR](100) NULL DEFAULT ('...'), [BHXH] [NVARCHAR](20) NULL DEFAULT ('...'), [Ngaysinh] [NVARCHAR](10) NULL DEFAULT ('...'), [Luongcu] [NVARCHAR](20) NULL DEFAULT ('...'), [PCCVcu] [NVARCHAR](20) NULL DEFAULT ('...'), [PCVKcu] [NVARCHAR](20) NULL DEFAULT ('...'), [PCNcu] [NVARCHAR](20) NULL DEFAULT ('...'), [PCKcu] [NVARCHAR](20) NULL DEFAULT ('...'), [Luongmoi] [NVARCHAR](20) NULL DEFAULT ('...'), [PCCVmoi] [NVARCHAR](20) NULL DEFAULT ('...'), [PCVKmoi] [NVARCHAR](20) NULL DEFAULT ('...'), [PCNmoi] [NVARCHAR](20) NULL DEFAULT ('...'), [PCKmoi] [NVARCHAR](20) NULL DEFAULT ('...'), [TuThang] [NVARCHAR](20) NULL DEFAULT ('...'), [DenThang] [NVARCHAR](20) NULL DEFAULT ('...'), [Tyle] [NVARCHAR](20) NULL DEFAULT ('...'), [ThaydoiChucdanh] [NVARCHAR](100) NULL DEFAULT ('...'), [Trathe] [NVARCHAR](20) NULL DEFAULT ('...'), [Noidung] [NVARCHAR](100) NULL DEFAULT ('...'), [Thang] [int] NULL DEFAULT ((0)), [Loai] [NVARCHAR](10) NULL DEFAULT ('...'), [MDV] [NVARCHAR](20) NULL DEFAULT ('...'), [MKCB] [NVARCHAR](20) NULL DEFAULT ('...'), [So] [NVARCHAR](20) NULL DEFAULT ('...'), [BHXHcuoi1] [float] NULL DEFAULT ((0)), [BHXHcuoi2] [float] NULL DEFAULT ((0)), [BHYTcuoi1] [float] NULL DEFAULT ((0)), [BHYTcuoi2] [float] NULL DEFAULT ((0)), [BHTNcuoi1] [float] NULL DEFAULT ((0)), [BHTNcuoi2] [float] NULL DEFAULT ((0)), [upsize_ts] [timestamp] NULL, CONSTRAINT [aaaaaBHXH03A_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY] "
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
        UpdateQuanlynhanvienTable()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateBHXH02ATable()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("BHXH02A") Then
                sql = "CREATE TABLE [dbo].[BHXH02A]( [MaSo] [int] NOT NULL, [Hoten] [NVARCHAR](100) NULL DEFAULT ('...'), [BHXH] [NVARCHAR](20) NULL DEFAULT ('...'), [BHYT] [NVARCHAR](20) NULL DEFAULT ('...'), [Ngaysinh] [NVARCHAR](10) NULL DEFAULT ('...'), [Nu] [NVARCHAR](1) NULL DEFAULT ('...'), [Sochungminh] [NVARCHAR](20) NULL DEFAULT ('...'), [Diachi] [NVARCHAR](100) NULL DEFAULT ('...'), [Tinhdangky] [NVARCHAR](20) NULL DEFAULT ('...'), [Benhvien] [NVARCHAR](100) NULL DEFAULT ('...'), [Luong] [NVARCHAR](20) NULL DEFAULT ('...'), [PCCV] [NVARCHAR](20) NULL DEFAULT ('...'), [PCVK] [NVARCHAR](20) NULL DEFAULT ('...'), [PCN] [NVARCHAR](20) NULL DEFAULT ('...'), [PCK] [NVARCHAR](20) NULL DEFAULT ('...'), [DongBHTN] [NVARCHAR](1) NULL DEFAULT ('...'), [Thangdong] [NVARCHAR](20) NULL DEFAULT ('...'), [Ghichu] [NVARCHAR](100) NULL DEFAULT ('...'), [Thang] [NVARCHAR](3) NULL DEFAULT ('...'), [MDV] [NVARCHAR](20) NULL DEFAULT ('...'), [So] [NVARCHAR](20) NULL DEFAULT ('...'), CONSTRAINT [aaaaaBHXH02A_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
        UpdateQuanlynhanvienTable()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateBHXH03BTable()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("BHXH03B") Then
                sql = "CREATE TABLE [dbo].[BHXH03B]( [MaSo] [int] NOT NULL, [Hoten] [NVARCHAR](100) NULL DEFAULT ('...'), [BHXH] [NVARCHAR](20) NULL DEFAULT ('...'), [KCB] [NVARCHAR](20) NULL DEFAULT ('...'), [Noidung] [NVARCHAR](100) NULL DEFAULT ('...'), [Cu] [NVARCHAR](100) NULL DEFAULT ('...'), [Moi] [NVARCHAR](100) NULL DEFAULT ('...'), [Lydo] [NVARCHAR](100) NULL DEFAULT ('...'), [Thang] [NVARCHAR](3) NULL DEFAULT ('...'), [MDV] [NVARCHAR](20) NULL DEFAULT ('...'), [MKCB] [NVARCHAR](20) NULL DEFAULT ('...'), [So] [NVARCHAR](20) NULL DEFAULT ('...'), CONSTRAINT [aaaaaBHXH03B_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
        UpdateQuanlynhanvienTable()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateBHXH01ATable()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("BHXH01A") Then
                sql = "CREATE TABLE BHXH01A(MaSo counter primary key, Hoten varchar(100) not null, BHXH varchar(20) not null, BHYT varchar(20) not null, Ngaysinh varchar(10) not null, Nu varchar(1) not null, Sochungminh varchar(20) not null, Ngaycap varchar(10) not null, Tinhcap varchar(20) not null, Nguyenquan varchar(100) not null, Chucdanh varchar(100) not null, Diachi varchar(100) not null, Tinhdangky varchar(20) not null, Benhvien varchar(20) not null, Ghichu varchar(100) not null,Thang varchar(3) not null,MDV varchar(20)not null,MKCB varchar(20)not null,So varchar(20)not null)"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
        UpdateQuanlynhanvienTable()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateTKBHXH1Table()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("TKBHXH1") Then
                sql = "CREATE TABLE [dbo].[TKBHXH1]( [MaSo] [int] NOT NULL, [Tuthang] [NVARCHAR](10) NULL DEFAULT ('...'), [Denthang] [NVARCHAR](10) NULL DEFAULT ('...'), [Chucvu] [NVARCHAR](100) NULL DEFAULT ('...'), [Luong] [int] NULL DEFAULT ((0)), [PCCV] [int] NULL DEFAULT ((0)), [PCVK] [int] NULL DEFAULT ((0)), [PCN] [int] NULL DEFAULT ((0)), [PCK] [int] NULL DEFAULT ((0)), [Ghichu] [NVARCHAR](100) NULL DEFAULT ('...'), CONSTRAINT [aaaaaTKBHXH1_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
        UpdateQuanlynhanvienTable()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateTKBHXH2Table()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("TKBHXH2") Then
                sql = "CREATE TABLE [dbo].[TKBHXH2]( [MaSo] [int] NOT NULL, [Ten] [NVARCHAR](100) NULL DEFAULT ('...'), [Ngaysinh] [NVARCHAR](10) NULL DEFAULT ('...'), [Quanhe] [NVARCHAR](10) NULL DEFAULT ('...'), [Nghenghiep] [NVARCHAR](100) NULL DEFAULT ('...'), [Thunhap] [int] NULL DEFAULT ((0)), [Noicutru] [NVARCHAR](100) NULL DEFAULT ('...'), CONSTRAINT [aaaaaTKBHXH2_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateHSCNTable()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("HSCN") Then
                sql = "CREATE TABLE [dbo].[HSCN]( [MaSo] [int] NOT NULL, [Tuthang] [NVARCHAR](10) NULL DEFAULT ('...'), [Denthang] [NVARCHAR](10) NULL DEFAULT ('...'), [Chucvu] [NVARCHAR](100) NULL DEFAULT ('...'), [Luong] [int] NULL DEFAULT ((0)), CONSTRAINT [aaaaaHSCN_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
        UpdateQuanlynhanvienTable()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateChucdanhTable()
        Dim sql As String = String.Empty
        Dim rs As DataTable
        Try
            If Not BangDaCo("ChucDanh") Then
                sql = "CREATE TABLE [dbo].[ChucDanh]( [MaSo] [int] NOT NULL, [NhanVien] [NVARCHAR](20) NULL DEFAULT ('...'), [Chucvu] [int] NULL DEFAULT ((0)), [Bacluong] [int] NULL DEFAULT ((0)), [Loailuong] [int] NULL DEFAULT ((0)), [NgayApdung] [datetime] NULL, [thang] [int] NULL DEFAULT ((0)), [nam] [int] NULL DEFAULT ((0)), [SoPLHD] [int] NULL DEFAULT ((0)), [thang13] [int] NULL DEFAULT ((0)), CONSTRAINT [aaaaaChucDanh_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
            rs = ExecSQLReturnDT("quanlynhanvien")
            For Each rsItem As DataRow In rs.Rows
                ExecSQLNonQuery(String.Format("INSERT INTO chucdanh(maso,nhanvien,chucvu,bacluong,loailuong,ngayapdung,thang,nam)VALUES({0}, N'{1}',{2},{3},{4}, N'{5}',0,{6})", _
                                    Lng_MaxValue("MaSo", "chucdanh") + 1, _
                                    rsItem("SoHieu"), _
                                    rsItem("MaChucvu"), _
                                    rsItem("BacLuong"), _
                                    rsItem("LoaiLuong"), _
                                    Format(DateSerial(pNamTC, 1, 1), Mask_DB), _
                                    ConvertToStrSafe(pNamTC)))
            Next
        Catch
        End Try
        Try
            Dim dem As Integer
            If Not TruongDaCo("Chucdanh", "SoPLHD") Then
                ExecSQLNonQuery("ALTER TABLE Chucdanh add SoPLHD long null")
                rs = ExecSQLReturnDT("SELECT maso,nhanvien FROM Chucdanh ORDER BY nhanvien,maso")
                For Each rsItem As DataRow In rs.Rows
                    dem = ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso)AS f1 FROM Chucdanh WHERE nhanvien=N'{0}' AND maso<{1}", _
                                                              rsItem("Nhanvien"), _
                                                              rsItem("MaSo"))))
                    ExecSQLNonQuery(String.Format("UPDATE Chucdanh SET SoPLHD={0} WHERE maso={1}", _
                                        dem + ConvertToDblSafe(GetSelectValue("SELECT max(soplhd)AS f1 FROM chucdanh")), _
                                        rsItem("MaSo")))
                Next
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateDoiTuongCTTable()
        Try
            If Not TruongDaCo("DoiTuongCT", "Thang") Then
                ExecSQLNonQuery("ALTER TABLE DoiTuongCT add Thang byte null")
                ExecSQLNonQuery("UPDATE DoiTuongCT SET Thang=LEFT(RIGHT(ngayth,len(ngayth)-3),2)")
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateBaoCaoCP2Table()
        If Not TruongDaCo("BaoCaoCP2", "Kq9") Then
            ExecSQLNonQuery("ALTER TABLE BaoCaoCP2 ADD Kq9 MONEY NULL,Kq10 MONEY NULL,Kq11 MONEY NULL,Kq12 MONEY NULL,Kq13 MONEY NULL,Kq14 MONEY NULL,Kq15 MONEY NULL,Kq16 MONEY NULL,Kq17 MONEY NULL,Kq18 MONEY NULL,Kq19 MONEY NULL,Kq20 MONEY NULL")
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateChamCongGioTable()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("ChamCongGio") Then
                sql = "CREATE TABLE [dbo].[ChamCongGio]( [MaSo] [int] NOT NULL, [MaNhanvien] [NVARCHAR](20) NULL DEFAULT ('...'), [Thang] [int] NULL DEFAULT ((0)), [Cong] [int] NULL DEFAULT ((0)), [Nghi] [int] NULL DEFAULT ((0)), [Phep] [int] NULL DEFAULT ((0)), [Tangca] [int] NULL DEFAULT ((0)), [N1] [int] NULL DEFAULT ((0)), [N2] [int] NULL DEFAULT ((0)), [N3] [int] NULL DEFAULT ((0)), [N4] [int] NULL DEFAULT ((0)), [N5] [int] NULL DEFAULT ((0)), [N6] [int] NULL DEFAULT ((0)), [N7] [int] NULL DEFAULT ((0)), [N8] [int] NULL DEFAULT ((0)), [N9] [int] NULL DEFAULT ((0)), [N10] [int] NULL DEFAULT ((0)), [N11] [int] NULL DEFAULT ((0)), [N12] [int] NULL DEFAULT ((0)), [N13] [int] NULL DEFAULT ((0)), [N14] [int] NULL DEFAULT ((0)), [N15] [int] NULL DEFAULT ((0)), [N16] [int] NULL DEFAULT ((0)), [N17] [int] NULL DEFAULT ((0)), [N18] [int] NULL DEFAULT ((0)), [N19] [int] NULL DEFAULT ((0)), [N20] [int] NULL DEFAULT ((0)), [N21] [int] NULL DEFAULT ((0)), [N22] [int] NULL DEFAULT ((0)), [N23] [int] NULL DEFAULT ((0)), [N24] [int] NULL DEFAULT ((0)), [N25] [int] NULL DEFAULT ((0)), [N26] [int] NULL DEFAULT ((0)), [N27] [int] NULL DEFAULT ((0)), [N28] [int] NULL DEFAULT ((0)), [N29] [int] NULL DEFAULT ((0)), [N30] [int] NULL DEFAULT ((0)), [N31] [int] NULL DEFAULT ((0)), [N1D] [int] NULL DEFAULT ((0)), [N2D] [int] NULL DEFAULT ((0)), [N3D] [int] NULL DEFAULT ((0)), [N4D] [int] NULL DEFAULT ((0)), [N5D] [int] NULL DEFAULT ((0)), [N6D] [int] NULL DEFAULT ((0)), [N7D] [int] NULL DEFAULT ((0)), [N8D] [int] NULL DEFAULT ((0)), [N9D] [int] NULL DEFAULT ((0)), [N10D] [int] NULL DEFAULT ((0)), [N11D] [int] NULL DEFAULT ((0)), [N12D] [int] NULL DEFAULT ((0)), [N13D] [int] NULL DEFAULT ((0)), [N14D] [int] NULL DEFAULT ((0)), [N15D] [int] NULL DEFAULT ((0)), [N16D] [int] NULL DEFAULT ((0)), [N17D] [int] NULL DEFAULT ((0)), [N18D] [int] NULL DEFAULT ((0)), [N19D] [int] NULL DEFAULT ((0)), [N20D] [int] NULL DEFAULT ((0)), [N21D] [int] NULL DEFAULT ((0)), [N22D] [int] NULL DEFAULT ((0)), [N23D] [int] NULL DEFAULT ((0)), [N24D] [int] NULL DEFAULT ((0)), [N25D] [int] NULL DEFAULT ((0)), [N26D] [int] NULL DEFAULT ((0)), [N27D] [int] NULL DEFAULT ((0)), [N28D] [int] NULL DEFAULT ((0)), [N29D] [int] NULL DEFAULT ((0)), [N30D] [int] NULL DEFAULT ((0)), [N31D] [int] NULL DEFAULT ((0)), [N1C] [int] NULL DEFAULT ((0)), [N2C] [int] NULL DEFAULT ((0)), [N3C] [int] NULL DEFAULT ((0)), [N4C] [int] NULL DEFAULT ((0)), [N5C] [int] NULL DEFAULT ((0)), [N6C] [int] NULL DEFAULT ((0)), [N7C] [int] NULL DEFAULT ((0)), [N8C] [int] NULL DEFAULT ((0)), [N9C] [int] NULL DEFAULT ((0)), [N10C] [int] NULL DEFAULT ((0)), [N11C] [int] NULL DEFAULT ((0)), [N12C] [int] NULL DEFAULT ((0)), [N13C] [int] NULL DEFAULT ((0)), [N14C] [int] NULL DEFAULT ((0)), [N15C] [int] NULL DEFAULT ((0)), [N16C] [int] NULL DEFAULT ((0)), [N17C] [int] NULL DEFAULT ((0)), [N18C] [int] NULL DEFAULT ((0)), [N19C] [int] NULL DEFAULT ((0)), [N20C] [int] NULL DEFAULT ((0)), [N21C] [int] NULL DEFAULT ((0)), [N22C] [int] NULL DEFAULT ((0)), [N23C] [int] NULL DEFAULT ((0)), [N24C] [int] NULL DEFAULT ((0)), [N25C] [int] NULL DEFAULT ((0)), [N26C] [int] NULL DEFAULT ((0)), [N27C] [int] NULL DEFAULT ((0)), [N28C] [int] NULL DEFAULT ((0)), [N29C] [int] NULL DEFAULT ((0)), [N30C] [int] NULL DEFAULT ((0)), [N31C] [int] NULL DEFAULT ((0)), [N1T] [float] NULL DEFAULT ((0)), [N2T] [float] NULL DEFAULT ((0)), [N3T] [float] NULL DEFAULT ((0)), [N4T] [float] NULL DEFAULT ((0)), [N5T] [float] NULL DEFAULT ((0)), [N6T] [float] NULL DEFAULT ((0)), [N7T] [float] NULL DEFAULT ((0)), [N8T] [float] NULL DEFAULT ((0)), [N9T] [float] NULL DEFAULT ((0)), [N10T] [float] NULL DEFAULT ((0)), [N11T] [float] NULL DEFAULT ((0)), [N12T] [float] NULL DEFAULT ((0)), [N13T] [float] NULL DEFAULT ((0)), [N14T] [float] NULL DEFAULT ((0)), [N15T] [float] NULL DEFAULT ((0)), [N16T] [float] NULL DEFAULT ((0)), [N17T] [float] NULL DEFAULT ((0)), [N18T] [float] NULL DEFAULT ((0)), [N19T] [float] NULL DEFAULT ((0)), [N20T] [float] NULL DEFAULT ((0)), [N21T] [float] NULL DEFAULT ((0)), [N22T] [float] NULL DEFAULT ((0)), [N23T] [float] NULL DEFAULT ((0)), [N24T] [float] NULL DEFAULT ((0)), [N25T] [float] NULL DEFAULT ((0)), [N26T] [float] NULL DEFAULT ((0)), [N27T] [float] NULL DEFAULT ((0)), [N28T] [float] NULL DEFAULT ((0)), [N29T] [float] NULL DEFAULT ((0)), [N30T] [float] NULL DEFAULT ((0)), [N31T] [float] NULL DEFAULT ((0)), [upsize_ts] [timestamp] NULL, CONSTRAINT [aaaaaChamCongGio_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateThanhphamDD()
        Dim sql As String = String.Empty
        Try
            If Not BangDaCo("ThanhPhamDD") Then
                sql = "CREATE TABLE [dbo].[ThanhPhamDD]( [Maso1] [int] NOT NULL, [Maso] [int] NULL DEFAULT ((0)), [MaCT] [int] NULL DEFAULT ((0)), [Sohieu] [NVARCHAR](20) NULL DEFAULT ('...'), [Thang] [int] NULL DEFAULT ((0)), [Ngay] [datetime] NULL, [MakhoTP] [int] NULL DEFAULT ((0)), [MakhoNVL] [int] NULL DEFAULT ((0)), [MaTK] [int] NULL DEFAULT ((0)), [MaTP] [int] NULL DEFAULT ((0)), [SoLuong] [float] NULL DEFAULT ((0)), [MaTKCP] [int] NULL DEFAULT ((0)), [MaTKNC] [int] NULL DEFAULT ((0)), [MaTKSX] [int] NULL DEFAULT ((0)), [CPNVL] [float] NULL DEFAULT ((0)), [CPNC] [float] NULL DEFAULT ((0)), [CPSXC] [float] NULL DEFAULT ((0)), [CPBH] [float] NULL DEFAULT ((0)), [CPQL] [float] NULL DEFAULT ((0)), [MaTKKH] [int] NULL DEFAULT ((0)), [CPKH] [float] NULL DEFAULT ((0)), [Ma154] [int] NULL DEFAULT ((0)), [GiaThanh] [float] NULL DEFAULT ((0)), [XK] [int] NULL DEFAULT ((0)), [CPTC] [float] NULL DEFAULT ((0)), [PLTH] [NVARCHAR](20) NULL DEFAULT ('...'), [NVLPL] [float] NULL DEFAULT ((0)), [TyLe] [int] NULL DEFAULT ((0)), [DonGia] [float] NULL DEFAULT ((0)), [MaKT] [int] NULL DEFAULT ((0)), [phantram] [float] NULL DEFAULT ((0)), [upsize_ts] [timestamp] NULL, CONSTRAINT [aaaaaThanhPhamDD_PK] PRIMARY KEY NONCLUSTERED ( [Maso1] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
                ExecSQLNonQuery(sql)
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateDinhmuc()
        Try
            If Not TruongDaCo("Dinhmuc", "PL") Then
                ExecSQLNonQuery("ALTER TABLE Dinhmuc add PL varchar(1) null")
                ExecSQLNonQuery("UPDATE Dinhmuc SET PL='-'")
            End If
        Catch
        End Try
        Try
            If Not TruongDaCo("Dinhmuc", "Luong") Then
                ExecSQLNonQuery("ALTER TABLE Dinhmuc add Luong MONEY null")
                ExecSQLNonQuery("ALTER TABLE Dinhmuc add TL integer null")
            End If
        Catch
        End Try
        Try
            If BangDaCo("DinhmucTL") Then
                ExecSQLNonQuery("drop TABLE DinhmucTL")
            End If
        Catch
        End Try
        Try
            If Not TruongDaCo("Dinhmuc", "DaIn") Then
                ExecSQLNonQuery("ALTER TABLE Dinhmuc add DaIn varchar(1) null")
                ExecSQLNonQuery("UPDATE Dinhmuc SET DaIn='-'")
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateThanhpham()
        Try
            If Not TruongDaCo("Thanhpham", "PLTH") Then
                ExecSQLNonQuery("ALTER TABLE Thanhpham add PLTH varchar(20) null,NVLPL MONEY null,Tyle integer null,Dongia MONEY null")
                ExecSQLNonQuery("UPDATE Thanhpham SET Tyle=0,dongia=0")
            End If
        Catch
        End Try
        Try
            If TruongDaCo("Thanhpham", "LoaiDM") Then
                ExecSQLNonQuery("ALTER TABLE Thanhpham drop column LoaiDM")
            End If
        Catch
        End Try
        Try
            If Not TruongDaCo("Thanhpham", "DDDK") Then
                ExecSQLNonQuery("ALTER TABLE Thanhpham add DDDK MONEY null,DDCK MONEY null")
                ExecSQLNonQuery("UPDATE Thanhpham SET DDDK=0,DDCK=0")
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SetSPTC()
        Dim mathuchi As String = String.Empty
        Dim rs As DataTable = ExecSQLReturnDT("SELECT mact FROM chungtu WHERE mathuchi='...' OR mathuchi='0'")
        For Each rsItem As DataRow In rs.Rows
            mathuchi = ""
            mathuchi = ConvertToStrSafe(GetSelectValue(String.Format("SELECT mathuchi AS f1 FROM chungtu WHERE mact={0} AND mathuchi<>'...' AND mathuchi<>'0'", rsItem("MaCT"))))
            If mathuchi <> "" Then ExecSQLNonQuery(String.Format("UPDATE chungtu SET mathuchi=N'{0}' WHERE mact={1}", mathuchi, rsItem("MaCT")))
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SetSPNX()
        Dim manhapxuat As String = String.Empty
        Dim rs As DataTable = ExecSQLReturnDT("SELECT mact FROM chungtu WHERE (manhapxuat='...' OR manhapxuat='0' OR manhapxuat='') AND mact in(SELECT mact FROM chungtu WHERE manhapxuat<>'...' AND manhapxuat<>'0' AND manhapxuat<>'')")
        For Each rsItem As DataRow In rs.Rows
            manhapxuat = ""
            manhapxuat = ConvertToStrSafe(GetSelectValue(String.Format("SELECT manhapxuat AS f1 FROM chungtu WHERE mact={0} AND manhapxuat<>'...' AND manhapxuat<>'0' AND manhapxuat<>''", rsItem("MaCT"))))
            If manhapxuat <> "" Then ExecSQLNonQuery(String.Format("UPDATE chungtu SET manhapxuat=N'{0}' WHERE mact={1}", manhapxuat, rsItem("MaCT")))
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Congcucan()
        CreateLCCDCTable()
        CreateCCDCTable()
        CreateCTCCDCTable()
        Createthongso1Table()
        NhaplieuPL_CCDC_CTCDCD()
        CreateChungTuTruocTable()
        UpdateLoaicongcudungcu()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Nhanviencan()
        CreateTinhTPTable()
        CreateQuanHuyenTable()
        CreatePhuongXaTable()
        CreatePhanLoaiQuanLyNhanVienTable()
        CreateCMNDHochieuTable()
        CreateQuanLyNhanVienTable()
        'OpenDB(pDataPath)
        CreateQuanLyNhanVienTable1()
        CreateChucdanhTable()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Luongcan()
        UpdateLiscenseTable()
        CreateChucVuTable()
        CreatePhuCapTable()
        CreateThongsoluongTable()
        CreateChamCongTable()
        CreateChamCongGioTable()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateBienbanbangiaoTable()
        Dim sql As String = String.Empty
Lamlai:
        Try
            sql = "CREATE TABLE [dbo].[BienBanBanGiao]( [MaSo] [int] NOT NULL, [sosach1] [NVARCHAR](100) NULL DEFAULT ('...'), [sosach2] [NVARCHAR](100) NULL DEFAULT ('...'), [sosach3] [NVARCHAR](100) NULL DEFAULT ('...'), [sosach4] [NVARCHAR](100) NULL DEFAULT ('...'), [sosach5] [NVARCHAR](100) NULL DEFAULT ('...'), [sosach6] [NVARCHAR](100) NULL DEFAULT ('...'), [sosach7] [NVARCHAR](100) NULL DEFAULT ('...'), [thue1] [NVARCHAR](100) NULL DEFAULT ('...'), [thue2] [NVARCHAR](100) NULL DEFAULT ('...'), [thue3] [NVARCHAR](100) NULL DEFAULT ('...'), [thue4] [NVARCHAR](100) NULL DEFAULT ('...'), [thue5] [NVARCHAR](100) NULL DEFAULT ('...'), [chungtu1] [NVARCHAR](100) NULL DEFAULT ('...'), [chungtu2] [NVARCHAR](100) NULL DEFAULT ('...'), [chungtu3] [NVARCHAR](100) NULL DEFAULT ('...'), [chungtu4] [NVARCHAR](100) NULL DEFAULT ('...'), [chungtu5] [NVARCHAR](100) NULL DEFAULT ('...'), [chungtu6] [NVARCHAR](100) NULL DEFAULT ('...'), [chungtu7] [NVARCHAR](100) NULL DEFAULT ('...'), [nguoigiao] [NVARCHAR](100) NULL DEFAULT ('...'), [nguoinhan] [NVARCHAR](100) NULL DEFAULT ('...'), [nganhang] [NVARCHAR](100) NULL DEFAULT ('...'), [ghichu] [NVARCHAR](250) NULL DEFAULT ('...'), [ghichu1] [NVARCHAR](250) NULL DEFAULT ('...'), [ghichu2] [NVARCHAR](250) NULL DEFAULT ('...'), [thang] [NVARCHAR](100) NULL DEFAULT ('...'), [quy] [NVARCHAR](100) NULL DEFAULT ('...'), [nam] [NVARCHAR](100) NULL DEFAULT ('...'), [thang1] [NVARCHAR](100) NULL DEFAULT ('...'), CONSTRAINT [aaaaaBienBanBanGiao_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            ExecSQLNonQuery(sql)
        Catch
            If Not TruongDaCo("BienBanBanGiao", "thue5") Then
                ExecSQLNonQuery("drop TABLE bienbanbangiao")
                'OpenDB(pDataPath)
            Else
                Exit Sub
            End If
            GoTo Lamlai
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateMaTC()
        ExecSQLNonQuery("UPDATE Hethongtk SET matc=maso")
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateNhatkyTable()
        Dim sql As String = String.Empty
        Dim i As Integer
Lamlai:
        Try
            i += 1
            sql = "CREATE TABLE [dbo].[Nhatky]( [MaSo] [int] NOT NULL, [MS] [int] NULL DEFAULT ((0)), [MaCT] [int] NULL DEFAULT ((0)), [Sohieuct] [NVARCHAR](20) NULL DEFAULT ('...'), [ngayct] [datetime] NULL, [ngaygs] [datetime] NULL, [DienGiai] [NVARCHAR](150) NULL DEFAULT ('...'), [ps] [int] NULL DEFAULT ((0)), [sohieutk] [NVARCHAR](20) NULL DEFAULT ('...'), [ten] [NVARCHAR](150) NULL DEFAULT ('...'), [loaips] [int] NULL DEFAULT ((0)), CONSTRAINT [aaaaaNhatky_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            ExecSQLNonQuery(sql)
            Exit Sub
        Catch ex As Exception
            If i = 2 Then Exit Sub
            ExecSQLNonQuery(("drop TABLE nhatky"))
            GoTo Lamlai
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateLiscenseTable()
        Try
            If Not TruongDaCo("License", "LCB") Then
                ExecSQLNonQuery("ALTER TABLE license add LCB MONEY null")
            End If
        Catch
        End Try
        Try
            If Not TruongDaCo("License", "cn1") Then
                ExecSQLNonQuery("ALTER TABLE license add cn1 text null, cn2 text null, cn3 text null, cn4 text null, cn5 text null, cn6 text null,kbs integer null, nnt text null")
            End If
        Catch
        End Try
        Try
            If Not TruongDaCo("License", "cn7") Then
                ExecSQLNonQuery("ALTER TABLE license add cn7 text null, cn8 text null, cn9 text null, cn10 text null")
            End If
        Catch
        End Try
        Try
            If Not TruongDaCo("License", "Von") Then
                ExecSQLNonQuery("ALTER TABLE license add Von number null")
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateThongsoluongTable()
        Dim sql As String = String.Empty
        Try
            sql = "CREATE TABLE [dbo].[ThongSoLuong]( [MaSo] [int] NOT NULL, [SohieuNhanvien] [NVARCHAR](20) NULL DEFAULT ('...'), [Thang] [int] NULL DEFAULT ((0)), [ngaycong] [float] NULL DEFAULT ((0)), [LuongCB] [float] NULL DEFAULT ((0)), [Heso] [float] NULL DEFAULT ((0)), [Bac] [int] NULL DEFAULT ((0)), [PCCV] [float] NULL DEFAULT ((0)), [PCTN] [float] NULL DEFAULT ((0)), [PCLD] [float] NULL DEFAULT ((0)), [Com] [float] NULL DEFAULT ((0)), [PCK] [float] NULL DEFAULT ((0)), [Thuong] [float] NULL DEFAULT ((0)), [Congkhac] [float] NULL DEFAULT ((0)), [BHTN] [float] NULL DEFAULT ((0)), [BHYT] [float] NULL DEFAULT ((0)), [BHXH] [float] NULL DEFAULT ((0)), [TamUng] [float] NULL DEFAULT ((0)), [Trukhac] [float] NULL DEFAULT ((0)), [LDThuong] [NVARCHAR](20) NULL DEFAULT ('...'), [LDCong] [NVARCHAR](20) NULL DEFAULT ('...'), [LDTru] [NVARCHAR](20) NULL DEFAULT ('...'), [nghi] [float] NULL DEFAULT ((0)), [phep] [float] NULL DEFAULT ((0)), [tangca] [float] NULL DEFAULT ((0)), [Thue] [float] NULL DEFAULT ((0)), [Heso1] [float] NULL DEFAULT ((0)), [bac1] [int] NULL DEFAULT ((0)), [PCCV1] [float] NULL DEFAULT ((0)), [PCTN1] [float] NULL DEFAULT ((0)), [PCLD1] [float] NULL DEFAULT ((0)), [Com1] [float] NULL DEFAULT ((0)), [PCK1] [float] NULL DEFAULT ((0)), [BHTN1] [float] NULL DEFAULT ((0)), [BHYT1] [float] NULL DEFAULT ((0)), [BHXH1] [float] NULL DEFAULT ((0)), [demcu] [int] NULL DEFAULT ((0)), [demmoi] [int] NULL DEFAULT ((0)), [tangcagio] [float] NULL DEFAULT ((0)), [Luong13] [int] NULL DEFAULT ((0)), [upsize_ts] [timestamp] NULL, CONSTRAINT [aaaaaThongSoLuong_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            ExecSQLNonQuery(sql)
        Catch
            Try
                If Not TruongDaCo("ThongSoLuong", "BHTN") Then
                    ExecSQLNonQuery("drop TABLE ThongSoLuong")
                    ExecSQLNonQuery(sql)
                End If
            Catch
            End Try
            Try
                If Not TruongDaCo("ThongSoLuong", "Heso1") Then
                    ExecSQLNonQuery("ALTER TABLE ThongSoLuong add Heso1 MONEY null,bac1 integer null,PCCV1 MONEY null,PCTN1 MONEY null,PCLD1 MONEY null,Com1 MONEY null,PCK1 MONEY null,BHTN1 MONEY null,BHYT1 MONEY null,BHXH1 MONEY null,demcu integer null,demmoi integer null,tangcagio MONEY null")
                End If
            Catch
            End Try
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateChamCongTable()
        Dim sql As String = String.Empty
        Try
            sql = "CREATE TABLE [dbo].[ChamCong]( [MaSo] [int] NOT NULL, [MaNhanvien] [NVARCHAR](20) NULL DEFAULT ('...'), [Thang] [int] NULL DEFAULT ((0)), [cong] [float] NULL DEFAULT ((0)), [nghi] [float] NULL DEFAULT ((0)), [phep] [float] NULL DEFAULT ((0)), [tangca] [float] NULL DEFAULT ((0)), [N1] [NVARCHAR](3) NULL DEFAULT ('...'), [N2] [NVARCHAR](3) NULL DEFAULT ('...'), [N3] [NVARCHAR](3) NULL DEFAULT ('...'), [N4] [NVARCHAR](3) NULL DEFAULT ('...'), [N5] [NVARCHAR](3) NULL DEFAULT ('...'), [N6] [NVARCHAR](3) NULL DEFAULT ('...'), [N7] [NVARCHAR](3) NULL DEFAULT ('...'), [N8] [NVARCHAR](3) NULL DEFAULT ('...'), [N9] [NVARCHAR](3) NULL DEFAULT ('...'), [N10] [NVARCHAR](3) NULL DEFAULT ('...'), [N11] [NVARCHAR](3) NULL DEFAULT ('...'), [N12] [NVARCHAR](3) NULL DEFAULT ('...'), [N13] [NVARCHAR](3) NULL DEFAULT ('...'), [N14] [NVARCHAR](3) NULL DEFAULT ('...'), [N15] [NVARCHAR](3) NULL DEFAULT ('...'), [N16] [NVARCHAR](3) NULL DEFAULT ('...'), [N17] [NVARCHAR](3) NULL DEFAULT ('...'), [N18] [NVARCHAR](3) NULL DEFAULT ('...'), [N19] [NVARCHAR](3) NULL DEFAULT ('...'), [N20] [NVARCHAR](3) NULL DEFAULT ('...'), [N21] [NVARCHAR](3) NULL DEFAULT ('...'), [N22] [NVARCHAR](3) NULL DEFAULT ('...'), [N23] [NVARCHAR](3) NULL DEFAULT ('...'), [N24] [NVARCHAR](3) NULL DEFAULT ('...'), [N25] [NVARCHAR](3) NULL DEFAULT ('...'), [N26] [NVARCHAR](3) NULL DEFAULT ('...'), [N27] [NVARCHAR](3) NULL DEFAULT ('...'), [N28] [NVARCHAR](3) NULL DEFAULT ('...'), [N29] [NVARCHAR](3) NULL DEFAULT ('...'), [N30] [NVARCHAR](3) NULL DEFAULT ('...'), [N31] [NVARCHAR](3) NULL DEFAULT ('...'), [DNBHXH] [float] NULL DEFAULT ((0)), [DNBHYT] [float] NULL DEFAULT ((0)), [DNBHTN] [float] NULL DEFAULT ((0)), [NVBHXH] [float] NULL DEFAULT ((0)), [NVBHYT] [float] NULL DEFAULT ((0)), [NVBHTN] [float] NULL DEFAULT ((0)), [upsize_ts] [timestamp] NULL, CONSTRAINT [aaaaaChamCong_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            ExecSQLNonQuery(sql)
        Catch
            Try
                If Not TruongDaCo("chamcong", "cong") Then
                    ExecSQLNonQuery("drop TABLE chamcong")
                    ExecSQLNonQuery(sql)
                End If
            Catch
            End Try
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateChucVuTable()
        Dim sql As String = String.Empty
        Try
            If TruongDaCo("Chucvu", "HSB_I") Then
                ExecSQLNonQuery("drop TABLE chucvu")
            End If
        Catch
        End Try
        Try
            sql = "CREATE TABLE [dbo].[ChucVu]( [MaSo] [int] NOT NULL, [Sohieu] [NVARCHAR](20) NULL DEFAULT ('...'), [Ten] [NVARCHAR](50) NULL DEFAULT ('...'), [HSB1] [float] NULL DEFAULT ((0)), [HSB2] [float] NULL DEFAULT ((0)), [HSB3] [float] NULL DEFAULT ((0)), [HSB4] [float] NULL DEFAULT ((0)), [HSB5] [float] NULL DEFAULT ((0)), [MLB1] [float] NULL DEFAULT ((0)), [MLB2] [float] NULL DEFAULT ((0)), [MLB3] [float] NULL DEFAULT ((0)), [MLB4] [float] NULL DEFAULT ((0)), [MLB5] [float] NULL DEFAULT ((0)), [TVB1] [float] NULL DEFAULT ((0)), [TVB2] [float] NULL DEFAULT ((0)), [TVB3] [float] NULL DEFAULT ((0)), [TVB4] [float] NULL DEFAULT ((0)), [TVB5] [float] NULL DEFAULT ((0)), [LNB1] [float] NULL DEFAULT ((0)), [LNB2] [float] NULL DEFAULT ((0)), [LNB3] [float] NULL DEFAULT ((0)), [LNB4] [float] NULL DEFAULT ((0)), [LNB5] [float] NULL DEFAULT ((0)), [upsize_ts] [timestamp] NULL, CONSTRAINT [aaaaaChucVu_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            ExecSQLNonQuery(sql)
        Catch
            Try
                If Not TruongDaCo("ChucVu", "TVB1") Then
                    ExecSQLNonQuery("ALTER TABLE chucvu add TVB1 double not null,TVB2 double not null,TVB3 double not null,TVB4 double not null,TVB5 double not null,LNB1 double not null,LNB2 double not null,LNB3 double not null,LNB4 double not null,LNB5 double not null")
                    ExecSQLNonQuery("UPDATE chucvu SET TVB1 = 0,TVB2 = 0,TVB3 = 0,TVB4 = 0,TVB5 = 0,LNB1 = 0,LNB2 = 0,LNB3 = 0,LNB4 = 0,LNB5 = 0")
                End If
            Catch
            End Try
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreatePhuCapTable()
        Dim sql As String = String.Empty
        Try
            If TruongDaCo("Phucap", "Ten") Or Not TruongDaCo("Phucap", "sohieunhanvien") Or Not TruongDaCo("Phucap", "thang") Then
                ExecSQLNonQuery("drop TABLE phucap")
            End If
        Catch
        End Try
        Try
            sql = "CREATE TABLE [dbo].[PhuCap]( [MaSo] [int] NOT NULL, [MaPhanloai] [int] NULL DEFAULT ((0)), [Machucvu] [int] NULL DEFAULT ((0)), [Sohieunhanvien] [NVARCHAR](20) NULL DEFAULT ('...'), [Loai] [int] NULL DEFAULT ((0)), [Thang] [int] NULL DEFAULT ((0)), [Chucvu] [float] NULL DEFAULT ((0)), [Trachnhiem] [float] NULL DEFAULT ((0)), [Luudong] [float] NULL DEFAULT ((0)), [khac1] [float] NULL DEFAULT ((0)), [ghichu1] [NVARCHAR](20) NULL DEFAULT ('...'), [khac2] [float] NULL DEFAULT ((0)), [ghichu2] [NVARCHAR](20) NULL DEFAULT ('...'), [khac3] [float] NULL DEFAULT ((0)), [ghichu3] [NVARCHAR](20) NULL DEFAULT ('...'), [khac4] [float] NULL DEFAULT ((0)), [ghichu4] [NVARCHAR](20) NULL DEFAULT ('...'), [khac5] [float] NULL DEFAULT ((0)), [ghichu5] [NVARCHAR](20) NULL DEFAULT ('...'), [TangCa] [float] NULL DEFAULT ((0)), [tamung] [float] NULL DEFAULT ((0)), [trukhac] [float] NULL DEFAULT ((0)), [trukhac1] [float] NULL DEFAULT ((0)), [trukhac2] [float] NULL DEFAULT ((0)), [upsize_ts] [timestamp] NULL, CONSTRAINT [aaaaaPhuCap_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            ExecSQLNonQuery(sql)
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdatePhPhanLoaiTable()
        Try
            If Not TruongDaCo("Phanloaiquanlynhanvien", "MaTK") Then
                ExecSQLNonQuery("ALTER TABLE Phanloaiquanlynhanvien add [MaTK] [nvarchar](10) NULL")
                ExecSQLNonQuery("UPDATE Phanloaiquanlynhanvien SET MaTK = 0")
            End If
        Catch
        End Try
    End Sub

    Public Sub UpdatePhuCapTable()
        Try
            If Not TruongDaCo("PhuCap", "TangCa") Then
                ExecSQLNonQuery("ALTER TABLE PhuCap add TangCa MONEY null")
                ExecSQLNonQuery("UPDATE PhuCap SET TangCa = 0")
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateThueTable()
        ExecSQLNonQuery("DELETE FROM Thue WHERE Ma>8")
        Try
            ExecSQLNonQuery("UPDATE Thue SET DienGiai=N'Thuế', matk=0, kytruocsang=0,kynay=0, luykepn=0, danop=0, luykedn=0, tonghop=0, dahoan=0, miengiam=0 WHERE ma=1")
        Catch
        End Try
        Try
            ExecSQLNonQuery(String.Format("UPDATE Thue SET DienGiai=N'Thuế TNDN', matk={0}, kytruocsang=0,kynay=0, luykepn=0, danop=0, luykedn=0, tonghop=1, dahoan=0, miengiam=0 WHERE ma=2", Timten("maso", ConvertToStrSafe(3334), "sohieu", "hethongtk")))
        Catch
        End Try
        Try
            ExecSQLNonQuery(String.Format("UPDATE Thue SET DienGiai=N'Thuế GTGT', matk={0}, kytruocsang=0,kynay=0, luykepn=0, danop=0, luykedn=0, tonghop=1, dahoan=0, miengiam=0 WHERE ma=3", Timten("maso", ConvertToStrSafe(3331), "sohieu", "hethongtk")))
        Catch
        End Try
        Try
            ExecSQLNonQuery(String.Format("UPDATE Thue SET DienGiai=N'Thuế Môn bài', matk={0}, kytruocsang=0,kynay=0, luykepn=0, danop=0, luykedn=0, tonghop=1, dahoan=0, miengiam=0 WHERE ma=4", Timten("maso", ConvertToStrSafe(3339), "sohieu", "hethongtk")))
        Catch
        End Try
        Try
            ExecSQLNonQuery(String.Format("UPDATE Thue SET DienGiai=N'Thuế phạt', matk={0}, kytruocsang=0,kynay=0, luykepn=0, danop=0, luykedn=0, tonghop=1, dahoan=0, miengiam=0 WHERE ma=5", Timten("maso", ConvertToStrSafe(3338), "sohieu", "hethongtk")))
        Catch
        End Try
        Try
            ExecSQLNonQuery("UPDATE Thue SET DienGiai=N'Thuế GTGT nộp thay', matk=0, kytruocsang=0,kynay=0, luykepn=0, danop=0, luykedn=0, tonghop=1, dahoan=0, miengiam=0 WHERE ma=6")
        Catch
        End Try
        Try
            ExecSQLNonQuery("UPDATE Thue SET DienGiai=N'Thuế TNDN nộp thay', matk=0, kytruocsang=0,kynay=0, luykepn=0, danop=0, luykedn=0, tonghop=1, dahoan=0, miengiam=0 WHERE ma=7")
        Catch
        End Try
        Try
            ExecSQLNonQuery(String.Format("UPDATE Thue SET DienGiai=N'Thuế TNCN', matk={0}, kytruocsang=0,kynay=0, luykepn=0, danop=0, luykedn=0, tonghop=1, dahoan=0, miengiam=0 WHERE ma=8", Timten("maso", ConvertToStrSafe(3335), "sohieu", "hethongtk")))
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreatePhanLoaiQuanLyNhanVienTable()
        Dim sql As String = String.Empty
        Try
            sql = "CREATE TABLE [dbo].[PhanLoaiQuanLyNhanVien]( [MaSo] [int] NOT NULL, [sohieu] [NVARCHAR](20) NULL DEFAULT ('...'), [ten] [NVARCHAR](50) NULL DEFAULT ('...'), [captren] [int] NULL DEFAULT ((0)), [cap] [int] NULL DEFAULT ((0)), CONSTRAINT [aaaaaPhanLoaiQuanLyNhanVien_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            ExecSQLNonQuery(sql)
        Catch
        End Try
        NhaplieuPL_QLNV()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateQuanLyNhanVienTable()
        Dim sql As String = String.Empty
        Try
            sql = "CREATE TABLE [dbo].[QuanLyNhanVien]( [MaSo] [int] NOT NULL, [Sohieu] [NVARCHAR](20) NULL DEFAULT ('...'), [ten] [NVARCHAR](50) NULL DEFAULT ('...'), [phai] [NVARCHAR](3) NULL DEFAULT ('...'), [ngaysinh] [datetime] NULL, [cmnd] [NVARCHAR](15) NULL DEFAULT ('...'), [ngaycap] [datetime] NULL, [noicap] [int] NULL DEFAULT ((0)), [tel1] [NVARCHAR](20) NULL DEFAULT ('...'), [mail] [NVARCHAR](50) NULL DEFAULT ('...'), [DiaChiCT] [NVARCHAR](50) NULL DEFAULT ('...'), [PhuongXaCT] [int] NULL DEFAULT ((0)), [quanhuyenct] [int] NULL DEFAULT ((0)), [tinhtpct] [int] NULL DEFAULT ((0)), [DiaChihk] [NVARCHAR](50) NULL DEFAULT ('...'), [PhuongXahk] [int] NULL DEFAULT ((0)), [quanhuyenhk] [int] NULL DEFAULT ((0)), [tinhtphk] [int] NULL DEFAULT ((0)), [quoctich] [int] NULL DEFAULT ((0)), [Maphanloai] [int] NULL DEFAULT ((0)), [MaChucvu] [int] NULL DEFAULT ((0)), [Bacluong] [int] NULL DEFAULT ((0)), [Nghiviec] [int] NULL DEFAULT ((0)), [Ngaynghi] [datetime] NULL, [Thaisan] [int] NULL DEFAULT ((0)), [TuNgay] [datetime] NULL, [DenNgay] [datetime] NULL, [baohiem] [int] NULL DEFAULT ((0)), [LoaiHD] [int] NULL DEFAULT ((0)), [LoaiLuong] [int] NULL DEFAULT ((0)), [Giamld] [int] NULL DEFAULT ((0)), [TuThang] [int] NULL DEFAULT ((0)), [DenThang] [int] NULL DEFAULT ((0)), [tang] [int] NULL DEFAULT ((0)), [thangtang] [int] NULL DEFAULT ((0)), [SoHD] [int] NULL DEFAULT ((0)), [SoBHXH] [NVARCHAR](20) NULL DEFAULT ('...'), [SoBHYT] [NVARCHAR](20) NULL DEFAULT ('...'), [The] [int] NULL DEFAULT ((0)), [Tu] [int] NULL DEFAULT ((0)), [Den] [int] NULL DEFAULT ((0)), [TangBH] [int] NULL DEFAULT ((0)), [ThangtangBH] [int] NULL DEFAULT ((0)), [MST] [NVARCHAR](20) NULL DEFAULT ('...'), CONSTRAINT [aaaaaQuanLyNhanVien_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            ExecSQLNonQuery(sql)
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateQuanLyNhanVienTable1()
        Dim co As Boolean
        Try
            co = TruongDaCo("Quanlynhanvien", "Bacluong")
            If Not co Then
                ExecSQLNonQuery("ALTER TABLE quanlynhanvien add Bacluong integer not null")
            End If
        Catch
        End Try
        Try
            co = TruongDaCo("Quanlynhanvien", "Nghiviec")
            If Not co Then
                ExecSQLNonQuery("ALTER TABLE quanlynhanvien add Nghiviec integer null")
            End If
        Catch
        End Try
        Try
            co = TruongDaCo("Quanlynhanvien", "Ngaynghi")
            If Not co Then
                ExecSQLNonQuery("ALTER TABLE quanlynhanvien add Ngaynghi datetime null")
            End If
        Catch
        End Try
        Try
            co = TruongDaCo("Quanlynhanvien", "Thaisan")
            If Not co Then
                ExecSQLNonQuery("ALTER TABLE quanlynhanvien add Thaisan integer null")
                ExecSQLNonQuery("ALTER TABLE quanlynhanvien add TuNgay datetime null")
                ExecSQLNonQuery("ALTER TABLE quanlynhanvien add DenNgay datetime null")
            End If
        Catch
        End Try
        Try
            XoaTruong("quanlynhanvien", "tel2")
            ExecSQLNonQuery("ALTER TABLE quanlynhanvien add column baohiem integer not null")
        Catch
        End Try
        Try
            co = TruongDaCo("Quanlynhanvien", "LoaiHD")
            If Not co Then
                ExecSQLNonQuery("ALTER TABLE quanlynhanvien add LoaiHD integer null")
                ExecSQLNonQuery("UPDATE quanlynhanvien SET loaihd=1")
            End If
        Catch
        End Try
        Try
            co = TruongDaCo("Quanlynhanvien", "LoaiLuong")
            If Not co Then
                ExecSQLNonQuery("ALTER TABLE quanlynhanvien add LoaiLuong integer null")
                ExecSQLNonQuery("UPDATE quanlynhanvien SET loailuong=1")
            End If
        Catch
        End Try
        Try
            co = TruongDaCo("Quanlynhanvien", "Giamld")
            If Not co Then
                ExecSQLNonQuery("ALTER TABLE quanlynhanvien add Giamld integer not null")
                ExecSQLNonQuery("ALTER TABLE quanlynhanvien add TuThang integer not null")
                ExecSQLNonQuery("ALTER TABLE quanlynhanvien add DenThang integer not null")
            End If
        Catch
        End Try
        Try
            If Not TruongDaCo("Quanlynhanvien", "tang") Then
                ExecSQLNonQuery("ALTER TABLE quanlynhanvien add tang integer not null,thangtang integer null")
                ExecSQLNonQuery("UPDATE quanlynhanvien SET tang=0,thangtang=0")
            End If
        Catch
        End Try
        Try
            Dim rs As DataTable
            Dim dem As Integer
            If Not TruongDaCo("Quanlynhanvien", "SoHD") Then
                ExecSQLNonQuery("ALTER TABLE quanlynhanvien add SoHD long null")
                rs = ExecSQLReturnDT("quanlynhanvien")
                For Each rsItem As DataRow In rs.Rows
                    dem = ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(qlnv.maso)AS f1 FROM quanlynhanvien qlnv inner join chucvu cv on qlnv.machucvu=cv.maso WHERE qlnv.maso<={0} AND cv.ten<>'Giám Đốc' AND cv.ten<>'Phó Giám Đốc' AND cv.ten<>'P. Giám Đốc' AND cv.ten<>'P.giám Đốc' AND cv.ten<>'Kế Toán Trưởng' ", rsItem("MaSo"))))
                    ExecSQLNonQuery(String.Format("UPDATE quanlynhanvien SET SoHD={0} WHERE maso={1}", _
                                        dem + 3, _
                                        rsItem("MaSo")))
                Next
                ExecSQLNonQuery("UPDATE quanlynhanvien qlnv inner join chucvu cv on qlnv.machucvu=cv.maso SET SoHD=1 WHERE cv.ten='Giám Đốc'")
                ExecSQLNonQuery("UPDATE quanlynhanvien qlnv inner join chucvu cv on qlnv.machucvu=cv.maso SET SoHD=2 WHERE cv.ten='Phó Giám Đốc' OR cv.ten='P.giám Đốc'OR cv.ten='P. Giám Đốc'")
                ExecSQLNonQuery("UPDATE quanlynhanvien qlnv inner join chucvu cv on qlnv.machucvu=cv.maso SET SoHD=3 WHERE cv.ten='Kế Toán Trưởng'")
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreatePhuongXaTable()
        Dim sql As String = String.Empty
        Try
            sql = "CREATE TABLE [dbo].[PhuongXa]( [MaSo] [int] NOT NULL, [ten] [NVARCHAR](50) NULL DEFAULT ('...'), CONSTRAINT [aaaaaPhuongXa_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            ExecSQLNonQuery(sql)
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateCMNDHochieuTable()
        Dim sql As String = String.Empty
        Try
            sql = "CREATE TABLE [dbo].[CMND]( [MaSo] [int] NOT NULL, [Sohieu] [NVARCHAR](20) NULL DEFAULT ('...'), [NgayCap] [datetime] NULL, [NoiCap] [NVARCHAR](50) NULL DEFAULT ('...'), CONSTRAINT [aaaaaCMND_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            ExecSQLNonQuery(sql)
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateQuanHuyenTable()
        Dim sql As String = String.Empty
        Try
            sql = "CREATE TABLE [dbo].[QuanHuyen]( [MaSo] [int] NOT NULL, [Ten] [NVARCHAR](50) NULL DEFAULT ('...'), CONSTRAINT [aaaaaQuanHuyen_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            ExecSQLNonQuery(sql)
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateTinhTPTable()
        Dim sql As String = String.Empty
        Try
            sql = "CREATE TABLE [dbo].[TinhTP]( [MaSo] [int] NOT NULL, [Ten] [NVARCHAR](50) NULL DEFAULT ('...'), CONSTRAINT [aaaaaTinhTP_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY] "
            ExecSQLNonQuery(sql)
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateChungTuTruocTable()
        Dim sql As String = String.Empty
        Try
            sql = "CREATE TABLE [dbo].[ChungTuTruoc]( [MaSo] [int] NOT NULL, [MaSoTK] [int] NULL DEFAULT ((0)), [SoHieuTK] [NVARCHAR](20) NULL DEFAULT ('...'), [MaTKNo] [int] NULL DEFAULT ((0)), [MaTKCo] [int] NULL DEFAULT ((0)), [SoPS] [float] NULL DEFAULT ((0)), [upsize_ts] [timestamp] NULL, CONSTRAINT [aaaaaChungTuTruoc_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            ExecSQLNonQuery(sql)
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateLCCDCTable()
        Dim sql As String = String.Empty
        Try
            sql = "CREATE TABLE [dbo].[LoaiCongcudungcu]( [Maso] [int] NOT NULL, [Ten] [NVARCHAR](50) NULL DEFAULT ('...'), [SoHieu] [NVARCHAR](15) NULL DEFAULT ('...'), [CapTren] [int] NULL DEFAULT ((0)), [Cap] [int] NULL DEFAULT ((0)), CONSTRAINT [aaaaaLoaiCongcudungcu_PK] PRIMARY KEY NONCLUSTERED ( [Maso] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            ExecSQLNonQuery(sql)
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateCCDCTable()
        Dim sql As String = String.Empty
        Try
            sql = "CREATE TABLE [dbo].[Congcudungcu]( [Maso] [int] NOT NULL, [SoHieu] [NVARCHAR](15) NULL DEFAULT ('...'), [Ten] [NVARCHAR](50) NULL DEFAULT ('...'), [NangLuc] [NVARCHAR](50) NULL DEFAULT ('...'), [GhiChu] [NVARCHAR](50) NULL DEFAULT ('...'), [MaNuoc] [int] NULL DEFAULT ((0)), [MaTaiKhoan] [int] NULL DEFAULT ((0)), [MaLoai] [int] NULL DEFAULT ((0)), [MaNhom] [int] NULL DEFAULT ((0)), [ThangTang] [int] NULL DEFAULT ((0)), [ThangGiam] [int] NULL DEFAULT ((0)), [NamSX] [int] NULL DEFAULT ((0)), [NamSD] [int] NULL DEFAULT ((0)), [NamKH] [int] NULL DEFAULT ((0)), [SHCT] [NVARCHAR](50) NULL DEFAULT ('...'), [NCT] [datetime] NULL, CONSTRAINT [aaaaaCongcudungcu_PK] PRIMARY KEY NONCLUSTERED ( [Maso] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            ExecSQLNonQuery(sql)
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateCTCCDCTable()
        Dim sql As String = String.Empty
        Try
            sql = "CREATE TABLE [dbo].[CTCongcudungcu]( [Maso] [int] NOT NULL, [MaCTKT] [int] NULL DEFAULT ((0)), [SoHieu] [NVARCHAR](15) NULL DEFAULT ('...'), [Thang] [int] NULL DEFAULT ((0)), [Vaoso] [datetime] NULL, [NgayGhi] [datetime] NULL, [DienGiai] [NVARCHAR](100) NULL DEFAULT ('...'), [MaLoai] [int] NULL DEFAULT ((0)), [MaNhom] [int] NULL DEFAULT ((0)), [MaTS] [int] NULL DEFAULT ((0)), [NG_NS] [int] NULL DEFAULT ((0)), [NG_TBS] [int] NULL DEFAULT ((0)), [NG_CNK] [int] NULL DEFAULT ((0)), [NG_TD] [int] NULL DEFAULT ((0)), [CL_NS] [int] NULL DEFAULT ((0)), [CL_TBS] [int] NULL DEFAULT ((0)), [CL_CNK] [int] NULL DEFAULT ((0)), [CL_TD] [int] NULL DEFAULT ((0)), [DienGiaiE] [NVARCHAR](100) NULL DEFAULT ('...'), CONSTRAINT [aaaaaCTCongcudungcu_PK] PRIMARY KEY NONCLUSTERED ( [Maso] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            ExecSQLNonQuery(sql)
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Createthongso1Table()
        Dim sql As String = String.Empty
        Try
            sql = "CREATE TABLE [dbo].[ThongSo1]( [Maso] [int] NOT NULL, [MaTS] [int] NULL DEFAULT ((0)), [thang] [int] NULL DEFAULT ((0)), [kh_ns] [int] NULL DEFAULT ((0)), [kh_tbs] [int] NULL DEFAULT ((0)), [kh_cnk] [int] NULL DEFAULT ((0)), [kh_td] [int] NULL DEFAULT ((0)), [ng_ns] [int] NULL DEFAULT ((0)), [ng_tbs] [int] NULL DEFAULT ((0)), [ng_cnk] [int] NULL DEFAULT ((0)), [ng_td] [int] NULL DEFAULT ((0)), [cl_ns] [int] NULL DEFAULT ((0)), [cl_tbs] [int] NULL DEFAULT ((0)), [cl_cnk] [int] NULL DEFAULT ((0)), [cl_td] [int] NULL DEFAULT ((0)), [MaDTSD] [int] NULL DEFAULT ((0)), [MaTTSD] [int] NULL DEFAULT ((0)), [MaDTQL] [int] NULL DEFAULT ((0)), CONSTRAINT [aaaaaThongSo1_PK] PRIMARY KEY NONCLUSTERED ( [Maso] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            ExecSQLNonQuery(sql)
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Updatephieunx()
        Try
            If Not TruongDaCo("Chungtu", "MaNhapXuat") Then
                ExecSQLNonQuery("ALTER TABLE Chungtu add MaNhapXuat varchar(10) null")
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateCSDL()
        Dim sql As String = String.Empty
        Dim rs As DataTable
        Dim MaSo, cotaisan As Integer
        Try
            If Not TruongDaCo("Chungtu", "MaThuChi") Then
                ExecSQLNonQuery("ALTER TABLE Chungtu add MaThuChi varchar(10) null")
            End If
        Catch
        End Try
        Try
            If Not TruongDaCo("NamTC", "MaSo") Then
                ExecSQLNonQuery("ALTER TABLE NamTC add MaSo counter primary key")
            End If
        Catch
        End Try
        cotaisan = ConvertToDblSafe(GetSelectValue("SELECT count(maso)AS f1 FROM taisan"))
        If cotaisan = 0 Then
            ExecSQLNonQuery("DELETE FROM loaitaisan")
        Else
            MaSo = ConvertToDblSafe(GetSelectValue("SELECT min(maso) AS f1 FROM loaitaisan"))
            ExecSQLNonQuery(String.Format("UPDATE taisan SET mataikhoan={0},maloai={1},manhom=0", MaSo, ConvertToStrSafe(MaSo)))
            ExecSQLNonQuery(String.Format("DELETE FROM loaitaisan WHERE maso>{0}", MaSo))
        End If
        '    UpdateLoaitaisan
        NhaplieuLoaitaisan()
        MaSo = ConvertToDblSafe(GetSelectValue("SELECT min(maso) AS f1 FROM loaitaisan WHERE cap=2"))
        If cotaisan > 0 Then ExecSQLNonQuery(String.Format("UPDATE taisan SET maloai={0}", MaSo))
        Try
            rs = ExecSQLReturnDT("SELECT sum(No_1),sum(Co_1),sum(No_2),sum(Co_2),sum(No_3),sum(Co_3),sum(No_4),sum(Co_4),sum(No_5),sum(Co_5),sum(No_6),sum(Co_6),sum(No_7),sum(Co_7),sum(No_8),sum(Co_8),sum(No_9),sum(Co_9),sum(No_10),sum(Co_10),sum(No_11),sum(Co_11),sum(No_12),sum(Co_12) FROM hethongtk group by sohieu having len(sohieu)=4 AND sohieu LIKE '211?'")
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                For i As Integer = 1 To 12
                    ExecSQLNonQuery(String.Format("UPDATE hethongtk SET No_{0}={1},Co_{2}={3} WHERE sohieu='211'", _
                                        i, _
                                        rsItem(2 * i - 2), _
                                        ConvertToStrSafe(i), _
                                        rsItem(2 * i - 1)))
                Next
            End If
        Catch
        End Try
        Try
            rs = ExecSQLReturnDT("SELECT sum(DuNo_0),sum(DuCo_0),sum(DuNo_1),sum(DuCo_1),sum(DuNo_2),sum(DuCo_2),sum(DuNo_3),sum(DuCo_3),sum(DuNo_4),sum(DuCo_4),sum(DuNo_5),sum(DuCo_5),sum(DuNo_6),sum(DuCo_6),sum(DuNo_7),sum(DuCo_7),sum(DuNo_8),sum(DuCo_8),sum(DuNo_9),sum(DuCo_9),sum(DuNo_10),sum(DuCo_10),sum(DuNo_11),sum(DuCo_11),sum(DuNo_12),sum(DuCo_12) FROM hethongtk group by sohieu having len(sohieu)=4 AND sohieu LIKE '211?'")
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                For i As Integer = 0 To 12
                    ExecSQLNonQuery(String.Format("UPDATE hethongtk SET DuNo_{0}={1},DuCo_{2}={3} WHERE sohieu='211'", _
                                        i, _
                                        rsItem(2 * i), _
                                        ConvertToStrSafe(i), _
                                        rsItem(2 * i + 1)))
                Next
            End If
        Catch
        End Try
        Try
            ExecSQLNonQuery(String.Format("UPDATE hethongtk SET tkcha1={0},tkcha0={1} WHERE len(sohieu)=4 AND sohieu LIKE '211?'", _
                                Timten("tkcha0", "211", "sohieu", "hethongtk"), _
                                Timten("maso", "211", "sohieu", "hethongtk")))
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateLoaitaisan()
        Dim rs1 As DataTable
        Dim rs As DataTable = ExecSQLReturnDT("SELECT * FROM loaitaisan WHERE len(sohieu)=6 AND cap=3 ORDER BY maso")
        If rs.Rows.Count > 0 Then
            'Xoá tài khoản có số hiệu gồm 6 chữ số
            ExecSQLNonQuery("DELETE FROM loaitaisan WHERE len(sohieu)=6 AND cap=3")
            'Tăng cấp của các tài khoản
            ExecSQLNonQuery("UPDATE loaitaisan SET cap=3 WHERE cap=2")
            ExecSQLNonQuery("UPDATE loaitaisan SET cap=2 WHERE cap=1")
            'Thêm tài khoản 211
            ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap) VALUES({0},'Tài sản cố định','211',0,1)", Lng_MaxValue("maso", "loaitaisan") + 1))
            'Cập nhật lại cấp trên của các tài khoản cấp 2
            ExecSQLNonQuery(String.Format("UPDATE loaitaisan SET captren= {0} WHERE cap=2", Timten("maso", "211", "sohieu", "loaitaisan")))
            For Each rsItem As DataRow In rs.Rows
                'Lấy danh sách các tài sản của tài khoản có số hiệu gồm 6 chữ số
                rs1 = ExecSQLReturnDT(String.Format("SELECT * FROM taisan WHERE manhom={0}", rsItem("MaSo")))
                For Each rs1Item As DataRow In rs1.Rows
                    'Cập nhật các tài sản của tài khoản có số hiệu gồm 6 chữ số
                    ExecSQLNonQuery(String.Format("UPDATE taisan SET sohieu=LEFT(sohieu,1)+RIGHT(sohieu,len(sohieu)-2),mataikhoan={0},maloai={1},manhom={2} WHERE maso={3}", _
                                        Timten("maso", Strings.Left(ConvertToStrSafe(rsItem("SoHieu")), 3), "sohieu", "loaitaisan"), _
                                        Timten("maso", Strings.Left(ConvertToStrSafe(rsItem("SoHieu")), 4), "sohieu", "loaitaisan"), _
                                        Timten("maso", Strings.Left(ConvertToStrSafe(rsItem("SoHieu")), 5), "sohieu", "loaitaisan"), _
                                        rs1Item("MaSo")))
                Next
            Next
        End If
        'Lấy danh sách các tài  sản có mã nhóm bằng 0
        rs1 = ExecSQLReturnDT("SELECT * FROM taisan WHERE manhom=0")
        For Each rs1Item As DataRow In rs1.Rows
            'Cập nhật lại các tài sản có mã nhóm bằng 0
            ExecSQLNonQuery(String.Format("UPDATE taisan SET mataikhoan={0},maloai={1},manhom={2} WHERE maso={3} AND mataikhoan<>{0}", _
                                Timten("maso", Strings.Left(ConvertToStrSafe(rs1Item("SoHieu")), 3), "sohieu", "loaitaisan"), _
                                rs1Item("MaTaiKhoan"), _
                                rs1Item("maloai"), _
                                rs1Item("MaSo")))
        Next
        'Xoá tài khoản 217
        ExecSQLNonQuery("DELETE FROM loaitaisan WHERE sohieu='217'")
        'Cập nhật lại số hiệu theo tên tài khoản Hữu hình
        Capnhatsohieuhuuhinh("Nhà cửa*", "21115")
        Capnhatsohieuhuuhinh("Máy móc*", "21116")
        Capnhatsohieuhuuhinh("*ng tiện*", "21117")
        Capnhatsohieuhuuhinh("TSCĐ hữu hình khác", "21118")
        Capnhatsohieuhuuhinh1("21115", "21111")
        Capnhatsohieuhuuhinh1("21116", "21112")
        Capnhatsohieuhuuhinh1("21117", "21113")
        Capnhatsohieuhuuhinh1("21118", "21114")
        'Cập nhật lại số hiệu theo tên tài khoản Vô hình
        rs = ExecSQLReturnDT("SELECT * FROM loaitaisan t3 inner join(loaitaisan t2 inner join taisan t1 on t1.manhom=t2.maso)on t3.maso=t2.captren WHERE t3.ten like '%vô hình%' ORDER BY t1.maso")
        If rs.Rows.Count = 0 Then
            rs1 = ExecSQLReturnDT("SELECT t2.maso FROM loaitaisan t3 inner join loaitaisan t2 on t3.maso=t2.captren WHERE t3.ten like '%vô hình%' ORDER BY t2.maso")
            For Each rs1Item As DataRow In rs1.Rows
                ExecSQLNonQuery("DELETE FROM loaitaisan WHERE maso=" & rs1Item("MaSo"))
            Next
        End If
        'Cập nhật số hiệu tài khoản vô hình + tài chính
        CapNhatSoHieuvohinh("2114", "*tài chính*")
        CapNhatSoHieuvohinh("2115", "*vô hình")
        CapNhatSoHieuvohinh("2112", "*tài chính*")
        CapNhatSoHieuvohinh("2113", "*vô hình")
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sohieu_moi"></param>
    ''' <param name="ten"></param>
    ''' <remarks></remarks>
    Public Sub CapNhatSoHieuvohinh(ByRef sohieu_moi As String, ByRef ten As String)
        Dim do_dai, cap_ct As Integer
        Dim maso_ct As Integer
        ExecSQLNonQuery(String.Format("UPDATE loaitaisan SET sohieu=N'{0}' WHERE ten LIKE '{1}'", sohieu_moi, ten))
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT * FROM loaitaisan WHERE cap=2 AND ten LIKE '{0}' ORDER BY maso", ten))
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            cap_ct = ConvertToDblSafe(rsItem("cap"))
            maso_ct = ConvertToDblSafe(rsItem("MaSo"))
            do_dai = sohieu_moi.Length
            ExecSQLNonQuery(String.Format("UPDATE LoaiTaiSan SET SoHieu =N'{0}' + RIGHT(SoHieu,Len(SoHieu) - {1}) WHERE CapTren = {2}", _
                                sohieu_moi, _
                                ConvertToStrSafe(do_dai), _
                                ConvertToStrSafe(maso_ct)))
            ExecSQLNonQuery(String.Format("UPDATE TaiSan SET SoHieu =N'{0}' + RIGHT(SoHieu,Len(SoHieu) - {1}) WHERE MaLoai = {2}", _
                                sohieu_moi, _
                                ConvertToStrSafe(do_dai), _
                                ConvertToStrSafe(maso_ct)))
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ten"></param>
    ''' <param name="sh"></param>
    ''' <remarks></remarks>
    Public Sub Capnhatsohieuhuuhinh(ByRef ten As String, ByRef sh As String)
        Dim i As Integer = sh.Length
        ExecSQLNonQuery(String.Format("UPDATE loaitaisan SET sohieu=N'{0}' WHERE ten LIKE '{1}'", sh, ten))
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT maso FROM loaitaisan WHERE ten LIKE '{0}' ORDER BY maso", ten))
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            ExecSQLNonQuery(String.Format("UPDATE TaiSan SET SoHieu =N'{0}' + RIGHT(SoHieu,Len(SoHieu) - {1}) WHERE MaNhom = {2}", _
                                sh, _
                                ConvertToStrSafe(i), _
                                rsItem("MaSo")))
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="shcu"></param>
    ''' <param name="sh"></param>
    ''' <remarks></remarks>
    Public Sub Capnhatsohieuhuuhinh1(ByRef shcu As String, ByRef sh As String)
        Dim i As Integer = sh.Length
        ExecSQLNonQuery(String.Format("UPDATE loaitaisan SET sohieu=N'{0}' WHERE sohieu=N'{1}'", sh, shcu))
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT maso FROM loaitaisan WHERE sohieu=N'{0}' ORDER BY maso", sh))
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            ExecSQLNonQuery(String.Format("UPDATE TaiSan SET SoHieu =N'{0}' + RIGHT(SoHieu,Len(SoHieu) - {1}) WHERE MaNhom = {2}", _
                                sh, _
                                ConvertToStrSafe(i), _
                                rsItem("MaSo")))
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub NhaplieuLoaitaisan()
        If Timten("maso", "211", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Tài sản cố định hữu hình','211',0,1)", ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1)))
            Catch
            End Try
        End If
        If Timten("maso", "2111", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Nhà cửa, vật kiến trúc','2111',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "211", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
        If Timten("maso", "2112", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Máy móc, thiết bị','2112',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "211", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
        If Timten("maso", "2113", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Phương tiện vận tải, truyền dẫn','2113',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "211", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
        If Timten("maso", "2114", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Thiết bị, dụng cụ quản lý','2114',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "211", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
        If Timten("maso", "2115", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Cây lâu năm, súc vật làm việc và cho sản phẩm','2115',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "211", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
        If Timten("maso", "2118", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Tài sản cố định khác','2118',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "211", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
        If Timten("maso", "212", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Tài sản cố định thuê tài chính','212',0,1)", ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1)))
            Catch
            End Try
        End If
        If Timten("maso", "2121", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Nhà cửa , vật kiến trúc','2121',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "212", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
        If Timten("maso", "2122", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Máy móc , thiết bị','2122',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "212", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
        If Timten("maso", "2123", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Phương tiện vận tải , truyền dẫn','2123',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "212", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
        If Timten("maso", "2124", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Thiết bị , dụng cụ quản lý','2124',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "212", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
        If Timten("maso", "2125", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Cây lâu năm , súc vật làm việc và cho sản phẩm','2125',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "212", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
        If Timten("maso", "2128", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Tài sản cố định  khác','2128',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "212", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
        If Timten("maso", "213", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Tài sản cố định vô hình','213',0,1)", ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1)))
            Catch
            End Try
        End If
        If Timten("maso", "2131", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Quyền sử dụng đất','2131',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "213", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
        If Timten("maso", "2132", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Quyền phát hành','2132',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "213", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
        If Timten("maso", "2133", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Bản quyền bằng sáng chế','2133',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "213", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
        If Timten("maso", "2134", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Nhãn hiệu hàng hóa','2134',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "213", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
        If Timten("maso", "2135", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Phần mềm máy vi tính','2135',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "213", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
        If Timten("maso", "2136", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Giấy phép và giấy phép nhượng quyền','2136',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "213", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
        If Timten("maso", "2138", "sohieu", "loaitaisan").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaitaisan(maso,ten,sohieu,captren,cap)VALUES({0},'Tài sản cố định vô hình khác','2138',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaitaisan") + 1), _
                                    Timten("maso", "213", "sohieu", "loaitaisan")))
            Catch
            End Try
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub NhaplieuPL_QLNV()
        If Timten("maso", "334", "sohieu", "phanloaiquanlynhanvien").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO phanloaiquanlynhanvien(maso,ten,sohieu,captren,cap)VALUES({0},'Công nhân viên','334',0,1)", ConvertToStrSafe(Lng_MaxValue("maso", "phanloaiquanlynhanvien") + 1)))
            Catch
            End Try
        End If
        If Timten("maso", "3341", "sohieu", "phanloaiquanlynhanvien").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO phanloaiquanlynhanvien(maso,ten,sohieu,captren,cap)VALUES({0},'Nhân viên văn phòng','3341',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "phanloaiquanlynhanvien") + 1), _
                                    Timten("maso", "334", "sohieu", "phanloaiquanlynhanvien")))
            Catch
            End Try
        End If
        If Timten("maso", "3342", "sohieu", "phanloaiquanlynhanvien").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO phanloaiquanlynhanvien(maso,ten,sohieu,captren,cap)VALUES({0},'Nhân viên bán hàng','3342',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "phanloaiquanlynhanvien") + 1), _
                                    Timten("maso", "334", "sohieu", "phanloaiquanlynhanvien")))
            Catch
            End Try
        End If
        If Timten("maso", "3343", "sohieu", "phanloaiquanlynhanvien").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO phanloaiquanlynhanvien(maso,ten,sohieu,captren,cap)VALUES({0},'Nhân viên sản xuất','3343',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "phanloaiquanlynhanvien") + 1), _
                                    Timten("maso", "334", "sohieu", "phanloaiquanlynhanvien")))
            Catch
            End Try
        End If
        If Timten("maso", "3344", "sohieu", "phanloaiquanlynhanvien").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO phanloaiquanlynhanvien(maso,ten,sohieu,captren,cap)VALUES({0},'Nhân viên công trình','3344',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "phanloaiquanlynhanvien") + 1), _
                                    Timten("maso", "334", "sohieu", "phanloaiquanlynhanvien")))
            Catch
            End Try
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub NhaplieuPL_CCDC_CTCDCD()
        If Timten("maso", "1531", "sohieu", "loaicongcudungcu").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaicongcudungcu(maso,ten,sohieu,captren,cap)VALUES({0},'Chi phí trả trước ngắn hạn','1531',0,1)", ConvertToStrSafe(Lng_MaxValue("maso", "loaicongcudungcu") + 1)))
            Catch
            End Try
        End If
        If Timten("maso", "15311", "sohieu", "loaicongcudungcu").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaicongcudungcu(maso,ten,sohieu,captren,cap)VALUES({0},'Công cụ dụng cụ','15311',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaicongcudungcu") + 1), _
                                    Timten("maso", "1531", "sohieu", "loaicongcudungcu")))
            Catch
            End Try
        End If
        If Timten("maso", "1532", "sohieu", "loaicongcudungcu").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaicongcudungcu(maso,ten,sohieu,captren,cap)VALUES({0},'Chi phí trả trước dài hạn','1532',0,1)", ConvertToStrSafe(Lng_MaxValue("maso", "loaicongcudungcu") + 1)))
            Catch
            End Try
        End If
        If Timten("maso", "15321", "sohieu", "loaicongcudungcu").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaicongcudungcu(maso,ten,sohieu,captren,cap)VALUES({0},'Công cụ dụng cụ','15321',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaicongcudungcu") + 1), _
                                    Timten("maso", "1532", "sohieu", "loaicongcudungcu")))
            Catch
            End Try
        End If
        If Timten("maso", "PBO", "sohieu", "loaichungtu").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaichungtu(maso,ten,sohieu,captren,cap)VALUES({0},'Trích phân bổ','PBO',0,1)", ConvertToStrSafe(Lng_MaxValue("maso", "loaichungtu") + 1)))
            Catch
            End Try
        End If
        If Timten("maso", "PBO-01", "sohieu", "loaichungtu").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaichungtu(maso,ten,sohieu,captren,cap)VALUES({0},'Trích phân bổ CCDC ngắn hạn','PBO-01',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaichungtu") + 1), _
                                    Timten("maso", "PBO", "sohieu", "loaichungtu")))
            Catch
            End Try
        End If
        If Timten("maso", "PBO-02", "sohieu", "loaichungtu").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO loaichungtu(maso,ten,sohieu,captren,cap)VALUES({0},'Trích phân bổ CCDC dài hạn','PBO-02',{1},2)", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "loaichungtu") + 1), _
                                    Timten("maso", "PBO", "sohieu", "loaichungtu")))
            Catch
            End Try
        End If
        If Timten("maso", "1531", "sohieu", "hethongtk").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO hethongtk (maso,sohieu,cap,ten,kieu,loai,tk_id,tkcha0,tkcha1,matc,capduoi,ngaykc,ngayht) VALUES ({0},'1531',2,'Công cụ dụng cụ ngắn hạn',-1,1,1000,{1},{2},{3},1, N'{4}', N'{4}')", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "hethongtk") + 1), _
                                    Timten("maso", "153", "sohieu", "hethongtk"), _
                                    Timten("tkcha0", "153", "sohieu", "hethongtk"), _
                                    ConvertToStrSafe(Lng_MaxValue("matc", "hethongtk") + 1), _
                                    Format(DateTime.Today, Mask_DB)))
            Catch
            End Try
        End If
        If Timten("maso", "1532", "sohieu", "hethongtk").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO hethongtk (maso,sohieu,cap,ten,kieu,loai,tk_id,tkcha0,tkcha1,matc,capduoi,ngaykc,ngayht) VALUES ({0},'1532',2,'Công cụ dụng cụ dài hạn',-1,1,1000,{1},{2},{3},1, N'{4}', N'{4}')", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "hethongtk") + 1), _
                                    Timten("maso", "153", "sohieu", "hethongtk"), _
                                    Timten("tkcha0", "153", "sohieu", "hethongtk"), _
                                    ConvertToStrSafe(Lng_MaxValue("matc", "hethongtk") + 1), _
                                    Format(DateTime.Today, Mask_DB)))
            Catch
            End Try
        End If
        Dim rscha As DataTable
        Dim rscon1, rscon2 As DataTable
        Dim sql As String = String.Empty
        If Timten("maso", "1531", "sohieu", "hethongtk").Length <> 0 Then
            Try
                rscha = ExecSQLReturnDT("SELECT duno_0,duco_0,duno_12,duco_12 FROM hethongtk WHERE sohieu='153'")
                rscon1 = ExecSQLReturnDT("SELECT duno_0,duco_0,duno_12,duco_12 FROM hethongtk WHERE sohieu='1531'")
                rscon2 = ExecSQLReturnDT("SELECT duno_0,duco_0,duno_12,duco_12 FROM hethongtk WHERE sohieu='1532'")
                Dim rschaItem As DataRow = rscha.Rows(0)
                Dim rscon1Item As DataRow = rscon1.Rows(0)
                Dim rscon2Item As DataRow = rscon2.Rows(0)
                If (ConvertToDblSafe(rschaItem("DuNo_0")) <> (ConvertToDblSafe(rscon1Item("DuNo_0")) + ConvertToDblSafe(rscon2Item("DuNo_0")))) _
                Or (ConvertToDblSafe(rschaItem("DuCo_0")) <> (ConvertToDblSafe(rscon1Item("DuCo_0")) + ConvertToDblSafe(rscon2Item("DuCo_0")))) _
                Or (ConvertToDblSafe(rschaItem("DuNo_12")) <> (ConvertToDblSafe(rscon1Item("DuNo_12")) + ConvertToDblSafe(rscon2Item("DuNo_12")))) _
                Or (ConvertToDblSafe(rschaItem("DuCo_12")) <> (ConvertToDblSafe(rscon1Item("DuCo_12")) + ConvertToDblSafe(rscon2Item("DuCo_12")))) Then
                    sql = String.Format("UPDATE hethongtk SET duno_0=,duco_0={0},duno_12={1},duco_12={2} WHERE sohieu='1531'", _
                              ConvertToStrSafe(ConvertToDblSafe(rschaItem("DuCo_0")) - ConvertToDblSafe(rscon2Item("DuCo_0"))), _
                              ConvertToStrSafe(ConvertToDblSafe(rschaItem("DuNo_12")) - ConvertToDblSafe(rscon2Item("DuNo_12"))), _
                              ConvertToStrSafe(ConvertToDblSafe(rschaItem("DuCo_12")) - ConvertToDblSafe(rscon2Item("DuCo_12"))))
                    ExecSQLNonQuery(sql)
                End If
                ExecSQLNonQuery(String.Format("UPDATE chungtu SET matktcno={0} ,matkno={0} WHERE matkno={1}", _
                                    Timten("maso", ConvertToStrSafe(1531), "sohieu", "hethongtk"), _
                                    Timten("maso", ConvertToStrSafe(153), "sohieu", "hethongtk")))
                ExecSQLNonQuery(String.Format("UPDATE chungtu SET matktcco={0} ,matkco={0} WHERE matkco={1}", _
                                    Timten("maso", ConvertToStrSafe(1531), "sohieu", "hethongtk"), _
                                    Timten("maso", ConvertToStrSafe(153), "sohieu", "hethongtk")))
            Catch
            End Try
        End If
        If Timten("maso", "13881", "sohieu", "hethongtk").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO hethongtk (maso,sohieu,cap,ten,kieu,loai,tk_id2,tkcha0,tkcha1,tkcha2,matc,capduoi,ngaykc,ngayht) VALUES ({0},'13881',3,'Chi phí không được khấu trừ vào thu nhập chịu thuế',-1,1,1310,{1},{2},{3},{4},0, N'{5}', N'{5}')", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "hethongtk") + 1), _
                                    Timten("maso", "1388", "sohieu", "hethongtk"), _
                                    Timten("tkcha0", "1388", "sohieu", "hethongtk"), _
                                    Timten("tkcha1", "1388", "sohieu", "hethongtk"), _
                                    Lng_MaxValue("matc", "hethongtk") + 1, _
                                    Format(DateTime.Today, Mask_DB)))
            Catch
            End Try
        End If
        If Timten("maso", "13881", "sohieu", "hethongtk").Length <> 0 Then
            Try
                rscha = ExecSQLReturnDT("SELECT duno_0,duco_0,duno_12,duco_12 FROM hethongtk WHERE sohieu='1388'")
                rscon1 = ExecSQLReturnDT("SELECT duno_0,duco_0,duno_12,duco_12 FROM hethongtk WHERE sohieu='13881'")
                Dim rschaItem As DataRow = rscha.Rows(0)
                Dim rscon1Item As DataRow = rscon1.Rows(0)
                If (ConvertToDblSafe(rschaItem("DuNo_0")) <> ConvertToDblSafe(rscon1Item("DuNo_0"))) _
                 Or (ConvertToDblSafe(rschaItem("DuCo_0")) <> ConvertToDblSafe(rscon1Item("DuCo_0"))) _
                 Or (ConvertToDblSafe(rschaItem("DuNo_12")) <> ConvertToDblSafe(rscon1Item("DuNo_12"))) _
                 Or (ConvertToDblSafe(rschaItem("DuCo_12")) <> ConvertToDblSafe(rscon1Item("DuCo_12"))) Then
                    sql = String.Format("UPDATE hethongtk SET duno_0={0},duco_0={1},duno_12={2},duco_12={3} WHERE sohieu='13881'", _
                              rschaItem("DuNo_0"), _
                              rschaItem("DuCo_0"), _
                              rschaItem("duno_12"), _
                              rschaItem("duco_12"))
                    ExecSQLNonQuery(sql)
                End If
                ExecSQLNonQuery(String.Format("UPDATE chungtu SET matktcno={0} ,matkno={0} WHERE matkno={1}", _
                                    Timten("maso", ConvertToStrSafe(13881), "sohieu", "hethongtk"), _
                                    Timten("maso", ConvertToStrSafe(1388), "sohieu", "hethongtk")))
                ExecSQLNonQuery(String.Format("UPDATE chungtu SET matktcco={0} ,matkco={0} WHERE matkco={1}", _
                                    Timten("maso", ConvertToStrSafe(13881), "sohieu", "hethongtk"), _
                                    Timten("maso", ConvertToStrSafe(1388), "sohieu", "hethongtk")))
            Catch
            End Try
        End If
        If ConvertToDblSafe(Timten("tkcon", "153", "sohieu", "hethongtk")) = 0 Then
            Try
                ExecSQLNonQuery("UPDATE hethongtk SET tkcon=1 WHERE sohieu='153'")
            Catch
            End Try
        End If
        If ConvertToDblSafe(Timten("tkcon", "1388", "sohieu", "hethongtk")) = 0 Then
            Try
                ExecSQLNonQuery("UPDATE hethongtk SET tkcon=1 WHERE sohieu='1388'")
            Catch
            End Try
        End If
        Try
            ExecSQLNonQuery("UPDATE hethongtk SET sohieu=LEFT(sohieu,3)+RIGHT(sohieu,1) WHERE sohieu='63501' OR sohieu='63502'")
        Catch
        End Try
        Try
            ExecSQLNonQuery("UPDATE hethongtk SET tkcon=1 WHERE sohieu='211'")
        Catch
        End Try
        rscha = ExecSQLReturnDT("SELECT * FROM phanloaivattu WHERE maso not in (SELECT t1.maso FROM phanloaivattu t1 inner join hethongtk t2 on t1.matk=t2.maso) AND maso not in(SELECT maphanloai FROM vattu)")
        For Each rschaItem As DataRow In rscha.Rows
            ExecSQLNonQuery(String.Format("DELETE FROM phanloaivattu WHERE maso={0}", rschaItem("MaSo")))
        Next
        Dim rs As DataTable
        rscha = ExecSQLReturnDT(String.Format("SELECT * FROM phanloaivattu WHERE matk ={0}", Timten("maso", "153", "sohieu", "hethongtk")))
        rs = ExecSQLReturnDT("SELECT maso FROM phanloaivattu vatty WHERE sohieu='CCDC'")
        If rscha.Rows.Count = 0 Then
            If rs.Rows.Count = 0 Then
                ExecSQLNonQuery(String.Format("INSERT INTO phanloaivattu(maso,sohieu,tenphanloai,vat,plcon,cap,matk,plcha) VALUES({0},'CCDC', N'{1}',0,0,1,{2},0)", _
                                    Lng_MaxValue("maso", "phanloaivattu") + 1, _
                                    "CÔNG CỤ DỤNG CỤ", _
                                    Timten("maso", "153", "sohieu", "hethongtk")))
            Else
                ExecSQLNonQuery(String.Format("UPDATE phanloaivattu SET matk={0} WHERE sohieu='CCDC'", Timten("maso", "153", "sohieu", "hethongtk")))
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateLoaicongcudungcu()
        If Timten("maso", "1421", "sohieu", "hethongtk").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO hethongtk (maso,sohieu,cap,ten,kieu,loai,tk_id,tkcha0,tkcha1,matc,capduoi,ngaykc,ngayht) VALUES ({0},'1421',2,'Chi phí trả trước',-1,1,0,{1},{2},{3},1, N'{4}', N'{4}')", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "hethongtk") + 1), _
                                    Timten("maso", "142", "sohieu", "hethongtk"), _
                                    Timten("tkcha0", "142", "sohieu", "hethongtk"), _
                                    ConvertToStrSafe(Lng_MaxValue("matc", "hethongtk") + 1), _
                                    Format(DateTime.Today, Mask_DB)))
            Catch
            End Try
        End If
        If Timten("maso", "1422", "sohieu", "hethongtk").Length = 0 Then
            Try
                ExecSQLNonQuery(String.Format("INSERT INTO hethongtk (maso,sohieu,cap,ten,kieu,loai,tk_id,tkcha0,tkcha1,matc,capduoi,ngaykc,ngayht) VALUES ({0},'1422',2,'Chi phí nhập hàng',-1,1,0,{1},{2},{3},1, N'{4}', N'{4}')", _
                                    ConvertToStrSafe(Lng_MaxValue("maso", "hethongtk") + 1), _
                                    Timten("maso", "142", "sohieu", "hethongtk"), _
                                    Timten("tkcha0", "142", "sohieu", "hethongtk"), _
                                    ConvertToStrSafe(Lng_MaxValue("matc", "hethongtk") + 1), _
                                    Format(DateTime.Today, Mask_DB)))
            Catch
            End Try
        End If
        If ConvertToDblSafe(Timten("tkcon", "142", "sohieu", "hethongtk")) = 0 Then
            Try
                ExecSQLNonQuery("UPDATE hethongtk SET tkcon=1 WHERE sohieu='142'")
            Catch
            End Try
        End If
        Dim rs1, rs2, rscon1, rscha, rscon2 As DataTable
        Dim sql As String = String.Empty
        If Timten("maso", "1421", "sohieu", "hethongtk").Length <> 0 Then
            Try
                rscha = ExecSQLReturnDT("SELECT duno_0,duco_0,duno_12,duco_12 FROM hethongtk WHERE sohieu='142'")
                rscon1 = ExecSQLReturnDT("SELECT duno_0,duco_0,duno_12,duco_12 FROM hethongtk WHERE sohieu='1421'")
                rscon2 = ExecSQLReturnDT("SELECT duno_0,duco_0,duno_12,duco_12 FROM hethongtk WHERE sohieu='1422'")
                Dim rschaItem As DataRow = rscha.Rows(0)
                Dim rscon1Item As DataRow = rscon1.Rows(0)
                Dim rscon2Item As DataRow = rscon2.Rows(0)
                If (ConvertToDblSafe(rschaItem("DuNo_0")) <> (ConvertToDblSafe(rscon1Item("DuNo_0")) + ConvertToDblSafe(rscon2Item("DuNo_0")))) _
                Or (ConvertToDblSafe(rschaItem("DuCo_0")) <> (ConvertToDblSafe(rscon1Item("DuCo_0")) + ConvertToDblSafe(rscon2Item("DuCo_0")))) _
                Or (ConvertToDblSafe(rschaItem("DuNo_12")) <> (ConvertToDblSafe(rscon1Item("DuNo_12")) + ConvertToDblSafe(rscon2Item("DuNo_12")))) _
                Or (ConvertToDblSafe(rschaItem("DuCo_12")) <> (ConvertToDblSafe(rscon1Item("DuCo_12")) + ConvertToDblSafe(rscon2Item("DuCo_12")))) Then
                    sql = String.Format("UPDATE hethongtk SET duno_0=,duco_0={0},duno_12={1},duco_12={2} WHERE sohieu='1421'", _
                              ConvertToStrSafe(ConvertToDblSafe(rschaItem("DuCo_0")) - ConvertToDblSafe(rscon2Item("DuCo_0"))), _
                              ConvertToStrSafe(ConvertToDblSafe(rschaItem("DuNo_12")) - ConvertToDblSafe(rscon2Item("DuNo_12"))), _
                              ConvertToStrSafe(ConvertToDblSafe(rschaItem("DuCo_12")) - ConvertToDblSafe(rscon2Item("DuCo_12"))))
                    ExecSQLNonQuery(sql)
                End If
                ExecSQLNonQuery(String.Format("UPDATE chungtu SET matktcno={0} ,matkno={0} WHERE matkno={1}", _
                                    Timten("maso", ConvertToStrSafe(1421), "sohieu", "hethongtk"), _
                                    Timten("maso", ConvertToStrSafe(142), "sohieu", "hethongtk")))
                ExecSQLNonQuery(String.Format("UPDATE chungtu SET matktcco={0} ,matkco={0} WHERE matkco={1}", _
                                    Timten("maso", ConvertToStrSafe(1421), "sohieu", "hethongtk"), _
                                    Timten("maso", ConvertToStrSafe(142), "sohieu", "hethongtk")))
                For i As Integer = 1 To 12
                    rs1 = ExecSQLReturnDT(String.Format("SELECT sum(sops) FROM chungtu WHERE matkno={0} AND thangct={1}", _
                                              Timten("maso", ConvertToStrSafe(1421), "sohieu", "hethongtk"), _
                                              i))
                    rs2 = ExecSQLReturnDT(String.Format("SELECT sum(sops) FROM chungtu WHERE matkco={0} AND thangct={1}", _
                                              Timten("maso", ConvertToStrSafe(1421), "sohieu", "hethongtk"), _
                                              i))
                    Dim rs1Item As DataRow = rs1.Rows(0)
                    Dim rs2Item As DataRow = rs2.Rows(0)
                    ExecSQLNonQuery(String.Format("UPDATE hethongtk SET no_{0}={1},co_{2}={3} WHERE sohieu='1421'", _
                                        i, _
                                        IIf(IsDBNull(rs1Item(0)), "0", ConvertToStrSafe(rs1Item(0))), _
                                        ConvertToStrSafe(i), _
                                        IIf(IsDBNull(rs2Item(0)), "0", ConvertToStrSafe(rs2Item(0)))))
                Next
            Catch
            End Try
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateDLNamTruocTable()
        Dim sql As String = String.Empty
        Try
            sql = "CREATE TABLE [dbo].[DLNamTruoc]( [MaSo] [int] NOT NULL, [MaSoTK] [int] NULL DEFAULT ((0)), [SoHieuTK] [NVARCHAR](20) NULL DEFAULT ('...'), [SoPSCo] [float] NULL DEFAULT ((0)), [SoPSNo] [float] NULL DEFAULT ((0)), [DkCo] [float] NULL DEFAULT ((0)), [DkNo] [float] NULL DEFAULT ((0)), [upsize_ts] [timestamp] NULL, CONSTRAINT [aaaaaDLNamTruoc_PK] PRIMARY KEY NONCLUSTERED ( [MaSo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            ExecSQLNonQuery(sql)
        Catch
        End Try
    End Sub
End Module

