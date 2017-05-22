<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FACTURA_SECCION_CAJA
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FACTURA_SECCION_CAJA))
        Me.Buscar_Producto = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn_agregarcliente = New System.Windows.Forms.PictureBox
        Me.BTN_BUSCAR_CLIENTE = New System.Windows.Forms.PictureBox
        Me.Agregar_Cliente = New System.Windows.Forms.ToolTip(Me.components)
        Me.Agregar_Producto1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NUEVOPRODUCTO = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTN_NUEVAFACTURA = New System.Windows.Forms.PictureBox
        Me.BTN_ELIMINAR = New System.Windows.Forms.PictureBox
        Me.IMPRIMIR = New System.Windows.Forms.ToolTip(Me.components)
        Me.SALIR = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTN_SALIR = New System.Windows.Forms.PictureBox
        Me.EXPORTAR_EXECEL = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTN_EXEL = New System.Windows.Forms.PictureBox
        Me.BTN_IMPRIMIR = New System.Windows.Forms.PictureBox
        Me.ATRAS = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTN_ATRAS = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ElCalculator1 = New Klik.Windows.Forms.v1.EntryLib.ELCalculator
        Me.dgdDetalle = New Klik.Windows.Forms.v1.EntryLib.ELDataGridView
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TALLAS = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.SUM_TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QUITAR = New System.Windows.Forms.DataGridViewButtonColumn
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.TEXT_TOTAL = New System.Windows.Forms.MaskedTextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.BTN_GUARDAR_FACTURA = New System.Windows.Forms.PictureBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BTN_BUSCAR_PRODUCTO = New System.Windows.Forms.PictureBox
        Me.tottla = New System.Windows.Forms.Label
        Me.lbl_iva = New System.Windows.Forms.Label
        Me.lbl_sobotal = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.codigo_cliente = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.SALIRPANEL = New System.Windows.Forms.PictureBox
        Me.BTN_ACEPTAR = New System.Windows.Forms.PictureBox
        Me.LB_CODIGO = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.direccion = New System.Windows.Forms.Label
        Me.cidad = New System.Windows.Forms.Label
        Me.telefonomovil = New System.Windows.Forms.Label
        Me.telefonoparticular = New System.Windows.Forms.Label
        Me.identificacion = New System.Windows.Forms.Label
        Me.apellido = New System.Windows.Forms.Label
        Me.nombre = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GrB_datosdelcliente = New System.Windows.Forms.GroupBox
        Me.CNX_MARCAS = New System.Windows.Forms.ComboBox
        Me.TXT_FECHA = New System.Windows.Forms.MaskedTextBox
        Me.TXT_NUM_FACTURA = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GUARDAR_FACTURA = New System.Windows.Forms.ToolTip(Me.components)
        Me.CALCULADORA = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintForm2 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.Btn_agregarcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_BUSCAR_CLIENTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_NUEVAFACTURA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_ELIMINAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_SALIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_EXEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_IMPRIMIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_ATRAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ElCalculator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.BTN_GUARDAR_FACTURA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.BTN_BUSCAR_PRODUCTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SALIRPANEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_ACEPTAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrB_datosdelcliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_agregarcliente
        '
        Me.Btn_agregarcliente.BackColor = System.Drawing.Color.Transparent
        Me.Btn_agregarcliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_agregarcliente.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.GUARDARCLIENTE
        Me.Btn_agregarcliente.Location = New System.Drawing.Point(17, 23)
        Me.Btn_agregarcliente.Name = "Btn_agregarcliente"
        Me.Btn_agregarcliente.Size = New System.Drawing.Size(61, 75)
        Me.Btn_agregarcliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_agregarcliente.TabIndex = 51
        Me.Btn_agregarcliente.TabStop = False
        Me.Buscar_Producto.SetToolTip(Me.Btn_agregarcliente, "Agregar Cliente")
        '
        'BTN_BUSCAR_CLIENTE
        '
        Me.BTN_BUSCAR_CLIENTE.BackColor = System.Drawing.Color.Transparent
        Me.BTN_BUSCAR_CLIENTE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_BUSCAR_CLIENTE.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.Buscar
        Me.BTN_BUSCAR_CLIENTE.Location = New System.Drawing.Point(84, 23)
        Me.BTN_BUSCAR_CLIENTE.Name = "BTN_BUSCAR_CLIENTE"
        Me.BTN_BUSCAR_CLIENTE.Size = New System.Drawing.Size(61, 75)
        Me.BTN_BUSCAR_CLIENTE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_BUSCAR_CLIENTE.TabIndex = 50
        Me.BTN_BUSCAR_CLIENTE.TabStop = False
        Me.Buscar_Producto.SetToolTip(Me.BTN_BUSCAR_CLIENTE, "Buscar Cliente")
        '
        'BTN_NUEVAFACTURA
        '
        Me.BTN_NUEVAFACTURA.BackColor = System.Drawing.Color.Transparent
        Me.BTN_NUEVAFACTURA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_NUEVAFACTURA.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.Nuevo
        Me.BTN_NUEVAFACTURA.Location = New System.Drawing.Point(84, 19)
        Me.BTN_NUEVAFACTURA.Name = "BTN_NUEVAFACTURA"
        Me.BTN_NUEVAFACTURA.Size = New System.Drawing.Size(61, 75)
        Me.BTN_NUEVAFACTURA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_NUEVAFACTURA.TabIndex = 53
        Me.BTN_NUEVAFACTURA.TabStop = False
        Me.NUEVOPRODUCTO.SetToolTip(Me.BTN_NUEVAFACTURA, "Nuevo Factura")
        '
        'BTN_ELIMINAR
        '
        Me.BTN_ELIMINAR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ELIMINAR.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources._1__399_
        Me.BTN_ELIMINAR.Location = New System.Drawing.Point(15, 19)
        Me.BTN_ELIMINAR.Name = "BTN_ELIMINAR"
        Me.BTN_ELIMINAR.Size = New System.Drawing.Size(63, 76)
        Me.BTN_ELIMINAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_ELIMINAR.TabIndex = 58
        Me.BTN_ELIMINAR.TabStop = False
        Me.NUEVOPRODUCTO.SetToolTip(Me.BTN_ELIMINAR, "Limpiar")
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SALIR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_SALIR.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.SALIR1
        Me.BTN_SALIR.Location = New System.Drawing.Point(98, 192)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(45, 42)
        Me.BTN_SALIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_SALIR.TabIndex = 55
        Me.BTN_SALIR.TabStop = False
        Me.SALIR.SetToolTip(Me.BTN_SALIR, "Salir")
        '
        'BTN_EXEL
        '
        Me.BTN_EXEL.BackColor = System.Drawing.Color.Transparent
        Me.BTN_EXEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_EXEL.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.PDF
        Me.BTN_EXEL.Location = New System.Drawing.Point(82, 111)
        Me.BTN_EXEL.Name = "BTN_EXEL"
        Me.BTN_EXEL.Size = New System.Drawing.Size(61, 75)
        Me.BTN_EXEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_EXEL.TabIndex = 56
        Me.BTN_EXEL.TabStop = False
        Me.EXPORTAR_EXECEL.SetToolTip(Me.BTN_EXEL, "Exportar PDF")
        '
        'BTN_IMPRIMIR
        '
        Me.BTN_IMPRIMIR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_IMPRIMIR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_IMPRIMIR.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.IMPRIMIR1
        Me.BTN_IMPRIMIR.Location = New System.Drawing.Point(84, 19)
        Me.BTN_IMPRIMIR.Name = "BTN_IMPRIMIR"
        Me.BTN_IMPRIMIR.Size = New System.Drawing.Size(59, 76)
        Me.BTN_IMPRIMIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_IMPRIMIR.TabIndex = 59
        Me.BTN_IMPRIMIR.TabStop = False
        Me.EXPORTAR_EXECEL.SetToolTip(Me.BTN_IMPRIMIR, "Imprimir")
        '
        'BTN_ATRAS
        '
        Me.BTN_ATRAS.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ATRAS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ATRAS.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.INICIO1
        Me.BTN_ATRAS.Location = New System.Drawing.Point(25, 192)
        Me.BTN_ATRAS.Name = "BTN_ATRAS"
        Me.BTN_ATRAS.Size = New System.Drawing.Size(45, 42)
        Me.BTN_ATRAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_ATRAS.TabIndex = 57
        Me.BTN_ATRAS.TabStop = False
        Me.ATRAS.SetToolTip(Me.BTN_ATRAS, "Atras")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ElCalculator1)
        Me.GroupBox1.Controls.Add(Me.dgdDetalle)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.tottla)
        Me.GroupBox1.Controls.Add(Me.lbl_iva)
        Me.GroupBox1.Controls.Add(Me.lbl_sobotal)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GrB_datosdelcliente)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1072, 606)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        '
        'ElCalculator1
        '
        Me.ElCalculator1.ButtonOffice2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlue
        Me.ElCalculator1.ButtonTexts = New String() {"Round", "Back", "CE", "C", "MC", "MR", "MS", "M+", "÷", "X", "-", "+", "%", "1/ x", "=", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "+/-", ".", "Ok", "Cancel"}
        Me.ElCalculator1.ContainerStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.ElCalculator1.ContainerStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElCalculator1.ContainerStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlue
        Me.ElCalculator1.Expanded = True
        Me.ElCalculator1.FooterStyle.BackgroundStyle.GradientAngle = 0.0!
        Me.ElCalculator1.FooterStyle.FlashStyle.GradientAngle = 0.0!
        Me.ElCalculator1.FooterStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElCalculator1.FooterStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElCalculator1.FooterStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ElCalculator1.FooterStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlue
        Me.ElCalculator1.HeaderStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElCalculator1.HeaderStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElCalculator1.HeaderStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ElCalculator1.HeaderStyle.Height = 24
        Me.ElCalculator1.HeaderStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlue
        Me.ElCalculator1.HeaderStyle.TextStyle.Text = "CALCULADORA"
        Me.ElCalculator1.Location = New System.Drawing.Point(316, 305)
        Me.ElCalculator1.Name = "ElCalculator1"
        Me.ElCalculator1.Size = New System.Drawing.Size(249, 230)
        Me.ElCalculator1.TabIndex = 51
        Me.ElCalculator1.Visible = False
        '
        'dgdDetalle
        '
        Me.dgdDetalle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.dgdDetalle.BackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.dgdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.DESCRIPCION, Me.PRECIO, Me.CANTIDAD, Me.TALLAS, Me.SUM_TOTAL, Me.IVA, Me.QUITAR})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdDetalle.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgdDetalle.GridColor = System.Drawing.Color.LightGray
        Me.dgdDetalle.Location = New System.Drawing.Point(6, 296)
        Me.dgdDetalle.Name = "dgdDetalle"
        Me.dgdDetalle.Size = New System.Drawing.Size(884, 298)
        Me.dgdDetalle.TabIndex = 80
        '
        'CODIGO
        '
        Me.CODIGO.HeaderText = "Codigo"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.Width = 50
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.HeaderText = "Descripcion"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.Width = 230
        '
        'PRECIO
        '
        Me.PRECIO.HeaderText = "Presio Un"
        Me.PRECIO.Name = "PRECIO"
        '
        'CANTIDAD
        '
        Me.CANTIDAD.FillWeight = 90.0!
        Me.CANTIDAD.HeaderText = "Cantidad"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.Width = 60
        '
        'TALLAS
        '
        Me.TALLAS.FillWeight = 50.0!
        Me.TALLAS.HeaderText = "Tallas"
        Me.TALLAS.Name = "TALLAS"
        Me.TALLAS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TALLAS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TALLAS.Width = 50
        '
        'SUM_TOTAL
        '
        Me.SUM_TOTAL.HeaderText = "Sup total"
        Me.SUM_TOTAL.Name = "SUM_TOTAL"
        Me.SUM_TOTAL.Width = 150
        '
        'IVA
        '
        Me.IVA.HeaderText = "Iva"
        Me.IVA.Name = "IVA"
        Me.IVA.Width = 150
        '
        'QUITAR
        '
        Me.QUITAR.HeaderText = "Quitar"
        Me.QUITAR.Name = "QUITAR"
        Me.QUITAR.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.QUITAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.QUITAR.Width = 50
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Controls.Add(Me.GroupBox6)
        Me.GroupBox7.Controls.Add(Me.GroupBox3)
        Me.GroupBox7.Controls.Add(Me.GroupBox4)
        Me.GroupBox7.Location = New System.Drawing.Point(896, 19)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(170, 581)
        Me.GroupBox7.TabIndex = 61
        Me.GroupBox7.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TEXT_TOTAL)
        Me.GroupBox8.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(6, 519)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(158, 56)
        Me.GroupBox8.TabIndex = 90
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "TOTAL  COMPRA"
        '
        'TEXT_TOTAL
        '
        Me.TEXT_TOTAL.Enabled = False
        Me.TEXT_TOTAL.Location = New System.Drawing.Point(17, 20)
        Me.TEXT_TOTAL.Name = "TEXT_TOTAL"
        Me.TEXT_TOTAL.Size = New System.Drawing.Size(119, 25)
        Me.TEXT_TOTAL.TabIndex = 88
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BTN_GUARDAR_FACTURA)
        Me.GroupBox6.Controls.Add(Me.BTN_NUEVAFACTURA)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(158, 111)
        Me.GroupBox6.TabIndex = 81
        Me.GroupBox6.TabStop = False
        '
        'BTN_GUARDAR_FACTURA
        '
        Me.BTN_GUARDAR_FACTURA.BackColor = System.Drawing.Color.Transparent
        Me.BTN_GUARDAR_FACTURA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_GUARDAR_FACTURA.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.Guardar1
        Me.BTN_GUARDAR_FACTURA.Location = New System.Drawing.Point(11, 23)
        Me.BTN_GUARDAR_FACTURA.Name = "BTN_GUARDAR_FACTURA"
        Me.BTN_GUARDAR_FACTURA.Size = New System.Drawing.Size(61, 75)
        Me.BTN_GUARDAR_FACTURA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_GUARDAR_FACTURA.TabIndex = 58
        Me.BTN_GUARDAR_FACTURA.TabStop = False
        Me.GUARDAR_FACTURA.SetToolTip(Me.BTN_GUARDAR_FACTURA, "Guardar ")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn_agregarcliente)
        Me.GroupBox3.Controls.Add(Me.BTN_BUSCAR_CLIENTE)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 143)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(158, 118)
        Me.GroupBox3.TabIndex = 59
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BTN_IMPRIMIR)
        Me.GroupBox4.Controls.Add(Me.BTN_ELIMINAR)
        Me.GroupBox4.Controls.Add(Me.BTN_BUSCAR_PRODUCTO)
        Me.GroupBox4.Controls.Add(Me.BTN_SALIR)
        Me.GroupBox4.Controls.Add(Me.BTN_EXEL)
        Me.GroupBox4.Controls.Add(Me.BTN_ATRAS)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 267)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(156, 244)
        Me.GroupBox4.TabIndex = 80
        Me.GroupBox4.TabStop = False
        '
        'BTN_BUSCAR_PRODUCTO
        '
        Me.BTN_BUSCAR_PRODUCTO.BackColor = System.Drawing.Color.Transparent
        Me.BTN_BUSCAR_PRODUCTO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_BUSCAR_PRODUCTO.Image = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.calculator2
        Me.BTN_BUSCAR_PRODUCTO.Location = New System.Drawing.Point(17, 111)
        Me.BTN_BUSCAR_PRODUCTO.Name = "BTN_BUSCAR_PRODUCTO"
        Me.BTN_BUSCAR_PRODUCTO.Size = New System.Drawing.Size(61, 75)
        Me.BTN_BUSCAR_PRODUCTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_BUSCAR_PRODUCTO.TabIndex = 52
        Me.BTN_BUSCAR_PRODUCTO.TabStop = False
        '
        'tottla
        '
        Me.tottla.AutoSize = True
        Me.tottla.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tottla.Location = New System.Drawing.Point(739, 491)
        Me.tottla.Name = "tottla"
        Me.tottla.Size = New System.Drawing.Size(0, 17)
        Me.tottla.TabIndex = 79
        '
        'lbl_iva
        '
        Me.lbl_iva.AutoSize = True
        Me.lbl_iva.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_iva.Location = New System.Drawing.Point(739, 530)
        Me.lbl_iva.Name = "lbl_iva"
        Me.lbl_iva.Size = New System.Drawing.Size(0, 17)
        Me.lbl_iva.TabIndex = 77
        '
        'lbl_sobotal
        '
        Me.lbl_sobotal.AutoSize = True
        Me.lbl_sobotal.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sobotal.Location = New System.Drawing.Point(39, 558)
        Me.lbl_sobotal.Name = "lbl_sobotal"
        Me.lbl_sobotal.Size = New System.Drawing.Size(0, 17)
        Me.lbl_sobotal.TabIndex = 75
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.codigo_cliente)
        Me.GroupBox5.Controls.Add(Me.Panel1)
        Me.GroupBox5.Controls.Add(Me.direccion)
        Me.GroupBox5.Controls.Add(Me.cidad)
        Me.GroupBox5.Controls.Add(Me.telefonomovil)
        Me.GroupBox5.Controls.Add(Me.telefonoparticular)
        Me.GroupBox5.Controls.Add(Me.identificacion)
        Me.GroupBox5.Controls.Add(Me.apellido)
        Me.GroupBox5.Controls.Add(Me.nombre)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 131)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(884, 159)
        Me.GroupBox5.TabIndex = 71
        Me.GroupBox5.TabStop = False
        '
        'codigo_cliente
        '
        Me.codigo_cliente.AutoSize = True
        Me.codigo_cliente.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigo_cliente.Location = New System.Drawing.Point(846, 124)
        Me.codigo_cliente.Name = "codigo_cliente"
        Me.codigo_cliente.Size = New System.Drawing.Size(0, 18)
        Me.codigo_cliente.TabIndex = 45
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Location = New System.Drawing.Point(236, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 156)
        Me.Panel1.TabIndex = 50
        Me.Panel1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.SALIRPANEL)
        Me.GroupBox2.Controls.Add(Me.BTN_ACEPTAR)
        Me.GroupBox2.Controls.Add(Me.LB_CODIGO)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Calligraphy", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(18, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(374, 140)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'SALIRPANEL
        '
        Me.SALIRPANEL.Image = CType(resources.GetObject("SALIRPANEL.Image"), System.Drawing.Image)
        Me.SALIRPANEL.Location = New System.Drawing.Point(200, 75)
        Me.SALIRPANEL.Name = "SALIRPANEL"
        Me.SALIRPANEL.Size = New System.Drawing.Size(43, 41)
        Me.SALIRPANEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SALIRPANEL.TabIndex = 20
        Me.SALIRPANEL.TabStop = False
        '
        'BTN_ACEPTAR
        '
        Me.BTN_ACEPTAR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ACEPTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ACEPTAR.Image = CType(resources.GetObject("BTN_ACEPTAR.Image"), System.Drawing.Image)
        Me.BTN_ACEPTAR.Location = New System.Drawing.Point(119, 75)
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
        Me.LB_CODIGO.Size = New System.Drawing.Size(201, 20)
        Me.LB_CODIGO.TabIndex = 1
        Me.LB_CODIGO.Text = "INGRESE EL CODIGO"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(90, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(177, 22)
        Me.TextBox1.TabIndex = 0
        '
        'direccion
        '
        Me.direccion.AutoSize = True
        Me.direccion.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion.Location = New System.Drawing.Point(281, 124)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(0, 18)
        Me.direccion.TabIndex = 49
        '
        'cidad
        '
        Me.cidad.AutoSize = True
        Me.cidad.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cidad.Location = New System.Drawing.Point(97, 75)
        Me.cidad.Name = "cidad"
        Me.cidad.Size = New System.Drawing.Size(0, 18)
        Me.cidad.TabIndex = 48
        '
        'telefonomovil
        '
        Me.telefonomovil.AutoSize = True
        Me.telefonomovil.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefonomovil.Location = New System.Drawing.Point(666, 75)
        Me.telefonomovil.Name = "telefonomovil"
        Me.telefonomovil.Size = New System.Drawing.Size(0, 18)
        Me.telefonomovil.TabIndex = 47
        '
        'telefonoparticular
        '
        Me.telefonoparticular.AutoSize = True
        Me.telefonoparticular.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefonoparticular.Location = New System.Drawing.Point(418, 75)
        Me.telefonoparticular.Name = "telefonoparticular"
        Me.telefonoparticular.Size = New System.Drawing.Size(0, 18)
        Me.telefonoparticular.TabIndex = 46
        '
        'identificacion
        '
        Me.identificacion.AutoSize = True
        Me.identificacion.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.identificacion.Location = New System.Drawing.Point(666, 28)
        Me.identificacion.Name = "identificacion"
        Me.identificacion.Size = New System.Drawing.Size(0, 18)
        Me.identificacion.TabIndex = 45
        '
        'apellido
        '
        Me.apellido.AutoSize = True
        Me.apellido.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellido.Location = New System.Drawing.Point(342, 28)
        Me.apellido.Name = "apellido"
        Me.apellido.Size = New System.Drawing.Size(0, 18)
        Me.apellido.TabIndex = 44
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(102, 28)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(0, 18)
        Me.nombre.TabIndex = 43
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(270, 75)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(138, 18)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Telefono Particular:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(199, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 18)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Direccion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 18)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Ciudad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(553, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 18)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Telefono Movil:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(557, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 18)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Identificacion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Nombre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(270, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Apellido:"
        '
        'GrB_datosdelcliente
        '
        Me.GrB_datosdelcliente.BackColor = System.Drawing.Color.Transparent
        Me.GrB_datosdelcliente.Controls.Add(Me.CNX_MARCAS)
        Me.GrB_datosdelcliente.Controls.Add(Me.TXT_FECHA)
        Me.GrB_datosdelcliente.Controls.Add(Me.TXT_NUM_FACTURA)
        Me.GrB_datosdelcliente.Controls.Add(Me.Label11)
        Me.GrB_datosdelcliente.Controls.Add(Me.Label9)
        Me.GrB_datosdelcliente.Controls.Add(Me.Label3)
        Me.GrB_datosdelcliente.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrB_datosdelcliente.Location = New System.Drawing.Point(6, 19)
        Me.GrB_datosdelcliente.Name = "GrB_datosdelcliente"
        Me.GrB_datosdelcliente.Size = New System.Drawing.Size(884, 106)
        Me.GrB_datosdelcliente.TabIndex = 68
        Me.GrB_datosdelcliente.TabStop = False
        Me.GrB_datosdelcliente.Text = "Datos del Cliente"
        '
        'CNX_MARCAS
        '
        Me.CNX_MARCAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CNX_MARCAS.FormattingEnabled = True
        Me.CNX_MARCAS.Items.AddRange(New Object() {"SECCION CAJA", "SECCION BODEGA", "ATENCION AL CLIENTE", "SUPERVISOR BODEGA", " NO HAY EMPLEADO"})
        Me.CNX_MARCAS.Location = New System.Drawing.Point(502, 40)
        Me.CNX_MARCAS.Name = "CNX_MARCAS"
        Me.CNX_MARCAS.Size = New System.Drawing.Size(186, 25)
        Me.CNX_MARCAS.TabIndex = 34
        '
        'TXT_FECHA
        '
        Me.TXT_FECHA.Enabled = False
        Me.TXT_FECHA.Location = New System.Drawing.Point(209, 21)
        Me.TXT_FECHA.Mask = "00/00/0000"
        Me.TXT_FECHA.Name = "TXT_FECHA"
        Me.TXT_FECHA.Size = New System.Drawing.Size(124, 25)
        Me.TXT_FECHA.TabIndex = 9
        Me.TXT_FECHA.ValidatingType = GetType(Date)
        '
        'TXT_NUM_FACTURA
        '
        Me.TXT_NUM_FACTURA.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TXT_NUM_FACTURA.Enabled = False
        Me.TXT_NUM_FACTURA.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TXT_NUM_FACTURA.Location = New System.Drawing.Point(209, 57)
        Me.TXT_NUM_FACTURA.Name = "TXT_NUM_FACTURA"
        Me.TXT_NUM_FACTURA.Size = New System.Drawing.Size(124, 25)
        Me.TXT_NUM_FACTURA.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Fecha"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(339, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Nombre del Vendedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nunero de Factura"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintForm2
        '
        Me.PrintForm2.DocumentName = "document"
        Me.PrintForm2.Form = Me
        Me.PrintForm2.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm2.PrinterSettings = CType(resources.GetObject("PrintForm2.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm2.PrintFileName = Nothing
        '
        'FACTURA_SECCION_CAJA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.THE_TIME_OF_DRAGON.My.Resources.Resources.FORMULARIO91
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1085, 630)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1101, 668)
        Me.MinimumSize = New System.Drawing.Size(1101, 668)
        Me.Name = "FACTURA_SECCION_CAJA"
        Me.Text = "FACTURA_SECCION_CAJA"
        Me.Buscar_Producto.SetToolTip(Me, "Bucar Producto")
        Me.TransparencyKey = System.Drawing.Color.Silver
        CType(Me.Btn_agregarcliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_BUSCAR_CLIENTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_NUEVAFACTURA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_ELIMINAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_SALIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_EXEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_IMPRIMIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_ATRAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ElCalculator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.BTN_GUARDAR_FACTURA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.BTN_BUSCAR_PRODUCTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SALIRPANEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_ACEPTAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrB_datosdelcliente.ResumeLayout(False)
        Me.GrB_datosdelcliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Buscar_Producto As System.Windows.Forms.ToolTip
    Friend WithEvents Agregar_Cliente As System.Windows.Forms.ToolTip
    Friend WithEvents Agregar_Producto1 As System.Windows.Forms.ToolTip
    Friend WithEvents IMPRIMIR As System.Windows.Forms.ToolTip
    Friend WithEvents NUEVOPRODUCTO As System.Windows.Forms.ToolTip
    Friend WithEvents SALIR As System.Windows.Forms.ToolTip
    Friend WithEvents ATRAS As System.Windows.Forms.ToolTip
    Friend WithEvents EXPORTAR_EXECEL As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_ATRAS As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_EXEL As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_NUEVAFACTURA As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_SALIR As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_BUSCAR_PRODUCTO As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_agregarcliente As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_BUSCAR_CLIENTE As System.Windows.Forms.PictureBox
    Friend WithEvents GrB_datosdelcliente As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_FECHA As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TXT_NUM_FACTURA As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BTN_GUARDAR_FACTURA As System.Windows.Forms.PictureBox
    Friend WithEvents GUARDAR_FACTURA As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nombre As System.Windows.Forms.Label
    Friend WithEvents apellido As System.Windows.Forms.Label
    Friend WithEvents direccion As System.Windows.Forms.Label
    Friend WithEvents cidad As System.Windows.Forms.Label
    Friend WithEvents telefonomovil As System.Windows.Forms.Label
    Friend WithEvents telefonoparticular As System.Windows.Forms.Label
    Friend WithEvents identificacion As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SALIRPANEL As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_ACEPTAR As System.Windows.Forms.PictureBox
    Friend WithEvents LB_CODIGO As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CNX_MARCAS As System.Windows.Forms.ComboBox
    Friend WithEvents codigo_cliente As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_sobotal As System.Windows.Forms.Label
    Friend WithEvents tottla As System.Windows.Forms.Label
    Friend WithEvents CALCULADORA As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_iva As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_ELIMINAR As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_IMPRIMIR As System.Windows.Forms.PictureBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents dgdDetalle As Klik.Windows.Forms.v1.EntryLib.ELDataGridView
    Friend WithEvents ElCalculator1 As Klik.Windows.Forms.v1.EntryLib.ELCalculator
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TALLAS As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SUM_TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QUITAR As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents TEXT_TOTAL As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintForm2 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
