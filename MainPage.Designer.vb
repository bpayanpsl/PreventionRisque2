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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DuercontientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetContient = New PreventionRisque2.DataSetContient()
        Me.Duer_contientTableAdapter = New PreventionRisque2.DataSetContientTableAdapters.duer_contientTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FermerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SociétéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SRIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RIGAUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CheckedListBoxRisque = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxProcessus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxActivite = New System.Windows.Forms.ComboBox()
        Me.LabelProc = New System.Windows.Forms.Label()
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
        Me.ButtonAjoutRisque = New System.Windows.Forms.Button()
        Me.ButtonAjoutProcessus = New System.Windows.Forms.Button()
        Me.ButtonAjoutActivite = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ComboBoxTriCrit = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTriProc = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IdProcessusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdActiviteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdRisqueDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FrequenceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GraviteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreventionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CriticiteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentaireDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesureExistanteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesureProposeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NiveauPreventionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentifiantDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateModifDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DuercontientBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Contient1DataSet = New PreventionRisque2.Contient1DataSet()
        Me.Duer_contientTableAdapter1 = New PreventionRisque2.Contient1DataSetTableAdapters.duer_contientTableAdapter()
        CType(Me.DuercontientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetContient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DuercontientBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contient1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'AdministrateurToolStripMenuItem
        '
        Me.AdministrateurToolStripMenuItem.Name = "AdministrateurToolStripMenuItem"
        Me.AdministrateurToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.AdministrateurToolStripMenuItem.Text = "Administrateur"
        Me.AdministrateurToolStripMenuItem.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1808, 531)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CheckedListBoxRisque)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.ComboBoxProcessus)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.ComboBoxActivite)
        Me.TabPage2.Controls.Add(Me.LabelProc)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.ButtonAjoutRisque)
        Me.TabPage2.Controls.Add(Me.ButtonAjoutProcessus)
        Me.TabPage2.Controls.Add(Me.ButtonAjoutActivite)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1800, 505)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Saisie"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CheckedListBoxRisque
        '
        Me.CheckedListBoxRisque.CheckOnClick = True
        Me.CheckedListBoxRisque.FormattingEnabled = True
        Me.CheckedListBoxRisque.Location = New System.Drawing.Point(6, 109)
        Me.CheckedListBoxRisque.Name = "CheckedListBoxRisque"
        Me.CheckedListBoxRisque.Size = New System.Drawing.Size(359, 304)
        Me.CheckedListBoxRisque.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Risques"
        '
        'ComboBoxProcessus
        '
        Me.ComboBoxProcessus.FormattingEnabled = True
        Me.ComboBoxProcessus.Location = New System.Drawing.Point(6, 29)
        Me.ComboBoxProcessus.Name = "ComboBoxProcessus"
        Me.ComboBoxProcessus.Size = New System.Drawing.Size(317, 21)
        Me.ComboBoxProcessus.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Activités"
        '
        'ComboBoxActivite
        '
        Me.ComboBoxActivite.FormattingEnabled = True
        Me.ComboBoxActivite.Location = New System.Drawing.Point(6, 69)
        Me.ComboBoxActivite.Name = "ComboBoxActivite"
        Me.ComboBoxActivite.Size = New System.Drawing.Size(317, 21)
        Me.ComboBoxActivite.TabIndex = 13
        '
        'LabelProc
        '
        Me.LabelProc.AutoSize = True
        Me.LabelProc.Location = New System.Drawing.Point(3, 13)
        Me.LabelProc.Name = "LabelProc"
        Me.LabelProc.Size = New System.Drawing.Size(59, 13)
        Me.LabelProc.TabIndex = 18
        Me.LabelProc.Text = "Processus "
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRisqueDataGridViewTextBoxColumn, Me.DetailDataGridViewTextBoxColumn, Me.FrequenceDataGridViewTextBoxColumn, Me.GraviteDataGridViewTextBoxColumn, Me.PreventionDataGridViewTextBoxColumn, Me.CriticiteDataGridViewTextBoxColumn, Me.MesureExistanteDataGridViewTextBoxColumn, Me.MesureProposeDataGridViewTextBoxColumn, Me.commentaire, Me.NiveauPreventionDataGridViewTextBoxColumn, Me.IdentifiantDataGridViewTextBoxColumn, Me.DateModifDataGridViewTextBoxColumn, Me.Suppr})
        Me.DataGridView1.DataSource = Me.DuercontientBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(420, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.Size = New System.Drawing.Size(1305, 382)
        Me.DataGridView1.TabIndex = 14
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FrequenceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.FrequenceDataGridViewTextBoxColumn.HeaderText = "F"
        Me.FrequenceDataGridViewTextBoxColumn.Name = "FrequenceDataGridViewTextBoxColumn"
        Me.FrequenceDataGridViewTextBoxColumn.Width = 20
        '
        'GraviteDataGridViewTextBoxColumn
        '
        Me.GraviteDataGridViewTextBoxColumn.DataPropertyName = "gravite"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.GraviteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.GraviteDataGridViewTextBoxColumn.HeaderText = "G"
        Me.GraviteDataGridViewTextBoxColumn.Name = "GraviteDataGridViewTextBoxColumn"
        Me.GraviteDataGridViewTextBoxColumn.Width = 20
        '
        'PreventionDataGridViewTextBoxColumn
        '
        Me.PreventionDataGridViewTextBoxColumn.DataPropertyName = "prevention"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PreventionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
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
        'ButtonAjoutRisque
        '
        Me.ButtonAjoutRisque.Location = New System.Drawing.Point(371, 233)
        Me.ButtonAjoutRisque.Name = "ButtonAjoutRisque"
        Me.ButtonAjoutRisque.Size = New System.Drawing.Size(43, 38)
        Me.ButtonAjoutRisque.TabIndex = 17
        Me.ButtonAjoutRisque.Text = ">"
        Me.ButtonAjoutRisque.UseVisualStyleBackColor = True
        '
        'ButtonAjoutProcessus
        '
        Me.ButtonAjoutProcessus.Location = New System.Drawing.Point(329, 29)
        Me.ButtonAjoutProcessus.Name = "ButtonAjoutProcessus"
        Me.ButtonAjoutProcessus.Size = New System.Drawing.Size(36, 23)
        Me.ButtonAjoutProcessus.TabIndex = 15
        Me.ButtonAjoutProcessus.Text = "+ / -"
        Me.ButtonAjoutProcessus.UseVisualStyleBackColor = True
        '
        'ButtonAjoutActivite
        '
        Me.ButtonAjoutActivite.Location = New System.Drawing.Point(329, 67)
        Me.ButtonAjoutActivite.Name = "ButtonAjoutActivite"
        Me.ButtonAjoutActivite.Size = New System.Drawing.Size(36, 23)
        Me.ButtonAjoutActivite.TabIndex = 16
        Me.ButtonAjoutActivite.Text = "+ / -"
        Me.ButtonAjoutActivite.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ComboBoxTriCrit)
        Me.TabPage1.Controls.Add(Me.ComboBoxTriProc)
        Me.TabPage1.Controls.Add(Me.DataGridView2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1800, 505)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ComboBoxTriCrit
        '
        Me.ComboBoxTriCrit.FormattingEnabled = True
        Me.ComboBoxTriCrit.Items.AddRange(New Object() {"Faible", "Moyenne", "Importante", "Grave"})
        Me.ComboBoxTriCrit.Location = New System.Drawing.Point(754, 46)
        Me.ComboBoxTriCrit.Name = "ComboBoxTriCrit"
        Me.ComboBoxTriCrit.Size = New System.Drawing.Size(180, 21)
        Me.ComboBoxTriCrit.TabIndex = 2
        '
        'ComboBoxTriProc
        '
        Me.ComboBoxTriProc.FormattingEnabled = True
        Me.ComboBoxTriProc.Location = New System.Drawing.Point(754, 19)
        Me.ComboBoxTriProc.Name = "ComboBoxTriProc"
        Me.ComboBoxTriProc.Size = New System.Drawing.Size(180, 21)
        Me.ComboBoxTriProc.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProcessusDataGridViewTextBoxColumn, Me.IdActiviteDataGridViewTextBoxColumn, Me.IdRisqueDataGridViewTextBoxColumn1, Me.DetailDataGridViewTextBoxColumn1, Me.FrequenceDataGridViewTextBoxColumn1, Me.GraviteDataGridViewTextBoxColumn1, Me.PreventionDataGridViewTextBoxColumn1, Me.CriticiteDataGridViewTextBoxColumn1, Me.CommentaireDataGridViewTextBoxColumn, Me.MesureExistanteDataGridViewTextBoxColumn1, Me.MesureProposeDataGridViewTextBoxColumn1, Me.NiveauPreventionDataGridViewTextBoxColumn1, Me.IdentifiantDataGridViewTextBoxColumn1, Me.DateModifDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.DuercontientBindingSource1
        Me.DataGridView2.Location = New System.Drawing.Point(59, 79)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(1642, 359)
        Me.DataGridView2.TabIndex = 0
        '
        'IdProcessusDataGridViewTextBoxColumn
        '
        Me.IdProcessusDataGridViewTextBoxColumn.DataPropertyName = "idProcessus"
        Me.IdProcessusDataGridViewTextBoxColumn.HeaderText = "Processus"
        Me.IdProcessusDataGridViewTextBoxColumn.Name = "IdProcessusDataGridViewTextBoxColumn"
        Me.IdProcessusDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProcessusDataGridViewTextBoxColumn.Width = 150
        '
        'IdActiviteDataGridViewTextBoxColumn
        '
        Me.IdActiviteDataGridViewTextBoxColumn.DataPropertyName = "idActivite"
        Me.IdActiviteDataGridViewTextBoxColumn.HeaderText = "Activite"
        Me.IdActiviteDataGridViewTextBoxColumn.Name = "IdActiviteDataGridViewTextBoxColumn"
        Me.IdActiviteDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdActiviteDataGridViewTextBoxColumn.Width = 200
        '
        'IdRisqueDataGridViewTextBoxColumn1
        '
        Me.IdRisqueDataGridViewTextBoxColumn1.DataPropertyName = "idRisque"
        Me.IdRisqueDataGridViewTextBoxColumn1.HeaderText = "Risque"
        Me.IdRisqueDataGridViewTextBoxColumn1.Name = "IdRisqueDataGridViewTextBoxColumn1"
        Me.IdRisqueDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdRisqueDataGridViewTextBoxColumn1.Width = 200
        '
        'DetailDataGridViewTextBoxColumn1
        '
        Me.DetailDataGridViewTextBoxColumn1.DataPropertyName = "detail"
        Me.DetailDataGridViewTextBoxColumn1.HeaderText = "Detail"
        Me.DetailDataGridViewTextBoxColumn1.Name = "DetailDataGridViewTextBoxColumn1"
        Me.DetailDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DetailDataGridViewTextBoxColumn1.Width = 200
        '
        'FrequenceDataGridViewTextBoxColumn1
        '
        Me.FrequenceDataGridViewTextBoxColumn1.DataPropertyName = "frequence"
        Me.FrequenceDataGridViewTextBoxColumn1.HeaderText = "F"
        Me.FrequenceDataGridViewTextBoxColumn1.Name = "FrequenceDataGridViewTextBoxColumn1"
        Me.FrequenceDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FrequenceDataGridViewTextBoxColumn1.Width = 20
        '
        'GraviteDataGridViewTextBoxColumn1
        '
        Me.GraviteDataGridViewTextBoxColumn1.DataPropertyName = "gravite"
        Me.GraviteDataGridViewTextBoxColumn1.HeaderText = "G"
        Me.GraviteDataGridViewTextBoxColumn1.Name = "GraviteDataGridViewTextBoxColumn1"
        Me.GraviteDataGridViewTextBoxColumn1.ReadOnly = True
        Me.GraviteDataGridViewTextBoxColumn1.Width = 20
        '
        'PreventionDataGridViewTextBoxColumn1
        '
        Me.PreventionDataGridViewTextBoxColumn1.DataPropertyName = "prevention"
        Me.PreventionDataGridViewTextBoxColumn1.HeaderText = "P"
        Me.PreventionDataGridViewTextBoxColumn1.Name = "PreventionDataGridViewTextBoxColumn1"
        Me.PreventionDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PreventionDataGridViewTextBoxColumn1.Width = 20
        '
        'CriticiteDataGridViewTextBoxColumn1
        '
        Me.CriticiteDataGridViewTextBoxColumn1.DataPropertyName = "criticite"
        Me.CriticiteDataGridViewTextBoxColumn1.HeaderText = "Criticite"
        Me.CriticiteDataGridViewTextBoxColumn1.Name = "CriticiteDataGridViewTextBoxColumn1"
        Me.CriticiteDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CommentaireDataGridViewTextBoxColumn
        '
        Me.CommentaireDataGridViewTextBoxColumn.DataPropertyName = "commentaire"
        Me.CommentaireDataGridViewTextBoxColumn.HeaderText = "Commentaire"
        Me.CommentaireDataGridViewTextBoxColumn.Name = "CommentaireDataGridViewTextBoxColumn"
        Me.CommentaireDataGridViewTextBoxColumn.ReadOnly = True
        Me.CommentaireDataGridViewTextBoxColumn.Width = 200
        '
        'MesureExistanteDataGridViewTextBoxColumn1
        '
        Me.MesureExistanteDataGridViewTextBoxColumn1.DataPropertyName = "mesureExistante"
        Me.MesureExistanteDataGridViewTextBoxColumn1.HeaderText = "Mesures existantes"
        Me.MesureExistanteDataGridViewTextBoxColumn1.Name = "MesureExistanteDataGridViewTextBoxColumn1"
        Me.MesureExistanteDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MesureExistanteDataGridViewTextBoxColumn1.Width = 200
        '
        'MesureProposeDataGridViewTextBoxColumn1
        '
        Me.MesureProposeDataGridViewTextBoxColumn1.DataPropertyName = "mesurePropose"
        Me.MesureProposeDataGridViewTextBoxColumn1.HeaderText = "Mesures proposées"
        Me.MesureProposeDataGridViewTextBoxColumn1.Name = "MesureProposeDataGridViewTextBoxColumn1"
        Me.MesureProposeDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MesureProposeDataGridViewTextBoxColumn1.Width = 200
        '
        'NiveauPreventionDataGridViewTextBoxColumn1
        '
        Me.NiveauPreventionDataGridViewTextBoxColumn1.DataPropertyName = "niveauPrevention"
        Me.NiveauPreventionDataGridViewTextBoxColumn1.HeaderText = "Niveau prévention"
        Me.NiveauPreventionDataGridViewTextBoxColumn1.Name = "NiveauPreventionDataGridViewTextBoxColumn1"
        Me.NiveauPreventionDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'IdentifiantDataGridViewTextBoxColumn1
        '
        Me.IdentifiantDataGridViewTextBoxColumn1.DataPropertyName = "identifiant"
        Me.IdentifiantDataGridViewTextBoxColumn1.HeaderText = "Modifié par"
        Me.IdentifiantDataGridViewTextBoxColumn1.Name = "IdentifiantDataGridViewTextBoxColumn1"
        Me.IdentifiantDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DateModifDataGridViewTextBoxColumn1
        '
        Me.DateModifDataGridViewTextBoxColumn1.DataPropertyName = "dateModif"
        Me.DateModifDataGridViewTextBoxColumn1.HeaderText = "Modifié le"
        Me.DateModifDataGridViewTextBoxColumn1.Name = "DateModifDataGridViewTextBoxColumn1"
        Me.DateModifDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DuercontientBindingSource1
        '
        Me.DuercontientBindingSource1.DataMember = "duer_contient"
        Me.DuercontientBindingSource1.DataSource = Me.Contient1DataSet
        '
        'Contient1DataSet
        '
        Me.Contient1DataSet.DataSetName = "Contient1DataSet"
        Me.Contient1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Duer_contientTableAdapter1
        '
        Me.Duer_contientTableAdapter1.ClearBeforeFill = True
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1832, 566)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainPage"
        Me.Text = "MainPage"
        CType(Me.DuercontientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetContient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DuercontientBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contient1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetContient As PreventionRisque2.DataSetContient
    Friend WithEvents DuercontientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Duer_contientTableAdapter As PreventionRisque2.DataSetContientTableAdapters.duer_contientTableAdapter
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FermerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SociétéToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SRIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RIGAUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrateurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents CheckedListBoxRisque As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxProcessus As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxActivite As System.Windows.Forms.ComboBox
    Friend WithEvents LabelProc As System.Windows.Forms.Label
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
    Friend WithEvents ButtonAjoutRisque As System.Windows.Forms.Button
    Friend WithEvents ButtonAjoutProcessus As System.Windows.Forms.Button
    Friend WithEvents ButtonAjoutActivite As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents IdProcessusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdActiviteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdRisqueDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetailDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FrequenceDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GraviteDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreventionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CriticiteDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentaireDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MesureExistanteDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MesureProposeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NiveauPreventionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdentifiantDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateModifDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contient1DataSet As PreventionRisque2.Contient1DataSet
    Friend WithEvents DuercontientBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Duer_contientTableAdapter1 As PreventionRisque2.Contient1DataSetTableAdapters.duer_contientTableAdapter
    Friend WithEvents ComboBoxTriCrit As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxTriProc As System.Windows.Forms.ComboBox
End Class
