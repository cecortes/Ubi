﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrInvEditFromDevice
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
        Me.PnlBottom = New System.Windows.Forms.Panel()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.TxtArea = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCost = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTag = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtCom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtInt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboTpo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PbFoto = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DgvInv = New System.Windows.Forms.DataGridView()
        Me.PnlTop.SuspendLayout()
        CType(Me.PbLed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PnlCtrl.SuspendLayout()
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbLogoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBottom.SuspendLayout()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvInv, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PnlBottom
        '
        Me.PnlBottom.BackColor = System.Drawing.Color.Transparent
        Me.PnlBottom.Controls.Add(Me.BtnOk)
        Me.PnlBottom.Controls.Add(Me.BtnClear)
        Me.PnlBottom.Controls.Add(Me.TxtArea)
        Me.PnlBottom.Controls.Add(Me.Label5)
        Me.PnlBottom.Controls.Add(Me.TxtCost)
        Me.PnlBottom.Controls.Add(Me.Label8)
        Me.PnlBottom.Controls.Add(Me.TxtDesc)
        Me.PnlBottom.Controls.Add(Me.Label4)
        Me.PnlBottom.Controls.Add(Me.TxtTag)
        Me.PnlBottom.Controls.Add(Me.Label11)
        Me.PnlBottom.Controls.Add(Me.TxtCom)
        Me.PnlBottom.Controls.Add(Me.Label3)
        Me.PnlBottom.Controls.Add(Me.TxtInt)
        Me.PnlBottom.Controls.Add(Me.Label6)
        Me.PnlBottom.Controls.Add(Me.CboTpo)
        Me.PnlBottom.Controls.Add(Me.Label9)
        Me.PnlBottom.Controls.Add(Me.PbFoto)
        Me.PnlBottom.Controls.Add(Me.Label7)
        Me.PnlBottom.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBottom.Location = New System.Drawing.Point(0, 114)
        Me.PnlBottom.Name = "PnlBottom"
        Me.PnlBottom.Size = New System.Drawing.Size(1024, 323)
        Me.PnlBottom.TabIndex = 4
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Image = Global.UbiSoft.My.Resources.Resources.ok32
        Me.BtnOk.Location = New System.Drawing.Point(942, 250)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(60, 60)
        Me.BtnOk.TabIndex = 49
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
        Me.BtnClear.Location = New System.Drawing.Point(12, 251)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(60, 60)
        Me.BtnClear.TabIndex = 48
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'TxtArea
        '
        Me.TxtArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtArea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtArea.Location = New System.Drawing.Point(650, 190)
        Me.TxtArea.MaxLength = 100
        Me.TxtArea.Name = "TxtArea"
        Me.TxtArea.Size = New System.Drawing.Size(140, 31)
        Me.TxtArea.TabIndex = 45
        Me.TxtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(493, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 28)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Area:"
        '
        'TxtCost
        '
        Me.TxtCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCost.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtCost.Location = New System.Drawing.Point(650, 137)
        Me.TxtCost.MaxLength = 100
        Me.TxtCost.Name = "TxtCost"
        Me.TxtCost.Size = New System.Drawing.Size(140, 31)
        Me.TxtCost.TabIndex = 43
        Me.TxtCost.Text = "1.00"
        Me.TxtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(493, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 28)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Valor:"
        '
        'TxtDesc
        '
        Me.TxtDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtDesc.Location = New System.Drawing.Point(498, 67)
        Me.TxtDesc.MaxLength = 100
        Me.TxtDesc.Multiline = True
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(292, 51)
        Me.TxtDesc.TabIndex = 41
        Me.TxtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(493, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 28)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Descripción:"
        '
        'TxtTag
        '
        Me.TxtTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtTag.Location = New System.Drawing.Point(325, 187)
        Me.TxtTag.MaxLength = 100
        Me.TxtTag.Name = "TxtTag"
        Me.TxtTag.Size = New System.Drawing.Size(140, 31)
        Me.TxtTag.TabIndex = 39
        Me.TxtTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(218, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 28)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "TAG:"
        '
        'TxtCom
        '
        Me.TxtCom.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtCom.Location = New System.Drawing.Point(325, 137)
        Me.TxtCom.MaxLength = 100
        Me.TxtCom.Name = "TxtCom"
        Me.TxtCom.Size = New System.Drawing.Size(140, 31)
        Me.TxtCom.TabIndex = 37
        Me.TxtCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(216, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 28)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Comercial:"
        '
        'TxtInt
        '
        Me.TxtInt.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtInt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtInt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtInt.Location = New System.Drawing.Point(325, 87)
        Me.TxtInt.MaxLength = 100
        Me.TxtInt.Name = "TxtInt"
        Me.TxtInt.Size = New System.Drawing.Size(140, 31)
        Me.TxtInt.TabIndex = 35
        Me.TxtInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(218, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 28)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Interno:"
        '
        'CboTpo
        '
        Me.CboTpo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboTpo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboTpo.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboTpo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboTpo.FormattingEnabled = True
        Me.CboTpo.Location = New System.Drawing.Point(325, 38)
        Me.CboTpo.Name = "CboTpo"
        Me.CboTpo.Size = New System.Drawing.Size(140, 31)
        Me.CboTpo.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(218, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 28)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Categoría:"
        '
        'PbFoto
        '
        Me.PbFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PbFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbFoto.Image = Global.UbiSoft.My.Resources.Resources.inventario
        Me.PbFoto.Location = New System.Drawing.Point(12, 38)
        Me.PbFoto.Name = "PbFoto"
        Me.PbFoto.Size = New System.Drawing.Size(200, 180)
        Me.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbFoto.TabIndex = 12
        Me.PbFoto.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(7, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 28)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Foto:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.DgvInv)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 437)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1024, 331)
        Me.Panel2.TabIndex = 5
        '
        'DgvInv
        '
        Me.DgvInv.AllowUserToAddRows = False
        Me.DgvInv.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ebrima", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DgvInv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvInv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvInv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvInv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvInv.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvInv.EnableHeadersVisualStyles = False
        Me.DgvInv.GridColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DgvInv.Location = New System.Drawing.Point(12, 12)
        Me.DgvInv.Name = "DgvInv"
        Me.DgvInv.ReadOnly = True
        Me.DgvInv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvInv.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Ebrima", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DgvInv.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvInv.RowTemplate.Height = 240
        Me.DgvInv.Size = New System.Drawing.Size(1000, 261)
        Me.DgvInv.TabIndex = 1
        '
        'ScrInvEditFromDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PnlBottom)
        Me.Controls.Add(Me.PnlTop)
        Me.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrInvEditFromDevice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScrInvEditFromDevice"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        CType(Me.PbLed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnlCtrl.ResumeLayout(False)
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbLogoMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBottom.ResumeLayout(False)
        Me.PnlBottom.PerformLayout()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DgvInv, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PnlBottom As Panel
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents TxtArea As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCost As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTag As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtCom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtInt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CboTpo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PbFoto As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DgvInv As DataGridView
End Class
