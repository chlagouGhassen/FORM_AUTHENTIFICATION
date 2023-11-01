<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_Annuler = New System.Windows.Forms.Button()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.txt_pw = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_Annuler
        '
        Me.btn_Annuler.Location = New System.Drawing.Point(230, 175)
        Me.btn_Annuler.Name = "btn_Annuler"
        Me.btn_Annuler.Size = New System.Drawing.Size(75, 65)
        Me.btn_Annuler.TabIndex = 0
        Me.btn_Annuler.Text = "Annuler"
        Me.btn_Annuler.UseVisualStyleBackColor = True
        '
        'btn_valider
        '
        Me.btn_valider.Location = New System.Drawing.Point(365, 175)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(88, 65)
        Me.btn_valider.TabIndex = 1
        Me.btn_valider.Text = "Valider"
        Me.btn_valider.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nom utulisateur :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mot de passe :"
        '
        'txt_login
        '
        Me.txt_login.Location = New System.Drawing.Point(167, 48)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(186, 20)
        Me.txt_login.TabIndex = 4
        '
        'txt_pw
        '
        Me.txt_pw.Location = New System.Drawing.Point(167, 105)
        Me.txt_pw.Name = "txt_pw"
        Me.txt_pw.Size = New System.Drawing.Size(186, 20)
        Me.txt_pw.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_pw)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_valider)
        Me.Controls.Add(Me.btn_Annuler)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Annuler As Button
    Friend WithEvents btn_valider As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_login As TextBox
    Friend WithEvents txt_pw As TextBox
End Class
