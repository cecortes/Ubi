'Imports
Imports UbiDll

Public Class ScrExternaNew

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim add As New Agregar
    Dim errorMsg As New ErrorMsg

#End Region

#Region "Funciones y Métodos"

    ''' <summary>
    ''' Formato para poner a o los índices de los cbo
    ''' </summary>
    Private Sub FormatCbo()

        'Manejo de Errores
        Try

            'Cbo Bancos
            CboBanco.SelectedIndex = 0

        Catch ex As Exception

        End Try

        Try

            'Cbo Tpo
            CboTpo.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Carga al cbo la consulta de la tabla proveedors
    ''' </summary>
    Public Sub FillProv()

        'Reset
        consulta._dtsCbo.Reset()

        'Consulta
        consulta.GetAllProv()

        'Dataset 
        CboProv.DataSource = consulta._dtsCbo.Tables("nomProv")

        'Datos
        CboProv.DisplayMember = "razon_prov"

        'Control de errores
        Try

            'Index
            CboProv.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Se encarga de llenar el datagrid con todas las entradas de la tabla de ctasexterna
    ''' </summary>
    Private Sub FillDgvExt()

        'Reset
        consulta.dgvCode.Reset()

        'Consulta
        consulta.DgvAllCtaExt()

        'Datagrid
        DgvExt.DataSource = consulta.dgvCode.Tables("EXTERNA")

        'Formato al Dgv
        FormatDgv()

    End Sub

    ''' <summary>
    ''' Formato para el datagridview
    ''' </summary>
    Private Sub FormatDgv()

        'Sort Descending
        DgvPropia.Sort(DgvPropia.Columns("Nombre"), System.ComponentModel.ListSortDirection.Ascending)

        'Size mode para las columnas
        DgvPropia.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvPropia.Columns("Nombre").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvPropia.Columns("Banco").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvPropia.Columns("Banco").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvPropia.Columns("Id SAT").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvPropia.Columns("Id SAT").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvPropia.Columns("No. de Cuenta").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvPropia.Columns("No. de Cuenta").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvPropia.Columns("Plaza").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvPropia.Columns("Plaza").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvPropia.Columns("Sucursal").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvPropia.Columns("Sucursal").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvPropia.Columns("Tipo").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvPropia.Columns("Tipo").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvPropia.Columns("CLABE").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvPropia.Columns("CLABE").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvPropia.Columns("ABB").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvPropia.Columns("ABB").SortMode = DataGridViewColumnSortMode.Programmatic

        DgvPropia.Refresh()

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Carga la información en los cbo
    ''' Carga la información en los dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrExternaNew_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Cbo
        FormatCbo()

        'Proveedores
        FillProv()

    End Sub

#End Region

End Class