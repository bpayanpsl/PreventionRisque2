<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewUser = New System.Windows.Forms.DataGridView()
        Me.IdentifiantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MdpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valider = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DueruserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataSet = New PreventionRisque2.UserDataSet()
        Me.Duer_userTableAdapter = New PreventionRisque2.UserDataSetTableAdapters.duer_userTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DueruserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewUser
        '
        Me.DataGridViewUser.AllowUserToAddRows = False
        Me.DataGridViewUser.AllowUserToDeleteRows = False
        Me.DataGridViewUser.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentifiantDataGridViewTextBoxColumn, Me.MdpDataGridViewTextBoxColumn, Me.Valider})
        Me.DataGridViewUser.DataSource = Me.DueruserBindingSource
        Me.DataGridViewUser.Location = New System.Drawing.Point(12, 26)
        Me.DataGridViewUser.Name = "DataGridViewUser"
        Me.DataGridViewUser.ReadOnly = True
        Me.DataGridViewUser.RowHeadersVisible = False
        Me.DataGridViewUser.Size = New System.Drawing.Size(373, 207)
        Me.DataGridViewUser.TabIndex = 0
        '
        'IdentifiantDataGridViewTextBoxColumn
        '
        Me.IdentifiantDataGridViewTextBoxColumn.DataPropertyName = "identifiant"
        Me.IdentifiantDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdentifiantDataGridViewTextBoxColumn.Name = "IdentifiantDataGridViewTextBoxColumn"
        Me.IdentifiantDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdentifiantDataGridViewTextBoxColumn.Width = 150
        '
        'MdpDataGridViewTextBoxColumn
        '
        Me.MdpDataGridViewTextBoxColumn.DataPropertyName = "mdp"
        Me.MdpDataGridViewTextBoxColumn.HeaderText = "MDP"
        Me.MdpDataGridViewTextBoxColumn.Name = "MdpDataGridViewTextBoxColumn"
        Me.MdpDataGridViewTextBoxColumn.ReadOnly = True
        Me.MdpDataGridViewTextBoxColumn.Width = 150
        '
        'Valider
        '
        Me.Valider.HeaderText = "Valider"
        Me.Valider.Name = "Valider"
        Me.Valider.ReadOnly = True
        Me.Valider.Text = "OK"
        Me.Valider.UseColumnTextForButtonValue = True
        Me.Valider.Width = 70
        '
        'DueruserBindingSource
        '
        Me.DueruserBindingSource.DataMember = "duer_user"
        Me.DueruserBindingSource.DataSource = Me.UserDataSet
        '
        'UserDataSet
        '
        Me.UserDataSet.DataSetName = "UserDataSet"
        Me.UserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Duer_userTableAdapter
        '
        Me.Duer_userTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Demandes d'identifiants en attente :"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 426)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewUser)
        Me.Name = "Admin"
        Me.Text = "Admin"
        CType(Me.DataGridViewUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DueruserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewUser As System.Windows.Forms.DataGridView
    Friend WithEvents UserDataSet As PreventionRisque2.UserDataSet
    Friend WithEvents DueruserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Duer_userTableAdapter As PreventionRisque2.UserDataSetTableAdapters.duer_userTableAdapter
    Friend WithEvents IdentifiantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MdpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valider As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
