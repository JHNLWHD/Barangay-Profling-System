Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Drawing.Printing
Imports System.Management

Public Class frmClearance
    Dim crPFDS As ParameterFieldDefinitions
    Dim crPFD As ParameterFieldDefinition
    Private CertificateObj As New CertificateClass

    Public _idperson As Integer = 0
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Try
            If txtClearancePurpose.Text.Trim.Length > 0 Then

                If btnPrint.Text = "PRINT" Then
                    btnPrint.Text = "PRINTING..."

                    Dim frm As New DisplayReports
                    Dim cr As New ParameterValues
                    Dim crv As New ParameterDiscreteValue
                    Dim rpt As New Clearance

                    rpt.SetParameterValue("Name", txtClearanceName.Text)
                    rpt.SetParameterValue("Age", txtClearanceAge.Text)
                    rpt.SetParameterValue("Gender", txtClearanceGender.Text)
                    rpt.SetParameterValue("Civil Status", txtClearanceCivilStatus.Text)
                    rpt.SetParameterValue("Purpose", txtClearancePurpose.Text)
                    rpt.SetParameterValue("Address", TextBox1txtClearanceAddress.Text)


                    crv.Value = getYear()
                    crPFDS = rpt.DataDefinition.ParameterFields
                    crPFD = crPFDS.Item("Year")
                    cr = crPFD.CurrentValues
                    'cr.Clear()
                    cr.Add(crv)
                    crPFD.ApplyCurrentValues(cr)

                    crv.Value = getDate()
                    crPFDS = rpt.DataDefinition.ParameterFields
                    crPFD = crPFDS.Item("DateIssued")
                    cr = crPFD.CurrentValues
                    'cr.Clear()
                    cr.Add(crv)
                    crPFD.ApplyCurrentValues(cr)


                    rpt.PrintToPrinter(1, False, 0, 0)



                    frm.CrystalReportViewer1.ReportSource = rpt
                    frm.CrystalReportViewer1.Refresh()
                    frm.ShowDialog()

                    With CertificateObj

                        .Person_idperson = _idperson
                        .Certificate_purpose = txtClearancePurpose.Text
                        .Certificate_type = "Clearance"




                        If .AddCertificate() = True Then
                            txtClearancePurpose.Clear()


                            CertificateObj = New CertificateClass
                            With CertificateObj
                                .LoadCertificate(dgvCertificate)
                            End With

                            MessageBox.Show("Successfully printed.")

                        Else
                            MessageBox.Show("Failed to print.")
                        End If



                    End With

                End If

            Else
                MessageBox.Show("Fill up required fields.")
            End If


            btnPrint.Text = "PRINT"

        Catch ex As Exception
            btnPrint.Text = "PRINT"
            MsgBox(ex.Message)
        End Try




    End Sub

    Private Sub frmClearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try



            CertificateObj = New CertificateClass
            With CertificateObj
                .LoadCertificate(dgvCertificate)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtClearanceAge_TextChanged(sender As Object, e As EventArgs) Handles txtClearanceAge.TextChanged
        Try
            txtClearanceAge.Text = GetCurrentAge(frmResidentRecord.dgvBrowsePerson.SelectedRows(0).Cells(6).Value.ToString, getDate)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboSearch_Click(sender As Object, e As EventArgs) Handles cboSearch.Click

    End Sub

    Private Sub cboSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearch.SelectedIndexChanged

        If cboSearch.Text = "Residency" Then


            CertificateObj = New CertificateClass
            With CertificateObj

                .LoadResidency(dgvCertificate)
            End With

        ElseIf cboSearch.Text = "Appearance" Then


            CertificateObj = New CertificateClass
            With CertificateObj

                .LoadAppearance(dgvCertificate)


            End With

        ElseIf cboSearch.Text = "Clearance" Then


            CertificateObj = New CertificateClass
            With CertificateObj

                .LoadClearance(dgvCertificate)


            End With

        ElseIf cboSearch.Text = "Indigency" Then


            CertificateObj = New CertificateClass
            With CertificateObj

                .LoadIndigency(dgvCertificate)


            End With

        ElseIf cboSearch.Text = "All" Then


            CertificateObj = New CertificateClass
            With CertificateObj

                .LoadCertificate(dgvCertificate)


            End With

        End If
    End Sub


End Class