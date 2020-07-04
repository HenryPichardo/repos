Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Try
            If Me.ValidateChildren And txt1.Text <> String.Empty And Val(txt2.Text) - Int(Val(txt2.Text)) Then

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
