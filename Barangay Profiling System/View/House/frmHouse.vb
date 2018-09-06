Imports MySql.Data.MySqlClient
Public Class frmHouse

    Private HouseObj As New HouseClass
    Dim trigger As String = ""
    'For Add Triggers
    Dim addLotOwnerTrigger As Boolean = False
    Dim browseLotOwnerTrigger As Boolean = False
    Dim addHouseOwnerTrigger As Boolean = False
    Dim browseHouseOwnerTrigger As Boolean = False
    Dim sameOwner As Boolean = False
    Dim str As String = ""
    Public _idLotOwner As Integer = 0
    Public _idHouseOwner As Integer = 0
    'For Edit Triggers
    Dim addLotOwnerTriggerEdit As Boolean = False
    Dim browseLotOwnerTriggerEdit As Boolean = False
    Dim addHouseOwnerTriggerEdit As Boolean = False
    Dim browseHouseOwnerTriggerEdit As Boolean = False
    Dim sameOwnerEdit As Boolean = False

    Private Sub btnHouseAddress_Click(sender As Object, e As EventArgs) Handles btnHouseAddress.Click
        Try
            frmAddAddress.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmHouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            addLotOwnerTrigger = False
            browseLotOwnerTrigger = False
            addHouseOwnerTrigger = False
            browseHouseOwnerTrigger = False
            sameOwner = False

            addLotOwnerTriggerEdit = False
            browseLotOwnerTriggerEdit = False
            addHouseOwnerTriggerEdit = False
            browseHouseOwnerTriggerEdit = False
            sameOwner = False

            trigger = ""
            btnNew.Text = "New"
            btnEdit.Text = "Edit"
            btnNew.Enabled = True
            btnSave.Enabled = False
            btnEdit.Enabled = False
            btnShowRecords.Enabled = True
            pnlInfo.Enabled = False
            pnlSearch.Enabled = True
            ClearAll(pnlInfo)
            ClearAll(pnlSearch)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim triggerID As Boolean = False

            If trigger = "New" Then
                'SAVE
                With HouseObj

                    If txtLotOwnerName.Text <> "" And txtHouseOwnerName.Text <> "" And txtHouseAddress.Text <> "" Then



                        If addLotOwnerTrigger = True And browseLotOwnerTrigger = False Then

                            With frmAddLotOwner

                                If .chkResident.Checked = True Then
                                    str = "INSERT INTO person(person_first_name,person_middle_name," _
                               & "person_last_name,person_extension_name,person_gender," _
                               & "person_mobile_no,person_tel_no,person_civil_status," _
                               & "person_date_of_birth,person_status,person_vital_status,person_reg_date,person_reg_date_resident," _
                               & "person_voter_status,person_precinct_number,person_place_of_birth,person_height,person_weight,person_complexion,person_hair_color,person_eye_color) " _
                               & "VALUES('" & MySqlHelper.EscapeString(.txtFirstName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtMiddleName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtLastName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtExtensionName.Text) & "'," _
                               & "'" & If(.rbtnMale.Checked = True, "Male", "Female") & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtMobileNumber.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtTelephoneNumber.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.cboCivilStatus.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.dtpDOB.Value.ToString("yyyy-MM-dd")) & "'," _
                               & "'" & If(.chkResident.Checked = True, "Resident", "Non Resident") & "'," _
                               & "'" & If(.rbtnAlive.Checked = True, "Alive", "Dead") & "',CURRENT_DATE,CURRENT_DATE,'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "');"
                                Else
                                    str = "INSERT INTO person(person_first_name,person_middle_name," _
                               & "person_last_name,person_extension_name,person_gender," _
                               & "person_mobile_no,person_tel_no,person_civil_status," _
                               & "person_date_of_birth,person_status,person_vital_status,person_reg_date," _
                               & "person_voter_status,person_precinct_number,person_place_of_birth,person_height,person_weight,person_complexion,person_hair_color,person_eye_color) " _
                               & "VALUES('" & MySqlHelper.EscapeString(.txtFirstName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtMiddleName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtLastName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtExtensionName.Text) & "'," _
                               & "'" & If(.rbtnMale.Checked = True, "Male", "Female") & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtMobileNumber.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtTelephoneNumber.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.cboCivilStatus.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.dtpDOB.Value.ToString("yyyy-MM-dd")) & "'," _
                               & "'" & If(.chkResident.Checked = True, "Resident", "Non Resident") & "'," _
                               & "'" & If(.rbtnAlive.Checked = True, "Alive", "Dead") & "',CURRENT_DATE,'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "');"
                                End If


                                str += "INSERT INTO lot_ownership(person_idperson," _
                               & "lot_house_idlot_house,lot_ownership_status,lot_ownership_reg_date) " _
                               & "VALUES((SELECT MAX(idperson) FROM person)," _
                               & "(SELECT MAX(idlot_house) FROM lot_house)," _
                               & "'" & MySqlHelper.EscapeString("Active") & "',CURRENT_DATE);"
                            End With
                        Else
                            str = "INSERT INTO lot_ownership(person_idperson," _
                             & "lot_house_idlot_house,lot_ownership_status,lot_ownership_reg_date) " _
                             & "VALUES('" & MySqlHelper.EscapeString(_idLotOwner) & "'," _
                             & "(SELECT MAX(idlot_house) FROM lot_house)," _
                             & "'" & MySqlHelper.EscapeString("Active") & "',CURRENT_DATE);"
                        End If



                        If addHouseOwnerTrigger = True And browseHouseOwnerTrigger = False And sameOwner = False Then
                            With frmAddHouseOwner
                                If .chkResident.Checked = True Then
                                    str = "INSERT INTO person(person_first_name,person_middle_name," _
                               & "person_last_name,person_extension_name,person_gender," _
                               & "person_mobile_no,person_tel_no,person_civil_status," _
                               & "person_date_of_birth,person_status,person_vital_status,person_reg_date,person_reg_date_resident," _
                               & "person_voter_status,person_precinct_number,person_place_of_birth,person_height,person_weight,person_complexion,person_hair_color,person_eye_color) " _
                               & "VALUES('" & MySqlHelper.EscapeString(.txtFirstName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtMiddleName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtLastName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtExtensionName.Text) & "'," _
                               & "'" & If(.rbtnMale.Checked = True, "Male", "Female") & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtMobileNumber.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtTelephoneNumber.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.cboCivilStatus.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.dtpDOB.Value.ToString("yyyy-MM-dd")) & "'," _
                               & "'" & If(.chkResident.Checked = True, "Resident", "Non Resident") & "'," _
                               & "'" & If(.rbtnAlive.Checked = True, "Alive", "Dead") & "',CURRENT_DATE,CURRENT_DATE,'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "');"
                                Else
                                    str = "INSERT INTO person(person_first_name,person_middle_name," _
                               & "person_last_name,person_extension_name,person_gender," _
                               & "person_mobile_no,person_tel_no,person_civil_status," _
                               & "person_date_of_birth,person_status,person_vital_status,person_reg_date," _
                               & "person_voter_status,person_precinct_number,person_place_of_birth,person_height,person_weight,person_complexion,person_hair_color,person_eye_color) " _
                               & "VALUES('" & MySqlHelper.EscapeString(.txtFirstName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtMiddleName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtLastName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtExtensionName.Text) & "'," _
                               & "'" & If(.rbtnMale.Checked = True, "Male", "Female") & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtMobileNumber.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtTelephoneNumber.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.cboCivilStatus.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.dtpDOB.Value.ToString("yyyy-MM-dd")) & "'," _
                               & "'" & If(.chkResident.Checked = True, "Resident", "Non Resident") & "'," _
                               & "'" & If(.rbtnAlive.Checked = True, "Alive", "Dead") & "',CURRENT_DATE,'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "');"
                                End If
                                str += "INSERT INTO house_ownership(person_idperson," _
                              & "house_idhouse,house_ownership_status,house_ownership_reg_date) " _
                              & "VALUES((SELECT MAX(idperson) FROM person)," _
                              & "(SELECT MAX(idhouse) FROM house)," _
                              & "'" & MySqlHelper.EscapeString("Active") & "',CURRENT_DATE);"
                            End With


                        ElseIf addHouseOwnerTrigger = False And browseHouseOwnerTrigger = True And sameOwner = False Then
                            str += "INSERT INTO house_ownership(person_idperson," _
                              & "house_idhouse,house_ownership_status,house_ownership_reg_date) " _
                              & "VALUES('" & MySqlHelper.EscapeString(_idHouseOwner) & "'," _
                              & "(SELECT MAX(idhouse) FROM house)," _
                              & "'" & MySqlHelper.EscapeString("Active") & "',CURRENT_DATE);"


                        Else
                            Dim lambda = Function(bool As Boolean)
                                             Return If(bool = True, "INSERT INTO house_ownership(person_idperson," _
                              & "house_idhouse,house_ownership_status,house_ownership_reg_date) " _
                              & "VALUES((SELECT MAX(idperson) FROM person)," _
                              & "(SELECT MAX(idhouse) FROM house)," _
                              & "'" & MySqlHelper.EscapeString("Active") & "',CURRENT_DATE);", "INSERT INTO house_ownership(person_idperson," _
                              & "house_idhouse,house_ownership_status,house_ownership_reg_date) " _
                              & "VALUES('" & MySqlHelper.EscapeString(_idHouseOwner) & "'," _
                              & "(SELECT MAX(idhouse) FROM house)," _
                              & "'" & MySqlHelper.EscapeString("Active") & "',CURRENT_DATE);")
                                         End Function
                            str += lambda(addLotOwnerTrigger)
                        End If

                        .Purok_idpurok = frmAddAddress.purokLambda(frmAddAddress.cboPurok.Text)
                        .Drive_iddrive = frmAddAddress.driveLambda(frmAddAddress.cboDrive.Text)
                        .Street_idstreet = frmAddAddress.streetLambda(frmAddAddress.cboStreet.Text)
                        .Road_idroad = frmAddAddress.roadLambda(frmAddAddress.cboRoad.Text)

                        .Lot_house_code = txtLotCode.Text
                        .House_code = txtHouseCode.Text
                        .House_name = txtHouseName.Text
                        .House_level = txtHouseLevel.Text
                        .House_type = cboType.Text
                        .House_status = "Active"
                        .House_settlement_status = If(rbtnLegal.Checked = True, "Legal Settler", "Illegal Settler")

                        .House_history_desc = String.Format("House number: {0} is registered on this date: {1} that has {2} floor/s with {3} status and it is {4}. This house is owned by {5} under lot number {6}.", .House_code, Now.ToShortDateString, .House_level, .House_settlement_status, .House_type, txtHouseOwnerName.Text, .Lot_house_code)
                        .House_remarks = .House_history_desc


                        If .AddHouse(str) = True Then
                            MessageBox.Show("New House has been saved.")
                            frmHouse_Load(sender, e)
                            trigger = ""
                            frmAddAddress.cboStreet.SelectedIndex = -1
                            frmAddAddress.cboPurok.SelectedIndex = -1
                            frmAddAddress.cboRoad.SelectedIndex = -1
                            frmAddAddress.cboDrive.SelectedIndex = -1
                            Exit Sub
                        Else
                            MessageBox.Show("Error occured in saving the data.")
                            Exit Sub
                        End If

                    Else
                        MessageBox.Show("Please fill up fields.")
                        Exit Sub
                    End If

                End With


            Else
                'EDIT
                With HouseObj

                    If addLotOwnerTriggerEdit = True And browseLotOwnerTriggerEdit = False Then
                        With frmAddLotOwner

                            If .chkResident.Checked = True Then
                                str = "INSERT INTO person(person_first_name,person_middle_name," _
                               & "person_last_name,person_extension_name,person_gender," _
                               & "person_mobile_no,person_tel_no,person_civil_status," _
                               & "person_date_of_birth,person_status,person_vital_status,person_reg_date,person_reg_date_resident," _
                               & "person_voter_status,person_precinct_number,person_place_of_birth,person_height,person_weight,person_complexion,person_hair_color,person_eye_color) " _
                               & "VALUES('" & MySqlHelper.EscapeString(.txtFirstName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtMiddleName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtLastName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtExtensionName.Text) & "'," _
                               & "'" & If(.rbtnMale.Checked = True, "Male", "Female") & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtMobileNumber.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtTelephoneNumber.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.cboCivilStatus.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.dtpDOB.Value.ToString("yyyy-MM-dd")) & "'," _
                               & "'" & If(.chkResident.Checked = True, "Resident", "Non Resident") & "'," _
                               & "'" & If(.rbtnAlive.Checked = True, "Alive", "Dead") & "',CURRENT_DATE,CURRENT_DATE,'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "');"
                            Else
                                str = "INSERT INTO person(person_first_name,person_middle_name," _
                               & "person_last_name,person_extension_name,person_gender," _
                               & "person_mobile_no,person_tel_no,person_civil_status," _
                               & "person_date_of_birth,person_status,person_vital_status,person_reg_date," _
                               & "person_voter_status,person_precinct_number,person_place_of_birth,person_height,person_weight,person_complexion,person_hair_color,person_eye_color) " _
                               & "VALUES('" & MySqlHelper.EscapeString(.txtFirstName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtMiddleName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtLastName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtExtensionName.Text) & "'," _
                               & "'" & If(.rbtnMale.Checked = True, "Male", "Female") & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtMobileNumber.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtTelephoneNumber.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.cboCivilStatus.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.dtpDOB.Value.ToString("yyyy-MM-dd")) & "'," _
                               & "'" & If(.chkResident.Checked = True, "Resident", "Non Resident") & "'," _
                               & "'" & If(.rbtnAlive.Checked = True, "Alive", "Dead") & "',CURRENT_DATE,'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "');"
                            End If

                            str += "UPDATE lot_ownership SET lot_ownership_status = '" & "Inactive" & "' WHERE lot_house_idlot_house = '" & HouseObj.Idlot_house & "';"
                            str += "INSERT INTO lot_ownership(person_idperson," _
                           & "lot_house_idlot_house,lot_ownership_status,lot_ownership_reg_date) " _
                           & "VALUES((SELECT MAX(idperson) FROM person)," _
                           & "(SELECT MAX(idlot_house) FROM lot_house)," _
                           & "'" & MySqlHelper.EscapeString("Active") & "',CURRENT_DATE);"
                        End With
                    ElseIf addLotOwnerTriggerEdit = False And browseLotOwnerTriggerEdit = True Then
                        str += "UPDATE lot_ownership SET lot_ownership_status = '" & "Inactive" & "' WHERE lot_house_idlot_house = '" & .Idlot_house & "';"
                        str = "INSERT INTO lot_ownership(person_idperson," _
                         & "lot_house_idlot_house,lot_ownership_status,lot_ownership_reg_date) " _
                         & "VALUES('" & MySqlHelper.EscapeString(_idLotOwner) & "'," _
                         & "(SELECT MAX(idlot_house) FROM lot_house)," _
                         & "'" & MySqlHelper.EscapeString("Active") & "',CURRENT_DATE);"
                    Else
                        'get id
                        .Idlot_house = .Idlot_house
                        triggerID = True
                    End If

                    If addHouseOwnerTriggerEdit = True And browseHouseOwnerTriggerEdit = False And sameOwnerEdit = False Then
                        With frmAddHouseOwner
                            If .chkResident.Checked = True Then
                                str = "INSERT INTO person(person_first_name,person_middle_name," _
                               & "person_last_name,person_extension_name,person_gender," _
                               & "person_mobile_no,person_tel_no,person_civil_status," _
                               & "person_date_of_birth,person_status,person_vital_status,person_reg_date,person_reg_date_resident," _
                               & "person_voter_status,person_precinct_number,person_place_of_birth,person_height,person_weight,person_complexion,person_hair_color,person_eye_color) " _
                               & "VALUES('" & MySqlHelper.EscapeString(.txtFirstName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtMiddleName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtLastName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtExtensionName.Text) & "'," _
                               & "'" & If(.rbtnMale.Checked = True, "Male", "Female") & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtMobileNumber.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtTelephoneNumber.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.cboCivilStatus.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.dtpDOB.Value.ToString("yyyy-MM-dd")) & "'," _
                               & "'" & If(.chkResident.Checked = True, "Resident", "Non Resident") & "'," _
                               & "'" & If(.rbtnAlive.Checked = True, "Alive", "Dead") & "',CURRENT_DATE,CURRENT_DATE,'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "');"
                            Else
                                str = "INSERT INTO person(person_first_name,person_middle_name," _
                               & "person_last_name,person_extension_name,person_gender," _
                               & "person_mobile_no,person_tel_no,person_civil_status," _
                               & "person_date_of_birth,person_status,person_vital_status,person_reg_date," _
                               & "person_voter_status,person_precinct_number,person_place_of_birth,person_height,person_weight,person_complexion,person_hair_color,person_eye_color) " _
                               & "VALUES('" & MySqlHelper.EscapeString(.txtFirstName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtMiddleName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtLastName.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtExtensionName.Text) & "'," _
                               & "'" & If(.rbtnMale.Checked = True, "Male", "Female") & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtMobileNumber.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.txtTelephoneNumber.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.cboCivilStatus.Text) & "'," _
                               & "'" & MySqlHelper.EscapeString(.dtpDOB.Value.ToString("yyyy-MM-dd")) & "'," _
                               & "'" & If(.chkResident.Checked = True, "Resident", "Non Resident") & "'," _
                               & "'" & If(.rbtnAlive.Checked = True, "Alive", "Dead") & "',CURRENT_DATE,'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "');"
                            End If
                            str += "UPDATE house_ownership SET house_ownership_status = '" & "Inactive" & "' WHERE house_idhouse = '" & HouseObj.Idhouse & "';"
                            str += "INSERT INTO house_ownership(person_idperson," _
                          & "house_idhouse,house_ownership_status,house_ownership_reg_date) " _
                          & "VALUES((SELECT MAX(idperson) FROM person)," _
                          & "(SELECT MAX(idhouse) FROM house)," _
                          & "'" & MySqlHelper.EscapeString("Active") & "',CURRENT_DATE);"
                        End With
                    ElseIf addHouseOwnerTriggerEdit = False And browseHouseOwnerTriggerEdit = True And sameOwnerEdit = False Then
                        str += "UPDATE house_ownership SET house_ownership_status = '" & "Inactive" & "' WHERE house_idhouse = '" & HouseObj.Idhouse & "';"
                        str += "INSERT INTO house_ownership(person_idperson," _
                          & "house_idhouse,house_ownership_status,house_ownership_reg_date) " _
                          & "VALUES('" & MySqlHelper.EscapeString(_idHouseOwner) & "'," _
                          & "(SELECT MAX(idhouse) FROM house)," _
                          & "'" & MySqlHelper.EscapeString("Active") & "',CURRENT_DATE);"
                    Else

                        If triggerID = False Then
                            'getID
                            .Idhouse = .Idhouse
                        Else
                            Dim lambda = Function(bool As Boolean)
                                             Return If(bool = True, "UPDATE house_ownership SET house_ownership_status = '" & "Inactive" & "' WHERE house_idhouse = '" & HouseObj.Idhouse & "';" _
                                             & "INSERT INTO house_ownership(person_idperson," _
                              & "house_idhouse,house_ownership_status,house_ownership_reg_date) " _
                              & "VALUES((SELECT MAX(idperson) FROM person)," _
                              & "(SELECT MAX(idhouse) FROM house)," _
                              & "'" & MySqlHelper.EscapeString("Active") & "',CURRENT_DATE);", "UPDATE house_ownership SET house_ownership_status = '" & "Inactive" & "' WHERE house_idhouse = '" & HouseObj.Idhouse & "';" _
                              & "INSERT INTO house_ownership(person_idperson," _
                              & "house_idhouse,house_ownership_status,house_ownership_reg_date) " _
                              & "VALUES('" & MySqlHelper.EscapeString(_idHouseOwner) & "'," _
                              & "(SELECT MAX(idhouse) FROM house)," _
                              & "'" & MySqlHelper.EscapeString("Active") & "',CURRENT_DATE);")
                                         End Function
                            str += lambda(addLotOwnerTriggerEdit)
                        End If

                    End If

                    If .Address_name <> txtHouseAddress.Text Then

                        .Purok_idpurok = frmAddAddress.purokLambda(frmAddAddress.cboPurok.Text)
                        .Drive_iddrive = frmAddAddress.driveLambda(frmAddAddress.cboDrive.Text)
                        .Street_idstreet = frmAddAddress.streetLambda(frmAddAddress.cboStreet.Text)
                        .Road_idroad = frmAddAddress.roadLambda(frmAddAddress.cboRoad.Text)

                    Else
                        'Do Nothing
                    End If



                    .Lot_house_code = txtLotCode.Text
                    .House_code = txtHouseCode.Text
                    .House_name = txtHouseName.Text
                    .House_level = txtHouseLevel.Text
                    .House_type = cboType.Text
                    .House_status = "Active"
                    .House_settlement_status = If(rbtnLegal.Checked = True, "Legal Settler", "Illegal Settler")

                    .House_history_desc = String.Format("House number: {0} is registered on this date: {1} that has {2} floor/s with {3} status and it is {4}. This house is owned by {5} under lot number {6}.", .House_code, Now.ToShortDateString, .House_level, .House_settlement_status, .House_type, txtHouseOwnerName.Text, .Lot_house_code)

                    If .EditHouse(str) = True Then

                        MessageBox.Show("House has been updated.")
                        frmHouse_Load(sender, e)
                        trigger = ""
                        frmAddAddress.cboStreet.SelectedIndex = -1
                        frmAddAddress.cboPurok.SelectedIndex = -1
                        frmAddAddress.cboRoad.SelectedIndex = -1
                        frmAddAddress.cboDrive.SelectedIndex = -1
                        Exit Sub
                    Else
                        MessageBox.Show("Error occured in saving the data.")
                        Exit Sub

                    End If
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddLotOwner_Click(sender As Object, e As EventArgs) Handles btnAddLotOwner.Click
        Try
            addLotOwnerTrigger = True
            browseLotOwnerTrigger = False

            addLotOwnerTriggerEdit = True
            browseLotOwnerTriggerEdit = False
            frmAddLotOwner.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBrowseLotOwner_Click(sender As Object, e As EventArgs) Handles btnBrowseLotOwner.Click
        Try
            addLotOwnerTrigger = False
            browseLotOwnerTrigger = True

            addLotOwnerTriggerEdit = False
            browseLotOwnerTriggerEdit = True
            frmBrowseLotOwner.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddHouseOwner_Click(sender As Object, e As EventArgs) Handles btnAddHouseOwner.Click
        Try
            addHouseOwnerTrigger = True
            browseHouseOwnerTrigger = False
            sameOwner = False

            addHouseOwnerTriggerEdit = True
            browseHouseOwnerTriggerEdit = False
            sameOwnerEdit = False
            frmAddHouseOwner.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBrowseHouseOwner_Click(sender As Object, e As EventArgs) Handles btnBrowseHouseOwner.Click
        Try
            addHouseOwnerTrigger = False
            browseHouseOwnerTrigger = True
            sameOwner = False

            addHouseOwnerTriggerEdit = False
            browseHouseOwnerTriggerEdit = True
            sameOwnerEdit = False
            frmBrowseHouseOwner.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSameOwner_Click(sender As Object, e As EventArgs) Handles btnSameOwner.Click
        Try
            addHouseOwnerTrigger = False
            browseHouseOwnerTrigger = False
            sameOwner = True

            addHouseOwnerTriggerEdit = False
            browseHouseOwnerTriggerEdit = False
            sameOwnerEdit = True

            txtHouseOwnerName.Text = txtLotOwnerName.Text
            _idHouseOwner = _idLotOwner
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnShowRecords_Click(sender As Object, e As EventArgs) Handles btnShowRecords.Click
        Try
            frmHouseRecord.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Try
            If btnNew.Text = "New" Then
                btnNew.Text = "Cancel"
                trigger = "New"
                btnSave.Enabled = True
                btnEdit.Enabled = False
                pnlInfo.Enabled = True
                pnlSearch.Enabled = False
                ClearAll(pnlSearch)
                txtLotCode.Text = String.Format("L-{0}", generateRandomNumber())
                txtHouseCode.Text = generateRandomNumber()
                frmAddAddress.cboStreet.SelectedIndex = -1
                frmAddAddress.cboPurok.SelectedIndex = -1
                frmAddAddress.cboRoad.SelectedIndex = -1
                frmAddAddress.cboDrive.SelectedIndex = -1
            Else
                addLotOwnerTrigger = False
                browseLotOwnerTrigger = False
                addHouseOwnerTrigger = False
                browseHouseOwnerTrigger = False
                sameOwner = False
                ClearAll(pnlInfo)
                btnNew.Text = "New"
                trigger = ""
                btnSave.Enabled = False
                btnEdit.Enabled = True
                pnlInfo.Enabled = False
                pnlSearch.Enabled = True
                frmAddAddress.cboStreet.SelectedIndex = -1
                frmAddAddress.cboPurok.SelectedIndex = -1
                frmAddAddress.cboRoad.SelectedIndex = -1
                frmAddAddress.cboDrive.SelectedIndex = -1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If btnEdit.Text = "Edit" Then
                btnEdit.Text = "Cancel"
                trigger = "Edit"
                btnNew.Enabled = False
                btnSave.Enabled = True
                pnlInfo.Enabled = True
                pnlSearch.Enabled = False
            Else
                addLotOwnerTrigger = False
                browseLotOwnerTrigger = False
                addHouseOwnerTrigger = False
                browseHouseOwnerTrigger = False
                sameOwner = False
                ClearAll(pnlInfo)
                ClearAll(pnlSearch)
                pnlInfo.Enabled = False
                pnlSearch.Enabled = True
                btnEdit.Text = "Edit"
                btnSave.Enabled = False
                btnNew.Enabled = True
                trigger = ""
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            With HouseObj
                If txtSearch.Text.Trim.Length > 0 Then
                    .SearchHouseCode(dgvSearch, txtSearch.Text)
                Else
                    dgvSearch.Rows.Clear()
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellClick
        Try
            With HouseObj
                .GetLotHouseDetails(dgvSearch.SelectedRows(0).Cells(2).Value.ToString)
                .Idlot_house = .Idlot_house
                txtLotCode.Text = .Lot_house_code
                .GetOwnerDetails(.Lot_owner_id)
                txtLotOwnerName.Text = String.Format("{0} {1} {2} {3}", .Person_first_name, .Person_middle_name, .Person_last_name, .Person_extension_name)
                .GetAddressDetails(.Idlot_house)
                txtHouseAddress.Text = .Address_name
                .GetHouseDetails(dgvSearch.SelectedRows(0).Cells(1).Value.ToString, .Idlot_house.ToString)
                .Idhouse = .Idhouse
                txtHouseCode.Text = .House_code
                txtHouseName.Text = .House_name
                cboType.SelectedIndex = cboType.FindString(.House_type)
                txtHouseLevel.Text = .House_level
                _idHouseOwner = .House_owner_id
                _idLotOwner = .Lot_owner_id


                If (.House_settlement_status = "Legal Settler") Then
                    rbtnLegal.Checked = True
                Else
                    rbtnIllegal.Checked = True
                End If

                .GetOwnerDetails(.House_owner_id)
                txtHouseOwnerName.Text = String.Format("{0} {1} {2} {3}", .Person_first_name, .Person_middle_name, .Person_last_name, .Person_extension_name)



                btnNew.Enabled = False
                btnEdit.Enabled = True
                btnSave.Enabled = False
                btnShowRecords.Enabled = True
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellDoubleClick
        Try
            dgvSearch_CellClick(sender, e)
            btnEdit.Text = "Cancel"
            trigger = "Edit"
            btnNew.Enabled = False
            btnSave.Enabled = True
            pnlInfo.Enabled = True
            pnlSearch.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
End Class