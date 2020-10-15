<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrConfigAutoDel
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
        Me.DgvAutos = New System.Windows.Forms.DataGridView()
        Me.PnlData = New System.Windows.Forms.Panel()
        Me.BtnDevice = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.TxtPol = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMotor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAno = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPlaca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PbFoto = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PnlTop.SuspendLayout()
        CType(Me.DgvAutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlData.SuspendLayout()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.Transparent
        Me.PnlTop.Controls.Add(Me.DgvAutos)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(984, 322)
        Me.PnlTop.TabIndex = 2
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
        Me.DgvAutos.Size = New System.Drawing.Size(960, 289)
        Me.DgvAutos.TabIndex = 1
        '
        'PnlData
        '
        Me.PnlData.BackColor = System.Drawing.Color.Transparent
        Me.PnlData.Controls.Add(Me.BtnDevice)
        Me.PnlData.Controls.Add(Me.BtnOk)
        Me.PnlData.Controls.Add(Me.BtnClear)
        Me.PnlData.Controls.Add(Me.TxtPol)
        Me.PnlData.Controls.Add(Me.Label6)
        Me.PnlData.Controls.Add(Me.TxtMotor)
        Me.PnlData.Controls.Add(Me.Label5)
        Me.PnlData.Controls.Add(Me.TxtAno)
        Me.PnlData.Controls.Add(Me.Label8)
        Me.PnlData.Controls.Add(Me.TxtModelo)
        Me.PnlData.Controls.Add(Me.Label4)
        Me.PnlData.Controls.Add(Me.TxtMarca)
        Me.PnlData.Controls.Add(Me.Label3)
        Me.PnlData.Controls.Add(Me.TxtPlaca)
        Me.PnlData.Controls.Add(Me.Label1)
        Me.PnlData.Controls.Add(Me.PbFoto)
        Me.PnlData.Controls.Add(Me.Label2)
        Me.PnlData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlData.Location = New System.Drawing.Point(0, 322)
        Me.PnlData.Name = "PnlData"
        Me.PnlData.Size = New System.Drawing.Size(984, 341)
        Me.PnlData.TabIndex = 3
        '
        'BtnDevice
        '
        Me.BtnDevice.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnDevice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDevice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnDevice.FlatAppearance.BorderSize = 2
        Me.BtnDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDevice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnDevice.Image = Global.UbiSoft.My.Resources.Resources.rfid
        Me.BtnDevice.Location = New System.Drawing.Point(541, 137)
        Me.BtnDevice.Name = "BtnDevice"
        Me.BtnDevice.Size = New System.Drawing.Size(60, 60)
        Me.BtnDevice.TabIndex = 47
        Me.BtnDevice.UseVisualStyleBackColor = False
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Image = Global.UbiSoft.My.Resources.Resources.ok32
        Me.BtnOk.Location = New System.Drawing.Point(541, 226)
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
        Me.BtnClear.Location = New System.Drawing.Point(541, 43)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(60, 60)
        Me.BtnClear.TabIndex = 45
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'TxtPol
        '
        Me.TxtPol.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtPol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtPol.Location = New System.Drawing.Point(354, 269)
        Me.TxtPol.MaxLength = 100
        Me.TxtPol.Name = "TxtPol"
        Me.TxtPol.Size = New System.Drawing.Size(140, 31)
        Me.TxtPol.TabIndex = 27
        Me.TxtPol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(280, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 28)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Póliza:"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(263, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 28)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Placas:"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 28)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Foto:"
        '
        'ScrConfigAutoDel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 663)
        Me.Controls.Add(Me.PnlData)
        Me.Controls.Add(Me.PnlTop)
        Me.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrConfigAutoDel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrConfigAutoDel"
        Me.PnlTop.ResumeLayout(False)
        CType(Me.DgvAutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlData.ResumeLayout(False)
        Me.PnlData.PerformLayout()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents DgvAutos As DataGridView
    Friend WithEvents PnlData As Panel
    Friend WithEvents BtnDevice As Button
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents TxtPol As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtMotor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtAno As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtModelo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPlaca As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PbFoto As PictureBox
    Friend WithEvents Label2 As Label
End Class
