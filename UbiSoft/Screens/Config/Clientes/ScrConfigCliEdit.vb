'Imports
Imports UbiDll

Public Class ScrConfigCliEdit

#Region "Variables"

    'Dll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim upd As New Actualizar
    Dim errMsg As New ErrorMsg

#End Region

#Region "Funciones"

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Se encarga de llenar el datagrid con todas las entradas de la tabla de clientes
    ''' </summary>
    Private Sub FillDgvAllCli()

        'Reset
        consulta._dtsDgv.Reset()

        'Consulta
        consulta.GetAllUsr()

        'Datagrid
        DgvCliEdit.DataSource = consulta._dtvDgv

        'Formato Dgv
        DgvCliEdit.Columns(9).HeaderText = "Rfc"
        DgvCliEdit.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvCliEdit.Columns(10).HeaderText = "Razón Social"
        DgvCliEdit.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvCliEdit.Columns(11).HeaderText = "Correo electrónico"
        DgvCliEdit.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvCliEdit.Columns(12).HeaderText = "Contacto"
        DgvCliEdit.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvCliEdit.Columns(13).HeaderText = "Teléfono"
        DgvCliEdit.Columns(13).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvCliEdit.Columns(14).HeaderText = "Dirección"
        DgvCliEdit.Columns(14).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvCliEdit.Columns(15).HeaderText = "Ciudad"
        DgvCliEdit.Columns(15).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvCliEdit.Columns(16).HeaderText = "Estado"
        DgvCliEdit.Columns(16).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvCliEdit.Refresh()

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Llama al método para extraer a los clientes
    ''' Llama al método para extraer a los rfc de los clientes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrConfigCliEdit_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dgv
        FillDgvAllCli()

        'Cbo
        'FillCboUnidad()

    End Sub

#End Region

End Class