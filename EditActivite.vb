Imports System.Data.SqlClient

Public Class EditActivite

    Private Sub EditActivite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initForm()
    End Sub

    Private Sub initForm()
        CheckedListBoxTotalAct.Items.Clear()
        con.Open()
        Dim query As String = "SELECT idActivite FROM GPSQL.duer_activite WHERE idActivite NOT IN (SELECT idActivite FROM GPSQL.duer_appartient WHERE idProcessus = '" & MainPage.ComboBoxProcessus.Text & "') ORDER BY idActivite"
        Dim command As New SqlCommand(query, con)
        Dim reader As SqlDataReader = command.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                CheckedListBoxTotalAct.Items.Add(reader("idActivite"))
            End While
        End If
        reader.Close()
        con.Close()

        CheckedListBoxSelectAct.Items.Clear()
        For i = 0 To MainPage.ComboBoxActivite.Items.Count - 1
            CheckedListBoxSelectAct.Items.Add(MainPage.ComboBoxActivite.Items(i))
        Next
    End Sub

    Private Sub ButtonAjout_Click(sender As Object, e As EventArgs) Handles ButtonAjout.Click
        For Each item In CheckedListBoxTotalAct.CheckedItems
            con.Open()
            Dim query As String = "INSERT INTO GPSQL.duer_appartient VALUES ('" & MainPage.ComboBoxProcessus.Text & "', '" & item.ToString & "', '" & societe & "')"
            Dim command As New SqlCommand(query, con)
            command.ExecuteNonQuery()
            con.Close()
            CheckedListBoxSelectAct.Items.Add(item)
        Next
        While CheckedListBoxTotalAct.CheckedItems.Count > 0
            CheckedListBoxTotalAct.Items.RemoveAt(CheckedListBoxTotalAct.CheckedIndices(0))
        End While
    End Sub

    Private Sub ButtonSuppr_Click(sender As Object, e As EventArgs) Handles ButtonSuppr.Click
        For Each item In CheckedListBoxSelectAct.CheckedItems
            For i = 0 To CheckedListBoxSelectAct.Items.Count - 1
                con.Open()
                Dim query As String = "DELETE FROM GPSQL.duer_appartient WHERE idProcessus = '" & MainPage.ComboBoxProcessus.Text & "' AND idActivite = '" & item.ToString & "' AND societe = '" & societe & "'"
                Dim command As New SqlCommand(query, con)
                command.ExecuteNonQuery()
                con.Close()
            Next
            CheckedListBoxTotalAct.Items.Add(item)
        Next
        While CheckedListBoxSelectAct.CheckedItems.Count > 0
            CheckedListBoxSelectAct.Items.RemoveAt(CheckedListBoxSelectAct.CheckedIndices(0))
        End While

    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        chargeActivites()
        Me.Close()
    End Sub

    Private Sub TextboxRecherche_TextChanged(sender As Object, e As EventArgs) Handles TextboxRecherche.TextChanged
        CheckedListBoxTotalAct.Items.Clear()
        If TextboxRecherche.Text.Length = 0 Then
            initForm()
        Else
            con.Open()
            Dim query As String = "SELECT idActivite FROM GPSQL.duer_activite WHERE idActivite LIKE '" & TextboxRecherche.Text & "%'"
            Dim command As New SqlCommand(query, con)
            Dim reader As SqlDataReader = command.ExecuteReader
            If reader.HasRows Then
                While reader.Read
                    CheckedListBoxTotalAct.Items.Add(reader("idActivite"))
                End While
            End If
            reader.Close()
            con.Close()
        End If
    End Sub
End Class