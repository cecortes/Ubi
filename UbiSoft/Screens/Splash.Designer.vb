<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Me.TmrStart = New System.Windows.Forms.Timer(Me.components)
        Me.PbLogo = New System.Windows.Forms.PictureBox()
        Me.ProgBar = New Bunifu.Framework.UI.BunifuProgressBar()
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TmrStart
        '
        Me.TmrStart.Enabled = True
        Me.TmrStart.Interval = 1000
        '
        'PbLogo
        '
        Me.PbLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbLogo.Image = Global.UbiSoft.My.Resources.Resources.splash
        Me.PbLogo.Location = New System.Drawing.Point(0, 0)
        Me.PbLogo.Name = "PbLogo"
        Me.PbLogo.Size = New System.Drawing.Size(1024, 768)
        Me.PbLogo.TabIndex = 0
        Me.PbLogo.TabStop = False
        '
        'ProgBar
        '
        Me.ProgBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ProgBar.BorderRadius = 5
        Me.ProgBar.Location = New System.Drawing.Point(13, 622)
        Me.ProgBar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ProgBar.MaximumValue = 100
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ProgBar.Size = New System.Drawing.Size(998, 12)
        Me.ProgBar.TabIndex = 1
        Me.ProgBar.Value = 0
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.ProgBar)
        Me.Controls.Add(Me.PbLogo)
        Me.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Gray
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PbLogo As PictureBox
    Friend WithEvents TmrStart As Timer
    Friend WithEvents ProgBar As Bunifu.Framework.UI.BunifuProgressBar
End Class
