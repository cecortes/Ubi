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
        Me.PbLogin = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.txtUsr = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtPass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        CType(Me.PbLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 100
        Me.BunifuElipse1.TargetControl = Me.PbLogin
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
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(500, 600)
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
End Class
