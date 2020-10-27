'Imports
Imports UbiDll

Public Class ScrExternaDel

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim del As New Eliminar
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
        DgvExt.Columns("CLABE").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvExt.Columns("CLABE").SortMode = DataGridViewColumnSortMode.Programmatic
        DgvExt.Columns("ABB").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvExt.Columns("ABB").SortMode = DataGridViewColumnSortMode.Programmatic

        DgvExt.Refresh()

    End Sub

    ''' <summary>
    ''' Limpia los cuadros de texto
    ''' </summary>
    Private Sub ClearTxt()

        'Text
        TxtRfc.Text = ""
        TxtNombre.Text = ""
        TxtCuenta.Text = ""
        TxtSuc.Text = ""
        TxtClabe.Text = ""

        'Cbo
        FormatCbo()

    End Sub

    ''' <summary>
    ''' Captura la key ext_nocuenta
    ''' Realiza el borrado en la tabla de ctasexterna
    ''' </summary>
    Private Sub DelExterna()

        'Captura
        datos.ext_nocuenta = TxtCuenta.Text

        'Delete
        If del.DelExt(datos) Then

            'Msg Usr
            MsgBox("Cuenta externa eliminada", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

            'Re inicia los valores
            ClearTxt()

            'Captura
            datos.ext_nomprov = CboProv.Text

            'Reset
            consulta.dgvCode.Reset()

            'Consulta
            consulta.DgvCtaExt(datos)

            'Datagrid
            DgvExt.DataSource = consulta.dgvCode.Tables("EXTERNA")

            'Formato al Dgv
            FormatDgv()

        End If

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Carga la información en los cbo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrExternaDel_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Cbo
        FormatCbo()

        'Proveedores
        FillProv()


    End Sub

    ''' <summary>
    ''' Realiza un consulta por medio de la Dll
    ''' Llena el dgv con el resultado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboProv_TextChanged(sender As Object, e As EventArgs) Handles CboProv.TextChanged

        'Captura
        datos.ext_nomprov = CboProv.Text

        'Reset
        consulta.dgvCode.Reset()

        'Consulta
        consulta.DgvCtaExt(datos)

        'Datagrid
        DgvExt.DataSource = consulta.dgvCode.Tables("EXTERNA")

        'Formato al Dgv
        FormatDgv()

    End Sub

    ''' <summary>
    ''' Obtiene los datos de la fila / celda seleccionada
    ''' Carga los valores en los textbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvExt_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvExt.CellMouseClick

        'Privadas
        Dim fila As Integer = DgvExt.Rows(e.RowIndex).Index

        'Datos
        TxtRfc.Text = DgvExt.Item(1, fila).Value
        TxtNombre.Text = DgvExt.Item(4, fila).Value
        CboBanco.Text = DgvExt.Item(5, fila).Value
        TxtCuenta.Text = DgvExt.Item(7, fila).Value
        TxtSuc.Text = DgvExt.Item(9, fila).Value
        CboTpo.Text = DgvExt.Item(10, fila).Value
        TxtClabe.Text = DgvExt.Item(11, fila).Value

    End Sub

    ''' <summary>
    ''' Llama al método para limpiar los campos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        'Clr
        ClearTxt()

    End Sub

    ''' <summary>
    ''' Llama al método para borrar ctasexterna
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        'Del
        DelExterna()

    End Sub

#End Region

End Class