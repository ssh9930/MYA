
Public Class ContentPanel : Inherits System.Windows.Forms.Panel

        'NOTE : this is a base class for content panel (ex : filemgrpanel, shellpanel)

        Public ContentPanelRegularSize As Point = New Point(500, 500)

        Public WithEvents MasterWindow As Form
        Private Title_ As String = ""
        Public Event ContentPanelTitleChanged()


        Public Property ContentPanelTitle As String

            Get
                Return Title_
            End Get

            Set(Title__ As String)

                RaiseEvent ContentPanelTitleChanged()
                Title_ = Title__

            End Set

        End Property


        Private Sub OnMasterWndClose() Handles MasterWindow.Closed

        LOG_("MasterWndClose for :" + MasterWindow.Name)
        Me.Dispose()

        End Sub

        '

        Sub New()

            Me.DoubleBuffered = True
            Me.BackColor = Color.White

        End Sub

    End Class

