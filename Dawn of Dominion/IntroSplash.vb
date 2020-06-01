'Splash Screen for DoD that shows at very beginning

Public Class IntroSplash

    Dim shrTimer As Short
    'Used for determining whether fading in, out, or staying idle

    Private Sub IntroSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrFade.Start()
    End Sub

    Private Sub tmrFade_Tick(sender As Object, e As EventArgs) Handles tmrFade.Tick
        shrTimer += 1
        'Fade in at first, slight pause, then fade out
        If shrTimer <= 1 / My.Settings.FadeSpeed Then
            Me.Opacity += My.Settings.FadeSpeed
        ElseIf shrTimer > 1 / My.Settings.FadeSpeed + 100 Then
            Me.Opacity -= My.Settings.FadeSpeed
            If Me.Opacity = 0 Then
                tmrFade.Stop()
                MainMenu.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class
