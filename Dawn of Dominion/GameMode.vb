'Game Mode
'The most complicated form in the program, where all of the action happens
'Only it and the main menu have a fadein, because they are important

Public Class GameMode

    'Each square behaves as its own unit, so even multi-grid units are really smaller untis
    'Thus, each "part" of a bigger unit can function like its own piece

    'CODE FOR ACCESSIBLEDESCRIPTIONS AND GRID DATA:
    'Blank - Nothing - not placed or ever touched
    'Beginning with U = Unit is there
    'Beginning with A = Auxiliary of a unit (i.e. a branch of it)
    'ex. A 4 by 2 unit would have one "root" part (U) and 7 other auxiliaries (A)

    'Beginning with D = Destroyed Unit or Destoyed Part of Unit
    'Beginning with M = Missed shot from other side

    'Format for Grid Data:
    'Identifier|UnitID|<Stats>|Inventory Data

    'PRIVATE VARIABLES

    Dim blnTurnControl, blnFire As Boolean
    'Directly allows control of either player 1 (false) or player 2 (true)
    'Whether or not a player has expended their shot for their turn

    Dim clrPreviousColor As Color
    'Used for selection

    Dim pntGuessShot, pntSelectUnit As Point
    'Used for the player's shot guess
    'GuessShot: The player's guess on target
    'SelectUnit: The firing unit

    Dim shrGameUnitID As Short
    'Used when generating a unit to differentiate it

    Dim sglIncomeMultiplier(1) As Single
    'Income multiplier


    'PUBLIC VARIABLES

    Public btnUnitGrid(1, 6, 6) As Button
    '2 2D grids used for holding the players' units
    'The life blood of the game


    Public strGridData(1, 6, 6) As String
    'Used for storing the data in the grid, that would usually be in the accessibledescription


    Public strUnitData() As String = New String(15) {"NameEquanos Tank/Name|DescThe Equanos are focused on maintaining a balance in everything - this tank is no exception./Desc|HP100/HP|MaxH100/MaxH|AD50/AD|DR15/DR|HS30/HS|RType0/RType|TTypeG/TType|",
                                    "NameElementan Ground Strider/Name|DescThe Elementan have a profound connection with defense and shield strength./Desc|HP120/HP|MaxH120/MaxH|AD30/AD|DR20/DR|HS20/HS|RType1/RType|TTypeG/TType|",
                                    "NameInfernus Scorcher/Name|DescThe Infernus put aggression as a priority, but are no slouch on defenses either./Desc|HP70/HP|MaxH70/MaxH|AD70/AD|DR10/DR|HS30/HS|RType2/RType|TTypeG/TType|",
                                    "NamePrisma Land Striker/Name|DescPrisma design maximizes attack damage while weakening almost every other aspect./Desc|HP60/HP|MaxH60/MaxH|AD85/AD|DR0/DR|HS40/HS|RType3/RType|TTypeG/TType|",
                                    "NameUmbra Lurker/Name|DescThis tank has been wrapped in shadows and is apt at evading damage. /Desc|HP30/HP|MaxH30/MaxH|AD50/AD|DR20/DR|HS15/HS|RType4/RType|TTypeV/TType|",
                                    "NameVoid Swarm/Name|DescA confusing artifact of the void. Very easily dissipated, but covers a big area./Desc|HP10/HP|MaxH10/MaxH|AD10/AD|DR20/DR|HS20/HS|RType4/RType|TTypeV/TType|SizeHori1/HoriVert3/Vert/Size",
                                    "NamePrisma Missile Battery/Name|DescA fragile, but hard hitting group of guided missile launchers./Desc|HP30/HP|MaxH30/MaxH|AD60/AD|DR0/DR|HS60/HS|RType3/RType|TTypeG/TType|SizeHori1/HoriVert1/Vert/Size",
                                    "NameEquanos Howitzer/Name|DescA well armoured, but less powerful battery of artillery./Desc|HP50/HP|MaxH50/MaxH|AD40/AD|DR10/DR|HS45/HS|RType0/RType|TTypeG/TType|SizeHori1/HoriVert1/Vert/Size",
                                    "NameEquanos Battleship/Name|DescThis Equanos vessel has excellent firepower and armour./Desc|HP50/HP|MaxH50/MaxH|AD50/AD|DR20/DR|HS20/HS|RType0/RType|TTypeW/TType|SizeVert2/Vert/Size",
                                    "NameElementan Warden/Name|DescThis ship is equipped with powerful elemental shields only the strongest of units can destroy./Desc|HP100/HP|MaxH100/MaxH|AD40/AD|DR35/DR|HS15/HS|RType1/RType|TTypeW/TType|SizeVert2/Vert/Size",
                                    "NameInfernus Forger/Name|DescThe infernus flagship is known for being able to level small cities in a single barrage./Desc|HP40/HP|MaxH40/MaxH|AD70/AD|DR20/DR|HS25/HS|RType3/RType|TTypeW/TType|SizeVert3/Vert/Size",
                                    "NameUndergrowth Submarine/Name|DescThis submarine is very stealthy and able to take at least a couple of hits./Desc|HP120/HP|MaxH120/MaxH|AD30/AD|DR15/DR|HS15/HS|RType1/RType|TTypeW/TType|SizeHori1/Hori/Size",
                                    "NameLightbringer Attack Heli/Name|DescLittle more than a flying gun, the Lightbringer redefines flying by the seat of your pants./Desc|HP20/HP|MaxH20/MaxH|AD100/AD|DR0/DR|HS75/HS|RType3/RType|TTypeA/TType",
                                    "NamePrisma Zoomer/Name|DescA bit more conservative, the zoomer trades some firepower for a sturdier frame ./Desc|HP40/HP|MaxH40/MaxH|AD60/AD|DR0/DR|HS40/HS|RType3/RType|TTypeA/TType",
                                    "NameIgnitor/Name|DescA fearsome jet that can outshoot all but the best of fighters./Desc|HP20/HP|MaxH20/MaxH|AD60/AD|DR10/DR|HS30/HS|RType2/RType|TTypeA/TType",
                                    "NameCanopy Superfortress/Name|DescThe pinnacle of Elementan technology - a large flying fortress./Desc|HP80/HP|MaxH80/MaxH|AD30/AD|DR20/DR|HS15/HS|RType1/RType|TTypeA/TType|SizeVert2/VertHori1/Hori/Size"}
    'Used for storing the actual infomration of the units (like the description and whatnot), that remains the same always


    Public strMapData(,) = New String(1, 6) {{"G21|W7|G21", "G7|W14|A7|G21", "V14|W7|G7|A7|V14", "A2|W3|A2|G1|A7|G1|A7|G1|A7|G1|A3|A2|W3|A2|G7", "W2|V4|W3|V4|W1|G14|W7|A10|G4", "G3|A1|G6|A1|G5|A3|G2|W2|A3|W4|A3|W2|V3|A1|V6|A1|V3", "G8|W5|G2|W1|G3|W1|G2|W1|G1|A1|G1|W1|G2|W1|G3|W1|G2|W5|G8"},
                                             {"River Crossing", "Equanos Homeland", "Shadow Plannum", "Prisma Munitions Factory", "Guardian's Rainforest", "Lightbridge", "Fire Fountain"}}
    'Information about every map

    Public shrPlaceID, shrTurns, shrMoney(1) As Short
    'Used for tracking which unit is being placed
    'Number of turns
    'Amount of money


    Private Sub GameMode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BG Setup

        KeyPreview = True
        'Enable keypreview for debug console

        Randomize()
        'Randomize for crits and other RNG

        'Used for storing the actual infomration of the units (like the description and whatnot), that remains the same always
        'FORMAT: Name|Description|Base HP|Base Attack Damage|Damage Reduction|Damage Type|Terrain Type|Unit Size


        'Set starting money
        shrMoney = New Short(1) {shrMoneyStart, shrMoneyStart}
        'Set number of turns to 1 for start
        shrTurns = 1
        'Set to no unit placed by default
        shrPlaceID = -1

        'Form Setup

        UpdateMoney(shrMoneyStart)
        'Display starting money

        Dim shrMapGen As Short = 1
        'Counter for map

        'Battleship Grid Generation for BOTH sides

        For GridIteration = 0 To 1
            'Repeats twice for both arrays

            Dim strMapString As String = strMapData(0, shrPlayerChoice(1, GridIteration))
            'Declare a temp string

            For GridX = 0 To 6
                'For Loop used to generate first index (horizontal), does not actually make buttons
                'Simply used to make an easy to manage coordinate system

                For GridY = 0 To 6
                    'For Loop used to make the actual buttons (vertical)

                    btnUnitGrid(GridIteration, GridX, GridY) = New Button
                    btnUnitGrid(GridIteration, GridX, GridY).Size = New Size(50, 50)

                    btnUnitGrid(GridIteration, GridX, GridY).AccessibleName = GridIteration
                    'Used internally by code to track which array each button is in

                    btnUnitGrid(GridIteration, GridX, GridY).Font = New Font("Century Gothic", 12, FontStyle.Bold)
                    btnUnitGrid(GridIteration, GridX, GridY).ForeColor = Color.WhiteSmoke
                    btnUnitGrid(GridIteration, GridX, GridY).BackgroundImageLayout = ImageLayout.Zoom
                    'Appearance

                    btnUnitGrid(GridIteration, GridX, GridY).Location = New Point(50 + 550 * GridIteration + 50 * GridX, 50 + 50 * GridY)
                    'Positioning - self contained within generation
                    '"150 * GridIteration" is used to make sure that the second array is displaced additionally
                    'with respect to the first
                    '"50 * GridX and GridY" is used for displacing each button within each grid

                    pnlGrids.Controls.Add(btnUnitGrid(GridIteration, GridX, GridY))
                    'Add to panel

                    AddHandler btnUnitGrid(GridIteration, GridX, GridY).Click, AddressOf GridClick
                    'Add event handler

                    AddHandler btnUnitGrid(GridIteration, GridX, GridY).MouseEnter, AddressOf GridTooltip
                    'Add another event handler

                    'Terrain Generation for Game

                    btnUnitGrid(GridIteration, GridX, GridY).AccessibleDescription += "|Terrain" & Mid(strMapString, 1, 1) & "/Terrain"
                    'Add the data for terrain

                    Select Case Mid(strMapString, 1, 1)
                        Case "G"
                            btnUnitGrid(GridIteration, GridX, GridY).BackColor = Color.FromArgb(85, 139, 47)
                        Case "W"
                            btnUnitGrid(GridIteration, GridX, GridY).BackColor = Color.FromArgb(25, 118, 210)
                        Case "A"
                            btnUnitGrid(GridIteration, GridX, GridY).BackColor = Color.WhiteSmoke
                        Case "V"
                            btnUnitGrid(GridIteration, GridX, GridY).BackColor = Color.DarkSlateGray
                    End Select
                    'Colour the grid based on the terrain type

                    'Reset string if needed
                    If shrMapGen >= Val(Mid(strMapString, 2, 2)) Then
                        strMapString = Mid(strMapString, InStr(strMapString, "|") + 1)
                        shrMapGen = 1
                    Else
                        shrMapGen += 1
                    End If
                Next
            Next
        Next

        'Update the race passive indicatior (or if there is none)
        If shrPlayerChoice(0, 0) <> -1 Then
            pbxRaceDisp.Image = MapSelect.iglRace.Images(shrPlayerChoice(0, 0))
        Else
            pbxRaceDisp.Image = Nothing
        End If

        'Show what turn it is
        lblControlIndicator.Text = "Player 1 (" & strUserNames(1 - shrTurns Mod 2) & ")'s Turn"

        If blnPlayMode = False Then
            '2 player specific stuff
            MusicChange(Int(5 * Rnd() + 3))
            'Change music to any
        Else
            '1 player specific stuff
            lblControlIndicator.Text = "Your Turn"

            'Change music based on mission
            Select Case shrMissionNumber
                Case 1 To 3
                    MusicChange(Int(2 * Rnd() + 3))
                Case 4 To 8
                    MusicChange(Int(2 * Rnd() + 5))
                Case 9
                    MusicChange(7)
            End Select

        End If

        sglIncomeMultiplier = New Single(1) {80, 80}
        'Set base income multiplier

        InfoMessage("Welcome to Dawn of Dominion!", Color.WhiteSmoke)

        'Timer Fade In
        tmrFadeIn.Start()
    End Sub

    Private Sub tmrFadeIn_Tick(sender As Object, e As EventArgs) Handles tmrFadeIn.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += My.Settings.FadeSpeed
        Else
            tmrFadeIn.Stop()

            If blnPlayMode = True And shrMissionNumber <= 9 Then
                'If the user is playing story mode, show the cutscene (does not include advanced AI)
                shrCutsceneCount = 0
                Cutscene.ShowDialog()
            End If
        End If
    End Sub

    Sub GridClick(sender As System.Object, e As System.EventArgs)

        'UNIT PLACEMENT FOR LS (Setup Phase)
        If shrTurns <= 2 And sender.AccessibleName = 0 And shrPlaceID <> -1 And btnNextTurn.Enabled = False Then
            'Checks that it is the LS grid being clicked

            'PLACING/TAKING BACK UNITS


            If Mid(sender.accessibledescription, 1, 1) Like "U" Then
                'Checks whether a unit is already on the square
                'If so, clicking again will refund the unit

                UpdateMoney(shrMoney(1 - shrTurns Mod 2) + Shop.shrCosts(0, Val(GetStat(sender.accessibledescription, "PID"))))
                'Refund the price

                shrMoneyRefunded(1 - shrTurns Mod 2) += Shop.shrCosts(0, Val(GetStat(sender.accessibledescription, "PID")))
                'Update Stat

                'Check for multi-unit
                Dim Hsize As Short = Val(GetStat(sender.accessibledescription, "Hori"))
                'Used because sender.acc.d is wiped, thus removing all the info on horizontal size. An intermediate variable is thus used.

                For VerticalSize = 0 To Val(GetStat(sender.accessibledescription, "Vert"))
                    For HorizontalSize = 0 To Hsize

                        'Check terrain type
                        Select Case GetStat(btnUnitGrid(0, FindCoordinate(sender, 0).X + HorizontalSize, FindCoordinate(sender, 0).Y + VerticalSize).AccessibleDescription, "Terrain")
                            Case "G"
                                btnUnitGrid(0, FindCoordinate(sender, 0).X + HorizontalSize, FindCoordinate(sender, 0).Y + VerticalSize).BackColor = Color.FromArgb(85, 139, 47)
                            Case "W"
                                btnUnitGrid(0, FindCoordinate(sender, 0).X + HorizontalSize, FindCoordinate(sender, 0).Y + VerticalSize).BackColor = Color.FromArgb(25, 118, 210)
                            Case "A"
                                btnUnitGrid(0, FindCoordinate(sender, 0).X + HorizontalSize, FindCoordinate(sender, 0).Y + VerticalSize).BackColor = Color.WhiteSmoke
                            Case "V"
                                btnUnitGrid(0, FindCoordinate(sender, 0).X + HorizontalSize, FindCoordinate(sender, 0).Y + VerticalSize).BackColor = Color.DarkSlateGray
                        End Select

                        btnUnitGrid(0, FindCoordinate(sender, 0).X + HorizontalSize, FindCoordinate(sender, 0).Y + VerticalSize).AccessibleDescription =
                            "|Terrain" & GetStat(btnUnitGrid(0, FindCoordinate(sender, 0).X + HorizontalSize, FindCoordinate(sender, 0).Y + VerticalSize).AccessibleDescription, "Terrain") & "/Terrain"

                        btnUnitGrid(0, FindCoordinate(sender, 0).X + HorizontalSize, FindCoordinate(sender, 0).Y + VerticalSize).Image = Nothing
                        'Clear image(s)
                    Next
                Next

            ElseIf Mid(sender.accessibledescription, 1, 1) Like "A" Then
                'If clicking on an auxiliary to refund,

                'Click on the original unit.
                For CheckX = 0 To 6
                    For CheckY = 0 To 6
                        If GetStat(btnUnitGrid(0, CheckX, CheckY).AccessibleDescription, "GID") = GetStat(sender.accessibledescription, "GID") And Mid(btnUnitGrid(0, CheckX, CheckY).AccessibleDescription, 1, 1) = "U" Then
                            btnUnitGrid(0, CheckX, CheckY).PerformClick()
                        End If
                    Next
                Next


            ElseIf shrMoney(1 - shrTurns Mod 2) >= Shop.shrCosts(0, shrPlaceID) Or blnAIActive = True Then
                'If not, make sure that the player can place down their selected unit in terms or turns and money
                'OR it is the AI

                'Check that parameters are valid

                'GATE 1: BOUNDS
                If Val(GetStat(GetStat(strUnitData(shrPlaceID), "Size"), "Vert")) + FindCoordinate(sender, 0).Y > 6 Or Val(GetStat(GetStat(strUnitData(shrPlaceID), "Size"), "Hori")) + FindCoordinate(sender, 0).X > 6 Then

                    If blnPlayMode = False Or (blnPlayMode = True And shrTurns Mod 2 = 1) Then
                        Shop.Focus()
                        MsgBox("Out of Bounds!", MsgBoxStyle.Exclamation, "Can't Place Unit!")
                    End If
                Else
                    Dim blnTerrainGood As Boolean = True
                    'Start by assuming terrain is fine

                    'CHECK TERRAIN VAILIDITY
                    For CheckX = 0 To Val(GetStat(GetStat(strUnitData(shrPlaceID), "Size"), "Hori"))
                        For CheckY = 0 To Val(GetStat(GetStat(strUnitData(shrPlaceID), "Size"), "Vert"))

                            'Check if terrain of each square matches 
                            blnTerrainGood = (GetStat(btnUnitGrid(0, FindCoordinate(sender, 0).X + CheckX, FindCoordinate(sender, 0).Y + CheckY).AccessibleDescription, "Terrain") Like GetStat(strUnitData(shrPlaceID), "TType"))

                            If blnTerrainGood = True Then
                                'Check for unit intersection on each square
                                blnTerrainGood = Not Mid(btnUnitGrid(0, FindCoordinate(sender, 0).X + CheckX, FindCoordinate(sender, 0).Y + CheckY).AccessibleDescription, 1, 1) Like "[U, A]"
                            End If

                        Next
                    Next

                    'GATE 2: TERRAIN TYPE
                    If blnTerrainGood = False Then
                        If blnPlayMode = False Or (blnPlayMode = True And shrTurns Mod 2 = 1) Then
                            'Msgbox must be on shop form
                            Shop.Focus()
                            MsgBox("Invalid terrain or intersection with another unit!", MsgBoxStyle.Exclamation, "Can't Place Unit!")
                        End If
                    Else
                        'IF ALL GOOD, GO ON
                        UpdateMoney(shrMoney(1 - shrTurns Mod 2) - Shop.shrCosts(0, shrPlaceID))
                        'Update costs

                        'UPDATE STAT
                        shrMoneySpent(1 - shrTurns Mod 2) += Shop.shrCosts(0, shrPlaceID)

                        'Check for multi-unit
                        For HorizontalSize = 0 To Val(GetStat(GetStat(strUnitData(shrPlaceID), "Size"), "Hori"))
                            For VerticalSize = 0 To Val(GetStat(GetStat(strUnitData(shrPlaceID), "Size"), "Vert"))

                                If VerticalSize = 0 And HorizontalSize = 0 Then
                                    'Root Part
                                    'NOTE: Adding | is purely cosmetic for the string
                                    sender.accessibledescription = "U" & sender.accessibledescription
                                    'Put the square data at the very front
                                    'Add description that unit is there

                                    'TBD - Unit specific stuff
                                Else
                                    'Aux Branch
                                    btnUnitGrid(0, FindCoordinate(sender, 0).X + HorizontalSize, FindCoordinate(sender, 0).Y + VerticalSize).AccessibleDescription = "A" & sender.accessibledescription
                                End If

                                btnUnitGrid(0, FindCoordinate(sender, 0).X + HorizontalSize, FindCoordinate(sender, 0).Y + VerticalSize).AccessibleDescription += "|GID" & shrGameUnitID & "/GID" &
                                    "|PID" & shrPlaceID & "/PID"

                                btnUnitGrid(0, FindCoordinate(sender, 0).X + HorizontalSize, FindCoordinate(sender, 0).Y + VerticalSize).AccessibleDescription += "|" & strUnitData(shrPlaceID)
                                'Add description to unit from array

                                btnUnitGrid(0, FindCoordinate(sender, 0).X + HorizontalSize, FindCoordinate(sender, 0).Y + VerticalSize).BackColor = Color.Green
                                btnUnitGrid(0, FindCoordinate(sender, 0).X + HorizontalSize, FindCoordinate(sender, 0).Y + VerticalSize).Image = iglUnitSprites.Images(shrPlaceID)

                            Next
                        Next

                        shrGameUnitID += 1
                        'Cycle to next unit generation ID

                    End If
                End If

            ElseIf shrMoney(1 - shrTurns Mod 2) < Shop.shrCosts(0, shrPlaceID) Then
                MsgBox("Insufficient money!", MsgBoxStyle.Exclamation, "Can't Place Unit")

            End If

            'Check that units exist in order for them to be done placing
            If UnitCount(0) > 0 Then
                btnPlace.Enabled = True
            Else
                btnPlace.Enabled = False
            End If

            'END ALLY UNITS MODIFICATION


            'TARGETING FOR RS
        ElseIf shrTurns >= 3 And sender.AccessibleName = 1 And Not Mid(sender.accessibledescription, 1, 1) Like "[D, M]" And blnFire = True Then
            'Checks that it is the RS grid being clicked AND that a valid square is being targeted AND that the player can fire

            If sender.backcolor = Color.Orange Then
                sender.backcolor = clrPreviousColor

            Else
                If btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).BackColor = Color.Orange Then

                    btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).BackColor = clrPreviousColor

                End If
                'Reset previous target colour if needed

                clrPreviousColor = sender.backcolor
                'Store previous colour

                sender.Backcolor = Color.Orange
                'Set target square to orange

                pntGuessShot = FindCoordinate(sender, 1)
                'Find coordinates on the Right Side
            End If

            'SELECTING ATTACKING UNIT
        ElseIf shrTurns >= 3 And sender.accessiblename = 0 And Mid(sender.accessibledescription, 1, 1) Like "[U, A]" Then
            'If it is the appropriate turn AND the player is clicking on a unit

            If sender.backcolor = Color.Yellow Then
                sender.backcolor = Color.FromArgb(255 - Int(255 * GetStat(sender.AccessibleDescription, "HP")) / GetStat(sender.AccessibleDescription, "MaxH"),
                                                   Int(128 * GetStat(sender.AccessibleDescription, "HP")) / GetStat(sender.AccessibleDescription, "MaxH"), 0)
                'Revert colour to what it was before

            Else
                If btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).BackColor = Color.Yellow Then
                    btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).BackColor = Color.FromArgb(255 - Int(255 * GetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "HP")) /
                                                    GetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "MaxH"),
                                                   Int(128 * GetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "HP")) /
                                                   GetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "MaxH"), 0)
                End If
                'Change back the previous square's colour if applicable

                sender.backcolor = Color.Yellow
                'Change the back colour

                pntSelectUnit = FindCoordinate(sender, 0)
                shrPlaceID = GetStat(sender.accessibledescription, "PID")
                'ID for identifying the unit to load
                Shop.pntSelectUnit = pntSelectUnit
                Shop.UnitLoad(sender.AccessibleDescription)
            End If

        End If

        UpdateFireStatus()
        'Check firing validty
    End Sub

    Private Sub btnPlace_Click(sender As Object, e As EventArgs) Handles btnPlace.Click
        If shrTurns <= 2 Then
            btnNextTurn.Enabled = True
        End If

        lblAllyActives.Text = "Active Units: " & UnitCount(0)
        'Update unit count for ally side

        'UPDATE STAT
        shrUnitsPlaced(1 - shrTurns Mod 2) = UnitCount(0)

        btnPlace.Enabled = False

        Shop.btnClose.PerformClick()
        btnShop.Enabled = False
    End Sub

    Private Sub GridTooltip(sender As Object, e As EventArgs)
        'The tooltip generated when mousing over any of the grids

        Dim strCompound As String = ""
        'Used to condense multiple information points together.

        'If nothing is there, and there is a Heat Sig, mark it
        If sender.text Like "!" Then
            strCompound += "Heat Signature!" & vbCrLf

            'Check for visibility otherwise
        ElseIf sender.AccessibleName Like 1 And My.Settings.DevMode = False And Not GetStat(sender.accessibledescription, "Visible") Like "True" Then
            'If they are on enemy side and not visible
            strCompound &= "???" & vbCrLf
            'You can't see anything on their side until you hit them
        End If

        'Unit checking
        Select Case Mid(sender.accessibledescription, 1, 1)
            Case "U", "A"
                If sender.accessiblename = 0 Or (sender.accessiblename = 1 And My.Settings.DevMode = True) Or GetStat(sender.accessibledescription, "Visible") Like "True" Then
                    strCompound &= GetStat(sender.accessibledescription, "Name") &
                                          vbCrLf & GetStat(sender.accessibledescription, "Desc") & vbCrLf &
                                          "HP: " & GetStat(sender.accessibledescription, "HP") & "/" &
                                    GetStat(sender.accessibledescription, "MaxH") & vbCrLf &
                                    "Attack Damage: " & GetStat(sender.accessibledescription, "AD") & vbCrLf &
                                    "Damage Reduction: " & GetStat(sender.accessibledescription, "DR") & vbCrLf &
                                    "Heat Signature: " & GetStat(sender.accessibledescription, "HS") & "%" & vbCrLf
                End If
            Case "M"
                strCompound &= "Missed shot." & vbCrLf
            Case "D"
                strCompound &= GetStat(sender.accessibledescription, "Name") &
                 vbCrLf & GetStat(sender.accessibledescription, "Desc") & vbCrLf & "[DESTROYED]" & vbCrLf
        End Select

        'Terrain checking
        Select Case GetStat(sender.accessibledescription, "Terrain")
            Case "G"
                strCompound &= "Ground"
            Case "W"
                strCompound &= "Water"
            Case "A"
                strCompound &= "Air"
            Case "V"
                strCompound &= "Void"
        End Select


        If sender.accessiblename = 0 Then
            'Ally side, indicate on tooltip
            ttpDescription.ToolTipTitle = "Ally Side"
        Else
            'Enemy side, indicate on tooltip
            ttpDescription.ToolTipTitle = "Enemy Side"
        End If
        ttpDescription.SetToolTip(sender, strCompound)
        'Send the tooltip


    End Sub

    Private Sub btnFire_Click(sender As Object, e As EventArgs) Handles btnFire.Click

        Dim shrHSignature As Short = GetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "HS")
        'Calculate a heat signature chance

        If Hitcheck(pntGuessShot) = True Then
            'MAJOR EVENT: ANOTHER UNIT IS HIT
            If blnAIActive = False Then
                MsgBox("Hit!", , "Result:")
            End If
            'MsgBox to be refined 

            'Change the square
            btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).ForeColor = Color.WhiteSmoke
            btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).Text = "HIT"

            'MAJOR: DAMAGE CALCULATIONS
            'VERY IMPORTANT PART

            'Please read up on the below Functions

            'The SetTotals sub is used to update stats of a unit before and after item transactions

            'The GetStat function is used to get one single stat from a formatted unit data string ex. AD of a unit

            'The SetStat sub is used to either add or overwrite a stat into a formatted unit data string ex. Replace AD = 60 with AD = 75


            Dim shrTotalDmg As Short

            'Calculate a total damage stat


            'Combine damage from other parts of the unit
            For CheckX = 0 To 6
                For CheckY = 0 To 6
                    If GetStat(btnUnitGrid(0, CheckX, CheckY).AccessibleDescription, "GID") =
                        GetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "GID") And
                        Not Mid(btnUnitGrid(0, CheckX, CheckY).AccessibleDescription, 1, 1) = "D" Then

                        'Checks for other parts with identical ID (same unit)
                        'Also make sure that they are not destroyed


                        shrTotalDmg += GetStat(btnUnitGrid(0, CheckX, CheckY).AccessibleDescription, "AD")
                    End If
                Next
            Next

            shrDDealt(1 - shrTurns Mod 2) += shrTotalDmg
            'Add to the player's total damage dealt stat

            shrTotalDmg -= GetStat(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, "DR")

            'Formula: Target's New HP = Target's HP - (Attacker's AD - Target's Damage Reduction)

            If shrTotalDmg < 0 Then
                shrTotalDmg = 0
                'If they were to do negative damage...



                'They can't do negative damage of course, so it becomes 0
            End If

            shrDTaken(shrTurns Mod 2) += shrTotalDmg
            'Add to the opponent's damage taken stat

            'Damage Calculation
            SetStat(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, "HP",
                     GetStat(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, "HP") - shrTotalDmg)
            'Update HP accordingly

            'INFERNUS PASSIVE - Flaming Ammunition - Application
            If shrPlayerChoice(0, 1 - shrTurns Mod 2) = 2 Then
                SetStat(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, "Burning", 3)
                'Set fire for 3 turns
            End If

            Dim shrKey As Short = GetStat(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, "PID")
            'Used for images

            'Check if the unit has been destroyed (HP <= 0)
            If GetStat(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, "HP") <= 0 Then
                If Mid(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, 1, 1) Like "U" Then
                    'If the command square was hit,
                    'make the entire unit go kaboom

                    'Add 1 to destroyed units
                    shrUnitsDestroyed(1 - shrTurns Mod 2) += 1

                    For GridX = 0 To 6
                        For GridY = 0 To 6
                            If GetStat(btnUnitGrid(1, GridX, GridY).AccessibleDescription, "GID") Like
                                GetStat(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, "GID") And
                                Mid(btnUnitGrid(1, GridX, GridY).AccessibleDescription, 1, 1) Like "[A, U]" Then

                                Mid(btnUnitGrid(1, GridX, GridY).AccessibleDescription, 1, 1) = "D"
                                btnUnitGrid(1, GridX, GridY).ForeColor = Color.White
                                btnUnitGrid(1, GridX, GridY).Text = "X"


                                btnUnitGrid(1, GridX, GridY).Image = iglUnitSprites.Images(shrKey)
                                SetStat(btnUnitGrid(1, GridX, GridY).AccessibleDescription, "Visible", "True")


                                btnUnitGrid(1, GridX, GridY).BackColor = Color.Red
                            End If
                        Next
                    Next
                ElseIf Mid(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, 1, 1) Like "A" Then
                    'If another part is hit and destroyed
                    Mid(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, 1, 1) = "D"
                    btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).ForeColor = Color.White
                    btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).Text = "X"

                    btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).BackColor = Color.Red
                    btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).Image = iglUnitSprites.Images(shrKey)
                    SetStat(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, "Visible", "True")
                End If

                InfoMessage("You dealt " & shrTotalDmg & " damage to the enemy " & GetStat(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, "Name") & " and destroyed it!", Color.WhiteSmoke)

                lblEnemyActives.Text = "Active Units: " & UnitCount(1)
                'Update enemy unit count



            Else
                'If not destroyed
                btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).BackColor =
                                    Color.FromArgb(255 - Int(255 * GetStat(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, "HP")) / GetStat(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, "MaxH"),
                                                   Int(128 * GetStat(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, "HP")) / GetStat(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, "MaxH"), 0)
                'Set backcolor based on HP

                InfoMessage("You dealt " & shrTotalDmg & " damage to the enemy " & GetStat(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, "Name") & ".", Color.WhiteSmoke)
            End If

            'DAMAGE CALCULATION END


            'VISIBILITY, MONEY
            btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).Image = iglUnitSprites.Images(shrKey)
            SetStat(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, "Visible", "True")
            'They can now see the unit


            'Reward the player by increasing income multiplier
            sglIncomeMultiplier(1 - shrTurns Mod 2) += shrTotalDmg / 50

            UpdateIncome()

            'HEAT SIGNATURE (x2 on hit):
            shrHSignature *= 2

        Else
            If blnAIActive = False Then
                MsgBox("Miss!", , "Result:")
                'MsgBox to be refined
            End If


            btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).BackgroundImage = My.Resources.Graphic_ShotMiss

            'Durability for code changes
            'In case 1st letter is existant, only replace it, otherwise, change the entire thing
            If Not Mid(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, 1, 1) Like "[D, U, A]" Then
                btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription = "M" & btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription
            Else
                Mid(btnUnitGrid(1, pntGuessShot.X, pntGuessShot.Y).AccessibleDescription, 1, 1) = "M"
            End If
        End If

        'UMBRA PASSIVE - Dark Affinity - Halve Heat Signature
        If shrPlayerChoice(0, 1 - shrTurns Mod 2) = 4 Then
            shrHSignature /= 2
        End If

        'HEAT SIGNATURE:
        If Int(100 * Rnd() + 1) <= shrHSignature Then
            'Percent chance
            SetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "HeatVis", "True")
            'Set it to be visible next turn
        End If

        btnNextTurn.Enabled = True

        blnFire = False
        UpdateFireStatus()
    End Sub

    Private Sub btnNextTurn_Click(sender As Object, e As EventArgs) Handles btnNextTurn.Click
        'Used for making the transition between 2 turns

        'Transfer grid data to array
        Dim shrPlayerSide As Short
        'Used for making data offset
        For Iteration = 0 To 1
            'Checks to see whose turn it is
            If blnTurnControl = True Then
                'If it is player 2's turn
                shrPlayerSide = 1 - Iteration
            Else
                'If it is player 1's turn
                shrPlayerSide = Iteration
            End If


            For GridX = 0 To 6
                For GridY = 0 To 6

                    strGridData(shrPlayerSide, GridX, GridY) = btnUnitGrid(Iteration, GridX, GridY).AccessibleDescription
                    'Copy the data of the unit into the array
                    'Will be cleaned in clearpositions sub
                Next
            Next
        Next

        'MAJOR: DETERMINE WIN OR LOSE
        If UnitCount(shrTurns Mod 2) <= 0 And shrTurns > 2 Then
            'OTHER PLAYER LOSE
            lblEnemyActives.Text = "Active Units: 0"

            If blnPlayMode = True And shrTurns Mod 2 = 1 Then
                MsgBox("Mission " & shrMissionNumber + 1 & " complete!", , "Good Job!")

                shrCutsceneCount = 1
                Cutscene.ShowDialog()

                If shrMissionNumber = My.Settings.SaveState And shrMissionNumber <= 8 Then
                    'If the player is doing the mission to be done (not last level)
                    My.Settings.SaveState += 1
                    'Add 1 to save progression
                    MsgBox("Next mission unlocked!", , "Good Job!")

                    If GetStat(My.Settings.Achievements, "Ambassador") Like "False" And shrMissionNumber = 8 Then
                        SetStat(My.Settings.Achievements, "Ambassador", "True")
                        'Update Achievement
                        MsgBox("Ambassador - Gain the influence of all 5 races by completing mission 9.", , "Achievement Get!")
                    End If

                ElseIf shrMissionNumber = My.Settings.SaveState And shrMissionNumber = 9 Then
                    My.Settings.SaveState += 1
                    'Add 1 to save progression
                    MsgBox("You have unlocked a secret!", , "Good Job!")

                    If GetStat(My.Settings.Achievements, "Hero") Like "False" Then
                        SetStat(My.Settings.Achievements, "Hero", "True")
                        'Update Achievement
                        MsgBox("Hero - Defeat the Dark Order by completing all 10 singleplayer missions!", , "Achievement Get!")
                    End If

                ElseIf shrMissionNumber = My.Settings.SaveState And shrMissionNumber = 10 Then
                    'If they beat advanced AI

                    If GetStat(My.Settings.Achievements, "Advanced") Like "False" Then
                        SetStat(My.Settings.Achievements, "Advanced", "True")
                        'Update Achievement

                        MsgBox("Advanced - Win against the advanced AI.", , "Achievement Get!")
                    End If
                End If
                blnWinner = False

            ElseIf blnPlayMode = False Then
                MsgBox("Player " & 2 - (shrTurns Mod 2) & " wins!", , "Good Game!")
                If shrTurns Mod 2 = 1 Then
                    blnWinner = False
                    'Player 1 wins!
                Else
                    blnWinner = True
                    'Player 2 wins!
                End If

            End If

            'CHECK FOR ACHIEVEMENT - YOLO
            If UnitCount(1 - shrTurns Mod 2) = 1 Then
                'If there was only 1 unit left

                If GetStat(My.Settings.Achievements, "YOLO") Like "False" Then
                    SetStat(My.Settings.Achievements, "YOLO", "True")
                    'Update Achievement

                    MsgBox("YOLO - Win a game with only 1 unit left.", , "Achievement Get!")
                End If
            End If

            GameReview.Show()
            Me.Close()
            'Show after game screen

        Else
            'Show transition screen and set up next turn

            If blnAIActive = False Then
                btnNextTurn.Enabled = False
                Blackout.ShowDialog()
            Else
                'If the AI turn is being played, ignore the transition screen and use a different process
                btnNextTurn.Enabled = False
                NextTurnSetup()
            End If

        End If

    End Sub


    'Subs and Functions

    Sub NextTurnSetup()
        'Set up the next turn

        'Update turn count
        shrTurns += 1
        blnTurnControl += 1

        ClearPositions()
        'Clear the grids
        'SUBS WITHIN SUBS

        Dim strMessage As String = ""
        'Used for broadcasting a summary of all actions.

        If shrPlayerChoice(0, 1 - shrTurns Mod 2) = 3 And shrTurns >= 3 Then
            'PRISMA PASSIVE - Illumination
            'RANDOMLY MARK A SQUARE ON THE ENEMY SIDE AS VISIBLE (even if it already is)

            SetStat(strGridData(shrTurns Mod 2, Int(7 * Rnd()), Int(7 * Rnd())), "Visible", "True")
            strMessage &= "Illumination has marked an enemy square as visible." & vbCrLf
        End If

        LoadPositions()
        'Load data

        'SUBS WITHIN SUBS

        If shrTurns >= 3 Then

            'Battle phase
            lblPhaseIndicate.Text = "Combat Phase"
            InfoMessage("You can now fire. Click on the LS Pane to select a unit to attack with, click on the RS pane to select your target, and click FIRE!", Color.Red)

            'RACE PASSIVES

            Select Case shrPlayerChoice(0, 1 - shrTurns Mod 2)
                Case 0
                    'EQUANOS PASSIVE - Communism Booster
                    strMessage &= "Communism Booster Earned $" & 0.15 * shrMoney(1 - shrTurns Mod 2) & "." & vbCrLf

                    shrMoneyEarned(1 - shrTurns Mod 2) += 0.15 * shrMoney(1 - shrTurns Mod 2)
                    'Update Stats

                    UpdateMoney(shrMoney(1 - shrTurns Mod 2) * 1.15)

                Case 1

                    'ELEMENTAN PASSIVE - Mending Sap
                    'If any ally units are under 80% HP, heal for 8% of their max HP per turn
                    Dim shrHealedUnits As Short

                    If shrPlayerChoice(0, 1 - shrTurns Mod 2) = 1 Then
                        For GridX = 0 To 6
                            For GridY = 0 To 6
                                If GetStat(btnUnitGrid(0, GridX, GridY).AccessibleDescription, "HP") <
                                    0.8 * GetStat(btnUnitGrid(0, GridX, GridY).AccessibleDescription, "MaxH") And
                                    Mid(btnUnitGrid(0, GridX, GridY).AccessibleDescription, 1, 1) Like "[U, A]" Then
                                    'Check that there is a unit, and that its HP is below 80% of max

                                    SetStat(btnUnitGrid(0, GridX, GridY).AccessibleDescription, "HP",
                                             Int(0.08 * GetStat(btnUnitGrid(0, GridX, GridY).AccessibleDescription, "MaxH") + GetStat(btnUnitGrid(0, GridX, GridY).AccessibleDescription, "HP")))
                                    shrHealedUnits += 1
                                End If
                            Next
                        Next

                        If shrHealedUnits = 1 Then
                            strMessage &= "Mending sap healed 1 unit." & vbCrLf
                        Else
                            strMessage &= "Mending sap healed " & shrHealedUnits & " units." & vbCrLf
                        End If

                    End If

            End Select

            'INFERNUS PASSIVE - Flaming Ammunition
            'Burn affected units for 10% of their maximum HP per turn for 3 turns

            Dim shrNumberUnits, shrDamage As Short
            'Used for indicating number of units affected and amount of damage dealt.

            For GridX = 0 To 6
                For GridY = 0 To 6
                    If GetStat(btnUnitGrid(0, GridX, GridY).AccessibleDescription, "Burning") Like "[1-3]" Then
                        'Check if it is burning

                        shrDamage = GetStat(btnUnitGrid(0, GridX, GridY).AccessibleDescription, "MaxH") * 0.1
                        'Add to total damage

                        shrNumberUnits += 1
                        'Add to number of units

                        SetStat(btnUnitGrid(0, GridX, GridY).AccessibleDescription, "HP", GetStat(btnUnitGrid(0, GridX, GridY).AccessibleDescription, "HP") - GetStat(btnUnitGrid(0, GridX, GridY).AccessibleDescription, "MaxH") * 0.1)
                        'Burn Damage

                        SetStat(btnUnitGrid(0, GridX, GridY).AccessibleDescription, "Burning", GetStat(btnUnitGrid(0, GridX, GridY).AccessibleDescription, "Burning") - 1)
                        'Reduce burn tick

                        'Make it so that burn ends at 1 HP
                        If GetStat(btnUnitGrid(0, GridX, GridY).AccessibleDescription, "HP") <= 0 Then
                            SetStat(btnUnitGrid(0, GridX, GridY).AccessibleDescription, "HP", 1)
                        End If

                    End If
                Next
            Next

            If shrNumberUnits = 1 Then
                strMessage &= "The enemy's flaming ammunition burned 1 unit for a total of " & shrDamage & " damage." & vbCrLf
                'Display a message
            ElseIf shrNumberUnits > 1 Then
                strMessage &= "The enemy's flaming ammunition burned " & shrNumberUnits & " units for a total of " & shrDamage & " damage." & vbCrLf
                'Display a message
            End If

            'END RACE PASSIVES


            'UPDATE MONEY
            UpdateMoney(shrMoney(1 - shrTurns Mod 2) + Int(UnitCount(0) * sglIncomeMultiplier(1 - shrTurns Mod 2)))
            'Incoming money - base income * number of units owned

            strMessage &= "$" & Int(UnitCount(0) * sglIncomeMultiplier(1 - shrTurns Mod 2)) & " earned." & vbCrLf

            shrMoneyEarned(1 - shrTurns Mod 2) += Int(UnitCount(0) * sglIncomeMultiplier(1 - shrTurns Mod 2))
            'Update Stats

            UpdateIncome()

            'END UPDATE MONEY


            blnFire = True
            'Unlock the player's firing ability

            clrPreviousColor = btnUnitGrid((1 - shrTurns Mod 2), pntGuessShot.X, pntGuessShot.Y).BackColor
            'Set colour for indication (explained a bit more in GridClick)

            InfoMessage(strMessage, Color.GreenYellow)

        Else
            shrPlaceID = -1
            'Reset unit placement ID

            UpdateMoney(shrMoney(1 - shrTurns Mod 2))
            'Display new money (starting) for the other player
        End If


        'General Setup

        btnShop.Enabled = True

        'Update unit counts
        lblAllyActives.Text = "Active Units: " & UnitCount(0)
        lblEnemyActives.Text = "Active Units: " & UnitCount(1)

        'Update turn number text
        lblTurnNumber.Text = "Turn " & Int(shrTurns / 2) + shrTurns Mod 2

        If blnPlayMode = False Then
            '2 player specific stuff
            lblControlIndicator.Text = "Player " & 2 - (shrTurns Mod 2) & " (" & strUserNames(1 - shrTurns Mod 2) & ")'s Turn"
        End If

        If shrPlayerChoice(0, 1 - shrTurns Mod 2) <> -1 Then
            pbxRaceDisp.Image = MapSelect.iglRace.Images(shrPlayerChoice(0, 1 - shrTurns Mod 2))
        Else
            pbxRaceDisp.Image = Nothing
        End If
        'SETUP COMPLETE - READY TO GO

    End Sub

    Sub LoadPositions()
        'Used to load in positions of each player
        'Historically one of the earliest subs to be programmed

        Dim shrPlayerSide As Short
        'Used for determining which player's units to load onto each grid
        For GridIteration = 0 To 1
            'Checks to see whose turn it is
            If blnTurnControl = True Then
                'If it is player 2's turn
                shrPlayerSide = 1 - GridIteration
            Else
                'If it is player 1's turn
                shrPlayerSide = GridIteration
            End If

            For GridX = 0 To 6

                For GridY = 0 To 6
                    'X and Y

                    'Load base terrain data, then load unit data

                    'TERRAIN
                    Select Case GetStat(strGridData(shrPlayerSide, GridX, GridY), "Terrain")
                        Case "G"
                            btnUnitGrid(GridIteration, GridX, GridY).BackColor = Color.FromArgb(85, 139, 47)
                        Case "W"
                            btnUnitGrid(GridIteration, GridX, GridY).BackColor = Color.FromArgb(25, 118, 210)
                        Case "A"
                            btnUnitGrid(GridIteration, GridX, GridY).BackColor = Color.WhiteSmoke
                        Case "V"
                            btnUnitGrid(GridIteration, GridX, GridY).BackColor = Color.DarkSlateGray
                    End Select

                    'Load in data for each grid
                    btnUnitGrid(GridIteration, GridX, GridY).AccessibleDescription = strGridData(shrPlayerSide, GridX, GridY)

                    'CHECK FOR HEAT SIG
                    If GetStat(btnUnitGrid(GridIteration, GridX, GridY).AccessibleDescription, "HeatVis") Like "True" Then
                        btnUnitGrid(GridIteration, GridX, GridY).ForeColor = Color.Red
                        btnUnitGrid(GridIteration, GridX, GridY).Text = "!"
                        btnUnitGrid(GridIteration, GridX, GridY).BackgroundImage = My.Resources.Graphic_HeatSig

                        SetStat(btnUnitGrid(GridIteration, GridX, GridY).AccessibleDescription, "HeatVis", "False")
                        'Clean the stat since it has been used
                    End If

                    'CHECK FOR ILLUMINATION
                    If GetStat(btnUnitGrid(GridIteration, GridX, GridY).AccessibleDescription, "Visible") Like "True" And GridIteration = 1 Then
                        'IF it's RS (enemy)
                        btnUnitGrid(1, GridX, GridY).BackgroundImage = My.Resources.Graphic_Illuminated
                    End If

                    'UNIT CHECKING

                    Select Case Mid(strGridData(shrPlayerSide, GridX, GridY), 1, 1)
                        Case "U", "A"
                            'Verfiy that the FIRST TERM of the ACCESSIBLEDESCRIPTION of the POSITION IN THE ARRAY is U
                            'Meaning that a unit is there

                            'Only print text of units on if they are on player side
                            If My.Settings.DevMode = True Or GridIteration = 0 Or (GetStat(btnUnitGrid(GridIteration, GridX, GridY).AccessibleDescription, "Visible") Like "True") Then
                                'If it is on ally side OR devcheat is on OR it is visible
                                Dim shrKey As Short = GetStat(btnUnitGrid(GridIteration, GridX, GridY).AccessibleDescription, "PID")

                                btnUnitGrid(GridIteration, GridX, GridY).Image = iglUnitSprites.Images(shrKey)
                                btnUnitGrid(GridIteration, GridX, GridY).BackColor =
                                    Color.FromArgb(255 - Int(255 * GetStat(btnUnitGrid(GridIteration, GridX, GridY).AccessibleDescription, "HP")) / GetStat(btnUnitGrid(GridIteration, GridX, GridY).AccessibleDescription, "MaxH"),
                                                   Int(128 * GetStat(btnUnitGrid(GridIteration, GridX, GridY).AccessibleDescription, "HP")) / GetStat(btnUnitGrid(GridIteration, GridX, GridY).AccessibleDescription, "MaxH"), 0)

                            End If


                        Case "D"
                            'If destroyed unit is there
                            '(Info is shown to both sides)
                            btnUnitGrid(GridIteration, GridX, GridY).Text = "X"

                            Dim shrKey As Short = GetStat(btnUnitGrid(GridIteration, GridX, GridY).AccessibleDescription, "PID")
                            'Go the the point where the first | is, go one after

                            btnUnitGrid(GridIteration, GridX, GridY).BackColor = Color.Red
                            btnUnitGrid(GridIteration, GridX, GridY).Image = iglUnitSprites.Images(shrKey)


                        Case "M"
                            'If it's a blank shot
                            'Load Missed Shots
                            btnUnitGrid(GridIteration, GridX, GridY).BackgroundImage = My.Resources.Graphic_ShotMiss

                    End Select

                Next
            Next
        Next
        'End of Grid Loop

    End Sub

    Sub ClearPositions()
        'Clear all grids

        'Used for cleaning everything after turn
        For GridIteration = 0 To 1
            For GridX = 0 To 6
                For GridY = 0 To 6
                    btnUnitGrid(GridIteration, GridX, GridY).BackColor = Color.DarkGray
                    btnUnitGrid(GridIteration, GridX, GridY).ForeColor = Color.WhiteSmoke
                    'Reset colours

                    btnUnitGrid(GridIteration, GridX, GridY).Text = ""
                    btnUnitGrid(GridIteration, GridX, GridY).AccessibleDescription = ""

                    'Check for presence of images - this was is less laggy
                    If Not btnUnitGrid(GridIteration, GridX, GridY).Image Is Nothing Then
                        btnUnitGrid(GridIteration, GridX, GridY).Image = Nothing
                    End If

                    If Not btnUnitGrid(GridIteration, GridX, GridY).BackgroundImage Is Nothing Then
                        btnUnitGrid(GridIteration, GridX, GridY).BackgroundImage = Nothing
                    End If
                Next
            Next
        Next
    End Sub

    Sub UpdateFireStatus()
        'Updates the activity of the fire button
        Dim blnLSValid, blnRSValid As Boolean
        '2 booleans for validating LS and RS grid respectively

        For CheckX = 0 To 6
            For CheckY = 0 To 6
                If btnUnitGrid(0, CheckX, CheckY).BackColor = Color.Yellow Then
                    blnLSValid = True
                    'Check if a square is selected (yellow)
                End If

                If btnUnitGrid(1, CheckX, CheckY).BackColor = Color.Orange Then
                    blnRSValid = True
                    'Check is a square is targeted (red)
                End If
            Next
        Next

        If blnLSValid = True And blnRSValid = True And blnFire = True Then
            'Make it check if all the squares are valid, AND that player is allowed to fire
            btnFire.Enabled = True
        Else
            btnFire.Enabled = False
        End If

    End Sub

    Sub UpdateMoney(ByVal Amount As Short)
        'Update the amount of money (and display it)

        shrMoney(1 - shrTurns Mod 2) = Amount
        lblMoney.Text = "Money: $" & Amount
        'Change the amount
    End Sub

    Function UnitCount(ByVal Side As Short) As Short
        'Counts the number of units on that side (and returns it)

        Dim shrUnits As Short
        'CHECK units on enemy side to determine win or loss

        For GridX = 0 To 6
            For GridY = 0 To 6
                If Mid(btnUnitGrid(Side, GridX, GridY).AccessibleDescription, 1, 1) Like "U" Then
                    'If unit exists, then add 1 to count
                    shrUnits += 1
                End If
            Next
        Next
        Return shrUnits
    End Function


    '***Stat Functions
    '(VERY IMPORTANT)

    'The SetTotals function is used to add up the total stats of a unit, with inventory and base stats

    'The GetStat function is used to get one single stat from a formatted unit data string ex. AD of a unit

    'The SetStat function is used to either add or overwrite a stat into a formatted unit data string ex. Replace AD = 60 with AD = 75

    Function GetStat(ByVal strInput As String, ByVal strStatType As String) As String

        'Return the stat that is wanted

        'Ex. if your string looked like
        'apple44/apple|banana11/banana|
        'and you put "apple" into the function,
        'you would get 44.

        If InStr(strInput, strStatType) = 0 Then
            DebugConsole.GetInfo("Gamemode getstat", strStatType & " not found in " & strInput & "(OK)")
            Return Nothing
        ElseIf Mid(strInput, InStr(strInput, strStatType) + Len(strStatType), InStr(strInput, "/" & strStatType) - (InStr(strInput, strStatType) + Len(strStatType))) Like Nothing Then
            DebugConsole.GetInfo("Gamemode getstat", strStatType & " not found in " & strInput & "(OK)")
            Return Nothing
        Else
            Return Mid(strInput, InStr(strInput, strStatType) + Len(strStatType), InStr(strInput, "/" & strStatType) - (InStr(strInput, strStatType) + Len(strStatType)))
        End If
    End Function

    Sub SetStat(ByRef strInput As String, ByVal strStatType As String, ByVal strWrite As String)
        'Overwrite a stat that exists in a string OR make a new stat

        If Not strInput Like "*" & strStatType & "*" Then
            'If the stat does not already exist

            DebugConsole.GetInfo("Gamemode setstat", strStatType & " not found in " & strInput & ", creating new entry (OK)")
            strInput += strStatType & strWrite & "/" & strStatType
            'Add a new entry
        Else
            'If it does exist, overwrite

            strInput = Mid(strInput, 1, InStr(strInput, strStatType) + Len(strStatType) - 1) &
                strWrite &
                Mid(strInput, InStr(strInput, "/" & strStatType))
            'Replace the string between strStatType with strWrite

            'Ex.

            'SetStat("Apple|TypeDog/Type|Banana", "Type", "Cat")

            'Mid(Apple|TypeDog/Type|Banana, 1, 10) & strWrite & mid(Apple|TypeDog/Type|Banana, 14)
            'Outputs "Apple|TypeCat/Type|Banana

        End If
    End Sub

    Sub SetTotals()

        Dim strStatAdd As String = ""
        'Stat to be added (assigned value of "" to avoid exceptions)

        Dim strTotalStats As String = strUnitData(GetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "PID"))
        'Temporary total stats variable
        'Determine base stats of a unit - refer to reference table

        'Add any extra effects on the unit
        'Visibility, Heat Visibility

        For Check = 0 To 3
            Select Case Check
                Case 0
                    strStatAdd = "Visible"
                Case 1
                    strStatAdd = "HeatVis"
                Case 2
                    strStatAdd = "Burning"
                Case 3
                    strStatAdd = "HP"
                    'HP is not a debuff per se, but is a real-time stat that needs to be recalculated not only across upgrades
            End Select
            SetStat(strTotalStats, strStatAdd, GetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, strStatAdd))
        Next

        Dim sglPercentHP As Single = GetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "HP") / GetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "MaxH")
        'Temporary variable used for a unit's HP

        'Determine if there is an inventory of the unit
        If InStr(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "Inventory") <> 0 AndAlso Not GetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "Inventory") Like "NoInventory" Then
            'Use InStr to check for presece of "Inventory"
            '1st Check - check that inventory exists
            '2nd Check - check that inventory is not null

            For Check = 0 To 4
                'Loop once for every stat in the context of the shop (Damage, Armour, Health, Thermal Signature)

                Select Case Check
                    Case 0
                        strStatAdd = "AD"
                    Case 1
                        strStatAdd = "DR"
                    Case 2
                        strStatAdd = "HP"
                    Case 3
                        strStatAdd = "MaxH"
                    Case 4
                        strStatAdd = "HS"
                End Select

                'Check if the stat modification is there
                If InStr(Shop.strUpgradeData(GetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "Inventory")), strStatAdd) <> 0 Then
                    SetStat(strTotalStats, strStatAdd,
                             Val(GetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, strStatAdd)) +
                             Val(GetStat(Shop.strUpgradeData(GetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "Inventory")), strStatAdd)))

                    'Combine the damage of a unit's base AD and the bonus AD from the item(s)
                End If
            Next
        End If

        btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription = Mid(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, 1, InStr(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "/PID|") + 5) &
            strTotalStats & "Inventory" & GetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "Inventory") & "/Inventory"
        'Set the new data of the strings

        If InStr(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "Inventory") = 0 OrElse GetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "Inventory") Like "NoInventory" Then
            'IMPORTANT: READJUST HP to match current percentage if selling (new inventory is nothing)
            SetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "HP", Math.Ceiling(GetStat(btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "MaxH") * sglPercentHP))
            'Also, make it an integer (ceiling function instead of int because for some reason it sometimes makes the HP lower than needed)
        End If
    End Sub

    Function FindCoordinate(Origin As Button, shrSide As Short) As Point
        'Find coordinate of a button upon player guess

        'This function could be modified to use any 3D array, but I am only using it for btnUnitGrid, to simplify

        Dim pntResult As Point
        For FindX = 0 To 6
            For FindY = 0 To 6
                If btnUnitGrid(shrSide, FindX, FindY) Is Origin Then
                    pntResult = New Point(FindX, FindY)
                End If
            Next
        Next
        Return pntResult
    End Function

    Function Hitcheck(Input As Point) As Boolean
        'Check if there was a hit

        If Mid(btnUnitGrid(1, Input.X, Input.Y).AccessibleDescription, 1, 1) Like "[U, A]" Then
            'Checks if there is a unit/part of a unit on the square (RS grid only)
            Return True
        Else
            Return False
        End If

    End Function

    Sub InfoMessage(strMessage As String, clrColour As Color)
        'Used for broadcasting a global message
        lblInfoDisp.Text = strMessage
        'The message itself in string form
        lblInfoDisp.ForeColor = clrColour
        'The message colour

    End Sub

    Sub UpdateIncome()
        'Display the current income
        lblIncomeDisp.Text = "Income Per Turn: $" & Int(sglIncomeMultiplier(1 - shrTurns Mod 2) * UnitCount(0))
    End Sub

    'QUEST SYSTEM
    'Minigames
    Sub Quest(ByVal Difficulty As Short)
        'Depending on mission number in singleplayer

        If MsgBox("Would you like to take on a quest for money?", MsgBoxStyle.YesNo, "Quest?") = MsgBoxResult.Yes Then

            Dim strDataBase() As String = New String(9) {"Enemy", "Strike", "Demolish", "Retreat", "Attack", "Retaliate", "Tactic", "Dominion", "Ally", "Victory"}
            'Database for words

            Select Case Int(3 * Rnd())
                Case 0
                    'Quest Type 1: Pig Latin
                    Dim strAnswer As String = ""
                    Dim strQuiz As String = ""
                    'Declare temporary variables (add "" to prevent errors in visual studio)

                    For Counter = 1 To Difficulty
                        Dim strCycleAdd As String = strDataBase(Int(10 * Rnd()))

                        If Counter = 1 Then
                            strAnswer = strCycleAdd
                            strQuiz = PigLatin(strCycleAdd)
                        Else
                            strAnswer &= " " & strCycleAdd
                            strQuiz &= " " & PigLatin(strCycleAdd)
                        End If
                    Next

                    If UCase(InputBox("Translate this Pig Latin phrase (Case Insensitive):" & vbCrLf & strQuiz, "Quest - Pig Latin", "Your Response?")) Like UCase(strAnswer) Then
                        MsgBox("Good job! You earned $" & Difficulty * 100)

                        UpdateMoney(shrMoney(1 - shrTurns Mod 2) + Difficulty * 100)
                        shrMoneyEarned(1 - shrTurns Mod 2) += Difficulty * 100
                    Else
                        MsgBox("Incorrect. The correct answer was " & strAnswer & ".", , "Wrong!")
                    End If
                Case 1
                    'Quest Type 2: Unreverse
                    Dim strAnswer As String = ""
                    Dim strQuiz As String = ""
                    'Declare temporary variables (add "" to prevent errors in visual studio)

                    For Counter = 1 To Difficulty
                        Dim strCycleAdd As String = strDataBase(Int(10 * Rnd()))

                        If Counter = 1 Then
                            strAnswer = strCycleAdd
                            strQuiz = StrReverse(strCycleAdd)
                        Else
                            strAnswer &= " " & strCycleAdd
                            strQuiz &= " " & StrReverse(strCycleAdd)
                        End If
                    Next

                    If UCase(InputBox("Unreverse each of the words:" & vbCrLf & strQuiz, "Quest - Pig Latin", "Your Response?")) Like UCase(strAnswer) Then
                        MsgBox("Good job! You earned $" & Difficulty * 100)

                        UpdateMoney(shrMoney(1 - shrTurns Mod 2) + Difficulty * 100)

                        shrMoneyEarned(1 - shrTurns Mod 2) += Difficulty * 100
                    Else
                        MsgBox("Incorrect. The correct answer was " & strAnswer & ".", , "Wrong!")
                    End If
                Case 2
                    'Quest Type 3: Math Challenge
                    'Pretty much the first bit of my math game... as a minigame

                    Dim shrAnswer, shrValue1, shrValue2 As Short
                    'The answer variable, and the 2 values
                    Dim chrSign As Char
                    'Operator

                    shrValue1 = Int(Difficulty * 5 * Rnd())
                    shrValue2 = Int(Difficulty * 5 * Rnd())

                    Select Case Int(4 * Rnd())
                        Case 0
                            'Addition
                            shrAnswer = shrValue1 + shrValue2
                            chrSign = "+"
                        Case 1
                            'Subtraction
                            shrAnswer = shrValue1 - shrValue2
                            chrSign = "-"
                        Case 2
                            'Multiplication
                            shrAnswer = shrValue1 * shrValue2
                            chrSign = "x"
                        Case 3
                            'Division
                            shrValue1 *= shrValue2
                            'Make values divisible for sure
                            shrAnswer = shrValue1 / shrValue2
                            chrSign = "/"
                    End Select

                    If Val(InputBox("Solve this map problem:" & vbCrLf & shrValue1 & " " & chrSign & " " & shrValue2, "Quest - Math", "Your Response?")) =
                        shrAnswer Then
                        MsgBox("Good job! You earned $" & Difficulty * 100)
                        shrMoneyEarned(1 - shrTurns Mod 2) += Difficulty * 100
                    Else
                        MsgBox("Incorrect. The correct answer was " & shrAnswer & ".", , "Wrong!")
                    End If

            End Select

        End If

    End Sub

    Function PigLatin(ByVal strWord As String) As String
        'Converts any word into pig latin

        If Mid(strWord, 1, 1) Like "[A,a,E,e,I,i,O,o,U,u]" Then
            'Check if the word starts with a vowel
            strWord = strWord & "ay"
            'If there's a vowel, just add ay to the end
        Else
            strWord = Mid(strWord, 2, Len(strWord) - 1) & Mid(strWord, 1, 1) & "ay"
            'Otherwise, recompose word with first letter on the back and "ay"
        End If
        'Word has been processed

        Return strWord

    End Function

    'END OF SUBS AND FUNCTIONS



    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        Shop.Show()
    End Sub

    Private Sub btnReturnMenu_Click(sender As Object, e As EventArgs) Handles btnReturnMenu.Click
        If MsgBox("Are you sure you want to return to the menu?", MsgBoxStyle.YesNo, "Return to Menu?") = MsgBoxResult.Yes Then
            MainMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnDebug_Click(sender As Object, e As EventArgs)
        DebugConsole.Show()
    End Sub

    Private Sub pbxRaceDisp_MouseEnter(sender As Object, e As EventArgs) Handles pbxRaceDisp.MouseEnter
        'Display tooltip for race passive
        If shrPlayerChoice(0, 1 - shrTurns Mod 2) <> -1 Then
            ttpDescription.ToolTipTitle = "Race: " & MapSelect.strRaceInfo(0, shrPlayerChoice(0, 1 - shrTurns Mod 2))
            ttpDescription.SetToolTip(sender, MapSelect.strRaceInfo(1, shrPlayerChoice(0, 1 - shrTurns Mod 2)))
        Else
            ttpDescription.ToolTipTitle = "Race: None"
            ttpDescription.SetToolTip(sender, "No race selected!")
        End If

    End Sub

    Private Sub GameMode_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Used for developer purposes VERY EXPERIMENTAL USE AT YOUR OWN RISK

        If e.KeyCode = Keys.F2 And My.Settings.DevMode = True Then
            'Show debug console
            DebugConsole.Show()
        ElseIf e.KeyCode = Keys.F12 And My.Settings.DevMode = True Then
            'Show cheat prompt
            Select Case InputBox("Command? (Type 'help' for details)", "Command Prompt")
                Case "Help"
                    MsgBox("AddMoney - Give the current player $5000" & vbCrLf & "ModifyGrid - Modify the data in any current grid")
                Case "AddMoney"
                    UpdateMoney(shrMoney(1 - shrTurns Mod 2) + 5000)
                Case "ModifyGrid"
                    Dim shrSide, shrX, shrY As Short
                    shrSide = InputBox("Grid Side? (0 or 1)", "Modify Grid (1/5)")
                    shrX = InputBox("X-coordinate? (0 to 6)", "Modify Grid (2/5)")
                    shrY = InputBox("Y-coordinate? (0 to 6)", "Modify Grid (3/5)")

                    SetStat(btnUnitGrid(shrSide, shrX, shrY).AccessibleDescription, InputBox("Stat Type?", "Modify Grid (4/5)"), InputBox("Data? (Current is " & btnUnitGrid(shrSide, shrX, shrY).AccessibleDescription & ").", "Modify Grid (5/5)"))
            End Select
        End If
    End Sub

    Private Sub btnGuide_Click(sender As Object, e As EventArgs) Handles btnGuide.Click
        'Show the tutorial

        If Shop.Visible = True Then
            Shop.btnClose.PerformClick()
            'Close shop just in case
        End If

        Tutorial.ShowDialog()

    End Sub
End Class