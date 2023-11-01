Public Class Frm_authentifier

    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        If txt_login.Text = "admin" And txt_pw.Text = "1234" Then
            MsgBox("you login succfully")
        Else

            MsgBox("wroning")
        End If
    End Sub



End Class