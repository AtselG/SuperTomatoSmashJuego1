﻿Public Class FormJugar
    Private Sub FormJugar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CursorSiNo = False Then
            Me.Cursor = New Cursor(Cursor1)
        ElseIf CursorSiNo = True Then
            If CursorCont = 1 Then
                Me.Cursor = New Cursor(Cursor1)
            ElseIf CursorCont = 2 Then
                Me.Cursor = New Cursor(Cursor5)
            ElseIf CursorCont = 3 Then
                Me.Cursor = New Cursor(Cursor6)
            ElseIf CursorCont = 4 Then
                Me.Cursor = New Cursor(Cursor7)
            End If
        End If
        If DificultadElegida = 1 Then
            DificultadBajaNivel = 1
        ElseIf DificultadElegida = 2 Then
            DificultadMediaNivel = 1
        ElseIf DificultadElegida = 3 Then
            DificultadAltaNivel = 1
        End If
        ContCont = 0
        LabelContador.Text = " 0 "
        TimerObjetivo1.Start()
        PictureBox2.Hide()
        PictureBoxObjetivo1.Hide()
        PictureBoxObjetivo2.Hide()
        PictureBoxObjetivo3.Hide()
        PictureBoxObjetivo4.Hide()
        PictureBoxObjetivo5.Hide()
        PictureBoxObjetivo6.Hide()
        PictureBoxObjetivo7.Hide()
        PictureBoxObjetivo8.Hide()
        PictureBoxObjetivo9.Hide()
        PictureBoxObjetivo10.Hide()
        PictureBoxObjetivo11.Hide()
        PictureBoxObjetivo12.Hide()
        PictureBoxObjetivo13.Hide()
        If DificultadElegida = 1 Then
            If DificultadBajaNivel = 1 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
            ElseIf DificultadBajaNivel = 2 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
            ElseIf DificultadBajaNivel = 3 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
            ElseIf DificultadBajaNivel = 4 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
            ElseIf DificultadBajaNivel = 5 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
            ElseIf DificultadBajaNivel = 6 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
            ElseIf DificultadBajaNivel = 7 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
            ElseIf DificultadBajaNivel = 8 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
                PictureBoxObjetivo6.Show()
            ElseIf DificultadBajaNivel = 9 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
                PictureBoxObjetivo6.Show()
                PictureBoxObjetivo7.Show()
            ElseIf DificultadBajaNivel = 10 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
                PictureBoxObjetivo6.Show()
                PictureBoxObjetivo7.Show()
                PictureBoxObjetivo8.Show()
            End If
        ElseIf DificultadElegida = 2 Then
            If DificultadMediaNivel = 1 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
            ElseIf DificultadMediaNivel = 2 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
            ElseIf DificultadMediaNivel = 3 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
            ElseIf DificultadMediaNivel = 4 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
            ElseIf DificultadMediaNivel = 5 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
                PictureBoxObjetivo6.Show()
            ElseIf DificultadMediaNivel = 6 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
                PictureBoxObjetivo6.Show()
            ElseIf DificultadMediaNivel = 7 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
                PictureBoxObjetivo6.Show()
                PictureBoxObjetivo7.Show()
            ElseIf DificultadMediaNivel = 8 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
                PictureBoxObjetivo6.Show()
                PictureBoxObjetivo7.Show()
                PictureBoxObjetivo8.Show()
            ElseIf DificultadMediaNivel = 9 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
                PictureBoxObjetivo6.Show()
                PictureBoxObjetivo7.Show()
                PictureBoxObjetivo8.Show()
                PictureBoxObjetivo9.Show()
            ElseIf DificultadMediaNivel = 10 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
                PictureBoxObjetivo6.Show()
                PictureBoxObjetivo7.Show()
                PictureBoxObjetivo8.Show()
                PictureBoxObjetivo9.Show()
                PictureBoxObjetivo10.Show()
            End If
        ElseIf DificultadElegida = 3 Then
            If DificultadAltaNivel = 1 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
            ElseIf DificultadAltaNivel = 2 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
            ElseIf DificultadAltaNivel = 3 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
                PictureBoxObjetivo6.Show()
            ElseIf DificultadAltaNivel = 4 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
                PictureBoxObjetivo6.Show()
                PictureBoxObjetivo7.Show()
            ElseIf DificultadAltaNivel = 5 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
                PictureBoxObjetivo6.Show()
                PictureBoxObjetivo7.Show()
                PictureBoxObjetivo8.Show()
            ElseIf DificultadAltaNivel = 6 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
                PictureBoxObjetivo6.Show()
                PictureBoxObjetivo7.Show()
                PictureBoxObjetivo8.Show()
                PictureBoxObjetivo9.Show()
            ElseIf DificultadAltaNivel = 7 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
                PictureBoxObjetivo6.Show()
                PictureBoxObjetivo7.Show()
                PictureBoxObjetivo8.Show()
                PictureBoxObjetivo9.Show()
                PictureBoxObjetivo10.Show()
            ElseIf DificultadAltaNivel = 8 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
                PictureBoxObjetivo6.Show()
                PictureBoxObjetivo7.Show()
                PictureBoxObjetivo8.Show()
                PictureBoxObjetivo9.Show()
                PictureBoxObjetivo10.Show()
                PictureBoxObjetivo11.Show()
            ElseIf DificultadAltaNivel = 9 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
                PictureBoxObjetivo6.Show()
                PictureBoxObjetivo7.Show()
                PictureBoxObjetivo8.Show()
                PictureBoxObjetivo9.Show()
                PictureBoxObjetivo10.Show()
                PictureBoxObjetivo11.Show()
                PictureBoxObjetivo12.Show()
            ElseIf DificultadAltaNivel = 10 Then
                PictureBoxObjetivo1.Show()
                PictureBoxObjetivo2.Show()
                PictureBoxObjetivo3.Show()
                PictureBoxObjetivo4.Show()
                PictureBoxObjetivo5.Show()
                PictureBoxObjetivo6.Show()
                PictureBoxObjetivo7.Show()
                PictureBoxObjetivo8.Show()
                PictureBoxObjetivo9.Show()
                PictureBoxObjetivo10.Show()
                PictureBoxObjetivo11.Show()
                PictureBoxObjetivo12.Show()
                PictureBoxObjetivo13.Show()
            End If
        End If
    End Sub

    Private Sub TimerContador1_Tick(sender As Object, e As EventArgs) Handles TimerContador1.Tick
        ContInfo += 1
        TimerContador1.Stop()
        If ContInfo = 1 And DificultadBajaNivel = 1 Or DificultadMediaNivel = 1 Or DificultadAltaNivel = 1 Then
            Info1.ShowDialog(owner:=Me)
        ElseIf ContInfo = 2 And DificultadBajaNivel = 2 Or DificultadMediaNivel = 2 Or DificultadAltaNivel = 2 Then
            Info2.ShowDialog(owner:=Me)
        ElseIf ContInfo = 3 And DificultadBajaNivel = 3 Or DificultadMediaNivel = 3 Or DificultadAltaNivel = 3 Then
            Info3.ShowDialog(owner:=Me)
        ElseIf ContInfo = 4 And DificultadBajaNivel = 4 Or DificultadMediaNivel = 4 Or DificultadAltaNivel = 4 Then
            Info4.ShowDialog(owner:=Me)
        ElseIf ContInfo = 5 And DificultadBajaNivel = 5 Or DificultadMediaNivel = 5 Or DificultadAltaNivel = 5 Then
            Info5.ShowDialog(owner:=Me)
        ElseIf ContInfo = 6 And DificultadBajaNivel = 6 Or DificultadMediaNivel = 6 Or DificultadAltaNivel = 6 Then
            Info6.ShowDialog(owner:=Me)
        ElseIf ContInfo = 7 And DificultadBajaNivel = 7 Or DificultadMediaNivel = 7 Or DificultadAltaNivel = 7 Then
            info7.ShowDialog(owner:=Me)
        ElseIf ContInfo = 8 And DificultadBajaNivel = 8 Or DificultadMediaNivel = 8 Or DificultadAltaNivel = 8 Then
            Info8.ShowDialog(owner:=Me)
        ElseIf ContInfo = 9 And DificultadBajaNivel = 9 Or DificultadMediaNivel = 9 Or DificultadAltaNivel = 9 Then
            Info9.ShowDialog(owner:=Me)
        ElseIf ContInfo = 10 And DificultadBajaNivel = 10 Or DificultadMediaNivel = 10 Or DificultadAltaNivel = 10 Then
            Info10.ShowDialog(owner:=Me)
        ElseIf ContInfo = 11 Then
            ContInfo = 1
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox2.Hide()
    End Sub
    'Acá se mueven los objetivos
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
                PictureBoxObjetivo4.Left += 50
            ElseIf DificultadMediaNivel = 2 Then
                PictureBoxObjetivo1.Left -= 20 + 8
                PictureBoxObjetivo2.Left += 30 + 8
                PictureBoxObjetivo3.Left -= 40 + 8
                PictureBoxObjetivo4.Left += 50 + 8
            ElseIf DificultadMediaNivel = 3 Then
                PictureBoxObjetivo1.Left -= 20 + 10
                PictureBoxObjetivo2.Left += 30 + 10
                PictureBoxObjetivo3.Left -= 40 + 10
                PictureBoxObjetivo4.Left += 20 + 10
                PictureBoxObjetivo5.Left -= 30 + 10
            ElseIf DificultadMediaNivel = 4 Then
                PictureBoxObjetivo1.Left -= 20 + 12
                PictureBoxObjetivo2.Left += 30 + 12
                PictureBoxObjetivo3.Left -= 40 + 12
                PictureBoxObjetivo4.Left += 20 + 12
                PictureBoxObjetivo5.Left -= 30 + 12
            ElseIf DificultadMediaNivel = 5 Then
                PictureBoxObjetivo1.Left -= 20 + 14
                PictureBoxObjetivo2.Left += 30 + 14
                PictureBoxObjetivo3.Left -= 40 + 14
                PictureBoxObjetivo4.Left += 20 + 14
                PictureBoxObjetivo5.Left -= 30 + 14
                PictureBoxObjetivo6.Left += 40 + 14
            ElseIf DificultadMediaNivel = 6 Then
                PictureBoxObjetivo1.Left -= 20 + 16
                PictureBoxObjetivo2.Left += 30 + 16
                PictureBoxObjetivo3.Left -= 40 + 16
                PictureBoxObjetivo4.Left += 20 + 16
                PictureBoxObjetivo5.Left -= 30 + 16
                PictureBoxObjetivo6.Left += 40 + 16
            ElseIf DificultadMediaNivel = 7 Then
                PictureBoxObjetivo1.Left -= 20 + 18
                PictureBoxObjetivo2.Left += 30 + 18
                PictureBoxObjetivo3.Left -= 40 + 18
                PictureBoxObjetivo4.Left += 20 + 18
                PictureBoxObjetivo5.Left -= 30 + 18
                PictureBoxObjetivo6.Left += 40 + 18
                PictureBoxObjetivo7.Left -= 20 + 18
            ElseIf DificultadMediaNivel = 8 Then
                PictureBoxObjetivo1.Left -= 20 + 20
                PictureBoxObjetivo2.Left += 30 + 20
                PictureBoxObjetivo3.Left -= 40 + 20
                PictureBoxObjetivo4.Left += 20 + 20
                PictureBoxObjetivo5.Left -= 30 + 20
                PictureBoxObjetivo6.Left += 40 + 20
                PictureBoxObjetivo7.Left -= 20 + 20
                PictureBoxObjetivo8.Left += 30 + 20
            ElseIf DificultadMediaNivel = 9 Then
                PictureBoxObjetivo1.Left -= 20 + 22
                PictureBoxObjetivo2.Left += 30 + 22
                PictureBoxObjetivo3.Left -= 40 + 22
                PictureBoxObjetivo4.Left += 20 + 22
                PictureBoxObjetivo5.Left -= 30 + 22
                PictureBoxObjetivo6.Left += 40 + 22
                PictureBoxObjetivo7.Left -= 20 + 22
                PictureBoxObjetivo8.Left += 30 + 22
                PictureBoxObjetivo9.Left -= 20 + 22
            ElseIf DificultadMediaNivel = 10 Then
                PictureBoxObjetivo1.Left -= 20 + 24
                PictureBoxObjetivo2.Left += 30 + 24
                PictureBoxObjetivo3.Left -= 40 + 24
                PictureBoxObjetivo4.Left += 20 + 24
                PictureBoxObjetivo5.Left -= 30 + 24
                PictureBoxObjetivo6.Left += 40 + 24
                PictureBoxObjetivo7.Left -= 20 + 24
                PictureBoxObjetivo8.Left += 30 + 24
                PictureBoxObjetivo9.Left -= 20 + 24
                PictureBoxObjetivo10.Left += 30 + 24
            End If
        ElseIf DificultadElegida = 3 Then
            If DificultadAltaNivel = 1 Then
                PictureBoxObjetivo1.Left -= 20 + 10
                PictureBoxObjetivo2.Left += 30 + 10
                PictureBoxObjetivo3.Left -= 40 + 10
                PictureBoxObjetivo4.Left += 20 + 10
            ElseIf DificultadAltaNivel = 2 Then
                PictureBoxObjetivo1.Left -= 20 + 20
                PictureBoxObjetivo2.Left += 30 + 20
                PictureBoxObjetivo3.Left -= 40 + 20
                PictureBoxObjetivo4.Left += 20 + 20
                PictureBoxObjetivo5.Left -= 30 + 20
            ElseIf DificultadAltaNivel = 3 Then
                PictureBoxObjetivo1.Left -= 20 + 30
                PictureBoxObjetivo2.Left += 30 + 30
                PictureBoxObjetivo3.Left -= 40 + 30
                PictureBoxObjetivo4.Left += 20 + 30
                PictureBoxObjetivo5.Left -= 30 + 30
                PictureBoxObjetivo6.Left += 40 + 30
            ElseIf DificultadAltaNivel = 4 Then
                PictureBoxObjetivo1.Left -= 20 + 40
                PictureBoxObjetivo2.Left += 30 + 40
                PictureBoxObjetivo3.Left -= 40 + 40
                PictureBoxObjetivo4.Left += 20 + 40
                PictureBoxObjetivo5.Left -= 30 + 40
                PictureBoxObjetivo6.Left += 40 + 40
                PictureBoxObjetivo7.Left -= 20 + 40
            ElseIf DificultadAltaNivel = 5 Then
                PictureBoxObjetivo1.Left -= 20 + 50
                PictureBoxObjetivo2.Left += 30 + 50
                PictureBoxObjetivo3.Left -= 40 + 50
                PictureBoxObjetivo4.Left += 20 + 50
                PictureBoxObjetivo5.Left -= 30 + 50
                PictureBoxObjetivo6.Left += 40 + 50
                PictureBoxObjetivo7.Left -= 20 + 50
                PictureBoxObjetivo8.Left += 30 + 50
            ElseIf DificultadAltaNivel = 6 Then
                PictureBoxObjetivo1.Left -= 20 + 60
                PictureBoxObjetivo2.Left += 30 + 60
                PictureBoxObjetivo3.Left -= 40 + 60
                PictureBoxObjetivo4.Left += 20 + 60
                PictureBoxObjetivo5.Left -= 30 + 60
                PictureBoxObjetivo6.Left += 40 + 60
                PictureBoxObjetivo7.Left -= 20 + 60
                PictureBoxObjetivo8.Left += 30 + 60
                PictureBoxObjetivo9.Left -= 20 + 60
            ElseIf DificultadAltaNivel = 7 Then
                PictureBoxObjetivo1.Left -= 20 + 70
                PictureBoxObjetivo2.Left += 30 + 70
                PictureBoxObjetivo3.Left -= 40 + 70
                PictureBoxObjetivo4.Left += 20 + 70
                PictureBoxObjetivo5.Left -= 30 + 70
                PictureBoxObjetivo6.Left += 40 + 70
                PictureBoxObjetivo7.Left -= 20 + 70
                PictureBoxObjetivo8.Left += 30 + 70
                PictureBoxObjetivo9.Left -= 20 + 70
                PictureBoxObjetivo10.Left += 40 + 70
            ElseIf DificultadAltaNivel = 8 Then
                PictureBoxObjetivo1.Left -= 20 + 80
                PictureBoxObjetivo2.Left += 30 + 80
                PictureBoxObjetivo3.Left -= 40 + 80
                PictureBoxObjetivo4.Left += 20 + 80
                PictureBoxObjetivo5.Left -= 30 + 80
                PictureBoxObjetivo6.Left += 40 + 80
                PictureBoxObjetivo7.Left -= 20 + 80
                PictureBoxObjetivo8.Left += 30 + 80
                PictureBoxObjetivo9.Left -= 20 + 80
                PictureBoxObjetivo10.Left += 40 + 80
                PictureBoxObjetivo11.Left += 30 + 80
            ElseIf DificultadAltaNivel = 9 Then
                PictureBoxObjetivo1.Left -= 20 + 90
                PictureBoxObjetivo2.Left += 30 + 90
                PictureBoxObjetivo3.Left -= 40 + 90
                PictureBoxObjetivo4.Left += 20 + 90
                PictureBoxObjetivo5.Left -= 30 + 90
                PictureBoxObjetivo6.Left += 40 + 90
                PictureBoxObjetivo7.Left -= 20 + 90
                PictureBoxObjetivo8.Left += 30 + 90
                PictureBoxObjetivo9.Left -= 20 + 90
                PictureBoxObjetivo10.Left += 40 + 90
                PictureBoxObjetivo11.Left += 30 + 90
                PictureBoxObjetivo12.Left -= 50 + 90
            ElseIf DificultadAltaNivel = 10 Then
                PictureBoxObjetivo1.Left -= 20 + 100
                PictureBoxObjetivo2.Left += 30 + 100
                PictureBoxObjetivo3.Left -= 40 + 100
                PictureBoxObjetivo4.Left += 20 + 100
                PictureBoxObjetivo5.Left -= 30 + 100
                PictureBoxObjetivo6.Left += 40 + 100
                PictureBoxObjetivo7.Left -= 20 + 100
                PictureBoxObjetivo8.Left += 30 + 100
                PictureBoxObjetivo9.Left -= 20 + 100
                PictureBoxObjetivo10.Left += 40 + 100
                PictureBoxObjetivo11.Left += 30 + 100
                PictureBoxObjetivo12.Left -= 50 + 100
                PictureBoxObjetivo13.Left += 30 + 100
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
    Private Sub PictureBoxObjetivo11_LocationChanged(sender As Object, e As EventArgs) Handles PictureBoxObjetivo11.LocationChanged
        If PictureBoxObjetivo10.Right >= Me.Left Then
            PictureBoxObjetivo10.Left = 0 + Me.Right
        End If
    End Sub
    Private Sub PictureBoxObjetivo12_LocationChanged(sender As Object, e As EventArgs) Handles PictureBoxObjetivo12.LocationChanged
        If PictureBoxObjetivo10.Left >= Me.Right Then
            PictureBoxObjetivo10.Left = 0 + Me.Left
        End If
    End Sub
    Private Sub PictureBoxObjetivo13_LocationChanged(sender As Object, e As EventArgs) Handles PictureBoxObjetivo13.LocationChanged
        If PictureBoxObjetivo10.Right >= Me.Left Then
            PictureBoxObjetivo10.Left = 0 + Me.Right
        End If
    End Sub
    Private Sub PictureBoxObjetivo1_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo1.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        Timer1.Start()
        PictureBoxObjetivo1.Hide()
        ContCont += 1
        PictureBox2.Location = PictureBoxObjetivo1.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo2_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo2.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        Timer1.Start()
        PictureBoxObjetivo2.Hide()
        ContCont += 1
        PictureBox2.Location = PictureBoxObjetivo2.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo3Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo3.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        Timer1.Start()
        PictureBoxObjetivo3.Hide()
        ContCont += 1
        PictureBox2.Location = PictureBoxObjetivo3.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo4_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo4.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        Timer1.Start()
        PictureBoxObjetivo4.Hide()
        ContCont += 1
        PictureBox2.Location = PictureBoxObjetivo4.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo5_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo5.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        Timer1.Start()
        PictureBoxObjetivo5.Hide()
        ContCont += 1
        PictureBox2.Location = PictureBoxObjetivo5.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo6_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo6.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        Timer1.Start()
        PictureBoxObjetivo6.Hide()
        ContCont += 1
        PictureBox2.Location = PictureBoxObjetivo6.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo7Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo7.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        Timer1.Start()
        PictureBoxObjetivo7.Hide()
        ContCont += 1
        PictureBox2.Location = PictureBoxObjetivo7.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo8_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo8.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        Timer1.Start()
        PictureBoxObjetivo8.Hide()
        ContCont += 1
        PictureBox2.Location = PictureBoxObjetivo8.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo9_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo9.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        Timer1.Start()
        PictureBoxObjetivo9.Hide()
        ContCont += 1
        PictureBox2.Location = PictureBoxObjetivo9.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo10_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo10.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        Timer1.Start()
        PictureBoxObjetivo10.Hide()
        ContCont += 1
        PictureBox2.Location = PictureBoxObjetivo10.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo11_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo11.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        Timer1.Start()
        PictureBoxObjetivo11.Hide()
        ContCont += 1
        PictureBox2.Location = PictureBoxObjetivo11.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo12_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo12.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        Timer1.Start()
        PictureBoxObjetivo12.Hide()
        ContCont += 1
        PictureBox2.Location = PictureBoxObjetivo12.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo13_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo13.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.LaserSound1, AudioPlayMode.Background)
        End If
        Timer1.Start()
        PictureBoxObjetivo13.Hide()
        ContCont += 1
        PictureBox2.Location = PictureBoxObjetivo13.Location
        PictureBox2.Show()
    End Sub
    Private Sub PictureBoxObjetivo_Click(sender As Object, e As EventArgs) Handles PictureBoxObjetivo1.Click, PictureBoxObjetivo2.Click, PictureBoxObjetivo3.Click, PictureBoxObjetivo10.Click, PictureBoxObjetivo4.Click, PictureBoxObjetivo5.Click, PictureBoxObjetivo6.Click, PictureBoxObjetivo7.Click, PictureBoxObjetivo8.Click, PictureBoxObjetivo9.Click, PictureBoxObjetivo11.Click, PictureBoxObjetivo12.Click, PictureBoxObjetivo13.Click
        If DificultadElegida = 1 Then
            Score += 20
            LabelContador.Text = Score
            If DificultadBajaNivel = 1 Then
                If LabelContador.Text = 60 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadBajaNivel = 2 Then
                If LabelContador.Text = 120 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadBajaNivel = 3 Then
                If LabelContador.Text = 200 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadBajaNivel = 4 Then
                If LabelContador.Text = 280 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadBajaNivel = 5 Then
                If LabelContador.Text = 380 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadBajaNivel = 6 Then
                If LabelContador.Text = 480 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadBajaNivel = 7 Then
                If LabelContador.Text = 580 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadBajaNivel = 8 Then
                If LabelContador.Text = 700 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadBajaNivel = 9 Then
                If LabelContador.Text = 840 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadBajaNivel = 10 Then
                If LabelContador.Text = 1000 Then
                    TimerContador1.Start()
                End If
            End If
        ElseIf DificultadElegida = 2 Then
            Score += 10
            LabelContador.Text = Score
            If DificultadMediaNivel = 1 Then
                If LabelContador.Text = 40 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadMediaNivel = 2 Then
                If LabelContador.Text = 40 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadMediaNivel = 3 Then
                If LabelContador.Text = 50 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadMediaNivel = 4 Then
                If LabelContador.Text = 50 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadMediaNivel = 5 Then
                If LabelContador.Text = 60 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadMediaNivel = 6 Then
                If LabelContador.Text = 60 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadMediaNivel = 7 Then
                If LabelContador.Text = 70 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadMediaNivel = 8 Then
                If LabelContador.Text = 80 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadMediaNivel = 9 Then
                If LabelContador.Text = 90 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadMediaNivel = 10 Then
                If LabelContador.Text = 100 Then
                    TimerContador1.Start()
                End If
            End If
        ElseIf DificultadElegida = 3 Then
            Score += 5
            LabelContador.Text = Score
            If DificultadAltaNivel = 1 Then
                If LabelContador.Text = 20 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadAltaNivel = 2 Then
                If LabelContador.Text = 25 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadAltaNivel = 3 Then
                If LabelContador.Text = 30 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadAltaNivel = 4 Then
                If LabelContador.Text = 35 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadAltaNivel = 5 Then
                If LabelContador.Text = 40 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadAltaNivel = 6 Then
                If LabelContador.Text = 45 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadAltaNivel = 7 Then
                If LabelContador.Text = 50 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadAltaNivel = 8 Then
                If LabelContador.Text = 55 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadAltaNivel = 9 Then
                If LabelContador.Text = 60 Then
                    TimerContador1.Start()
                End If
            ElseIf DificultadAltaNivel = 10 Then
                If LabelContador.Text = 65 Then
                    TimerContador1.Start()
                End If
            End If
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
            Hide()
        ElseIf Result = DialogResult.No Then
            If SoundOnOff = True Then
                My.Computer.Audio.Play(My.Resources.Drip_2, AudioPlayMode.Background)
            End If
            TimerObjetivo1.Start()
        End If
    End Sub
End Class