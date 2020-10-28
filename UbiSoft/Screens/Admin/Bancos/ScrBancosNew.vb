Public Class ScrBancosNew

#Region "Variables"

#End Region

#Region "Funciones y Métodos"

    ''' <summary>
    ''' Inicia el dtp con la fecha del sistema
    ''' </summary>
    Private Sub InitDtp()

        'Dtp
        DtpFecha.Value = Date.Today

    End Sub

    ''' <summary>
    ''' Funcion para que solo permite el ingreso de caracteres tipo numerico
    ''' </summary>
    ''' <param name="e"></param>
    Private Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        'Validación dígito
        If Char.IsDigit(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsPunctuation(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

            'Usuario
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "UbiSoft by Ubicamatic - 2020(C)")

        End If

    End Sub

    ''' <summary>
    ''' Re inicia los controles necesarios
    ''' </summary>
    Private Sub ClearText()

        'Txt
        TxtCpto.Text = ""
        TxtDebe.Text = ""
        TxtHaber.Text = ""

    End Sub

    ''' <summary>
    ''' Valida que los datos debe haber sean númericos
    ''' 
    ''' </summary>
    Private Sub AddReg()

        'Validación


    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Inicia el dtp con la fecha del sistema
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrBancosNew_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dtp
        InitDtp()

    End Sub

    ''' <summary>
    ''' Llama al método encargado de validar que sea dígito
    ''' Deshabilita al control contrario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtDebe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDebe.KeyPress

        'Valida
        SoloNumeros(e)

        'Unable
        TxtHaber.Enabled = False

    End Sub

    ''' <summary>
    ''' Llama al método encargado de validar que sea dígito
    ''' Deshabilita al control contrario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtHaber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHaber.KeyPress

        'Valida
        SoloNumeros(e)

        'Unable
        TxtDebe.Enabled = False

    End Sub

    ''' <summary>
    ''' Habilita al control contrario si el texto es nulo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtHaber_TextChanged(sender As Object, e As EventArgs) Handles TxtHaber.TextChanged

        'Enable
        If String.IsNullOrEmpty(TxtHaber.Text) Then

            TxtDebe.Enabled = True

        End If

    End Sub

    ''' <summary>
    ''' Habilita al control contrario si el texto es nulo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtDebe_TextChanged(sender As Object, e As EventArgs) Handles TxtDebe.TextChanged

        'Enable
        If String.IsNullOrEmpty(TxtDebe.Text) Then

            TxtHaber.Enabled = True

        End If

    End Sub

    ''' <summary>
    ''' Llama al método para reiniciar los controles
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        'Clr
        ClearText()

    End Sub

    ''' <summary>
    ''' Llama al método encargado de agregar una línea al dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        'Registro
        AddReg()

    End Sub

#End Region

End Class