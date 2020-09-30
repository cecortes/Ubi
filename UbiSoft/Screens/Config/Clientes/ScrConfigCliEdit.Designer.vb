<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrConfigCliEdit
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
        Me.CboRfcEdit = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlData = New System.Windows.Forms.Panel()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.TxtEdoEdit = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCiudadEdit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDirEdit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTelEdit = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtContactoEdit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMailEdit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtRazonEdit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtRfcEdit = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PnlTop.SuspendLayout()
        Me.PnlData.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.Transparent
        Me.PnlTop.Controls.Add(Me.CboRfcEdit)
        Me.PnlTop.Controls.Add(Me.Label1)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(984, 150)
        Me.PnlTop.TabIndex = 0
        '
        'CboRfcEdit
        '
        Me.CboRfcEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CboRfcEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CboRfcEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboRfcEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CboRfcEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboRfcEdit.FormattingEnabled = True
        Me.CboRfcEdit.Location = New System.Drawing.Point(352, 37)
        Me.CboRfcEdit.Name = "CboRfcEdit"
        Me.CboRfcEdit.Size = New System.Drawing.Size(300, 31)
        Me.CboRfcEdit.TabIndex = 24
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
        Me.PnlData.Controls.Add(Me.TxtEdoEdit)
        Me.PnlData.Controls.Add(Me.Label8)
        Me.PnlData.Controls.Add(Me.TxtCiudadEdit)
        Me.PnlData.Controls.Add(Me.Label7)
        Me.PnlData.Controls.Add(Me.TxtDirEdit)
        Me.PnlData.Controls.Add(Me.Label6)
        Me.PnlData.Controls.Add(Me.TxtTelEdit)
        Me.PnlData.Controls.Add(Me.Label5)
        Me.PnlData.Controls.Add(Me.TxtContactoEdit)
        Me.PnlData.Controls.Add(Me.Label4)
        Me.PnlData.Controls.Add(Me.TxtMailEdit)
        Me.PnlData.Controls.Add(Me.Label3)
        Me.PnlData.Controls.Add(Me.TxtRazonEdit)
        Me.PnlData.Controls.Add(Me.Label2)
        Me.PnlData.Controls.Add(Me.TxtRfcEdit)
        Me.PnlData.Controls.Add(Me.Label9)
        Me.PnlData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlData.Location = New System.Drawing.Point(0, 150)
        Me.PnlData.Name = "PnlData"
        Me.PnlData.Size = New System.Drawing.Size(984, 513)
        Me.PnlData.TabIndex = 1
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
        'TxtEdoEdit
        '
        Me.TxtEdoEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEdoEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtEdoEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEdoEdit.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtEdoEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtEdoEdit.Location = New System.Drawing.Point(550, 199)
        Me.TxtEdoEdit.Name = "TxtEdoEdit"
        Me.TxtEdoEdit.Size = New System.Drawing.Size(169, 31)
        Me.TxtEdoEdit.TabIndex = 17
        Me.TxtEdoEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'TxtCiudadEdit
        '
        Me.TxtCiudadEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtCiudadEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCiudadEdit.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtCiudadEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtCiudadEdit.Location = New System.Drawing.Point(94, 199)
        Me.TxtCiudadEdit.Name = "TxtCiudadEdit"
        Me.TxtCiudadEdit.Size = New System.Drawing.Size(220, 31)
        Me.TxtCiudadEdit.TabIndex = 15
        Me.TxtCiudadEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'TxtDirEdit
        '
        Me.TxtDirEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDirEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtDirEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDirEdit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDirEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtDirEdit.Location = New System.Drawing.Point(550, 136)
        Me.TxtDirEdit.MaxLength = 100
        Me.TxtDirEdit.Name = "TxtDirEdit"
        Me.TxtDirEdit.Size = New System.Drawing.Size(403, 31)
        Me.TxtDirEdit.TabIndex = 13
        Me.TxtDirEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'TxtTelEdit
        '
        Me.TxtTelEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtTelEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtTelEdit.Location = New System.Drawing.Point(94, 136)
        Me.TxtTelEdit.Mask = "(999)000-0000"
        Me.TxtTelEdit.Name = "TxtTelEdit"
        Me.TxtTelEdit.PromptChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.TxtTelEdit.Size = New System.Drawing.Size(220, 31)
        Me.TxtTelEdit.TabIndex = 11
        Me.TxtTelEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'TxtContactoEdit
        '
        Me.TxtContactoEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtContactoEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtContactoEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtContactoEdit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtContactoEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtContactoEdit.Location = New System.Drawing.Point(550, 73)
        Me.TxtContactoEdit.MaxLength = 100
        Me.TxtContactoEdit.Name = "TxtContactoEdit"
        Me.TxtContactoEdit.Size = New System.Drawing.Size(403, 31)
        Me.TxtContactoEdit.TabIndex = 9
        Me.TxtContactoEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'TxtMailEdit
        '
        Me.TxtMailEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtMailEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMailEdit.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtMailEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtMailEdit.Location = New System.Drawing.Point(94, 73)
        Me.TxtMailEdit.Name = "TxtMailEdit"
        Me.TxtMailEdit.Size = New System.Drawing.Size(220, 31)
        Me.TxtMailEdit.TabIndex = 7
        Me.TxtMailEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'TxtRazonEdit
        '
        Me.TxtRazonEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRazonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtRazonEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRazonEdit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRazonEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtRazonEdit.Location = New System.Drawing.Point(550, 12)
        Me.TxtRazonEdit.MaxLength = 100
        Me.TxtRazonEdit.Name = "TxtRazonEdit"
        Me.TxtRazonEdit.Size = New System.Drawing.Size(403, 31)
        Me.TxtRazonEdit.TabIndex = 5
        Me.TxtRazonEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'TxtRfcEdit
        '
        Me.TxtRfcEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TxtRfcEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRfcEdit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRfcEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtRfcEdit.Location = New System.Drawing.Point(94, 12)
        Me.TxtRfcEdit.MaxLength = 13
        Me.TxtRfcEdit.Name = "TxtRfcEdit"
        Me.TxtRfcEdit.Size = New System.Drawing.Size(180, 31)
        Me.TxtRfcEdit.TabIndex = 3
        Me.TxtRfcEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'ScrConfigCliEdit
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
        Me.Name = "ScrConfigCliEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrConfigCliEdit"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        Me.PnlData.ResumeLayout(False)
        Me.PnlData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CboRfcEdit As ComboBox
    Friend WithEvents PnlData As Panel
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents TxtEdoEdit As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtCiudadEdit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDirEdit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTelEdit As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtContactoEdit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtMailEdit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtRazonEdit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtRfcEdit As TextBox
    Friend WithEvents Label9 As Label
End Class
