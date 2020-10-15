<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrConfigAutoNew
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
        Me.CboTpo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtVeri = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.PnlData = New System.Windows.Forms.Panel()
        Me.TxtCapa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTag = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtUbi = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ChkGps = New System.Windows.Forms.CheckBox()
        Me.ChkFrio = New System.Windows.Forms.CheckBox()
        Me.DgvMaq = New System.Windows.Forms.DataGridView()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlTop.SuspendLayout()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlData.SuspendLayout()
        CType(Me.DgvMaq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.Transparent
        Me.PnlTop.Controls.Add(Me.ChkFrio)
        Me.PnlTop.Controls.Add(Me.ChkGps)
        Me.PnlTop.Controls.Add(Me.TxtUbi)
        Me.PnlTop.Controls.Add(Me.Label12)
        Me.PnlTop.Controls.Add(Me.TxtTag)
        Me.PnlTop.Controls.Add(Me.Label11)
        Me.PnlTop.Controls.Add(Me.TxtCapa)
        Me.PnlTop.Controls.Add(Me.Label10)
        Me.PnlTop.Controls.Add(Me.CboTpo)
        Me.PnlTop.Controls.Add(Me.Label9)
        Me.PnlTop.Controls.Add(Me.TxtVeri)
        Me.PnlTop.Controls.Add(Me.Label7)
        Me.PnlTop.Controls.Add(Me.TxtPol)
        Me.PnlTop.Controls.Add(Me.Label6)
        Me.PnlTop.Controls.Add(Me.TxtMotor)
        Me.PnlTop.Controls.Add(Me.Label5)
        Me.PnlTop.Controls.Add(Me.TxtAno)
        Me.PnlTop.Controls.Add(Me.Label8)
        Me.PnlTop.Controls.Add(Me.TxtModelo)
        Me.PnlTop.Controls.Add(Me.Label4)
        Me.PnlTop.Controls.Add(Me.TxtMarca)
        Me.PnlTop.Controls.Add(Me.Label3)
        Me.PnlTop.Controls.Add(Me.TxtPlaca)
        Me.PnlTop.Controls.Add(Me.Label1)
        Me.PnlTop.Controls.Add(Me.PbFoto)
        Me.PnlTop.Controls.Add(Me.Label2)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(984, 314)
        Me.PnlTop.TabIndex = 0
        '
        'CboTpo
        '
        Me.CboTpo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboTpo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboTpo.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboTpo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboTpo.FormattingEnabled = True
        Me.CboTpo.Location = New System.Drawing.Point(646, 136)
        Me.CboTpo.Name = "CboTpo"
        Me.CboTpo.Size = New System.Drawing.Size(140, 31)
        Me.CboTpo.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(585, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 28)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Tipo:"
        '
        'TxtVeri
        '
        Me.TxtVeri.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtVeri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVeri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtVeri.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtVeri.Location = New System.Drawing.Point(646, 90)
        Me.TxtVeri.MaxLength = 100
        Me.TxtVeri.Name = "TxtVeri"
        Me.TxtVeri.Size = New System.Drawing.Size(140, 31)
        Me.TxtVeri.TabIndex = 29
        Me.TxtVeri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(523, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 28)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Verificación:"
        '
        'TxtPol
        '
        Me.TxtPol.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtPol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtPol.Location = New System.Drawing.Point(646, 43)
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
        Me.Label6.Location = New System.Drawing.Point(572, 40)
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
        'PnlData
        '
        Me.PnlData.BackColor = System.Drawing.Color.Transparent
        Me.PnlData.Controls.Add(Me.BtnOk)
        Me.PnlData.Controls.Add(Me.BtnClear)
        Me.PnlData.Controls.Add(Me.BtnSearch)
        Me.PnlData.Controls.Add(Me.DgvMaq)
        Me.PnlData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlData.Location = New System.Drawing.Point(0, 314)
        Me.PnlData.Name = "PnlData"
        Me.PnlData.Size = New System.Drawing.Size(984, 349)
        Me.PnlData.TabIndex = 1
        '
        'TxtCapa
        '
        Me.TxtCapa.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtCapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCapa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCapa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtCapa.Location = New System.Drawing.Point(646, 182)
        Me.TxtCapa.MaxLength = 100
        Me.TxtCapa.Name = "TxtCapa"
        Me.TxtCapa.Size = New System.Drawing.Size(140, 31)
        Me.TxtCapa.TabIndex = 33
        Me.TxtCapa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(532, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 28)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Capacidad:"
        '
        'TxtTag
        '
        Me.TxtTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtTag.Location = New System.Drawing.Point(646, 226)
        Me.TxtTag.MaxLength = 100
        Me.TxtTag.Name = "TxtTag"
        Me.TxtTag.Size = New System.Drawing.Size(140, 31)
        Me.TxtTag.TabIndex = 35
        Me.TxtTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(587, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 28)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "TAG:"
        '
        'TxtUbi
        '
        Me.TxtUbi.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtUbi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUbi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUbi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtUbi.Location = New System.Drawing.Point(646, 271)
        Me.TxtUbi.MaxLength = 100
        Me.TxtUbi.Name = "TxtUbi"
        Me.TxtUbi.Size = New System.Drawing.Size(140, 31)
        Me.TxtUbi.TabIndex = 37
        Me.TxtUbi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(593, 268)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 28)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Ubi:"
        '
        'ChkGps
        '
        Me.ChkGps.AutoSize = True
        Me.ChkGps.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkGps.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkGps.Font = New System.Drawing.Font("Ebrima", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkGps.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ChkGps.Location = New System.Drawing.Point(264, 273)
        Me.ChkGps.Name = "ChkGps"
        Me.ChkGps.Size = New System.Drawing.Size(68, 29)
        Me.ChkGps.TabIndex = 38
        Me.ChkGps.Text = "GPS"
        Me.ChkGps.UseVisualStyleBackColor = True
        '
        'ChkFrio
        '
        Me.ChkFrio.AutoSize = True
        Me.ChkFrio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkFrio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkFrio.Font = New System.Drawing.Font("Ebrima", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFrio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ChkFrio.Location = New System.Drawing.Point(17, 273)
        Me.ChkFrio.Name = "ChkFrio"
        Me.ChkFrio.Size = New System.Drawing.Size(162, 29)
        Me.ChkFrio.TabIndex = 39
        Me.ChkFrio.Text = "Cámara de Frío"
        Me.ChkFrio.UseVisualStyleBackColor = True
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
        Me.DgvMaq.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13})
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
        Me.DgvMaq.Location = New System.Drawing.Point(3, 6)
        Me.DgvMaq.Name = "DgvMaq"
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
        Me.DgvMaq.Size = New System.Drawing.Size(978, 265)
        Me.DgvMaq.TabIndex = 1
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Image = Global.UbiSoft.My.Resources.Resources.ok32
        Me.BtnOk.Location = New System.Drawing.Point(898, 277)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(60, 60)
        Me.BtnOk.TabIndex = 44
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
        Me.BtnClear.Location = New System.Drawing.Point(776, 277)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(60, 60)
        Me.BtnClear.TabIndex = 43
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnSearch.Image = Global.UbiSoft.My.Resources.Resources.excel
        Me.BtnSearch.Location = New System.Drawing.Point(9, 277)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(60, 60)
        Me.BtnSearch.TabIndex = 42
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Placas"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 86
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Marca"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 86
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Modelo"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 97
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Año"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 70
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Motor"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 86
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Póliza"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 84
        '
        'Column7
        '
        Me.Column7.HeaderText = "Verificación"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "Tipo"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Column9
        '
        Me.Column9.HeaderText = "Capacidad"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 125
        '
        'Column10
        '
        Me.Column10.HeaderText = "Refrigerador"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 125
        '
        'Column11
        '
        Me.Column11.HeaderText = "Gps"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 125
        '
        'Column12
        '
        Me.Column12.HeaderText = "TAG"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 125
        '
        'Column13
        '
        Me.Column13.HeaderText = "UBI"
        Me.Column13.MinimumWidth = 6
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 125
        '
        'ScrConfigAutoNew
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
        Me.Name = "ScrConfigAutoNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrConfigAutoNew"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlData.ResumeLayout(False)
        CType(Me.DgvMaq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents PnlData As Panel
    Friend WithEvents PbFoto As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPlaca As TextBox
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtModelo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtAno As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtMotor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtVeri As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtPol As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CboTpo As ComboBox
    Friend WithEvents TxtCapa As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ChkFrio As CheckBox
    Friend WithEvents ChkGps As CheckBox
    Friend WithEvents TxtUbi As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtTag As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DgvMaq As DataGridView
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
End Class
