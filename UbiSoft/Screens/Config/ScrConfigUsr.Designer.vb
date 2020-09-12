<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrConfigUsr
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
        Me.components = New System.ComponentModel.Container()
        Dim BunifuElipse7 As Bunifu.Framework.UI.BunifuElipse
        Dim BunifuElipse6 As Bunifu.Framework.UI.BunifuElipse
        Dim BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
        Dim BunifuElipse4 As Bunifu.Framework.UI.BunifuElipse
        Dim BunifuElipse5 As Bunifu.Framework.UI.BunifuElipse
        Dim BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
        Dim BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
        Dim BunifuElipse8 As Bunifu.Framework.UI.BunifuElipse
        Dim Elipse1 As Bunifu.Framework.UI.BunifuElipse
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScrConfigUsr))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.TxtTel = New System.Windows.Forms.MaskedTextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtApelli = New System.Windows.Forms.TextBox()
        Me.CboUnidad = New System.Windows.Forms.ComboBox()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.PnlOpt = New System.Windows.Forms.Panel()
        Me.BtnDel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnEdit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnNew = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PnlBottom = New System.Windows.Forms.Panel()
        Me.DgvUsr = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.PnlData = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        BunifuElipse7 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        BunifuElipse6 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        BunifuElipse4 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        BunifuElipse5 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        BunifuElipse8 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Elipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PnlOpt.SuspendLayout()
        Me.PnlBottom.SuspendLayout()
        CType(Me.DgvUsr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlData.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse7
        '
        BunifuElipse7.ElipseRadius = 25
        BunifuElipse7.TargetControl = Me.BtnSearch
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnSearch.Image = Global.UbiSoft.My.Resources.Resources.excel
        Me.BtnSearch.Location = New System.Drawing.Point(13, 586)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(60, 60)
        Me.BtnSearch.TabIndex = 16
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'BunifuElipse6
        '
        BunifuElipse6.ElipseRadius = 25
        BunifuElipse6.TargetControl = Me.BtnClear
        '
        'BtnClear
        '
        Me.BtnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnClear.Image = Global.UbiSoft.My.Resources.Resources.borrar
        Me.BtnClear.Location = New System.Drawing.Point(795, 586)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(60, 60)
        Me.BtnClear.TabIndex = 16
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BunifuElipse1
        '
        BunifuElipse1.ElipseRadius = 25
        BunifuElipse1.TargetControl = Me.BtnOk
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Image = Global.UbiSoft.My.Resources.Resources.ok32
        Me.BtnOk.Location = New System.Drawing.Point(912, 586)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(60, 60)
        Me.BtnOk.TabIndex = 15
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'BunifuElipse4
        '
        BunifuElipse4.ElipseRadius = 25
        BunifuElipse4.TargetControl = Me.TxtTel
        '
        'TxtTel
        '
        Me.TxtTel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtTel.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtTel.Location = New System.Drawing.Point(337, 179)
        Me.TxtTel.Mask = "(999)000-0000"
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.PromptChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.TxtTel.Size = New System.Drawing.Size(250, 31)
        Me.TxtTel.TabIndex = 8
        Me.TxtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuElipse5
        '
        BunifuElipse5.ElipseRadius = 25
        BunifuElipse5.TargetControl = Me.TxtPass
        '
        'TxtPass
        '
        Me.TxtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPass.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtPass.Location = New System.Drawing.Point(54, 179)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.TxtPass.Size = New System.Drawing.Size(200, 29)
        Me.TxtPass.TabIndex = 6
        Me.TxtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuElipse3
        '
        BunifuElipse3.ElipseRadius = 25
        BunifuElipse3.TargetControl = Me.TxtMail
        '
        'TxtMail
        '
        Me.TxtMail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMail.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtMail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtMail.Location = New System.Drawing.Point(664, 63)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(250, 31)
        Me.TxtMail.TabIndex = 4
        Me.TxtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuElipse2
        '
        BunifuElipse2.ElipseRadius = 25
        BunifuElipse2.TargetControl = Me.TxtApelli
        '
        'TxtApelli
        '
        Me.TxtApelli.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtApelli.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtApelli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApelli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApelli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtApelli.Location = New System.Drawing.Point(337, 63)
        Me.TxtApelli.Name = "TxtApelli"
        Me.TxtApelli.Size = New System.Drawing.Size(250, 31)
        Me.TxtApelli.TabIndex = 2
        Me.TxtApelli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuElipse8
        '
        BunifuElipse8.ElipseRadius = 15
        BunifuElipse8.TargetControl = Me.CboUnidad
        '
        'CboUnidad
        '
        Me.CboUnidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboUnidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CboUnidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboUnidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboUnidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboUnidad.FormattingEnabled = True
        Me.CboUnidad.Location = New System.Drawing.Point(664, 179)
        Me.CboUnidad.Name = "CboUnidad"
        Me.CboUnidad.Size = New System.Drawing.Size(250, 31)
        Me.CboUnidad.TabIndex = 13
        '
        'Elipse1
        '
        Elipse1.ElipseRadius = 25
        Elipse1.TargetControl = Me.TxtNom
        '
        'TxtNom
        '
        Me.TxtNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtNom.Location = New System.Drawing.Point(54, 63)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(200, 31)
        Me.TxtNom.TabIndex = 0
        Me.TxtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnlOpt
        '
        Me.PnlOpt.BackColor = System.Drawing.Color.Transparent
        Me.PnlOpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PnlOpt.Controls.Add(Me.BtnDel)
        Me.PnlOpt.Controls.Add(Me.BtnEdit)
        Me.PnlOpt.Controls.Add(Me.BtnNew)
        Me.PnlOpt.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlOpt.Location = New System.Drawing.Point(0, 0)
        Me.PnlOpt.Name = "PnlOpt"
        Me.PnlOpt.Size = New System.Drawing.Size(984, 65)
        Me.PnlOpt.TabIndex = 0
        '
        'BtnDel
        '
        Me.BtnDel.ActiveBorderThickness = 1
        Me.BtnDel.ActiveCornerRadius = 20
        Me.BtnDel.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnDel.ActiveForecolor = System.Drawing.Color.White
        Me.BtnDel.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnDel.BackColor = System.Drawing.Color.Transparent
        Me.BtnDel.BackgroundImage = CType(resources.GetObject("BtnDel.BackgroundImage"), System.Drawing.Image)
        Me.BtnDel.ButtonText = "Borrar Usuario"
        Me.BtnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDel.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnDel.IdleBorderThickness = 1
        Me.BtnDel.IdleCornerRadius = 20
        Me.BtnDel.IdleFillColor = System.Drawing.Color.Transparent
        Me.BtnDel.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnDel.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnDel.Location = New System.Drawing.Point(379, 16)
        Me.BtnDel.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(166, 46)
        Me.BtnDel.TabIndex = 2
        Me.BtnDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEdit
        '
        Me.BtnEdit.ActiveBorderThickness = 1
        Me.BtnEdit.ActiveCornerRadius = 20
        Me.BtnEdit.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnEdit.ActiveForecolor = System.Drawing.Color.White
        Me.BtnEdit.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnEdit.BackColor = System.Drawing.Color.Transparent
        Me.BtnEdit.BackgroundImage = CType(resources.GetObject("BtnEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnEdit.ButtonText = "Editar Usuario"
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnEdit.IdleBorderThickness = 1
        Me.BtnEdit.IdleCornerRadius = 20
        Me.BtnEdit.IdleFillColor = System.Drawing.Color.Transparent
        Me.BtnEdit.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnEdit.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnEdit.Location = New System.Drawing.Point(196, 16)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(166, 46)
        Me.BtnEdit.TabIndex = 1
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnNew
        '
        Me.BtnNew.ActiveBorderThickness = 1
        Me.BtnNew.ActiveCornerRadius = 20
        Me.BtnNew.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnNew.ActiveForecolor = System.Drawing.Color.White
        Me.BtnNew.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnNew.BackColor = System.Drawing.Color.Transparent
        Me.BtnNew.BackgroundImage = CType(resources.GetObject("BtnNew.BackgroundImage"), System.Drawing.Image)
        Me.BtnNew.ButtonText = "Nuevo Usuario"
        Me.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNew.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnNew.IdleBorderThickness = 1
        Me.BtnNew.IdleCornerRadius = 20
        Me.BtnNew.IdleFillColor = System.Drawing.Color.Transparent
        Me.BtnNew.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnNew.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnNew.Location = New System.Drawing.Point(13, 16)
        Me.BtnNew.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(166, 46)
        Me.BtnNew.TabIndex = 0
        Me.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlBottom
        '
        Me.PnlBottom.BackColor = System.Drawing.Color.Transparent
        Me.PnlBottom.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.PnlBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlBottom.Controls.Add(Me.BtnOk)
        Me.PnlBottom.Controls.Add(Me.BtnClear)
        Me.PnlBottom.Controls.Add(Me.BtnSearch)
        Me.PnlBottom.Controls.Add(Me.DgvUsr)
        Me.PnlBottom.Controls.Add(Me.PnlData)
        Me.PnlBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlBottom.Location = New System.Drawing.Point(0, 65)
        Me.PnlBottom.Name = "PnlBottom"
        Me.PnlBottom.Size = New System.Drawing.Size(984, 663)
        Me.PnlBottom.TabIndex = 1
        '
        'DgvUsr
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvUsr.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvUsr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvUsr.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgvUsr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvUsr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvUsr.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvUsr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUsr.DoubleBuffered = True
        Me.DgvUsr.EnableHeadersVisualStyles = False
        Me.DgvUsr.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.DgvUsr.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.DgvUsr.Location = New System.Drawing.Point(13, 290)
        Me.DgvUsr.Name = "DgvUsr"
        Me.DgvUsr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvUsr.RowHeadersWidth = 51
        Me.DgvUsr.RowTemplate.Height = 24
        Me.DgvUsr.Size = New System.Drawing.Size(959, 283)
        Me.DgvUsr.TabIndex = 1
        '
        'PnlData
        '
        Me.PnlData.Controls.Add(Me.CboUnidad)
        Me.PnlData.Controls.Add(Me.Label6)
        Me.PnlData.Controls.Add(Me.Label5)
        Me.PnlData.Controls.Add(Me.TxtTel)
        Me.PnlData.Controls.Add(Me.Label4)
        Me.PnlData.Controls.Add(Me.TxtPass)
        Me.PnlData.Controls.Add(Me.Label3)
        Me.PnlData.Controls.Add(Me.TxtMail)
        Me.PnlData.Controls.Add(Me.Label2)
        Me.PnlData.Controls.Add(Me.TxtApelli)
        Me.PnlData.Controls.Add(Me.Label1)
        Me.PnlData.Controls.Add(Me.TxtNom)
        Me.PnlData.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlData.Location = New System.Drawing.Point(0, 0)
        Me.PnlData.Name = "PnlData"
        Me.PnlData.Size = New System.Drawing.Size(984, 284)
        Me.PnlData.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(685, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 28)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Area / Departamento:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(418, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 28)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Teléfono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(99, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 28)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(702, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 28)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Correo electrónico:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(415, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellidos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(113, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'ScrConfigUsr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 728)
        Me.Controls.Add(Me.PnlBottom)
        Me.Controls.Add(Me.PnlOpt)
        Me.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrConfigUsr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrConfigUsr"
        Me.PnlOpt.ResumeLayout(False)
        Me.PnlBottom.ResumeLayout(False)
        CType(Me.DgvUsr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlData.ResumeLayout(False)
        Me.PnlData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlOpt As Panel
    Friend WithEvents PnlBottom As Panel
    Friend WithEvents BtnNew As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnEdit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnDel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PnlData As Panel
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtApelli As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTel As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents DgvUsr As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents CboUnidad As ComboBox
End Class
