'Used mainly during the early phases of development, now serves as a semi-useful debugging tool

Public Class DebugConsole

    Sub GetInfo(ByVal strHeader As String, ByVal strInput As String)
        lbxOutput.Items.Add("FROM: " & strHeader & vbCrLf & "DATA: " & strInput)
    End Sub

End Class