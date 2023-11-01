Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Com_1.SelectedIndexChanged
        If (Com_1.SelectedItem = "clavier") Then
            Text_p.Text = 30
        ElseIf (Com_1.SelectedItem = "souris") Then
            Text_p.Text = 15
        ElseIf (Com_1.SelectedItem = "imprimante") Then
            Text_p.Text = 500
        ElseIf (com_1.SelectedItem = "ordinateur") Then
            Text_p.Text = 1000
        End If
    End Sub

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        lst_1.Items.Add(Com_1.SelectedItem)
        lst_2.Items.Add(Text_p.Text)
        lst_3.Items.Add(Text_q.Text)
        lst_4.Items.Add(Text_m.Text)
    End Sub

    Private Sub Text_q_TextChanged(sender As Object, e As EventArgs) Handles Text_q.TextChanged
        Dim Quant As Integer = Val(Text_q.Text)
        Dim prix As Integer = Val(Text_p.Text)
        Dim mon As Integer = prix * Quant
        Text_m.Text = mon.ToString()

    End Sub

    Private Sub btn_vider_Click(sender As Object, e As EventArgs) Handles btn_vider.Click
        Text_p.Clear()
        Text_q.Clear()
        Text_m.Clear()
        Com_1.Text = "Choisir le produit"




    End Sub

    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click


        lst_1.Items.Remove(Com_1.SelectedItem)
        lst_2.Items.Remove(Text_p.Text)
        lst_3.Items.Remove(Text_q.Text)
        lst_4.Items.Remove(Text_m.Text)









    End Sub

    Private Sub btn_calculer_Click(sender As Object, e As EventArgs) Handles btn_calculer.Click
        Dim som As Integer = 0
        Dim somA As Integer = 0
        Dim somB As Integer = 0
        For Each item As Integer In lst_2.Items
            som += item
        Next
        Txt_10.Text = som
        For Each item As Integer In lst_3.Items
            somA += item
        Next
        txt_11.Text = somA
        For Each item As Integer In lst_4.Items
            somB += item
        Next
        txt_12.Text = somB
        txt_13.Text = som + somA + somB
        If (txt_13.Text > 1000) Then
            Txt_14.Text = (txt_13.Text / 100) * 80
        Else
            Txt_14.Text = "n'est pas de remise"
        End If




    End Sub

    Private Sub btn_Quitter_Click(sender As Object, e As EventArgs) Handles btn_Quitter.Click
        Me.Close()

    End Sub

    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click

        If lst_1.SelectedIndex >= 0 Then
            Dim l As Integer
            l = lst_1.SelectedIndex
            Dim q As Integer

            If Integer.TryParse(InputBox("nouvelle valeur:", "modifier la valeur"), q) Then
                Dim pu As Decimal
                pu = CDec(lst_2.Items(l))

                Text_q.Text = CDec(Text_q.Text) - CDec(lst_4.Items(l))
                Dim ml As Integer = pu * q
                Text_q.Text = CDec(Text_q.Text) + ml
                lst_3.Items(l) = q
                lst_4.Items(l) = ml
            End If
        End If


    End Sub

    Private Sub txt_total_Click(sender As Object, e As EventArgs) Handles txt_total.Click
        Dim ga As Integer = Val(Text_p.Text)
        Dim x As Integer = Val(Text_q.Text)
        Dim tot As Integer = x * ga
        Text_m.Text = tot.ToString()

    End Sub

    Private Sub txt_R_Click(sender As Object, e As EventArgs) Handles txt_R.Click
        Dim ch As Double
        ch = Text_p.Text * Text_q.Text
        Text_m.Text = ch

    End Sub
End Class
