Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports MYA.ADB

Public Class Startup


    Public Sub StartUp()
        'warn: temporary code
        '
        '░░░░░░░░░░░░░▄███▄▄▄░░░░░░░
        '░░░░░░░░░▄▄▄██▀▀▀▀███▄░░░░░ 
        '░░░░░░░▄▀▀░░░░░░░░░░░▀█░░░░
        '░░░░▄▄▀░░░░░░░░░░░░░░░▀█░░░
        '░░░█░░░░░▀▄░░▄▀░░░░░░░░█░░░
        '░░░▐██▄░░▀▄▀▀▄▀░░▄██▀░▐▌░░░
        '░░░█▀█░▀░░░▀▀░░░▀░█▀░░▐▌░░░
        '░░░█MYA EASTER!░▌▀░░░░░█░░░
        '░░░█░░░░░░░░░░░░░░░░░░░█░░░
        '░░░░█░░▀▄░░░░▄▀░░░░░░░░█░░░
        '░░░░█░░░░░░░░░░░▄▄░░░░█░░░░
        '░░░░░█▀██▀▀▀▀██▀░░░░░░█░░░░
        '░░░░░█░░▀████▀░░░░░░░█░░░░░
        '░░░░░░█░░░░░░░░░░░░▄█░░░░░░
        '░░░░░░░██░░░░░█▄▄▀▀░█░░░░░░
        '░░░░░░░░▀▀█▀▀▀▀░░░░░░█░░░░░
        '░░░░░░░░░█░░░░░░░░░░░░█░░░░

        Dim LaunchStr As String = "MYA launched : " + DateTime.Now
        Dim DecoText As String = ""

        For Each i In LaunchStr : DecoText += "*" : Next
        LOG_(vbCrLf + DecoText + vbCrLf + LaunchStr + vbCrLf + DecoText + vbCrLf)

        'set ApliicationcationExecuted
        LOG_("ApliicationcationExecuted = True")
        ApplicationExecuted = True

        'check files
        LOG_("FileCheck start")

        If ChkFiles() Then
        Else
            LOG_("FileCheck failed, terminating")
            MsgBox("Not enough to run MYA: files missing.") : End
            'TODO: make pathsettings
        End If
        LOG_("Testing adb and fastboot status")
        TestProcess()

        'Finished.
        'MYA Successfuly launched.
        LOG_("MYALaunched = True")
        MYALaunched = True

    End Sub

    Private Function ChkADBFiles(path As String) As Boolean

        Dim UsbApiExistance As Boolean = FileExists(path + "/" + My.Settings.ADB_usb) _
            And FileExists(path + "/" + My.Settings.ADB_win)

        Dim ADBExistance As Boolean = FileExists(path + "/" + My.Settings.ADB_exe)
        LOG_("ADB chk result (" + path + ") : " + (UsbApiExistance And ADBExistance).ToString)

        Return UsbApiExistance And ADBExistance
    End Function


    Private Function ChkFBFiles(path As String) As Boolean

        Dim UsbApiExistance As Boolean = FileExists(path + "/" + My.Settings.ADB_usb) _
            And FileExists(My.Settings.ADBpath + "/" + My.Settings.ADB_win)

        Dim FBExistance As Boolean = FileExists(path + "/" + My.Settings.FB_exe)
        LOG_("Fastbook chk result (" + path + ") : " + (UsbApiExistance And FBExistance).ToString)

        Return FBExistance And UsbApiExistance
    End Function


    Public Function ChkFiles() As Boolean

        If Not ChkADBFiles(My.Settings.ADBpath) Then

            If ChkADBFiles(MYAStartupPath) Then
                My.Settings.ADBpath = MYAStartupPath
                My.Settings.Save()
            Else
                ADB_Safelock = True
            End If
        End If

        If Not ChkFBFiles(My.Settings.FBPath) Then

            If ChkADBFiles(MYAStartupPath) Then
                My.Settings.FBPath = MYAStartupPath
                My.Settings.Save()
            Else
                FB_Safelock = True
            End If
        End If

        If Not DirectoryExists(MYA_tmppath) Then
            'makes tmpdir (used to save tmp images, etc)
            MkDir(MYA_tmppath)
        End If

        Return False = ADB_Safelock
    End Function
    Public Sub TestProcess()

Retry:

        'TODO: multi device support

        Dim ADBTester As New ADB
        Dim Raw As String = ADBTester.ADBExecute("devices")
        Dim DeviceStatus As String = Mid(Raw, Raw.LastIndexOf(" "))

        Select Case True

            Case DeviceStatus = ("unauthorized")

                'warn: this is temporary code for check device status.
                'TODO: finish this code

                If MessageBox.Show("Device unauthorized. please check the confimation dialog on your device.", "Device unauthorized",
                                MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) = vbRetry Then

                    GoTo Retry

                End If

                ADB_Safelock = True
                End
                'daemon not running. starting it now

            Case DeviceStatus.Replace(" ", "").Replace(vbCrLf, "") = "d"


                'warn: this is temporary code for cstatus.
                'TODO: finish this code   heck your device connected to the computer." _
                ', vbCritical, "Device not found")

                If MessageBox.Show("Device not found. Check Your device connected to computer properly.", "Device not found",
                                MessageBoxButtons.RetryCancel, MessageBoxIcon.Error
                                ) = vbRetry Then

                    GoTo Retry

                End If

                ADB_Safelock = True
                End


        End Select
        'warn: this is temporary code for test codes.
        'MsgBox("start!")

        'Dim aa As New adb_control.screenmanager.screenrecord
        'aa.RecordScreen("/sdcard/.a.vid", True, 10000, "c:\users\ssh99\desktop\a.mp4")
        'a.StartProcess("bootanimation")
        'LOG_(af.GetFiles("/storage/emulated/0")(0))
        '''''''''''''''''''''''''''''''''''''''''''''''
        '3 47 0
        '3 57 0
        '3 53 898
        '3 54 1994
        '3 58 38
        '3 50 5
        '3 51 4
        '0 0 0
        '3 57 4294967295
        '0 0 0
        '''''''''''''''''''''''''''''''''''''''''''''''

    End Sub
End Class
