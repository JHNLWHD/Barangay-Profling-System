Public Class frmFiscalYear

    Dim trigger As String = ""
    Private AccountObj As New AccountClass
    Private FiscalYearObj As New FiscalYearClass


    Private Sub frmFiscalYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            trigger = ""
            ClearAll(gboFiscalYearInfo)
            ClearAll(pnlSearch)
            btnNew.Text = "New"
            btnEdit.Text = "Edit"
            btnNew.Enabled = True
            btnSave.Enabled = False
            btnEdit.Enabled = False
            btnShowRecords.Enabled = True
            gboFiscalYearInfo.Enabled = False
            pnlSearch.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Try
            If btnNew.Text = "New" Then
                btnNew.Text = "Cancel"
                btnSave.Enabled = True
                pnlSearch.Enabled = False
                btnEdit.Enabled = False
                trigger = "New"
                gboFiscalYearInfo.Enabled = True
                cboStatus.SelectedIndex = 1
                cboStatus.Enabled = False
            Else
                ClearAll(gboFiscalYearInfo)
                btnNew.Text = "New"
                btnSave.Enabled = False
                pnlSearch.Enabled = True
                trigger = ""
                gboFiscalYearInfo.Enabled = False
                cboStatus.SelectedIndex = -1
                cboStatus.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim msg As String = ""

            If trigger = "New" Then

                With FiscalYearObj

                    .Fiscal_year = dtpYear.Value.ToString("yyyy")
                    .Fiscal_year_status = "Inactive"
                    .Fiscal_year_remove_status = "False"
                    If .isFiscalYearExist(.Fiscal_year.ToString, "New") = True Then
                        msg = "already exist."
                        MessageBox.Show(String.Format("{0} {1}", .Fiscal_year_obj, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    Else
                        If .AddFiscalYear = True Then
                            msg = "is saved."
                            MessageBox.Show(String.Format("{0} {1}", .Fiscal_year, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            dtpYear.Value = New Date(Now.Year, Now.Month, Now.Day)
                            dtpYear.CustomFormat = "yyyy"
                            dtpYear.Format = DateTimePickerFormat.Custom
                            trigger = ""
                            frmFiscalYear_Load(sender, e)
                            trigger = ""
                            Exit Sub
                        Else
                            msg = "is not saved."
                            MessageBox.Show(String.Format("{0} {1}", .Fiscal_year, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If


                End With
            Else

                With FiscalYearObj
                    .Idfiscal_year = dgvSearch.SelectedRows(0).Cells(0).Value.ToString
                    If .isFiscalYearExist(.Fiscal_year.ToString, "Edit", .Idfiscal_year) = True Then
                        msg = "already exist."
                        MessageBox.Show(String.Format("{0} {1}", .Fiscal_year_obj, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        .Fiscal_year = dtpYear.Value.ToString("yyyy")
                        .Idfiscal_year = dgvSearch.SelectedRows(0).Cells(0).Value.ToString
                        If .UpdateFiscalYear = True Then
                            msg = "is updated."
                            MessageBox.Show(String.Format("{0} {1}", .Fiscal_year, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            dtpYear.Value = New Date(Now.Year, Now.Month, Now.Day)
                            dtpYear.CustomFormat = "yyyy"
                            dtpYear.Format = DateTimePickerFormat.Custom
                            trigger = ""
                            frmFiscalYear_Load(sender, e)
                            trigger = ""
                            Exit Sub
                        Else
                            msg = "is not updated."
                            MessageBox.Show(String.Format("{0} {1}", .Fiscal_year, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If

                End With
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If btnEdit.Text = "Edit" Then
                btnEdit.Text = "Cancel"
                btnSave.Enabled = True
                btnNew.Enabled = False
                txtSearch.Enabled = False
                dgvSearch.Enabled = False
                btnEdit.Enabled = True
                gboFiscalYearInfo.Enabled = True
                pnlCenter.Enabled = True
                cboStatus.Enabled = False
                trigger = "Edit"
            Else
                ClearAll(gboFiscalYearInfo)
                gboFiscalYearInfo.Enabled = False
                cboStatus.Enabled = False
                btnEdit.Text = "Edit"
                btnEdit.Enabled = False
                btnSave.Enabled = False
                btnNew.Enabled = True
                txtSearch.Enabled = True
                dgvSearch.Enabled = True
                pnlCenter.Enabled = False
                cboStatus.SelectedIndex = -1
                dgvSearch.Rows.Clear()
                txtSearch.Clear()
                trigger = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnShowRecords_Click(sender As Object, e As EventArgs) Handles btnShowRecords.Click
        Try
            frmFiscalYear_Load(sender, e)
            frmFiscalYearRecords.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            With FiscalYearObj
                If txtSearch.Text.Trim.Length > 0 Then
                    'MsgBox("1")
                    .SearchFiscalYearRecords(dgvSearch, "All", 1, txtSearch.Text)
                Else
                    'MsgBox("2")
                    dgvSearch.Rows.Clear()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellClick
        Try
            With FiscalYearObj
                .LoadFYToEdit(dgvSearch.SelectedRows(0).Cells(0).Value.ToString)
                .Idfiscal_year = .Idfiscal_year
                dtpYear.Value = DateTime.ParseExact(.Fiscal_year.ToString, "yyyy", System.Globalization.CultureInfo.InvariantCulture)
                cboStatus.SelectedIndex = cboStatus.FindString(.Fiscal_year_status)
            End With

            btnNew.Enabled = False
            btnEdit.Enabled = True
            btnSave.Enabled = False
            btnShowRecords.Enabled = True
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellDoubleClick
        Try
            dgvSearch_CellClick(sender, e)
            gboFiscalYearInfo.Enabled = True
            btnNew.Enabled = False
            btnEdit.Enabled = False
            btnSave.Enabled = True
            btnShowRecords.Enabled = True
            trigger = "Edit"
            pnlCenter.Enabled = True
            cboStatus.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmFiscalYear_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub
End Class