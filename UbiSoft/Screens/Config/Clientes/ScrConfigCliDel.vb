'Imports
Imports UbiDll

Public Class ScrConfigCliDel

#Region "Variables"

    'Dll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim borrar As New Eliminar
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
        TxtRfcDel.Text = cliente.rfc_cli
        TxtRazonDel.Text = cliente.razon_cli
        TxtMailDel.Text = cliente.mail_cli
        TxtContactoDel.Text = cliente.contacto_cli
        TxtTelDel.Text = cliente.tel_cli
        TxtDirDel.Text = cliente.dir_cli
        TxtCiudadDel.Text = cliente.ciudad_cli
        TxtEdoDel.Text = cliente.edo_cli

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
        DgvCliDel.DataSource = consulta._dtvDgv

        'Formato Dgv
        DgvCliDel.Columns(8).HeaderText = "Rfc"
        DgvCliDel.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvCliDel.Columns(9).HeaderText = "Razón Social"
        DgvCliDel.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvCliDel.Columns(10).HeaderText = "Correo electrónico"
        DgvCliDel.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvCliDel.Columns(11).HeaderText = "Teléfono"
        DgvCliDel.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvCliDel.Columns(12).HeaderText = "Dirección"
        DgvCliDel.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvCliDel.Columns(13).HeaderText = "Estado"
        DgvCliDel.Columns(13).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvCliDel.Columns(14).HeaderText = "Ciudad"
        DgvCliDel.Columns(14).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvCliDel.Columns(15).Visible = False
        DgvCliDel.Columns(16).Visible = False
        DgvCliDel.Columns(17).HeaderText = "Contacto"
        DgvCliDel.Columns(17).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvCliDel.Refresh()

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
        CboRfcDel.DataSource = consulta._dtsCbo.Tables("rfcCli")

        'Datos
        CboRfcDel.DisplayMember = "rfc_cli"

        'Control de errores
        Try

            'Index
            CboRfcDel.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Captura los valores necesarios en la clase datos
    ''' Realiza el borradp por medio de la Dll para clientes
    ''' Reset del datasource
    ''' Recarga de datos al dgv
    ''' Recarga de datos al cbo
    ''' </summary>
    Private Sub DelCliente()

        'Captura
        datos.rfc_cli = TxtRfcDel.Text
        datos.razon_cli = TxtRazonDel.Text
        datos.mail_cli = TxtMailDel.Text
        datos.contacto_cli = TxtContactoDel.Text
        datos.tel_cli = TxtTelDel.Text
        datos.dir_cli = TxtDirDel.Text
        datos.ciudad_cli = TxtCiudadDel.Text
        datos.edo_cli = TxtEdoDel.Text

        'Update
        If borrar.DelCli(datos) Then

            'Usuario
            MsgBox("El cliente se eliminó correctamente", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

        End If

        'Reset y Reload
        FillDgvAllCli()
        FillCboRfc()

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Llama al método para extraer a los clientes
    ''' Llama al método para extraer a los rfc de los clientes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrConfigCliDel_Load(sender As Object, e As EventArgs) Handles Me.Load

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
    Private Sub CboRfcDel_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboRfcDel.SelectedValueChanged

        'Consulta
        GetCliente(CboRfcDel.Text)

    End Sub

    ''' <summary>
    ''' Obtiene el rfc de la fila / celda seleccionada
    ''' Llama al método para realizar la consulta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvCliDel_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvCliDel.CellMouseClick

        'Privadas
        Dim fila As Integer = DgvCliDel.Rows(e.RowIndex).Index

        'Conuslta
        GetCliente(DgvCliDel.Item(8, fila).Value.ToString)

    End Sub

    ''' <summary>
    ''' Limpia los cuadros de texto y cbo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        'Clean
        TxtRfcDel.Text = ""
        TxtRazonDel.Text = ""
        TxtMailDel.Text = ""
        TxtContactoDel.Text = ""
        TxtTelDel.Text = ""
        TxtDirDel.Text = ""
        TxtCiudadDel.Text = ""
        TxtEdoDel.Text = ""

        'Control de errores
        Try

            'Posición del cbo
            CboRfcDel.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Llama al método para borrar al usuario seleccionado en la base de datos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        'Borrar
        DelCliente()

    End Sub

#End Region

End Class