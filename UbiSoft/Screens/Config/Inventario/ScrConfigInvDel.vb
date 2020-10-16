'Imports
Imports System.IO
Imports UbiDll

Public Class ScrConfigInvDel

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim del As New Eliminar
    Dim errorMsg As New ErrorMsg

    Dim id As Integer = 0

#End Region

#Region "Funciones y Métodos"

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
    ''' Convierte el arreglo Byte() recibido a Imágen
    ''' Regresa una imágen
    ''' </summary>
    ''' <param name="Imagen">Image filetype</param>
    ''' <returns></returns>
    Private Function BinToImg(ByVal Imagen As Byte()) As Image

        'Control de errores
        Try

            'Validamos si hay imagen
            If Not Imagen Is Nothing Then

                'Capturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)

                'Con el método FromStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)

                'Regresamos la imágen
                Return Resultado

            Else

                Return Nothing

            End If

        Catch ex As Exception

            Return Nothing

        End Try

    End Function

    ''' <summary>
    ''' Se encarga de llenar el datagrid con todas las entradas de la tabla de inventario
    ''' </summary>
    Private Sub FillDgvInv()

        'Reset
        consulta.dgvCode.Reset()

        'Consulta
        consulta.DgvAllInv()

        'Datagrid
        DgvInv.DataSource = consulta.dgvCode.Tables("INV")

        'Formato al Dgv
        FormatDgv()

    End Sub

    ''' <summary>
    ''' Formato para el datagridview
    ''' </summary>
    Private Sub FormatDgv()

        'Sort Descending
        DgvInv.Sort(DgvInv.Columns("Id"), System.ComponentModel.ListSortDirection.Ascending)

        'Size mode para las columnas
        DgvInv.Columns("Id").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvInv.Columns("Id").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvInv.Columns("Categoría").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvInv.Columns("Categoría").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvInv.Columns("Interno").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvInv.Columns("Interno").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvInv.Columns("Comercial").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvInv.Columns("Comercial").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvInv.Columns("TAG").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvInv.Columns("TAG").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvInv.Columns("Descripción").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvInv.Columns("Descripción").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvInv.Columns("Valor").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvInv.Columns("Valor").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvInv.Columns("Area").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvInv.Columns("Area").SortMode = DataGridViewColumnSortMode.Programmatic

        'Rutina para configurar la altura de las filas
        For Each filas As DataGridViewRow In DgvInv.Rows
            filas.Height = 240
        Next

        'Cambio de tipo para la columna que almacena la fotografía
        DgvInv.Columns("Foto").ValueType = GetType(DataGridViewImageColumn)
        DgvInv.Columns("Foto").Width = 200

        'Rutina para configurar el tamaño de la foto
        For Each col As DataGridViewImageColumn In DgvInv.Columns
            col.ImageLayout = DataGridViewImageCellLayout.Stretch
            Exit For
        Next

    End Sub

    ''' <summary>
    ''' Limpia los cuadros de texto
    ''' </summary>
    Private Sub ClearTxt()

        'Text
        TxtInt.Text = ""
        TxtCom.Text = ""
        TxtTag.Text = ""

        'Img
        PbFoto.Image = My.Resources.inventario

    End Sub

    ''' <summary>
    ''' Captura el id del inventario
    ''' Pasa la id a datos
    ''' Realiza el delete de la tabla inventario
    ''' </summary>
    Private Sub DelInvData()

        'Captura
        datos.id_inv = id

        'Delete 
        If (del.DelAuto(datos)) Then

            'Msg Usr
            MsgBox("Inventario eliminado", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

            'Re inicia los valores
            ClearTxt()
            FillDgvInv()

        End If

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Llama al método para cargar los autos en el Dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrConfigInvDel_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dgv
        FillDgvInv()

    End Sub

    ''' <summary>
    ''' Obtiene los datos de la fila / celda seleccionada
    ''' Carga los valores en los textbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvInv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvInv.CellMouseClick

        'Privadas
        Dim fila As Integer = DgvInv.Rows(e.RowIndex).Index

        'Datos
        id = DgvInv.Item(1, fila).Value
        TxtInt.Text = DgvInv.Item(3, fila).Value
        TxtCom.Text = DgvInv.Item(4, fila).Value
        TxtTag.Text = DgvInv.Item(5, fila).Value

        'Conversión BinToImg
        PbFoto.Image = BinToImg(DgvInv.Item(0, fila).Value)

    End Sub

    ''' <summary>
    ''' Llama al método para limpiar los campos de texto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        'Clear
        ClearTxt()

    End Sub

    ''' <summary>
    ''' Muestra la pantalla para el dispositivo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnDevice_Click(sender As Object, e As EventArgs) Handles BtnDevice.Click

        'Scr
        ScrInvDelFromDevice.Show()

    End Sub

    ''' <summary>
    ''' Llama al método encargado de realizar el delete
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        'Del
        DelInvData()

    End Sub

#End Region

End Class