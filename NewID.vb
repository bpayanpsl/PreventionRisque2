Imports System.Data.SqlClient

Public Class NewID

    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        Me.Close()
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        If TextBoxID.Text = "" Or TextBoxMDP.Text = "" Or TextBoxMDP2.Text = "" Then
            MsgBox("Veuillez remplir tout les champs.", vbOKOnly + vbExclamation, "Avertissement")
            If TextBoxID.Text = "" Then
                TextBoxID.BackColor = Color.LightSteelBlue
            Else
                TextBoxID.BackColor = Color.White
            End If
            If TextBoxMDP.Text = "" Then
                TextBoxMDP.BackColor = Color.LightSteelBlue
            Else
                TextBoxMDP.BackColor = Color.White
            End If
            If TextBoxMDP2.Text = "" Then
                TextBoxMDP2.BackColor = Color.LightSteelBlue
            Else
                TextBoxMDP2.BackColor = Color.White
            End If
        ElseIf TextBoxMDP.Text <> TextBoxMDP2.Text Then
            MsgBox("Les mots de passe ne correspondent pas.", vbOKOnly + vbExclamation, "Avertissement")
            TextBoxMDP.BackColor = Color.LightSteelBlue
            TextBoxMDP2.BackColor = Color.LightSteelBlue
        Else
            TextBoxID.BackColor = Color.White
            TextBoxMDP.BackColor = Color.White
            TextBoxMDP2.BackColor = Color.White
            con.Open()
            Dim query As String = "SELECT identifiant FROM GPSQL.duer_user WHERE identifiant = '" & TextBoxID.Text & "'"
            Dim command As New SqlCommand(query, con)
            Dim reader As SqlDataReader = command.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                MsgBox("Cet identifiant existe déjà.", vbOKOnly + vbExclamation, "Avertissement")
                reader.Close()
                con.Close()
            Else
                reader.Close()
                con.Close()
                con.Open()
                query = "INSERT INTO GPSQL.duer_user VALUES ('" & TextBoxID.Text & "','" & TextBoxMDP.Text & "','1')"
                command = New SqlCommand(query, con)
                command.ExecuteNonQuery()
                con.Close()
                MsgBox("Identifiants enregistrés avec succès.", vbOKOnly)
                TextBoxID.Clear()
                TextBoxMDP.Clear()
                TextBoxMDP2.Clear()
                Me.Close()
            End If
        End If
    End Sub
End Class