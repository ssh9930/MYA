Namespace adb_control
    Public Class powermanager

        Private adb_ As New ADB()

        Enum RebootMode
            System
            Bootloader
            Recovery
        End Enum


        Public Sub PowerOff()
            adb_.ADBExecute("shell reboot -p")
        End Sub


        Public Sub Reboot(RebootAs As RebootMode)

            Select Case RebootAs

                Case RebootMode.System
                    adb_.ADBExecute("reboot")

                Case RebootMode.Bootloader
                    adb_.ADBExecute("reboot bootloader")

                Case RebootMode.Recovery
                    adb_.ADBExecute("reboot recovery")

            End Select

        End Sub


        Public Sub Restart()
            'restarting systemui
            adb_.ADBExecute("restart")
        End Sub
    End Class
End Namespace
