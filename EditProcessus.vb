Imports System.Data.SqlClient

Public Class EditProcessus

    Private Sub EditProcessus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To MainPage.ComboBoxProcessus.Items.Count - 1
            CheckedListBoxTotalProc.Items.Add(MainPage.ComboBoxProcessus.Items(i))
        Next
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Me.Close()
    End Sub

    Private Sub ButtonSuppr_Click(sender As Object, e As EventArgs) Handles ButtonSuppr.Click
        For Each item In CheckedListBoxTotalProc.CheckedItems
            con.Open()
            Dim query As String = "DELETE FROM GPSQL.duer_modif WHERE idProcessus = '" + item.ToString + "'; DELETE FROM GPSQL.duer_rapportsecurite WHERE idProcessus = '" + item.ToString + "'; DELETE FROM GPSQL.duer_appartient WHERE idProcessus = '" + item.ToString + "'; DELETE FROM GPSQL.duer_contient WHERE idProcessus = '" + item.ToString + "'; DELETE FROM GPSQL.duer_processus WHERE idProcessus = '" + item.ToString + "';"
            Dim command As New SqlClient.SqlCommand(query, con)
            command.ExecuteNonQuery()
            con.Close()
        Next
        While CheckedListBoxTotalProc.CheckedItems.Count > 0
            CheckedListBoxTotalProc.Items.RemoveAt(CheckedListBoxTotalProc.CheckedIndices(0))
        End While
    End Sub

    Private Sub ButtonAjouter_Click(sender As Object, e As EventArgs) Handles ButtonAjouter.Click
        If TextBoxNewProc.Text = "" Then
            TextBoxNewProc.BackColor = Color.LightSteelBlue
        Else
            CheckedListBoxTotalProc.Items.Add(TextBoxNewProc.Text)
            con.Open()
            Dim query As String = "INSERT INTO gpsql.duer_processus VALUES ('" & TextBoxNewProc.Text & "')"
            Dim command As New SqlCommand(query, con)
            command.ExecuteNonQuery()
            con.Close()
            TextBoxNewProc.Clear()
        End If
    End Sub
End Class