Public Class Info3
    Private Sub Info1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClosePermission3 = True
        Info2.Hide()
        Me.Icon = (My.Resources.Icono)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClosePermission2 = True
        ClosePermission3 = False
        Hide()
        Info2.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClosePermission3 = False
        Info4.ShowDialog(owner:=FormJugar)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DificultadElegida = 1 Then
            If DificultadBajaNivel = 1 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
            ElseIf DificultadBajaNivel = 2 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
            ElseIf DificultadBajaNivel = 3 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
            ElseIf DificultadBajaNivel = 4 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
            ElseIf DificultadBajaNivel = 5 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
            ElseIf DificultadBajaNivel = 6 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
            ElseIf DificultadBajaNivel = 7 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
            ElseIf DificultadBajaNivel = 8 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
                FormJugar.PictureBoxObjetivo6.Show()
            ElseIf DificultadBajaNivel = 9 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
                FormJugar.PictureBoxObjetivo6.Show()
                FormJugar.PictureBoxObjetivo7.Show()
            ElseIf DificultadBajaNivel = 10 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
                FormJugar.PictureBoxObjetivo6.Show()
                FormJugar.PictureBoxObjetivo7.Show()
                FormJugar.PictureBoxObjetivo8.Show()
            End If
        ElseIf DificultadElegida = 2 Then
            If DificultadMediaNivel = 1 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
            ElseIf DificultadMediaNivel = 2 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
            ElseIf DificultadMediaNivel = 3 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
            ElseIf DificultadMediaNivel = 4 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
            ElseIf DificultadMediaNivel = 5 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
                FormJugar.PictureBoxObjetivo6.Show()
            ElseIf DificultadMediaNivel = 6 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
                FormJugar.PictureBoxObjetivo6.Show()
            ElseIf DificultadMediaNivel = 7 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
                FormJugar.PictureBoxObjetivo6.Show()
                FormJugar.PictureBoxObjetivo7.Show()
            ElseIf DificultadMediaNivel = 8 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
                FormJugar.PictureBoxObjetivo6.Show()
                FormJugar.PictureBoxObjetivo7.Show()
                FormJugar.PictureBoxObjetivo8.Show()
            ElseIf DificultadMediaNivel = 9 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
                FormJugar.PictureBoxObjetivo6.Show()
                FormJugar.PictureBoxObjetivo7.Show()
                FormJugar.PictureBoxObjetivo8.Show()
                FormJugar.PictureBoxObjetivo9.Show()
            ElseIf DificultadMediaNivel = 10 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
                FormJugar.PictureBoxObjetivo6.Show()
                FormJugar.PictureBoxObjetivo7.Show()
                FormJugar.PictureBoxObjetivo8.Show()
                FormJugar.PictureBoxObjetivo9.Show()
                FormJugar.PictureBoxObjetivo10.Show()
            End If
        ElseIf DificultadElegida = 3 Then
            If DificultadAltaNivel = 1 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
            ElseIf DificultadAltaNivel = 2 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
            ElseIf DificultadAltaNivel = 3 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
                FormJugar.PictureBoxObjetivo6.Show()
            ElseIf DificultadAltaNivel = 4 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
                FormJugar.PictureBoxObjetivo6.Show()
                FormJugar.PictureBoxObjetivo7.Show()
            ElseIf DificultadAltaNivel = 5 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
                FormJugar.PictureBoxObjetivo6.Show()
                FormJugar.PictureBoxObjetivo7.Show()
                FormJugar.PictureBoxObjetivo8.Show()
            ElseIf DificultadAltaNivel = 6 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
                FormJugar.PictureBoxObjetivo6.Show()
                FormJugar.PictureBoxObjetivo7.Show()
                FormJugar.PictureBoxObjetivo8.Show()
                FormJugar.PictureBoxObjetivo9.Show()
            ElseIf DificultadAltaNivel = 7 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
                FormJugar.PictureBoxObjetivo6.Show()
                FormJugar.PictureBoxObjetivo7.Show()
                FormJugar.PictureBoxObjetivo8.Show()
                FormJugar.PictureBoxObjetivo9.Show()
                FormJugar.PictureBoxObjetivo10.Show()
            ElseIf DificultadAltaNivel = 8 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
                FormJugar.PictureBoxObjetivo6.Show()
                FormJugar.PictureBoxObjetivo7.Show()
                FormJugar.PictureBoxObjetivo8.Show()
                FormJugar.PictureBoxObjetivo9.Show()
                FormJugar.PictureBoxObjetivo10.Show()
                FormJugar.PictureBoxObjetivo11.Show()
            ElseIf DificultadAltaNivel = 9 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
                FormJugar.PictureBoxObjetivo6.Show()
                FormJugar.PictureBoxObjetivo7.Show()
                FormJugar.PictureBoxObjetivo8.Show()
                FormJugar.PictureBoxObjetivo9.Show()
                FormJugar.PictureBoxObjetivo10.Show()
                FormJugar.PictureBoxObjetivo11.Show()
                FormJugar.PictureBoxObjetivo12.Show()
            ElseIf DificultadAltaNivel = 10 Then
                FormJugar.PictureBoxObjetivo1.Show()
                FormJugar.PictureBoxObjetivo2.Show()
                FormJugar.PictureBoxObjetivo3.Show()
                FormJugar.PictureBoxObjetivo4.Show()
                FormJugar.PictureBoxObjetivo5.Show()
                FormJugar.PictureBoxObjetivo6.Show()
                FormJugar.PictureBoxObjetivo7.Show()
                FormJugar.PictureBoxObjetivo8.Show()
                FormJugar.PictureBoxObjetivo9.Show()
                FormJugar.PictureBoxObjetivo10.Show()
                FormJugar.PictureBoxObjetivo11.Show()
                FormJugar.PictureBoxObjetivo12.Show()
                FormJugar.PictureBoxObjetivo13.Show()
            End If
        End If
        FormJugar.LabelContador.Text = " 0 "
        ContCont = 0
        If DificultadElegida = 1 Then
            DificultadBajaNivel += 1
        ElseIf DificultadElegida = 2 Then
            DificultadMediaNivel += 1
        ElseIf DificultadElegida = 3 Then
            DificultadAltaNivel += 1
        End If
        Hide()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim msgboxresponse As MsgBoxResult
        If ClosePermission3 = True Then
            If e.CloseReason = CloseReason.UserClosing Then
                msgboxresponse = MsgBox("¿Deseas volver al menú principal?",
                                    MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text)
                If msgboxresponse = MsgBoxResult.Yes Then
                    FormInicio.Show()
                    FormJugar.Close()
                ElseIf msgboxresponse = MsgBoxResult.No Then
                    e.Cancel = True
                End If
            End If
        ElseIf ClosePermission3 = False Then
            e.Cancel = True
        End If
    End Sub
End Class