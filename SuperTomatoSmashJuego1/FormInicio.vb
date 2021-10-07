Public Class FormInicio
    Private Sub ButtonJugar_Click(sender As Object, e As EventArgs) Handles ButtonJugar.Click
        My.Computer.Audio.Play(My.Resources.Drip_2, AudioPlayMode.Background)
        FormJugar.Show()
        Close()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        My.Computer.Audio.Play(My.Resources.Drip_2, AudioPlayMode.Background)
        Application.Exit()
    End Sub

    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.MusicInicio, AudioPlayMode.BackgroundLoop)
        CursorOpciones = (My.Resources.Cursor12)
    End Sub

    Private Sub ButtonOpciones_Click(sender As Object, e As EventArgs) Handles ButtonOpciones.Click
        FormOpciones.Show()
        Dispose()
    End Sub
End Class
