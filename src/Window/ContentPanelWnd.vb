Namespace MYAWindow
    Public Class ContentPanelWnd : Inherits System.Windows.Forms.Form

        Dim WithEvents TargetPanel As ContentPanel

        Sub New(ContentPanel As ContentPanel, Optional CustomTitle As String = "",
                Optional WindowBorderStyle As FormBorderStyle = FormBorderStyle.Sizable)

            TargetPanel = ContentPanel
            TargetPanel.MasterWindow = Me

            If Not CustomTitle = "" Then
                Me.Text = CustomTitle
            Else
                Me.Text = TargetPanel.ContentPanelTitle
            End If

            Me.Size = TargetPanel.ContentPanelRegularSize
            Me.FormBorderStyle = WindowBorderStyle

            Me.Controls.Add(TargetPanel)

        End Sub

        Private Sub TitleChanged() Handles TargetPanel.ContentPanelTitleChanged

            Me.Text = TargetPanel.ContentPanelTitle

        End Sub

    End Class
End Namespace
