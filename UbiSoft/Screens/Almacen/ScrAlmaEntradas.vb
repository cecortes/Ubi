'Imports
Imports UbiDll

Public Class ScrAlmaEntradas

#Region "Variables"

    'Dll
    Dim datos As New Datos
    'Dim consulCli As New Consulta
    'Dim consulProd As New Consulta
    Dim add As New Agregar
    Dim errMsg As New ErrorMsg

    Dim dateEntrada As String = ""
    Dim dateCaduci As String = ""
    Dim dateIni As String = ""
    Dim dateFin As String = ""
    Dim folioAlma As String = ""

#End Region

#Region "Funciones y Métodos"

    ''' <summary>
    ''' Se encarga de darle formato a los date time picker del formulario
    ''' Cambia el color de fondo cuando hover en ambos dtp
    ''' Carga los valores iniciales en sus respectivas variables globales.
    ''' </summary>
    Private Sub FormatDtp()

        'Textos alineación y Color
        DtpEntrada.Style.TextAlign = ContentAlignment.MiddleCenter
        DtpEntrada.BorderRadius = 20
        DtpEntrada.Style.colhover = Color.FromArgb(79, 52, 90)

        DtpCaducidad.Style.TextAlign = ContentAlignment.MiddleCenter
        DtpCaducidad.BorderRadius = 20
        DtpCaducidad.Style.colhover = Color.FromArgb(79, 52, 90)

        DtpAlmaIni.Style.TextAlign = ContentAlignment.MiddleCenter
        DtpAlmaIni.BorderRadius = 20
        DtpAlmaIni.Style.colhover = Color.FromArgb(79, 52, 90)

        DtpAlmaFin.Style.TextAlign = ContentAlignment.MiddleCenter
        DtpAlmaFin.BorderRadius = 20
        DtpAlmaFin.Style.colhover = Color.FromArgb(79, 52, 90)

        'Captura de las fechas
        DtpEntrada.Value = Date.Now.ToShortDateString
        DtpCaducidad.Value = Date.Now.ToShortDateString
        dateEntrada = DtpEntrada.Value.ToShortDateString
        dateCaduci = DtpCaducidad.Value.ToShortDateString
        DtpAlmaIni.Value = Date.Now.ToShortDateString
        DtpAlmaFin.Value = Date.Now.ToShortDateString
        dateIni = DtpAlmaIni.Value.ToShortDateString
        dateFin = DtpAlmaFin.Value.ToShortDateString

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Cierra el formulario y abre la pantalla principal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PbClose_Click(sender As Object, e As EventArgs) Handles PbClose.Click

        'Close
        ScrAlmacen.Show()
        Me.Close()

    End Sub

    ''' <summary>
    ''' Maximiza o minimiza la pantalla, según sea el caso
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PbMax_Click(sender As Object, e As EventArgs) Handles PbMax.Click


        'Valida el estado de la pantalla para tomar la acción correspondiente
        If Me.WindowState = 0 Then
            'Max
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = 2 Then
            'Min
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub

    ''' <summary>
    ''' Minimiza el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PbMin_Click(sender As Object, e As EventArgs) Handles PbMin.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

    ''' <summary>
    ''' Condiciones iniciales de los elementos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrAlmaEntradas_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dtp
        FormatDtp()

        'Control de errores del CboAlma
        Try

            'Index
            CboAlma.SelectedIndex = 0

        Catch ex As Exception

        End Try

        'Control de errores del CboUnidad
        Try

            'Index
            CboUnidades.SelectedIndex = 0

        Catch ex As Exception

        End Try

        'Control de errores del CboEntrada
        Try

            'Index
            CboEntradas.SelectedIndex = 0

        Catch ex As Exception

        End Try

        'Folio
        folioAlma = Now.Year.ToString + Now.Month.ToString + Now.Day.ToString
        folioAlma += Now.Hour.ToString + Now.Minute.ToString + Now.Second.ToString
        folioAlma += "-AL"
        LblFolio.Text = folioAlma

    End Sub

    ''' <summary>
    ''' Valida el valor capturado para habilitar el DtpCaducidad
    ''' Llama al método para realizar la consulta de entradas anteriores
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboAlma_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboAlma.SelectedValueChanged

        'Validación
        If (CboAlma.Text = "Materia Prima") Then

            'Enable
            DtpCaducidad.Enabled = True
            DtpCaducidad.Visible = True
            dateCaduci = DtpCaducidad.Value.ToShortDateString

        Else

            'Disable
            DtpCaducidad.Enabled = False
            DtpCaducidad.Visible = False
            dateCaduci = ""

        End If

    End Sub

    ''' <summary>
    ''' Captura la fecha seleccionada
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DtpEntrada_onValueChanged(sender As Object, e As EventArgs) Handles DtpEntrada.onValueChanged
        dateEntrada = DtpEntrada.Value.ToShortDateString
    End Sub

    ''' <summary>
    ''' Captura la fecha seleccionada
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DtpCaducidad_onValueChanged(sender As Object, e As EventArgs) Handles DtpCaducidad.onValueChanged
        dateCaduci = DtpCaducidad.Value.ToShortDateString
    End Sub

    ''' <summary>
    ''' Valida los textos
    ''' Captura los valores necesarios
    ''' Agrega los valores al DGV
    ''' Re inicia los campos necesarios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        'Validación
        If (String.IsNullOrEmpty(TxtNombre.Text)) Then

            'Usuario
            MsgBox("El texto de Entrada no puede estar vacío...", MsgBoxStyle.Exclamation,
                 "UbiSoft by Ubicamatic - 2020(C)")

            Return

        End If

        If (String.IsNullOrEmpty(TxtCantidad.Text)) Then

            'Usuario
            MsgBox("La cantidad no puede estar vacía...", MsgBoxStyle.Exclamation,
                 "UbiSoft by Ubicamatic - 2020(C)")

            Return

        End If

        'Dgv
        DgvEntradas.Rows.Add(dateEntrada, CboAlma.Text, dateCaduci, TxtNombre.Text, CboUnidades.Text, TxtPack.Text, TxtCantidad.Text)

        'Re inicio de campos
        'Control de errores del CboAlma
        Try

            'Index
            CboAlma.SelectedIndex = 0

        Catch ex As Exception

        End Try

        'Control de errores del CboUnidad
        Try

            'Index
            CboUnidades.SelectedIndex = 0

        Catch ex As Exception

        End Try

        'Control de errores del CboEntrada
        Try

            'Index
            CboEntradas.SelectedIndex = 0

        Catch ex As Exception

        End Try

        'Textos
        TxtNombre.Text = ""
        TxtPack.Text = ""
        TxtCantidad.Text = ""

    End Sub

    ''' <summary>
    ''' Recorre el DGV para extraer los datos y realizar la insercción
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click

        'Contador
        Dim contAdd As Integer = 0

        'Rutina para recorrer las filas del datagridview
        For Each filas As DataGridViewRow In DgvEntradas.Rows

            'Captura el tipo de almacen


        Next

    End Sub

#End Region

End Class