Public Class InfoGanar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormJugar.Hide()
        Close()
        FormInicio.Show()
    End Sub
    Private Sub Info2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "El puntaje que has acumulado es: " & Score
        Info10.Hide()
        Me.Icon = (My.Resources.Icono)
    End Sub
End Class