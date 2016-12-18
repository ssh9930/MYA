Namespace adb_control
    Public Class inputmanager

        Private Const KEYCODE_TEXT As String = "KEYCODE"


        Private adb_ As New ADB()

        'TOUCH FEATURE IS IN DEVELOPMENT!

        Public Sub Touch(point As Point, pressure As Integer, Optional MinFingerSize As Integer = 5, Optional MaxFingerSize As Integer = 50)

            Dim adb_ As New ADB()

            adb_.ADBExecute("shell " + AddColumnEachSide("sendevent /dev/input/event0 3 53 " + point.X.ToString), False, True = 0)
            adb_.ADBExecute("shell " + AddColumnEachSide("sendevent /dev/input/event0 3 54 " + point.Y.ToString), False, True = 0)
            adb_.ADBExecute("shell " + AddColumnEachSide("sendevent /dev/input/event0 3 58 " + pressure.ToString), False, True = 0)
        End Sub


        Public Sub Release()

            Dim adb_ As New ADB()

            adb_.ADBExecute("shell " + AddColumnEachSide("sendevent /dev/input/event0 3 57 0"), False, True)
            adb_.ADBExecute("shell " + AddColumnEachSide("sendevent /dev/input/event0 0 0 0"), False, True)

        End Sub
    End Class
End Namespace
