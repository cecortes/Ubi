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
        Dim ip As String = "localhost"
        Dim user As String = "root"
        Dim pass As String = "ZMalqp10"

        'Tratamos de abrir la conexión
        Try
            _cadena = ("server= " & ip.Trim() & ";user id=" & user.Trim() & ";password=" & pass.Trim() & ";database=ubi ;SslMode=none")
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

#Region "departamentos"

#Region "DATAMEMBERS"

    Private _Id_depa As String
    Private _Total_depa As Integer

#End Region

#Region "PROPIEDADES"

    Public Property Id_depa() As String
        Get
            Return _Id_depa
        End Get
        Set(ByVal value As String)
            _Id_depa = value
        End Set
    End Property

    Public Property Total_depa() As Integer
        Get
            Return _Total_depa
        End Get
        Set(ByVal value As Integer)
            _Total_depa = value
        End Set
    End Property

#End Region

#End Region

#Region "clientes"

#Region "DATAMEMBERS"

    Private _rfc_cli As String
    Private _razon_cli As String
    Private _mail_cli As String
    Private _tel_cli As String
    Private _dir_cli As String
    Private _edo_cli As String
    Private _ciudad_cli As String
    Private _lat_cli As Double
    Private _lon_cli As Double
    Private _contacto_cli As String

#End Region

#Region "PROPIEDADES"

    Public Property rfc_cli() As String
        Get
            Return _rfc_cli
        End Get
        Set(ByVal value As String)
            _rfc_cli = value
        End Set
    End Property

    Public Property razon_cli() As String
        Get
            Return _razon_cli
        End Get
        Set(ByVal value As String)
            _razon_cli = value
        End Set
    End Property

    Public Property mail_cli() As String
        Get
            Return _mail_cli
        End Get
        Set(ByVal value As String)
            _mail_cli = value
        End Set
    End Property

    Public Property tel_cli() As String
        Get
            Return _tel_cli
        End Get
        Set(ByVal value As String)
            _tel_cli = value
        End Set
    End Property

    Public Property dir_cli() As String
        Get
            Return _dir_cli
        End Get
        Set(ByVal value As String)
            _dir_cli = value
        End Set
    End Property

    Public Property edo_cli() As String
        Get
            Return _edo_cli
        End Get
        Set(ByVal value As String)
            _edo_cli = value
        End Set
    End Property

    Public Property ciudad_cli() As String
        Get
            Return _ciudad_cli
        End Get
        Set(ByVal value As String)
            _ciudad_cli = value
        End Set
    End Property

    Public Property lat_cli() As Double
        Get
            Return _lat_cli
        End Get
        Set(ByVal value As Double)
            _lat_cli = value
        End Set
    End Property

    Public Property lon_cli() As Double
        Get
            Return _lon_cli
        End Get
        Set(ByVal value As Double)
            _lon_cli = value
        End Set
    End Property

    Public Property contacto_cli() As String
        Get
            Return _contacto_cli
        End Get
        Set(ByVal value As String)
            _contacto_cli = value
        End Set
    End Property

#End Region

#End Region

End Class

Public Class Consulta

