'Imports
Imports System.IO
Imports UbiDll

Public Class ScrInvDelFromDevice

#Region "Variables"

    'Serial
    Dim WithEvents SerialPort As New IO.Ports.SerialPort
    Dim spName As String = ""

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim del As New Eliminar
    Dim errorMsg As New ErrorMsg

    Dim id As Integer = 0

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
    ''' Se encarga de llenar el datagrid con todas las entradas de la tabla de inventario
    ''' </summary>
    Private Sub FillDgvInv()

        'Reset
        Consulta.dgvCode.Reset()

        'Consulta
        Consulta.DgvAllInv()

        'Datagrid
        DgvInv.DataSource = Consulta.dgvCode.Tables("INV")

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
    ''' Captura el tag del textbox
    ''' Lo pasa a datos
    ''' Realiza una consulta en la tabla inventario para obtener los datos
    ''' </summary>
    Private Sub GetInvTag()

        'Privadas
        Dim inv As New Datos

        'Consulta para datos del cliente
        datos.tag_inv = TxtTag.Text
        inv = consulta.GetInvRfid(datos)

        id = inv.id_inv

        'Textbox
        TxtInt.Text = inv.placas_auto
        TxtCom.Text = inv.marca_auto
        TxtTag.Text = inv.modelo_auto

        'Img
        PbFoto.Image = BinToImg(inv.foto_auto)

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
        Datos.id_inv = id

        'Delete 
        If (del.DelInv(Datos)) Then

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
    Private Sub ScrInvDelFromDevice_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dgv
        FillDgvInv()

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
    ''' Llama al método para realizar la consulta del TAG en la tabla autos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtTag_TextChanged(sender As Object, e As EventArgs) Handles TxtTag.TextChanged

        'Consulta
        GetInvTag()

    End Sub


#End Region

End Class