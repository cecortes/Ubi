'Imports
Imports UbiDll
Imports SpreadsheetLight

Public Class ScrConfigProdEdit

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim consulta2 As New Consulta
    Dim consulta3 As New Consulta
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
    ''' Carga al cbo la consulta de la tabla productos
    ''' </summary>
    Public Sub FillProd()

        'Reset
        consulta3._dtsCbo.Reset()

        'Consulta
        consulta3.GetNomProd()

        'Dataset 
        CboNom.DataSource = consulta3._dtsCbo.Tables("nomProd")

        'Datos
        CboNom.DisplayMember = "nom_prod"

        'Control de errores
        Try

            'Index
            CboNom.SelectedIndex = 0

        Catch ex As Exception

        End Try

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

            'Captura
            Dim nombre As String = slExl.GetCellValueAsString(filas, 1)
            Dim cat As String = slExl.GetCellValueAsString(filas, 2)
            Dim unidad As String = slExl.GetCellValueAsString(filas, 3)
            Dim l1 As String = slExl.GetCellValueAsString(filas, 4)
            Dim l2 As String = slExl.GetCellValueAsString(filas, 5)
            Dim l3 As String = slExl.GetCellValueAsString(filas, 6)
            Dim l4 As String = slExl.GetCellValueAsString(filas, 7)

            'Validación
            If String.IsNullOrEmpty(l1) Then
                l1 = "0.00"
            ElseIf String.IsNullOrEmpty(l2) Then
                l2 = "0.00"
            ElseIf String.IsNullOrEmpty(l3) Then
                l3 = "0.00"
            ElseIf String.IsNullOrEmpty(l4) Then
                l4 = "0.00"
            End If

            'Populate DatagridView
            DgvProd.Rows.Add(nombre, cat, unidad, l1, l2, l3, l4)

            'Incrementamos la fila
            filas += 1

        End While

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Carga los datos de los cbo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrConfigProdEdit_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Cbo
        FillProd()
        FillUnidades()
        FillCatego()

    End Sub

    ''' <summary>
    ''' Obtiene los datos del producto mediante un método de consulta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboNom_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboNom.SelectedValueChanged

        'Captura
        datos.nom_prod = CboNom.Text

        'Consulta mediante Dll
        Dim producto As Datos = consulta.GetProd(datos)

        'Textos y datos
        TxtNom.Text = producto.nom_prod
        TxtLp1.Text = producto.lp_1.ToString
        TxtLp2.Text = producto.lp_2.ToString
        TxtLp3.Text = producto.lp_3.ToString
        TxtLp4.Text = producto.lp_4.ToString
        CboPack.Text = producto.pack_prod
        CboCat.Text = producto.cat_prod

    End Sub

    ''' <summary>
    ''' LLama al método para abrir el excel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnImport_Click(sender As Object, e As EventArgs) Handles BtnImport.Click

        'Open Excel
        OpenExcel()

    End Sub

#End Region

End Class