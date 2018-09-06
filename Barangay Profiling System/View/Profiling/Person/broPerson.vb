Public Class broPerson

    Private PersonObj As PersonClass
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            'Pass id , basic info
            frmRole.ShowDialog()
            If frmRole.cboFamilyRole.Text = "Spouse" Then
                frmProfiling.dgvRelative.Rows.Add(dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString,
                                              "", "", "", "",
                                               dgvBrowsePerson.SelectedRows(0).Cells(1).Value.ToString,
                                              dgvBrowsePerson.SelectedRows(0).Cells(2).Value.ToString,
                                              frmRole.cboFamilyRole.Text, 1,
                                              frmRole.dtpDOM.Value.ToString("yyyy-MM-dd"), dgvBrowsePerson.SelectedRows(0).Cells(7).Value.ToString)
            Else
                frmProfiling.dgvRelative.Rows.Add(dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString,
                                              "", "", "", "",
                                               dgvBrowsePerson.SelectedRows(0).Cells(1).Value.ToString,
                                              dgvBrowsePerson.SelectedRows(0).Cells(2).Value.ToString,
                                              frmRole.cboFamilyRole.Text, 0,
                                              "", dgvBrowsePerson.SelectedRows(0).Cells(7).Value.ToString)
            End If

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