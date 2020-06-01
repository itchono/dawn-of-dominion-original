'A cutscene shown before and after every SP mission

Public Class Cutscene

    Dim shrSequenceTick As Short
    'Used for "fading" in the cutscene
    'Also used for text fading - efficient use of variable

    Dim strText(,) As String = New String(1, 9) {{"The Dark Order is a dangerous force, one that has wreaked havoc on Gliese 581g for over 250 years. " &
                                                    "They are an advanced group of extremists trying to eradicate life on the planet, and you're their next target. " &
                                                    "It looks like you've caught them off guard! Their heat dampeners are turned off and they only have a few operational units!",
                                                  "The Last Ember are the other dangerous group on this planet. After hearing about your recent endeavours, Jlon-Haidson Yu, " &
                                                  "the leader of the coalition, has spotted you as a major threat to their existence. Prepare for a fight!",
                                                  "The Prisma's IXV-0023 is preparing to make a jump into deep space. They're not convinced that anyone on this planet is worth saving..." &
                                                  "Their only opinion of you is as a useless citizen of the planet. Can you show them otherwise?",
                                                  "The current Elementan Pope, Banos Hjarne, is dismissing efforts to destroy the world as false. " &
                                                  "The Elementan, however, want to overthrow him and reestablish proper leadership. Beware, Hjarne's forces are durable!",
                                                  "The Equanos are the first to reach out towards you. The recent news of your power interests them... " &
                                                  "They want to see how strong you truly are.",
                                                  "The Elementan leadership council have seen you as a true force of nature. Now, their forces have come to test you...",
                                                  "The Infernus refuse to be absorbed by the likes of you! They challenge you to a fight!",
                                                  "The Prisma assert themselves as wiser than you. They waste no time in readying their military.",
                                                  "The Umbra are impressed with what you have accomplished to date, but they want to see your power first hand...",
                                                  "The leader of the Somber Dusk will accept nothing but your surrender. You've come much too far to back down... " &
                                                  "You ready yourself, and prepare to fight for the fate of Gliese 581g!"},
                                                 {"Well, it looks like they've been satisfied for now. However, the Dark Order is far from destroyed. " &
                                                     "Now that they've found a worthy opponent, they will come back even stronger. Beware, news of this will spread!",
                                                  "The Last Ember are significantly weakened, but also angered. Who knows, they might find someone else to team up with...",
                                                  "The Prisma are shocked at your wit, and they reconsider leaving Gliese 581g.",
                                                  "With their new leader, the Elementan thank you for your efforts. They take note of your name.",
                                                  "The Equanos are impressed by your power. They have agreed to follow your orders and join you on your quest!",
                                                  "The Elementan are astounded! They form an alliance with you, willing to help whenever needed.",
                                                  "The Infernus apologize for their initial conduct towards you. You have truly earned their respect. They now bow down to you!",
                                                  "The Prisma acknowledge your intelligence and honour you as their most sacred asset. They are now under your command.",
                                                  "The Umbra knew from the beginning your great power. They are certain that they can help you.",
                                                  "With the Somber Dusk defeated, the planet rejoyces. You have shown that the unity of everyone is the true solution. " &
                                                  "Each race has decided to cooperate, to restore the planet to its original state. You have truly establised a Dawn of Dominion."}}
    'Text used for the cutscene

    Private Sub Cutscene_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set initial state of form
        rctBackGround.FillStyle = PowerPacks.FillStyle.Transparent
        lblText.Visible = False

        btnNext.Enabled = False
        shrSequenceTick = 0
        tmrTransition.Start()
    End Sub

    Private Sub tmrTransition_Tick(sender As Object, e As EventArgs) Handles tmrTransition.Tick
        'Make the rectangle "opacity" go up for a pseudo fadein effect

        Select Case shrSequenceTick
            'Nothing on first tick
            Case 1
                rctBackGround.FillStyle = PowerPacks.FillStyle.Percent10
            Case 2
                rctBackGround.FillStyle = PowerPacks.FillStyle.Percent20
            Case 3
                rctBackGround.FillStyle = PowerPacks.FillStyle.Percent30
            Case 4
                rctBackGround.FillStyle = PowerPacks.FillStyle.Percent40
            Case 5
                rctBackGround.FillStyle = PowerPacks.FillStyle.Percent50
            Case 6
                rctBackGround.FillStyle = PowerPacks.FillStyle.Percent60
                tmrTransition.Stop()
                lblText.Text = Nothing

                lblText.Visible = True


        End Select

        If shrSequenceTick <> 6 Then
            shrSequenceTick += 1
        Else
            tmrTextIn.Start()
            shrSequenceTick = 1
        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Close()
    End Sub

    Private Sub tmrTextIn_Tick(sender As Object, e As EventArgs) Handles tmrTextIn.Tick
        'Used for sequencing in the text
        If shrSequenceTick <= Len(strText(shrCutsceneCount, shrMissionNumber)) Then
            lblText.Text += Mid(strText(shrCutsceneCount, shrMissionNumber), shrSequenceTick, 1)
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
            tmrTextIn.Stop()
            btnNext.Enabled = True
        End If

        shrSequenceTick += 1

    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        Me.Close()
    End Sub
End Class