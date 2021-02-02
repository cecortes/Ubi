Public Class ScrAlmacen

#Region "Variables"

#End Region

#Region "Funciones y Métodos"

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Cierra el formulario y abre la pantalla principal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PbClose_Click(sender As Object, e As EventArgs) Handles PbClose.Click

        'Close
        ScrMain.Show()
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
    ''' Muestra la ventana de Entradas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbEntradas_Click(sender As Object, e As EventArgs) Handles pbEntradas.Click
        ScrAlmaEntradas.Show()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Muestra la ventana de salidas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbSalidas_Click(sender As Object, e As EventArgs) Handles pbSalidas.Click
        ScrAlmaSalidas.Show()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Muestra la ventana de traspasos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbTraspasos_Click(sender As Object, e As EventArgs) Handles pbTraspasos.Click
        ScrAlmaTraspasos.Show()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Muestra la ventana de consultas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbConsultas_Click(sender As Object, e As EventArgs) Handles pbConsultas.Click
        ScrAlmaConsultas.Show()
        Me.Close()
    End Sub

#End Region

End Class