'Introduction to the singleplayer story

Public Class SPlayerIntro

    Dim shrSequenceTick, shrDialogueCount As Short
    'For putting the text in, in a cool manner
    'Determines the line to be displayed

    Dim blnQuickIntro As Boolean
    'In case the user needs to skip

    Dim strLines() As String = New String(24) {"SURFACE OF Gliese 581g, NILABASK PLANNUM, DUSK",
                                               "...",
                                               "Old Man: ???",
                                               "Old Man: Hello?",
                                               "...",
                                               "Old Man: Ah, yes. Good day. You, are you trying to escape the war?",
                                               "Old Man: There’s no use. It’s only going to get worse and worse.",
                                               "...",
                                               "Old Man: Let me tell you a story.",
                                               "Old Man: 1.8 billion years ago, a life on our planet formed. Our planet was big enough to sustain all the species who took from our planet." & vbCrLf & "But as they grew more advanced, our planet grew tired.",
                                               "Old Man: Early on, there were proposals to stop our heavy dependence on the planet, or even to move off of it. None of those plans worked.",
                                               "Old Man: Tensions rose, and one by one, the advanced races of our planet were pointing their guns at each other.",
                                               "Old Man: It started with a few individuals fighting on front lines.",
                                               "Old Man: Then, entire races were wiped off the face of the planet.",
                                               "Old Man: Now, there are only 5 races left on this planet, not counting ones like you and me.",
                                               "Old Man: On that matter, what is your name?",
                                               "Old Man: Ah yes, <name>.  Now, where was I? Ehm, yes:",
                                               "Old Man: The war is now a stalemate.",
                                               "Old Man: If we are to survive on this planet, someone will need to reunite the planet, and show how unity is stronger than isolation.",
                                               "...",
                                               "Old Man: Look to the west - the suns are setting.",
                                               "Old Man: If no action is to be taken, we may not see many more dawns.",
                                               "...",
                                               "Old Man: My story is finished. It is up to you to save the planet, if you so choose. Please, <name>, do not let the suns set on our planet’s life. Bring dawn to our planet - ",
                                               "Old Man: A dawn of dominion."}
    'The lines said by the Old Man in the intro

    Private Sub txtNameInput_TextChanged(sender As Object, e As EventArgs) Handles txtNameInput.TextChanged
        'When the name in the textbox changes, reverify vailidity

        'Checks for blank, valid
        If txtNameInput.Text Like "" Then
            txtNameInput.BackColor = Color.Red
            btnSubmitName.Enabled = False
        Else
            txtNameInput.BackColor = Color.White
            btnSubmitName.Enabled = True
        End If
    End Sub

    Private Sub tmrTextIn_Tick(sender As Object, e As EventArgs) Handles tmrTextIn.Tick
        'Used for sequencing in the text
        If shrSequenceTick <= Len(strLines(shrDialogueCount)) Then
            lblStoryText.Text += Mid(strLines(shrDialogueCount), shrSequenceTick, 1)
            'This may seem really daunting, but let's decompose it.

            'First, the If statement.
            'It checks on the length of the string to be used as dialogue
            'Because if the word is done sequencing in, we stop the timer.

            'Next, the code.
            'Every tick of the timer, there is a new bit of text displayed in the dialogue box.
            'Ex. Tick 1: a
            '    Tick 2: ap
            '    Tick 5: apple --> looks like old school videogame dialogue

            'Back to the code
            'The string used in mid is the same one that we talked about above - that's already 4 variables accounted for. See? Easy.
            'The position is the sequencetick (number of elapsed ticks)
            'And we take 1 character each time, and stick it to the end
            'Easy as that.

        Else
            'If it's done, stop
            tmrTextIn.Stop()

            If shrDialogueCount = 15 Then
                'Special: Ask player for name
                pnlName.Visible = True
            Else
                btnNext.Enabled = True
            End If

        End If

        shrSequenceTick += 1
        'Advance by 1

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Advance the story

        lblStoryText.Text = Nothing
        'Purge text

        shrSequenceTick = 1
        shrDialogueCount += 1

        tmrTextIn.Start()
        'Fade in dialogue
        btnNext.Enabled = False

        'Event - Player has finished dialogue
        If shrDialogueCount > 24 Then
            MissionSelect.Show()
            Me.Close()
        End If

        Select Case shrDialogueCount
            'Change the image at set points

            'NOTE: If animations are disabled, the static image versions are displayed instead
            Case 2
                pbxStory.Image = My.Resources.Graphic_LandScapeMan
            Case 9
                If My.Settings.Animations = True Then
                    pbxStory.Image = My.Resources.Anim_GliesePast
                Else
                    pbxStory.Image = My.Resources.Graphic_StaticGliesePast
                End If
            Case 11
                If My.Settings.Animations = True Then
                    pbxStory.Image = My.Resources.Anim_GlieseNow
                Else
                    pbxStory.Image = My.Resources.Graphic_StaticGlieseNow
                End If
            Case 12
                pbxStory.Image = My.Resources.Graphic_WarScape1
            Case 13
                pbxStory.Image = My.Resources.Graphic_WarScape2
            Case 14
                pbxStory.Image = My.Resources.Graphic_LandScapeMan
            Case 17
                pbxStory.Image = My.Resources.Graphic_WarScape3
            Case 18
                pbxStory.Image = My.Resources.Anim_GlieseNow
            Case 19
                pbxStory.Image = My.Resources.Graphic_SunFullSet
            Case 23
                pbxStory.Image = Nothing
            Case 24
                If My.Settings.Animations = True Then
                    pbxStory.Image = My.Resources.Anim_GlieseNow
                Else
                    pbxStory.Image = My.Resources.Graphic_StaticGlieseNow
                End If
        End Select
    End Sub

    Private Sub SPlayerIntro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shrSequenceTick = 1
        tmrTextIn.Start()
        MusicChange(2)
    End Sub

    Private Sub btnSubmitName_Click(sender As Object, e As EventArgs) Handles btnSubmitName.Click
        'When the name is submitted

        My.Settings.SaveUser = txtNameInput.Text
        'Set username

        My.Settings.SaveState = 0
        'Player now has set name - will go directly to Mission Select on next playthrough

        If blnQuickIntro = True Then
            'If it's a speedy run, go straight to the missionselect screen
            MissionSelect.Show()
            Me.Close()

        Else
            'If it's a normal run,
            strLines(23) = Mid(strLines(23), 1, InStr(strLines(23), "<name>") - 1) & My.Settings.SaveUser & Mid(strLines(23), InStr(strLines(23), "<name>") + 6)
            strLines(16) = Mid(strLines(16), 1, InStr(strLines(16), "<name>") - 1) & My.Settings.SaveUser & Mid(strLines(16), InStr(strLines(16), "<name>") + 6)

            pnlName.Visible = False
            btnNext.Enabled = True
            btnNext.PerformClick()
        End If
    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        tmrTextIn.Stop()
        'Stop timer in case user had started it

        btnSkip.Enabled = False
        btnNext.Enabled = False
        'Disables the buttons

        If strUserNames(0) Like Nothing Then
            'If username has not been inputted yet
            lblStoryText.Text = "Please input a username."
            blnQuickIntro = True
            'Quick mode activated
            pnlName.Show()

        Else
            'If it HAS (remember, the skip intro button is available even after the player inputs their username in the story
            MissionSelect.Show()
            Me.Close()
        End If

    End Sub

    Private Sub txtNameInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNameInput.KeyDown
        If e.KeyCode = 13 Then
            btnSubmitName.PerformClick()
        End If
    End Sub

    Private Sub btnReturnMenu_Click(sender As Object, e As EventArgs) Handles btnReturnMenu.Click
        'Confirm before going back
        If MsgBox("Are you sure you want to return to the menu?", MsgBoxStyle.YesNo, "Return to Menu?") = MsgBoxResult.Yes Then
            MainMenu.Show()
            Me.Close()
        End If
    End Sub
End Class