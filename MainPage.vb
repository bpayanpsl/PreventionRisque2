Imports System.Data.SqlClient

Public Class MainPage

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargeProcessus()
    End Sub

    Private Sub ChargeRisques()
        ' Peut etre pas utile
        For i = 0 To TabRisquesLigne - 1
            CheckedListBoxRisque.Items.Add(tabRisques(i, 0))
        Next
    End Sub

    Private Sub ChargeProcessus()
        For i = 0 To tabProcessusLigne - 1
            ComboBoxProcessus.Items.Add(tabProcessus(i, 0))
        Next
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
        EditProcessus.Show()
    End Sub

    Private Sub ButtonAjoutActivite_Click(sender As Object, e As EventArgs) Handles ButtonAjoutActivite.Click
        EditActivite.Show()
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        calculeCriticite()
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
        Me.Duer_contientTableAdapter.FillByProcActSoc(Me.DataSetContient.duer_contient, ComboBoxProcessus.Text, ComboBoxActivite.Text, societe.ToString)
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
    End Sub
End Class