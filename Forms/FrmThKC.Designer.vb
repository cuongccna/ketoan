<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmThKC
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeLbKC()
		InitializeLabel()
		InitializeFrame()
		InitializeCommand()
		InitializeChkKC()
		InitializeCboThang()
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
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents txt As System.Windows.Forms.TextBox
    Private WithEvents _ChkKC_32 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_33 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_34 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_35 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_36 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_37 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_38 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_39 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_40 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_41 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_42 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_43 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_44 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_45 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_46 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_47 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_16 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_17 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_18 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_19 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_20 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_21 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_22 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_23 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_24 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_25 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_26 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_27 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_28 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_29 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_30 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_31 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_15 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_14 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_13 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_12 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_11 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_10 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_9 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_8 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_7 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_6 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_5 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_4 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_3 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_2 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_1 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkKC_0 As System.Windows.Forms.CheckBox
    Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Private WithEvents _Frame_4 As System.Windows.Forms.Panel
    Private WithEvents _LbKC_1 As System.Windows.Forms.Label
    Public CboThang(1) As ComboBoxEx.ComboBoxExt
    Public ChkKC(47) As System.Windows.Forms.CheckBox
    Public Command(1) As System.Windows.Forms.Button
    Public Command1(1) As System.Windows.Forms.Button
    Public Frame(4) As System.Windows.Forms.Panel
    Public Label(18) As System.Windows.Forms.Label
    Public LbKC(1) As System.Windows.Forms.Label
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me.txt = New System.Windows.Forms.TextBox
        Me._ChkKC_32 = New System.Windows.Forms.CheckBox
        Me._ChkKC_33 = New System.Windows.Forms.CheckBox
        Me._ChkKC_34 = New System.Windows.Forms.CheckBox
        Me._ChkKC_35 = New System.Windows.Forms.CheckBox
        Me._ChkKC_36 = New System.Windows.Forms.CheckBox
        Me._ChkKC_37 = New System.Windows.Forms.CheckBox
        Me._ChkKC_38 = New System.Windows.Forms.CheckBox
        Me._ChkKC_39 = New System.Windows.Forms.CheckBox
        Me._ChkKC_40 = New System.Windows.Forms.CheckBox
        Me._ChkKC_41 = New System.Windows.Forms.CheckBox
        Me._ChkKC_42 = New System.Windows.Forms.CheckBox
        Me._ChkKC_43 = New System.Windows.Forms.CheckBox
        Me._ChkKC_44 = New System.Windows.Forms.CheckBox
        Me._ChkKC_45 = New System.Windows.Forms.CheckBox
        Me._ChkKC_46 = New System.Windows.Forms.CheckBox
        Me._ChkKC_47 = New System.Windows.Forms.CheckBox
        Me._ChkKC_16 = New System.Windows.Forms.CheckBox
        Me._ChkKC_17 = New System.Windows.Forms.CheckBox
        Me._ChkKC_18 = New System.Windows.Forms.CheckBox
        Me._ChkKC_19 = New System.Windows.Forms.CheckBox
        Me._ChkKC_20 = New System.Windows.Forms.CheckBox
        Me._ChkKC_21 = New System.Windows.Forms.CheckBox
        Me._ChkKC_22 = New System.Windows.Forms.CheckBox
        Me._ChkKC_23 = New System.Windows.Forms.CheckBox
        Me._ChkKC_24 = New System.Windows.Forms.CheckBox
        Me._ChkKC_25 = New System.Windows.Forms.CheckBox
        Me._ChkKC_26 = New System.Windows.Forms.CheckBox
        Me._ChkKC_27 = New System.Windows.Forms.CheckBox
        Me._ChkKC_28 = New System.Windows.Forms.CheckBox
        Me._ChkKC_29 = New System.Windows.Forms.CheckBox
        Me._ChkKC_30 = New System.Windows.Forms.CheckBox
        Me._ChkKC_31 = New System.Windows.Forms.CheckBox
        Me._ChkKC_15 = New System.Windows.Forms.CheckBox
        Me._ChkKC_14 = New System.Windows.Forms.CheckBox
        Me._ChkKC_13 = New System.Windows.Forms.CheckBox
        Me._ChkKC_12 = New System.Windows.Forms.CheckBox
        Me._ChkKC_11 = New System.Windows.Forms.CheckBox
        Me._ChkKC_10 = New System.Windows.Forms.CheckBox
        Me._ChkKC_9 = New System.Windows.Forms.CheckBox
        Me._ChkKC_8 = New System.Windows.Forms.CheckBox
        Me._ChkKC_7 = New System.Windows.Forms.CheckBox
        Me._ChkKC_6 = New System.Windows.Forms.CheckBox
        Me._ChkKC_5 = New System.Windows.Forms.CheckBox
        Me._ChkKC_4 = New System.Windows.Forms.CheckBox
        Me._ChkKC_3 = New System.Windows.Forms.CheckBox
        Me._ChkKC_2 = New System.Windows.Forms.CheckBox
        Me._ChkKC_1 = New System.Windows.Forms.CheckBox
        Me._ChkKC_0 = New System.Windows.Forms.CheckBox
        Me._Frame_4 = New System.Windows.Forms.Panel
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt
        Me._Label_17 = New System.Windows.Forms.Label
        Me._Label_18 = New System.Windows.Forms.Label
        Me._LbKC_1 = New System.Windows.Forms.Label
        Me._Frame_4.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(348, 415)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(89, 25)
        Me._Command_1.TabIndex = 58
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.select16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(253, 415)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(89, 25)
        Me._Command_0.TabIndex = 57
        Me._Command_0.Tag = "Apply"
        Me._Command_0.Text = "&Thực hiện"
        '
        'txt
        '
        Me.txt.AcceptsReturn = True
        Me.txt.BackColor = System.Drawing.SystemColors.Window
        Me.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(313, 6)
        Me.txt.MaxLength = 20
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(49, 20)
        Me.txt.TabIndex = 2
        Me.txt.Visible = False
        '
        '_ChkKC_32
        '
        Me._ChkKC_32.Checked = True
        Me._ChkKC_32.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_32.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_32.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_32.Location = New System.Drawing.Point(472, 32)
        Me._ChkKC_32.Name = "_ChkKC_32"
        Me._ChkKC_32.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_32.TabIndex = 51
        Me._ChkKC_32.Tag = "0"
        Me._ChkKC_32.Text = "KC"
        Me._ChkKC_32.UseVisualStyleBackColor = False
        Me._ChkKC_32.Visible = False
        '
        '_ChkKC_33
        '
        Me._ChkKC_33.Checked = True
        Me._ChkKC_33.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_33.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_33.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_33.Location = New System.Drawing.Point(472, 56)
        Me._ChkKC_33.Name = "_ChkKC_33"
        Me._ChkKC_33.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_33.TabIndex = 50
        Me._ChkKC_33.Tag = "0"
        Me._ChkKC_33.Text = "KC"
        Me._ChkKC_33.UseVisualStyleBackColor = False
        Me._ChkKC_33.Visible = False
        '
        '_ChkKC_34
        '
        Me._ChkKC_34.Checked = True
        Me._ChkKC_34.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_34.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_34.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_34.Location = New System.Drawing.Point(472, 80)
        Me._ChkKC_34.Name = "_ChkKC_34"
        Me._ChkKC_34.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_34.TabIndex = 49
        Me._ChkKC_34.Tag = "0"
        Me._ChkKC_34.Text = "KC"
        Me._ChkKC_34.UseVisualStyleBackColor = False
        Me._ChkKC_34.Visible = False
        '
        '_ChkKC_35
        '
        Me._ChkKC_35.Checked = True
        Me._ChkKC_35.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_35.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_35.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_35.Location = New System.Drawing.Point(472, 104)
        Me._ChkKC_35.Name = "_ChkKC_35"
        Me._ChkKC_35.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_35.TabIndex = 48
        Me._ChkKC_35.Tag = "0"
        Me._ChkKC_35.Text = "KC"
        Me._ChkKC_35.UseVisualStyleBackColor = False
        Me._ChkKC_35.Visible = False
        '
        '_ChkKC_36
        '
        Me._ChkKC_36.Checked = True
        Me._ChkKC_36.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_36.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_36.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_36.Location = New System.Drawing.Point(472, 128)
        Me._ChkKC_36.Name = "_ChkKC_36"
        Me._ChkKC_36.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_36.TabIndex = 47
        Me._ChkKC_36.Tag = "0"
        Me._ChkKC_36.Text = "KC"
        Me._ChkKC_36.UseVisualStyleBackColor = False
        Me._ChkKC_36.Visible = False
        '
        '_ChkKC_37
        '
        Me._ChkKC_37.Checked = True
        Me._ChkKC_37.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_37.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_37.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_37.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_37.Location = New System.Drawing.Point(472, 152)
        Me._ChkKC_37.Name = "_ChkKC_37"
        Me._ChkKC_37.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_37.TabIndex = 46
        Me._ChkKC_37.Tag = "0"
        Me._ChkKC_37.Text = "KC"
        Me._ChkKC_37.UseVisualStyleBackColor = False
        Me._ChkKC_37.Visible = False
        '
        '_ChkKC_38
        '
        Me._ChkKC_38.Checked = True
        Me._ChkKC_38.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_38.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_38.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_38.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_38.Location = New System.Drawing.Point(472, 176)
        Me._ChkKC_38.Name = "_ChkKC_38"
        Me._ChkKC_38.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_38.TabIndex = 45
        Me._ChkKC_38.Tag = "0"
        Me._ChkKC_38.Text = "KC"
        Me._ChkKC_38.UseVisualStyleBackColor = False
        Me._ChkKC_38.Visible = False
        '
        '_ChkKC_39
        '
        Me._ChkKC_39.Checked = True
        Me._ChkKC_39.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_39.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_39.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_39.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_39.Location = New System.Drawing.Point(472, 200)
        Me._ChkKC_39.Name = "_ChkKC_39"
        Me._ChkKC_39.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_39.TabIndex = 44
        Me._ChkKC_39.Tag = "0"
        Me._ChkKC_39.Text = "KC"
        Me._ChkKC_39.UseVisualStyleBackColor = False
        Me._ChkKC_39.Visible = False
        '
        '_ChkKC_40
        '
        Me._ChkKC_40.Checked = True
        Me._ChkKC_40.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_40.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_40.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_40.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_40.Location = New System.Drawing.Point(472, 224)
        Me._ChkKC_40.Name = "_ChkKC_40"
        Me._ChkKC_40.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_40.TabIndex = 43
        Me._ChkKC_40.Tag = "0"
        Me._ChkKC_40.Text = "KC"
        Me._ChkKC_40.UseVisualStyleBackColor = False
        Me._ChkKC_40.Visible = False
        '
        '_ChkKC_41
        '
        Me._ChkKC_41.Checked = True
        Me._ChkKC_41.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_41.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_41.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_41.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_41.Location = New System.Drawing.Point(472, 248)
        Me._ChkKC_41.Name = "_ChkKC_41"
        Me._ChkKC_41.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_41.TabIndex = 42
        Me._ChkKC_41.Tag = "0"
        Me._ChkKC_41.Text = "KC"
        Me._ChkKC_41.UseVisualStyleBackColor = False
        Me._ChkKC_41.Visible = False
        '
        '_ChkKC_42
        '
        Me._ChkKC_42.Checked = True
        Me._ChkKC_42.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_42.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_42.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_42.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_42.Location = New System.Drawing.Point(472, 272)
        Me._ChkKC_42.Name = "_ChkKC_42"
        Me._ChkKC_42.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_42.TabIndex = 41
        Me._ChkKC_42.Tag = "0"
        Me._ChkKC_42.Text = "KC"
        Me._ChkKC_42.UseVisualStyleBackColor = False
        Me._ChkKC_42.Visible = False
        '
        '_ChkKC_43
        '
        Me._ChkKC_43.Checked = True
        Me._ChkKC_43.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_43.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_43.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_43.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_43.Location = New System.Drawing.Point(472, 296)
        Me._ChkKC_43.Name = "_ChkKC_43"
        Me._ChkKC_43.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_43.TabIndex = 40
        Me._ChkKC_43.Tag = "0"
        Me._ChkKC_43.Text = "KC"
        Me._ChkKC_43.UseVisualStyleBackColor = False
        Me._ChkKC_43.Visible = False
        '
        '_ChkKC_44
        '
        Me._ChkKC_44.Checked = True
        Me._ChkKC_44.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_44.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_44.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_44.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_44.Location = New System.Drawing.Point(472, 320)
        Me._ChkKC_44.Name = "_ChkKC_44"
        Me._ChkKC_44.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_44.TabIndex = 39
        Me._ChkKC_44.Tag = "0"
        Me._ChkKC_44.Text = "KC"
        Me._ChkKC_44.UseVisualStyleBackColor = False
        Me._ChkKC_44.Visible = False
        '
        '_ChkKC_45
        '
        Me._ChkKC_45.Checked = True
        Me._ChkKC_45.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_45.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_45.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_45.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_45.Location = New System.Drawing.Point(472, 344)
        Me._ChkKC_45.Name = "_ChkKC_45"
        Me._ChkKC_45.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_45.TabIndex = 38
        Me._ChkKC_45.Tag = "0"
        Me._ChkKC_45.Text = "KC"
        Me._ChkKC_45.UseVisualStyleBackColor = False
        Me._ChkKC_45.Visible = False
        '
        '_ChkKC_46
        '
        Me._ChkKC_46.Checked = True
        Me._ChkKC_46.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_46.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_46.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_46.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_46.Location = New System.Drawing.Point(472, 368)
        Me._ChkKC_46.Name = "_ChkKC_46"
        Me._ChkKC_46.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_46.TabIndex = 37
        Me._ChkKC_46.Tag = "0"
        Me._ChkKC_46.Text = "KC"
        Me._ChkKC_46.UseVisualStyleBackColor = False
        Me._ChkKC_46.Visible = False
        '
        '_ChkKC_47
        '
        Me._ChkKC_47.Checked = True
        Me._ChkKC_47.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_47.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_47.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_47.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_47.Location = New System.Drawing.Point(472, 392)
        Me._ChkKC_47.Name = "_ChkKC_47"
        Me._ChkKC_47.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_47.TabIndex = 36
        Me._ChkKC_47.Tag = "0"
        Me._ChkKC_47.Text = "KC"
        Me._ChkKC_47.UseVisualStyleBackColor = False
        Me._ChkKC_47.Visible = False
        '
        '_ChkKC_16
        '
        Me._ChkKC_16.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_16.Checked = True
        Me._ChkKC_16.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_16.Location = New System.Drawing.Point(232, 32)
        Me._ChkKC_16.Name = "_ChkKC_16"
        Me._ChkKC_16.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_16.TabIndex = 35
        Me._ChkKC_16.Tag = "0"
        Me._ChkKC_16.Text = "KC"
        Me._ChkKC_16.UseVisualStyleBackColor = False
        Me._ChkKC_16.Visible = False
        '
        '_ChkKC_17
        '
        Me._ChkKC_17.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_17.Checked = True
        Me._ChkKC_17.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_17.Location = New System.Drawing.Point(232, 56)
        Me._ChkKC_17.Name = "_ChkKC_17"
        Me._ChkKC_17.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_17.TabIndex = 34
        Me._ChkKC_17.Tag = "0"
        Me._ChkKC_17.Text = "KC"
        Me._ChkKC_17.UseVisualStyleBackColor = False
        Me._ChkKC_17.Visible = False
        '
        '_ChkKC_18
        '
        Me._ChkKC_18.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_18.Checked = True
        Me._ChkKC_18.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_18.Location = New System.Drawing.Point(232, 80)
        Me._ChkKC_18.Name = "_ChkKC_18"
        Me._ChkKC_18.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_18.TabIndex = 33
        Me._ChkKC_18.Tag = "0"
        Me._ChkKC_18.Text = "KC"
        Me._ChkKC_18.UseVisualStyleBackColor = False
        Me._ChkKC_18.Visible = False
        '
        '_ChkKC_19
        '
        Me._ChkKC_19.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_19.Checked = True
        Me._ChkKC_19.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_19.Location = New System.Drawing.Point(232, 104)
        Me._ChkKC_19.Name = "_ChkKC_19"
        Me._ChkKC_19.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_19.TabIndex = 32
        Me._ChkKC_19.Tag = "0"
        Me._ChkKC_19.Text = "KC"
        Me._ChkKC_19.UseVisualStyleBackColor = False
        Me._ChkKC_19.Visible = False
        '
        '_ChkKC_20
        '
        Me._ChkKC_20.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_20.Checked = True
        Me._ChkKC_20.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_20.Location = New System.Drawing.Point(232, 128)
        Me._ChkKC_20.Name = "_ChkKC_20"
        Me._ChkKC_20.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_20.TabIndex = 31
        Me._ChkKC_20.Tag = "0"
        Me._ChkKC_20.Text = "KC"
        Me._ChkKC_20.UseVisualStyleBackColor = False
        Me._ChkKC_20.Visible = False
        '
        '_ChkKC_21
        '
        Me._ChkKC_21.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_21.Checked = True
        Me._ChkKC_21.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_21.Location = New System.Drawing.Point(232, 152)
        Me._ChkKC_21.Name = "_ChkKC_21"
        Me._ChkKC_21.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_21.TabIndex = 30
        Me._ChkKC_21.Tag = "0"
        Me._ChkKC_21.Text = "KC"
        Me._ChkKC_21.UseVisualStyleBackColor = False
        Me._ChkKC_21.Visible = False
        '
        '_ChkKC_22
        '
        Me._ChkKC_22.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_22.Checked = True
        Me._ChkKC_22.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_22.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_22.Location = New System.Drawing.Point(232, 176)
        Me._ChkKC_22.Name = "_ChkKC_22"
        Me._ChkKC_22.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_22.TabIndex = 29
        Me._ChkKC_22.Tag = "0"
        Me._ChkKC_22.Text = "KC"
        Me._ChkKC_22.UseVisualStyleBackColor = False
        Me._ChkKC_22.Visible = False
        '
        '_ChkKC_23
        '
        Me._ChkKC_23.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_23.Checked = True
        Me._ChkKC_23.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_23.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_23.Location = New System.Drawing.Point(232, 200)
        Me._ChkKC_23.Name = "_ChkKC_23"
        Me._ChkKC_23.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_23.TabIndex = 28
        Me._ChkKC_23.Tag = "0"
        Me._ChkKC_23.Text = "KC"
        Me._ChkKC_23.UseVisualStyleBackColor = False
        Me._ChkKC_23.Visible = False
        '
        '_ChkKC_24
        '
        Me._ChkKC_24.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_24.Checked = True
        Me._ChkKC_24.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_24.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_24.Location = New System.Drawing.Point(232, 224)
        Me._ChkKC_24.Name = "_ChkKC_24"
        Me._ChkKC_24.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_24.TabIndex = 27
        Me._ChkKC_24.Tag = "0"
        Me._ChkKC_24.Text = "KC"
        Me._ChkKC_24.UseVisualStyleBackColor = False
        Me._ChkKC_24.Visible = False
        '
        '_ChkKC_25
        '
        Me._ChkKC_25.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_25.Checked = True
        Me._ChkKC_25.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_25.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_25.Location = New System.Drawing.Point(232, 248)
        Me._ChkKC_25.Name = "_ChkKC_25"
        Me._ChkKC_25.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_25.TabIndex = 26
        Me._ChkKC_25.Tag = "0"
        Me._ChkKC_25.Text = "KC"
        Me._ChkKC_25.UseVisualStyleBackColor = False
        Me._ChkKC_25.Visible = False
        '
        '_ChkKC_26
        '
        Me._ChkKC_26.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_26.Checked = True
        Me._ChkKC_26.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_26.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_26.Location = New System.Drawing.Point(232, 272)
        Me._ChkKC_26.Name = "_ChkKC_26"
        Me._ChkKC_26.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_26.TabIndex = 25
        Me._ChkKC_26.Tag = "0"
        Me._ChkKC_26.Text = "KC"
        Me._ChkKC_26.UseVisualStyleBackColor = False
        Me._ChkKC_26.Visible = False
        '
        '_ChkKC_27
        '
        Me._ChkKC_27.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_27.Checked = True
        Me._ChkKC_27.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_27.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_27.Location = New System.Drawing.Point(232, 296)
        Me._ChkKC_27.Name = "_ChkKC_27"
        Me._ChkKC_27.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_27.TabIndex = 24
        Me._ChkKC_27.Tag = "0"
        Me._ChkKC_27.Text = "KC"
        Me._ChkKC_27.UseVisualStyleBackColor = False
        Me._ChkKC_27.Visible = False
        '
        '_ChkKC_28
        '
        Me._ChkKC_28.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_28.Checked = True
        Me._ChkKC_28.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_28.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_28.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_28.Location = New System.Drawing.Point(232, 320)
        Me._ChkKC_28.Name = "_ChkKC_28"
        Me._ChkKC_28.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_28.TabIndex = 23
        Me._ChkKC_28.Tag = "0"
        Me._ChkKC_28.Text = "KC"
        Me._ChkKC_28.UseVisualStyleBackColor = False
        Me._ChkKC_28.Visible = False
        '
        '_ChkKC_29
        '
        Me._ChkKC_29.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_29.Checked = True
        Me._ChkKC_29.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_29.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_29.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_29.Location = New System.Drawing.Point(232, 344)
        Me._ChkKC_29.Name = "_ChkKC_29"
        Me._ChkKC_29.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_29.TabIndex = 22
        Me._ChkKC_29.Tag = "0"
        Me._ChkKC_29.Text = "KC"
        Me._ChkKC_29.UseVisualStyleBackColor = False
        Me._ChkKC_29.Visible = False
        '
        '_ChkKC_30
        '
        Me._ChkKC_30.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_30.Checked = True
        Me._ChkKC_30.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_30.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_30.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_30.Location = New System.Drawing.Point(232, 368)
        Me._ChkKC_30.Name = "_ChkKC_30"
        Me._ChkKC_30.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_30.TabIndex = 21
        Me._ChkKC_30.Tag = "0"
        Me._ChkKC_30.Text = "KC"
        Me._ChkKC_30.UseVisualStyleBackColor = False
        Me._ChkKC_30.Visible = False
        '
        '_ChkKC_31
        '
        Me._ChkKC_31.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_31.Checked = True
        Me._ChkKC_31.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_31.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_31.Location = New System.Drawing.Point(232, 392)
        Me._ChkKC_31.Name = "_ChkKC_31"
        Me._ChkKC_31.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_31.TabIndex = 20
        Me._ChkKC_31.Tag = "0"
        Me._ChkKC_31.Text = "KC"
        Me._ChkKC_31.UseVisualStyleBackColor = False
        Me._ChkKC_31.Visible = False
        '
        '_ChkKC_15
        '
        Me._ChkKC_15.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_15.Checked = True
        Me._ChkKC_15.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_15.Location = New System.Drawing.Point(8, 392)
        Me._ChkKC_15.Name = "_ChkKC_15"
        Me._ChkKC_15.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_15.TabIndex = 18
        Me._ChkKC_15.Tag = "0"
        Me._ChkKC_15.Text = "KC"
        Me._ChkKC_15.UseVisualStyleBackColor = False
        Me._ChkKC_15.Visible = False
        '
        '_ChkKC_14
        '
        Me._ChkKC_14.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_14.Checked = True
        Me._ChkKC_14.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_14.Location = New System.Drawing.Point(8, 368)
        Me._ChkKC_14.Name = "_ChkKC_14"
        Me._ChkKC_14.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_14.TabIndex = 17
        Me._ChkKC_14.Tag = "0"
        Me._ChkKC_14.Text = "KC"
        Me._ChkKC_14.UseVisualStyleBackColor = False
        Me._ChkKC_14.Visible = False
        '
        '_ChkKC_13
        '
        Me._ChkKC_13.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_13.Checked = True
        Me._ChkKC_13.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_13.Location = New System.Drawing.Point(8, 344)
        Me._ChkKC_13.Name = "_ChkKC_13"
        Me._ChkKC_13.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_13.TabIndex = 16
        Me._ChkKC_13.Tag = "0"
        Me._ChkKC_13.Text = "KC"
        Me._ChkKC_13.UseVisualStyleBackColor = False
        Me._ChkKC_13.Visible = False
        '
        '_ChkKC_12
        '
        Me._ChkKC_12.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_12.Checked = True
        Me._ChkKC_12.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_12.Location = New System.Drawing.Point(8, 320)
        Me._ChkKC_12.Name = "_ChkKC_12"
        Me._ChkKC_12.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_12.TabIndex = 15
        Me._ChkKC_12.Tag = "0"
        Me._ChkKC_12.Text = "KC"
        Me._ChkKC_12.UseVisualStyleBackColor = False
        Me._ChkKC_12.Visible = False
        '
        '_ChkKC_11
        '
        Me._ChkKC_11.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_11.Checked = True
        Me._ChkKC_11.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_11.Location = New System.Drawing.Point(8, 296)
        Me._ChkKC_11.Name = "_ChkKC_11"
        Me._ChkKC_11.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_11.TabIndex = 14
        Me._ChkKC_11.Tag = "0"
        Me._ChkKC_11.Text = "KC"
        Me._ChkKC_11.UseVisualStyleBackColor = False
        Me._ChkKC_11.Visible = False
        '
        '_ChkKC_10
        '
        Me._ChkKC_10.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_10.Checked = True
        Me._ChkKC_10.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_10.Location = New System.Drawing.Point(8, 272)
        Me._ChkKC_10.Name = "_ChkKC_10"
        Me._ChkKC_10.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_10.TabIndex = 13
        Me._ChkKC_10.Tag = "0"
        Me._ChkKC_10.Text = "KC"
        Me._ChkKC_10.UseVisualStyleBackColor = False
        Me._ChkKC_10.Visible = False
        '
        '_ChkKC_9
        '
        Me._ChkKC_9.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_9.Checked = True
        Me._ChkKC_9.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_9.Location = New System.Drawing.Point(8, 248)
        Me._ChkKC_9.Name = "_ChkKC_9"
        Me._ChkKC_9.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_9.TabIndex = 12
        Me._ChkKC_9.Tag = "0"
        Me._ChkKC_9.Text = "KC"
        Me._ChkKC_9.UseVisualStyleBackColor = False
        Me._ChkKC_9.Visible = False
        '
        '_ChkKC_8
        '
        Me._ChkKC_8.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_8.Checked = True
        Me._ChkKC_8.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_8.Location = New System.Drawing.Point(8, 224)
        Me._ChkKC_8.Name = "_ChkKC_8"
        Me._ChkKC_8.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_8.TabIndex = 11
        Me._ChkKC_8.Tag = "0"
        Me._ChkKC_8.Text = "KC"
        Me._ChkKC_8.UseVisualStyleBackColor = False
        Me._ChkKC_8.Visible = False
        '
        '_ChkKC_7
        '
        Me._ChkKC_7.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_7.Checked = True
        Me._ChkKC_7.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_7.Location = New System.Drawing.Point(8, 200)
        Me._ChkKC_7.Name = "_ChkKC_7"
        Me._ChkKC_7.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_7.TabIndex = 10
        Me._ChkKC_7.Tag = "0"
        Me._ChkKC_7.Text = "KC"
        Me._ChkKC_7.UseVisualStyleBackColor = False
        Me._ChkKC_7.Visible = False
        '
        '_ChkKC_6
        '
        Me._ChkKC_6.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_6.Checked = True
        Me._ChkKC_6.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_6.Location = New System.Drawing.Point(8, 176)
        Me._ChkKC_6.Name = "_ChkKC_6"
        Me._ChkKC_6.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_6.TabIndex = 9
        Me._ChkKC_6.Tag = "0"
        Me._ChkKC_6.Text = "KC"
        Me._ChkKC_6.UseVisualStyleBackColor = False
        Me._ChkKC_6.Visible = False
        '
        '_ChkKC_5
        '
        Me._ChkKC_5.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_5.Checked = True
        Me._ChkKC_5.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_5.Location = New System.Drawing.Point(8, 152)
        Me._ChkKC_5.Name = "_ChkKC_5"
        Me._ChkKC_5.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_5.TabIndex = 8
        Me._ChkKC_5.Tag = "0"
        Me._ChkKC_5.Text = "KC"
        Me._ChkKC_5.UseVisualStyleBackColor = False
        Me._ChkKC_5.Visible = False
        '
        '_ChkKC_4
        '
        Me._ChkKC_4.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_4.Checked = True
        Me._ChkKC_4.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_4.Location = New System.Drawing.Point(8, 128)
        Me._ChkKC_4.Name = "_ChkKC_4"
        Me._ChkKC_4.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_4.TabIndex = 7
        Me._ChkKC_4.Tag = "0"
        Me._ChkKC_4.Text = "KC"
        Me._ChkKC_4.UseVisualStyleBackColor = False
        Me._ChkKC_4.Visible = False
        '
        '_ChkKC_3
        '
        Me._ChkKC_3.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_3.Checked = True
        Me._ChkKC_3.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_3.Location = New System.Drawing.Point(8, 104)
        Me._ChkKC_3.Name = "_ChkKC_3"
        Me._ChkKC_3.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_3.TabIndex = 6
        Me._ChkKC_3.Tag = "0"
        Me._ChkKC_3.Text = "KC"
        Me._ChkKC_3.UseVisualStyleBackColor = False
        Me._ChkKC_3.Visible = False
        '
        '_ChkKC_2
        '
        Me._ChkKC_2.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_2.Checked = True
        Me._ChkKC_2.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_2.Location = New System.Drawing.Point(8, 80)
        Me._ChkKC_2.Name = "_ChkKC_2"
        Me._ChkKC_2.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_2.TabIndex = 5
        Me._ChkKC_2.Tag = "0"
        Me._ChkKC_2.Text = "KC"
        Me._ChkKC_2.UseVisualStyleBackColor = False
        Me._ChkKC_2.Visible = False
        '
        '_ChkKC_1
        '
        Me._ChkKC_1.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_1.Checked = True
        Me._ChkKC_1.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_1.Location = New System.Drawing.Point(8, 56)
        Me._ChkKC_1.Name = "_ChkKC_1"
        Me._ChkKC_1.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_1.TabIndex = 4
        Me._ChkKC_1.Tag = "0"
        Me._ChkKC_1.Text = "KC"
        Me._ChkKC_1.UseVisualStyleBackColor = False
        Me._ChkKC_1.Visible = False
        '
        '_ChkKC_0
        '
        Me._ChkKC_0.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_0.Checked = True
        Me._ChkKC_0.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkKC_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_0.Location = New System.Drawing.Point(8, 32)
        Me._ChkKC_0.Name = "_ChkKC_0"
        Me._ChkKC_0.Size = New System.Drawing.Size(225, 17)
        Me._ChkKC_0.TabIndex = 3
        Me._ChkKC_0.Tag = "0"
        Me._ChkKC_0.Text = "KC"
        Me._ChkKC_0.UseVisualStyleBackColor = False
        Me._ChkKC_0.Visible = False
        '
        '_Frame_4
        '
        Me._Frame_4.BackColor = System.Drawing.Color.Transparent
        Me._Frame_4.Controls.Add(Me._CboThang_0)
        Me._Frame_4.Controls.Add(Me._CboThang_1)
        Me._Frame_4.Controls.Add(Me._Label_17)
        Me._Frame_4.Controls.Add(Me._Label_18)
        Me._Frame_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Frame_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_4.Location = New System.Drawing.Point(0, 0)
        Me._Frame_4.Name = "_Frame_4"
        Me._Frame_4.Size = New System.Drawing.Size(265, 33)
        Me._Frame_4.TabIndex = 54
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(56, 4)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_0.TabIndex = 0
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(192, 4)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_1.TabIndex = 1
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.Transparent
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_17.Location = New System.Drawing.Point(133, 8)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(59, 17)
        Me._Label_17.TabIndex = 56
        Me._Label_17.Tag = "to"
        Me._Label_17.Text = "Đến tháng"
        Me._Label_17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.Transparent
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_18.Location = New System.Drawing.Point(0, 8)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.Size = New System.Drawing.Size(52, 17)
        Me._Label_18.TabIndex = 55
        Me._Label_18.Tag = "to"
        Me._Label_18.Text = "Từ tháng"
        Me._Label_18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_LbKC_1
        '
        Me._LbKC_1.BackColor = System.Drawing.Color.Transparent
        Me._LbKC_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbKC_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbKC_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LbKC_1.Location = New System.Drawing.Point(266, 9)
        Me._LbKC_1.Name = "_LbKC_1"
        Me._LbKC_1.Size = New System.Drawing.Size(41, 17)
        Me._LbKC_1.TabIndex = 52
        Me._LbKC_1.Tag = "Ex. Rate"
        Me._LbKC_1.Text = "Tỷ giá"
        Me._LbKC_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me._LbKC_1.Visible = False
        '
        'FrmThKC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(708, 446)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me._ChkKC_32)
        Me.Controls.Add(Me._ChkKC_33)
        Me.Controls.Add(Me._ChkKC_34)
        Me.Controls.Add(Me._ChkKC_35)
        Me.Controls.Add(Me._ChkKC_36)
        Me.Controls.Add(Me._ChkKC_37)
        Me.Controls.Add(Me._ChkKC_38)
        Me.Controls.Add(Me._ChkKC_39)
        Me.Controls.Add(Me._ChkKC_40)
        Me.Controls.Add(Me._ChkKC_41)
        Me.Controls.Add(Me._ChkKC_42)
        Me.Controls.Add(Me._ChkKC_43)
        Me.Controls.Add(Me._ChkKC_44)
        Me.Controls.Add(Me._ChkKC_45)
        Me.Controls.Add(Me._ChkKC_46)
        Me.Controls.Add(Me._ChkKC_47)
        Me.Controls.Add(Me._ChkKC_16)
        Me.Controls.Add(Me._ChkKC_17)
        Me.Controls.Add(Me._ChkKC_18)
        Me.Controls.Add(Me._ChkKC_19)
        Me.Controls.Add(Me._ChkKC_20)
        Me.Controls.Add(Me._ChkKC_21)
        Me.Controls.Add(Me._ChkKC_22)
        Me.Controls.Add(Me._ChkKC_23)
        Me.Controls.Add(Me._ChkKC_24)
        Me.Controls.Add(Me._ChkKC_25)
        Me.Controls.Add(Me._ChkKC_26)
        Me.Controls.Add(Me._ChkKC_27)
        Me.Controls.Add(Me._ChkKC_28)
        Me.Controls.Add(Me._ChkKC_29)
        Me.Controls.Add(Me._ChkKC_30)
        Me.Controls.Add(Me._ChkKC_31)
        Me.Controls.Add(Me._ChkKC_15)
        Me.Controls.Add(Me._ChkKC_14)
        Me.Controls.Add(Me._ChkKC_13)
        Me.Controls.Add(Me._ChkKC_12)
        Me.Controls.Add(Me._ChkKC_11)
        Me.Controls.Add(Me._ChkKC_10)
        Me.Controls.Add(Me._ChkKC_9)
        Me.Controls.Add(Me._ChkKC_8)
        Me.Controls.Add(Me._ChkKC_7)
        Me.Controls.Add(Me._ChkKC_6)
        Me.Controls.Add(Me._ChkKC_5)
        Me.Controls.Add(Me._ChkKC_4)
        Me.Controls.Add(Me._ChkKC_3)
        Me.Controls.Add(Me._ChkKC_2)
        Me.Controls.Add(Me._ChkKC_1)
        Me.Controls.Add(Me._ChkKC_0)
        Me.Controls.Add(Me._Frame_4)
        Me.Controls.Add(Me._LbKC_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(110, 103)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmThKC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Monthly Conversion"
        Me.Text = "Thực hiện kết chuyển"
        Me._Frame_4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeLbKC()
		Me.LbKC(1) = _LbKC_1
	End Sub
	Sub InitializeLabel()
		Me.Label(17) = _Label_17
		Me.Label(18) = _Label_18
	End Sub
	Sub InitializeFrame()
		Me.Frame(4) = _Frame_4
	End Sub
	Sub InitializeCommand()
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeChkKC()
		Me.ChkKC(32) = _ChkKC_32
		Me.ChkKC(33) = _ChkKC_33
		Me.ChkKC(34) = _ChkKC_34
		Me.ChkKC(35) = _ChkKC_35
		Me.ChkKC(36) = _ChkKC_36
		Me.ChkKC(37) = _ChkKC_37
		Me.ChkKC(38) = _ChkKC_38
		Me.ChkKC(39) = _ChkKC_39
		Me.ChkKC(40) = _ChkKC_40
		Me.ChkKC(41) = _ChkKC_41
		Me.ChkKC(42) = _ChkKC_42
		Me.ChkKC(43) = _ChkKC_43
		Me.ChkKC(44) = _ChkKC_44
		Me.ChkKC(45) = _ChkKC_45
		Me.ChkKC(46) = _ChkKC_46
		Me.ChkKC(47) = _ChkKC_47
		Me.ChkKC(16) = _ChkKC_16
		Me.ChkKC(17) = _ChkKC_17
		Me.ChkKC(18) = _ChkKC_18
		Me.ChkKC(19) = _ChkKC_19
		Me.ChkKC(20) = _ChkKC_20
		Me.ChkKC(21) = _ChkKC_21
		Me.ChkKC(22) = _ChkKC_22
		Me.ChkKC(23) = _ChkKC_23
		Me.ChkKC(24) = _ChkKC_24
		Me.ChkKC(25) = _ChkKC_25
		Me.ChkKC(26) = _ChkKC_26
		Me.ChkKC(27) = _ChkKC_27
		Me.ChkKC(28) = _ChkKC_28
		Me.ChkKC(29) = _ChkKC_29
		Me.ChkKC(30) = _ChkKC_30
		Me.ChkKC(31) = _ChkKC_31
		Me.ChkKC(15) = _ChkKC_15
		Me.ChkKC(14) = _ChkKC_14
		Me.ChkKC(13) = _ChkKC_13
		Me.ChkKC(12) = _ChkKC_12
		Me.ChkKC(11) = _ChkKC_11
		Me.ChkKC(10) = _ChkKC_10
		Me.ChkKC(9) = _ChkKC_9
		Me.ChkKC(8) = _ChkKC_8
		Me.ChkKC(7) = _ChkKC_7
		Me.ChkKC(6) = _ChkKC_6
		Me.ChkKC(5) = _ChkKC_5
		Me.ChkKC(4) = _ChkKC_4
		Me.ChkKC(3) = _ChkKC_3
		Me.ChkKC(2) = _ChkKC_2
		Me.ChkKC(1) = _ChkKC_1
		Me.ChkKC(0) = _ChkKC_0
	End Sub
	Sub InitializeCboThang()
		Me.CboThang(0) = _CboThang_0
		Me.CboThang(1) = _CboThang_1
	End Sub
#End Region 
End Class
