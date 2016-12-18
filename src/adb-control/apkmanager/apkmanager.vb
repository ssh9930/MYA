Imports Microsoft.VisualBasic.FileIO.FileSystem
Namespace adb_control
    Public Class apkmanager


        Public adb_ As New ADB()


        Public Function InstallAPK(apk_path As String) As String
            'Returns SUCCESS when success
            'Returns *reason* when failed

            If Not FileExists(apk_path) Then
                Return apk_path + " is not a correct path."
            End If

            Dim Raw As String = adb_.ADBExecute("install " + Chr(34) + apk_path + Chr(34))

            If Raw.Contains("Failure") And Raw.Contains("[") And Raw.Contains("]") Then
                Return Split(Split(Raw, "[")(1), "]")(0)
            ElseIf Raw.Contains("Success") Then
                Return "SUCCESS"
            Else
                Return "unknown error"
            End If

        End Function


        Public Function UninstallAPK(apk_package_name As String, Optional SaveAppCache As Boolean = False) As String
            'Returns SUCCESS when success
            'Returns FAILURE=*reason* when failed

            Dim AdditionalCommandLine As String = ""

            If SaveAppCache Then
                AdditionalCommandLine = "-k"
            End If

            Dim Raw As String = adb_.ADBExecute("uninstall " + AdditionalCommandLine + AddColumnEachSide(apk_package_name))
            If Raw.Contains("Failure") And Raw.Contains("[") And Raw.Contains("]") Then
                Return Split(Split(Raw, "[")(1), "]")(0)
            ElseIf Raw.Contains("Success") Then
                Return "SUCCESS"
            Else
                Return "unknown error"
            End If

        End Function


        Public Function GetAPKlist() As Array

            Dim APKcount As Integer = 0
            Dim APKlist(APKcount) As String
            adb_.ADBExecute("shell pm list packages", False, True)

            While Not adb_.StandardOutput.EndOfStream

                Dim ThisLine As String = adb_.StandardOutput.ReadLine

                If Not ThisLine = vbNullString And ThisLine.Contains("package:") Then

                    APKcount += 1
                    ReDim Preserve APKlist(APKcount)
                    APKlist(APKcount) = Split(ThisLine, "package:")(1)

                End If

            End While

            Return APKlist

        End Function

    End Class
End Namespace