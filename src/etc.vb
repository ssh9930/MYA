Module MYA_etc

    '***DEBUG SUBS***'

    Public Sub LOG_(input As Object)

        Dim Output As String = "[" + Application.ProductName + " v." + Application.ProductVersion + "][" + Format(DateTime.Now, "yy-MM-dd HH:mm:ss") + "] " _
                                + input.ToString

        If EnableDbgLogging Then
            Debug.Print(Output)

            If EnabledDbgLogSave Then
                My.Computer.FileSystem.WriteAllText(DbgLogSavePath, vbCrLf + Output, True)
            End If
        End If
    End Sub


    Public Sub CleanDebugLog()
        FileIO.FileSystem.DeleteFile(DbgLogSavePath)
    End Sub


    '***PLAIN SUBS***

    Public Sub CleanTMPfolder()
        Try

            If Not FileIO.FileSystem.DirectoryExists(MYA_tmpPath) Then
                MkDir(MYA_tmpPath)
            End If

            For Each Files As String In FileIO.FileSystem.GetFiles(MYA_tmpPath)
                FileIO.FileSystem.DeleteFile(Files)
            Next

        Catch ex As IO.IOException
        End Try
    End Sub

End Module
