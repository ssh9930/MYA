Public Class BorderButton : Inherits Button

    Private ColorBackup As System.Drawing.Color
    Public EnableBorder_ As Boolean = True

    Public Property EnableBorder As Boolean

        Get

            Return EnableBorder_

        End Get

        Set(value As Boolean)

            EnableBorder_ = value
            ChangeBorderColor()

        End Set

    End Property

    Public PaintedCount As Integer = 0

    Sub New()

        AddHandler Me.Paint, Sub() PaintedCount += 1

        Me.BackColor = System.Drawing.Color.FromArgb(245, 245, 245)
        Me.FlatStyle = FlatStyle.Flat
        Me.Cursor = Cursors.Hand
        Me.DoubleBuffered = True
        Me.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(Me.BackColor.R - 30, Me.BackColor.G - 30, Me.BackColor.B - 30)

        ChangeBorderColor()

    End Sub


    Private Sub ChangeBorderColor()

        If EnableBorder Then

            Me.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(Me.BackColor.R - 30, Me.BackColor.G - 30, Me.BackColor.B - 30)

        Else

            Me.FlatAppearance.BorderColor = Me.BackColor

        End If

    End Sub


End Class