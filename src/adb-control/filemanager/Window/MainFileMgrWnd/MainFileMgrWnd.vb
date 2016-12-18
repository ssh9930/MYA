Public Class FileManagerWnd
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New ADB()
        MsgBox(a.ADBExecute(TextBox1.Text, CheckBox1.Checked, CheckBox2.Checked, CheckBox3.Checked), vbInformation, "result")
    End Sub

End Class