<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BUSCAR_PRODUCTOS = New System.Windows.Forms.Panel
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TXT_NOMBRE_BUSCAR = New System.Windows.Forms.ComboBox
        Me.BTN_SALIR = New System.Windows.Forms.PictureBox
        Me.BTN_ACEPTAR = New System.Windows.Forms.PictureBox
        Me.LB_CODIGO = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TXT_SEX = New System.Windows.Forms.Label
        Me.TXT_PREC = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.TXT_TIP = New System.Windows.Forms.Label
        Me.TXT_CANT = New System.Windows.Forms.Label
        Me.TXT_MRC = New System.Windows.Forms.Label
        Me.TXT_NOMB = New System.Windows.Forms.Label
        Me.TXT_COD = New System.Windows.Forms.Label
        Me.TXT_CODB = New System.Windows.Forms.Label
        Me.TIPO = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.CODIGO_TALL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BUTON_TALL = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.TALLAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BUTON = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.COLORES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BTN_AYUDA = New System.Windows.Forms.PictureBox
        Me.BTN_ATRAS = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.BUSCAR_PRODUCTOS.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.BTN_SALIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_ACEPTAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_AYUDA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_ATRAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 34)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(645, 553)
        Me.TabControl1.TabIndex = 64
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(637, 523)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PRRDUCTO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BUSCAR_PRODUCTOS)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 515)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRODUCTO"
        '
        'BUSCAR_PRODUCTOS
        '
        Me.BUSCAR_PRODUCTOS.BackColor = System.Drawing.Color.Transparent
        Me.BUSCAR_PRODUCTOS.BackgroundImage = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.FORMULARIO5
        Me.BUSCAR_PRODUCTOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BUSCAR_PRODUCTOS.Controls.Add(Me.GroupBox4)
        Me.BUSCAR_PRODUCTOS.Location = New System.Drawing.Point(134, 284)
        Me.BUSCAR_PRODUCTOS.Name = "BUSCAR_PRODUCTOS"
        Me.BUSCAR_PRODUCTOS.Size = New System.Drawing.Size(411, 156)
        Me.BUSCAR_PRODUCTOS.TabIndex = 106
        Me.BUSCAR_PRODUCTOS.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.TXT_NOMBRE_BUSCAR)
        Me.GroupBox4.Controls.Add(Me.BTN_SALIR)
        Me.GroupBox4.Controls.Add(Me.BTN_ACEPTAR)
        Me.GroupBox4.Controls.Add(Me.LB_CODIGO)
        Me.GroupBox4.Font = New System.Drawing.Font("Lucida Calligraphy", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(14, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(374, 140)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'TXT_NOMBRE_BUSCAR
        '
        Me.TXT_NOMBRE_BUSCAR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_NOMBRE_BUSCAR.FormattingEnabled = True
        Me.TXT_NOMBRE_BUSCAR.Location = New System.Drawing.Point(92, 43)
        Me.TXT_NOMBRE_BUSCAR.Name = "TXT_NOMBRE_BUSCAR"
        Me.TXT_NOMBRE_BUSCAR.Size = New System.Drawing.Size(185, 28)
        Me.TXT_NOMBRE_BUSCAR.TabIndex = 22
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.Image = CType(resources.GetObject("BTN_SALIR.Image"), System.Drawing.Image)
        Me.BTN_SALIR.Location = New System.Drawing.Point(199, 77)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(43, 41)
        Me.BTN_SALIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_SALIR.TabIndex = 20
        Me.BTN_SALIR.TabStop = False
        '
        'BTN_ACEPTAR
        '
        Me.BTN_ACEPTAR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ACEPTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ACEPTAR.Image = CType(resources.GetObject("BTN_ACEPTAR.Image"), System.Drawing.Image)
        Me.BTN_ACEPTAR.Location = New System.Drawing.Point(116, 77)
        Me.BTN_ACEPTAR.Name = "BTN_ACEPTAR"
        Me.BTN_ACEPTAR.Size = New System.Drawing.Size(43, 41)
        Me.BTN_ACEPTAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTN_ACEPTAR.TabIndex = 21
        Me.BTN_ACEPTAR.TabStop = False
        '
        'LB_CODIGO
        '
        Me.LB_CODIGO.AutoSize = True
        Me.LB_CODIGO.Location = New System.Drawing.Point(73, 24)
        Me.LB_CODIGO.Name = "LB_CODIGO"
        Me.LB_CODIGO.Size = New System.Drawing.Size(214, 20)
        Me.LB_CODIGO.TabIndex = 1
        Me.LB_CODIGO.Text = "INGRESE EL NOMBRE"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.TXT_SEX)
        Me.GroupBox6.Controls.Add(Me.TXT_PREC)
        Me.GroupBox6.Location = New System.Drawing.Point(336, 199)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(230, 85)
        Me.GroupBox6.TabIndex = 107
        Me.GroupBox6.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 18)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Sexo"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(28, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 18)
        Me.Label16.TabIndex = 95
        Me.Label16.Text = "Precio"
        '
        'TXT_SEX
        '
        Me.TXT_SEX.AutoSize = True
        Me.TXT_SEX.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SEX.Location = New System.Drawing.Point(101, 21)
        Me.TXT_SEX.Name = "TXT_SEX"
        Me.TXT_SEX.Size = New System.Drawing.Size(0, 18)
        Me.TXT_SEX.TabIndex = 102
        '
        'TXT_PREC
        '
        Me.TXT_PREC.AutoSize = True
        Me.TXT_PREC.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PREC.Location = New System.Drawing.Point(101, 56)
        Me.TXT_PREC.Name = "TXT_PREC"
        Me.TXT_PREC.Size = New System.Drawing.Size(0, 18)
        Me.TXT_PREC.TabIndex = 103
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TXT_TIP)
        Me.GroupBox5.Controls.Add(Me.TXT_CANT)
        Me.GroupBox5.Controls.Add(Me.TXT_MRC)
        Me.GroupBox5.Controls.Add(Me.TXT_NOMB)
        Me.GroupBox5.Controls.Add(Me.TXT_COD)
        Me.GroupBox5.Controls.Add(Me.TXT_CODB)
        Me.GroupBox5.Controls.Add(Me.TIPO)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(313, 267)
        Me.GroupBox5.TabIndex = 106
        Me.GroupBox5.TabStop = False
        '
        'TXT_TIP
        '
        Me.TXT_TIP.AutoSize = True
        Me.TXT_TIP.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TIP.Location = New System.Drawing.Point(88, 236)
        Me.TXT_TIP.Name = "TXT_TIP"
        Me.TXT_TIP.Size = New System.Drawing.Size(0, 18)
        Me.TXT_TIP.TabIndex = 113
        '
        'TXT_CANT
        '
        Me.TXT_CANT.AutoSize = True
        Me.TXT_CANT.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CANT.Location = New System.Drawing.Point(88, 201)
        Me.TXT_CANT.Name = "TXT_CANT"
        Me.TXT_CANT.Size = New System.Drawing.Size(0, 18)
        Me.TXT_CANT.TabIndex = 112
        '
        'TXT_MRC
        '
        Me.TXT_MRC.AutoSize = True
        Me.TXT_MRC.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MRC.Location = New System.Drawing.Point(83, 152)
        Me.TXT_MRC.Name = "TXT_MRC"
        Me.TXT_MRC.Size = New System.Drawing.Size(0, 18)
        Me.TXT_MRC.TabIndex = 111
        '
        'TXT_NOMB
        '
        Me.TXT_NOMB.AutoSize = True
        Me.TXT_NOMB.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOMB.Location = New System.Drawing.Point(83, 58)
        Me.TXT_NOMB.Name = "TXT_NOMB"
        Me.TXT_NOMB.Size = New System.Drawing.Size(0, 18)
        Me.TXT_NOMB.TabIndex = 108
        '
        'TXT_COD
        '
        Me.TXT_COD.AutoSize = True
        Me.TXT_COD.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_COD.Location = New System.Drawing.Point(82, 18)
        Me.TXT_COD.Name = "TXT_COD"
        Me.TXT_COD.Size = New System.Drawing.Size(0, 16)
        Me.TXT_COD.TabIndex = 110
        '
        'TXT_CODB
        '
        Me.TXT_CODB.AutoSize = True
        Me.TXT_CODB.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CODB.Location = New System.Drawing.Point(139, 101)
        Me.TXT_CODB.Name = "TXT_CODB"
        Me.TXT_CODB.Size = New System.Drawing.Size(0, 18)
        Me.TXT_CODB.TabIndex = 109
        '
        'TIPO
        '
        Me.TIPO.AutoSize = True
        Me.TIPO.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIPO.Location = New System.Drawing.Point(34, 236)
        Me.TIPO.Name = "TIPO"
        Me.TIPO.Size = New System.Drawing.Size(36, 18)
        Me.TIPO.TabIndex = 107
        Me.TIPO.Text = "Tipo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 18)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "Cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 18)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "Marcas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Nombre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 18)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Codigo de Barras"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Location = New System.Drawing.Point(314, 290)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(284, 213)
        Me.GroupBox3.TabIndex = 105
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TALLAS"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO_TALL, Me.BUTON_TALL, Me.TALLAS})
        Me.DataGridView2.Location = New System.Drawing.Point(6, 34)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(260, 162)
        Me.DataGridView2.TabIndex = 85
        '
        'CODIGO_TALL
        '
        Me.CODIGO_TALL.DataPropertyName = "codi_tal"
        Me.CODIGO_TALL.HeaderText = "CODIGO"
        Me.CODIGO_TALL.Name = "CODIGO_TALL"
        Me.CODIGO_TALL.Visible = False
        Me.CODIGO_TALL.Width = 200
        '
        'BUTON_TALL
        '
        Me.BUTON_TALL.HeaderText = ""
        Me.BUTON_TALL.Name = "BUTON_TALL"
        Me.BUTON_TALL.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BUTON_TALL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BUTON_TALL.Width = 40
        '
        'TALLAS
        '
        Me.TALLAS.DataPropertyName = "nom_tal"
        Me.TALLAS.HeaderText = "TALLAS"
        Me.TALLAS.Name = "TALLAS"
        Me.TALLAS.Width = 250
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 300)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 209)
        Me.GroupBox2.TabIndex = 104
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "COLORES"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.BUTON, Me.COLORES})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(278, 179)
        Me.DataGridView1.TabIndex = 84
        '
        'CODIGO
        '
        Me.CODIGO.DataPropertyName = "codi_col"
        Me.CODIGO.HeaderText = "CODIGO"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.Visible = False
        '
        'BUTON
        '
        Me.BUTON.HeaderText = ""
        Me.BUTON.Name = "BUTON"
        Me.BUTON.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BUTON.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BUTON.Width = 40
        '
        'COLORES
        '
        Me.COLORES.DataPropertyName = "nom_col"
        Me.COLORES.HeaderText = "COLORES"
        Me.COLORES.Name = "COLORES"
        Me.COLORES.Width = 198
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(388, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 164)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'BTN_AYUDA
        '
        Me.BTN_AYUDA.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AYUDA.Image = CType(resources.GetObject("BTN_AYUDA.Image"), System.Drawing.Image)
        Me.BTN_AYUDA.Location = New System.Drawing.Point(623, 12)
        Me.BTN_AYUDA.Name = "BTN_AYUDA"
        Me.BTN_AYUDA.Size = New System.Drawing.Size(43, 41)
        Me.BTN_AYUDA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_AYUDA.TabIndex = 45
        Me.BTN_AYUDA.TabStop = False
        '
        'BTN_ATRAS
        '
        Me.BTN_ATRAS.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ATRAS.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.Anterior
        Me.BTN_ATRAS.Location = New System.Drawing.Point(559, 9)
        Me.BTN_ATRAS.Name = "BTN_ATRAS"
        Me.BTN_ATRAS.Size = New System.Drawing.Size(43, 44)
        Me.BTN_ATRAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_ATRAS.TabIndex = 37
        Me.BTN_ATRAS.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.Buscar
        Me.PictureBox2.Location = New System.Drawing.Point(487, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 65
        Me.PictureBox2.TabStop = False
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.FORMULARIO1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(678, 599)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BTN_ATRAS)
        Me.Controls.Add(Me.BTN_AYUDA)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Name = "Productos"
        Me.Text = "Productos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.BUSCAR_PRODUCTOS.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.BTN_SALIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_ACEPTAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_AYUDA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_ATRAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_PREC As System.Windows.Forms.Label
    Friend WithEvents TXT_SEX As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BUTON As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents COLORES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents CODIGO_TALL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BUTON_TALL As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TALLAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BUSCAR_PRODUCTOS As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_SALIR As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_ACEPTAR As System.Windows.Forms.PictureBox
    Friend WithEvents LB_CODIGO As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_TIP As System.Windows.Forms.Label
    Friend WithEvents TXT_CANT As System.Windows.Forms.Label
    Friend WithEvents TXT_MRC As System.Windows.Forms.Label
    Friend WithEvents TXT_NOMB As System.Windows.Forms.Label
    Friend WithEvents TXT_COD As System.Windows.Forms.Label
    Friend WithEvents TXT_CODB As System.Windows.Forms.Label
    Friend WithEvents TIPO As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_NOMBRE_BUSCAR As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_AYUDA As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_ATRAS As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
