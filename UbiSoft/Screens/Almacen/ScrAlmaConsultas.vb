'Imports
Imports UbiDll

Public Class ScrAlmaConsultas

#Region "Variables"

    'Dll
    Dim datos As New Datos
    Dim dataProdGral As New Datos
    Dim dataProdRefa As New Datos
    Dim dataProdPri As New Datos
    Dim dataProdTer As New Datos
    Dim consulta As New Consulta
    Dim cboAlmaGral As New Consulta
    Dim cboAlmaRefa As New Consulta
    Dim cboAlmaPri As New Consulta
    Dim cboAlmaTer As New Consulta
    Dim dgvAlmaGral As New Consulta
    Dim dgvAlmaRefa As New Consulta
    Dim dgvAlmaPri As New Consulta
    Dim dgvAlmaTer As New Consulta

#End Region

#Region "Funciones y Métodos"

    ''' <summary>
    ''' Carga el resultado de la consulta de productos para almagral, almarefa, almapri, almater
    ''' </summary>
    Private Sub GetAllCbo()

        'Almacén General
        cboAlmaGral._dtsCbo.Reset()     'Reset

        'Consulta
        cboAlmaGral.GetAlmagralCbo()

        'Dataset 
        CboProdGral.DataSource = cboAlmaGral._dtsCbo.Tables("almagrl_nom")

        'Datos
        CboProdGral.DisplayMember = "almagrl_nom"

        'Control de errores
        Try

            'Index
            CboProdGral.SelectedIndex = 0

        Catch ex As Exception

        End Try

        'Captura
        datos.almagrl_nom = CboProdGral.Text

        'Consulta
        dataProdGral = consulta.GetAlmagrlData(datos)

        'Labels
        LblUniGral.Text = dataProdGral.almagrl_uni
        LblPackGral.Text = dataProdGral.almagrl_pack
        LblCantiGral.Text = dataProdGral.almagrl_canti
        LblFechaGral.Text = dataProdGral.almagrl_fecha

        'Almacén Refacciones
        cboAlmaRefa._dtsCbo.Reset()           'Reset

        'Consulta
        cboAlmaRefa.GetAlmarefaCbo()

        'Dataset 
        CboProdRefa.DataSource = cboAlmaRefa._dtsCbo.Tables("almarefa_nom")

        'Datos
        CboProdRefa.DisplayMember = "almarefa_nom"

        'Control de errores
        Try

            'Index
            CboProdRefa.SelectedIndex = 0

        Catch ex As Exception

        End Try

        'Captura
        datos.almarefa_nom = CboProdRefa.Text

        'Consulta
        dataProdRefa = consulta.GetAlmarefaData(datos)

        'Labels
        LblUniRefa.Text = dataProdRefa.almarefa_uni
        LblPackRefa.Text = dataProdRefa.almarefa_pack
        LblCantiRefa.Text = dataProdRefa.almarefa_canti
        LblFechaRefa.Text = dataProdRefa.almarefa_fecha

        'Almacén Materia Prima
        cboAlmaPri._dtsCbo.Reset()        'Reset

        'Consulta
        cboAlmaPri.GetAlmapriCbo()

        'Dataset 
        CboProdPri.DataSource = cboAlmaPri._dtsCbo.Tables("almapri_nom")

        'Datos
        CboProdPri.DisplayMember = "almapri_nom"

        'Control de errores
        Try

            'Index
            CboProdPri.SelectedIndex = 0

        Catch ex As Exception

        End Try

        'Captura
        datos.almapri_nom = CboProdPri.Text

        'Consulta
        dataProdPri = consulta.GetAlmapriData(datos)

        'Labels
        LblUniPri.Text = dataProdPri.almapri_uni
        LblPackPri.Text = dataProdPri.almapri_pack
        LblCantiPri.Text = dataProdPri.almapri_canti
        LblFechaPri.Text = dataProdPri.almapri_fecha
        LblCaduPri.Text = dataProdPri.almapri_cadu

        'Almacén Producto Terminado
        cboAlmaTer._dtsCbo.Reset()        'Reset

        'Consulta
        cboAlmaTer.GetAlmaterCbo()

        'Dataset 
        CboProdTer.DataSource = cboAlmaTer._dtsCbo.Tables("almater_nom")

        'Datos
        CboProdTer.DisplayMember = "almater_nom"

        'Control de errores
        Try

            'Index
            CboProdTer.SelectedIndex = 0

        Catch ex As Exception

        End Try

        'Captura
        datos.almater_nom = CboProdTer.Text

        'Consulta
        dataProdTer = consulta.GetAlmaterData(datos)

        'Labels
        LblUniTer.Text = dataProdTer.almater_uni
        LblPackTer.Text = dataProdTer.almater_pack
        LblCantiTer.Text = dataProdTer.almater_canti
        LblFechaTer.Text = dataProdTer.almater_fecha
        LblCaduTer.Text = dataProdTer.almater_cadu

    End Sub

    ''' <summary>
    ''' Realiza la consulta para almagral, almarefa, almapri, almater
    ''' Carga los resultados en los DGV correspondientes para cada almacén
    ''' </summary>
    Private Sub GetAllDgv()

        'Almacén General
        dgvAlmaGral._dtsDgv.Reset()        'Reset

        'Consulta
        dgvAlmaGral.GetAlmagralDgv(datos)

        'Datagrid
        DgvGral.DataSource = dgvAlmaGral._dtvDgv

        'Almacén Refacciones
        dgvAlmaRefa._dtsDgv.Reset()        'Reset

        'Consulta
        dgvAlmaRefa.GetAlmarefaDgv(datos)

        'Datagrid
        DgvRefa.DataSource = dgvAlmaRefa._dtvDgv

        'Almacén Materia Prima
        dgvAlmaPri._dtsDgv.Reset()        'Reset

        'Consulta
        dgvAlmaPri.GetAlmapriDgv(datos)

        'Datagrid
        DgvPri.DataSource = dgvAlmaPri._dtvDgv

        'Almacén Producto Terminado
        dgvAlmaTer._dtsDgv.Reset()        'Reset

        'Consulta
        dgvAlmaTer.GetAlmaterDgv(datos)

        'Datagrid
        DgvTer.DataSource = dgvAlmaTer._dtvDgv

        'Formato DGV AlmaGral
        DgvGral.Columns(0).HeaderText = "Nombre Producto"
        DgvGral.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvGral.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvGral.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvGral.Columns(1).HeaderText = "Unidades"
        DgvGral.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvGral.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvGral.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvGral.Columns(2).HeaderText = "Pack"
        DgvGral.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvGral.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvGral.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvGral.Columns(3).HeaderText = "Cantidad"
        DgvGral.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvGral.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvGral.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvGral.Columns(4).HeaderText = "Tipo Almacén"
        DgvGral.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvGral.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvGral.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvGral.Columns(5).HeaderText = "Fecha"
        DgvGral.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvGral.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvGral.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvGral.Refresh()

        'Formato DGV AlmaRefa
        DgvRefa.Columns(0).HeaderText = "Nombre Producto"
        DgvRefa.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvRefa.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvRefa.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvRefa.Columns(1).HeaderText = "Unidades"
        DgvRefa.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvRefa.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvRefa.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvRefa.Columns(2).HeaderText = "Pack"
        DgvRefa.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvRefa.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvRefa.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvRefa.Columns(3).HeaderText = "Cantidad"
        DgvRefa.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvRefa.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvRefa.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvRefa.Columns(4).HeaderText = "Tipo Almacén"
        DgvRefa.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvRefa.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvRefa.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvRefa.Columns(5).HeaderText = "Fecha"
        DgvRefa.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvRefa.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvRefa.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvRefa.Refresh()

        'Formato DGV AlmaPri
        DgvPri.Columns(0).HeaderText = "Nombre Producto"
        DgvPri.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPri.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvPri.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvPri.Columns(1).HeaderText = "Unidades"
        DgvPri.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPri.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvPri.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvPri.Columns(2).HeaderText = "Pack"
        DgvPri.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPri.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvPri.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvPri.Columns(3).HeaderText = "Cantidad"
        DgvPri.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPri.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvPri.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvPri.Columns(4).HeaderText = "Tipo Almacén"
        DgvPri.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPri.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvPri.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvPri.Columns(5).HeaderText = "Fecha"
        DgvPri.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPri.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvPri.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvPri.Columns(6).HeaderText = "Caducidad"
        DgvPri.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPri.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvPri.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvPri.Refresh()

        'Formato DGV AlmaTer
        DgvTer.Columns(0).HeaderText = "Nombre Producto"
        DgvTer.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTer.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTer.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvTer.Columns(1).HeaderText = "Unidades"
        DgvTer.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTer.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTer.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvTer.Columns(2).HeaderText = "Pack"
        DgvTer.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTer.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTer.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvTer.Columns(3).HeaderText = "Cantidad"
        DgvTer.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTer.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTer.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvTer.Columns(4).HeaderText = "Tipo Almacén"
        DgvTer.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTer.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTer.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvTer.Columns(5).HeaderText = "Fecha"
        DgvTer.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTer.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTer.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvTer.Columns(6).HeaderText = "Caducidad"
        DgvTer.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTer.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTer.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvTer.Refresh()

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Carga los cbo con los datos de todos los almacénes
    ''' Carga los DGV con los datos de todos los almacénes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrAlmaConsultas_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Cbo
        GetAllCbo()

        'Dgv
        GetAllDgv()

    End Sub

    ''' <summary>
    ''' Captura el valor dentro de datos
    ''' Llama al método para realizar la consulta
    ''' Recibe el resultado y actualiza las etiquetas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboProdGral_TextChanged(sender As Object, e As EventArgs) Handles CboProdGral.TextChanged

        'Captura
        datos.almagrl_nom = CboProdGral.Text

        'Consulta
        dataProdGral = consulta.GetAlmagrlData(datos)

        'Labels
        LblUniGral.Text = dataProdGral.almagrl_uni
        LblPackGral.Text = dataProdGral.almagrl_pack
        LblCantiGral.Text = dataProdGral.almagrl_canti
        LblFechaGral.Text = dataProdGral.almagrl_fecha

    End Sub

    ''' <summary>
    ''' Captura el valor dentro de datos
    ''' Llama al método para realizar la consulta
    ''' Recibe el resultado y actualiza las etiquetas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboProdRefa_TextChanged(sender As Object, e As EventArgs) Handles CboProdRefa.TextChanged

        'Captura
        datos.almarefa_nom = CboProdRefa.Text

        'Consulta
        dataProdRefa = consulta.GetAlmarefaData(datos)

        'Labels
        LblUniRefa.Text = dataProdRefa.almarefa_uni
        LblPackRefa.Text = dataProdRefa.almarefa_pack
        LblCantiRefa.Text = dataProdRefa.almarefa_canti
        LblFechaRefa.Text = dataProdRefa.almarefa_fecha

    End Sub

    ''' <summary>
    ''' Captura el valor dentro de datos
    ''' Llama al método para realizar la consulta
    ''' Recibe el resultado y actualiza las etiquetas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboProdPri_TextChanged(sender As Object, e As EventArgs) Handles CboProdPri.TextChanged

        'Captura
        datos.almapri_nom = CboProdPri.Text

        'Consulta
        dataProdPri = consulta.GetAlmapriData(datos)

        'Labels
        LblUniPri.Text = dataProdPri.almapri_uni
        LblPackPri.Text = dataProdPri.almapri_pack
        LblCantiPri.Text = dataProdPri.almapri_canti
        LblFechaPri.Text = dataProdPri.almapri_fecha
        LblCaduPri.Text = dataProdPri.almapri_cadu

    End Sub

    ''' <summary>
    ''' Captura el valor dentro de datos
    ''' Llama al método para realizar la consulta
    ''' Recibe el resultado y actualiza las etiquetas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboProdTer_TextChanged(sender As Object, e As EventArgs) Handles CboProdTer.TextChanged

        'Captura
        datos.almater_nom = CboProdTer.Text

        'Consulta
        dataProdTer = consulta.GetAlmaterData(datos)

        'Labels
        LblUniTer.Text = dataProdTer.almater_uni
        LblPackTer.Text = dataProdTer.almater_pack
        LblCantiTer.Text = dataProdTer.almater_canti
        LblFechaTer.Text = dataProdTer.almater_fecha
        LblCaduTer.Text = dataProdTer.almater_cadu

    End Sub

#End Region

End Class