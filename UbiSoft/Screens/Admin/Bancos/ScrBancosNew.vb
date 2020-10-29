'Imports
Imports UbiDll

Public Class ScrBancosNew

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim add As New Agregar
    Dim errorMsg As New ErrorMsg

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
    ''' Valida los valores necesarios
    ''' Agrega una nueva fila al dgv
    ''' Llama al método para calcular el saldo
    ''' </summary>
    Private Sub AddDgvReg()

        'Validación
        If String.IsNullOrEmpty(TxtCpto.Text) Then

            'Usuario
            MsgBox("El concepto no puede estar vacío", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

            'Break
            Return

        End If

        'Row
        DgvDiaro.Rows.Add(DtpFecha.Value.ToShortDateString, TxtCpto.Text, TxtDebe.Text, TxtHaber.Text)

        'Saldo
        CalcSaldo()

    End Sub

    ''' <summary>
    ''' Recorre el dgv para calcular el saldo entre debe y haber
    ''' Actualiza el valor del saldo al final del dgv
    ''' </summary>
    Private Sub CalcSaldo()

        'Locales
        Dim debeT As Decimal = 0.0
        Dim haberT As Decimal = 0.0
        Dim saldoT As Decimal = 0.0
        Dim flgSaldo As Boolean = False

        'Rutina Captura de Valores
        For Each fila As DataGridViewRow In DgvDiaro.Rows

            Dim debe As String = ""
            Dim haber As String = ""

            'Captura
            If String.IsNullOrEmpty(fila.Cells(2).Value) Then

                debe = "0.0"

            Else

                debe = fila.Cells(2).Value

            End If

            If String.IsNullOrEmpty(fila.Cells(3).Value) Then

                haber = "0.0"

            Else

                haber = fila.Cells(3).Value

            End If

            'Manejo de errores
            Try

                'Conversión
                debeT += Convert.ToDecimal(debe)
                haberT += Convert.ToDecimal(haber)

            Catch ex As Exception

            End Try

        Next

        'Saldo Total
        saldoT = debeT - haberT
        TxtSaldo.Text = saldoT

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
        AddDgvReg()

    End Sub

#End Region

End Class