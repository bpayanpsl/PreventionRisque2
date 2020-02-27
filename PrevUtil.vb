Imports System.Data.SqlClient

Module PrevUtil

    Public Sub chargeActivites()
        MainPage.ComboBoxActivite.Items.Clear()
        MainPage.ComboBoxActivite.Text = ""

        con.Open()
        Dim query As String = "SELECT idActivite FROM GPSQL.duer_appartient WHERE idProcessus = '" & MainPage.ComboBoxProcessus.Text & "' AND societe = '" & societe & "'"
        Dim command As New SqlCommand(query, con)
        Dim reader As SqlDataReader = command.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                MainPage.ComboBoxActivite.Items.Add(reader("idActivite"))
            End While
        End If
        reader.Close()
        con.Close()
    End Sub

    Public Sub calculeCriticite(dgv As DataGridView)
        If dgv Is MainPage.DataGridView1 Then
            For Each row As DataGridViewRow In dgv.Rows
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
        ElseIf dgv Is MainPage.DataGridView2 Then
            For Each row As DataGridViewRow In dgv.Rows
                If row.Cells(4).Value Is DBNull.Value Or row.Cells(2).Value Is Nothing Then
                    row.Cells(4).Value = 0
                End If
                If row.Cells(5).Value Is DBNull.Value Or row.Cells(3).Value Is Nothing Then
                    row.Cells(5).Value = 0
                End If
                row.Cells(6).Value = row.Cells(4).Value * row.Cells(5).Value
                If row.Cells(6).Value < 25 Then
                    row.Cells(7).Value = "Faible"
                    row.Cells(7).Style.BackColor = Color.FromArgb(0, 255, 74)
                ElseIf row.Cells(6).Value >= 25 And row.Cells(4).Value < 50 Then
                    row.Cells(7).Value = "Moyenne"
                    row.Cells(7).Style.BackColor = Color.FromArgb(255, 255, 74)
                ElseIf row.Cells(6).Value >= 50 And row.Cells(4).Value < 75 Then
                    row.Cells(7).Value = "Importante"
                    row.Cells(7).Style.BackColor = Color.FromArgb(255, 128, 32)
                ElseIf row.Cells(6).Value >= 75 Then
                    row.Cells(7).Value = "Grave"
                    row.Cells(7).Style.BackColor = Color.FromArgb(255, 32, 0)
                End If
            Next
        End If
    End Sub
End Module
