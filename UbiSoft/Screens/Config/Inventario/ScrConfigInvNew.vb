'Imports
Imports UbiDll
Imports SpreadsheetLight
Imports System.IO

Public Class ScrConfigInvNew

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim add As New Agregar
    Dim errorMsg As New ErrorMsg

#End Region

#Region "Funciones y Métodos"

    ''' <summary>
    ''' Llena el cbo con cat_inventario de la tabla inventario_cat
    ''' </summary>
    Private Sub FillCboCat()

        'Reset
        consulta._dtsCbo.Reset()

        'Consulta
        consulta.GetInvCat()

        'Dataset 
        CboTpo.DataSource = consulta._dtsCbo.Tables("invCat")

        'Datos
        CboTpo.DisplayMember = "cat_inventario"

        'Control de errores
        Try

            'Index
            CboTpo.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

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
    ''' Abre el diálogo para capturar el path del excel
    ''' Lo pasa como parámetro al método para llenar el dgv
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
                FillDgvInv(.FileName, DgvInv)

            End If

        End With

    End Sub

    ''' <summary>
    ''' Recibe el path y el objeto datagrid como parámetros
    ''' Llena el dgv que recibe como parámetro con los datos del excel
    ''' </summary>
    ''' <param name="path"></param>
    ''' <param name="dgv"></param>
    Private Sub FillDgvInv(ByRef path As String, ByVal dgv As DataGridView)

        'Privadas
        Dim filas As Integer = 2

        'Objeto de la clase spreadsheetslight para abrir el contenido del excel
        Dim slExl As New SLDocument(path)


        'Rutina para recorrer todos los datos del archivo
        While (Not String.IsNullOrEmpty(slExl.GetCellValueAsString(filas, 1)))

            'Debug
            'MsgBox(slExl.GetCellValueAsString(filas, 1))

            'Populate DatagridView
            dgv.Rows.Add(slExl.GetCellValueAsString(filas, 1), slExl.GetCellValueAsString(filas, 2), slExl.GetCellValueAsString(filas, 3), slExl.GetCellValueAsString(filas, 4), slExl.GetCellValueAsString(filas, 5), slExl.GetCellValueAsString(filas, 6), slExl.GetCellValueAsString(filas, 7))

            'Incrementamos la fila
            filas += 1

        End While

    End Sub

    ''' <summary>
    ''' Limpia los cuadros de texto
    ''' </summary>
    Private Sub ClearTxt()

        'Text
        TxtInt.Text = ""
        TxtCom.Text = ""
        TxtTag.Text = ""
        TxtDesc.Text = ""
        TxtCost.Text = ""
        TxtArea.Text = ""

        'Control de errores
        Try

            'Index
            CboTpo.SelectedIndex = 0

        Catch ex As Exception

        End Try

        'Img
        PbFoto.Image = My.Resources.inventario

    End Sub

    ''' <summary>
    ''' Captura los valores del dgv en la clase datos
    ''' Agrega el inventario cargado por medio del archivo de excel al datagridview
    ''' </summary>
    Private Sub AddInvDgv()

        'Privadas
        Dim contAdd As Integer = 0
        Dim arrayBin As Byte()

        'Conversión Img to Bin
        arrayBin = ImgToBin(PbFoto.Image)

        'Rutina para recorrer las filas del datagridview
        For Each filas As DataGridViewRow In DgvInv.Rows

            'Captura
            datos.foto_inv = arrayBin
            datos.cat_inv = filas.Cells(0).Value
            datos.codint_inv = filas.Cells(1).Value
            datos.codcom_inv = filas.Cells(2).Value
            datos.tag_inv = filas.Cells(3).Value
            datos.desc_inv = filas.Cells(4).Value
            datos.cost_inv = filas.Cells(5).Value
            datos.area_inv = filas.Cells(6).Value

            'Insert
            If (add.NewInv(datos)) Then

                'Incrementamos el contador
                contAdd += 1

            End If

        Next

        'Validación de todos las insert & update
        If (DgvInv.Rows.Count = contAdd) Then

            'Usuario
            MsgBox("Todo el inventario ha sido agregado con éxito", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

        Else

            'Usuario
            MsgBox("Uno o más items no pudieron agregarse a la base de datos", MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        End If

        'Limpiar Dgv
        DgvInv.Rows.Clear()

    End Sub

    ''' <summary>
    ''' Captura los valores de los textbox
    ''' Llama al método para convertir la imágen a binario
    ''' Realiza la inserción en la tabla de inventario
    ''' </summary>
    Private Sub AddInvData()

        'Privadas
        Dim flgErr As Boolean = False
        Dim arrayBin As Byte()

        'Validación textos
        If String.IsNullOrEmpty(TxtInt.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtDesc.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtCost.Text) Then

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
        datos.foto_inv = arrayBin
        datos.cat_inv = CboTpo.Text
        datos.codint_inv = TxtInt.Text
        datos.codcom_inv = TxtCom.Text
        datos.tag_inv = TxtTag.Text
        datos.desc_inv = TxtDesc.Text
        datos.cost_inv = TxtCost.Text
        datos.area_inv = TxtArea.Text

        'Insert
        If add.NewInv(datos) Then

            'Msg Usr
            MsgBox("Nuevo inventario agregado", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

            'Re inicia los valores
            ClearTxt()

        End If

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Carga las categorías en el cbo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrConfigInvNew_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Cbo
        FillCboCat()

    End Sub

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
    ''' LLama al método para abrir el excel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        'Open Excel
        OpenExcel()

    End Sub

    ''' <summary>
    ''' Limpia los cuadros de texto y el dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        'Clear
        ClearTxt()
        DgvInv.Rows.Clear()

    End Sub

    ''' <summary>
    ''' Valida que el dgv no tenga datos, en caso de ser así llama al método para la inserción por lista
    ''' En caso contrario realiza la inserción por medio de los cuadros de texto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        'Validación
        If (DgvInv.Rows.Count > 0) Then

            'Método para insert por medio de la tabla
            AddInvDgv()

        Else

            'Método para insert de los campos de texto
            AddInvData()

        End If

    End Sub

#End Region

End Class