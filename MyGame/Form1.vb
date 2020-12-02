Public Class Form1
    Private Sub Form1KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.J
                Picturebox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX)
                Me.Refresh()
            Case Keys.Up
                MoveTo(Picturebox1, 0, -5)
            Case Keys.Down
                MoveTo(Picturebox1, 0, 5)
            Case Keys.Left
                MoveTo(Picturebox1, -5, 0)
            Case Keys.Right
                MoveTo(Picturebox1, 5, 0)

            Case Else

        End Select
    End Sub

    Private Sub casetimer1_Tick(sender As Object, e As EventArgs) Handles TImer1.Tick
        follow(PictureBox2)
    End Sub
    Sub move(p As PictureBox, x As Integer, y As Integer)
        p.Location = New Point(p.Location.X + x, p.Location.Y + y)
    End Sub


    Sub follow(p As PictureBox)
        Static headstart As Integer
        Static c As New Collection
        c.Add(Picturebox1.Location)
        headstart = headstart + 1
        If headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub

    Public Sub chase(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > Picturebox1.Location.X Then
            x = -5
        Else
            x = 5
        End If
        MoveTo(p, x, 0)
        If p.Location.Y < Picturebox1.Location.Y Then
            y = 5
        Else
            y = -5
        End If
        MoveTo(p, x, y)
    End Sub



    Function Collision(p As PictureBox, t As String, Optional ByRef other As Object = vbNull)
        Dim col As Boolean
        Console.WriteLine(p.Name & "," & t)
        For Each c In Controls
            Dim obj As Control
            obj = c
            If obj.Visible AndAlso p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
                other = obj
                Return col
            End If
        Next
        Return col
    End Function
    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If
        Dim other As Object = Nothing
        If p.Name = "Picturebox1" And Collision(p, "WIN", other) Then
            ' Me.BackColor = Color.Green
            Form2.ShowDialog()
            TImer1.Enabled = False
            Timer2.Enabled = False
            Return
        End If
        If p.Name = "Picturebox4" And Collision(p, "LOOSE", other) Then
            ' Me.BackColor = Color.Green
            Form3.ShowDialog()
            Dim g As New Form1
            Me.Visible = False
            g.ShowDialog()

            TImer1.Enabled = False
            Timer2.Enabled = False
            Return
        End If
        If p.Name = "PictureBox2" And Collision(p, "picturebox2") Then
            'Me.BackColor = Color.Red
            other.visible = True
            Return
        End If
    End Sub
End Class



