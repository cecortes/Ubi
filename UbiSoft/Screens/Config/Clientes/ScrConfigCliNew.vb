'Imports
Imports UbiDll
Imports SpreadsheetLight

Public Class ScrConfigCliNew

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim add As New Agregar
    Dim upd As New Actualizar
    Dim errorMsg As New ErrorMsg

#End Region

#Region "Funciones"

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Re inicia los valores de los textbox
    ''' </summary>
    Private Sub ClearTxt()

        'Txt
        TxtRfcNew.Text = ""
        TxtRazonNew.Text = ""
        TxtMailNew.Text = ""
        TxtContactoNew.Text = ""
        TxtTelNew.Text = ""
        TxtDirNew.Text = ""
        TxtCiudadNew.Text = ""
        TxtEdoNew.Text = ""

    End Sub

    ''' <summary>
    ''' Agrega a un nuevo usuario por medio de los datos de los cuadros de texto
    ''' </summary>
    Private Sub AddCliData()

        'Privadas
        Dim flgErr As Boolean = False

        'Valida
        If String.IsNullOrEmpty(TxtRfcNew.Text) Then
            flgErr = True
        ElseIf String.IsNullOrEmpty(TxtRazonNew.Text) Then
            flgErr = True
        ElseIf String.IsNullOrEmpty(TxtMailNew.Text) Then
            flgErr = True
        ElseIf String.IsNullOrEmpty(TxtContactoNew.Text) Then
            flgErr = True
        ElseIf String.IsNullOrEmpty(TxtTelNew.Text) Then
            flgErr = True
        ElseIf String.IsNullOrEmpty(TxtDirNew.Text) Then
            flgErr = True
        ElseIf String.IsNullOrEmpty(TxtCiudadNew.Text) Then
            flgErr = True
        ElseIf String.IsNullOrEmpty(TxtEdoNew.Text) Then
            flgErr = True
        End If

        'Usr
        If flgErr Then

            MsgBox("Uno o varios campos no válidos, favor de verificar", MsgBoxStyle.Exclamation, "UbiSoft by Ubicamatic - 2020(C)")

            Return

        End If

        'Captura
        datos.rfc_cli = TxtRfcNew.Text
        datos.razon_cli = TxtRazonNew.Text
        datos.mail_cli = TxtMailNew.Text
        datos.contacto_cli = TxtContactoNew.Text
        datos.tel_cli = TxtTelNew.Text
        datos.dir_cli = TxtDirNew.Text
        datos.ciudad_cli = TxtCiudadNew.Text
        datos.edo_cli = TxtEdoNew.Text

        'Insert 
        If (add.NewUsr(datos)) Then

            'Msg Usr
            MsgBox("Nuevo cliente agregado", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

            'Re inicia los valores
            ClearTxt()

        End If

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Valida que el dgv no tenga datos, en caso de ser así llama al método para la inserción por lista
    ''' En caso contrario realiza la inserción por medio de los cuadros de texto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        'Validación
        If (DgvCli.Rows.Count > 0) Then

            'Método para insert por medio de la tabla
            AddCliDgv()

        Else

            'Método para insert de los campos de texto
            AddCliData()

        End If

    End Sub

#End Region

End Class