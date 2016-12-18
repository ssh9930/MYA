Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports MYA.ADB

Public Class Startup


    Public Sub StartUp()
      

        Dim LaunchStr As String = "MYA launched : " + DateTime.Now
        Dim DecoText As String = ""

        For Each i In LaunchStr : DecoText += "*" : Next
        LOG_(vbCrLf + DecoText + vbCrLf + LaunchStr + vbCrLf + DecoText + vbCrLf)
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

    End Sub

    Private Function ChkADBFiles(path As String) As Boolean

        Dim UsbApiExistance As Boolean = FileExists(path + "/" + My.Settings.ADB_usb) _
            And FileExists(My.Settings.ADBpath + "/" + My.Settings.ADB_win)

        Dim ADBExistance As Boolean = FileExists(path + "/" + My.Settings.ADB_exe)
        LOG_("ADB chk result : " + (UsbApiExistance And ADBExistance).ToString)

        Return UsbApiExistance And ADBExistance
    End Function


    Private Function ChkFBFiles(path As String) As Boolean

        Dim UsbApiExistance As Boolean = FileExists(path + "/" + My.Settings.ADB_usb) _
            And FileExists(My.Settings.ADBpath + "/" + My.Settings.ADB_win)

        Dim FBExistance As Boolean = FileExists(path + "/" + My.Settings.FB_exe)
        LOG_("Fastbook chk result : " + (UsbApiExistance And FBExistance).ToString)

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

        Dim ADBTester As New ADB
        Dim Raw As String = ADBTester.ADBExecute("shell ;", 1)

        Select Case True

            Case Raw.Contains("error: device unauthorized. Please check the confirmation dialog on your device.")
                'warn: this is temporary code for check device status.
                'TODO: finish this code
                MsgBox("Device unauthorized. please check the confimation dialog on your device.",
                       vbInformation, "Confirmtion error")
                ADB_Safelock = True
                End

            Case Raw.Contains("error: device not found") Or
                    Raw.Contains("error: protocol")
                'warn: this is temporary code for check device status.
                'TODO: finish this code
                MsgBox("Device not found. check your device connected to the computer." _
                     , vbCritical, "Device not found")
                ADB_Safelock = True
                End

        End Select


        ''''''''''''''''''''''''''''''''''''''''''''''''
        'warn: this is temporary code for test codes.
        Dim aa As New OpenFileDialog
        Dim a As New adb_control.filemanager.io_filesystem.List
        LOG_(a.GetFiles("/d")(2))
        '''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''

    End Sub
End Class
