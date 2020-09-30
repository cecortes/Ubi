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
    ''' Recibe el path y el objeto datagrid como parámetros
    ''' Llena el dgv que recibe como parámetro con los datos del excel
    ''' </summary>
    ''' <param name="path"></param>
    ''' <param name="dgv"></param>
    Private Sub FillDgvUsr(ByRef path As String, ByVal dgv As DataGridView)

        'Privadas
        Dim filas As Integer = 2

        'Objeto de la clase spreadsheetslight para abrir el contenido del excel
        Dim slExl As New SLDocument(path)


        'Rutina para recorrer todos los datos del archivo
        While (Not String.IsNullOrEmpty(slExl.GetCellValueAsString(filas, 1)))

            'Debug
            'MsgBox(slExl.GetCellValueAsString(filas, 1))

            'Populate DatagridView
            DgvCli.Rows.Add(slExl.GetCellValueAsString(filas, 1), slExl.GetCellValueAsString(filas, 2), slExl.GetCellValueAsString(filas, 3), slExl.GetCellValueAsString(filas, 4), slExl.GetCellValueAsString(filas, 5), slExl.GetCellValueAsString(filas, 6), slExl.GetCellValueAsString(filas, 7), slExl.GetCellValueAsString(filas, 8))

            'Incrementamos la fila
            filas += 1

        End While

    End Sub

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
    ''' Abre el diálogo para capturar el path del excel
    ''' Lo pasa como parámetro al método para llenar el dgvCli
    ''' </summary>
    Private Sub OpenExcel()

        'Open
        Dim opnExcel As New OpenFileDialog()

        With opnExcel

            .Title = "Seleccionar archivo"
            .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

            'Validación
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                'Método para llenar el dgvUsr
                FillDgvUsr(.FileName, DgvCli)

            End If

        End With

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
        If (add.NewClient(datos)) Then

            'Msg Usr
            MsgBox("Nuevo cliente agregado", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

            'Re inicia los valores
            ClearTxt()

        End If

    End Sub

    ''' <summary>
    ''' Captura los valores del dgv en la clase datos
    ''' Agrega a los clientes cargados por medio del archivo de excel al datagridview
    ''' Limpia el Dgv
    ''' </summary>
    Private Sub AddCliDgv()

        'Privadas
        Dim contAdd As Integer = 0

        'Rutina para recorrer las filas del datagridview
        For Each filas As DataGridViewRow In DgvCli.Rows

            'Captura
            datos.rfc_cli = filas.Cells(0).Value
            datos.razon_cli = filas.Cells(1).Value
            datos.mail_cli = filas.Cells(2).Value
            datos.contacto_cli = filas.Cells(3).Value
            datos.tel_cli = filas.Cells(4).Value
            datos.dir_cli = filas.Cells(5).Value
            datos.ciudad_cli = filas.Cells(6).Value
            datos.edo_cli = filas.Cells(7).Value

            'Insert & Update
            If (add.NewClient(datos)) Then

                'Incrementamos el contador
                contAdd += 1

            End If

        Next

        'Validación de todos las insert & update
        If (DgvCli.Rows.Count = contAdd) Then

            'Usuario
            MsgBox("Todos los clientes fueron agregados con éxito", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

        Else

            'Usuario
            MsgBox("Uno o más clientes no pudieron agregarse a la base de datos", MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        End If

        'Limpiar Dgv
        DgvCli.Rows.Clear()

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

    ''' <summary>
    ''' LLama al método para abrir el excel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        'Open Excel
        OpenExcel()

    End Sub

    ''' <summary>
    ''' Limpia los valores de los textbox y del datagrid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        'Clear
        ClearTxt()
        DgvCli.Rows.Clear()

    End Sub

#End Region

End Class