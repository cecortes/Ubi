'Imports
Imports UbiDll
Imports SpreadsheetLight

Public Class ScrConfigCliNew

#Region "Variables"

#End Region

#Region "Funciones"

#End Region

#Region "Métodos"

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