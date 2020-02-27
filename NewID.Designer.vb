<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewID
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
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.TextBoxMDP = New System.Windows.Forms.TextBox()
        Me.TextBoxMDP2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(41, 161)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 4
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(41, 40)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(156, 20)
        Me.TextBoxID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Identifiant"
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.Location = New System.Drawing.Point(122, 161)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAnnuler.TabIndex = 5
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'TextBoxMDP
        '
        Me.TextBoxMDP.Location = New System.Drawing.Point(41, 81)
        Me.TextBoxMDP.Name = "TextBoxMDP"
        Me.TextBoxMDP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxMDP.Size = New System.Drawing.Size(156, 20)
        Me.TextBoxMDP.TabIndex = 2
        '
        'TextBoxMDP2
        '
        Me.TextBoxMDP2.Location = New System.Drawing.Point(41, 122)
        Me.TextBoxMDP2.Name = "TextBoxMDP2"
        Me.TextBoxMDP2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxMDP2.Size = New System.Drawing.Size(156, 20)
        Me.TextBoxMDP2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mot de passe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Valider le mot de passe"
        '
        'NewID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 214)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxMDP2)
        Me.Controls.Add(Me.TextBoxMDP)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.ButtonOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(251, 253)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(251, 253)
        Me.Name = "NewID"
        Me.Text = "Demande d'identifiants"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonAnnuler As System.Windows.Forms.Button
    Friend WithEvents TextBoxMDP As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMDP2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
