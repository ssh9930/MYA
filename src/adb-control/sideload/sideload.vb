Namespace adb_control
    Public Class sideload
        Private _Raw As String = ""
        Private _Progress As Boolean = 0
        Enum SideloadResult
            Success
            Fail
            ConnectionClosed
            FileCourrupted
        End Enum

        '' ***!클래스 형식으로 개발 안함|***
        ''  Public Function SendSideload(file As String) As SideloadResult
        ''    Dim adb_ As New ADB("sideload " + file)
        ''         adb_.Start()
        ''      While Not adb_.StandardOutput.EndOfStream
        ''    Dim raw As String = adb_.StandardOutput.ReadLine
        ''             _Raw = raw
        ''             LOG_(raw)
        ''     Select Case True
        ''     Case raw.Contains("* cannot read")
        ''     Return SideloadResult.FileCourrupted
        ''     Case raw.Contains("error: closed")
        ''     Return SideloadResult.ConnectionClosed
        ''              End Select
        ''  
        ''      ' _Progress = 
        ''    End While
        ''    End Function

        ''     Public ReadOnly Property SideloadProgress() As Integer

        ''    Get

        ''    If _Raw.Contains("Serving") Then
        ''                 _Progress = CInt(Split(Split(_Raw, "(~")(1), "%)")(0))
        ''  ElseIf _Raw.Contains("Sending") Then
        ''               _Progress = CInt(Split(Split(_Raw, "(")(1), "%)")(0))
        ''    End If
        ''    Return _Progress
        ''         End Get
        ''     End Property
    End Class
End Namespace
