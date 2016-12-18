Public Class Fastboot : Inherits Process

    Public ReadOnly FB_exe As String = "fastboot.exe"


    Public ReadOnly Property FBath() As String
        Get
            Return My.Settings.FBPath
        End Get
    End Property


    Sub New(Optional args As String = "")

        With Me.StartInfo
            .FileName = My.Settings.FBPath + "/" + My.Settings.FB_exe
            .Arguments = args
            .UseShellExecute = False
            .CreateNoWindow = True
            .RedirectStandardError = True
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
        End With

    End Sub


    Public Function FBExecute(command As String, Optional DisableSecureMethmods As Boolean = False, Optional ReturnNoData As Boolean = False _
                             , Optional BypassFBSafeLock As Boolean = False) As String

        If Not ADB_Safelock And Not BypassFBSafeLock Then

            If Not DisableSecureMethmods Then
                If command.Contains(";") Or command.Contains("|") Or command.Contains("&") Then
                    'For secure, must set DisableSecureMethmods to false when you put custom input. 
                    Return Nothing
                End If
            End If

            Me.Start()

            If Not ReturnNoData Then
                Dim output As String = Me.StandardError.ReadToEnd + Me.StandardOutput.ReadToEnd
                'From now, we don't know what is the fastboot error output.
                'If Not output.Contains("★") Then 
                Return output
                ' End If
            End If
        End If
        Return Nothing
    End Function

End Class
