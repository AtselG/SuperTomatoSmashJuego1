Public Class Info1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Info2.ShowDialog(owner:=FormJugar)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

        FormJugar.LabelContador.Text = " 0/10 "
        ContCont = 0
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            msgboxresponse = MsgBox("¿Estás seguro de qué quieres volver al menú principal?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text)
            If msgboxresponse = MsgBoxResult.Yes Then
                e.Cancel = False
                FormInicio.Show()
                FormJugar.Close()
            ElseIf msgboxresponse = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Info1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class