<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrConfigPrimaDel
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
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.PbLed = New System.Windows.Forms.PictureBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnSerial = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.CboPto = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PnlDgv = New System.Windows.Forms.Panel()
        Me.DgvPrima = New System.Windows.Forms.DataGridView()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTag = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtComer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtInt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PbFoto = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PnlMenu.SuspendLayout()
        CType(Me.PbLed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlDgv.SuspendLayout()
        CType(Me.DgvPrima, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTop.SuspendLayout()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.Transparent
        Me.PnlMenu.Controls.Add(Me.PbLed)
        Me.PnlMenu.Controls.Add(Me.BtnOk)
        Me.PnlMenu.Controls.Add(Me.BtnSerial)
        Me.PnlMenu.Controls.Add(Me.BtnClear)
        Me.PnlMenu.Controls.Add(Me.CboPto)
        Me.PnlMenu.Controls.Add(Me.Label7)
        Me.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(984, 77)
        Me.PnlMenu.TabIndex = 3
        '
        'PbLed
        '
        Me.PbLed.BackColor = System.Drawing.Color.DarkRed
        Me.PbLed.Location = New System.Drawing.Point(796, 37)
        Me.PbLed.Name = "PbLed"
        Me.PbLed.Size = New System.Drawing.Size(30, 30)
        Me.PbLed.TabIndex = 34
        Me.PbLed.TabStop = False
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Image = Global.UbiSoft.My.Resources.Resources.ok32
        Me.BtnOk.Location = New System.Drawing.Point(157, 14)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(60, 60)
        Me.BtnOk.TabIndex = 47
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'BtnSerial
        '
        Me.BtnSerial.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnSerial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSerial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnSerial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.BtnSerial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSerial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnSerial.Location = New System.Drawing.Point(534, 37)
        Me.BtnSerial.Name = "BtnSerial"
        Me.BtnSerial.Size = New System.Drawing.Size(137, 31)
        Me.BtnSerial.TabIndex = 33
        Me.BtnSerial.Text = "Conectar"
        Me.BtnSerial.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnClear.Image = Global.UbiSoft.My.Resources.Resources.borrar
        Me.BtnClear.Location = New System.Drawing.Point(17, 10)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(60, 60)
        Me.BtnClear.TabIndex = 46
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'CboPto
        '
        Me.CboPto.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboPto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboPto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboPto.FormattingEnabled = True
        Me.CboPto.Location = New System.Drawing.Point(342, 38)
        Me.CboPto.Name = "CboPto"
        Me.CboPto.Size = New System.Drawing.Size(140, 31)
        Me.CboPto.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(327, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 28)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Puerto Dispositivo:"
        '
        'PnlDgv
        '
        Me.PnlDgv.BackColor = System.Drawing.Color.Transparent
        Me.PnlDgv.Controls.Add(Me.DgvPrima)
        Me.PnlDgv.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlDgv.Location = New System.Drawing.Point(0, 77)
        Me.PnlDgv.Name = "PnlDgv"
        Me.PnlDgv.Size = New System.Drawing.Size(984, 333)
        Me.PnlDgv.TabIndex = 7
        '
        'DgvPrima
        '
        Me.DgvPrima.AllowUserToAddRows = False
        Me.DgvPrima.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ebrima", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DgvPrima.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvPrima.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvPrima.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPrima.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvPrima.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvPrima.EnableHeadersVisualStyles = False
        Me.DgvPrima.GridColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DgvPrima.Location = New System.Drawing.Point(3, 6)
        Me.DgvPrima.Name = "DgvPrima"
        Me.DgvPrima.ReadOnly = True
        Me.DgvPrima.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPrima.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Ebrima", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DgvPrima.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvPrima.RowTemplate.Height = 240
        Me.DgvPrima.Size = New System.Drawing.Size(978, 260)
        Me.DgvPrima.TabIndex = 1
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.Transparent
        Me.PnlTop.Controls.Add(Me.TxtDesc)
        Me.PnlTop.Controls.Add(Me.Label6)
        Me.PnlTop.Controls.Add(Me.TxtTag)
        Me.PnlTop.Controls.Add(Me.Label5)
        Me.PnlTop.Controls.Add(Me.TxtComer)
        Me.PnlTop.Controls.Add(Me.Label4)
        Me.PnlTop.Controls.Add(Me.TxtInt)
        Me.PnlTop.Controls.Add(Me.Label3)
        Me.PnlTop.Controls.Add(Me.TxtNom)
        Me.PnlTop.Controls.Add(Me.Label1)
        Me.PnlTop.Controls.Add(Me.PbFoto)
        Me.PnlTop.Controls.Add(Me.Label2)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlTop.Location = New System.Drawing.Point(0, 410)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(984, 253)
        Me.PnlTop.TabIndex = 8
        '
        'TxtDesc
        '
        Me.TxtDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDesc.Enabled = False
        Me.TxtDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtDesc.Location = New System.Drawing.Point(534, 74)
        Me.TxtDesc.MaxLength = 100
        Me.TxtDesc.Multiline = True
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(292, 152)
        Me.TxtDesc.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(529, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 28)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Descripción:"
        '
        'TxtTag
        '
        Me.TxtTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTag.Enabled = False
        Me.TxtTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtTag.Location = New System.Drawing.Point(332, 195)
        Me.TxtTag.MaxLength = 100
        Me.TxtTag.Name = "TxtTag"
        Me.TxtTag.Size = New System.Drawing.Size(150, 31)
        Me.TxtTag.TabIndex = 43
        Me.TxtTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(223, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 28)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "TAG:"
        '
        'TxtComer
        '
        Me.TxtComer.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtComer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtComer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtComer.Enabled = False
        Me.TxtComer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtComer.Location = New System.Drawing.Point(332, 145)
        Me.TxtComer.MaxLength = 100
        Me.TxtComer.Name = "TxtComer"
        Me.TxtComer.Size = New System.Drawing.Size(150, 31)
        Me.TxtComer.TabIndex = 41
        Me.TxtComer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(223, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 28)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Comercial:"
        '
        'TxtInt
        '
        Me.TxtInt.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtInt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtInt.Enabled = False
        Me.TxtInt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtInt.Location = New System.Drawing.Point(332, 92)
        Me.TxtInt.MaxLength = 100
        Me.TxtInt.Name = "TxtInt"
        Me.TxtInt.Size = New System.Drawing.Size(150, 31)
        Me.TxtInt.TabIndex = 39
        Me.TxtInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(223, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 28)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Interno:"
        '
        'TxtNom
        '
        Me.TxtNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNom.Enabled = False
        Me.TxtNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtNom.Location = New System.Drawing.Point(332, 43)
        Me.TxtNom.MaxLength = 100
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(150, 31)
        Me.TxtNom.TabIndex = 37
        Me.TxtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(223, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 28)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Nombre:"
        '
        'PbFoto
        '
        Me.PbFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PbFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbFoto.Image = Global.UbiSoft.My.Resources.Resources.bolsas
        Me.PbFoto.Location = New System.Drawing.Point(17, 40)
        Me.PbFoto.Name = "PbFoto"
        Me.PbFoto.Size = New System.Drawing.Size(200, 180)
        Me.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbFoto.TabIndex = 14
        Me.PbFoto.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 28)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Foto:"
        '
        'ScrConfigPrimaDel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 663)
        Me.Controls.Add(Me.PnlTop)
        Me.Controls.Add(Me.PnlDgv)
        Me.Controls.Add(Me.PnlMenu)
        Me.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrConfigPrimaDel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrConfigPrimaDel"
        Me.PnlMenu.ResumeLayout(False)
        Me.PnlMenu.PerformLayout()
        CType(Me.PbLed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlDgv.ResumeLayout(False)
        CType(Me.DgvPrima, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMenu As Panel
    Friend WithEvents PbLed As PictureBox
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnSerial As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents CboPto As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PnlDgv As Panel
    Friend WithEvents DgvPrima As DataGridView
    Friend WithEvents PnlTop As Panel
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTag As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtComer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtInt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PbFoto As PictureBox
    Friend WithEvents Label2 As Label
End Class
