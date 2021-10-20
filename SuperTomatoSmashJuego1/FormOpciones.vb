Public Class FormOpciones
    Private Sub LabelSi_Click(sender As Object, e As EventArgs) Handles LabelSi.Click
        SoundOnOff = True
        LabelSi.Hide()
        LabelNo.Show()
    End Sub

    Private Sub LabelNo_Click(sender As Object, e As EventArgs) Handles LabelNo.Click
        SoundOnOff = False
        LabelNo.Hide()
        LabelSi.Show()
    End Sub
    Private Sub ButtonVolver_Click_1(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.Drip_2, AudioPlayMode.Background)
        End If
        FormInicio.Show()
        Close()
    End Sub

    Private Sub FormOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBoxCursor2.Hide()
        PictureBoxCursor3.Hide()
        PictureBoxCursor4.Hide()
        ButtonLeft1.Hide()
        LabelNo.Hide()
        CursorCont = 1
    End Sub

    Private Sub ButtonRight1_Click(sender As Object, e As EventArgs) Handles ButtonRight1.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.Drip_2, AudioPlayMode.Background)
        End If
        CursorCont += 1
        If CursorCont = 1 Then
            ButtonLeft1.Show()
            PictureBoxCursor1.Show()
            ButtonTick.Show()
        ElseIf CursorCont = 2 Then
            PictureBoxCursor1.Hide()
            PictureBoxCursor2.Show()
            ButtonTick.Show()
            ButtonLeft1.Show()
        ElseIf CursorCont = 3 Then
            PictureBoxCursor2.Hide()
            PictureBoxCursor3.Show()
            ButtonTick.Show()
            ButtonLeft1.Show()
        ElseIf CursorCont = 4 Then
            PictureBoxCursor3.Hide()
            PictureBoxCursor4.Show()
            ButtonRight1.Hide()
            ButtonTick.Show()
            ButtonLeft1.Show()
        End If
    End Sub

    Private Sub ButtonLeft1_Click(sender As Object, e As EventArgs) Handles ButtonLeft1.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.Drip_2, AudioPlayMode.Background)
        End If
        CursorCont -= 1
        If CursorCont = 0 Then
            ButtonTick.Hide()
            ButtonRight1.Show()
        ElseIf CursorCont = 1
            PictureBoxCursor2.Hide()
            PictureBoxCursor1.Show()
            ButtonLeft1.Hide()
            ButtonTick.Show()
            ButtonRight1.Show()
        ElseIf CursorCont = 2
            PictureBoxCursor3.Hide()
            PictureBoxCursor2.Show()
            ButtonTick.Show()
            ButtonRight1.Show()
        ElseIf CursorCont = 3
            PictureBoxCursor4.Hide()
            PictureBoxCursor3.Show()
            ButtonTick.Show()
            ButtonRight1.Show()
        End If
    End Sub

    Private Sub ButtonTick_Click(sender As Object, e As EventArgs) Handles ButtonTick.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.Drip_2, AudioPlayMode.Background)
        End If
        ButtonTick.Hide()
        CursorSiNo = True
    End Sub
End Class
