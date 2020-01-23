Imports System.Data.SqlClient

Public Class EditActivite

    Private Sub EditActivite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        'con.Open()
        'query = "SELECT idActivite FROM GPSQL.duer_appartient WHERE idProcessus = '" & MainPage.ComboBoxProcessus.Text & "' ORDER BY idActivite"
        'command = New SqlCommand(query, con)
        'reader = command.ExecuteReader
        'If reader.HasRows Then
        '    While reader.Read
        '        CheckedListBoxSelectAct.Items.Add(reader("idActivite"))
        '    End While
        'End If
        'reader.Close()
        'con.Close()

        For i = 0 To MainPage.ComboBoxActivite.Items.Count - 1
            CheckedListBoxSelectAct.Items.Add(MainPage.ComboBoxActivite.Items(i))
        Next
    End Sub

    Private Sub ButtonAjout_Click(sender As Object, e As EventArgs) Handles ButtonAjout.Click
        For Each item In CheckedListBoxTotalAct.CheckedItems
            CheckedListBoxSelectAct.Items.Add(item)
        Next
        While CheckedListBoxTotalAct.CheckedItems.Count > 0
            CheckedListBoxTotalAct.Items.RemoveAt(CheckedListBoxTotalAct.CheckedIndices(0))
        End While
    End Sub

    Private Sub ButtonSuppr_Click(sender As Object, e As EventArgs) Handles ButtonSuppr.Click
        For Each item In CheckedListBoxSelectAct.CheckedItems
            CheckedListBoxTotalAct.Items.Add(item)
        Next
        While CheckedListBoxSelectAct.CheckedItems.Count > 0
            CheckedListBoxSelectAct.Items.RemoveAt(CheckedListBoxSelectAct.CheckedIndices(0))
        End While
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        con.Open()
        Dim query As String = "DELETE FROM GPSQL.duer_appartient WHERE idProcessus = '" & MainPage.ComboBoxProcessus.Text & "'"
        Dim command As New SqlCommand(query, con)
        command.ExecuteNonQuery()
        con.Close()

        For i = 0 To CheckedListBoxSelectAct.Items.Count - 1
            con.Open()
            query = "INSERT INTO GPSQL.duer_appartient VALUES ('" & MainPage.ComboBoxProcessus.Text & "', '" & CheckedListBoxSelectAct.Items(i).ToString & "', '" & societe & "')"
            command = New SqlCommand(query, con)
            command.ExecuteNonQuery()
            con.Close()
        Next
        chargeActivites()
        Me.Close()
    End Sub
End Class