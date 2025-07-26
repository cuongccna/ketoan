'Imports Library
Imports System.Data.SqlClient
Imports System.IO
Imports UNET.DataAdapter
Public Class IC0005
    Public ID As String
    Public Name, typebillID, pattenID, path, Kyhieu As String
    Public loaiHD As Integer
    Public Mucdich As String() = {"", "", "", "", "", "", "", "", ""}
    Public Mau As Object() = {"", "", "", "", "", "", "", "", ""}
    Public Hinh_nen As Object() = {"", "", "", "", "", "", "", "", ""}
    Public size As Object() = {"", "", "", "", "", "", "", "", ""}
    Public Font As Object() = {"", "", "", "", "", "", "", "", ""}

    Public numcontact, dong, Lien As Integer
    '-------------------
    Private cDP As New DataAdapter
    Private sql As String
    Private r_pa(12) As SqlParameter
    Private dr As SqlDataReader
    Public logo_nen
    Public logo

    ' Private e1 As New UExcelApp
    Private dt As New DataTable
    Public Sub INSERT()
        ExecSQLNonQuery(String.Format("INSERT INTO MAUHOADON(ID, Name, typebillID,path,numcontact,dong,Kyhieu,LoaiHD) VALUES('{0}',N'{1}', '{2}','{3}',{4},{5},'{6}',{7})", _
                                       ID, _
                                       Name, _
                                       typebillID, _
                                       path, _
                                       numcontact, _
                                       dong, _
                                      Kyhieu, _
                                      loaiHD))

        'luu chi tiet
        Try
            For i = 0 To numcontact - 1
                ReDim r_pa(7)
                sql = "INSERT INTO  CT_MAUHOADON (ID, Mucdich,Mau,Lien,hinh_nen,hinh_logo,size,font) values (@id,@Mucdich,@Mau,@Lien,@hinh_nen,@hinh_logo,@size,@font)"
                r_pa(0) = New SqlParameter("ID", ID)
                '----------------------------
                r_pa(1) = New SqlParameter("Mucdich", Mucdich(i))
                r_pa(2) = New SqlParameter("Mau", Mau(i))
                r_pa(3) = New SqlParameter("Lien", i + 1)
                If logo Is Nothing Then
                    r_pa(4) = New SqlParameter("hinh_logo", SqlTypes.SqlBytes.Null)
                Else
                    r_pa(4) = New SqlParameter("hinh_logo", logo)
                End If
                If Hinh_nen(i) Is Nothing Then
                    r_pa(5) = New SqlParameter("hinh_nen", SqlTypes.SqlBytes.Null)
                Else
                    r_pa(5) = New SqlParameter("hinh_nen", Hinh_nen(i))
                End If
                r_pa(6) = New SqlParameter("size", size(i))
                r_pa(7) = New SqlParameter("font", Font(i))
                cDP.EX_PA(sql, r_pa)
            Next
        Catch ex As Exception
            MessageBox.Show("Lỗi do lưu chi tiết liên hóa đơn " + ex.Message)
        End Try
    End Sub
    Public Sub UPDATE()
        Dim sql As String = (String.Format("UPDATE  MAUHOADON SET Name=N'{0}',  typebillID='{1}',path = '{2}',numcontact={3},dong = {4},Kyhieu='{5}',LoaiHD = {6} WHERE ID='{7}'", _
                                      Name, _
                                      typebillID, _
                                      path, _
                                      numcontact, _
                                      dong, _
                                      Kyhieu, _
                                     loaiHD, _
                                     ID))
        ExecSQLNonQuery(sql)
    End Sub
    Public Sub Insert_ct_hd(ByVal stt As Integer)
        Try
            sql = Nothing

            ReDim r_pa(7)
            sql = "INSERT INTO  CT_MAUHOADON (ID, Mucdich,Mau,Lien,hinh_nen,hinh_logo,size,font) values (@id,@Mucdich,@Mau,@Lien,@hinh_nen,@hinh_logo,@size,@font)"
            r_pa(0) = New SqlParameter("ID", ID)
            '----------------------------
            r_pa(1) = New SqlParameter("Mucdich", Mucdich(stt))
            r_pa(2) = New SqlParameter("Mau", Mau(stt))
            r_pa(3) = New SqlParameter("Lien", stt + 1)
            If logo Is Nothing Then
                r_pa(4) = New SqlParameter("hinh_logo", SqlTypes.SqlBytes.Null)
            Else
                r_pa(4) = New SqlParameter("hinh_logo", logo)
            End If
            If Hinh_nen(stt) Is Nothing Then
                r_pa(5) = New SqlParameter("hinh_nen", SqlTypes.SqlBytes.Null)
            Else
                r_pa(5) = New SqlParameter("hinh_nen", Hinh_nen(stt))
            End If
            r_pa(6) = New SqlParameter("size", size(stt))
            r_pa(7) = New SqlParameter("font", Font(stt))
            cDP.EX_PA(sql, r_pa)
        Catch ex As Exception
            MessageBox.Show("Lỗi do Insert_ct_hd(1) " + ex.Message)
        End Try
        
    End Sub
    Public Sub Update_ct_hd(ByVal stt As Integer)

        Try
            sql = String.Empty
            ReDim r_pa(7)
            sql = "Update  CT_MAUHOADON set Mucdich = @Mucdich,Mau = @Mau,hinh_nen = @hinh_nen,hinh_logo = @hinh_logo,size = @size,font = @font where ID = @ID and Lien =@Lien"
            r_pa(0) = New SqlParameter("ID", ID)
            '----------------------------
            r_pa(1) = New SqlParameter("Mucdich", Mucdich(stt))
            r_pa(2) = New SqlParameter("Mau", Mau(stt))
            r_pa(3) = New SqlParameter("Lien", stt + 1)
            If logo Is Nothing Then
                r_pa(4) = New SqlParameter("hinh_logo", SqlTypes.SqlBytes.Null)
            Else
                r_pa(4) = New SqlParameter("hinh_logo", logo)
            End If
            If Hinh_nen(stt) Is Nothing Then
                r_pa(5) = New SqlParameter("hinh_nen", SqlTypes.SqlBytes.Null)
            Else
                r_pa(5) = New SqlParameter("hinh_nen", Hinh_nen(stt))
            End If
            r_pa(6) = New SqlParameter("size", size(stt))
            r_pa(7) = New SqlParameter("font", Font(stt))
            cDP.EX_PA(sql, r_pa)
        Catch ex As Exception
            MessageBox.Show("Lỗi do Update_ct_hd(1) " + ex.Message)
        End Try
       
    End Sub
    Public Sub delete_ct_hd(ByVal sl As Integer)
        ExecSQLNonQuery("Delete from CT_MAUHOADON where ID = '" & ID & "' and Lien = " & sl + 1)
    End Sub
    Public Sub UPDATE_hinh()
        ReDim r_pa(4)
        sql = "UPDATE  CT_MAUHOADON SET  hinh_nen=@hinh_nen,size = @size, font = @font WHERE ID=@ID and Lien = @Lien"
        r_pa(0) = New SqlParameter("ID", ID)
        '----------------------------
        If hinh_nen Is Nothing Then
            r_pa(1) = New SqlParameter("hinh_nen", SqlTypes.SqlBytes.Null)
        Else
            r_pa(1) = New SqlParameter("hinh_nen", hinh_nen)
        End If
        r_pa(2) = New SqlParameter("Lien", Lien)
        r_pa(3) = New SqlParameter("size", size)
        r_pa(4) = New SqlParameter("font", font)
        cDP.EX_PA(sql, r_pa)
    End Sub
    Public Sub UPDATE_hinh_LOGO()
        ReDim r_pa(1)
        sql = "UPDATE  CT_MAUHOADON SET  hinh_logo=@hinh_logo WHERE ID=@ID"
        r_pa(0) = New SqlParameter("ID", ID)
        '----------------------------
        If logo Is Nothing Then
            r_pa(1) = New SqlParameter("hinh_logo", SqlTypes.SqlBytes.Null)
        Else
            r_pa(1) = New SqlParameter("hinh_logo", logo)
        End If
        cDP.EX_PA(sql, r_pa)
    End Sub
End Class
