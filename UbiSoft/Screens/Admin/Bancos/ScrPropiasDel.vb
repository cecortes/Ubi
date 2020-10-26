'Imports
Imports UbiDll

Public Class ScrPropiasDel

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim del As New Eliminar
    Dim errorMsg As New ErrorMsg

#End Region

#Region "Funciones y Métodos"

    ''' <summary>
    ''' Se encarga de llenar el datagrid con todas las entradas de la tabla de ctapropia
    ''' </summary>
    Private Sub FillDgvPropia()

        'Reset
        consulta.dgvCode.Reset()

        'Consulta
        consulta.DgvAllCtaPropia()

        'Datagrid
        DgvPropia.DataSource = consulta.dgvCode.Tables("PROPIA")

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

    ''' <summary>
    ''' Limpia los cuadros de texto
    ''' </summary>
    Private Sub ClearTxt()

        'Text
        TxtNombre.Text = ""
        TxtCuenta.Text = ""
        TxtClabe.Text = ""
        TxtTpo.Text = ""
        TxtBanco.Text = ""

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Llama al método para cargar las cuentas propias en el Dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrPropiasDel_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dgv
        FillDgvPropia()

    End Sub

    ''' <summary>
    ''' Obtiene los datos de la fila / celda seleccionada
    ''' Carga los valores en los textbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvPropia_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvPropia.CellMouseClick

        'Privadas
        Dim fila As Integer = DgvPropia.Rows(e.RowIndex).Index

        'Datos
        TxtNombre.Text = DgvPropia.Item(0, fila).Value
        TxtBanco.Text = DgvPropia.Item(1, fila).Value
        TxtCuenta.Text = DgvPropia.Item(3, fila).Value
        TxtTpo.Text = DgvPropia.Item(6, fila).Value
        TxtClabe.Text = DgvPropia.Item(7, fila).Value

    End Sub

    ''' <summary>
    ''' Llama al método para limpiar los campos de texto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        'Clr
        ClearTxt()

    End Sub

#End Region

End Class