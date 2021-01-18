Public Class ScrVentas

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
    ''' Muestra la pantalla de punto de venta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbCaja_Click(sender As Object, e As EventArgs) Handles pbCaja.Click
        ScrPtoVenta.Show()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Muestra la pantalla para consultar ventas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbConsul_Click(sender As Object, e As EventArgs) Handles pbConsul.Click
        ScrVentaConsul.Show()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Muestra la pantalla para editar las ventas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbEdit_Click(sender As Object, e As EventArgs) Handles pbEdit.Click
        ScrVentasEdit.Show()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Muestra la pantalla para borrar ventas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbDel_Click(sender As Object, e As EventArgs) Handles pbDel.Click
        ScrVentasDel.Show()
        Me.Close()
    End Sub

#End Region
End Class