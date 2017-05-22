<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUPERVISOR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SUPERVISOR))
        Me.AYUDA = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTN_AYUDA = New System.Windows.Forms.PictureBox
        Me.CANCELAR = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTN_SALIR = New System.Windows.Forms.PictureBox
        Me.BTN_ATRAS = New System.Windows.Forms.PictureBox
        Me.ATRAS = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BTN_MUSICA = New System.Windows.Forms.PictureBox
        Me.BTN_JUEGOS = New System.Windows.Forms.PictureBox
        Me.BTN_FACTURA = New System.Windows.Forms.PictureBox
        Me.JUEGOS = New System.Windows.Forms.Panel
        Me.BTN_SALIR_JUEGOS = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        CType(Me.BTN_AYUDA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_SALIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_ATRAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_MUSICA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_JUEGOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_FACTURA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JUEGOS.SuspendLayout()
        CType(Me.BTN_SALIR_JUEGOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_AYUDA
        '
        Me.BTN_AYUDA.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AYUDA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_AYUDA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_AYUDA.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.AYUDA1
        Me.BTN_AYUDA.Location = New System.Drawing.Point(737, 18)
        Me.BTN_AYUDA.Name = "BTN_AYUDA"
        Me.BTN_AYUDA.Size = New System.Drawing.Size(46, 46)
        Me.BTN_AYUDA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_AYUDA.TabIndex = 78
        Me.BTN_AYUDA.TabStop = False
        Me.AYUDA.SetToolTip(Me.BTN_AYUDA, "Ayuda")
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_SALIR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_SALIR.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.SALIR1
        Me.BTN_SALIR.Location = New System.Drawing.Point(740, 394)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(43, 41)
        Me.BTN_SALIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_SALIR.TabIndex = 76
        Me.BTN_SALIR.TabStop = False
        Me.CANCELAR.SetToolTip(Me.BTN_SALIR, "Salir")
        '
        'BTN_ATRAS
        '
        Me.BTN_ATRAS.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ATRAS.BackgroundImage = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.Anterior
        Me.BTN_ATRAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ATRAS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ATRAS.Location = New System.Drawing.Point(15, 394)
        Me.BTN_ATRAS.Name = "BTN_ATRAS"
        Me.BTN_ATRAS.Size = New System.Drawing.Size(40, 41)
        Me.BTN_ATRAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_ATRAS.TabIndex = 77
        Me.BTN_ATRAS.TabStop = False
        Me.ATRAS.SetToolTip(Me.BTN_ATRAS, "Atras")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(341, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 24)
        Me.Label6.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(393, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 24)
        Me.Label5.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(600, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 24)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Musica"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(350, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 24)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Juegos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(53, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 24)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Memorandos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(261, 411)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 24)
        Me.Label2.TabIndex = 70
        '
        'BTN_MUSICA
        '
        Me.BTN_MUSICA.BackColor = System.Drawing.Color.Transparent
        Me.BTN_MUSICA.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.MUSICA
        Me.BTN_MUSICA.Location = New System.Drawing.Point(579, 154)
        Me.BTN_MUSICA.Name = "BTN_MUSICA"
        Me.BTN_MUSICA.Size = New System.Drawing.Size(139, 133)
        Me.BTN_MUSICA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_MUSICA.TabIndex = 69
        Me.BTN_MUSICA.TabStop = False
        '
        'BTN_JUEGOS
        '
        Me.BTN_JUEGOS.BackColor = System.Drawing.Color.Transparent
        Me.BTN_JUEGOS.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.JUEGOS1
        Me.BTN_JUEGOS.Location = New System.Drawing.Point(329, 154)
        Me.BTN_JUEGOS.Name = "BTN_JUEGOS"
        Me.BTN_JUEGOS.Size = New System.Drawing.Size(139, 133)
        Me.BTN_JUEGOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_JUEGOS.TabIndex = 68
        Me.BTN_JUEGOS.TabStop = False
        '
        'BTN_FACTURA
        '
        Me.BTN_FACTURA.BackColor = System.Drawing.Color.Transparent
        Me.BTN_FACTURA.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.PEDIDOPROVEEDOR
        Me.BTN_FACTURA.Location = New System.Drawing.Point(57, 154)
        Me.BTN_FACTURA.Name = "BTN_FACTURA"
        Me.BTN_FACTURA.Size = New System.Drawing.Size(139, 133)
        Me.BTN_FACTURA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_FACTURA.TabIndex = 67
        Me.BTN_FACTURA.TabStop = False
        '
        'JUEGOS
        '
        Me.JUEGOS.BackgroundImage = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.ADMINISTRADOR_1
        Me.JUEGOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.JUEGOS.Controls.Add(Me.BTN_SALIR_JUEGOS)
        Me.JUEGOS.Controls.Add(Me.PictureBox2)
        Me.JUEGOS.Controls.Add(Me.PictureBox1)
        Me.JUEGOS.Controls.Add(Me.Label7)
        Me.JUEGOS.Controls.Add(Me.Label8)
        Me.JUEGOS.Location = New System.Drawing.Point(177, 98)
        Me.JUEGOS.Name = "JUEGOS"
        Me.JUEGOS.Size = New System.Drawing.Size(457, 290)
        Me.JUEGOS.TabIndex = 79
        Me.JUEGOS.Visible = False
        '
        'BTN_SALIR_JUEGOS
        '
        Me.BTN_SALIR_JUEGOS.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SALIR_JUEGOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_SALIR_JUEGOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_SALIR_JUEGOS.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.SALIR1
        Me.BTN_SALIR_JUEGOS.Location = New System.Drawing.Point(397, 233)
        Me.BTN_SALIR_JUEGOS.Name = "BTN_SALIR_JUEGOS"
        Me.BTN_SALIR_JUEGOS.Size = New System.Drawing.Size(43, 41)
        Me.BTN_SALIR_JUEGOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_SALIR_JUEGOS.TabIndex = 65
        Me.BTN_SALIR_JUEGOS.TabStop = False
        Me.CANCELAR.SetToolTip(Me.BTN_SALIR_JUEGOS, "Salir")
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(63, 87)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 94)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(291, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(69, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Pac-Mam"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(319, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 20)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Luxor"
        '
        'SUPERVISOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.FORMULARIO4
        Me.ClientSize = New System.Drawing.Size(798, 453)
        Me.Controls.Add(Me.JUEGOS)
        Me.Controls.Add(Me.BTN_ATRAS)
        Me.Controls.Add(Me.BTN_SALIR)
        Me.Controls.Add(Me.BTN_AYUDA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_MUSICA)
        Me.Controls.Add(Me.BTN_JUEGOS)
        Me.Controls.Add(Me.BTN_FACTURA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SUPERVISOR"
        Me.Text = "SUPERVISOR"
        CType(Me.BTN_AYUDA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_SALIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_ATRAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_MUSICA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_JUEGOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_FACTURA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JUEGOS.ResumeLayout(False)
        Me.JUEGOS.PerformLayout()
        CType(Me.BTN_SALIR_JUEGOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AYUDA As System.Windows.Forms.ToolTip
    Friend WithEvents BTN_AYUDA As System.Windows.Forms.PictureBox
    Friend WithEvents CANCELAR As System.Windows.Forms.ToolTip
    Public WithEvents BTN_SALIR As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_ATRAS As System.Windows.Forms.PictureBox
    Friend WithEvents ATRAS As System.Windows.Forms.ToolTip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTN_MUSICA As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_JUEGOS As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_FACTURA As System.Windows.Forms.PictureBox
    Friend WithEvents JUEGOS As System.Windows.Forms.Panel
    Public WithEvents BTN_SALIR_JUEGOS As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
