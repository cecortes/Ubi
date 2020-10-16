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

#Region "prod_uni"

#Region "DATAMEMBERS"

    Private _tipo_uni As String

#End Region

#Region "PROPIEDADES"

    Public Property tipo_uni() As String
        Get
            Return _tipo_uni
        End Get
        Set(ByVal value As String)
            _tipo_uni = value
        End Set
    End Property

#End Region

#End Region

#Region "productos"

#Region "DATAMEMBERS"

    Private _nom_prod As String
    Private _cat_prod As String
    Private _pack_prod As String
    Private _lp_1 As Double
    Private _lp_2 As Double
    Private _lp_3 As Double
    Private _lp_4 As Double

#End Region

#Region "PROPIEDADES"

    Public Property nom_prod() As String
        Get
            Return _nom_prod
        End Get
        Set(ByVal value As String)
            _nom_prod = value
        End Set
    End Property

    Public Property cat_prod() As String
        Get
            Return _cat_prod
        End Get
        Set(ByVal value As String)
            _cat_prod = value
        End Set
    End Property

    Public Property pack_prod() As String
        Get
            Return _pack_prod
        End Get
        Set(ByVal value As String)
            _pack_prod = value
        End Set
    End Property

    Public Property lp_1() As Double
        Get
            Return _lp_1
        End Get
        Set(ByVal value As Double)
            _lp_1 = value
        End Set
    End Property

    Public Property lp_2() As Double
        Get
            Return _lp_2
        End Get
        Set(ByVal value As Double)
            _lp_2 = value
        End Set
    End Property

    Public Property lp_3() As Double
        Get
            Return _lp_3
        End Get
        Set(ByVal value As Double)
            _lp_3 = value
        End Set
    End Property

    Public Property lp_4() As Double
        Get
            Return _lp_4
        End Get
        Set(ByVal value As Double)
            _lp_4 = value
        End Set
    End Property

#End Region

#End Region

#Region "maquinaria"

#Region "DATAMEMBERS"

    Private _idmaq As Integer
    Private _foto_maq As Byte()
    Private _serie_maq As String
    Private _modelo_maq As String
    Private _marca_maq As String
    Private _desc_maq As String
    Private _area_maq As String
    Private _yyadq_maq As String

#End Region

#Region "PROPIEDADES"

    Public Property idmaq() As Integer
        Get
            Return _idmaq
        End Get
        Set(ByVal value As Integer)
            _idmaq = value
        End Set
    End Property

    Public Property foto_maq() As Byte()
        Get
            Return _foto_maq
        End Get
        Set(ByVal value As Byte())
            _foto_maq = value
        End Set
    End Property

    Public Property serie_maq() As String
        Get
            Return _serie_maq
        End Get
        Set(ByVal value As String)
            _serie_maq = value
        End Set
    End Property

    Public Property modelo_maq() As String
        Get
            Return _modelo_maq
        End Get
        Set(ByVal value As String)
            _modelo_maq = value
        End Set
    End Property

    Public Property marca_maq() As String
        Get
            Return _marca_maq
        End Get
        Set(ByVal value As String)
            _marca_maq = value
        End Set
    End Property

    Public Property desc_maq() As String
        Get
            Return _desc_maq
        End Get
        Set(ByVal value As String)
            _desc_maq = value
        End Set
    End Property

    Public Property area_maq() As String
        Get
            Return _area_maq
        End Get
        Set(ByVal value As String)
            _area_maq = value
        End Set
    End Property

    Public Property yyadq_maq() As String
        Get
            Return _yyadq_maq
        End Get
        Set(ByVal value As String)
            _yyadq_maq = value
        End Set
    End Property

#End Region

#End Region

#Region "autos"

#Region "DATAMEMBERS"

    Private _foto_auto As Byte()
    Private _placas_auto As String
    Private _marca_auto As String
    Private _modelo_auto As String
    Private _year_auto As String
    Private _motor_auto As String
    Private _poliza_auto As String
    Private _verif_auto As String
    Private _tipo_auto As String
    Private _capa_auto As String
    Private _refri_auto As String
    Private _gps_auto As String
    Private _tag_auto As String
    Private _ubi_auto As String

#End Region

