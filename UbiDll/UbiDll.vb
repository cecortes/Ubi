﻿'Importamos referencias
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

#Region "proveedores"

#Region "DATAMEMBERS"

    Private _rfc_prov As String
    Private _razon_prov As String
    Private _mail_prov As String
    Private _tel_prov As String
    Private _dir_prov As String
    Private _edo_prov As String
    Private _ciudad_prov As String
    Private _contacto_prov As String

#End Region

#Region "PROPIEDADES"

    Public Property rfc_prov() As String
        Get
            Return _rfc_prov
        End Get
        Set(ByVal value As String)
            _rfc_prov = value
        End Set
    End Property

    Public Property razon_prov() As String
        Get
            Return _razon_prov
        End Get
        Set(ByVal value As String)
            _razon_prov = value
        End Set
    End Property

    Public Property mail_prov() As String
        Get
            Return _mail_prov
        End Get
        Set(ByVal value As String)
            _mail_prov = value
        End Set
    End Property

    Public Property tel_prov() As String
        Get
            Return _tel_prov
        End Get
        Set(ByVal value As String)
            _tel_prov = value
        End Set
    End Property

    Public Property dir_prov() As String
        Get
            Return _dir_prov
        End Get
        Set(ByVal value As String)
            _dir_prov = value
        End Set
    End Property

    Public Property edo_prov() As String
        Get
            Return _edo_prov
        End Get
        Set(ByVal value As String)
            _edo_prov = value
        End Set
    End Property

    Public Property ciudad_prov() As String
        Get
            Return _ciudad_prov
        End Get
        Set(ByVal value As String)
            _ciudad_prov = value
        End Set
    End Property

    Public Property contacto_prov() As String
        Get
            Return _contacto_prov
        End Get
        Set(ByVal value As String)
            _contacto_prov = value
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

#Region "prima"

#Region "DATAMEMBERS"

    Private _prima_foto As Byte()
    Private _prima_nombre As String
    Private _prima_interno As String
    Private _prima_comercial As String
    Private _prima_tag As String
    Private _prima_desc As String

#End Region

#Region "PROPIEDADES"

    Public Property prima_foto() As Byte()
        Get
            Return _prima_foto
        End Get
        Set(ByVal value As Byte())
            _prima_foto = value
        End Set
    End Property

    Public Property prima_nombre() As String
        Get
            Return _prima_nombre
        End Get
        Set(ByVal value As String)
            _prima_nombre = value
        End Set
    End Property

    Public Property prima_interno() As String
        Get
            Return _prima_interno
        End Get
        Set(ByVal value As String)
            _prima_interno = value
        End Set
    End Property

    Public Property prima_comercial() As String
        Get
            Return _prima_comercial
        End Get
        Set(ByVal value As String)
            _prima_comercial = value
        End Set
    End Property

    Public Property prima_tag() As String
        Get
            Return _prima_tag
        End Get
        Set(ByVal value As String)
            _prima_tag = value
        End Set
    End Property

    Public Property prima_desc() As String
        Get
            Return _prima_desc
        End Get
        Set(ByVal value As String)
            _prima_desc = value
        End Set
    End Property

#End Region

#End Region

#Region "ctapropia"

#Region "DATAMEMBERS"

    Private _propia_nom As String
    Private _propia_banco As String
    Private _propia_keybanco As String
    Private _propia_nocuenta As String
    Private _propia_noplaza As String
    Private _propia_nosuc As String
    Private _propia_tipo As String
    Private _propia_clabe As String
    Private _propia_abb As String

#End Region

#Region "PROPIEDADES"

    Public Property propia_nom() As String
        Get
            Return _propia_nom
        End Get
        Set(ByVal value As String)
            _propia_nom = value
        End Set
    End Property

    Public Property propia_banco() As String
        Get
            Return _propia_banco
        End Get
        Set(ByVal value As String)
            _propia_banco = value
        End Set
    End Property

    Public Property propia_keybanco() As String
        Get
            Return _propia_keybanco
        End Get
        Set(ByVal value As String)
            _propia_keybanco = value
        End Set
    End Property

    Public Property propia_nocuenta() As String
        Get
            Return _propia_nocuenta
        End Get
        Set(ByVal value As String)
            _propia_nocuenta = value
        End Set
    End Property

    Public Property propia_noplaza() As String
        Get
            Return _propia_noplaza
        End Get
        Set(ByVal value As String)
            _propia_noplaza = value
        End Set
    End Property

    Public Property propia_nosuc() As String
        Get
            Return _propia_nosuc
        End Get
        Set(ByVal value As String)
            _propia_nosuc = value
        End Set
    End Property

    Public Property propia_tipo() As String
        Get
            Return _propia_tipo
        End Get
        Set(ByVal value As String)
            _propia_tipo = value
        End Set
    End Property

    Public Property propia_clabe() As String
        Get
            Return _propia_clabe
        End Get
        Set(ByVal value As String)
            _propia_clabe = value
        End Set
    End Property

    Public Property propia_abb() As String
        Get
            Return _propia_abb
        End Get
        Set(ByVal value As String)
            _propia_abb = value
        End Set
    End Property

#End Region

#End Region

#Region "ctasexterna"

#Region "DATAMEMBERS"

    Private _ext_nomprov As String
    Private _ext_rfc As String
    Private _ext_mail As String
    Private _ext_tel As String
    Private _ext_nom As String
    Private _ext_banco As String
    Private _ext_keybanco As String
    Private _ext_nocuenta As String
    Private _ext_noplaza As String
    Private _ext_nosuc As String
    Private _ext_tipo As String
    Private _ext_clabe As String
    Private _ext_abb As String

#End Region

#Region "PROPIEDADES"

    Public Property ext_nomprov() As String
        Get
            Return _ext_nomprov
        End Get
        Set(ByVal value As String)
            _ext_nomprov = value
        End Set
    End Property

    Public Property ext_rfc() As String
        Get
            Return _ext_rfc
        End Get
        Set(ByVal value As String)
            _ext_rfc = value
        End Set
    End Property

    Public Property ext_mail() As String
        Get
            Return _ext_mail
        End Get
        Set(ByVal value As String)
            _ext_mail = value
        End Set
    End Property

    Public Property ext_tel() As String
        Get
            Return _ext_tel
        End Get
        Set(ByVal value As String)
            _ext_tel = value
        End Set
    End Property

    Public Property ext_nom() As String
        Get
            Return _ext_nom
        End Get
        Set(ByVal value As String)
            _ext_nom = value
        End Set
    End Property

    Public Property ext_banco() As String
        Get
            Return _ext_banco
        End Get
        Set(ByVal value As String)
            _ext_banco = value
        End Set
    End Property

    Public Property ext_keybanco() As String
        Get
            Return _ext_keybanco
        End Get
        Set(ByVal value As String)
            _ext_keybanco = value
        End Set
    End Property

    Public Property ext_nocuenta() As String
        Get
            Return _ext_nocuenta
        End Get
        Set(ByVal value As String)
            _ext_nocuenta = value
        End Set
    End Property

    Public Property ext_noplaza() As String
        Get
            Return _ext_noplaza
        End Get
        Set(ByVal value As String)
            _ext_noplaza = value
        End Set
    End Property

    Public Property ext_nosuc() As String
        Get
            Return _ext_nosuc
        End Get
        Set(ByVal value As String)
            _ext_nosuc = value
        End Set
    End Property

    Public Property ext_tipo() As String
        Get
            Return _ext_tipo
        End Get
        Set(ByVal value As String)
            _ext_tipo = value
        End Set
    End Property

    Public Property ext_clabe() As String
        Get
            Return _ext_clabe
        End Get
        Set(ByVal value As String)
            _ext_clabe = value
        End Set
    End Property

    Public Property ext_abb() As String
        Get
            Return _ext_abb
        End Get
        Set(ByVal value As String)
            _ext_abb = value
        End Set
    End Property

#End Region

#End Region

#Region "banco_diario"

#Region "DATAMEMBERS"

    Private _bancodiario_id As Integer
    Private _bancodiario_fecha As String
    Private _bancodiario_cpto As String
    Private _bancodiario_debe As Decimal
    Private _bancodiario_haber As Decimal

#End Region

#Region "PROPIEDADES"

    Public Property bancodiario_id() As Integer
        Get
            Return _bancodiario_id
        End Get
        Set(ByVal value As Integer)
            _bancodiario_id = value
        End Set
    End Property

    Public Property bancodiario_fecha() As String
        Get
            Return _bancodiario_fecha
        End Get
        Set(ByVal value As String)
            _bancodiario_fecha = value
        End Set
    End Property

    Public Property bancodiario_cpto() As String
        Get
            Return _bancodiario_cpto
        End Get
        Set(ByVal value As String)
            _bancodiario_cpto = value
        End Set
    End Property

    Public Property bancodiario_debe() As Decimal
        Get
            Return _bancodiario_debe
        End Get
        Set(ByVal value As Decimal)
            _bancodiario_debe = value
        End Set
    End Property

    Public Property bancodiario_haber() As Decimal
        Get
            Return _bancodiario_haber
        End Get
        Set(ByVal value As Decimal)
            _bancodiario_haber = value
        End Set
    End Property

#End Region

#End Region

#Region "ventas"

#Region "DATAMEMBERS"

    Private _periodo_ini As Date
    Private _periodo_fin As Date
    Private _cliente_ini As Date
    Private _cliente_fin As Date
    Private _ventas_id As Integer
    Private _ventas_folio As String
    Private _ventas_date As Date
    Private _ventas_usr As String
    Private _ventas_rfc As String
    Private _ventas_nom As String
    Private _ventas_mail As String
    Private _ventas_prod As String
    Private _ventas_cat As String
    Private _ventas_uni As String
    Private _ventas_canti As Integer
    Private _ventas_pu As Decimal
    Private _ventas_sub As Decimal
    Private _ventas_tot As Decimal

#End Region

#Region "PROPIEDADES"

    Public Property periodo_fin() As Date
        Get
            Return _periodo_fin
        End Get
        Set(ByVal value As Date)
            _periodo_fin = value
        End Set
    End Property

    Public Property periodo_ini() As Date
        Get
            Return _periodo_ini
        End Get
        Set(ByVal value As Date)
            _periodo_ini = value
        End Set
    End Property

    Public Property cliente_fin() As Date
        Get
            Return _cliente_fin
        End Get
        Set(ByVal value As Date)
            _cliente_fin = value
        End Set
    End Property

    Public Property cliente_ini() As Date
        Get
            Return _cliente_ini
        End Get
        Set(ByVal value As Date)
            _cliente_ini = value
        End Set
    End Property

    Public Property ventas_id() As Integer
        Get
            Return _ventas_id
        End Get
        Set(ByVal value As Integer)
            _ventas_id = value
        End Set
    End Property

    Public Property ventas_folio() As String
        Get
            Return _ventas_folio
        End Get
        Set(ByVal value As String)
            _ventas_folio = value
        End Set
    End Property

    Public Property ventas_date() As Date
        Get
            Return _ventas_date
        End Get
        Set(ByVal value As Date)
            _ventas_date = value
        End Set
    End Property

    Public Property ventas_usr() As String
        Get
            Return _ventas_usr
        End Get
        Set(ByVal value As String)
            _ventas_usr = value
        End Set
    End Property

    Public Property ventas_rfc() As String
        Get
            Return _ventas_rfc
        End Get
        Set(ByVal value As String)
            _ventas_rfc = value
        End Set
    End Property

    Public Property ventas_nom() As String
        Get
            Return _ventas_nom
        End Get
        Set(ByVal value As String)
            _ventas_nom = value
        End Set
    End Property

    Public Property ventas_mail() As String
        Get
            Return _ventas_mail
        End Get
        Set(ByVal value As String)
            _ventas_mail = value
        End Set
    End Property

    Public Property ventas_prod() As String
        Get
            Return _ventas_prod
        End Get
        Set(ByVal value As String)
            _ventas_prod = value
        End Set
    End Property

    Public Property ventas_cat() As String
        Get
            Return _ventas_cat
        End Get
        Set(ByVal value As String)
            _ventas_cat = value
        End Set
    End Property

    Public Property ventas_uni() As String
        Get
            Return _ventas_uni
        End Get
        Set(ByVal value As String)
            _ventas_uni = value
        End Set
    End Property

    Public Property ventas_canti() As Integer
        Get
            Return _ventas_canti
        End Get
        Set(ByVal value As Integer)
            _ventas_canti = value
        End Set
    End Property

    Public Property ventas_pu() As Decimal
        Get
            Return _ventas_pu
        End Get
        Set(ByVal value As Decimal)
            _ventas_pu = value
        End Set
    End Property

    Public Property ventas_sub() As Decimal
        Get
            Return _ventas_sub
        End Get
        Set(ByVal value As Decimal)
            _ventas_sub = value
        End Set
    End Property

    Public Property ventas_tot() As Decimal
        Get
            Return _ventas_tot
        End Get
        Set(ByVal value As Decimal)
            _ventas_tot = value
        End Set
    End Property

