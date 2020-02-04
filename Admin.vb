Imports System.Data.SqlClient

Public Class Admin

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Duer_userTableAdapter.FillByDemande(Me.UserDataSet.duer_user)
    End Sub

    Private Sub DataGridViewUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUser.CellContentClick
        Dim senderGrid = CType(sender, DataGridView)
        If TypeOf (senderGrid.Columns(e.ColumnIndex)) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridViewUser.Rows(DataGridViewUser.CurrentCell.RowIndex)
            con.Open()
            Dim query As String = "UPDATE GPSQL.duer_user SET demande = 0 WHERE identifiant = '" & row.Cells(0).Value & "' AND mdp = '" & row.Cells(1).Value & "'"
            Dim command As New SqlCommand(query, con)
            command.ExecuteNonQuery()
            con.Close()
            Me.Duer_userTableAdapter.FillByDemande(Me.UserDataSet.duer_user)
        End If
    End Sub
End Class