#Region "PROPIEDADES"

    Public Property foto_auto() As Byte()
        Get
            Return _foto_auto
        End Get
        Set(ByVal value As Byte())
            _foto_auto = value
        End Set
    End Property

    Public Property placas_auto() As String
        Get
            Return _placas_auto
        End Get
        Set(ByVal value As String)
            _placas_auto = value
        End Set
    End Property

    Public Property marca_auto() As String
        Get
            Return _marca_auto
        End Get
        Set(ByVal value As String)
            _marca_auto = value
        End Set
    End Property

    Public Property modelo_auto() As String
        Get
            Return _modelo_auto
        End Get
        Set(ByVal value As String)
            _modelo_auto = value
        End Set
    End Property

    Public Property year_auto() As String
        Get
            Return _year_auto
        End Get
        Set(ByVal value As String)
            _year_auto = value
        End Set
    End Property

    Public Property motor_auto() As String
        Get
            Return _motor_auto
        End Get
        Set(ByVal value As String)
            _motor_auto = value
        End Set
    End Property

    Public Property poliza_auto() As String
        Get
            Return _poliza_auto
        End Get
        Set(ByVal value As String)
            _poliza_auto = value
        End Set
    End Property

    Public Property verif_auto() As String
        Get
            Return _verif_auto
        End Get
        Set(ByVal value As String)
            _verif_auto = value
        End Set
    End Property

    Public Property tipo_auto() As String
        Get
            Return _tipo_auto
        End Get
        Set(ByVal value As String)
            _tipo_auto = value
        End Set
    End Property

    Public Property capa_auto() As String
        Get
            Return _capa_auto
        End Get
        Set(ByVal value As String)
            _capa_auto = value
        End Set
    End Property

    Public Property refri_auto() As String
        Get
            Return _refri_auto
        End Get
        Set(ByVal value As String)
            _refri_auto = value
        End Set
    End Property

    Public Property gps_auto() As String
        Get
            Return _gps_auto
        End Get
        Set(ByVal value As String)
            _gps_auto = value
        End Set
    End Property

    Public Property tag_auto() As String
        Get
            Return _tag_auto
        End Get
        Set(ByVal value As String)
            _tag_auto = value
        End Set
    End Property

    Public Property ubi_auto() As String
        Get
            Return _ubi_auto
        End Get
        Set(ByVal value As String)
            _ubi_auto = value
        End Set
    End Property

#End Region

#End Region

#Region "auto_tipos"

#Region "DATAMEMBERS"

    Private _idauto_tipos As String

#End Region

#Region "PROPIEDADES"

    Public Property idauto_tipos() As String
        Get
            Return _idauto_tipos
        End Get
        Set(ByVal value As String)
            _idauto_tipos = value
        End Set
    End Property

#End Region

#End Region

#Region "inventario"

#Region "DATAMEMBERS"

    Private _foto_inv As Byte()
    Private _id_inv As Integer
    Private _cat_inv As String
    Private _codint_inv As String
    Private _codcom_inv As String
    Private _tag_inv As String
    Private _desc_inv As String
    Private _cost_inv As Decimal
    Private _area_inv As String

#End Region

#Region "PROPIEDADES"

    Public Property foto_inv() As Byte()
        Get
            Return _foto_inv
        End Get
        Set(ByVal value As Byte())
            _foto_inv = value
        End Set
    End Property

    Public Property id_inv() As Integer
        Get
            Return _id_inv
        End Get
        Set(ByVal value As Integer)
            _id_inv = value
        End Set
    End Property

    Public Property cat_inv() As String
        Get
            Return _cat_inv
        End Get
        Set(ByVal value As String)
            _cat_inv = value
        End Set
    End Property

    Public Property codint_inv() As String
        Get
            Return _codint_inv
        End Get
        Set(ByVal value As String)
            _codint_inv = value
        End Set
    End Property

    Public Property codcom_inv() As String
        Get
            Return _codcom_inv
        End Get
        Set(ByVal value As String)
            _codcom_inv = value
        End Set
    End Property

    Public Property tag_inv() As String
        Get
            Return _tag_inv
        End Get
        Set(ByVal value As String)
            _tag_inv = value
        End Set
    End Property

    Public Property desc_inv() As String
        Get
            Return _desc_inv
        End Get
        Set(ByVal value As String)
            _desc_inv = value
        End Set
    End Property

    Public Property cost_inv() As Decimal
        Get
            Return _cost_inv
        End Get
        Set(ByVal value As Decimal)
            _cost_inv = value
        End Set
    End Property

    Public Property area_inv() As String
        Get
            Return _area_inv
        End Get
        Set(ByVal value As String)
            _area_inv = value
        End Set
    End Property

#End Region

#End Region

#Region "inventario_cat"

#Region "DATAMEMBERS"

    Private _cat_inventario As String

#End Region

#Region "PROPIEDADES"

    Public Property cat_inventario() As String
        Get
            Return _cat_inventario
        End Get
        Set(ByVal value As String)
            _cat_inventario = value
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
    Public dgvCode As New DataSet      'Datagrid Only HardCode

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

