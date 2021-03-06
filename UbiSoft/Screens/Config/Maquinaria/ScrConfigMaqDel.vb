﻿'Imports
Imports System.IO
Imports UbiDll

Public Class ScrConfigMaqDel

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim del As New Eliminar
    Dim errorMsg As New ErrorMsg

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
    ''' Se encarga de llenar el datagrid con todas las entradas de la tabla de maquinaria
    ''' </summary>
    Private Sub GetAllMaq()

        'Reset
        consulta.dgvCode.Reset()

        'Consulta
        consulta.DgvAllMaq()

        'Datagrid
        DgvMaqui.DataSource = consulta.dgvCode.Tables("MAQ")

        'Formato al Dgv
        FormatDgv()

    End Sub

    ''' <summary>
    ''' Formato para el datagridview
    ''' </summary>
    Private Sub FormatDgv()

        'Sort Descending
        DgvMaqui.Sort(DgvMaqui.Columns("Id"), System.ComponentModel.ListSortDirection.Ascending)

        'Size mode para las columnas
        DgvMaqui.Columns("Id").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvMaqui.Columns("Id").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvMaqui.Columns("Serie").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvMaqui.Columns("Serie").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvMaqui.Columns("Modelo").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvMaqui.Columns("Modelo").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvMaqui.Columns("Marca").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvMaqui.Columns("Marca").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvMaqui.Columns("Descripción").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvMaqui.Columns("Descripción").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvMaqui.Columns("Area").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvMaqui.Columns("Area").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvMaqui.Columns("Año de adq.").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvMaqui.Columns("Año de adq.").SortMode = DataGridViewColumnSortMode.Programmatic

        'Rutina para configurar la altura de las filas
        For Each filas As DataGridViewRow In DgvMaqui.Rows
            filas.Height = 240
        Next

        'Cambio de tipo para la columna que almacena la fotografía
        DgvMaqui.Columns("Foto").ValueType = GetType(DataGridViewImageColumn)
        DgvMaqui.Columns("Foto").Width = 200

        'Rutina para configurar el tamaño de la foto
        For Each col As DataGridViewImageColumn In DgvMaqui.Columns
            col.ImageLayout = DataGridViewImageCellLayout.Stretch
            Exit For
        Next

    End Sub

    ''' <summary>
    ''' Limpia los cuadros de texto
    ''' </summary>
    Private Sub ClearTxt()

        'Text
        TxtId.Text = ""
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
    ''' Captura el id de la maquinaria del cuadro de texto
    ''' Pasa el id a datos
    ''' Realiza el delete de la tabla maquinaria
    ''' </summary>
    Private Sub DelMaqData()

        'Captura
        datos.idmaq = TxtId.Text

        'Delete 
        If (del.DelMaq(datos)) Then

            'Msg Usr
            MsgBox("Maquinaria eliminada", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

            'Re inicia los valores
            ClearTxt()
            GetAllMaq()

        End If

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Carga la tabla maquinaria en el Dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrConfigMaqDel_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dgv
        GetAllMaq()

    End Sub

    ''' <summary>
    ''' Obtiene los datos de la fila / celda seleccionada
    ''' Carga los valores en los textbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvMaqui_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvMaqui.CellMouseClick

        'Privadas
        Dim fila As Integer = DgvMaqui.Rows(e.RowIndex).Index

        'Datos
        TxtId.Text = DgvMaqui.Item(1, fila).Value
        TxtSerie.Text = DgvMaqui.Item(2, fila).Value
        TxtModelo.Text = DgvMaqui.Item(3, fila).Value
        TxtMarca.Text = DgvMaqui.Item(4, fila).Value
        TxtDesc.Text = DgvMaqui.Item(5, fila).Value
        TxtArea.Text = DgvMaqui.Item(6, fila).Value
        TxtAdq.Text = DgvMaqui.Item(7, fila).Value

        'Conversión BinToImg
        PbFoto.Image = BinToImg(DgvMaqui.Item(0, fila).Value)

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
    ''' Muestra la pantalla para borrar desde dispositivo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnDevice_Click(sender As Object, e As EventArgs) Handles BtnDevice.Click

        'Scr
        ScrMaqDelFromDevice.Show()

    End Sub

    ''' <summary>
    ''' Llama al método para realizar el delete
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        'Delete
        DelMaqData()

    End Sub

#End Region

End Class