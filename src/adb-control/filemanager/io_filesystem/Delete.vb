Namespace adb_control
    Namespace filemanager
        Namespace io_filesystem
            Public Class delete

                Private adb_ As New ADB



                Public Function DeleteFile(file As String) As Boolean

                    If Not New adb_control.filemanager.io_filesystem.info().GetElementType(file) = EXPLORER_CONTENT_TYPE.File Then
                        Return False
                    End If

                    If adb_.ADBExecute("shell rm " + AddColumnEachSide(file)).Replace(" ", "").Replace(Chr(9), "").Replace(vbCrLf, "").Length = 0 Then
                        Return True
                    Else
                        Return False
                    End If

                End Function


                Public Function DeleteDirectory(dir As String, Optional CheckDirectoryNonEmpty As Boolean = False) As Boolean

                    Dim RMargs As String = "-rf"

                    If Not New adb_control.filemanager.io_filesystem.info().GetElementType(dir) = EXPLORER_CONTENT_TYPE.Directory Then
                        Return False
                    End If

                    If CheckDirectoryNonEmpty Then
                        RMargs = ""
                    End If

                    If adb_.ADBExecute("shell rm " + RMargs + " " + AddColumnEachSide(dir)).Replace(" ", "").Replace(Chr(9), "").Replace(vbCrLf, "").Length = 0 Then
                        Return True
                    Else
                        Return False
                    End If

                End Function

            End Class
        End Namespace
    End Namespace
End Namespace
