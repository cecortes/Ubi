<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScrConfigMaqEdit
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.DgvMaq = New System.Windows.Forms.DataGridView()
        Me.PnlData = New System.Windows.Forms.Panel()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnDevice = New System.Windows.Forms.Button()
        Me.TxtAdq = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtArea = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PbFoto = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlTop.SuspendLayout()
        CType(Me.DgvMaq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlData.SuspendLayout()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.Transparent
        Me.PnlTop.Controls.Add(Me.DgvMaq)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(984, 288)
        Me.PnlTop.TabIndex = 0
        '
        'DgvMaq
        '
        Me.DgvMaq.AllowUserToAddRows = False
        Me.DgvMaq.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ebrima", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DgvMaq.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvMaq.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvMaq.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvMaq.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvMaq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvMaq.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvMaq.EnableHeadersVisualStyles = False
        Me.DgvMaq.GridColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DgvMaq.Location = New System.Drawing.Point(12, 12)
        Me.DgvMaq.Name = "DgvMaq"
        Me.DgvMaq.ReadOnly = True
        Me.DgvMaq.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvMaq.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Ebrima", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DgvMaq.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvMaq.RowTemplate.Height = 24
        Me.DgvMaq.Size = New System.Drawing.Size(960, 255)
        Me.DgvMaq.TabIndex = 1
        '
        'PnlData
        '
        Me.PnlData.BackColor = System.Drawing.Color.Transparent
        Me.PnlData.Controls.Add(Me.BtnOk)
        Me.PnlData.Controls.Add(Me.BtnClear)
        Me.PnlData.Controls.Add(Me.BtnDevice)
        Me.PnlData.Controls.Add(Me.TxtAdq)
        Me.PnlData.Controls.Add(Me.Label8)
        Me.PnlData.Controls.Add(Me.TxtArea)
        Me.PnlData.Controls.Add(Me.Label7)
        Me.PnlData.Controls.Add(Me.TxtDesc)
        Me.PnlData.Controls.Add(Me.Label6)
        Me.PnlData.Controls.Add(Me.TxtMarca)
        Me.PnlData.Controls.Add(Me.Label5)
        Me.PnlData.Controls.Add(Me.TxtModelo)
        Me.PnlData.Controls.Add(Me.Label4)
        Me.PnlData.Controls.Add(Me.TxtSerie)
        Me.PnlData.Controls.Add(Me.Label3)
        Me.PnlData.Controls.Add(Me.PbFoto)
        Me.PnlData.Controls.Add(Me.Label2)
        Me.PnlData.Controls.Add(Me.TxtId)
        Me.PnlData.Controls.Add(Me.Label1)
        Me.PnlData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlData.Location = New System.Drawing.Point(0, 288)
        Me.PnlData.Name = "PnlData"
        Me.PnlData.Size = New System.Drawing.Size(984, 375)
        Me.PnlData.TabIndex = 1
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Image = Global.UbiSoft.My.Resources.Resources.ok32
        Me.BtnOk.Location = New System.Drawing.Point(203, 303)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(60, 60)
        Me.BtnOk.TabIndex = 44
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnClear.Image = Global.UbiSoft.My.Resources.Resources.borrar
        Me.BtnClear.Location = New System.Drawing.Point(23, 303)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(60, 60)
        Me.BtnClear.TabIndex = 43
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnDevice
        '
        Me.BtnDevice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDevice.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnDevice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDevice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnDevice.FlatAppearance.BorderSize = 2
        Me.BtnDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDevice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnDevice.Image = Global.UbiSoft.My.Resources.Resources.ok32
        Me.BtnDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDevice.Location = New System.Drawing.Point(653, 307)
        Me.BtnDevice.Name = "BtnDevice"
        Me.BtnDevice.Size = New System.Drawing.Size(319, 31)
        Me.BtnDevice.TabIndex = 42
        Me.BtnDevice.Text = "Desde dispositivo"
        Me.BtnDevice.UseVisualStyleBackColor = False
        '
        'TxtAdq
        '
        Me.TxtAdq.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtAdq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAdq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtAdq.Location = New System.Drawing.Point(373, 153)
        Me.TxtAdq.Mask = "9999"
        Me.TxtAdq.Name = "TxtAdq"
        Me.TxtAdq.Size = New System.Drawing.Size(158, 31)
        Me.TxtAdq.TabIndex = 21
        Me.TxtAdq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAdq.ValidatingType = GetType(Integer)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(276, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 28)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Año adq:"
        '
        'TxtArea
        '
        Me.TxtArea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtArea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtArea.Location = New System.Drawing.Point(653, 236)
        Me.TxtArea.MaxLength = 100
        Me.TxtArea.Name = "TxtArea"
        Me.TxtArea.Size = New System.Drawing.Size(319, 31)
        Me.TxtArea.TabIndex = 18
        Me.TxtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(785, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 28)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Area:"
        '
        'TxtDesc
        '
        Me.TxtDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtDesc.Location = New System.Drawing.Point(653, 58)
        Me.TxtDesc.MaxLength = 100
        Me.TxtDesc.Multiline = True
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(319, 136)
        Me.TxtDesc.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(755, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 28)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Descripción:"
        '
        'TxtMarca
        '
        Me.TxtMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMarca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtMarca.Location = New System.Drawing.Point(373, 244)
        Me.TxtMarca.MaxLength = 100
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(158, 31)
        Me.TxtMarca.TabIndex = 14
        Me.TxtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(282, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 28)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Marca:"
        '
        'TxtModelo
        '
        Me.TxtModelo.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtModelo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtModelo.Location = New System.Drawing.Point(373, 197)
        Me.TxtModelo.MaxLength = 100
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(158, 31)
        Me.TxtModelo.TabIndex = 12
        Me.TxtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(282, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 28)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Modelo:"
        '
        'TxtSerie
        '
        Me.TxtSerie.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtSerie.Location = New System.Drawing.Point(373, 104)
        Me.TxtSerie.MaxLength = 100
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(158, 31)
        Me.TxtSerie.TabIndex = 10
        Me.TxtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(276, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 28)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Serie:"
        '
        'PbFoto
        '
        Me.PbFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PbFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbFoto.Image = Global.UbiSoft.My.Resources.Resources.camara__1_
        Me.PbFoto.Location = New System.Drawing.Point(23, 58)
        Me.PbFoto.Name = "PbFoto"
        Me.PbFoto.Size = New System.Drawing.Size(240, 217)
        Me.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbFoto.TabIndex = 8
        Me.PbFoto.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 28)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Foto:"
        '
        'TxtId
        '
        Me.TxtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtId.Enabled = False
        Me.TxtId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtId.Location = New System.Drawing.Point(425, 58)
        Me.TxtId.MaxLength = 100
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(106, 31)
        Me.TxtId.TabIndex = 6
        Me.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(269, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Control Interno:"
        '
        'ScrConfigMaqEdit
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
        Me.Name = "ScrConfigMaqEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrConfigMaqEdit"
        Me.PnlTop.ResumeLayout(False)
        CType(Me.DgvMaq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlData.ResumeLayout(False)
        Me.PnlData.PerformLayout()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents DgvMaq As DataGridView
    Friend WithEvents PnlData As Panel
    Friend WithEvents BtnDevice As Button
    Friend WithEvents TxtAdq As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtArea As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtModelo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtSerie As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PbFoto As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnClear As Button
End Class
