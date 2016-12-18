Namespace adb_control
    Namespace filemanager
        Namespace io_filesystem
            Public Class info
                'NOTE : file size calculation won't be exact at all.

                Public Function GetFileSize(ByVal file As String) As String

                    LOG_("GetFileSize() : " + file)

                    Dim adb_ As New ADB("shell du -hs -h " + file)
                    Dim Block As String = ""

                    adb_.Start()

                    While Not adb_.StandardOutput.EndOfStream

                        Dim raw As String = adb_.StandardOutput.ReadLine

                        If Not raw.Replace(" ", "").Replace(Chr(9), "") _
                            .Replace(vbCrLf, "").Length = 0 Then
                            Block = raw
                        End If

                    End While

                    Return Split(Block, Chr(9))(0)

                End Function


                Public Function GetFilePermissionByNum(ByVal file As String) As Integer

                    LOG_("GetFilePermissionByNum() : " + file)

                    Dim adb_ As New ADB("shell stat " + file)
                    Dim Block As String = ""

                    adb_.Start()

                    While Not adb_.StandardOutput.EndOfStream

                        Dim raw As String = adb_.StandardOutput.ReadLine

                        If raw.Contains("Access: ") Then
                            Return Split(Split(raw, "(")(1), "/")(0)
                        End If

                    End While

                    Return Nothing

                End Function


                Public Function GetFilePermissionByString(ByVal file As String) As String

                    LOG_("GetFilePermissionByString() : " + file)

                    Dim adb_ As New ADB("shell stat " + file)
                    Dim Count As Integer = 0

                    adb_.Start()

                    While Not adb_.StandardOutput.EndOfStream

                        Dim raw As String = adb_.StandardOutput.ReadLine

                        If raw.Contains("Access: ") Then

                            If Count = 1 Then
                                Return Split(Split(raw, "(")(1), "/")(0)
                            Else
                                Count += 1
                            End If

                        End If

                    End While

                    Return Nothing

                End Function

                Public Function GetElementType(ByVal file As String)

                    LOG_("GetElementType() : " + file)
                    If file.Replace("/", "").Length = 0 Then
                        Return EXPLORER_CONTENT_TYPE.Directory
                    End If

                    Dim adb_ As New ADB("shell stat " + file)
                    adb_.Start()

                    While Not adb_.StandardOutput.EndOfStream

                        Dim raw As String = adb_.StandardOutput.ReadLine

                        If raw.Contains("Size:") Then

                            Select Case True

                                Case raw.Contains("directory")

                                    LOG_(file + " : directory")
                                    Return EXPLORER_CONTENT_TYPE.Directory

                                Case raw.Contains("file")

                                    LOG_(file + " : file")
                                    Return EXPLORER_CONTENT_TYPE.File

                                Case raw.Contains("link")

                                    LOG_(file + " : link")
                                    Return EXPLORER_CONTENT_TYPE.Link

                            End Select

                        End If

                    End While

                    LOG_(file + " : none of all")
                    Return EXPLORER_CONTENT_TYPE.None

                End Function
            End Class
        End Namespace
    End Namespace
End Namespace
