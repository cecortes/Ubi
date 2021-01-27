'Imports
Imports UbiDll

Public Class ScrAlmaEntradas

#Region "Variables"

    'Dll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim add As New Agregar
    Dim errMsg As New ErrorMsg

    Dim dateEntrada As String = ""
    Dim dateCaduci As String = ""
    Dim dateIni As String = ""
    Dim dateFin As String = ""
    Dim folioAlma As String = ""

#End Region

#Region "Funciones y Métodos"

    ''' <summary>
    ''' Se encarga de darle formato a los date time picker del formulario
    ''' Cambia el color de fondo cuando hover en ambos dtp
    ''' Carga los valores iniciales en sus respectivas variables globales.
    ''' </summary>
    Private Sub FormatDtp()

        'Textos alineación y Color
        DtpEntrada.Style.TextAlign = ContentAlignment.MiddleCenter
        DtpEntrada.BorderRadius = 20
        DtpEntrada.Style.colhover = Color.FromArgb(79, 52, 90)

        DtpCaducidad.Style.TextAlign = ContentAlignment.MiddleCenter
        DtpCaducidad.BorderRadius = 20
        DtpCaducidad.Style.colhover = Color.FromArgb(79, 52, 90)

        DtpAlmaIni.Style.TextAlign = ContentAlignment.MiddleCenter
        DtpAlmaIni.BorderRadius = 20
        DtpAlmaIni.Style.colhover = Color.FromArgb(79, 52, 90)

        DtpAlmaFin.Style.TextAlign = ContentAlignment.MiddleCenter
        DtpAlmaFin.BorderRadius = 20
        DtpAlmaFin.Style.colhover = Color.FromArgb(79, 52, 90)

        'Captura de las fechas
        DtpEntrada.Value = Date.Now.ToShortDateString
        DtpCaducidad.Value = Date.Now.ToShortDateString
        dateEntrada = DtpEntrada.Value.ToShortDateString
        dateCaduci = DtpCaducidad.Value.ToShortDateString
        DtpAlmaIni.Value = Date.Now.ToShortDateString
        DtpAlmaFin.Value = Date.Now.ToShortDateString
        dateIni = DtpAlmaIni.Value.ToShortDateString
        dateFin = DtpAlmaFin.Value.ToShortDateString

    End Sub

    ''' <summary>
    ''' Se encarga de realizar la consulta mediante DLL del periódo seleccionado por los DTP
    ''' </summary>
    Private Sub GetPeriodoVtas()

        'Captura Periódo inicial y final
        datos.periodo_ini = dateIni
        datos.periodo_fin = dateFin

        'Reset
        consulta.dgvCode.Reset()

        'Consulta
        consulta.GetFolAlma(datos)

        'Datagrid
        DgvAlmaEntrada.DataSource = consulta.dgvCode.Tables("PERALMA")

        'Formato al Dgv
        FormatDgvAlma()

    End Sub

    ''' <summary>
    ''' Se encarga de aplicar el formato al DGV
    ''' </summary>
    Private Sub FormatDgvAlma()

        'Formato
        DgvAlmaEntrada.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvAlmaEntrada.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvAlmaEntrada.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvAlmaEntrada.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvAlmaEntrada.Columns(1).SortMode = DataGridViewColumnSortMode.Automatic
        DgvAlmaEntrada.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvAlmaEntrada.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvAlmaEntrada.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvAlmaEntrada.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvAlmaEntrada.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvAlmaEntrada.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvAlmaEntrada.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvAlmaEntrada.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvAlmaEntrada.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvAlmaEntrada.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvAlmaEntrada.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvAlmaEntrada.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvAlmaEntrada.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvAlmaEntrada.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvAlmaEntrada.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        DgvAlmaEntrada.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

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
    ''' Condiciones iniciales de los elementos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrAlmaEntradas_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dtp
        FormatDtp()

        'Control de errores del CboAlma
        Try

            'Index
            CboAlma.SelectedIndex = 0

        Catch ex As Exception

        End Try

        'Control de errores del CboUnidad
        Try

            'Index
            CboUnidades.SelectedIndex = 0

        Catch ex As Exception

        End Try

        'Control de errores del CboEntrada
        Try

            'Index
            CboEntradas.SelectedIndex = 0

        Catch ex As Exception

        End Try

        'Folio
        folioAlma = Now.Year.ToString + Now.Month.ToString + Now.Day.ToString
        folioAlma += Now.Hour.ToString + Now.Minute.ToString + Now.Second.ToString
        folioAlma += "-AL"
        LblFolio.Text = folioAlma

    End Sub

    ''' <summary>
    ''' Valida el valor capturado para habilitar el DtpCaducidad
    ''' Llama al método para realizar la consulta de entradas anteriores
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboAlma_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboAlma.SelectedValueChanged

        'Validación
        If (CboAlma.Text = "Materia Prima") Then

            'Enable
            DtpCaducidad.Enabled = True
            DtpCaducidad.Visible = True
            dateCaduci = DtpCaducidad.Value.ToShortDateString

        ElseIf (CboAlma.Text = "Producto Terminado") Then

            'Enable
            DtpCaducidad.Enabled = True
            DtpCaducidad.Visible = True
            dateCaduci = DtpCaducidad.Value.ToShortDateString

        Else

            'Disable
            DtpCaducidad.Enabled = False
            DtpCaducidad.Visible = False
            dateCaduci = ""

        End If

    End Sub

    ''' <summary>
    ''' Captura la fecha seleccionada
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DtpEntrada_onValueChanged(sender As Object, e As EventArgs) Handles DtpEntrada.onValueChanged
        dateEntrada = DtpEntrada.Value.ToShortDateString
    End Sub

    ''' <summary>
    ''' Captura la fecha seleccionada
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DtpCaducidad_onValueChanged(sender As Object, e As EventArgs) Handles DtpCaducidad.onValueChanged
        dateCaduci = DtpCaducidad.Value.ToShortDateString
    End Sub

    ''' <summary>
    ''' Captura la fecha seleccionada
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DtpAlmaIni_onValueChanged(sender As Object, e As EventArgs) Handles DtpAlmaIni.onValueChanged
        dateIni = DtpAlmaIni.Value.ToShortDateString
    End Sub

    ''' <summary>
    ''' Captura la fecha seleccionada
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DtpAlmaFin_onValueChanged(sender As Object, e As EventArgs) Handles DtpAlmaFin.onValueChanged
        dateFin = DtpAlmaFin.Value.ToShortDateString
    End Sub

    ''' <summary>
    ''' Valida los textos
    ''' Captura los valores necesarios
    ''' Agrega los valores al DGV
    ''' Re inicia los campos necesarios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        'Validación
        If (String.IsNullOrEmpty(TxtNombre.Text)) Then

            'Usuario
            MsgBox("El texto de Entrada no puede estar vacío...", MsgBoxStyle.Exclamation,
                 "UbiSoft by Ubicamatic - 2020(C)")

            Return

        End If

        If (String.IsNullOrEmpty(TxtCantidad.Text)) Then

            'Usuario
            MsgBox("La cantidad no puede estar vacía...", MsgBoxStyle.Exclamation,
                 "UbiSoft by Ubicamatic - 2020(C)")

            Return

        End If

        'Dgv
        DgvEntradas.Rows.Add(dateEntrada, CboAlma.Text, dateCaduci, TxtNombre.Text, CboUnidades.Text, TxtPack.Text, TxtCantidad.Text)

        'Re inicio de campos
        ''Control de errores del CboAlma
        'Try

        '    'Index
        '    CboAlma.SelectedIndex = 0

        'Catch ex As Exception

        'End Try

        ''Control de errores del CboUnidad
        'Try

        '    'Index
        '    CboUnidades.SelectedIndex = 0

        'Catch ex As Exception

        'End Try

        ''Control de errores del CboEntrada
        'Try

        '    'Index
        '    CboEntradas.SelectedIndex = 0

        'Catch ex As Exception

        'End Try

        'Textos
        TxtNombre.Text = ""
        TxtPack.Text = ""
        TxtCantidad.Text = ""

    End Sub

    ''' <summary>
    ''' Recorre el DGV para extraer los datos y realizar la insercción
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click

        'Contador
        Dim contAdd As Integer = 0

        'Rutina para recorrer las filas del datagridview
        For Each filas As DataGridViewRow In DgvEntradas.Rows

            'Valida el tipo de almacén
            Select Case filas.Cells(1).Value

                Case "General"

                    'Captura de datos
                    datos.alma_gral_folio = folioAlma
                    datos.alma_gral_fecha = filas.Cells(0).Value
                    datos.alma_gral_tpo = filas.Cells(1).Value
                    datos.alma_gral_nom = filas.Cells(3).Value
                    datos.alma_gral_uni = filas.Cells(4).Value
                    datos.alma_gral_pack = filas.Cells(5).Value
                    datos.alma_gral_canti = Integer.Parse(filas.Cells(6).Value)

                    'Insert en la tabla alma_general
                    If (add.NewAlmaGral(datos)) Then

                        'Incrementamos el contador
                        contAdd += 1

                    End If

                Case "Refacciones"

                    'Captura de datos
                    datos.alma_refa_folio = folioAlma
                    datos.alma_refa_fecha = filas.Cells(0).Value
                    datos.alma_refa_tpo = filas.Cells(1).Value
                    datos.alma_refa_nom = filas.Cells(3).Value
                    datos.alma_refa_uni = filas.Cells(4).Value
                    datos.alma_refa_pack = filas.Cells(5).Value
                    datos.alma_refa_canti = Integer.Parse(filas.Cells(6).Value)

                    'Insert en la tabla alma_general
                    If (add.NewAlmaRefa(datos)) Then

                        'Incrementamos el contador
                        contAdd += 1

                    End If

                Case "Materia Prima"

                    'Captura de datos
                    datos.alma_prima_folio = folioAlma
                    datos.alma_prima_fecha = filas.Cells(0).Value
                    datos.alma_prima_tpo = filas.Cells(1).Value
                    datos.alma_prima_cadu = filas.Cells(2).Value
                    datos.alma_prima_nom = filas.Cells(3).Value
                    datos.alma_prima_uni = filas.Cells(4).Value
                    datos.alma_prima_pack = filas.Cells(5).Value
                    datos.alma_prima_canti = Integer.Parse(filas.Cells(6).Value)

                    'Insert en la tabla alma_general
                    If (add.NewAlmaPrima(datos)) Then

                        'Incrementamos el contador
                        contAdd += 1

                    End If

                Case "Producto Terminado"

                    'Captura de datos
                    datos.alma_prod_folio = folioAlma
                    datos.alma_prod_fecha = filas.Cells(0).Value
                    datos.alma_prod_tpo = filas.Cells(1).Value
                    datos.alma_prod_cadu = filas.Cells(2).Value
                    datos.alma_prod_nom = filas.Cells(3).Value
                    datos.alma_prod_uni = filas.Cells(4).Value
                    datos.alma_prod_pack = filas.Cells(5).Value
                    datos.alma_prod_canti = Integer.Parse(filas.Cells(6).Value)

                    'Insert en la tabla alma_general
                    If (add.NewAlmaProd(datos)) Then

                        'Incrementamos el contador
                        contAdd += 1

                    End If

            End Select

        Next

        'Validación de todos las insert & update
        If (DgvEntradas.Rows.Count = contAdd) Then

            'Usuario
            MsgBox("Todos las entradas fueron agregadas con éxito", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

        Else

            'Usuario
            MsgBox("Una o más entradas no pudieron agregarse a la base de datos", MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        End If

        'Limpiar Dgv
        DgvEntradas.Rows.Clear()

    End Sub

    ''' <summary>
    ''' Llama al método para realizar la consulta por periódo de fechas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSrchFol_Click(sender As Object, e As EventArgs) Handles BtnSrchFol.Click

        'Consulta
        GetPeriodoVtas()

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click

    End Sub

#End Region

End Class