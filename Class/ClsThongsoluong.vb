Imports System
Imports System.Data
Imports UNET.Utility
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Friend Class ClsThongsoluong
    Public maso As Integer
    Public Sohieunhanvien As String = String.Empty
    Public thang As Integer
    Public Ngaycong As Double
    Public LCB As Double
    Public Heso As Double
    Public Bac As Integer
    Public PCCV As Double
    Public PCTN As Double
    Public PCLD As Double
    Public Com As Double
    Public PCK As Double
    Public thuong As Double
    Public BHXH As Double
    Public BHYT As Double
    Public BHTN As Double
    Public Tamung As Double
    Public Trukhac As Double
    Public congkhac As Double
    Public Tangca As Double
    Public Nghi As Double
    Public Phep As Double
    Public LDThuong As String = String.Empty
    Public LDCong As String = String.Empty
    Public LDTru As String = String.Empty
    Public Thue As Double
    Public Heso1 As Double
    Public Bac1 As Integer
    Public PCCV1 As Double
    Public PCTN1 As Double
    Public PCLD1 As Double
    Public com1 As Double
    Public PCK1 As Double
    Public BHXH1 As Double
    Public BHYT1 As Double
    Public BHTN1 As Double
    Public Demcu As Integer
    Public Demmoi As Integer
    Public TCgio As Double
    Public Luong13 As Integer
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        MyBase.New()
        init()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub init()
        Sohieunhanvien = ""
        thang = 0
        Ngaycong = 0
        LCB = 0
        Heso = 0
        Bac = 0
        PCCV = 0
        PCTN = 0
        PCLD = 0
        Com = 0
        PCK = 0
        thuong = 0
        BHXH = 0
        BHYT = 0
        BHTN = 0
        Tamung = 0
        Trukhac = 0
        congkhac = 0
        Tangca = 0
        Nghi = 0
        Phep = 0
        LDThuong = ""
        LDCong = ""
        LDTru = ""
        Thue = 0
        Heso1 = 0
        Bac1 = 0
        PCCV1 = 0
        PCTN1 = 0
        PCLD1 = 0
        com1 = 0
        PCK1 = 0
        BHXH1 = 0
        BHYT1 = 0
        BHTN1 = 0
        Demcu = 0
        Demmoi = 0
        TCgio = 0
        Luong13 = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GhiNV() As Integer
        Dim sql As String = String.Format("INSERT INTO Thongsoluong (Luong13,BHTN,Thue,BHYT,BHXH,MaSo, SohieuNhanvien,Thang,Ngaycong,LuongCB,Heso,Bac,PCCV,PCTN,PCLD,Com,PCK,Thuong,Tamung,Trukhac,Congkhac,LDThuong,LDCong,LDTru,Tangca,Nghi,Phep,Heso1,Bac1,PCCV1,PCTN1,PCLD1,Com1,PCK1,BHXH1,BHYT1,BHTN1,Demcu,Demmoi,Tangcagio)  VALUES ({0},{1},{2},{3},{4},{5}, N'{6}',{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20}, N'{21}', N'{22}', N'{23}',{24},{25},{26},{27},{28},{29},{30},{31},{32},{33},{34},{35},{36},{37},{38},{39})", _
                                                Luong13, _
                                                doidau(BHTN), _
                                                doidau(Thue), _
                                                doidau(BHYT), _
                                                doidau(BHXH), _
                                                (Lng_MaxValue("MaSo", "Thongsoluong") + 1), _
                                                Sohieunhanvien, _
                                                (thang), _
                                                doidau(Ngaycong), _
                                                doidau(LCB), _
                                                doidau(Heso), _
                                                doidau(Bac), _
                                                doidau(PCCV), _
                                                doidau(PCTN), _
                                                doidau(PCLD), _
                                                doidau(Com), _
                                                doidau(PCK), _
                                                doidau(thuong), _
                                                doidau(Tamung), _
                                                doidau(Trukhac), _
                                                doidau(congkhac), _
                                                LDThuong, _
                                                LDCong, _
                                                LDTru, _
                                                doidau(Tangca), _
                                                doidau(Nghi), _
                                                doidau(Phep), _
                                                doidau(Heso1), _
                                                doidau(Bac1), _
                                                doidau(PCCV1), _
                                                doidau(PCTN1), _
                                                doidau(PCLD1), _
                                                doidau(com1), _
                                                doidau(PCK1), _
                                                doidau(BHXH1), _
                                                doidau(BHYT1), _
                                                doidau(BHTN1), _
                                                doidau(Demcu), _
                                                doidau(Demmoi), _
                                                doidau(TCgio))
        Dim kq As Integer = ExecSQLNonQuery(sql)
        If kq = 0 Then maso = Lng_MaxValue("MaSo", "Thongsoluong")
        Return kq
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SuaNV() As Integer
        Return ExecSQLNonQuery(String.Format("UPDATE Thongsoluong SET Luong13={0},BHTN={1},Thue={2},BHXH={3},BHYT={4},Phep={5},Nghi={6},Tangca={7},SohieuNhanvien=N'{8}',LDThuong=N'{9}',LDCong=N'{10}',LDTru=N'{11}',Thang={12},Ngaycong={13},LuongCB={14},Heso={15},Bac={16},PCCV={17},PCTN={18},PCLD={19},Com={20},PCK={21},Thuong={22},Tamung={23},Trukhac={24},Congkhac={25},Heso1={26},Bac1={27},PCCV1={28},PCTN1={29},PCLD1={30},Com1={31},PCK1={32},BHXH1={33},BHYT1={34},BHTN1={35},Demcu={36},Demmoi={37},Tangcagio={38} WHERE sohieunhanvien=N'{8}' AND thang={12}", _
                                   Luong13, _
                                   (BHTN), _
                                   (Thue), _
                                   (BHXH), _
                                   (BHYT), _
                                   (Phep), _
                                   (Nghi), _
                                   (Tangca), _
                                   Sohieunhanvien, _
                                   LDThuong, _
                                   LDCong, _
                                   LDTru, _
                                   (thang), _
                                   (Ngaycong), _
                                   (LCB), _
                                   (Heso), _
                                   (Bac), _
                                   (PCCV), _
                                   (PCTN), _
                                   (PCLD), _
                                   (Com), _
                                   (PCK), _
                                   (thuong), _
                                   (Tamung), _
                                   (Trukhac), _
                                   (congkhac), _
                                   (Heso1), _
                                   (Bac1), _
                                   (PCCV1), _
                                   (PCTN1), _
                                   (PCLD1), _
                                   (com1), _
                                   (PCK1), _
                                   (BHXH1), _
                                   (BHYT1), _
                                   (BHTN1), _
                                   (Demcu), _
                                   (Demmoi), _
                                   (TCgio)))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function XoaNV() As Integer
        If ExecSQLNonQuery(String.Format("DELETE  FROM Thongsoluong WHERE MaSo={0}", maso)) = 0 Then
            Return 0
        Else
            Return -1
        End If
    End Function
    Public Sub InitNVMaSo(ByRef ms As Integer)
        Dim rs As DataTable
        init()
        If ms > 0 Then
            rs = ExecSQLReturnDT(String.Format("SELECT t1.*,t2.chucvu,t2.trachnhiem,t2.luudong,t2.khac1,(t2.khac2+t2.khac3+t2.khac4+t2.khac5) AS khac,t2.loai FROM Thongsoluong t1 LEFT join phucap t2 on t1.sohieunhanvien=t2.sohieunhanvien WHERE t1.MaSo={0}", ms))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                Try
                    If rsItem("maso") IsNot Nothing Then
                        maso = rsItem("maso")
                    End If


                    If rsItem("Sohieunhanvien") IsNot Nothing Then
                        Sohieunhanvien = rsItem("Sohieunhanvien")
                    End If

                    If rsItem("thang") IsNot Nothing Then
                        thang = rsItem("thang")
                    End If

                    If rsItem("Ngaycong") IsNot Nothing Then
                        Ngaycong = rsItem("Ngaycong")
                    End If

                    If rsItem("luongcb") IsNot Nothing Then
                        LCB = rsItem("luongcb")
                    End If

                    If rsItem("Heso") IsNot Nothing Then
                        Heso = rsItem("Heso")
                    End If

                    If rsItem("Bac") IsNot Nothing Then
                        Bac = rsItem("Bac")
                    End If

                    If rsItem("chucvu") IsNot Nothing Then
                        PCCV = IIf(rsItem("PCCV") <> 0, rsItem("chucvu"), 0)
                    End If

                    If rsItem("Trachnhiem") IsNot Nothing Then
                        PCTN = IIf(rsItem("PCTN") <> 0, rsItem("Trachnhiem"), 0)
                    End If

                    If rsItem("Luudong") IsNot Nothing Then
                        PCLD = IIf(rsItem("PCLD") <> 0, rsItem("Luudong"), 0)
                    End If

                    If rsItem("Khac1") IsNot Nothing Then
                        Com = IIf(rsItem("Com") <> 0, rsItem("Khac1") * (IIf(rsItem("loai") = 1, LCB, 1)), 0)
                    End If

                    If rsItem("khac") IsNot Nothing Then
                        PCK = IIf(rsItem("PCK") <> 0, rsItem("khac") * (IIf(rsItem("loai") = 1, LCB, 1)), 0)
                    End If

                    If rsItem("thuong") IsNot Nothing Then
                        thuong = rsItem("thuong")
                    End If

                    If rsItem("BHXH") IsNot Nothing Then
                        BHXH = rsItem("BHXH")
                    End If

                    If rsItem("BHYT") IsNot Nothing Then
                        BHYT = rsItem("BHYT")
                    End If

                    If rsItem("BHTN") IsNot Nothing Then
                        BHTN = rsItem("BHTN")
                    End If

                    If rsItem("Tamung") IsNot Nothing Then
                        Tamung = rsItem("Tamung")
                    End If

                    If rsItem("Trukhac") IsNot Nothing Then
                        Trukhac = rsItem("Trukhac")
                    End If

                    If rsItem("congkhac") IsNot Nothing Then
                        congkhac = rsItem("congkhac")
                    End If

                    If rsItem("LDThuong") IsNot Nothing Then
                        LDThuong = rsItem("LDThuong")
                    End If

                    If rsItem("LDCong") IsNot Nothing Then
                        LDCong = rsItem("LDCong")
                    End If

                    If rsItem("LDTru") IsNot Nothing Then
                        LDTru = rsItem("LDTru")
                    End If

                    If rsItem("Tangca") IsNot Nothing Then
                        Tangca = rsItem("Tangca")
                    End If

                    If rsItem("Nghi") IsNot Nothing Then
                        Nghi = rsItem("Nghi")
                    End If

                    If rsItem("Phep") IsNot Nothing Then
                        Phep = rsItem("Phep")
                    End If

                    If rsItem("Thue") IsNot Nothing Then
                        Thue = rsItem("Thue")
                    End If

                    If rsItem("Heso1") IsNot Nothing Then
                        Heso1 = rsItem("Heso1")
                    End If

                    If rsItem("Bac1") IsNot Nothing Then
                        Bac1 = rsItem("Bac1")
                    End If

                    If rsItem("PCCV1") IsNot Nothing Then
                        PCCV1 = rsItem("PCCV1")
                    End If

                    If rsItem("PCTN1") IsNot Nothing Then
                        PCTN1 = rsItem("PCTN1")
                    End If

                    If rsItem("PCLD1") IsNot Nothing Then
                        PCLD1 = rsItem("PCLD1")
                    End If

                    If rsItem("com1") IsNot Nothing Then
                        com1 = rsItem("com1")
                    End If

                    If rsItem("PCK1") IsNot Nothing Then
                        PCK1 = rsItem("PCK1")
                    End If

                    If rsItem("BHXH1") IsNot Nothing Then
                        BHXH1 = rsItem("BHXH1")
                    End If

                    If rsItem("BHYT1") IsNot Nothing Then
                        BHYT1 = rsItem("BHYT1")
                    End If

                    If rsItem("BHTN1") IsNot Nothing Then
                        BHTN1 = rsItem("BHTN1")
                    End If

                    If rsItem("Demcu") IsNot Nothing Then
                        Demcu = rsItem("Demcu")
                    End If

                    If rsItem("Demmoi") IsNot Nothing Then
                        Demmoi = rsItem("Demmoi")
                    End If

                    If rsItem("tangcagio") IsNot Nothing Then
                        TCgio = rsItem("tangcagio")
                    End If

                    If rsItem("Luong13") IsNot Nothing Then
                        Luong13 = rsItem("Luong13")
                    End If
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ms"></param>
    ''' <remarks></remarks>
    Public Sub InitNVMaSo1(ByRef ms As Integer)
        Dim rs As DataTable
        init()
        If ms > 0 Then
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM quanlynhanvien WHERE MaSo={0}", ms))
            If rs.Rows.Count > 0 Then
                On Error Resume Next
                If rs.Rows.Count > 0 Then
                    Dim rsItem As DataRow = rs.Rows(0)

                    If rsItem("maso") IsNot Nothing Then
                        maso = rsItem("maso")
                    End If

                    If rsItem("Sohieunhanvien") IsNot Nothing Then
                        Sohieunhanvien = rsItem("Sohieunhanvien")
                    End If
                End If

            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="thang"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InitNVSoHieuNhanvien(ByRef sh As String, Optional ByRef thang As Integer = 0) As Integer
        Dim ms As Integer = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM Thongsoluong WHERE SoHieuNhanvien=N'{0}'{1}", _
                                                                sh, _
                                                                (IIf(thang <> 0, String.Format(" AND thang={0}", thang), String.Empty)))))
        If ms > 0 Then InitNVMaSo(ms) Else init()
        Return ms
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="thang"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InitNVSoHieuNhanvien1(ByRef sh As String, Optional ByRef thang As Integer = 0) As Integer
        Dim ms As Integer = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM quanlynhanvien WHERE SoHieu=N'{0}'{1}", _
                                                                sh, _
                                                                (IIf(thang <> 0, String.Format(" AND thang={0}", thang), String.Empty)))))
        If ms > 0 Then InitNVMaSo1(ms) Else init()
        Return ms
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="thang"></param>
    ''' <remarks></remarks>
    Public Sub InitNVSoHieuNhanvien2(ByRef sh As String, Optional ByRef thang As Integer = 0)
        Dim co As Integer
        Dim str As String = String.Format("SELECT maso FROM phucap WHERE sohieunhanvien=N'{0}'{1}", _
                                sh, _
                                (IIf(thang <> 0, String.Format(" AND thang={0}", thang), String.Empty)))
        Dim rs2 As DataTable = ExecSQLReturnDT(str)
        If rs2.Rows.Count > 0 Then
            str = String.Format("SELECT t1.bacluong,t1.sohieu,t3.cong,t2.HSB1,t2.HSB2,t2.HSB3,t2.HSB4,t2.HSB5,t2.MLB1,t2.MLB2,t2.MLB3,t2.MLB4,t2.MLB5,t2.TVB1,t2.TVB2,t2.TVB3,t2.TVB4,t2.TVB5,t2.LNB1,t2.LNB2,t2.LNB3,t2.LNB4,t2.LNB5,t1.maso,t4.chucvu,t4.trachnhiem,t4.luudong,t4.khac1,t4.khac2+t4.khac3+t4.khac4+t4.khac5 AS pck,t3.tangca,t3.nghi,t3.phep,t4.loai FROM ((quanlynhanvien t1 inner join chucvu t2 on t1.machucvu=t2.maso) inner join chamcong t3 on t1.sohieu=t3.manhanvien)inner join phucap t4 on t1.sohieu=t4.sohieunhanvien WHERE t1.SoHieu=N'{0}'{1}", _
                      sh, _
                      (IIf(thang <> 0, String.Format(" AND t3.thang={0} AND t4.thang={1}", thang, ConvertToStrSafe(thang)), String.Empty)))
            co = 1
        Else
            str = String.Format("SELECT t1.bacluong,t1.sohieu,t3.cong,t2.HSB1,t2.HSB2,t2.HSB3,t2.HSB4,t2.HSB5,t2.MLB1,t2.MLB2,t2.MLB3,t2.MLB4,t2.MLB5,t2.TVB1,t2.TVB2,t2.TVB3,t2.TVB4,t2.TVB5,t2.LNB1,t2.LNB2,t2.LNB3,t2.LNB4,t2.LNB5,t1.maso,t3.tangca,t3.nghi,t3.phep FROM (quanlynhanvien t1 inner join chucvu t2 on t1.machucvu=t2.maso) inner join chamcong t3 on t1.sohieu=t3.manhanvien WHERE t1.SoHieu=N'{0}'{1}", _
                      sh, _
                      (IIf(thang <> 0, String.Format(" AND t3.thang={0}", thang), String.Empty)))
            co = 2
        End If
        Dim rs As DataTable = ExecSQLReturnDT(str)
        If rs.Rows.Count = 0 Then
            MessageBox.Show(String.Format("Thông tin lương của nhân viên này chưa có !{0}Vui lòng kiểm tra lại phần chấm công !", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim rsItem As DataRow = rs.Rows(0)
            If rsItem("maso") IsNot Nothing Then
                maso = rsItem("maso")
            End If
            If rsItem("sohieu") IsNot Nothing Then
                Sohieunhanvien = rsItem("sohieu")
            End If
            If rsItem("Cong") IsNot Nothing Then
                Ngaycong = rsItem("Cong")
            End If

            LCB = ConvertToDblSafe((GetSelectValue("SELECT lcb AS f1 FROM license")))
            Heso = IIf(rsItem(2 + rsItem("BacLuong")) <> 0, rsItem(2 + rsItem("BacLuong")), rsItem(7 + rsItem("BacLuong")))
            If rsItem("BacLuong") IsNot Nothing Then
                Bac = rsItem("BacLuong")
            End If
            If rsItem("Tangca") IsNot Nothing Then
                Tangca = rsItem("Tangca")
            End If
            If rsItem("Nghi") IsNot Nothing Then
                Nghi = rsItem("Nghi")
            End If
            If rsItem("Phep") IsNot Nothing Then
                Phep = rsItem("Phep")
            End If

            '        Thue = rs!Thue
            If co = 1 Then
                If rsItem("loai") = 1 Then
                    If rsItem("chucvu") IsNot Nothing Then
                        PCCV = rsItem("chucvu") * LCB
                    End If
                    If rsItem("Trachnhiem") IsNot Nothing Then
                        PCTN = rsItem("Trachnhiem") * LCB
                    End If
                    If rsItem("Luudong") IsNot Nothing Then
                        PCLD = rsItem("Luudong") * LCB
                    End If
                    If rsItem("Khac1") IsNot Nothing Then
                        Com = rsItem("Khac1") * LCB
                    End If
                    If rsItem("PCK") IsNot Nothing Then
                        PCK = rsItem("PCK") * LCB
                    End If

                Else
                    If rsItem("chucvu") IsNot Nothing Then
                        PCCV = rsItem("chucvu")
                    End If
                    If rsItem("Trachnhiem") IsNot Nothing Then
                        PCTN = rsItem("Trachnhiem")
                    End If
                    If rsItem("Luudong") IsNot Nothing Then
                        PCLD = rsItem("Luudong")
                    End If
                    If rsItem("Khac1") IsNot Nothing Then
                        Com = rsItem("Khac1")
                    End If
                    If rsItem("PCK") IsNot Nothing Then
                        PCK = rsItem("PCK")
                    End If
                End If
            End If
        End If
    End Sub
End Class
