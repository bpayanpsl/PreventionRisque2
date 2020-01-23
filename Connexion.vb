Imports System.Data.SqlClient

Public Class Connexion

    Private Sub ButtonConnexion_Click(sender As Object, e As EventArgs) Handles ButtonConnexion.Click
        If TextBoxID.Text <> "" And TextBoxMDP.Text <> "" Then
            con.Open()
            Dim query As String = "SELECT identifiant FROM GPSQL.duer_user WHERE identifiant = '" & TextBoxID.Text & "' AND mdp = '" & TextBoxMDP.Text & "'"
            Dim command As New SqlCommand(query, con)
            Dim reader As SqlDataReader = command.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                Console.WriteLine("CONNECTE")
                societe = ComboBoxSociete.Text
                identifiant = TextBoxID.Text
                MainPage.Show()
                Me.Close()
            Else
                Console.WriteLine("PAS CONNECTE")
            End If
            reader.Close()
            con.Close()
        Else
            If TextBoxID.Text = "" Then
                TextBoxID.BackColor = Color.LightSteelBlue
            End If
            If TextBoxMDP.Text = "" Then
                TextBoxMDP.BackColor = Color.LightSteelBlue
            End If
            MsgBox("Veuillez remplir tous les champs.", vbOKOnly + vbExclamation, "Erreur")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxSociete.SelectedIndex = 0
    End Sub
End Class
