Public Class frmComplainant

    Private PersonObj As New PersonClass
    Private Sub frmComplainant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtSearch.Text = String.Empty
            With PersonObj
                .LoadPerson(dgvBrowsePerson)
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            With PersonObj
                If txtSearch.Text.Trim.Length > 0 Then
                    .SearchPerson(dgvBrowsePerson, txtSearch.Text)
                Else
                    .LoadPerson(dgvBrowsePerson)
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            frmCase.dgvComplainant.Rows.Add(dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString, "", "", "", "",
                                    String.Format("{0}", dgvBrowsePerson.SelectedRows(0).Cells(1).Value.ToString),
                                    dgvBrowsePerson.SelectedRows(0).Cells(2).Value.ToString, "C-" + generateRandom(),
                                    dgvBrowsePerson.SelectedRows(0).Cells(3).Value.ToString,
                                    dgvBrowsePerson.SelectedRows(0).Cells(6).Value.ToString,
                                    dgvBrowsePerson.SelectedRows(0).Cells(7).Value.ToString)
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            txtSearch.Text = String.Empty
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            frmComplainant_Load(sender, e)
        Catch ex As Exception

        End Try
    End Sub
End Class