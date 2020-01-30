<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditActivite
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
        Me.ButtonSuppr = New System.Windows.Forms.Button()
        Me.ButtonAjout = New System.Windows.Forms.Button()
        Me.CheckedListBoxSelectAct = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBoxTotalAct = New System.Windows.Forms.CheckedListBox()
        Me.TextboxRecherche = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(342, 312)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(99, 23)
        Me.ButtonOK.TabIndex = 9
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonSuppr
        '
        Me.ButtonSuppr.Location = New System.Drawing.Point(371, 166)
        Me.ButtonSuppr.Name = "ButtonSuppr"
        Me.ButtonSuppr.Size = New System.Drawing.Size(43, 34)
        Me.ButtonSuppr.TabIndex = 8
        Me.ButtonSuppr.Tag = ""
        Me.ButtonSuppr.Text = "<"
        Me.ButtonSuppr.UseVisualStyleBackColor = True
        '
        'ButtonAjout
        '
        Me.ButtonAjout.Location = New System.Drawing.Point(371, 126)
        Me.ButtonAjout.Name = "ButtonAjout"
        Me.ButtonAjout.Size = New System.Drawing.Size(43, 34)
        Me.ButtonAjout.TabIndex = 7
        Me.ButtonAjout.Text = ">"
        Me.ButtonAjout.UseVisualStyleBackColor = True
        '
        'CheckedListBoxSelectAct
        '
        Me.CheckedListBoxSelectAct.FormattingEnabled = True
        Me.CheckedListBoxSelectAct.HorizontalScrollbar = True
        Me.CheckedListBoxSelectAct.Location = New System.Drawing.Point(420, 32)
        Me.CheckedListBoxSelectAct.Name = "CheckedListBoxSelectAct"
        Me.CheckedListBoxSelectAct.Size = New System.Drawing.Size(353, 274)
        Me.CheckedListBoxSelectAct.Sorted = True
        Me.CheckedListBoxSelectAct.TabIndex = 6
        '
        'CheckedListBoxTotalAct
        '
        Me.CheckedListBoxTotalAct.FormattingEnabled = True
        Me.CheckedListBoxTotalAct.HorizontalScrollbar = True
        Me.CheckedListBoxTotalAct.Location = New System.Drawing.Point(12, 32)
        Me.CheckedListBoxTotalAct.Name = "CheckedListBoxTotalAct"
        Me.CheckedListBoxTotalAct.Size = New System.Drawing.Size(353, 274)
        Me.CheckedListBoxTotalAct.Sorted = True
        Me.CheckedListBoxTotalAct.TabIndex = 5
        '
        'TextboxRecherche
        '
        Me.TextboxRecherche.Location = New System.Drawing.Point(161, 6)
        Me.TextboxRecherche.Name = "TextboxRecherche"
        Me.TextboxRecherche.Size = New System.Drawing.Size(204, 20)
        Me.TextboxRecherche.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Rechercher :"
        '
        'EditActivite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 339)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextboxRecherche)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.ButtonSuppr)
        Me.Controls.Add(Me.ButtonAjout)
        Me.Controls.Add(Me.CheckedListBoxSelectAct)
        Me.Controls.Add(Me.CheckedListBoxTotalAct)
        Me.Name = "EditActivite"
        Me.Text = "EditActivite"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents ButtonSuppr As System.Windows.Forms.Button
    Friend WithEvents ButtonAjout As System.Windows.Forms.Button
    Friend WithEvents CheckedListBoxSelectAct As System.Windows.Forms.CheckedListBox
    Friend WithEvents CheckedListBoxTotalAct As System.Windows.Forms.CheckedListBox
    Friend WithEvents TextboxRecherche As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
