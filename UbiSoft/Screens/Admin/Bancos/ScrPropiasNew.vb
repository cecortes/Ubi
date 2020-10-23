'Imports
Imports UbiDll
Imports System.IO

Public Class ScrPropiasNew

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim add As New Agregar
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
    ''' Limpia los cuadros de texto
    ''' </summary>
    Private Sub ClearTxt()

        'Text
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
    ''' Realiza la inserción en la tabla de ctapropia
    ''' </summary>
    Private Sub AddPropia()

        'Privadas
        Dim flgErr As Boolean = False
        Dim arrayBin As Byte()

        'Validación textos
        If String.IsNullOrEmpty(TxtNombre.Text) Then

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

        End If

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Llama al método para cargar las cuentas propias en el Dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrPropiasNew_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Cbo
        FormatCbo()

        'Dgv
        FillDgvPropia()

    End Sub

    ''' <summary>
    ''' Llama al método para limpiar los campos de texto y reiniciar los cbo
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
        AddPropia()

    End Sub

#End Region

End Class