'Imports
Imports UbiDll
Imports SpreadsheetLight

Public Class ScrConfigMaqNew

#Region "Variables"

#End Region

#Region "Métodos y Funciones"

    ''' <summary>
    ''' Muestra el cuadro para abrir archivo
    ''' Aplica los filtros necesarios
    ''' Regresa el archivo seleccionado
    ''' </summary>
    Private Sub AbrirImagen()
        'Privadas
        Dim imagen As New OpenFileDialog

        'Open
        imagen.Filter = "JPEGs|*.jpg|PNGs|*.png|Bitmaps|*.bmp|AllFiles|*.*"

        'Validación
        If imagen.ShowDialog() = DialogResult.OK Then

            PbFoto.Image = Image.FromFile(imagen.FileName)

        End If

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PbFoto_Click(sender As Object, e As EventArgs) Handles PbFoto.Click

        'Abrir
        AbrirImagen()

    End Sub

#End Region

End Class