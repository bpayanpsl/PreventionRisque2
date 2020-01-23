Public Class EditProcessus

    Private Sub EditProcessus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To MainPage.ComboBoxProcessus.Items.Count - 1
            CheckedListBoxSelectProc.Items.Add(MainPage.ComboBoxProcessus.Items(i))
        Next

        Dim ok As Boolean = True

        For i = 0 To tabProcessusLigne - 1
            For j = 0 To CheckedListBoxSelectProc.Items.Count - 1
                If CheckedListBoxSelectProc.Items(j).ToString = tabProcessus(i, 0) Then
                    ok = False
                End If
            Next
            If ok Then CheckedListBoxTotalProc.Items.Add(tabProcessus(i, 0))
        Next
    End Sub
End Class