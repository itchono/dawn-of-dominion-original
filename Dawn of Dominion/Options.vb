'Used for adjusting settings and also displaying credits of the author

Public Class Options

    Dim blnCtlLock, blnFadeInOut As Boolean
    'Lock setting change capability
    'For fading form in/out

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'FORM POSITION
        Me.Left = MainMenu.Right

        pnlTransparency.Left = 0
        'Put it against the edge

        'Why do I need blnCtlLock?

        'When I am applying existing settings, I change the check value of the checkboxes and the numericupdown.
        'However, this triggers the checkchanged and valuechanged events, which resets the value of the variable
        'Thus, I must lock the boxes first until settings are done being applied.

        'Detect existing settings

        'Sound on/off
        If My.Settings.Sound = True Then
            cbxSound.Checked = True
        End If

        'Dev mode on/off
        If My.Settings.DevMode = True Then
            cbxDevCheat.Checked = True
        End If

        'Animations on/off
        If My.Settings.Animations = True Then
            cbxAnimations.Checked = True
        End If

        'Update fadespeed
        nudFadeSpeed.Value = My.Settings.FadeSpeed / 0.04 * 100

        'Update Reset Save ability
        btnResetSave.Enabled = My.Settings.SaveState <> -1

        'Reenable settings modification
        blnCtlLock = True

        'Verify animations first
        If My.Settings.Animations = True Then
            tmrFade.Start()
        Else
            Me.Opacity = 1
            pnlTransparency.Left = 1280
            Me.Left = MainMenu.Right - Me.Width
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Verify animations first
        If My.Settings.Animations = True Then
            blnFadeInOut = True
            tmrFade.Start()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub tmrFade_Tick(sender As Object, e As EventArgs) Handles tmrFade.Tick
        'Determine fading in or fading out
        If blnFadeInOut = False And Me.Left <= MainMenu.Right - Me.Width Then
            'If fading in, and opacity reaches 100%, stop
            tmrFade.Stop()

        ElseIf blnFadeInOut = False And Me.Left > MainMenu.Right - Me.Width Then
            'If fading in and opacity <> 100%, keep going

            pnlTransparency.Left += Me.Width / 25 * My.Settings.FadeSpeed / 0.04
            Me.Left -= Me.Width / 25 * My.Settings.FadeSpeed / 0.04

        ElseIf blnFadeInOut = True And Me.Left < MainMenu.Right Then
            'If fading out, keep going

            pnlTransparency.Left -= Me.Width / 25 * My.Settings.FadeSpeed / 0.04
            Me.Left += Me.Width / 25 * My.Settings.FadeSpeed / 0.04

        ElseIf blnFadeInOut = True And Me.Left >= MainMenu.Right Then
            'If fading out, and opacity is 0%, stop
            Me.Close()
            'Close form; return to menu (since opened as showdialog)
        End If
    End Sub

    '**Each option has its own unique set of needs in terms of what code needs to be executed. Functions are therefore not used.

    'Animation Checkbox
    Private Sub cbxAnimations_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAnimations.CheckedChanged
        If blnCtlLock = True Then
            If sender.checked = True Then
                My.Settings.Animations = True
                If My.Settings.SaveState > 9 Then
                    MainMenu.pbxMenuAnimation.Image = My.Resources.Anim_GliesePast
                Else
                    MainMenu.pbxMenuAnimation.Image = My.Resources.Anim_GlieseNow
                End If
            Else
                My.Settings.Animations = False
                If My.Settings.SaveState > 9 Then
                    MainMenu.pbxMenuAnimation.Image = My.Resources.Graphic_StaticGliesePast
                Else
                    MainMenu.pbxMenuAnimation.Image = My.Resources.Graphic_StaticGlieseNow
                End If
            End If
        End If
    End Sub

    'Sound Checkbox
    Private Sub cbxSound_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSound.CheckedChanged
        If blnCtlLock = True Then
            If sender.checked = True Then
                My.Settings.Sound = True
                shrActiveTrack = -1
                'Clear existing tracks if there so that audio can restart
                MusicChange(1)

            Else
                My.Settings.Sound = False
                My.Computer.Audio.Stop()
            End If
        End If
    End Sub

    'Developer Mode Checkbox
    Private Sub cbxDevCheat_CheckedChanged(sender As Object, e As EventArgs) Handles cbxDevCheat.CheckedChanged
        If blnCtlLock = True Then
            If sender.checked = True Then

                If InputBox("Password?", "Enable Developer Mode?") Like "Warden" Then
                    My.Settings.DevMode = True

                    If GameMode.GetStat(My.Settings.Achievements, "I am a h4ck3r") Like "False" Then
                        GameMode.SetStat(My.Settings.Achievements, "I am a h4ck3r", "True")
                        'Update Achievement

                        MsgBox("I am a h4ck3r - Enable the developer cheats.", , "Achievement Get!")
                    End If


                    My.Settings.SaveState = 10
                    MsgBox("Cheat Enabled - all levels unlocked as well.")
                Else
                    sender.checked = False
                End If
            Else
                My.Settings.DevMode = False
            End If
        End If
    End Sub

    Private Sub nudFadeSpeed_ValueChanged(sender As Object, e As EventArgs) Handles nudFadeSpeed.ValueChanged
        'Whenever the user adjusts the fadespeed of the form

        If blnCtlLock = True Then
            'Change fadespeed to the new setting
            My.Settings.FadeSpeed = nudFadeSpeed.Value / 100 * 0.04
        End If
    End Sub

    Private Sub btnResetStats_Click(sender As Object, e As EventArgs) Handles btnResetStats.Click
        'Reset all stats
        If MsgBox("Are you sure you want to reset your stats and achievements?", MsgBoxStyle.YesNo, "Reset Save?") = MsgBoxResult.Yes Then
            My.Settings.StatUnitsPlaced = Nothing
            My.Settings.StatUnitsDestroyed = Nothing
            My.Settings.StatDTaken = Nothing
            My.Settings.StatDDealt = Nothing
            My.Settings.MapsPlayed = "M0False/M0|M1False/M1|M2False/M2|M3False/M3|M4False/M4|M5False/M5|M6False/M6|"
            My.Settings.Achievements = "AmbassadorFalse/Ambassador|HeroFalse/Hero|YOLOFalse/YOLO|Not Even a ScratchFalse/Not Even a Scratch|Grand TourFalse/Grand Tour|I am a h4ck3rFalse/I am a h4ck3r|AdvancedFalse/Advanced|"

            btnResetStats.Enabled = False
        End If
    End Sub

    Private Sub btnResetSave_Click(sender As Object, e As EventArgs) Handles btnResetSave.Click
        'Reset the Save
        If MsgBox("Are you sure you want to reset your save? All progress will be lost!", MsgBoxStyle.YesNo, "Reset Save?") = MsgBoxResult.Yes Then
            My.Settings.SaveState = -1
            My.Settings.SaveUser = Nothing
            btnResetSave.Enabled = False
        End If
    End Sub
End Class