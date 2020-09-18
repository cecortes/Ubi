<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrCfgUsr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScrCfgUsr))
        Me.PnlOpt = New System.Windows.Forms.Panel()
        Me.BtnDel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnEdit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnNew = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PnlWrp = New System.Windows.Forms.Panel()
        Me.PnlOpt.SuspendLayout()
        Me.SuspendLayout()
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
        Me.PnlOpt.TabIndex = 1
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
        'PnlWrp
        '
        Me.PnlWrp.BackColor = System.Drawing.Color.Transparent
        Me.PnlWrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlWrp.Location = New System.Drawing.Point(0, 65)
        Me.PnlWrp.Name = "PnlWrp"
        Me.PnlWrp.Size = New System.Drawing.Size(984, 663)
        Me.PnlWrp.TabIndex = 2
        '
        'ScrCfgUsr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 728)
        Me.Controls.Add(Me.PnlWrp)
        Me.Controls.Add(Me.PnlOpt)
        Me.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrCfgUsr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrCfgUsr"
        Me.PnlOpt.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlOpt As Panel
    Friend WithEvents BtnDel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnEdit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnNew As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PnlWrp As Panel
End Class
