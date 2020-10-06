'Imports
Imports UbiDll
Imports SpreadsheetLight

Public Class ScrConfigProdNew

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim consulta2 As New Consulta
    Dim add As New Agregar
    Dim upd As New Actualizar
    Dim errorMsg As New ErrorMsg

#End Region

#Region "Funciones"

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Carga al cbo la consulta de la tabla prod_uni
    ''' </summary>
    Public Sub FillUnidades()

        'Reset
        consulta._dtsCbo.Reset()

        'Consulta
        consulta.GetUniProd()

        'Dataset 
        CboPack.DataSource = consulta._dtsCbo.Tables("uniProd")

        'Datos
        CboPack.DisplayMember = "tipo_uni"

        'Control de errores
        Try

            'Index
            CboPack.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Carga al cbo la consulta de la tabla productos
    ''' </summary>
    Public Sub FillCatego()

        'Reset
        consulta2._dtsCbo.Reset()

        'Consulta
        consulta2.GetCatProd()

        'Dataset 
        CboCat.DataSource = consulta2._dtsCbo.Tables("catProd")

        'Datos
        CboCat.DisplayMember = "cat_prod"

        'Control de errores
        Try

            'Index
            CboCat.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Re inicia los valores de los textbox
    ''' </summary>
    Private Sub ClearTxt()

        'Txt
        TxtNom.Text = ""
        TxtLp1.Text = ""
        TxtLp2.Text = ""
        TxtLp3.Text = ""
        TxtLp4.Text = ""

    End Sub

    ''' <summary>
    ''' Agrega a un nuevo producto por medio de los datos de los cuadros de texto
    ''' </summary>
    Private Sub AddProdData()

        'Privadas
        Dim flgErr As Boolean = False

        'Valida
        If String.IsNullOrEmpty(TxtNom.Text) Then
            flgErr = True
        ElseIf String.IsNullOrEmpty(TxtLp1.Text) Then
            flgErr = True
        ElseIf String.IsNullOrEmpty(TxtLp2.Text) Then
            flgErr = True
        ElseIf String.IsNullOrEmpty(TxtLp3.Text) Then
            flgErr = True
        ElseIf String.IsNullOrEmpty(TxtLp4.Text) Then
            flgErr = True
        End If

        'Usr
        If flgErr Then

            MsgBox("Uno o varios campos no válidos, favor de verificar", MsgBoxStyle.Exclamation, "UbiSoft by Ubicamatic - 2020(C)")

            Return

        End If

        'Captura
        datos.nom_prod = TxtNom.Text
        datos.cat_prod = CboCat.Text
        datos.pack_prod = CboPack.Text
        datos.lp_1 = TxtLp1.Text
        datos.lp_2 = TxtLp2.Text
        datos.lp_3 = TxtLp3.Text
        datos.lp_4 = TxtLp4.Text

        'Insert 
        If (add.NewProd(datos)) Then

            'Msg Usr
            MsgBox("Nuevo producto agregado", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

            'Re inicia los valores
            ClearTxt()
            FillCatego()

        End If

    End Sub

    ''' <summary>
    ''' Captura los valores del dgv en la clase datos
    ''' Agrega a los productos cargados por medio del archivo de excel al datagridview
    ''' </summary>
    Private Sub AddProdDgv()

        'Privadas
        Dim contAdd As Integer = 0

        'Rutina para recorrer las filas del datagridview
        For Each filas As DataGridViewRow In DgvProd.Rows

            'Captura
            datos.nom_prod = filas.Cells(0).Value
            datos.cat_prod = filas.Cells(1).Value
            datos.pack_prod = filas.Cells(2).Value
            datos.lp_1 = filas.Cells(3).Value
            datos.lp_2 = filas.Cells(4).Value
            datos.lp_3 = filas.Cells(5).Value
            datos.lp_4 = filas.Cells(6).Value

            'Insert & Update
            If (add.NewProd(datos)) Then

                'Incrementamos el contador
                contAdd += 1

            End If

        Next

        'Validación de todos las insert & update
        If (DgvProd.Rows.Count = contAdd) Then

            'Usuario
            MsgBox("Todos los productos fueron agregados con éxito", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

        Else

            'Usuario
            MsgBox("Uno o más productos no pudieron agregarse a la base de datos", MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        End If

        'Limpiar Dgv
        DgvProd.Rows.Clear()

    End Sub

    ''' <summary>
    ''' Abre el diálogo para capturar el path del excel
    ''' Lo pasa como parámetro al método para llenar el dgvProd
    ''' </summary>
    Private Sub OpenExcel()

        'Open
        Dim opnExcel As New OpenFileDialog()

        With opnExcel

            .Title = "Seleccionar archivo"
            .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

            'Validación
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                'Método para llenar el dgvUsr
                FillDgvProd(.FileName, DgvProd)

            End If

        End With

    End Sub

    ''' <summary>
    ''' Recibe el path y el objeto datagrid como parámetros
    ''' Llena el dgv que recibe como parámetro con los datos del excel
    ''' </summary>
    ''' <param name="path"></param>
    ''' <param name="dgv"></param>
    Private Sub FillDgvProd(ByRef path As String, ByVal dgv As DataGridView)

        'Privadas
        Dim filas As Integer = 2

        'Objeto de la clase spreadsheetslight para abrir el contenido del excel
        Dim slExl As New SLDocument(path)


        'Rutina para recorrer todos los datos del archivo
        While (Not String.IsNullOrEmpty(slExl.GetCellValueAsString(filas, 1)))

            'Debug
            'MsgBox(slExl.GetCellValueAsString(filas, 1))

            'Populate DatagridView
            DgvProd.Rows.Add(slExl.GetCellValueAsString(filas, 1), slExl.GetCellValueAsString(filas, 2), slExl.GetCellValueAsString(filas, 3), slExl.GetCellValueAsString(filas, 4), slExl.GetCellValueAsString(filas, 5), slExl.GetCellValueAsString(filas, 6), slExl.GetCellValueAsString(filas, 7))

            'Incrementamos la fila
            filas += 1

        End While

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Llama al método para cargar las unidades
    ''' Llama al método para cargar las categorías
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrConfigProdNew_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Cbo
        FillUnidades()
        FillCatego()

    End Sub

    ''' <summary>
    ''' Valida que el dgv no tenga datos, en caso de ser así llama al método para la inserción por lista
    ''' En caso contrario realiza la inserción por medio de los cuadros de texto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        'Validación
        If (DgvProd.Rows.Count > 0) Then

            'Método para insert por medio de la tabla
            AddProdDgv()

        Else

            'Método para insert de los campos de texto
            AddProdData()

        End If

    End Sub

    ''' <summary>
    ''' LLama al método para abrir el excel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        'Open Excel
        OpenExcel()

    End Sub

    ''' <summary>
    ''' Limpia los valores de los textbox y del datagrid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        'Clear
        ClearTxt()
        DgvProd.Rows.Clear()

    End Sub

#End Region

End Class