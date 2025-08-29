Public Class BedList
    Private Sub BedBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.BedBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataDictionaryDataSet)

    End Sub

    Private Sub BedList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDictionaryDataSet.Bed' table. You can move, or remove it, as needed.
        Me.BedTableAdapter.Fill(Me.DataDictionaryDataSet.Bed)

    End Sub
End Class