#Region "prod_uni"

    ''' <summary>
    ''' Se encarga de consultar a prod_uni y llenar al cbo correspondiente con el tipo_uni
    ''' </summary>
    Public Sub GetUniProd()

        'Variables Locales
        Dim con As New Conexion

        'Control Excepción
        Try

            'Conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM prod_uni", con._conexion)
            _adaptador.Fill(_dtsCbo)

            'Cbo
            _adaptador.Fill(_dtsCbo, "uniProd")
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

#Region "productos"

    ''' <summary>
    ''' Se encarga de consultar a productos y llenar al cbo correspondiente con el cat_prod
    ''' </summary>
    Public Sub GetCatProd()

        'Variables Locales
        Dim con As New Conexion

        'Control Excepción
        Try

            'Conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM productos", con._conexion)
            _adaptador.Fill(_dtsCbo)

            'Cbo
            _adaptador.Fill(_dtsCbo, "catProd")
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
    ''' Se encarga de consultar a productos y llenar al cbo correspondiente con el nom_prod
    ''' </summary>
    Public Sub GetNomProd()

        'Variables Locales
        Dim con As New Conexion

        'Control Excepción
        Try

            'Conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM productos", con._conexion)
            _adaptador.Fill(_dtsCbo)

            'Cbo
            _adaptador.Fill(_dtsCbo, "nomProd")
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
    ''' Se encarga de obtener los datos de un producto en particular y regresarlo como datos
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>Resultado como objeto de Datos</returns>
    Public Function GetProd(ByVal Datos As Datos) As Datos
        'Variables locales
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM productos WHERE nom_prod = @nom_prod", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@nom_prod", MySqlDbType.String, 100).Value = Datos.nom_prod

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.nom_prod = reader("nom_prod").ToString
                resultado.cat_prod = reader("cat_prod").ToString
                resultado.pack_prod = reader("pack_prod").ToString
                resultado.lp_1 = reader("lp_1")
                resultado.lp_2 = reader("lp_2")
                resultado.lp_3 = reader("lp_3")
                resultado.lp_4 = reader("lp_4")

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

#Region "maquinaria"

    ''' <summary>
    ''' Se encarga de obtener el último id de la tabla y lo regresa como resultado
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>Password as string</returns>
    Public Function GetLastId() As Integer
        'Variables locales
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As Integer = 0

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT idmaq FROM maquinaria", con._conexion)

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()
                resultado = reader("idmaq")
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
    ''' Se encarga de consultar la tabla de maquinaria y llenar el DGV con el resultado
    ''' </summary>
    Public Sub GetAllMaq()

        'Privadas
        Dim con As New Conexion

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM maquinaria", con._conexion)

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
    ''' Crea una tabla harcode en el dataset
    ''' Crea las columnas del tipo ncesario para los datos
    ''' Realiza una consulta para obtener los datos de la tabla maquinaria
    ''' Mediante un reader almacena los datos
    ''' Genera una nueva fila en el dataset con todos los datos
    ''' </summary>
    Public Sub DgvAllMaq()

        'Privadas
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Init Tabla, hardcode MAQREP
        dgvCode.Tables.Add("MAQ")
        dgvCode.Tables("MAQ").Columns.Add("Foto", GetType(Byte()))
        dgvCode.Tables("MAQ").Columns.Add("Id", GetType(Integer))
        dgvCode.Tables("MAQ").Columns.Add("Serie", GetType(String))
        dgvCode.Tables("MAQ").Columns.Add("Modelo", GetType(String))
        dgvCode.Tables("MAQ").Columns.Add("Marca", GetType(String))
        dgvCode.Tables("MAQ").Columns.Add("Descripción", GetType(String))
        dgvCode.Tables("MAQ").Columns.Add("Area", GetType(String))
        dgvCode.Tables("MAQ").Columns.Add("Año de adq.", GetType(String))

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM maquinaria", con._conexion)

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.foto_maq = reader("foto_maq")
                resultado.idmaq = reader("idmaq")
                resultado.serie_maq = reader("serie_maq")
                resultado.modelo_maq = reader("modelo_maq")
                resultado.marca_maq = reader("marca_maq")
                resultado.desc_maq = reader("desc_maq")
                resultado.area_maq = reader("area_maq")
                resultado.yyadq_maq = reader("yyadq_maq")

                'Agregamos el arreglo byte para la foto y los demás datos
                dgvCode.Tables("MAQ").Rows.Add(resultado.foto_maq, resultado.idmaq, resultado.serie_maq, resultado.modelo_maq, resultado.marca_maq, resultado.desc_maq, resultado.area_maq, resultado.yyadq_maq)

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
            reader.Close()
            con._conexion.Close()

        End Try

    End Sub

    ''' <summary>
    ''' Se encarga de obtener los datos de una maquinaria en particular y regresarlo como datos
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>Resultado como objeto de Datos</returns>
    Public Function GetMaqRfid(ByVal Datos As Datos) As Datos
        'Variables locales
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM maquinaria WHERE serie_maq = @serie_maq", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@serie_maq", MySqlDbType.String, 45).Value = Datos.serie_maq

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.foto_maq = reader("foto_maq")
                resultado.idmaq = reader("idmaq")
                resultado.serie_maq = reader("serie_maq")
                resultado.modelo_maq = reader("modelo_maq")
                resultado.marca_maq = reader("marca_maq")
                resultado.desc_maq = reader("desc_maq")
                resultado.area_maq = reader("area_maq")
                resultado.yyadq_maq = reader("yyadq_maq")

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
            reader.Close()
            con._conexion.Close()

        End Try

        'Regresamos el resultado de la consulta
        Return resultado

    End Function

#End Region

#Region "auto_tipos"

    ''' <summary>
    ''' Se encarga de consultar a auto_tipos y llenar al cbo correspondiente con el idauto_tipos
    ''' </summary>
    Public Sub GetAutoTipos()

        'Variables Locales
        Dim con As New Conexion

        'Control Excepción
        Try

            'Conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM auto_tipos", con._conexion)
            _adaptador.Fill(_dtsCbo)

            'Cbo
            _adaptador.Fill(_dtsCbo, "autoTpo")
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

