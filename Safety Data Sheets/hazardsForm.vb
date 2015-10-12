Public Class hazardsForm

    Dim checkedBoxText11, checkedBoxText12, checkedBoxText13, checkedBoxText14, checkedBoxText15, checkedBoxText16 As String
    Dim checkedBoxText21, checkedBoxText22, checkedBoxText23, checkedBoxText24, checkedBoxText25, checkedBoxText26, checkedBoxText27, checkedBoxText28, checkedBoxText29 As String
    Dim checkedBoxText31, checkedBoxText32, checkedBoxText33, checkedBoxText34 As String
    Dim physicalHazardText, healthHazardText, environmentalHazardText As String

    Private Sub hazardsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hazardsFormTextBox.Text = mainForm.hazardsSDSLookupTextBox.Text
    End Sub

    Private Sub hazardsFormSaveButton_Click(sender As Object, e As EventArgs) Handles hazardsFormSaveButton.Click
        mainForm.hazardsSDSLookupTextBox.Text = mainForm.hazardsSDSLookupTextBox.Text & vbNewLine & hazardsFormTextBox.Text
        Me.Close()
    End Sub

    Private Sub overwriteButton_Click(sender As Object, e As EventArgs) Handles overwriteButton.Click
        mainForm.hazardsSDSLookupTextBox.Text = hazardsFormTextBox.Text
        Me.Close()
    End Sub

    Private Sub clearChecksButton_Click(sender As Object, e As EventArgs) Handles clearChecksButton.Click
        Call clearAllChecks
    End Sub

    Public Sub clearAllChecks()

        For i = 0 To CheckedListBox11.Items.Count - 1
            CheckedListBox11.SetItemChecked(i, False)
        Next
        For i = 0 To CheckedListBox12.Items.Count - 1
            CheckedListBox12.SetItemChecked(i, False)
        Next
        For i = 0 To CheckedListBox13.Items.Count - 1
            CheckedListBox13.SetItemChecked(i, False)
        Next
        For i = 0 To CheckedListBox14.Items.Count - 1
            CheckedListBox14.SetItemChecked(i, False)
        Next
        For i = 0 To CheckedListBox15.Items.Count - 1
            CheckedListBox15.SetItemChecked(i, False)
        Next
        For i = 0 To CheckedListBox16.Items.Count - 1
            CheckedListBox16.SetItemChecked(i, False)
        Next

        For i = 0 To CheckedListBox21.Items.Count - 1
            CheckedListBox21.SetItemChecked(i, False)
        Next
        For i = 0 To CheckedListBox22.Items.Count - 1
            CheckedListBox22.SetItemChecked(i, False)
        Next
        For i = 0 To CheckedListBox23.Items.Count - 1
            CheckedListBox23.SetItemChecked(i, False)
        Next
        For i = 0 To CheckedListBox24.Items.Count - 1
            CheckedListBox24.SetItemChecked(i, False)
        Next
        For i = 0 To CheckedListBox25.Items.Count - 1
            CheckedListBox25.SetItemChecked(i, False)
        Next
        For i = 0 To CheckedListBox26.Items.Count - 1
            CheckedListBox26.SetItemChecked(i, False)
        Next
        For i = 0 To CheckedListBox27.Items.Count - 1
            CheckedListBox27.SetItemChecked(i, False)
        Next
        For i = 0 To CheckedListBox28.Items.Count - 1
            CheckedListBox28.SetItemChecked(i, False)
        Next
        For i = 0 To CheckedListBox29.Items.Count - 1
            CheckedListBox29.SetItemChecked(i, False)
        Next


        For i = 0 To CheckedListBox31.Items.Count - 1
            CheckedListBox31.SetItemChecked(i, False)
        Next
        For i = 0 To CheckedListBox32.Items.Count - 1
            CheckedListBox32.SetItemChecked(i, False)
        Next
        For i = 0 To CheckedListBox33.Items.Count - 1
            CheckedListBox33.SetItemChecked(i, False)
        Next
        For i = 0 To CheckedListBox34.Items.Count - 1
            CheckedListBox34.SetItemChecked(i, False)
        Next

    End Sub

    Private Sub CheckedListBox11_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox11.SelectedIndexChanged

        checkedBoxText11 = ""

        If CheckedListBox11.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox11.CheckedItems.Count - 1
                If CheckedListBox11.CheckedItems(x).ToString <> "" Then checkedBoxText11 = checkedBoxText11 & CheckedListBox11.CheckedItems(x).ToString
                If x <> CheckedListBox11.CheckedItems.Count - 1 Then
                    checkedBoxText11 = checkedBoxText11 & ", "
                End If
            Next x
        Else
            checkedBoxText11 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub CheckedListBox12_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox12.SelectedIndexChanged

        checkedBoxText12 = ""

        If CheckedListBox12.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox12.CheckedItems.Count - 1
                If CheckedListBox12.CheckedItems(x).ToString <> "" Then checkedBoxText12 = checkedBoxText12 & CheckedListBox12.CheckedItems(x).ToString
                If x <> CheckedListBox12.CheckedItems.Count - 1 Then
                    checkedBoxText12 = checkedBoxText12 & ", "
                End If
            Next x
        Else
            checkedBoxText12 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub CheckedListBox13_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox13.SelectedIndexChanged

        checkedBoxText13 = ""

        If CheckedListBox13.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox13.CheckedItems.Count - 1
                If CheckedListBox13.CheckedItems(x).ToString <> "" Then checkedBoxText13 = checkedBoxText13 & CheckedListBox13.CheckedItems(x).ToString
                If x <> CheckedListBox13.CheckedItems.Count - 1 Then
                    checkedBoxText13 = checkedBoxText13 & ", "
                End If
            Next x
        Else
            checkedBoxText13 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub CheckedListBox14_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox14.SelectedIndexChanged

        checkedBoxText14 = "May "

        If CheckedListBox14.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox14.CheckedItems.Count - 1
                If CheckedListBox14.CheckedItems(x).ToString <> "" Then checkedBoxText14 = checkedBoxText14 & CheckedListBox14.CheckedItems(x).ToString
                If x <> CheckedListBox14.CheckedItems.Count - 1 Then
                    checkedBoxText14 = checkedBoxText14 & ", "
                End If
            Next x
        Else
            checkedBoxText14 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub CheckedListBox15_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox15.SelectedIndexChanged

        checkedBoxText15 = "Contains "

        If CheckedListBox15.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox15.CheckedItems.Count - 1
                If CheckedListBox15.CheckedItems(x).ToString <> "" Then checkedBoxText15 = checkedBoxText15 & CheckedListBox15.CheckedItems(x).ToString
                If x <> CheckedListBox15.CheckedItems.Count - 1 Then
                    checkedBoxText15 = checkedBoxText15 & ", "
                End If
            Next x
        Else
            checkedBoxText15 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub CheckedListBox16_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox16.SelectedIndexChanged

        checkedBoxText16 = "In contact with water "

        If CheckedListBox16.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox16.CheckedItems.Count - 1
                If CheckedListBox16.CheckedItems(x).ToString <> "" Then checkedBoxText16 = checkedBoxText16 & CheckedListBox16.CheckedItems(x).ToString
                If x <> CheckedListBox16.CheckedItems.Count - 1 Then
                    checkedBoxText16 = checkedBoxText16 & ", "
                End If
            Next x
        Else
            checkedBoxText16 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub CheckedListBox21_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox21.SelectedIndexChanged

        checkedBoxText21 = "Fatal "

        If CheckedListBox21.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox21.CheckedItems.Count - 1
                If CheckedListBox21.CheckedItems(x).ToString <> "" Then checkedBoxText21 = checkedBoxText21 & CheckedListBox21.CheckedItems(x).ToString
                If x <> CheckedListBox21.CheckedItems.Count - 1 Then
                    checkedBoxText21 = checkedBoxText21 & ", "
                End If
            Next x
        Else
            checkedBoxText21 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub CheckedListBox22_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox22.SelectedIndexChanged

        checkedBoxText22 = "May be fatal "

        If CheckedListBox22.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox22.CheckedItems.Count - 1
                If CheckedListBox22.CheckedItems(x).ToString <> "" Then checkedBoxText22 = checkedBoxText22 & CheckedListBox22.CheckedItems(x).ToString
                If x <> CheckedListBox22.CheckedItems.Count - 1 Then
                    checkedBoxText22 = checkedBoxText22 & ", "
                End If
            Next x
        Else
            checkedBoxText22 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub CheckedListBox23_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox23.SelectedIndexChanged

        checkedBoxText23 = "Toxic "

        If CheckedListBox23.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox23.CheckedItems.Count - 1
                If CheckedListBox23.CheckedItems(x).ToString <> "" Then checkedBoxText23 = checkedBoxText23 & CheckedListBox23.CheckedItems(x).ToString
                If x <> CheckedListBox23.CheckedItems.Count - 1 Then
                    checkedBoxText23 = checkedBoxText23 & ", "
                End If
            Next x
        Else
            checkedBoxText23 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub CheckedListBox24_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox24.SelectedIndexChanged

        checkedBoxText24 = "Harmful "

        If CheckedListBox24.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox24.CheckedItems.Count - 1
                If CheckedListBox24.CheckedItems(x).ToString <> "" Then checkedBoxText24 = checkedBoxText24 & CheckedListBox24.CheckedItems(x).ToString
                If x <> CheckedListBox24.CheckedItems.Count - 1 Then
                    checkedBoxText24 = checkedBoxText24 & ", "
                End If
            Next x
        Else
            checkedBoxText24 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub CheckedListBox25_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox25.SelectedIndexChanged

        checkedBoxText25 = "Causes "

        If CheckedListBox25.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox25.CheckedItems.Count - 1
                If CheckedListBox25.CheckedItems(x).ToString <> "" Then checkedBoxText25 = checkedBoxText25 & CheckedListBox25.CheckedItems(x).ToString
                If x <> CheckedListBox25.CheckedItems.Count - 1 Then
                    checkedBoxText25 = checkedBoxText25 & ", "
                End If
            Next x
        Else
            checkedBoxText25 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub CheckedListBox26_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox26.SelectedIndexChanged

        checkedBoxText26 = "May cause "

        If CheckedListBox26.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox26.CheckedItems.Count - 1
                If CheckedListBox26.CheckedItems(x).ToString <> "" Then checkedBoxText26 = checkedBoxText26 & CheckedListBox26.CheckedItems(x).ToString
                If x <> CheckedListBox26.CheckedItems.Count - 1 Then
                    checkedBoxText26 = checkedBoxText26 & ", "
                End If
            Next x
        Else
            checkedBoxText26 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub CheckedListBox27_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox27.SelectedIndexChanged

        checkedBoxText27 = "May damage "

        If CheckedListBox27.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox27.CheckedItems.Count - 1
                If CheckedListBox27.CheckedItems(x).ToString <> "" Then checkedBoxText27 = checkedBoxText27 & CheckedListBox27.CheckedItems(x).ToString
                If x <> CheckedListBox27.CheckedItems.Count - 1 Then
                    checkedBoxText27 = checkedBoxText27 & ", "
                End If
            Next x
        Else
            checkedBoxText27 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub CheckedListBox28_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox28.SelectedIndexChanged

        checkedBoxText28 = "Suspected of "

        If CheckedListBox28.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox28.CheckedItems.Count - 1
                If CheckedListBox28.CheckedItems(x).ToString <> "" Then checkedBoxText28 = checkedBoxText28 & CheckedListBox28.CheckedItems(x).ToString
                If x <> CheckedListBox28.CheckedItems.Count - 1 Then
                    checkedBoxText28 = checkedBoxText28 & ", "
                End If
            Next x
        Else
            checkedBoxText28 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub CheckedListBox29_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox29.SelectedIndexChanged

        checkedBoxText29 = vbNewLine & "Prop 65: "

        If CheckedListBox29.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox29.CheckedItems.Count - 1
                If CheckedListBox29.CheckedItems(x).ToString <> "" Then checkedBoxText29 = checkedBoxText29 & CheckedListBox29.CheckedItems(x).ToString
                If x <> CheckedListBox29.CheckedItems.Count - 1 Then
                    checkedBoxText29 = checkedBoxText29 & ", "
                End If
            Next x
        Else
            checkedBoxText29 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub CheckedListBox31_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox31.SelectedIndexChanged

        checkedBoxText31 = "Very toxic "

        If CheckedListBox31.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox31.CheckedItems.Count - 1
                If CheckedListBox31.CheckedItems(x).ToString <> "" Then checkedBoxText31 = checkedBoxText31 & CheckedListBox31.CheckedItems(x).ToString
                If x <> CheckedListBox31.CheckedItems.Count - 1 Then
                    checkedBoxText31 = checkedBoxText31 & ", "
                End If
            Next x
        Else
            checkedBoxText31 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub CheckedListBox32_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox32.SelectedIndexChanged

        checkedBoxText32 = "Toxic "

        If CheckedListBox32.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox32.CheckedItems.Count - 1
                If CheckedListBox32.CheckedItems(x).ToString <> "" Then checkedBoxText32 = checkedBoxText32 & CheckedListBox32.CheckedItems(x).ToString
                If x <> CheckedListBox32.CheckedItems.Count - 1 Then
                    checkedBoxText32 = checkedBoxText32 & ", "
                End If
            Next x
        Else
            checkedBoxText32 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub CheckedListBox33_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox33.SelectedIndexChanged

        checkedBoxText33 = "Harmful "

        If CheckedListBox33.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox33.CheckedItems.Count - 1
                If CheckedListBox33.CheckedItems(x).ToString <> "" Then checkedBoxText33 = checkedBoxText33 & CheckedListBox33.CheckedItems(x).ToString
                If x <> CheckedListBox33.CheckedItems.Count - 1 Then
                    checkedBoxText33 = checkedBoxText33 & ", "
                End If
            Next x
        Else
            checkedBoxText33 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub CheckedListBox34_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckedListBox34.SelectedIndexChanged

        checkedBoxText34 = "May cause "

        If CheckedListBox34.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            For x = 0 To CheckedListBox34.CheckedItems.Count - 1
                If CheckedListBox34.CheckedItems(x).ToString <> "" Then checkedBoxText34 = checkedBoxText34 & CheckedListBox34.CheckedItems(x).ToString
                If x <> CheckedListBox34.CheckedItems.Count - 1 Then
                    checkedBoxText34 = checkedBoxText34 & ", "
                End If
            Next x
        Else
            checkedBoxText34 = ""
        End If

        Call changeHazardText()

    End Sub

    Private Sub changeHazardText()

        'Dimension variables and clear
        physicalHazardText = ""
        healthHazardText = ""
        environmentalHazardText = ""

        'Clear text box
        hazardsFormTextBox.Text = ""

        'Physical Hazards
        physicalHazardText = "Physical: "

        If checkedBoxText11 <> "" Then physicalHazardText = physicalHazardText & checkedBoxText11 & "; "
        If checkedBoxText12 <> "" Then physicalHazardText = physicalHazardText & checkedBoxText12 & "; "
        If checkedBoxText13 <> "" Then physicalHazardText = physicalHazardText & checkedBoxText13 & "; "
        If checkedBoxText14 <> "" Then physicalHazardText = physicalHazardText & checkedBoxText14 & "; "
        If checkedBoxText15 <> "" Then physicalHazardText = physicalHazardText & checkedBoxText15 & "; "
        If checkedBoxText16 <> "" Then physicalHazardText = physicalHazardText & checkedBoxText16

        If physicalHazardText.Substring(physicalHazardText.Length - 2) = "; " Then
            physicalHazardText = physicalHazardText.Substring(0, physicalHazardText.Length - 2)
        End If

        physicalHazardText = physicalHazardText & ". "

        If checkedBoxText11 = "" And checkedBoxText12 = "" And checkedBoxText13 = "" And checkedBoxText14 = "" And checkedBoxText15 = "" And checkedBoxText16 = "" Then physicalHazardText = ""

        'Health Hazards
        healthHazardText = "Health: "

        If checkedBoxText21 <> "" Then healthHazardText = healthHazardText & checkedBoxText21 & "; "
        If checkedBoxText22 <> "" Then healthHazardText = healthHazardText & checkedBoxText22 & "; "
        If checkedBoxText23 <> "" Then healthHazardText = healthHazardText & checkedBoxText23 & "; "
        If checkedBoxText24 <> "" Then healthHazardText = healthHazardText & checkedBoxText24 & "; "
        If checkedBoxText25 <> "" Then healthHazardText = healthHazardText & checkedBoxText25 & "; "
        If checkedBoxText26 <> "" Then healthHazardText = healthHazardText & checkedBoxText26 & "; "
        If checkedBoxText27 <> "" Then healthHazardText = healthHazardText & checkedBoxText27 & "; "
        If checkedBoxText28 <> "" Then healthHazardText = healthHazardText & checkedBoxText28 & "; "

        If healthHazardText.Substring(healthHazardText.Length - 2) = "; " Then
            healthHazardText = healthHazardText.Substring(0, healthHazardText.Length - 2)
        End If

        healthHazardText = healthHazardText & ". "

        If checkedBoxText29 <> "" Then healthHazardText = healthHazardText & checkedBoxText29 & ". "

        If checkedBoxText21 = "" And checkedBoxText22 = "" And checkedBoxText23 = "" And checkedBoxText24 = "" And checkedBoxText25 = "" And checkedBoxText26 = "" And checkedBoxText27 = "" And checkedBoxText28 = "" And checkedBoxText29 = "" Then healthHazardText = ""

        'Environmental Hazards
        environmentalHazardText = "Environmental: "

        If checkedBoxText31 <> "" Then environmentalHazardText = environmentalHazardText & checkedBoxText31 & "; "
        If checkedBoxText32 <> "" Then environmentalHazardText = environmentalHazardText & checkedBoxText32 & "; "
        If checkedBoxText33 <> "" Then environmentalHazardText = environmentalHazardText & checkedBoxText33 & "; "
        If checkedBoxText34 <> "" Then environmentalHazardText = environmentalHazardText & checkedBoxText34 & "; "

        If environmentalHazardText.Substring(environmentalHazardText.Length - 2) = "; " Then
            environmentalHazardText = environmentalHazardText.Substring(0, environmentalHazardText.Length - 2)
        End If

        environmentalHazardText = environmentalHazardText & ". "

        If checkedBoxText31 = "" And checkedBoxText32 = "" And checkedBoxText33 = "" And checkedBoxText34 = "" Then environmentalHazardText = ""

        'Create new string
        If physicalHazardText <> "" Then hazardsFormTextBox.Text = hazardsFormTextBox.Text & physicalHazardText & vbNewLine
        If healthHazardText <> "" Then hazardsFormTextBox.Text = hazardsFormTextBox.Text & healthHazardText & vbNewLine
        If environmentalHazardText <> "" Then hazardsFormTextBox.Text = hazardsFormTextBox.Text & environmentalHazardText & vbNewLine

    End Sub

End Class