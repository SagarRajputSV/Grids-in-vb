Public Class Form1


    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        Dim br0 As New SolidBrush(Color.CadetBlue)

        Dim rt As New Rectangle(10, 100, 100, 20)

        'e.Graphics.DrawRectangle(Pens.Red, rt)
        e.Graphics.FillRectangle(br0, rt)
    End Sub


End Class
