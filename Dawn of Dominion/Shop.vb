'Shop for gamemode, where the user buys units and upgrades - quite complicated due to its heavy relation with gamemode

Public Class Shop

    Public btnShopItems(15) As Button
    Dim lblCosts(15), lblItemInfo(15) As Label
    'Used for showing items and costs

    Dim shrShopID As Short
    'Determine which unit is being clicked

    Dim blnMoveMode As Boolean
    'Determine whether form is sliding in or out

    Public pntSelectUnit As Point
    'The point of the selected unit

    Public shrCosts(,) As Short = New Short(1, 15) {{500, 500, 500, 500, 550, 1000, 600, 600, 1200, 1200, 2000, 900, 1000, 1000, 1000, 1800},
                                                   {350, 400, 400, 800, 600, 800, 600, 1000, 850, 850, 850, 1000, 1000, 1000, 1200, 3333}}
    'The costs of every single unit and upgrade

    Public strUpgradeData() As String = New String(15) {"NameEnergy Blade/Name|AD10/AD|",
                                        "NameHealth Well/Name|HP20/HP|MaxH20/MaxH|",
                                        "NameArmour plate/Name|DR10/DR|",
                                        "NameWeapon Pre-Igniter/Name|AD15/AD|HS5/HS|",
                                        "NameFortitude Enhancer/Name|HP40/HP|MaxH40/MaxH|",
                                        "NameRed Buckler/Name|DR15/DR|HS10/HS|",
                                        "NameOakstone Rootplate/Name|DR25/DR|HP30/HP|MaxH30/MaxH|",
                                        "NameCannonplate/Name|AD5/AD|DR15/DR|",
                                        "NamePhoenix Talon/Name|HS20/HS|AD20/AD|",
                                        "NamePrisma Gatling Striker/Name|AD20/AD|DR-20/DR|",
                                        "NameDefensive Override Controller/Name|AD-20/AD|DR35/DR|",
                                        "NameGuardian of the Grove/Name|DR30/DR|HS-10/HS|",
                                        "NameSteel Gauntlet/Name|AD20/AD|HS-10/HS|",
                                        "NameVitality Staff/Name|HP40/HP|MaxH40/MaxH|HS-5/HS|",
                                        "NameOne-hit Wonder/Name|AD30/AD|DR-25/DR|HP-10/HP|MaxH-10/MaxH|HS-10/HS|",
                                        "NameTrinity Force/Name|AD20/AD|HP50/HP|MaxH50/MaxH|DR30/DR|HS20/HS|"}
    'The data for all of the upgrades

    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Form Setup
        'Set default dimensions
        Me.Left = GameMode.Right
        Me.Top = GameMode.Top

        If My.Settings.Animations = True Then
            tmrInOut.Start()

            pnlTransparency.Left = 0

        Else
            'If you want to skip animations
            Me.Left = GameMode.Right - Me.Width
            Me.Opacity = 1
            pnlTransparency.Left = 1280
        End If

        'BG Setup

        'Shop catagory initialization
        'Units at first, upgrades next
        If GameMode.shrTurns > 2 Then
            gbxShopItems.Text = "Upgrades"

            btnBuy.Visible = True
            btnSell.Visible = True
            gbxUnitInventory.Visible = True
        Else
            gbxShopItems.Text = "Units"
        End If

        'Make array of buttons for shop
        For Sequencer = 0 To 15
            'Button for the unit itself
            btnShopItems(Sequencer) = New Button
            btnShopItems(Sequencer).Size = New Size(100, 95)
            btnShopItems(Sequencer).Location = New Point(15 + 120 * (Sequencer Mod 4), 20 + Int(Sequencer / 4) * 100)
            btnShopItems(Sequencer).AccessibleDescription = Sequencer
            btnShopItems(Sequencer).BackColor = Color.FromArgb(42, 42, 42)


            'Cost of the unit
            lblCosts(Sequencer) = New Label
            lblCosts(Sequencer).Size = New Size(90, 20)
            lblCosts(Sequencer).Font = New Font("Century Gothic", 10)
            lblCosts(Sequencer).ForeColor = Color.Orange
            lblCosts(Sequencer).Location = New Point(5, 70)
            lblCosts(Sequencer).BackColor = Color.Transparent

            'Set unit type
            lblItemInfo(Sequencer) = New Label
            lblItemInfo(Sequencer).Size = New Size(90, 20)
            lblItemInfo(Sequencer).Font = New Font("Century Gothic", 10)
            lblItemInfo(Sequencer).ForeColor = Color.Orange
            lblItemInfo(Sequencer).Location = New Point(5, 5)
            lblItemInfo(Sequencer).BackColor = Color.Transparent

            If GameMode.shrTurns >= 3 Then
                btnShopItems(Sequencer).Image = iglUpgradeSprites.Images(Sequencer)
                'Display the image of the upgrade

                lblCosts(Sequencer).Text = shrCosts(1, Sequencer)
            Else
                btnShopItems(Sequencer).Image = GameMode.iglUnitSprites.Images(Sequencer)
                'Display the image of the unit

                lblItemInfo(Sequencer).Text = Val(GameMode.GetStat(GameMode.strUnitData(Sequencer), "Hori")) + 1 & "x" & Val(GameMode.GetStat(GameMode.strUnitData(Sequencer), "Vert")) + 1
                'Display the size of the unit

                lblCosts(Sequencer).Text = shrCosts(0, Sequencer)
                'Show the cost
            End If

            'Add controls and handler
            gbxShopItems.Controls.Add(btnShopItems(Sequencer))

            AddHandler btnShopItems(Sequencer).Click, AddressOf ShopItemClick

            btnShopItems(Sequencer).Controls.Add(lblCosts(Sequencer))
            btnShopItems(Sequencer).Controls.Add(lblItemInfo(Sequencer))
        Next

        'Finish array creation


        'Load in a unit if necessary
        If GameMode.shrTurns >= 3 Then
            If GameMode.btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).BackColor = Color.Yellow Then
                UnitLoad(GameMode.btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription)
            Else
                lblDescription.Text = "Click on a shop item for more information!"
            End If
        End If

    End Sub

    Private Sub tmrInOut_Tick(sender As Object, e As EventArgs) Handles tmrInOut.Tick
        'Used for sliding the form in and out
        If blnMoveMode = False And Me.Right > GameMode.Right Then
            Me.Left -= My.Settings.FadeSpeed * 1000
            pnlTransparency.Left += My.Settings.FadeSpeed * 1000
        ElseIf blnMoveMode = False And Me.Right <= GameMode.Right Then
            tmrInOut.Stop()
        ElseIf blnMoveMode = True And Me.Left < GameMode.Right Then
            Me.Left += My.Settings.FadeSpeed * 1000
            pnlTransparency.Left -= My.Settings.FadeSpeed * 1000
        ElseIf blnMoveMode = True And Me.Left >= GameMode.Right Then
            tmrInOut.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Verifies if animations are on or off first
        If My.Settings.Animations = True Then
            blnMoveMode = True
            tmrInOut.Start()
        Else
            Me.Close()
        End If

    End Sub

    Public Sub UnitLoad(ByVal Input As String)
        'Used to load EITHER

        '- Items in the store
        '- Units in the game

        'Calculate stats of unit that has been selected

        lblDescription.Text = GameMode.GetStat(Input, "Name") & " - $"

        If GameMode.shrTurns >= 3 Then
            lblDescription.Text &= shrCosts(1, GameMode.shrPlaceID)

            'Map unit-specific actions
            'Check for presence of inventory

            btnSell.Enabled = Not GameMode.GetStat(GameMode.btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "Inventory") Like Nothing
            'Enable sell only if the unit has an inventory

        Else
            lblDescription.Text &= shrCosts(0, GameMode.shrPlaceID)
        End If

        'Interpret from string - stats and other information
        lblDescription.Text &= vbCrLf & GameMode.GetStat(Input, "Desc") & vbCrLf &
            "Unit Health: " & GameMode.GetStat(Input, "HP") & vbCrLf &
             "Damage Reduction: " & GameMode.GetStat(Input, "DR") & vbCrLf &
            "Attack Damage: " & GameMode.GetStat(Input, "AD") & vbCrLf &
            "Heat Signature: " & GameMode.GetStat(Input, "HS") & "%" & vbCrLf & "Manufacturer: "

        Select Case GameMode.GetStat(Input, "RType")
            Case 0
                lblDescription.Text += "Equanos"
            Case 1
                lblDescription.Text += "Elementan"
            Case 2
                lblDescription.Text += "Infernus"
            Case 3
                lblDescription.Text += "Prisma"
            Case 4
                lblDescription.Text += "Umbra"
        End Select

        lblDescription.Text += vbCrLf & "Can be placed on: "

        Select Case GameMode.GetStat(Input, "TType")
            Case "G"
                lblDescription.Text += "Ground"
            Case "W"
                lblDescription.Text += "Water"
            Case "A"
                lblDescription.Text += "Air"
            Case "V"
                lblDescription.Text += "Void"
        End Select

        pbxDisplay.Image = GameMode.iglUnitSprites.Images(GameMode.shrPlaceID)
        'Load the image of the unit/shop unit

        InventoryVerify(Input)

        btnBuy.Enabled = False
        'Keep it disabled until a shop selection is given
    End Sub

    Private Sub UpgradeLoad(ByVal Input As String)
        'Calculate stats of upgrade that has been selected

        lblDescription.Text = GameMode.GetStat(Input, "Name") & vbCrLf
        'Get name of the upgrade

        'Load the stat descriptions

        'Interpret from string
        Dim strStatAdd As String = ""
        Dim strStatName As String = ""

        For Check = 0 To 3
            'Loop once for every stat in the game

            Select Case Check
                Case 0
                    strStatAdd = "AD"
                    strStatName = "Attack Damage"
                Case 1
                    strStatAdd = "DR"
                    strStatName = "Damage Reduction"
                Case 2
                    strStatAdd = "HP"
                    strStatName = "Maximum Health"
                Case 3
                    strStatAdd = "HS"
                    strStatName = "Heat Signature"
            End Select

            If InStr(Input, strStatAdd) <> 0 Then

                If Val(GameMode.GetStat(Input, strStatAdd)) > 0 Then
                    'If you get stat buff,
                    lblDescription.Text += "+ "
                Else
                    'If you get stat debuff,
                    lblDescription.Text += "- "
                End If

                If Check = 3 Then
                    'SPECIAL CASE - HEAT SIGNATURE - It has to be %
                    lblDescription.Text &= Math.Abs(Val(GameMode.GetStat(Input, strStatAdd))) & "%" & " " & strStatName & vbCrLf
                Else
                    'Otherwise, add normally
                    lblDescription.Text &= Math.Abs(Val(GameMode.GetStat(Input, strStatAdd))) & " " & strStatName & vbCrLf
                End If

            End If
        Next

        pbxDisplay.Image = iglUpgradeSprites.Images(shrShopID)
        'Display the corresponding image

        InventoryVerify(GameMode.btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription)
        'Update status of buy/sell buttons
    End Sub

    Sub InventoryVerify(ByVal Input As String)
        'Used to update buy and sell buttons based on inventory presence

        If InStr(Input, "Inventory") <> 0 Then
            'Check 1 - Presence of Inventory Stat Header
            If Not GameMode.GetStat(Input, "Inventory") Like "NoInventory" Then
                'Check 2 - Presence of a stat
                Dim shrKey As Short = GameMode.GetStat(Input, "Inventory")
                pbxInventoryDisp.Image = iglUpgradeSprites.Images(shrKey)

                btnSell.Enabled = True
                btnBuy.Enabled = False
            Else
                btnSell.Enabled = False
                pbxInventoryDisp.Image = Nothing
            End If
            'If it has an inventory
        Else
            btnSell.Enabled = False
            pbxInventoryDisp.Image = Nothing
        End If
    End Sub

    Private Sub ShopItemClick(sender As Object, e As EventArgs)
        'When a shop item is clicked on

        If GameMode.shrTurns >= 3 Then
            'LOADING AN UPGRADE
            shrShopID = sender.accessibledescription

            UpgradeLoad(strUpgradeData(shrShopID))

            'Update buy button enable/disable based on money and inventory presence
            'Not just using InventoryVerify due to extra factors
            btnBuy.Enabled = GameMode.shrMoney(1 - GameMode.shrTurns Mod 2) > shrCosts(1, shrShopID) And
                (InStr(GameMode.btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "Inventory") = 0 OrElse
                 GameMode.GetStat(GameMode.btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "Inventory") Like "NoInventory")
            'Check 1: Enough money
            'Check 2: Inventory slot available

        Else
            'LOADING A UNIT
            GameMode.shrPlaceID = sender.accessibledescription
            'Set ID for placing unit on gamemode side
            UnitLoad(GameMode.strUnitData(sender.accessibledescription))

        End If
    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        'This assumes that player has enough money - accounted for in other parts of code
        GameMode.UpdateMoney(GameMode.shrMoney(1 - GameMode.shrTurns Mod 2) - shrCosts(1, shrShopID))

        'UPDATE STAT
        shrMoneySpent(1 - GameMode.shrTurns Mod 2) += shrCosts(1, shrShopID)

        'Add entry
        GameMode.SetStat(GameMode.btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "Inventory", shrShopID)

        BuySellCycle(sender)

    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        'This assumes that player is able to sell - accounted for in other parts of code

        If MsgBox("Are you sure you want to sell? You will only receive 40% of the purchase cost ($" &
                  shrCosts(1, Val(GameMode.GetStat(GameMode.btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "Inventory"))) * 0.4 &
                  ") back!", MsgBoxStyle.YesNo, "Sell?") = MsgBoxResult.Yes Then
            'Confirm with the player that they are selling

            GameMode.UpdateMoney(GameMode.shrMoney(1 - GameMode.shrTurns Mod 2) + shrCosts(1, Val(GameMode.GetStat(GameMode.btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "Inventory"))) * 0.4)
            'Refund unit cost (40%)

            shrMoneyRefunded(1 - GameMode.shrTurns Mod 2) += shrCosts(1, Val(GameMode.GetStat(GameMode.btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "Inventory"))) * 0.4
            'Update Stats

            'Clear entry
            GameMode.SetStat(GameMode.btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription, "Inventory", "NoInventory")

            pbxInventoryDisp.Image = Nothing
            'Clear the inventory image

            BuySellCycle(sender)

        End If

    End Sub

    Sub BuySellCycle(ByRef sender As Object)
        'Routine code to be executed with all buy and sell cycles (efficiency)

        GameMode.SetTotals()

        'Update Total stats of the unit
        UnitLoad(GameMode.btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription)
        'Reload unit
    End Sub

    Private Sub Shop_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick, lblDescription.MouseClick
        'Defocus an item if the shop's bounds are clicked on
        If GameMode.shrTurns >= 3 Then
            If GameMode.btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).BackColor = Color.Yellow Then
                UnitLoad(GameMode.btnUnitGrid(0, pntSelectUnit.X, pntSelectUnit.Y).AccessibleDescription)
            Else
                lblDescription.Text = "Click on a shop item for more information!"
            End If
        End If

    End Sub
End Class