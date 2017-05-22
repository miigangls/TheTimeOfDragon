<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MOSTRAR
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MOSTRAR))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.FACTURA = New System.Windows.Forms.TabPage
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.LinK_ATRAS = New System.Windows.Forms.LinkLabel
        Me.LinK_CERRAR = New System.Windows.Forms.LinkLabel
        Me.ElDataGridView1 = New Klik.Windows.Forms.v1.EntryLib.ELDataGridView
        Me.ElDataGridView2 = New Klik.Windows.Forms.v1.EntryLib.ELDataGridView
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.ElDataGridView3 = New Klik.Windows.Forms.v1.EntryLib.ELDataGridView
        Me.ElDataGridView4 = New Klik.Windows.Forms.v1.EntryLib.ELDataGridView
        Me.ElDataGridView5 = New Klik.Windows.Forms.v1.EntryLib.ELDataGridView
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.ElDataGridView6 = New Klik.Windows.Forms.v1.EntryLib.ELDataGridView
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.FACTURA.SuspendLayout()
        CType(Me.ElDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElDataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.ElDataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElDataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElDataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.ElDataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.LinK_ATRAS)
        Me.GroupBox1.Controls.Add(Me.LinK_CERRAR)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 343)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.FACTURA)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(18, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(741, 296)
        Me.TabControl1.TabIndex = 41
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ElDataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(733, 270)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "EMPLEADO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ElDataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(733, 270)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PROVEEDOR"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ElDataGridView4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(733, 270)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "PRODUCTO"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'FACTURA
        '
        Me.FACTURA.Controls.Add(Me.ElDataGridView5)
        Me.FACTURA.Location = New System.Drawing.Point(4, 22)
        Me.FACTURA.Name = "FACTURA"
        Me.FACTURA.Padding = New System.Windows.Forms.Padding(3)
        Me.FACTURA.Size = New System.Drawing.Size(733, 270)
        Me.FACTURA.TabIndex = 4
        Me.FACTURA.Text = "FACTURA"
        Me.FACTURA.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel2.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Lucida Calligraphy", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.White
        Me.LinkLabel2.Location = New System.Drawing.Point(389, 16)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(67, 20)
        Me.LinkLabel2.TabIndex = 40
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "INICIO"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Lucida Calligraphy", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(570, 16)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(81, 20)
        Me.LinkLabel1.TabIndex = 39
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "AYUDA"
        '
        'LinK_ATRAS
        '
        Me.LinK_ATRAS.AutoSize = True
        Me.LinK_ATRAS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinK_ATRAS.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.LinK_ATRAS.Font = New System.Drawing.Font("Lucida Calligraphy", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinK_ATRAS.LinkColor = System.Drawing.Color.White
        Me.LinK_ATRAS.Location = New System.Drawing.Point(480, 16)
        Me.LinK_ATRAS.Name = "LinK_ATRAS"
        Me.LinK_ATRAS.Size = New System.Drawing.Size(72, 20)
        Me.LinK_ATRAS.TabIndex = 38
        Me.LinK_ATRAS.TabStop = True
        Me.LinK_ATRAS.Text = "ATRAS"
        '
        'LinK_CERRAR
        '
        Me.LinK_CERRAR.AutoSize = True
        Me.LinK_CERRAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinK_CERRAR.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.LinK_CERRAR.Font = New System.Drawing.Font("Lucida Calligraphy", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinK_CERRAR.LinkColor = System.Drawing.Color.White
        Me.LinK_CERRAR.Location = New System.Drawing.Point(675, 16)
        Me.LinK_CERRAR.Name = "LinK_CERRAR"
        Me.LinK_CERRAR.Size = New System.Drawing.Size(84, 20)
        Me.LinK_CERRAR.TabIndex = 37
        Me.LinK_CERRAR.TabStop = True
        Me.LinK_CERRAR.Text = "CERRAR"
        '
        'ElDataGridView1
        '
        Me.ElDataGridView1.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElDataGridView1.BackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.ElDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ElDataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.ElDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElDataGridView1.GridColor = System.Drawing.Color.LightGray
        Me.ElDataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.ElDataGridView1.Name = "ElDataGridView1"
        Me.ElDataGridView1.Size = New System.Drawing.Size(727, 264)
        Me.ElDataGridView1.TabIndex = 1
        '
        'ElDataGridView2
        '
        Me.ElDataGridView2.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElDataGridView2.BackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.ElDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ElDataGridView2.DefaultCellStyle = DataGridViewCellStyle2
        Me.ElDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElDataGridView2.GridColor = System.Drawing.Color.LightGray
        Me.ElDataGridView2.Location = New System.Drawing.Point(3, 3)
        Me.ElDataGridView2.Name = "ElDataGridView2"
        Me.ElDataGridView2.Size = New System.Drawing.Size(727, 264)
        Me.ElDataGridView2.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ElDataGridView3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(733, 270)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "CLIENTE"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ElDataGridView3
        '
        Me.ElDataGridView3.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElDataGridView3.BackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.ElDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ElDataGridView3.DefaultCellStyle = DataGridViewCellStyle3
        Me.ElDataGridView3.GridColor = System.Drawing.Color.LightGray
        Me.ElDataGridView3.Location = New System.Drawing.Point(3, 3)
        Me.ElDataGridView3.Name = "ElDataGridView3"
        Me.ElDataGridView3.Size = New System.Drawing.Size(727, 264)
        Me.ElDataGridView3.TabIndex = 1
        '
        'ElDataGridView4
        '
        Me.ElDataGridView4.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElDataGridView4.BackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.ElDataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ElDataGridView4.DefaultCellStyle = DataGridViewCellStyle4
        Me.ElDataGridView4.GridColor = System.Drawing.Color.LightGray
        Me.ElDataGridView4.Location = New System.Drawing.Point(3, 3)
        Me.ElDataGridView4.Name = "ElDataGridView4"
        Me.ElDataGridView4.Size = New System.Drawing.Size(727, 264)
        Me.ElDataGridView4.TabIndex = 1
        '
        'ElDataGridView5
        '
        Me.ElDataGridView5.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElDataGridView5.BackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.ElDataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ElDataGridView5.DefaultCellStyle = DataGridViewCellStyle5
        Me.ElDataGridView5.GridColor = System.Drawing.Color.LightGray
        Me.ElDataGridView5.Location = New System.Drawing.Point(3, 3)
        Me.ElDataGridView5.Name = "ElDataGridView5"
        Me.ElDataGridView5.Size = New System.Drawing.Size(727, 264)
        Me.ElDataGridView5.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.ElDataGridView6)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(733, 270)
        Me.TabPage5.TabIndex = 5
        Me.TabPage5.Text = "COMPRA"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'ElDataGridView6
        '
        Me.ElDataGridView6.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElDataGridView6.BackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.ElDataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ElDataGridView6.DefaultCellStyle = DataGridViewCellStyle6
        Me.ElDataGridView6.GridColor = System.Drawing.Color.LightGray
        Me.ElDataGridView6.Location = New System.Drawing.Point(3, 3)
        Me.ElDataGridView6.Name = "ElDataGridView6"
        Me.ElDataGridView6.Size = New System.Drawing.Size(727, 264)
        Me.ElDataGridView6.TabIndex = 2
        '
        'MOSTRAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 502)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MOSTRAR"
        Me.Text = "MOSTRAR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.FACTURA.ResumeLayout(False)
        CType(Me.ElDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElDataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.ElDataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElDataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElDataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.ElDataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinK_ATRAS As System.Windows.Forms.LinkLabel
    Friend WithEvents LinK_CERRAR As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents FACTURA As System.Windows.Forms.TabPage
    Friend WithEvents ElDataGridView1 As Klik.Windows.Forms.v1.EntryLib.ELDataGridView
    Friend WithEvents ElDataGridView2 As Klik.Windows.Forms.v1.EntryLib.ELDataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ElDataGridView3 As Klik.Windows.Forms.v1.EntryLib.ELDataGridView
    Friend WithEvents ElDataGridView4 As Klik.Windows.Forms.v1.EntryLib.ELDataGridView
    Friend WithEvents ElDataGridView5 As Klik.Windows.Forms.v1.EntryLib.ELDataGridView
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents ElDataGridView6 As Klik.Windows.Forms.v1.EntryLib.ELDataGridView
End Class
