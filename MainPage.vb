Imports System.Data.SqlClient

Public Class MainPage

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargeProcessus()
        If societe = "SRI" Then
            SRIToolStripMenuItem.Checked = True
        ElseIf societe = "RIGAU" Then
            RIGAUToolStripMenuItem.Checked = True
        End If
        Me.Width = 1764
        Me.Height = 440
    End Sub

    Private Sub ChargeRisques()
        ' Peut etre pas utile
        For i = 0 To TabRisquesLigne - 1
            CheckedListBoxRisque.Items.Add(tabRisques(i, 0))
        Next
    End Sub

    Private Sub ChargeProcessus()
        'For i = 0 To tabProcessusLigne - 1
        '    ComboBoxProcessus.Items.Add(tabProcessus(i, 0))
        'Next
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
    End Sub

    Private Sub ComboBoxActivite_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxActivite.SelectedIndexChanged
        rempliRisques()
        Me.Duer_contientTableAdapter.FillByProcActSoc(Me.DataSetContient.duer_contient, ComboBoxProcessus.Text, ComboBoxActivite.Text, societe.ToString)
        calculeCriticite()
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
    End Sub

    Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDown
        If DataGridView1.Rows.Count > 0 Then
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Dim hit = DataGridView1.HitTest(e.X, e.Y)
                DataGridView1.ClearSelection()
                If hit.ColumnIndex <> -1 And hit.RowIndex <> -1 Then
                    DataGridView1(hit.ColumnIndex, hit.RowIndex).Selected = True
                    DataGridView1.ContextMenuStrip = ContextMenuStrip1
                Else
                    DataGridView1.ClearSelection()
                End If
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItemSuppr_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemSuppr.Click
        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
        DataGridView1.ClearSelection()
    End Sub

    Private Sub DataGridView1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
        DuercontientBindingSource.EndEdit()
        If Me.DataSetContient.HasChanges Then
            Me.Duer_contientTableAdapter.Update(Me.DataSetContient.duer_contient)
        End If
    End Sub

    Private Sub DataGridView1_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.UserDeletedRow
        calculeCriticite()
    End Sub
End Class