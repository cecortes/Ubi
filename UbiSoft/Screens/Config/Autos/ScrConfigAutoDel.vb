'Imports
Imports System.IO
Imports UbiDll

Public Class ScrConfigAutoDel

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
    ''' Se encarga de llenar el datagrid con todas las entradas de la tabla de autos
    ''' </summary>
    Private Sub FillDgvAutos()

        'Reset
        Consulta.dgvCode.Reset()

        'Consulta
        Consulta.DgvAllAutos()

        'Datagrid
        DgvAutos.DataSource = Consulta.dgvCode.Tables("AUT")

        'Formato al Dgv
        FormatDgv()

    End Sub

    ''' <summary>
    ''' Formato para el datagridview
    ''' </summary>
    Private Sub FormatDgv()

        'Sort Descending
        DgvAutos.Sort(DgvAutos.Columns("Placas"), System.ComponentModel.ListSortDirection.Ascending)

        'Size mode para las columnas
        DgvAutos.Columns("Placas").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvAutos.Columns("Placas").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvAutos.Columns("Marca").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvAutos.Columns("Marca").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvAutos.Columns("Modelo").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvAutos.Columns("Modelo").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvAutos.Columns("Año").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvAutos.Columns("Año").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvAutos.Columns("Motor").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvAutos.Columns("Motor").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvAutos.Columns("Póliza").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvAutos.Columns("Póliza").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvAutos.Columns("Verificación").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvAutos.Columns("Verificación").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvAutos.Columns("Tipo").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvAutos.Columns("Tipo").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvAutos.Columns("Capacidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvAutos.Columns("Capacidad").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvAutos.Columns("Refrigeración").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvAutos.Columns("Refrigeración").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvAutos.Columns("Gps").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvAutos.Columns("Gps").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvAutos.Columns("TAG").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvAutos.Columns("TAG").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvAutos.Columns("UBI").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvAutos.Columns("UBI").SortMode = DataGridViewColumnSortMode.Programmatic

        'Rutina para configurar la altura de las filas
        For Each filas As DataGridViewRow In DgvAutos.Rows
            filas.Height = 240
        Next

        'Cambio de tipo para la columna que almacena la fotografía
        DgvAutos.Columns("Foto").ValueType = GetType(DataGridViewImageColumn)
        DgvAutos.Columns("Foto").Width = 200

        'Rutina para configurar el tamaño de la foto
        For Each col As DataGridViewImageColumn In DgvAutos.Columns
            col.ImageLayout = DataGridViewImageCellLayout.Stretch
            Exit For
        Next

    End Sub

    ''' <summary>
    ''' Limpia los cuadros de texto
    ''' </summary>
    Private Sub ClearTxt()

        'Text
        TxtPlaca.Text = ""
        TxtMarca.Text = ""
        TxtModelo.Text = ""
        TxtAno.Text = ""
        TxtMotor.Text = ""
        TxtTag.Text = ""

        'Img
        PbFoto.Image = My.Resources.pick

    End Sub

    ''' <summary>
    ''' Captura la placa del vehículo del cuadro de texto
    ''' Pasa la placa a datos
    ''' Realiza el delete de la tabla autos
    ''' </summary>
    Private Sub DelAutoData()

        'Captura
        datos.placas_auto = TxtPlaca.Text

        'Delete 
        If (del.DelMaq(datos)) Then

            'Msg Usr
            MsgBox("Vehículo eliminado", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

            'Re inicia los valores
            ClearTxt()
            FillDgvAutos()

        End If

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Llama al método para cargar los autos en el Dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrConfigAutoDel_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dgv
        FillDgvAutos()

    End Sub

    ''' <summary>
    ''' Obtiene los datos de la fila / celda seleccionada
    ''' Carga los valores en los textbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvAutos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvAutos.CellMouseClick

        'Privadas
        Dim fila As Integer = DgvAutos.Rows(e.RowIndex).Index

        'Datos
        TxtPlaca.Text = DgvAutos.Item(1, fila).Value
        TxtMarca.Text = DgvAutos.Item(2, fila).Value
        TxtModelo.Text = DgvAutos.Item(3, fila).Value
        TxtAno.Text = DgvAutos.Item(4, fila).Value
        TxtMotor.Text = DgvAutos.Item(5, fila).Value
        TxtTag.Text = DgvAutos.Item(12, fila).Value

        'Conversión BinToImg
        PbFoto.Image = BinToImg(DgvAutos.Item(0, fila).Value)

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
    ''' Muestra la pantalla del dispositivo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnDevice_Click(sender As Object, e As EventArgs) Handles BtnDevice.Click

        'Scr
        ScrAutoDelFromDevice.Show()

    End Sub

    ''' <summary>
    ''' Llama al método encargado de borrar al auto de la tabla autos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        'Del
        DelAutoData()

    End Sub

#End Region

End Class