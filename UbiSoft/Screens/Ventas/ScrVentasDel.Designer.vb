<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrVentasDel
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.PnlCtrl = New System.Windows.Forms.Panel()
        Me.PbMax = New System.Windows.Forms.PictureBox()
        Me.PbMin = New System.Windows.Forms.PictureBox()
        Me.PbClose = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PbLogoMin = New System.Windows.Forms.PictureBox()
        Me.PnlFolio = New System.Windows.Forms.Panel()
        Me.CboFol = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PnlCli = New System.Windows.Forms.Panel()
        Me.LblRazon = New System.Windows.Forms.Label()
        Me.LblRfc = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PnlDgv = New System.Windows.Forms.Panel()
        Me.DgvVta = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.PnlOpt = New System.Windows.Forms.Panel()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.LblTot = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PnlTop.SuspendLayout()
        Me.PnlCtrl.SuspendLayout()
        CType(Me.PbMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbLogoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlFolio.SuspendLayout()
        Me.PnlCli.SuspendLayout()
        Me.PnlDgv.SuspendLayout()
        CType(Me.DgvVta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlOpt.SuspendLayout()
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
        Me.PnlTop.TabIndex = 8
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
        'PnlFolio
        '
        Me.PnlFolio.BackColor = System.Drawing.Color.Transparent
        Me.PnlFolio.Controls.Add(Me.CboFol)
        Me.PnlFolio.Controls.Add(Me.Label6)
        Me.PnlFolio.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlFolio.Location = New System.Drawing.Point(0, 40)
        Me.PnlFolio.Name = "PnlFolio"
        Me.PnlFolio.Size = New System.Drawing.Size(1024, 54)
        Me.PnlFolio.TabIndex = 9
        '
        'CboFol
        '
        Me.CboFol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboFol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboFol.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboFol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboFol.FormattingEnabled = True
        Me.CboFol.Location = New System.Drawing.Point(171, 11)
        Me.CboFol.Name = "CboFol"
        Me.CboFol.Size = New System.Drawing.Size(219, 31)
        Me.CboFol.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 28)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Folio de Venta:"
        '
        'PnlCli
        '
        Me.PnlCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.PnlCli.Controls.Add(Me.LblRazon)
        Me.PnlCli.Controls.Add(Me.LblRfc)
        Me.PnlCli.Controls.Add(Me.Label3)
        Me.PnlCli.Controls.Add(Me.Label5)
        Me.PnlCli.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlCli.Location = New System.Drawing.Point(0, 94)
        Me.PnlCli.Name = "PnlCli"
        Me.PnlCli.Size = New System.Drawing.Size(1024, 66)
        Me.PnlCli.TabIndex = 10
        '
        'LblRazon
        '
        Me.LblRazon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblRazon.AutoSize = True
        Me.LblRazon.Font = New System.Drawing.Font("Ebrima", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRazon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LblRazon.Location = New System.Drawing.Point(759, 22)
        Me.LblRazon.Name = "LblRazon"
        Me.LblRazon.Size = New System.Drawing.Size(40, 25)
        Me.LblRazon.TabIndex = 84
        Me.LblRazon.Text = "NA"
        '
        'LblRfc
        '
        Me.LblRfc.AutoSize = True
        Me.LblRfc.Font = New System.Drawing.Font("Ebrima", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRfc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LblRfc.Location = New System.Drawing.Point(196, 19)
        Me.LblRfc.Name = "LblRfc"
        Me.LblRfc.Size = New System.Drawing.Size(40, 25)
        Me.LblRfc.TabIndex = 83
        Me.LblRfc.Text = "NA"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(471, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 28)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Razón Social:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 28)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "RFC:"
        '
        'PnlDgv
        '
        Me.PnlDgv.BackColor = System.Drawing.Color.Transparent
        Me.PnlDgv.Controls.Add(Me.DgvVta)
        Me.PnlDgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlDgv.Location = New System.Drawing.Point(0, 160)
        Me.PnlDgv.Name = "PnlDgv"
        Me.PnlDgv.Size = New System.Drawing.Size(1024, 608)
        Me.PnlDgv.TabIndex = 11
        '
        'DgvVta
        '
        Me.DgvVta.AllowUserToAddRows = False
        Me.DgvVta.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.DgvVta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvVta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DgvVta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvVta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvVta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvVta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvVta.DefaultCellStyle = DataGridViewCellStyle6
        Me.DgvVta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvVta.DoubleBuffered = True
        Me.DgvVta.EnableHeadersVisualStyles = False
        Me.DgvVta.GridColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DgvVta.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DgvVta.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvVta.Location = New System.Drawing.Point(0, 0)
        Me.DgvVta.Name = "DgvVta"
        Me.DgvVta.ReadOnly = True
        Me.DgvVta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvVta.RowHeadersWidth = 51
        Me.DgvVta.RowTemplate.Height = 24
        Me.DgvVta.Size = New System.Drawing.Size(1024, 608)
        Me.DgvVta.TabIndex = 6
        '
        'PnlOpt
        '
        Me.PnlOpt.BackColor = System.Drawing.Color.Transparent
        Me.PnlOpt.Controls.Add(Me.BtnClear)
        Me.PnlOpt.Controls.Add(Me.LblTot)
        Me.PnlOpt.Controls.Add(Me.Label16)
        Me.PnlOpt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlOpt.Location = New System.Drawing.Point(0, 687)
        Me.PnlOpt.Name = "PnlOpt"
        Me.PnlOpt.Size = New System.Drawing.Size(1024, 81)
        Me.PnlOpt.TabIndex = 12
        '
        'BtnClear
        '
        Me.BtnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnClear.Image = Global.UbiSoft.My.Resources.Resources.borrar
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClear.Location = New System.Drawing.Point(17, 16)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(219, 46)
        Me.BtnClear.TabIndex = 62
        Me.BtnClear.Text = "Borrar Folio"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'LblTot
        '
        Me.LblTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTot.AutoSize = True
        Me.LblTot.Font = New System.Drawing.Font("Ebrima", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LblTot.Location = New System.Drawing.Point(856, 26)
        Me.LblTot.Name = "LblTot"
        Me.LblTot.Size = New System.Drawing.Size(66, 25)
        Me.LblTot.TabIndex = 61
        Me.LblTot.Text = "$ 0.00"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(725, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(125, 28)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Total venta:"
        '
        'ScrVentasDel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.PnlOpt)
        Me.Controls.Add(Me.PnlDgv)
        Me.Controls.Add(Me.PnlCli)
        Me.Controls.Add(Me.PnlFolio)
        Me.Controls.Add(Me.PnlTop)
        Me.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ScrVentasDel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScrVentasDel"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        Me.PnlCtrl.ResumeLayout(False)
        CType(Me.PbMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbLogoMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlFolio.ResumeLayout(False)
        Me.PnlFolio.PerformLayout()
        Me.PnlCli.ResumeLayout(False)
        Me.PnlCli.PerformLayout()
        Me.PnlDgv.ResumeLayout(False)
        CType(Me.DgvVta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlOpt.ResumeLayout(False)
        Me.PnlOpt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents PnlCtrl As Panel
    Friend WithEvents PbMax As PictureBox
    Friend WithEvents PbMin As PictureBox
    Friend WithEvents PbClose As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PbLogoMin As PictureBox
    Friend WithEvents PnlFolio As Panel
    Friend WithEvents CboFol As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PnlCli As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblRazon As Label
    Friend WithEvents LblRfc As Label
    Friend WithEvents PnlDgv As Panel
    Friend WithEvents DgvVta As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents PnlOpt As Panel
    Friend WithEvents LblTot As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents BtnClear As Button
End Class
