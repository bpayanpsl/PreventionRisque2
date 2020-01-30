Imports System.Data.SqlClient

Module PrevUtil

    Public Sub chargeActivites()
        MainPage.ComboBoxActivite.Items.Clear()
        MainPage.ComboBoxActivite.Text = ""

        con.Open()
        Dim query As String = "SELECT idActivite FROM GPSQL.duer_appartient WHERE idProcessus = '" & MainPage.ComboBoxProcessus.Text & "' AND societe = '" & societe & "'"
        Console.WriteLine(query)
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
End Module
