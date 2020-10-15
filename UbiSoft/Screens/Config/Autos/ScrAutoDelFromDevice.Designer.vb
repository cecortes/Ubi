<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrAutoDelFromDevice
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
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.PbLed = New System.Windows.Forms.PictureBox()
        Me.BtnSerial = New System.Windows.Forms.Button()
        Me.CboPto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PnlCtrl = New System.Windows.Forms.Panel()
        Me.PbClose = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PbLogoMin = New System.Windows.Forms.PictureBox()
        Me.PnlData = New System.Windows.Forms.Panel()
        Me.TxtTag = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.TxtMotor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAno = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPlaca = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PbFoto = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PnlBott = New System.Windows.Forms.Panel()
        Me.DgvAutos = New System.Windows.Forms.DataGridView()
        Me.PnlTop.SuspendLayout()
        CType(Me.PbLed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PnlCtrl.SuspendLayout()
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbLogoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlData.SuspendLayout()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBott.SuspendLayout()
        CType(Me.DgvAutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.Transparent
        Me.PnlTop.Controls.Add(Me.PbLed)
        Me.PnlTop.Controls.Add(Me.BtnSerial)
        Me.PnlTop.Controls.Add(Me.CboPto)
        Me.PnlTop.Controls.Add(Me.Label2)
        Me.PnlTop.Controls.Add(Me.Panel1)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(1024, 114)
        Me.PnlTop.TabIndex = 3
        '
        'PbLed
        '
        Me.PbLed.BackColor = System.Drawing.Color.DarkRed
        Me.PbLed.Location = New System.Drawing.Point(349, 74)
        Me.PbLed.Name = "PbLed"
        Me.PbLed.Size = New System.Drawing.Size(30, 30)
        Me.PbLed.TabIndex = 30
        Me.PbLed.TabStop = False
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
        Me.BtnSerial.Location = New System.Drawing.Point(188, 74)
        Me.BtnSerial.Name = "BtnSerial"
        Me.BtnSerial.Size = New System.Drawing.Size(137, 31)
        Me.BtnSerial.TabIndex = 29
        Me.BtnSerial.Text = "Conectar"
        Me.BtnSerial.UseVisualStyleBackColor = False
        '
        'CboPto
        '
        Me.CboPto.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboPto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboPto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboPto.FormattingEnabled = True
        Me.CboPto.Location = New System.Drawing.Point(17, 74)
        Me.CboPto.Name = "CboPto"
        Me.CboPto.Size = New System.Drawing.Size(140, 31)
        Me.CboPto.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 28)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Puerto Dispositivo:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PnlCtrl)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PbLogoMin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 40)
        Me.Panel1.TabIndex = 3
        '
        'PnlCtrl
        '
        Me.PnlCtrl.Controls.Add(Me.PbClose)
        Me.PnlCtrl.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlCtrl.Location = New System.Drawing.Point(624, 0)
        Me.PnlCtrl.Name = "PnlCtrl"
        Me.PnlCtrl.Size = New System.Drawing.Size(400, 40)
        Me.PnlCtrl.TabIndex = 4
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
        'PnlData
        '
        Me.PnlData.BackColor = System.Drawing.Color.Transparent
        Me.PnlData.Controls.Add(Me.TxtTag)
        Me.PnlData.Controls.Add(Me.Label11)
        Me.PnlData.Controls.Add(Me.BtnOk)
        Me.PnlData.Controls.Add(Me.BtnClear)
        Me.PnlData.Controls.Add(Me.TxtMotor)
        Me.PnlData.Controls.Add(Me.Label5)
        Me.PnlData.Controls.Add(Me.TxtAno)
        Me.PnlData.Controls.Add(Me.Label8)
        Me.PnlData.Controls.Add(Me.TxtModelo)
        Me.PnlData.Controls.Add(Me.Label4)
        Me.PnlData.Controls.Add(Me.TxtMarca)
        Me.PnlData.Controls.Add(Me.Label3)
        Me.PnlData.Controls.Add(Me.TxtPlaca)
        Me.PnlData.Controls.Add(Me.Label6)
        Me.PnlData.Controls.Add(Me.PbFoto)
        Me.PnlData.Controls.Add(Me.Label7)
        Me.PnlData.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlData.Location = New System.Drawing.Point(0, 114)
        Me.PnlData.Name = "PnlData"
        Me.PnlData.Size = New System.Drawing.Size(1024, 315)
        Me.PnlData.TabIndex = 4
        '
        'TxtTag
        '
        Me.TxtTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtTag.Location = New System.Drawing.Point(354, 272)
        Me.TxtTag.MaxLength = 100
        Me.TxtTag.Name = "TxtTag"
        Me.TxtTag.Size = New System.Drawing.Size(140, 31)
        Me.TxtTag.TabIndex = 49
        Me.TxtTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(263, 269)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 28)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "TAG:"
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Image = Global.UbiSoft.My.Resources.Resources.ok32
        Me.BtnOk.Location = New System.Drawing.Point(541, 134)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(60, 60)
        Me.BtnOk.TabIndex = 46
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnClear.Image = Global.UbiSoft.My.Resources.Resources.borrar
        Me.BtnClear.Location = New System.Drawing.Point(541, 40)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(60, 60)
        Me.BtnClear.TabIndex = 45
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'TxtMotor
        '
        Me.TxtMotor.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMotor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMotor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtMotor.Location = New System.Drawing.Point(354, 226)
        Me.TxtMotor.MaxLength = 100
        Me.TxtMotor.Name = "TxtMotor"
        Me.TxtMotor.Size = New System.Drawing.Size(140, 31)
        Me.TxtMotor.TabIndex = 25
        Me.TxtMotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(263, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 28)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Motor:"
        '
        'TxtAno
        '
        Me.TxtAno.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtAno.Location = New System.Drawing.Point(354, 182)
        Me.TxtAno.Mask = "9999"
        Me.TxtAno.Name = "TxtAno"
        Me.TxtAno.Size = New System.Drawing.Size(140, 31)
        Me.TxtAno.TabIndex = 23
        Me.TxtAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAno.ValidatingType = GetType(Integer)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(263, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 28)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Año:"
        '
        'TxtModelo
        '
        Me.TxtModelo.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtModelo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtModelo.Location = New System.Drawing.Point(354, 137)
        Me.TxtModelo.MaxLength = 100
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(140, 31)
        Me.TxtModelo.TabIndex = 16
        Me.TxtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(263, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 28)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Modelo:"
        '
        'TxtMarca
        '
        Me.TxtMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMarca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtMarca.Location = New System.Drawing.Point(354, 90)
        Me.TxtMarca.MaxLength = 100
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(140, 31)
        Me.TxtMarca.TabIndex = 14
        Me.TxtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(263, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 28)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Marca:"
        '
        'TxtPlaca
        '
        Me.TxtPlaca.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPlaca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtPlaca.Location = New System.Drawing.Point(354, 43)
        Me.TxtPlaca.MaxLength = 100
        Me.TxtPlaca.Name = "TxtPlaca"
        Me.TxtPlaca.Size = New System.Drawing.Size(140, 31)
        Me.TxtPlaca.TabIndex = 12
        Me.TxtPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(263, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 28)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Placas:"
        '
        'PbFoto
        '
        Me.PbFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PbFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbFoto.Image = Global.UbiSoft.My.Resources.Resources.pick
        Me.PbFoto.Location = New System.Drawing.Point(17, 40)
        Me.PbFoto.Name = "PbFoto"
        Me.PbFoto.Size = New System.Drawing.Size(240, 217)
        Me.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbFoto.TabIndex = 10
        Me.PbFoto.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 28)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Foto:"
        '
        'PnlBott
        '
        Me.PnlBott.BackColor = System.Drawing.Color.Transparent
        Me.PnlBott.Controls.Add(Me.DgvAutos)
        Me.PnlBott.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlBott.Location = New System.Drawing.Point(0, 429)
        Me.PnlBott.Name = "PnlBott"
        Me.PnlBott.Size = New System.Drawing.Size(1024, 339)
        Me.PnlBott.TabIndex = 5
        '
        'DgvAutos
        '
        Me.DgvAutos.AllowUserToAddRows = False
        Me.DgvAutos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ebrima", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DgvAutos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvAutos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvAutos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvAutos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvAutos.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvAutos.EnableHeadersVisualStyles = False
        Me.DgvAutos.GridColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DgvAutos.Location = New System.Drawing.Point(12, 12)
        Me.DgvAutos.Name = "DgvAutos"
        Me.DgvAutos.ReadOnly = True
        Me.DgvAutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvAutos.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Ebrima", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DgvAutos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvAutos.RowTemplate.Height = 240
        Me.DgvAutos.Size = New System.Drawing.Size(1000, 306)
        Me.DgvAutos.TabIndex = 1
        '
        'ScrAutoDelFromDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.PnlBott)
        Me.Controls.Add(Me.PnlData)
        Me.Controls.Add(Me.PnlTop)
        Me.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrAutoDelFromDevice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScrAutoDelFromDevice"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        CType(Me.PbLed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnlCtrl.ResumeLayout(False)
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbLogoMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlData.ResumeLayout(False)
        Me.PnlData.PerformLayout()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBott.ResumeLayout(False)
        CType(Me.DgvAutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents PbLed As PictureBox
    Friend WithEvents BtnSerial As Button
    Friend WithEvents CboPto As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PnlCtrl As Panel
    Friend WithEvents PbClose As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PbLogoMin As PictureBox
    Friend WithEvents PnlData As Panel
    Friend WithEvents TxtTag As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents TxtMotor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtAno As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtModelo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPlaca As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PbFoto As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PnlBott As Panel
    Friend WithEvents DgvAutos As DataGridView
End Class
