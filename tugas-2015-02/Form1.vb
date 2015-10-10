Public Class Form1
    Dim nilai1 As Integer
    Dim nilai2 As Integer
    Dim hasil As Boolean
    Dim operasi As String
    Private Sub input(ByVal nilai As Char)
        If Me.hasil = True Then
            If (Me.TextBox1.Text = "0") Then
                Me.TextBox1.Text = Convert.ToString(nilai)
            Else
                Dim TextBox1 As TextBox = Me.TextBox1
                TextBox1.Text = (TextBox1.Text & Convert.ToString(nilai))
            End If
        Else
            Me.TextBox1.Text = Convert.ToString(nilai)
            Me.hasil = True
        End If
    End Sub
    Private Sub hitung()
        Me.nilai2 = Convert.ToInt32(Me.TextBox1.Text)
        Select Case Me.operasi
            Case "+"
                Me.nilai1 = (Me.nilai1 + Me.nilai2)
                Exit Select
            Case "-"
                Me.nilai1 = (Me.nilai1 - Me.nilai2)
                Exit Select
        End Select
        Me.TextBox1.Text = Me.nilai1.ToString
        Me.hasil = False
    End Sub
    Private Sub inputUser(ByVal user As String)
        If (Me.TextBox1.Text <> "0") Then
            If (Me.operasi = String.Empty) Then
                Me.nilai1 = Convert.ToUInt32(Me.TextBox1.Text)
                Me.TextBox1.Text = Me.nilai1.ToString
                Me.hasil = False
            Else
                Me.hitung()
            End If
            Me.operasi = user
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.input("7")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.input("8")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.input("1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.input("2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.input("3")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.input("4")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.input("5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.input("6")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.input("9")
    End Sub
    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        Me.TextBox1.Text = "0"
        Me.nilai1 = 0
        Me.operasi = String.Empty
    End Sub

    Private Sub kurangi_Click(sender As Object, e As EventArgs) Handles kurangi.Click
        Me.inputUser("-")
    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        Me.inputUser("+")
    End Sub

    Private Sub H_Click(sender As Object, e As EventArgs) Handles H.Click
        If ((Me.TextBox1.Text <> "0") And (Me.nilai1 <> 0)) Then
            Me.hitung()
            Me.operasi = String.Empty
        End If
    End Sub

    Private Sub nol_Click(sender As Object, e As EventArgs) Handles nol.Click
        If (Me.hasil AndAlso (Me.TextBox1.Text <> "0")) Then
            Dim resultText As TextBox = Me.TextBox1
            TextBox1.Text = (TextBox1.Text & "0")
        End If

    End Sub
End Class