#Region "DATAMEMBERS"

    Private _adaptador As New MySqlDataAdapter

    Public _dtsCbo As New DataSet       'ComboBox
    Public _dtvCbo As New DataView      'ComboBox
    Public _dtsDgv As New DataSet       'Datagridview
    Public _dtvDgv As New DataView      'Datagridview

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
        Dim reader As MySqlDataReader
        Dim resultado As String = ""

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT pass_usr, unidad_usr FROM usuarios WHERE correo_usr = @correo_usr", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@correo_usr", MySqlDbType.String, 100).Value = Datos.correo_usr

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()
                resultado = reader("pass_usr").ToString() + "," + reader("unidad_usr").ToString
            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
            reader.Close()
            con._conexion.Close()

        End Try

        'Debug
        'MsgBox(resultado.ToString, MsgBoxStyle.Information, "UbiSoft by Ubicamatic - 2020(C)")

        'Regresamos el resultado de la consulta
        Return resultado

    End Function

    ''' <summary>
    ''' Se encarga de consultar la tabala de usuarios y llenar el DGV con el resultado
    ''' </summary>
    ''' <param name="datos"></param>
    Public Sub GetAllUsr()

        'Privadas
        Dim con As New Conexion

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM usuarios", con._conexion)

            'Pasamos el resultado al DataSet
            _adaptador.Fill(_dtsDgv)

            'Pasamos la tabla al DataView
            _dtvDgv.Table = _dtsDgv.Tables(0)

            'Open Conection
            con._conexion.Open()

            'Query
            _adaptador.SelectCommand.Connection = con._conexion
            _adaptador.SelectCommand.ExecuteNonQuery()

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close conection
            con._conexion.Close()

        End Try

    End Sub

#End Region

#Region "departamentos"

    ''' <summary>
    ''' Consulta la tabla departamentos
    ''' Obtiene el Total_depa y lo devuelve como entero
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function GetTotDepa(ByVal datos As Datos) As Integer

        'Privadas
        Dim con As New Conexion
        Dim total As Integer = 0

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT Total_depa FROM departamentos WHERE Id_depa = @Id_depa", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@Id_depa", MySqlDbType.String, 45).Value = datos.Id_depa

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            total = _adaptador.SelectCommand.ExecuteScalar()

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
            con._conexion.Close()

        End Try

        'Return
        Return total

    End Function

    ''' <summary>
    ''' Se encarga de consultar a departamentos y llenar al cbo correspondiente con el Id_depa
    ''' </summary>
    Public Sub GetAllDepa()

        'Variables Locales
        Dim con As New Conexion

        'Control Excepción
        Try

            'Conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM departamentos", con._conexion)
            _adaptador.Fill(_dtsCbo)

            'Cbo
            _adaptador.Fill(_dtsCbo, "depa")
            _dtvCbo.Table = _dtsCbo.Tables(0)

            'Query
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion
            _adaptador.SelectCommand.ExecuteNonQuery()

        Catch ex As MySqlException

            'Error
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally
            con._conexion.Close()
        End Try

    End Sub

#End Region

#Region "clientes"

    ''' <summary>
    ''' Se encarga de consultar la tabla de clientes y llenar el DGV con el resultado
    ''' </summary>
    Public Sub GetAllCli()

        'Privadas
        Dim con As New Conexion

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM clientes", con._conexion)

            'Pasamos el resultado al DataSet
            _adaptador.Fill(_dtsDgv)

            'Pasamos la tabla al DataView
            _dtvDgv.Table = _dtsDgv.Tables(0)

            'Open Conection
            con._conexion.Open()

            'Query
            _adaptador.SelectCommand.Connection = con._conexion
            _adaptador.SelectCommand.ExecuteNonQuery()

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close conection
            con._conexion.Close()

        End Try

    End Sub

    ''' <summary>
    ''' Se encarga de consultar a clientes y llenar al cbo correspondiente con el rfc_cli
    ''' </summary>
    Public Sub GetAllRfc()

        'Variables Locales
        Dim con As New Conexion

        'Control Excepción
        Try

            'Conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM clientes", con._conexion)
            _adaptador.Fill(_dtsCbo)

            'Cbo
            _adaptador.Fill(_dtsCbo, "rfcCli")
            _dtvCbo.Table = _dtsCbo.Tables(0)

            'Query
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion
            _adaptador.SelectCommand.ExecuteNonQuery()

        Catch ex As MySqlException

            'Error
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally
            con._conexion.Close()
        End Try

    End Sub

    ''' <summary>
    ''' Se encarga de obtener los datos de un cliente en particular y regresarlo como datos
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>Resultado como objeto de Datos</returns>
    Public Function GetCli(ByVal Datos As Datos) As Datos
        'Variables locales
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM clientes WHERE rfc_cli = @rfc_cli", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@rfc_cli", MySqlDbType.String, 13).Value = Datos.rfc_cli

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.rfc_cli = reader("rfc_cli").ToString
                resultado.razon_cli = reader("razon_cli").ToString
                resultado.mail_cli = reader("mail_cli").ToString
                resultado.tel_cli = reader("tel_cli").ToString
                resultado.dir_cli = reader("dir_cli").ToString
                resultado.edo_cli = reader("edo_cli").ToString
                resultado.ciudad_cli = reader("ciudad_cli").ToString
                resultado.contacto_cli = reader("contacto_cli").ToString

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
            reader.Close()
            con._conexion.Close()

        End Try

        'Debug
        'MsgBox(resultado.ToString, MsgBoxStyle.Information, "UbiSoft by Ubicamatic - 2020(C)")

        'Regresamos el resultado de la consulta
        Return resultado

    End Function

