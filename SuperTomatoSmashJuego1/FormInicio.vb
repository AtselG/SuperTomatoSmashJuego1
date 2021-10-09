Public Class FormInicio
    Private Sub ButtonJugar_Click(sender As Object, e As EventArgs) Handles ButtonJugar.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.Drip_2, AudioPlayMode.Background)
        End If
        FormJugar.Show()
        Close()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.Drip_2, AudioPlayMode.Background)
        End If
        Application.Exit()
    End Sub

    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SoundOnOff = True
        CursorSiNo = False
    End Sub

    Private Sub ButtonOpciones_Click(sender As Object, e As EventArgs) Handles ButtonOpciones.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.Drip_2, AudioPlayMode.Background)
        End If
        FormOpciones.Show()
        Close()
    End Sub
End Class
