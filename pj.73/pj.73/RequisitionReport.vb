Public Class RequisitionReport
    Private Sub RequsitionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDictionaryDataSet.Requestion' table. You can move, or remove it, as needed.
        Me.RequestionTableAdapter.Fill(Me.DataDictionaryDataSet.Requestion)

    End Sub

    Private Sub RequestionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RequestionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataDictionaryDataSet)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class