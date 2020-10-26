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

    ''' <summary>
    ''' Limpia los cuadros de texto
    ''' </summary>
    Private Sub ClearTxt()

        'Text
        TxtRfc.Text = ""
        TxtMail.Text = ""
        TxtNombre.Text = ""
        TxtCuenta.Text = ""
        TxtSuc.Text = ""
        TxtClabe.Text = ""
        TxtPlaza.Text = ""
        TxtAbb.Text = ""

        'Cbo
        FormatCbo()

    End Sub

    ''' <summary>
    ''' Captura los valores de los textbox
    ''' Captura los valores de los cbo
    ''' Realiza la inserción en la tabla de ctasexterna
    ''' </summary>
    Private Sub AddExt()

        'Privadas
        Dim flgErr As Boolean = False

        'Validación textos
        If String.IsNullOrEmpty(TxtRfc.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtNombre.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(CboProv.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(CboBanco.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtCuenta.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtSuc.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtClabe.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(TxtPlaza.Text) Then

            'Flag
            flgErr = True

        ElseIf String.IsNullOrEmpty(CboTpo.Text) Then

            'Flag
            flgErr = True

        End If

        If flgErr Then

            'Usuario
            MsgBox("Uno o varios campos no válidos, favor de verificar", MsgBoxStyle.Exclamation, "UbiSoft by Ubicamatic - 2020(C)")

            Return

        End If

        'Separacion Banco y SAT
        Dim satBanco() As String = Split(CboBanco.Text, "-")
        satBanco(0).Trim()
        satBanco(1).Trim()

        'Captura
        datos.propia_nom = TxtNombre.Text
        datos.propia_banco = satBanco(0)
        datos.propia_keybanco = satBanco(1)
        datos.propia_nocuenta = TxtCuenta.Text
        datos.propia_noplaza = TxtPlaza.Text
        datos.propia_nosuc = TxtSuc.Text
        datos.propia_tipo = CboTpo.Text
        datos.propia_clabe = TxtClabe.Text
        datos.propia_abb = TxtAbb.Text

        'Insert
        If add.NewPropia(datos) Then

            'Msg Usr
            MsgBox("Nueva cuenta propia agregada", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

            'Re inicia los valores
            ClearTxt()
            'Dgv
            FillDgvPropia()

        End If

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

    ''' <summary>
    ''' Realiza un consulta por medio de la Dll
    ''' Actualiza los cbo y textbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboProv_TextChanged(sender As Object, e As EventArgs) Handles CboProv.TextChanged

        'Captura
        datos.ext_nomprov = CboProv.Text

        'Consulta mediante Dll
        Dim ctaexterna As Datos = consulta.GetExtProv(datos)

        'Textos y datos
        TxtRfc.Text = ctaexterna.ext_rfc
        TxtMail.Text = ctaexterna.ext_mail
        TxtNombre.Text = ctaexterna.ext_nom

        'Validación por null

        If (String.IsNullOrEmpty(ctaexterna.ext_banco)) Then
        Else

            CboBanco.Text = ctaexterna.ext_banco

        End If

        TxtCuenta.Text = ctaexterna.ext_nocuenta
        TxtSuc.Text = ctaexterna.ext_nosuc
        TxtClabe.Text = ctaexterna.ext_clabe
        TxtPlaza.Text = ctaexterna.ext_noplaza

        'Validación por null

        If (String.IsNullOrEmpty(ctaexterna.ext_tipo)) Then
        Else

            CboTpo.Text = ctaexterna.ext_tipo

        End If

        TxtAbb.Text = ctaexterna.ext_abb

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
    ''' Llama al método para realizar la insercción
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        'Add
        AddExt()

    End Sub



#End Region

End Class