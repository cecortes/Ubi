﻿Public Class ScrConfigAutos

#Region "Variables"

#End Region

#Region "Funciones y Métodos"

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
        End If

    End Sub

    ''' <summary>
    ''' Método para recorrer los paneles abiertos y cerrarlos
    ''' </summary>
    Private Sub CerrarFormPanel()

        'Valida para los paneles abiertos

        For Each formulario As Form In Application.OpenForms

            If formulario.Name = "ScrConfigAutoNew" Then

                'Close
                ScrConfigAutoNew.Close()

            ElseIf formulario.Name = "ScrConfigAutoEdit" Then

                'Close
                ScrConfigAutoEdit.Close()

            ElseIf formulario.Name = "ScrConfigAutoDel" Then

                'Close
                ScrConfigAutoDel.Close()

            End If

        Next

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Llama al método para cerrar los paneles
    ''' Muestra el panel para agregar vehículos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click

        'Close
        CerrarFormPanel()

        'Open
        AbrirFormPanel(Of ScrConfigAutoNew)()

    End Sub

    ''' <summary>
    ''' Llama al método para cerrar los paneles
    ''' Muestra el panel para editar vehículos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

        'Close
        CerrarFormPanel()

        'Open
        AbrirFormPanel(Of ScrConfigAutoEdit)()

    End Sub

    ''' <summary>
    ''' Llama al método para cerrar los paneles
    ''' Muestra el panel para borrar vehículos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click

        'Close
        CerrarFormPanel()

        'Open
        AbrirFormPanel(Of ScrConfigAutoDel)()

    End Sub

#End Region

End Class