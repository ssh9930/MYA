Namespace adb_control
    Namespace filemanager
        Namespace io_filesystem
            Public Class List

                'some codes are based on last MYA's code.

                Private adb_ As New ADB()

                Public Function GetFiles(directory As String) As Array

                    Return GetContent(directory, "^-")

                End Function

                Public Function GetDirectories(directory As String) As Array

                    Return GetContent(directory, "^d")

                End Function

                Public Function GetLinks(directory As String) As Array

                    Return GetContent(directory, "^l")

                End Function



                Private Function GetContent(directory As String, grepstring As String) As Array

                    Dim Raw As String = adb_.ADBExecute("shell " + AddColumnEachSide("ls -l " + AddColumnEachSide("/" + directory) + " | grep " + grepstring), True)
                    Dim WhenToExit As Integer = CountStr(Raw, vbCrLf) / 2
                    Dim FileNameReadLineCount As String = ""
                    Dim FileListCount As Integer = 0
                    Dim FileList(FileListCount) As String
                    Dim ReadLineCountDefenition_SkippedLine As Integer = 0



                    Dim DirectocyConfirm As New adb_control.filemanager.io_filesystem.info()

                    If Raw.Replace(" ", "").Replace("    ", "").Replace(vbCrLf, "").Length = 0 Then

                        LOG_("WARNING : DIRECTORY EMPTY. RETURNING NULLSTRING")
                        Return {EXPLORER_NULL_STRING}

                    ElseIf Not DirectocyConfirm.GetElementType(directory) = EXPLORER_CONTENT_TYPE.Directory Then

                        LOG_("WARNING : NOT A DIRECTORY. RETURNING EXPLORER_CORRUPTED_STRING")
                        Return {EXPLORER_CORRUPTED_STRING}

                    End If

                    If IsItLink(directory) Then
                        Return GetContent(GetOriginPathOfLink(adb_.ADBExecute("shell ls -l " + AddColumnEachSide("/" + directory), True)), grepstring)
                    End If

                    Dim StrReader As New IO.StringReader(Raw)
                    Dim ReadCount As Integer = 0



                    'ReadLineCount 변수
                    Dim ReadLineCountThisLine As String = ""
                    ReadLineCountThisLine = StrReader.ReadLine
                    Dim ReadLineCountRegex As New System.Text.RegularExpressions.Regex("\d{4}-\d{2}-\d{2} \d{2}:\d{2}") '****-**-** **:**
                    Dim DateTimeTotalLength As Integer = 16
                    Dim MaxTryCount As Integer = ReadLineCountThisLine.Length - DateTimeTotalLength
                    Dim TryCount As Integer = 1



                    LOG_("=====ReadLineCount Defenition progress start=====")
                    Do
                        'ReadLineCount 정의 루프
                        LOG_("")
                        LOG_("Parsing Line _ Txt:" + ReadLineCountThisLine + " Len:" + ReadLineCountThisLine.Length.ToString)

                        If ReadLineCountThisLine.Contains(": Permission denied") Then

                            LOG_("Skipped due to permission")

                            ReadLineCountThisLine = StrReader.ReadLine
                            Continue Do

                        End If

                        If TryCount = MaxTryCount Then
                            LOG_("WARNING : FileNameReadLineCount NOT DEFINED!!!")
                            Exit Do
                        End If

                        LOG_("(" + TryCount.ToString + "/" + MaxTryCount.ToString + ") " + Mid(ReadLineCountThisLine, TryCount, DateTimeTotalLength))
                        If ReadLineCountRegex.IsMatch(Mid(ReadLineCountThisLine, TryCount, DateTimeTotalLength)) Then

                            'GOTCHA
                            LOG_("FileNameReadLineCount Found at : " + (TryCount + DateTimeTotalLength).ToString)
                            FileNameReadLineCount = TryCount + DateTimeTotalLength + 1 '1의 의미는 날짜 정의 후의 한 빈칸입니다
                            Exit Do

                        End If

                        TryCount += 1
                        LOG_("")
                    Loop
                    LOG_("=====ReadLineCount Defenition progress end=====")

                    '다음 루프로 넘어가기전 StrReader 초기화
                    StrReader.Dispose()
                    StrReader = New IO.StringReader(Raw)

                    LOG_("=====List Defenition progress start=====")
                    Do
                        '리스트 갱신 루프

                        If ReadCount = WhenToExit Then
                            Exit Do
                        End If

                        Dim ThisLine As String = StrReader.ReadLine

                        If ThisLine = vbNullString Then
                            Continue Do
                        End If

                        ReDim Preserve FileList(FileListCount)
                        FileList(FileListCount) = Mid(ThisLine, FileNameReadLineCount)

                        LOG_("ThisLine: " + ThisLine)
                        LOG_("Content=" + FileList(FileListCount) + vbCrLf + "Repeat count : " + ReadCount.ToString + "/" + WhenToExit.ToString)

                        FileListCount += 1
                        ReadCount += 1

                    Loop
                    LOG_("=====List Defenition progress end=====")

                    ' ReDim Preserve FileList(FileListCount - 2)
                    Return FileList

                End Function

                Private Function IsItLink(path As String) As Boolean

                    LOG_("IsItLink() of : " + path)
                    Dim Raw As String = adb_.ADBExecute("shell ls -l " + AddColumnEachSide("/" + path) + " | grep ^l", True)
                    Return Raw.Contains("->") And Mid(Raw, 1, 1) = "l" And CountStr(Raw, vbCrLf) <= 2

                End Function



                Private Function GetOriginPathOfLink(raw As String)
                    Return Split(raw, " -> ")(1).Replace(Chr(10), "").Replace(Chr(13), "")
                End Function


            End Class
        End Namespace
    End Namespace
End Namespace