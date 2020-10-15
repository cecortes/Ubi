'Imports
Imports UbiDll
Imports SpreadsheetLight
Imports System.IO

Public Class ScrConfigInvNew

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim add As New Agregar
    Dim errorMsg As New ErrorMsg

#End Region

#Region "Funciones y Métodos"

    ''' <summary>
    ''' Llena el cbo con cat_inventario de la tabla inventario_cat
    ''' </summary>
    Private Sub FillCboCat()

        'Reset
        consulta._dtsCbo.Reset()

        'Consulta
        consulta.GetAutoTipos()

        'Dataset 
        CboTpo.DataSource = consulta._dtsCbo.Tables("invCat")

        'Datos
        CboTpo.DisplayMember = "cat_inventario"

        'Control de errores
        Try

            'Index
            CboTpo.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Carga las categorías en el cbo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrConfigInvNew_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Cbo
        FillCboCat()

    End Sub

#End Region

End Class