'A tutorial/guide to show the player what they need to do

Public Class Tutorial

    Dim shrTutSlide As Short
    'Used to keep track of what slide of the tutorial we are on

    Dim strText(,) As String = New String(1, 9) {{"Welcome to Dawn of Dominion!", "1. Main Menu", "2. Map Selection and Race Passives", "3.0 Battlegrounds Intro", "3.1 Buying your First Unit",
                                                 "3.2.0 Attacking", "3.2.1 Damage and Multi-Grid Units", "3.3 Income", "3.4 Vision and Heat Signature", "3.5 Items"},
                                                {"Dawn of Dominion is a large-scale turn-based combat and strategy game. Your ultimate goal is to destroy all of your opponent's units to win." & vbCrLf &
                                                    "Combat is achieved through the use of units, which attack each other. Like Battleship, you select a target square to fire upon. Unlike it, " &
                                                    "You fire using a unit, and all units have different, modifiable stats. Additionally, you get to choose your own battle grounds. Some allow " &
                                                    "certain units to be placed, while others allow different ones. Furthermore, you get to choose from 1 of 5 passives to help you!",
                                             "This is the main menu. You can start playing the story mode (singleplayer), or a 1 vs 1 battle against someone else near you.",
                                             "This is the Map and Race Selection Screen. Here, you get to choose what race you play as, as well as your map. " &
                                             "Choose wisely upon your race - each of the 5 passives allows a different playstyle. Additionally, the map you choose " &
                                             "can have an effect on how your units are placed.",
                                             "These are the battlegrounds. The one on the left is always yours, and the one on the right is the enemy's. Your units are placed here. " &
                                             "The indicators near the top right indicate your income and any info messages that you may receive. The number of active units on each side " &
                                             "are listed. The turn number and phase (Setup Phase/Combat Phase) are indicaed near the top left.",
                                             "The shop is located at the very top right. It contains all of the units that you can place down in the game. To place a unit, click on a unit in the shop, then click on a square on your grid. " &
                                            "Understand that diffent units go on different terrain types. For instance, ships cannot go on land. Remember to click the 'Done Placing' button after you're done!",
                                             "To attack another unit, you must select a target square on your opponent's side, and a unit to attack with on your own side. After you select both, click the " &
                                             "FIRE button. You will see if your shot hits or not, and how much damage you dealt as an info message if you did so.",
                                             "When a unit strikes another unit, its health decreases by a certain amount. This is based off of the attacker's damage, and the unit's armour (damage reduction). " &
                                             "If the unit's health reaches 0, it is destroyed. Remember multi-grid units fdfrom earlier? Their damage works a bit differently. This is VERY importnant: Damage " &
                                             "for multi-grid units is displayed as a per-square stat. For instance, if a 1x3 unit in the shop is displayed as having 30 damage, its actual damage when attacking is " &
                                             "30 x 3 = 90 damage. However, if one of the squares is destroyed, it loses that attacking power (Ex. 1x3 with only 2 squares left deals 30 damage). Items in the shop " &
                                             "only apply to the square that it is purchased on, not the entire unit." & vbCrLf & "Note: If you destroy the command square of a unit (top-left most), THE ENTIRE " &
                                             "UNIT IS DESTROYED! So if you know that a multi-grid unit is somewhere, try to find the command square!",
                                             "Income is the money that you earn each turn. Your income is calculated based on how many operational (not destroyed) units you have, as well as the amount of damage " &
                                             "that you deal to your opponent. So make sure you hit your shots properly!" & vbCrLf & "Additionally, you can earn money each turn through randomly appearing quests!",
                                             "At the start of each game, you cannot see your opponent's units' positions. However, the Prisma passive (Illumination) and the heat signature system change this. " &
                                             "Each time a unit fires, it has a chance of leaving a heat signature for 1 turn, which your opponent can use to spot you! Additionally, heat signature chance is " &
                                             "doubled if a shot is made by a unit and hits another unit. Be careful when and how you shoot!" & vbCrLf & "Another point about vision is that once you hit an enemy, " &
                                             "They become visible to you. Remember, you cannot see your opponent's units until they emit a heat signature, or become visible!",
                                             "After Setup Phase has ended, you can buy upgrades for your units. Select a unit on your side just like with combat (shop can be open or closed), " &
                                             "and find an item to your liking in the shop. Items increase or decrease stats of a unit for money. You can only buy and store " &
                                             "1 item per unit, so be wise in your choice. If you ever change your mind, you can sell the item for its original cost by clicking the sell button " &
                                             "on an appropriate unit. Beware, once a unit is destroyed, you cannot recuperate any items from it! NOTE: Health scaling is based off of your health percentage!" &
                                             "For example, if you buy a +40 health item at 50% HP, you will only gain 50% of 40, or +20 health."}}
    'Tutorial text


    Private Sub Tutorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateSlide(shrTutSlide)
        'Show first slide
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    'Back and Forth in the tutorial
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        shrTutSlide += 1
        UpdateSlide(shrTutSlide)
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        shrTutSlide -= 1
        UpdateSlide(shrTutSlide)
    End Sub

    'Update the text in the tutorial
    Sub UpdateSlide(ByVal shrNumber As Short)
        lblTutorialTitle.Text = strText(0, shrNumber)
        lblTutorialText.Text = strText(1, shrNumber)

        'For button activity
        Select Case shrTutSlide
            Case Is <= 0
                btnPrev.Enabled = False
            Case Is >= 9
                btnNext.Enabled = False
            Case Else
                btnPrev.Enabled = True
                btnNext.Enabled = True
        End Select


        'Display the correct image depending on the slide
        'These need to be higher res, so I am not using an imagelist (whose max. res is 255 * 255)
        Select Case shrTutSlide
            Case 0
                pbxTutorialImage.Image = My.Resources.Graphic_StaticGlieseNow
            Case 1
                pbxTutorialImage.Image = My.Resources.Tutorial0
            Case 2
                pbxTutorialImage.Image = My.Resources.Tutorial1
            Case 3
                pbxTutorialImage.Image = My.Resources.Tutorial2
            Case 4
                pbxTutorialImage.Image = My.Resources.Tutorial3
            Case 5
                pbxTutorialImage.Image = My.Resources.Tutorial4
            Case 6
                pbxTutorialImage.Image = My.Resources.Tutorial5
            Case 7
                pbxTutorialImage.Image = My.Resources.Tutorial6
            Case 8
                pbxTutorialImage.Image = My.Resources.Tutorial7
            Case 9
                pbxTutorialImage.Image = My.Resources.Tutorial8
        End Select

    End Sub
End Class