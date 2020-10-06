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


    End Sub

#End Region

End Class