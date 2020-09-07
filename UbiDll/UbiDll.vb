'Importamos referencias
Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class Conexion

#Region "DATAMEMBERS"

    ''' En esta región se declaran variables de la clase, las cuales se les
    ''' llama Data Members.

    Private _cadena As String
    Public _conexion As New MySqlConnection

#End Region

#Region "SHARED_FUNCTIONS"
    ''' En esta región se implementan las funciones compartidas de la clase,
    ''' si la función no es compartida o pública, esta no podrá ser usada por
    ''' la aplicación que la llame aunque esté correctamente importada.

    Public Function Con_Global() As Boolean

        ' Se encarga de realizar la conexión con la base de datos.
        ' Regresa el estado de la conexión como Boolean.

        'Variables locales
        Dim estado As Boolean = False
        Dim ip As String = "https://sql304.epizy.com"
        Dim user As String = "epiz_26625789"
        Dim pass As String = "ZMalqp10"

        'Tratamos de abrir la conexión
        Try
            _cadena = ("server= " & ip.Trim() & ";user id=" & user.Trim() & ";password=" & pass.Trim() & ";database=epiz_26625789_UbiSoft ;SslMode=none")
            _conexion = New MySqlConnection(_cadena)
            estado = True
        Catch ex As Exception
            estado = False
        End Try

        'Resultado de la conexión
        Return estado

    End Function

#End Region

End Class

Public Class Datos

#Region "usuarios"

#Region "DATAMEMBERS"

    Private _nombre_usr As String
    Private _apellidos_usr As String
    Private _correo_usr As String
    Private _pass_usr As String
    Private _tel_usr As String
    Private _unidad_usr As String

#End Region

#Region "PROPIEDADES"

    Public Property nombre_usr() As String
        Get
            Return _nombre_usr
        End Get
        Set(ByVal value As String)
            _nombre_usr = value
        End Set
    End Property

    Public Property apellidos_usr() As String
        Get
            Return _apellidos_usr
        End Get
        Set(ByVal value As String)
            _apellidos_usr = value
        End Set
    End Property

    Public Property correo_usr() As String
        Get
            Return _correo_usr
        End Get
        Set(ByVal value As String)
            _correo_usr = value
        End Set
    End Property

    Public Property pass_usr() As String
        Get
            Return _pass_usr
        End Get
        Set(ByVal value As String)
            _pass_usr = value
        End Set
    End Property

    Public Property tel_usr() As String
        Get
            Return _tel_usr
        End Get
        Set(ByVal value As String)
            _tel_usr = value
        End Set
    End Property

    Public Property unidad_usr() As String
        Get
            Return _unidad_usr
        End Get
        Set(ByVal value As String)
            _unidad_usr = value
        End Set
    End Property

#End Region

#End Region

End Class

Public Class Consulta

#Region "DATAMEMBERS"

    Private _adaptador As New MySqlDataAdapter

#End Region

#Region "usuarios"

    ''' <summary>
    ''' Se encarga de obtener el Pass de la tabla y lo regresa como resultado
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>Password as string</returns>
    Public Function GetPass(ByVal Datos As Datos) As String
        'Variables locales
        Dim con As New Conexion
        Dim resultado As String = ""

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT pass_usr FROM usuarios WHERE correo_usr = @correo_usr", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@correo_usr", MySqlDbType.String, 100).Value = Datos.correo_usr

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Result
            resultado = _adaptador.SelectCommand.ExecuteScalar()

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
            con._conexion.Close()

        End Try

        'Debug
        MsgBox(resultado.ToString, MsgBoxStyle.Information, "UbiSoft by Ubicamatic - 2020(C)")

        'Regresamos el resultado de la consulta
        Return resultado

    End Function

#End Region
End Class
