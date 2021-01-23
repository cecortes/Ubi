'Imports
Imports UbiDll

Public Class ScrVentaConsul

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim consulCli As New Consulta
    Dim consulCliDgv As New Consulta
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
    ''' Consulta clientes
    ''' Llena el cbo con los resultados
    ''' </summary>
    Private Sub FillCboRfc()

        'Reset
        consulCli._dtsCbo.Reset()

        'Consulta
        consulCli.GetAllRfc()

        'Dataset 
        CboRfc.DataSource = consulCli._dtsCbo.Tables("rfcCli")

        'Datos
        CboRfc.DisplayMember = "rfc_cli"

        'Control de errores
        Try

            'Index
            CboRfc.SelectedIndex = 0

        Catch ex As Exception

        End Try

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
        FormatDgvPer()

    End Sub

    ''' <summary>
    ''' Se encarga de aplicar el formato al DGV
    ''' </summary>
    Private Sub FormatDgvPer()

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

    ''' <summary>
    ''' Se encarga de realizar la consulta mediante DLL del periódo seleccionado por los DTP
    ''' </summary>
    Private Sub GetClientesVtas()

        'Captura Periódo inicial, final y rfc
        datos.ventas_rfc = CboRfc.Text
        datos.cliente_ini = dateIniCli
        datos.cliente_fin = dateFinCli

        'Reset
        consulCliDgv.dgvCode.Reset()

        'Consulta
        consulCliDgv.GetCliVtas(datos)

        'Datagrid
        DgvCli.DataSource = consulCliDgv.dgvCode.Tables("CLIVTA")

        'Formato al Dgv
        FormatDgvCli()

    End Sub

    ''' <summary>
    ''' Se encarga de aplicar el formato al DGV
    ''' </summary>
    Private Sub FormatDgvCli()

        'Formato
        DgvCli.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvCli.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvCli.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvCli.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvCli.Columns(1).SortMode = DataGridViewColumnSortMode.Automatic
        DgvCli.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvCli.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvCli.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvCli.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvCli.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvCli.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvCli.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvCli.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvCli.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvCli.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvCli.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvCli.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvCli.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

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

        'Cbo
        FillCboRfc()

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
    ''' Cambia el color de fondo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSrchCli_MouseHover(sender As Object, e As EventArgs) Handles BtnSrchCli.MouseHover

        'Color Accent
        BtnSrchCli.BackColor = Color.WhiteSmoke

    End Sub

    ''' <summary>
    ''' Regresa el color de fondo original
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSrchCli_MouseLeave(sender As Object, e As EventArgs) Handles BtnSrchCli.MouseLeave

        'Color normal
        BtnSrchCli.BackColor = Color.FromArgb(156, 191, 167)

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
    ''' Captura el valor seleccionado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DtpIniCli_onValueChanged(sender As Object, e As EventArgs) Handles DtpIniCli.onValueChanged

        'Captura
        dateIniCli = DtpIniCli.Value.ToShortDateString

    End Sub

    ''' <summary>
    ''' Captura el valor seleccionado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DtpFinCli_onValueChanged(sender As Object, e As EventArgs) Handles DtpFinCli.onValueChanged

        dateFinCli = DtpFinCli.Value.ToShortDateString

    End Sub

    ''' <summary>
    ''' Llama al método para realizar la consulta por Periódo en el DGV
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSrchPer_Click(sender As Object, e As EventArgs) Handles BtnSrchPer.Click

        'DgvPer
        GetPeriodoVtas()

    End Sub

    ''' <summary>
    ''' Llama al método para realizar la consulta por Clientes en el DGV
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSrchCli_Click(sender As Object, e As EventArgs) Handles BtnSrchCli.Click

        'DgvCli
        GetClientesVtas()

    End Sub

#End Region
End Class