<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrPtoVenta
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.PnlCtrl = New System.Windows.Forms.Panel()
        Me.PbMax = New System.Windows.Forms.PictureBox()
        Me.PbMin = New System.Windows.Forms.PictureBox()
        Me.PbClose = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PbLogoMin = New System.Windows.Forms.PictureBox()
        Me.pnlCli = New System.Windows.Forms.Panel()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblDir = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblContacto = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblCiudad = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblTel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.CboRfc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PnlProd = New System.Windows.Forms.Panel()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtCanti = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblUni = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.LblCat = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboProd = New System.Windows.Forms.ComboBox()
        Me.PnlSep = New System.Windows.Forms.Panel()
        Me.PnlDgv = New System.Windows.Forms.Panel()
        Me.BtnAlta = New System.Windows.Forms.Button()
        Me.LblTot = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DgvProd = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlTop.SuspendLayout()
        Me.PnlCtrl.SuspendLayout()
        CType(Me.PbMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbLogoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCli.SuspendLayout()
        Me.PnlProd.SuspendLayout()
        Me.PnlDgv.SuspendLayout()
        CType(Me.DgvProd, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'pnlCli
        '
        Me.pnlCli.BackColor = System.Drawing.Color.Transparent
        Me.pnlCli.Controls.Add(Me.LblEstado)
        Me.pnlCli.Controls.Add(Me.Label10)
        Me.pnlCli.Controls.Add(Me.LblDir)
        Me.pnlCli.Controls.Add(Me.Label9)
        Me.pnlCli.Controls.Add(Me.LblContacto)
        Me.pnlCli.Controls.Add(Me.Label8)
        Me.pnlCli.Controls.Add(Me.LblCiudad)
        Me.pnlCli.Controls.Add(Me.Label7)
        Me.pnlCli.Controls.Add(Me.LblTel)
        Me.pnlCli.Controls.Add(Me.Label6)
        Me.pnlCli.Controls.Add(Me.LblMail)
        Me.pnlCli.Controls.Add(Me.Label4)
        Me.pnlCli.Controls.Add(Me.Label3)
        Me.pnlCli.Controls.Add(Me.TxtNombre)
        Me.pnlCli.Controls.Add(Me.CboRfc)
        Me.pnlCli.Controls.Add(Me.Label2)
        Me.pnlCli.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCli.Location = New System.Drawing.Point(0, 40)
        Me.pnlCli.Name = "pnlCli"
        Me.pnlCli.Size = New System.Drawing.Size(1024, 194)
        Me.pnlCli.TabIndex = 6
        '
        'LblEstado
        '
        Me.LblEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Font = New System.Drawing.Font("Ebrima", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LblEstado.Location = New System.Drawing.Point(734, 157)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(40, 25)
        Me.LblEstado.TabIndex = 50
        Me.LblEstado.Text = "NA"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(538, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 28)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Estado:"
        '
        'LblDir
        '
        Me.LblDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDir.AutoSize = True
        Me.LblDir.Font = New System.Drawing.Font("Ebrima", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LblDir.Location = New System.Drawing.Point(734, 115)
        Me.LblDir.Name = "LblDir"
        Me.LblDir.Size = New System.Drawing.Size(40, 25)
        Me.LblDir.TabIndex = 48
        Me.LblDir.Text = "NA"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(511, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 28)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Dirección:"
        '
        'LblContacto
        '
        Me.LblContacto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblContacto.AutoSize = True
        Me.LblContacto.Font = New System.Drawing.Font("Ebrima", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContacto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LblContacto.Location = New System.Drawing.Point(734, 75)
        Me.LblContacto.Name = "LblContacto"
        Me.LblContacto.Size = New System.Drawing.Size(40, 25)
        Me.LblContacto.TabIndex = 46
        Me.LblContacto.Text = "NA"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(516, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 28)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Contacto:"
        '
        'LblCiudad
        '
        Me.LblCiudad.AutoSize = True
        Me.LblCiudad.Font = New System.Drawing.Font("Ebrima", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCiudad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LblCiudad.Location = New System.Drawing.Point(206, 157)
        Me.LblCiudad.Name = "LblCiudad"
        Me.LblCiudad.Size = New System.Drawing.Size(40, 25)
        Me.LblCiudad.TabIndex = 44
        Me.LblCiudad.Text = "NA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(22, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 28)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Ciudad:"
        '
        'LblTel
        '
        Me.LblTel.AutoSize = True
        Me.LblTel.Font = New System.Drawing.Font("Ebrima", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LblTel.Location = New System.Drawing.Point(206, 115)
        Me.LblTel.Name = "LblTel"
        Me.LblTel.Size = New System.Drawing.Size(40, 25)
        Me.LblTel.TabIndex = 42
        Me.LblTel.Text = "NA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(22, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 28)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Teléfono:"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Font = New System.Drawing.Font("Ebrima", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LblMail.Location = New System.Drawing.Point(206, 75)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(40, 25)
        Me.LblMail.TabIndex = 40
        Me.LblMail.Text = "NA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(22, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 28)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Correo:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(481, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 28)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Razón Social:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtNombre.Location = New System.Drawing.Point(624, 24)
        Me.TxtNombre.MaxLength = 100
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(382, 31)
        Me.TxtNombre.TabIndex = 36
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CboRfc
        '
        Me.CboRfc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboRfc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboRfc.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboRfc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboRfc.FormattingEnabled = True
        Me.CboRfc.Location = New System.Drawing.Point(80, 23)
        Me.CboRfc.Name = "CboRfc"
        Me.CboRfc.Size = New System.Drawing.Size(320, 31)
        Me.CboRfc.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(22, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "RFC:"
        '
        'PnlProd
        '
        Me.PnlProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.PnlProd.Controls.Add(Me.BtnAdd)
        Me.PnlProd.Controls.Add(Me.TxtCanti)
        Me.PnlProd.Controls.Add(Me.Label14)
        Me.PnlProd.Controls.Add(Me.LblUni)
        Me.PnlProd.Controls.Add(Me.Label13)
        Me.PnlProd.Controls.Add(Me.Label12)
        Me.PnlProd.Controls.Add(Me.LblPrecio)
        Me.PnlProd.Controls.Add(Me.LblCat)
        Me.PnlProd.Controls.Add(Me.Label11)
        Me.PnlProd.Controls.Add(Me.Label5)
        Me.PnlProd.Controls.Add(Me.CboProd)
        Me.PnlProd.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlProd.Location = New System.Drawing.Point(0, 234)
        Me.PnlProd.Name = "PnlProd"
        Me.PnlProd.Size = New System.Drawing.Size(1024, 114)
        Me.PnlProd.TabIndex = 7
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnAdd.Image = Global.UbiSoft.My.Resources.Resources.ok32
        Me.BtnAdd.Location = New System.Drawing.Point(770, 63)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(47, 42)
        Me.BtnAdd.TabIndex = 39
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'TxtCanti
        '
        Me.TxtCanti.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCanti.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtCanti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCanti.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCanti.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtCanti.Location = New System.Drawing.Point(624, 74)
        Me.TxtCanti.MaxLength = 100
        Me.TxtCanti.Name = "TxtCanti"
        Me.TxtCanti.Size = New System.Drawing.Size(112, 31)
        Me.TxtCanti.TabIndex = 45
        Me.TxtCanti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(517, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 28)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Cantidad:"
        '
        'LblUni
        '
        Me.LblUni.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblUni.AutoSize = True
        Me.LblUni.Font = New System.Drawing.Font("Ebrima", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.LblUni.Location = New System.Drawing.Point(662, 19)
        Me.LblUni.Name = "LblUni"
        Me.LblUni.Size = New System.Drawing.Size(40, 25)
        Me.LblUni.TabIndex = 42
        Me.LblUni.Text = "NA"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(542, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 28)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Unidad:"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(765, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 28)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Precio:"
        '
        'LblPrecio
        '
        Me.LblPrecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Font = New System.Drawing.Font("Ebrima", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.LblPrecio.Location = New System.Drawing.Point(879, 19)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(66, 25)
        Me.LblPrecio.TabIndex = 41
        Me.LblPrecio.Text = "$ 0.00"
        '
        'LblCat
        '
        Me.LblCat.AutoSize = True
        Me.LblCat.Font = New System.Drawing.Font("Ebrima", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.LblCat.Location = New System.Drawing.Point(293, 77)
        Me.LblCat.Name = "LblCat"
        Me.LblCat.Size = New System.Drawing.Size(40, 25)
        Me.LblCat.TabIndex = 40
        Me.LblCat.Text = "NA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(22, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 28)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Categoría:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(22, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 28)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Producto:"
        '
        'CboProd
        '
        Me.CboProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboProd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboProd.FormattingEnabled = True
        Me.CboProd.Location = New System.Drawing.Point(131, 18)
        Me.CboProd.Name = "CboProd"
        Me.CboProd.Size = New System.Drawing.Size(400, 31)
        Me.CboProd.TabIndex = 27
        '
        'PnlSep
        '
        Me.PnlSep.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSep.Location = New System.Drawing.Point(0, 348)
        Me.PnlSep.Name = "PnlSep"
        Me.PnlSep.Size = New System.Drawing.Size(1024, 10)
        Me.PnlSep.TabIndex = 8
        '
        'PnlDgv
        '
        Me.PnlDgv.BackColor = System.Drawing.Color.Transparent
        Me.PnlDgv.Controls.Add(Me.BtnAlta)
        Me.PnlDgv.Controls.Add(Me.LblTot)
        Me.PnlDgv.Controls.Add(Me.Label15)
        Me.PnlDgv.Controls.Add(Me.DgvProd)
        Me.PnlDgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlDgv.Location = New System.Drawing.Point(0, 358)
        Me.PnlDgv.Name = "PnlDgv"
        Me.PnlDgv.Size = New System.Drawing.Size(1024, 410)
        Me.PnlDgv.TabIndex = 9
        '
        'BtnAlta
        '
        Me.BtnAlta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAlta.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnAlta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnAlta.Image = Global.UbiSoft.My.Resources.Resources.ok32
        Me.BtnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAlta.Location = New System.Drawing.Point(27, 353)
        Me.BtnAlta.Name = "BtnAlta"
        Me.BtnAlta.Size = New System.Drawing.Size(232, 42)
        Me.BtnAlta.TabIndex = 47
        Me.BtnAlta.Text = "Procesar Venta"
        Me.BtnAlta.UseVisualStyleBackColor = False
        '
        'LblTot
        '
        Me.LblTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTot.AutoSize = True
        Me.LblTot.Font = New System.Drawing.Font("Ebrima", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LblTot.Location = New System.Drawing.Point(833, 361)
        Me.LblTot.Name = "LblTot"
        Me.LblTot.Size = New System.Drawing.Size(66, 25)
        Me.LblTot.TabIndex = 46
        Me.LblTot.Text = "$ 0.00"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(702, 358)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 28)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Total venta:"
        '
        'DgvProd
        '
        Me.DgvProd.AllowUserToAddRows = False
        Me.DgvProd.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.DgvProd.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DgvProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvProd.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DgvProd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvProd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvProd.DefaultCellStyle = DataGridViewCellStyle18
        Me.DgvProd.DoubleBuffered = True
        Me.DgvProd.EnableHeadersVisualStyles = False
        Me.DgvProd.GridColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DgvProd.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DgvProd.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvProd.Location = New System.Drawing.Point(0, 7)
        Me.DgvProd.Name = "DgvProd"
        Me.DgvProd.ReadOnly = True
        Me.DgvProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvProd.RowHeadersWidth = 51
        Me.DgvProd.RowTemplate.Height = 24
        Me.DgvProd.Size = New System.Drawing.Size(1024, 333)
        Me.DgvProd.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle12
        Me.Column1.HeaderText = "Nombre Producto"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle13
        Me.Column2.HeaderText = "Categoría"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 111
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle14
        Me.Column3.HeaderText = "Unidades"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 108
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle15
        Me.Column4.HeaderText = "Cantidad"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 106
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle16
        Me.Column5.HeaderText = "Precio Unitario"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 137
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle17
        Me.Column6.HeaderText = "Sub Total"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'ScrPtoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.PnlDgv)
        Me.Controls.Add(Me.PnlSep)
        Me.Controls.Add(Me.PnlProd)
        Me.Controls.Add(Me.pnlCli)
        Me.Controls.Add(Me.PnlTop)
        Me.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrPtoVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScrPtoVenta"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        Me.PnlCtrl.ResumeLayout(False)
        CType(Me.PbMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbLogoMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCli.ResumeLayout(False)
        Me.pnlCli.PerformLayout()
        Me.PnlProd.ResumeLayout(False)
        Me.PnlProd.PerformLayout()
        Me.PnlDgv.ResumeLayout(False)
        Me.PnlDgv.PerformLayout()
        CType(Me.DgvProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents PnlCtrl As Panel
    Friend WithEvents PbMax As PictureBox
    Friend WithEvents PbMin As PictureBox
    Friend WithEvents PbClose As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PbLogoMin As PictureBox
    Friend WithEvents pnlCli As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents CboRfc As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblMail As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblTel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblCiudad As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblContacto As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LblDir As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblEstado As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PnlProd As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents CboProd As ComboBox
    Friend WithEvents LblCat As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LblUni As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LblPrecio As Label
    Friend WithEvents TxtCanti As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents PnlSep As Panel
    Friend WithEvents PnlDgv As Panel
    Friend WithEvents DgvProd As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents BtnAlta As Button
    Friend WithEvents LblTot As Label
    Friend WithEvents Label15 As Label
End Class
