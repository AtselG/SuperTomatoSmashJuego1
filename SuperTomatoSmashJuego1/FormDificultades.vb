Imports MaterialSkin
Public Class FormDificultades
    Private Sub FormDificultades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        DificultadElegida = 1
        DificultadBajaNivel = 1
        FormJugar.Show()
        FormInicio.Hide()
        Close()
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        DificultadElegida = 2
        DificultadMediaNivel = 1
        FormJugar.Show()
        FormInicio.Hide()
        Close()
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        DificultadElegida = 3
        DificultadAltaNivel = 1
        FormJugar.Show()
        FormInicio.Hide()
        Close()
    End Sub
End Class