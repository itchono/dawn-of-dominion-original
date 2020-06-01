'A form displayed after the main gamemode screen to display stats


Public Class GameReview

    Dim shrSequencer As Short
    'Used for sequencing in stats

    Private Sub GameReview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If it's PVP or SP and the player won, play the standard music
        If blnPlayMode = False Or (blnPlayMode = True And blnWinner = False) Then
            MusicChange(8)
        Else
            'Otherwise, fail music
            MusicChange(9)
        End If

        If blnPlayMode = True Then
            lbl1PTitle.Text = My.Settings.SaveUser
            Dim strName As String = ""
            'Used for the AI opponent
            Select Case shrMissionNumber
                Case 0
                    strName = "The Dark Order"
                Case 1
                    strName = "The Last Ember"
                Case 2
                    strName = "The Prisma"
                Case 3
                    strName = "The Elementan Pope - Banos Hjarne"
                Case 4
                    strName = "The Equanos"
                Case 5
                    strName = "The Elementan"
                Case 6
                    strName = "The Infernus"
                Case 7
                    strName = "The Prisma"
                Case 8
                    strName = "The Umbra"
                Case 9
                    strName = "The Union"
                Case 10
                    strName = "Bob the Advanced Robot"
            End Select

            lbl2PTitle.Text = strName
            'Set the name of the other person (SP)
        Else
            'If it's 1 on 1, plug in usernames
            lbl1PTitle.Text = strUserNames(0)
            lbl2PTitle.Text = strUserNames(1)
        End If

        tmrSequencer.Start()
    End Sub

    Private Sub btnReturnMenu_Click(sender As Object, e As EventArgs) Handles btnReturnMenu.Click
        'Verify before closing
        If MsgBox("Are you sure you want to return to the menu?", MsgBoxStyle.YesNo, "Return to Menu?") = MsgBoxResult.Yes Then
            MainMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub tmrSequencer_Tick(sender As Object, e As EventArgs) Handles tmrSequencer.Tick
        'Every tick, a new line is added

        Dim strStatName As String = ""
        'Name of stat to be added

        Dim shrStatNum(1) As Short
        'Numerical data for a stat (ex. Money)

        'Cycle to stats
        'For some, add to TOTAL STATS
        'Then, purge value
        Select Case shrSequencer
            Case 0
                strStatName = "Money Spent: $"
                shrStatNum = shrMoneySpent
                My.Settings.StatMoneySpent += shrMoneySpent(0) + shrMoneySpent(1)
                shrMoneySpent = {0, 0}

            Case 1
                strStatName = "Money Earned: $"
                shrStatNum = shrMoneyEarned
                shrMoneyEarned = {0, 0}

            Case 2
                strStatName = "Money Refunded: $"
                shrStatNum = shrMoneyRefunded
                shrMoneyRefunded = {0, 0}

            Case 3
                strStatName = "Damage Dealt: "
                shrStatNum = shrDDealt
                My.Settings.StatDDealt += shrDDealt(0) + shrDDealt(1)
                shrDDealt = {0, 0}

            Case 4
                strStatName = "Damage Taken: "
                shrStatNum = shrDTaken
                My.Settings.StatDTaken += shrDTaken(0) + shrDTaken(1)
                'Delay purge for achievement check
            Case 5
                strStatName = "Units Placed:"
                shrStatNum = shrUnitsPlaced
                My.Settings.StatUnitsPlaced += shrUnitsPlaced(0) + shrUnitsPlaced(1)
                shrUnitsPlaced = {0, 0}

            Case 6
                strStatName = "Enemy Units Destroyed: "
                shrStatNum = shrUnitsDestroyed
                My.Settings.StatUnitsDestroyed += shrUnitsDestroyed(0) + shrUnitsDestroyed(1)
                shrUnitsDestroyed = {0, 0}

            Case 7
                If blnWinner = False Then
                    lbl1PInfo.Text &= "WINNER!"
                    lbl2PInfo.Text &= "Loser"
                Else
                    lbl1PInfo.Text &= "Loser"
                    lbl2PInfo.Text &= "WINNER!"
                End If

                tmrSequencer.Stop()

                'CHECK FOR ACHIEVEMENT - Not Even a Scratch
                If ((blnWinner = False And shrDTaken(0) = 0) Or (blnWinner = True And shrDTaken(1) = 0)) And GameMode.GetStat(My.Settings.Achievements, "Not Even a Scratch") Like "False" Then
                    GameMode.SetStat(My.Settings.Achievements, "Not Even a Scratch", "True")
                    MsgBox("Not Even a Scratch - Win a game without having taken any damage (resistance from armour counts).", , "Achievement Get!")
                End If

                'Delayed purge
                shrDTaken = {0, 0}

                'CHECK FOR ACHIEVEMENT  - Grand Tour
                If blnPlayMode = False Then
                    GameMode.SetStat(My.Settings.MapsPlayed, "M" & shrPlayerChoice(1, 0), "True")
                    GameMode.SetStat(My.Settings.MapsPlayed, "M" & shrPlayerChoice(1, 1), "True")
                End If
                'Only factor in for 2 player

                'Update maps played

                Dim blnComplete As Boolean = True
                'Scan through all maps to see if it's been played, assuming that it starts as true

                For Check = 0 To 6
                    If GameMode.GetStat(My.Settings.MapsPlayed, "M" & Check) Like False Then
                        blnComplete = False
                        'Invalidate
                    End If
                Next

                If GameMode.GetStat(My.Settings.Achievements, "Grand Tour") Like "False" And blnComplete = True Then
                    GameMode.SetStat(My.Settings.Achievements, "Grand Tour", "True")
                    MsgBox("Grand Tour - Play at least once on every map in the game in 2 player mode.", , "Achievement Get!")
                End If

                btnDone.Enabled = True
                'Enabled proceed
        End Select

        lblStatName.Text &= strStatName & vbCrLf

        If shrSequencer <> 7 Then
            lbl1PInfo.Text &= shrStatNum(0) & vbCrLf
            lbl2PInfo.Text &= shrStatNum(1) & vbCrLf
        End If
        'Display the info to the form

        shrSequencer += 1
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        MainMenu.Show()
        Me.Close()
    End Sub
End Class