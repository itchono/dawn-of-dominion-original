Module GlobalItems

    'A BUNCH OF GLOBAL VARIABLES


    Public shrActiveTrack As Short
    'Used to track active track of music being played

    Public blnPlayMode As Boolean
    'Used to keep track of play mode
    'False = 1v1 PVP
    'True = PvE

    Public shrPlayerChoice(1, 1) As Short
    '(First Index)
    '0: Race Choice
    '1: Map Choice
    'Second Index: 1 per player

    Public shrMoneyStart As Short = 3000
    'Starting cash for both sides

    Public strUserNames(1) As String
    'Usernames for 2 player

    Public shrMissionNumber As Short
    'Mission number for singleplayer

    Public shrCutsceneCount As Short
    'Used for identifying in part which lines to display in the cutscene

    Public blnQuestEnabled As Boolean = True
    'Determines whether or not quests are enables (true by default)

    'STATS
    Public shrDDealt(1), shrDTaken(1), shrMoneySpent(1), shrMoneyRefunded(1), shrMoneyEarned(1), shrUnitsDestroyed(1), shrUnitsPlaced(1) As Short
    'Used for keeping track of stats

    Public blnWinner As Boolean
    'Who wins - False is player 1, and True is player 2/AI

    'END OF STATS

    'END OF GLOBAL VARIABLES

    'Efficient usage of a global sub for changing the active track
    'DYNAMIC MUSIC SYSTEM
    'If a track is already playing, don't override it (because then it makes the experience weird)
    Public Sub MusicChange(shrTrack As Short)
        If Not shrActiveTrack = shrTrack And My.Settings.Sound = True Then
            'Checks that 1. Track is not playing and 2. Sound is enabled
            Select Case shrTrack
                Case 1
                    My.Computer.Audio.Play(My.Resources.Music_MainTheme, AudioPlayMode.BackgroundLoop)
                Case 2
                    My.Computer.Audio.Play(My.Resources.Music_SPlayerIntro, AudioPlayMode.BackgroundLoop)
                Case 3
                    My.Computer.Audio.Play(My.Resources.Music_Javelin, AudioPlayMode.BackgroundLoop)
                Case 4
                    My.Computer.Audio.Play(My.Resources.Music_Select, AudioPlayMode.BackgroundLoop)
                Case 5
                    My.Computer.Audio.Play(My.Resources.Music_ArenaCommander, AudioPlayMode.BackgroundLoop)
                Case 6
                    My.Computer.Audio.Play(My.Resources.Music_SQ42THEME, AudioPlayMode.BackgroundLoop)
                Case 7
                    My.Computer.Audio.Play(My.Resources.Music_Challenger, AudioPlayMode.BackgroundLoop)
                Case 8
                    My.Computer.Audio.Play(My.Resources.Music_MissionComplete, AudioPlayMode.BackgroundLoop)
                Case 9
                    My.Computer.Audio.Play(My.Resources.Music_Fail, AudioPlayMode.Background)
                    'DON'T repeat this one
            End Select

            shrActiveTrack = shrTrack
        End If
    End Sub


End Module
