Public Class Form1
    Dim cnt As Integer = 0
    Dim myask As String = ""

    Private Sub breset_Click(sender As Object, e As EventArgs) Handles breset.Click
        b1.Text = ""
        b2.Text = ""
        b3.Text = ""
        b4.Text = ""
        b5.Text = ""
        b6.Text = ""
        b7.Text = ""
        b8.Text = ""
        b9.Text = ""
        cnt = 0
        myask = 0

        b1.Enabled = True
        b2.Enabled = True
        b3.Enabled = True
        b4.Enabled = True
        b5.Enabled = True
        b6.Enabled = True
        b7.Enabled = True
        b8.Enabled = True
        b9.Enabled = True


    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        If cnt = 0 Then
            b1.Text = "X"
            myask = "X"
            cnt = cnt + 1
        ElseIf myask = "X" Then
            b1.Text = "O"
            myask = "O"
            cnt = cnt + 1
        ElseIf myask = "O" Then
            b1.Text = "X"
            myask = "X"
            cnt = cnt + 1
        End If
        b1.Enabled = False

        Dim kjh As String = "X"
        If b1.Text = kjh And b2.Text = kjh And b3.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b1.Text = kjh And b5.Text = kjh And b9.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b1.Text = kjh And b4.Text And b7.Text Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        End If

        kjh = "O"
        If b1.Text = kjh And b2.Text = kjh And b3.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b1.Text = kjh And b5.Text = kjh And b9.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b1.Text = kjh And b4.Text And b7.Text Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        End If



    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        If cnt = 0 Then
            b2.Text = "X"
            myask = "X"
            cnt = cnt + 1
        ElseIf myask = "X" Then
            b2.Text = "O"
            myask = "O"
            cnt = cnt + 1
        ElseIf myask = "O" Then
            b2.Text = "X"
            myask = "X"
            cnt = cnt + 1
        End If
        b2.Enabled = False

        Dim kjh As String = "X"
        If b2.Text = kjh And b1.Text = kjh And b3.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b2.Text = kjh And b5.Text = kjh And b8.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()

        End If

        kjh = "O"
        If b2.Text = kjh And b1.Text = kjh And b3.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b2.Text = kjh And b5.Text = kjh And b8.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()

        End If
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        If cnt = 0 Then
            b3.Text = "X"
            myask = "X"
            cnt = cnt + 1
        ElseIf myask = "X" Then
            b3.Text = "O"
            myask = "O"
            cnt = cnt + 1
        ElseIf myask = "O" Then
            b3.Text = "X"
            myask = "X"
            cnt = cnt + 1
        End If
        b3.Enabled = False

        Dim kjh As String = "X"
        If b3.Text = kjh And b2.Text = kjh And b1.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b3.Text = kjh And b5.Text = kjh And b7.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b3.Text = kjh And b6.Text And b9.Text Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        End If

        kjh = "O"
        If b3.Text = kjh And b2.Text = kjh And b1.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b3.Text = kjh And b5.Text = kjh And b7.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b3.Text = kjh And b6.Text And b9.Text Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        End If

    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        If cnt = 0 Then
            b4.Text = "X"
            myask = "X"
            cnt = cnt + 1
        ElseIf myask = "X" Then
            b4.Text = "O"
            myask = "O"
            cnt = cnt + 1
        ElseIf myask = "O" Then
            b4.Text = "X"
            myask = "X"
            cnt = cnt + 1
        End If
        b4.Enabled = False

        Dim kjh As String = "X"
        If b4.Text = kjh And b1.Text = kjh And b7.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b4.Text = kjh And b5.Text = kjh And b6.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()

        End If

        kjh = "O"
        If b4.Text = kjh And b1.Text = kjh And b7.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b4.Text = kjh And b5.Text = kjh And b6.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()

        End If
    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        If cnt = 0 Then
            b5.Text = "X"
            myask = "X"
            cnt = cnt + 1
        ElseIf myask = "X" Then
            b5.Text = "O"
            myask = "O"
            cnt = cnt + 1
        ElseIf myask = "O" Then
            b5.Text = "X"
            myask = "X"
            cnt = cnt + 1
        End If
        b5.Enabled = False

        Dim kjh As String = "X"
        If b5.Text = kjh And b1.Text = kjh And b9.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b5.Text = kjh And b3.Text = kjh And b7.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b5.Text = kjh And b2.Text = kjh And b8.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b5.Text = kjh And b6.Text And b4.Text Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        End If

        kjh = "O"
        If b5.Text = kjh And b1.Text = kjh And b9.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b5.Text = kjh And b3.Text = kjh And b7.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b5.Text = kjh And b2.Text = kjh And b8.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b5.Text = kjh And b6.Text And b4.Text Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        End If

    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        If cnt = 0 Then
            b6.Text = "X"
            myask = "X"
            cnt = cnt + 1
        ElseIf myask = "X" Then
            b6.Text = "O"
            myask = "O"
            cnt = cnt + 1
        ElseIf myask = "O" Then
            b6.Text = "X"
            myask = "X"
            cnt = cnt + 1
        End If
        b6.Enabled = False

        Dim kjh As String = "X"
        If b6.Text = kjh And b3.Text = kjh And b9.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b6.Text = kjh And b5.Text = kjh And b4.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()

        End If

        kjh = "O"
        If b6.Text = kjh And b3.Text = kjh And b9.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b6.Text = kjh And b5.Text = kjh And b4.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()

        End If

    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click
        If cnt = 0 Then
            b7.Text = "X"
            myask = "X"
            cnt = cnt + 1
        ElseIf myask = "X" Then
            b7.Text = "O"
            myask = "O"
            cnt = cnt + 1
        ElseIf myask = "O" Then
            b7.Text = "X"
            myask = "X"
            cnt = cnt + 1
        End If
        b7.Enabled = False

        Dim kjh As String = "X"
        If b7.Text = kjh And b1.Text = kjh And b4.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b7.Text = kjh And b5.Text = kjh And b3.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b7.Text = kjh And b8.Text And b9.Text Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        End If

        kjh = "O"
        If b7.Text = kjh And b1.Text = kjh And b4.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b7.Text = kjh And b5.Text = kjh And b3.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b7.Text = kjh And b8.Text And b9.Text Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        End If
    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click
        If cnt = 0 Then
            b8.Text = "X"
            myask = "X"
            cnt = cnt + 1
        ElseIf myask = "X" Then
            b8.Text = "O"
            myask = "O"
            cnt = cnt + 1
        ElseIf myask = "O" Then
            b8.Text = "X"
            myask = "X"
            cnt = cnt + 1
        End If
        b8.Enabled = False

        Dim kjh As String = "X"
        If b8.Text = kjh And b2.Text = kjh And b5.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b8.Text = kjh And b7.Text = kjh And b9.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()

        End If

        kjh = "O"
        If b8.Text = kjh And b2.Text = kjh And b5.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b8.Text = kjh And b7.Text = kjh And b9.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()

    End Sub

    Private Sub b9_Click(sender As Object, e As EventArgs) Handles b9.Click
        If cnt = 0 Then
            b9.Text = "X"
            myask = "X"
            cnt = cnt + 1
        ElseIf myask = "X" Then
            b9.Text = "O"
            myask = "O"
            cnt = cnt + 1
        ElseIf myask = "O" Then
            b9.Text = "X"
            myask = "X"
            cnt = cnt + 1
        End If
        b9.Enabled = False

        Dim kjh As String = "X"
        If b9.Text = kjh And b1.Text = kjh And b5.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b9.Text = kjh And b6.Text = kjh And b3.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b9.Text = kjh And b8.Text And b7.Text Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        End If

        kjh = "O"
        If b9.Text = kjh And b1.Text = kjh And b5.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b9.Text = kjh And b6.Text = kjh And b3.Text = kjh Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        ElseIf b9.Text = kjh And b8.Text And b7.Text Then
            MessageBox.Show("Player " + kjh + " won")
            breset.PerformClick()
        End If
    End Sub
End Class