#Region "autos"

    ''' <summary>
    ''' Crea una tabla harcode en el dataset
    ''' Crea las columnas del tipo ncesario para los datos
    ''' Realiza una consulta para obtener los datos de la tabla autos
    ''' Mediante un reader almacena los datos
    ''' Genera una nueva fila en el dataset con todos los datos
    ''' </summary>
    Public Sub DgvAllAutos()

        'Privadas
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Init Tabla, hardcode MAQREP
        dgvCode.Tables.Add("AUT")
        dgvCode.Tables("AUT").Columns.Add("Foto", GetType(Byte()))
        dgvCode.Tables("AUT").Columns.Add("Placas", GetType(String))
        dgvCode.Tables("AUT").Columns.Add("Marca", GetType(String))
        dgvCode.Tables("AUT").Columns.Add("Modelo", GetType(String))
        dgvCode.Tables("AUT").Columns.Add("Año", GetType(String))
        dgvCode.Tables("AUT").Columns.Add("Motor", GetType(String))
        dgvCode.Tables("AUT").Columns.Add("Póliza", GetType(String))
        dgvCode.Tables("AUT").Columns.Add("Verificación", GetType(String))
        dgvCode.Tables("AUT").Columns.Add("Tipo", GetType(String))
        dgvCode.Tables("AUT").Columns.Add("Capacidad", GetType(String))
        dgvCode.Tables("AUT").Columns.Add("Refrigeración", GetType(String))
        dgvCode.Tables("AUT").Columns.Add("Gps", GetType(String))
        dgvCode.Tables("AUT").Columns.Add("TAG", GetType(String))
        dgvCode.Tables("AUT").Columns.Add("UBI", GetType(String))

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM autos", con._conexion)

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.foto_auto = reader("foto_auto")
                resultado.placas_auto = reader("placas_auto")
                resultado.marca_auto = reader("marca_auto")
                resultado.modelo_auto = reader("modelo_auto")
                resultado.year_auto = reader("year_auto")
                resultado.motor_auto = reader("motor_auto")
                resultado.poliza_auto = reader("poliza_auto")
                resultado.verif_auto = reader("verif_auto")
                resultado.tipo_auto = reader("tipo_auto")
                resultado.capa_auto = reader("capa_auto")
                resultado.refri_auto = reader("refri_auto")
                resultado.gps_auto = reader("gps_auto")
                resultado.tag_auto = reader("tag_auto")
                resultado.ubi_auto = reader("ubi_auto")

                'Agregamos el arreglo byte para la foto y los demás datos
                dgvCode.Tables("AUT").Rows.Add(resultado.foto_auto, resultado.placas_auto, resultado.marca_auto, resultado.modelo_auto, resultado.year_auto, resultado.motor_auto, resultado.poliza_auto, resultado.verif_auto, resultado.tipo_auto, resultado.capa_auto, resultado.refri_auto, resultado.gps_auto, resultado.tag_auto, resultado.ubi_auto)

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
            reader.Close()
            con._conexion.Close()

        End Try

    End Sub

    ''' <summary>
    ''' Se encarga de obtener los datos de un vehículo en particular y regresarlo como datos
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>Resultado como objeto de Datos</returns>
    Public Function GetAutoRfid(ByVal Datos As Datos) As Datos
        'Variables locales
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM autos WHERE tag_auto = @tag_auto", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@tag_auto", MySqlDbType.String, 45).Value = Datos.tag_auto

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.foto_auto = reader("foto_auto")
                resultado.placas_auto = reader("placas_auto")
                resultado.marca_auto = reader("marca_auto")
                resultado.modelo_auto = reader("modelo_auto")
                resultado.year_auto = reader("year_auto")
                resultado.motor_auto = reader("motor_auto")
                resultado.tag_auto = reader("tag_auto")

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
            reader.Close()
            con._conexion.Close()

        End Try

        'Regresamos el resultado de la consulta
        Return resultado

    End Function

#End Region

#Region "inventario_cat"

    ''' <summary>
    ''' Se encarga de consultar a inventario_cat y llenar al cbo correspondiente con el cat_inventario
    ''' </summary>
    Public Sub GetInvCat()

        'Variables Locales
        Dim con As New Conexion

        'Control Excepción
        Try

            'Conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM inventario_cat", con._conexion)
            _adaptador.Fill(_dtsCbo)

            'Cbo
            _adaptador.Fill(_dtsCbo, "invCat")
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

