Namespace adb_control
    Namespace filemanager
        Namespace io_filesystem
            Public Class rename

                Private adb_ As New ADB()



                Public Function RenameContent(ContentName As String, RenameName As String) As Boolean

                    If adb_.ADBExecute("shell " + AddColumnEachSide("rename " + AddColumnEachSide(ContentName) + " " + AddColumnEachSide(RenameName))).ToString _
                        .Replace(" ", "").Replace(Chr(9), "").Replace(vbCrLf, "") Then

                        Return True

                    Else

                        Return False

                    End If

                End Function


            End Class
        End Namespace
    End Namespace
End Namespace
