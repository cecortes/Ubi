<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrConfigUsrEdit
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
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlData = New System.Windows.Forms.Panel()
        Me.BtnOkEdit = New System.Windows.Forms.Button()
        Me.BtnClearEdit = New System.Windows.Forms.Button()
        Me.BtnSearchEdit = New System.Windows.Forms.Button()
        Me.DgvUsrEdit = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlOpt = New System.Windows.Forms.Panel()
        Me.TxtMailEdit = New System.Windows.Forms.TextBox()
        Me.TxtApelliEdit = New System.Windows.Forms.TextBox()
        Me.CboUnidadEdit = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTelEdit = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPassEdit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNomEdit = New System.Windows.Forms.TextBox()
        Me.PnlData.SuspendLayout()
        CType(Me.DgvUsrEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlOpt.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlData
        '
        Me.PnlData.BackColor = System.Drawing.Color.Transparent
        Me.PnlData.Controls.Add(Me.BtnOkEdit)
        Me.PnlData.Controls.Add(Me.BtnClearEdit)
        Me.PnlData.Controls.Add(Me.BtnSearchEdit)
        Me.PnlData.Controls.Add(Me.DgvUsrEdit)
        Me.PnlData.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlData.Location = New System.Drawing.Point(0, 0)
        Me.PnlData.Name = "PnlData"
        Me.PnlData.Size = New System.Drawing.Size(984, 406)
        Me.PnlData.TabIndex = 0
        '
        'BtnOkEdit
        '
        Me.BtnOkEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOkEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOkEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOkEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOkEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOkEdit.Image = Global.UbiSoft.My.Resources.Resources.ok32
        Me.BtnOkEdit.Location = New System.Drawing.Point(912, 321)
        Me.BtnOkEdit.Name = "BtnOkEdit"
        Me.BtnOkEdit.Size = New System.Drawing.Size(60, 60)
        Me.BtnOkEdit.TabIndex = 19
        Me.BtnOkEdit.UseVisualStyleBackColor = False
        '
        'BtnClearEdit
        '
        Me.BtnClearEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClearEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnClearEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClearEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClearEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnClearEdit.Image = Global.UbiSoft.My.Resources.Resources.borrar
        Me.BtnClearEdit.Location = New System.Drawing.Point(795, 321)
        Me.BtnClearEdit.Name = "BtnClearEdit"
        Me.BtnClearEdit.Size = New System.Drawing.Size(60, 60)
        Me.BtnClearEdit.TabIndex = 18
        Me.BtnClearEdit.UseVisualStyleBackColor = False
        '
        'BtnSearchEdit
        '
        Me.BtnSearchEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSearchEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnSearchEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearchEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnSearchEdit.Image = Global.UbiSoft.My.Resources.Resources.excel
        Me.BtnSearchEdit.Location = New System.Drawing.Point(13, 321)
        Me.BtnSearchEdit.Name = "BtnSearchEdit"
        Me.BtnSearchEdit.Size = New System.Drawing.Size(60, 60)
        Me.BtnSearchEdit.TabIndex = 17
        Me.BtnSearchEdit.UseVisualStyleBackColor = False
        '
        'DgvUsrEdit
        '
        Me.DgvUsrEdit.AllowUserToAddRows = False
        Me.DgvUsrEdit.AllowUserToDeleteRows = False
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.DgvUsrEdit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle28
        Me.DgvUsrEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvUsrEdit.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DgvUsrEdit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvUsrEdit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvUsrEdit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle29
        Me.DgvUsrEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUsrEdit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvUsrEdit.DefaultCellStyle = DataGridViewCellStyle36
        Me.DgvUsrEdit.DoubleBuffered = True
        Me.DgvUsrEdit.EnableHeadersVisualStyles = False
        Me.DgvUsrEdit.GridColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DgvUsrEdit.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DgvUsrEdit.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvUsrEdit.Location = New System.Drawing.Point(12, 12)
        Me.DgvUsrEdit.Name = "DgvUsrEdit"
        Me.DgvUsrEdit.ReadOnly = True
        Me.DgvUsrEdit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvUsrEdit.RowHeadersWidth = 51
        Me.DgvUsrEdit.RowTemplate.Height = 24
        Me.DgvUsrEdit.Size = New System.Drawing.Size(959, 283)
        Me.DgvUsrEdit.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle30
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle31
        Me.Column2.HeaderText = "Apellidos"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 106
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle32
        Me.Column3.HeaderText = "Correo"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 89
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle33
        Me.Column4.HeaderText = "Contraseña"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 124
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle34
        Me.Column5.HeaderText = "Teléfono"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 103
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle35
        Me.Column6.HeaderText = "Departamento"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'PnlOpt
        '
        Me.PnlOpt.BackColor = System.Drawing.Color.Transparent
        Me.PnlOpt.Controls.Add(Me.TxtMailEdit)
        Me.PnlOpt.Controls.Add(Me.TxtApelliEdit)
        Me.PnlOpt.Controls.Add(Me.CboUnidadEdit)
        Me.PnlOpt.Controls.Add(Me.Label6)
        Me.PnlOpt.Controls.Add(Me.Label5)
        Me.PnlOpt.Controls.Add(Me.TxtTelEdit)
        Me.PnlOpt.Controls.Add(Me.Label4)
        Me.PnlOpt.Controls.Add(Me.TxtPassEdit)
        Me.PnlOpt.Controls.Add(Me.Label3)
        Me.PnlOpt.Controls.Add(Me.Label2)
        Me.PnlOpt.Controls.Add(Me.Label1)
        Me.PnlOpt.Controls.Add(Me.TxtNomEdit)
        Me.PnlOpt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOpt.Location = New System.Drawing.Point(0, 406)
        Me.PnlOpt.Name = "PnlOpt"
        Me.PnlOpt.Size = New System.Drawing.Size(984, 257)
        Me.PnlOpt.TabIndex = 1
        '
        'TxtMailEdit
        '
        Me.TxtMailEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMailEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtMailEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMailEdit.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtMailEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtMailEdit.Location = New System.Drawing.Point(671, 63)
        Me.TxtMailEdit.Name = "TxtMailEdit"
        Me.TxtMailEdit.Size = New System.Drawing.Size(250, 31)
        Me.TxtMailEdit.TabIndex = 25
        Me.TxtMailEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtApelliEdit
        '
        Me.TxtApelliEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtApelliEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtApelliEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApelliEdit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApelliEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtApelliEdit.Location = New System.Drawing.Point(344, 63)
        Me.TxtApelliEdit.Name = "TxtApelliEdit"
        Me.TxtApelliEdit.Size = New System.Drawing.Size(250, 31)
        Me.TxtApelliEdit.TabIndex = 24
        Me.TxtApelliEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CboUnidadEdit
        '
        Me.CboUnidadEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboUnidadEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CboUnidadEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboUnidadEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboUnidadEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboUnidadEdit.FormattingEnabled = True
        Me.CboUnidadEdit.Location = New System.Drawing.Point(671, 179)
        Me.CboUnidadEdit.Name = "CboUnidadEdit"
        Me.CboUnidadEdit.Size = New System.Drawing.Size(250, 31)
        Me.CboUnidadEdit.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(692, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 28)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Area / Departamento:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(425, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 28)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Teléfono:"
        '
        'TxtTelEdit
        '
        Me.TxtTelEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtTelEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtTelEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtTelEdit.Location = New System.Drawing.Point(344, 179)
        Me.TxtTelEdit.Mask = "(999)000-0000"
        Me.TxtTelEdit.Name = "TxtTelEdit"
        Me.TxtTelEdit.PromptChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.TxtTelEdit.Size = New System.Drawing.Size(250, 31)
        Me.TxtTelEdit.TabIndex = 20
        Me.TxtTelEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(106, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 28)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Contraseña:"
        '
        'TxtPassEdit
        '
        Me.TxtPassEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtPassEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPassEdit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPassEdit.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtPassEdit.Location = New System.Drawing.Point(61, 179)
        Me.TxtPassEdit.Name = "TxtPassEdit"
        Me.TxtPassEdit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.TxtPassEdit.Size = New System.Drawing.Size(200, 29)
        Me.TxtPassEdit.TabIndex = 18
        Me.TxtPassEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(709, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 28)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Correo electrónico:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(422, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 28)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Apellidos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(120, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 28)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nombre:"
        '
        'TxtNomEdit
        '
        Me.TxtNomEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtNomEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNomEdit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNomEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtNomEdit.Location = New System.Drawing.Point(61, 63)
        Me.TxtNomEdit.Name = "TxtNomEdit"
        Me.TxtNomEdit.Size = New System.Drawing.Size(200, 31)
        Me.TxtNomEdit.TabIndex = 14
        Me.TxtNomEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ScrConfigUsrEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 663)
        Me.Controls.Add(Me.PnlOpt)
        Me.Controls.Add(Me.PnlData)
        Me.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ScrConfigUsrEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrConfigUsrEdit"
        Me.PnlData.ResumeLayout(False)
        CType(Me.DgvUsrEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlOpt.ResumeLayout(False)
        Me.PnlOpt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlData As Panel
    Friend WithEvents PnlOpt As Panel
    Friend WithEvents DgvUsrEdit As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents BtnSearchEdit As Button
    Friend WithEvents BtnClearEdit As Button
    Friend WithEvents BtnOkEdit As Button
    Friend WithEvents CboUnidadEdit As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTelEdit As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPassEdit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNomEdit As TextBox
    Friend WithEvents TxtMailEdit As TextBox
    Friend WithEvents TxtApelliEdit As TextBox
End Class
