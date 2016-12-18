Namespace adb_control
    Namespace filemanager
        Namespace io_filesystem
            Public Class make

                Private adb_ As New ADB()

                Public Sub MakeFile(file As String, Optional FileText As String = "")

                    adb_.ADBExecute("shell " + AddColumnEachSide("echo " + FileText + ">" + AddColumnEachSide(file)))

                End Sub


                Public Sub MakeDirectory(file As String, Optional FileText As String = "")

                    adb_.ADBExecute("shell " + AddColumnEachSide("mkdir " + AddColumnEachSide(file)))

                End Sub

            End Class
        End Namespace
    End Namespace
End Namespace
