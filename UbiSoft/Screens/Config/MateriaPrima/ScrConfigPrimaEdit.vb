'Imports
Imports UbiDll
Imports System.IO

Public Class ScrConfigPrimaEdit

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
        TxtTag.Text = dato

    End Sub

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
    ''' Se encarga de llenar el datagrid con todas las entradas de la tabla de prima
    ''' </summary>
    Private Sub FillDgvPrima()

        'Reset
        consulta.dgvCode.Reset()

        'Consulta
        consulta.DgvAllPrima()

        'Datagrid
        DgvPrima.DataSource = consulta.dgvCode.Tables("PRIMA")

        'Formato al Dgv
        FormatDgv()

    End Sub

    ''' <summary>
    ''' Formato para el datagridview
    ''' </summary>
    Private Sub FormatDgv()

        'Sort Descending
        DgvPrima.Sort(DgvPrima.Columns("Nombre"), System.ComponentModel.ListSortDirection.Ascending)

        'Size mode para las columnas
        DgvPrima.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvPrima.Columns("Nombre").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvPrima.Columns("Interno").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvPrima.Columns("Interno").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvPrima.Columns("Comercial").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvPrima.Columns("Comercial").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvPrima.Columns("TAG").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvPrima.Columns("TAG").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvPrima.Columns("Descripción").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvPrima.Columns("Descripción").SortMode = DataGridViewColumnSortMode.Programmatic

        'Rutina para configurar la altura de las filas
        For Each filas As DataGridViewRow In DgvPrima.Rows
            filas.Height = 240
        Next

        'Cambio de tipo para la columna que almacena la fotografía
        DgvPrima.Columns("Foto").ValueType = GetType(DataGridViewImageColumn)
        DgvPrima.Columns("Foto").Width = 200

        'Rutina para configurar el tamaño de la foto
        For Each col As DataGridViewImageColumn In DgvPrima.Columns
            col.ImageLayout = DataGridViewImageCellLayout.Stretch
            Exit For
        Next

    End Sub

    ''' <summary>
    ''' Limpia los cuadros de texto
    ''' </summary>
    Private Sub ClearTxt()

        'Text
        TxtNom.Text = ""
        TxtInt.Text = ""
        TxtComer.Text = ""
        TxtTag.Text = ""
        TxtDesc.Text = ""

        'Img
        PbFoto.Image = My.Resources.bolsas

    End Sub

    ''' <summary>
    ''' Captura el tag del textbox
    ''' Lo pasa a datos
    ''' Realiza una consulta en la tabla prima para obtener los datos
    ''' </summary>
    Private Sub GetPrimaTag()

        'Privadas
        Dim prima As New Datos

        'Consulta para datos del cliente
        datos.prima_tag = TxtTag.Text
        prima = consulta.GetPrimaRfid(datos)

        'Textbox
        TxtNom.Text = prima.prima_nombre
        TxtInt.Text = prima.prima_interno
        TxtComer.Text = prima.prima_comercial
        TxtTag.Text = prima.prima_tag
        TxtDesc.Text = prima.prima_desc

        'Img
        PbFoto.Image = BinToImg(prima.prima_foto)

    End Sub

    ''' <summary>
    ''' Captura los valores de los textbox
    ''' Llama al método para convertir la imágen a binario
    ''' Realiza el update en la tabla de prima
    ''' </summary>
    Private Sub UpdPrimaData()

        'Privadas
        Dim flgErr As Boolean = False
        Dim arrayBin As Byte()

        'Validación textos
        If String.IsNullOrEmpty(TxtNom.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtInt.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtDesc.Text) Then

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
        datos.prima_foto = arrayBin
        datos.prima_nombre = TxtNom.Text
        datos.prima_interno = TxtInt.Text
        datos.prima_comercial = TxtComer.Text
        datos.prima_tag = TxtTag.Text
        datos.prima_desc = TxtDesc.Text

        'Update
        If upd.UpdPrima(datos) Then

            'Msg Usr
            MsgBox("Materia Prima actualizada", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

            'Re inicia los valores
            ClearTxt()
            FillDgvPrima()

        End If

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Carga los puertos seriales
    ''' Llama al método para cargar las materias primas en el Dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrConfigPrimaEdit_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Serial
        FillSerial()

        'Dgv
        FillDgvPrima()

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
    ''' Llama al método para realizar la consulta del TAG en la tabla prima
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtTag_TextChanged(sender As Object, e As EventArgs) Handles TxtTag.TextChanged

        'Consulta
        GetPrimaTag()

    End Sub

    ''' <summary>
    ''' Obtiene los datos de la fila / celda seleccionada
    ''' Carga los valores en los textbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvPrima_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvPrima.CellMouseClick

        'Privadas
        Dim fila As Integer = DgvPrima.Rows(e.RowIndex).Index

        'Datos
        TxtNom.Text = DgvPrima.Item(1, fila).Value
        TxtInt.Text = DgvPrima.Item(2, fila).Value
        TxtComer.Text = DgvPrima.Item(3, fila).Value
        TxtTag.Text = DgvPrima.Item(4, fila).Value
        TxtDesc.Text = DgvPrima.Item(5, fila).Value

        'Conversión BinToImg
        PbFoto.Image = BinToImg(DgvPrima.Item(0, fila).Value)

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
    ''' Se encarga de llamar al método para limpiar los text
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        'Clr
        ClearTxt()

    End Sub

    ''' <summary>
    ''' Llama al método encargado de realizar el update
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        'Upd
        UpdPrimaData()

    End Sub

#End Region

End Class