#End Region

#End Region

#Region "almacen"

#Region "DATAMEMBERS"

    Private _alma_gral_folio As String
    Private _alma_gral_fecha As Date
    Private _alma_gral_tpo As String
    Private _alma_gral_nom As String
    Private _alma_gral_uni As String
    Private _alma_gral_pack As String
    Private _alma_gral_canti As Integer

    Private _alma_refa_folio As String
    Private _alma_refa_fecha As Date
    Private _alma_refa_tpo As String
    Private _alma_refa_nom As String
    Private _alma_refa_uni As String
    Private _alma_refa_pack As String
    Private _alma_refa_canti As Integer

    Private _alma_prima_folio As String
    Private _alma_prima_fecha As Date
    Private _alma_prima_cadu As Date
    Private _alma_prima_tpo As String
    Private _alma_prima_nom As String
    Private _alma_prima_uni As String
    Private _alma_prima_pack As String
    Private _alma_prima_canti As Integer

    Private _alma_prod_folio As String
    Private _alma_prod_fecha As Date
    Private _alma_prod_cadu As Date
    Private _alma_prod_tpo As String
    Private _alma_prod_nom As String
    Private _alma_prod_uni As String
    Private _alma_prod_pack As String
    Private _alma_prod_canti As Integer

    Private _almagrl_nom As String
    Private _almagrl_uni As String
    Private _almagrl_pack As String
    Private _almagrl_canti As Integer
    Private _almagrl_tpo As String
    Private _almagrl_fecha As Date

    Private _almarefa_nom As String
    Private _almarefa_uni As String
    Private _almarefa_pack As String
    Private _almarefa_canti As Integer
    Private _almarefa_tpo As String
    Private _almarefa_fecha As Date

    Private _almapri_nom As String
    Private _almapri_uni As String
    Private _almapri_pack As String
    Private _almapri_canti As Integer
    Private _almapri_tpo As String
    Private _almapri_fecha As Date
    Private _almapri_cadu As Date

    Private _almater_nom As String
    Private _almater_uni As String
    Private _almater_pack As String
    Private _almater_canti As Integer
    Private _almater_tpo As String
    Private _almater_fecha As Date
    Private _almater_cadu As Date

    Private _almafecha As Date
    Private _almacadu As Date
    Private _almatpo As String
    Private _almanom As String
    Private _almauni As String
    Private _almapack As String
    Private _almacanti As Integer

#End Region

#Region "PROPIEDADES"

    Public Property almanom() As String
        Get
            Return _almanom
        End Get
        Set(ByVal value As String)
            _almanom = value
        End Set
    End Property

    Public Property almauni() As String
        Get
            Return _almauni
        End Get
        Set(ByVal value As String)
            _almauni = value
        End Set
    End Property

    Public Property almapack() As String
        Get
            Return _almapack
        End Get
        Set(ByVal value As String)
            _almapack = value
        End Set
    End Property

    Public Property almacanti() As Integer
        Get
            Return _almacanti
        End Get
        Set(ByVal value As Integer)
            _almacanti = value
        End Set
    End Property

    Public Property almatpo() As String
        Get
            Return _almatpo
        End Get
        Set(ByVal value As String)
            _almatpo = value
        End Set
    End Property

    Public Property almafecha() As Date
        Get
            Return _almafecha
        End Get
        Set(ByVal value As Date)
            _almafecha = value
        End Set
    End Property

    Public Property almacadu() As Date
        Get
            Return _almacadu
        End Get
        Set(ByVal value As Date)
            _almacadu = value
        End Set
    End Property

    Public Property almater_nom() As String
        Get
            Return _almater_nom
        End Get
        Set(ByVal value As String)
            _almater_nom = value
        End Set
    End Property

    Public Property almater_uni() As String
        Get
            Return _almater_uni
        End Get
        Set(ByVal value As String)
            _almater_uni = value
        End Set
    End Property

    Public Property almater_pack() As String
        Get
            Return _almater_pack
        End Get
        Set(ByVal value As String)
            _almater_pack = value
        End Set
    End Property

    Public Property almater_canti() As Integer
        Get
            Return _almater_canti
        End Get
        Set(ByVal value As Integer)
            _almater_canti = value
        End Set
    End Property

    Public Property almater_tpo() As String
        Get
            Return _almater_tpo
        End Get
        Set(ByVal value As String)
            _almater_tpo = value
        End Set
    End Property

    Public Property almater_fecha() As Date
        Get
            Return _almater_fecha
        End Get
        Set(ByVal value As Date)
            _almater_fecha = value
        End Set
    End Property

    Public Property almater_cadu() As Date
        Get
            Return _almater_cadu
        End Get
        Set(ByVal value As Date)
            _almater_cadu = value
        End Set
    End Property

    Public Property almapri_nom() As String
        Get
            Return _almapri_nom
        End Get
        Set(ByVal value As String)
            _almapri_nom = value
        End Set
    End Property

    Public Property almapri_uni() As String
        Get
            Return _almapri_uni
        End Get
        Set(ByVal value As String)
            _almapri_uni = value
        End Set
    End Property

    Public Property almapri_pack() As String
        Get
            Return _almapri_pack
        End Get
        Set(ByVal value As String)
            _almapri_pack = value
        End Set
    End Property

    Public Property almapri_canti() As Integer
        Get
            Return _almapri_canti
        End Get
        Set(ByVal value As Integer)
            _almapri_canti = value
        End Set
    End Property

    Public Property almapri_tpo() As String
        Get
            Return _almapri_tpo
        End Get
        Set(ByVal value As String)
            _almapri_tpo = value
        End Set
    End Property

    Public Property almapri_fecha() As Date
        Get
            Return _almapri_fecha
        End Get
        Set(ByVal value As Date)
            _almapri_fecha = value
        End Set
    End Property

    Public Property almapri_cadu() As Date
        Get
            Return _almapri_cadu
        End Get
        Set(ByVal value As Date)
            _almapri_cadu = value
        End Set
    End Property

    Public Property almarefa_nom() As String
        Get
            Return _almarefa_nom
        End Get
        Set(ByVal value As String)
            _almarefa_nom = value
        End Set
    End Property

    Public Property almarefa_uni() As String
        Get
            Return _almarefa_uni
        End Get
        Set(ByVal value As String)
            _almarefa_uni = value
        End Set
    End Property

    Public Property almarefa_pack() As String
        Get
            Return _almarefa_pack
        End Get
        Set(ByVal value As String)
            _almarefa_pack = value
        End Set
    End Property

    Public Property almarefa_canti() As Integer
        Get
            Return _almarefa_canti
        End Get
        Set(ByVal value As Integer)
            _almarefa_canti = value
        End Set
    End Property

    Public Property almarefa_tpo() As String
        Get
            Return _almarefa_tpo
        End Get
        Set(ByVal value As String)
            _almarefa_tpo = value
        End Set
    End Property

    Public Property almarefa_fecha() As Date
        Get
            Return _almarefa_fecha
        End Get
        Set(ByVal value As Date)
            _almarefa_fecha = value
        End Set
    End Property

    Public Property almagrl_nom() As String
        Get
            Return _almagrl_nom
        End Get
        Set(ByVal value As String)
            _almagrl_nom = value
        End Set
    End Property

    Public Property almagrl_uni() As String
        Get
            Return _almagrl_uni
        End Get
        Set(ByVal value As String)
            _almagrl_uni = value
        End Set
    End Property

    Public Property almagrl_pack() As String
        Get
            Return _almagrl_pack
        End Get
        Set(ByVal value As String)
            _almagrl_pack = value
        End Set
    End Property

    Public Property almagrl_canti() As Integer
        Get
            Return _almagrl_canti
        End Get
        Set(ByVal value As Integer)
            _almagrl_canti = value
        End Set
    End Property

    Public Property almagrl_tpo() As String
        Get
            Return _almagrl_tpo
        End Get
        Set(ByVal value As String)
            _almagrl_tpo = value
        End Set
    End Property

    Public Property almagrl_fecha() As Date
        Get
            Return _almagrl_fecha
        End Get
        Set(ByVal value As Date)
            _almagrl_fecha = value
        End Set
    End Property

    Public Property alma_prod_folio() As String
        Get
            Return _alma_prod_folio
        End Get
        Set(ByVal value As String)
            _alma_prod_folio = value
        End Set
    End Property

    Public Property alma_prod_fecha() As Date
        Get
            Return _alma_prod_fecha
        End Get
        Set(ByVal value As Date)
            _alma_prod_fecha = value
        End Set
    End Property

    Public Property alma_prod_cadu() As Date
        Get
            Return _alma_prod_cadu
        End Get
        Set(ByVal value As Date)
            _alma_prod_cadu = value
        End Set
    End Property

    Public Property alma_prod_tpo() As String
        Get
            Return _alma_prod_tpo
        End Get
        Set(ByVal value As String)
            _alma_prod_tpo = value
        End Set
    End Property

    Public Property alma_prod_nom() As String
        Get
            Return _alma_prod_nom
        End Get
        Set(ByVal value As String)
            _alma_prod_nom = value
        End Set
    End Property

    Public Property alma_prod_uni() As String
        Get
            Return _alma_prod_uni
        End Get
        Set(ByVal value As String)
            _alma_prod_uni = value
        End Set
    End Property

    Public Property alma_prod_pack() As String
        Get
            Return _alma_prod_pack
        End Get
        Set(ByVal value As String)
            _alma_prod_pack = value
        End Set
    End Property

    Public Property alma_prod_canti() As Integer
        Get
            Return _alma_prod_canti
        End Get
        Set(ByVal value As Integer)
            _alma_prod_canti = value
        End Set
    End Property

    Public Property alma_prima_folio() As String
        Get
            Return _alma_prima_folio
        End Get
        Set(ByVal value As String)
            _alma_prima_folio = value
        End Set
    End Property

    Public Property alma_prima_fecha() As Date
        Get
            Return _alma_prima_fecha
        End Get
        Set(ByVal value As Date)
            _alma_prima_fecha = value
        End Set
    End Property

    Public Property alma_prima_cadu() As Date
        Get
            Return _alma_prima_cadu
        End Get
        Set(ByVal value As Date)
            _alma_prima_cadu = value
        End Set
    End Property

    Public Property alma_prima_tpo() As String
        Get
            Return _alma_prima_tpo
        End Get
        Set(ByVal value As String)
            _alma_prima_tpo = value
        End Set
    End Property

    Public Property alma_prima_nom() As String
        Get
            Return _alma_prima_nom
        End Get
        Set(ByVal value As String)
            _alma_prima_nom = value
        End Set
    End Property

    Public Property alma_prima_uni() As String
        Get
            Return _alma_prima_uni
        End Get
        Set(ByVal value As String)
            _alma_prima_uni = value
        End Set
    End Property

    Public Property alma_prima_pack() As String
        Get
            Return _alma_prima_pack
        End Get
        Set(ByVal value As String)
            _alma_prima_pack = value
        End Set
    End Property

    Public Property alma_prima_canti() As Integer
        Get
            Return _alma_prima_canti
        End Get
        Set(ByVal value As Integer)
            _alma_prima_canti = value
        End Set
    End Property

    Public Property alma_refa_folio() As String
        Get
            Return _alma_refa_folio
        End Get
        Set(ByVal value As String)
            _alma_refa_folio = value
        End Set
    End Property

    Public Property alma_refa_fecha() As Date
        Get
            Return _alma_refa_fecha
        End Get
        Set(ByVal value As Date)
            _alma_refa_fecha = value
        End Set
    End Property

    Public Property alma_refa_tpo() As String
        Get
            Return _alma_refa_tpo
        End Get
        Set(ByVal value As String)
            _alma_refa_tpo = value
        End Set
    End Property

    Public Property alma_refa_nom() As String
        Get
            Return _alma_refa_nom
        End Get
        Set(ByVal value As String)
            _alma_refa_nom = value
        End Set
    End Property

    Public Property alma_refa_uni() As String
        Get
            Return _alma_refa_uni
        End Get
        Set(ByVal value As String)
            _alma_refa_uni = value
        End Set
    End Property

    Public Property alma_refa_pack() As String
        Get
            Return _alma_refa_pack
        End Get
        Set(ByVal value As String)
            _alma_refa_pack = value
        End Set
    End Property

    Public Property alma_refa_canti() As Integer
        Get
            Return _alma_refa_canti
        End Get
        Set(ByVal value As Integer)
            _alma_refa_canti = value
        End Set
    End Property

    Public Property alma_gral_folio() As String
        Get
            Return _alma_gral_folio
        End Get
        Set(ByVal value As String)
            _alma_gral_folio = value
        End Set
    End Property

    Public Property alma_gral_fecha() As Date
        Get
            Return _alma_gral_fecha
        End Get
        Set(ByVal value As Date)
            _alma_gral_fecha = value
        End Set
    End Property

    Public Property alma_gral_tpo() As String
        Get
            Return _alma_gral_tpo
        End Get
        Set(ByVal value As String)
            _alma_gral_tpo = value
        End Set
    End Property

    Public Property alma_gral_nom() As String
        Get
            Return _alma_gral_nom
        End Get
        Set(ByVal value As String)
            _alma_gral_nom = value
        End Set
    End Property

    Public Property alma_gral_uni() As String
        Get
            Return _alma_gral_uni
        End Get
        Set(ByVal value As String)
            _alma_gral_uni = value
        End Set
    End Property

    Public Property alma_gral_pack() As String
        Get
            Return _alma_gral_pack
        End Get
        Set(ByVal value As String)
            _alma_gral_pack = value
        End Set
    End Property

    Public Property alma_gral_canti() As Integer
        Get
            Return _alma_gral_canti
        End Get
        Set(ByVal value As Integer)
            _alma_gral_canti = value
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
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
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
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

        'Debug
        'MsgBox(resultado.ToString, MsgBoxStyle.Information, "UbiSoft by Ubicamatic - 2020(C)")

        'Regresamos el resultado de la consulta
        Return resultado

    End Function

