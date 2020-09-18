Imports System.ComponentModel

Public Class ScrConfig

#Region "Variables"

#End Region

#Region "Funciones"

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Se encarga de crear un nuevo objeto del tipo Form
    ''' Busca el formulario recibido como parámetro en la colección
    ''' Asigna la creación del formulario recibido al objeto creado
    ''' Le asigna los parámetros necesarios para mostrarlo
    ''' Lo muestra y lo trae al frente
    ''' </summary>
    ''' <typeparam name="MiForm"></typeparam>
    Private Sub AbrirFormPanel(Of MiForm As {Form, New})()

        'Objeto
        Dim form As Form

        'Busca el formulario en la colección
        form = PnlWrapp.Controls.OfType(Of MiForm)().FirstOrDefault()

        'Si el formulario no es encontrado / no existe
        If form Is Nothing Then
            form = New MiForm()
            form.TopLevel = False
            form.FormBorderStyle = FormBorderStyle.None
            form.Dock = DockStyle.Fill
            PnlWrapp.Controls.Add(form)
            PnlWrapp.Tag = form
            form.Show()
            form.BringToFront()
        Else
            form.BringToFront()
        End If

    End Sub

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
        ScrMain.unidad = "ADMIN"
        ScrMain.Show()

        'Valida
        For Each formulario As Form In Application.OpenForms

            If formulario.Name = "ScrConfigUsr" Then

                'Close
                ScrConfigUsr.Close()

            ElseIf formulario.Name = "ScrCfgUsr" Then

                'Close
                ScrCfgUsr.Close()

            ElseIf formulario.Name = "ScrConfigCli" Then

                'Close
                ScrConfigCli.Close()

            ElseIf formulario.Name = "ScrConfigProd" Then

                'Close
                ScrConfigProd.Close()

            ElseIf formulario.Name = "ScrConfigList" Then

                'Close
                ScrConfigList.Close()

            ElseIf formulario.Name = "ScrConfigMaq" Then

                'Close
                ScrConfigMaq.Close()

            ElseIf formulario.Name = "ScrConfigAutos" Then

                'Close
                ScrConfigAutos.Close()

            ElseIf formulario.Name = "ScrConfigInv" Then

                'Close
                ScrConfigInv.Close()

            ElseIf formulario.Name = "ScrConfigPrima" Then

                'Close
                ScrConfigPrima.Close()

            ElseIf formulario.Name = "ScrConfigPack" Then

                'Close
                ScrConfigPack.Close()

            ElseIf formulario.Name = "ScrConfigAdv" Then

                'Close
                ScrConfigAdv.Close()

            End If

        Next

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

    ''' <summary>
    ''' Abre el formulario de usuarios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click

        'AbrirFormPanel(Of ScrConfigUsr)()

        AbrirFormPanel(Of ScrCfgUsr)()

    End Sub

    ''' <summary>
    ''' Abre el formulario de clientes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click

        AbrirFormPanel(Of ScrConfigCli)()

    End Sub

    ''' <summary>
    ''' Abre el formulario de productos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles BtnProductos.Click

        AbrirFormPanel(Of ScrConfigProd)()

    End Sub

    ''' <summary>
    ''' Abre el formulario de precios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnPrecios_Click(sender As Object, e As EventArgs) Handles BtnPrecios.Click

        AbrirFormPanel(Of ScrConfigList)()

    End Sub

    ''' <summary>
    ''' Abre el formulario de maquinaria
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnMaq_Click(sender As Object, e As EventArgs) Handles BtnMaq.Click

        AbrirFormPanel(Of ScrConfigMaq)()

    End Sub

    ''' <summary>
    ''' Abre el formulario de vehículos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnAutos_Click(sender As Object, e As EventArgs) Handles BtnAutos.Click

        AbrirFormPanel(Of ScrConfigAutos)()

    End Sub

    ''' <summary>
    ''' Abre el formulario de inventarios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles BtnInventario.Click

        AbrirFormPanel(Of ScrConfigInv)()

    End Sub

    ''' <summary>
    ''' Abre el formulario de materias primas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnMatPrima_Click(sender As Object, e As EventArgs) Handles BtnMatPrima.Click

        AbrirFormPanel(Of ScrConfigPrima)()

    End Sub

    ''' <summary>
    ''' Abre el formulario de producto terminado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnProdTer_Click(sender As Object, e As EventArgs) Handles BtnProdTer.Click

        AbrirFormPanel(Of ScrConfigPack)()

    End Sub

    ''' <summary>
    ''' Abre el formulario de configuración avanzada
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnAvanzada_Click(sender As Object, e As EventArgs) Handles BtnAvanzada.Click

        AbrirFormPanel(Of ScrConfigAdv)()

    End Sub

#End Region

End Class