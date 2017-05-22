Public Class AGREGAR_PRODUCTO
    Dim INT As New DATOS
    Private Sub BTN_MODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_MODIFICAR.Click
        Dim b As String = TXT_codigo.Text()
        If b = "" Then
            MsgBox("INGRESE EL CODIGO" & "PARA CONTINUAR DE CLICK EN NUEVO", MsgBoxStyle.Exclamation)
        Else
            INT.actualizar_PRODUCTO(TXT_NOMBRE.Text, TXT_CODIGODEVARRAS.Text, CNX_MARCAS.Text, COM_SEXO.Text, CNX_TIPO.Text, TXT_PRESIO.Text, LBL_IMGEN.Text, TXTR_CANTIDAD.Text, TXT_codigo.Text)
            INT.ELIMINAR_pro_tal(TXT_codigo.Text)
            INT.ELIMINAR_pro_col(TXT_codigo.Text)
            For index As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item("BUTON", index).Value = True Then
                    INT.ACTUALIZAR_PRO_COL(TXT_codigo.Text, DataGridView1.Item("CODIGO", index).Value)
                End If
            Next
            For index As Integer = 0 To DataGridView2.Rows.Count - 1
                If DataGridView2.Item("BUTON_TALL", index).Value = True Then
                    INT.ACTUALIZAR_PRO_TALL(TXT_codigo.Text, DataGridView2.Item("CODIGO_TALL", index).Value, TXTR_CANTIDAD.Text)
                End If
            Next

        End If
    End Sub

    Private Sub BTN_ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.Click
        INT.ELIMINAREMPLEADO(TXT_codigo.Text)
        TXT_NOMBRE.Text = ""
        TXT_codigo.Text = ""
        DataGridView1.DataSource = INT.CONSULTAR_COLORES
        DataGridView2.DataSource = INT.CONSULTAR_TALLAS
        CNX_MARCAS.Text = ""
        TXT_PRESIO.Text = ""
        TXTR_CANTIDAD.Text = ""
        PictureBox1.Image = PictureBox1.Tag
        PictureBox1.BackgroundImage = PictureBox1.Tag
    End Sub
    Private Sub BTN_NUEVO_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_NUEVO.Click
        TXT_NOMBRE.Text = ""
        TXT_codigo.Text = INT.nuevo_PRODUCTO
        DataGridView1.DataSource = INT.CONSULTAR_COLORES
        DataGridView2.DataSource = INT.CONSULTAR_TALLAS
        CNX_MARCAS.Enabled = True
        TXT_PRESIO.Enabled = True
        TXTR_CANTIDAD.Enabled = True
        TXT_CODIGODEVARRAS.Enabled = True
        CNX_TIPO.Enabled = True
        CNX_MARCAS.Text = ""
        TXT_PRESIO.Text = ""
        TXTR_CANTIDAD.Text = ""
        TXT_CODIGODEVARRAS.Text = ""
        DataGridView2.Enabled = True
        DataGridView1.Enabled = True
        PictureBox1.Image = PictureBox1.Tag
        PictureBox1.BackgroundImage = PictureBox1.Tag
    End Sub

    Private Sub BTN_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR.Click
        Dim A As String = TXT_codigo.Text
        Dim B As String = TXT_NOMBRE.Text
        Dim C As String = TXT_CODIGODEVARRAS.Text
        Dim D As String = CNX_MARCAS.Text
        Dim P As String = TXTR_CANTIDAD.Text
        Dim F As String = TXT_PRESIO.Text
        Dim G As String = CNX_TIPO.Text
        'Dim H As String = TXT_PRESIO.Text
        Dim I As String = COM_SEXO.Text
        If A = "" And B = "" And C = "" And D = "" And P = "" And F = "" And G = "" And I = "" Then
            MsgBox("PRO FAVOR LLENE LOS CAMPOS", MsgBoxStyle.RetryCancel)
        ElseIf A = "" Then
            MsgBox("POR FAVOR INGRESE EL CÓDIGO" & "PARA CONTINUAR DE CLICK EN NUEVO", MsgBoxStyle.RetryCancel)
        ElseIf B = "" Then
            MsgBox("POR FAVOR INGRESE EL NOMBRE DEL PRODUCTO", MsgBoxStyle.RetryCancel)
        ElseIf C = "" Then
            MsgBox("POR FAVOR INGRESE EL CODIGO DE VARRAS DEL PRODUCTO", MsgBoxStyle.RetryCancel)
        ElseIf D = "" Then
            MsgBox("POR FAVOR SELECCION LA MARCA ", MsgBoxStyle.RetryCancel)
        ElseIf P = "" Then
            MsgBox("POR FAVOR DIGITE LA CONATIDAD DEL PRODUCTO", MsgBoxStyle.RetryCancel)
        ElseIf F = "" Then
            MsgBox("POR FAVOR DIGITE LA PRECION DEL PRODUCTO", MsgBoxStyle.RetryCancel)
        ElseIf G = "" Then
            MsgBox("POR FAVOR SELECCIONE EL TIPO DEL PRODUCTO", MsgBoxStyle.RetryCancel)
            'ElseIf H = "" Then
            '    MsgBox("POR FAVOR DIGITE SU USUARIO", MsgBoxStyle.RetryCancel)
        ElseIf I = "" Then
            MsgBox("POR FAVOR SELECCIONE EL SEXO DEL PRODUCTO", MsgBoxStyle.RetryCancel)

        Else
            INT.GUARDAR_PRODUCTO(TXT_NOMBRE.Text, TXT_CODIGODEVARRAS.Text, CNX_MARCAS.Text, COM_SEXO.Text, CNX_TIPO.Text, TXT_PRESIO.Text, LBL_IMGEN.Text, TXTR_CANTIDAD.Text)
            For index As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item("BUTON", index).Value = True Then
                    INT.GUARDAR_PRO_COL(TXT_codigo.Text, DataGridView1.Item("CODIGO", index).Value)
                End If
            Next
            For index1 As Integer = 0 To DataGridView2.Rows.Count - 1
                If DataGridView2.Item("BUTON_TALL", index1).Value = True Then
                    INT.GUARDAR_PRO_TAL(TXT_codigo.Text, DataGridView2.Item("CODIGO_TALL", index1).Value, TXTR_CANTIDAD.Text)
                End If
            Next
        End If
        TXT_NOMBRE.Text = ""
        TXT_codigo.Text = INT.nuevo_PRODUCTO
        DataGridView1.DataSource = INT.CONSULTAR_COLORES
        DataGridView2.DataSource = INT.CONSULTAR_TALLAS
        CNX_MARCAS.Text = ""
        TXT_PRESIO.Text = ""
        TXTR_CANTIDAD.Text = ""
        TXT_CODIGODEVARRAS.Text = ""
        PictureBox1.Image = PictureBox1.Tag
        PictureBox1.BackgroundImage = PictureBox1.Tag

    End Sub

    Private Sub BTN_GUARDAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR.MouseEnter
        BTN_GUARDAR.Height = 69
        BTN_GUARDAR.Width = 65
    End Sub

    Private Sub BTN_GUARDAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR.MouseLeave
        BTN_GUARDAR.Height = 66
        BTN_GUARDAR.Width = 62
    End Sub

    Private Sub BTN_ELIMINAR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.Click
        INT.ELIMINAREMPLEADO(TXT_codigo.Text)
    End Sub

    Private Sub BTN_NUEVO_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_NUEVO.MouseEnter
        BTN_NUEVO.Height = 69
        BTN_NUEVO.Width = 65
    End Sub

    Private Sub BTN_NUEVO_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_NUEVO.MouseLeave
        BTN_NUEVO.Height = 66
        BTN_NUEVO.Width = 62
    End Sub

    Private Sub BTN_BUSCAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.MouseEnter
        BTN_BUSCAR.Height = 69
        BTN_BUSCAR.Width = 65
    End Sub

    Private Sub BTN_BUSCAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.MouseLeave
        BTN_BUSCAR.Height = 66
        BTN_BUSCAR.Width = 62
    End Sub

    Private Sub BTN_MODIFICAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_MODIFICAR.MouseEnter
        BTN_MODIFICAR.Height = 69
        BTN_MODIFICAR.Width = 65
    End Sub

    Private Sub BTN_MODIFICAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_MODIFICAR.MouseLeave
        BTN_MODIFICAR.Height = 66
        BTN_MODIFICAR.Width = 62
    End Sub

    Private Sub BTN_ELIMINAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.MouseEnter
        BTN_ELIMINAR.Height = 69
        BTN_ELIMINAR.Width = 65
    End Sub

    Private Sub BTN_ELIMINAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.MouseLeave
        BTN_ELIMINAR.Height = 66
        BTN_ELIMINAR.Width = 62
    End Sub

    Private Sub BTN_ATRAS_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.MouseEnter
        BTN_ATRAS.Height = 47
        BTN_ATRAS.Width = 46
    End Sub

    Private Sub BTN_ATRAS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.MouseLeave
        BTN_ATRAS.Height = 44
        BTN_ATRAS.Width = 43
    End Sub

    Private Sub BTN_ATRAS_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.Click
        Me.Hide()
        ADMINISTRADOR.Show()
        TXT_NOMBRE.Text = ""
        TXT_CODIGODEVARRAS.Text = ""
        TXT_codigo.Text = ""
        TXT_PRESIO.Text = ""
        TXTR_CANTIDAD.Text = ""
        CNX_MARCAS.DataSource = INT.mostrarPROVEEDOR
        CNX_MARCAS.ValueMember = "codi_prov"
        CNX_MARCAS.DisplayMember = "raz_prov"
        PictureBox1.Image = PictureBox1.Tag
        PictureBox1.BackgroundImage = PictureBox1.Tag
        DataGridView1.DataSource = INT.CONSULTAR_COLORES
        DataGridView2.DataSource = INT.CONSULTAR_TALLAS
        BUSCAR_PRODUCTOS.Visible = True
        TXT_CODIGODEVARRAS.Enabled = True
        TXTR_CANTIDAD.Enabled = True
        CNX_MARCAS.Enabled = True
        CNX_TIPO.Enabled = True
        TXT_PRESIO.Enabled = True
        LinkLabel1.Enabled = True
        DataGridView2.Enabled = True
        DataGridView1.Enabled = True
    End Sub
    Private Sub BTN_AYUDA_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_AYUDA.MouseEnter
        BTN_AYUDA.Height = 44
        BTN_AYUDA.Width = 46
    End Sub
    Private Sub BTN_AYUDA_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_AYUDA.MouseLeave
        BTN_AYUDA.Height = 41
        BTN_AYUDA.Width = 43
    End Sub

    Private Sub BTN_AYUDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_AYUDA.Click
        AYODA.Show()
    End Sub
    Private Sub BTN_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.Click
        BUSCAR_PRODUCTOS.Visible = True
        BUSCAR_PRODUCTOS.Location = New System.Drawing.Point(139, 265)
        TXT_NOMBRE.Text = ""
        TXT_CODIGODEVARRAS.Text = ""
        TXT_codigo.Text = ""
        LBL_IMGEN.Text = ""
        PictureBox1.Image = PictureBox1.Tag
        PictureBox1.BackgroundImage = PictureBox1.Tag
        DataGridView1.DataSource = INT.CONSULTAR_COLORES
        DataGridView2.DataSource = INT.CONSULTAR_TALLAS
    End Sub

    Private Sub BTN_ACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.Click
        INT.BUSCAR_PRODUCTO(TXT_CODIGO_BUSCAR.Text)
        BUSCAR_PRODUCTOS.Visible = False
        TXT_CODIGODEVARRAS.Enabled = False
        TXTR_CANTIDAD.Enabled = False
        CNX_TIPO.Enabled = False
        TXT_PRESIO.Enabled = False
    End Sub

    Private Sub AGREGAR_PRODUCTO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CNX_MARCAS.DataSource = INT.mostrarPROVEEDOR
        CNX_MARCAS.ValueMember = "codi_prov"
        CNX_MARCAS.DisplayMember = "raz_prov"
        DataGridView1.DataSource = INT.CONSULTAR_COLORES
        DataGridView2.DataSource = INT.CONSULTAR_TALLAS

    End Sub

    Private Sub BTN_ACEPTAR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.Click
        Dim A As String = TXT_CODIGO_BUSCAR.Text
        If A = "" Then
            MsgBox("INGRESE EL CODIGO", MsgBoxStyle.Exclamation)
        Else
            INT.BUSCAR_PRODUCTO(TXT_CODIGO_BUSCAR.Text)
        End If
    End Sub

    Private Sub BTN_ACEPTAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.MouseEnter
        BTN_ACEPTAR.Height = 47
        BTN_ACEPTAR.Width = 45
    End Sub

    Private Sub BTN_ACEPTAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.MouseLeave
        BTN_ACEPTAR.Height = 43
        BTN_ACEPTAR.Width = 41
    End Sub
    Private Sub BTN_SALIR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SALIR.MouseEnter
        BTN_SALIR.Height = 47
        BTN_SALIR.Width = 45
    End Sub

    Private Sub BTN_SALIR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SALIR.MouseLeave
        BTN_SALIR.Height = 43
        BTN_SALIR.Width = 41
    End Sub

    Private Sub BTN_SALIR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SALIR.Click
        BUSCAR_PRODUCTOS.Visible = False
        TXT_CODIGODEVARRAS.Enabled = True
        TXTR_CANTIDAD.Enabled = True
        CNX_MARCAS.Enabled = True
        CNX_TIPO.Enabled = True
        TXT_PRESIO.Enabled = True
        LinkLabel1.Enabled = True
        DataGridView2.Enabled = True
        DataGridView1.Enabled = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        With OpenFileDialog1
            .InitialDirectory = "C:"
            .Filter = "jpg|*.jpg|bmp|*.bmp|png|*.png|jpeg|*.jpeg"
        End With
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With PictureBox1
                .Image = Image.FromFile(OpenFileDialog1.FileName)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BorderStyle = BorderStyle.None
            End With
            LBL_IMGEN.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub TXT_PRESIO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_PRESIO.KeyPress
        INT.VALIDAR_NUMEROS(TXT_PRESIO, e)
    End Sub

    Private Sub TXTR_CANTIDAD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTR_CANTIDAD.KeyPress
        INT.VALIDAR_NUMEROS(TXTR_CANTIDAD, e)
    End Sub

    Private Sub TXT_CODIGODEVARRAS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CODIGODEVARRAS.KeyPress
        INT.VALIDAR_NUMEROS(TXT_CODIGODEVARRAS, e)
    End Sub
End Class