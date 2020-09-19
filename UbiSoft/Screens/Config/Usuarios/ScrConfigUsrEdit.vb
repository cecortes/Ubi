'Imports
Imports UbiDll

Public Class ScrConfigUsrEdit

#Region "Variables"

    'Dll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim upd As New Actualizar
    Dim errMsg As New ErrorMsg

#End Region

#Region "Funciones"

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Se encarga de llenar el datagrid con todas las entradas de la tabla de usuarios
    ''' </summary>
    Private Sub FillDgvAllUsr()

        'Reset
        consulta._dtsDgv.Reset()

        'Consulta
        consulta.GetAllUsr()

        'Datagrid
        DgvUsrEdit.DataSource = consulta._dtvDgv

        'Formato Dgv
        DgvUsrEdit.Columns(6).HeaderText = "Nombre"
        DgvUsrEdit.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvUsrEdit.Columns(7).HeaderText = "Apellidos"
        DgvUsrEdit.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvUsrEdit.Columns(8).HeaderText = "Correo electrónico"
        DgvUsrEdit.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvUsrEdit.Columns(9).HeaderText = "Contraseña"
        DgvUsrEdit.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvUsrEdit.Columns(10).HeaderText = "Teléfono"
        DgvUsrEdit.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvUsrEdit.Columns(11).HeaderText = "Departamento"
        DgvUsrEdit.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvUsrEdit.Refresh()

    End Sub

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
        CboUnidadEdit.DataSource = consulta._dtsCbo.Tables("depa")

        'Datos
        CboUnidadEdit.DisplayMember = "Id_depa"

        'Control de errores
        Try

            'Index
            CboUnidadEdit.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Valida que la colección de columnas no sea nula y se posiciona en la Column4 (Contraseña)
    ''' Valida que el valor de la celda no sea cero
    ''' Cambia por el caracter X todo el contenido de la celda
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvUsrEdit_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvUsrEdit.CellFormatting

        'Posición Columna 4 y validación de la colección
        If (e.ColumnIndex <> -1 AndAlso DgvUsrEdit.Columns(e.ColumnIndex).Name = "pass_usr") Then

            'Validación del contenido
            If (Not e.Value Is Nothing) Then

                'Nueva cadena con los caracteres reemplazados por X
                e.Value = New String("X", e.Value.ToString().Length)

            End If

        End If

    End Sub

    ''' <summary>
    ''' Captura los valores necesarios en la clase datos
    ''' Realiza la actualización por medio de la Dll para usuarios
    ''' Realiza la actualización por medio de la Dll para departamentos
    ''' Reset del datasource
    ''' Recarga de datos al dgv
    ''' </summary>
    Private Sub EditUsr()

        'Captura
        datos.nombre_usr = TxtNomEdit.Text
        datos.apellidos_usr = TxtApelliEdit.Text
        datos.correo_usr = TxtMailEdit.Text
        datos.pass_usr = TxtPassEdit.Text
        datos.tel_usr = TxtTelEdit.Text
        datos.unidad_usr = CboUnidadEdit.Text
        datos.Id_depa = datos.unidad_usr
        Dim tot As Integer = consulta.GetTotDepa(datos)
        tot += 1
        datos.Total_depa = tot

        'Update
        If (upd.UpdUsr(datos) And upd.UpdTotDepa(datos)) Then

            'Usuario
            MsgBox("El usuario se actualizó correctamente", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

            'Reset y Reload
            FillDgvAllUsr()

        End If

    End Sub
#End Region

#Region "Eventos"

    ''' <summary>
    ''' Llama al método para extraer a los usuarios
    ''' Llama al método para extraer a los ddepartamentos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrConfigUsrEdit_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dgv
        FillDgvAllUsr()

        'Cbo
        FillCboUnidad()

    End Sub

    ''' <summary>
    ''' Obtiene los datos de la fila / celda seleccionada
    ''' Carga los valores en los textbox y cbo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvUsrEdit_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvUsrEdit.CellMouseClick

        'Privadas
        Dim fila As Integer = DgvUsrEdit.Rows(e.RowIndex).Index

        'Datos
        TxtNomEdit.Text = DgvUsrEdit.Item(6, fila).Value
        TxtApelliEdit.Text = DgvUsrEdit.Item(7, fila).Value
        TxtMailEdit.Text = DgvUsrEdit.Item(8, fila).Value
        TxtPassEdit.Text = DgvUsrEdit.Item(9, fila).Value
        TxtTelEdit.Text = DgvUsrEdit.Item(10, fila).Value
        CboUnidadEdit.Text = DgvUsrEdit.Item(11, fila).Value

    End Sub

    ''' <summary>
    ''' Limpia los cuadros de texto y cbo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClearEdit_Click(sender As Object, e As EventArgs) Handles BtnClearEdit.Click

        'Clean
        TxtNomEdit.Text = ""
        TxtApelliEdit.Text = ""
        TxtMailEdit.Text = ""
        TxtPassEdit.Text = ""
        TxtTelEdit.Text = ""

        'Control de errores
        Try

            'Posición del cbo
            CboUnidadEdit.SelectedIndex = 0

        Catch ex As Exception

        End Try


    End Sub

    ''' <summary>
    ''' Llama al método para editar al usuario seleccionado en la base de datos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnOkEdit_Click(sender As Object, e As EventArgs) Handles BtnOkEdit.Click

        'Editar
        EditUsr()

    End Sub

#End Region

End Class