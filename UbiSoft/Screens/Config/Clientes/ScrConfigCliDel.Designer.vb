<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrConfigCliDel
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
        Me.CboRfcDel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlData = New System.Windows.Forms.Panel()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.TxtEdoDel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCiudadDel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDirDel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTelDel = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtContactoDel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMailDel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtRazonDel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtRfcDel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PnlTop.SuspendLayout()
        Me.PnlData.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.Transparent
        Me.PnlTop.Controls.Add(Me.CboRfcDel)
        Me.PnlTop.Controls.Add(Me.Label1)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(984, 150)
        Me.PnlTop.TabIndex = 1
        '
        'CboRfcDel
        '
        Me.CboRfcDel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CboRfcDel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CboRfcDel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboRfcDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboRfcDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboRfcDel.FormattingEnabled = True
        Me.CboRfcDel.Location = New System.Drawing.Point(352, 37)
        Me.CboRfcDel.Name = "CboRfcDel"
        Me.CboRfcDel.Size = New System.Drawing.Size(300, 31)
        Me.CboRfcDel.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(303, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Rfc:"
        '
        'PnlData
        '
        Me.PnlData.BackColor = System.Drawing.Color.Transparent
        Me.PnlData.Controls.Add(Me.BtnOk)
        Me.PnlData.Controls.Add(Me.BtnClear)
        Me.PnlData.Controls.Add(Me.TxtEdoDel)
        Me.PnlData.Controls.Add(Me.Label8)
        Me.PnlData.Controls.Add(Me.TxtCiudadDel)
        Me.PnlData.Controls.Add(Me.Label7)
        Me.PnlData.Controls.Add(Me.TxtDirDel)
        Me.PnlData.Controls.Add(Me.Label6)
        Me.PnlData.Controls.Add(Me.TxtTelDel)
        Me.PnlData.Controls.Add(Me.Label5)
        Me.PnlData.Controls.Add(Me.TxtContactoDel)
        Me.PnlData.Controls.Add(Me.Label4)
        Me.PnlData.Controls.Add(Me.TxtMailDel)
        Me.PnlData.Controls.Add(Me.Label3)
        Me.PnlData.Controls.Add(Me.TxtRazonDel)
        Me.PnlData.Controls.Add(Me.Label2)
        Me.PnlData.Controls.Add(Me.TxtRfcDel)
        Me.PnlData.Controls.Add(Me.Label9)
        Me.PnlData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlData.Location = New System.Drawing.Point(0, 150)
        Me.PnlData.Name = "PnlData"
        Me.PnlData.Size = New System.Drawing.Size(984, 513)
        Me.PnlData.TabIndex = 2
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnOk.Image = Global.UbiSoft.My.Resources.Resources.ok32
        Me.BtnOk.Location = New System.Drawing.Point(893, 437)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(60, 60)
        Me.BtnOk.TabIndex = 18
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
        Me.BtnClear.Location = New System.Drawing.Point(19, 437)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(60, 60)
        Me.BtnClear.TabIndex = 19
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'TxtEdoDel
        '
        Me.TxtEdoDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEdoDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtEdoDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEdoDel.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtEdoDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtEdoDel.Location = New System.Drawing.Point(550, 199)
        Me.TxtEdoDel.Name = "TxtEdoDel"
        Me.TxtEdoDel.Size = New System.Drawing.Size(169, 31)
        Me.TxtEdoDel.TabIndex = 17
        Me.TxtEdoDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(469, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 28)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Estado:"
        '
        'TxtCiudadDel
        '
        Me.TxtCiudadDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtCiudadDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCiudadDel.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtCiudadDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtCiudadDel.Location = New System.Drawing.Point(94, 199)
        Me.TxtCiudadDel.Name = "TxtCiudadDel"
        Me.TxtCiudadDel.Size = New System.Drawing.Size(220, 31)
        Me.TxtCiudadDel.TabIndex = 15
        Me.TxtCiudadDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 28)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Ciudad:"
        '
        'TxtDirDel
        '
        Me.TxtDirDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDirDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtDirDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDirDel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDirDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtDirDel.Location = New System.Drawing.Point(550, 136)
        Me.TxtDirDel.MaxLength = 100
        Me.TxtDirDel.Name = "TxtDirDel"
        Me.TxtDirDel.Size = New System.Drawing.Size(403, 31)
        Me.TxtDirDel.TabIndex = 13
        Me.TxtDirDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(448, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 28)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Dirección:"
        '
        'TxtTelDel
        '
        Me.TxtTelDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtTelDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtTelDel.Location = New System.Drawing.Point(94, 136)
        Me.TxtTelDel.Mask = "(999)000-0000"
        Me.TxtTelDel.Name = "TxtTelDel"
        Me.TxtTelDel.PromptChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.TxtTelDel.Size = New System.Drawing.Size(220, 31)
        Me.TxtTelDel.TabIndex = 11
        Me.TxtTelDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(14, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 28)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tel:"
        '
        'TxtContactoDel
        '
        Me.TxtContactoDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtContactoDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtContactoDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtContactoDel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtContactoDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtContactoDel.Location = New System.Drawing.Point(550, 73)
        Me.TxtContactoDel.MaxLength = 100
        Me.TxtContactoDel.Name = "TxtContactoDel"
        Me.TxtContactoDel.Size = New System.Drawing.Size(403, 31)
        Me.TxtContactoDel.TabIndex = 9
        Me.TxtContactoDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(448, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 28)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Contacto:"
        '
        'TxtMailDel
        '
        Me.TxtMailDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtMailDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMailDel.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtMailDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtMailDel.Location = New System.Drawing.Point(94, 73)
        Me.TxtMailDel.Name = "TxtMailDel"
        Me.TxtMailDel.Size = New System.Drawing.Size(220, 31)
        Me.TxtMailDel.TabIndex = 7
        Me.TxtMailDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Correo:"
        '
        'TxtRazonDel
        '
        Me.TxtRazonDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRazonDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtRazonDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRazonDel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRazonDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtRazonDel.Location = New System.Drawing.Point(550, 12)
        Me.TxtRazonDel.MaxLength = 100
        Me.TxtRazonDel.Name = "TxtRazonDel"
        Me.TxtRazonDel.Size = New System.Drawing.Size(403, 31)
        Me.TxtRazonDel.TabIndex = 5
        Me.TxtRazonDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(417, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Razón Social:"
        '
        'TxtRfcDel
        '
        Me.TxtRfcDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtRfcDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRfcDel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRfcDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtRfcDel.Location = New System.Drawing.Point(94, 12)
        Me.TxtRfcDel.MaxLength = 13
        Me.TxtRfcDel.Name = "TxtRfcDel"
        Me.TxtRfcDel.Size = New System.Drawing.Size(180, 31)
        Me.TxtRfcDel.TabIndex = 3
        Me.TxtRfcDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 28)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Rfc:"
        '
        'ScrConfigCliDel
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
        Me.Name = "ScrConfigCliDel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrConfigCliDel"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        Me.PnlData.ResumeLayout(False)
        Me.PnlData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents CboRfcDel As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PnlData As Panel
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents TxtEdoDel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtCiudadDel As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDirDel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTelDel As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtContactoDel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtMailDel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtRazonDel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtRfcDel As TextBox
    Friend WithEvents Label9 As Label
End Class
