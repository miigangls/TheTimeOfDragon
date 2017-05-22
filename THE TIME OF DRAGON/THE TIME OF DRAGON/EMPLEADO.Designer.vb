<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMPLEADO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EMPLEADO))
        Dim PaintStyle5 As Klik.Windows.Forms.v1.Common.PaintStyle = New Klik.Windows.Forms.v1.Common.PaintStyle
        Me.ACEPTAR = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTN_ACEPTAR = New System.Windows.Forms.PictureBox
        Me.BTN_SALIR = New System.Windows.Forms.PictureBox
        Me.ATRAS = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTN_ATRAS = New System.Windows.Forms.PictureBox
        Me.SALIR = New System.Windows.Forms.ToolTip(Me.components)
        Me.AYUDA = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTN_AYUDA = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXT_codigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ElLabel1 = New Klik.Windows.Forms.v1.EntryLib.ELLabel
        Me.TXT_USUARIO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BTN_ACEPTAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_SALIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_ATRAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_AYUDA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ElLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_ACEPTAR
        '
        Me.BTN_ACEPTAR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ACEPTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ACEPTAR.Image = CType(resources.GetObject("BTN_ACEPTAR.Image"), System.Drawing.Image)
        Me.BTN_ACEPTAR.Location = New System.Drawing.Point(81, 406)
        Me.BTN_ACEPTAR.Name = "BTN_ACEPTAR"
        Me.BTN_ACEPTAR.Size = New System.Drawing.Size(43, 41)
        Me.BTN_ACEPTAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTN_ACEPTAR.TabIndex = 34
        Me.BTN_ACEPTAR.TabStop = False
        Me.ACEPTAR.SetToolTip(Me.BTN_ACEPTAR, "Aceptar")
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_SALIR.Image = CType(resources.GetObject("BTN_SALIR.Image"), System.Drawing.Image)
        Me.BTN_SALIR.Location = New System.Drawing.Point(145, 406)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(43, 41)
        Me.BTN_SALIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTN_SALIR.TabIndex = 38
        Me.BTN_SALIR.TabStop = False
        Me.SALIR.SetToolTip(Me.BTN_SALIR, "Salir")
        '
        'BTN_ATRAS
        '
        Me.BTN_ATRAS.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.Anterior
        Me.BTN_ATRAS.Location = New System.Drawing.Point(6, 11)
        Me.BTN_ATRAS.Name = "BTN_ATRAS"
        Me.BTN_ATRAS.Size = New System.Drawing.Size(40, 41)
        Me.BTN_ATRAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_ATRAS.TabIndex = 36
        Me.BTN_ATRAS.TabStop = False
        Me.ATRAS.SetToolTip(Me.BTN_ATRAS, "Atras")
        '
        'AYUDA
        '
        Me.AYUDA.BackColor = System.Drawing.Color.Transparent
        '
        'BTN_AYUDA
        '
        Me.BTN_AYUDA.Image = CType(resources.GetObject("BTN_AYUDA.Image"), System.Drawing.Image)
        Me.BTN_AYUDA.Location = New System.Drawing.Point(219, 11)
        Me.BTN_AYUDA.Name = "BTN_AYUDA"
        Me.BTN_AYUDA.Size = New System.Drawing.Size(47, 49)
        Me.BTN_AYUDA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_AYUDA.TabIndex = 37
        Me.BTN_AYUDA.TabStop = False
        Me.AYUDA.SetToolTip(Me.BTN_AYUDA, "Ayuda")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "INGRESE EL CODIGO"
        '
        'TXT_codigo
        '
        Me.TXT_codigo.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_codigo.Location = New System.Drawing.Point(48, 353)
        Me.TXT_codigo.Name = "TXT_codigo"
        Me.TXT_codigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_codigo.Size = New System.Drawing.Size(181, 24)
        Me.TXT_codigo.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 15)
        Me.Label2.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Calligraphy", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(98, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "CARGO"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SECCION CAJA", "ATENCION AL CLIENTE", "SUPERVISOR "})
        Me.ComboBox1.Location = New System.Drawing.Point(27, 101)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(220, 25)
        Me.ComboBox1.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ElLabel1)
        Me.GroupBox1.Controls.Add(Me.TXT_USUARIO)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BTN_SALIR)
        Me.GroupBox1.Controls.Add(Me.BTN_AYUDA)
        Me.GroupBox1.Controls.Add(Me.BTN_ATRAS)
        Me.GroupBox1.Controls.Add(Me.BTN_ACEPTAR)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_codigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 203)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 489)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 18)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 489)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Label5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(78, 461)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 18)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Label5"
        '
        'ElLabel1
        '
        PaintStyle5.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        PaintStyle5.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElLabel1.FlashStyle = PaintStyle5
        Me.ElLabel1.Location = New System.Drawing.Point(32247, 32573)
        Me.ElLabel1.Name = "ElLabel1"
        Me.ElLabel1.Size = New System.Drawing.Size(75, 23)
        Me.ElLabel1.TabIndex = 63
        Me.ElLabel1.TabStop = False
        Me.ElLabel1.TextStyle.Text = "ElLabel1"
        '
        'TXT_USUARIO
        '
        Me.TXT_USUARIO.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_USUARIO.Location = New System.Drawing.Point(48, 278)
        Me.TXT_USUARIO.Name = "TXT_USUARIO"
        Me.TXT_USUARIO.Size = New System.Drawing.Size(178, 24)
        Me.TXT_USUARIO.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(99, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "USUARIO"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox2.Location = New System.Drawing.Point(68, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(135, 120)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'EMPLEADO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.FORMULARIO81
        Me.ClientSize = New System.Drawing.Size(293, 241)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EMPLEADO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMPLEADO"
        Me.TopMost = True
        CType(Me.BTN_ACEPTAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_SALIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_ATRAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_AYUDA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ElLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ACEPTAR As System.Windows.Forms.ToolTip
    Friend WithEvents ATRAS As System.Windows.Forms.ToolTip
    Friend WithEvents SALIR As System.Windows.Forms.ToolTip
    Friend WithEvents AYUDA As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_ACEPTAR As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_ATRAS As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_AYUDA As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_SALIR As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TXT_USUARIO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ElLabel1 As Klik.Windows.Forms.v1.EntryLib.ELLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
