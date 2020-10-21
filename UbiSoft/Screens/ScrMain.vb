Public Class ScrMain

#Region "Variables"

    Public Shared unidad As String

#End Region

#Region "Funciones"

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Mediante un select mustra los controles de usuario adecuados
    ''' </summary>
    ''' <param name="op">As string</param>
    Private Sub EnableCtrl(ByVal op As String)

        Select Case op

            Case "ADMIN"
                BtnConfig.Enabled = True
                BtnAdmin.Enabled = True
                BtnAlmacen.Enabled = True
                BtnManto.Enabled = True
                BtnProd.Enabled = True
                BtnVentas.Enabled = True

            Case "ADMINISTRACION"
                BtnConfig.Enabled = True
                BtnAdmin.Enabled = True
                BtnAlmacen.Enabled = False
                BtnManto.Enabled = False
                BtnProd.Enabled = False
                BtnVentas.Enabled = False

            Case "ALMACEN"
                BtnConfig.Enabled = False
                BtnAdmin.Enabled = False
                BtnAlmacen.Enabled = True
                BtnManto.Enabled = False
                BtnProd.Enabled = False
                BtnVentas.Enabled = False

            Case "PRODUCCION"
                BtnConfig.Enabled = False
                BtnAdmin.Enabled = False
                BtnAlmacen.Enabled = False
                BtnManto.Enabled = False
                BtnProd.Enabled = True
                BtnVentas.Enabled = False

            Case "VENTAS"
                BtnConfig.Enabled = False
                BtnAdmin.Enabled = False
                BtnAlmacen.Enabled = False
                BtnManto.Enabled = False
                BtnProd.Enabled = False
                BtnVentas.Enabled = True

            Case Else
                BtnConfig.Enabled = False
                BtnAdmin.Enabled = False
                BtnAlmacen.Enabled = False
                BtnManto.Enabled = False
                BtnProd.Enabled = False
                BtnVentas.Enabled = False

        End Select

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Llama al método para evaluar los controles a mostrar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        EnableCtrl(unidad)

    End Sub

    ''' <summary>
    ''' Cierra el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PbClose_Click(sender As Object, e As EventArgs) Handles PbClose.Click

        'Cierre
        Me.Close()
        Application.Exit()

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
    ''' Muestra el formulario de configuración
    ''' Cierra el formulario actual
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnConfig_Click(sender As Object, e As EventArgs) Handles BtnConfig.Click

        ScrConfig.Show()
        Me.Close()

    End Sub

    ''' <summary>
    ''' Muestra el formulario de administración
    ''' Cierra el formulario actual
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmin.Click

        ScrAdmin.Show()
        Me.Close()

    End Sub

    ''' <summary>
    ''' Muestra el formulario de almacén
    ''' Cierra el formulario actual
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnAlmacen_Click(sender As Object, e As EventArgs) Handles BtnAlmacen.Click

        'ScrAlmacen.Show()
        Me.Close()

    End Sub

    ''' <summary>
    ''' Muestra el formulario de producción
    ''' Cierra el formulario actual
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnProd_Click(sender As Object, e As EventArgs) Handles BtnProd.Click

        'ScrProd.Show()
        Me.Close()

    End Sub

    ''' <summary>
    ''' Muestra el formulario de mantenimiento
    ''' Cierra el formulario actual
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnManto_Click(sender As Object, e As EventArgs) Handles BtnManto.Click

        'ScrManto.Show()
        Me.Close()

    End Sub

    ''' <summary>
    ''' Muestra el formulario de ventas
    ''' Cierra el formulario actual
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click

        'ScrVentas.Show()
        Me.Close()

    End Sub

#End Region

End Class