#End Region

#Region "proveedores"

    ''' <summary>
    ''' Se encarga de consultar a proveedores y llenar al cbo correspondiente con el razon_prov
    ''' </summary>
    Public Sub GetAllProv()

        'Variables Locales
        Dim con As New Conexion

        'Control Excepción
        Try

            'Conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM proveedores", con._conexion)
            _adaptador.Fill(_dtsCbo)

            'Cbo
            _adaptador.Fill(_dtsCbo, "nomProv")
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
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
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
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
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
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
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
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
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
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
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
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
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
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

    End Sub

    ''' <summary>
    ''' Se encarga de obtener los datos de un inventario en particular y regresarlo como datos
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>Resultado como objeto de Datos</returns>
    Public Function GetInvRfid(ByVal Datos As Datos) As Datos

        'Variables locales
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM inventario WHERE tag_inv = @tag_inv", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@tag_inv", MySqlDbType.String, 45).Value = Datos.tag_inv

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

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

        'Regresamos el resultado de la consulta
        Return resultado

    End Function

#End Region

#Region "prima"

    ''' <summary>
    ''' Consulta la tabla prima
    ''' Obtiene el prima_nombre
    ''' Si existe devuelve false
    ''' Si no existe devuelve true
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function ChkPrimaKey(ByVal datos As Datos) As Boolean

        'Privadas
        Dim con As New Conexion
        Dim key As String
        Dim flg As Boolean = True

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT prima_nombre FROM prima WHERE prima_nombre = @prima_nombre", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@prima_nombre", MySqlDbType.String, 45).Value = datos.prima_nombre

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            key = _adaptador.SelectCommand.ExecuteScalar()

            'Validación
            If (String.IsNullOrEmpty(key)) Then
            Else

                'Flg to false
                flg = False

            End If

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
            con._conexion.Close()

        End Try

        'Return
        Return flg

    End Function

    ''' <summary>
    ''' Crea una tabla harcode en el dataset
    ''' Crea las columnas del tipo ncesario para los datos
    ''' Realiza una consulta para obtener los datos de la tabla prima
    ''' Mediante un reader almacena los datos
    ''' Genera una nueva fila en el dataset con todos los datos
    ''' </summary>
    Public Sub DgvAllPrima()

        'Privadas
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Init Tabla, hardcode MAQREP
        dgvCode.Tables.Add("PRIMA")
        dgvCode.Tables("PRIMA").Columns.Add("Foto", GetType(Byte()))
        dgvCode.Tables("PRIMA").Columns.Add("Nombre", GetType(String))
        dgvCode.Tables("PRIMA").Columns.Add("Interno", GetType(String))
        dgvCode.Tables("PRIMA").Columns.Add("Comercial", GetType(String))
        dgvCode.Tables("PRIMA").Columns.Add("TAG", GetType(String))
        dgvCode.Tables("PRIMA").Columns.Add("Descripción", GetType(String))

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM prima", con._conexion)

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.prima_foto = reader("prima_foto")
                resultado.prima_nombre = reader("prima_nombre")
                resultado.prima_interno = reader("prima_interno")
                resultado.prima_comercial = reader("prima_comercial")
                resultado.prima_tag = reader("prima_tag")
                resultado.prima_desc = reader("prima_desc")

                'Agregamos el arreglo byte para la foto y los demás datos
                dgvCode.Tables("PRIMA").Rows.Add(resultado.prima_foto, resultado.prima_nombre, resultado.prima_interno, resultado.prima_comercial, resultado.prima_tag, resultado.prima_desc)

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

    End Sub

    ''' <summary>
    ''' Se encarga de obtener los datos de una materia prima en particular y regresarlo como datos
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>Resultado como objeto de Datos</returns>
    Public Function GetPrimaRfid(ByVal Datos As Datos) As Datos

        'Variables locales
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM prima WHERE prima_tag = @prima_tag", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@prima_tag", MySqlDbType.String, 45).Value = Datos.prima_tag

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.prima_foto = reader("prima_foto")
                resultado.prima_nombre = reader("prima_nombre")
                resultado.prima_interno = reader("prima_interno")
                resultado.prima_comercial = reader("prima_comercial")
                resultado.prima_tag = reader("prima_tag")
                resultado.prima_desc = reader("prima_desc")

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

        'Regresamos el resultado de la consulta
        Return resultado

    End Function

#End Region

#Region "ctapropia"

    ''' <summary>
    ''' Crea una tabla harcode en el dataset
    ''' Crea las columnas del tipo ncesario para los datos
    ''' Realiza una consulta para obtener los datos de la tabla ctapropia
    ''' Mediante un reader almacena los datos
    ''' Genera una nueva fila en el dataset con todos los datos
    ''' </summary>
    Public Sub DgvAllCtaPropia()

        'Privadas
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Init Tabla, hardcode PROPIA
        dgvCode.Tables.Add("PROPIA")
        dgvCode.Tables("PROPIA").Columns.Add("Nombre", GetType(String))
        dgvCode.Tables("PROPIA").Columns.Add("Banco", GetType(String))
        dgvCode.Tables("PROPIA").Columns.Add("Id SAT", GetType(String))
        dgvCode.Tables("PROPIA").Columns.Add("No. de Cuenta", GetType(String))
        dgvCode.Tables("PROPIA").Columns.Add("Plaza", GetType(String))
        dgvCode.Tables("PROPIA").Columns.Add("Sucursal", GetType(String))
        dgvCode.Tables("PROPIA").Columns.Add("Tipo", GetType(String))
        dgvCode.Tables("PROPIA").Columns.Add("CLABE", GetType(String))
        dgvCode.Tables("PROPIA").Columns.Add("ABB", GetType(String))

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM ctapropia", con._conexion)

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.propia_nom = reader("propia_nom")
                resultado.propia_banco = reader("propia_banco")
                resultado.propia_keybanco = reader("propia_keybanco")
                resultado.propia_nocuenta = reader("propia_nocuenta")
                resultado.propia_noplaza = reader("propia_noplaza")
                resultado.propia_nosuc = reader("propia_nosuc")
                resultado.propia_tipo = reader("propia_tipo")
                resultado.propia_clabe = reader("propia_clabe")
                resultado.propia_abb = reader("propia_abb")

                'Agregamos el arreglo byte para la foto y los demás datos
                dgvCode.Tables("PROPIA").Rows.Add(resultado.propia_nom, resultado.propia_banco, resultado.propia_keybanco, resultado.propia_nocuenta, resultado.propia_noplaza, resultado.propia_nosuc, resultado.propia_tipo, resultado.propia_clabe, resultado.propia_abb)

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

    End Sub

#End Region

