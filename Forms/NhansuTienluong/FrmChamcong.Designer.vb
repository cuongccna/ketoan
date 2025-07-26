<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChamcong
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeLabel()
		InitializeCommand()
	End Sub
    Private Sub ReleaseResources(ByVal eventSender As Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        Dispose(True)
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
     Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTipMain As System.Windows.Forms.ToolTip
    Public WithEvents TxtChunhat As System.Windows.Forms.TextBox
    Public WithEvents TxtNgayle As System.Windows.Forms.TextBox
    Private WithEvents _Label_81 As System.Windows.Forms.Label
    Private WithEvents _Label_82 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Private WithEvents _Label_83 As System.Windows.Forms.Label
    Private WithEvents _Label_84 As System.Windows.Forms.Label
    Private WithEvents _Label_88 As System.Windows.Forms.Label
    Private WithEvents _Label_89 As System.Windows.Forms.Label
    Private WithEvents _Label_90 As System.Windows.Forms.Label
    Private WithEvents _Label_91 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents Luong13 As System.Windows.Forms.TextBox
    Private WithEvents _Label_80 As System.Windows.Forms.Label
    Public WithEvents FLuong13 As System.Windows.Forms.Panel
    Private WithEvents _Command_8 As System.Windows.Forms.Button
    Private WithEvents _Command_9 As System.Windows.Forms.Button
    Private WithEvents _Command_6 As System.Windows.Forms.Button
    Private WithEvents _Command_5 As System.Windows.Forms.Button
    Private WithEvents _Command_7 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents TxtDNTN As System.Windows.Forms.TextBox
    Public WithEvents TxtNVTN As System.Windows.Forms.TextBox
    Public WithEvents TxtNVYT As System.Windows.Forms.TextBox
    Public WithEvents TxtNVXH As System.Windows.Forms.TextBox
    Public WithEvents TxtDNYT As System.Windows.Forms.TextBox
    Public WithEvents TxtDNXH As System.Windows.Forms.TextBox
    Private WithEvents _Label_85 As System.Windows.Forms.Label
    Private WithEvents _Label_86 As System.Windows.Forms.Label
    Private WithEvents _Label_87 As System.Windows.Forms.Label
    Private WithEvents _Label_79 As System.Windows.Forms.Label
    Private WithEvents _Label_78 As System.Windows.Forms.Label
    Private WithEvents _Label_77 As System.Windows.Forms.Label
    Private WithEvents _Label_76 As System.Windows.Forms.Label
    Private WithEvents _Label_75 As System.Windows.Forms.Label
    Private WithEvents _Label_74 As System.Windows.Forms.Label
    Private WithEvents _Label_73 As System.Windows.Forms.Label
    Private WithEvents _Label_72 As System.Windows.Forms.Label
    Private WithEvents _Label_40 As System.Windows.Forms.Label
    Private WithEvents _Label_39 As System.Windows.Forms.Label
    Private WithEvents _Label_38 As System.Windows.Forms.Label
    Public WithEvents FrameBaohiem As System.Windows.Forms.GroupBox
    Public WithEvents ChkBaohiem As System.Windows.Forms.CheckBox
    Public WithEvents GrdNhanvien As ListviewEx.ListviewExt
    Public WithEvents CboThang As ComboBoxEx.ComboBoxExt
    Public WithEvents Lich As System.Windows.Forms.MonthCalendar
    Public WithEvents Chk As System.Windows.Forms.CheckBox
    Private WithEvents _Label_37 As System.Windows.Forms.Label
    Private WithEvents _Label_36 As System.Windows.Forms.Label
    Private WithEvents _Label_41 As System.Windows.Forms.Label
    Private WithEvents _Label_42 As System.Windows.Forms.Label
    Private WithEvents _Label_43 As System.Windows.Forms.Label
    Private WithEvents _Label_44 As System.Windows.Forms.Label
    Private WithEvents _Label_45 As System.Windows.Forms.Label
    Private WithEvents _Label_46 As System.Windows.Forms.Label
    Private WithEvents _Label_47 As System.Windows.Forms.Label
    Private WithEvents _Label_48 As System.Windows.Forms.Label
    Private WithEvents _Label_49 As System.Windows.Forms.Label
    Private WithEvents _Label_50 As System.Windows.Forms.Label
    Private WithEvents _Label_51 As System.Windows.Forms.Label
    Private WithEvents _Label_52 As System.Windows.Forms.Label
    Private WithEvents _Label_53 As System.Windows.Forms.Label
    Private WithEvents _Label_54 As System.Windows.Forms.Label
    Private WithEvents _Label_55 As System.Windows.Forms.Label
    Private WithEvents _Label_56 As System.Windows.Forms.Label
    Private WithEvents _Label_57 As System.Windows.Forms.Label
    Private WithEvents _Label_58 As System.Windows.Forms.Label
    Private WithEvents _Label_59 As System.Windows.Forms.Label
    Private WithEvents _Label_60 As System.Windows.Forms.Label
    Private WithEvents _Label_61 As System.Windows.Forms.Label
    Private WithEvents _Label_62 As System.Windows.Forms.Label
    Private WithEvents _Label_63 As System.Windows.Forms.Label
    Private WithEvents _Label_64 As System.Windows.Forms.Label
    Private WithEvents _Label_65 As System.Windows.Forms.Label
    Private WithEvents _Label_66 As System.Windows.Forms.Label
    Private WithEvents _Label_67 As System.Windows.Forms.Label
    Private WithEvents _Label_68 As System.Windows.Forms.Label
    Private WithEvents _Label_69 As System.Windows.Forms.Label
    Private WithEvents _Label_70 As System.Windows.Forms.Label
    Private WithEvents _Label_71 As System.Windows.Forms.Label
    Private WithEvents _Label_35 As System.Windows.Forms.Label
    Private WithEvents _Label_31 As System.Windows.Forms.Label
    Private WithEvents _Label_30 As System.Windows.Forms.Label
    Private WithEvents _Label_29 As System.Windows.Forms.Label
    Private WithEvents _Label_28 As System.Windows.Forms.Label
    Private WithEvents _Label_27 As System.Windows.Forms.Label
    Private WithEvents _Label_26 As System.Windows.Forms.Label
    Private WithEvents _Label_25 As System.Windows.Forms.Label
    Private WithEvents _Label_24 As System.Windows.Forms.Label
    Private WithEvents _Label_23 As System.Windows.Forms.Label
    Private WithEvents _Label_22 As System.Windows.Forms.Label
    Private WithEvents _Label_21 As System.Windows.Forms.Label
    Private WithEvents _Label_20 As System.Windows.Forms.Label
    Private WithEvents _Label_19 As System.Windows.Forms.Label
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Private WithEvents _Label_16 As System.Windows.Forms.Label
    Private WithEvents _Label_15 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_34 As System.Windows.Forms.Label
    Private WithEvents _Label_32 As System.Windows.Forms.Label
    Private WithEvents _Label_33 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Public Command(9) As System.Windows.Forms.Button
    Public Command1(9) As System.Windows.Forms.Button
    Public Label(91) As System.Windows.Forms.Label
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Label_31 = New System.Windows.Forms.Label
        Me._Label_30 = New System.Windows.Forms.Label
        Me._Label_29 = New System.Windows.Forms.Label
        Me._Label_28 = New System.Windows.Forms.Label
        Me._Label_27 = New System.Windows.Forms.Label
        Me._Label_26 = New System.Windows.Forms.Label
        Me._Label_25 = New System.Windows.Forms.Label
        Me._Label_24 = New System.Windows.Forms.Label
        Me._Label_23 = New System.Windows.Forms.Label
        Me._Label_22 = New System.Windows.Forms.Label
        Me._Label_21 = New System.Windows.Forms.Label
        Me._Label_20 = New System.Windows.Forms.Label
        Me._Label_19 = New System.Windows.Forms.Label
        Me._Label_18 = New System.Windows.Forms.Label
        Me._Label_17 = New System.Windows.Forms.Label
        Me._Label_16 = New System.Windows.Forms.Label
        Me._Label_15 = New System.Windows.Forms.Label
        Me._Label_14 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me._Label_12 = New System.Windows.Forms.Label
        Me._Label_11 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me._Label_9 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.TxtChunhat = New System.Windows.Forms.TextBox
        Me.TxtNgayle = New System.Windows.Forms.TextBox
        Me._Label_81 = New System.Windows.Forms.Label
        Me._Label_82 = New System.Windows.Forms.Label
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me._Label_83 = New System.Windows.Forms.Label
        Me._Label_84 = New System.Windows.Forms.Label
        Me._Label_88 = New System.Windows.Forms.Label
        Me._Label_89 = New System.Windows.Forms.Label
        Me._Label_90 = New System.Windows.Forms.Label
        Me._Label_91 = New System.Windows.Forms.Label
        Me.FLuong13 = New System.Windows.Forms.Panel
        Me.Luong13 = New System.Windows.Forms.TextBox
        Me._Label_80 = New System.Windows.Forms.Label
        Me._Command_8 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me.FrameBaohiem = New System.Windows.Forms.GroupBox
        Me.TxtDNTN = New System.Windows.Forms.TextBox
        Me.TxtNVTN = New System.Windows.Forms.TextBox
        Me.TxtNVYT = New System.Windows.Forms.TextBox
        Me.TxtNVXH = New System.Windows.Forms.TextBox
        Me.TxtDNYT = New System.Windows.Forms.TextBox
        Me.TxtDNXH = New System.Windows.Forms.TextBox
        Me._Label_85 = New System.Windows.Forms.Label
        Me._Label_86 = New System.Windows.Forms.Label
        Me._Label_87 = New System.Windows.Forms.Label
        Me._Label_79 = New System.Windows.Forms.Label
        Me._Label_78 = New System.Windows.Forms.Label
        Me._Label_77 = New System.Windows.Forms.Label
        Me._Label_76 = New System.Windows.Forms.Label
        Me._Label_75 = New System.Windows.Forms.Label
        Me._Label_74 = New System.Windows.Forms.Label
        Me._Label_73 = New System.Windows.Forms.Label
        Me._Label_72 = New System.Windows.Forms.Label
        Me._Label_40 = New System.Windows.Forms.Label
        Me._Label_39 = New System.Windows.Forms.Label
        Me._Label_38 = New System.Windows.Forms.Label
        Me.ChkBaohiem = New System.Windows.Forms.CheckBox
        Me.CboThang = New ComboBoxEx.ComboBoxExt
        Me.Lich = New System.Windows.Forms.MonthCalendar
        Me.Chk = New System.Windows.Forms.CheckBox
        Me._Label_37 = New System.Windows.Forms.Label
        Me._Label_36 = New System.Windows.Forms.Label
        Me._Label_41 = New System.Windows.Forms.Label
        Me._Label_42 = New System.Windows.Forms.Label
        Me._Label_43 = New System.Windows.Forms.Label
        Me._Label_44 = New System.Windows.Forms.Label
        Me._Label_45 = New System.Windows.Forms.Label
        Me._Label_46 = New System.Windows.Forms.Label
        Me._Label_47 = New System.Windows.Forms.Label
        Me._Label_48 = New System.Windows.Forms.Label
        Me._Label_49 = New System.Windows.Forms.Label
        Me._Label_50 = New System.Windows.Forms.Label
        Me._Label_51 = New System.Windows.Forms.Label
        Me._Label_52 = New System.Windows.Forms.Label
        Me._Label_53 = New System.Windows.Forms.Label
        Me._Label_54 = New System.Windows.Forms.Label
        Me._Label_55 = New System.Windows.Forms.Label
        Me._Label_56 = New System.Windows.Forms.Label
        Me._Label_57 = New System.Windows.Forms.Label
        Me._Label_58 = New System.Windows.Forms.Label
        Me._Label_59 = New System.Windows.Forms.Label
        Me._Label_60 = New System.Windows.Forms.Label
        Me._Label_61 = New System.Windows.Forms.Label
        Me._Label_62 = New System.Windows.Forms.Label
        Me._Label_63 = New System.Windows.Forms.Label
        Me._Label_64 = New System.Windows.Forms.Label
        Me._Label_65 = New System.Windows.Forms.Label
        Me._Label_66 = New System.Windows.Forms.Label
        Me._Label_67 = New System.Windows.Forms.Label
        Me._Label_68 = New System.Windows.Forms.Label
        Me._Label_69 = New System.Windows.Forms.Label
        Me._Label_70 = New System.Windows.Forms.Label
        Me._Label_71 = New System.Windows.Forms.Label
        Me._Label_35 = New System.Windows.Forms.Label
        Me._Label_34 = New System.Windows.Forms.Label
        Me._Label_32 = New System.Windows.Forms.Label
        Me._Label_33 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Command_9 = New System.Windows.Forms.Button
        Me._Command_6 = New System.Windows.Forms.Button
        Me._Command_5 = New System.Windows.Forms.Button
        Me._Command_7 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me.GrdNhanvien = New ListViewEx.ListviewExt
        Me.TxtTNCN = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtGiaCanh = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.FLuong13.SuspendLayout()
        Me.FrameBaohiem.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Label_31
        '
        Me._Label_31.BackColor = System.Drawing.Color.Silver
        Me._Label_31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_31.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_31.ForeColor = System.Drawing.Color.Black
        Me._Label_31.Location = New System.Drawing.Point(928, 120)
        Me._Label_31.Name = "_Label_31"
        Me._Label_31.Size = New System.Drawing.Size(17, 17)
        Me._Label_31.TabIndex = 56
        Me._Label_31.Tag = ""
        Me._Label_31.Text = "31"
        Me._Label_31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_31, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_30
        '
        Me._Label_30.BackColor = System.Drawing.Color.Silver
        Me._Label_30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_30.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_30.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_30.ForeColor = System.Drawing.Color.Black
        Me._Label_30.Location = New System.Drawing.Point(912, 120)
        Me._Label_30.Name = "_Label_30"
        Me._Label_30.Size = New System.Drawing.Size(17, 17)
        Me._Label_30.TabIndex = 55
        Me._Label_30.Tag = ""
        Me._Label_30.Text = "30"
        Me._Label_30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_30, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_29
        '
        Me._Label_29.BackColor = System.Drawing.Color.Silver
        Me._Label_29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_29.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_29.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_29.ForeColor = System.Drawing.Color.Black
        Me._Label_29.Location = New System.Drawing.Point(896, 120)
        Me._Label_29.Name = "_Label_29"
        Me._Label_29.Size = New System.Drawing.Size(17, 17)
        Me._Label_29.TabIndex = 54
        Me._Label_29.Tag = ""
        Me._Label_29.Text = "29"
        Me._Label_29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_29, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_28
        '
        Me._Label_28.BackColor = System.Drawing.Color.Silver
        Me._Label_28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_28.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_28.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_28.ForeColor = System.Drawing.Color.Black
        Me._Label_28.Location = New System.Drawing.Point(880, 120)
        Me._Label_28.Name = "_Label_28"
        Me._Label_28.Size = New System.Drawing.Size(17, 17)
        Me._Label_28.TabIndex = 53
        Me._Label_28.Tag = ""
        Me._Label_28.Text = "28"
        Me._Label_28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_28, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_27
        '
        Me._Label_27.BackColor = System.Drawing.Color.Silver
        Me._Label_27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_27.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_27.ForeColor = System.Drawing.Color.Black
        Me._Label_27.Location = New System.Drawing.Point(864, 120)
        Me._Label_27.Name = "_Label_27"
        Me._Label_27.Size = New System.Drawing.Size(17, 17)
        Me._Label_27.TabIndex = 52
        Me._Label_27.Tag = ""
        Me._Label_27.Text = "27"
        Me._Label_27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_27, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_26
        '
        Me._Label_26.BackColor = System.Drawing.Color.Silver
        Me._Label_26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_26.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_26.ForeColor = System.Drawing.Color.Black
        Me._Label_26.Location = New System.Drawing.Point(848, 120)
        Me._Label_26.Name = "_Label_26"
        Me._Label_26.Size = New System.Drawing.Size(17, 17)
        Me._Label_26.TabIndex = 51
        Me._Label_26.Tag = ""
        Me._Label_26.Text = "26"
        Me._Label_26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_26, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_25
        '
        Me._Label_25.BackColor = System.Drawing.Color.Silver
        Me._Label_25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_25.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_25.ForeColor = System.Drawing.Color.Black
        Me._Label_25.Location = New System.Drawing.Point(832, 120)
        Me._Label_25.Name = "_Label_25"
        Me._Label_25.Size = New System.Drawing.Size(17, 17)
        Me._Label_25.TabIndex = 50
        Me._Label_25.Tag = ""
        Me._Label_25.Text = "25"
        Me._Label_25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_25, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_24
        '
        Me._Label_24.BackColor = System.Drawing.Color.Silver
        Me._Label_24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_24.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_24.ForeColor = System.Drawing.Color.Black
        Me._Label_24.Location = New System.Drawing.Point(816, 120)
        Me._Label_24.Name = "_Label_24"
        Me._Label_24.Size = New System.Drawing.Size(17, 17)
        Me._Label_24.TabIndex = 49
        Me._Label_24.Tag = ""
        Me._Label_24.Text = "24"
        Me._Label_24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_24, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_23
        '
        Me._Label_23.BackColor = System.Drawing.Color.Silver
        Me._Label_23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_23.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_23.ForeColor = System.Drawing.Color.Black
        Me._Label_23.Location = New System.Drawing.Point(800, 120)
        Me._Label_23.Name = "_Label_23"
        Me._Label_23.Size = New System.Drawing.Size(17, 17)
        Me._Label_23.TabIndex = 48
        Me._Label_23.Tag = ""
        Me._Label_23.Text = "23"
        Me._Label_23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_23, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_22
        '
        Me._Label_22.BackColor = System.Drawing.Color.Silver
        Me._Label_22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_22.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_22.ForeColor = System.Drawing.Color.Black
        Me._Label_22.Location = New System.Drawing.Point(784, 120)
        Me._Label_22.Name = "_Label_22"
        Me._Label_22.Size = New System.Drawing.Size(17, 17)
        Me._Label_22.TabIndex = 47
        Me._Label_22.Tag = ""
        Me._Label_22.Text = "22"
        Me._Label_22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_22, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_21
        '
        Me._Label_21.BackColor = System.Drawing.Color.Silver
        Me._Label_21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_21.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_21.ForeColor = System.Drawing.Color.Black
        Me._Label_21.Location = New System.Drawing.Point(768, 120)
        Me._Label_21.Name = "_Label_21"
        Me._Label_21.Size = New System.Drawing.Size(17, 17)
        Me._Label_21.TabIndex = 46
        Me._Label_21.Tag = ""
        Me._Label_21.Text = "21"
        Me._Label_21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_21, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_20
        '
        Me._Label_20.BackColor = System.Drawing.Color.Silver
        Me._Label_20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_20.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_20.ForeColor = System.Drawing.Color.Black
        Me._Label_20.Location = New System.Drawing.Point(752, 120)
        Me._Label_20.Name = "_Label_20"
        Me._Label_20.Size = New System.Drawing.Size(17, 17)
        Me._Label_20.TabIndex = 45
        Me._Label_20.Tag = ""
        Me._Label_20.Text = "20"
        Me._Label_20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_20, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_19
        '
        Me._Label_19.BackColor = System.Drawing.Color.Silver
        Me._Label_19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_19.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_19.ForeColor = System.Drawing.Color.Black
        Me._Label_19.Location = New System.Drawing.Point(736, 120)
        Me._Label_19.Name = "_Label_19"
        Me._Label_19.Size = New System.Drawing.Size(17, 17)
        Me._Label_19.TabIndex = 44
        Me._Label_19.Tag = ""
        Me._Label_19.Text = "19"
        Me._Label_19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_19, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.Silver
        Me._Label_18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.Color.Black
        Me._Label_18.Location = New System.Drawing.Point(720, 120)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.Size = New System.Drawing.Size(17, 17)
        Me._Label_18.TabIndex = 43
        Me._Label_18.Tag = ""
        Me._Label_18.Text = "18"
        Me._Label_18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_18, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.Silver
        Me._Label_17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.Color.Black
        Me._Label_17.Location = New System.Drawing.Point(704, 120)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(17, 17)
        Me._Label_17.TabIndex = 42
        Me._Label_17.Tag = ""
        Me._Label_17.Text = "17"
        Me._Label_17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_17, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.Silver
        Me._Label_16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.Color.Black
        Me._Label_16.Location = New System.Drawing.Point(688, 120)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.Size = New System.Drawing.Size(17, 17)
        Me._Label_16.TabIndex = 41
        Me._Label_16.Tag = ""
        Me._Label_16.Text = "16"
        Me._Label_16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_16, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_15
        '
        Me._Label_15.BackColor = System.Drawing.Color.Silver
        Me._Label_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.Color.Black
        Me._Label_15.Location = New System.Drawing.Point(672, 120)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.Size = New System.Drawing.Size(17, 17)
        Me._Label_15.TabIndex = 40
        Me._Label_15.Tag = ""
        Me._Label_15.Text = "15"
        Me._Label_15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_15, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.Silver
        Me._Label_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.Color.Black
        Me._Label_14.Location = New System.Drawing.Point(656, 120)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(17, 17)
        Me._Label_14.TabIndex = 39
        Me._Label_14.Tag = ""
        Me._Label_14.Text = "14"
        Me._Label_14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_14, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.Silver
        Me._Label_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.Color.Black
        Me._Label_13.Location = New System.Drawing.Point(640, 120)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(17, 17)
        Me._Label_13.TabIndex = 38
        Me._Label_13.Tag = ""
        Me._Label_13.Text = "13"
        Me._Label_13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_13, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.Silver
        Me._Label_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.Color.Black
        Me._Label_12.Location = New System.Drawing.Point(624, 120)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(17, 17)
        Me._Label_12.TabIndex = 37
        Me._Label_12.Tag = ""
        Me._Label_12.Text = "12"
        Me._Label_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_12, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.Silver
        Me._Label_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.Color.Black
        Me._Label_11.Location = New System.Drawing.Point(608, 120)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(17, 17)
        Me._Label_11.TabIndex = 36
        Me._Label_11.Tag = ""
        Me._Label_11.Text = "11"
        Me._Label_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_11, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.Silver
        Me._Label_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.Color.Black
        Me._Label_10.Location = New System.Drawing.Point(592, 120)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(17, 17)
        Me._Label_10.TabIndex = 35
        Me._Label_10.Tag = ""
        Me._Label_10.Text = "10"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_10, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.Silver
        Me._Label_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.Color.Black
        Me._Label_9.Location = New System.Drawing.Point(576, 120)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(17, 17)
        Me._Label_9.TabIndex = 34
        Me._Label_9.Tag = ""
        Me._Label_9.Text = "9"
        Me._Label_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_9, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.Silver
        Me._Label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.Black
        Me._Label_8.Location = New System.Drawing.Point(560, 120)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(17, 17)
        Me._Label_8.TabIndex = 33
        Me._Label_8.Tag = ""
        Me._Label_8.Text = "8"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_8, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.Silver
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(544, 120)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(17, 17)
        Me._Label_7.TabIndex = 32
        Me._Label_7.Tag = ""
        Me._Label_7.Text = "7"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_7, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.Silver
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.Black
        Me._Label_6.Location = New System.Drawing.Point(528, 120)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(17, 17)
        Me._Label_6.TabIndex = 31
        Me._Label_6.Tag = ""
        Me._Label_6.Text = "6"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_6, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.Silver
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.Color.Black
        Me._Label_5.Location = New System.Drawing.Point(512, 120)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(17, 17)
        Me._Label_5.TabIndex = 30
        Me._Label_5.Tag = ""
        Me._Label_5.Text = "5"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_5, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.Silver
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(496, 120)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(17, 17)
        Me._Label_4.TabIndex = 29
        Me._Label_4.Tag = ""
        Me._Label_4.Text = "4"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_4, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.Silver
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(480, 120)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(17, 17)
        Me._Label_3.TabIndex = 28
        Me._Label_3.Tag = ""
        Me._Label_3.Text = "3"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_3, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Silver
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(464, 120)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(17, 17)
        Me._Label_2.TabIndex = 27
        Me._Label_2.Tag = ""
        Me._Label_2.Text = "2"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_2, "ấn vào đây để chấm công ngày lễ")
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Silver
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(448, 120)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(17, 17)
        Me._Label_1.TabIndex = 26
        Me._Label_1.Tag = ""
        Me._Label_1.Text = "1"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipMain.SetToolTip(Me._Label_1, "ấn vào đây để chấm công ngày lễ")
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Transparent
        Me.Frame1.Controls.Add(Me.TxtChunhat)
        Me.Frame1.Controls.Add(Me.TxtNgayle)
        Me.Frame1.Controls.Add(Me._Label_81)
        Me.Frame1.Controls.Add(Me._Label_82)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(512, 32)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(209, 65)
        Me.Frame1.TabIndex = 125
        Me.Frame1.TabStop = False
        Me.Frame1.Tag = "Overtime rate"
        Me.Frame1.Text = "Tỷ lệ tăng ca"
        '
        'TxtChunhat
        '
        Me.TxtChunhat.AcceptsReturn = True
        Me.TxtChunhat.BackColor = System.Drawing.SystemColors.Window
        Me.TxtChunhat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtChunhat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtChunhat.Location = New System.Drawing.Point(88, 16)
        Me.TxtChunhat.MaxLength = 0
        Me.TxtChunhat.Name = "TxtChunhat"
        Me.TxtChunhat.Size = New System.Drawing.Size(25, 20)
        Me.TxtChunhat.TabIndex = 3
        Me.TxtChunhat.Text = "2"
        Me.TxtChunhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNgayle
        '
        Me.TxtNgayle.AcceptsReturn = True
        Me.TxtNgayle.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNgayle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNgayle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgayle.Location = New System.Drawing.Point(88, 40)
        Me.TxtNgayle.MaxLength = 0
        Me.TxtNgayle.Name = "TxtNgayle"
        Me.TxtNgayle.Size = New System.Drawing.Size(25, 20)
        Me.TxtNgayle.TabIndex = 4
        Me.TxtNgayle.Text = "3"
        Me.TxtNgayle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Label_81
        '
        Me._Label_81.BackColor = System.Drawing.Color.Transparent
        Me._Label_81.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_81.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_81.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_81.Location = New System.Drawing.Point(16, 16)
        Me._Label_81.Name = "_Label_81"
        Me._Label_81.Size = New System.Drawing.Size(187, 17)
        Me._Label_81.TabIndex = 127
        Me._Label_81.Tag = "Sun day     =              x  day"
        Me._Label_81.Text = "Chủ nhật    =              x  ngày thường"
        '
        '_Label_82
        '
        Me._Label_82.BackColor = System.Drawing.Color.Transparent
        Me._Label_82.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_82.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_82.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_82.Location = New System.Drawing.Point(16, 40)
        Me._Label_82.Name = "_Label_82"
        Me._Label_82.Size = New System.Drawing.Size(187, 17)
        Me._Label_82.TabIndex = 126
        Me._Label_82.Tag = "Holiday     =              x  day"
        Me._Label_82.Text = "Ngày lễ      =              x  ngày thường"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.Transparent
        Me.Frame2.Controls.Add(Me._Label_83)
        Me.Frame2.Controls.Add(Me._Label_84)
        Me.Frame2.Controls.Add(Me._Label_88)
        Me.Frame2.Controls.Add(Me._Label_89)
        Me.Frame2.Controls.Add(Me._Label_90)
        Me.Frame2.Controls.Add(Me._Label_91)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(230, 32)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(284, 65)
        Me.Frame2.TabIndex = 118
        Me.Frame2.TabStop = False
        Me.Frame2.Tag = "Convention attendance"
        Me.Frame2.Text = "Quy ước chấm công"
        '
        '_Label_83
        '
        Me._Label_83.BackColor = System.Drawing.Color.Transparent
        Me._Label_83.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_83.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_83.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_83.Location = New System.Drawing.Point(16, 32)
        Me._Label_83.Name = "_Label_83"
        Me._Label_83.Size = New System.Drawing.Size(73, 17)
        Me._Label_83.TabIndex = 124
        Me._Label_83.Tag = "V : Absence"
        Me._Label_83.Text = "V : Vắng mặt"
        '
        '_Label_84
        '
        Me._Label_84.BackColor = System.Drawing.Color.Transparent
        Me._Label_84.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_84.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_84.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_84.Location = New System.Drawing.Point(16, 16)
        Me._Label_84.Name = "_Label_84"
        Me._Label_84.Size = New System.Drawing.Size(73, 17)
        Me._Label_84.TabIndex = 123
        Me._Label_84.Tag = "C : Present"
        Me._Label_84.Text = "C : Có mặt"
        '
        '_Label_88
        '
        Me._Label_88.BackColor = System.Drawing.Color.Transparent
        Me._Label_88.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_88.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_88.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_88.Location = New System.Drawing.Point(16, 48)
        Me._Label_88.Name = "_Label_88"
        Me._Label_88.Size = New System.Drawing.Size(73, 17)
        Me._Label_88.TabIndex = 122
        Me._Label_88.Tag = "P : Off"
        Me._Label_88.Text = "P : Nghỉ phép"
        '
        '_Label_89
        '
        Me._Label_89.BackColor = System.Drawing.Color.Transparent
        Me._Label_89.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_89.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_89.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_89.Location = New System.Drawing.Point(88, 16)
        Me._Label_89.Name = "_Label_89"
        Me._Label_89.Size = New System.Drawing.Size(185, 17)
        Me._Label_89.TabIndex = 121
        Me._Label_89.Tag = "R : Present half, Off half"
        Me._Label_89.Text = "R : Đi làm nữa ngày, phép nữa ngày"
        '
        '_Label_90
        '
        Me._Label_90.BackColor = System.Drawing.Color.Transparent
        Me._Label_90.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_90.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_90.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_90.Location = New System.Drawing.Point(88, 32)
        Me._Label_90.Name = "_Label_90"
        Me._Label_90.Size = New System.Drawing.Size(185, 17)
        Me._Label_90.TabIndex = 120
        Me._Label_90.Tag = "L : Present half, Absence half"
        Me._Label_90.Text = "L : Đi làm nữa ngày, vắng nữa ngày"
        '
        '_Label_91
        '
        Me._Label_91.BackColor = System.Drawing.Color.Transparent
        Me._Label_91.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_91.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_91.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_91.Location = New System.Drawing.Point(88, 48)
        Me._Label_91.Name = "_Label_91"
        Me._Label_91.Size = New System.Drawing.Size(177, 17)
        Me._Label_91.TabIndex = 119
        Me._Label_91.Tag = "T : Overtime"
        Me._Label_91.Text = "T : Tăng ca"
        '
        'FLuong13
        '
        Me.FLuong13.BackColor = System.Drawing.Color.Transparent
        Me.FLuong13.Controls.Add(Me.Luong13)
        Me.FLuong13.Controls.Add(Me._Label_80)
        Me.FLuong13.Cursor = System.Windows.Forms.Cursors.Default
        Me.FLuong13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FLuong13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FLuong13.Location = New System.Drawing.Point(78, 40)
        Me.FLuong13.Name = "FLuong13"
        Me.FLuong13.Size = New System.Drawing.Size(90, 33)
        Me.FLuong13.TabIndex = 113
        Me.FLuong13.Visible = False
        '
        'Luong13
        '
        Me.Luong13.AcceptsReturn = True
        Me.Luong13.BackColor = System.Drawing.SystemColors.Window
        Me.Luong13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Luong13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Luong13.Location = New System.Drawing.Point(7, 6)
        Me.Luong13.MaxLength = 0
        Me.Luong13.Name = "Luong13"
        Me.Luong13.Size = New System.Drawing.Size(24, 20)
        Me.Luong13.TabIndex = 2
        Me.Luong13.Text = "100"
        Me.Luong13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Label_80
        '
        Me._Label_80.BackColor = System.Drawing.Color.Transparent
        Me._Label_80.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_80.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_80.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_80.Location = New System.Drawing.Point(32, 9)
        Me._Label_80.Name = "_Label_80"
        Me._Label_80.Size = New System.Drawing.Size(56, 17)
        Me._Label_80.TabIndex = 114
        Me._Label_80.Tag = "% salary"
        Me._Label_80.Text = "% lương"
        Me._Label_80.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Command_8
        '
        Me._Command_8.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_8.Location = New System.Drawing.Point(199, 516)
        Me._Command_8.Name = "_Command_8"
        Me._Command_8.Size = New System.Drawing.Size(25, 25)
        Me._Command_8.TabIndex = 112
        Me._Command_8.Text = "..."
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(816, 516)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(65, 25)
        Me._Command_2.TabIndex = 106
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "X&oá"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(888, 516)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 105
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        'FrameBaohiem
        '
        Me.FrameBaohiem.BackColor = System.Drawing.Color.Transparent
        Me.FrameBaohiem.Controls.Add(Me.TxtDNTN)
        Me.FrameBaohiem.Controls.Add(Me.TxtNVTN)
        Me.FrameBaohiem.Controls.Add(Me.TxtNVYT)
        Me.FrameBaohiem.Controls.Add(Me.TxtNVXH)
        Me.FrameBaohiem.Controls.Add(Me.TxtDNYT)
        Me.FrameBaohiem.Controls.Add(Me.TxtDNXH)
        Me.FrameBaohiem.Controls.Add(Me._Label_85)
        Me.FrameBaohiem.Controls.Add(Me._Label_86)
        Me.FrameBaohiem.Controls.Add(Me._Label_87)
        Me.FrameBaohiem.Controls.Add(Me._Label_79)
        Me.FrameBaohiem.Controls.Add(Me._Label_78)
        Me.FrameBaohiem.Controls.Add(Me._Label_77)
        Me.FrameBaohiem.Controls.Add(Me._Label_76)
        Me.FrameBaohiem.Controls.Add(Me._Label_75)
        Me.FrameBaohiem.Controls.Add(Me._Label_74)
        Me.FrameBaohiem.Controls.Add(Me._Label_73)
        Me.FrameBaohiem.Controls.Add(Me._Label_72)
        Me.FrameBaohiem.Controls.Add(Me._Label_40)
        Me.FrameBaohiem.Controls.Add(Me._Label_39)
        Me.FrameBaohiem.Controls.Add(Me._Label_38)
        Me.FrameBaohiem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameBaohiem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameBaohiem.Location = New System.Drawing.Point(728, 0)
        Me.FrameBaohiem.Name = "FrameBaohiem"
        Me.FrameBaohiem.Size = New System.Drawing.Size(233, 97)
        Me.FrameBaohiem.TabIndex = 92
        Me.FrameBaohiem.TabStop = False
        '
        'TxtDNTN
        '
        Me.TxtDNTN.AcceptsReturn = True
        Me.TxtDNTN.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDNTN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDNTN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDNTN.Location = New System.Drawing.Point(80, 72)
        Me.TxtDNTN.MaxLength = 0
        Me.TxtDNTN.Name = "TxtDNTN"
        Me.TxtDNTN.Size = New System.Drawing.Size(33, 20)
        Me.TxtDNTN.TabIndex = 10
        Me.TxtDNTN.Text = "1"
        Me.TxtDNTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNVTN
        '
        Me.TxtNVTN.AcceptsReturn = True
        Me.TxtNVTN.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNVTN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNVTN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNVTN.Location = New System.Drawing.Point(176, 72)
        Me.TxtNVTN.MaxLength = 0
        Me.TxtNVTN.Name = "TxtNVTN"
        Me.TxtNVTN.Size = New System.Drawing.Size(33, 20)
        Me.TxtNVTN.TabIndex = 11
        Me.TxtNVTN.Text = "1"
        Me.TxtNVTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNVYT
        '
        Me.TxtNVYT.AcceptsReturn = True
        Me.TxtNVYT.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNVYT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNVYT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNVYT.Location = New System.Drawing.Point(176, 48)
        Me.TxtNVYT.MaxLength = 0
        Me.TxtNVYT.Name = "TxtNVYT"
        Me.TxtNVYT.Size = New System.Drawing.Size(33, 20)
        Me.TxtNVYT.TabIndex = 9
        Me.TxtNVYT.Text = "1.5"
        Me.TxtNVYT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNVXH
        '
        Me.TxtNVXH.AcceptsReturn = True
        Me.TxtNVXH.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNVXH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNVXH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNVXH.Location = New System.Drawing.Point(176, 24)
        Me.TxtNVXH.MaxLength = 0
        Me.TxtNVXH.Name = "TxtNVXH"
        Me.TxtNVXH.Size = New System.Drawing.Size(33, 20)
        Me.TxtNVXH.TabIndex = 7
        Me.TxtNVXH.Text = "6"
        Me.TxtNVXH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDNYT
        '
        Me.TxtDNYT.AcceptsReturn = True
        Me.TxtDNYT.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDNYT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDNYT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDNYT.Location = New System.Drawing.Point(80, 48)
        Me.TxtDNYT.MaxLength = 0
        Me.TxtDNYT.Name = "TxtDNYT"
        Me.TxtDNYT.Size = New System.Drawing.Size(33, 20)
        Me.TxtDNYT.TabIndex = 8
        Me.TxtDNYT.Text = "3"
        Me.TxtDNYT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDNXH
        '
        Me.TxtDNXH.AcceptsReturn = True
        Me.TxtDNXH.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDNXH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDNXH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDNXH.Location = New System.Drawing.Point(80, 24)
        Me.TxtDNXH.MaxLength = 0
        Me.TxtDNXH.Name = "TxtDNXH"
        Me.TxtDNXH.Size = New System.Drawing.Size(33, 20)
        Me.TxtDNXH.TabIndex = 6
        Me.TxtDNXH.Text = "16"
        Me.TxtDNXH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Label_85
        '
        Me._Label_85.BackColor = System.Drawing.Color.Transparent
        Me._Label_85.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_85.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_85.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_85.Location = New System.Drawing.Point(136, 72)
        Me._Label_85.Name = "_Label_85"
        Me._Label_85.Size = New System.Drawing.Size(33, 17)
        Me._Label_85.TabIndex = 117
        Me._Label_85.Tag = "(1%)"
        Me._Label_85.Text = "(1%)"
        Me._Label_85.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_86
        '
        Me._Label_86.BackColor = System.Drawing.Color.Transparent
        Me._Label_86.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_86.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_86.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_86.Location = New System.Drawing.Point(131, 48)
        Me._Label_86.Name = "_Label_86"
        Me._Label_86.Size = New System.Drawing.Size(40, 17)
        Me._Label_86.TabIndex = 116
        Me._Label_86.Tag = "(1.5%)"
        Me._Label_86.Text = "(1.5%)"
        Me._Label_86.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_87
        '
        Me._Label_87.BackColor = System.Drawing.Color.Transparent
        Me._Label_87.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_87.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_87.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_87.Location = New System.Drawing.Point(136, 24)
        Me._Label_87.Name = "_Label_87"
        Me._Label_87.Size = New System.Drawing.Size(33, 17)
        Me._Label_87.TabIndex = 115
        Me._Label_87.Tag = "(7%)"
        Me._Label_87.Text = "(7%)"
        Me._Label_87.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_79
        '
        Me._Label_79.BackColor = System.Drawing.Color.Transparent
        Me._Label_79.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_79.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_79.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_79.Location = New System.Drawing.Point(8, 72)
        Me._Label_79.Name = "_Label_79"
        Me._Label_79.Size = New System.Drawing.Size(73, 17)
        Me._Label_79.TabIndex = 103
        Me._Label_79.Tag = "UI        (1%)"
        Me._Label_79.Text = "BHTN   (1%)"
        '
        '_Label_78
        '
        Me._Label_78.BackColor = System.Drawing.Color.Transparent
        Me._Label_78.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_78.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_78.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_78.Location = New System.Drawing.Point(112, 72)
        Me._Label_78.Name = "_Label_78"
        Me._Label_78.Size = New System.Drawing.Size(17, 17)
        Me._Label_78.TabIndex = 102
        Me._Label_78.Tag = ""
        Me._Label_78.Text = "%"
        Me._Label_78.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_77
        '
        Me._Label_77.BackColor = System.Drawing.Color.Transparent
        Me._Label_77.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_77.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_77.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_77.Location = New System.Drawing.Point(208, 72)
        Me._Label_77.Name = "_Label_77"
        Me._Label_77.Size = New System.Drawing.Size(17, 17)
        Me._Label_77.TabIndex = 101
        Me._Label_77.Tag = ""
        Me._Label_77.Text = "%"
        Me._Label_77.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_76
        '
        Me._Label_76.BackColor = System.Drawing.Color.Transparent
        Me._Label_76.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_76.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_76.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_76.Location = New System.Drawing.Point(208, 48)
        Me._Label_76.Name = "_Label_76"
        Me._Label_76.Size = New System.Drawing.Size(17, 17)
        Me._Label_76.TabIndex = 100
        Me._Label_76.Tag = ""
        Me._Label_76.Text = "%"
        Me._Label_76.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_75
        '
        Me._Label_75.BackColor = System.Drawing.Color.Transparent
        Me._Label_75.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_75.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_75.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_75.Location = New System.Drawing.Point(208, 24)
        Me._Label_75.Name = "_Label_75"
        Me._Label_75.Size = New System.Drawing.Size(17, 17)
        Me._Label_75.TabIndex = 99
        Me._Label_75.Tag = ""
        Me._Label_75.Text = "%"
        Me._Label_75.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_74
        '
        Me._Label_74.BackColor = System.Drawing.Color.Transparent
        Me._Label_74.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_74.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_74.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_74.Location = New System.Drawing.Point(112, 48)
        Me._Label_74.Name = "_Label_74"
        Me._Label_74.Size = New System.Drawing.Size(17, 17)
        Me._Label_74.TabIndex = 98
        Me._Label_74.Tag = ""
        Me._Label_74.Text = "%"
        Me._Label_74.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_73
        '
        Me._Label_73.BackColor = System.Drawing.Color.Transparent
        Me._Label_73.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_73.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_73.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_73.Location = New System.Drawing.Point(112, 24)
        Me._Label_73.Name = "_Label_73"
        Me._Label_73.Size = New System.Drawing.Size(17, 17)
        Me._Label_73.TabIndex = 97
        Me._Label_73.Tag = ""
        Me._Label_73.Text = "%"
        Me._Label_73.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_72
        '
        Me._Label_72.BackColor = System.Drawing.Color.Transparent
        Me._Label_72.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_72.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_72.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_72.Location = New System.Drawing.Point(8, 48)
        Me._Label_72.Name = "_Label_72"
        Me._Label_72.Size = New System.Drawing.Size(74, 17)
        Me._Label_72.TabIndex = 96
        Me._Label_72.Tag = "HI        (3%)"
        Me._Label_72.Text = "BHYT   (3%)"
        '
        '_Label_40
        '
        Me._Label_40.BackColor = System.Drawing.Color.Transparent
        Me._Label_40.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_40.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_40.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_40.Location = New System.Drawing.Point(8, 24)
        Me._Label_40.Name = "_Label_40"
        Me._Label_40.Size = New System.Drawing.Size(74, 17)
        Me._Label_40.TabIndex = 95
        Me._Label_40.Tag = "SI        (17%)"
        Me._Label_40.Text = "BHXH  (17%)"
        '
        '_Label_39
        '
        Me._Label_39.BackColor = System.Drawing.Color.Transparent
        Me._Label_39.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_39.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_39.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_39.Location = New System.Drawing.Point(155, 8)
        Me._Label_39.Name = "_Label_39"
        Me._Label_39.Size = New System.Drawing.Size(74, 17)
        Me._Label_39.TabIndex = 94
        Me._Label_39.Tag = "Employee"
        Me._Label_39.Text = "NV"
        Me._Label_39.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_38
        '
        Me._Label_38.BackColor = System.Drawing.Color.Transparent
        Me._Label_38.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_38.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_38.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_38.Location = New System.Drawing.Point(60, 8)
        Me._Label_38.Name = "_Label_38"
        Me._Label_38.Size = New System.Drawing.Size(73, 17)
        Me._Label_38.TabIndex = 93
        Me._Label_38.Tag = "Enterprises"
        Me._Label_38.Text = "DN"
        Me._Label_38.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ChkBaohiem
        '
        Me.ChkBaohiem.BackColor = System.Drawing.Color.Transparent
        Me.ChkBaohiem.Checked = True
        Me.ChkBaohiem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkBaohiem.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkBaohiem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBaohiem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkBaohiem.Location = New System.Drawing.Point(624, 8)
        Me.ChkBaohiem.Name = "ChkBaohiem"
        Me.ChkBaohiem.Size = New System.Drawing.Size(105, 17)
        Me.ChkBaohiem.TabIndex = 5
        Me.ChkBaohiem.Tag = "Insurance"
        Me.ChkBaohiem.Text = "Trích bảo hiểm"
        Me.ChkBaohiem.UseVisualStyleBackColor = False
        '
        'CboThang
        '
        Me.CboThang.BackColor = System.Drawing.SystemColors.Window
        Me.CboThang.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboThang.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboThang.Location = New System.Drawing.Point(8, 16)
        Me.CboThang.Name = "CboThang"
        Me.CboThang.Size = New System.Drawing.Size(73, 21)
        Me.CboThang.TabIndex = 0
        '
        'Lich
        '
        Me.Lich.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Lich.CalendarDimensions = New System.Drawing.Size(2, 1)
        Me.Lich.FirstDayOfWeek = System.Windows.Forms.Day.Sunday
        Me.Lich.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lich.Location = New System.Drawing.Point(160, 184)
        Me.Lich.Name = "Lich"
        Me.Lich.TabIndex = 58
        Me.Lich.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Lich.Visible = False
        '
        'Chk
        '
        Me.Chk.BackColor = System.Drawing.Color.Transparent
        Me.Chk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Chk.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.Location = New System.Drawing.Point(8, 48)
        Me.Chk.Name = "Chk"
        Me.Chk.Size = New System.Drawing.Size(73, 17)
        Me.Chk.TabIndex = 1
        Me.Chk.Tag = "Month 13"
        Me.Chk.Text = "Tháng 13"
        Me.Chk.UseVisualStyleBackColor = False
        '
        '_Label_37
        '
        Me._Label_37.BackColor = System.Drawing.Color.Transparent
        Me._Label_37.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_37.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_37.ForeColor = System.Drawing.Color.Black
        Me._Label_37.Location = New System.Drawing.Point(8, 520)
        Me._Label_37.Name = "_Label_37"
        Me._Label_37.Size = New System.Drawing.Size(185, 17)
        Me._Label_37.TabIndex = 91
        Me._Label_37.Tag = ""
        Me._Label_37.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_36
        '
        Me._Label_36.BackColor = System.Drawing.Color.Transparent
        Me._Label_36.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_36.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_36.ForeColor = System.Drawing.Color.Black
        Me._Label_36.Location = New System.Drawing.Point(88, 16)
        Me._Label_36.Name = "_Label_36"
        Me._Label_36.Size = New System.Drawing.Size(161, 17)
        Me._Label_36.TabIndex = 90
        Me._Label_36.Tag = ""
        Me._Label_36.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_41
        '
        Me._Label_41.BackColor = System.Drawing.Color.Silver
        Me._Label_41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_41.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_41.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_41.ForeColor = System.Drawing.Color.Black
        Me._Label_41.Location = New System.Drawing.Point(448, 104)
        Me._Label_41.Name = "_Label_41"
        Me._Label_41.Size = New System.Drawing.Size(17, 17)
        Me._Label_41.TabIndex = 89
        Me._Label_41.Tag = "Ho."
        Me._Label_41.Text = "Lễ"
        Me._Label_41.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_41.Visible = False
        '
        '_Label_42
        '
        Me._Label_42.BackColor = System.Drawing.Color.Silver
        Me._Label_42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_42.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_42.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_42.ForeColor = System.Drawing.Color.Black
        Me._Label_42.Location = New System.Drawing.Point(464, 104)
        Me._Label_42.Name = "_Label_42"
        Me._Label_42.Size = New System.Drawing.Size(17, 17)
        Me._Label_42.TabIndex = 88
        Me._Label_42.Tag = "Ho."
        Me._Label_42.Text = "Lễ"
        Me._Label_42.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_42.Visible = False
        '
        '_Label_43
        '
        Me._Label_43.BackColor = System.Drawing.Color.Silver
        Me._Label_43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_43.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_43.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_43.ForeColor = System.Drawing.Color.Black
        Me._Label_43.Location = New System.Drawing.Point(480, 104)
        Me._Label_43.Name = "_Label_43"
        Me._Label_43.Size = New System.Drawing.Size(17, 17)
        Me._Label_43.TabIndex = 87
        Me._Label_43.Tag = "Ho."
        Me._Label_43.Text = "Lễ"
        Me._Label_43.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_43.Visible = False
        '
        '_Label_44
        '
        Me._Label_44.BackColor = System.Drawing.Color.Silver
        Me._Label_44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_44.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_44.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_44.ForeColor = System.Drawing.Color.Black
        Me._Label_44.Location = New System.Drawing.Point(496, 104)
        Me._Label_44.Name = "_Label_44"
        Me._Label_44.Size = New System.Drawing.Size(17, 17)
        Me._Label_44.TabIndex = 86
        Me._Label_44.Tag = "Ho."
        Me._Label_44.Text = "Lễ"
        Me._Label_44.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_44.Visible = False
        '
        '_Label_45
        '
        Me._Label_45.BackColor = System.Drawing.Color.Silver
        Me._Label_45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_45.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_45.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_45.ForeColor = System.Drawing.Color.Black
        Me._Label_45.Location = New System.Drawing.Point(512, 104)
        Me._Label_45.Name = "_Label_45"
        Me._Label_45.Size = New System.Drawing.Size(17, 17)
        Me._Label_45.TabIndex = 85
        Me._Label_45.Tag = "Ho."
        Me._Label_45.Text = "Lễ"
        Me._Label_45.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_45.Visible = False
        '
        '_Label_46
        '
        Me._Label_46.BackColor = System.Drawing.Color.Silver
        Me._Label_46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_46.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_46.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_46.ForeColor = System.Drawing.Color.Black
        Me._Label_46.Location = New System.Drawing.Point(528, 104)
        Me._Label_46.Name = "_Label_46"
        Me._Label_46.Size = New System.Drawing.Size(17, 17)
        Me._Label_46.TabIndex = 84
        Me._Label_46.Tag = "Ho."
        Me._Label_46.Text = "Lễ"
        Me._Label_46.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_46.Visible = False
        '
        '_Label_47
        '
        Me._Label_47.BackColor = System.Drawing.Color.Silver
        Me._Label_47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_47.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_47.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_47.ForeColor = System.Drawing.Color.Black
        Me._Label_47.Location = New System.Drawing.Point(544, 104)
        Me._Label_47.Name = "_Label_47"
        Me._Label_47.Size = New System.Drawing.Size(17, 17)
        Me._Label_47.TabIndex = 83
        Me._Label_47.Tag = "Ho."
        Me._Label_47.Text = "Lễ"
        Me._Label_47.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_47.Visible = False
        '
        '_Label_48
        '
        Me._Label_48.BackColor = System.Drawing.Color.Silver
        Me._Label_48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_48.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_48.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_48.ForeColor = System.Drawing.Color.Black
        Me._Label_48.Location = New System.Drawing.Point(560, 104)
        Me._Label_48.Name = "_Label_48"
        Me._Label_48.Size = New System.Drawing.Size(17, 17)
        Me._Label_48.TabIndex = 82
        Me._Label_48.Tag = "Ho."
        Me._Label_48.Text = "Lễ"
        Me._Label_48.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_48.Visible = False
        '
        '_Label_49
        '
        Me._Label_49.BackColor = System.Drawing.Color.Silver
        Me._Label_49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_49.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_49.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_49.ForeColor = System.Drawing.Color.Black
        Me._Label_49.Location = New System.Drawing.Point(576, 104)
        Me._Label_49.Name = "_Label_49"
        Me._Label_49.Size = New System.Drawing.Size(17, 17)
        Me._Label_49.TabIndex = 81
        Me._Label_49.Tag = "Ho."
        Me._Label_49.Text = "Lễ"
        Me._Label_49.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_49.Visible = False
        '
        '_Label_50
        '
        Me._Label_50.BackColor = System.Drawing.Color.Silver
        Me._Label_50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_50.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_50.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_50.ForeColor = System.Drawing.Color.Black
        Me._Label_50.Location = New System.Drawing.Point(592, 104)
        Me._Label_50.Name = "_Label_50"
        Me._Label_50.Size = New System.Drawing.Size(17, 17)
        Me._Label_50.TabIndex = 80
        Me._Label_50.Tag = "Ho."
        Me._Label_50.Text = "Lễ"
        Me._Label_50.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_50.Visible = False
        '
        '_Label_51
        '
        Me._Label_51.BackColor = System.Drawing.Color.Silver
        Me._Label_51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_51.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_51.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_51.ForeColor = System.Drawing.Color.Black
        Me._Label_51.Location = New System.Drawing.Point(608, 104)
        Me._Label_51.Name = "_Label_51"
        Me._Label_51.Size = New System.Drawing.Size(17, 17)
        Me._Label_51.TabIndex = 79
        Me._Label_51.Tag = "Ho."
        Me._Label_51.Text = "Lễ"
        Me._Label_51.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_51.Visible = False
        '
        '_Label_52
        '
        Me._Label_52.BackColor = System.Drawing.Color.Silver
        Me._Label_52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_52.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_52.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_52.ForeColor = System.Drawing.Color.Black
        Me._Label_52.Location = New System.Drawing.Point(624, 104)
        Me._Label_52.Name = "_Label_52"
        Me._Label_52.Size = New System.Drawing.Size(17, 17)
        Me._Label_52.TabIndex = 78
        Me._Label_52.Tag = "Ho."
        Me._Label_52.Text = "Lễ"
        Me._Label_52.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_52.Visible = False
        '
        '_Label_53
        '
        Me._Label_53.BackColor = System.Drawing.Color.Silver
        Me._Label_53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_53.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_53.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_53.ForeColor = System.Drawing.Color.Black
        Me._Label_53.Location = New System.Drawing.Point(640, 104)
        Me._Label_53.Name = "_Label_53"
        Me._Label_53.Size = New System.Drawing.Size(17, 17)
        Me._Label_53.TabIndex = 77
        Me._Label_53.Tag = "Ho."
        Me._Label_53.Text = "Lễ"
        Me._Label_53.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_53.Visible = False
        '
        '_Label_54
        '
        Me._Label_54.BackColor = System.Drawing.Color.Silver
        Me._Label_54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_54.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_54.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_54.ForeColor = System.Drawing.Color.Black
        Me._Label_54.Location = New System.Drawing.Point(656, 104)
        Me._Label_54.Name = "_Label_54"
        Me._Label_54.Size = New System.Drawing.Size(17, 17)
        Me._Label_54.TabIndex = 76
        Me._Label_54.Tag = "Ho."
        Me._Label_54.Text = "Lễ"
        Me._Label_54.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_54.Visible = False
        '
        '_Label_55
        '
        Me._Label_55.BackColor = System.Drawing.Color.Silver
        Me._Label_55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_55.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_55.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_55.ForeColor = System.Drawing.Color.Black
        Me._Label_55.Location = New System.Drawing.Point(672, 104)
        Me._Label_55.Name = "_Label_55"
        Me._Label_55.Size = New System.Drawing.Size(17, 17)
        Me._Label_55.TabIndex = 75
        Me._Label_55.Tag = "Ho."
        Me._Label_55.Text = "Lễ"
        Me._Label_55.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_55.Visible = False
        '
        '_Label_56
        '
        Me._Label_56.BackColor = System.Drawing.Color.Silver
        Me._Label_56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_56.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_56.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_56.ForeColor = System.Drawing.Color.Black
        Me._Label_56.Location = New System.Drawing.Point(688, 104)
        Me._Label_56.Name = "_Label_56"
        Me._Label_56.Size = New System.Drawing.Size(17, 17)
        Me._Label_56.TabIndex = 74
        Me._Label_56.Tag = "Ho."
        Me._Label_56.Text = "Lễ"
        Me._Label_56.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_56.Visible = False
        '
        '_Label_57
        '
        Me._Label_57.BackColor = System.Drawing.Color.Silver
        Me._Label_57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_57.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_57.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_57.ForeColor = System.Drawing.Color.Black
        Me._Label_57.Location = New System.Drawing.Point(704, 104)
        Me._Label_57.Name = "_Label_57"
        Me._Label_57.Size = New System.Drawing.Size(17, 17)
        Me._Label_57.TabIndex = 73
        Me._Label_57.Tag = "Ho."
        Me._Label_57.Text = "Lễ"
        Me._Label_57.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_57.Visible = False
        '
        '_Label_58
        '
        Me._Label_58.BackColor = System.Drawing.Color.Silver
        Me._Label_58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_58.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_58.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_58.ForeColor = System.Drawing.Color.Black
        Me._Label_58.Location = New System.Drawing.Point(720, 104)
        Me._Label_58.Name = "_Label_58"
        Me._Label_58.Size = New System.Drawing.Size(17, 17)
        Me._Label_58.TabIndex = 72
        Me._Label_58.Tag = "Ho."
        Me._Label_58.Text = "Lễ"
        Me._Label_58.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_58.Visible = False
        '
        '_Label_59
        '
        Me._Label_59.BackColor = System.Drawing.Color.Silver
        Me._Label_59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_59.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_59.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_59.ForeColor = System.Drawing.Color.Black
        Me._Label_59.Location = New System.Drawing.Point(736, 104)
        Me._Label_59.Name = "_Label_59"
        Me._Label_59.Size = New System.Drawing.Size(17, 17)
        Me._Label_59.TabIndex = 71
        Me._Label_59.Tag = "Ho."
        Me._Label_59.Text = "Lễ"
        Me._Label_59.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_59.Visible = False
        '
        '_Label_60
        '
        Me._Label_60.BackColor = System.Drawing.Color.Silver
        Me._Label_60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_60.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_60.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_60.ForeColor = System.Drawing.Color.Black
        Me._Label_60.Location = New System.Drawing.Point(752, 104)
        Me._Label_60.Name = "_Label_60"
        Me._Label_60.Size = New System.Drawing.Size(17, 17)
        Me._Label_60.TabIndex = 70
        Me._Label_60.Tag = "Ho."
        Me._Label_60.Text = "Lễ"
        Me._Label_60.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_60.Visible = False
        '
        '_Label_61
        '
        Me._Label_61.BackColor = System.Drawing.Color.Silver
        Me._Label_61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_61.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_61.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_61.ForeColor = System.Drawing.Color.Black
        Me._Label_61.Location = New System.Drawing.Point(768, 104)
        Me._Label_61.Name = "_Label_61"
        Me._Label_61.Size = New System.Drawing.Size(17, 17)
        Me._Label_61.TabIndex = 69
        Me._Label_61.Tag = "Ho."
        Me._Label_61.Text = "Lễ"
        Me._Label_61.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_61.Visible = False
        '
        '_Label_62
        '
        Me._Label_62.BackColor = System.Drawing.Color.Silver
        Me._Label_62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_62.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_62.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_62.ForeColor = System.Drawing.Color.Black
        Me._Label_62.Location = New System.Drawing.Point(784, 104)
        Me._Label_62.Name = "_Label_62"
        Me._Label_62.Size = New System.Drawing.Size(17, 17)
        Me._Label_62.TabIndex = 68
        Me._Label_62.Tag = "Ho."
        Me._Label_62.Text = "Lễ"
        Me._Label_62.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_62.Visible = False
        '
        '_Label_63
        '
        Me._Label_63.BackColor = System.Drawing.Color.Silver
        Me._Label_63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_63.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_63.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_63.ForeColor = System.Drawing.Color.Black
        Me._Label_63.Location = New System.Drawing.Point(800, 104)
        Me._Label_63.Name = "_Label_63"
        Me._Label_63.Size = New System.Drawing.Size(17, 17)
        Me._Label_63.TabIndex = 67
        Me._Label_63.Tag = "Ho."
        Me._Label_63.Text = "Lễ"
        Me._Label_63.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_63.Visible = False
        '
        '_Label_64
        '
        Me._Label_64.BackColor = System.Drawing.Color.Silver
        Me._Label_64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_64.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_64.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_64.ForeColor = System.Drawing.Color.Black
        Me._Label_64.Location = New System.Drawing.Point(816, 104)
        Me._Label_64.Name = "_Label_64"
        Me._Label_64.Size = New System.Drawing.Size(17, 17)
        Me._Label_64.TabIndex = 66
        Me._Label_64.Tag = "Ho."
        Me._Label_64.Text = "Lễ"
        Me._Label_64.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_64.Visible = False
        '
        '_Label_65
        '
        Me._Label_65.BackColor = System.Drawing.Color.Silver
        Me._Label_65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_65.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_65.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_65.ForeColor = System.Drawing.Color.Black
        Me._Label_65.Location = New System.Drawing.Point(832, 104)
        Me._Label_65.Name = "_Label_65"
        Me._Label_65.Size = New System.Drawing.Size(17, 17)
        Me._Label_65.TabIndex = 65
        Me._Label_65.Tag = "Ho."
        Me._Label_65.Text = "Lễ"
        Me._Label_65.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_65.Visible = False
        '
        '_Label_66
        '
        Me._Label_66.BackColor = System.Drawing.Color.Silver
        Me._Label_66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_66.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_66.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_66.ForeColor = System.Drawing.Color.Black
        Me._Label_66.Location = New System.Drawing.Point(848, 104)
        Me._Label_66.Name = "_Label_66"
        Me._Label_66.Size = New System.Drawing.Size(17, 17)
        Me._Label_66.TabIndex = 64
        Me._Label_66.Tag = "Ho."
        Me._Label_66.Text = "Lễ"
        Me._Label_66.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_66.Visible = False
        '
        '_Label_67
        '
        Me._Label_67.BackColor = System.Drawing.Color.Silver
        Me._Label_67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_67.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_67.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_67.ForeColor = System.Drawing.Color.Black
        Me._Label_67.Location = New System.Drawing.Point(864, 104)
        Me._Label_67.Name = "_Label_67"
        Me._Label_67.Size = New System.Drawing.Size(17, 17)
        Me._Label_67.TabIndex = 63
        Me._Label_67.Tag = "Ho."
        Me._Label_67.Text = "Lễ"
        Me._Label_67.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_67.Visible = False
        '
        '_Label_68
        '
        Me._Label_68.BackColor = System.Drawing.Color.Silver
        Me._Label_68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_68.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_68.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_68.ForeColor = System.Drawing.Color.Black
        Me._Label_68.Location = New System.Drawing.Point(880, 104)
        Me._Label_68.Name = "_Label_68"
        Me._Label_68.Size = New System.Drawing.Size(17, 17)
        Me._Label_68.TabIndex = 62
        Me._Label_68.Tag = "Ho."
        Me._Label_68.Text = "Lễ"
        Me._Label_68.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_68.Visible = False
        '
        '_Label_69
        '
        Me._Label_69.BackColor = System.Drawing.Color.Silver
        Me._Label_69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_69.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_69.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_69.ForeColor = System.Drawing.Color.Black
        Me._Label_69.Location = New System.Drawing.Point(896, 104)
        Me._Label_69.Name = "_Label_69"
        Me._Label_69.Size = New System.Drawing.Size(17, 17)
        Me._Label_69.TabIndex = 61
        Me._Label_69.Tag = "Ho."
        Me._Label_69.Text = "Lễ"
        Me._Label_69.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_69.Visible = False
        '
        '_Label_70
        '
        Me._Label_70.BackColor = System.Drawing.Color.Silver
        Me._Label_70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_70.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_70.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_70.ForeColor = System.Drawing.Color.Black
        Me._Label_70.Location = New System.Drawing.Point(912, 104)
        Me._Label_70.Name = "_Label_70"
        Me._Label_70.Size = New System.Drawing.Size(17, 17)
        Me._Label_70.TabIndex = 60
        Me._Label_70.Tag = "Ho."
        Me._Label_70.Text = "Lễ"
        Me._Label_70.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_70.Visible = False
        '
        '_Label_71
        '
        Me._Label_71.BackColor = System.Drawing.Color.Silver
        Me._Label_71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_71.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_71.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_71.ForeColor = System.Drawing.Color.Black
        Me._Label_71.Location = New System.Drawing.Point(928, 104)
        Me._Label_71.Name = "_Label_71"
        Me._Label_71.Size = New System.Drawing.Size(17, 17)
        Me._Label_71.TabIndex = 59
        Me._Label_71.Tag = "Ho."
        Me._Label_71.Text = "Lễ"
        Me._Label_71.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_71.Visible = False
        '
        '_Label_35
        '
        Me._Label_35.BackColor = System.Drawing.Color.Silver
        Me._Label_35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_35.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_35.ForeColor = System.Drawing.Color.Black
        Me._Label_35.Location = New System.Drawing.Point(192, 120)
        Me._Label_35.Name = "_Label_35"
        Me._Label_35.Size = New System.Drawing.Size(129, 17)
        Me._Label_35.TabIndex = 57
        Me._Label_35.Tag = "Component"
        Me._Label_35.Text = "Bộ phận"
        Me._Label_35.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_34
        '
        Me._Label_34.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_34.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_34.ForeColor = System.Drawing.Color.Black
        Me._Label_34.Location = New System.Drawing.Point(343, 8)
        Me._Label_34.Name = "_Label_34"
        Me._Label_34.Size = New System.Drawing.Size(258, 20)
        Me._Label_34.TabIndex = 25
        Me._Label_34.Tag = "Attendance Employees List"
        Me._Label_34.Text = "Danh sách chấm công nhân viên"
        Me._Label_34.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_32
        '
        Me._Label_32.BackColor = System.Drawing.Color.Silver
        Me._Label_32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_32.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_32.ForeColor = System.Drawing.Color.Black
        Me._Label_32.Location = New System.Drawing.Point(32, 120)
        Me._Label_32.Name = "_Label_32"
        Me._Label_32.Size = New System.Drawing.Size(161, 17)
        Me._Label_32.TabIndex = 24
        Me._Label_32.Tag = "Full name"
        Me._Label_32.Text = "Họ và Tên"
        Me._Label_32.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_33
        '
        Me._Label_33.BackColor = System.Drawing.Color.Silver
        Me._Label_33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_33.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_33.ForeColor = System.Drawing.Color.Black
        Me._Label_33.Location = New System.Drawing.Point(320, 120)
        Me._Label_33.Name = "_Label_33"
        Me._Label_33.Size = New System.Drawing.Size(129, 17)
        Me._Label_33.TabIndex = 23
        Me._Label_33.Tag = "Position"
        Me._Label_33.Text = "Chức vụ"
        Me._Label_33.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Silver
        Me._Label_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.Color.Black
        Me._Label_0.Location = New System.Drawing.Point(8, 120)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(25, 17)
        Me._Label_0.TabIndex = 22
        Me._Label_0.Tag = "No."
        Me._Label_0.Text = "STT"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Command_9
        '
        Me._Command_9.Image = Global.UNET.My.Resources.Resources.tool16
        Me._Command_9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_9.Location = New System.Drawing.Point(432, 516)
        Me._Command_9.Name = "_Command_9"
        Me._Command_9.Size = New System.Drawing.Size(97, 25)
        Me._Command_9.TabIndex = 111
        Me._Command_9.Tag = "Update book"
        Me._Command_9.Text = "Trích &lương"
        '
        '_Command_6
        '
        Me._Command_6.Image = Global.UNET.My.Resources.Resources.report16
        Me._Command_6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_6.Location = New System.Drawing.Point(640, 516)
        Me._Command_6.Name = "_Command_6"
        Me._Command_6.Size = New System.Drawing.Size(65, 25)
        Me._Command_6.TabIndex = 110
        Me._Command_6.Tag = "Preview"
        Me._Command_6.Text = "&Xem"
        '
        '_Command_5
        '
        Me._Command_5.Image = Global.UNET.My.Resources.Resources.lefticon
        Me._Command_5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_5.Location = New System.Drawing.Point(230, 516)
        Me._Command_5.Name = "_Command_5"
        Me._Command_5.Size = New System.Drawing.Size(89, 25)
        Me._Command_5.TabIndex = 109
        Me._Command_5.Tag = "Refresh"
        Me._Command_5.Text = "&Không ghi"
        '
        '_Command_7
        '
        Me._Command_7.Image = Global.UNET.My.Resources.Resources.excel16
        Me._Command_7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_7.Location = New System.Drawing.Point(536, 516)
        Me._Command_7.Name = "_Command_7"
        Me._Command_7.Size = New System.Drawing.Size(97, 25)
        Me._Command_7.TabIndex = 108
        Me._Command_7.Tag = "SalaryList"
        Me._Command_7.Text = "&Bảng lương"
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.user
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(325, 516)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(97, 25)
        Me._Command_3.TabIndex = 107
        Me._Command_3.Tag = "Salary bill"
        Me._Command_3.Text = "&Phiếu lương"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.list16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(712, 516)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(97, 25)
        Me._Command_0.TabIndex = 104
        Me._Command_0.Tag = "Attendance"
        Me._Command_0.Text = "Chấm côn&g"
        '
        'GrdNhanvien
        '
        Me.GrdNhanvien.AllowColumnResize = False
        Me.GrdNhanvien.AllowMultiselect = False
        Me.GrdNhanvien.AlternateBackground = System.Drawing.Color.DarkGreen
        Me.GrdNhanvien.AlternatingColors = False
        Me.GrdNhanvien.AutoHeight = True
        Me.GrdNhanvien.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdNhanvien.BackgroundStretchToFit = True
        Me.GrdNhanvien.Col = 0
        Me.GrdNhanvien.Cols = 0
        Me.GrdNhanvien.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me.GrdNhanvien.FullRowSelect = True
        Me.GrdNhanvien.GridColor = System.Drawing.Color.LightGray
        Me.GrdNhanvien.GridLines = ListViewEx.GLGridLines.gridHorizontal
        Me.GrdNhanvien.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me.GrdNhanvien.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me.GrdNhanvien.HeaderHeight = 0
        Me.GrdNhanvien.HeaderVisible = False
        Me.GrdNhanvien.HeaderWordWrap = False
        Me.GrdNhanvien.HotColumnTracking = False
        Me.GrdNhanvien.HotItemTracking = False
        Me.GrdNhanvien.HotTrackingColor = System.Drawing.Color.LightGray
        Me.GrdNhanvien.HoverEvents = False
        Me.GrdNhanvien.HoverTime = 1
        Me.GrdNhanvien.ImageList = Nothing
        Me.GrdNhanvien.ItemHeight = 18
        Me.GrdNhanvien.ItemWordWrap = False
        Me.GrdNhanvien.Location = New System.Drawing.Point(8, 136)
        Me.GrdNhanvien.Name = "GrdNhanvien"
        Me.GrdNhanvien.Row = 0
        Me.GrdNhanvien.Rows = 0
        Me.GrdNhanvien.Selectable = True
        Me.GrdNhanvien.SelectedTextColor = System.Drawing.Color.White
        Me.GrdNhanvien.SelectionColor = System.Drawing.Color.DarkBlue
        Me.GrdNhanvien.ShowBorder = True
        Me.GrdNhanvien.ShowFocusRect = False
        Me.GrdNhanvien.Size = New System.Drawing.Size(953, 370)
        Me.GrdNhanvien.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdNhanvien.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdNhanvien.TabIndex = 10
        '
        'TxtTNCN
        '
        Me.TxtTNCN.AcceptsReturn = True
        Me.TxtTNCN.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTNCN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTNCN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTNCN.Location = New System.Drawing.Point(85, 77)
        Me.TxtTNCN.MaxLength = 0
        Me.TxtTNCN.Name = "TxtTNCN"
        Me.TxtTNCN.Size = New System.Drawing.Size(73, 20)
        Me.TxtTNCN.TabIndex = 128
        Me.TxtTNCN.Text = "9000000"
        Me.TxtTNCN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(5, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 17)
        Me.Label1.TabIndex = 129
        Me.Label1.Tag = ""
        Me.Label1.Text = "Mức tính thuế                              đ"
        '
        'TxtGiaCanh
        '
        Me.TxtGiaCanh.AcceptsReturn = True
        Me.TxtGiaCanh.BackColor = System.Drawing.SystemColors.Window
        Me.TxtGiaCanh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtGiaCanh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGiaCanh.Location = New System.Drawing.Point(85, 98)
        Me.TxtGiaCanh.MaxLength = 0
        Me.TxtGiaCanh.Name = "TxtGiaCanh"
        Me.TxtGiaCanh.Size = New System.Drawing.Size(73, 20)
        Me.TxtGiaCanh.TabIndex = 130
        Me.TxtGiaCanh.Text = "9000000"
        Me.TxtGiaCanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(5, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 17)
        Me.Label2.TabIndex = 131
        Me.Label2.Tag = ""
        Me.Label2.Text = "Gia cảnh                                     đ"
        '
        'FrmChamcong
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(969, 548)
        Me.Controls.Add(Me.TxtGiaCanh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTNCN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrdNhanvien)
        Me.Controls.Add(Me.Lich)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.FLuong13)
        Me.Controls.Add(Me._Command_8)
        Me.Controls.Add(Me._Command_9)
        Me.Controls.Add(Me._Command_6)
        Me.Controls.Add(Me._Command_5)
        Me.Controls.Add(Me._Command_7)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me.FrameBaohiem)
        Me.Controls.Add(Me.ChkBaohiem)
        Me.Controls.Add(Me.CboThang)
        Me.Controls.Add(Me.Chk)
        Me.Controls.Add(Me._Label_37)
        Me.Controls.Add(Me._Label_36)
        Me.Controls.Add(Me._Label_41)
        Me.Controls.Add(Me._Label_42)
        Me.Controls.Add(Me._Label_43)
        Me.Controls.Add(Me._Label_44)
        Me.Controls.Add(Me._Label_45)
        Me.Controls.Add(Me._Label_46)
        Me.Controls.Add(Me._Label_47)
        Me.Controls.Add(Me._Label_48)
        Me.Controls.Add(Me._Label_49)
        Me.Controls.Add(Me._Label_50)
        Me.Controls.Add(Me._Label_51)
        Me.Controls.Add(Me._Label_52)
        Me.Controls.Add(Me._Label_53)
        Me.Controls.Add(Me._Label_54)
        Me.Controls.Add(Me._Label_55)
        Me.Controls.Add(Me._Label_56)
        Me.Controls.Add(Me._Label_57)
        Me.Controls.Add(Me._Label_58)
        Me.Controls.Add(Me._Label_59)
        Me.Controls.Add(Me._Label_60)
        Me.Controls.Add(Me._Label_61)
        Me.Controls.Add(Me._Label_62)
        Me.Controls.Add(Me._Label_63)
        Me.Controls.Add(Me._Label_64)
        Me.Controls.Add(Me._Label_65)
        Me.Controls.Add(Me._Label_66)
        Me.Controls.Add(Me._Label_67)
        Me.Controls.Add(Me._Label_68)
        Me.Controls.Add(Me._Label_69)
        Me.Controls.Add(Me._Label_70)
        Me.Controls.Add(Me._Label_71)
        Me.Controls.Add(Me._Label_35)
        Me.Controls.Add(Me._Label_31)
        Me.Controls.Add(Me._Label_30)
        Me.Controls.Add(Me._Label_29)
        Me.Controls.Add(Me._Label_28)
        Me.Controls.Add(Me._Label_27)
        Me.Controls.Add(Me._Label_26)
        Me.Controls.Add(Me._Label_25)
        Me.Controls.Add(Me._Label_24)
        Me.Controls.Add(Me._Label_23)
        Me.Controls.Add(Me._Label_22)
        Me.Controls.Add(Me._Label_21)
        Me.Controls.Add(Me._Label_20)
        Me.Controls.Add(Me._Label_19)
        Me.Controls.Add(Me._Label_18)
        Me.Controls.Add(Me._Label_17)
        Me.Controls.Add(Me._Label_16)
        Me.Controls.Add(Me._Label_15)
        Me.Controls.Add(Me._Label_14)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._Label_12)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_34)
        Me.Controls.Add(Me._Label_32)
        Me.Controls.Add(Me._Label_33)
        Me.Controls.Add(Me._Label_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(4, 47)
        Me.MaximizeBox = False
        Me.Name = "FrmChamcong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Employee attendance"
        Me.Text = "Chấm công nhân viên"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.FLuong13.ResumeLayout(False)
        Me.FLuong13.PerformLayout()
        Me.FrameBaohiem.ResumeLayout(False)
        Me.FrameBaohiem.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub InitializeLabel()
        Me.Label(81) = _Label_81
        Me.Label(82) = _Label_82
        Me.Label(83) = _Label_83
        Me.Label(84) = _Label_84
        Me.Label(88) = _Label_88
        Me.Label(89) = _Label_89
        Me.Label(90) = _Label_90
        Me.Label(91) = _Label_91
        Me.Label(80) = _Label_80
        Me.Label(85) = _Label_85
        Me.Label(86) = _Label_86
        Me.Label(87) = _Label_87
        Me.Label(79) = _Label_79
        Me.Label(78) = _Label_78
        Me.Label(77) = _Label_77
        Me.Label(76) = _Label_76
        Me.Label(75) = _Label_75
        Me.Label(74) = _Label_74
        Me.Label(73) = _Label_73
        Me.Label(72) = _Label_72
        Me.Label(40) = _Label_40
        Me.Label(39) = _Label_39
        Me.Label(38) = _Label_38
        Me.Label(37) = _Label_37
        Me.Label(36) = _Label_36
        Me.Label(41) = _Label_41
        Me.Label(42) = _Label_42
        Me.Label(43) = _Label_43
        Me.Label(44) = _Label_44
        Me.Label(45) = _Label_45
        Me.Label(46) = _Label_46
        Me.Label(47) = _Label_47
        Me.Label(48) = _Label_48
        Me.Label(49) = _Label_49
        Me.Label(50) = _Label_50
        Me.Label(51) = _Label_51
        Me.Label(52) = _Label_52
        Me.Label(53) = _Label_53
        Me.Label(54) = _Label_54
        Me.Label(55) = _Label_55
        Me.Label(56) = _Label_56
        Me.Label(57) = _Label_57
        Me.Label(58) = _Label_58
        Me.Label(59) = _Label_59
        Me.Label(60) = _Label_60
        Me.Label(61) = _Label_61
        Me.Label(62) = _Label_62
        Me.Label(63) = _Label_63
        Me.Label(64) = _Label_64
        Me.Label(65) = _Label_65
        Me.Label(66) = _Label_66
        Me.Label(67) = _Label_67
        Me.Label(68) = _Label_68
        Me.Label(69) = _Label_69
        Me.Label(70) = _Label_70
        Me.Label(71) = _Label_71
        Me.Label(35) = _Label_35
        Me.Label(31) = _Label_31
        Me.Label(30) = _Label_30
        Me.Label(29) = _Label_29
        Me.Label(28) = _Label_28
        Me.Label(27) = _Label_27
        Me.Label(26) = _Label_26
        Me.Label(25) = _Label_25
        Me.Label(24) = _Label_24
        Me.Label(23) = _Label_23
        Me.Label(22) = _Label_22
        Me.Label(21) = _Label_21
        Me.Label(20) = _Label_20
        Me.Label(19) = _Label_19
        Me.Label(18) = _Label_18
        Me.Label(17) = _Label_17
        Me.Label(16) = _Label_16
        Me.Label(15) = _Label_15
        Me.Label(14) = _Label_14
        Me.Label(13) = _Label_13
        Me.Label(12) = _Label_12
        Me.Label(11) = _Label_11
        Me.Label(10) = _Label_10
        Me.Label(9) = _Label_9
        Me.Label(8) = _Label_8
        Me.Label(7) = _Label_7
        Me.Label(6) = _Label_6
        Me.Label(5) = _Label_5
        Me.Label(4) = _Label_4
        Me.Label(3) = _Label_3
        Me.Label(2) = _Label_2
        Me.Label(1) = _Label_1
        Me.Label(34) = _Label_34
        Me.Label(32) = _Label_32
        Me.Label(33) = _Label_33
        Me.Label(0) = _Label_0
    End Sub
    Sub InitializeCommand()
        Me.Command(8) = _Command_8
        Me.Command(9) = _Command_9
        Me.Command(6) = _Command_6
        Me.Command(5) = _Command_5
        Me.Command(7) = _Command_7
        Me.Command(3) = _Command_3
        Me.Command(2) = _Command_2
        Me.Command(1) = _Command_1
        Me.Command(0) = _Command_0
    End Sub
    Public WithEvents TxtTNCN As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents TxtGiaCanh As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
#End Region 
End Class
