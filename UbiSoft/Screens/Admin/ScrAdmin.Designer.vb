<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrAdmin
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
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.PnlCtrl = New System.Windows.Forms.Panel()
        Me.PbMax = New System.Windows.Forms.PictureBox()
        Me.PbMin = New System.Windows.Forms.PictureBox()
        Me.PbClose = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PbLogoMin = New System.Windows.Forms.PictureBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ReportesItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasPorCobrarItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasPorPagarItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.BancosToolItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasPropiasItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaPropiasItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaPropiasItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasExtItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaExtItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaExtItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.NominaItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.PnlWrp = New System.Windows.Forms.Panel()
        Me.ConciliacionItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdoCuentaBancarioItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibroMayorBancosItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnlTop.SuspendLayout()
        Me.PnlCtrl.SuspendLayout()
        CType(Me.PbMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbLogoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.PnlMenu.SuspendLayout()
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
        Me.PnlTop.TabIndex = 3
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
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesItm, Me.CuentasPorCobrarItm, Me.CuentasPorPagarItm, Me.BancosToolItm, Me.NominaItm})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1024, 41)
        Me.MenuStrip.TabIndex = 4
        Me.MenuStrip.Text = "Menu"
        '
        'ReportesItm
        '
        Me.ReportesItm.BackColor = System.Drawing.Color.Transparent
        Me.ReportesItm.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesItm.ForeColor = System.Drawing.Color.Black
        Me.ReportesItm.Name = "ReportesItm"
        Me.ReportesItm.Size = New System.Drawing.Size(91, 37)
        Me.ReportesItm.Text = "Reportes"
        '
        'CuentasPorCobrarItm
        '
        Me.CuentasPorCobrarItm.BackColor = System.Drawing.Color.Transparent
        Me.CuentasPorCobrarItm.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuentasPorCobrarItm.ForeColor = System.Drawing.Color.Black
        Me.CuentasPorCobrarItm.Name = "CuentasPorCobrarItm"
        Me.CuentasPorCobrarItm.Size = New System.Drawing.Size(174, 37)
        Me.CuentasPorCobrarItm.Text = "Cuentas por Cobrar"
        '
        'CuentasPorPagarItm
        '
        Me.CuentasPorPagarItm.BackColor = System.Drawing.Color.Transparent
        Me.CuentasPorPagarItm.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuentasPorPagarItm.ForeColor = System.Drawing.Color.Black
        Me.CuentasPorPagarItm.Name = "CuentasPorPagarItm"
        Me.CuentasPorPagarItm.Size = New System.Drawing.Size(166, 37)
        Me.CuentasPorPagarItm.Text = "Cuentas por Pagar"
        '
        'BancosToolItm
        '
        Me.BancosToolItm.BackColor = System.Drawing.Color.Transparent
        Me.BancosToolItm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuentasPropiasItm, Me.CuentasExtItm, Me.ConciliacionItm})
        Me.BancosToolItm.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BancosToolItm.ForeColor = System.Drawing.Color.Black
        Me.BancosToolItm.Name = "BancosToolItm"
        Me.BancosToolItm.Size = New System.Drawing.Size(78, 37)
        Me.BancosToolItm.Text = "Bancos"
        '
        'CuentasPropiasItm
        '
        Me.CuentasPropiasItm.BackColor = System.Drawing.Color.Transparent
        Me.CuentasPropiasItm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaPropiasItm, Me.BajaPropiasItm})
        Me.CuentasPropiasItm.ForeColor = System.Drawing.Color.Black
        Me.CuentasPropiasItm.Name = "CuentasPropiasItm"
        Me.CuentasPropiasItm.Size = New System.Drawing.Size(225, 28)
        Me.CuentasPropiasItm.Text = "Cuentas Propias"
        '
        'AltaPropiasItm
        '
        Me.AltaPropiasItm.Name = "AltaPropiasItm"
        Me.AltaPropiasItm.Size = New System.Drawing.Size(224, 28)
        Me.AltaPropiasItm.Text = "Alta de Cuentas"
        '
        'BajaPropiasItm
        '
        Me.BajaPropiasItm.Name = "BajaPropiasItm"
        Me.BajaPropiasItm.Size = New System.Drawing.Size(224, 28)
        Me.BajaPropiasItm.Text = "Baja de Cuentas"
        '
        'CuentasExtItm
        '
        Me.CuentasExtItm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaExtItm, Me.BajaExtItm})
        Me.CuentasExtItm.Name = "CuentasExtItm"
        Me.CuentasExtItm.Size = New System.Drawing.Size(225, 28)
        Me.CuentasExtItm.Text = "Cuentas Externas"
        '
        'AltaExtItm
        '
        Me.AltaExtItm.Name = "AltaExtItm"
        Me.AltaExtItm.Size = New System.Drawing.Size(224, 28)
        Me.AltaExtItm.Text = "Alta de Cuentas"
        '
        'BajaExtItm
        '
        Me.BajaExtItm.Name = "BajaExtItm"
        Me.BajaExtItm.Size = New System.Drawing.Size(224, 28)
        Me.BajaExtItm.Text = "Baja de Cuentas"
        '
        'NominaItm
        '
        Me.NominaItm.BackColor = System.Drawing.Color.Transparent
        Me.NominaItm.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NominaItm.ForeColor = System.Drawing.Color.Black
        Me.NominaItm.Name = "NominaItm"
        Me.NominaItm.Size = New System.Drawing.Size(85, 37)
        Me.NominaItm.Text = "Nómina"
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.Transparent
        Me.PnlMenu.Controls.Add(Me.MenuStrip)
        Me.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlMenu.Location = New System.Drawing.Point(0, 40)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(1024, 41)
        Me.PnlMenu.TabIndex = 5
        '
        'PnlWrp
        '
        Me.PnlWrp.BackColor = System.Drawing.Color.Transparent
        Me.PnlWrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlWrp.Location = New System.Drawing.Point(0, 81)
        Me.PnlWrp.Name = "PnlWrp"
        Me.PnlWrp.Size = New System.Drawing.Size(1024, 687)
        Me.PnlWrp.TabIndex = 6
        '
        'ConciliacionItm
        '
        Me.ConciliacionItm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EdoCuentaBancarioItm, Me.LibroMayorBancosItm})
        Me.ConciliacionItm.Name = "ConciliacionItm"
        Me.ConciliacionItm.Size = New System.Drawing.Size(225, 28)
        Me.ConciliacionItm.Text = "Conciliación"
        '
        'EdoCuentaBancarioItm
        '
        Me.EdoCuentaBancarioItm.Name = "EdoCuentaBancarioItm"
        Me.EdoCuentaBancarioItm.Size = New System.Drawing.Size(258, 28)
        Me.EdoCuentaBancarioItm.Text = "Edo. Cuenta Bancario"
        '
        'LibroMayorBancosItm
        '
        Me.LibroMayorBancosItm.Name = "LibroMayorBancosItm"
        Me.LibroMayorBancosItm.Size = New System.Drawing.Size(258, 28)
        Me.LibroMayorBancosItm.Text = "Libro Mayor Bancos"
        '
        'ScrAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.PnlWrp)
        Me.Controls.Add(Me.PnlMenu)
        Me.Controls.Add(Me.PnlTop)
        Me.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScrAdmin"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        Me.PnlCtrl.ResumeLayout(False)
        CType(Me.PbMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbLogoMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.PnlMenu.ResumeLayout(False)
        Me.PnlMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents PnlCtrl As Panel
    Friend WithEvents PbMax As PictureBox
    Friend WithEvents PbMin As PictureBox
    Friend WithEvents PbClose As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PbLogoMin As PictureBox
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ReportesItm As ToolStripMenuItem
    Friend WithEvents PnlMenu As Panel
    Friend WithEvents CuentasPorCobrarItm As ToolStripMenuItem
    Friend WithEvents CuentasPorPagarItm As ToolStripMenuItem
    Friend WithEvents BancosToolItm As ToolStripMenuItem
    Friend WithEvents NominaItm As ToolStripMenuItem
    Friend WithEvents CuentasPropiasItm As ToolStripMenuItem
    Friend WithEvents AltaPropiasItm As ToolStripMenuItem
    Friend WithEvents BajaPropiasItm As ToolStripMenuItem
    Friend WithEvents CuentasExtItm As ToolStripMenuItem
    Friend WithEvents AltaExtItm As ToolStripMenuItem
    Friend WithEvents BajaExtItm As ToolStripMenuItem
    Friend WithEvents PnlWrp As Panel
    Friend WithEvents ConciliacionItm As ToolStripMenuItem
    Friend WithEvents EdoCuentaBancarioItm As ToolStripMenuItem
    Friend WithEvents LibroMayorBancosItm As ToolStripMenuItem
End Class
