Imports System.Data.SqlClient

Public Class MainPage

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargeProcessus()
        initialiseInterface()
        '' /////////////////////////////
        If societe = "" Then societe = "SRI" ' WORKAROUND
        If identifiant = "" Then identifiant = "ADMINISTRATEUR"
        '' /////////////////////////////
        If identifiant = "admin" Or identifiant = "ADMINISTRATEUR" Then AdministrateurToolStripMenuItem.Visible = True
        If societe = "SRI" Then
            SRIToolStripMenuItem.Checked = True
        ElseIf societe = "RIGAU" Then
            RIGAUToolStripMenuItem.Checked = True
        End If
        'Me.Width = 1770
        'Me.Height = 600
        DataGridView2.AutoGenerateColumns = False
    End Sub

    Private Sub ChargeProcessus()
        ' FROM LIST
        'For i = 0 To tabProcessusLigne - 1
        '    ComboBoxProcessus.Items.Add(tabProcessus(i, 0))
        'Next

        ' FROM DATABASE
        ComboBoxProcessus.Items.Clear()
        con.Open()
        Dim query As String = "SELECT idProcessus FROM gpsql.duer_processus"
        Dim command As New SqlCommand(query, con)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                ComboBoxProcessus.Items.Add(reader("idProcessus"))
            End While
        End If
        reader.Close()
        con.Close()
    End Sub

    Private Sub ComboBoxProcessus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProcessus.SelectedIndexChanged
        chargeActivites()
        CheckedListBoxRisque.Items.Clear()
        ComboBoxActivite.Enabled = True
        ButtonAjoutActivite.Enabled = True
        ButtonAjoutRisque.Enabled = False
    End Sub

    Private Sub ComboBoxActivite_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxActivite.SelectedIndexChanged
        rempliRisques()
        Me.Duer_contientTableAdapter.FillByProcActSoc(Me.DataSetContient.duer_contient, ComboBoxProcessus.Text, ComboBoxActivite.Text, societe.ToString)
        calculeCriticite(DataGridView1)
        ButtonAjoutRisque.Enabled = True
    End Sub

    Private Sub rempliRisques()
        CheckedListBoxRisque.Items.Clear()
        con.Open()
        Dim query As String = "select idRisque from gpsql.duer_risque where idRisque not in (select idRisque from gpsql.duer_contient where idProcessus = '" & ComboBoxProcessus.Text & "' and idActivite = '" & ComboBoxActivite.Text & "' and societe = '" & societe & "')"
        Dim command As New SqlCommand(query, con)
        Dim reader As SqlDataReader = command.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                CheckedListBoxRisque.Items.Add(reader("idRisque"))
            End While
        End If
        reader.Close()
        con.Close()
    End Sub

    Private Sub ButtonAjoutProcessus_Click(sender As Object, e As EventArgs) Handles ButtonAjoutProcessus.Click
        EditProcessus.ShowDialog()
        ChargeProcessus()
    End Sub

    Private Sub ButtonAjoutActivite_Click(sender As Object, e As EventArgs) Handles ButtonAjoutActivite.Click
        EditActivite.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        calculeCriticite(DataGridView1)
        DataGridView1.CurrentRow.Cells(10).Value = identifiant
        DataGridView1.CurrentRow.Cells(11).Value = Date.Now
        DuercontientBindingSource.EndEdit()
        ButtonValiderChangements.Enabled = True
    End Sub

    Private Sub ButtonAjoutRisque_Click(sender As Object, e As EventArgs) Handles ButtonAjoutRisque.Click
        For Each item In CheckedListBoxRisque.CheckedItems
            con.Open()
            Dim query As String = "INSERT INTO GPSQL.duer_contient (idProcessus, idActivite, idRisque, identifiant, dateModif, societe) VALUES ('" & ComboBoxProcessus.Text & "', '" & ComboBoxActivite.Text & "', '" & item.ToString & "', '" & identifiant & "', '" & DateTime.Now.ToString() & "', '" & societe & "')"
            Dim command As New SqlCommand(query, con)
            command.ExecuteNonQuery()
            con.Close()
        Next
        While CheckedListBoxRisque.CheckedItems.Count > 0
            CheckedListBoxRisque.Items.RemoveAt(CheckedListBoxRisque.CheckedIndices(0))
        End While
        Me.Duer_contientTableAdapter.FillByProcActSoc(Me.DataSetContient.duer_contient, ComboBoxProcessus.Text, ComboBoxActivite.Text, societe)
        calculeCriticite(DataGridView1)
    End Sub

    Private Sub FermerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermerToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SRIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SRIToolStripMenuItem.Click, RIGAUToolStripMenuItem.Click
        Dim send = CType(sender, ToolStripMenuItem)
        If send.Text = "SRI" Then
            SRIToolStripMenuItem.CheckState = CheckState.Checked
            RIGAUToolStripMenuItem.CheckState = CheckState.Unchecked
            societe = "SRI"
        ElseIf send.Text = "RIGAU" Then
            RIGAUToolStripMenuItem.CheckState = CheckState.Checked
            SRIToolStripMenuItem.CheckState = CheckState.Unchecked
            societe = "RIGAU"
        End If
        initialiseInterface()
    End Sub

    Private Sub initialiseInterface()
        ComboBoxProcessus.Text = ""
        ComboBoxActivite.Text = ""
        ComboBoxActivite.Items.Clear()
        CheckedListBoxRisque.Items.Clear()
        DataSetContient.Clear()
        DataGridView1.Refresh()
        ButtonValiderChangements.Enabled = False

        ComboBoxActivite.Enabled = False
        ButtonAjoutActivite.Enabled = False
        ButtonAjoutRisque.Enabled = False

        ComboBoxTriCrit.Text = ""
        ComboBoxTriProc.Text = ""
        If TabControl1.SelectedTab Is TabPage1 Then
            Me.Duer_contientTableAdapter1.Fill(Me.Contient1DataSet.duer_contient, societe)
        Else
            Contient1DataSet.Clear()
            DataGridView2.Refresh()
        End If
    End Sub

    Private Sub ToolStripMenuItemSuppr_Click(sender As Object, e As EventArgs)
        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
        DataGridView1.ClearSelection()
    End Sub

    Private Sub DataGridView1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
        DuercontientBindingSource.EndEdit()
        If Me.DataSetContient.HasChanges Then
            Me.Duer_contientTableAdapter.Update(Me.DataSetContient.duer_contient)
        End If
        rempliRisques()
    End Sub

    Private Sub DataGridView1_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.UserDeletedRow
        calculeCriticite(DataGridView1)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = CType(sender, DataGridView)
        If TypeOf (senderGrid.Columns(e.ColumnIndex)) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
            DataGridView1.ClearSelection()
        End If
    End Sub

    Private Sub AdministrateurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrateurToolStripMenuItem.Click
        Admin.ShowDialog()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage1 Then
            If ComboBoxTriProc.Text = "" And ComboBoxTriCrit.Text = "" Then
                Me.Duer_contientTableAdapter1.Fill(Me.Contient1DataSet.duer_contient, societe)
            End If

            ComboBoxTriProc.Items.Add("Tout")

            con.Open()
            Dim query As String = "SELECT DISTINCT idProcessus FROM GPSQL.duer_contient ORDER BY idProcessus"
            Dim command As New SqlCommand(query, con)
            Dim reader As SqlDataReader = command.ExecuteReader
            If reader.HasRows Then
                While reader.Read
                    If ComboBoxTriProc.FindString(reader("idProcessus")) = -1 Then
                        ComboBoxTriProc.Items.Add(reader("idProcessus"))
                    End If
                End While
            End If
            reader.Close()
            con.Close()
            calculeCriticite(DataGridView2)
        End If
    End Sub

    Private Sub ComboBoxTriProc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTriProc.SelectedIndexChanged
        ComboBoxTriCrit.Text = ""
        If ComboBoxTriProc.Text = "Tout" Then
            Me.Duer_contientTableAdapter1.Fill(Me.Contient1DataSet.duer_contient, societe)
        Else
            Me.Duer_contientTableAdapter1.FillByProcessus(Me.Contient1DataSet.duer_contient, ComboBoxTriProc.Text, societe)
        End If
        calculeCriticite(DataGridView2)
    End Sub

    Private Sub ComboBoxTriCrit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTriCrit.SelectedIndexChanged
        ComboBoxTriProc.Text = ""
        If ComboBoxTriCrit.Text = "Tout" Then
            Me.Duer_contientTableAdapter1.Fill(Me.Contient1DataSet.duer_contient, societe)
        Else
            Me.Duer_contientTableAdapter1.FillByCriticite(Me.Contient1DataSet.duer_contient, ComboBoxTriCrit.Text, societe)
        End If
        calculeCriticite(DataGridView2)
    End Sub

    Private Sub ButtonValiderChangements_Click(sender As Object, e As EventArgs) Handles ButtonValiderChangements.Click
        If Me.DataSetContient.HasChanges Then
            Me.Duer_contientTableAdapter.Update(Me.DataSetContient.duer_contient)
        End If
        ButtonValiderChangements.Enabled = False
    End Sub

    Private Function isTheSameValue(row As Integer)
        If row > 0 Then
            Dim cell1 As DataGridViewCell = DataGridView2.Rows(row).Cells(0)
            Dim cell2 As DataGridViewCell = DataGridView2.Rows(row - 1).Cells(0)
            If cell1 Is DBNull.Value Or cell2 Is DBNull.Value Then
                isTheSameValue = False
            Else
                isTheSameValue = cell1.Value.ToString = cell2.Value.ToString
            End If
        Else
            isTheSameValue = False
        End If
    End Function

    Private Sub DataGridView2_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView2.CellPainting
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
        If isTheSameValue(e.RowIndex) And (e.ColumnIndex = 0 Or e.ColumnIndex = 1) Then
            e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None
        Else
            e.AdvancedBorderStyle.Top = DataGridView2.AdvancedCellBorderStyle.Top
        End If
    End Sub

    Private Sub DataGridView2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView2.CellFormatting
        If e.RowIndex = 0 Then Exit Sub
        If isTheSameValue(e.RowIndex) And (e.ColumnIndex = 0 Or e.ColumnIndex = 1) Then
            e.Value = ""
            e.FormattingApplied = True
        End If
    End Sub

    Private Sub DeconnexionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeconnexionToolStripMenuItem.Click
        Connexion.Show()
        Me.Close()
    End Sub
End Class