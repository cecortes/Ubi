'Imports
Imports UbiDll

Public Class ScrVentasEdit
#Region "Variables"

    'Dll
    Dim datos As New Datos
    Dim ventaDetalle As New Datos
    Dim consulFol As New Consulta
    Dim consulProd As New Consulta
    Dim consulVta As New Consulta
    Dim errMsg As New ErrorMsg

#End Region

#Region "Funciones y Métodos"

    ''' <summary>
    ''' Carga al cbo la consulta de la tabla productos
    ''' </summary>
    Public Sub FillProd()

        'Reset
        consulProd._dtsCbo.Reset()

        'Consulta
        consulProd.GetNomProd()

        'Dataset 
        CboProd.DataSource = consulProd._dtsCbo.Tables("nomProd")

        'Datos
        CboProd.DisplayMember = "nom_prod"

        'Control de errores
        Try

            'Index
            CboProd.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

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
        TxtRfc.Text = ventaDetalle.ventas_rfc
        TxtNombre.Text = ventaDetalle.ventas_nom
        LblMail.Text = ventaDetalle.ventas_mail
        LblFecha.Text = ventaDetalle.ventas_date
        LblUsr.Text = ventaDetalle.ventas_usr
        LblTot.Text = "$" + ventaDetalle.ventas_tot.ToString("#,###,###.00")

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
    ''' Carga los folios de la tabla de ventas
    ''' Carga los productos de la tabla de productos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrVentasEdit_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Cbo
        FillFolios()
        FillProd()

    End Sub

    ''' <summary>
    ''' Obtiene los datos del producto mediante un método de consulta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboProd_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboProd.SelectedValueChanged

        'Captura
        datos.nom_prod = CboProd.Text

        'Consulta mediante Dll
        Dim producto As Datos = consulProd.GetProd(datos)

        'Textos y datos
        LblPrecio.Text = producto.lp_1.ToString     'Precio fijado
        LblUni.Text = producto.pack_prod
        LblCat.Text = producto.cat_prod

    End Sub

    ''' <summary>
    ''' Obtiene los datos del folio de ventas mediante un método de consulta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboFol_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboFol.SelectedValueChanged

        'Detalle de Venta
        GetDetailVenta()

    End Sub

#End Region
End Class