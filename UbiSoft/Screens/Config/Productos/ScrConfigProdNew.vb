'Imports
Imports UbiDll
Imports SpreadsheetLight

Public Class ScrConfigProdNew

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
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

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Llama al método para cargar las unidades
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrConfigProdNew_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Cbo
        FillUnidades()

    End Sub

#End Region

End Class