<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrAlmaTraspasos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.PnlCtrl = New System.Windows.Forms.Panel()
        Me.PbMax = New System.Windows.Forms.PictureBox()
        Me.PbMin = New System.Windows.Forms.PictureBox()
        Me.PbClose = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PbLogoMin = New System.Windows.Forms.PictureBox()
        Me.PnlFrom = New System.Windows.Forms.Panel()
        Me.PnlTo = New System.Windows.Forms.Panel()
        Me.PnlBotttom = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboNomFrom = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboTpoFrom = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblCantiFrom = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtCantiTo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboTpoTo = New System.Windows.Forms.ComboBox()
        Me.BtnTraspaso = New System.Windows.Forms.Button()
        Me.DgvTraspaso = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.PnlTop.SuspendLayout()
        Me.PnlCtrl.SuspendLayout()
        CType(Me.PbMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbLogoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlFrom.SuspendLayout()
        Me.PnlTo.SuspendLayout()
        Me.PnlBotttom.SuspendLayout()
        CType(Me.DgvTraspaso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PnlTop.Controls.Add(Me.PnlCtrl)
        Me.PnlTop.Controls.Add(Me.Label1)
        Me.PnlTop.Controls.Add(Me.PbLogoMin)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(1024, 40)
        Me.PnlTop.TabIndex = 6
        '
        'PnlCtrl
        '
        Me.PnlCtrl.Controls.Add(Me.PbMax)
        Me.PnlCtrl.Controls.Add(Me.PbMin)
        Me.PnlCtrl.Controls.Add(Me.PbClose)
        Me.PnlCtrl.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlCtrl.Location = New System.Drawing.Point(624, 0)
        Me.PnlCtrl.Name = "PnlCtrl"
        Me.PnlCtrl.Size = New System.Drawing.Size(400, 40)
        Me.PnlCtrl.TabIndex = 4
        '
        'PbMax
        '
        Me.PbMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbMax.Image = Global.UbiSoft.My.Resources.Resources.maximizar
        Me.PbMax.Location = New System.Drawing.Point(305, 5)
        Me.PbMax.Name = "PbMax"
        Me.PbMax.Size = New System.Drawing.Size(32, 32)
        Me.PbMax.TabIndex = 4
        Me.PbMax.TabStop = False
        '
        'PbMin
        '
        Me.PbMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbMin.Image = Global.UbiSoft.My.Resources.Resources.min
        Me.PbMin.Location = New System.Drawing.Point(260, 5)
        Me.PbMin.Name = "PbMin"
        Me.PbMin.Size = New System.Drawing.Size(32, 32)
        Me.PbMin.TabIndex = 3
        Me.PbMin.TabStop = False
        '
        'PbClose
        '
        Me.PbClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbClose.Image = Global.UbiSoft.My.Resources.Resources.close
        Me.PbClose.Location = New System.Drawing.Point(350, 5)
        Me.PbClose.Name = "PbClose"
        Me.PbClose.Size = New System.Drawing.Size(32, 32)
        Me.PbClose.TabIndex = 0
        Me.PbClose.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(235, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ubicamatic (C) 2020"
        '
        'PbLogoMin
        '
        Me.PbLogoMin.Dock = System.Windows.Forms.DockStyle.Left
        Me.PbLogoMin.Image = Global.UbiSoft.My.Resources.Resources.LogoMin
        Me.PbLogoMin.Location = New System.Drawing.Point(0, 0)
        Me.PbLogoMin.Name = "PbLogoMin"
        Me.PbLogoMin.Size = New System.Drawing.Size(400, 40)
        Me.PbLogoMin.TabIndex = 0
        Me.PbLogoMin.TabStop = False
        '
        'PnlFrom
        '
        Me.PnlFrom.BackColor = System.Drawing.Color.Transparent
        Me.PnlFrom.Controls.Add(Me.LblCantiFrom)
        Me.PnlFrom.Controls.Add(Me.Label5)
        Me.PnlFrom.Controls.Add(Me.CboTpoFrom)
        Me.PnlFrom.Controls.Add(Me.Label4)
        Me.PnlFrom.Controls.Add(Me.CboNomFrom)
        Me.PnlFrom.Controls.Add(Me.Label3)
        Me.PnlFrom.Controls.Add(Me.Label2)
        Me.PnlFrom.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlFrom.Location = New System.Drawing.Point(0, 40)
        Me.PnlFrom.Name = "PnlFrom"
        Me.PnlFrom.Size = New System.Drawing.Size(1024, 116)
        Me.PnlFrom.TabIndex = 7
        '
        'PnlTo
        '
        Me.PnlTo.BackColor = System.Drawing.Color.Transparent
        Me.PnlTo.Controls.Add(Me.BtnTraspaso)
        Me.PnlTo.Controls.Add(Me.CboTpoTo)
        Me.PnlTo.Controls.Add(Me.Label6)
        Me.PnlTo.Controls.Add(Me.TxtCantiTo)
        Me.PnlTo.Controls.Add(Me.Label15)
        Me.PnlTo.Controls.Add(Me.Label13)
        Me.PnlTo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTo.Location = New System.Drawing.Point(0, 156)
        Me.PnlTo.Name = "PnlTo"
        Me.PnlTo.Size = New System.Drawing.Size(1024, 108)
        Me.PnlTo.TabIndex = 8
        '
        'PnlBotttom
        '
        Me.PnlBotttom.BackColor = System.Drawing.Color.Transparent
        Me.PnlBotttom.Controls.Add(Me.DgvTraspaso)
        Me.PnlBotttom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlBotttom.Location = New System.Drawing.Point(0, 264)
        Me.PnlBotttom.Name = "PnlBotttom"
        Me.PnlBotttom.Size = New System.Drawing.Size(1024, 504)
        Me.PnlBotttom.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(11, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 28)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Almacén de Salida:"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(12, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(207, 28)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Almacén de Destino:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 28)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Producto:"
        '
        'CboNomFrom
        '
        Me.CboNomFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboNomFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboNomFrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboNomFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboNomFrom.FormattingEnabled = True
        Me.CboNomFrom.Location = New System.Drawing.Point(121, 51)
        Me.CboNomFrom.Name = "CboNomFrom"
        Me.CboNomFrom.Size = New System.Drawing.Size(324, 31)
        Me.CboNomFrom.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(470, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 28)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Almacén:"
        '
        'CboTpoFrom
        '
        Me.CboTpoFrom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CboTpoFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboTpoFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboTpoFrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboTpoFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboTpoFrom.FormattingEnabled = True
        Me.CboTpoFrom.Location = New System.Drawing.Point(575, 51)
        Me.CboTpoFrom.Name = "CboTpoFrom"
        Me.CboTpoFrom.Size = New System.Drawing.Size(136, 31)
        Me.CboTpoFrom.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(778, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 28)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Existencia:"
        '
        'LblCantiFrom
        '
        Me.LblCantiFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCantiFrom.AutoSize = True
        Me.LblCantiFrom.Font = New System.Drawing.Font("Ebrima", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantiFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LblCantiFrom.Location = New System.Drawing.Point(919, 49)
        Me.LblCantiFrom.Name = "LblCantiFrom"
        Me.LblCantiFrom.Size = New System.Drawing.Size(42, 28)
        Me.LblCantiFrom.TabIndex = 64
        Me.LblCantiFrom.Text = "NA"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(12, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(194, 28)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "Traspaso Unidades:"
        '
        'TxtCantiTo
        '
        Me.TxtCantiTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCantiTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtCantiTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCantiTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCantiTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtCantiTo.Location = New System.Drawing.Point(212, 54)
        Me.TxtCantiTo.MaxLength = 100
        Me.TxtCantiTo.Name = "TxtCantiTo"
        Me.TxtCantiTo.Size = New System.Drawing.Size(145, 31)
        Me.TxtCantiTo.TabIndex = 66
        Me.TxtCantiTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(470, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 28)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Almacén:"
        '
        'CboTpoTo
        '
        Me.CboTpoTo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CboTpoTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboTpoTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboTpoTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboTpoTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboTpoTo.FormattingEnabled = True
        Me.CboTpoTo.Location = New System.Drawing.Point(575, 53)
        Me.CboTpoTo.Name = "CboTpoTo"
        Me.CboTpoTo.Size = New System.Drawing.Size(136, 31)
        Me.CboTpoTo.TabIndex = 68
        '
        'BtnTraspaso
        '
        Me.BtnTraspaso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTraspaso.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnTraspaso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTraspaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTraspaso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnTraspaso.Image = Global.UbiSoft.My.Resources.Resources.ok32
        Me.BtnTraspaso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTraspaso.Location = New System.Drawing.Point(783, 46)
        Me.BtnTraspaso.Name = "BtnTraspaso"
        Me.BtnTraspaso.Size = New System.Drawing.Size(223, 42)
        Me.BtnTraspaso.TabIndex = 69
        Me.BtnTraspaso.Text = "Procesar Traspaso"
        Me.BtnTraspaso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTraspaso.UseVisualStyleBackColor = False
        '
        'DgvTraspaso
        '
        Me.DgvTraspaso.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.DgvTraspaso.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvTraspaso.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DgvTraspaso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvTraspaso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTraspaso.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvTraspaso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvTraspaso.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvTraspaso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvTraspaso.DoubleBuffered = True
        Me.DgvTraspaso.EnableHeadersVisualStyles = False
        Me.DgvTraspaso.GridColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DgvTraspaso.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DgvTraspaso.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvTraspaso.Location = New System.Drawing.Point(0, 0)
        Me.DgvTraspaso.Name = "DgvTraspaso"
        Me.DgvTraspaso.ReadOnly = True
        Me.DgvTraspaso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvTraspaso.RowHeadersWidth = 51
        Me.DgvTraspaso.RowTemplate.Height = 24
        Me.DgvTraspaso.Size = New System.Drawing.Size(1024, 504)
        Me.DgvTraspaso.TabIndex = 8
        '
        'ScrAlmaTraspasos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.PnlBotttom)
        Me.Controls.Add(Me.PnlTo)
        Me.Controls.Add(Me.PnlFrom)
        Me.Controls.Add(Me.PnlTop)
        Me.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrAlmaTraspasos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScrAlmaTraspasos"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        Me.PnlCtrl.ResumeLayout(False)
        CType(Me.PbMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbLogoMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlFrom.ResumeLayout(False)
        Me.PnlFrom.PerformLayout()
        Me.PnlTo.ResumeLayout(False)
        Me.PnlTo.PerformLayout()
        Me.PnlBotttom.ResumeLayout(False)
        CType(Me.DgvTraspaso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents PnlCtrl As Panel
    Friend WithEvents PbMax As PictureBox
    Friend WithEvents PbMin As PictureBox
    Friend WithEvents PbClose As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PbLogoMin As PictureBox
    Friend WithEvents PnlFrom As Panel
    Friend WithEvents PnlTo As Panel
    Friend WithEvents PnlBotttom As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CboNomFrom As ComboBox
    Friend WithEvents CboTpoFrom As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LblCantiFrom As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtCantiTo As TextBox
    Friend WithEvents CboTpoTo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnTraspaso As Button
    Friend WithEvents DgvTraspaso As Bunifu.Framework.UI.BunifuCustomDataGrid
End Class
