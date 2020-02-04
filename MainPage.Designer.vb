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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CheckedListBoxRisque = New System.Windows.Forms.CheckedListBox()
        Me.ComboBoxProcessus = New System.Windows.Forms.ComboBox()
        Me.ComboBoxActivite = New System.Windows.Forms.ComboBox()
        Me.DuercontientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetContient = New PreventionRisque2.DataSetContient()
        Me.Duer_contientTableAdapter = New PreventionRisque2.DataSetContientTableAdapters.duer_contientTableAdapter()
        Me.ButtonAjoutProcessus = New System.Windows.Forms.Button()
        Me.ButtonAjoutActivite = New System.Windows.Forms.Button()
        Me.ButtonAjoutRisque = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FermerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SociétéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SRIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RIGAUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdRisqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FrequenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GraviteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreventionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CriticiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesureExistanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesureProposeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.commentaire = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NiveauPreventionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.IdentifiantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateModifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Suppr = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.LabelProc = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AdministrateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DuercontientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetContient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckedListBoxRisque
        '
        Me.CheckedListBoxRisque.CheckOnClick = True
        Me.CheckedListBoxRisque.FormattingEnabled = True
        Me.CheckedListBoxRisque.Location = New System.Drawing.Point(12, 124)
        Me.CheckedListBoxRisque.Name = "CheckedListBoxRisque"
        Me.CheckedListBoxRisque.Size = New System.Drawing.Size(359, 304)
        Me.CheckedListBoxRisque.TabIndex = 0
        '
        'ComboBoxProcessus
        '
        Me.ComboBoxProcessus.FormattingEnabled = True
        Me.ComboBoxProcessus.Location = New System.Drawing.Point(12, 44)
        Me.ComboBoxProcessus.Name = "ComboBoxProcessus"
        Me.ComboBoxProcessus.Size = New System.Drawing.Size(317, 21)
        Me.ComboBoxProcessus.TabIndex = 1
        '
        'ComboBoxActivite
        '
        Me.ComboBoxActivite.FormattingEnabled = True
        Me.ComboBoxActivite.Location = New System.Drawing.Point(12, 84)
        Me.ComboBoxActivite.Name = "ComboBoxActivite"
        Me.ComboBoxActivite.Size = New System.Drawing.Size(317, 21)
        Me.ComboBoxActivite.TabIndex = 2
        '
        'DuercontientBindingSource
        '
        Me.DuercontientBindingSource.DataMember = "duer_contient"
        Me.DuercontientBindingSource.DataSource = Me.DataSetContient
        '
        'DataSetContient
        '
        Me.DataSetContient.DataSetName = "DataSetContient"
        Me.DataSetContient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Duer_contientTableAdapter
        '
        Me.Duer_contientTableAdapter.ClearBeforeFill = True
        '
        'ButtonAjoutProcessus
        '
        Me.ButtonAjoutProcessus.Location = New System.Drawing.Point(335, 44)
        Me.ButtonAjoutProcessus.Name = "ButtonAjoutProcessus"
        Me.ButtonAjoutProcessus.Size = New System.Drawing.Size(36, 23)
        Me.ButtonAjoutProcessus.TabIndex = 4
        Me.ButtonAjoutProcessus.Text = "+ / -"
        Me.ButtonAjoutProcessus.UseVisualStyleBackColor = True
        '
        'ButtonAjoutActivite
        '
        Me.ButtonAjoutActivite.Location = New System.Drawing.Point(335, 82)
        Me.ButtonAjoutActivite.Name = "ButtonAjoutActivite"
        Me.ButtonAjoutActivite.Size = New System.Drawing.Size(36, 23)
        Me.ButtonAjoutActivite.TabIndex = 5
        Me.ButtonAjoutActivite.Text = "+ / -"
        Me.ButtonAjoutActivite.UseVisualStyleBackColor = True
        '
        'ButtonAjoutRisque
        '
        Me.ButtonAjoutRisque.Location = New System.Drawing.Point(377, 248)
        Me.ButtonAjoutRisque.Name = "ButtonAjoutRisque"
        Me.ButtonAjoutRisque.Size = New System.Drawing.Size(43, 38)
        Me.ButtonAjoutRisque.TabIndex = 6
        Me.ButtonAjoutRisque.Text = ">"
        Me.ButtonAjoutRisque.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.SociétéToolStripMenuItem, Me.AdministrateurToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1832, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FermerToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'FermerToolStripMenuItem
        '
        Me.FermerToolStripMenuItem.Name = "FermerToolStripMenuItem"
        Me.FermerToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.FermerToolStripMenuItem.Text = "Quitter"
        '
        'SociétéToolStripMenuItem
        '
        Me.SociétéToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SRIToolStripMenuItem, Me.RIGAUToolStripMenuItem})
        Me.SociétéToolStripMenuItem.Name = "SociétéToolStripMenuItem"
        Me.SociétéToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SociétéToolStripMenuItem.Text = "Société"
        '
        'SRIToolStripMenuItem
        '
        Me.SRIToolStripMenuItem.Name = "SRIToolStripMenuItem"
        Me.SRIToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.SRIToolStripMenuItem.Text = "SRI"
        '
        'RIGAUToolStripMenuItem
        '
        Me.RIGAUToolStripMenuItem.Name = "RIGAUToolStripMenuItem"
        Me.RIGAUToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.RIGAUToolStripMenuItem.Text = "RIGAU"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRisqueDataGridViewTextBoxColumn, Me.DetailDataGridViewTextBoxColumn, Me.FrequenceDataGridViewTextBoxColumn, Me.GraviteDataGridViewTextBoxColumn, Me.PreventionDataGridViewTextBoxColumn, Me.CriticiteDataGridViewTextBoxColumn, Me.MesureExistanteDataGridViewTextBoxColumn, Me.MesureProposeDataGridViewTextBoxColumn, Me.commentaire, Me.NiveauPreventionDataGridViewTextBoxColumn, Me.IdentifiantDataGridViewTextBoxColumn, Me.DateModifDataGridViewTextBoxColumn, Me.Suppr})
        Me.DataGridView1.DataSource = Me.DuercontientBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(426, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView1.Size = New System.Drawing.Size(1305, 382)
        Me.DataGridView1.TabIndex = 3
        '
        'IdRisqueDataGridViewTextBoxColumn
        '
        Me.IdRisqueDataGridViewTextBoxColumn.DataPropertyName = "idRisque"
        Me.IdRisqueDataGridViewTextBoxColumn.HeaderText = "Risque"
        Me.IdRisqueDataGridViewTextBoxColumn.Name = "IdRisqueDataGridViewTextBoxColumn"
        Me.IdRisqueDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdRisqueDataGridViewTextBoxColumn.Width = 200
        '
        'DetailDataGridViewTextBoxColumn
        '
        Me.DetailDataGridViewTextBoxColumn.DataPropertyName = "detail"
        Me.DetailDataGridViewTextBoxColumn.HeaderText = "Detail"
        Me.DetailDataGridViewTextBoxColumn.Name = "DetailDataGridViewTextBoxColumn"
        Me.DetailDataGridViewTextBoxColumn.Width = 250
        '
        'FrequenceDataGridViewTextBoxColumn
        '
        Me.FrequenceDataGridViewTextBoxColumn.DataPropertyName = "frequence"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FrequenceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.FrequenceDataGridViewTextBoxColumn.HeaderText = "F"
        Me.FrequenceDataGridViewTextBoxColumn.Name = "FrequenceDataGridViewTextBoxColumn"
        Me.FrequenceDataGridViewTextBoxColumn.Width = 20
        '
        'GraviteDataGridViewTextBoxColumn
        '
        Me.GraviteDataGridViewTextBoxColumn.DataPropertyName = "gravite"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.GraviteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13
        Me.GraviteDataGridViewTextBoxColumn.HeaderText = "G"
        Me.GraviteDataGridViewTextBoxColumn.Name = "GraviteDataGridViewTextBoxColumn"
        Me.GraviteDataGridViewTextBoxColumn.Width = 20
        '
        'PreventionDataGridViewTextBoxColumn
        '
        Me.PreventionDataGridViewTextBoxColumn.DataPropertyName = "prevention"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PreventionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.PreventionDataGridViewTextBoxColumn.HeaderText = "P"
        Me.PreventionDataGridViewTextBoxColumn.Name = "PreventionDataGridViewTextBoxColumn"
        Me.PreventionDataGridViewTextBoxColumn.Width = 20
        '
        'CriticiteDataGridViewTextBoxColumn
        '
        Me.CriticiteDataGridViewTextBoxColumn.DataPropertyName = "criticite"
        Me.CriticiteDataGridViewTextBoxColumn.HeaderText = "Criticite"
        Me.CriticiteDataGridViewTextBoxColumn.Name = "CriticiteDataGridViewTextBoxColumn"
        Me.CriticiteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MesureExistanteDataGridViewTextBoxColumn
        '
        Me.MesureExistanteDataGridViewTextBoxColumn.DataPropertyName = "mesureExistante"
        Me.MesureExistanteDataGridViewTextBoxColumn.HeaderText = "Mesures existantes"
        Me.MesureExistanteDataGridViewTextBoxColumn.Name = "MesureExistanteDataGridViewTextBoxColumn"
        Me.MesureExistanteDataGridViewTextBoxColumn.Width = 250
        '
        'MesureProposeDataGridViewTextBoxColumn
        '
        Me.MesureProposeDataGridViewTextBoxColumn.DataPropertyName = "mesurePropose"
        Me.MesureProposeDataGridViewTextBoxColumn.HeaderText = "Mesures proposées"
        Me.MesureProposeDataGridViewTextBoxColumn.Name = "MesureProposeDataGridViewTextBoxColumn"
        Me.MesureProposeDataGridViewTextBoxColumn.Width = 250
        '
        'commentaire
        '
        Me.commentaire.DataPropertyName = "commentaire"
        Me.commentaire.HeaderText = "Commentaire"
        Me.commentaire.Name = "commentaire"
        Me.commentaire.Width = 250
        '
        'NiveauPreventionDataGridViewTextBoxColumn
        '
        Me.NiveauPreventionDataGridViewTextBoxColumn.DataPropertyName = "niveauPrevention"
        Me.NiveauPreventionDataGridViewTextBoxColumn.HeaderText = "Niveau prévention"
        Me.NiveauPreventionDataGridViewTextBoxColumn.Items.AddRange(New Object() {"Faible", "Moyen", "Bon"})
        Me.NiveauPreventionDataGridViewTextBoxColumn.Name = "NiveauPreventionDataGridViewTextBoxColumn"
        Me.NiveauPreventionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NiveauPreventionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NiveauPreventionDataGridViewTextBoxColumn.Width = 150
        '
        'IdentifiantDataGridViewTextBoxColumn
        '
        Me.IdentifiantDataGridViewTextBoxColumn.DataPropertyName = "identifiant"
        Me.IdentifiantDataGridViewTextBoxColumn.HeaderText = "Modifié par"
        Me.IdentifiantDataGridViewTextBoxColumn.Name = "IdentifiantDataGridViewTextBoxColumn"
        Me.IdentifiantDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdentifiantDataGridViewTextBoxColumn.Width = 150
        '
        'DateModifDataGridViewTextBoxColumn
        '
        Me.DateModifDataGridViewTextBoxColumn.DataPropertyName = "dateModif"
        Me.DateModifDataGridViewTextBoxColumn.HeaderText = "Modifié le"
        Me.DateModifDataGridViewTextBoxColumn.Name = "DateModifDataGridViewTextBoxColumn"
        Me.DateModifDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateModifDataGridViewTextBoxColumn.Width = 150
        '
        'Suppr
        '
        Me.Suppr.DataPropertyName = "idRisque"
        Me.Suppr.HeaderText = ""
        Me.Suppr.Name = "Suppr"
        Me.Suppr.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Suppr.Text = "X"
        Me.Suppr.UseColumnTextForButtonValue = True
        Me.Suppr.Width = 40
        '
        'LabelProc
        '
        Me.LabelProc.AutoSize = True
        Me.LabelProc.Location = New System.Drawing.Point(9, 28)
        Me.LabelProc.Name = "LabelProc"
        Me.LabelProc.Size = New System.Drawing.Size(59, 13)
        Me.LabelProc.TabIndex = 8
        Me.LabelProc.Text = "Processus "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Activités"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Risques"
        '
        'AdministrateurToolStripMenuItem
        '
        Me.AdministrateurToolStripMenuItem.Name = "AdministrateurToolStripMenuItem"
        Me.AdministrateurToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.AdministrateurToolStripMenuItem.Text = "Administrateur"
        Me.AdministrateurToolStripMenuItem.Visible = False
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1832, 438)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelProc)
        Me.Controls.Add(Me.ButtonAjoutRisque)
        Me.Controls.Add(Me.ButtonAjoutActivite)
        Me.Controls.Add(Me.ButtonAjoutProcessus)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBoxActivite)
        Me.Controls.Add(Me.ComboBoxProcessus)
        Me.Controls.Add(Me.CheckedListBoxRisque)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainPage"
        Me.Text = "MainPage"
        CType(Me.DuercontientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetContient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckedListBoxRisque As System.Windows.Forms.CheckedListBox
    Friend WithEvents ComboBoxProcessus As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxActivite As System.Windows.Forms.ComboBox
    Friend WithEvents DataSetContient As PreventionRisque2.DataSetContient
    Friend WithEvents DuercontientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Duer_contientTableAdapter As PreventionRisque2.DataSetContientTableAdapters.duer_contientTableAdapter
    Friend WithEvents ButtonAjoutProcessus As System.Windows.Forms.Button
    Friend WithEvents ButtonAjoutActivite As System.Windows.Forms.Button
    Friend WithEvents ButtonAjoutRisque As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FermerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SociétéToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SRIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RIGAUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdRisqueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FrequenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GraviteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreventionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CriticiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MesureExistanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MesureProposeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents commentaire As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NiveauPreventionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents IdentifiantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateModifDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Suppr As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents LabelProc As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AdministrateurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