#End Region

End Class

Public Class Agregar

#Region "DATAMEMBERS"

    Private _adaptador As New MySqlDataAdapter

#End Region

#Region "USUARIOS"

    ''' <summary>
    ''' Realiza la inserción de datos en la tabla usuarios
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function NewUsr(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO usuarios (nombre_usr, apellidos_usr, correo_usr, pass_usr, tel_usr, unidad_usr) VALUES (@nombre_usr, @apellidos_usr, @correo_usr, @pass_usr, @tel_usr, @unidad_usr)", con._conexion)

            'Parámetros
            _adaptador.InsertCommand.Parameters.Add("@nombre_usr", MySqlDbType.String, 45).Value = datos.nombre_usr
            _adaptador.InsertCommand.Parameters.Add("@apellidos_usr", MySqlDbType.String, 45).Value = datos.apellidos_usr
            _adaptador.InsertCommand.Parameters.Add("@correo_usr", MySqlDbType.String, 45).Value = datos.correo_usr
            _adaptador.InsertCommand.Parameters.Add("@pass_usr", MySqlDbType.String, 10).Value = datos.pass_usr
            _adaptador.InsertCommand.Parameters.Add("@tel_usr", MySqlDbType.String, 45).Value = datos.tel_usr
            _adaptador.InsertCommand.Parameters.Add("@unidad_usr", MySqlDbType.String, 45).Value = datos.unidad_usr

            'Insert
            con._conexion.Open()
            _adaptador.InsertCommand.Connection = con._conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
            estado = True

        Catch ex As MySqlException

            'Error
            estado = False
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Conexión Close
            con._conexion.Close()

        End Try

        'Estado
        Return estado

    End Function

#End Region

#Region "CLIENTES"

    ''' <summary>
    ''' Realiza la inserción de datos en la tabla clientes
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function NewClient(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO clientes (rfc_cli, razon_cli, mail_cli, tel_cli, dir_cli, edo_cli, ciudad_cli, contacto_cli) VALUES (@rfc_cli,@razon_cli,@mail_cli,@tel_cli,@dir_cli,@edo_cli,@ciudad_cli,@contacto_cli)", con._conexion)

            'Parámetros
            _adaptador.InsertCommand.Parameters.Add("@rfc_cli", MySqlDbType.String, 13).Value = datos.rfc_cli
            _adaptador.InsertCommand.Parameters.Add("@razon_cli", MySqlDbType.String, 45).Value = datos.razon_cli
            _adaptador.InsertCommand.Parameters.Add("@mail_cli", MySqlDbType.String, 45).Value = datos.mail_cli
            _adaptador.InsertCommand.Parameters.Add("@tel_cli", MySqlDbType.String, 10).Value = datos.tel_cli
            _adaptador.InsertCommand.Parameters.Add("@dir_cli", MySqlDbType.String, 45).Value = datos.dir_cli
            _adaptador.InsertCommand.Parameters.Add("@edo_cli", MySqlDbType.String, 45).Value = datos.edo_cli
            _adaptador.InsertCommand.Parameters.Add("@ciudad_cli", MySqlDbType.String, 45).Value = datos.ciudad_cli
            _adaptador.InsertCommand.Parameters.Add("@contacto_cli", MySqlDbType.String, 45).Value = datos.contacto_cli

            'Insert
            con._conexion.Open()
            _adaptador.InsertCommand.Connection = con._conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
            estado = True

        Catch ex As MySqlException

            'Error
            estado = False
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Conexión Close
            con._conexion.Close()

        End Try

        'Estado
        Return estado

    End Function

#End Region

End Class

Public Class Actualizar

#Region "DATAMEMBERS"

    Private _adaptador As New MySqlDataAdapter

#End Region

#Region "USUARIOS"

    ''' <summary>
    ''' Actualiza los datos de la tabla de usuarios por medio de la llave primaria correo_usr
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function UpdUsr(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control de errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE usuarios SET nombre_usr=@nombre_usr, apellidos_usr=@apellidos_usr, pass_usr=@pass_usr, tel_usr=@tel_usr, unidad_usr=@unidad_usr WHERE correo_usr=@correo_usr", con._conexion)

            'Parámetros
            _adaptador.UpdateCommand.Parameters.Add("@correo_usr", MySqlDbType.String, 45).Value = datos.correo_usr
            _adaptador.UpdateCommand.Parameters.Add("@nombre_usr", MySqlDbType.String, 45).Value = datos.nombre_usr
            _adaptador.UpdateCommand.Parameters.Add("@apellidos_usr", MySqlDbType.String, 45).Value = datos.apellidos_usr
            _adaptador.UpdateCommand.Parameters.Add("@pass_usr", MySqlDbType.String, 45).Value = datos.pass_usr
            _adaptador.UpdateCommand.Parameters.Add("@tel_usr", MySqlDbType.String, 45).Value = datos.tel_usr
            _adaptador.UpdateCommand.Parameters.Add("@unidad_usr", MySqlDbType.String, 45).Value = datos.unidad_usr

            'Update
            con._conexion.Open()
            _adaptador.UpdateCommand.Connection = con._conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()
            estado = True

        Catch ex As MySqlException

            'Error
            estado = False
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Conexión Close
            con._conexion.Close()

        End Try

        'Return
        Return estado

    End Function

#End Region

#Region "DEPARTAMENTOS"

    ''' <summary>
    ''' Actualiza el total en Total_depa de la tabla departamentos
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function UpdTotDepa(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE departamentos SET Total_depa=@Total_depa WHERE Id_depa=@Id_depa", con._conexion)

            'Parámetros
            _adaptador.UpdateCommand.Parameters.Add("@Id_depa", MySqlDbType.String, 45).Value = datos.Id_depa
            _adaptador.UpdateCommand.Parameters.Add("@Total_depa", MySqlDbType.Int32, 11).Value = datos.Total_depa

            'Insert
            con._conexion.Open()
            _adaptador.UpdateCommand.Connection = con._conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()
            estado = True

        Catch ex As MySqlException

            'Error
            estado = False
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Conexión Close
            con._conexion.Close()

        End Try

        'Return
        Return estado

    End Function

    ''' <summary>
    ''' Actualiza en -1 el Total_depa de la tabla departamentos depaFrom
    ''' Actualiza en +1 el Total_depa de la tabla departamentos depaTo
    ''' </summary>
    ''' <param name="depaFrom"></param>
    ''' <param name="depaTo"></param>
    ''' <returns></returns>
    Public Function UpdDepaFromTo(ByVal depaFrom As String, ByVal depaTo As String, ByVal key As String) As Boolean

        'Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Primer Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE departamentos SET Total_depa=Total_depa - 1 WHERE Id_depa=@Id_depa", con._conexion)

            'Parámetros
            _adaptador.UpdateCommand.Parameters.Add("@Id_depa", MySqlDbType.String, 45).Value = depaFrom

            'Insert
            con._conexion.Open()
            _adaptador.UpdateCommand.Connection = con._conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()
            estado = True

        Catch ex As MySqlException

            'Error
            estado = False
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Conexión Close
            con._conexion.Close()

        End Try

        'Segundo Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE departamentos SET Total_depa=Total_depa + 1 WHERE Id_depa=@Id_depa", con._conexion)

            'Parámetros
            _adaptador.UpdateCommand.Parameters.Add("@Id_depa", MySqlDbType.String, 45).Value = depaTo

            'Insert
            con._conexion.Open()
            _adaptador.UpdateCommand.Connection = con._conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()
            estado = True

        Catch ex As MySqlException

            'Error
            estado = False
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Conexión Close
            con._conexion.Close()

        End Try

        'Tercer Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE usuarios SET unidad_usr=@unidad_usr WHERE correo_usr=@correo_usr", con._conexion)

            'Parámetros
            _adaptador.UpdateCommand.Parameters.Add("@correo_usr", MySqlDbType.String, 45).Value = key
            _adaptador.UpdateCommand.Parameters.Add("@unidad_usr", MySqlDbType.String, 45).Value = depaTo

            'Insert
            con._conexion.Open()
            _adaptador.UpdateCommand.Connection = con._conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()
            estado = True

        Catch ex As MySqlException

            'Error
            estado = False
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Conexión Close
            con._conexion.Close()

        End Try

        'Return
        Return estado

    End Function

    ''' <summary>
    ''' Actualiza en -1 el Total_depa de la tabla departamentos depaDel
    ''' </summary>
    ''' <param name="depaDel"></param>
    ''' <returns></returns>
    Public Function UpdDepaFromDel(ByVal depaDel As String) As Boolean

        'Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE departamentos SET Total_depa=Total_depa - 1 WHERE Id_depa=@Id_depa", con._conexion)

            'Parámetros
            _adaptador.UpdateCommand.Parameters.Add("@Id_depa", MySqlDbType.String, 45).Value = depaDel

            'Insert
            con._conexion.Open()
            _adaptador.UpdateCommand.Connection = con._conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()
            estado = True

        Catch ex As MySqlException

            'Error
            estado = False
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Conexión Close
            con._conexion.Close()

        End Try

        'Return
        Return estado

    End Function

#End Region

End Class

Public Class Eliminar

#Region "DATAMEMBERS"

    Private _adaptador As New MySqlDataAdapter

#End Region

#Region "USUARIOS"

    ''' <summary>
    ''' Se encarga de eliminar al usuario por medio de la key recibida como parámetro
    ''' </summary>
    ''' <param name="datos"> Resultado del borrado </param>
    ''' <returns></returns>
    Public Function DelUsr(ByVal datos As Datos) As Boolean

        'Variables Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control de Errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM usuarios WHERE correo_usr=@correo_usr", con._conexion)

            'Parámetros
            _adaptador.DeleteCommand.Parameters.Add("@correo_usr", MySqlDbType.String, 45).Value = datos.correo_usr

            'Delete
            con._conexion.Open()
            _adaptador.DeleteCommand.Connection = con._conexion
            _adaptador.DeleteCommand.ExecuteNonQuery()
            estado = True

        Catch ex As MySqlException

            'Error
            estado = False
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Conexión Close
            con._conexion.Close()

        End Try

        'Resultado
        Return estado

    End Function

#End Region

End Class

Public Class ErrorMsg

    ''' <summary>
    ''' Se encarga de mostrar al usuario el mensaje de acuerdo al tipo de error
    ''' Recibe como parámetro el tipo y lo valida para mostrar el mensaje adecuado
    ''' </summary>
    ''' <param name="tipo">As integer error type</param>
    Public Sub ErrorCode(ByVal tipo As Integer)

        'Valida
        Select Case tipo

            Case 1
                'Error Usuario o pasword incorrecto
                Dim msg As String = "Usuario o contraseña incorrecta" + vbCrLf + "favor de verificar."
                MsgBox(msg, MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        End Select

    End Sub

End Class
