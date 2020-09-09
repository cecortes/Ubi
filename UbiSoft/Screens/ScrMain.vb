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

#End Region

End Class