<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrConfigInvDel
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
        Me.DgvInv = New System.Windows.Forms.DataGridView()
        Me.PnlBottom = New System.Windows.Forms.Panel()
        Me.BtnDevice = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.TxtTag = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtCom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtInt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PbFoto = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PnlTop.SuspendLayout()
        CType(Me.DgvInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBottom.SuspendLayout()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.Transparent
        Me.PnlTop.Controls.Add(Me.DgvInv)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(984, 417)
        Me.PnlTop.TabIndex = 3
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
        Me.DgvInv.Size = New System.Drawing.Size(960, 384)
        Me.DgvInv.TabIndex = 1
        '
        'PnlBottom
        '
        Me.PnlBottom.BackColor = System.Drawing.Color.Transparent
        Me.PnlBottom.Controls.Add(Me.BtnDevice)
        Me.PnlBottom.Controls.Add(Me.BtnOk)
        Me.PnlBottom.Controls.Add(Me.BtnClear)
        Me.PnlBottom.Controls.Add(Me.TxtTag)
        Me.PnlBottom.Controls.Add(Me.Label11)
        Me.PnlBottom.Controls.Add(Me.TxtCom)
        Me.PnlBottom.Controls.Add(Me.Label3)
        Me.PnlBottom.Controls.Add(Me.TxtInt)
        Me.PnlBottom.Controls.Add(Me.Label1)
        Me.PnlBottom.Controls.Add(Me.PbFoto)
        Me.PnlBottom.Controls.Add(Me.Label2)
        Me.PnlBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlBottom.Location = New System.Drawing.Point(0, 417)
        Me.PnlBottom.Name = "PnlBottom"
        Me.PnlBottom.Size = New System.Drawing.Size(984, 246)
        Me.PnlBottom.TabIndex = 4
        '
        'BtnDevice
        '
        Me.BtnDevice.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnDevice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDevice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnDevice.FlatAppearance.BorderSize = 2
        Me.BtnDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDevice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnDevice.Image = Global.UbiSoft.My.Resources.Resources.rfid
        Me.BtnDevice.Location = New System.Drawing.Point(542, 101)
        Me.BtnDevice.Name = "BtnDevice"
        Me.BtnDevice.Size = New System.Drawing.Size(60, 60)
        Me.BtnDevice.TabIndex = 50
        Me.BtnDevice.UseVisualStyleBackColor = False
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Image = Global.UbiSoft.My.Resources.Resources.ok32
        Me.BtnOk.Location = New System.Drawing.Point(542, 167)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(60, 60)
        Me.BtnOk.TabIndex = 49
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnClear.Image = Global.UbiSoft.My.Resources.Resources.borrar
        Me.BtnClear.Location = New System.Drawing.Point(542, 35)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(60, 60)
        Me.BtnClear.TabIndex = 48
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'TxtTag
        '
        Me.TxtTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtTag.Location = New System.Drawing.Point(344, 187)
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
        Me.Label11.Location = New System.Drawing.Point(237, 184)
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
        Me.TxtCom.Location = New System.Drawing.Point(344, 113)
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
        Me.Label3.Location = New System.Drawing.Point(235, 110)
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
        Me.TxtInt.Location = New System.Drawing.Point(344, 38)
        Me.TxtInt.MaxLength = 100
        Me.TxtInt.Name = "TxtInt"
        Me.TxtInt.Size = New System.Drawing.Size(140, 31)
        Me.TxtInt.TabIndex = 35
        Me.TxtInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(237, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 28)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Interno:"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 28)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Foto:"
        '
        'ScrConfigInvDel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BackgroundImage = Global.UbiSoft.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 663)
        Me.Controls.Add(Me.PnlBottom)
        Me.Controls.Add(Me.PnlTop)
        Me.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrConfigInvDel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrConfigInvDel"
        Me.PnlTop.ResumeLayout(False)
        CType(Me.DgvInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBottom.ResumeLayout(False)
        Me.PnlBottom.PerformLayout()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents DgvInv As DataGridView
    Friend WithEvents PnlBottom As Panel
    Friend WithEvents BtnDevice As Button
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents TxtTag As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtCom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtInt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PbFoto As PictureBox
    Friend WithEvents Label2 As Label
End Class
