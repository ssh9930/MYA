Imports System.Threading

Public Class MasterWnd

    Private MainPanel As ContentPanel


    Private Sub OnMasterWndLoad() Handles Me.Load


    End Sub


    Private Sub SetMasterWndLayout() Handles MyBase.SizeChanged

        DOCK_PANEL.Size = New Point(DOCK_PANEL.Width, Me.Height + 20)

    End Sub


    Public Sub SetMainPanel(TargetPanel As ContentPanel)

        'RESET MAINPANEL
        MainPanel.Hide()
        MainPanel.Dispose()

        Dim Target As ContentPanel = TargetPanel

        Target.Location = New Point(DOCK_PANEL.Width, 0)
        Target.Size = New Point(Me.Width - DOCK_PANEL.Width, Me.Height)
        Target.MasterWindow = Me

        MainPanel = Target
        Me.Controls.Add(MainPanel)

    End Sub



#Region "DesignerSetting"

    'Delegate for designer loading thread
    Private Delegate Sub DesignerLoadDeleate()


    Private Sub MainBtnDrawTemplete(g As Graphics, BtnImage As Image,
                                BtnString As String, Optional Selected As Boolean = False)

        g.DrawImage(BtnImage, 10, 12, 25, 25)
        g.DrawString(BtnString,
                              New System.Drawing.Font(DefaultMYAFontName, 9.0!, System.Drawing.FontStyle.Bold,
                                                      System.Drawing.GraphicsUnit.Point, CType(0, Byte)) _
                                                      , Brushes.Black, 40, 8)


    End Sub



    Private Sub BtnSubStrDrawTemplete(g As Graphics, BtnSubString As String, Optional Selected As Boolean = False)

        g.DrawString(BtnSubString,
                   New System.Drawing.Font(DefaultMYAFontName, 8.0!, System.Drawing.FontStyle.Regular,
                                           System.Drawing.GraphicsUnit.Point, CType(0, Byte)) _
                                           , Brushes.DimGray, 40, 25)

    End Sub



    Private Sub InfoPanelDrawTemplete(g As Graphics, MainStr As String, SubStr As String)

        g.DrawString(MainStr,
                       New System.Drawing.Font(DefaultMYAFontName, 10.0!, System.Drawing.FontStyle.Bold,
                                               System.Drawing.GraphicsUnit.Point, CType(0, Byte)) _
                                               , Brushes.Black, 48, 13)

        g.DrawString(SubStr,
                    New System.Drawing.Font(DefaultMYAFontName, 8.0!, System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point, CType(0, Byte)) _
                                                , Brushes.DimGray, 48, 32)

    End Sub



    ''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''

    Sub MASTER_WND_PAINT(sender As Object, e As PaintEventArgs) Handles Me.Paint

        PHONE_INFO_BTN.EnableBorder = False
        FILE_MGR_BTN.EnableBorder = False
        RMT_SHL_BTN.EnableBorder = False
        INP_MGR_BTN.EnableBorder = False
        UPGRADE_BTN.EnableBorder = False
        POWER_BTN.EnableBorder = False
        APPS_BTN.EnableBorder = False
        SRC_REC_BTN.EnableBorder = False
        PRC_BTN.EnableBorder = False


    End Sub

    Private Sub PHONE_INFO_PANEL_PAINT(sender As Object, e As PaintEventArgs) Handles PHONE_INFO_PANEL.Paint

        Dim g As Graphics = sender.CreateGraphics
        Dim MainStr As String = "Loading"
        Dim SubStr As String = ""

        g.DrawImage(My.Resources.Phone, 12, 12, 35, 35)
        ' InfoPanelDrawTemplete(g, MainStr, SubStr)
        'e.Graphics.Clear(sender.BackColor)

        Task.Factory.StartNew(Sub()

                                  MainStr = New adb_control.phoneinfo.build_prop().GetPhoneModel
                                  SubStr = "Battery " + New adb_control.phoneinfo.Hardware.Battery().RemainingBatteryByPercentage().ToString _
                                                         + "% remaining."

                                  sender.Invoke(New DesignerLoadDeleate(Sub()

                                                                            g.FillRectangle(New SolidBrush(CType(sender.BackColor, Color)) _
                                                                                            , 0, 0, sender.Width, sender.Height)

                                                                            g.DrawImage(My.Resources.Phone, 12, 12, 35, 35)
                                                                            InfoPanelDrawTemplete(g, MainStr, SubStr)

                                                                        End Sub))
                              End Sub)

        Exit Sub

    End Sub




    ''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''

    Private PHONE_INFO_BTN_SUBSTR As String = ""
    Private FILE_MGR_BTN_SUBSTR As String = ""
    Private RMT_SHL_BTN_SUBSTR As String = ""
    Private INP_MGR_BTN_SUBSTR As String = ""
    Private UPGRADE_BTN_SUBSTR As String = ""
    Private POWER_BTN_SUBSTR As String = ""
    Private APPS_BTN_SUBSTR As String = ""
    Private SRC_REC_BTN_SUBSTR As String = ""
    Private PRC_BTN_SUBSTR As String = ""

    Private Sub DOCK_PANEL_BTN_PAINT(sender As Object, e As PaintEventArgs) Handles PHONE_INFO_BTN.Paint,
                                                                                    FILE_MGR_BTN.Paint,
                                                                                    RMT_SHL_BTN.Paint,
                                                                                    INP_MGR_BTN.Paint,
                                                                                    UPGRADE_BTN.Paint,
                                                                                    POWER_BTN.Paint,
                                                                                    SRC_REC_BTN.Paint,
                                                                                    APPS_BTN.Paint,
                                                                                    PRC_BTN.Paint



        Dim g As Graphics = sender.CreateGraphics

        Dim MainStr As String = ""
        Dim SubStr As String = ""
        Dim MainPic As Image = Nothing

        Task.Factory.StartNew(Sub()

                                  Select Case True

                                      Case sender.Name = "PHONE_INFO_BTN"

                                          SubStr = PHONE_INFO_BTN_SUBSTR

                                          MainStr = "Device Manager"
                                          MainPic = My.Resources.PhoneInfo

                                          If SubStr = vbNullString Then

                                              SubStr = "Running on Android version " + New adb_control.phoneinfo.build_prop().GetPhoneAndroidVersion
                                              PHONE_INFO_BTN_SUBSTR = SubStr

                                          End If

                                      Case sender.Name = "FILE_MGR_BTN"

                                          SubStr = FILE_MGR_BTN_SUBSTR

                                          MainStr = "File Manager"
                                          MainPic = My.Resources.Folder

                                          If SubStr = vbNullString Then

                                              SubStr = "Storage lib is STILL W.I.P.."
                                              FILE_MGR_BTN_SUBSTR = SubStr

                                          End If

                                      Case sender.Name = "INP_MGR_BTN"

                                          SubStr = INP_MGR_BTN_SUBSTR

                                          MainStr = "Input Manager
"
                                          MainPic = My.Resources.Input

                                          If SubStr = vbNullString Then

                                              SubStr = "Manage device's screen, hardware keys, etc."
                                              INP_MGR_BTN_SUBSTR = SubStr

                                          End If

                                      Case sender.Name = "RMT_SHL_BTN"

                                          SubStr = RMT_SHL_BTN_SUBSTR

                                          MainStr = "Remote Shell"
                                          MainPic = My.Resources.Shell

                                          If SubStr = vbNullString Then

                                              SubStr = "Remote " + New adb_control.phoneinfo.build_prop().GetPhoneName + "'s internal shell."
                                              RMT_SHL_BTN_SUBSTR = SubStr

                                          End If

                                      Case sender.Name = "UPGRADE_BTN"

                                          SubStr = UPGRADE_BTN_SUBSTR

                                          MainStr = "Upgrade device"
                                          MainPic = My.Resources.Update

                                          If SubStr = vbNullString Then

                                              SubStr = "Sideload, fastboot flashing."
                                              UPGRADE_BTN_SUBSTR = SubStr

                                          End If

                                      Case sender.Name = "POWER_BTN"

                                          SubStr = POWER_BTN_SUBSTR

                                          MainStr = "Power Manager"
                                          MainPic = My.Resources.Power

                                          If SubStr = vbNullString Then

                                              SubStr = "Shutdown, reboot, etc."
                                              POWER_BTN_SUBSTR = SubStr

                                          End If

                                      Case sender.Name = "SRC_REC_BTN"

                                          SubStr = SRC_REC_BTN_SUBSTR

                                          MainStr = "Screen Manager"
                                          MainPic = My.Resources.Camera

                                          If SubStr = vbNullString Then

                                              SubStr = "Running on " + New adb_control.screenmanager.ScreenInfo().ScreenWidth().ToString + "x" +
                                              New adb_control.screenmanager.ScreenInfo().ScreenHeight().ToString + " resolution."
                                              SRC_REC_BTN_SUBSTR = SubStr

                                          End If

                                      Case sender.Name = "APPS_BTN"

                                          SubStr = APPS_BTN_SUBSTR

                                          MainStr = "Application Manager"
                                          MainPic = My.Resources.Apps

                                          If SubStr = vbNullString Then

                                              SubStr = New adb_control.apkmanager().GetAPKlist().Length.ToString + " application installed"
                                              APPS_BTN_SUBSTR = SubStr

                                          End If

                                      Case sender.Name = "PRC_BTN"

                                          SubStr = PRC_BTN_SUBSTR

                                          MainStr = "Process Manager"
                                          MainPic = My.Resources.Process

                                          If SubStr = vbNullString Then

                                              SubStr = "프로세스매니저 정비 후 구현 예정"
                                              PRC_BTN_SUBSTR = SubStr

                                          End If

                                      Case Else

                                          LOG_("DOCK_PANEL_BTN_PAINT() : sender is not on the list!! what happened??")
                                          Exit Sub




                                  End Select

                                  'PREVENTS STRING GOES DOWN
                                  SubStr = SubStr.Replace(vbCrLf, " ")

                                  sender.Invoke(New DesignerLoadDeleate(Sub()

                                                                            ' g.FillRectangle(New SolidBrush(CType(sender.BackColor, Color)) _
                                                                            '            , 0, 0, sender.Width, sender.Height)

                                                                            '
                                                                            MainBtnDrawTemplete(g, MainPic, MainStr)
                                                                            BtnSubStrDrawTemplete(g, SubStr)


                                                                        End Sub))
                              End Sub)


    End Sub




    '  Private Sub DOCK_PANEL_BTN_CLICK(sender As Object, e As EventArgs) Handles BorderButton3




#End Region



End Class