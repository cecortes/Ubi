'Imports
Imports UbiDll

Public Class ScrVentasEdit
#Region "Variables"

    'Dll
    Dim datos As New Datos
    Dim ventaDetalle As New Datos
    Dim consulta As New Consulta
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

    ''' <summary>
    ''' Se encarga de llenar el datagrid con todas las entradas de la tabla de ventas de acuerdo al folio
    ''' </summary>
    Private Sub GetVtaAll()

        'Reset
        consulta._dtsDgv.Reset()

        'Consulta
        consulta.GetAllVta(datos)

        'Datagrid
        DgvVta.DataSource = consulta._dtvDgv

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
    ''' Recorre las filas del DGV para sumar los subtotales
    ''' Convierte los valores a decimal
    ''' Almacena el resultado en una variable
    ''' Da formato para actualizar la etiqueta Total
    ''' </summary>
    Private Sub CalculaTotal()

        'Locales
        Dim subTotStr As String = ""
        Dim subTotDec As Decimal = 0.00
        Dim totalDec As Decimal = 0.00

        'Recorre el DGV ventas
        For Each filas As DataGridViewRow In DgvVta.Rows

            'Subtotal
            subTotStr = filas.Cells(5).Value

            'Control de errores Decimal Parse
            Try

                'Conversión
                subTotDec = Decimal.Parse(subTotStr)

            Catch ex As Exception

            End Try

            'Cálculo del Total
            totalDec += subTotDec

        Next

        'Etiqueta Total
        LblTot.Text = totalDec.ToString("$ #,###,##0.00")

        'Reset Variables
        subTotStr = ""
        subTotDec = 0.00

        'Recorre el DGV ventas add
        For Each fila As DataGridViewRow In DgvVtaAdd.Rows

            'Subtotal
            subTotStr = fila.Cells(5).Value

            'Control de errores Decimal Parse
            Try

                'Conversión
                subTotDec = Decimal.Parse(subTotStr)

            Catch ex As Exception

            End Try

            'Cálculo del Total
            totalDec += subTotDec

        Next

        'Etiqueta Total
        LblTot.Text = totalDec.ToString("$ #,###,##0.00")

    End Sub

    ''' <summary>
    ''' Se encarga de borrar el folio de la tabla de ventas
    ''' </summary>
    Private Sub DelFolioVta()

        'Captura del folio
        datos.ventas_folio = CboFol.Text



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

        'Dgv
        GetVtaAll()

        'Detalle de Venta
        GetDetailVenta()

    End Sub

    ''' <summary>
    ''' Llama al método para calcular el total de las ventas del DGV
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvVta_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DgvVta.RowsRemoved

        'Cálculo del Total
        CalculaTotal()

    End Sub

    ''' <summary>
    ''' Llama al método para calcular el total
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvVtaAdd_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DgvVtaAdd.RowsAdded

        'Cálculo Total
        CalculaTotal()

    End Sub

    ''' <summary>
    ''' Valida los datos antes de capturarlos
    ''' Captura los datos necesarios y los agrega en el dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        'Validación
        If String.IsNullOrEmpty(CboProd.Text) Then

            MsgBox("Seleccione un producto válido...", MsgBoxStyle.Exclamation,
                  "UbiSoft by Ubicamatic - 2020(C)")

            Return

        End If

        If String.IsNullOrEmpty(TxtCanti.Text) Then

            MsgBox("La cantidad no puede estar vacía...", MsgBoxStyle.Exclamation,
                  "UbiSoft by Ubicamatic - 2020(C)")

            Return

        End If

        'Variables del sub total
        Dim cantidadInt = 0
        Dim precioDec As Decimal = 0.0
        Dim subDec As Decimal = 0.0

        'Control Excepciones
        Try

            'Conversión de unidades
            cantidadInt = Integer.Parse(TxtCanti.Text)

        Catch ex As Exception

            'Usuario
            MsgBox("La cantidad debe ser entera...", MsgBoxStyle.Exclamation,
                  "UbiSoft by Ubicamatic - 2020(C)")

            Return

        End Try

        Try

            'Eliminar $
            Dim precio As String = LblPrecio.Text
            precio = precio.Replace("$", "")

            'Conversión de unidades
            precioDec = Decimal.Parse(precio)

        Catch ex As Exception

            'Usuario
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation,
                  "UbiSoft by Ubicamatic - 2020(C)")

            Return

        End Try

        'Cálculo del sub total
        subDec = precioDec * cantidadInt
        Dim subTotal As String = subDec.ToString

        'Cálculo del TOTAL
        'totalVta += subDec
        'LblTot.Text = totalVta.ToString("#,###,###.00")

        'DGV
        DgvVtaAdd.Rows.Add(CboProd.Text, LblCat.Text, LblUni.Text, TxtCanti.Text, LblPrecio.Text, subTotal)

        'Formato Dgv
        DgvVtaAdd.Columns(0).HeaderText = "Nombre Producto"
        DgvVtaAdd.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvVtaAdd.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvVtaAdd.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvVtaAdd.Columns(1).HeaderText = "Categoría"
        DgvVtaAdd.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvVtaAdd.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvVtaAdd.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvVtaAdd.Columns(2).HeaderText = "Unidades"
        DgvVtaAdd.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvVtaAdd.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvVtaAdd.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvVtaAdd.Columns(3).HeaderText = "Cantidad"
        DgvVtaAdd.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvVtaAdd.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvVtaAdd.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvVtaAdd.Columns(4).HeaderText = "Precio Unitario"
        DgvVtaAdd.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvVtaAdd.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvVtaAdd.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvVtaAdd.Columns(5).HeaderText = "Sub Total"
        DgvVtaAdd.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvVtaAdd.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvVtaAdd.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvVtaAdd.Refresh()

        'Clear Text
        TxtCanti.Text = ""

    End Sub

    ''' <summary>
    ''' Borra el folio de la tabla de ventas
    ''' Alta del folio en la tabla de ventas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click

        'Borrar folio
        DelFolioVta()

    End Sub

#End Region
End Class