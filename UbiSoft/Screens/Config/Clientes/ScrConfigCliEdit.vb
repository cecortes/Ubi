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
    ''' Realiza la consulta del rfc seleccionado en el cbo
    ''' Captura el resultado en los textbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboRfcEdit_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboRfcEdit.SelectedValueChanged

        If CboRfcEdit.SelectedIndex > 0 Then
            MsgBox("FIN")
        End If

        'Consulta
        datos.rfc_cli = CboRfcEdit.Text

        MsgBox(datos.rfc_cli)

    End Sub

#End Region

End Class