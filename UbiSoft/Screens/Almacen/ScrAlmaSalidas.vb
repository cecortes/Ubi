'Imports
Imports UbiDll

Public Class ScrAlmaSalidas

#Region "Variables"

    'Dll
    Dim datos As New Datos
    Dim almagrl As New Datos
    Dim consulta As New Consulta

#End Region

#Region "Funciones y Métodos"

    ''' <summary>
    ''' Realiza la consulta por medio de la DLL a almagral
    ''' Llena el cbo con el resultado
    ''' </summary>
    Private Sub FillCboAlmagral()

        'Reset
        consulta._dtsCbo.Reset()

        'Consulta
        consulta.GetAlmagralCbo()

        'Dataset 
        CboEntraGral.DataSource = consulta._dtsCbo.Tables("almagrl_nom")

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
        consulta._dtsDgv.Reset()

        'Consulta
        consulta.GetAlmagralDgv(datos)

        'Datagrid
        DgvSalGral.DataSource = consulta._dtvDgv

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

    End Sub

    ''' <summary>
    ''' Llama al método para consultar el producto de almagrl
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboEntraGral_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboEntraGral.SelectedValueChanged

        'Consulta
        GetAlmaGrl()

    End Sub

#End Region

End Class