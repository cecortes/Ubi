'Imports
Imports UbiDll

Public Class ScrExternaDel

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim del As New Eliminar
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

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Carga la información en los cbo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrExternaDel_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Cbo
        FormatCbo()

        'Proveedores
        FillProv()


    End Sub

#End Region

End Class