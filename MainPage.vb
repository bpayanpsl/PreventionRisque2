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
        Me.Width = 1770
        Me.Height = 600
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

    Private Sub ComboBoxProcessus_SelectedIndexChanged(sender As Object, e As EventArgs)
        chargeActivites()
        CheckedListBoxRisque.Items.Clear()
        ComboBoxActivite.Enabled = True
        ButtonAjoutActivite.Enabled = True
        ButtonAjoutRisque.Enabled = False
    End Sub

    Private Sub ComboBoxActivite_SelectedIndexChanged(sender As Object, e As EventArgs)
        rempliRisques()
        Me.Duer_contientTableAdapter.FillByProcActSoc(Me.DataSetContient.duer_contient, ComboBoxProcessus.Text, ComboBoxActivite.Text, societe.ToString)
        calculeCriticite()
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

    Private Sub ButtonAjoutProcessus_Click(sender As Object, e As EventArgs)
        EditProcessus.ShowDialog()
        ChargeProcessus()
    End Sub

    Private Sub ButtonAjoutActivite_Click(sender As Object, e As EventArgs)
        EditActivite.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        calculeCriticite()
        DataGridView1.CurrentRow.Cells(10).Value = identifiant
        DataGridView1.CurrentRow.Cells(11).Value = Date.Now
        DuercontientBindingSource.EndEdit()
        If Me.DataSetContient.HasChanges Then
            Me.Duer_contientTableAdapter.Update(Me.DataSetContient.duer_contient)
        End If
    End Sub

    Private Sub calculeCriticite()
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(2).Value Is DBNull.Value Or row.Cells(2).Value Is Nothing Then
                row.Cells(2).Value = 0
            End If
            If row.Cells(3).Value Is DBNull.Value Or row.Cells(3).Value Is Nothing Then
                row.Cells(3).Value = 0
            End If
            row.Cells(4).Value = row.Cells(2).Value * row.Cells(3).Value
            If row.Cells(4).Value < 25 Then
                row.Cells(5).Value = "Faible"
                row.Cells(5).Style.BackColor = Color.FromArgb(0, 255, 74)
            ElseIf row.Cells(4).Value >= 25 And row.Cells(4).Value < 50 Then
                row.Cells(5).Value = "Moyenne"
                row.Cells(5).Style.BackColor = Color.FromArgb(255, 255, 74)
            ElseIf row.Cells(4).Value >= 50 And row.Cells(4).Value < 75 Then
                row.Cells(5).Value = "Importante"
                row.Cells(5).Style.BackColor = Color.FromArgb(255, 128, 32)
            ElseIf row.Cells(4).Value >= 75 Then
                row.Cells(5).Value = "Grave"
                row.Cells(5).Style.BackColor = Color.FromArgb(255, 32, 0)
            End If
        Next
    End Sub

    Private Sub ButtonAjoutRisque_Click(sender As Object, e As EventArgs)
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
        calculeCriticite()
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

        ComboBoxActivite.Enabled = False
        ButtonAjoutActivite.Enabled = False
        ButtonAjoutRisque.Enabled = False
    End Sub

    Private Sub ToolStripMenuItemSuppr_Click(sender As Object, e As EventArgs)
        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
        DataGridView1.ClearSelection()
    End Sub

    Private Sub DataGridView1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs)
        DuercontientBindingSource.EndEdit()
        If Me.DataSetContient.HasChanges Then
            Me.Duer_contientTableAdapter.Update(Me.DataSetContient.duer_contient)
        End If
        rempliRisques()
    End Sub

    Private Sub DataGridView1_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs)
        calculeCriticite()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
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
                Me.Duer_contientTableAdapter1.Fill(Me.Contient1DataSet.duer_contient)
            End If

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
        End If
    End Sub
End Class