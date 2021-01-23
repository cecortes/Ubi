'Imports
Imports UbiDll

Public Class ScrVentaConsul

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim errorMsg As New ErrorMsg

    Dim dateIniPer As String = ""
    Dim dateFinPer As String = ""
    Dim dateIniCli As String = ""
    Dim dateFinCli As String = ""

#End Region

#Region "Funciones y Métodos"

    ''' <summary>
    ''' Se encarga de darle formato a los date time picker del formulario
    ''' Cambia el color de fondo cuando hover en ambos dtp
    ''' Carga los valores iniciales en sus respectivas variables globales.
    ''' </summary>
    Private Sub FormatDtp()

        'Textos alineación y Color
        DtpInicial.Style.TextAlign = ContentAlignment.MiddleCenter
        DtpInicial.BorderRadius = 20
        DtpInicial.Style.colhover = Color.FromArgb(79, 52, 90)
        DtpIniCli.Style.TextAlign = ContentAlignment.MiddleCenter
        DtpIniCli.BorderRadius = 20
        DtpIniCli.Style.colhover = Color.FromArgb(79, 52, 90)
        DtpFinal.Style.TextAlign = ContentAlignment.MiddleCenter
        DtpFinal.BorderRadius = 20
        DtpFinal.Style.colhover = Color.FromArgb(79, 52, 90)
        DtpFinCli.Style.TextAlign = ContentAlignment.MiddleCenter
        DtpFinCli.BorderRadius = 20
        DtpFinCli.Style.colhover = Color.FromArgb(79, 52, 90)

        'Captura de las fechas
        DtpInicial.Value = Date.Now.ToShortDateString
        DtpFinal.Value = Date.Now.ToShortDateString
        dateIniPer = DtpInicial.Value.ToShortDateString
        dateFinPer = DtpFinal.Value.ToShortDateString
        DtpIniCli.Value = Date.Now.ToShortDateString
        DtpFinCli.Value = Date.Now.ToShortDateString
        dateIniCli = DtpIniCli.Value.ToShortDateString
        dateFinCli = DtpFinCli.Value.ToShortDateString

    End Sub

    ''' <summary>
    ''' Se encarga de realizar la consulta mediante DLL del periódo seleccionado por los DTP
    ''' </summary>
    Private Sub GetPeriodoVtas()

        'Captura Periódo inicial y final
        datos.periodo_ini = dateIniPer
        datos.periodo_fin = dateFinPer

        'Reset
        consulta.dgvCode.Reset()

        'Consulta
        consulta.GetPerVtas(datos)

        'Datagrid
        DgvPeriod.DataSource = consulta.dgvCode.Tables("PERVTA")

        'Formato al Dgv
        FormatDgv()

    End Sub

    ''' <summary>
    ''' Se encarga de aplicar el formato al DGV
    ''' </summary>
    Private Sub FormatDgv()

        'Formato
        DgvPeriod.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPeriod.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvPeriod.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvPeriod.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPeriod.Columns(1).SortMode = DataGridViewColumnSortMode.Automatic
        DgvPeriod.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvPeriod.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPeriod.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvPeriod.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvPeriod.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPeriod.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvPeriod.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvPeriod.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPeriod.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvPeriod.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvPeriod.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPeriod.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvPeriod.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

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
        ScrVentas.Show()
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
    ''' Carga las fechas actuales en los Dtp
    ''' Llama al método para el formato de los DTP
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrVentaConsul_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Fecha y Formato Dtp
        FormatDtp()

    End Sub

    ''' <summary>
    ''' Cambia el color de fondo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSrchPer_MouseHover(sender As Object, e As EventArgs) Handles BtnSrchPer.MouseHover

        'Color Accent
        BtnSrchPer.BackColor = Color.WhiteSmoke

    End Sub

    ''' <summary>
    ''' Regresa el color de fondo original
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSrchPer_MouseLeave(sender As Object, e As EventArgs) Handles BtnSrchPer.MouseLeave

        'Color normal
        BtnSrchPer.BackColor = Color.FromArgb(156, 191, 167)

    End Sub

    ''' <summary>
    ''' Captura el valor seleccionado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DtpInicial_onValueChanged(sender As Object, e As EventArgs) Handles DtpInicial.onValueChanged

        'Captura
        dateIniPer = DtpInicial.Value.ToShortDateString

    End Sub

    ''' <summary>
    ''' Captura el valor seleccionado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DtpFinal_onValueChanged(sender As Object, e As EventArgs) Handles DtpFinal.onValueChanged

        'Captura
        dateFinPer = DtpFinal.Value.ToShortDateString

    End Sub

    ''' <summary>
    ''' Llama al método para realizar la consulta en el DGV
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSrchPer_Click(sender As Object, e As EventArgs) Handles BtnSrchPer.Click

        'Dgv
        GetPeriodoVtas()

    End Sub

#End Region
End Class