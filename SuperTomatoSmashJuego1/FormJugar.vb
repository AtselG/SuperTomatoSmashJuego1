Public Class FormJugar
    Private Sub FormJugar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContCont = 0
        TimerObjetivo1.Start()
        LabelContador.Text = " 0/10 "
        If CursorSiNo = False Then
            Me.Cursor = Cursors.Cross
        ElseIf CursorSiNo = True Then
            If CursorCont = 1 Then
                Me.Cursor = New Cursor(Cursor1)
            ElseIf CursorCont = 2 Then
                Me.Cursor = New Cursor(Cursor2)
            ElseIf CursorCont = 3 Then
                Me.Cursor = New Cursor(Cursor3)
            ElseIf CursorCont = 4 Then
                Me.Cursor = New Cursor(Cursor4)
            End If
        End If
        PictureBox2.Hide()
    End Sub

    Private Sub TimerContador1_Tick(sender As Object, e As EventArgs) Handles TimerContador1.Tick
        TimerContador1.Stop()
        ContInfo += 1
        If ContInfo = 1 Then
            Info1.ShowDialog(owner:=Me)
        ElseIf ContInfo = 2 Then
            Info2.ShowDialog()
        ElseIf ContInfo = 3 Then
            Info3.ShowDialog()
        ElseIf ContInfo = 4 Then
            Info4.ShowDialog()
        ElseIf ContInfo = 5 Then
            Info5.ShowDialog()
        ElseIf ContInfo = 6 Then
            Info6.ShowDialog()
        ElseIf ContInfo = 7 Then
            info7.ShowDialog()
        ElseIf ContInfo = 8 Then
            Info8.ShowDialog()
        ElseIf ContInfo = 9 Then
            Info9.ShowDialog()
        ElseIf ContInfo = 10 Then
            Info10.ShowDialog()
        ElseIf ContInfo = 11 Then
            ContInfo = 1
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox2.Hide()
    End Sub
    Private Sub TimerObjetivo1_Tick(sender As Object, e As EventArgs) Handles TimerObjetivo1.Tick
        If DificultadElegida = 1 Then
            If DificultadBajaNivel = 1 Then
                PictureBoxObjetivo1.Left -= 20
                PictureBoxObjetivo2.Left += 30
                PictureBoxObjetivo3.Left -= 40
            ElseIf DificultadBajaNivel = 2 Then
                PictureBoxObjetivo1.Left -= 20 + 6
                PictureBoxObjetivo2.Left += 30 + 6
                PictureBoxObjetivo3.Left -= 40 + 6
            ElseIf DificultadBajaNivel = 3 Then
                PictureBoxObjetivo1.Left -= 20 + 7
                PictureBoxObjetivo2.Left += 30 + 7
                PictureBoxObjetivo3.Left -= 40 + 7
                PictureBoxObjetivo4.Left += 50 + 7
            ElseIf DificultadBajaNivel = 4 Then
                PictureBoxObjetivo1.Left -= 20 + 8
                PictureBoxObjetivo2.Left += 30 + 8
                PictureBoxObjetivo3.Left -= 40 + 8
                PictureBoxObjetivo4.Left += 50 + 8
            ElseIf DificultadBajaNivel = 5 Then
                PictureBoxObjetivo1.Left -= 20 + 9
                PictureBoxObjetivo2.Left += 30 + 9
                PictureBoxObjetivo3.Left -= 40 + 9
                PictureBoxObjetivo4.Left += 50 + 9
                PictureBoxObjetivo5.Left -= 20 + 9
            ElseIf DificultadBajaNivel = 6 Then
                PictureBoxObjetivo1.Left -= 20 + 10
                PictureBoxObjetivo2.Left += 30 + 10
                PictureBoxObjetivo3.Left -= 40 + 10
                PictureBoxObjetivo4.Left += 50 + 10
                PictureBoxObjetivo5.Left -= 40 + 10
            ElseIf DificultadBajaNivel = 7 Then
                PictureBoxObjetivo1.Left -= 20 + 11
                PictureBoxObjetivo2.Left += 30 + 11
                PictureBoxObjetivo3.Left -= 40 + 11
                PictureBoxObjetivo4.Left += 50 + 11
                PictureBoxObjetivo5.Left -= 40 + 11
            ElseIf DificultadBajaNivel = 8 Then
                PictureBoxObjetivo1.Left -= 20 + 12
                PictureBoxObjetivo2.Left += 30 + 12
                PictureBoxObjetivo3.Left -= 40 + 12
                PictureBoxObjetivo4.Left += 50 + 12
                PictureBoxObjetivo5.Left -= 20 + 12
                PictureBoxObjetivo6.Left += 30 + 12
            ElseIf DificultadBajaNivel = 9 Then
                PictureBoxObjetivo1.Left -= 20 + 13
                PictureBoxObjetivo2.Left += 30 + 13
                PictureBoxObjetivo3.Left -= 40 + 13
                PictureBoxObjetivo4.Left += 50 + 13
                PictureBoxObjetivo5.Left -= 20 + 13
                PictureBoxObjetivo6.Left += 20 + 13
                PictureBoxObjetivo7.Left -= 20 + 13
            ElseIf DificultadBajaNivel = 10 Then
                PictureBoxObjetivo1.Left -= 20 + 14
                PictureBoxObjetivo2.Left += 30 + 14
                PictureBoxObjetivo3.Left -= 40 + 14
                PictureBoxObjetivo4.Left += 20 + 14
                PictureBoxObjetivo5.Left -= 30 + 14
                PictureBoxObjetivo6.Left += 40 + 14
                PictureBoxObjetivo7.Left -= 20 + 14
                PictureBoxObjetivo8.Left += 30 + 14
            End If
        ElseIf DificultadElegida = 2 Then
            If DificultadMediaNivel = 1 Then
                PictureBoxObjetivo1.Left -= 20
                PictureBoxObjetivo2.Left += 30
                PictureBoxObjetivo3.Left -= 40
            ElseIf DificultadmediaNivel = 2 Then
                PictureBoxObjetivo1.Left -= 20 + 8
                PictureBoxObjetivo2.Left += 30 + 8
                PictureBoxObjetivo3.Left -= 40 + 8
            ElseIf DificultadmediaNivel = 3 Then
                PictureBoxObjetivo1.Left -= 20 + 10
                PictureBoxObjetivo2.Left += 30 + 10
                PictureBoxObjetivo3.Left -= 40 + 10
                PictureBoxObjetivo4.Left += 50 + 10
            ElseIf DificultadmediaNivel = 4 Then
                PictureBoxObjetivo1.Left -= 20 + 12
                PictureBoxObjetivo2.Left += 30 + 12
                PictureBoxObjetivo3.Left -= 40 + 12
                PictureBoxObjetivo4.Left += 50 + 12
            ElseIf DificultadmediaNivel = 5 Then
                PictureBoxObjetivo1.Left -= 20 + 14
                PictureBoxObjetivo2.Left += 30 + 14
                PictureBoxObjetivo3.Left -= 40 + 14
                PictureBoxObjetivo4.Left += 50 + 14
                PictureBoxObjetivo5.Left -= 20 + 14
            ElseIf DificultadmediaNivel = 6 Then
                PictureBoxObjetivo1.Left -= 20 + 16
                PictureBoxObjetivo2.Left += 30 + 16
                PictureBoxObjetivo3.Left -= 40 + 16
                PictureBoxObjetivo4.Left += 50 + 16
                PictureBoxObjetivo5.Left -= 40 + 16
            ElseIf DificultadmediaNivel = 7 Then
                PictureBoxObjetivo1.Left -= 20 + 18
                PictureBoxObjetivo2.Left += 30 + 18
                PictureBoxObjetivo3.Left -= 40 + 18
                PictureBoxObjetivo4.Left += 50 + 18
                PictureBoxObjetivo5.Left -= 40 + 18
            ElseIf DificultadmediaNivel = 8 Then
                PictureBoxObjetivo1.Left -= 20 + 20
                PictureBoxObjetivo2.Left += 30 + 20
                PictureBoxObjetivo3.Left -= 40 + 20
                PictureBoxObjetivo4.Left += 50 + 20
                PictureBoxObjetivo5.Left -= 20 + 20
                PictureBoxObjetivo6.Left += 30 + 20
            ElseIf DificultadmediaNivel = 9 Then
                PictureBoxObjetivo1.Left -= 20 + 22
                PictureBoxObjetivo2.Left += 30 + 22
                PictureBoxObjetivo3.Left -= 40 + 22
                PictureBoxObjetivo4.Left += 50 + 22
                PictureBoxObjetivo5.Left -= 20 + 22
                PictureBoxObjetivo6.Left += 20 + 22
                PictureBoxObjetivo7.Left -= 20 + 22
            ElseIf DificultadmediaNivel = 10 Then
                PictureBoxObjetivo1.Left -= 20 + 24
                PictureBoxObjetivo2.Left += 30 + 24
                PictureBoxObjetivo3.Left -= 40 + 24
                PictureBoxObjetivo4.Left += 20 + 24
                PictureBoxObjetivo5.Left -= 30 + 24
                PictureBoxObjetivo6.Left += 40 + 24
                PictureBoxObjetivo7.Left -= 20 + 24
                PictureBoxObjetivo8.Left += 30 + 24
            End If
        ElseIf DificultadElegida = 3 Then
            If DificultadAltaNivel = 1 Then
                PictureBoxObjetivo1.Left -= 20
                PictureBoxObjetivo2.Left += 30
                PictureBoxObjetivo3.Left -= 40
            ElseIf DificultadaltaNivel = 2 Then
                PictureBoxObjetivo1.Left -= 20 + 10
                PictureBoxObjetivo2.Left += 30 + 10
                PictureBoxObjetivo3.Left -= 40 + 10
            ElseIf DificultadaltaNivel = 3 Then
                PictureBoxObjetivo1.Left -= 20 + 15
                PictureBoxObjetivo2.Left += 30 + 15
                PictureBoxObjetivo3.Left -= 40 + 15
                PictureBoxObjetivo4.Left += 50 + 15
            ElseIf DificultadaltaNivel = 4 Then
                PictureBoxObjetivo1.Left -= 20 + 20
                PictureBoxObjetivo2.Left += 30 + 20
                PictureBoxObjetivo3.Left -= 40 + 20
                PictureBoxObjetivo4.Left += 50 + 20
            ElseIf DificultadaltaNivel = 5 Then
                PictureBoxObjetivo1.Left -= 20 + 25
                PictureBoxObjetivo2.Left += 30 + 25
                PictureBoxObjetivo3.Left -= 40 + 25
                PictureBoxObjetivo4.Left += 50 + 25
                PictureBoxObjetivo5.Left -= 20 + 25
            ElseIf DificultadaltaNivel = 6 Then
                PictureBoxObjetivo1.Left -= 20 + 30
                PictureBoxObjetivo2.Left += 30 + 30
                PictureBoxObjetivo3.Left -= 40 + 30
                PictureBoxObjetivo4.Left += 50 + 30
                PictureBoxObjetivo5.Left -= 40 + 30
            ElseIf DificultadaltaNivel = 7 Then
                PictureBoxObjetivo1.Left -= 20 + 35
                PictureBoxObjetivo2.Left += 30 + 35
                PictureBoxObjetivo3.Left -= 40 + 35
                PictureBoxObjetivo4.Left += 50 + 35
                PictureBoxObjetivo5.Left -= 40 + 35
            ElseIf DificultadaltaNivel = 8 Then
                PictureBoxObjetivo1.Left -= 20 + 40
                PictureBoxObjetivo2.Left += 30 + 40
                PictureBoxObjetivo3.Left -= 40 + 40
                PictureBoxObjetivo4.Left += 50 + 40
                PictureBoxObjetivo5.Left -= 20 + 40
                PictureBoxObjetivo6.Left += 30 + 40
            ElseIf DificultadaltaNivel = 9 Then
                PictureBoxObjetivo1.Left -= 20 + 45
                PictureBoxObjetivo2.Left += 30 + 45
                PictureBoxObjetivo3.Left -= 40 + 45
                PictureBoxObjetivo4.Left += 50 + 45
                PictureBoxObjetivo5.Left -= 20 + 45
                PictureBoxObjetivo6.Left += 20 + 45
                PictureBoxObjetivo7.Left -= 20 + 45
            ElseIf DificultadaltaNivel = 10 Then
                PictureBoxObjetivo1.Left -= 20 + 50
                PictureBoxObjetivo2.Left += 30 + 50
                PictureBoxObjetivo3.Left -= 40 + 50
                PictureBoxObjetivo4.Left += 20 + 50
                PictureBoxObjetivo5.Left -= 30 + 50
                PictureBoxObjetivo6.Left += 40 + 50
                PictureBoxObjetivo7.Left -= 20 + 50
                PictureBoxObjetivo8.Left += 30 + 50
            End If
        End If
    End Sub
    Private Sub PictureBoxObjetivo1_LocationChanged(sender As Object, e As EventArgs) Handles PictureBoxObjetivo1.LocationChanged
        If PictureBoxObjetivo1.Right <= Me.Left Then
            PictureBoxObjetivo1.Left = 0 + Me.Right
        End If
    End Sub
    Private Sub PictureBoxObjetivo2_LocationChanged(sender As Object, e As EventArgs) Handles PictureBoxObjetivo2.LocationChanged
        If PictureBoxObjetivo2.Left >= Me.Right Then
            PictureBoxObjetivo2.Left = 0 + Me.Left
        End If
    End Sub
    Private Sub PictureBoxObjetivo3_LocationChanged(sender As Object, e As EventArgs) Handles PictureBoxObjetivo3.LocationChanged
        If PictureBoxObjetivo3.Right <= Me.Left Then
            PictureBoxObjetivo3.Left = 0 + Me.Right
        End If
    End Sub
    Private Sub PictureBoxObjetivo4_LocationChanged(sender As Object, e As EventArgs) Handles PictureBoxObjetivo4.LocationChanged
        If PictureBoxObjetivo4.Left >= Me.Right Then
            PictureBoxObjetivo4.Left = 0 + Me.Left
        End If
    End Sub
    Private Sub PictureBoxObjetivo5_LocationChanged(sender As Object, e As EventArgs) Handles PictureBoxObjetivo5.LocationChanged
        If PictureBoxObjetivo5.Right <= Me.Left Then
            PictureBoxObjetivo5.Left = 0 + Me.Right
        End If
    End Sub
    Private Sub PictureBoxObjetivo6_LocationChanged(sender As Object, e As EventArgs) Handles PictureBoxObjetivo6.LocationChanged
        If PictureBoxObjetivo6.Left >= Me.Right Then
            PictureBoxObjetivo6.Left = 0 + Me.Left
        End If
    End Sub
    Private Sub PictureBoxObjetivo7_LocationChanged(sender As Object, e As EventArgs) Handles PictureBoxObjetivo7.LocationChanged
        If PictureBoxObjetivo7.Right <= Me.Left Then
            PictureBoxObjetivo7.Left = 0 + Me.Right
        End If
    End Sub
    Private Sub PictureBoxObjetivo8_LocationChanged(sender As Object, e As EventArgs) Handles PictureBoxObjetivo8.LocationChanged
        If PictureBoxObjetivo8.Left >= Me.Right Then
            PictureBoxObjetivo8.Left = 0 + Me.Left
        End If
    End Sub
    Private Sub PictureBoxObjetivo9_LocationChanged(sender As Object, e As EventArgs) Handles PictureBoxObjetivo9.LocationChanged
        If PictureBoxObjetivo9.Right <= Me.Left Then
            PictureBoxObjetivo9.Left = 0 + Me.Right
        End If
    End Sub
    Private Sub PictureBoxObjetivo10_LocationChanged(sender As Object, e As EventArgs) Handles PictureBoxObjetivo10.LocationChanged
        If PictureBoxObjetivo10.Left >= Me.Right Then
            PictureBoxObjetivo10.Left = 0 + Me.Left
        End If
    End Sub
    Private Sub PictureBoxObjetivo1_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo1.Click
        Timer1.Start()
        PictureBoxObjetivo1.Hide()
        ContCont += 1
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        PictureBox2.Location = PictureBoxObjetivo1.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo2_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo2.Click
        Timer1.Start()
        PictureBoxObjetivo2.Hide()
        ContCont += 1
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        PictureBox2.Location = PictureBoxObjetivo2.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo3Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo3.Click
        Timer1.Start()
        PictureBoxObjetivo3.Hide()
        ContCont += 1
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        PictureBox2.Location = PictureBoxObjetivo3.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo4_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo4.Click
        Timer1.Start()
        PictureBoxObjetivo4.Hide()
        ContCont += 1
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        PictureBox2.Location = PictureBoxObjetivo4.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo5_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo5.Click
        Timer1.Start()
        PictureBoxObjetivo5.Hide()
        ContCont += 1
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        PictureBox2.Location = PictureBoxObjetivo5.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo6_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo6.Click
        Timer1.Start()
        PictureBoxObjetivo6.Hide()
        ContCont += 1
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        PictureBox2.Location = PictureBoxObjetivo6.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo7Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo7.Click
        Timer1.Start()
        PictureBoxObjetivo7.Hide()
        ContCont += 1
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        PictureBox2.Location = PictureBoxObjetivo7.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo8_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo8.Click
        Timer1.Start()
        PictureBoxObjetivo8.Hide()
        ContCont += 1
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        PictureBox2.Location = PictureBoxObjetivo8.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo9_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo9.Click
        Timer1.Start()
        PictureBoxObjetivo9.Hide()
        ContCont += 1
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        PictureBox2.Location = PictureBoxObjetivo9.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo10_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo10.Click
        Timer1.Start()
        PictureBoxObjetivo10.Hide()
        ContCont += 1
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        PictureBox2.Location = PictureBoxObjetivo10.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo1.Click, PictureBoxObjetivo2.Click, PictureBoxObjetivo3.Click, PictureBoxObjetivo10.Click, PictureBoxObjetivo4.Click, PictureBoxObjetivo5.Click, PictureBoxObjetivo6.Click, PictureBoxObjetivo7.Click, PictureBoxObjetivo8.Click, PictureBoxObjetivo9.Click
        If ContCont = 1 Then
            LabelContador.Text = " 1/10 "
        ElseIf ContCont = 2 Then
            LabelContador.Text = " 2/10 "
        ElseIf ContCont = 3 Then
            LabelContador.Text = " 3/10 "
        ElseIf ContCont = 4 Then
            LabelContador.Text = " 4/10 "
        ElseIf ContCont = 5 Then
            LabelContador.Text = " 5/10 "
        ElseIf ContCont = 6 Then
            LabelContador.Text = " 6/10 "
        ElseIf ContCont = 7 Then
            LabelContador.Text = " 7/10 "
        ElseIf ContCont = 8 Then
            LabelContador.Text = " 8/10 "
        ElseIf ContCont = 9 Then
            LabelContador.Text = " 9/10 "
        ElseIf ContCont = 10 Then
            LabelContador.Text = "10/10 "
            TimerContador1.Start()
        End If
    End Sub


    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        TimerObjetivo1.Stop()
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.Drip_2, AudioPlayMode.Background)
        End If
        Result = MessageBox.Show("¿Estás seguro de que quieres volver al menú principal?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If Result = DialogResult.Yes Then
            If SoundOnOff = True Then
                My.Computer.Audio.Play(My.Resources.Drip_2, AudioPlayMode.Background)
            End If
            FormInicio.Show()
            Close()
        ElseIf Result = DialogResult.No Then
            If SoundOnOff = True Then
                My.Computer.Audio.Play(My.Resources.Drip_2, AudioPlayMode.Background)
            End If
            TimerObjetivo1.Start()
        End If
    End Sub
End Class