'Used in SP and 1 on 1 for choosing the map and race (also for usernames in 1 on 1)

Public Class MapSelect

    Dim btnMapPreview(6, 6) As Button
    'Used to previewing the maps

    Dim shrTurnNumber As Short = 1
    'Used for differentiating choices in 1 on 1 (who selects what)

    Dim shrMapSelect, shrRaceSelect, shrRaceLimit As Short
    'Selected map and race
    'Mainly for singleplayer, limits what races the player can choose from

    Public strRaceInfo(,) As String = New String(1, 4) {{"Equanos", "Elementan", "Infernus", "Prisma", "Umbra"},
                                                     {"The Equanos are the most populous race on Gliese 581g, with a population nearing 11.5 billion." & vbCrLf &
                                                         "Their core mindset focuses on maintaining balance through nationalism and industrial power." & vbCrLf & vbCrLf &
                                                         "PASSIVE: COMMUNISM BOOSTER - Gain an additional 15% of your current money per turn (not as income).",
                                                      "Heavily associated with the power of nature, the Elementan are the most traditional race on Gliese 581g." & vbCrLf &
                                                      "With a profound connection to the planet's natural energy, they are determined to fight it out." & vbCrLf & vbCrLf &
                                                      "PASSIVE: MENDING SAP - All units under 80% HP regenerate 8% of their maximum HP per turn.",
                                                      "Blazing with power, the Infernus are the most violent race on the planet." & vbCrLf &
                                                      "With many centuries of war experience, their weapons are at the pinnacle of technology." & vbCrLf & vbCrLf &
                                                      "PASSIVE: FLAMING AMMUNITION - Attacks on units burn over 3 turns, dealing 10% of their maximum health per turn.",
                                                      "The Prisma are a transcendent spacefaring race with an innate ability to strike hard." & vbCrLf &
                                                      "Their basic design principle is to hit hard and hit once - disregarding staying power." & vbCrLf & vbCrLf &
                                                      "PASSIVE: ILLUMINATION - An enemy square is revealed randomly once every turn.",
                                                      "The Umbra are the most mysterious race on Gliese 581g. Seldom seen, they are difficult" & vbCrLf &
                                                      "to take down and even more difficult to evade. This dangerous race is only seen in the void." & vbCrLf & vbCrLf &
                                                      "PASSIVE: DARK AFFINITY - Heat signature is reduced by 50% on all units."}}
    'Stats and info for the races

    Private Sub MapSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For GridX = 0 To 6
            'For Loop used to generate first index (horizontal), does not actually make buttons
            'Simply used to make an easy to manage coordinate system

            For GridY = 0 To 6
                'For Loop used to make the actual buttons (vertical)

                btnMapPreview(GridX, GridY) = New Button
                btnMapPreview(GridX, GridY).Size = New Size(50, 50)


                btnMapPreview(GridX, GridY).Location = New Point(50 + 50 * GridX, 50 * GridY)
                'Positioning - self contained within generation
                '"50 * GridX and GridY" is used for displacing each button within each grid

                pnlMapPreview.Controls.Add(btnMapPreview(GridX, GridY))
                'Add to panel

                AddHandler btnMapPreview(GridX, GridY).MouseEnter, AddressOf GridTooltip
            Next
        Next

        UpdateMap()
        UpdateRace()
        'Set initial state for selection

        If blnPlayMode = True Then
            'If the user is playing singleplayer

            shrMoneyStart = 3000

            '(No need to change music, already started from MissionSelect)

            'Set AI stats
            'Includes map and race choice
            Select Case shrMissionNumber
                Case 0
                    'Mission 1: The Shadow Menace
                    shrPlayerChoice(1, 1) = 2
                    shrPlayerChoice(0, 1) = -1
                Case 1
                    'Mission 2: Flint and Steel
                    shrPlayerChoice(1, 1) = 0
                    shrPlayerChoice(0, 1) = 2
                Case 2
                    'Mission 3: Return of the prisma
                    shrPlayerChoice(1, 1) = 5
                    shrPlayerChoice(0, 1) = 3
                Case 3
                    'Mission 4: A New Pope
                    shrPlayerChoice(1, 1) = 4
                    shrPlayerChoice(0, 1) = 1
                Case 4
                    'Mission 5: The Race for Equity
                    shrPlayerChoice(1, 1) = 1
                    shrPlayerChoice(0, 1) = 0
                Case 5
                    'Mission 6: The Grass is Always Greener
                    shrPlayerChoice(1, 1) = 4
                    shrPlayerChoice(0, 1) = 1
                Case 6
                    'Mission 7: Trial by Fire
                    shrPlayerChoice(1, 1) = 6
                    shrPlayerChoice(0, 1) = 2
                Case 7
                    'Mission 8: The Light at the End
                    shrPlayerChoice(1, 1) = 3
                    shrPlayerChoice(0, 1) = 3
                Case 8
                    'Mission 9: A Dark Twist
                    shrPlayerChoice(1, 1) = 2
                    shrPlayerChoice(0, 1) = 4
                Case 9
                    'Mission 10: Confrontation
                    shrPlayerChoice(1, 1) = 5
                    shrPlayerChoice(0, 1) = 4
                Case 10
                    'Advanced AI
                    shrPlayerChoice(1, 1) = Int(7 * Rnd())
                    shrPlayerChoice(0, 1) = Int(5 * Rnd())

            End Select

            If shrMissionNumber <= 4 Then
                'Between missions 1 and 5
                btnRaceFwd.Enabled = False
                btnRaceBack.Enabled = False
                pbxRacePassive.Image = Nothing
                lblRaceName.Text = "No Race Selected"
                'Disable race selection
                shrRaceLimit = -1

                shrRaceSelect = -1

                lblRaceDesc.ForeColor = Color.Red
                lblRaceDesc.Text = "Race selection is locked until you gain the influence of other races! (Missions 5 to 9)"

            ElseIf shrMissionNumber >= 5 And shrMissionNumber <= 8 Then
                'Missions 6 to 9
                shrRaceLimit = shrMissionNumber - 5
                shrRaceSelect = 0
                UpdateRace()
            Else
                'Mission 10 = All races unlocked
                shrRaceLimit = 4
                UpdateRace()
            End If


            'Prompt them to do their choice
            shrTurnNumber -= 1
            lblAskName.Text = My.Settings.SaveUser & ", it is your time to choose!"
            txtNameInput.Visible = False
            lblNameQuery.Visible = False

            btnSubmit.Enabled = True
        Else
            'If it's 2 player
            shrRaceLimit = 4

            gbx2PlrAdvanced.Visible = True
            'Enable advanced settings

            UpdateRace()

            MusicChange(3)
            'Change the music
        End If
    End Sub

    Private Sub UpdateMap()
        'Update the appearance of the map

        Dim strMapString As String = GameMode.strMapData(0, shrMapSelect)
        'Declare a temp string

        Dim shrMapGen As Short = 1
        'Counter for map generation

        For GridX = 0 To 6
            For GridY = 0 To 6
                Select Case Mid(strMapString, 1, 1)
                    Case "G"
                        btnMapPreview(GridX, GridY).BackColor = Color.FromArgb(85, 139, 47)
                    Case "W"
                        btnMapPreview(GridX, GridY).BackColor = Color.FromArgb(25, 118, 210)
                    Case "A"
                        btnMapPreview(GridX, GridY).BackColor = Color.WhiteSmoke
                    Case "V"
                        btnMapPreview(GridX, GridY).BackColor = Color.DarkSlateGray
                End Select
                'Colour the grid based on the terrain type

                If shrMapGen >= Val(Mid(strMapString, 2, 2)) Then
                    strMapString = Mid(strMapString, InStr(strMapString, "|") + 1)
                    shrMapGen = 1
                Else
                    shrMapGen += 1
                End If
            Next
        Next

        lblMapName.Text = GameMode.strMapData(1, shrMapSelect)

        'CHECK VALIDITY OF BUTTON CLICKS

        Select Case shrMapSelect
            Case Is <= 0
                btnMapBack.Enabled = False
            Case Is >= UBound(GameMode.strMapData, 2)
                'Check that it is within max bounds of the array
                btnMapFwd.Enabled = False
            Case Else
                btnMapBack.Enabled = True
                btnMapFwd.Enabled = True
        End Select

    End Sub

    Sub UpdateRace()
        'Update the appearance of the race info

        lblRaceName.Text = strRaceInfo(0, shrRaceSelect)
        lblRaceDesc.Text = strRaceInfo(1, shrRaceSelect)
        pbxRacePassive.Image = iglRace.Images(shrRaceSelect)

        'CHECK VALIDITY OF BUTTON CLICKS

        Select Case shrRaceSelect
            Case Is <= 0
                btnRaceBack.Enabled = False
                btnRaceFwd.Enabled = True
            Case Is >= shrRaceLimit
                btnRaceFwd.Enabled = False
                btnRaceBack.Enabled = True
            Case Else
                btnRaceBack.Enabled = True
                btnRaceFwd.Enabled = True
        End Select

        If shrRaceLimit = 0 Then
            'Special case: Mission 5
            btnRaceBack.Enabled = False
            btnRaceFwd.Enabled = False
        End If
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Log choice
        shrPlayerChoice(0, shrTurnNumber) = shrRaceSelect
        shrPlayerChoice(1, shrTurnNumber) = shrMapSelect

        If shrTurnNumber = 0 Then
            'Go to gamemode
            GameMode.Show()
            Me.Close()
        Else
            'Cycle to next person
            shrTurnNumber -= 1
            txtNameInput.Clear()
            lblAskName.Text = "Player 1, it is your turn to choose!"
            txtNameInput.BackColor = Color.White

            'Also, reset the selection choice so that there is no cheating until the game starts
            shrMapSelect = 0
            shrRaceSelect = 0
            UpdateMap()
            UpdateRace()

            btnMapFwd.Enabled = True
            btnRaceFwd.Enabled = True
            'Check just in case
        End If
    End Sub

    Private Sub GridTooltip(sender As Object, e As EventArgs)
        'Set a tooltip based on the terrain type of a square (based purely on colour since nothing is changing)
        Select Case sender.backcolor
            Case Color.FromArgb(85, 139, 47)
                ttpDescription.SetToolTip(sender, "Ground")
            Case Color.FromArgb(25, 118, 210)
                ttpDescription.SetToolTip(sender, "Water")
            Case Color.WhiteSmoke
                ttpDescription.SetToolTip(sender, "Air")
            Case Color.DarkSlateGray
                ttpDescription.SetToolTip(sender, "Void")
            Case Else
                ttpDescription.SetToolTip(sender, "???")
        End Select
    End Sub

    'MAP FORWARDS/BACK
    Private Sub MapFwd_Click(sender As Object, e As EventArgs) Handles btnMapFwd.Click
        shrMapSelect += 1
        UpdateMap()
    End Sub

    Private Sub MapBack_Click(sender As Object, e As EventArgs) Handles btnMapBack.Click
        shrMapSelect -= 1
        UpdateMap()
    End Sub

    Private Sub btnReturnMenu_Click(sender As Object, e As EventArgs) Handles btnReturnMenu.Click
        'Verify before closing
        If MsgBox("Are you sure you want to return to the menu?", MsgBoxStyle.YesNo, "Return to Menu?") = MsgBoxResult.Yes Then
            MainMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub NameVerify(sender As Object, e As EventArgs) Handles txtNameInput.TextChanged
        'Check that the user's name is valid

        If txtNameInput.Text Like "" Then
            txtNameInput.BackColor = Color.Red
            If shrTurnNumber = 0 Then
                lblAskName.Text = "Player 1, it is now your turn to choose!"
            Else
                lblAskName.Text = "Player 2, it is your turn to choose!"
            End If
            btnSubmit.Enabled = False

        Else
            txtNameInput.BackColor = Color.White

            If shrTurnNumber = 0 Then
                lblAskName.Text = txtNameInput.Text & ", it is now your turn to choose!"
            Else
                lblAskName.Text = txtNameInput.Text & ", it is your turn to choose!"
            End If

            btnSubmit.Enabled = True
        End If

        strUserNames(shrTurnNumber) = txtNameInput.Text
    End Sub

    'RACE FORWARDS/BACK
    Private Sub btnRaceFwd_Click(sender As Object, e As EventArgs) Handles btnRaceFwd.Click
        shrRaceSelect += 1
        UpdateRace()
    End Sub

    Private Sub btnRaceBack_Click(sender As Object, e As EventArgs) Handles btnRaceBack.Click
        shrRaceSelect -= 1
        UpdateRace()
    End Sub

    Private Sub nudStartCash_ValueChanged(sender As Object, e As EventArgs) Handles nudStartCash.ValueChanged
        'Change starting cash
        shrMoneyStart = nudStartCash.Value
    End Sub
End Class