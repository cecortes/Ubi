'Imports
Imports UbiDll

Public Class ScrConfigUsr

#Region "Variables"

    'UbiDll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim add As New Agregar
    Dim upd As New Actualizar
    Dim errorMsg As New ErrorMsg

#End Region

#Region "Funciones"

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Consulta departamentos
    ''' Llena el cbo con los resultados
    ''' </summary>
    Private Sub FillCboUnidad()

        'Reset
        consulta._dtsCbo.Reset()

        'Consulta
        consulta.GetAllDepa()

        'Dataset 
        CboUnidad.DataSource = consulta._dtsCbo.Tables("depa")

        'Datos
        CboUnidad.DisplayMember = "Id_depa"

        'Control de errores
        Try

            'Index
            CboUnidad.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Re inicia los valores de los textbox
    ''' </summary>
    Private Sub ClearTxt()

        'Txt
        TxtNom.Text = ""
        TxtApelli.Text = ""
        TxtMail.Text = ""
        TxtPass.Text = ""
        TxtTel.Text = ""

        'Control de excepciones
        Try

            'Cbo
            CboUnidad.SelectedIndex = 0

        Catch ex As Exception

        End Try


    End Sub

    ''' <summary>
    ''' Agrega a un nuevo usuario por medio de los datos de los cuadros de texto
    ''' </summary>
    Private Sub AddUserData()

        'Privadas
        Dim flgErr As Boolean = False

        'Valida
        If String.IsNullOrEmpty(TxtNom.Text) Then
            flgErr = True
        ElseIf String.IsNullOrEmpty(TxtApelli.Text) Then
            flgErr = True
        ElseIf String.IsNullOrEmpty(TxtMail.Text) Then
            flgErr = True
        ElseIf String.IsNullOrEmpty(TxtPass.Text) Then
            flgErr = True
        ElseIf String.IsNullOrEmpty(CboUnidad.Text) Then
            flgErr = True
        End If

        'Usr
        If flgErr Then

            MsgBox("Uno o varios campos no válidos, favor de verificar", MsgBoxStyle.Exclamation, "UbiSoft by Ubicamatic - 2020(C)")

            Return

        End If

        'Captura
        datos.nombre_usr = TxtNom.Text
        datos.apellidos_usr = TxtApelli.Text
        datos.correo_usr = TxtMail.Text
        datos.pass_usr = TxtPass.Text
        datos.tel_usr = TxtTel.Text
        datos.unidad_usr = CboUnidad.Text
        datos.Id_depa = datos.unidad_usr
        Dim tot As Integer = consulta.GetTotDepa(datos)
        tot += 1
        datos.Total_depa = tot

        'Insert & Update
        If (add.NewUsr(datos) And upd.UpdTotDepa(datos)) Then

            'Msg Usr
            MsgBox("Nuevo Usuario agregado", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

            'Re inicia los valores
            ClearTxt()

        End If

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Carga los datos de las unidades en el combo box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrConfigUsr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Cbo
        FillCboUnidad()

    End Sub

    ''' <summary>
    ''' Valida que el dgv no tenga datos, en caso de ser así llama al método para la inserción por lista
    ''' En caso contrario realiza la inserción por medio de los cuadros de texto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        'Validación
        If (DgvUsr.Rows.Count > 0) Then

            'Método para insert por medio de la tabla

        Else

            'Método para insert de los campos de texto
            AddUserData()

        End If

    End Sub

#End Region

End Class