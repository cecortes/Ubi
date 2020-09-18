'Imports
Imports UbiDll

Public Class ScrConfigUsrEdit

#Region "Variables"

    'Dll
    Dim datos As New Datos
    Dim consulta As New Consulta
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

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Llama al método para extraer a los usuarios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrConfigUsrEdit_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dgv
        FillDgvAllUsr()

    End Sub

#End Region

End Class