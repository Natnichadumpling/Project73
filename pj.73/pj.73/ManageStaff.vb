Public Class ManageStaff
    Private Sub ManageStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' ปุ่ม Add Qualification
    Private Sub btnAddQuali_Click(sender As Object, e As EventArgs) Handles btnAddQuali.Click
        Dim frm As New StaffQualification()
        frm.Show()
    End Sub

    ' ปุ่ม Work Experience
    Private Sub btnExper_Click(sender As Object, e As EventArgs) Handles btnExper.Click
        Dim frm As New WorkExperience()
        frm.Show()
    End Sub

    ' ปุ่ม Payroll
    Private Sub btnPayroll_Click(sender As Object, e As EventArgs) Handles btnPayroll.Click
        Dim frm As New Payroll()
        frm.Show()
    End Sub
End Class