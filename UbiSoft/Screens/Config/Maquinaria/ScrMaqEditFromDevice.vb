﻿'Imports
Imports System.IO
Imports UbiDll

Public Class ScrMaqEditFromDevice

#Region "Variables"

    'Serial
    Dim WithEvents SerialPort As New IO.Ports.SerialPort
    Dim spName As String = ""

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim upd As New Actualizar
    Dim errorMsg As New ErrorMsg

#End Region

#Region "Funciones y Métodos"

    ''' <summary>
    ''' Se encarga de listar todos los puertos seriales
    ''' Los carga en el combo
    ''' </summary>
    Private Sub FillSerial()

        'Locales
        Dim Ports As String() = IO.Ports.SerialPort.GetPortNames()

        'Usuario
        CboPto.Text = ""

        'Validación
        If Ports.Length > 0 Then

            'Rutina
            For Each puertos In Ports

                'Combo
                CboPto.Items.Add(puertos)

            Next

            'Usuario
            CboPto.SelectedIndex = 0
            BtnSerial.Enabled = True

        Else

            'Usuario
            CboPto.Text = "Sin dispositivo"
            PbLed.BackColor = Color.DarkRed
            BtnSerial.Enabled = False

        End If

    End Sub

    ''' <summary>
    ''' Se encarga de configurar el Serial y abrir el puerto
    ''' </summary>
    Private Sub ConectSerial()

        'Control de errores
        Try
            'Configuramos Velocidad y Nombre
            SerialPort.BaudRate = 9600
            SerialPort.PortName = spName

            'Abrimos el puerto
            SerialPort.Open()

            'Btn
            BtnSerial.Text = "Conectado"
            PbLed.BackColor = Color.GreenYellow

        Catch ex As Exception

            'Btn
            BtnSerial.Text = "Conectar"
            PbLed.BackColor = Color.DarkRed

            'Cerramos el puerto en caso de estar abierto y causar error
            SerialPort.Close()

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
    ''' Se encarga de llenar el datagrid con todas las entradas de la tabla de usuarios
    ''' </summary>
    Private Sub GetAllMaq()

        'Reset
        Consulta.dgvCode.Reset()

        'Consulta
        Consulta.DgvAllMaq()

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
        'DgvMaq.Columns("Foto").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        'DgvMaq.Columns("Foto").SortMode = DataGridViewColumnSortMode.Programmatic
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
    ''' Captura los valores de los textbox
    ''' Llama al método para convertir la imágen a binario
    ''' Realiza el update en la tabla de maquinaria
    ''' </summary>
    Private Sub UpdMaqData()

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
        datos.idmaq = TxtId.Text
        datos.modelo_maq = TxtModelo.Text
        datos.marca_maq = TxtMarca.Text
        datos.desc_maq = TxtDesc.Text
        datos.area_maq = TxtArea.Text
        datos.yyadq_maq = TxtAdq.Text
        datos.foto_maq = arrayBin

        'Insert
        If upd.UpdMaq(datos) Then

            'Msg Usr
            MsgBox("Maquinaria editada", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

            'Re inicia los valores
            ClearTxt()

            'Carga el Dgv
            GetAllMaq()

        End If

    End Sub

#End Region

#Region "DELEGADOS"

    'Creamos el método delegado, el nombre lo eligimos nosostros
    Delegate Sub RfidDelegado(ByVal [text] As String)

    'Creamos el objeto delegado a GetRfid, direcciona al método a llamar y le pasa como parámetro el Texto
    Dim delegadoRFID As New RfidDelegado(AddressOf GetRfid)

    ''' <summary>
    ''' El método delegado como tal, tiene como nombre el mismo que usa Invoke
    ''' Obtiene el RFID recibido por el lector en la consola
    ''' Pasa el RFID al cuadro de texto reservado para tal
    ''' </summary>
    ''' <param name="dato">Cadena de texto</param>
    Sub GetRfid(ByVal dato As String)

        'Quitamos los caracteres basura del inicio y final del string
        dato = dato.Trim

        'Textbox
        TxtSerie.Text = dato

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Carga los puertos seriales
    ''' Llama al método para cargar la maquinaria en el Dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrMaqEditFromDevice_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Serial
        FillSerial()

        'Dgv
        GetAllMaq()

    End Sub

    ''' <summary>
    ''' Llama al método para la conexión serial
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSerial_Click(sender As Object, e As EventArgs) Handles BtnSerial.Click

        'Serial
        ConectSerial()

    End Sub

    ''' <summary>
    ''' Se encarga de capturar el nombre del puerto en la variable que le corresponde
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboPto_TextChanged(sender As Object, e As EventArgs) Handles CboPto.TextChanged

        'Locales
        Dim Ports As String() = IO.Ports.SerialPort.GetPortNames()

        'Validación
        If Ports.Length > 0 Then

            'Captura
            spName = CboPto.SelectedItem.ToString

        End If

    End Sub

    ''' <summary>
    ''' Recibe los datos seriales hasta recibir una nueva línea LN.
    ''' Invoca al método delegado para pasar el RFID al textbox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SerialPort_DataReceived(sender As Object, e As Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived

        'COM
        Dim str As String = SerialPort.ReadLine

        'Invoke, llama al método delegado y le pasa como argumento una cadena con el dato recibido.
        Invoke(delegadoRFID, str)

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
    ''' Cierra el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PbClose_Click(sender As Object, e As EventArgs) Handles PbClose.Click

        'Close
        Me.Close()

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
    ''' Llama al método para limpiar los campos de texto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        'Clear
        ClearTxt()

    End Sub

    ''' <summary>
    ''' Llama al método para realizar el update
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        'Update
        UpdMaqData()

    End Sub

#End Region

End Class