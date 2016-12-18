Module StringExtension


    Public Function AddColumnEachSide(text As String) As String
        Return Chr(34) + text + Chr(34)
    End Function


    Public Function CountStr(text As String, text_to_find As Char) As Integer

        Dim StrCount As Integer = 0

        For Each i In text

            If i = text_to_find Then
                StrCount += 1
            End If

        Next

        Return StrCount
    End Function

End Module
