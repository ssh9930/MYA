Public Class ADB : Inherits Process


    Public ReadOnly ADB_exe As String = "adb.exe"
    Public ReadOnly ADB_usb As String = "AdbWinUsbApi.dll"
    Public ReadOnly ADB_win As String = "AdbWinApi.dll"


    Public ReadOnly Property ADBPath() As String
        Get
            Return My.Settings.ADBpath
        End Get
    End Property


    Sub New(Optional args As String = "")

        With Me.StartInfo
            .FileName = ADBPath + "/" + ADB_exe
            .Arguments = args
            .UseShellExecute = False
            .CreateNoWindow = True
            .RedirectStandardError = True
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
            .StandardOutputEncoding = System.Text.Encoding.UTF8
            .StandardErrorEncoding = System.Text.Encoding.UTF8

        End With

    End Sub

    Public Function ADBExecute(command As String, Optional DisableSecureMethmods As Boolean = False,
                               Optional ReturnNoData As Boolean = False, Optional BypassADBSafeLock As Boolean = False) As String


        LOG_("ADBExecute() Started, command : " + command + ", DisableSecureMethmods: " _
                    + DisableSecureMethmods.ToString + ", ReturnNoData : " + ReturnNoData.ToString)
        If Not ADB_Safelock And Not BypassADBSafeLock Then

            If Not DisableSecureMethmods Then

                If command.Contains(";") Or command.Contains("|") Or command.Contains("&") Then

                    'For secure, must set DisableSecureMethmods to false when you put custom input. 
                    Return Nothing

                End If

            End If


            Me.StartInfo.Arguments = command
            Me.Start()


            If Not ReturnNoData Then

                Dim output As String = Me.StandardOutput.ReadToEnd

                If Not output.Contains("* daemon Not running. starting it now on port") Then

                    LOG_("Result : " + output)
                    Return output

                End If

            End If

        End If

        LOG_("ADB-safelock : " + ADB_Safelock.ToString)
        Return Nothing
    End Function

    Public Function IsPhoneConnected() As Boolean

        If New System.Text.RegularExpressions.Regex("^error:").IsMatch(New ADB().ADBExecute("shell echo MYA connection test", 1)) = True Then
            Return False
        Else
            Return True
        End If

    End Function


End Class
