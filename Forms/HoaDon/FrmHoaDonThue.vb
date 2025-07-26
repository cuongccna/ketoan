Imports UNET.ClsImportHoaDonThue
Imports System.IO
Imports System.Xml
Imports UNET.ClsVattu

Public Class FrmHoaDonThue

    Public list_dshhdichvu As New ClsImportHoaDonThue.ClsNDHDon.ClsDSHHDVu

    Public Sub DocDuLieu(ByVal ten_tap_tin_xml As String, ByRef m_dulieu As DataTable)
        Try
            Dim m_xmld As XmlDocument

            'Create the XML Document
            m_xmld = New XmlDocument()
            'Load the Xml file
            m_xmld.Load(ten_tap_tin_xml)

            '''
            'láy thông tin chứng từ ------------------------------------
            Dim ttchungtu As New ClsImportHoaDonThue
            Dim m_nodelist_ttChungTu As XmlNodeList
            Dim m_node_ttchungtu As XmlNode
            m_nodelist_ttChungTu = m_xmld.SelectNodes("/HDon/DLHDon/TTChung")
            'Loop through the nodes
            For Each m_node_ttchungtu In m_nodelist_ttChungTu

                ttchungtu._PBan = m_node_ttchungtu.Item("PBan").InnerText
                ttchungtu._THDon = m_node_ttchungtu.Item("THDon").InnerText
                ttchungtu._KHMSHDon = m_node_ttchungtu.Item("KHMSHDon").InnerText
                ttchungtu._KHHDon = m_node_ttchungtu.Item("KHHDon").InnerText
                ttchungtu._SHDon = m_node_ttchungtu.Item("SHDon").InnerText
                ttchungtu._MHSo = m_node_ttchungtu.Item("MHSo").InnerText
                ttchungtu._NLap = m_node_ttchungtu.Item("NLap").InnerText
                ttchungtu._SBKe = m_node_ttchungtu.Item("SBKe").InnerText
                ttchungtu._NBKe = m_node_ttchungtu.Item("NBKe").InnerText
                ttchungtu._DVTTe = m_node_ttchungtu.Item("DVTTe").InnerText
                ttchungtu._HTTToan = m_node_ttchungtu.Item("HTTToan").InnerText
                ttchungtu._MSTTCGP = m_node_ttchungtu.Item("MSTTCGP").InnerText
                ttchungtu._MSTDVNUNLHDon = m_node_ttchungtu.Item("MSTDVNUNLHDon").InnerText
                ttchungtu._TGia = m_node_ttchungtu.Item("TGia").InnerText
                ttchungtu._TDVNUNLHDon = m_node_ttchungtu.Item("TDVNUNLHDon").InnerText
                ttchungtu._DCDVNUNLHDon = m_node_ttchungtu.Item("DCDVNUNLHDon").InnerText

            Next
            '''hết láy thông tin chưng tư ----------------------------------

            '''-------------------------------------------------------------------
            ''' Nội dung hoa đơn

            ''' 1, chi tiết người bán --------------------------------------------
            Dim ttNguoiBan As New ClsImportHoaDonThue.ClsNDHDon.ClsNBan
            Dim m_nodelist_ttNguoiBan As XmlNodeList
            Dim m_node_ttNguoiBan As XmlNode
            m_nodelist_ttNguoiBan = m_xmld.SelectNodes("/HDon/DLHDon/NDHDon/NBan")
            For Each m_node_ttNguoiBan In m_nodelist_ttNguoiBan

                ttNguoiBan._Ten = m_node_ttNguoiBan.Item("Ten").InnerText
                ttNguoiBan._MST = m_node_ttNguoiBan.Item("MST").InnerText
                ttNguoiBan._DChi = m_node_ttNguoiBan.Item("DChi").InnerText
                ttNguoiBan._SDThoai = m_node_ttNguoiBan.Item("SDThoai").InnerText
                ttNguoiBan._DCTDTu = m_node_ttNguoiBan.Item("DCTDTu").InnerText
                ttNguoiBan._STKNHang = m_node_ttNguoiBan.Item("STKNHang").InnerText
                ttNguoiBan._TNHang = m_node_ttNguoiBan.Item("TNHang").InnerText
                ttNguoiBan._Fax = m_node_ttNguoiBan.Item("Fax").InnerText
                ttNguoiBan._Website = m_node_ttNguoiBan.Item("Website").InnerText
                ttNguoiBan._TTKhac = m_node_ttNguoiBan.Item("TTKhac").InnerText

            Next

            ''' hết lấy thông tin người bán------------------------------------------

            ''' 1, chi tiết người mua --------------------------------------------
            Dim ttNguoiMua As New ClsImportHoaDonThue.ClsNDHDon.ClsNMua
            Dim m_nodelist_ttNguoiMua As XmlNodeList
            Dim m_node_ttNguoiMua As XmlNode
            m_nodelist_ttNguoiMua = m_xmld.SelectNodes("/HDon/DLHDon/NDHDon/NMua")
            For Each m_node_ttNguoiMua In m_nodelist_ttNguoiMua

                ttNguoiMua._Ten = m_node_ttNguoiMua.Item("Ten").InnerText
                ttNguoiMua._MST = m_node_ttNguoiMua.Item("MST").InnerText
                ttNguoiMua._DChi = m_node_ttNguoiMua.Item("DChi").InnerText
                ttNguoiMua._MKHang = m_node_ttNguoiMua.Item("MKHang").InnerText
                ttNguoiMua._SDThoai = m_node_ttNguoiMua.Item("SDThoai").InnerText
                ttNguoiMua._HVTNMHang = m_node_ttNguoiMua.Item("HVTNMHang").InnerText
                ttNguoiMua._STKNHang = m_node_ttNguoiMua.Item("STKNHang").InnerText
                ttNguoiMua._TNHang = m_node_ttNguoiMua.Item("TNHang").InnerText
                ttNguoiMua._TTKhac = m_node_ttNguoiMua.Item("TTKhac").InnerText

            Next

            ''' hết lấy thông tin người Mua------------------------------------------


            ''' lấy thông tin hàng hóa dịch vu --------------------------------------

            'Dim list_dshhdichvu As New ClsImportHoaDonThue.ClsNDHDon.ClsDSHHDVu
            'list_dshhdichvu._DSHHDVu.Add(
            Dim m_nodelist_dshhdichvu As XmlNodeList
            Dim m_node_hhdvu As XmlNode
            m_nodelist_dshhdichvu = m_xmld.SelectNodes("/HDon/DLHDon/NDHDon/DSHHDVu/HHDVu")
            For Each m_node_hhdvu In m_nodelist_dshhdichvu

                Dim tthhdvu As New ClsImportHoaDonThue.ClsNDHDon.ClsDSHHDVu.ClsHHDVu
                tthhdvu._TChat = m_node_hhdvu.Item("TChat").InnerText
                tthhdvu._STT = m_node_hhdvu.Item("STT").InnerText
                tthhdvu._MHHDVu = m_node_hhdvu.Item("MHHDVu").InnerText
                tthhdvu._THHDVu = m_node_hhdvu.Item("THHDVu").InnerText
                tthhdvu._DVTinh = m_node_hhdvu.Item("DVTinh").InnerText
                tthhdvu._SLuong = m_node_hhdvu.Item("SLuong").InnerText
                tthhdvu._DGia = m_node_hhdvu.Item("DGia").InnerText
                tthhdvu._TLCKhau = m_node_hhdvu.Item("TLCKhau").InnerText
                tthhdvu._STCKhau = m_node_hhdvu.Item("STCKhau").InnerText
                tthhdvu._ThTien = m_node_hhdvu.Item("ThTien").InnerText
                tthhdvu._TSuat = m_node_hhdvu.Item("TSuat").InnerText

                Dim m_nodelist_ttkhac As XmlNodeList
                Dim m_node_ttkhac As XmlNode
                m_nodelist_ttkhac = m_node_hhdvu.SelectNodes("TTKhac/TTin")

                Dim list_ttkhac As New ClsImportHoaDonThue.ClsNDHDon.ClsDSHHDVu.ClsHHDVu.ClsTTKhac
                For Each m_node_ttkhac In m_nodelist_ttkhac
                    Dim list_ttin As New ClsImportHoaDonThue.ClsNDHDon.ClsDSHHDVu.ClsHHDVu.ClsTTKhac.ClsTTin
                    list_ttin._TTruong = m_node_ttkhac.Item("TTruong").InnerText
                    list_ttin._KDLieu = m_node_ttkhac.Item("KDLieu").InnerText
                    list_ttin._DLieu = m_node_ttkhac.Item("DLieu").InnerText

                    list_ttkhac._DSTTin.Add(list_ttin)
                Next
                tthhdvu._DSTTKhac.Add(list_ttkhac)
                list_dshhdichvu._DSHHDVu.Add(tthhdvu)
            Next

            ''' hết lấy thông tin hàng hóa dịch vu ---------------------------


            ' Lây thông tin thành toan ------------------------------------
            Dim ttTToan As New ClsImportHoaDonThue.ClsNDHDon.ClsTToan
            Dim m_nodelist_ttttoan As XmlNodeList
            Dim m_node_ttttoan As XmlNode
            m_nodelist_ttttoan = m_xmld.SelectNodes("/HDon/DLHDon/NDHDon/TToan")
            For Each m_node_ttttoan In m_nodelist_ttttoan

                ttTToan._TGTKCThue = m_node_ttttoan.Item("TGTKCThue").InnerText
                ttTToan._TGTKhac = m_node_ttttoan.Item("TGTKhac").InnerText
                ttTToan._TgTCThue = m_node_ttttoan.Item("TgTCThue").InnerText
                ttTToan._TgTThue = m_node_ttttoan.Item("TgTThue").InnerText
                ttTToan._TTCKTMai = m_node_ttttoan.Item("TTCKTMai").InnerText
                ttTToan._TgTTTBSo = m_node_ttttoan.Item("TgTTTBSo").InnerText
                ttTToan._TgTTTBChu = m_node_ttttoan.Item("TgTTTBChu").InnerText

                '-------- thong tin khac -----
                Dim m_nodelist_ttkhac As XmlNodeList
                Dim m_node_ttkhac As XmlNode
                Dim list_ttkhac As New ClsImportHoaDonThue.ClsNDHDon.ClsTToan.ClsTTKhac
                m_nodelist_ttkhac = m_node_ttttoan.SelectNodes("TTKhac/TTin")
                For Each m_node_ttkhac In m_nodelist_ttkhac
                    Dim list_ttin As New ClsImportHoaDonThue.ClsNDHDon.ClsTToan.ClsTTKhac.ClsTTin
                    list_ttin._TTruong = m_node_ttkhac.Item("TTruong").InnerText
                    list_ttin._KDLieu = m_node_ttkhac.Item("KDLieu").InnerText
                    list_ttin._DLieu = m_node_ttkhac.Item("DLieu").InnerText

                    list_ttkhac._DSTTin.Add(list_ttin)
                Next
                ttTToan._TTKhac = list_ttkhac
                '--------- hêt thong tin khac -----


                ' --------------- THTTLTSuat --------------
                Dim m_nodelist_ttTHTTLTSuat As XmlNodeList
                Dim m_node_ttTHTTLTSuat As XmlNode
                Dim list_ttTHTTLTSuat As New ClsImportHoaDonThue.ClsNDHDon.ClsTToan.ClsTHTTLTSuat
                m_nodelist_ttTHTTLTSuat = m_node_ttttoan.SelectNodes("THTTLTSuat/LTSuat")
                For Each m_node_ttTHTTLTSuat In m_nodelist_ttTHTTLTSuat
                    Dim list_LTSuat As New ClsImportHoaDonThue.ClsNDHDon.ClsTToan.ClsTHTTLTSuat.ClsLTSuat
                    list_LTSuat._TSuat = m_node_ttTHTTLTSuat.Item("TSuat").InnerText
                    list_LTSuat._ThTien = m_node_ttTHTTLTSuat.Item("ThTien").InnerText
                    list_LTSuat._TThue = m_node_ttTHTTLTSuat.Item("TThue").InnerText

                    list_ttTHTTLTSuat._DSLTSuat.Add(list_LTSuat)
                Next
                ttTToan._THTTLTSuat = list_ttTHTTLTSuat
                ' -------------- hêt THTTLTSuat -----------
            Next


            ' Hết Lây thông tin thành toan ------------------------------------


            ''' đưa thông tin lên lưới -----------------------------------------

            ' bước 1 xóa lưới cũ
            'dgv_danhsachhoadon.DataSource = Nothing

            'dgv_danhsachhoadon.Rows.Clear()
            'dgv_danhsachhoadon.Columns.Clear()


            ''' xây dưng datatable
            'Dim tbl_DuLieuHoaDon As New DataTable("HoaDon")
            'tbl_DuLieuHoaDon.Columns.Add("Col_Chon", GetType(Boolean)).Caption = "X"
            'tbl_DuLieuHoaDon.Columns.Add("Col_STT", GetType(String)).Caption = "STT"
            'tbl_DuLieuHoaDon.Columns.Add("col_Ghi", GetType(String)).Caption = "X"
            'tbl_DuLieuHoaDon.Columns.Add("col_Xem", GetType(String)).Caption = "X"
            'tbl_DuLieuHoaDon.Columns.Add("col_KyHieuMauSo", GetType(String)).Caption = "Ký hiệu mẫu số"
            'tbl_DuLieuHoaDon.Columns.Add("col_KyHieuHoaDon", GetType(String)).Caption = "Ký hiệu hóa đơn"
            'tbl_DuLieuHoaDon.Columns.Add("col_SoHoaDon", GetType(String)).Caption = "Số hóa đơn"
            'tbl_DuLieuHoaDon.Columns.Add("col_NgayLapHoaDon", GetType(DateTime)).Caption = "Ngày lập"
            'tbl_DuLieuHoaDon.Columns.Add("col_ThongTinHoaDon", GetType(String)).Caption = "Thông tin hóa đơn"
            'tbl_DuLieuHoaDon.Columns.Add("col_TonTienChuaThue", GetType(Double)).Caption = "Tổng tiền chưa thuế"
            'tbl_DuLieuHoaDon.Columns.Add("col_TongTienThue", GetType(Double)).Caption = "Tổng tiền thuế"
            'tbl_DuLieuHoaDon.Columns.Add("col_TongTienChietKhauThuongMai", GetType(Double)).Caption = "Tổng tiền chiết khấu thương mại"
            'tbl_DuLieuHoaDon.Columns.Add("col_TongTienPhi", GetType(Double)).Caption = "Tổng tiền phí"
            'tbl_DuLieuHoaDon.Columns.Add("col_TongTienThanhToan", GetType(Double)).Caption = "Tổng tiền thanh toán"
            'tbl_DuLieuHoaDon.Columns.Add("col_DonViTienTe", GetType(String)).Caption = "Đơn vị tiền tệ"


            '''' thêm dữ liêu
            Dim m_chon As Boolean = False
            Dim m_stt As Integer = 1
            Dim m_ghi As String = "Save"
            Dim m_xem As String = "View"
            Dim m_KyHieuMauSo As String = ttchungtu._KHMSHDon
            Dim m_KyHieuHoaDon As String = ttchungtu._KHHDon
            Dim m_SoHoaDon As String = ttchungtu._SHDon
            Dim m_NgayLapHoaDon As String = ttchungtu._NLap
            Dim m_ThongTinHoaDon As String = IIf(ttNguoiMua._MST.Length > 0, "MST người mua: " & ttNguoiMua._MST, String.Empty).ToString() & vbNewLine & IIf(ttNguoiMua._Ten.Length > 0, "Tên người mua: " & ttNguoiMua._Ten, String.Empty)
            Dim m_TongTienChuaThue As Double = ttTToan._TgTCThue
            Dim m_TongTienThue As Double = ttTToan._TgTThue
            Dim m_TongTienChietKhauThuongMai As Double = ttTToan._TTCKTMai
            Dim m_TongTienPhi As Double = 0
            Dim m_TongTienThanhToan As Double = ttTToan._TgTTTBSo
            Dim m_DonViTienTe As String = ttchungtu._DVTTe

            m_dulieu.Rows.Add(m_chon, _
                                      m_stt, _
                                      m_ghi, _
                                      m_xem, _
                                      m_KyHieuMauSo, _
                                      m_KyHieuHoaDon, _
                                      m_SoHoaDon, _
                                      m_NgayLapHoaDon, _
                                      m_ThongTinHoaDon, _
                                      m_TongTienChuaThue, _
                                      m_TongTienThue, _
                                      m_TongTienChietKhauThuongMai, _
                                        m_TongTienPhi, _
                                        m_TongTienThanhToan, _
                                        m_DonViTienTe)


            ' gán datasource
            'dgv_danhsachhoadon.DataSource = tbl_DuLieuHoaDon
            'tbl_DuLieuHoaDon.Dispose()

            ''' hết đưa thông tin lên lưới --------------------------------------
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub DocDuLieu(ByVal ten_tap_tin_xml As String)
        Try
            Dim m_xmld As XmlDocument
           
            'Create the XML Document
            m_xmld = New XmlDocument()
            'Load the Xml file
            m_xmld.Load(ten_tap_tin_xml)

            '''
            'láy thông tin chứng từ ------------------------------------
            Dim ttchungtu As New ClsImportHoaDonThue
            Dim m_nodelist_ttChungTu As XmlNodeList
            Dim m_node_ttchungtu As XmlNode
            m_nodelist_ttChungTu = m_xmld.SelectNodes("/HDon/DLHDon/TTChung")
            'Loop through the nodes
            For Each m_node_ttchungtu In m_nodelist_ttChungTu

                ttchungtu._PBan = m_node_ttchungtu.Item("PBan").InnerText
                ttchungtu._THDon = m_node_ttchungtu.Item("THDon").InnerText
                ttchungtu._KHMSHDon = m_node_ttchungtu.Item("KHMSHDon").InnerText
                ttchungtu._KHHDon = m_node_ttchungtu.Item("KHHDon").InnerText
                ttchungtu._SHDon = m_node_ttchungtu.Item("SHDon").InnerText
                ttchungtu._MHSo = m_node_ttchungtu.Item("MHSo").InnerText
                ttchungtu._NLap = m_node_ttchungtu.Item("NLap").InnerText
                ttchungtu._SBKe = m_node_ttchungtu.Item("SBKe").InnerText
                ttchungtu._NBKe = m_node_ttchungtu.Item("NBKe").InnerText
                ttchungtu._DVTTe = m_node_ttchungtu.Item("DVTTe").InnerText
                ttchungtu._HTTToan = m_node_ttchungtu.Item("HTTToan").InnerText
                ttchungtu._MSTTCGP = m_node_ttchungtu.Item("MSTTCGP").InnerText
                ttchungtu._MSTDVNUNLHDon = m_node_ttchungtu.Item("MSTDVNUNLHDon").InnerText
                ttchungtu._TGia = m_node_ttchungtu.Item("TGia").InnerText
                ttchungtu._TDVNUNLHDon = m_node_ttchungtu.Item("TDVNUNLHDon").InnerText
                ttchungtu._DCDVNUNLHDon = m_node_ttchungtu.Item("DCDVNUNLHDon").InnerText

            Next
            '''hết láy thông tin chưng tư ----------------------------------

            '''-------------------------------------------------------------------
            ''' Nội dung hoa đơn

            ''' 1, chi tiết người bán --------------------------------------------
            Dim ttNguoiBan As New ClsImportHoaDonThue.ClsNDHDon.ClsNBan
            Dim m_nodelist_ttNguoiBan As XmlNodeList
            Dim m_node_ttNguoiBan As XmlNode
            m_nodelist_ttNguoiBan = m_xmld.SelectNodes("/HDon/DLHDon/NDHDon/NBan")
            For Each m_node_ttNguoiBan In m_nodelist_ttNguoiBan
               
                ttNguoiBan._Ten = m_node_ttNguoiBan.Item("Ten").InnerText
                ttNguoiBan._MST = m_node_ttNguoiBan.Item("MST").InnerText
                ttNguoiBan._DChi = m_node_ttNguoiBan.Item("DChi").InnerText
                ttNguoiBan._SDThoai = m_node_ttNguoiBan.Item("SDThoai").InnerText
                ttNguoiBan._DCTDTu = m_node_ttNguoiBan.Item("DCTDTu").InnerText
                ttNguoiBan._STKNHang = m_node_ttNguoiBan.Item("STKNHang").InnerText
                ttNguoiBan._TNHang = m_node_ttNguoiBan.Item("TNHang").InnerText
                ttNguoiBan._Fax = m_node_ttNguoiBan.Item("Fax").InnerText
                ttNguoiBan._Website = m_node_ttNguoiBan.Item("Website").InnerText
                ttNguoiBan._TTKhac = m_node_ttNguoiBan.Item("TTKhac").InnerText

            Next

            ''' hết lấy thông tin người bán------------------------------------------

            ''' 1, chi tiết người mua --------------------------------------------
            Dim ttNguoiMua As New ClsImportHoaDonThue.ClsNDHDon.ClsNMua
            Dim m_nodelist_ttNguoiMua As XmlNodeList
            Dim m_node_ttNguoiMua As XmlNode
            m_nodelist_ttNguoiMua = m_xmld.SelectNodes("/HDon/DLHDon/NDHDon/NMua")
            For Each m_node_ttNguoiMua In m_nodelist_ttNguoiMua
                
                ttNguoiMua._Ten = m_node_ttNguoiMua.Item("Ten").InnerText
                ttNguoiMua._MST = m_node_ttNguoiMua.Item("MST").InnerText
                ttNguoiMua._DChi = m_node_ttNguoiMua.Item("DChi").InnerText
                ttNguoiMua._MKHang = m_node_ttNguoiMua.Item("MKHang").InnerText
                ttNguoiMua._SDThoai = m_node_ttNguoiMua.Item("SDThoai").InnerText
                ttNguoiMua._HVTNMHang = m_node_ttNguoiMua.Item("HVTNMHang").InnerText
                ttNguoiMua._STKNHang = m_node_ttNguoiMua.Item("STKNHang").InnerText
                ttNguoiMua._TNHang = m_node_ttNguoiMua.Item("TNHang").InnerText
                ttNguoiMua._TTKhac = m_node_ttNguoiMua.Item("TTKhac").InnerText

            Next

            ''' hết lấy thông tin người Mua------------------------------------------


            ''' lấy thông tin hàng hóa dịch vu --------------------------------------

            'Dim list_dshhdichvu As New ClsImportHoaDonThue.ClsNDHDon.ClsDSHHDVu
            'list_dshhdichvu._DSHHDVu.Add(
            Dim m_nodelist_dshhdichvu As XmlNodeList
            Dim m_node_hhdvu As XmlNode
            m_nodelist_dshhdichvu = m_xmld.SelectNodes("/HDon/DLHDon/NDHDon/DSHHDVu/HHDVu")
            For Each m_node_hhdvu In m_nodelist_dshhdichvu

                Dim tthhdvu As New ClsImportHoaDonThue.ClsNDHDon.ClsDSHHDVu.ClsHHDVu
                tthhdvu._TChat = m_node_hhdvu.Item("TChat").InnerText
                tthhdvu._STT = m_node_hhdvu.Item("STT").InnerText
                tthhdvu._MHHDVu = m_node_hhdvu.Item("MHHDVu").InnerText
                tthhdvu._THHDVu = m_node_hhdvu.Item("THHDVu").InnerText
                tthhdvu._DVTinh = m_node_hhdvu.Item("DVTinh").InnerText
                tthhdvu._SLuong = m_node_hhdvu.Item("SLuong").InnerText
                tthhdvu._DGia = m_node_hhdvu.Item("DGia").InnerText
                tthhdvu._TLCKhau = m_node_hhdvu.Item("TLCKhau").InnerText
                tthhdvu._STCKhau = m_node_hhdvu.Item("STCKhau").InnerText
                tthhdvu._ThTien = m_node_hhdvu.Item("ThTien").InnerText
                tthhdvu._TSuat = m_node_hhdvu.Item("TSuat").InnerText

                Dim m_nodelist_ttkhac As XmlNodeList
                Dim m_node_ttkhac As XmlNode
                m_nodelist_ttkhac = m_node_hhdvu.SelectNodes("TTKhac/TTin")

                Dim list_ttkhac As New ClsImportHoaDonThue.ClsNDHDon.ClsDSHHDVu.ClsHHDVu.ClsTTKhac
                For Each m_node_ttkhac In m_nodelist_ttkhac
                    Dim list_ttin As New ClsImportHoaDonThue.ClsNDHDon.ClsDSHHDVu.ClsHHDVu.ClsTTKhac.ClsTTin
                    list_ttin._TTruong = m_node_ttkhac.Item("TTruong").InnerText
                    list_ttin._KDLieu = m_node_ttkhac.Item("KDLieu").InnerText
                    list_ttin._DLieu = m_node_ttkhac.Item("DLieu").InnerText

                    list_ttkhac._DSTTin.Add(list_ttin)
                Next
                tthhdvu._DSTTKhac.Add(list_ttkhac)
                list_dshhdichvu._DSHHDVu.Add(tthhdvu)
            Next

            ''' hết lấy thông tin hàng hóa dịch vu ---------------------------


            ' Lây thông tin thành toan ------------------------------------
            Dim ttTToan As New ClsImportHoaDonThue.ClsNDHDon.ClsTToan
            Dim m_nodelist_ttttoan As XmlNodeList
            Dim m_node_ttttoan As XmlNode
            m_nodelist_ttttoan = m_xmld.SelectNodes("/HDon/DLHDon/NDHDon/TToan")
            For Each m_node_ttttoan In m_nodelist_ttttoan

                ttTToan._TGTKCThue = m_node_ttttoan.Item("TGTKCThue").InnerText
                ttTToan._TGTKhac = m_node_ttttoan.Item("TGTKhac").InnerText
                ttTToan._TgTCThue = m_node_ttttoan.Item("TgTCThue").InnerText
                ttTToan._TgTThue = m_node_ttttoan.Item("TgTThue").InnerText
                ttTToan._TTCKTMai = m_node_ttttoan.Item("TTCKTMai").InnerText
                ttTToan._TgTTTBSo = m_node_ttttoan.Item("TgTTTBSo").InnerText
                ttTToan._TgTTTBChu = m_node_ttttoan.Item("TgTTTBChu").InnerText

                '-------- thong tin khac -----
                Dim m_nodelist_ttkhac As XmlNodeList
                Dim m_node_ttkhac As XmlNode
                Dim list_ttkhac As New ClsImportHoaDonThue.ClsNDHDon.ClsTToan.ClsTTKhac
                m_nodelist_ttkhac = m_node_ttttoan.SelectNodes("TTKhac/TTin")
                For Each m_node_ttkhac In m_nodelist_ttkhac
                    Dim list_ttin As New ClsImportHoaDonThue.ClsNDHDon.ClsTToan.ClsTTKhac.ClsTTin
                    list_ttin._TTruong = m_node_ttkhac.Item("TTruong").InnerText
                    list_ttin._KDLieu = m_node_ttkhac.Item("KDLieu").InnerText
                    list_ttin._DLieu = m_node_ttkhac.Item("DLieu").InnerText

                    list_ttkhac._DSTTin.Add(list_ttin)
                Next
                ttTToan._TTKhac = list_ttkhac
                '--------- hêt thong tin khac -----


                ' --------------- THTTLTSuat --------------
                Dim m_nodelist_ttTHTTLTSuat As XmlNodeList
                Dim m_node_ttTHTTLTSuat As XmlNode
                Dim list_ttTHTTLTSuat As New ClsImportHoaDonThue.ClsNDHDon.ClsTToan.ClsTHTTLTSuat
                m_nodelist_ttTHTTLTSuat = m_node_ttttoan.SelectNodes("THTTLTSuat/LTSuat")
                For Each m_node_ttTHTTLTSuat In m_nodelist_ttTHTTLTSuat
                    Dim list_LTSuat As New ClsImportHoaDonThue.ClsNDHDon.ClsTToan.ClsTHTTLTSuat.ClsLTSuat
                    list_LTSuat._TSuat = m_node_ttTHTTLTSuat.Item("TSuat").InnerText
                    list_LTSuat._ThTien = m_node_ttTHTTLTSuat.Item("ThTien").InnerText
                    list_LTSuat._TThue = m_node_ttTHTTLTSuat.Item("TThue").InnerText

                    list_ttTHTTLTSuat._DSLTSuat.Add(list_LTSuat)
                Next
                ttTToan._THTTLTSuat = list_ttTHTTLTSuat
                ' -------------- hêt THTTLTSuat -----------
            Next


            ' Hết Lây thông tin thành toan ------------------------------------


            ''' đưa thông tin lên lưới -----------------------------------------

            ' bước 1 xóa lưới cũ
            'dgv_danhsachhoadon.DataSource = Nothing

            'dgv_danhsachhoadon.Rows.Clear()
            'dgv_danhsachhoadon.Columns.Clear()


            ''' xây dưng datatable
            Dim tbl_DuLieuHoaDon As New DataTable("HoaDon")
            tbl_DuLieuHoaDon.Columns.Add("Col_Chon", GetType(Boolean)).Caption = "X"
            tbl_DuLieuHoaDon.Columns.Add("Col_STT", GetType(String)).Caption = "STT"
            tbl_DuLieuHoaDon.Columns.Add("col_Ghi", GetType(String)).Caption = "X"
            tbl_DuLieuHoaDon.Columns.Add("col_Xem", GetType(String)).Caption = "X"
            tbl_DuLieuHoaDon.Columns.Add("col_KyHieuMauSo", GetType(String)).Caption = "Ký hiệu mẫu số"
            tbl_DuLieuHoaDon.Columns.Add("col_KyHieuHoaDon", GetType(String)).Caption = "Ký hiệu hóa đơn"
            tbl_DuLieuHoaDon.Columns.Add("col_SoHoaDon", GetType(String)).Caption = "Số hóa đơn"
            tbl_DuLieuHoaDon.Columns.Add("col_NgayLapHoaDon", GetType(DateTime)).Caption = "Ngày lập"
            tbl_DuLieuHoaDon.Columns.Add("col_ThongTinHoaDon", GetType(String)).Caption = "Thông tin hóa đơn"
            tbl_DuLieuHoaDon.Columns.Add("col_TonTienChuaThue", GetType(Double)).Caption = "Tổng tiền chưa thuế"
            tbl_DuLieuHoaDon.Columns.Add("col_TongTienThue", GetType(Double)).Caption = "Tổng tiền thuế"
            tbl_DuLieuHoaDon.Columns.Add("col_TongTienChietKhauThuongMai", GetType(Double)).Caption = "Tổng tiền chiết khấu thương mại"
            tbl_DuLieuHoaDon.Columns.Add("col_TongTienPhi", GetType(Double)).Caption = "Tổng tiền phí"
            tbl_DuLieuHoaDon.Columns.Add("col_TongTienThanhToan", GetType(Double)).Caption = "Tổng tiền thanh toán"
            tbl_DuLieuHoaDon.Columns.Add("col_DonViTienTe", GetType(String)).Caption = "Đơn vị tiền tệ"


            '''' thêm dữ liêu
            Dim m_chon As Boolean = False
            Dim m_stt As Integer = 1
            Dim m_ghi As String = "Save"
            Dim m_xem As String = "View"
            Dim m_KyHieuMauSo As String = ttchungtu._KHMSHDon
            Dim m_KyHieuHoaDon As String = ttchungtu._KHHDon
            Dim m_SoHoaDon As String = ttchungtu._SHDon
            Dim m_NgayLapHoaDon As String = ttchungtu._NLap
            Dim m_ThongTinHoaDon As String = IIf(ttNguoiMua._MST.Length > 0, "MST người mua: " & ttNguoiMua._MST, String.Empty).ToString() & vbNewLine & IIf(ttNguoiMua._Ten.Length > 0, "Tên người mua: " & ttNguoiMua._Ten, String.Empty)
            Dim m_TongTienChuaThue As Double = ttTToan._TgTCThue
            Dim m_TongTienThue As Double = ttTToan._TgTThue
            Dim m_TongTienChietKhauThuongMai As Double = ttTToan._TTCKTMai
            Dim m_TongTienPhi As Double = 0
            Dim m_TongTienThanhToan As Double = ttTToan._TgTTTBSo
            Dim m_DonViTienTe As String = ttchungtu._DVTTe

            tbl_DuLieuHoaDon.Rows.Add(m_chon, _
                                      m_stt, _
                                      m_ghi, _
                                      m_xem, _
                                      m_KyHieuMauSo, _
                                      m_KyHieuHoaDon, _
                                      m_SoHoaDon, _
                                      m_NgayLapHoaDon, _
                                      m_ThongTinHoaDon, _
                                      m_TongTienChuaThue, _
                                      m_TongTienThue, _
                                      m_TongTienChietKhauThuongMai, _
                                        m_TongTienPhi, _
                                        m_TongTienThanhToan, _
                                        m_DonViTienTe)


            ' gán datasource
            dgv_danhsachhoadon.DataSource = tbl_DuLieuHoaDon
            tbl_DuLieuHoaDon.Dispose()

            ''' hết đưa thông tin lên lưới --------------------------------------
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub btnMoTapTin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoTapTin.Click
        Try
            Dim openFD As New OpenFileDialog
            openFD.Title = "Mở tập tin XML"
            openFD.Filter = "XML |*.xml"

            If openFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtTapTin.Text = openFD.FileName
                DocDuLieu(txtTapTin.Text)
            End If
        Catch ex As Exception
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub dgv_chitiethoadon_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_chitiethoadon.CellClick
       
    End Sub

    Private Sub dgv_danhsachhoadon_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_danhsachhoadon.CellClick
        'Hien thi hoa don
        If e.ColumnIndex = 3 Then
            'Do any thing
            ''' chi tiết hóa đơn

            ''' xây dưng datatable
            Dim tbl_ChiTietHoaDon As New DataTable("ChiTietHoaDon")

            tbl_ChiTietHoaDon.Columns.Add("colct_STT", GetType(String)).Caption = "STT"
            tbl_ChiTietHoaDon.Columns.Add("colct_tinhchat", GetType(String)).Caption = "Tính chất"
            tbl_ChiTietHoaDon.Columns.Add("colct_tenhanghoadichvu", GetType(String)).Caption = "Tên hàng hóa dịch vụ"
            tbl_ChiTietHoaDon.Columns.Add("colct_donvitinh", GetType(String)).Caption = "Đơn vị tính"
            tbl_ChiTietHoaDon.Columns.Add("colct_soluong", GetType(Double)).Caption = "Số lượng"
            tbl_ChiTietHoaDon.Columns.Add("colct_dongia", GetType(Double)).Caption = "Đơn giá"
            tbl_ChiTietHoaDon.Columns.Add("colct_chietkhau", GetType(Double)).Caption = "Chiết khấu"
            tbl_ChiTietHoaDon.Columns.Add("colct_thuesuat", GetType(String)).Caption = "Thuế suất"
            tbl_ChiTietHoaDon.Columns.Add("colct_thanhtienchuacothuegtgt", GetType(Double)).Caption = "Thành tiền chưa thuế giá trị gia tăng"
            tbl_ChiTietHoaDon.Columns.Add("colct_tienthue", GetType(Double)).Caption = "Tiền thuế"
            tbl_ChiTietHoaDon.Columns.Add("colct_tongtienthanhtoan", GetType(Double)).Caption = "Tổng tiền thanh toán"

            ' thêm dữ liệu chi tiết hóa đơn

            tbl_ChiTietHoaDon.Rows.Clear()
            For Each m_hhdv As ClsImportHoaDonThue.ClsNDHDon.ClsDSHHDVu.ClsHHDVu In list_dshhdichvu._DSHHDVu
                Dim m_tienthue As Double = 0
                Dim m_tongtienthanhtoan As Double = 0

                For Each m_ttdvk As ClsImportHoaDonThue.ClsNDHDon.ClsDSHHDVu.ClsHHDVu.ClsTTKhac In m_hhdv._DSTTKhac

                    For Each m_ttin As ClsImportHoaDonThue.ClsNDHDon.ClsDSHHDVu.ClsHHDVu.ClsTTKhac.ClsTTin In m_ttdvk._DSTTin
                        If (m_ttin._TTruong = "VATAmount") Then
                            m_tienthue = Double.Parse(m_ttin._DLieu)

                        End If
                        If (m_ttin._TTruong = "Amount") Then
                            m_tongtienthanhtoan = Double.Parse(m_ttin._DLieu)
                        End If
                    Next

                Next
                tbl_ChiTietHoaDon.Rows.Add(m_hhdv._STT, _
                                            m_hhdv._TChat, _
                                            m_hhdv._THHDVu, _
                                            m_hhdv._DVTinh, _
                                            m_hhdv._SLuong, _
                                            m_hhdv._DGia, _
                                            m_hhdv._STCKhau, _
                                            m_hhdv._TSuat, _
                                            m_hhdv._ThTien, _
                                            m_tienthue, _
                                            m_tongtienthanhtoan)

            Next

            While dgv_chitiethoadon.Rows.Count > 0
                dgv_chitiethoadon.Rows.RemoveAt(0)
            End While

            dgv_chitiethoadon.Refresh()

            dgv_chitiethoadon.DataSource = tbl_ChiTietHoaDon

            tbl_ChiTietHoaDon.Dispose()

            'MsgBox("yes" + dgv_danhsachhoadon.Item(e.ColumnIndex, e.RowIndex).Value.ToString())
        ElseIf e.ColumnIndex = 2 Then
            GhiHoaDon()
            MsgBox("yes" + dgv_danhsachhoadon.Item(e.ColumnIndex, e.RowIndex).Value.ToString())
        End If
    End Sub
    
    Private Sub GhiHoaDon()
        Try
            ' Kiem tra vật tư đã có chưa nếu chưa có thêm mới
            For Each m_hhdv As ClsImportHoaDonThue.ClsNDHDon.ClsDSHHDVu.ClsHHDVu In list_dshhdichvu._DSHHDVu
                Dim m_tienthue As Double = 0
                Dim m_tongtienthanhtoan As Double = 0


                For Each m_ttdvk As ClsImportHoaDonThue.ClsNDHDon.ClsDSHHDVu.ClsHHDVu.ClsTTKhac In m_hhdv._DSTTKhac

                    For Each m_ttin As ClsImportHoaDonThue.ClsNDHDon.ClsDSHHDVu.ClsHHDVu.ClsTTKhac.ClsTTin In m_ttdvk._DSTTin
                        If (m_ttin._TTruong = "VATAmount") Then
                            m_tienthue = Double.Parse(m_ttin._DLieu)

                        End If
                        If (m_ttin._TTruong = "Amount") Then
                            m_tongtienthanhtoan = Double.Parse(m_ttin._DLieu)
                        End If
                    Next

                Next
                tbl_ChiTietHoaDon.Rows.Add(m_hhdv._STT, _
                                            m_hhdv._TChat, _
                                            m_hhdv._THHDVu, _
                                            m_hhdv._DVTinh, _
                                            m_hhdv._SLuong, _
                                            m_hhdv._DGia, _
                                            m_hhdv._STCKhau, _
                                            m_hhdv._TSuat, _
                                            m_hhdv._ThTien, _
                                            m_tienthue, _
                                            m_tongtienthanhtoan)

            Next
            Dim _vattu As New UNET.ClsVattu
            '_vattu.TenVattu = 
            '_vattu.sohieu = list_dshhdichvu.init()
            '_vattu.KiemTraTonTaiSoHieuVatTu("")
            '_vattu.GhiVattu(
        Catch ex As Exception
            myUMessager.mError(ex.Message, "Ghi hóa đơn thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnMoThuMuc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoThuMuc.Click
        Try
            Dim strFileSize As String = ""

            Dim folder As New FolderBrowserDialog()
            If (folder.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                Dim di As New IO.DirectoryInfo(folder.SelectedPath)
                Dim aryFi As IO.FileInfo() = di.GetFiles("*.xml")
                Dim fi As IO.FileInfo

                Dim tbl_DuLieuHoaDon As New DataTable("HoaDon")

                tbl_DuLieuHoaDon.Columns.Add("Col_Chon", GetType(Boolean)).Caption = "X"
                tbl_DuLieuHoaDon.Columns.Add("Col_STT", GetType(String)).Caption = "STT"
                tbl_DuLieuHoaDon.Columns.Add("col_Ghi", GetType(String)).Caption = "Ghi"
                tbl_DuLieuHoaDon.Columns.Add("col_Xem", GetType(String)).Caption = "Xem"
                tbl_DuLieuHoaDon.Columns.Add("col_KyHieuMauSo", GetType(String)).Caption = "Ký hiệu mẫu số"
                tbl_DuLieuHoaDon.Columns.Add("col_KyHieuHoaDon", GetType(String)).Caption = "Ký hiệu hóa đơn"
                tbl_DuLieuHoaDon.Columns.Add("col_SoHoaDon", GetType(String)).Caption = "Số hóa đơn"
                tbl_DuLieuHoaDon.Columns.Add("col_NgayLapHoaDon", GetType(DateTime)).Caption = "Ngày lập"
                tbl_DuLieuHoaDon.Columns.Add("col_ThongTinHoaDon", GetType(String)).Caption = "Thông tin hóa đơn"
                tbl_DuLieuHoaDon.Columns.Add("col_TonTienChuaThue", GetType(Double)).Caption = "Tổng tiền chưa thuế"
                tbl_DuLieuHoaDon.Columns.Add("col_TongTienThue", GetType(Double)).Caption = "Tổng tiền thuế"
                tbl_DuLieuHoaDon.Columns.Add("col_TongTienChietKhauThuongMai", GetType(Double)).Caption = "Tổng tiền chiết khấu thương mại"
                tbl_DuLieuHoaDon.Columns.Add("col_TongTienPhi", GetType(Double)).Caption = "Tổng tiền phí"
                tbl_DuLieuHoaDon.Columns.Add("col_TongTienThanhToan", GetType(Double)).Caption = "Tổng tiền thanh toán"
                tbl_DuLieuHoaDon.Columns.Add("col_DonViTienTe", GetType(String)).Caption = "Đơn vị tiền tệ"

                For Each fi In aryFi
                    'strFileSize = (Math.Round(fi.Length / 1024)).ToString()
                    'Console.WriteLine("File Name: {0}", fi.Name)
                    'Console.WriteLine("File Full Name: {0}", fi.FullName)
                    'Console.WriteLine("File Size (KB): {0}", strFileSize)
                    'Console.WriteLine("File Extension: {0}", fi.Extension)
                    'Console.WriteLine("Last Accessed: {0}", fi.LastAccessTime)
                    'Console.WriteLine("Read Only: {0}", (fi.Attributes.ReadOnly = True).ToString)

                    DocDuLieu(fi.FullName, tbl_DuLieuHoaDon)
                   
                Next
                dgv_danhsachhoadon.DataSource = tbl_DuLieuHoaDon

                '// Set the view to show details.
                'listView1.View = View.Details;
                '// Allow the user to edit item text.
                'listView1.LabelEdit = true;
                '// Allow the user to rearrange columns.
                'listView1.AllowColumnReorder = true;
                '// Display check boxes.
                'listView1.CheckBoxes = true;
                '// Select the item and subitems when selection is made.
                'listView1.FullRowSelect = true;
                '// Display grid lines.
                'listView1.GridLines = true;
                '// Sort the items in the list in ascending order.
                'listView1.Sorting = SortOrder.Ascending;

                With ListView1
                    .View = View.Details
                    .GridLines = True
                    .Columns.Clear()
                    .Items.Clear()
                    .LabelEdit = True
                    .AllowColumnReorder = True
                    .CheckBoxes = True
                End With

                For Each col As DataColumn In tbl_DuLieuHoaDon.Columns
                    '// Width of -2 indicates auto-size.
                    ListView1.Columns.Add(col.ToString(), col.ToString(), -2).Text = col.Caption


                Next

                For Each row As DataRow In tbl_DuLieuHoaDon.Rows
                    Dim lst As ListViewItem = ListView1.Items.Add(If(row(0) IsNot Nothing, row(0).ToString, String.Empty))

                    For i As Integer = 1 To ListView1.Columns.Count - 1
                        If (ListView1.Columns(i).Name = "col_TonTienChuaThue") Then

                            lst.SubItems.Add(If(row(i) IsNot Nothing, Format(row(i), "#,##0.00"), String.Empty))
                            ListView1.Columns(i).TextAlign = HorizontalAlignment.Right
                        ElseIf (ListView1.Columns(i).Name = "col_TongTienThue") Then

                            lst.SubItems.Add(If(row(i) IsNot Nothing, Format(row(i), "#,##0.00"), String.Empty))
                            ListView1.Columns(i).TextAlign = HorizontalAlignment.Right
                        ElseIf (ListView1.Columns(i).Name = "col_TongTienChietKhauThuongMai") Then

                            lst.SubItems.Add(If(row(i) IsNot Nothing, Format(row(i), "#,##0.00"), String.Empty))
                            ListView1.Columns(i).TextAlign = HorizontalAlignment.Right
                        ElseIf (ListView1.Columns(i).Name = "col_TongTienPhi") Then

                            lst.SubItems.Add(If(row(i) IsNot Nothing, Format(row(i), "#,##0.00"), String.Empty))
                            ListView1.Columns(i).TextAlign = HorizontalAlignment.Right
                        ElseIf (ListView1.Columns(i).Name = "col_TongTienThanhToan") Then

                            lst.SubItems.Add(If(row(i) IsNot Nothing, Format(row(i), "#,##0.00"), String.Empty))
                            ListView1.Columns(i).TextAlign = HorizontalAlignment.Right
                        ElseIf (ListView1.Columns(i).Name = "col_NgayLapHoaDon") Then

                            lst.SubItems.Add(If(row(i) IsNot Nothing, Format(row(i), "dd/MM/yyyy"), String.Empty))
                            ListView1.Columns(i).TextAlign = HorizontalAlignment.Right
                        Else
                            lst.SubItems.Add(If(row(i) IsNot Nothing, row(i).ToString, String.Empty))
                            ListView1.Columns(i).TextAlign = HorizontalAlignment.Left
                        End If

                    Next
                Next

                tbl_DuLieuHoaDon.Dispose()
            End If


        Catch ex As Exception

        End Try
    End Sub

End Class