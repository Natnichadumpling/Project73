Public Class Manage_Patient
    Private Sub btnEmergency_Click(sender As Object, e As EventArgs) Handles btnEmergency.Click
        Dim Emergency_ContactForm As New Emergency_Contact()
        Emergency_Contact.Show()
    End Sub

    Private Sub btnoutpatient_Click(sender As Object, e As EventArgs) Handles btnoutpatient.Click
        Dim Out_PatientForm As New Out_Patient()
        Out_Patient.Show()
    End Sub

    Private Sub btninpatient_Click(sender As Object, e As EventArgs) Handles btninpatient.Click
        Dim In_PatientForm As New In_Patient()
        In_Patient.Show()
    End Sub
End Class