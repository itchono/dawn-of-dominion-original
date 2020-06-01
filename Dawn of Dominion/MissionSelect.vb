'Used in singleplayer for when the user chooses their SP mission

Public Class MissionSelect

    Dim btnMissions(9) As Button
    'The buttons for selecting the mission - 3 rows of 5

    Dim strMissionDescriptions() As String = New String(9) {"Mission 1: The Shadow Menace" & vbCrLf & "The Dark Order, an Umbra splinter group, is threatening to destroy the entirety of Gliese society. Stop them and save the planet!",
                                                            "Mission 2: Flint and Steel" & vbCrLf & "The Last Ember are a powerful coalition of radicalists trying to destroy the world. Their leader has seen you as a significant threat!",
                                                            "Mission 3: Return of the prisma" & vbCrLf & "Prevent Singluaros from abandoning the planet! They are attempting to take the entire Prisma race off the planet - but we need them to stay for our planet!",
                                                            "Mission 4: A New Pope" & vbCrLf & "The Elementan are struggling with their current religious leader - they need you to banish the current Pope so that a new one may come!",
                                                            "Mission 5: The Race for Equity" & vbCrLf & "The Equanos want to industrialize the world to the point of destruction! They will stop at nothing, unless you have something to do about it...",
                                                            "Mission 6: The Grass is Always Greener" & vbCrLf & "The Elementan are untrusting of your power. They want to see that you can change the world.",
                                                            "Mission 7: Trial by Fire" & vbCrLf & "The Infernus refuse to bow down to you, and want a fight for dominion!",
                                                            "Mission 8: The Light at the End" & vbCrLf & "The Prisma dislike your way of thinking and want you to justify your powers.",
                                                            "Mission 9: A Dark Twist" & vbCrLf & "The Umbra are desperately trying to stop the Dark Order. They will back your cause, but only if you can show them how well you fight.",
                                                            "Mission 10: Confrontation" & vbCrLf & "It's all come down to this. The Dark Order and The Last Ember have joined forces to make the Somber Dusk. Will you be able to stop them and save Gliese 581g?"}
    'The descriptions for each mission

    Private Sub MissionSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Make array of buttons for shop
        For Sequencer = 0 To 9
            'Button for the unit itself
            btnMissions(Sequencer) = New Button
            btnMissions(Sequencer).Font = New Font("Century Gothic", 14, FontStyle.Bold)
            btnMissions(Sequencer).Size = New Size(100, 95)
            btnMissions(Sequencer).Location = New Point(15 + 120 * (Sequencer Mod 5), 20 + Int(Sequencer / 5) * 100)
            btnMissions(Sequencer).AccessibleDescription = Sequencer
            btnMissions(Sequencer).TabStop = False
            'Make it easier to set mission number

            If My.Settings.SaveState > Sequencer Then
                btnMissions(Sequencer).BackColor = Color.Gray
                btnMissions(Sequencer).Text = Sequencer + 1
            ElseIf My.Settings.SaveState = Sequencer Then
                'If the mission is doable, add an asterisk
                btnMissions(Sequencer).BackColor = Color.DarkGray
                btnMissions(Sequencer).Text = Sequencer + 1 & "*"
            Else
                'If mission is far away
                btnMissions(Sequencer).BackColor = Color.Gray
                btnMissions(Sequencer).Image = My.Resources.Graphic_Lock
            End If

            pnlMissions.Controls.Add(btnMissions(Sequencer))
            AddHandler btnMissions(Sequencer).Click, AddressOf MissionClick
        Next

        'Set Music
        MusicChange(4)

        'Randomly choose a splash art for the BG
        Select Case Int(3 * Rnd())
            Case 0
                Me.BackgroundImage = My.Resources.Graphic_WarScape1
            Case 1
                Me.BackgroundImage = My.Resources.Graphic_WarScape2
            Case 2
                Me.BackgroundImage = My.Resources.Graphic_WarScape3
        End Select

        'Unlock the secret mode if the player has finished all missions
        If My.Settings.SaveState > 9 Then
            btnAdvancedAI.Visible = True
        End If

    End Sub

    Private Sub btnReturnMenu_Click(sender As Object, e As EventArgs) Handles btnReturnMenu.Click
        'Verify choice first
        If MsgBox("Are you sure you want to return to the menu?", MsgBoxStyle.YesNo, "Return to Menu?") = MsgBoxResult.Yes Then
            MainMenu.Show()
            Me.Close()
        End If
    End Sub

    Sub MissionClick(sender As Object, e As EventArgs)
        'When a mission is selected
        shrMissionNumber = sender.accessibledescription
        'Easy way to set mission number (accessibledescription)

        lblMissionInfo.Text = strMissionDescriptions(shrMissionNumber)
        'Load mission info

        btnStart.Enabled = My.Settings.SaveState >= shrMissionNumber
        'Enable or disable start depending on eligibility
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        MapSelect.Show()
        Me.Close()
    End Sub

    Private Sub btnAdvancedAI_Click(sender As Object, e As EventArgs) Handles btnAdvancedAI.Click
        'For selecting the Advanced AI mode
        lblMissionInfo.Text = "Try your luck against the game's slightly more advanced AI. Beware, the game may break at times!"
        shrMissionNumber = 10
        btnStart.Enabled = True
    End Sub
End Class