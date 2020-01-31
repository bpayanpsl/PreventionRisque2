<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProcessus
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
        Me.CheckedListBoxTotalProc = New System.Windows.Forms.CheckedListBox()
        Me.ButtonSuppr = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.TextBoxNewProc = New System.Windows.Forms.TextBox()
        Me.ButtonAjouter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckedListBoxTotalProc
        '
        Me.CheckedListBoxTotalProc.CheckOnClick = True
        Me.CheckedListBoxTotalProc.FormattingEnabled = True
        Me.CheckedListBoxTotalProc.Location = New System.Drawing.Point(12, 68)
        Me.CheckedListBoxTotalProc.Name = "CheckedListBoxTotalProc"
        Me.CheckedListBoxTotalProc.Size = New System.Drawing.Size(211, 154)
        Me.CheckedListBoxTotalProc.Sorted = True
        Me.CheckedListBoxTotalProc.TabIndex = 0
        '
        'ButtonSuppr
        '
        Me.ButtonSuppr.Location = New System.Drawing.Point(73, 228)
        Me.ButtonSuppr.Name = "ButtonSuppr"
        Me.ButtonSuppr.Size = New System.Drawing.Size(92, 24)
        Me.ButtonSuppr.TabIndex = 3
        Me.ButtonSuppr.Tag = ""
        Me.ButtonSuppr.Text = "Supprimer"
        Me.ButtonSuppr.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(73, 259)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(92, 23)
        Me.ButtonOK.TabIndex = 4
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'TextBoxNewProc
        '
        Me.TextBoxNewProc.Location = New System.Drawing.Point(12, 7)
        Me.TextBoxNewProc.Name = "TextBoxNewProc"
        Me.TextBoxNewProc.Size = New System.Drawing.Size(211, 20)
        Me.TextBoxNewProc.TabIndex = 5
        '
        'ButtonAjouter
        '
        Me.ButtonAjouter.Location = New System.Drawing.Point(64, 33)
        Me.ButtonAjouter.Name = "ButtonAjouter"
        Me.ButtonAjouter.Size = New System.Drawing.Size(92, 23)
        Me.ButtonAjouter.TabIndex = 6
        Me.ButtonAjouter.Text = "Ajouter"
        Me.ButtonAjouter.UseVisualStyleBackColor = True
        '
        'EditProcessus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 286)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonAjouter)
        Me.Controls.Add(Me.TextBoxNewProc)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.ButtonSuppr)
        Me.Controls.Add(Me.CheckedListBoxTotalProc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(252, 325)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(252, 325)
        Me.Name = "EditProcessus"
        Me.Text = "EditProcessus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckedListBoxTotalProc As System.Windows.Forms.CheckedListBox
    Friend WithEvents ButtonSuppr As System.Windows.Forms.Button
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents TextBoxNewProc As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAjouter As System.Windows.Forms.Button
End Class
