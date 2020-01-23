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
        ComboBoxActivite.Items.Clear()
        con.Open()
        Dim query As String = "SELECT idActivite FROM GPSQL.duer_appartient WHERE idProcessus = '" & ComboBoxProcessus.Text & "' AND societe = '" & societe & "'"
        Dim command As New SqlCommand(query, con)
        Dim reader As SqlDataReader = command.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                ComboBoxActivite.Items.Add(reader("idActivite"))
            End While
        End If
        reader.Close()
        con.Close()
    End Sub

    Private Sub ComboBoxActivite_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxActivite.SelectedIndexChanged
        rempliRisques()
    End Sub

    Private Sub rempliRisques()
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
End Class