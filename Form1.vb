Public Class Form1
    Private Sub txt_login_TextChanged(sender As Object, e As EventArgs) Handles txt_login.TextChanged

    End Sub

    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        If txt_login.Text = "admin" And txt_pw.Text = "1234" Then
            MsgBox("you login succfully")
            FormAdmin.Show()
        Else

            MsgBox("wroning")
        End If
    End Sub

    Private Sub btn_Annuler_Click(sender As Object, e As EventArgs) Handles btn_Annuler.Click
        Me.Close()

    End Sub
End Class
