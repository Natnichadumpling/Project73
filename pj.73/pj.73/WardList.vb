Public Class WardList
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' เปิดฟอร์ม WardList_AddWard
        Dim addWardForm As New WardList_AddWard()
        addWardForm.Show()
        Me.Hide() ' ซ่อนฟอร์มปัจจุบัน
    End Sub
End Class