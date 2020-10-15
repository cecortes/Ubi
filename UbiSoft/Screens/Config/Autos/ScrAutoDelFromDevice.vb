'Imports
Imports System.IO
Imports UbiDll

Public Class ScrAutoDelFromDevice

#Region "Variables"

    'Serial
    Dim WithEvents SerialPort As New IO.Ports.SerialPort
    Dim spName As String = ""

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim del As New Eliminar
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

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Carga los puertos seriales
    ''' Llama al método para cargar los autos en el Dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrAutoDelFromDevice_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Serial
        FillSerial()

        'Dgv
        FillDgvAutos()

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

#End Region

End Class