#Region "inventario"

    ''' <summary>
    ''' Crea una tabla harcode en el dataset
    ''' Crea las columnas del tipo ncesario para los datos
    ''' Realiza una consulta para obtener los datos de la tabla autos
    ''' Mediante un reader almacena los datos
    ''' Genera una nueva fila en el dataset con todos los datos
    ''' </summary>
    Public Sub DgvAllInv()

        'Privadas
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Init Tabla, hardcode MAQREP
        dgvCode.Tables.Add("INV")
        dgvCode.Tables("INV").Columns.Add("Foto", GetType(Byte()))
        dgvCode.Tables("INV").Columns.Add("Id", GetType(Integer))
        dgvCode.Tables("INV").Columns.Add("Categoría", GetType(String))
        dgvCode.Tables("INV").Columns.Add("Interno", GetType(String))
        dgvCode.Tables("INV").Columns.Add("Comercial", GetType(String))
        dgvCode.Tables("INV").Columns.Add("TAG", GetType(String))
        dgvCode.Tables("INV").Columns.Add("Descripción", GetType(String))
        dgvCode.Tables("INV").Columns.Add("Valor", GetType(String))
        dgvCode.Tables("INV").Columns.Add("Area", GetType(String))

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM inventario", con._conexion)

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.foto_inv = reader("foto_inv")
                resultado.id_inv = reader("id_inv")
                resultado.cat_inv = reader("cat_inv")
                resultado.codint_inv = reader("codint_inv")
                resultado.codcom_inv = reader("codcom_inv")
                resultado.tag_inv = reader("tag_inv")
                resultado.desc_inv = reader("desc_inv")
                resultado.cost_inv = reader("cost_inv")
                resultado.area_inv = reader("area_inv")

                'Agregamos el arreglo byte para la foto y los demás datos
                dgvCode.Tables("INV").Rows.Add(resultado.foto_inv, resultado.id_inv, resultado.cat_inv, resultado.codint_inv, resultado.codcom_inv, resultado.tag_inv, resultado.desc_inv, resultado.cost_inv, resultado.area_inv)

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
            reader.Close()
            con._conexion.Close()

        End Try

    End Sub

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

#Region "PRODUCTOS"

    ''' <summary>
    ''' Realiza la inserción de datos en la tabla productos
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function NewProd(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO productos (nom_prod, cat_prod, pack_prod, lp_1, lp_2, lp_3, lp_4) VALUES (@nom_prod, @cat_prod, @pack_prod, @lp_1, @lp_2, @lp_3, @lp_4)", con._conexion)

            'Parámetros
            _adaptador.InsertCommand.Parameters.Add("@nom_prod", MySqlDbType.String, 100).Value = datos.nom_prod
            _adaptador.InsertCommand.Parameters.Add("@cat_prod", MySqlDbType.String, 45).Value = datos.cat_prod
            _adaptador.InsertCommand.Parameters.Add("@pack_prod", MySqlDbType.String, 45).Value = datos.pack_prod
            _adaptador.InsertCommand.Parameters.Add("@lp_1", MySqlDbType.Decimal, 10, 2).Value = datos.lp_1
            _adaptador.InsertCommand.Parameters.Add("@lp_2", MySqlDbType.Decimal, 10, 2).Value = datos.lp_2
            _adaptador.InsertCommand.Parameters.Add("@lp_3", MySqlDbType.Decimal, 10, 2).Value = datos.lp_3
            _adaptador.InsertCommand.Parameters.Add("@lp_4", MySqlDbType.Decimal, 10, 2).Value = datos.lp_4

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

#Region "MAQUINARIA"

    ''' <summary>
    ''' Realiza la inserción de datos en la tabla maquinaria
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function NewMaq(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO maquinaria (foto_maq, serie_maq, modelo_maq, marca_maq, desc_maq, area_maq, yyadq_maq) VALUES (@foto_maq, @serie_maq, @modelo_maq, @marca_maq, @desc_maq, @area_maq, @yyadq_maq)", con._conexion)

            'Parámetros
            _adaptador.InsertCommand.Parameters.AddWithValue("@foto_maq", datos.foto_maq)
            _adaptador.InsertCommand.Parameters.Add("@serie_maq", MySqlDbType.String, 45).Value = datos.serie_maq
            _adaptador.InsertCommand.Parameters.Add("@modelo_maq", MySqlDbType.String, 45).Value = datos.modelo_maq
            _adaptador.InsertCommand.Parameters.Add("@marca_maq", MySqlDbType.String, 45).Value = datos.marca_maq
            _adaptador.InsertCommand.Parameters.Add("@desc_maq", MySqlDbType.String, 200).Value = datos.desc_maq
            _adaptador.InsertCommand.Parameters.Add("@area_maq", MySqlDbType.String, 45).Value = datos.area_maq
            _adaptador.InsertCommand.Parameters.Add("@yyadq_maq", MySqlDbType.Int32, 11).Value = datos.yyadq_maq

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

#Region "AUTOS"

    ''' <summary>
    ''' Realiza la inserción de datos en la tabla autos
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function NewAuto(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO autos (foto_auto, placas_auto, marca_auto, modelo_auto, year_auto, motor_auto, poliza_auto, verif_auto, tipo_auto, capa_auto, refri_auto, gps_auto, tag_auto, ubi_auto) VALUES (@foto_auto, @placas_auto, @marca_auto, @modelo_auto, @year_auto, @motor_auto, @poliza_auto, @verif_auto, @tipo_auto, @capa_auto, @refri_auto, @gps_auto, @tag_auto, @ubi_auto)", con._conexion)

            'Parámetros
            _adaptador.InsertCommand.Parameters.AddWithValue("@foto_auto", datos.foto_auto)
            _adaptador.InsertCommand.Parameters.Add("@placas_auto", MySqlDbType.String, 45).Value = datos.placas_auto
            _adaptador.InsertCommand.Parameters.Add("@marca_auto", MySqlDbType.String, 45).Value = datos.marca_auto
            _adaptador.InsertCommand.Parameters.Add("@modelo_auto", MySqlDbType.String, 45).Value = datos.modelo_auto
            _adaptador.InsertCommand.Parameters.Add("@year_auto", MySqlDbType.String, 45).Value = datos.year_auto
            _adaptador.InsertCommand.Parameters.Add("@motor_auto", MySqlDbType.String, 45).Value = datos.motor_auto
            _adaptador.InsertCommand.Parameters.Add("@poliza_auto", MySqlDbType.String, 45).Value = datos.poliza_auto
            _adaptador.InsertCommand.Parameters.Add("@verif_auto", MySqlDbType.String, 45).Value = datos.verif_auto
            _adaptador.InsertCommand.Parameters.Add("@tipo_auto", MySqlDbType.String, 45).Value = datos.tipo_auto
            _adaptador.InsertCommand.Parameters.Add("@capa_auto", MySqlDbType.String, 45).Value = datos.capa_auto
            _adaptador.InsertCommand.Parameters.Add("@refri_auto", MySqlDbType.String, 45).Value = datos.refri_auto
            _adaptador.InsertCommand.Parameters.Add("@gps_auto", MySqlDbType.String, 45).Value = datos.gps_auto
            _adaptador.InsertCommand.Parameters.Add("@tag_auto", MySqlDbType.String, 45).Value = datos.tag_auto
            _adaptador.InsertCommand.Parameters.Add("@ubi_auto", MySqlDbType.String, 45).Value = datos.ubi_auto

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

#Region "INVENTARIO"

    ''' <summary>
    ''' Realiza la inserción de datos en la tabla inventario
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function NewInv(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO inventario (foto_inv, cat_inv, codint_inv, codcom_inv, tag_inv, desc_inv, cost_inv, area_inv) VALUES (@foto_inv, @cat_inv, @codint_inv, @codcom_inv, @tag_inv, @desc_inv, @cost_inv, @area_inv)", con._conexion)

            'Parámetros
            _adaptador.InsertCommand.Parameters.AddWithValue("@foto_inv", datos.foto_inv)
            _adaptador.InsertCommand.Parameters.Add("@cat_inv", MySqlDbType.String, 45).Value = datos.cat_inv
            _adaptador.InsertCommand.Parameters.Add("@codint_inv", MySqlDbType.String, 45).Value = datos.codint_inv
            _adaptador.InsertCommand.Parameters.Add("@codcom_inv", MySqlDbType.String, 45).Value = datos.codcom_inv
            _adaptador.InsertCommand.Parameters.Add("@tag_inv", MySqlDbType.String, 45).Value = datos.tag_inv
            _adaptador.InsertCommand.Parameters.Add("@desc_inv", MySqlDbType.String, 100).Value = datos.desc_inv
            _adaptador.InsertCommand.Parameters.Add("@cost_inv", MySqlDbType.Decimal, 10, 2).Value = datos.cost_inv
            _adaptador.InsertCommand.Parameters.Add("@area_inv", MySqlDbType.String, 45).Value = datos.area_inv

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

#Region "CLIENTES"

    ''' <summary>
    ''' Actualiza los datos de la tabla de clientes por medio de la llave primaria rfc_cli
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function UpdCli(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control de errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE clientes SET razon_cli=@razon_cli, mail_cli=@mail_cli, tel_cli=@tel_cli, dir_cli=@dir_cli, edo_cli=@edo_cli, ciudad_cli=@ciudad_cli, contacto_cli=@contacto_cli WHERE rfc_cli=@rfc_cli", con._conexion)

            'Parámetros
            _adaptador.UpdateCommand.Parameters.Add("@rfc_cli", MySqlDbType.String, 13).Value = datos.rfc_cli
            _adaptador.UpdateCommand.Parameters.Add("@razon_cli", MySqlDbType.String, 45).Value = datos.razon_cli
            _adaptador.UpdateCommand.Parameters.Add("@mail_cli", MySqlDbType.String, 45).Value = datos.mail_cli
            _adaptador.UpdateCommand.Parameters.Add("@tel_cli", MySqlDbType.String, 45).Value = datos.tel_cli
            _adaptador.UpdateCommand.Parameters.Add("@dir_cli", MySqlDbType.String, 45).Value = datos.dir_cli
            _adaptador.UpdateCommand.Parameters.Add("@edo_cli", MySqlDbType.String, 45).Value = datos.edo_cli
            _adaptador.UpdateCommand.Parameters.Add("@ciudad_cli", MySqlDbType.String, 45).Value = datos.ciudad_cli
            _adaptador.UpdateCommand.Parameters.Add("@contacto_cli", MySqlDbType.String, 45).Value = datos.contacto_cli

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

#Region "PRODUCTOS"

    ''' <summary>
    ''' Actualiza los datos de la tabla de productos por medio de la llave primaria nom_prod
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function UpdProd(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control de errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE productos SET cat_prod=@cat_prod, pack_prod=@pack_prod, lp_1=@lp_1, lp_2=@lp_2, lp_3=@lp_3, lp_4=@lp_4 WHERE nom_prod=@nom_prod", con._conexion)

            'Parámetros
            _adaptador.UpdateCommand.Parameters.Add("@nom_prod", MySqlDbType.String, 100).Value = datos.nom_prod
            _adaptador.UpdateCommand.Parameters.Add("@cat_prod", MySqlDbType.String, 45).Value = datos.cat_prod
            _adaptador.UpdateCommand.Parameters.Add("@pack_prod", MySqlDbType.String, 45).Value = datos.pack_prod
            _adaptador.UpdateCommand.Parameters.Add("@lp_1", MySqlDbType.Decimal, 10, 2).Value = datos.lp_1
            _adaptador.UpdateCommand.Parameters.Add("@lp_2", MySqlDbType.Decimal, 10, 2).Value = datos.lp_2
            _adaptador.UpdateCommand.Parameters.Add("@lp_3", MySqlDbType.Decimal, 10, 2).Value = datos.lp_3
            _adaptador.UpdateCommand.Parameters.Add("@lp_4", MySqlDbType.Decimal, 10, 2).Value = datos.lp_4

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

#Region "MAQUINARIA"

    ''' <summary>
    ''' Realiza la actualización de datos en la tabla maquinaria
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function UpdMaq(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE maquinaria SET foto_maq=@foto_maq, serie_maq=@serie_maq, modelo_maq=@modelo_maq, marca_maq=@marca_maq, desc_maq=@desc_maq, area_maq=@area_maq, yyadq_maq=@yyadq_maq WHERE idmaq=@idmaq", con._conexion)

            'Parámetros
            _adaptador.UpdateCommand.Parameters.AddWithValue("@foto_maq", datos.foto_maq)
            _adaptador.UpdateCommand.Parameters.Add("@idmaq", MySqlDbType.Int32, 11).Value = datos.idmaq
            _adaptador.UpdateCommand.Parameters.Add("@serie_maq", MySqlDbType.String, 45).Value = datos.serie_maq
            _adaptador.UpdateCommand.Parameters.Add("@modelo_maq", MySqlDbType.String, 45).Value = datos.modelo_maq
            _adaptador.UpdateCommand.Parameters.Add("@marca_maq", MySqlDbType.String, 45).Value = datos.marca_maq
            _adaptador.UpdateCommand.Parameters.Add("@desc_maq", MySqlDbType.String, 200).Value = datos.desc_maq
            _adaptador.UpdateCommand.Parameters.Add("@area_maq", MySqlDbType.String, 45).Value = datos.area_maq
            _adaptador.UpdateCommand.Parameters.Add("@yyadq_maq", MySqlDbType.Int32, 11).Value = datos.yyadq_maq

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

        'Estado
        Return estado

    End Function

#End Region

#Region "AUTOS"

    ''' <summary>
    ''' Realiza la actualización de datos en la tabla autos
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function UpdAuto(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE autos SET foto_auto=@foto_auto, marca_auto=@marca_auto, modelo_auto=@modelo_auto, year_auto=@year_auto, motor_auto=@motor_auto, poliza_auto=@poliza_auto, verif_auto=@verif_auto, tipo_auto=@tipo_auto, capa_auto=@capa_auto, refri_auto=@refri_auto, gps_auto=@gps_auto, tag_auto=@tag_auto, ubi_auto=@ubi_auto WHERE placas_auto=@placas_auto", con._conexion)

            'Parámetros
            _adaptador.UpdateCommand.Parameters.AddWithValue("@foto_auto", datos.foto_auto)
            _adaptador.UpdateCommand.Parameters.Add("@placas_auto", MySqlDbType.String, 45).Value = datos.placas_auto
            _adaptador.UpdateCommand.Parameters.Add("@marca_auto", MySqlDbType.String, 45).Value = datos.marca_auto
            _adaptador.UpdateCommand.Parameters.Add("@modelo_auto", MySqlDbType.String, 45).Value = datos.modelo_auto
            _adaptador.UpdateCommand.Parameters.Add("@year_auto", MySqlDbType.String, 45).Value = datos.year_auto
            _adaptador.UpdateCommand.Parameters.Add("@motor_auto", MySqlDbType.String, 45).Value = datos.motor_auto
            _adaptador.UpdateCommand.Parameters.Add("@poliza_auto", MySqlDbType.String, 45).Value = datos.poliza_auto
            _adaptador.UpdateCommand.Parameters.Add("@verif_auto", MySqlDbType.String, 45).Value = datos.verif_auto
            _adaptador.UpdateCommand.Parameters.Add("@tipo_auto", MySqlDbType.String, 45).Value = datos.tipo_auto
            _adaptador.UpdateCommand.Parameters.Add("@capa_auto", MySqlDbType.String, 45).Value = datos.capa_auto
            _adaptador.UpdateCommand.Parameters.Add("@refri_auto", MySqlDbType.String, 45).Value = datos.refri_auto
            _adaptador.UpdateCommand.Parameters.Add("@gps_auto", MySqlDbType.String, 45).Value = datos.gps_auto
            _adaptador.UpdateCommand.Parameters.Add("@tag_auto", MySqlDbType.String, 45).Value = datos.tag_auto
            _adaptador.UpdateCommand.Parameters.Add("@ubi_auto", MySqlDbType.String, 45).Value = datos.ubi_auto

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

        'Estado
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

#Region "CLIENTES"

    ''' <summary>
    ''' Se encarga de eliminar al cliente por medio de la key recibida como parámetro
    ''' </summary>
    ''' <param name="datos"> Resultado del borrado </param>
    ''' <returns></returns>
    Public Function DelCli(ByVal datos As Datos) As Boolean

        'Variables Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control de Errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM clientes WHERE rfc_cli=@rfc_cli", con._conexion)

            'Parámetros
            _adaptador.DeleteCommand.Parameters.Add("@rfc_cli", MySqlDbType.String, 13).Value = datos.rfc_cli

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

