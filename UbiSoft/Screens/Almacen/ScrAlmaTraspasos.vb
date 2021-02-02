'Imports
Imports UbiDll

Public Class ScrAlmaTraspasos

#Region "Variables"

    'Dll
    Dim datos As New Datos
    Dim dataProdFrom As New Datos
    Dim dataProdTo As New Datos
    Dim cboFrom As New Consulta
    Dim consulta As New Consulta
    Dim dgvData As New Consulta
    Dim borrar As New Eliminar
    Dim add As New Agregar

#End Region

#Region "Funciones y Métodos"

    ''' <summary>
    ''' Realiza la consulta en el almacén seleccionado en el cbotpofrom
    ''' </summary>
    Private Sub GetProdFrom()

        'Rutina para realizar las consultas de acuerdo al almacén
        Select Case CboTpoFrom.Text

            Case "General"

                'Reset
                cboFrom._dtsCbo.Reset()

                'Consulta
                cboFrom.GetAlmagralCbo()

                'Dataset 
                CboNomFrom.DataSource = cboFrom._dtsCbo.Tables("almagrl_nom")

                'Datos
                CboNomFrom.DisplayMember = "almagrl_nom"

                'Control de errores
                Try

                    'Index
                    CboNomFrom.SelectedIndex = 0

                Catch ex As Exception

                End Try

            Case "Refacciones"

                'Reset
                cboFrom._dtsCbo.Reset()

                'Consulta
                cboFrom.GetAlmarefaCbo()

                'Dataset 
                CboNomFrom.DataSource = cboFrom._dtsCbo.Tables("almarefa_nom")

                'Datos
                CboNomFrom.DisplayMember = "almarefa_nom"

                'Control de errores
                Try

                    'Index
                    CboNomFrom.SelectedIndex = 0

                Catch ex As Exception

                End Try

            Case "Materia Prima"

                'Reset
                cboFrom._dtsCbo.Reset()

                'Consulta
                cboFrom.GetAlmapriCbo()

                'Dataset 
                CboNomFrom.DataSource = cboFrom._dtsCbo.Tables("almapri_nom")

                'Datos
                CboNomFrom.DisplayMember = "almapri_nom"

                'Control de errores
                Try

                    'Index
                    CboNomFrom.SelectedIndex = 0

                Catch ex As Exception

                End Try

            Case "Producto Terminado"

                'Reset
                cboFrom._dtsCbo.Reset()

                'Consulta
                cboFrom.GetAlmaterCbo()

                'Dataset 
                CboNomFrom.DataSource = cboFrom._dtsCbo.Tables("almater_nom")

                'Datos
                CboNomFrom.DisplayMember = "almater_nom"

                'Control de errores
                Try

                    'Index
                    CboNomFrom.SelectedIndex = 0

                Catch ex As Exception

                End Try

        End Select

    End Sub

    ''' <summary>
    ''' Carga un objeto con los datos del producto seleccionado
    ''' </summary>
    Private Sub GetProdDataFrom()

        'Rutina para diferenciar entre almacenes
        Select Case CboTpoFrom.Text

            Case "General"

                'Datos
                datos.almagrl_nom = CboNomFrom.Text

                'Consulta
                dataProdFrom = consulta.GetAlmagrlData(datos)

                'Labels
                LblCantiFrom.Text = dataProdFrom.almagrl_canti

                'Generales
                dataProdFrom.almanom = dataProdFrom.almagrl_nom
                dataProdFrom.almauni = dataProdFrom.almagrl_uni
                dataProdFrom.almapack = dataProdFrom.almagrl_pack
                dataProdFrom.almacanti = dataProdFrom.almagrl_canti
                dataProdFrom.almafecha = dataProdFrom.almagrl_fecha

            Case "Refacciones"

                'Datos
                datos.almarefa_nom = CboNomFrom.Text

                'Consulta
                dataProdFrom = consulta.GetAlmarefaData(datos)

                'Labels
                LblCantiFrom.Text = dataProdFrom.almarefa_canti

                'Generales
                dataProdFrom.almanom = dataProdFrom.almarefa_nom
                dataProdFrom.almauni = dataProdFrom.almarefa_uni
                dataProdFrom.almapack = dataProdFrom.almarefa_pack
                dataProdFrom.almacanti = dataProdFrom.almarefa_canti
                dataProdFrom.almafecha = dataProdFrom.almarefa_fecha

            Case "Materia Prima"

                'Datos
                datos.almapri_nom = CboNomFrom.Text

                'Consulta
                dataProdFrom = consulta.GetAlmapriData(datos)

                'Labels
                LblCantiFrom.Text = dataProdFrom.almapri_canti

                'Generales
                dataProdFrom.almanom = dataProdFrom.almapri_nom
                dataProdFrom.almauni = dataProdFrom.almapri_uni
                dataProdFrom.almapack = dataProdFrom.almapri_pack
                dataProdFrom.almacanti = dataProdFrom.almapri_canti
                dataProdFrom.almafecha = dataProdFrom.almapri_fecha
                dataProdFrom.almacadu = dataProdFrom.almapri_cadu

            Case "Producto Terminado"

                'Datos
                datos.almater_nom = CboNomFrom.Text

                'Consulta
                dataProdFrom = consulta.GetAlmaterData(datos)

                'Labels
                LblCantiFrom.Text = dataProdFrom.almater_canti

                'Generales
                dataProdFrom.almanom = dataProdFrom.almater_nom
                dataProdFrom.almauni = dataProdFrom.almater_uni
                dataProdFrom.almapack = dataProdFrom.almater_pack
                dataProdFrom.almacanti = dataProdFrom.almater_canti
                dataProdFrom.almafecha = dataProdFrom.almater_fecha
                dataProdFrom.almacadu = dataProdFrom.almater_cadu

        End Select

    End Sub

    ''' <summary>
    ''' Realiza una consulta de acuerdo al almacén seleccionado en el CboTpoTo
    ''' Carga el resultado en el DGV
    ''' </summary>
    Private Sub GetDgvData()

        'Rutina de casos
        Select Case CboTpoTo.Text

            Case "General"

                'Reset
                dgvData._dtsDgv.Reset()

                'Consulta
                dgvData.GetAlmagralDgv(datos)

                'Datagrid
                DgvTraspaso.DataSource = dgvData._dtvDgv

                'Formato
                FormatDgv()

            Case "Refacciones"

                'Reset
                dgvData._dtsDgv.Reset()

                'Consulta
                dgvData.GetAlmarefaDgv(datos)

                'Datagrid
                DgvTraspaso.DataSource = dgvData._dtvDgv

                'Formato
                FormatDgv()

            Case "Materia Prima"

                'Reset
                dgvData._dtsDgv.Reset()

                'Consulta
                dgvData.GetAlmapriDgv(datos)

                'Datagrid
                DgvTraspaso.DataSource = dgvData._dtvDgv

                'Formato
                FormatDgvCad()

            Case "Producto Terminado"

                'Reset
                dgvData._dtsDgv.Reset()

                'Consulta
                dgvData.GetAlmaterDgv(datos)

                'Datagrid
                DgvTraspaso.DataSource = dgvData._dtvDgv

                'Formato
                FormatDgvCad()

        End Select

    End Sub

    ''' <summary>
    ''' Se encarga de aplicar formato al DgvTraspasos sin fecha de caducidad
    ''' </summary>
    Private Sub FormatDgv()

        'Formato Dgv
        DgvTraspaso.Columns(0).HeaderText = "Nombre Producto"
        DgvTraspaso.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTraspaso.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTraspaso.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvTraspaso.Columns(1).HeaderText = "Unidades"
        DgvTraspaso.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTraspaso.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTraspaso.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvTraspaso.Columns(2).HeaderText = "Pack"
        DgvTraspaso.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTraspaso.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTraspaso.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvTraspaso.Columns(3).HeaderText = "Cantidad"
        DgvTraspaso.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTraspaso.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTraspaso.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvTraspaso.Columns(4).HeaderText = "Tipo Almacén"
        DgvTraspaso.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTraspaso.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTraspaso.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvTraspaso.Columns(5).HeaderText = "Fecha"
        DgvTraspaso.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTraspaso.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTraspaso.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvTraspaso.Refresh()

    End Sub

    ''' <summary>
    ''' Se encarga de aplicar formato al DgvTraspasos con fecha de caducidad
    ''' </summary>
    Private Sub FormatDgvCad()

        'Formato Dgv
        DgvTraspaso.Columns(0).HeaderText = "Nombre Producto"
        DgvTraspaso.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTraspaso.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTraspaso.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvTraspaso.Columns(1).HeaderText = "Unidades"
        DgvTraspaso.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTraspaso.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTraspaso.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvTraspaso.Columns(2).HeaderText = "Pack"
        DgvTraspaso.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTraspaso.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTraspaso.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvTraspaso.Columns(3).HeaderText = "Cantidad"
        DgvTraspaso.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTraspaso.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTraspaso.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvTraspaso.Columns(4).HeaderText = "Tipo Almacén"
        DgvTraspaso.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTraspaso.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTraspaso.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvTraspaso.Columns(5).HeaderText = "Fecha"
        DgvTraspaso.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTraspaso.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTraspaso.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvTraspaso.Columns(6).HeaderText = "Caducidad"
        DgvTraspaso.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTraspaso.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvTraspaso.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvTraspaso.Refresh()

    End Sub

    ''' <summary>
    ''' Consulta si en el almacén de destino existe el producto
    ''' Captura el valor de las unidades del textbox
    ''' Almacena los datos en un objeto
    ''' Si no existe borra de la tabla existente el producto 
    ''' Inserta el producto en la tabla del almacén de destino seleccionado
    ''' </summary>
    Private Sub Traspaso()

        'Case
        Select Case CboTpoTo.Text

            Case "General"

                'Consulta
                datos.almanom = CboNomFrom.Text

                If (consulta.ChkUniqueAlmaGral(datos)) Then

                    'Captura de los datos
                    dataProdTo.almanom = CboNomFrom.Text
                    dataProdTo.almauni = dataProdFrom.almauni
                    dataProdTo.almapack = dataProdFrom.almapack
                    dataProdTo.almacanti = Integer.Parse(TxtCantiTo.Text)
                    dataProdTo.almatpo = "General"
                    dataProdTo.almafecha = dataProdFrom.almafecha

                    'Borrado
                    BorrarFrom()

                    'Insert
                    If (add.NewAlmaGrl(dataProdTo)) Then
                    Else

                        'Usuario
                        MsgBox("Error en el traspaso",
                           MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

                        'Salida
                        Return

                    End If

                    'Refresh
                    CboTpoFrom.SelectedIndex = 0
                    CboTpoTo.SelectedIndex = 0
                    GetProdFrom()
                    TxtCantiTo.Text = ""

                Else

                    'Usuario
                    MsgBox("No se puede realizar el traspaso, el producto ya existe en el almacén",
                       MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

                    'Salida
                    Return

                End If

            Case "Refacciones"

                'Consulta
                datos.almanom = CboNomFrom.Text

                If (consulta.ChkUniqueAlmaRefa(datos)) Then

                    'Captura de los datos
                    dataProdTo.almanom = CboNomFrom.Text
                    dataProdTo.almauni = dataProdFrom.almauni
                    dataProdTo.almapack = dataProdFrom.almapack
                    dataProdTo.almacanti = Integer.Parse(TxtCantiTo.Text)
                    dataProdTo.almatpo = "Refacciones"
                    dataProdTo.almafecha = dataProdFrom.almafecha

                    MsgBox("Antes de borrar: " + dataProdTo.almatpo)
                    Stop
                    'Borrado
                    BorrarFrom()

                    MsgBox("Después de borrar: " + dataProdTo.almatpo)

                    'Insert
                    If (add.NewAlmaRef(dataProdTo)) Then
                    Else

                        'Usuario
                        MsgBox("Error en el traspaso",
                           MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

                        'Salida
                        Return

                    End If

                    'Refresh
                    CboTpoFrom.SelectedIndex = 0
                    CboTpoTo.SelectedIndex = 0
                    GetProdFrom()
                    TxtCantiTo.Text = ""

                Else

                    'Usuario
                    MsgBox("No se puede realizar el traspaso, el producto ya existe en el almacén",
                       MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

                    'Salida
                    Return

                End If

            Case "Materia Prima"

                'Consulta
                datos.almanom = CboNomFrom.Text

                If (consulta.ChkUniqueAlmaPrima(datos)) Then

                    'Captura de los datos
                    dataProdTo.almanom = CboNomFrom.Text
                    dataProdTo.almauni = dataProdFrom.almauni
                    dataProdTo.almapack = dataProdFrom.almapack
                    dataProdTo.almacanti = Integer.Parse(TxtCantiTo.Text)
                    dataProdTo.almatpo = "Materia Prima"
                    dataProdTo.almafecha = dataProdFrom.almafecha
                    dataProdTo.almacadu = dataProdFrom.almacadu

                    'Borrado
                    BorrarFrom()

                    'Insert
                    If (add.NewAlmaPri(dataProdTo)) Then
                    Else

                        'Usuario
                        MsgBox("Error en el traspaso",
                           MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

                        'Salida
                        Return

                    End If

                    'Refresh
                    CboTpoFrom.SelectedIndex = 0
                    CboTpoTo.SelectedIndex = 0
                    GetProdFrom()
                    TxtCantiTo.Text = ""

                Else

                    'Usuario
                    MsgBox("No se puede realizar el traspaso, el producto ya existe en el almacén",
                       MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

                    'Salida
                    Return

                End If

            Case "Producto Terminado"

                'Consulta
                datos.almanom = CboNomFrom.Text

                If (consulta.ChkUniqueAlmaTerm(datos)) Then

                    'Captura de los datos
                    dataProdTo.almanom = CboNomFrom.Text
                    dataProdTo.almauni = dataProdFrom.almauni
                    dataProdTo.almapack = dataProdFrom.almapack
                    dataProdTo.almacanti = Integer.Parse(TxtCantiTo.Text)
                    dataProdTo.almatpo = "Producto Terminado"
                    dataProdTo.almafecha = dataProdFrom.almafecha
                    dataProdTo.almacadu = dataProdFrom.almacadu

                    'Borrado
                    BorrarFrom()

                    'Insert
                    If (add.NewAlmaTer(dataProdTo)) Then
                    Else

                        'Usuario
                        MsgBox("Error en el traspaso",
                           MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

                        'Salida
                        Return

                    End If

                    'Refresh
                    CboTpoFrom.SelectedIndex = 0
                    CboTpoTo.SelectedIndex = 0
                    GetProdFrom()
                    TxtCantiTo.Text = ""

                Else

                    'Usuario
                    MsgBox("No se puede realizar el traspaso, el producto ya existe en el almacén",
                       MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

                    'Salida
                    Return

                End If


        End Select

    End Sub

    ''' <summary>
    ''' Se encarga de borrar el producto de la tabla seleccionada FROM
    ''' </summary>
    Private Sub BorrarFrom()

        'Datos
        datos.almanom = CboNomFrom.Text

        Select Case CboTpoFrom.Text

            Case "General"

                'Delete
                If (borrar.DelProdAlmaGrl(datos)) Then
                Else

                    'Usuario
                    MsgBox("Error en el traspaso",
                       MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

                    'Salida
                    Return

                End If

            Case "Refacciones"

                'Delete
                If (borrar.DelProdAlmaRefa(datos)) Then
                Else

                    'Usuario
                    MsgBox("Error en el traspaso",
                       MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

                    'Salida
                    Return

                End If

            Case "Materia Prima"

                'Delete
                If (borrar.DelProdAlmaPrima(datos)) Then
                Else

                    'Usuario
                    MsgBox("Error en el traspaso",
                       MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

                    'Salida
                    Return

                End If

            Case "Producto Terminado"

                'Delete
                If (borrar.DelProdAlmaTer(datos)) Then
                Else

                    'Usuario
                    MsgBox("Error en el traspaso",
                       MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

                    'Salida
                    Return

                End If

        End Select

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
    ''' Cbo en posición 0
    ''' Cargar producto con el valor del cbo mediante consulta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrAlmaTraspasos_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Cbo
        CboTpoFrom.SelectedIndex = 0
        CboTpoTo.SelectedIndex = 0

        'Consulta
        GetProdFrom()

    End Sub

    ''' <summary>
    ''' Carga el producto con el valor del cbo mediante consulta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboTpoFrom_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboTpoFrom.SelectedValueChanged

        'Consulta
        GetProdFrom()

    End Sub

    ''' <summary>
    ''' Llama al método para obtener los datos del producto seleccionado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboNomFrom_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboNomFrom.SelectedValueChanged

        'Consulta
        GetProdDataFrom()

    End Sub

    ''' <summary>
    ''' Llama al método para realizar la consulta en el DGV
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboTpoTo_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboTpoTo.SelectedValueChanged

        'Consulta
        GetDgvData()

    End Sub

    ''' <summary>
    ''' Llama al método para realizar el traspaso
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnTraspaso_Click(sender As Object, e As EventArgs) Handles BtnTraspaso.Click

        'Traspaso
        Traspaso()

    End Sub

#End Region

End Class