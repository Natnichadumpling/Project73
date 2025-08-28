Public Class Waiting_List
    Private Sub Waiting_ListBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Waiting_ListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataDictionaryDataSet)

    End Sub

    Private Sub Waiting_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDictionaryDataSet.Waiting_List' table. You can move, or remove it, as needed.
        Me.Waiting_ListTableAdapter.Fill(Me.DataDictionaryDataSet.Waiting_List)

    End Sub
End Class