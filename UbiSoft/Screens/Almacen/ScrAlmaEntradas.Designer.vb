<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrAlmaEntradas
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.PnlCtrl = New System.Windows.Forms.Panel()
        Me.PbMax = New System.Windows.Forms.PictureBox()
        Me.PbMin = New System.Windows.Forms.PictureBox()
        Me.PbClose = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PbLogoMin = New System.Windows.Forms.PictureBox()
        Me.TCtMain = New System.Windows.Forms.TabControl()
        Me.entradas = New System.Windows.Forms.TabPage()
        Me.edicion = New System.Windows.Forms.TabPage()
        Me.DgvCli = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboRfc = New System.Windows.Forms.ComboBox()
        Me.BtnSrchCli = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFinCli = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtpIniCli = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.borrado = New System.Windows.Forms.TabPage()
        Me.DgvFolios = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboFol = New System.Windows.Forms.ComboBox()
        Me.BtnSrchFol = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtpFinFol = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DtpIniFol = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.PnlFecha = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpEntrada = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PnlTop.SuspendLayout()
        Me.PnlCtrl.SuspendLayout()
        CType(Me.PbMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbLogoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TCtMain.SuspendLayout()
        Me.entradas.SuspendLayout()
        Me.edicion.SuspendLayout()
        CType(Me.DgvCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.borrado.SuspendLayout()
        CType(Me.DgvFolios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlFecha.SuspendLayout()
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
        Me.PnlTop.TabIndex = 5
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
        'TCtMain
        '
        Me.TCtMain.Controls.Add(Me.entradas)
        Me.TCtMain.Controls.Add(Me.edicion)
        Me.TCtMain.Controls.Add(Me.borrado)
        Me.TCtMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCtMain.Location = New System.Drawing.Point(0, 40)
        Me.TCtMain.Multiline = True
        Me.TCtMain.Name = "TCtMain"
        Me.TCtMain.SelectedIndex = 0
        Me.TCtMain.Size = New System.Drawing.Size(1024, 728)
        Me.TCtMain.TabIndex = 6
        '
        'entradas
        '
        Me.entradas.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.entradas.Controls.Add(Me.PnlFecha)
        Me.entradas.Location = New System.Drawing.Point(4, 32)
        Me.entradas.Name = "entradas"
        Me.entradas.Padding = New System.Windows.Forms.Padding(3)
        Me.entradas.Size = New System.Drawing.Size(1016, 692)
        Me.entradas.TabIndex = 0
        Me.entradas.Text = "Entradas"
        Me.entradas.UseVisualStyleBackColor = True
        '
        'edicion
        '
        Me.edicion.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.edicion.Controls.Add(Me.DgvCli)
        Me.edicion.Controls.Add(Me.Label5)
        Me.edicion.Controls.Add(Me.CboRfc)
        Me.edicion.Controls.Add(Me.BtnSrchCli)
        Me.edicion.Controls.Add(Me.Label3)
        Me.edicion.Controls.Add(Me.DtpFinCli)
        Me.edicion.Controls.Add(Me.Label4)
        Me.edicion.Controls.Add(Me.DtpIniCli)
        Me.edicion.Location = New System.Drawing.Point(4, 32)
        Me.edicion.Name = "edicion"
        Me.edicion.Size = New System.Drawing.Size(1016, 692)
        Me.edicion.TabIndex = 2
        Me.edicion.Text = "Edición"
        Me.edicion.UseVisualStyleBackColor = True
        '
        'DgvCli
        '
        Me.DgvCli.AllowUserToAddRows = False
        Me.DgvCli.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DgvCli.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCli.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvCli.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCli.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvCli.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvCli.EnableHeadersVisualStyles = False
        Me.DgvCli.GridColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DgvCli.Location = New System.Drawing.Point(21, 108)
        Me.DgvCli.Name = "DgvCli"
        Me.DgvCli.ReadOnly = True
        Me.DgvCli.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvCli.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DgvCli.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvCli.RowTemplate.Height = 25
        Me.DgvCli.Size = New System.Drawing.Size(981, 564)
        Me.DgvCli.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(673, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 28)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "RFC del Cliente:"
        '
        'CboRfc
        '
        Me.CboRfc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboRfc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboRfc.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboRfc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboRfc.FormattingEnabled = True
        Me.CboRfc.Location = New System.Drawing.Point(611, 41)
        Me.CboRfc.Name = "CboRfc"
        Me.CboRfc.Size = New System.Drawing.Size(286, 31)
        Me.CboRfc.TabIndex = 53
        '
        'BtnSrchCli
        '
        Me.BtnSrchCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnSrchCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSrchCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSrchCli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnSrchCli.Image = Global.UbiSoft.My.Resources.Resources.lupa
        Me.BtnSrchCli.Location = New System.Drawing.Point(925, 25)
        Me.BtnSrchCli.Name = "BtnSrchCli"
        Me.BtnSrchCli.Size = New System.Drawing.Size(60, 60)
        Me.BtnSrchCli.TabIndex = 52
        Me.BtnSrchCli.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(331, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 28)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Final:"
        '
        'DtpFinCli
        '
        Me.DtpFinCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DtpFinCli.BorderRadius = 0
        Me.DtpFinCli.ForeColor = System.Drawing.Color.White
        Me.DtpFinCli.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFinCli.FormatCustom = Nothing
        Me.DtpFinCli.Location = New System.Drawing.Point(336, 41)
        Me.DtpFinCli.Margin = New System.Windows.Forms.Padding(4, 13, 4, 13)
        Me.DtpFinCli.Name = "DtpFinCli"
        Me.DtpFinCli.Size = New System.Drawing.Size(235, 40)
        Me.DtpFinCli.TabIndex = 50
        Me.DtpFinCli.Value = New Date(2021, 1, 18, 17, 11, 17, 947)
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 28)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Inicial:"
        '
        'DtpIniCli
        '
        Me.DtpIniCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DtpIniCli.BorderRadius = 0
        Me.DtpIniCli.ForeColor = System.Drawing.Color.White
        Me.DtpIniCli.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpIniCli.FormatCustom = Nothing
        Me.DtpIniCli.Location = New System.Drawing.Point(21, 41)
        Me.DtpIniCli.Margin = New System.Windows.Forms.Padding(4, 9, 4, 9)
        Me.DtpIniCli.Name = "DtpIniCli"
        Me.DtpIniCli.Size = New System.Drawing.Size(235, 40)
        Me.DtpIniCli.TabIndex = 48
        Me.DtpIniCli.Value = New Date(2021, 1, 18, 17, 11, 17, 947)
        '
        'borrado
        '
        Me.borrado.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.borrado.Controls.Add(Me.DgvFolios)
        Me.borrado.Controls.Add(Me.Label6)
        Me.borrado.Controls.Add(Me.CboFol)
        Me.borrado.Controls.Add(Me.BtnSrchFol)
        Me.borrado.Controls.Add(Me.Label7)
        Me.borrado.Controls.Add(Me.DtpFinFol)
        Me.borrado.Controls.Add(Me.Label8)
        Me.borrado.Controls.Add(Me.DtpIniFol)
        Me.borrado.Location = New System.Drawing.Point(4, 32)
        Me.borrado.Name = "borrado"
        Me.borrado.Padding = New System.Windows.Forms.Padding(3)
        Me.borrado.Size = New System.Drawing.Size(1016, 692)
        Me.borrado.TabIndex = 1
        Me.borrado.Text = "Borrado"
        Me.borrado.UseVisualStyleBackColor = True
        '
        'DgvFolios
        '
        Me.DgvFolios.AllowUserToAddRows = False
        Me.DgvFolios.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Ebrima", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DgvFolios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvFolios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvFolios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvFolios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvFolios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvFolios.DefaultCellStyle = DataGridViewCellStyle7
        Me.DgvFolios.EnableHeadersVisualStyles = False
        Me.DgvFolios.GridColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DgvFolios.Location = New System.Drawing.Point(21, 138)
        Me.DgvFolios.Name = "DgvFolios"
        Me.DgvFolios.ReadOnly = True
        Me.DgvFolios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvFolios.RowHeadersWidth = 51
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Ebrima", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DgvFolios.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DgvFolios.RowTemplate.Height = 240
        Me.DgvFolios.Size = New System.Drawing.Size(981, 534)
        Me.DgvFolios.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(673, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 28)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Folio de Venta:"
        '
        'CboFol
        '
        Me.CboFol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboFol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboFol.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboFol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboFol.FormattingEnabled = True
        Me.CboFol.Location = New System.Drawing.Point(620, 41)
        Me.CboFol.Name = "CboFol"
        Me.CboFol.Size = New System.Drawing.Size(277, 31)
        Me.CboFol.TabIndex = 61
        '
        'BtnSrchFol
        '
        Me.BtnSrchFol.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnSrchFol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSrchFol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSrchFol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnSrchFol.Image = Global.UbiSoft.My.Resources.Resources.lupa
        Me.BtnSrchFol.Location = New System.Drawing.Point(925, 25)
        Me.BtnSrchFol.Name = "BtnSrchFol"
        Me.BtnSrchFol.Size = New System.Drawing.Size(60, 60)
        Me.BtnSrchFol.TabIndex = 60
        Me.BtnSrchFol.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(331, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 28)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Final:"
        '
        'DtpFinFol
        '
        Me.DtpFinFol.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DtpFinFol.BorderRadius = 0
        Me.DtpFinFol.ForeColor = System.Drawing.Color.White
        Me.DtpFinFol.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFinFol.FormatCustom = Nothing
        Me.DtpFinFol.Location = New System.Drawing.Point(336, 41)
        Me.DtpFinFol.Margin = New System.Windows.Forms.Padding(4, 19, 4, 19)
        Me.DtpFinFol.Name = "DtpFinFol"
        Me.DtpFinFol.Size = New System.Drawing.Size(245, 44)
        Me.DtpFinFol.TabIndex = 58
        Me.DtpFinFol.Value = New Date(2021, 1, 18, 17, 11, 17, 947)
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(16, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 28)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Inicial:"
        '
        'DtpIniFol
        '
        Me.DtpIniFol.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DtpIniFol.BorderRadius = 0
        Me.DtpIniFol.ForeColor = System.Drawing.Color.White
        Me.DtpIniFol.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpIniFol.FormatCustom = Nothing
        Me.DtpIniFol.Location = New System.Drawing.Point(21, 41)
        Me.DtpIniFol.Margin = New System.Windows.Forms.Padding(4, 13, 4, 13)
        Me.DtpIniFol.Name = "DtpIniFol"
        Me.DtpIniFol.Size = New System.Drawing.Size(245, 44)
        Me.DtpIniFol.TabIndex = 56
        Me.DtpIniFol.Value = New Date(2021, 1, 18, 17, 11, 17, 947)
        '
        'PnlFecha
        '
        Me.PnlFecha.Controls.Add(Me.Label9)
        Me.PnlFecha.Controls.Add(Me.ComboBox1)
        Me.PnlFecha.Controls.Add(Me.DtpEntrada)
        Me.PnlFecha.Controls.Add(Me.Label2)
        Me.PnlFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlFecha.Location = New System.Drawing.Point(3, 3)
        Me.PnlFecha.Name = "PnlFecha"
        Me.PnlFecha.Size = New System.Drawing.Size(1010, 297)
        Me.PnlFecha.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 28)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Fecha de Entrada:"
        '
        'DtpEntrada
        '
        Me.DtpEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DtpEntrada.BorderRadius = 0
        Me.DtpEntrada.ForeColor = System.Drawing.Color.White
        Me.DtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpEntrada.FormatCustom = Nothing
        Me.DtpEntrada.Location = New System.Drawing.Point(10, 29)
        Me.DtpEntrada.Margin = New System.Windows.Forms.Padding(4, 13, 4, 13)
        Me.DtpEntrada.Name = "DtpEntrada"
        Me.DtpEntrada.Size = New System.Drawing.Size(210, 35)
        Me.DtpEntrada.TabIndex = 51
        Me.DtpEntrada.Value = New Date(2021, 1, 18, 17, 11, 17, 947)
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(250, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(171, 31)
        Me.ComboBox1.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(245, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 28)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Tipo de Almacén:"
        '
        'ScrAlmaEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.TCtMain)
        Me.Controls.Add(Me.PnlTop)
        Me.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrAlmaEntradas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScrAlmaEntradas"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        Me.PnlCtrl.ResumeLayout(False)
        CType(Me.PbMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbLogoMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TCtMain.ResumeLayout(False)
        Me.entradas.ResumeLayout(False)
        Me.edicion.ResumeLayout(False)
        Me.edicion.PerformLayout()
        CType(Me.DgvCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.borrado.ResumeLayout(False)
        Me.borrado.PerformLayout()
        CType(Me.DgvFolios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlFecha.ResumeLayout(False)
        Me.PnlFecha.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents PnlCtrl As Panel
    Friend WithEvents PbMax As PictureBox
    Friend WithEvents PbMin As PictureBox
    Friend WithEvents PbClose As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PbLogoMin As PictureBox
    Friend WithEvents TCtMain As TabControl
    Friend WithEvents entradas As TabPage
    Friend WithEvents PnlFecha As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DtpEntrada As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label2 As Label
    Friend WithEvents edicion As TabPage
    Friend WithEvents DgvCli As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents CboRfc As ComboBox
    Friend WithEvents BtnSrchCli As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpFinCli As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DtpIniCli As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents borrado As TabPage
    Friend WithEvents DgvFolios As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents CboFol As ComboBox
    Friend WithEvents BtnSrchFol As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents DtpFinFol As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label8 As Label
    Friend WithEvents DtpIniFol As Bunifu.Framework.UI.BunifuDatepicker
End Class
