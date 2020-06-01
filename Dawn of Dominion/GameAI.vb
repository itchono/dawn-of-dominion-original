'DoD's own AI, used for playing against the user
'The advanced mode is actually not as bad as I thought - give it a try!


Module GameAI
    Public blnAIActive, blnPlaceValid As Boolean
    'Used for compatiblity

    'The most basic AI, does a random move
    Sub RndMove()
        blnAIActive = True

        ChooseAttacker()
        'Used for guessing a random unit on the ally side

        Dim shrGuessX, shrGuessY As Short
        Dim blnValid As Boolean

        Do
            shrGuessX = Int(7 * Rnd())
            shrGuessY = Int(7 * Rnd())
            'Guess random coordinates

            'Square must be valid - cannot be missed square or destroyed unit
            blnValid = Not Mid(GameMode.btnUnitGrid(1, shrGuessX, shrGuessY).AccessibleDescription, 1, 1) Like "[D, M]"
            'If a valid square is found, exit the loop

        Loop While blnValid = False

        GameMode.btnUnitGrid(1, shrGuessX, shrGuessY).PerformClick()
        'Select the the enemy square

        GameMode.btnFire.PerformClick()
        'Fire!

        GameMode.btnNextTurn.PerformClick()
        'Next turn

        blnAIActive = False

        DebugConsole.lbxOutput.Items.Add("STATUS: Successful execution of AI turn, $" & GameMode.shrMoney(1) & " remaining on AI side.")
        'Debug Entry
    End Sub

    'This is a more advanced AI, targeting any heat signatures
    Sub IntelliMove()
        blnAIActive = True

        ChooseAttacker()
        'Used for guessing a random unit on the ally side

        Dim shrGuessX, shrGuessY As Short
        Dim blnValid As Boolean

        'Check all enemy squares for visibility + unit or a heat signature
        For CheckX = 0 To 6
            For CheckY = 0 To 6
                If (GameMode.btnUnitGrid(1, CheckX, CheckY).Text Like "!") Or
                    (GameMode.GetStat(GameMode.btnUnitGrid(1, CheckX, CheckY).AccessibleDescription, "Visible") Like "True" And
                    Mid(GameMode.btnUnitGrid(0, CheckX, CheckY).AccessibleDescription, 1, 1) Like "[U, A]") Then
                    shrGuessX = CheckX
                    shrGuessY = CheckY
                    blnValid = True

                End If
            Next
        Next
        'Check if a unit was found

        If blnValid = True Then
            GameMode.btnUnitGrid(1, shrGuessX, shrGuessY).PerformClick()
            'Select that one
        Else
            'If no enemy unit is found, do a random move
            Do
                shrGuessX = Int(7 * Rnd())
                shrGuessY = Int(7 * Rnd())
                'Guess random coordinates

                'Square must be valid - cannot be missed square or destroyed unit
                blnValid = Not Mid(GameMode.btnUnitGrid(1, shrGuessX, shrGuessY).AccessibleDescription, 1, 1) Like "[D, M]"
                'If a valid square is found, exit the loop

            Loop While blnValid = False

            GameMode.btnUnitGrid(1, shrGuessX, shrGuessY).PerformClick()
            'Select the the enemy square
        End If

        GameMode.btnFire.PerformClick()
        'Fire!

        GameMode.btnNextTurn.PerformClick()
        'Next turn

        blnAIActive = False

        DebugConsole.lbxOutput.Items.Add("STATUS: Successful execution of AI turn, $" & GameMode.shrMoney(1) & " remaining on AI side.")
        'Debug Entry

    End Sub


    'PERMENANTLY DECOMISSIONED - STAY AWAY
    Sub RndBuild()
        blnAIActive = True
        'Set AI lock

        Dim blnComplete As Boolean

        Dim shrGuessX, shrGuessY As Short

        'Used for guessing a random unit on the ally side
        GameMode.shrPlaceID = Int(11 * Rnd())

        Do
            For Tries = 0 To 4
                shrGuessX = Int(7 * Rnd())
                shrGuessY = Int(7 * Rnd())

                If Not Mid(GameMode.btnUnitGrid(0, shrGuessX, shrGuessX).AccessibleDescription, 1, 1) Like "[U, A]" Then
                    GameMode.btnUnitGrid(0, shrGuessX, shrGuessY).PerformClick()
                    'Select a random ally grid
                End If
            Next

            GameMode.shrPlaceID = Int(11 * Rnd())
            blnComplete = GameMode.shrMoney(1) <= Shop.shrCosts(0, GameMode.shrPlaceID)

        Loop Until blnComplete = True

        GameMode.btnPlace.PerformClick()

        GameMode.btnNextTurn.PerformClick()
        'Next turn

        blnAIActive = False

        DebugConsole.lbxOutput.Items.Add("STATUS: Successful execution of AI buying, $" & GameMode.shrMoney(1) & " remaining on AI side.")
        'Debug Entry

    End Sub


    Sub StoryBuild()
        'Build a side based on the given mission

        blnAIActive = True

        GameMode.UpdateMoney(10000)
        'Make money not a problem

        'Set AI stats
        Select Case shrMissionNumber
            Case 0
                'Mission 1: The Shadow Menace
                GameMode.shrPlaceID = 4
                'Umbra Lurker ID, Then place
                GameMode.btnUnitGrid(0, 0, 3).PerformClick()

                GameMode.shrPlaceID = 5
                'Void Swarm ID, Then place
                GameMode.btnUnitGrid(0, 5, 1).PerformClick()

                'SPECIAL: Make HS 100% for an easy first level
                For GridX = 0 To 6
                    For GridY = 0 To 6
                        If Mid(GameMode.btnUnitGrid(0, GridX, GridY).AccessibleDescription, 1, 1) Like "[U, A]" Then
                            GameMode.SetStat(GameMode.btnUnitGrid(0, GridX, GridY).AccessibleDescription, "HS", 100)
                        End If
                    Next
                Next
            Case 1
                'Mission 2: Flint and Steel
                GameMode.shrPlaceID = 2
                GameMode.btnUnitGrid(0, 0, 0).PerformClick()
                GameMode.btnUnitGrid(0, 6, 3).PerformClick()
                GameMode.btnUnitGrid(0, 0, 6).PerformClick()
                'Infernus Tank Placement

            Case 2
                'Mission 3: Return of the prisma
                GameMode.shrPlaceID = 13
                GameMode.btnUnitGrid(0, 2, 2).PerformClick()
                GameMode.btnUnitGrid(0, 4, 4).PerformClick()
                'Prisma Jet Placement

                GameMode.shrPlaceID = 12
                GameMode.btnUnitGrid(0, 3, 3).PerformClick()
                'Prisma Heli Placement
            Case 3
                'Mission 4: A New Pope
                GameMode.shrPlaceID = 11
                GameMode.btnUnitGrid(0, 0, 0).PerformClick()
                'Elementan Sub Placement

                GameMode.shrPlaceID = 1
                GameMode.btnUnitGrid(0, 6, 0).PerformClick()
                GameMode.btnUnitGrid(0, 6, 3).PerformClick()
                GameMode.btnUnitGrid(0, 6, 6).PerformClick()
                'Elementan Tank Placement
            Case 4
                'Mission 5: The Race for Equity

                GameMode.shrPlaceID = 0
                GameMode.btnUnitGrid(0, 5, 3).PerformClick()
                'Equanos Tank

                GameMode.shrPlaceID = 8
                GameMode.btnUnitGrid(0, 1, 0).PerformClick()
                GameMode.btnUnitGrid(0, 2, 4).PerformClick()
                'Equanos Ship

                GameMode.shrPlaceID = 7
                GameMode.btnUnitGrid(0, 4, 5).PerformClick()
                'Equanos Howitzer

            Case 5
                'Mission 6: The Grass is Always Greener

                GameMode.shrPlaceID = 9
                GameMode.btnUnitGrid(0, 4, 4).PerformClick()
                'Ship Placement

                GameMode.shrPlaceID = 15
                GameMode.btnUnitGrid(0, 5, 0).PerformClick()
                'Airplace Placement

            Case 6
                'Mission 7: Trial by Fire

                GameMode.shrPlaceID = 10
                GameMode.btnUnitGrid(0, 1, 2).PerformClick()
                'Infernus ship

                GameMode.shrPlaceID = 14
                GameMode.btnUnitGrid(0, 3, 3).PerformClick()
                'Infernus jet

            Case 7
                'Mission 8: The Light at the End
                GameMode.shrPlaceID = 3
                GameMode.btnUnitGrid(0, 1, 0).PerformClick()
                GameMode.btnUnitGrid(0, 4, 3).PerformClick()
                'Prisma tanks

                GameMode.shrPlaceID = 12
                GameMode.btnUnitGrid(0, 2, 4).PerformClick()
                'Prisma Heli

                GameMode.shrPlaceID = 13
                GameMode.btnUnitGrid(0, 0, 6).PerformClick()
                'Prisma Jet

            Case 8
                'Mission 9: A Dark Twist
                GameMode.shrPlaceID = 4
                GameMode.btnUnitGrid(0, 5, 1).PerformClick()
                GameMode.btnUnitGrid(0, 1, 5).PerformClick()
                'Umbra tanks

                GameMode.shrPlaceID = 5
                GameMode.btnUnitGrid(0, 0, 1).PerformClick()
                'Void swarm

            Case 9
                'Mission 10: Confrontation
                GameMode.shrPlaceID = 4
                GameMode.btnUnitGrid(0, 5, 0).PerformClick()
                GameMode.btnUnitGrid(0, 6, 2).PerformClick()
                GameMode.btnUnitGrid(0, 6, 4).PerformClick()
                GameMode.btnUnitGrid(0, 5, 6).PerformClick()
                'Umbra tanks

                GameMode.shrPlaceID = 14
                GameMode.btnUnitGrid(0, 2, 2).PerformClick()
                GameMode.btnUnitGrid(0, 2, 4).PerformClick()
                GameMode.btnUnitGrid(0, 4, 2).PerformClick()
                GameMode.btnUnitGrid(0, 4, 4).PerformClick()
                'Infernus jets
        End Select

        GameMode.btnPlace.PerformClick()

        GameMode.btnNextTurn.PerformClick()
        'Next turn

        blnAIActive = False

        DebugConsole.lbxOutput.Items.Add("STATUS: Successful execution of AI buying, $" & GameMode.shrMoney(1) & " remaining on AI side." & GameMode.UnitCount(0) & " units placed.")
        'Debug Entry
    End Sub

    Sub ChooseAttacker()
        'Used for guessing a random unit on the ally side

        Dim shrGuessX, shrGuessY As Short
        Dim blnUnitFound As Boolean

        Do
            shrGuessX = Int(7 * Rnd())
            shrGuessY = Int(7 * Rnd())
            'Guess random coordinates UNTIL a unit on the ally side is found

            blnUnitFound = Mid(GameMode.btnUnitGrid(0, shrGuessX, shrGuessY).AccessibleDescription, 1, 1) Like "[U, A]"
            'If a unit if found, exit the loop

        Loop While blnUnitFound = False

        GameMode.btnUnitGrid(0, shrGuessX, shrGuessY).PerformClick()
        'Select the unit for firing
    End Sub


End Module
