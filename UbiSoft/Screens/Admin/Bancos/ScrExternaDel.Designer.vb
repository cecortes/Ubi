<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrExternaDel
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlData = New System.Windows.Forms.Panel()
        Me.DgvExt = New System.Windows.Forms.DataGridView()
        Me.PnlBottom = New System.Windows.Forms.Panel()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.CboTpo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtClabe = New System.Windows.Forms.TextBox()
        Me.TxtCuenta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtSuc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboBanco = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtRfc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboProv = New System.Windows.Forms.ComboBox()
        Me.PnlData.SuspendLayout()
        CType(Me.DgvExt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlData
        '
        Me.PnlData.BackColor = System.Drawing.Color.Transparent
        Me.PnlData.Controls.Add(Me.DgvExt)
        Me.PnlData.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlData.Location = New System.Drawing.Point(0, 0)
        Me.PnlData.Name = "PnlData"
        Me.PnlData.Size = New System.Drawing.Size(1024, 286)
        Me.PnlData.TabIndex = 0
        '
        'DgvExt
        '
        Me.DgvExt.AllowUserToAddRows = False
        Me.DgvExt.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Ebrima", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DgvExt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvExt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvExt.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvExt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvExt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvExt.DefaultCellStyle = DataGridViewCellStyle7
        Me.DgvExt.EnableHeadersVisualStyles = False
        Me.DgvExt.GridColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DgvExt.Location = New System.Drawing.Point(17, 12)
        Me.DgvExt.Name = "DgvExt"
        Me.DgvExt.ReadOnly = True
        Me.DgvExt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvExt.RowHeadersWidth = 51
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Ebrima", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DgvExt.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DgvExt.RowTemplate.Height = 30
        Me.DgvExt.Size = New System.Drawing.Size(995, 262)
        Me.DgvExt.TabIndex = 4
        '
        'PnlBottom
        '
        Me.PnlBottom.BackColor = System.Drawing.Color.Transparent
        Me.PnlBottom.Controls.Add(Me.BtnOk)
        Me.PnlBottom.Controls.Add(Me.BtnClear)
        Me.PnlBottom.Controls.Add(Me.CboTpo)
        Me.PnlBottom.Controls.Add(Me.Label7)
        Me.PnlBottom.Controls.Add(Me.Label8)
        Me.PnlBottom.Controls.Add(Me.TxtClabe)
        Me.PnlBottom.Controls.Add(Me.TxtCuenta)
        Me.PnlBottom.Controls.Add(Me.Label10)
        Me.PnlBottom.Controls.Add(Me.Label11)
        Me.PnlBottom.Controls.Add(Me.TxtSuc)
        Me.PnlBottom.Controls.Add(Me.Label5)
        Me.PnlBottom.Controls.Add(Me.CboBanco)
        Me.PnlBottom.Controls.Add(Me.Label9)
        Me.PnlBottom.Controls.Add(Me.TxtNombre)
        Me.PnlBottom.Controls.Add(Me.Label3)
        Me.PnlBottom.Controls.Add(Me.TxtRfc)
        Me.PnlBottom.Controls.Add(Me.Label1)
        Me.PnlBottom.Controls.Add(Me.CboProv)
        Me.PnlBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlBottom.Location = New System.Drawing.Point(0, 286)
        Me.PnlBottom.Name = "PnlBottom"
        Me.PnlBottom.Size = New System.Drawing.Size(1024, 401)
        Me.PnlBottom.TabIndex = 1
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Image = Global.UbiSoft.My.Resources.Resources.ok32
        Me.BtnOk.Location = New System.Drawing.Point(870, 329)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(60, 60)
        Me.BtnOk.TabIndex = 72
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnClear.Image = Global.UbiSoft.My.Resources.Resources.borrar
        Me.BtnClear.Location = New System.Drawing.Point(664, 329)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(60, 60)
        Me.BtnClear.TabIndex = 71
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'CboTpo
        '
        Me.CboTpo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboTpo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboTpo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboTpo.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboTpo.Enabled = False
        Me.CboTpo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboTpo.FormattingEnabled = True
        Me.CboTpo.Items.AddRange(New Object() {"MXN", "USD", "EUR"})
        Me.CboTpo.Location = New System.Drawing.Point(811, 213)
        Me.CboTpo.Name = "CboTpo"
        Me.CboTpo.Size = New System.Drawing.Size(119, 31)
        Me.CboTpo.TabIndex = 70
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(750, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 28)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Tipo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(68, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 28)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "No. de Cuenta:"
        '
        'TxtClabe
        '
        Me.TxtClabe.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtClabe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtClabe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtClabe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtClabe.Location = New System.Drawing.Point(214, 336)
        Me.TxtClabe.MaxLength = 100
        Me.TxtClabe.Name = "TxtClabe"
        Me.TxtClabe.Size = New System.Drawing.Size(200, 31)
        Me.TxtClabe.TabIndex = 68
        Me.TxtClabe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCuenta
        '
        Me.TxtCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtCuenta.Location = New System.Drawing.Point(214, 213)
        Me.TxtCuenta.MaxLength = 100
        Me.TxtCuenta.Name = "TxtCuenta"
        Me.TxtCuenta.Size = New System.Drawing.Size(200, 31)
        Me.TxtCuenta.TabIndex = 64
        Me.TxtCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(137, 333)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 28)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "CLABE:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(57, 273)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(151, 28)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "No. de Sucursal:"
        '
        'TxtSuc
        '
        Me.TxtSuc.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtSuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSuc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtSuc.Location = New System.Drawing.Point(214, 276)
        Me.TxtSuc.MaxLength = 100
        Me.TxtSuc.Name = "TxtSuc"
        Me.TxtSuc.Size = New System.Drawing.Size(200, 31)
        Me.TxtSuc.TabIndex = 66
        Me.TxtSuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(133, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 28)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Inst. Bancaria:"
        '
        'CboBanco
        '
        Me.CboBanco.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CboBanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboBanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboBanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboBanco.Enabled = False
        Me.CboBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboBanco.FormattingEnabled = True
        Me.CboBanco.Items.AddRange(New Object() {"BANAMEX Banco Nacional de México - 002", "BANCOMEXT Banco Nacional de Comercio Exterior - 006 ", "BANOBRAS Banco Nacional de Obras y Servicios Públicos - 009", "BBVA BANCOMER BBVA Bancomer, S.A. - 012 ", "SANTANDER Banco Santander (México), S.A. - 014", "BANJERCITO Banco Nacional del Ejército, Fuerza Aérea y Armada - 019", "HSBC HSBC México, S.A. - 021 ", "BAJIO Banco del Bajío, S.A. - 030", "IXE IXE Banco, S.A. - 032 ", "INBURSA Banco Inbursa, S.A. - 036", "INTERACCIONES Banco Interacciones, S.A. - 037", "MIFEL Banca Mifel, S.A. - 042", "SCOTIABANK Scotiabank Inverlat, S.A.  - 044", "BANREGIO Banco Regional de Monterrey, S.A. - 058", "INVEX Banco Invex, S.A. - 059", "BANSI Bansi, S.A. - 060", "AFIRME Banca Afirme, S.A. - 062", "BANORTE Banco Mercantil del Norte, S.A. - 072", "THE ROYAL BANK The Royal Bank of Scotland México, S.A. - 102", "AMERICAN EXPRESS American Express Bank (México), S.A. - 103", "BAMSA Bank of America México, S.A. - 106", "TOKYO Bank of Tokyo-Mitsubishi UFJ (México), S.A. - 108", "JP MORGAN Banco J.P. Morgan, S.A. - 110", "BMONEX Banco Monex, S.A. - 112", "VE POR MAS Banco Ve Por Mas, S.A. - 113", "ING ING Bank (México), S.A. - 116", "DEUTSCHE Deutsche Bank México, S.A. - 124", "CREDIT SUISSE Banco Credit Suisse (México), S.A. - 126", "AZTECA Banco Azteca, S.A. - 127", "AUTOFIN Banco Autofin México, S.A. - 128", "BARCLAYS Barclays Bank México, S.A. - 129", "COMPARTAMOS Banco Compartamos, S.A. - 130", "BANCO FAMSA Banco Ahorro Famsa, S.A. - 131", "BMULTIVA Banco Multiva, S.A. - 132", "ACTINVER Banco Actinver, S.A. - 133", "WAL-MART Banco Wal-Mart de México Adelante, S.A. - 134", "NAFIN Nacional Financiera, Sociedad Nacional de Crédito - 135", "INTERBANCO Inter Banco, S.A. - 136", "BANCOPPEL BanCoppel, S.A. - 137", "ABC CAPITAL ABC Capital, S.A. - 138", "UBS BANK UBS Bank México, S.A. - 139", "CONSUBANCO Consubanco, S.A. - 140", "VOLKSWAGEN Volkswagen Bank, S.A. - 141", "CIBANCO CIBanco, S.A. - 143", "BBASE Banco Base, S.A. - 145", "BANSEFI Banco del Ahorro Nacional y Servicios Financieros - 166", "HIPOTECARIA FEDERAL Sociedad Hipotecaria Federal - 168", "MONEXCB Monex Casa de Bolsa, S.A. de C.V. - 600", "GBM GBM Grupo Bursátil Mexicano, S.A. de C.V. - 601", "MASARI Masari Casa de Bolsa, S.A. - 602", "VALUE Value, S.A. de C.V. - 605", "ESTRUCTURADORES Estructuradores del Mercado de Valores Casa de Bolsa, S.A. de C.V" &
                ". - 606", "TIBER Casa de Cambio Tiber, S.A. de C.V. - 607", "VECTOR Vector Casa de Bolsa, S.A. de C.V. - 608", "B&B B y B, Casa de Cambio, S.A. de C.V. - 610", "ACCIVAL Acciones y Valores Banamex, S.A. de C.V. - 614", "MERRILL LYNCH Merrill Lynch México, S.A. de C.V. - 615", "FINAMEX Casa de Bolsa Finamex, S.A. de C.V. - 616", "VALMEX Valores Mexicanos Casa de Bolsa, S.A. de C.V. - 617", "UNICA Unica Casa de Cambio, S.A. de C.V. - 618", "MAPFRE MAPFRE Tepeyac, S.A. - 619", "PROFUTURO Profuturo G.N.P., S.A. de C.V. - 620", "CB ACTINVER Actinver Casa de Bolsa, S.A. de C.V. - 621", "OACTIN OPERADORA ACTINVER, S.A. DE C.V. - 622", "SKANDIA Skandia Vida, S.A. de C.V. - 623", "CBDEUTSCHE Deutsche Securities, S.A. de C.V. - 626", "ZURICH Zurich Compañía de Seguros, S.A. - 627", "ZURICHVI Zurich Vida, Compañía de Seguros, S.A. - 628", "SU CASITA Hipotecaria Su Casita, S.A. de C.V. - 629", "CB INTERCAM Intercam Casa de Bolsa, S.A. de C.V. - 630", "CI BOLSA CI Casa de Bolsa, S.A. de C.V. - 631", "BULLTICK CB Bulltick Casa de Bolsa, S.A., de C.V. - 632", "STERLING Sterling Casa de Cambio, S.A. de C.V. - 633", "FINCOMUN Fincomún, Servicios Financieros Comunitarios, S.A. de C.V. - 634", "HDI SEGUROS HDI Seguros, S.A. de C.V. - 636", "ORDER Order Express Casa de Cambio, S.A. de C.V - 637", "AKALA Akala, S.A. de C.V., Sociedad Financiera Popular - 638", "CB JPMORGAN J.P. Morgan Casa de Bolsa, S.A. de C.V. - 640", "REFORMA Operadora de Recursos Reforma, S.A. de C.V. - 642", "STP Sistema de Transferencias y Pagos STP, S.A. de C.V. - 646", "TELECOMM Telecomunicaciones de México - 647", "EVERCORE Evercore Casa de Bolsa, S.A. de C.V. - 648", "SKANDIA Skandia Operadora de Fondos, S.A. de C.V. - 649", "SEGMTY Seguros Monterrey New York Life, S.A de C.V - 651", "ASEA Solución Asea, S.A. de C.V., Sociedad Financiera Popular - 652", "KUSPIT Kuspit Casa de Bolsa, S.A. de C.V. - 653", "SOFIEXPRESS J.P. SOFIEXPRESS, S.A. de C.V., S.F.P. - 655", "UNAGRA UNAGRA, S.A. de C.V., S.F.P. - 656", "OPCIONES EMPRESARIALES DEL NOROESTE, S.A. DE C.V. - 659", "CLS Cls Bank International - 901", "INDEVAL SD. Indeval, S.A. de C.V. - 902", "LIBERTAD Libertad Servicios Financieros, S.A. De C.V - 670"})
        Me.CboBanco.Location = New System.Drawing.Point(324, 153)
        Me.CboBanco.Name = "CboBanco"
        Me.CboBanco.Size = New System.Drawing.Size(400, 31)
        Me.CboBanco.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(145, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 28)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Beneficiario:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtNombre.Location = New System.Drawing.Point(324, 92)
        Me.TxtNombre.MaxLength = 100
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(400, 31)
        Me.TxtNombre.TabIndex = 50
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(617, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 28)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Rfc:"
        '
        'TxtRfc
        '
        Me.TxtRfc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRfc.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtRfc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRfc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtRfc.Location = New System.Drawing.Point(730, 21)
        Me.TxtRfc.MaxLength = 100
        Me.TxtRfc.Name = "TxtRfc"
        Me.TxtRfc.Size = New System.Drawing.Size(200, 31)
        Me.TxtRfc.TabIndex = 46
        Me.TxtRfc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 28)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Proveedor:"
        '
        'CboProv
        '
        Me.CboProv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboProv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboProv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboProv.FormattingEnabled = True
        Me.CboProv.Items.AddRange(New Object() {"BANAMEX Banco Nacional de México - 002", "BANCOMEXT Banco Nacional de Comercio Exterior - 006 ", "BANOBRAS Banco Nacional de Obras y Servicios Públicos - 009", "BBVA BANCOMER BBVA Bancomer, S.A. - 012 ", "SANTANDER Banco Santander (México), S.A. - 014", "BANJERCITO Banco Nacional del Ejército, Fuerza Aérea y Armada - 019", "HSBC HSBC México, S.A. - 021 ", "BAJIO Banco del Bajío, S.A. - 030", "IXE IXE Banco, S.A. - 032 ", "INBURSA Banco Inbursa, S.A. - 036", "INTERACCIONES Banco Interacciones, S.A. - 037", "MIFEL Banca Mifel, S.A. - 042", "SCOTIABANK Scotiabank Inverlat, S.A.  - 044", "BANREGIO Banco Regional de Monterrey, S.A. - 058", "INVEX Banco Invex, S.A. - 059", "BANSI Bansi, S.A. - 060", "AFIRME Banca Afirme, S.A. - 062", "BANORTE Banco Mercantil del Norte, S.A. - 072", "THE ROYAL BANK The Royal Bank of Scotland México, S.A. - 102", "AMERICAN EXPRESS American Express Bank (México), S.A. - 103", "BAMSA Bank of America México, S.A. - 106", "TOKYO Bank of Tokyo-Mitsubishi UFJ (México), S.A. - 108", "JP MORGAN Banco J.P. Morgan, S.A. - 110", "BMONEX Banco Monex, S.A. - 112", "VE POR MAS Banco Ve Por Mas, S.A. - 113", "ING ING Bank (México), S.A. - 116", "DEUTSCHE Deutsche Bank México, S.A. - 124", "CREDIT SUISSE Banco Credit Suisse (México), S.A. - 126", "AZTECA Banco Azteca, S.A. - 127", "AUTOFIN Banco Autofin México, S.A. - 128", "BARCLAYS Barclays Bank México, S.A. - 129", "COMPARTAMOS Banco Compartamos, S.A. - 130", "BANCO FAMSA Banco Ahorro Famsa, S.A. - 131", "BMULTIVA Banco Multiva, S.A. - 132", "ACTINVER Banco Actinver, S.A. - 133", "WAL-MART Banco Wal-Mart de México Adelante, S.A. - 134", "NAFIN Nacional Financiera, Sociedad Nacional de Crédito - 135", "INTERBANCO Inter Banco, S.A. - 136", "BANCOPPEL BanCoppel, S.A. - 137", "ABC CAPITAL ABC Capital, S.A. - 138", "UBS BANK UBS Bank México, S.A. - 139", "CONSUBANCO Consubanco, S.A. - 140", "VOLKSWAGEN Volkswagen Bank, S.A. - 141", "CIBANCO CIBanco, S.A. - 143", "BBASE Banco Base, S.A. - 145", "BANSEFI Banco del Ahorro Nacional y Servicios Financieros - 166", "HIPOTECARIA FEDERAL Sociedad Hipotecaria Federal - 168", "MONEXCB Monex Casa de Bolsa, S.A. de C.V. - 600", "GBM GBM Grupo Bursátil Mexicano, S.A. de C.V. - 601", "MASARI Masari Casa de Bolsa, S.A. - 602", "VALUE Value, S.A. de C.V. - 605", "ESTRUCTURADORES Estructuradores del Mercado de Valores Casa de Bolsa, S.A. de C.V" &
                ". - 606", "TIBER Casa de Cambio Tiber, S.A. de C.V. - 607", "VECTOR Vector Casa de Bolsa, S.A. de C.V. - 608", "B&B B y B, Casa de Cambio, S.A. de C.V. - 610", "ACCIVAL Acciones y Valores Banamex, S.A. de C.V. - 614", "MERRILL LYNCH Merrill Lynch México, S.A. de C.V. - 615", "FINAMEX Casa de Bolsa Finamex, S.A. de C.V. - 616", "VALMEX Valores Mexicanos Casa de Bolsa, S.A. de C.V. - 617", "UNICA Unica Casa de Cambio, S.A. de C.V. - 618", "MAPFRE MAPFRE Tepeyac, S.A. - 619", "PROFUTURO Profuturo G.N.P., S.A. de C.V. - 620", "CB ACTINVER Actinver Casa de Bolsa, S.A. de C.V. - 621", "OACTIN OPERADORA ACTINVER, S.A. DE C.V. - 622", "SKANDIA Skandia Vida, S.A. de C.V. - 623", "CBDEUTSCHE Deutsche Securities, S.A. de C.V. - 626", "ZURICH Zurich Compañía de Seguros, S.A. - 627", "ZURICHVI Zurich Vida, Compañía de Seguros, S.A. - 628", "SU CASITA Hipotecaria Su Casita, S.A. de C.V. - 629", "CB INTERCAM Intercam Casa de Bolsa, S.A. de C.V. - 630", "CI BOLSA CI Casa de Bolsa, S.A. de C.V. - 631", "BULLTICK CB Bulltick Casa de Bolsa, S.A., de C.V. - 632", "STERLING Sterling Casa de Cambio, S.A. de C.V. - 633", "FINCOMUN Fincomún, Servicios Financieros Comunitarios, S.A. de C.V. - 634", "HDI SEGUROS HDI Seguros, S.A. de C.V. - 636", "ORDER Order Express Casa de Cambio, S.A. de C.V - 637", "AKALA Akala, S.A. de C.V., Sociedad Financiera Popular - 638", "CB JPMORGAN J.P. Morgan Casa de Bolsa, S.A. de C.V. - 640", "REFORMA Operadora de Recursos Reforma, S.A. de C.V. - 642", "STP Sistema de Transferencias y Pagos STP, S.A. de C.V. - 646", "TELECOMM Telecomunicaciones de México - 647", "EVERCORE Evercore Casa de Bolsa, S.A. de C.V. - 648", "SKANDIA Skandia Operadora de Fondos, S.A. de C.V. - 649", "SEGMTY Seguros Monterrey New York Life, S.A de C.V - 651", "ASEA Solución Asea, S.A. de C.V., Sociedad Financiera Popular - 652", "KUSPIT Kuspit Casa de Bolsa, S.A. de C.V. - 653", "SOFIEXPRESS J.P. SOFIEXPRESS, S.A. de C.V., S.F.P. - 655", "UNAGRA UNAGRA, S.A. de C.V., S.F.P. - 656", "OPCIONES EMPRESARIALES DEL NOROESTE, S.A. DE C.V. - 659", "CLS Cls Bank International - 901", "INDEVAL SD. Indeval, S.A. de C.V. - 902", "LIBERTAD Libertad Servicios Financieros, S.A. De C.V - 670"})
        Me.CboProv.Location = New System.Drawing.Point(125, 20)
        Me.CboProv.Name = "CboProv"
        Me.CboProv.Size = New System.Drawing.Size(400, 31)
        Me.CboProv.TabIndex = 42
        '
        'ScrExternaDel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 687)
        Me.Controls.Add(Me.PnlBottom)
        Me.Controls.Add(Me.PnlData)
        Me.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrExternaDel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrExternaDel"
        Me.PnlData.ResumeLayout(False)
        CType(Me.DgvExt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBottom.ResumeLayout(False)
        Me.PnlBottom.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlData As Panel
    Friend WithEvents DgvExt As DataGridView
    Friend WithEvents PnlBottom As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CboProv As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtRfc As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CboBanco As ComboBox
    Friend WithEvents CboTpo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtClabe As TextBox
    Friend WithEvents TxtCuenta As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtSuc As TextBox
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnClear As Button
End Class
