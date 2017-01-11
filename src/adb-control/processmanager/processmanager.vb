Imports System.IO
Namespace adb_control
    Public Class ProcessManager

        Dim adb_ As New ADB
        Private Raw As String = ""
        Private ProcessInfoLine As Integer
        Public ProcessReportCount As Integer = 1
        Private TotalStatLineCount As Integer
        Private TotalStatLine As String = ""

        'NOTE!!
        '처음부터 Raw.IndexOf("PID PR") + 3
        'Raw.IndexOf("CPU%") Raw.IndexOf("CPU%") +3 까지
        'Raw.IndexOf("#THR") Raw.IndexOf("#THR") +3 까지
        'Raw.IndexOf("Name") 끝까지


        Sub New()
            'what is this : collecting basic top command parsing values
            'ps.on now, we are using single-thread, but i've a plan to change to multithread.
            'ps2. single-thread may casue some secs.
            'ps3. multi-thread may cause nullreferenceexception unless you manually sleep for some secs.


        End Sub


        Private Sub ProcessReport__()

            Dim adb_ As New ADB

            LOG_("ProcessReport()")


            Dim Raw__ As String = ""

            adb_.ADBExecute("shell top -n 1", False, True)

            While Not adb_.StandardOutput.EndOfStream
                Raw__ += vbCrLf + adb_.StandardOutput.ReadLine()
            End While

            Raw = Raw__
        End Sub

        Private Function GetProcessInfoLine(Optional SetTotalStatValues As Boolean = False)
            LOG_("GetProcessInfoLine()")

            'get the proces info line (under the PID CPU% VR line) *
            'WARNING : nullreference exception will be caused unless you defined "raw".

            Dim strStream As New StringReader(Raw)
            Dim LineCount As Integer = 1

            Do

                Dim ThisLine As String = strStream.ReadLine

                If Not ThisLine = vbNullString Then

                    If ThisLine.Contains("PID") And ThisLine.Contains("PR") _
                            And ThisLine.Contains("CPU%") And ThisLine.Contains("#THR") And
                            ThisLine.Contains("VSS") And ThisLine.Contains("RSS") _
                            And ThisLine.Contains("PCY") And ThisLine.Contains("UID") _
                        And ThisLine.Contains("Name") Then

                        If SetTotalStatValues Then
                            'Set the total stat line string ( PID CPU% VR line)

                            TotalStatLine = ThisLine
                        End If
                        Return LineCount + 2
                        Exit Do

                    End If

                Else

                    LineCount += 1
                End If
            Loop
            Return Nothing
        End Function

        Public Function GetTotalProcess() As Array

            'WARNING : nullreference exception will be caused unless you defined "raw".

            LOG_("==========ProcessManager Prepartion start==========")
            ProcessReport__()
            ProcessInfoLine = GetProcessInfoLine(True)
            LOG_("==========ProcessManager Prepartion end==========")


            Dim ProcessInfo As String = ""

            'ProcessInfo parsing line 
            Dim LineCount As Integer = 0
            Dim TotalCount As Integer = 0

            LOG_("ProcessInfo parsing..")

            For i As Integer = 1 To Raw.Length

                TotalCount += 1

                If Asc(Mid(Raw, i, 1)) = 13 Then

                    If LineCount = ProcessInfoLine Then

                        LOG_("Got the TotalCount!! :" + TotalCount.ToString)
                        Exit For
                    End If

                    LineCount += 1
                End If

            Next
            ProcessInfo = Mid(Raw, TotalCount)

            'list parsing & generating line

            LOG_("list parsing & generating..")

            Dim StrStream As New IO.StringReader(ProcessInfo)

            Dim NameCount As Integer = 0
            Dim ReturnData(NameCount) As String
            Dim ExitLoop As Boolean = False


            Do

                Dim ThisLine As String = StrStream.ReadLine


                If ExitLoop Then

                    LOG_("Exiting loop")
                    Exit Do

                End If

                If StrStream.Peek <= 0 Then

                    LOG_("Next time will be the end. preparing for the loop escape..")
                    ExitLoop = True

                End If

                If Not ThisLine = vbNullString Then

                    ReDim Preserve ReturnData(NameCount)
                    ReturnData(NameCount) = New String(GetProcessName(ThisLine))

                    LOG_("#" + NameCount.ToString + " attempt :" + ReturnData(NameCount))
                    NameCount += 1

                End If

            Loop

            Return ReturnData

        End Function


        '이와 같은 함수에서 1칸 뒤로 가서 파싱해야함.
        Private Function GetProcessID(RawLine As String) As Integer
            Return CInt(Mid(RawLine, 1, TotalStatLine.IndexOf("PID") + 3))
        End Function


        Private Function GetProcessName(RawLine As String) As String
            Return Mid(RawLine, TotalStatLine.IndexOf("Name") + 1)
        End Function


        Private Function GetProcessThreadCount(RawLine As String) As Integer
            Return Mid(RawLine, TotalStatLine.IndexOf("#THR") + 1, RawLine.IndexOf("#THR") + 3)
        End Function


        Private Function GetProcessCPUstat(RawLine As String) As Integer
            Return Mid(RawLine, TotalStatLine.IndexOf("CPU%") + 5, RawLine.IndexOf("CPU%") + 4)
        End Function


        Public Sub StartProcess(process As String, Optional WaitForExit As Boolean = True)

            adb_.ADBExecute("shell " + AddColumnEachSide(process), False, False <> WaitForExit)

        End Sub

        Public Sub EndProcess(PID As Integer, Optional WaitForExit As Boolean = True)

            adb_.ADBExecute("shell kill " + AddColumnEachSide(PID), False, False <> WaitForExit)

        End Sub

    End Class
End Namespace