#Region "ctasexterna"

    ''' <summary>
    ''' Crea una tabla harcode en el dataset
    ''' Crea las columnas del tipo necesario para los datos
    ''' Realiza una consulta para obtener los datos de la tabla ctasexterna
    ''' Mediante un reader almacena los datos
    ''' Genera una nueva fila en el dataset con todos los datos
    ''' </summary>
    Public Sub DgvAllCtaExt()

        'Privadas
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Init Tabla, hardcode PROPIA
        dgvCode.Tables.Add("EXTERNA")
        dgvCode.Tables("EXTERNA").Columns.Add("Proveedor", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("RFC", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Mail", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Tel.", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Beneficiario", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Banco", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Id. SAT", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Cuenta", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Plaza", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Sucursal", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Tipo", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Clabe", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("ABB", GetType(String))

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM ctasexterna", con._conexion)

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.ext_nomprov = reader("ext_nomprov")
                resultado.ext_rfc = reader("ext_rfc")
                resultado.ext_mail = reader("ext_mail")
                resultado.ext_tel = reader("ext_tel")
                resultado.ext_nom = reader("ext_nom")
                resultado.ext_banco = reader("ext_banco")
                resultado.ext_keybanco = reader("ext_keybanco")
                resultado.ext_nocuenta = reader("ext_nocuenta")
                resultado.ext_noplaza = reader("ext_noplaza")
                resultado.ext_nosuc = reader("ext_nosuc")
                resultado.ext_tipo = reader("ext_tipo")
                resultado.ext_clabe = reader("ext_clabe")
                resultado.ext_abb = reader("ext_abb")

                'Agregamos el arreglo byte para la foto y los demás datos
                dgvCode.Tables("EXTERNA").Rows.Add(resultado.ext_nomprov, resultado.ext_rfc, resultado.ext_mail, resultado.ext_tel, resultado.ext_nom, resultado.ext_banco, resultado.ext_keybanco, resultado.ext_nocuenta, resultado.ext_noplaza, resultado.ext_nosuc, resultado.ext_tipo, resultado.ext_clabe, resultado.ext_abb)

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

    End Sub

    ''' <summary>
    ''' Se encarga de obtener los datos de una cuenta externa en particular y regresarlo como datos
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>Resultado como objeto de Datos</returns>
    Public Function GetExtProv(ByVal Datos As Datos) As Datos
        'Variables locales
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM ctasexterna WHERE ext_nomprov = @ext_nomprov", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@ext_nomprov", MySqlDbType.String, 45).Value = Datos.ext_nomprov

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.ext_nomprov = reader("ext_nomprov").ToString
                resultado.ext_rfc = reader("ext_rfc").ToString
                resultado.ext_mail = reader("ext_mail").ToString
                resultado.ext_tel = reader("ext_tel")
                resultado.ext_nom = reader("ext_nom")
                resultado.ext_banco = reader("ext_banco")
                resultado.ext_keybanco = reader("ext_keybanco")
                resultado.ext_nocuenta = reader("ext_nocuenta")
                resultado.ext_noplaza = reader("ext_noplaza")
                resultado.ext_nosuc = reader("ext_nosuc")
                resultado.ext_tipo = reader("ext_tipo")
                resultado.ext_clabe = reader("ext_clabe")
                resultado.ext_abb = reader("ext_abb")

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

        'Debug
        'MsgBox(resultado.ToString, MsgBoxStyle.Information, "UbiSoft by Ubicamatic - 2020(C)")

        'Regresamos el resultado de la consulta
        Return resultado

    End Function

    ''' <summary>
    ''' Crea una tabla harcode en el dataset
    ''' Crea las columnas del tipo necesario para los datos
    ''' Realiza una consulta para obtener los datos de la tabla ctasexterna
    ''' Mediante un reader almacena los datos
    ''' Genera una nueva fila en el dataset con todos los datos
    ''' </summary>
    Public Sub DgvCtaExt(ByVal Datos As Datos)

        'Privadas
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Init Tabla, hardcode CTASEXTERNA
        dgvCode.Tables.Add("EXTERNA")
        dgvCode.Tables("EXTERNA").Columns.Add("Proveedor", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("RFC", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Mail", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Tel.", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Beneficiario", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Banco", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Id. SAT", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Cuenta", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Plaza", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Sucursal", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Tipo", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("Clabe", GetType(String))
        dgvCode.Tables("EXTERNA").Columns.Add("ABB", GetType(String))

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM ctasexterna WHERE ext_nomprov = @ext_nomprov", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@ext_nomprov", MySqlDbType.String, 45).Value = Datos.ext_nomprov

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.ext_nomprov = reader("ext_nomprov")
                resultado.ext_rfc = reader("ext_rfc")
                resultado.ext_mail = reader("ext_mail")
                resultado.ext_tel = reader("ext_tel")
                resultado.ext_nom = reader("ext_nom")
                resultado.ext_banco = reader("ext_banco")
                resultado.ext_keybanco = reader("ext_keybanco")
                resultado.ext_nocuenta = reader("ext_nocuenta")
                resultado.ext_noplaza = reader("ext_noplaza")
                resultado.ext_nosuc = reader("ext_nosuc")
                resultado.ext_tipo = reader("ext_tipo")
                resultado.ext_clabe = reader("ext_clabe")
                resultado.ext_abb = reader("ext_abb")

                'Agregamos el arreglo byte para la foto y los demás datos
                dgvCode.Tables("EXTERNA").Rows.Add(resultado.ext_nomprov, resultado.ext_rfc, resultado.ext_mail, resultado.ext_tel, resultado.ext_nom, resultado.ext_banco, resultado.ext_keybanco, resultado.ext_nocuenta, resultado.ext_noplaza, resultado.ext_nosuc, resultado.ext_tipo, resultado.ext_clabe, resultado.ext_abb)

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

    End Sub

#End Region

#Region "ventas"

    ''' <summary>
    ''' *****************************************
    ''' *** SOLO VALORES DISTINTOS DE FOLIOS ****
    ''' *****************************************
    ''' Se encarga de consultar a ventas y llenar al cbo correspondiente con ventas_folio
    ''' </summary>
    Public Sub GetFolioVta()

        'Variables Locales
        Dim con As New Conexion

        'Control Excepción
        Try

            'Conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand = New MySqlCommand("SELECT DISTINCT(ventas_folio) FROM ventas", con._conexion)
            _adaptador.Fill(_dtsCbo)

            'Cbo
            _adaptador.Fill(_dtsCbo, "ventas_folio")
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
    ''' Se encarga de obtener los datos de un folio de venta en particular y regresarlo como datos
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>Resultado como objeto de Datos</returns>
    Public Function GetVtaDetail(ByVal Datos As Datos) As Datos
        'Variables locales
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM ventas WHERE ventas_folio = @ventas_folio", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@ventas_folio", MySqlDbType.String, 45).Value = Datos.ventas_folio

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.ventas_folio = reader("ventas_folio")
                resultado.ventas_date = reader("ventas_date").ToString
                resultado.ventas_usr = reader("ventas_usr")
                resultado.ventas_rfc = reader("ventas_rfc")
                resultado.ventas_nom = reader("ventas_nom")
                resultado.ventas_mail = reader("ventas_mail")
                resultado.ventas_tot = reader("ventas_tot")

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

        'Debug
        'MsgBox(resultado.ToString, MsgBoxStyle.Information, "UbiSoft by Ubicamatic - 2020(C)")

        'Regresamos el resultado de la consulta
        Return resultado

    End Function

    ''' <summary>
    ''' Se encarga de consultar la tabla de ventas y llenar el DGV con el resultado
    ''' </summary>
    Public Sub GetAllVta(ByVal Datos As Datos)

        'Privadas
        Dim con As New Conexion

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand =
                New MySqlCommand("SELECT ventas_prod, ventas_cat, ventas_uni, ventas_canti, ventas_pu, ventas_sub FROM ventas WHERE ventas_folio = @ventas_folio", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@ventas_folio", MySqlDbType.String, 45).Value = Datos.ventas_folio

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
    ''' Crea las columnas del tipo necesario para los datos
    ''' Realiza una consulta para obtener los datos de la tabla ventas
    ''' Mediante un reader almacena los datos
    ''' Genera una nueva fila en el dataset con todos los datos
    ''' </summary>
    Public Sub GetPerVtas(ByVal Datos As Datos)

        'Privadas
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Init Tabla, hardcode PERVTA
        dgvCode.Tables.Add("PERVTA")
        dgvCode.Tables("PERVTA").Columns.Add("Folio", GetType(String))
        dgvCode.Tables("PERVTA").Columns.Add("Fecha", GetType(Date))
        dgvCode.Tables("PERVTA").Columns.Add("RFC", GetType(String))
        dgvCode.Tables("PERVTA").Columns.Add("Cliente", GetType(String))
        dgvCode.Tables("PERVTA").Columns.Add("Correo", GetType(String))
        dgvCode.Tables("PERVTA").Columns.Add("Total", GetType(String))

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand =
                New MySqlCommand("SELECT DISTINCT ventas_folio, ventas_date, ventas_rfc, ventas_nom, ventas_mail, ventas_tot FROM ventas WHERE ventas_date >= @ini AND ventas_date <= @fin", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@ini", MySqlDbType.Date).Value = Datos.periodo_ini
            _adaptador.SelectCommand.Parameters.Add("@fin", MySqlDbType.Date).Value = Datos.periodo_fin

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.ventas_folio = reader("ventas_folio")
                resultado.ventas_date = reader("ventas_date")
                resultado.ventas_rfc = reader("ventas_rfc")
                resultado.ventas_nom = reader("ventas_nom")
                resultado.ventas_mail = reader("ventas_mail")
                resultado.ventas_tot = reader("ventas_tot")

                'Type Parse
                Dim total As String = (resultado.ventas_tot).ToString("$ #,###,##0.00")

                'Agregamos el arreglo byte para la foto y los demás datos
                dgvCode.Tables("PERVTA").Rows.Add(resultado.ventas_folio, resultado.ventas_date, resultado.ventas_rfc, resultado.ventas_nom, resultado.ventas_mail, total)

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

    End Sub

    ''' <summary>
    ''' Crea una tabla harcode en el dataset
    ''' Crea las columnas del tipo necesario para los datos
    ''' Realiza una consulta para obtener los datos de la tabla ventas
    ''' Mediante un reader almacena los datos
    ''' Genera una nueva fila en el dataset con todos los datos
    ''' </summary>
    Public Sub GetCliVtas(ByVal Datos As Datos)

        'Privadas
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Init Tabla, hardcode PERVTA
        dgvCode.Tables.Add("CLIVTA")
        dgvCode.Tables("CLIVTA").Columns.Add("Folio", GetType(String))
        dgvCode.Tables("CLIVTA").Columns.Add("Fecha", GetType(Date))
        dgvCode.Tables("CLIVTA").Columns.Add("RFC", GetType(String))
        dgvCode.Tables("CLIVTA").Columns.Add("Cliente", GetType(String))
        dgvCode.Tables("CLIVTA").Columns.Add("Correo", GetType(String))
        dgvCode.Tables("CLIVTA").Columns.Add("Total", GetType(String))

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand =
                New MySqlCommand("SELECT DISTINCT ventas_folio, ventas_date, ventas_rfc, ventas_nom, ventas_mail, ventas_tot FROM ventas WHERE ventas_date >= @ini AND ventas_date <= @fin AND ventas_rfc = @ventas_rfc", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@ini", MySqlDbType.Date).Value = Datos.cliente_ini
            _adaptador.SelectCommand.Parameters.Add("@fin", MySqlDbType.Date).Value = Datos.cliente_fin
            _adaptador.SelectCommand.Parameters.Add("@ventas_rfc", MySqlDbType.String, 45).Value = Datos.ventas_rfc

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.ventas_folio = reader("ventas_folio")
                resultado.ventas_date = reader("ventas_date")
                resultado.ventas_rfc = reader("ventas_rfc")
                resultado.ventas_nom = reader("ventas_nom")
                resultado.ventas_mail = reader("ventas_mail")
                resultado.ventas_tot = reader("ventas_tot")

                'Type Parse
                Dim total As String = (resultado.ventas_tot).ToString("$ #,###,##0.00")

                'Agregamos el arreglo byte para la foto y los demás datos
                dgvCode.Tables("CLIVTA").Rows.Add(resultado.ventas_folio, resultado.ventas_date, resultado.ventas_rfc, resultado.ventas_nom, resultado.ventas_mail, total)

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

    End Sub
#End Region

#Region "almacenes"

    ''' <summary>
    ''' Crea una tabla harcode en el dataset
    ''' Crea las columnas del tipo necesario para los datos
    ''' Realiza una consulta para obtener los datos de las tablas de almacenes
    ''' Mediante un reader almacena los datos
    ''' Genera una nueva fila en el dataset con todos los datos
    ''' </summary>
    Public Sub GetFolAlma(ByVal Datos As Datos)

        'Privadas
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Init Tabla, hardcode PERALMA
        dgvCode.Tables.Add("PERALMA")
        dgvCode.Tables("PERALMA").Columns.Add("Folio", GetType(String))
        dgvCode.Tables("PERALMA").Columns.Add("Fecha", GetType(Date))
        dgvCode.Tables("PERALMA").Columns.Add("Tipo", GetType(String))
        dgvCode.Tables("PERALMA").Columns.Add("Nombre", GetType(String))
        dgvCode.Tables("PERALMA").Columns.Add("Unidades", GetType(String))
        dgvCode.Tables("PERALMA").Columns.Add("Pack", GetType(String))
        dgvCode.Tables("PERALMA").Columns.Add("Cantidad", GetType(Integer))

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand =
                New MySqlCommand("SELECT * FROM alma_general WHERE alma_gral_fecha >= @ini AND alma_gral_fecha <= @fin", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@ini", MySqlDbType.Date).Value = Datos.periodo_ini
            _adaptador.SelectCommand.Parameters.Add("@fin", MySqlDbType.Date).Value = Datos.periodo_fin

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.alma_gral_folio = reader("alma_gral_folio")
                resultado.alma_gral_fecha = reader("alma_gral_fecha")
                resultado.alma_gral_tpo = reader("alma_gral_tpo")
                resultado.alma_gral_nom = reader("alma_gral_nom")
                resultado.alma_gral_uni = reader("alma_gral_uni")
                resultado.alma_gral_pack = reader("alma_gral_pack")
                resultado.alma_gral_canti = reader("alma_gral_canti")

                'Agregamos el arreglo byte para la foto y los demás datos
                dgvCode.Tables("PERALMA").Rows.Add(resultado.alma_gral_folio, resultado.alma_gral_fecha, resultado.alma_gral_tpo, resultado.alma_gral_nom, resultado.alma_gral_uni, resultado.alma_gral_pack, resultado.alma_gral_canti)

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand =
                New MySqlCommand("SELECT * FROM alma_refa WHERE alma_refa_fecha >= @ini AND alma_refa_fecha <= @fin", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@ini", MySqlDbType.Date).Value = Datos.periodo_ini
            _adaptador.SelectCommand.Parameters.Add("@fin", MySqlDbType.Date).Value = Datos.periodo_fin

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.alma_refa_folio = reader("alma_refa_folio")
                resultado.alma_refa_fecha = reader("alma_refa_fecha")
                resultado.alma_refa_tpo = reader("alma_refa_tpo")
                resultado.alma_refa_nom = reader("alma_refa_nom")
                resultado.alma_refa_uni = reader("alma_refa_uni")
                resultado.alma_refa_pack = reader("alma_refa_pack")
                resultado.alma_refa_canti = reader("alma_refa_canti")

                'Agregamos el arreglo byte para la foto y los demás datos
                dgvCode.Tables("PERALMA").Rows.Add(resultado.alma_refa_folio, resultado.alma_refa_fecha, resultado.alma_refa_tpo, resultado.alma_refa_nom, resultado.alma_refa_uni, resultado.alma_refa_pack, resultado.alma_refa_canti)

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand =
                New MySqlCommand("SELECT * FROM alma_prima WHERE alma_prima_fecha >= @ini AND alma_prima_fecha <= @fin", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@ini", MySqlDbType.Date).Value = Datos.periodo_ini
            _adaptador.SelectCommand.Parameters.Add("@fin", MySqlDbType.Date).Value = Datos.periodo_fin

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.alma_prima_folio = reader("alma_prima_folio")
                resultado.alma_prima_fecha = reader("alma_prima_fecha")
                resultado.alma_prima_tpo = reader("alma_prima_tpo")
                resultado.alma_prima_nom = reader("alma_prima_nom")
                resultado.alma_prima_uni = reader("alma_prima_uni")
                resultado.alma_prima_pack = reader("alma_prima_pack")
                resultado.alma_prima_canti = reader("alma_prima_canti")

                'Agregamos el arreglo byte para la foto y los demás datos
                dgvCode.Tables("PERALMA").Rows.Add(resultado.alma_prima_folio, resultado.alma_prima_fecha, resultado.alma_prima_tpo, resultado.alma_prima_nom, resultado.alma_prima_uni, resultado.alma_prima_pack, resultado.alma_prima_canti)

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand =
                New MySqlCommand("SELECT * FROM alma_prod WHERE alma_prod_fecha >= @ini AND alma_prod_fecha <= @fin", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@ini", MySqlDbType.Date).Value = Datos.periodo_ini
            _adaptador.SelectCommand.Parameters.Add("@fin", MySqlDbType.Date).Value = Datos.periodo_fin

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.alma_prod_folio = reader("alma_prod_folio")
                resultado.alma_prod_fecha = reader("alma_prod_fecha")
                resultado.alma_prod_tpo = reader("alma_prod_tpo")
                resultado.alma_prod_nom = reader("alma_prod_nom")
                resultado.alma_prod_uni = reader("alma_prod_uni")
                resultado.alma_prod_pack = reader("alma_prod_pack")
                resultado.alma_prod_canti = reader("alma_prod_canti")

                'Agregamos el arreglo byte para la foto y los demás datos
                dgvCode.Tables("PERALMA").Rows.Add(resultado.alma_prod_folio, resultado.alma_prod_fecha, resultado.alma_prod_tpo, resultado.alma_prod_nom, resultado.alma_prod_uni, resultado.alma_prod_pack, resultado.alma_prod_canti)

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

    End Sub

    ''' <summary>
    ''' Obtiene todos los datos de la tabla almagrl y carga el CBO con el resultado
    ''' </summary>
    Public Sub GetAlmagralCbo()

        'Variables Locales
        Dim con As New Conexion

        'Control Excepción
        Try

            'Conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM almagrl", con._conexion)
            _adaptador.Fill(_dtsCbo)

            'Cbo
            _adaptador.Fill(_dtsCbo, "almagrl_nom")
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
    ''' Se encarga de consultar la tabla de almagral y llenar el DGV con el resultado
    ''' </summary>
    Public Sub GetAlmagralDgv(ByVal Datos As Datos)

        'Privadas
        Dim con As New Conexion

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand =
                New MySqlCommand("SELECT * FROM almagrl", con._conexion)

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
    ''' Se encarga de obtener los datos de un producto de almagrl en particular y regresarlo como datos
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>Resultado como objeto de Datos</returns>
    Public Function GetAlmagrlData(ByVal Datos As Datos) As Datos
        'Variables locales
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM almagrl WHERE almagrl_nom = @almagrl_nom", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@almagrl_nom", MySqlDbType.String, 100).Value = Datos.almagrl_nom

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.almagrl_uni = reader("almagrl_uni")
                resultado.almagrl_pack = reader("almagrl_pack")
                resultado.almagrl_canti = reader("almagrl_canti")
                resultado.almagrl_tpo = reader("almagrl_tpo")
                resultado.almagrl_fecha = reader("almagrl_fecha")

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

        'Debug
        'MsgBox(resultado.ToString, MsgBoxStyle.Information, "UbiSoft by Ubicamatic - 2020(C)")

        'Regresamos el resultado de la consulta
        Return resultado

    End Function

    ''' <summary>
    ''' Obtiene todos los datos de la tabla almarefa y carga el CBO con el resultado
    ''' </summary>
    Public Sub GetAlmarefaCbo()

        'Variables Locales
        Dim con As New Conexion

        'Control Excepción
        Try

            'Conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM almarefa", con._conexion)
            _adaptador.Fill(_dtsCbo)

            'Cbo
            _adaptador.Fill(_dtsCbo, "almarefa_nom")
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
    ''' Se encarga de consultar la tabla de almarefa y llenar el DGV con el resultado
    ''' </summary>
    Public Sub GetAlmarefaDgv(ByVal Datos As Datos)

        'Privadas
        Dim con As New Conexion

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand =
                New MySqlCommand("SELECT * FROM almarefa", con._conexion)

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
    ''' Se encarga de obtener los datos de un producto de almarefa en particular y regresarlo como datos
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>Resultado como objeto de Datos</returns>
    Public Function GetAlmarefaData(ByVal Datos As Datos) As Datos
        'Variables locales
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM almarefa WHERE almarefa_nom = @almarefa_nom", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@almarefa_nom", MySqlDbType.String, 100).Value = Datos.almarefa_nom

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.almarefa_uni = reader("almarefa_uni")
                resultado.almarefa_pack = reader("almarefa_pack")
                resultado.almarefa_canti = reader("almarefa_canti")
                resultado.almarefa_tpo = reader("almarefa_tpo")
                resultado.almarefa_fecha = reader("almarefa_fecha")

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

        'Debug
        'MsgBox(resultado.ToString, MsgBoxStyle.Information, "UbiSoft by Ubicamatic - 2020(C)")

        'Regresamos el resultado de la consulta
        Return resultado

    End Function

    ''' <summary>
    ''' Obtiene todos los datos de la tabla almapri y carga el CBO con el resultado
    ''' </summary>
    Public Sub GetAlmapriCbo()

        'Variables Locales
        Dim con As New Conexion

        'Control Excepción
        Try

            'Conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM almapri", con._conexion)
            _adaptador.Fill(_dtsCbo)

            'Cbo
            _adaptador.Fill(_dtsCbo, "almapri_nom")
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
    ''' Se encarga de consultar la tabla de almapri y llenar el DGV con el resultado
    ''' </summary>
    Public Sub GetAlmapriDgv(ByVal Datos As Datos)

        'Privadas
        Dim con As New Conexion

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand =
                New MySqlCommand("SELECT * FROM almapri", con._conexion)

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
    ''' Se encarga de obtener los datos de un producto de almapri en particular y regresarlo como datos
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>Resultado como objeto de Datos</returns>
    Public Function GetAlmapriData(ByVal Datos As Datos) As Datos
        'Variables locales
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM almapri WHERE almapri_nom = @almapri_nom", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@almapri_nom", MySqlDbType.String, 100).Value = Datos.almapri_nom

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.almapri_uni = reader("almapri_uni")
                resultado.almapri_pack = reader("almapri_pack")
                resultado.almapri_canti = reader("almapri_canti")
                resultado.almapri_tpo = reader("almapri_tpo")
                resultado.almapri_fecha = reader("almapri_fecha")
                resultado.almapri_cadu = reader("almapri_cadu")

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

        'Debug
        'MsgBox(resultado.ToString, MsgBoxStyle.Information, "UbiSoft by Ubicamatic - 2020(C)")

        'Regresamos el resultado de la consulta
        Return resultado

    End Function

    ''' <summary>
    ''' Obtiene todos los datos de la tabla almater y carga el CBO con el resultado
    ''' </summary>
    Public Sub GetAlmaterCbo()

        'Variables Locales
        Dim con As New Conexion

        'Control Excepción
        Try

            'Conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM almater", con._conexion)
            _adaptador.Fill(_dtsCbo)

            'Cbo
            _adaptador.Fill(_dtsCbo, "almater_nom")
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
    ''' Se encarga de consultar la tabla de almater y llenar el DGV con el resultado
    ''' </summary>
    Public Sub GetAlmaterDgv(ByVal Datos As Datos)

        'Privadas
        Dim con As New Conexion

        'Control de excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql
            _adaptador.SelectCommand =
                New MySqlCommand("SELECT * FROM almater", con._conexion)

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
    ''' Se encarga de obtener los datos de un producto de almater en particular y regresarlo como datos
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>Resultado como objeto de Datos</returns>
    Public Function GetAlmaterData(ByVal Datos As Datos) As Datos
        'Variables locales
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim resultado As New Datos

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM almater WHERE almater_nom = @almater_nom", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@almater_nom", MySqlDbType.String, 100).Value = Datos.almater_nom

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()

                'Captura de datos en el objeto
                resultado.almater_uni = reader("almater_uni")
                resultado.almater_pack = reader("almater_pack")
                resultado.almater_canti = reader("almater_canti")
                resultado.almater_tpo = reader("almater_tpo")
                resultado.almater_fecha = reader("almater_fecha")
                resultado.almater_cadu = reader("almater_cadu")

            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

        'Debug
        'MsgBox(resultado.ToString, MsgBoxStyle.Information, "UbiSoft by Ubicamatic - 2020(C)")

        'Regresamos el resultado de la consulta
        Return resultado

    End Function

    ''' <summary>
    ''' Se encarga de verificar que un producto sea único en la tabla
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>Password as string</returns>
    Public Function ChkUniqueAlmaGral(ByVal Datos As Datos) As String
        'Variables locales
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim data As String = ""
        Dim unique As Boolean = False

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT almagrl_nom FROM almagrl WHERE almagrl_nom = @nombre", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@nombre", MySqlDbType.String, 100).Value = Datos.almanom

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()
                data = reader("almagrl_nom").ToString()
            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

        'Validación
        If (String.IsNullOrEmpty(data)) Then

            'Flg
            unique = True

        End If

        'Regresamos el resultado de la validación
        Return unique

    End Function

    ''' <summary>
    ''' Se encarga de verificar que un producto sea único en la tabla
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>Password as string</returns>
    Public Function ChkUniqueAlmaRefa(ByVal Datos As Datos) As String
        'Variables locales
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim data As String = ""
        Dim unique As Boolean = False

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT almarefa_nom FROM almarefa WHERE almarefa_nom = @nombre", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@nombre", MySqlDbType.String, 100).Value = Datos.almanom

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()
                data = reader("almarefa_nom").ToString()
            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

        'Validación
        If (String.IsNullOrEmpty(data)) Then

            'Flg
            unique = True

        End If

        'Regresamos el resultado de la validación
        Return unique

    End Function

    ''' <summary>
    ''' Se encarga de verificar que un producto sea único en la tabla
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>Password as string</returns>
    Public Function ChkUniqueAlmaPrima(ByVal Datos As Datos) As String
        'Variables locales
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim data As String = ""
        Dim unique As Boolean = False

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT almapri_nom FROM almapri WHERE almapri_nom = @nombre", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@nombre", MySqlDbType.String, 100).Value = Datos.almanom

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()
                data = reader("almapri_nom").ToString()
            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

        'Validación
        If (String.IsNullOrEmpty(data)) Then

            'Flg
            unique = True

        End If

        'Regresamos el resultado de la validación
        Return unique

    End Function

    ''' <summary>
    ''' Se encarga de verificar que un producto sea único en la tabla
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>Password as string</returns>
    Public Function ChkUniqueAlmaTerm(ByVal Datos As Datos) As String
        'Variables locales
        Dim con As New Conexion
        Dim reader As MySqlDataReader
        Dim data As String = ""
        Dim unique As Boolean = False

        'Excepción
        Try

            'Objeto conexión
            con.Con_Global()

            'MySql 
            _adaptador.SelectCommand = New MySqlCommand("SELECT almater_nom FROM almater WHERE almater_nom = @nombre", con._conexion)
            _adaptador.SelectCommand.Parameters.Add("@nombre", MySqlDbType.String, 100).Value = Datos.almanom

            'Open Conection
            con._conexion.Open()
            _adaptador.SelectCommand.Connection = con._conexion

            'MySql Reader
            reader = _adaptador.SelectCommand.ExecuteReader()

            'Rutina para resultados
            While reader.Read()
                data = reader("almater_nom").ToString()
            End While

        Catch ex As MySqlException

            'Usuario
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, "UbiSoft by Ubicamatic - 2020(C)")

        Finally

            'Close
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            reader.Close()
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            con._conexion.Close()

        End Try

        'Validación
        If (String.IsNullOrEmpty(data)) Then

            'Flg
            unique = True

        End If

        'Regresamos el resultado de la validación
        Return unique

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

#Region "PRIMA"

    ''' <summary>
    ''' Realiza la inserción de datos en la tabla prima
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function NewPrima(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO prima (prima_foto, prima_nombre, prima_interno, prima_comercial, prima_tag, prima_desc) VALUES (@prima_foto, @prima_nombre, @prima_interno, @prima_comercial, @prima_tag, @prima_desc)", con._conexion)

            'Parámetros
            _adaptador.InsertCommand.Parameters.AddWithValue("@prima_foto", datos.prima_foto)
            _adaptador.InsertCommand.Parameters.Add("@prima_nombre", MySqlDbType.String, 45).Value = datos.prima_nombre
            _adaptador.InsertCommand.Parameters.Add("@prima_interno", MySqlDbType.String, 45).Value = datos.prima_interno
            _adaptador.InsertCommand.Parameters.Add("@prima_comercial", MySqlDbType.String, 45).Value = datos.prima_comercial
            _adaptador.InsertCommand.Parameters.Add("@prima_tag", MySqlDbType.String, 45).Value = datos.prima_tag
            _adaptador.InsertCommand.Parameters.Add("@prima_desc", MySqlDbType.String, 100).Value = datos.prima_desc

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

#Region "CTAPROPIA"

    ''' <summary>
    ''' Realiza la inserción de datos en la tabla ctapropia
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function NewPropia(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO ctapropia (propia_nom, propia_banco, propia_keybanco, propia_nocuenta, propia_noplaza, propia_nosuc, propia_tipo, propia_clabe, propia_abb) VALUES (@propia_nom, @propia_banco, @propia_keybanco, @propia_nocuenta, @propia_noplaza, @propia_nosuc, @propia_tipo, @propia_clabe, @propia_abb)", con._conexion)

            'Parámetros
            _adaptador.InsertCommand.Parameters.Add("@propia_nom", MySqlDbType.String, 100).Value = datos.propia_nom
            _adaptador.InsertCommand.Parameters.Add("@propia_banco", MySqlDbType.String, 100).Value = datos.propia_banco
            _adaptador.InsertCommand.Parameters.Add("@propia_keybanco", MySqlDbType.String, 4).Value = datos.propia_keybanco
            _adaptador.InsertCommand.Parameters.Add("@propia_nocuenta", MySqlDbType.String, 45).Value = datos.propia_nocuenta
            _adaptador.InsertCommand.Parameters.Add("@propia_noplaza", MySqlDbType.String, 45).Value = datos.propia_noplaza
            _adaptador.InsertCommand.Parameters.Add("@propia_nosuc", MySqlDbType.String, 45).Value = datos.propia_nosuc
            _adaptador.InsertCommand.Parameters.Add("@propia_tipo", MySqlDbType.String, 45).Value = datos.propia_tipo
            _adaptador.InsertCommand.Parameters.Add("@propia_clabe", MySqlDbType.String, 45).Value = datos.propia_clabe
            _adaptador.InsertCommand.Parameters.Add("@propia_abb", MySqlDbType.String, 45).Value = datos.propia_abb

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

#Region "CTASEXTERNA"

    ''' <summary>
    ''' Realiza la inserción de datos en la tabla ctasexterna
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function NewExt(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO ctasexterna (ext_nomprov, ext_rfc, ext_mail, ext_tel, ext_nom, ext_banco, ext_keybanco, ext_nocuenta, ext_noplaza, ext_nosuc, ext_tipo, ext_clabe, ext_abb) VALUES (@ext_nomprov, @ext_rfc, @ext_mail, @ext_tel, @ext_nom, @ext_banco, @ext_keybanco, @ext_nocuenta, @ext_noplaza, @ext_nosuc, @ext_tipo, @ext_clabe, @ext_abb)", con._conexion)

            'Parámetros
            _adaptador.InsertCommand.Parameters.Add("@ext_nomprov", MySqlDbType.String, 45).Value = datos.ext_nomprov
            _adaptador.InsertCommand.Parameters.Add("@ext_rfc", MySqlDbType.String, 45).Value = datos.ext_rfc
            _adaptador.InsertCommand.Parameters.Add("@ext_mail", MySqlDbType.String, 45).Value = datos.ext_mail
            _adaptador.InsertCommand.Parameters.Add("@ext_tel", MySqlDbType.String, 45).Value = datos.ext_tel
            _adaptador.InsertCommand.Parameters.Add("@ext_nom", MySqlDbType.String, 100).Value = datos.ext_nom
            _adaptador.InsertCommand.Parameters.Add("@ext_banco", MySqlDbType.String, 100).Value = datos.ext_banco
            _adaptador.InsertCommand.Parameters.Add("@ext_keybanco", MySqlDbType.String, 4).Value = datos.ext_keybanco
            _adaptador.InsertCommand.Parameters.Add("@ext_nocuenta", MySqlDbType.String, 45).Value = datos.ext_nocuenta
            _adaptador.InsertCommand.Parameters.Add("@ext_noplaza", MySqlDbType.String, 45).Value = datos.ext_noplaza
            _adaptador.InsertCommand.Parameters.Add("@ext_nosuc", MySqlDbType.String, 45).Value = datos.ext_nosuc
            _adaptador.InsertCommand.Parameters.Add("@ext_tipo", MySqlDbType.String, 45).Value = datos.ext_tipo
            _adaptador.InsertCommand.Parameters.Add("@ext_clabe", MySqlDbType.String, 45).Value = datos.ext_clabe
            _adaptador.InsertCommand.Parameters.Add("@ext_abb", MySqlDbType.String, 45).Value = datos.ext_abb

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

#Region "VENTAS"

    ''' <summary>
    ''' Realiza la inserción de datos en la tabla ventas
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function NewVenta(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.InsertCommand =
                New MySqlCommand("INSERT INTO ventas 
                (ventas_folio, ventas_date, ventas_usr, ventas_rfc, ventas_nom, ventas_mail, ventas_prod, ventas_cat, ventas_uni, ventas_canti, ventas_pu, ventas_sub, ventas_tot) 
                VALUES 
                (@ventas_folio,@ventas_date,@ventas_usr,@ventas_rfc,@ventas_nom,@ventas_mail,@ventas_prod,@ventas_cat,@ventas_uni,@ventas_canti,@ventas_pu,@ventas_sub,@ventas_tot)", con._conexion)

            'Parámetros
            _adaptador.InsertCommand.Parameters.Add("@ventas_folio", MySqlDbType.String, 45).Value = datos.ventas_folio
            _adaptador.InsertCommand.Parameters.Add("@ventas_date", MySqlDbType.Date).Value = datos.ventas_date
            _adaptador.InsertCommand.Parameters.Add("@ventas_usr", MySqlDbType.String, 45).Value = datos.ventas_usr
            _adaptador.InsertCommand.Parameters.Add("@ventas_rfc", MySqlDbType.String, 45).Value = datos.ventas_rfc
            _adaptador.InsertCommand.Parameters.Add("@ventas_nom", MySqlDbType.String, 45).Value = datos.ventas_nom
            _adaptador.InsertCommand.Parameters.Add("@ventas_mail", MySqlDbType.String, 45).Value = datos.ventas_mail
            _adaptador.InsertCommand.Parameters.Add("@ventas_prod", MySqlDbType.String, 45).Value = datos.ventas_prod
            _adaptador.InsertCommand.Parameters.Add("@ventas_cat", MySqlDbType.String, 45).Value = datos.ventas_cat
            _adaptador.InsertCommand.Parameters.Add("@ventas_uni", MySqlDbType.String, 45).Value = datos.ventas_uni
            _adaptador.InsertCommand.Parameters.Add("@ventas_canti", MySqlDbType.Int32, 11).Value = datos.ventas_canti
            _adaptador.InsertCommand.Parameters.Add("@ventas_pu", MySqlDbType.Decimal, 10, 2).Value = datos.ventas_pu
            _adaptador.InsertCommand.Parameters.Add("@ventas_sub", MySqlDbType.Decimal, 10, 2).Value = datos.ventas_sub
            _adaptador.InsertCommand.Parameters.Add("@ventas_tot", MySqlDbType.Decimal, 10, 2).Value = datos.ventas_tot

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

#Region "ALMACEN GENERAL"

    ''' <summary>
    ''' Realiza la inserción de datos en la tabla alma_general
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function NewAlmaGral(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.InsertCommand =
                New MySqlCommand("INSERT INTO alma_general 
                (alma_gral_folio, alma_gral_fecha, alma_gral_tpo, alma_gral_nom, alma_gral_uni, alma_gral_pack, alma_gral_canti) 
                VALUES 
                (@alma_gral_folio,@alma_gral_fecha,@alma_gral_tpo,@alma_gral_nom,@alma_gral_uni,@alma_gral_pack,@alma_gral_canti)", con._conexion)

            'Parámetros
            _adaptador.InsertCommand.Parameters.Add("@alma_gral_folio", MySqlDbType.String, 45).Value = datos.alma_gral_folio
            _adaptador.InsertCommand.Parameters.Add("@alma_gral_fecha", MySqlDbType.Date).Value = datos.alma_gral_fecha
            _adaptador.InsertCommand.Parameters.Add("@alma_gral_tpo", MySqlDbType.String, 45).Value = datos.alma_gral_tpo
            _adaptador.InsertCommand.Parameters.Add("@alma_gral_nom", MySqlDbType.String, 45).Value = datos.alma_gral_nom
            _adaptador.InsertCommand.Parameters.Add("@alma_gral_uni", MySqlDbType.String, 45).Value = datos.alma_gral_uni
            _adaptador.InsertCommand.Parameters.Add("@alma_gral_pack", MySqlDbType.String, 45).Value = datos.alma_gral_pack
            _adaptador.InsertCommand.Parameters.Add("@alma_gral_canti", MySqlDbType.Int32, 11).Value = datos.alma_gral_canti

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

    ''' <summary>
    ''' Realiza la inserción de datos en la tabla almagrl
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function NewAlmaGrl(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.InsertCommand =
                New MySqlCommand("INSERT INTO almagrl 
                (almagrl_nom, almagrl_uni, almagrl_pack, almagrl_canti, almagrl_tpo, almagrl_fecha) 
                VALUES 
                (@almagrl_nom,@almagrl_uni,@almagrl_pack,@almagrl_canti,@almagrl_tpo,@almagrl_fecha)", con._conexion)

            'Parámetros
            _adaptador.InsertCommand.Parameters.Add("@almagrl_nom", MySqlDbType.String, 100).Value = datos.almanom
            _adaptador.InsertCommand.Parameters.Add("@almagrl_uni", MySqlDbType.String, 45).Value = datos.almauni
            _adaptador.InsertCommand.Parameters.Add("@almagrl_pack", MySqlDbType.String, 45).Value = datos.almapack
            _adaptador.InsertCommand.Parameters.Add("@almagrl_canti", MySqlDbType.Int32, 11).Value = datos.almacanti
            _adaptador.InsertCommand.Parameters.Add("@almagrl_tpo", MySqlDbType.String, 45).Value = datos.almatpo
            _adaptador.InsertCommand.Parameters.Add("@almagrl_fecha", MySqlDbType.Date).Value = datos.almafecha

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

    ''' <summary>
    ''' Realiza la inserción de datos en la tabla almarefa
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function NewAlmaRef(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.InsertCommand =
                New MySqlCommand("INSERT INTO almarefa 
                (almarefa_nom, almarefa_uni, almarefa_pack, almarefa_canti, almarefa_tpo, almarefa_fecha) 
                VALUES 
                (@almarefa_nom,@almarefa_uni,@almarefa_pack,@almarefa_canti,@almarefa_tpo,@almarefa_fecha)", con._conexion)

            'Parámetros
            _adaptador.InsertCommand.Parameters.Add("@almarefa_nom", MySqlDbType.String, 100).Value = datos.almanom
            _adaptador.InsertCommand.Parameters.Add("@almarefa_uni", MySqlDbType.String, 45).Value = datos.almauni
            _adaptador.InsertCommand.Parameters.Add("@almarefa_pack", MySqlDbType.String, 45).Value = datos.almapack
            _adaptador.InsertCommand.Parameters.Add("@almarefa_canti", MySqlDbType.Int32, 11).Value = datos.almacanti
            _adaptador.InsertCommand.Parameters.Add("@almarefa_tpo", MySqlDbType.String, 45).Value = datos.almatpo
            _adaptador.InsertCommand.Parameters.Add("@almarefa_fecha", MySqlDbType.Date).Value = datos.almafecha

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

    ''' <summary>
    ''' Realiza la inserción de datos en la tabla almapri
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function NewAlmaPri(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.InsertCommand =
                New MySqlCommand("INSERT INTO almapri 
                (almapri_nom, almapri_uni, almapri_pack, almapri_canti, almapri_tpo, almapri_fecha, almapri_cadu) 
                VALUES 
                (@almapri_nom,@almapri_uni,@almapri_pack,@almapri_canti,@almapri_tpo,@almapri_fecha,@almapri_cadu)", con._conexion)

            'Parámetros
            _adaptador.InsertCommand.Parameters.Add("@almapri_nom", MySqlDbType.String, 100).Value = datos.almanom
            _adaptador.InsertCommand.Parameters.Add("@almapri_uni", MySqlDbType.String, 45).Value = datos.almauni
            _adaptador.InsertCommand.Parameters.Add("@almapri_pack", MySqlDbType.String, 45).Value = datos.almapack
            _adaptador.InsertCommand.Parameters.Add("@almapri_canti", MySqlDbType.Int32, 11).Value = datos.almacanti
            _adaptador.InsertCommand.Parameters.Add("@almapri_tpo", MySqlDbType.String, 45).Value = datos.almatpo
            _adaptador.InsertCommand.Parameters.Add("@almapri_fecha", MySqlDbType.Date).Value = datos.almafecha
            _adaptador.InsertCommand.Parameters.Add("@almapri_cadu", MySqlDbType.Date).Value = datos.almacadu

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

    ''' <summary>
    ''' Realiza la inserción de datos en la tabla almater
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function NewAlmaTer(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.InsertCommand =
                New MySqlCommand("INSERT INTO almater 
                (almater_nom, almater_uni, almater_pack, almater_canti, almater_tpo, almater_fecha, almater_cadu) 
                VALUES 
                (@almater_nom,@almater_uni,@almater_pack,@almater_canti,@almater_tpo,@almater_fecha,@almater_cadu)", con._conexion)

            'Parámetros
            _adaptador.InsertCommand.Parameters.Add("@almater_nom", MySqlDbType.String, 100).Value = datos.almanom
            _adaptador.InsertCommand.Parameters.Add("@almater_uni", MySqlDbType.String, 45).Value = datos.almauni
            _adaptador.InsertCommand.Parameters.Add("@almater_pack", MySqlDbType.String, 45).Value = datos.almapack
            _adaptador.InsertCommand.Parameters.Add("@almater_canti", MySqlDbType.Int32, 11).Value = datos.almacanti
            _adaptador.InsertCommand.Parameters.Add("@almater_tpo", MySqlDbType.String, 45).Value = datos.almatpo
            _adaptador.InsertCommand.Parameters.Add("@almater_fecha", MySqlDbType.Date).Value = datos.almafecha
            _adaptador.InsertCommand.Parameters.Add("@almater_cadu", MySqlDbType.Date).Value = datos.almacadu

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

#Region "ALMACEN REFACCIONES"

    ''' <summary>
    ''' Realiza la inserción de datos en la tabla alma_refa 
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function NewAlmaRefa(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.InsertCommand =
                New MySqlCommand("INSERT INTO alma_refa 
                (alma_refa_folio, alma_refa_fecha, alma_refa_tpo, alma_refa_nom, alma_refa_uni, alma_refa_pack, alma_refa_canti) 
                VALUES 
                (@alma_refa_folio,@alma_refa_fecha,@alma_refa_tpo,@alma_refa_nom,@alma_refa_uni,@alma_refa_pack,@alma_refa_canti)", con._conexion)

            'Parámetros
            _adaptador.InsertCommand.Parameters.Add("@alma_refa_folio", MySqlDbType.String, 45).Value = datos.alma_refa_folio
            _adaptador.InsertCommand.Parameters.Add("@alma_refa_fecha", MySqlDbType.Date).Value = datos.alma_refa_fecha
            _adaptador.InsertCommand.Parameters.Add("@alma_refa_tpo", MySqlDbType.String, 45).Value = datos.alma_refa_tpo
            _adaptador.InsertCommand.Parameters.Add("@alma_refa_nom", MySqlDbType.String, 100).Value = datos.alma_gral_nom
            _adaptador.InsertCommand.Parameters.Add("@alma_refa_uni", MySqlDbType.String, 45).Value = datos.alma_refa_uni
            _adaptador.InsertCommand.Parameters.Add("@alma_refa_pack", MySqlDbType.String, 45).Value = datos.alma_refa_pack
            _adaptador.InsertCommand.Parameters.Add("@alma_refa_canti", MySqlDbType.Int32, 11).Value = datos.alma_refa_canti

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

#Region "ALMACEN PRIMA"

    ''' <summary>
    ''' Realiza la inserción de datos en la tabla alma_prima
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function NewAlmaPrima(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.InsertCommand =
                New MySqlCommand("INSERT INTO alma_prima 
                (alma_prima_folio, alma_prima_fecha, alma_prima_cadu, alma_prima_tpo, alma_prima_nom, alma_prima_uni, alma_prima_pack, alma_prima_canti) 
                VALUES 
                (@alma_prima_folio,@alma_prima_fecha,@alma_prima_cadu,@alma_prima_tpo,@alma_prima_nom,@alma_prima_uni,@alma_prima_pack,@alma_prima_canti)", con._conexion)

            'Parámetros
            _adaptador.InsertCommand.Parameters.Add("@alma_prima_folio", MySqlDbType.String, 45).Value = datos.alma_prima_folio
            _adaptador.InsertCommand.Parameters.Add("@alma_prima_fecha", MySqlDbType.Date).Value = datos.alma_prima_fecha
            _adaptador.InsertCommand.Parameters.Add("@alma_prima_cadu", MySqlDbType.Date).Value = datos.alma_prima_cadu
            _adaptador.InsertCommand.Parameters.Add("@alma_prima_tpo", MySqlDbType.String, 45).Value = datos.alma_prima_tpo
            _adaptador.InsertCommand.Parameters.Add("@alma_prima_nom", MySqlDbType.String, 100).Value = datos.alma_prima_nom
            _adaptador.InsertCommand.Parameters.Add("@alma_prima_uni", MySqlDbType.String, 45).Value = datos.alma_prima_uni
            _adaptador.InsertCommand.Parameters.Add("@alma_prima_pack", MySqlDbType.String, 45).Value = datos.alma_prima_pack
            _adaptador.InsertCommand.Parameters.Add("@alma_prima_canti", MySqlDbType.Int32, 11).Value = datos.alma_prima_canti

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

#Region "ALMACEN PROD"

    ''' <summary>
    ''' Realiza la inserción de datos en la tabla alma_prod
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function NewAlmaProd(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.InsertCommand =
                New MySqlCommand("INSERT INTO alma_prod 
                ( alma_prod_folio, alma_prod_fecha, alma_prod_cadu, alma_prod_tpo, alma_prod_nom, alma_prod_uni, alma_prod_pack, alma_prod_canti) 
                VALUES 
                (@alma_prod_folio,@alma_prod_fecha,@alma_prod_cadu,@alma_prod_tpo,@alma_prod_nom,@alma_prod_uni,@alma_prod_pack,@alma_prod_canti)", con._conexion)

            'Parámetros
            _adaptador.InsertCommand.Parameters.Add("@alma_prod_folio", MySqlDbType.String, 45).Value = datos.alma_prod_folio
            _adaptador.InsertCommand.Parameters.Add("@alma_prod_fecha", MySqlDbType.Date).Value = datos.alma_prod_fecha
            _adaptador.InsertCommand.Parameters.Add("@alma_prod_cadu", MySqlDbType.Date).Value = datos.alma_prod_cadu
            _adaptador.InsertCommand.Parameters.Add("@alma_prod_tpo", MySqlDbType.String, 45).Value = datos.alma_prod_tpo
            _adaptador.InsertCommand.Parameters.Add("@alma_prod_nom", MySqlDbType.String, 100).Value = datos.alma_prod_nom
            _adaptador.InsertCommand.Parameters.Add("@alma_prod_uni", MySqlDbType.String, 45).Value = datos.alma_prod_uni
            _adaptador.InsertCommand.Parameters.Add("@alma_prod_pack", MySqlDbType.String, 45).Value = datos.alma_prod_pack
            _adaptador.InsertCommand.Parameters.Add("@alma_prod_canti", MySqlDbType.Int32, 11).Value = datos.alma_prod_canti

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

#Region "INVENTARIO"

    ''' <summary>
    ''' Realiza la actualización de datos en la tabla inventario
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function UpdInv(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE inventario SET foto_inv=@foto_inv, cat_inv=@cat_inv, codint_inv=@codint_inv, codcom_inv=@codcom_inv, tag_inv=@tag_inv, desc_inv=@desc_inv, cost_inv=@cost_inv, area_inv=@area_inv WHERE id_inv=@id_inv", con._conexion)

            'Parámetros
            _adaptador.UpdateCommand.Parameters.AddWithValue("@foto_inv", datos.foto_inv)
            _adaptador.UpdateCommand.Parameters.Add("@id_inv", MySqlDbType.Int32, 11).Value = datos.id_inv
            _adaptador.UpdateCommand.Parameters.Add("@cat_inv", MySqlDbType.String, 45).Value = datos.cat_inv
            _adaptador.UpdateCommand.Parameters.Add("@codint_inv", MySqlDbType.String, 45).Value = datos.codint_inv
            _adaptador.UpdateCommand.Parameters.Add("@codcom_inv", MySqlDbType.String, 45).Value = datos.codcom_inv
            _adaptador.UpdateCommand.Parameters.Add("@tag_inv", MySqlDbType.String, 45).Value = datos.tag_inv
            _adaptador.UpdateCommand.Parameters.Add("@desc_inv", MySqlDbType.String, 100).Value = datos.desc_inv
            _adaptador.UpdateCommand.Parameters.Add("@cost_inv", MySqlDbType.Decimal, 10, 2).Value = datos.cost_inv
            _adaptador.UpdateCommand.Parameters.Add("@area_inv", MySqlDbType.String, 45).Value = datos.area_inv

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

#Region "PRIMA"

    ''' <summary>
    ''' Realiza la actualización de datos en la tabla prima
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function UpdPrima(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE prima SET prima_foto=@prima_foto, prima_nombre=@prima_nombre, prima_interno=@prima_interno, prima_comercial=@prima_comercial, prima_tag=@prima_tag, prima_desc=@prima_desc WHERE prima_nombre=@prima_nombre", con._conexion)

            'Parámetros
            _adaptador.UpdateCommand.Parameters.AddWithValue("@prima_foto", datos.prima_foto)
            _adaptador.UpdateCommand.Parameters.Add("@prima_nombre", MySqlDbType.String, 45).Value = datos.prima_nombre
            _adaptador.UpdateCommand.Parameters.Add("@prima_interno", MySqlDbType.String, 45).Value = datos.prima_interno
            _adaptador.UpdateCommand.Parameters.Add("@prima_comercial", MySqlDbType.String, 45).Value = datos.prima_comercial
            _adaptador.UpdateCommand.Parameters.Add("@prima_tag", MySqlDbType.String, 45).Value = datos.prima_tag
            _adaptador.UpdateCommand.Parameters.Add("@prima_desc", MySqlDbType.String, 100).Value = datos.prima_desc

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

#Region "ALMACENES"

    ''' <summary>
    ''' Realiza la actualización de datos en la tabla almagrl
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function UpdAlmaGral(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE almagrl SET almagrl_canti= almagrl_canti - @almagrl_canti WHERE almagrl_nom= @almagrl_nom ", con._conexion)

            'Parámetros
            _adaptador.UpdateCommand.Parameters.Add("@almagrl_canti", MySqlDbType.Int32, 11).Value = datos.almagrl_canti
            _adaptador.UpdateCommand.Parameters.Add("@almagrl_nom", MySqlDbType.String, 45).Value = datos.almagrl_nom

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

    ''' <summary>
    ''' Realiza la actualización de datos en la tabla almarefa
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function UpdAlmaRefa(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE almarefa SET almarefa_canti= almarefa_canti - @almarefa_canti WHERE almarefa_nom= @almarefa_nom ", con._conexion)

            'Parámetros
            _adaptador.UpdateCommand.Parameters.Add("@almarefa_canti", MySqlDbType.Int32, 11).Value = datos.almarefa_canti
            _adaptador.UpdateCommand.Parameters.Add("@almarefa_nom", MySqlDbType.String, 45).Value = datos.almarefa_nom

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

    ''' <summary>
    ''' Realiza la actualización de datos en la tabla almapri
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function UpdAlmaPri(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE almapri SET almapri_canti= almapri_canti - @almapri_canti WHERE almapri_nom= @almapri_nom ", con._conexion)

            'Parámetros
            _adaptador.UpdateCommand.Parameters.Add("@almapri_canti", MySqlDbType.Int32, 11).Value = datos.almapri_canti
            _adaptador.UpdateCommand.Parameters.Add("@almapri_nom", MySqlDbType.String, 45).Value = datos.almapri_nom

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

    ''' <summary>
    ''' Realiza la actualización de datos en la tabla almater
    ''' </summary>
    ''' <param name="datos"></param>
    ''' <returns></returns>
    Public Function UpdAlmaTer(ByVal datos As Datos) As Boolean

        'Privadas
        Dim estado As Boolean = False
        Dim con As New Conexion

        'Control excepciones
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE almater SET almater_canti= almater_canti - @almater_canti WHERE almater_nom= @almater_nom ", con._conexion)

            'Parámetros
            _adaptador.UpdateCommand.Parameters.Add("@almater_canti", MySqlDbType.Int32, 11).Value = datos.almater_canti
            _adaptador.UpdateCommand.Parameters.Add("@almater_nom", MySqlDbType.String, 45).Value = datos.almater_nom

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

#Region "INVENTARIO"

    ''' <summary>
    ''' Se encarga de eliminar al inventario por medio de la key recibida como parámetro
    ''' </summary>
    ''' <param name="datos"> Resultado del borrado </param>
    ''' <returns></returns>
    Public Function DelInv(ByVal datos As Datos) As Boolean

        'Variables Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control de Errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM inventario WHERE id_inv=@id_inv", con._conexion)

            'Parámetros
            _adaptador.DeleteCommand.Parameters.Add("@id_inv", MySqlDbType.String, 45).Value = datos.id_inv

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

#Region "PRIMA"

    ''' <summary>
    ''' Se encarga de eliminar a la materia prima por medio de la key recibida como parámetro
    ''' </summary>
    ''' <param name="datos"> Resultado del borrado </param>
    ''' <returns></returns>
    Public Function DelPrima(ByVal datos As Datos) As Boolean

        'Variables Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control de Errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM prima WHERE prima_nombre=@prima_nombre", con._conexion)

            'Parámetros
            _adaptador.DeleteCommand.Parameters.Add("@prima_nombre", MySqlDbType.String, 45).Value = datos.prima_nombre

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

#Region "CTAPROPIA"

    ''' <summary>
    ''' Se encarga de eliminar a la cuenta propia por medio de la key recibida como parámetro
    ''' </summary>
    ''' <param name="datos"> Resultado del borrado </param>
    ''' <returns></returns>
    Public Function DelPropia(ByVal datos As Datos) As Boolean

        'Variables Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control de Errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM ctapropia WHERE propia_nocuenta=@propia_nocuenta", con._conexion)

            'Parámetros
            _adaptador.DeleteCommand.Parameters.Add("@propia_nocuenta", MySqlDbType.String, 45).Value = datos.propia_nocuenta

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

#Region "CTASEXTERNA"

    ''' <summary>
    ''' Se encarga de eliminar a la cuenta propia por medio de la key recibida como parámetro
    ''' </summary>
    ''' <param name="datos"> Resultado del borrado </param>
    ''' <returns></returns>
    Public Function DelExt(ByVal datos As Datos) As Boolean

        'Variables Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control de Errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM ctasexterna WHERE ext_nocuenta=@ext_nocuenta", con._conexion)

            'Parámetros
            _adaptador.DeleteCommand.Parameters.Add("@ext_nocuenta", MySqlDbType.String, 45).Value = datos.ext_nocuenta

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

#Region "VENTAS"

    ''' <summary>
    ''' Se encarga de eliminar al folio por medio de la key recibida como parámetro
    ''' </summary>
    ''' <param name="datos"> Resultado del borrado </param>
    ''' <returns></returns>
    Public Function DelFolio(ByVal datos As Datos) As Boolean

        'Variables Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control de Errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM ventas WHERE ventas_folio=@ventas_folio", con._conexion)

            'Parámetros
            _adaptador.DeleteCommand.Parameters.Add("@ventas_folio", MySqlDbType.String, 45).Value = datos.ventas_folio

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

#Region "ALMACENES"

    ''' <summary>
    ''' Se encarga de eliminar al folio por medio de la key recibida como parámetro
    ''' </summary>
    ''' <param name="datos"> Resultado del borrado </param>
    ''' <returns></returns>
    Public Function DelFolAlma(ByVal datos As Datos) As Boolean

        'Variables Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control de Errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM alma_general WHERE alma_gral_folio=@alma_gral_folio", con._conexion)

            'Parámetros
            _adaptador.DeleteCommand.Parameters.Add("@alma_gral_folio", MySqlDbType.String, 45).Value = datos.alma_gral_folio

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

        'Control de Errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM alma_refa WHERE alma_refa_folio=@alma_refa_folio", con._conexion)

            'Parámetros
            _adaptador.DeleteCommand.Parameters.Add("@alma_refa_folio", MySqlDbType.String, 45).Value = datos.alma_refa_folio

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

        'Control de Errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM alma_prima WHERE alma_prima_folio=@alma_prima_folio", con._conexion)

            'Parámetros
            _adaptador.DeleteCommand.Parameters.Add("@alma_prima_folio", MySqlDbType.String, 45).Value = datos.alma_prima_folio

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

        'Control de Errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM alma_prod WHERE alma_prod_folio=@alma_prod_folio", con._conexion)

            'Parámetros
            _adaptador.DeleteCommand.Parameters.Add("@alma_prod_folio", MySqlDbType.String, 45).Value = datos.alma_prod_folio

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

    ''' <summary>
    ''' Se encarga de eliminar un producto de almacén general por medio de la key recibida como parámetro
    ''' </summary>
    ''' <param name="datos"> Resultado del borrado </param>
    ''' <returns></returns>
    Public Function DelProdAlmaGrl(ByVal datos As Datos) As Boolean

        'Variables Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control de Errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM almagrl WHERE almagrl_nom=@almagrl_nom", con._conexion)

            'Parámetros
            _adaptador.DeleteCommand.Parameters.Add("@almagrl_nom", MySqlDbType.String, 100).Value = datos.almanom

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

    ''' <summary>
    ''' Se encarga de eliminar un producto de almacén refacciones por medio de la key recibida como parámetro
    ''' </summary>
    ''' <param name="datos"> Resultado del borrado </param>
    ''' <returns></returns>
    Public Function DelProdAlmaRefa(ByVal datos As Datos) As Boolean

        'Variables Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control de Errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM almarefa WHERE almarefa_nom=@almarefa_nom", con._conexion)

            'Parámetros
            _adaptador.DeleteCommand.Parameters.Add("@almarefa_nom", MySqlDbType.String, 100).Value = datos.almanom

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

    ''' <summary>
    ''' Se encarga de eliminar un producto de almacén materia prima por medio de la key recibida como parámetro
    ''' </summary>
    ''' <param name="datos"> Resultado del borrado </param>
    ''' <returns></returns>
    Public Function DelProdAlmaPrima(ByVal datos As Datos) As Boolean

        'Variables Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control de Errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM almapri WHERE almapri_nom=@almapri_nom", con._conexion)

            'Parámetros
            _adaptador.DeleteCommand.Parameters.Add("@almapri_nom", MySqlDbType.String, 100).Value = datos.almanom

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

    ''' <summary>
    ''' Se encarga de eliminar un producto de almacén producto terminado por medio de la key recibida como parámetro
    ''' </summary>
    ''' <param name="datos"> Resultado del borrado </param>
    ''' <returns></returns>
    Public Function DelProdAlmaTer(ByVal datos As Datos) As Boolean

        'Variables Privadas
        Dim estado As Boolean = False

        Dim con As New Conexion

        'Control de Errores
        Try

            'Conexión
            con.Con_Global()

            'Query
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM almater WHERE almater_nom=@almater_nom", con._conexion)

            'Parámetros
            _adaptador.DeleteCommand.Parameters.Add("@almater_nom", MySqlDbType.String, 100).Value = datos.almanom

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
