Public Class MasterWnd : Inherits Form

#Region "VisualStudioDesignerArea"
    Friend WithEvents PHONE_INFO_PANEL As BorderPanel
    Friend WithEvents PHONE_INFO_PIC As PictureBox
    Friend WithEvents PHONE_NAME_LABEL As SeguoUI_Label
    Friend WithEvents PHONE_BT_STATUS_LABEL As SeguoUI_Label
    Friend WithEvents SeguoUI_Label5 As SeguoUI_Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents SeguoUI_Label6 As SeguoUI_Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents SeguoUI_Label7 As SeguoUI_Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents SeguoUI_Label8 As SeguoUI_Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents SeguoUI_Label3 As SeguoUI_Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents SeguoUI_Label4 As SeguoUI_Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents SeguoUI_Label2 As SeguoUI_Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents SeguoUI_Label1 As SeguoUI_Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents SeguoUI_Label12 As SeguoUI_Label
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents DOCK_PANEL As BorderPanel

    Private Sub InitializeComponent()
        Me.DOCK_PANEL = New MYA.BorderPanel()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.SeguoUI_Label5 = New MYA.SeguoUI_Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.SeguoUI_Label12 = New MYA.SeguoUI_Label()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.SeguoUI_Label6 = New MYA.SeguoUI_Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.SeguoUI_Label7 = New MYA.SeguoUI_Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.SeguoUI_Label8 = New MYA.SeguoUI_Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.SeguoUI_Label3 = New MYA.SeguoUI_Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.SeguoUI_Label4 = New MYA.SeguoUI_Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.SeguoUI_Label2 = New MYA.SeguoUI_Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.SeguoUI_Label1 = New MYA.SeguoUI_Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PHONE_INFO_PANEL = New MYA.BorderPanel()
        Me.PHONE_BT_STATUS_LABEL = New MYA.SeguoUI_Label()
        Me.PHONE_NAME_LABEL = New MYA.SeguoUI_Label()
        Me.PHONE_INFO_PIC = New System.Windows.Forms.PictureBox()
        Me.DOCK_PANEL.SuspendLayout()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PHONE_INFO_PANEL.SuspendLayout()
        CType(Me.PHONE_INFO_PIC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DOCK_PANEL
        '
        Me.DOCK_PANEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.DOCK_PANEL.Controls.Add(Me.PictureBox20)
        Me.DOCK_PANEL.Controls.Add(Me.PictureBox19)
        Me.DOCK_PANEL.Controls.Add(Me.PictureBox18)
        Me.DOCK_PANEL.Controls.Add(Me.PictureBox17)
        Me.DOCK_PANEL.Controls.Add(Me.PictureBox16)
        Me.DOCK_PANEL.Controls.Add(Me.PictureBox15)
        Me.DOCK_PANEL.Controls.Add(Me.PictureBox13)
        Me.DOCK_PANEL.Controls.Add(Me.PictureBox12)
        Me.DOCK_PANEL.Controls.Add(Me.PictureBox11)
        Me.DOCK_PANEL.Controls.Add(Me.SeguoUI_Label5)
        Me.DOCK_PANEL.Controls.Add(Me.PictureBox7)
        Me.DOCK_PANEL.Controls.Add(Me.SeguoUI_Label12)
        Me.DOCK_PANEL.Controls.Add(Me.PictureBox14)
        Me.DOCK_PANEL.Controls.Add(Me.SeguoUI_Label6)
        Me.DOCK_PANEL.Controls.Add(Me.PictureBox8)
        Me.DOCK_PANEL.Controls.Add(Me.SeguoUI_Label7)
        Me.DOCK_PANEL.Controls.Add(Me.PictureBox9)
        Me.DOCK_PANEL.Controls.Add(Me.SeguoUI_Label8)
        Me.DOCK_PANEL.Controls.Add(Me.PictureBox10)
        Me.DOCK_PANEL.Controls.Add(Me.SeguoUI_Label3)
        Me.DOCK_PANEL.Controls.Add(Me.PictureBox5)
        Me.DOCK_PANEL.Controls.Add(Me.SeguoUI_Label4)
        Me.DOCK_PANEL.Controls.Add(Me.PictureBox6)
        Me.DOCK_PANEL.Controls.Add(Me.SeguoUI_Label2)
        Me.DOCK_PANEL.Controls.Add(Me.PictureBox4)
        Me.DOCK_PANEL.Controls.Add(Me.SeguoUI_Label1)
        Me.DOCK_PANEL.Controls.Add(Me.PictureBox3)
        Me.DOCK_PANEL.Controls.Add(Me.PHONE_INFO_PANEL)
        Me.DOCK_PANEL.Location = New System.Drawing.Point(0, 0)
        Me.DOCK_PANEL.Name = "DOCK_PANEL"
        Me.DOCK_PANEL.Size = New System.Drawing.Size(260, 560)
        Me.DOCK_PANEL.TabIndex = 0
        '
        'PictureBox20
        '
        Me.PictureBox20.Image = Global.MYA.My.Resources.Resources.NewWnd
        Me.PictureBox20.Location = New System.Drawing.Point(225, 321)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox20.TabIndex = 30
        Me.PictureBox20.TabStop = False
        '
        'PictureBox19
        '
        Me.PictureBox19.Image = Global.MYA.My.Resources.Resources.NewWnd
        Me.PictureBox19.Location = New System.Drawing.Point(225, 290)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox19.TabIndex = 29
        Me.PictureBox19.TabStop = False
        '
        'PictureBox18
        '
        Me.PictureBox18.Image = Global.MYA.My.Resources.Resources.NewWnd
        Me.PictureBox18.Location = New System.Drawing.Point(225, 260)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox18.TabIndex = 28
        Me.PictureBox18.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.Image = Global.MYA.My.Resources.Resources.NewWnd
        Me.PictureBox17.Location = New System.Drawing.Point(225, 229)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox17.TabIndex = 28
        Me.PictureBox17.TabStop = False
        '
        'PictureBox16
        '
        Me.PictureBox16.Image = Global.MYA.My.Resources.Resources.NewWnd
        Me.PictureBox16.Location = New System.Drawing.Point(225, 199)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 27
        Me.PictureBox16.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = Global.MYA.My.Resources.Resources.NewWnd
        Me.PictureBox15.Location = New System.Drawing.Point(225, 169)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 26
        Me.PictureBox15.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.MYA.My.Resources.Resources.NewWnd
        Me.PictureBox13.Location = New System.Drawing.Point(225, 139)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 25
        Me.PictureBox13.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.MYA.My.Resources.Resources.NewWnd
        Me.PictureBox12.Location = New System.Drawing.Point(225, 108)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 24
        Me.PictureBox12.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.MYA.My.Resources.Resources.NewWnd
        Me.PictureBox11.Location = New System.Drawing.Point(225, 78)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 23
        Me.PictureBox11.TabStop = False
        '
        'SeguoUI_Label5
        '
        Me.SeguoUI_Label5.AutoSize = True
        Me.SeguoUI_Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeguoUI_Label5.Location = New System.Drawing.Point(43, 293)
        Me.SeguoUI_Label5.Name = "SeguoUI_Label5"
        Me.SeguoUI_Label5.Size = New System.Drawing.Size(97, 15)
        Me.SeguoUI_Label5.TabIndex = 21
        Me.SeguoUI_Label5.Text = "Process manager"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.MYA.My.Resources.Resources.Process
        Me.PictureBox7.Location = New System.Drawing.Point(12, 290)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 22
        Me.PictureBox7.TabStop = False
        '
        'SeguoUI_Label12
        '
        Me.SeguoUI_Label12.AutoSize = True
        Me.SeguoUI_Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeguoUI_Label12.Location = New System.Drawing.Point(43, 324)
        Me.SeguoUI_Label12.Name = "SeguoUI_Label12"
        Me.SeguoUI_Label12.Size = New System.Drawing.Size(148, 15)
        Me.SeguoUI_Label12.TabIndex = 15
        Me.SeguoUI_Label12.Text = "Custom rom / Flash image"
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = Global.MYA.My.Resources.Resources.Update
        Me.PictureBox14.Location = New System.Drawing.Point(12, 321)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 16
        Me.PictureBox14.TabStop = False
        '
        'SeguoUI_Label6
        '
        Me.SeguoUI_Label6.AutoSize = True
        Me.SeguoUI_Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeguoUI_Label6.Location = New System.Drawing.Point(43, 263)
        Me.SeguoUI_Label6.Name = "SeguoUI_Label6"
        Me.SeguoUI_Label6.Size = New System.Drawing.Size(75, 15)
        Me.SeguoUI_Label6.TabIndex = 19
        Me.SeguoUI_Label6.Text = "Remote shell"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.MYA.My.Resources.Resources.Shell
        Me.PictureBox8.Location = New System.Drawing.Point(12, 260)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 20
        Me.PictureBox8.TabStop = False
        '
        'SeguoUI_Label7
        '
        Me.SeguoUI_Label7.AutoSize = True
        Me.SeguoUI_Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeguoUI_Label7.Location = New System.Drawing.Point(43, 232)
        Me.SeguoUI_Label7.Name = "SeguoUI_Label7"
        Me.SeguoUI_Label7.Size = New System.Drawing.Size(90, 15)
        Me.SeguoUI_Label7.TabIndex = 17
        Me.SeguoUI_Label7.Text = "Power manager"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.MYA.My.Resources.Resources.Power
        Me.PictureBox9.Location = New System.Drawing.Point(12, 229)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 18
        Me.PictureBox9.TabStop = False
        '
        'SeguoUI_Label8
        '
        Me.SeguoUI_Label8.AutoSize = True
        Me.SeguoUI_Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeguoUI_Label8.Location = New System.Drawing.Point(43, 202)
        Me.SeguoUI_Label8.Name = "SeguoUI_Label8"
        Me.SeguoUI_Label8.Size = New System.Drawing.Size(80, 15)
        Me.SeguoUI_Label8.TabIndex = 15
        Me.SeguoUI_Label8.Text = "Custom input"
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.MYA.My.Resources.Resources.Input
        Me.PictureBox10.Location = New System.Drawing.Point(12, 199)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 16
        Me.PictureBox10.TabStop = False
        '
        'SeguoUI_Label3
        '
        Me.SeguoUI_Label3.AutoSize = True
        Me.SeguoUI_Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeguoUI_Label3.Location = New System.Drawing.Point(43, 172)
        Me.SeguoUI_Label3.Name = "SeguoUI_Label3"
        Me.SeguoUI_Label3.Size = New System.Drawing.Size(79, 15)
        Me.SeguoUI_Label3.TabIndex = 13
        Me.SeguoUI_Label3.Text = "App manager"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.MYA.My.Resources.Resources.Apps
        Me.PictureBox5.Location = New System.Drawing.Point(12, 169)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        '
        'SeguoUI_Label4
        '
        Me.SeguoUI_Label4.AutoSize = True
        Me.SeguoUI_Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeguoUI_Label4.Location = New System.Drawing.Point(43, 142)
        Me.SeguoUI_Label4.Name = "SeguoUI_Label4"
        Me.SeguoUI_Label4.Size = New System.Drawing.Size(145, 15)
        Me.SeguoUI_Label4.TabIndex = 11
        Me.SeguoUI_Label4.Text = "Screenshot / Screenrecord"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.MYA.My.Resources.Resources.Camera
        Me.PictureBox6.Location = New System.Drawing.Point(12, 139)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 12
        Me.PictureBox6.TabStop = False
        '
        'SeguoUI_Label2
        '
        Me.SeguoUI_Label2.AutoSize = True
        Me.SeguoUI_Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeguoUI_Label2.Location = New System.Drawing.Point(43, 111)
        Me.SeguoUI_Label2.Name = "SeguoUI_Label2"
        Me.SeguoUI_Label2.Size = New System.Drawing.Size(75, 15)
        Me.SeguoUI_Label2.TabIndex = 9
        Me.SeguoUI_Label2.Text = "File manager"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.MYA.My.Resources.Resources.Folder
        Me.PictureBox4.Location = New System.Drawing.Point(12, 108)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'SeguoUI_Label1
        '
        Me.SeguoUI_Label1.AutoSize = True
        Me.SeguoUI_Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeguoUI_Label1.Location = New System.Drawing.Point(43, 81)
        Me.SeguoUI_Label1.Name = "SeguoUI_Label1"
        Me.SeguoUI_Label1.Size = New System.Drawing.Size(108, 15)
        Me.SeguoUI_Label1.TabIndex = 7
        Me.SeguoUI_Label1.Text = "Device Information"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.MYA.My.Resources.Resources.PhoneInfo
        Me.PictureBox3.Location = New System.Drawing.Point(12, 78)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PHONE_INFO_PANEL
        '
        Me.PHONE_INFO_PANEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PHONE_INFO_PANEL.Controls.Add(Me.PHONE_BT_STATUS_LABEL)
        Me.PHONE_INFO_PANEL.Controls.Add(Me.PHONE_NAME_LABEL)
        Me.PHONE_INFO_PANEL.Controls.Add(Me.PHONE_INFO_PIC)
        Me.PHONE_INFO_PANEL.Location = New System.Drawing.Point(0, 0)
        Me.PHONE_INFO_PANEL.Name = "PHONE_INFO_PANEL"
        Me.PHONE_INFO_PANEL.Size = New System.Drawing.Size(260, 60)
        Me.PHONE_INFO_PANEL.TabIndex = 4
        '
        'PHONE_BT_STATUS_LABEL
        '
        Me.PHONE_BT_STATUS_LABEL.AutoSize = True
        Me.PHONE_BT_STATUS_LABEL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHONE_BT_STATUS_LABEL.Location = New System.Drawing.Point(53, 34)
        Me.PHONE_BT_STATUS_LABEL.Name = "PHONE_BT_STATUS_LABEL"
        Me.PHONE_BT_STATUS_LABEL.Size = New System.Drawing.Size(101, 13)
        Me.PHONE_BT_STATUS_LABEL.TabIndex = 6
        Me.PHONE_BT_STATUS_LABEL.Text = "PHONE_BT_STATUS"
        '
        'PHONE_NAME_LABEL
        '
        Me.PHONE_NAME_LABEL.AutoSize = True
        Me.PHONE_NAME_LABEL.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHONE_NAME_LABEL.Location = New System.Drawing.Point(53, 12)
        Me.PHONE_NAME_LABEL.Name = "PHONE_NAME_LABEL"
        Me.PHONE_NAME_LABEL.Size = New System.Drawing.Size(96, 17)
        Me.PHONE_NAME_LABEL.TabIndex = 5
        Me.PHONE_NAME_LABEL.Text = "PHONE_NAME"
        '
        'PHONE_INFO_PIC
        '
        Me.PHONE_INFO_PIC.Image = Global.MYA.My.Resources.Resources.Phone
        Me.PHONE_INFO_PIC.Location = New System.Drawing.Point(12, 12)
        Me.PHONE_INFO_PIC.Name = "PHONE_INFO_PIC"
        Me.PHONE_INFO_PIC.Size = New System.Drawing.Size(35, 35)
        Me.PHONE_INFO_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PHONE_INFO_PIC.TabIndex = 4
        Me.PHONE_INFO_PIC.TabStop = False
        '
        'MasterWnd
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.Controls.Add(Me.DOCK_PANEL)
        Me.Name = "MasterWnd"
        Me.DOCK_PANEL.ResumeLayout(False)
        Me.DOCK_PANEL.PerformLayout()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PHONE_INFO_PANEL.ResumeLayout(False)
        Me.PHONE_INFO_PANEL.PerformLayout()
        CType(Me.PHONE_INFO_PIC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub OnMasterWndLoad() Handles MyBase.Load

        InitializeComponent()

        'PHONE_NAME, PHONE_BT
        PHONE_NAME_LABEL.Text = New adb_control.phoneinfo.build_prop().GetPhoneModel
        PHONE_BT_STATUS_LABEL.Text = "Battery " + New adb_control.phoneinfo.Hardware.Battery().RemainingBatteryByPercentage().ToString() _
           + "% Remaining."

    End Sub

End Class