#Region "PRODUCTOS"

    ''' <summary>
    ''' Se encarga de eliminar al producto por medio de la key recibida como parámetro
    ''' </summary>
    ''' <param name="datos"> Resultado del borrado </param>
    ''' <returns></returns>
    Public Function DelProd(ByVal datos As Datos) As Boolean

        'Variables Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control de Errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM productos WHERE nom_prod=@nom_prod", con._conexion)

            'Parámetros
            _adaptador.DeleteCommand.Parameters.Add("@nom_prod", MySqlDbType.String, 100).Value = datos.nom_prod

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

#Region "MAQUINARIA"

    ''' <summary>
    ''' Se encarga de eliminar a la maquinaria por medio de la key recibida como parámetro
    ''' </summary>
    ''' <param name="datos"> Resultado del borrado </param>
    ''' <returns></returns>
    Public Function DelMaq(ByVal datos As Datos) As Boolean

        'Variables Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control de Errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM maquinaria WHERE idmaq=@idmaq", con._conexion)

            'Parámetros
            _adaptador.DeleteCommand.Parameters.Add("@idmaq", MySqlDbType.Int32, 11).Value = datos.idmaq

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

#Region "AUTOS"

    ''' <summary>
    ''' Se encarga de eliminar al vehículo por medio de la key recibida como parámetro
    ''' </summary>
    ''' <param name="datos"> Resultado del borrado </param>
    ''' <returns></returns>
    Public Function DelAuto(ByVal datos As Datos) As Boolean

        'Variables Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control de Errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM autos WHERE placas_auto=@placas_auto", con._conexion)

            'Parámetros
            _adaptador.DeleteCommand.Parameters.Add("@placas_auto", MySqlDbType.String, 45).Value = datos.placas_auto

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
