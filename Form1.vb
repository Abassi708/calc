Public Class Form1
    Dim a As Double
    Dim b As Double
    Dim c As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        a = Val(TextBox1.Text)
        TextBox1.Clear()
        c = "+"
    End Sub

    Private Sub btnmoin_Click(sender As Object, e As EventArgs) Handles btnmoin.Click
        a = Val(TextBox1.Text)
        TextBox1.Clear()
        c = "-"
    End Sub

    Private Sub btnfois_Click(sender As Object, e As EventArgs) Handles btnfois.Click
        a = Val(TextBox1.Text)
        TextBox1.Clear()
        c = "*"
    End Sub

    Private Sub btnsur_Click(sender As Object, e As EventArgs) Handles btnsur.Click
        a = Val(TextBox1.Text)
        TextBox1.Clear()
        c = "/"
    End Sub

    Private Sub btnegal_Click(sender As Object, e As EventArgs) Handles btnegal.Click
        b = Val(TextBox1.Text)
        TextBox1.Clear()

        If c = "+" Then TextBox1.Text = a + b
        If c = "-" Then TextBox1.Text = a - b
        If c = "*" Then TextBox1.Text = a * b
        If c = "/" Then TextBox1.Text = a / b
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
    End Sub
End Class
