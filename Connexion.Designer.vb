<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connexion
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
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxMDP = New System.Windows.Forms.TextBox()
        Me.ButtonDemandeID = New System.Windows.Forms.Button()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelMDP = New System.Windows.Forms.Label()
        Me.ButtonConnexion = New System.Windows.Forms.Button()
        Me.ComboBoxSociete = New System.Windows.Forms.ComboBox()
        Me.LabelSociete = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(118, 14)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(120, 20)
        Me.TextBoxID.TabIndex = 0
        '
        'TextBoxMDP
        '
        Me.TextBoxMDP.Location = New System.Drawing.Point(118, 40)
        Me.TextBoxMDP.Name = "TextBoxMDP"
        Me.TextBoxMDP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxMDP.Size = New System.Drawing.Size(120, 20)
        Me.TextBoxMDP.TabIndex = 1
        '
        'ButtonDemandeID
        '
        Me.ButtonDemandeID.Location = New System.Drawing.Point(157, 94)
        Me.ButtonDemandeID.Name = "ButtonDemandeID"
        Me.ButtonDemandeID.Size = New System.Drawing.Size(121, 23)
        Me.ButtonDemandeID.TabIndex = 4
        Me.ButtonDemandeID.Text = "Demande d'identifiant"
        Me.ButtonDemandeID.UseVisualStyleBackColor = True
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(53, 17)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(59, 13)
        Me.LabelID.TabIndex = 3
        Me.LabelID.Text = "Identifiant :"
        '
        'LabelMDP
        '
        Me.LabelMDP.AutoSize = True
        Me.LabelMDP.Location = New System.Drawing.Point(35, 43)
        Me.LabelMDP.Name = "LabelMDP"
        Me.LabelMDP.Size = New System.Drawing.Size(77, 13)
        Me.LabelMDP.TabIndex = 4
        Me.LabelMDP.Text = "Mot de passe :"
        '
        'ButtonConnexion
        '
        Me.ButtonConnexion.Location = New System.Drawing.Point(30, 94)
        Me.ButtonConnexion.Name = "ButtonConnexion"
        Me.ButtonConnexion.Size = New System.Drawing.Size(121, 23)
        Me.ButtonConnexion.TabIndex = 3
        Me.ButtonConnexion.Text = "Connexion"
        Me.ButtonConnexion.UseVisualStyleBackColor = True
        '
        'ComboBoxSociete
        '
        Me.ComboBoxSociete.FormattingEnabled = True
        Me.ComboBoxSociete.Items.AddRange(New Object() {"SRI", "RIGAU"})
        Me.ComboBoxSociete.Location = New System.Drawing.Point(118, 67)
        Me.ComboBoxSociete.Name = "ComboBoxSociete"
        Me.ComboBoxSociete.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxSociete.TabIndex = 2
        '
        'LabelSociete
        '
        Me.LabelSociete.AutoSize = True
        Me.LabelSociete.Location = New System.Drawing.Point(63, 70)
        Me.LabelSociete.Name = "LabelSociete"
        Me.LabelSociete.Size = New System.Drawing.Size(49, 13)
        Me.LabelSociete.TabIndex = 7
        Me.LabelSociete.Text = "Société :"
        '
        'Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 128)
        Me.Controls.Add(Me.LabelSociete)
        Me.Controls.Add(Me.ComboBoxSociete)
        Me.Controls.Add(Me.ButtonConnexion)
        Me.Controls.Add(Me.LabelMDP)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.ButtonDemandeID)
        Me.Controls.Add(Me.TextBoxMDP)
        Me.Controls.Add(Me.TextBoxID)
        Me.Name = "Connexion"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMDP As System.Windows.Forms.TextBox
    Friend WithEvents ButtonDemandeID As System.Windows.Forms.Button
    Friend WithEvents LabelID As System.Windows.Forms.Label
    Friend WithEvents LabelMDP As System.Windows.Forms.Label
    Friend WithEvents ButtonConnexion As System.Windows.Forms.Button
    Friend WithEvents ComboBoxSociete As System.Windows.Forms.ComboBox
    Friend WithEvents LabelSociete As System.Windows.Forms.Label

End Class
