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
        Me.CheckedListBoxSelectProc = New System.Windows.Forms.CheckedListBox()
        Me.ButtonAjout = New System.Windows.Forms.Button()
        Me.ButtonSuppr = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckedListBoxTotalProc
        '
        Me.CheckedListBoxTotalProc.FormattingEnabled = True
        Me.CheckedListBoxTotalProc.Location = New System.Drawing.Point(12, 12)
        Me.CheckedListBoxTotalProc.Name = "CheckedListBoxTotalProc"
        Me.CheckedListBoxTotalProc.Size = New System.Drawing.Size(211, 184)
        Me.CheckedListBoxTotalProc.TabIndex = 0
        '
        'CheckedListBoxSelectProc
        '
        Me.CheckedListBoxSelectProc.FormattingEnabled = True
        Me.CheckedListBoxSelectProc.Location = New System.Drawing.Point(278, 12)
        Me.CheckedListBoxSelectProc.Name = "CheckedListBoxSelectProc"
        Me.CheckedListBoxSelectProc.Size = New System.Drawing.Size(208, 184)
        Me.CheckedListBoxSelectProc.TabIndex = 1
        '
        'ButtonAjout
        '
        Me.ButtonAjout.Location = New System.Drawing.Point(229, 58)
        Me.ButtonAjout.Name = "ButtonAjout"
        Me.ButtonAjout.Size = New System.Drawing.Size(43, 34)
        Me.ButtonAjout.TabIndex = 2
        Me.ButtonAjout.Text = ">"
        Me.ButtonAjout.UseVisualStyleBackColor = True
        '
        'ButtonSuppr
        '
        Me.ButtonSuppr.Location = New System.Drawing.Point(229, 98)
        Me.ButtonSuppr.Name = "ButtonSuppr"
        Me.ButtonSuppr.Size = New System.Drawing.Size(43, 34)
        Me.ButtonSuppr.TabIndex = 3
        Me.ButtonSuppr.Tag = ""
        Me.ButtonSuppr.Text = "<"
        Me.ButtonSuppr.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(211, 202)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 4
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'EditProcessus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 231)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.ButtonSuppr)
        Me.Controls.Add(Me.ButtonAjout)
        Me.Controls.Add(Me.CheckedListBoxSelectProc)
        Me.Controls.Add(Me.CheckedListBoxTotalProc)
        Me.Name = "EditProcessus"
        Me.Text = "EditProcessus"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CheckedListBoxTotalProc As System.Windows.Forms.CheckedListBox
    Friend WithEvents CheckedListBoxSelectProc As System.Windows.Forms.CheckedListBox
    Friend WithEvents ButtonAjout As System.Windows.Forms.Button
    Friend WithEvents ButtonSuppr As System.Windows.Forms.Button
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
End Class
