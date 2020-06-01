'Displays stats and achievements accomplished by the player


Public Class StatsAchievements

    Dim lblAchievementList(6) As Label
    'Used for displaying achievements

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub StatsAchievements_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'STATS
        lblStats.Text = "Stats:"

        'Load stats
        For StatCount = 0 To 5

            lblStats.Text &= vbCrLf & vbCrLf
            'Double line spacing

            Select Case StatCount
                Case 0
                    lblStats.Text &= "Total Damage Dealt: " & My.Settings.StatDDealt
                Case 1
                    lblStats.Text &= "Total Damage Taken: " & My.Settings.StatDTaken
                Case 2
                    lblStats.Text &= "Total Money Spent: $" & My.Settings.StatMoneySpent
                Case 3
                    lblStats.Text &= "Total Units Placed: " & My.Settings.StatUnitsPlaced
                Case 4
                    lblStats.Text &= "Total Units Destroyed: " & My.Settings.StatUnitsDestroyed
                Case 5
                    Dim shrMapCount As Short
                    For Check = 0 To 6
                        If GameMode.GetStat(My.Settings.MapsPlayed, "M" & Check) Like "True" Then
                            shrMapCount += 1
                        End If
                    Next

                    lblStats.Text &= "Maps Played in 2 Player: " & shrMapCount
            End Select
        Next

        'END OF STATS


        'ACHIEVEMENTS
        Dim strTempAchievements As String = My.Settings.Achievements

        Dim strAchievementName As String


        'Load Achievements
        For AchievementCount = 0 To 6

            'Create label instances
            lblAchievementList(AchievementCount) = New Label

            'Appearance Stuff
            lblAchievementList(AchievementCount).Font = New Font("Century Gothic", 12, FontStyle.Regular)
            lblAchievementList(AchievementCount).Location = New Point(15, 75 + 50 * AchievementCount)
            lblAchievementList(AchievementCount).AutoSize = True
            lblAchievementList(AchievementCount).BringToFront()

            strAchievementName = Mid(strTempAchievements, InStr(strTempAchievements, "/") + 1, (InStr(strTempAchievements, "|")) - (InStr(strTempAchievements, "/") + 1))
            'Load the name of the achievement

            'Load data
            lblAchievementList(AchievementCount).Text = strAchievementName & ": "

            If GameMode.GetStat(My.Settings.Achievements, strAchievementName) Like "True" Then
                'If achievement was earned
                lblAchievementList(AchievementCount).Text &= "EARNED!"
                lblAchievementList(AchievementCount).ForeColor = Color.Green
                lblAchievementList(AchievementCount).Text &= vbCrLf & vbTab

                Select Case AchievementCount
                    Case 0
                        'Ambassador
                        lblAchievementList(AchievementCount).Text &= "- Gain the influence of all 5 races by completing mission 9."
                    Case 1
                        'Hero
                        lblAchievementList(AchievementCount).Text &= "- Defeat the Dark Order by completing all 10 singleplayer missions!"
                    Case 2
                        'YOLO
                        lblAchievementList(AchievementCount).Text &= "- Win a game with only 1 unit left."
                    Case 3
                        'Not Even a Scratch
                        lblAchievementList(AchievementCount).Text &= "- Win a game without having taken any damage (resistance from armour counts)."
                    Case 4
                        'Grand Tour
                        lblAchievementList(AchievementCount).Text &= "- Play at least once on every map in the game in 2 player mode."
                    Case 5
                        'I am a h4ck3r
                        lblAchievementList(AchievementCount).Text &= "- Enable the developer cheats."
                    Case 6
                        'Advanced
                        lblAchievementList(AchievementCount).Text &= "- Win against the advanced AI."

                End Select

            Else
                'If achievement was not
                lblAchievementList(AchievementCount).Text &= "Locked"
                lblAchievementList(AchievementCount).ForeColor = Color.WhiteSmoke

            End If

            tpgAchievements.Controls.Add(lblAchievementList(AchievementCount))
            strTempAchievements = Mid(strTempAchievements, InStr(strTempAchievements, "|") + 1)
            'Cycle the string so that it is reset to the next cycle
        Next

        'END OF ACHIEVEMENTS
    End Sub
End Class