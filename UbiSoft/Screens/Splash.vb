
Public Class Splash

#Region "Variables"

    Dim tiempo As Integer = 0                   'Contador para el timer
    Dim tmrEnd As Integer = 10                  'Tiempo total para final del contador en segundos

#End Region

#Region "Funciones"

#End Region

#Region "Métodos"

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Se encarga de cerrar la pantalla al cabo de x seg.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TmrStart_Tick(sender As Object, e As EventArgs) Handles TmrStart.Tick

        'Incremento
        tiempo += 1
        ProgBar.Value += 10

        'Validación
        If (tiempo >= tmrEnd) Then

            'Reset
            tiempo = 0
            TmrStart.Enabled = False
            ProgBar.Value = 0

            'Cierre de pantalla
            Login.Show()
            Me.Close()

        End If

    End Sub

#End Region

End Class
