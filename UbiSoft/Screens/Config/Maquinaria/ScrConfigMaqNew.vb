'Imports
Imports UbiDll
Imports SpreadsheetLight
Imports System.IO

Public Class ScrConfigMaqNew

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim add As New Agregar
    Dim errorMsg As New ErrorMsg

#End Region

#Region "Métodos y Funciones"

    ''' <summary>
    ''' Muestra el cuadro para abrir archivo
    ''' Aplica los filtros necesarios
    ''' Regresa el archivo seleccionado
    ''' </summary>
    Private Sub AbrirImagen()
        'Privadas
        Dim imagen As New OpenFileDialog

        'Open
        imagen.Filter = "JPEGs|*.jpg|PNGs|*.png|Bitmaps|*.bmp|AllFiles|*.*"

        'Validación
        If imagen.ShowDialog() = DialogResult.OK Then

            PbFoto.Image = Image.FromFile(imagen.FileName)

        End If

    End Sub

    ''' <summary>
    ''' Convierte la imágen recibida a formato RAW Binario
    ''' Regresa un arreglo de tipo Byte()
    ''' </summary>
    ''' <param name="pic">Objeto Imágen</param>
    ''' <returns>Bin as Memory Stream</returns>
    Public Function ImgToBin(ByVal pic As Image) As Byte()

        'Evaluamos que la imágen contenga datos
        If Not pic Is Nothing Then

            'Variable para almacenar la imágen como stream(flujo de datos)
            Dim bin As New MemoryStream

            'Convertimos a binario Raw
            pic.Save(bin, Imaging.ImageFormat.Jpeg)

            'Regresa la imágen ya en binario, pero contenida en un arreglo
            Return bin.GetBuffer

        Else

            'Null
            Return Nothing

        End If

    End Function

    ''' <summary>
    ''' Captura los valores del dgv en la clase datos
    ''' Agrega a los productos cargados por medio del archivo de excel al datagridview
    ''' </summary>
    Private Sub AddMaqDgv()

        'Privadas
        Dim contAdd As Integer = 0
        Dim arrayBin As Byte()

        'Conversión Img to Bin
        arrayBin = ImgToBin(PbFoto.Image)

        'Rutina para recorrer las filas del datagridview
        For Each filas As DataGridViewRow In DgvMaq.Rows

            'Captura
            datos.foto_maq = arrayBin
            datos.serie_maq = filas.Cells(0).Value
            datos.modelo_maq = filas.Cells(1).Value
            datos.marca_maq = filas.Cells(2).Value
            datos.desc_maq = filas.Cells(3).Value
            datos.area_maq = filas.Cells(4).Value
            datos.yyadq_maq = filas.Cells(5).Value

            'Insert
            If (add.NewMaq(datos)) Then

                'Incrementamos el contador
                contAdd += 1

            End If

        Next

        'Validación de todos las insert & update
        If (DgvMaq.Rows.Count = contAdd) Then

            'Usuario
            MsgBox("Toda la maquinaria ha sido agregada con éxito", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

        Else

            'Usuario
            MsgBox("Uno o más maquinaria no pudo agregarse a la base de datos", MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        End If

        'Limpiar Dgv
        DgvMaq.Rows.Clear()

    End Sub

    ''' <summary>
    ''' Captura los valores de los textbox
    ''' Llama al método para convertir la imágen a binario
    ''' Realiza la inserción en la tabla de maquinaria
    ''' </summary>
    Private Sub AddMaqData()

        'Privadas
        Dim flgErr As Boolean = False
        Dim arrayBin As Byte()

        'Validación textos
        If String.IsNullOrEmpty(TxtSerie.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtMarca.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtDesc.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtArea.Text) Then

            'Flag
            flgErr = True

        End If

        If flgErr Then

            'Usuario
            MsgBox("Uno o varios campos no válidos, favor de verificar", MsgBoxStyle.Exclamation, "UbiSoft by Ubicamatic - 2020(C)")

            Return

        End If

        'Conversión Img to Bin
        arrayBin = ImgToBin(PbFoto.Image)

        'Captura 
        datos.serie_maq = TxtSerie.Text
        datos.modelo_maq = TxtModelo.Text
        datos.marca_maq = TxtMarca.Text
        datos.desc_maq = TxtDesc.Text
        datos.area_maq = TxtArea.Text
        datos.yyadq_maq = TxtAdq.Text
        datos.foto_maq = arrayBin

        'Insert
        If add.NewMaq(datos) Then

            'Msg Usr
            MsgBox("Nueva maquinaria agregada", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

            'Re inicia los valores
            ClearTxt()

        End If

    End Sub

    ''' <summary>
    ''' Limpia los cuadros de texto
    ''' </summary>
    Private Sub ClearTxt()

        'Text
        TxtSerie.Text = ""
        TxtAdq.Text = ""
        TxtModelo.Text = ""
        TxtMarca.Text = ""
        TxtDesc.Text = ""
        TxtArea.Text = ""

        'Img
        PbFoto.Image = My.Resources.camara__1_

    End Sub

    ''' <summary>
    ''' Abre el diálogo para capturar el path del excel
    ''' Lo pasa como parámetro al método para llenar el dgvProd
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
                FillDgvProd(.FileName, DgvMaq)

            End If

        End With

    End Sub

    ''' <summary>
    ''' Recibe el path y el objeto datagrid como parámetros
    ''' Llena el dgv que recibe como parámetro con los datos del excel
    ''' </summary>
    ''' <param name="path"></param>
    ''' <param name="dgv"></param>
    Private Sub FillDgvProd(ByRef path As String, ByVal dgv As DataGridView)

        'Privadas
        Dim filas As Integer = 2

        'Objeto de la clase spreadsheetslight para abrir el contenido del excel
        Dim slExl As New SLDocument(path)


        'Rutina para recorrer todos los datos del archivo
        While (Not String.IsNullOrEmpty(slExl.GetCellValueAsString(filas, 1)))

            'Debug
            'MsgBox(slExl.GetCellValueAsString(filas, 1))

            'Populate DatagridView
            DgvMaq.Rows.Add(slExl.GetCellValueAsString(filas, 1), slExl.GetCellValueAsString(filas, 2), slExl.GetCellValueAsString(filas, 3), slExl.GetCellValueAsString(filas, 4), slExl.GetCellValueAsString(filas, 5), slExl.GetCellValueAsString(filas, 6))

            'Incrementamos la fila
            filas += 1

        End While

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Llama al método para cargar la imágen
    ''' Muestra la imágen seleccionada en el picture box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PbFoto_Click(sender As Object, e As EventArgs) Handles PbFoto.Click

        'Abrir
        AbrirImagen()

    End Sub

    ''' <summary>
    ''' Valida que el dgv no tenga datos, en caso de ser así llama al método para la inserción por lista
    ''' En caso contrario realiza la inserción por medio de los cuadros de texto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        'Validación
        If (DgvMaq.Rows.Count > 0) Then

            'Método para insert por medio de la tabla
            AddMaqDgv()

        Else

            'Método para insert de los campos de texto
            AddMaqData()

        End If

    End Sub

    ''' <summary>
    ''' Limpia los cuadros de texto y el dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        'Clear
        ClearTxt()
        DgvMaq.Rows.Clear()

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
    ''' Llama al método para cargar el número consecutivo de la tabla maquinaria
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrConfigMaqNew_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Serial Bd + 1
        Dim id As Integer = consulta.GetLastId + 1

        'Text
        TxtId.Text = id.ToString

    End Sub

    ''' <summary>
    ''' Muestra la pantalla para captura de datos desde el dispositivo lector RFID
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnDevice_Click(sender As Object, e As EventArgs) Handles BtnDevice.Click

        'Show new screen
        ScrMaqNewFromDevice.Show()

    End Sub

#End Region

End Class