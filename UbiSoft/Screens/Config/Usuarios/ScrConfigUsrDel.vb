'Imports
Imports UbiDll

Public Class ScrConfigUsrDel

#Region "Variables"

    Dim depaDel As String = ""

    'Dll
    Dim datos As New Datos
    Dim consulta As New Consulta
    Dim update As New Actualizar
    Dim eliminar As New Eliminar
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
        DgvUsrDel.DataSource = consulta._dtvDgv

        'Formato Dgv
        DgvUsrDel.Columns(6).HeaderText = "Nombre"
        DgvUsrDel.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvUsrDel.Columns(7).HeaderText = "Apellidos"
        DgvUsrDel.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvUsrDel.Columns(8).HeaderText = "Correo electrónico"
        DgvUsrDel.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvUsrDel.Columns(9).HeaderText = "Contraseña"
        DgvUsrDel.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DgvUsrDel.Columns(10).HeaderText = "Teléfono"
        DgvUsrDel.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvUsrDel.Columns(11).HeaderText = "Departamento"
        DgvUsrDel.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvUsrDel.Refresh()

    End Sub

    ''' <summary>
    ''' Captura los valores necesarios en la clase datos
    ''' Realiza el borrado del usuario por medio de la dll
    ''' Actualiza el total en el departamento donde el usuario fue eliminado por medio de la dll
    ''' Reset del datasource
    ''' Recarga de datos al dgv
    ''' </summary>
    Private Sub DeleteUsr()

        'Captura
        datos.correo_usr = TxtMailDel.Text

        'Borrado y actualizado
        If (eliminar.DelUsr(datos) And update.UpdDepaFromDel(TxtDepa.Text)) Then

            'Usuario
            MsgBox("El usuario se eliminó correctamente", MsgBoxStyle.OkOnly, "UbiSoft by Ubicamatic - 2020(C)")

        End If

        'Reset y Reload
        FillDgvAllUsr()

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Llama al método para extraer a los usuarios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrConfigUsrDel_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dgv
        FillDgvAllUsr()

    End Sub

    ''' <summary>
    ''' Obtiene los datos de la fila / celda seleccionada
    ''' Carga los valores en los textbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvUsrDel_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvUsrDel.CellMouseClick

        'Privadas
        Dim fila As Integer = DgvUsrDel.Rows(e.RowIndex).Index

        'Datos
        TxtNomDel.Text = DgvUsrDel.Item(6, fila).Value
        TxtApelliDel.Text = DgvUsrDel.Item(7, fila).Value
        TxtMailDel.Text = DgvUsrDel.Item(8, fila).Value
        TxtPassDel.Text = DgvUsrDel.Item(9, fila).Value
        TxtTelDel.Text = DgvUsrDel.Item(10, fila).Value
        TxtDepa.Text = DgvUsrDel.Item(11, fila).Value

    End Sub

    ''' <summary>
    ''' Valida que la colección de columnas no sea nula y se posiciona en la Column4 (Contraseña)
    ''' Valida que el valor de la celda no sea cero
    ''' Cambia por el caracter X todo el contenido de la celda
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvUsrDel_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvUsrDel.CellFormatting

        'Posición Columna 4 y validación de la colección
        If (e.ColumnIndex <> -1 AndAlso DgvUsrDel.Columns(e.ColumnIndex).Name = "pass_usr") Then

            'Validación del contenido
            If (Not e.Value Is Nothing) Then

                'Nueva cadena con los caracteres reemplazados por X
                e.Value = New String("X", e.Value.ToString().Length)

            End If

        End If

    End Sub

    ''' <summary>
    ''' Limpia los cuadros de texto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClearDel_Click(sender As Object, e As EventArgs) Handles BtnClearDel.Click

        'Clean
        TxtNomDel.Text = ""
        TxtApelliDel.Text = ""
        TxtMailDel.Text = ""
        TxtPassDel.Text = ""
        TxtTelDel.Text = ""
        TxtDepa.Text = ""

    End Sub

    ''' <summary>
    ''' Llama al método para borrar al usuario seleccionado en la base de datos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnOkDel_Click(sender As Object, e As EventArgs) Handles BtnOkDel.Click

        'Borrar
        DeleteUsr()

    End Sub

#End Region

End Class