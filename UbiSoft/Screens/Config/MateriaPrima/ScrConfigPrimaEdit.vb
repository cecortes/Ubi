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

#End Region

End Class