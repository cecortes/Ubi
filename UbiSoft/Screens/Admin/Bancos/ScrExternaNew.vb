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
        DgvExt.Sort(DgvExt.Columns("Proveedor"), System.ComponentModel.ListSortDirection.Ascending)

        'Size mode para las columnas
        DgvExt.Columns("Proveedor").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvExt.Columns("Proveedor").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvExt.Columns("RFC").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvExt.Columns("RFC").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvExt.Columns("Mail").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvExt.Columns("Mail").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvExt.Columns("Tel.").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvExt.Columns("Tel.").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvExt.Columns("Beneficiario").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvExt.Columns("Beneficiario").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvExt.Columns("Banco").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvExt.Columns("Banco").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvExt.Columns("Id. SAT").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvExt.Columns("Id. SAT").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvExt.Columns("Cuenta").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvExt.Columns("Cuenta").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvExt.Columns("Plaza").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvExt.Columns("Plaza").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvExt.Columns("Sucursal").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvExt.Columns("Sucursal").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvExt.Columns("Tipo").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvExt.Columns("Tipo").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvExt.Columns("CLABE").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvExt.Columns("CLABE").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvExt.Columns("ABB").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvExt.Columns("ABB").SortMode = DataGridViewColumnSortMode.Programmatic

        DgvExt.Refresh()

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

        'Dgv
        FillDgvExt()

    End Sub

#End Region

End Class