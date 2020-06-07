'A slightly complicated form used to transition between turns

Public Class Blackout

    Dim blnFadeMode As Boolean
    'False = Fadein
    'True = Fadeout

    Private Sub Blackout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Form BG setup
        If blnPlayMode = False Then
            lblDispPrompt.Text = "It is now the other player's turn. Please give control of the device to them."
        Else
            lblDispPrompt.Text = "The AI makes its move."
        End If

        'Start fadein
        blnFadeMode = False
        tmrFadeInOut.Start()
    End Sub

    Private Sub tmrFadeInOut_Tick(sender As Object, e As EventArgs) Handles tmrFadeInOut.Tick
        If Me.Opacity < 1 And blnFadeMode = False Then
            'Opacity < 100%, fading in, --> continue
            Me.Opacity += My.Settings.FadeSpeed
        ElseIf blnFadeMode = False Then
            'Opacity is 100%, fading in, --> stop
            tmrFadeInOut.Stop()
            GameMode.NextTurnSetup()
            'Set up next turn in BG
            If GameMode.shrTurns >= 3 And GameMode.shrTurns Mod 2 = 0 And blnPlayMode = True Then
                'Use either of the AI modes depending on the mission
                If shrMissionNumber <= 4 Then
                    GameAI.RndMove()
                Else
                    GameAI.IntelliMove()
                End If

            ElseIf GameMode.shrTurns = 2 And blnPlayMode = True Then
                If shrMissionNumber >= 0 And shrMissionNumber <= 9 Then
                    'If it's a valid mission
                    GameAI.StoryBuild()
                Else
                    GameAI.RndBuild()
                    'IF the player chose to play special AI mode, do the experiemental AI build
                End If
            End If

            btnNext.Enabled = True

        ElseIf Me.Opacity > 0 And blnFadeMode = True Then
            'Opacity > 0%, fading out, --> continue
            Me.Opacity -= My.Settings.FadeSpeed
        Else
            'Opacity is 0%, fading out, ---> stop
            tmrFadeInOut.Stop()

            Me.Close()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        blnFadeMode = True
        tmrFadeInOut.Start()

        'Player loses mission
        If GameMode.UnitCount(1 - GameMode.shrTurns Mod 2) <= 0 Then
            MsgBox("You lose!", , "Oh no!")
            Me.Close()
            blnWinner = True
            GameReview.Show()
            GameMode.Close()
        End If

    End Sub
End Class