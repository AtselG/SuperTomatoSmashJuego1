Module ModuleVariables
    Public Cursor1 As New System.IO.MemoryStream(My.Resources.Cursor1cur)
    Public Cursor5 As New System.IO.MemoryStream(My.Resources.Cursor5cur)
    Public Cursor6 As New System.IO.MemoryStream(My.Resources.Cursor6cur)
    Public Cursor7 As New System.IO.MemoryStream(My.Resources.Cursor7cur)
    Public Cursor8 As New System.IO.MemoryStream(My.Resources.Cursor8cur)
    Public Cursor9 As New System.IO.MemoryStream(My.Resources.Cursor9cur)
    Public Cursor10 As New System.IO.MemoryStream(My.Resources.Cursor10cur)
    Public Cursor11 As New System.IO.MemoryStream(My.Resources.Cursor11cur)
    Public CursorOpciones As Byte 'Var para almacenar cursor
    Public CursorCont As Integer 'Variable para cambiar cursor en FormOpciones
    Public CursorSiNo As Boolean 'Var para activar cursor
    Public ContCont As Integer 'Contador utilizado para el contador de objetivos
    Public ContInfo As Integer 'Contador utilizado para los cuadros de información
    Public SoundOnOff As Boolean 'Variable para el sonido
    Public Result As DialogResult 'Messagebox
    Public msgboxresponse As MsgBoxResult
    Public DificultadElegida As Integer
    Public DificultadBajaNivel As Integer
    Public DificultadMediaNivel As Integer
    Public DificultadAltaNivel As Integer
    Public Score As Integer = 0
    Public ClosePermission1 As Boolean 'Permiso para cerrar la información
    Public ClosePermission2 As Boolean = True 'lode arriba
    Public ClosePermission3 As Boolean = True 'lode arriba
    Public ClosePermission4 As Boolean = True 'lode arriba
    Public ClosePermission5 As Boolean = True 'lode arriba
    Public ClosePermission6 As Boolean = True 'lode arriba
    Public ClosePermission7 As Boolean = True 'lode arriba
    Public ClosePermission8 As Boolean = True 'lode arriba
    Public ClosePermission9 As Boolean = True 'lode arriba
    Public ClosePermission10 As Boolean = True 'lode arriba
End Module
