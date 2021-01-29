'Imports
Imports UbiDll

Public Class ScrAlmaSalidas

#Region "Variables"

    'Dll
    Dim datos As New Datos
    Dim almagrl As New Datos
    Dim almarefa As New Datos
    Dim almapri As New Datos
    Dim almater As New Datos
    Dim consulta As New Consulta
    Dim cboGral As New Consulta
    Dim cboRefa As New Consulta
    Dim cboPri As New Consulta
    Dim cboTer As New Consulta
    Dim dgvGral As New Consulta
    Dim dgvRefa As New Consulta
    Dim dgvPri As New Consulta
    Dim dgvTer As New Consulta

#End Region

#Region "Funciones y Métodos"

    ''' <summary>
    ''' Realiza la consulta por medio de la DLL a almagral
    ''' Llena el cbo con el resultado
    ''' </summary>
    Private Sub FillCboAlmagral()

        'Reset
        cboGral._dtsCbo.Reset()

        'Consulta
        cboGral.GetAlmagralCbo()

        'Dataset 
        CboEntraGral.DataSource = cboGral._dtsCbo.Tables("almagrl_nom")

        'Datos
        CboEntraGral.DisplayMember = "almagrl_nom"

        'Control de errores
        Try

            'Index
            CboEntraGral.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Realiza la consulta por medio de la DLL a almagral
    ''' Llena el dgv con el resultado
    ''' </summary>
    Private Sub FillDgvAlmagral()

        'Reset
        dgvGral._dtsDgv.Reset()

        'Consulta
        dgvGral.GetAlmagralDgv(datos)

        'Datagrid
        DgvSalGral.DataSource = dgvGral._dtvDgv

        'Formato Dgv
        DgvSalGral.Columns(0).HeaderText = "Nombre Producto"
        DgvSalGral.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalGral.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalGral.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvSalGral.Columns(1).HeaderText = "Unidades"
        DgvSalGral.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalGral.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalGral.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvSalGral.Columns(2).HeaderText = "Pack"
        DgvSalGral.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalGral.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalGral.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvSalGral.Columns(3).HeaderText = "Cantidad"
        DgvSalGral.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalGral.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalGral.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvSalGral.Columns(4).HeaderText = "Tipo Almacén"
        DgvSalGral.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalGral.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalGral.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvSalGral.Columns(5).HeaderText = "Fecha"
        DgvSalGral.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalGral.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalGral.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvSalGral.Refresh()

    End Sub

    ''' <summary>
    ''' Captura el valor del cbo
    ''' Realiza la consulta de los datos del valor seleccionado en el cbo
    ''' Actualiza los campos con el resultado
    ''' </summary>
    Private Sub GetAlmaGrl()

        'Captura
        datos.almagrl_nom = CboEntraGral.Text

        'Consulta mediante Dll devuelve un objeto Datos
        almagrl = consulta.GetAlmagrlData(datos)

        'Textos y datos
        LblUniGral.Text = almagrl.almagrl_uni
        LblPackGral.Text = almagrl.almagrl_pack
        LblCantiGral.Text = almagrl.almagrl_canti

    End Sub

    ''' <summary>
    ''' Realiza la consulta por medio de la DLL a almarefa
    ''' Llena el cbo con el resultado
    ''' </summary>
    Private Sub FillCboAlmarefa()

        'Reset
        cboRefa._dtsCbo.Reset()

        'Consulta
        cboRefa.GetAlmarefaCbo()

        'Dataset 
        CboEntraRefa.DataSource = cboRefa._dtsCbo.Tables("almarefa_nom")

        'Datos
        CboEntraRefa.DisplayMember = "almarefa_nom"

        'Control de errores
        Try

            'Index
            CboEntraRefa.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Realiza la consulta por medio de la DLL a almarefa
    ''' Llena el dgv con el resultado
    ''' </summary>
    Private Sub FillDgvAlmarefa()

        'Reset
        dgvRefa._dtsDgv.Reset()

        'Consulta
        dgvRefa.GetAlmarefaDgv(datos)

        'Datagrid
        DgvSalRefa.DataSource = dgvRefa._dtvDgv

        'Formato Dgv
        DgvSalRefa.Columns(0).HeaderText = "Nombre Producto"
        DgvSalRefa.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalRefa.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalRefa.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvSalRefa.Columns(1).HeaderText = "Unidades"
        DgvSalRefa.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalRefa.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalRefa.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvSalRefa.Columns(2).HeaderText = "Pack"
        DgvSalRefa.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalRefa.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalRefa.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvSalRefa.Columns(3).HeaderText = "Cantidad"
        DgvSalRefa.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalRefa.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalRefa.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvSalRefa.Columns(4).HeaderText = "Tipo Almacén"
        DgvSalRefa.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalRefa.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalRefa.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvSalRefa.Columns(5).HeaderText = "Fecha"
        DgvSalRefa.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalRefa.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalRefa.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvSalRefa.Refresh()

    End Sub

    ''' <summary>
    ''' Captura el valor del cbo
    ''' Realiza la consulta de los datos del valor seleccionado en el cbo
    ''' Actualiza los campos con el resultado
    ''' </summary>
    Private Sub GetAlmaRefa()

        'Captura
        datos.almarefa_nom = CboEntraRefa.Text

        'Consulta mediante Dll devuelve un objeto Datos
        almarefa = consulta.GetAlmarefaData(datos)

        'Textos y datos
        LblUniRefa.Text = almarefa.almarefa_uni
        LblPackRefa.Text = almarefa.almarefa_pack
        LblCantiRefa.Text = almarefa.almarefa_canti

    End Sub

    ''' <summary>
    ''' Realiza la consulta por medio de la DLL a almapri
    ''' Llena el cbo con el resultado
    ''' </summary>
    Private Sub FillCboAlmapri()

        'Reset
        cboPri._dtsCbo.Reset()

        'Consulta
        cboPri.GetAlmapriCbo()

        'Dataset 
        CboEntraPrima.DataSource = cboPri._dtsCbo.Tables("almapri_nom")

        'Datos
        CboEntraPrima.DisplayMember = "almapri_nom"

        'Control de errores
        Try

            'Index
            CboEntraPrima.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Realiza la consulta por medio de la DLL a almapri
    ''' Llena el dgv con el resultado
    ''' </summary>
    Private Sub FillDgvAlmapri()

        'Reset
        dgvPri._dtsDgv.Reset()

        'Consulta
        dgvPri.GetAlmapriDgv(datos)

        'Datagrid
        DgvSalPrima.DataSource = dgvPri._dtvDgv

        'Formato Dgv
        DgvSalPrima.Columns(0).HeaderText = "Nombre Producto"
        DgvSalPrima.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalPrima.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalPrima.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvSalPrima.Columns(1).HeaderText = "Unidades"
        DgvSalPrima.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalPrima.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalPrima.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvSalPrima.Columns(2).HeaderText = "Pack"
        DgvSalPrima.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalPrima.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalPrima.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvSalPrima.Columns(3).HeaderText = "Cantidad"
        DgvSalPrima.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalPrima.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalPrima.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvSalPrima.Columns(4).HeaderText = "Tipo Almacén"
        DgvSalPrima.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalPrima.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalPrima.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvSalPrima.Columns(5).HeaderText = "Fecha"
        DgvSalPrima.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalPrima.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalPrima.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvSalPrima.Columns(6).HeaderText = "Fecha Caducidad"
        DgvSalPrima.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalPrima.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalPrima.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvSalPrima.Refresh()

    End Sub

    ''' <summary>
    ''' Captura el valor del cbo
    ''' Realiza la consulta de los datos del valor seleccionado en el cbo
    ''' Actualiza los campos con el resultado
    ''' </summary>
    Private Sub GetAlmaPri()

        'Captura
        datos.almapri_nom = CboEntraPrima.Text

        'Consulta mediante Dll devuelve un objeto Datos
        almapri = consulta.GetAlmapriData(datos)

        'Textos y datos
        LBlUniPrima.Text = almapri.almapri_uni
        LblPackPrima.Text = almapri.almapri_pack
        LblCantiPrima.Text = almapri.almapri_canti

    End Sub

    ''' <summary>
    ''' Realiza la consulta por medio de la DLL a almater
    ''' Llena el cbo con el resultado
    ''' </summary>
    Private Sub FillCboAlmater()

        'Reset
        cboTer._dtsCbo.Reset()

        'Consulta
        cboTer.GetAlmaterCbo()

        'Dataset 
        CboEntraTermi.DataSource = cboTer._dtsCbo.Tables("almater_nom")

        'Datos
        CboEntraTermi.DisplayMember = "almater_nom"

        'Control de errores
        Try

            'Index
            CboEntraTermi.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Realiza la consulta por medio de la DLL a almater
    ''' Llena el dgv con el resultado
    ''' </summary>
    Private Sub FillDgvAlmater()

        'Reset
        dgvTer._dtsDgv.Reset()

        'Consulta
        dgvTer.GetAlmaterDgv(datos)

        'Datagrid
        DgvSalTermi.DataSource = dgvTer._dtvDgv

        'Formato Dgv
        DgvSalTermi.Columns(0).HeaderText = "Nombre Producto"
        DgvSalTermi.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalTermi.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalTermi.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvSalTermi.Columns(1).HeaderText = "Unidades"
        DgvSalTermi.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalTermi.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalTermi.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvSalTermi.Columns(2).HeaderText = "Pack"
        DgvSalTermi.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalTermi.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalTermi.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvSalTermi.Columns(3).HeaderText = "Cantidad"
        DgvSalTermi.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalTermi.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalTermi.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvSalTermi.Columns(4).HeaderText = "Tipo Almacén"
        DgvSalTermi.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalTermi.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalTermi.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvSalTermi.Columns(5).HeaderText = "Fecha"
        DgvSalTermi.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalTermi.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalTermi.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvSalTermi.Columns(6).HeaderText = "Fecha Caducidad"
        DgvSalTermi.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvSalTermi.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvSalTermi.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvSalTermi.Refresh()

    End Sub

    ''' <summary>
    ''' Captura el valor del cbo
    ''' Realiza la consulta de los datos del valor seleccionado en el cbo
    ''' Actualiza los campos con el resultado
    ''' </summary>
    Private Sub GetAlmaTer()

        'Captura
        datos.almater_nom = CboEntraTermi.Text

        'Consulta mediante Dll devuelve un objeto Datos
        almater = consulta.GetAlmaterData(datos)

        'Textos y datos
        LblUniTermi.Text = almater.almater_uni
        LblPackTermi.Text = almater.almater_pack
        LblCantiTermi.Text = almater.almater_canti

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
    ''' Inicia los componentes necesarios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrAlmaSalidas_Load(sender As Object, e As EventArgs) Handles Me.Load

        'AlmaGral
        FillCboAlmagral()
        FillDgvAlmagral()

        'AlmaRefa
        FillCboAlmarefa()
        FillDgvAlmarefa()

        'AlmaPri
        FillCboAlmapri()
        FillDgvAlmapri()

        'AlmaTer
        FillCboAlmater()
        FillDgvAlmater()

    End Sub

    ''' <summary>
    ''' Llama al método para consultar el producto de almagrl
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboEntraGral_TextChanged(sender As Object, e As EventArgs) Handles CboEntraGral.TextChanged

        'Consulta
        GetAlmaGrl()

    End Sub

    ''' <summary>
    ''' Llama al método para consultar el producto de almarefa
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboEntraRefa_TextChanged(sender As Object, e As EventArgs) Handles CboEntraRefa.TextChanged

        'Consulta
        GetAlmaRefa()

    End Sub

    ''' <summary>
    ''' Llama al método para consultar el producto de almapri
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboEntraPrima_TextChanged(sender As Object, e As EventArgs) Handles CboEntraPrima.TextChanged

        'Consulta
        GetAlmaPri()

    End Sub

    ''' <summary>
    ''' Llama al método para consultar el producto de almater
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboEntraTermi_TextChanged(sender As Object, e As EventArgs) Handles CboEntraTermi.TextChanged

        'Consulta
        GetAlmaTer()

    End Sub

#End Region

End Class