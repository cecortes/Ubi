<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrMain
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
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.PnlCtrl = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Drag = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ElipseConfig = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ElipseAdmin = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ElipseAlma = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ElipseManto = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ElipseProd = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ElipseVentas = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BtnVentas = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BtnProd = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BtnManto = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BtnAlmacen = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BtnAdmin = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BtnConfig = New Bunifu.Framework.UI.BunifuTileButton()
        Me.PbBottom = New System.Windows.Forms.PictureBox()
        Me.PbMin = New System.Windows.Forms.PictureBox()
        Me.PbClose = New System.Windows.Forms.PictureBox()
        Me.PbLogoMin = New System.Windows.Forms.PictureBox()
        Me.PbBckGround = New System.Windows.Forms.PictureBox()
        Me.PnlTop.SuspendLayout()
        Me.PnlCtrl.SuspendLayout()
        CType(Me.PbBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbLogoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbBckGround, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PnlTop.TabIndex = 1
        '
        'PnlCtrl
        '
        Me.PnlCtrl.Controls.Add(Me.PbMin)
        Me.PnlCtrl.Controls.Add(Me.PbClose)
        Me.PnlCtrl.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlCtrl.Location = New System.Drawing.Point(624, 0)
        Me.PnlCtrl.Name = "PnlCtrl"
        Me.PnlCtrl.Size = New System.Drawing.Size(400, 40)
        Me.PnlCtrl.TabIndex = 4
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
        'Drag
        '
        Me.Drag.Fixed = True
        Me.Drag.Horizontal = True
        Me.Drag.TargetControl = Me.PbBckGround
        Me.Drag.Vertical = True
        '
        'Elipse
        '
        Me.Elipse.ElipseRadius = 30
        Me.Elipse.TargetControl = Me
        '
        'ElipseConfig
        '
        Me.ElipseConfig.ElipseRadius = 50
        Me.ElipseConfig.TargetControl = Me.BtnConfig
        '
        'ElipseAdmin
        '
        Me.ElipseAdmin.ElipseRadius = 50
        Me.ElipseAdmin.TargetControl = Me.BtnAdmin
        '
        'ElipseAlma
        '
        Me.ElipseAlma.ElipseRadius = 50
        Me.ElipseAlma.TargetControl = Me.BtnAlmacen
        '
        'ElipseManto
        '
        Me.ElipseManto.ElipseRadius = 50
        Me.ElipseManto.TargetControl = Me.BtnManto
        '
        'ElipseProd
        '
        Me.ElipseProd.ElipseRadius = 50
        Me.ElipseProd.TargetControl = Me.BtnProd
        '
        'ElipseVentas
        '
        Me.ElipseVentas.ElipseRadius = 50
        Me.ElipseVentas.TargetControl = Me.BtnVentas
        '
        'BtnVentas
        '
        Me.BtnVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnVentas.color = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnVentas.colorActive = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVentas.Enabled = False
        Me.BtnVentas.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnVentas.Image = Global.UbiSoft.My.Resources.Resources.ventas
        Me.BtnVentas.ImagePosition = 15
        Me.BtnVentas.ImageZoom = 45
        Me.BtnVentas.LabelPosition = 41
        Me.BtnVentas.LabelText = "Ventas"
        Me.BtnVentas.Location = New System.Drawing.Point(579, 520)
        Me.BtnVentas.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(202, 150)
        Me.BtnVentas.TabIndex = 8
        '
        'BtnProd
        '
        Me.BtnProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnProd.color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnProd.colorActive = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProd.Enabled = False
        Me.BtnProd.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnProd.Image = Global.UbiSoft.My.Resources.Resources.proveedor
        Me.BtnProd.ImagePosition = 15
        Me.BtnProd.ImageZoom = 45
        Me.BtnProd.LabelPosition = 41
        Me.BtnProd.LabelText = "Producción"
        Me.BtnProd.Location = New System.Drawing.Point(239, 520)
        Me.BtnProd.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BtnProd.Name = "BtnProd"
        Me.BtnProd.Size = New System.Drawing.Size(200, 150)
        Me.BtnProd.TabIndex = 7
        '
        'BtnManto
        '
        Me.BtnManto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnManto.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnManto.color = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnManto.colorActive = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnManto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnManto.Enabled = False
        Me.BtnManto.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnManto.Image = Global.UbiSoft.My.Resources.Resources.mantenimiento
        Me.BtnManto.ImagePosition = 15
        Me.BtnManto.ImageZoom = 45
        Me.BtnManto.LabelPosition = 41
        Me.BtnManto.LabelText = "Mantenimiento"
        Me.BtnManto.Location = New System.Drawing.Point(637, 314)
        Me.BtnManto.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BtnManto.Name = "BtnManto"
        Me.BtnManto.Size = New System.Drawing.Size(200, 150)
        Me.BtnManto.TabIndex = 6
        '
        'BtnAlmacen
        '
        Me.BtnAlmacen.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnAlmacen.color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnAlmacen.colorActive = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnAlmacen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAlmacen.Enabled = False
        Me.BtnAlmacen.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlmacen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnAlmacen.Image = Global.UbiSoft.My.Resources.Resources.caja
        Me.BtnAlmacen.ImagePosition = 15
        Me.BtnAlmacen.ImageZoom = 45
        Me.BtnAlmacen.LabelPosition = 41
        Me.BtnAlmacen.LabelText = "Almacén"
        Me.BtnAlmacen.Location = New System.Drawing.Point(171, 314)
        Me.BtnAlmacen.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BtnAlmacen.Name = "BtnAlmacen"
        Me.BtnAlmacen.Size = New System.Drawing.Size(200, 150)
        Me.BtnAlmacen.TabIndex = 5
        '
        'BtnAdmin
        '
        Me.BtnAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnAdmin.color = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnAdmin.colorActive = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdmin.Enabled = False
        Me.BtnAdmin.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnAdmin.Image = Global.UbiSoft.My.Resources.Resources.mano
        Me.BtnAdmin.ImagePosition = 15
        Me.BtnAdmin.ImageZoom = 45
        Me.BtnAdmin.LabelPosition = 41
        Me.BtnAdmin.LabelText = "Administración"
        Me.BtnAdmin.Location = New System.Drawing.Point(579, 108)
        Me.BtnAdmin.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BtnAdmin.Name = "BtnAdmin"
        Me.BtnAdmin.Size = New System.Drawing.Size(200, 150)
        Me.BtnAdmin.TabIndex = 4
        '
        'BtnConfig
        '
        Me.BtnConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnConfig.color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnConfig.colorActive = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConfig.Enabled = False
        Me.BtnConfig.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfig.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnConfig.Image = Global.UbiSoft.My.Resources.Resources.gear
        Me.BtnConfig.ImagePosition = 15
        Me.BtnConfig.ImageZoom = 45
        Me.BtnConfig.LabelPosition = 41
        Me.BtnConfig.LabelText = "Configuración"
        Me.BtnConfig.Location = New System.Drawing.Point(239, 108)
        Me.BtnConfig.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BtnConfig.Name = "BtnConfig"
        Me.BtnConfig.Size = New System.Drawing.Size(200, 150)
        Me.BtnConfig.TabIndex = 3
        '
        'PbBottom
        '
        Me.PbBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PbBottom.Image = Global.UbiSoft.My.Resources.Resources.BackBottom1
        Me.PbBottom.Location = New System.Drawing.Point(0, 743)
        Me.PbBottom.Name = "PbBottom"
        Me.PbBottom.Size = New System.Drawing.Size(1024, 25)
        Me.PbBottom.TabIndex = 2
        Me.PbBottom.TabStop = False
        '
        'PbMin
        '
        Me.PbMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbMin.Image = Global.UbiSoft.My.Resources.Resources.min
        Me.PbMin.Location = New System.Drawing.Point(295, 5)
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
        'PbBckGround
        '
        Me.PbBckGround.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbBckGround.Image = Global.UbiSoft.My.Resources.Resources.background
        Me.PbBckGround.Location = New System.Drawing.Point(0, 0)
        Me.PbBckGround.Name = "PbBckGround"
        Me.PbBckGround.Size = New System.Drawing.Size(1024, 768)
        Me.PbBckGround.TabIndex = 0
        Me.PbBckGround.TabStop = False
        '
        'ScrMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.BtnVentas)
        Me.Controls.Add(Me.BtnProd)
        Me.Controls.Add(Me.BtnManto)
        Me.Controls.Add(Me.BtnAlmacen)
        Me.Controls.Add(Me.BtnAdmin)
        Me.Controls.Add(Me.BtnConfig)
        Me.Controls.Add(Me.PbBottom)
        Me.Controls.Add(Me.PnlTop)
        Me.Controls.Add(Me.PbBckGround)
        Me.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        Me.PnlCtrl.ResumeLayout(False)
        CType(Me.PbBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbLogoMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbBckGround, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PbBckGround As PictureBox
    Friend WithEvents PnlTop As Panel
    Friend WithEvents PbBottom As PictureBox
    Friend WithEvents PbLogoMin As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PnlCtrl As Panel
    Friend WithEvents PbClose As PictureBox
    Friend WithEvents PbMin As PictureBox
    Friend WithEvents Drag As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Elipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BtnAlmacen As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BtnAdmin As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BtnConfig As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BtnManto As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BtnVentas As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BtnProd As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents ElipseConfig As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ElipseAdmin As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ElipseAlma As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ElipseManto As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ElipseProd As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ElipseVentas As Bunifu.Framework.UI.BunifuElipse
End Class
