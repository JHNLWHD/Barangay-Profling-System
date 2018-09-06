Public Class broExistingPerson

    Private PersonObj As PersonClass
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            'CHANGE CODE/ LOAD
            frmProfiling.dgvRelative.Rows.Add(dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString,
                                              "", "", "", "",
                                               dgvBrowsePerson.SelectedRows(0).Cells(1).Value.ToString,
                                              dgvBrowsePerson.SelectedRows(0).Cells(2).Value.ToString,
                                              frmRole.cboFamilyRole.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub broPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PersonObj = New PersonClass
            With PersonObj
                .LoadPerson(dgvBrowsePerson)
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class