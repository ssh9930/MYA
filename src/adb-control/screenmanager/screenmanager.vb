Namespace adb_control
    Namespace screenmanager

        Class screenshot

            Private adb_ As New ADB()

            Public Function GetPhoneScreen(Optional PhoneImagePath As String = "/sdcard/.myascrsht.tmpa", Optional DeletePhoneImage As Boolean = 0) As Image
                'MUST CLEAN TMP AFTER RUNNING THIS

                CleanTMPfolder()

                Dim PCPath As String = MYA_tmppath + "\.myascrsht.tmp"

                Dim adb_ As New ADB()
                adb_.ADBExecute("shell screencap -p " + AddColumnEachSide(PhoneImagePath))

                Dim Pull As New adb_control.filemanager.io_sync.ADBpull()
                Pull.ADBPull(PhoneImagePath, PCPath)

                If DeletePhoneImage Then
                    adb_.ADBExecute("rm " + AddColumnEachSide(PhoneImagePath))
                End If

                Return Image.FromFile(PCPath)

            End Function
        End Class

        Class screenrecord

            'only supports device that is higher than 4.4.2
            'WARN: radicaly causes video courruption problem. may seems to be a adb kill problem.

            Private Phonepath__ As String = ""

            Private adb_ As New ADB()

            Public Sub RecordScreen(ByVal PhonePath As String, ByVal DeleteSavedVidOnPhone As Boolean,
                                    ByVal RecordingMiliSec As Integer, Optional SaveFile As String = "")

                Dim IOpull As New adb_control.filemanager.io_sync.ADBpull
                Dim IOpush As New adb_control.filemanager.io_sync.ADBpush
                Dim Recorder As New Threading.Thread(AddressOf ScreenRecord__)
                Dim RestartADB As New Startup

                Phonepath__ = PhonePath
                Recorder.Start()
                System.Threading.Thread.Sleep(RecordingMiliSec)

                If Not adb_.HasExited Then
                    adb_.Kill()
                End If

                Recorder.Abort()
                IOpull.ADBPull(PhonePath, SaveFile)

                If DeleteSavedVidOnPhone Then
                    adb_.ADBExecute("shell rm " + AddColumnEachSide(Phonepath__))
                End If
            End Sub


            Private Sub ScreenRecord__()
                adb_.ADBExecute("shell screenrecord " + AddColumnEachSide(Phonepath__))
            End Sub
        End Class

        Class ScreenInfo

            Private adb_ As New ADB()

            'WARN: may not suppport multi-screen.

            Private Function RawDisplayDumpData() As String

                Try

                    'WATN: only support android 5.0 or higher

                    Return Split(Split(adb_.ADBExecute("shell dumpsys display | grep supportedModes", True), "supportedModes")(1), "}]")(0).Replace("[{", "")
                Catch ex As ArgumentOutOfRangeException

                    Return Split(Split(adb_.ADBExecute("shell dumpsys display | grep DisplayInfo", True), "DisplayInfo")(1), "}]")(0).Replace("[{", "")
                End Try

            End Function


            Public Function ScreenWidth() As Integer
                Return CInt(Split(Split(RawDisplayDumpData, "width=")(1), ",")(0))
            End Function


            Public Function ScreenHeight() As Integer
                Return CInt(Split(Split(RawDisplayDumpData, "height=")(1), ",")(0))
            End Function


            Public Function ScreenFPS() As Integer
                Return CInt(Split(Split(RawDisplayDumpData, "fps=")(1), ",")(0))
            End Function


            Public Function ScreenDPI() As Integer
                'WATN: only support android 5.0 or higher
                Return CInt(New adb_control.phoneinfo.build_prop().GetProp("ro.sf.lcd_density"))
            End Function


            Public Function ScreenResoultion() As Point
                Return New Point(ScreenWidth(), ScreenHeight())
            End Function

        End Class
    End Namespace
End Namespace
