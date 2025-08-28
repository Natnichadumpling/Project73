Public Class In_Patient_Report
    Private Sub In_PatientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.In_PatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataDictionaryDataSet)

    End Sub

    Private Sub In_Patient_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDictionaryDataSet.In_Patient' table. You can move, or remove it, as needed.
        Me.In_PatientTableAdapter.Fill(Me.DataDictionaryDataSet.In_Patient)

    End Sub
End Class