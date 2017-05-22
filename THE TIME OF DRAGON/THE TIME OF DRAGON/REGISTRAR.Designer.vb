<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REGISTRAR
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REGISTRAR))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btn_actualizar_usurio = New System.Windows.Forms.PictureBox
        Me.btn_actualizar_contr = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.CNX_CARGO = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BTN_ACEPTAR = New System.Windows.Forms.PictureBox
        Me.BTN_SALIR = New System.Windows.Forms.PictureBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXT_NOMBRE_USUSRIO = New System.Windows.Forms.TextBox
        Me.TXT_CONTRASEÑA_USURIO = New System.Windows.Forms.TextBox
        Me.ACEPTAR = New System.Windows.Forms.ToolTip(Me.components)
        Me.SALIR = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_actualizar_usurio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_actualizar_contr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_ACEPTAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_SALIR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.CNX_CARGO)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BTN_ACEPTAR)
        Me.GroupBox1.Controls.Add(Me.BTN_SALIR)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_NOMBRE_USUSRIO)
        Me.GroupBox1.Controls.Add(Me.TXT_CONTRASEÑA_USURIO)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 263)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.FORMULARIO_2
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Location = New System.Drawing.Point(18, 335)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 244)
        Me.Panel1.TabIndex = 70
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.btn_actualizar_usurio)
        Me.GroupBox2.Controls.Add(Me.btn_actualizar_contr)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 222)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.SALIR1
        Me.PictureBox1.Location = New System.Drawing.Point(211, 163)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'btn_actualizar_usurio
        '
        Me.btn_actualizar_usurio.BackColor = System.Drawing.Color.Transparent
        Me.btn_actualizar_usurio.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.Ok_2
        Me.btn_actualizar_usurio.Location = New System.Drawing.Point(142, 163)
        Me.btn_actualizar_usurio.Name = "btn_actualizar_usurio"
        Me.btn_actualizar_usurio.Size = New System.Drawing.Size(43, 41)
        Me.btn_actualizar_usurio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_actualizar_usurio.TabIndex = 74
        Me.btn_actualizar_usurio.TabStop = False
        '
        'btn_actualizar_contr
        '
        Me.btn_actualizar_contr.BackColor = System.Drawing.Color.Transparent
        Me.btn_actualizar_contr.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.Ok_2
        Me.btn_actualizar_contr.Location = New System.Drawing.Point(93, 163)
        Me.btn_actualizar_contr.Name = "btn_actualizar_contr"
        Me.btn_actualizar_contr.Size = New System.Drawing.Size(43, 41)
        Me.btn_actualizar_contr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_actualizar_contr.TabIndex = 73
        Me.btn_actualizar_contr.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(29, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Usuario Nuevo"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(178, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 20)
        Me.TextBox1.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Contraceña nueva"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(178, 140)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(166, 20)
        Me.TextBox4.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(52, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 17)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Contraceña"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(52, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Usuario"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(178, 20)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(166, 20)
        Me.TextBox2.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(178, 62)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(166, 20)
        Me.TextBox3.TabIndex = 1
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(102, 171)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(217, 17)
        Me.LinkLabel2.TabIndex = 75
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "A olvidado su Nombre Usurio"
        '
        'CNX_CARGO
        '
        Me.CNX_CARGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CNX_CARGO.FormattingEnabled = True
        Me.CNX_CARGO.Items.AddRange(New Object() {"ADMINISTRADOR"})
        Me.CNX_CARGO.Location = New System.Drawing.Point(128, 107)
        Me.CNX_CARGO.Name = "CNX_CARGO"
        Me.CNX_CARGO.Size = New System.Drawing.Size(166, 21)
        Me.CNX_CARGO.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Cargo"
        '
        'BTN_ACEPTAR
        '
        Me.BTN_ACEPTAR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ACEPTAR.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.Ok_2
        Me.BTN_ACEPTAR.Location = New System.Drawing.Point(133, 191)
        Me.BTN_ACEPTAR.Name = "BTN_ACEPTAR"
        Me.BTN_ACEPTAR.Size = New System.Drawing.Size(43, 41)
        Me.BTN_ACEPTAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_ACEPTAR.TabIndex = 72
        Me.BTN_ACEPTAR.TabStop = False
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SALIR.Image = CType(resources.GetObject("BTN_SALIR.Image"), System.Drawing.Image)
        Me.BTN_SALIR.Location = New System.Drawing.Point(236, 191)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(43, 41)
        Me.BTN_SALIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_SALIR.TabIndex = 71
        Me.BTN_SALIR.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(116, 143)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(187, 17)
        Me.LinkLabel1.TabIndex = 24
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "A olvidado su contraceña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraceña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario"
        '
        'TXT_NOMBRE_USUSRIO
        '
        Me.TXT_NOMBRE_USUSRIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOMBRE_USUSRIO.Location = New System.Drawing.Point(128, 28)
        Me.TXT_NOMBRE_USUSRIO.Name = "TXT_NOMBRE_USUSRIO"
        Me.TXT_NOMBRE_USUSRIO.Size = New System.Drawing.Size(166, 20)
        Me.TXT_NOMBRE_USUSRIO.TabIndex = 0
        '
        'TXT_CONTRASEÑA_USURIO
        '
        Me.TXT_CONTRASEÑA_USURIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CONTRASEÑA_USURIO.Location = New System.Drawing.Point(128, 63)
        Me.TXT_CONTRASEÑA_USURIO.Name = "TXT_CONTRASEÑA_USURIO"
        Me.TXT_CONTRASEÑA_USURIO.Size = New System.Drawing.Size(166, 20)
        Me.TXT_CONTRASEÑA_USURIO.TabIndex = 1
        '
        'REGISTRAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.ADMINISTRADOR
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(436, 344)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "REGISTRAR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRAR"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_actualizar_usurio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_actualizar_contr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_ACEPTAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_SALIR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_NOMBRE_USUSRIO As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CONTRASEÑA_USURIO As System.Windows.Forms.TextBox
    Friend WithEvents SALIR As System.Windows.Forms.ToolTip
    Friend WithEvents ACEPTAR As System.Windows.Forms.ToolTip
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents BTN_SALIR As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_ACEPTAR As System.Windows.Forms.PictureBox
    Friend WithEvents CNX_CARGO As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents btn_actualizar_contr As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_actualizar_usurio As System.Windows.Forms.PictureBox
End Class
