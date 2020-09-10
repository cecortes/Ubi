Public Class ScrConfig

#Region "Variables"

#End Region

#Region "Funciones"

#End Region

#Region "Métodos"

#End Region

#Region "Eventos"

#Region "Controles Usuario"

    ''' <summary>
    ''' Minimiza el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PbMin_Click(sender As Object, e As EventArgs) Handles PbMin.Click

        Me.WindowState = FormWindowState.Minimized

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
    ''' Cierra el formulario y muestra el menú principal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PbClose_Click(sender As Object, e As EventArgs) Handles PbClose.Click

        'Pantalla principal
        ScrMain.Show()

        'Close
        Me.Close()

    End Sub

    ''' <summary>
    ''' Valida el tamaño del panel side y lo cambia según sea el caso
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PbMenu_Click(sender As Object, e As EventArgs) Handles PbMenu.Click

        If (PnlSide.Width = 150) Then

            'Panel mínimo
            PnlSide.Width = 40

            'Hide
            BtnUsuarios.Visible = False
            BtnClientes.Visible = False
            BtnProductos.Visible = False
            BtnPrecios.Visible = False
            BtnMaq.Visible = False
            BtnAutos.Visible = False
            BtnInventario.Visible = False
            BtnMatPrima.Visible = False
            BtnProdTer.Visible = False
            BtnAvanzada.Visible = False

        Else

            'Panel máximo
            PnlSide.Width = 150

            'Hide
            BtnUsuarios.Visible = True
            BtnClientes.Visible = True
            BtnProductos.Visible = True
            BtnPrecios.Visible = True
            BtnMaq.Visible = True
            BtnAutos.Visible = True
            BtnInventario.Visible = True
            BtnMatPrima.Visible = True
            BtnProdTer.Visible = True
            BtnAvanzada.Visible = True

        End If

    End Sub

    ''' <summary>
    ''' Cambia el color de fondo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PbMenu_MouseHover(sender As Object, e As EventArgs) Handles PbMenu.MouseHover

        PbMenu.BackColor = Color.FromKnownColor(KnownColor.Gray)

    End Sub

    ''' <summary>
    ''' Regresa el color de fondo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PbMenu_MouseLeave(sender As Object, e As EventArgs) Handles PbMenu.MouseLeave

        PbMenu.BackColor = Color.FromKnownColor(KnownColor.Transparent)

    End Sub

#End Region

#End Region

End Class