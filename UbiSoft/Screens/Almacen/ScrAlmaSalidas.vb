'Imports
Imports UbiDll

Public Class ScrAlmaSalidas

#Region "Variables"

    'Dll
    Dim datos As New Datos
    Dim consulta As New Consulta

#End Region

#Region "Funciones y Métodos"

    ''' <summary>
    ''' Realiza la consulta por medio de la DLL a almagral
    ''' Llena el cbo con el resultado
    ''' </summary>
    Private Sub FillCboAlmagral()

        'Reset
        consulta._dtsCbo.Reset()

        'Consulta
        consulta.GetAlmagralCbo()

        'Dataset 
        CboEntraGral.DataSource = consulta._dtsCbo.Tables("almagrl_nom")

        'Datos
        CboEntraGral.DisplayMember = "almagrl_nom"

        'Control de errores
        Try

            'Index
            CboEntraGral.SelectedIndex = 0

        Catch ex As Exception

        End Try

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
    ''' Inicia los componentes necesarios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrAlmaSalidas_Load(sender As Object, e As EventArgs) Handles Me.Load

        'AlmaGral
        FillCboAlmagral()

    End Sub

#End Region

End Class