
Public Class ScrAlmaEntradas

#Region "Variables"

    Dim dateEntrada As String = ""
    Dim dateCaduci As String = ""
    Dim dateIni As String = ""
    Dim dateFin As String = ""

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

        Else

            'Disable
            DtpCaducidad.Enabled = False
            DtpCaducidad.Visible = False

        End If

    End Sub

#End Region

End Class