Public Class AGREGAR_PROVEEDOR
    Dim INT As New DATOS
  
    Private Sub TXT_RAZON_SOCIAL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_RAZON_SOCIAL.KeyPress
        INT.VALIDAR_TEXTO(TXT_RAZON_SOCIAL, e)
    End Sub
    Private Sub TXT_NIT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_NIT.KeyPress
        INT.VALIDAR_NUMEROS(TXT_NIT, e)
    End Sub
    Private Sub TXT_telefonoparticular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_telefonoparticular.KeyPress
        INT.VALIDAR_NUMEROS(TXT_telefonoparticular, e)
    End Sub
    Private Sub TXT_telefonofax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_telefonofax.KeyPress
        INT.VALIDAR_NUMEROS(TXT_telefonofax, e)
    End Sub
    Private Sub BTN_GUARDAR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR.Click
        Dim A As String = TXT_codigo.Text
        Dim B As String = TXT_NIT.Text
        Dim C As String = TXT_RAZON_SOCIAL.Text
        Dim P As String = TXT_telefonoparticular.Text
        Dim F As String = TXT_telefonofax.Text
        Dim G As String = TXT_direccion.Text
        Dim H As String = TXT_ciudad.Text
        If A = "" And B = "" And C = "" And F = "" And P = "" And G = "" And H = "" Then
            MsgBox("PRO FAVOR LLENE LOS CAMPOS", MsgBoxStyle.MsgBoxRtlReading)
        ElseIf A = "" Then
            MsgBox("POR FAVOR DE CLIK EN NUMBO PARA CONTINUAR", MsgBoxStyle.RetryCancel)
        ElseIf B = "" Then
            MsgBox("POR FAVOR ESCRIBA EN NIT DE LA EMPRESA", MsgBoxStyle.RetryCancel)
        ElseIf C = "" Then
            MsgBox("POR FAVOR ESCRIBA EN RAZON SOCIAL DE LA EMPRESA", MsgBoxStyle.RetryCancel)
        ElseIf F = "" Then
            MsgBox("POR FAVOR ESCRIBA EN NUMERO FAX DE LA EMPRESA", MsgBoxStyle.RetryCancel)
        ElseIf P = "" Then
            MsgBox("POR FAVOR ESCRIBA EN NUMERO TELEFONO DE LA EMPRESA", MsgBoxStyle.RetryCancel)
        ElseIf G = "" Then
            MsgBox("POR FAVOR ESCRIBA EN DIRECCION DE LA EMPRESA", MsgBoxStyle.RetryCancel)
        ElseIf H = "" Then
            MsgBox("PRO FAVOR SELECCIONE LA CIUDAD DE LA EMPRESA", MsgBoxStyle.RetryCancel)
        Else
            INT.GUARDARPROVEEDOR(TXT_RAZON_SOCIAL.Text, TXT_NIT.Text, TXT_telefonoparticular.Text, TXT_telefonofax.Text, TXT_direccion.Text, TXT_ciudad.Text, LBL_IMGEN.Text, TXT_PAGINAWEP.Text)
            TXT_RAZON_SOCIAL.Text = ""
            TXT_NIT.Text = ""
            TXT_ciudad.Text = ""
            TXT_telefonoparticular.Text = ""
            TXT_telefonofax.Text = ""
            TXT_direccion.Text = ""
            TXT_ciudad.Text = ""
            TXT_codigo.Text = INT.nuevoPROVEEDOR
            TXT_PAGINAWEP.Text = ""
            LBL_IMGEN.Text = ""
            PictureBox1.Image = PictureBox1.Tag
            PictureBox1.BackgroundImage = PictureBox1.Tag
        End If
    End Sub
    Private Sub BTN_NUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_NUEVO.Click
        TXT_RAZON_SOCIAL.Text = ""
        TXT_NIT.Text = ""
        TXT_ciudad.Text = ""
        TXT_NIT.Enabled = True
        TXT_telefonoparticular.Text = ""
        TXT_telefonofax.Text = ""
        TXT_direccion.Text = ""
        TXT_ciudad.Text = ""
        TXT_codigo.Text = INT.nuevoPROVEEDOR
        TXT_PAGINAWEP.Text = ""
        LBL_IMGEN.Text = ""
        PictureBox1.Image = PictureBox1.Tag
        PictureBox1.BackgroundImage = PictureBox1.Tag
    End Sub
    Private Sub BTN_BUSCAR_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.Click
        BUSCAR_PROVEEDOR.Visible = True
        BTN_ANTERIOR.Enabled = False
        BTN_SIGUENTE.Enabled = False
        BTN_PRIMERA.Enabled = False
        BTN_ULTIMO.Enabled = False
        TXT_RAZON_SOCIAL.Text = ""
        TXT_NIT.Text = ""
        TXT_ciudad.Text = ""
        TXT_telefonoparticular.Text = ""
        TXT_telefonofax.Text = ""
        TXT_direccion.Text = ""
        TXT_ciudad.Text = ""
        TXT_codigo.Text = ""
        TXT_PAGINAWEP.Text = ""
        LBL_IMGEN.Text = ""
        PictureBox1.Image = PictureBox1.Tag
        PictureBox1.BackgroundImage = PictureBox1.Tag
    End Sub
    Private Sub BTN_MODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_MODIFICAR.Click
        INT.actualizarPROVEEDOR(TXT_RAZON_SOCIAL.Text, TXT_NIT.Text, TXT_telefonoparticular.Text, TXT_telefonofax.Text, TXT_direccion.Text, TXT_ciudad.Text, LBL_IMGEN.Text, TXT_PAGINAWEP.Text, TXT_codigo.Text)
    End Sub
    Private Sub BIM_ATRAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.Click
        Me.Hide()
        ADMINISTRADOR.Show()
        BTN_ANTERIOR.Enabled = True
        BTN_SIGUENTE.Enabled = True
        BTN_PRIMERA.Enabled = True
        BTN_ULTIMO.Enabled = True
        TXT_RAZON_SOCIAL.Text = ""
        TXT_NIT.Text = ""
        TXT_ciudad.Text = ""
        TXT_telefonoparticular.Text = ""
        TXT_telefonofax.Text = ""
        TXT_direccion.Text = ""
        TXT_ciudad.Text = ""
        TXT_codigo.Text = ""
        TXT_PAGINAWEP.Text = ""
        PictureBox1.Image = PictureBox1.Tag
        PictureBox1.BackgroundImage = PictureBox1.Tag
    End Sub
    Private Sub BTN_PRIMERA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PRIMERA.Click
        INT.Primeraproveedor()
    End Sub
    Private Sub BTN_ANTERIOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ANTERIOR.Click
        INT.Anteriorproveedor()
    End Sub
    Private Sub BTN_SIGUENTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SIGUENTE.Click
        INT.Siguienteproveedor()
    End Sub
    Private Sub BTN_ULTIMO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ULTIMO.Click
        INT.Ultimaproveedor()
    End Sub
    Private Sub BTN_GUARDAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR.MouseEnter
        BTN_GUARDAR.Height = 69
        BTN_GUARDAR.Width = 65
    End Sub
    Private Sub BTN_GUARDAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR.MouseLeave
        BTN_GUARDAR.Height = 66
        BTN_GUARDAR.Width = 62
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
    Private Sub BIM_ATRAS_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.MouseEnter
        BTN_ATRAS.Height = 53
        BTN_ATRAS.Width = 39
    End Sub
    Private Sub BIM_ATRAS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.MouseLeave
        BTN_ATRAS.Height = 50
        BTN_ATRAS.Width = 36
    End Sub
    Private Sub BTN_ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.Click
        INT.ELIMINARPROVEEDOR(TXT_codigo.Text)
    End Sub
    Private Sub BTN_AYUDA_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_AYUDA.MouseEnter
        BTN_AYUDA.Height = 44
        BTN_AYUDA.Width = 46
    End Sub
    Private Sub BTN_AYUDA_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_AYUDA.MouseLeave
        BTN_AYUDA.Height = 41
        BTN_AYUDA.Width = 43
    End Sub
    Private Sub BTN_PRIMERA_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_PRIMERA.MouseEnter
        BTN_PRIMERA.Height = 56
        BTN_PRIMERA.Width = 52
    End Sub
    Private Sub BTN_PRIMERA_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_PRIMERA.MouseLeave
        BTN_PRIMERA.Height = 53
        BTN_PRIMERA.Width = 49
    End Sub
    Private Sub BTN_ULTIMO_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ULTIMO.MouseEnter
        BTN_ULTIMO.Height = 56
        BTN_ULTIMO.Width = 51
    End Sub
    Private Sub BTN_ULTIMO_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ULTIMO.MouseLeave
        BTN_ULTIMO.Height = 53
        BTN_ULTIMO.Width = 49
    End Sub
    Private Sub BTN_SIGUENTE_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SIGUENTE.MouseEnter
        BTN_SIGUENTE.Height = 56
        BTN_SIGUENTE.Width = 51
    End Sub
    Private Sub BTN_SIGUENTE_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SIGUENTE.MouseLeave
        BTN_SIGUENTE.Height = 53
        BTN_SIGUENTE.Width = 49
    End Sub
    Private Sub BTN_ANTERIOR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ANTERIOR.MouseEnter
        BTN_ANTERIOR.Height = 56
        BTN_ANTERIOR.Width = 51
    End Sub
    Private Sub BTN_ANTERIOR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ANTERIOR.MouseLeave
        BTN_ANTERIOR.Height = 53
        BTN_ANTERIOR.Width = 49
    End Sub

    Private Sub TXT_RAZON_SOCIAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_RAZON_SOCIAL.TextChanged

    End Sub

    Private Sub BTN_ACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.Click
        Dim B As String = Me.TXT_CODIGO_BUSCAR.Text
        If B = "" Then
            MsgBox("INGRESE EL CODIGO A BUSCCAR", MsgBoxStyle.Exclamation)
        Else
            Dim TABLA As New DataTable

            protal.DataSource = INT.CARGAR_COMPRA_PROVEEDOR(TXT_CODIGO_BUSCAR.Text)
            INT.BUSCARPROVEEDOR(TXT_CODIGO_BUSCAR.Text)
            TXT_NIT.Enabled = False
            BUSCAR_PROVEEDOR.Visible = False
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
    Private Sub BTN_SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SALIR.Click
        BUSCAR_PROVEEDOR.Visible = False
        TXT_NIT.Enabled = True
    End Sub

    Private Sub BTN_SALIR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SALIR.MouseEnter
        BTN_SALIR.Height = 47
        BTN_SALIR.Width = 45
    End Sub

    Private Sub BTN_SALIR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SALIR.MouseLeave
        BTN_SALIR.Height = 43
        BTN_SALIR.Width = 41
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
End Class