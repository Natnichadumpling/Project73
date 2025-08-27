Public Class Patient
    Private Sub btnManagePatient_Click(sender As Object, e As EventArgs) Handles btnManagePatient.Click
        Dim Manage_PatientForm As New Manage_Patient()
        Manage_Patient.Show()
    End Sub

    Private Sub btnWaitinglist_Click(sender As Object, e As EventArgs) Handles btnWaitinglist.Click
        Dim Waiting_ListForm As New Waiting_List()
        Waiting_List.Show()
    End Sub

    Private Sub btnInPatientReport_Click(sender As Object, e As EventArgs) Handles btnInPatientReport.Click
        Dim In_Patient_ReportForm As New In_Patient_Report()
        In_Patient_Report.Show()
    End Sub

    Private Sub btnOutPatientReport_Click(sender As Object, e As EventArgs) Handles btnOutPatientReport.Click
        Dim Out_Patient_ReportForm As New Out_Patient_Report()
        Out_Patient_Report.Show()
    End Sub
End Class