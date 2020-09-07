<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PbLogin = New System.Windows.Forms.PictureBox()
        Me.txtUsr = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtPass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnCancel = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnAceptar = New Bunifu.Framework.UI.BunifuTileButton()
        CType(Me.PbLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 100
        Me.BunifuElipse1.TargetControl = Me.PbLogin
        '
        'PbLogin
        '
        Me.PbLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbLogin.Image = Global.UbiSoft.My.Resources.Resources.Login
        Me.PbLogin.Location = New System.Drawing.Point(0, 0)
        Me.PbLogin.Name = "PbLogin"
        Me.PbLogin.Size = New System.Drawing.Size(500, 600)
        Me.PbLogin.TabIndex = 0
        Me.PbLogin.TabStop = False
        '
        'txtUsr
        '
        Me.txtUsr.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtUsr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsr.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUsr.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUsr.HintText = "Correo electrónico"
        Me.txtUsr.isPassword = False
        Me.txtUsr.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUsr.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtUsr.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUsr.LineThickness = 3
        Me.txtUsr.Location = New System.Drawing.Point(50, 244)
        Me.txtUsr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsr.Name = "txtUsr"
        Me.txtUsr.Size = New System.Drawing.Size(379, 38)
        Me.txtUsr.TabIndex = 1
        Me.txtUsr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtPass.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtPass.HintText = "Contraseña"
        Me.txtPass.isPassword = True
        Me.txtPass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtPass.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtPass.LineThickness = 3
        Me.txtPass.Location = New System.Drawing.Point(50, 355)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(379, 38)
        Me.txtPass.TabIndex = 2
        Me.txtPass.Text = "1234"
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnCancel.color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnCancel.colorActive = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Ebrima", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnCancel.Image = Global.UbiSoft.My.Resources.Resources.cancelado
        Me.btnCancel.ImagePosition = 4
        Me.btnCancel.ImageZoom = 40
        Me.btnCancel.LabelPosition = 27
        Me.btnCancel.LabelText = "Cancelar"
        Me.btnCancel.Location = New System.Drawing.Point(338, 461)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 64)
        Me.btnCancel.TabIndex = 4
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnAceptar.color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnAceptar.colorActive = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnAceptar.Image = Global.UbiSoft.My.Resources.Resources.ok
        Me.btnAceptar.ImagePosition = 5
        Me.btnAceptar.ImageZoom = 40
        Me.btnAceptar.LabelPosition = 30
        Me.btnAceptar.LabelText = "Aceptar"
        Me.btnAceptar.Location = New System.Drawing.Point(50, 461)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(81, 64)
        Me.btnAceptar.TabIndex = 3
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(500, 600)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUsr)
        Me.Controls.Add(Me.PbLogin)
        Me.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.Gray
        CType(Me.PbLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PbLogin As PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtUsr As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtPass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnAceptar As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnCancel As Bunifu.Framework.UI.BunifuTileButton
End Class
