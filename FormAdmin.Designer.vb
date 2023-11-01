<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin

    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Com_1 = New System.Windows.Forms.ComboBox()
        Me.Text_p = New System.Windows.Forms.TextBox()
        Me.Text_q = New System.Windows.Forms.TextBox()
        Me.Text_m = New System.Windows.Forms.TextBox()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_vider = New System.Windows.Forms.Button()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lst_1 = New System.Windows.Forms.ListBox()
        Me.lst_2 = New System.Windows.Forms.ListBox()
        Me.lst_3 = New System.Windows.Forms.ListBox()
        Me.lst_4 = New System.Windows.Forms.ListBox()
        Me.btn_calculer = New System.Windows.Forms.Button()
        Me.btn_Quitter = New System.Windows.Forms.Button()
        Me.txt_total = New System.Windows.Forms.Label()
        Me.Txt_10 = New System.Windows.Forms.TextBox()
        Me.txt_12 = New System.Windows.Forms.TextBox()
        Me.txt_11 = New System.Windows.Forms.TextBox()
        Me.txt_TVA = New System.Windows.Forms.Label()
        Me.txt_13 = New System.Windows.Forms.TextBox()
        Me.Txt_14 = New System.Windows.Forms.TextBox()
        Me.txt_R = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "produit :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "prix unitaire :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Quantité :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Montant HT :"
        '
        'Com_1
        '
        Me.Com_1.FormattingEnabled = True
        Me.Com_1.Items.AddRange(New Object() {"clavier", "souris", "imprimante", "ordinateur"})
        Me.Com_1.Location = New System.Drawing.Point(162, 39)
        Me.Com_1.Name = "Com_1"
        Me.Com_1.Size = New System.Drawing.Size(99, 21)
        Me.Com_1.TabIndex = 4
        '
        'Text_p
        '
        Me.Text_p.Location = New System.Drawing.Point(171, 96)
        Me.Text_p.Name = "Text_p"
        Me.Text_p.Size = New System.Drawing.Size(87, 20)
        Me.Text_p.TabIndex = 5
        '
        'Text_q
        '
        Me.Text_q.Location = New System.Drawing.Point(169, 136)
        Me.Text_q.Name = "Text_q"
        Me.Text_q.Size = New System.Drawing.Size(89, 20)
        Me.Text_q.TabIndex = 6
        '
        'Text_m
        '
        Me.Text_m.Location = New System.Drawing.Point(162, 185)
        Me.Text_m.Name = "Text_m"
        Me.Text_m.Size = New System.Drawing.Size(99, 20)
        Me.Text_m.TabIndex = 7
        '
        'btn_ajouter
        '
        Me.btn_ajouter.Location = New System.Drawing.Point(360, 36)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(91, 30)
        Me.btn_ajouter.TabIndex = 8
        Me.btn_ajouter.Text = "Ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = True
        '
        'btn_vider
        '
        Me.btn_vider.Location = New System.Drawing.Point(360, 81)
        Me.btn_vider.Name = "btn_vider"
        Me.btn_vider.Size = New System.Drawing.Size(91, 30)
        Me.btn_vider.TabIndex = 9
        Me.btn_vider.Text = "vider"
        Me.btn_vider.UseVisualStyleBackColor = True
        '
        'btn_supprimer
        '
        Me.btn_supprimer.Location = New System.Drawing.Point(360, 130)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(91, 30)
        Me.btn_supprimer.TabIndex = 10
        Me.btn_supprimer.Text = "supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(95, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "produit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(191, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "prix unitaire"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(317, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Quantité"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(430, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Montant HT"
        '
        'lst_1
        '
        Me.lst_1.FormattingEnabled = True
        Me.lst_1.Location = New System.Drawing.Point(92, 280)
        Me.lst_1.Name = "lst_1"
        Me.lst_1.Size = New System.Drawing.Size(72, 121)
        Me.lst_1.TabIndex = 15
        '
        'lst_2
        '
        Me.lst_2.FormattingEnabled = True
        Me.lst_2.Location = New System.Drawing.Point(203, 280)
        Me.lst_2.Name = "lst_2"
        Me.lst_2.Size = New System.Drawing.Size(75, 121)
        Me.lst_2.TabIndex = 16
        '
        'lst_3
        '
        Me.lst_3.FormattingEnabled = True
        Me.lst_3.Location = New System.Drawing.Point(314, 280)
        Me.lst_3.Name = "lst_3"
        Me.lst_3.Size = New System.Drawing.Size(73, 121)
        Me.lst_3.TabIndex = 17
        '
        'lst_4
        '
        Me.lst_4.FormattingEnabled = True
        Me.lst_4.Location = New System.Drawing.Point(421, 280)
        Me.lst_4.Name = "lst_4"
        Me.lst_4.Size = New System.Drawing.Size(84, 121)
        Me.lst_4.TabIndex = 18
        '
        'btn_calculer
        '
        Me.btn_calculer.Location = New System.Drawing.Point(572, 268)
        Me.btn_calculer.Name = "btn_calculer"
        Me.btn_calculer.Size = New System.Drawing.Size(74, 33)
        Me.btn_calculer.TabIndex = 19
        Me.btn_calculer.Text = "calculer"
        Me.btn_calculer.UseVisualStyleBackColor = True
        '
        'btn_Quitter
        '
        Me.btn_Quitter.Location = New System.Drawing.Point(572, 317)
        Me.btn_Quitter.Name = "btn_Quitter"
        Me.btn_Quitter.Size = New System.Drawing.Size(74, 32)
        Me.btn_Quitter.TabIndex = 20
        Me.btn_Quitter.Text = "Quitter"
        Me.btn_Quitter.UseVisualStyleBackColor = True
        '
        'txt_total
        '
        Me.txt_total.AutoSize = True
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(116, 418)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(52, 20)
        Me.txt_total.TabIndex = 21
        Me.txt_total.Text = "Total :"
        '
        'Txt_10
        '
        Me.Txt_10.Location = New System.Drawing.Point(199, 420)
        Me.Txt_10.Name = "Txt_10"
        Me.Txt_10.Size = New System.Drawing.Size(75, 20)
        Me.Txt_10.TabIndex = 22
        '
        'txt_12
        '
        Me.txt_12.Location = New System.Drawing.Point(421, 420)
        Me.txt_12.Name = "txt_12"
        Me.txt_12.Size = New System.Drawing.Size(84, 20)
        Me.txt_12.TabIndex = 23
        '
        'txt_11
        '
        Me.txt_11.Location = New System.Drawing.Point(314, 420)
        Me.txt_11.Name = "txt_11"
        Me.txt_11.Size = New System.Drawing.Size(75, 20)
        Me.txt_11.TabIndex = 24
        '
        'txt_TVA
        '
        Me.txt_TVA.AutoSize = True
        Me.txt_TVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TVA.Location = New System.Drawing.Point(184, 453)
        Me.txt_TVA.Name = "txt_TVA"
        Me.txt_TVA.Size = New System.Drawing.Size(94, 20)
        Me.txt_TVA.TabIndex = 25
        Me.txt_TVA.Text = "TVA (20%) :"
        '
        'txt_13
        '
        Me.txt_13.Location = New System.Drawing.Point(278, 455)
        Me.txt_13.Name = "txt_13"
        Me.txt_13.Size = New System.Drawing.Size(227, 20)
        Me.txt_13.TabIndex = 26
        '
        'Txt_14
        '
        Me.Txt_14.Location = New System.Drawing.Point(278, 507)
        Me.Txt_14.Name = "Txt_14"
        Me.Txt_14.Size = New System.Drawing.Size(227, 20)
        Me.Txt_14.TabIndex = 27
        '
        'txt_R
        '
        Me.txt_R.AutoSize = True
        Me.txt_R.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_R.Location = New System.Drawing.Point(191, 505)
        Me.txt_R.Name = "txt_R"
        Me.txt_R.Size = New System.Drawing.Size(71, 20)
        Me.txt_R.TabIndex = 28
        Me.txt_R.Text = "Remise :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(195, 542)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 20)
        Me.Label12.TabIndex = 29
        '
        'btn_modifier
        '
        Me.btn_modifier.Location = New System.Drawing.Point(360, 171)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(91, 34)
        Me.btn_modifier.TabIndex = 31
        Me.btn_modifier.Text = "modifier"
        Me.btn_modifier.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 604)
        Me.Controls.Add(Me.btn_modifier)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_R)
        Me.Controls.Add(Me.Txt_14)
        Me.Controls.Add(Me.txt_13)
        Me.Controls.Add(Me.txt_TVA)
        Me.Controls.Add(Me.txt_11)
        Me.Controls.Add(Me.txt_12)
        Me.Controls.Add(Me.Txt_10)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.btn_Quitter)
        Me.Controls.Add(Me.btn_calculer)
        Me.Controls.Add(Me.lst_4)
        Me.Controls.Add(Me.lst_3)
        Me.Controls.Add(Me.lst_2)
        Me.Controls.Add(Me.lst_1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_supprimer)
        Me.Controls.Add(Me.btn_vider)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.Text_m)
        Me.Controls.Add(Me.Text_q)
        Me.Controls.Add(Me.Text_p)
        Me.Controls.Add(Me.Com_1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Com_1 As ComboBox
    Friend WithEvents Text_p As TextBox
    Friend WithEvents Text_q As TextBox
    Friend WithEvents Text_m As TextBox
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_vider As Button
    Friend WithEvents btn_supprimer As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lst_1 As ListBox
    Friend WithEvents lst_2 As ListBox
    Friend WithEvents lst_3 As ListBox
    Friend WithEvents lst_4 As ListBox
    Friend WithEvents btn_calculer As Button
    Friend WithEvents btn_Quitter As Button
    Friend WithEvents txt_total As Label
    Friend WithEvents Txt_10 As TextBox
    Friend WithEvents txt_12 As TextBox
    Friend WithEvents txt_11 As TextBox
    Friend WithEvents txt_TVA As Label
    Friend WithEvents txt_13 As TextBox
    Friend WithEvents Txt_14 As TextBox
    Friend WithEvents txt_R As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_modifier As Button
End Class
