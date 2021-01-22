'Imports
Imports UbiDll

Public Class ScrVentasDel

#Region "Variables"

    'Dll
    Dim datos As New Datos
    Dim ventaDetalle As New Datos
    Dim consulFol As New Consulta
    Dim consulVta As New Consulta
    Dim consulta As New Consulta
    Dim del As New Eliminar

#End Region

#Region "Funciones y Eventos"

    ''' <summary>
    ''' Carga al cbo los folios distintos de la consulta de la tabla ventas
    ''' </summary>
    Public Sub FillFolios()

        'Reset
        consulFol._dtsCbo.Reset()

        'Consulta
        consulFol.GetFolioVta()

        'Dataset 
        CboFol.DataSource = consulFol._dtsCbo.Tables("ventas_folio")

        'Datos
        CboFol.DisplayMember = "ventas_folio"

        'Control de errores
        Try

            'Index
            CboFol.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Captura el folio de la venta
    ''' Consulta a la tabla ventas para obtner los datos
    ''' Almacena el objeto resultante dentro de una variable global
    ''' Actualiza los elementos necesarios text y labels
    ''' </summary>
    Public Sub GetDetailVenta()

        'Captura
        datos.ventas_folio = CboFol.Text

        'Consulta mediante Dll devuelve un objeto Datos
        ventaDetalle = consulVta.GetVtaDetail(datos)

        'Textos y datos
        LblRfc.Text = ventaDetalle.ventas_rfc
        LblRazon.Text = ventaDetalle.ventas_nom
        LblTot.Text = "$" + ventaDetalle.ventas_tot.ToString("#,###,###.00")

    End Sub

    ''' <summary>
    ''' Se encarga de llenar el datagrid con todas las entradas de la tabla de ventas de acuerdo al folio
    ''' </summary>
    Private Sub GetVtaAll()

        'Reset
        Consulta._dtsDgv.Reset()

        'Consulta
        Consulta.GetAllVta(datos)

        'Datagrid
        DgvVta.DataSource = Consulta._dtvDgv

        'Formato Dgv
        DgvVta.Columns(0).HeaderText = "Nombre Producto"
        DgvVta.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvVta.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvVta.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvVta.Columns(1).HeaderText = "Categoría"
        DgvVta.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvVta.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvVta.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvVta.Columns(2).HeaderText = "Unidades"
        DgvVta.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvVta.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvVta.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvVta.Columns(3).HeaderText = "Cantidad"
        DgvVta.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvVta.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvVta.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvVta.Columns(4).HeaderText = "Precio Unitario"
        DgvVta.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvVta.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvVta.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvVta.Columns(5).HeaderText = "Sub Total"
        DgvVta.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvVta.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvVta.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvVta.Refresh()

    End Sub

    ''' <summary>
    ''' Se encarga de borrar el folio de la tabla de ventas
    ''' </summary>
    Private Sub DelFolioVta()

        'Captura del folio
        datos.ventas_folio = CboFol.Text
        Dim folioVta = datos.ventas_folio

        'Delete 
        If (del.DelFolio(datos)) Then

            'Msg Usr
            MsgBox("Folio de venta eliminado", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

        End If


        'Clear and Reset
        consulta._dtsDgv.Reset()
        DgvVta.DataSource = consulta._dtvDgv
        CboFol.Text = ""
        LblTot.Text = "$ 0.00"

        'Control de errores
        Try

            'Index
            CboFol.SelectedIndex = 0

        Catch ex As Exception

        End Try

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
    ''' Carga los folios en el cbo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrVentasDel_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Cbo
        FillFolios()

    End Sub

    ''' <summary>
    ''' Obtiene los datos del folio de ventas mediante un método de consulta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboFol_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboFol.SelectedValueChanged

        'Detalle de Venta
        GetDetailVenta()

        'Dgv
        GetVtaAll()

    End Sub

    ''' <summary>
    ''' Se encarga de llamar al método para borrar folios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        'Del
        DelFolioVta()

    End Sub

#End Region
End Class