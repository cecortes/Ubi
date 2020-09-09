<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScrConfig))
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.PnlCtrl = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlSide = New System.Windows.Forms.Panel()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.PnlWrapp = New System.Windows.Forms.Panel()
        Me.PbMenu = New System.Windows.Forms.PictureBox()
        Me.PbBckPanel = New System.Windows.Forms.PictureBox()
        Me.PbMax = New System.Windows.Forms.PictureBox()
        Me.PbMin = New System.Windows.Forms.PictureBox()
        Me.PbClose = New System.Windows.Forms.PictureBox()
        Me.PbLogoMin = New System.Windows.Forms.PictureBox()
        Me.PbBackground = New System.Windows.Forms.PictureBox()
        Me.Elipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.DragTop = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.DragSide = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BtnUsuarios = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnClientes = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnProductos = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnPrecios = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnMaq = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnAutos = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PnlTop.SuspendLayout()
        Me.PnlCtrl.SuspendLayout()
        Me.PnlSide.SuspendLayout()
        Me.PnlMenu.SuspendLayout()
        CType(Me.PbMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbBckPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbLogoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PnlTop.TabIndex = 2
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
        'PnlSide
        '
        Me.PnlSide.BackColor = System.Drawing.Color.Transparent
        Me.PnlSide.BackgroundImage = Global.UbiSoft.My.Resources.Resources.PnlBckG
        Me.PnlSide.Controls.Add(Me.BtnAutos)
        Me.PnlSide.Controls.Add(Me.BtnMaq)
        Me.PnlSide.Controls.Add(Me.BtnPrecios)
        Me.PnlSide.Controls.Add(Me.BtnProductos)
        Me.PnlSide.Controls.Add(Me.BtnClientes)
        Me.PnlSide.Controls.Add(Me.BtnUsuarios)
        Me.PnlSide.Controls.Add(Me.PnlMenu)
        Me.PnlSide.Controls.Add(Me.PbBckPanel)
        Me.PnlSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlSide.Location = New System.Drawing.Point(0, 40)
        Me.PnlSide.Name = "PnlSide"
        Me.PnlSide.Size = New System.Drawing.Size(150, 728)
        Me.PnlSide.TabIndex = 3
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.Transparent
        Me.PnlMenu.Controls.Add(Me.PbMenu)
        Me.PnlMenu.Location = New System.Drawing.Point(0, 10)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(150, 40)
        Me.PnlMenu.TabIndex = 1
        '
        'PnlWrapp
        '
        Me.PnlWrapp.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.PnlWrapp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlWrapp.Location = New System.Drawing.Point(150, 40)
        Me.PnlWrapp.Name = "PnlWrapp"
        Me.PnlWrapp.Size = New System.Drawing.Size(874, 728)
        Me.PnlWrapp.TabIndex = 4
        '
        'PbMenu
        '
        Me.PbMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PbMenu.Image = Global.UbiSoft.My.Resources.Resources.menu
        Me.PbMenu.Location = New System.Drawing.Point(0, 0)
        Me.PbMenu.Name = "PbMenu"
        Me.PbMenu.Size = New System.Drawing.Size(40, 40)
        Me.PbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PbMenu.TabIndex = 0
        Me.PbMenu.TabStop = False
        '
        'PbBckPanel
        '
        Me.PbBckPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PbBckPanel.BackgroundImage = Global.UbiSoft.My.Resources.Resources.PnlBckG
        Me.PbBckPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbBckPanel.Image = Global.UbiSoft.My.Resources.Resources.PnlBckG
        Me.PbBckPanel.Location = New System.Drawing.Point(0, 0)
        Me.PbBckPanel.Name = "PbBckPanel"
        Me.PbBckPanel.Size = New System.Drawing.Size(150, 728)
        Me.PbBckPanel.TabIndex = 0
        Me.PbBckPanel.TabStop = False
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
        'PbBackground
        '
        Me.PbBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbBackground.Image = Global.UbiSoft.My.Resources.Resources.background
        Me.PbBackground.Location = New System.Drawing.Point(0, 0)
        Me.PbBackground.Name = "PbBackground"
        Me.PbBackground.Size = New System.Drawing.Size(1024, 768)
        Me.PbBackground.TabIndex = 0
        Me.PbBackground.TabStop = False
        '
        'Elipse1
        '
        Me.Elipse1.ElipseRadius = 25
        Me.Elipse1.TargetControl = Me
        '
        'DragTop
        '
        Me.DragTop.Fixed = True
        Me.DragTop.Horizontal = True
        Me.DragTop.TargetControl = Me.PnlTop
        Me.DragTop.Vertical = True
        '
        'DragSide
        '
        Me.DragSide.Fixed = True
        Me.DragSide.Horizontal = True
        Me.DragSide.TargetControl = Me.PbBckPanel
        Me.DragSide.Vertical = True
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.ActiveBorderThickness = 1
        Me.BtnUsuarios.ActiveCornerRadius = 20
        Me.BtnUsuarios.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnUsuarios.ActiveForecolor = System.Drawing.Color.White
        Me.BtnUsuarios.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.BtnUsuarios.BackgroundImage = CType(resources.GetObject("BtnUsuarios.BackgroundImage"), System.Drawing.Image)
        Me.BtnUsuarios.ButtonText = "Usuarios"
        Me.BtnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUsuarios.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnUsuarios.IdleBorderThickness = 1
        Me.BtnUsuarios.IdleCornerRadius = 20
        Me.BtnUsuarios.IdleFillColor = System.Drawing.Color.Transparent
        Me.BtnUsuarios.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnUsuarios.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnUsuarios.Location = New System.Drawing.Point(5, 59)
        Me.BtnUsuarios.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(137, 46)
        Me.BtnUsuarios.TabIndex = 2
        Me.BtnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnClientes
        '
        Me.BtnClientes.ActiveBorderThickness = 1
        Me.BtnClientes.ActiveCornerRadius = 20
        Me.BtnClientes.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnClientes.ActiveForecolor = System.Drawing.Color.White
        Me.BtnClientes.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnClientes.BackColor = System.Drawing.Color.Transparent
        Me.BtnClientes.BackgroundImage = CType(resources.GetObject("BtnClientes.BackgroundImage"), System.Drawing.Image)
        Me.BtnClientes.ButtonText = "Clientes"
        Me.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClientes.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnClientes.IdleBorderThickness = 1
        Me.BtnClientes.IdleCornerRadius = 20
        Me.BtnClientes.IdleFillColor = System.Drawing.Color.Transparent
        Me.BtnClientes.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnClientes.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnClientes.Location = New System.Drawing.Point(5, 100)
        Me.BtnClientes.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(137, 46)
        Me.BtnClientes.TabIndex = 3
        Me.BtnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnProductos
        '
        Me.BtnProductos.ActiveBorderThickness = 1
        Me.BtnProductos.ActiveCornerRadius = 20
        Me.BtnProductos.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnProductos.ActiveForecolor = System.Drawing.Color.White
        Me.BtnProductos.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnProductos.BackColor = System.Drawing.Color.Transparent
        Me.BtnProductos.BackgroundImage = CType(resources.GetObject("BtnProductos.BackgroundImage"), System.Drawing.Image)
        Me.BtnProductos.ButtonText = "Productos"
        Me.BtnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProductos.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnProductos.IdleBorderThickness = 1
        Me.BtnProductos.IdleCornerRadius = 20
        Me.BtnProductos.IdleFillColor = System.Drawing.Color.Transparent
        Me.BtnProductos.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnProductos.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnProductos.Location = New System.Drawing.Point(5, 141)
        Me.BtnProductos.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.Size = New System.Drawing.Size(137, 46)
        Me.BtnProductos.TabIndex = 4
        Me.BtnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnPrecios
        '
        Me.BtnPrecios.ActiveBorderThickness = 1
        Me.BtnPrecios.ActiveCornerRadius = 20
        Me.BtnPrecios.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnPrecios.ActiveForecolor = System.Drawing.Color.White
        Me.BtnPrecios.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnPrecios.BackColor = System.Drawing.Color.Transparent
        Me.BtnPrecios.BackgroundImage = CType(resources.GetObject("BtnPrecios.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrecios.ButtonText = "Listas Precios"
        Me.BtnPrecios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrecios.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrecios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnPrecios.IdleBorderThickness = 1
        Me.BtnPrecios.IdleCornerRadius = 20
        Me.BtnPrecios.IdleFillColor = System.Drawing.Color.Transparent
        Me.BtnPrecios.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnPrecios.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnPrecios.Location = New System.Drawing.Point(5, 182)
        Me.BtnPrecios.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnPrecios.Name = "BtnPrecios"
        Me.BtnPrecios.Size = New System.Drawing.Size(137, 46)
        Me.BtnPrecios.TabIndex = 5
        Me.BtnPrecios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnMaq
        '
        Me.BtnMaq.ActiveBorderThickness = 1
        Me.BtnMaq.ActiveCornerRadius = 20
        Me.BtnMaq.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnMaq.ActiveForecolor = System.Drawing.Color.White
        Me.BtnMaq.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnMaq.BackColor = System.Drawing.Color.Transparent
        Me.BtnMaq.BackgroundImage = CType(resources.GetObject("BtnMaq.BackgroundImage"), System.Drawing.Image)
        Me.BtnMaq.ButtonText = "Maquinaria"
        Me.BtnMaq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaq.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMaq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnMaq.IdleBorderThickness = 1
        Me.BtnMaq.IdleCornerRadius = 20
        Me.BtnMaq.IdleFillColor = System.Drawing.Color.Transparent
        Me.BtnMaq.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnMaq.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnMaq.Location = New System.Drawing.Point(5, 223)
        Me.BtnMaq.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnMaq.Name = "BtnMaq"
        Me.BtnMaq.Size = New System.Drawing.Size(137, 46)
        Me.BtnMaq.TabIndex = 6
        Me.BtnMaq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAutos
        '
        Me.BtnAutos.ActiveBorderThickness = 1
        Me.BtnAutos.ActiveCornerRadius = 20
        Me.BtnAutos.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnAutos.ActiveForecolor = System.Drawing.Color.White
        Me.BtnAutos.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BtnAutos.BackColor = System.Drawing.Color.Transparent
        Me.BtnAutos.BackgroundImage = CType(resources.GetObject("BtnAutos.BackgroundImage"), System.Drawing.Image)
        Me.BtnAutos.ButtonText = "Vehículos"
        Me.BtnAutos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAutos.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAutos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnAutos.IdleBorderThickness = 1
        Me.BtnAutos.IdleCornerRadius = 20
        Me.BtnAutos.IdleFillColor = System.Drawing.Color.Transparent
        Me.BtnAutos.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnAutos.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnAutos.Location = New System.Drawing.Point(5, 264)
        Me.BtnAutos.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnAutos.Name = "BtnAutos"
        Me.BtnAutos.Size = New System.Drawing.Size(137, 46)
        Me.BtnAutos.TabIndex = 7
        Me.BtnAutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ScrConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.PnlWrapp)
        Me.Controls.Add(Me.PnlSide)
        Me.Controls.Add(Me.PnlTop)
        Me.Controls.Add(Me.PbBackground)
        Me.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScrConfig"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        Me.PnlCtrl.ResumeLayout(False)
        Me.PnlSide.ResumeLayout(False)
        Me.PnlMenu.ResumeLayout(False)
        CType(Me.PbMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbBckPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbLogoMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PbBackground As PictureBox
    Friend WithEvents PnlTop As Panel
    Friend WithEvents PnlCtrl As Panel
    Friend WithEvents PbMin As PictureBox
    Friend WithEvents PbClose As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PbLogoMin As PictureBox
    Friend WithEvents PbMax As PictureBox
    Friend WithEvents PnlSide As Panel
    Friend WithEvents PbBckPanel As PictureBox
    Friend WithEvents PnlWrapp As Panel
    Friend WithEvents PnlMenu As Panel
    Friend WithEvents PbMenu As PictureBox
    Friend WithEvents Elipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents DragTop As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents DragSide As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BtnUsuarios As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnClientes As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnProductos As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnPrecios As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnAutos As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnMaq As Bunifu.Framework.UI.BunifuThinButton2
End Class
