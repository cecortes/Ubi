'Imports
Imports UbiDll

Public Class Login

#Region "Variables"

    'Dll
    Dim datos As New Datos
    Dim consulta As New Consulta

#End Region

#Region "Funciones"

#End Region

#Region "Métodos"

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Se encarga de borrar los cuadros de texto y regresarlos a condiciones iniciales.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        'Clear
        txtUsr.Text = ""
        txtUsr.HintText = "Correo electrónico"
        txtPass.Text = "1234"

    End Sub

    ''' <summary>
    ''' Limpia el contenido del cuadro de texto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtPass_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPass.MouseClick

        'Clear
        txtPass.Text = ""

    End Sub

    ''' <summary>
    ''' Captura la info de los cuadros textos
    ''' Realiza la consulta mediante la dll
    ''' Valida el resultado y da acceso
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        'Captura
        Dim usuario As String = txtUsr.Text
        Dim pwd As String = txtPass.Text
        datos.correo_usr = usuario

        'Consulta
        Dim dllRes As String = consulta.GetPass(datos)
        'Dim dbTipo As String = buscar.GetUserTipo(datos)

        MsgBox(dllRes)

    End Sub

#End Region

End Class