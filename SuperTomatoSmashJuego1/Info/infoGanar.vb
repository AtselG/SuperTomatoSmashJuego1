Public Class InfoGanar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormInicio.Show()
        Close()
        FormJugar.Close()
    End Sub
    Private Sub Info2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = (My.Resources.Icono)
    End Sub
End Class