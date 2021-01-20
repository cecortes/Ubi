'Imports
Imports UbiDll

Public Class ScrPtoVenta

#Region "Variables"

    'Dll
    Dim datos As New Datos
    Dim consulCli As New Consulta
    Dim consulProd As New Consulta
    Dim errMsg As New ErrorMsg

    Dim folioVta As String = ""
    Dim totalVta As Decimal = 0.00

#End Region

#Region "Funciones y Métodos"

    ''' <summary>
    ''' Consulta clientes
    ''' Llena el cbo con los resultados
    ''' </summary>
    Private Sub FillCboRfc()

        'Reset
        consulCli._dtsCbo.Reset()

        'Consulta
        consulCli.GetAllRfc()

        'Dataset 
        CboRfc.DataSource = consulCli._dtsCbo.Tables("rfcCli")

        'Datos
        CboRfc.DisplayMember = "rfc_cli"

        'Control de errores
        Try

            'Index
            CboRfc.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Carga al cbo la consulta de la tabla productos
    ''' </summary>
    Public Sub FillProd()

        'Reset
        consulProd._dtsCbo.Reset()

        'Consulta
        consulProd.GetNomProd()

        'Dataset 
        CboProd.DataSource = consulProd._dtsCbo.Tables("nomProd")

        'Datos
        CboProd.DisplayMember = "nom_prod"

        'Control de errores
        Try

            'Index
            CboProd.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Realiza la consulta del rfc seleccionado en el cbo
    ''' Captura el resultado en los textbox y labels
    ''' </summary>
    Private Sub GetCliente(ByVal rfc As String)

        'Privadas
        Dim cliente As New Datos

        'Consulta para datos del cliente
        datos.rfc_cli = rfc
        cliente = consulCli.GetCli(datos)

        'Textbox
        TxtNombre.Text = cliente.razon_cli
        LblMail.Text = cliente.mail_cli
        LblContacto.Text = cliente.contacto_cli
        LblTel.Text = cliente.tel_cli
        LblDir.Text = cliente.dir_cli
        LblCiudad.Text = cliente.ciudad_cli
        LblEstado.Text = cliente.edo_cli

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Llama al método para extraer a los rfc de los clientes
    ''' Llama al método para extraer los nombres de productos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrPtoVenta_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Cbo
        FillCboRfc()
        FillProd()

    End Sub

    ''' <summary>
    ''' Cierra el formulario y abre la pantalla principal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PbClose_Click(sender As Object, e As EventArgs) Handles PbClose.Click

        'Close
        ScrVentas.Show()
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
    ''' Llama al método para realizar la consulta del cliente
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboRfc_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboRfc.SelectedValueChanged

        'Consulta
        GetCliente(CboRfc.Text)

    End Sub

    ''' <summary>
    ''' Obtiene los datos del producto mediante un método de consulta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CboProd_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboProd.SelectedValueChanged

        'Captura
        datos.nom_prod = CboProd.Text

        'Consulta mediante Dll
        Dim producto As Datos = consulProd.GetProd(datos)

        'Textos y datos
        LblPrecio.Text = producto.lp_1.ToString     'Precio fijado
        LblUni.Text = producto.pack_prod
        LblCat.Text = producto.cat_prod

    End Sub

    ''' <summary>
    ''' Valida los datos antes de capturarlos
    ''' Captura los datos necesarios y los agrega en el dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        'Validación
        If String.IsNullOrEmpty(CboRfc.Text) Then

            MsgBox("Seleccione un RFC válido...", MsgBoxStyle.Exclamation,
                  "UbiSoft by Ubicamatic - 2020(C)")

            Return

        End If

        If String.IsNullOrEmpty(CboProd.Text) Then

            MsgBox("Seleccione un producto válido...", MsgBoxStyle.Exclamation,
                  "UbiSoft by Ubicamatic - 2020(C)")

            Return

        End If

        If String.IsNullOrEmpty(TxtCanti.Text) Then

            MsgBox("La cantidad no puede estar vacía...", MsgBoxStyle.Exclamation,
                  "UbiSoft by Ubicamatic - 2020(C)")

            Return

        End If

        'Variables del sub total
        Dim cantidadInt = 0
        Dim precioDec As Decimal = 0.0
        Dim subDec As Decimal = 0.0

        'Control Excepciones
        Try

            'Conversión de unidades
            cantidadInt = Integer.Parse(TxtCanti.Text)

        Catch ex As Exception

            'Usuario
            MsgBox("La cantidad debe ser entera...", MsgBoxStyle.Exclamation,
                  "UbiSoft by Ubicamatic - 2020(C)")

            Return

        End Try

        Try

            'Eliminar $
            Dim precio As String = LblPrecio.Text
            precio = precio.Replace("$", "")

            'Conversión de unidades
            precioDec = Decimal.Parse(precio)

        Catch ex As Exception

            'Usuario
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation,
                  "UbiSoft by Ubicamatic - 2020(C)")

            Return

        End Try

        'Cálculo del sub total
        subDec = precioDec * cantidadInt
        Dim subTotal As String = subDec.ToString("#,###,###.00")

        'Cálculo del TOTAL
        totalVta += subDec
        LblTot.Text = totalVta.ToString("#,###,###.00")

        'DGV
        DgvProd.Rows.Add(CboProd.Text, LblCat.Text, LblUni.Text, TxtCanti.Text, LblPrecio.Text, subTotal)

    End Sub

#End Region
End Class