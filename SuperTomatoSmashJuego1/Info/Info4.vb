Public Class Info4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormInicio.Show()
        FormJugar.Close()
        Close()
    End Sub
End Class