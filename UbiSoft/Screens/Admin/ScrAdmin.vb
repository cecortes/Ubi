

Public Class ScrAdmin

#Region "Variables"

#End Region

#Region "Funciones y Eventos"

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
        form = PnlWrp.Controls.OfType(Of MiForm)().FirstOrDefault()

        'Si el formulario no es encontrado / no existe
        If form Is Nothing Then

            form = New MiForm()
            form.TopLevel = False
            form.FormBorderStyle = FormBorderStyle.None
            form.Dock = DockStyle.Fill
            PnlWrp.Controls.Add(form)
            PnlWrp.Tag = form
            form.Show()
            form.BringToFront()

        Else

            form.BringToFront()

            'ElseIf form.Name = "ScrPropiasNew" Then

            '    form.BringToFront()
            '    ScrPropiasDel.Close()

            'ElseIf form.Name = "ScrPropiasDel" Then

            '    form.BringToFront()
            '    ScrPropiasNew.Close()

        End If

    End Sub

    ''' <summary>
    ''' Método para recorrer los paneles abiertos y cerrarlos
    ''' </summary>
    Private Sub CerrarFormPanel()

        'Valida para los paneles abiertos
        For Each formulario As Form In Application.OpenForms

            'MsgBox(formulario.Name)

            If formulario.Name = "ScrPropiasNew" Then

                'Close
                ScrPropiasNew.Close()

            ElseIf formulario.Name = "ScrPropiasDel" Then

                'Close
                ScrPropiasDel.Close()

            ElseIf formulario.Name = "ScrConfigCliDel" Then

                'Close
                'ScrConfigCliDel.Close()

            End If

        Next

    End Sub

    Private Sub CerrarFormPanel2(Of MiForm As {Form, New})()

        'Objeto
        Dim form As Form

        'Busca el formulario en la colección
        form = PnlWrp.Controls.OfType(Of MiForm)().FirstOrDefault()

        'Si el formulario no es encontrado / no existe
        If form Is Nothing Then

            'form = New MiForm()
            'form.TopLevel = False
            'form.FormBorderStyle = FormBorderStyle.None
            'form.Dock = DockStyle.Fill
            'PnlWrp.Controls.Add(form)
            'PnlWrp.Tag = form
            'form.Show()
            'form.BringToFront()

            MsgBox("Nada")

        ElseIf form.Name = "ScrPropiasNew" Then

            MsgBox("Tiene " + form.Name)
            form.Name = "ScrPropiasDel"
            form.Close()


            'form.BringToFront()

            'ElseIf form.Name = "ScrPropiasNew" Then

            '    form.BringToFront()
            '    ScrPropiasDel.Close()

            'ElseIf form.Name = "ScrPropiasDel" Then

            '    form.BringToFront()
            '    ScrPropiasNew.Close()

        End If

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

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
    ''' Muestra el panel para alta cuentas propias
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AltaPropiasItm_Click(sender As Object, e As EventArgs) Handles AltaPropiasItm.Click

        'Open
        AbrirFormPanel(Of ScrPropiasNew)()

    End Sub

    ''' <summary>
    ''' Muestra el panel para baja cuentas propias
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BajaPropiasItm_Click(sender As Object, e As EventArgs) Handles BajaPropiasItm.Click

        'Open
        AbrirFormPanel(Of ScrPropiasDel)()

    End Sub

    ''' <summary>
    ''' Muestra el panel para alta cuentas externas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AltaExtItm_Click(sender As Object, e As EventArgs) Handles AltaExtItm.Click

        'Open
        AbrirFormPanel(Of ScrExternaNew)()

    End Sub

    ''' <summary>
    ''' Muestra el panel para baja cuentas externas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BajaExtItm_Click(sender As Object, e As EventArgs) Handles BajaExtItm.Click

        'Open
        AbrirFormPanel(Of ScrExternaDel)()

    End Sub

#End Region

End Class