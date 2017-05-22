<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SECCION_CAJA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SECCION_CAJA))
        Me.BTN_FACTURA = New System.Windows.Forms.PictureBox
        Me.BTN_JUEGOS = New System.Windows.Forms.PictureBox
        Me.BTN_MUSICA = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BTN_ATRAS = New System.Windows.Forms.PictureBox
        Me.BTN_SALIR = New System.Windows.Forms.PictureBox
        Me.BTN_AYUDA = New System.Windows.Forms.PictureBox
        Me.CANCELAR = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTN_SALIR_JUEGOS = New System.Windows.Forms.PictureBox
        Me.ATRAS = New System.Windows.Forms.ToolTip(Me.components)
        Me.AYUDA = New System.Windows.Forms.ToolTip(Me.components)
        Me.JUEGOS = New System.Windows.Forms.Panel
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        CType(Me.BTN_FACTURA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_JUEGOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_MUSICA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_ATRAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_SALIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_AYUDA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_SALIR_JUEGOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JUEGOS.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_FACTURA
        '
        Me.BTN_FACTURA.BackColor = System.Drawing.Color.Transparent
        Me.BTN_FACTURA.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.FACTURA1
        Me.BTN_FACTURA.Location = New System.Drawing.Point(63, 148)
        Me.BTN_FACTURA.Name = "BTN_FACTURA"
        Me.BTN_FACTURA.Size = New System.Drawing.Size(139, 133)
        Me.BTN_FACTURA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_FACTURA.TabIndex = 55
        Me.BTN_FACTURA.TabStop = False
        '
        'BTN_JUEGOS
        '
        Me.BTN_JUEGOS.BackColor = System.Drawing.Color.Transparent
        Me.BTN_JUEGOS.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.JUEGOS1
        Me.BTN_JUEGOS.Location = New System.Drawing.Point(335, 148)
        Me.BTN_JUEGOS.Name = "BTN_JUEGOS"
        Me.BTN_JUEGOS.Size = New System.Drawing.Size(139, 133)
        Me.BTN_JUEGOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_JUEGOS.TabIndex = 56
        Me.BTN_JUEGOS.TabStop = False
        '
        'BTN_MUSICA
        '
        Me.BTN_MUSICA.BackColor = System.Drawing.Color.Transparent
        Me.BTN_MUSICA.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.MUSICA
        Me.BTN_MUSICA.Location = New System.Drawing.Point(585, 148)
        Me.BTN_MUSICA.Name = "BTN_MUSICA"
        Me.BTN_MUSICA.Size = New System.Drawing.Size(139, 133)
        Me.BTN_MUSICA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_MUSICA.TabIndex = 57
        Me.BTN_MUSICA.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(267, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 24)
        Me.Label2.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(80, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 24)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Factura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(356, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 24)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Juegos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(606, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 24)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Musica"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(399, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 24)
        Me.Label5.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(347, 375)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 24)
        Me.Label6.TabIndex = 63
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'BTN_ATRAS
        '
        Me.BTN_ATRAS.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ATRAS.BackgroundImage = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.Anterior
        Me.BTN_ATRAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ATRAS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ATRAS.Location = New System.Drawing.Point(21, 388)
        Me.BTN_ATRAS.Name = "BTN_ATRAS"
        Me.BTN_ATRAS.Size = New System.Drawing.Size(40, 41)
        Me.BTN_ATRAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_ATRAS.TabIndex = 65
        Me.BTN_ATRAS.TabStop = False
        Me.ATRAS.SetToolTip(Me.BTN_ATRAS, "Atras")
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_SALIR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_SALIR.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.SALIR1
        Me.BTN_SALIR.Location = New System.Drawing.Point(746, 388)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(43, 41)
        Me.BTN_SALIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_SALIR.TabIndex = 64
        Me.BTN_SALIR.TabStop = False
        Me.CANCELAR.SetToolTip(Me.BTN_SALIR, "Salir")
        '
        'BTN_AYUDA
        '
        Me.BTN_AYUDA.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AYUDA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_AYUDA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_AYUDA.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.AYUDA1
        Me.BTN_AYUDA.Location = New System.Drawing.Point(743, 12)
        Me.BTN_AYUDA.Name = "BTN_AYUDA"
        Me.BTN_AYUDA.Size = New System.Drawing.Size(46, 46)
        Me.BTN_AYUDA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_AYUDA.TabIndex = 66
        Me.BTN_AYUDA.TabStop = False
        Me.AYUDA.SetToolTip(Me.BTN_AYUDA, "Ayuda")
        '
        'BTN_SALIR_JUEGOS
        '
        Me.BTN_SALIR_JUEGOS.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SALIR_JUEGOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_SALIR_JUEGOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_SALIR_JUEGOS.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.SALIR1
        Me.BTN_SALIR_JUEGOS.Location = New System.Drawing.Point(631, 357)
        Me.BTN_SALIR_JUEGOS.Name = "BTN_SALIR_JUEGOS"
        Me.BTN_SALIR_JUEGOS.Size = New System.Drawing.Size(43, 41)
        Me.BTN_SALIR_JUEGOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_SALIR_JUEGOS.TabIndex = 65
        Me.BTN_SALIR_JUEGOS.TabStop = False
        Me.CANCELAR.SetToolTip(Me.BTN_SALIR_JUEGOS, "Salir")
        '
        'JUEGOS
        '
        Me.JUEGOS.BackgroundImage = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.ADMINISTRADOR_1
        Me.JUEGOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.JUEGOS.Controls.Add(Me.PictureBox7)
        Me.JUEGOS.Controls.Add(Me.PictureBox6)
        Me.JUEGOS.Controls.Add(Me.Label25)
        Me.JUEGOS.Controls.Add(Me.PictureBox5)
        Me.JUEGOS.Controls.Add(Me.Label24)
        Me.JUEGOS.Controls.Add(Me.PictureBox4)
        Me.JUEGOS.Controls.Add(Me.Label23)
        Me.JUEGOS.Controls.Add(Me.PictureBox3)
        Me.JUEGOS.Controls.Add(Me.Label9)
        Me.JUEGOS.Controls.Add(Me.BTN_SALIR_JUEGOS)
        Me.JUEGOS.Controls.Add(Me.PictureBox2)
        Me.JUEGOS.Controls.Add(Me.Label16)
        Me.JUEGOS.Controls.Add(Me.Label21)
        Me.JUEGOS.Location = New System.Drawing.Point(54, 21)
        Me.JUEGOS.Name = "JUEGOS"
        Me.JUEGOS.Size = New System.Drawing.Size(690, 416)
        Me.JUEGOS.TabIndex = 70
        Me.JUEGOS.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.luxor3
        Me.PictureBox7.Location = New System.Drawing.Point(297, 87)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(112, 94)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 74
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.Vista_Mine
        Me.PictureBox6.Location = New System.Drawing.Point(477, 244)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(103, 94)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 73
        Me.PictureBox6.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(504, 362)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 20)
        Me.Label25.TabIndex = 72
        Me.Label25.Text = "Chess" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.Vista__24_
        Me.PictureBox5.Location = New System.Drawing.Point(477, 87)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(103, 94)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 71
        Me.PictureBox5.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(504, 205)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 20)
        Me.Label24.TabIndex = 70
        Me.Label24.Text = "Chess" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.HeartsMCE
        Me.PictureBox4.Location = New System.Drawing.Point(303, 244)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(103, 94)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 69
        Me.PictureBox4.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(319, 362)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 20)
        Me.Label23.TabIndex = 68
        Me.Label23.Text = "Chess" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.chess
        Me.PictureBox3.Location = New System.Drawing.Point(61, 244)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(103, 94)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 67
        Me.PictureBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(94, 362)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 20)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Chess" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.Games_2
        Me.PictureBox2.Location = New System.Drawing.Point(63, 87)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 94)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(69, 205)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 20)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Pac-Mam"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(319, 205)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 20)
        Me.Label21.TabIndex = 39
        Me.Label21.Text = "Luxor"
        '
        'SECCION_CAJA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.ADMINISTRADOR_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(798, 459)
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
        Me.MaximizeBox = False
        Me.Name = "SECCION_CAJA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SECCION_CAJA"
        CType(Me.BTN_FACTURA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_JUEGOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_MUSICA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_ATRAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_SALIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_AYUDA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_SALIR_JUEGOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JUEGOS.ResumeLayout(False)
        Me.JUEGOS.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_FACTURA As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_JUEGOS As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_MUSICA As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BTN_ATRAS As System.Windows.Forms.PictureBox
    Public WithEvents BTN_SALIR As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_AYUDA As System.Windows.Forms.PictureBox
    Friend WithEvents CANCELAR As System.Windows.Forms.ToolTip
    Friend WithEvents ATRAS As System.Windows.Forms.ToolTip
    Friend WithEvents AYUDA As System.Windows.Forms.ToolTip
    Friend WithEvents JUEGOS As System.Windows.Forms.Panel
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents BTN_SALIR_JUEGOS As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
End Class
