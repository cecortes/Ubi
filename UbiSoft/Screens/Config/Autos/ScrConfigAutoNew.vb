'Imports
Imports UbiDll
Imports SpreadsheetLight
Imports System.IO

Public Class ScrConfigAutoNew

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim add As New Agregar
    Dim errorMsg As New ErrorMsg

#End Region

#Region "Funciones y Métodos"

    ''' <summary>
    ''' Llena el cbo con idauto_tipos de la tabla auto_tipos
    ''' </summary>
    Private Sub FillCboTpo()

        'Reset
        consulta._dtsCbo.Reset()

        'Consulta
        consulta.GetAutoTipos()

        'Dataset 
        CboTpo.DataSource = consulta._dtsCbo.Tables("autoTpo")

        'Datos
        CboTpo.DisplayMember = "idauto_tipos"

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
                FillDgvAuto(.FileName, DgvAuto)

            End If

        End With

    End Sub

    ''' <summary>
    ''' Recibe el path y el objeto datagrid como parámetros
    ''' Llena el dgv que recibe como parámetro con los datos del excel
    ''' </summary>
    ''' <param name="path"></param>
    ''' <param name="dgv"></param>
    Private Sub FillDgvAuto(ByRef path As String, ByVal dgv As DataGridView)

        'Privadas
        Dim filas As Integer = 2

        'Objeto de la clase spreadsheetslight para abrir el contenido del excel
        Dim slExl As New SLDocument(path)


        'Rutina para recorrer todos los datos del archivo
        While (Not String.IsNullOrEmpty(slExl.GetCellValueAsString(filas, 1)))

            'Debug
            'MsgBox(slExl.GetCellValueAsString(filas, 1))

            'Populate DatagridView
            dgv.Rows.Add(slExl.GetCellValueAsString(filas, 1), slExl.GetCellValueAsString(filas, 2), slExl.GetCellValueAsString(filas, 3), slExl.GetCellValueAsString(filas, 4), slExl.GetCellValueAsString(filas, 5), slExl.GetCellValueAsString(filas, 6), slExl.GetCellValueAsString(filas, 7), slExl.GetCellValueAsString(filas, 8), slExl.GetCellValueAsString(filas, 9), slExl.GetCellValueAsString(filas, 10), slExl.GetCellValueAsString(filas, 11), slExl.GetCellValueAsString(filas, 12), slExl.GetCellValueAsString(filas, 13))

            'Incrementamos la fila
            filas += 1

        End While

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
        TxtPol.Text = ""
        TxtVeri.Text = ""
        TxtCapa.Text = ""
        TxtTag.Text = ""
        TxtUbi.Text = ""

        'Control de errores
        Try

            'Index
            CboTpo.SelectedIndex = 0

        Catch ex As Exception

        End Try

        'Img
        PbFoto.Image = My.Resources.pick

        'CHK
        ChkFrio.Checked = False
        ChkGps.Checked = False

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
    Private Sub AddAutoDgv()

        'Privadas
        Dim contAdd As Integer = 0

        'Rutina para recorrer las filas del datagridview
        For Each filas As DataGridViewRow In DgvAuto.Rows

            'Captura
            datos.placas_auto = filas.Cells(0).Value
            datos.marca_auto = filas.Cells(1).Value
            datos.modelo_auto = filas.Cells(2).Value
            datos.year_auto = filas.Cells(3).Value
            datos.motor_auto = filas.Cells(4).Value
            datos.poliza_auto = filas.Cells(5).Value
            datos.verif_auto = filas.Cells(6).Value
            datos.tipo_auto = filas.Cells(7).Value
            datos.capa_auto = filas.Cells(8).Value
            datos.refri_auto = filas.Cells(9).Value
            datos.gps_auto = filas.Cells(10).Value
            datos.tag_auto = filas.Cells(11).Value
            datos.ubi_auto = filas.Cells(12).Value

            'Insert
            If (add.NewAuto(datos)) Then

                'Incrementamos el contador
                contAdd += 1

            End If

        Next

        'Validación de todos las insert & update
        If (DgvAuto.Rows.Count = contAdd) Then

            'Usuario
            MsgBox("Todos los vehículos han sido agregados con éxito", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

        Else

            'Usuario
            MsgBox("Uno o más vehículos no pudieron agregarse a la base de datos", MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        End If

        'Limpiar Dgv
        DgvAuto.Rows.Clear()

    End Sub

    ''' <summary>
    ''' Captura los valores de los textbox
    ''' Llama al método para convertir la imágen a binario
    ''' Realiza la inserción en la tabla de autos
    ''' </summary>
    Private Sub AddAutoData()

        'Privadas
        Dim flgErr As Boolean = False
        Dim arrayBin As Byte()

        'Validación textos
        If String.IsNullOrEmpty(TxtPlaca.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtMarca.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtModelo.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtAno.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtMotor.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtPol.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtVeri.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtCapa.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtTag.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtUbi.Text) Then

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
        datos.foto_auto = arrayBin
        datos.placas_auto = TxtPlaca.Text
        datos.marca_auto = TxtMarca.Text
        datos.modelo_auto = TxtModelo.Text
        datos.year_auto = TxtAno.Text
        datos.motor_auto = TxtMotor.Text
        datos.poliza_auto = TxtPol.Text
        datos.verif_auto = TxtVeri.Text
        datos.tipo_auto = CboTpo.Text
        datos.capa_auto = TxtCapa.Text
        datos.tag_auto = TxtTag.Text
        datos.ubi_auto = TxtUbi.Text

        'CHK
        If ChkFrio.Checked Then

            datos.refri_auto = "SI"

        Else

            datos.refri_auto = "NO"

        End If

        If ChkGps.Checked Then

            datos.gps_auto = "SI"

        Else

            datos.gps_auto = "NO"

        End If

        'Insert
        If add.NewAuto(datos) Then

            'Msg Usr
            MsgBox("Nuevo vehículo agregado", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

            'Re inicia los valores
            ClearTxt()

        End If

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Llena el cbo con el tipo de auto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrConfigAutoNew_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Cbo
        FillCboTpo()

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
        DgvAuto.Rows.Clear()

    End Sub

    ''' <summary>
    ''' Valida que el dgv no tenga datos, en caso de ser así llama al método para la inserción por lista
    ''' En caso contrario realiza la inserción por medio de los cuadros de texto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        'Validación
        If (DgvAuto.Rows.Count > 0) Then

            'Método para insert por medio de la tabla
            AddAutoDgv()

        Else

            'Método para insert de los campos de texto
            AddAutoData()

        End If

    End Sub

#End Region

End Class