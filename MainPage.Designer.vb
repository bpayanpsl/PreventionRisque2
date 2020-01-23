<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.CheckedListBoxRisque = New System.Windows.Forms.CheckedListBox()
        Me.ComboBoxProcessus = New System.Windows.Forms.ComboBox()
        Me.ComboBoxActivite = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSetContient = New PreventionRisque2.DataSetContient()
        Me.DuercontientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Duer_contientTableAdapter = New PreventionRisque2.DataSetContientTableAdapters.duer_contientTableAdapter()
        Me.IdRisqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdActiviteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProcessusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FrequenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GraviteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreventionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CriticiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CriticiteNbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentaireDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesureExistanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesureProposeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NiveauPreventionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentifiantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateModifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SocieteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetContient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DuercontientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckedListBoxRisque
        '
        Me.CheckedListBoxRisque.FormattingEnabled = True
        Me.CheckedListBoxRisque.Location = New System.Drawing.Point(12, 64)
        Me.CheckedListBoxRisque.Name = "CheckedListBoxRisque"
        Me.CheckedListBoxRisque.Size = New System.Drawing.Size(359, 304)
        Me.CheckedListBoxRisque.TabIndex = 0
        '
        'ComboBoxProcessus
        '
        Me.ComboBoxProcessus.FormattingEnabled = True
        Me.ComboBoxProcessus.Location = New System.Drawing.Point(12, 6)
        Me.ComboBoxProcessus.Name = "ComboBoxProcessus"
        Me.ComboBoxProcessus.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxProcessus.TabIndex = 1
        '
        'ComboBoxActivite
        '
        Me.ComboBoxActivite.FormattingEnabled = True
        Me.ComboBoxActivite.Location = New System.Drawing.Point(12, 33)
        Me.ComboBoxActivite.Name = "ComboBoxActivite"
        Me.ComboBoxActivite.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxActivite.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRisqueDataGridViewTextBoxColumn, Me.IdActiviteDataGridViewTextBoxColumn, Me.IdProcessusDataGridViewTextBoxColumn, Me.DetailDataGridViewTextBoxColumn, Me.FrequenceDataGridViewTextBoxColumn, Me.GraviteDataGridViewTextBoxColumn, Me.PreventionDataGridViewTextBoxColumn, Me.CriticiteDataGridViewTextBoxColumn, Me.CriticiteNbDataGridViewTextBoxColumn, Me.CommentaireDataGridViewTextBoxColumn, Me.MesureExistanteDataGridViewTextBoxColumn, Me.MesureProposeDataGridViewTextBoxColumn, Me.NiveauPreventionDataGridViewTextBoxColumn, Me.IdentifiantDataGridViewTextBoxColumn, Me.DateModifDataGridViewTextBoxColumn, Me.SocieteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DuercontientBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(377, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(984, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'DataSetContient
        '
        Me.DataSetContient.DataSetName = "DataSetContient"
        Me.DataSetContient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DuercontientBindingSource
        '
        Me.DuercontientBindingSource.DataMember = "duer_contient"
        Me.DuercontientBindingSource.DataSource = Me.DataSetContient
        '
        'Duer_contientTableAdapter
        '
        Me.Duer_contientTableAdapter.ClearBeforeFill = True
        '
        'IdRisqueDataGridViewTextBoxColumn
        '
        Me.IdRisqueDataGridViewTextBoxColumn.DataPropertyName = "idRisque"
        Me.IdRisqueDataGridViewTextBoxColumn.HeaderText = "idRisque"
        Me.IdRisqueDataGridViewTextBoxColumn.Name = "IdRisqueDataGridViewTextBoxColumn"
        '
        'IdActiviteDataGridViewTextBoxColumn
        '
        Me.IdActiviteDataGridViewTextBoxColumn.DataPropertyName = "idActivite"
        Me.IdActiviteDataGridViewTextBoxColumn.HeaderText = "idActivite"
        Me.IdActiviteDataGridViewTextBoxColumn.Name = "IdActiviteDataGridViewTextBoxColumn"
        '
        'IdProcessusDataGridViewTextBoxColumn
        '
        Me.IdProcessusDataGridViewTextBoxColumn.DataPropertyName = "idProcessus"
        Me.IdProcessusDataGridViewTextBoxColumn.HeaderText = "idProcessus"
        Me.IdProcessusDataGridViewTextBoxColumn.Name = "IdProcessusDataGridViewTextBoxColumn"
        '
        'DetailDataGridViewTextBoxColumn
        '
        Me.DetailDataGridViewTextBoxColumn.DataPropertyName = "detail"
        Me.DetailDataGridViewTextBoxColumn.HeaderText = "detail"
        Me.DetailDataGridViewTextBoxColumn.Name = "DetailDataGridViewTextBoxColumn"
        '
        'FrequenceDataGridViewTextBoxColumn
        '
        Me.FrequenceDataGridViewTextBoxColumn.DataPropertyName = "frequence"
        Me.FrequenceDataGridViewTextBoxColumn.HeaderText = "frequence"
        Me.FrequenceDataGridViewTextBoxColumn.Name = "FrequenceDataGridViewTextBoxColumn"
        '
        'GraviteDataGridViewTextBoxColumn
        '
        Me.GraviteDataGridViewTextBoxColumn.DataPropertyName = "gravite"
        Me.GraviteDataGridViewTextBoxColumn.HeaderText = "gravite"
        Me.GraviteDataGridViewTextBoxColumn.Name = "GraviteDataGridViewTextBoxColumn"
        '
        'PreventionDataGridViewTextBoxColumn
        '
        Me.PreventionDataGridViewTextBoxColumn.DataPropertyName = "prevention"
        Me.PreventionDataGridViewTextBoxColumn.HeaderText = "prevention"
        Me.PreventionDataGridViewTextBoxColumn.Name = "PreventionDataGridViewTextBoxColumn"
        '
        'CriticiteDataGridViewTextBoxColumn
        '
        Me.CriticiteDataGridViewTextBoxColumn.DataPropertyName = "criticite"
        Me.CriticiteDataGridViewTextBoxColumn.HeaderText = "criticite"
        Me.CriticiteDataGridViewTextBoxColumn.Name = "CriticiteDataGridViewTextBoxColumn"
        '
        'CriticiteNbDataGridViewTextBoxColumn
        '
        Me.CriticiteNbDataGridViewTextBoxColumn.DataPropertyName = "criticiteNb"
        Me.CriticiteNbDataGridViewTextBoxColumn.HeaderText = "criticiteNb"
        Me.CriticiteNbDataGridViewTextBoxColumn.Name = "CriticiteNbDataGridViewTextBoxColumn"
        '
        'CommentaireDataGridViewTextBoxColumn
        '
        Me.CommentaireDataGridViewTextBoxColumn.DataPropertyName = "commentaire"
        Me.CommentaireDataGridViewTextBoxColumn.HeaderText = "commentaire"
        Me.CommentaireDataGridViewTextBoxColumn.Name = "CommentaireDataGridViewTextBoxColumn"
        '
        'MesureExistanteDataGridViewTextBoxColumn
        '
        Me.MesureExistanteDataGridViewTextBoxColumn.DataPropertyName = "mesureExistante"
        Me.MesureExistanteDataGridViewTextBoxColumn.HeaderText = "mesureExistante"
        Me.MesureExistanteDataGridViewTextBoxColumn.Name = "MesureExistanteDataGridViewTextBoxColumn"
        '
        'MesureProposeDataGridViewTextBoxColumn
        '
        Me.MesureProposeDataGridViewTextBoxColumn.DataPropertyName = "mesurePropose"
        Me.MesureProposeDataGridViewTextBoxColumn.HeaderText = "mesurePropose"
        Me.MesureProposeDataGridViewTextBoxColumn.Name = "MesureProposeDataGridViewTextBoxColumn"
        '
        'NiveauPreventionDataGridViewTextBoxColumn
        '
        Me.NiveauPreventionDataGridViewTextBoxColumn.DataPropertyName = "niveauPrevention"
        Me.NiveauPreventionDataGridViewTextBoxColumn.HeaderText = "niveauPrevention"
        Me.NiveauPreventionDataGridViewTextBoxColumn.Name = "NiveauPreventionDataGridViewTextBoxColumn"
        '
        'IdentifiantDataGridViewTextBoxColumn
        '
        Me.IdentifiantDataGridViewTextBoxColumn.DataPropertyName = "identifiant"
        Me.IdentifiantDataGridViewTextBoxColumn.HeaderText = "identifiant"
        Me.IdentifiantDataGridViewTextBoxColumn.Name = "IdentifiantDataGridViewTextBoxColumn"
        '
        'DateModifDataGridViewTextBoxColumn
        '
        Me.DateModifDataGridViewTextBoxColumn.DataPropertyName = "dateModif"
        Me.DateModifDataGridViewTextBoxColumn.HeaderText = "dateModif"
        Me.DateModifDataGridViewTextBoxColumn.Name = "DateModifDataGridViewTextBoxColumn"
        '
        'SocieteDataGridViewTextBoxColumn
        '
        Me.SocieteDataGridViewTextBoxColumn.DataPropertyName = "societe"
        Me.SocieteDataGridViewTextBoxColumn.HeaderText = "societe"
        Me.SocieteDataGridViewTextBoxColumn.Name = "SocieteDataGridViewTextBoxColumn"
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1373, 502)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBoxActivite)
        Me.Controls.Add(Me.ComboBoxProcessus)
        Me.Controls.Add(Me.CheckedListBoxRisque)
        Me.Name = "MainPage"
        Me.Text = "MainPage"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetContient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DuercontientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CheckedListBoxRisque As System.Windows.Forms.CheckedListBox
    Friend WithEvents ComboBoxProcessus As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxActivite As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSetContient As PreventionRisque2.DataSetContient
    Friend WithEvents DuercontientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Duer_contientTableAdapter As PreventionRisque2.DataSetContientTableAdapters.duer_contientTableAdapter
    Friend WithEvents IdRisqueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdActiviteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProcessusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FrequenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GraviteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreventionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CriticiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CriticiteNbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentaireDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MesureExistanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MesureProposeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NiveauPreventionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdentifiantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateModifDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SocieteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
