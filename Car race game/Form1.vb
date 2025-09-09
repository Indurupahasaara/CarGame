Public Class Form1
    Dim speed As Integer
    Dim road(7) As PictureBox
    Dim score As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox11
        road(7) = PictureBox12

    End Sub

    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick
        For x As Integer = 0 To 7
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next

        If score > 10 And score < 30 Then
            speed = 5
        End If
        If score > 30 And score < 50 Then
            speed = 6
        End If
        If score > 50 And score < 70 Then
            speed = 7
        End If
        If score > 100 Then
            speed = 9
        End If

        Label3.Text = "Speed" & speed
        If (car.Bounds.IntersectsWith(race1.bound) Then


    End Sub

    Private Sub endGame()
        Button1.Visible = True
        Label1.Visible = True
        RoadMover().Stop()
        RacerMover1.Stop()
        RacerMover2.Stop()
        RacerMover3.Stop()







    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles car.Click

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            RightSlide.Start()
        End If

        If e.KeyCode = Keys.Left Then
            LeftSide.Start()
        End If

    End Sub

    Private Sub RightSlide_Tick(sender As Object, e As EventArgs) Handles RightSlide.Tick
        If (car.Location.X < 295) Then
            car.Left += 5
        End If

    End Sub

    Private Sub LeftSide_Tick(sender As Object, e As EventArgs) Handles LeftSide.Tick
        If (car.Location.X > 0) Then
            car.Left -= 5
        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        RightSlide.Stop()
        LeftSide.Stop()

    End Sub
End Class
