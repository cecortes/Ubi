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
    ''' Realiza la consulta del rfc seleccionado en el cbo
    ''' Captura el resultado en los textbox
    ''' </summary>
    Private Sub GetCliente(ByVal rfc As String)

        'Privadas
        Dim cliente As New Datos

        'Consulta para datos del cliente
        datos.rfc_cli = rfc
        cliente = consulta.GetCli(datos)

        'Textbox
        TxtRfcEdit.Text = cliente.rfc_cli
        TxtRazonEdit.Text = cliente.razon_cli
        TxtMailEdit.Text = cliente.mail_cli
        TxtContactoEdit.Text = cliente.contacto_cli
        TxtTelEdit.Text = cliente.tel_cli
        TxtDirEdit.Text = cliente.dir_cli
        TxtCiudadEdit.Text = cliente.ciudad_cli
        TxtEdoEdit.Text = cliente.edo_cli

    End Sub

    ''' <summary>
    ''' Se encarga de llenar el datagrid con todas las entradas de la tabla de clientes
    ''' </summary>
    Private Sub FillDgvAllCli()

        'Reset
        consulta._dtsDgv.Reset()

        'Consulta
        consulta.GetAllCli()

        'Datagrid
        DgvCliEdit.DataSource = consulta._dtvDgv

        'Formato Dgv
        DgvCliEdit.Columns(8).HeaderText = "Rfc"
        DgvCliEdit.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvCliEdit.Columns(9).HeaderText = "Razón Social"
        DgvCliEdit.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvCliEdit.Columns(10).HeaderText = "Correo electrónico"
        DgvCliEdit.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvCliEdit.Columns(11).HeaderText = "Teléfono"
        DgvCliEdit.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvCliEdit.Columns(12).HeaderText = "Dirección"
        DgvCliEdit.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvCliEdit.Columns(13).HeaderText = "Estado"
        DgvCliEdit.Columns(13).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvCliEdit.Columns(14).HeaderText = "Ciudad"
        DgvCliEdit.Columns(14).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvCliEdit.Columns(15).Visible = False
        DgvCliEdit.Columns(16).Visible = False
        DgvCliEdit.Columns(17).HeaderText = "Contacto"
        DgvCliEdit.Columns(17).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvCliEdit.Refresh()

    End Sub

    ''' <summary>
    ''' Consulta clientes
    ''' Llena el cbo con los resultados
    ''' </summary>
    Private Sub FillCboRfc()

        'Reset
        consulta._dtsCbo.Reset()

        'Consulta
        consulta.GetAllRfc()

        'Dataset 
        CboRfcEdit.DataSource = consulta._dtsCbo.Tables("rfcCli")

        'Datos
        CboRfcEdit.DisplayMember = "rfc_cli"

        'Control de errores
        Try

            'Index
            CboRfcEdit.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Captura los valores necesarios en la clase datos
    ''' Realiza la actualización por medio de la Dll para clientes
    ''' Reset del datasource
    ''' Recarga de datos al dgv
    ''' Recarga de datos al cbo
    ''' </summary>
    Private Sub EditCli()

        'Captura
        datos.rfc_cli = TxtRfcEdit.Text
        datos.razon_cli = TxtRazonEdit.Text
        datos.mail_cli = TxtMailEdit.Text
        datos.contacto_cli = TxtContactoEdit.Text
        datos.tel_cli = TxtTelEdit.Text
        datos.dir_cli = TxtDirEdit.Text
        datos.ciudad_cli = TxtCiudadEdit.Text
        datos.edo_cli = TxtEdoEdit.Text


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
        FillCboRfc()

    End Sub

    ''' <summary>
    ''' Llama al método para realizar la consulta del cliente
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboRfcEdit_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboRfcEdit.SelectedValueChanged

        'Consulta
        GetCliente(CboRfcEdit.Text)

    End Sub

    ''' <summary>
    ''' Obtiene el rfc de la fila / celda seleccionada
    ''' Llama al método para realizar la consulta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvCliEdit_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvCliEdit.CellMouseClick

        'Privadas
        Dim fila As Integer = DgvCliEdit.Rows(e.RowIndex).Index

        'Conuslta
        GetCliente(DgvCliEdit.Item(8, fila).Value.ToString)

    End Sub

    ''' <summary>
    ''' Limpia los cuadros de texto y cbo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        'Clean
        TxtRfcEdit.Text = ""
        TxtRazonEdit.Text = ""
        TxtMailEdit.Text = ""
        TxtContactoEdit.Text = ""
        TxtTelEdit.Text = ""
        TxtDirEdit.Text = ""
        TxtCiudadEdit.Text = ""
        TxtEdoEdit.Text = ""

        'Control de errores
        Try

            'Posición del cbo
            CboRfcEdit.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Llama al método para editar al usuario seleccionado en la base de datos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        'Editar
        EditCli()

    End Sub

#End Region

End Class