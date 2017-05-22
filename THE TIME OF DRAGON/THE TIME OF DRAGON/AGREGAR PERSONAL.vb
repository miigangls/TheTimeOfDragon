Public Class AGRGAPERSONAL
    Dim a As String
    Friend instancia As New DATOS
    Private Sub BTN_ATRAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        ADMINISTRADOR.Show()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim a As String
        a = ComboBox1.Text
        If a = "SECCION CAJA" Then
            PictureBox1.BackgroundImage = My.Resources.IMG_SECCION_CAJA1
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf a = "SUPERVISOR BODEGA" Then
            PictureBox1.BackgroundImage = My.Resources.CELADORES1
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf a = "ATENCION AL CLIENTE" Then
            PictureBox1.BackgroundImage = My.Resources.IMG_ATENCIONCLIENTE1
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch

        ElseIf a = "SECCION BODEGA" Then
            PictureBox1.BackgroundImage = My.Resources.IMG_BODEGA1
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub
    Private Sub TXT_codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        instancia.VALIDAR_NUMEROS(TXT_codigo, e)
    End Sub
    Private Sub TXT_identificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        instancia.VALIDAR_NUMEROS(TXT_identificacion, e)
    End Sub
    Private Sub TXT_telefonoparticular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        instancia.VALIDAR_NUMEROS(TXT_telefonoparticular, e)
    End Sub
    Private Sub TXT_telefonomovil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        instancia.VALIDAR_NUMEROS(TXT_telefonomovil, e)
    End Sub
    Private Sub TXT_salario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        instancia.VALIDAR_NUMEROS(TXT_salario, e)
    End Sub
    Private Sub TXT_NOMBRE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        instancia.VALIDAR_TEXTO(TXT_NOMBRE, e)
    End Sub
    Private Sub TXT_APELLIDOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        instancia.VALIDAR_TEXTO(TXT_APELLIDOS, e)
    End Sub

    Private Sub BTN_MODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_MODIFICAR.Click
        instancia.actualizarEMPLEADO(TXT_NOMBRE.Text, TXT_APELLIDOS.Text, TXT_identificacion.Text, TXT_telefonoparticular.Text, TXT_telefonomovil.Text, TXT_direccion.Text, TXT_ciudad.Text, TXT_coreo.Text, TXT_salario.Text, TXT_codigo.Text)
    End Sub

    Private Sub BTN_ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.Click
        instancia.ELIMINAREMPLEADO(TXT_codigo.Text)
    End Sub

    Private Sub BTN_SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub BTN_PRIMERA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PRIMERA.Click
        instancia.PrimeraEMPLEADO()
    End Sub

    Private Sub BTN_ANTERIOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ANTERIOR.Click
        instancia.AnteriorEMPLEADO()
    End Sub
    Private Sub BTN_SIGUENTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SIGUENTE.Click
        instancia.SiguienteEMPLEADO()
    End Sub

    Private Sub BTN_ULTIMO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ULTIMO.Click
        instancia.UltimaEMPLEADO()
    End Sub

    Private Sub BTN_NUEVO_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_NUEVO.Click
        TXT_NOMBRE.Text = ""
        TXT_APELLIDOS.Text = ""
        TXT_identificacion.Text = ""
        TXT_telefonoparticular.Text = ""
        TXT_telefonomovil.Text = ""
        TXT_direccion.Text = ""
        TXT_ciudad.Text = ""
        TXT_codigo.Text = instancia.nuevoEMPLEADO
        TXT_coreo.Text = ""
        TXT_salario.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub BTN_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR.Click
        Dim A As String = TXT_codigo.Text
        Dim B As String = TXT_NOMBRE.Text
        Dim C As String = TXT_APELLIDOS.Text
        Dim D As String = TXT_identificacion.Text
        Dim P As String = TXT_telefonoparticular.Text
        Dim F As String = TXT_telefonomovil.Text
        Dim G As String = TXT_salario.Text
        Dim H As String = TXT_ciudad.Text
        Dim I As String = ComboBox1.Text
        Dim j As String = REGISTRAR.TXT_NOMBRE_USUSRIO.Text
        Dim k As String = REGISTRAR.TXT_CONTRASEÑA_USURIO.Text
        If A = "" And B = "" And C = "" And D = "" And P = "" And F = "" And G = "" And H = "" And I = "" And j = "" And k = "" Then
            MsgBox("PRO FAVOR LLENE LOS CAMPOS", MsgBoxStyle.RetryCancel)
        ElseIf A = "" Then
            MsgBox("POR FAVOR INGRESE EL CÓDIGO", MsgBoxStyle.RetryCancel)
        ElseIf B = "" Then
            MsgBox("POR FAVOR INGRESE EL NOMBRE", MsgBoxStyle.RetryCancel)
        ElseIf C = "" Then
            MsgBox("POR FAVOR INGRESE EL APELLIDO", MsgBoxStyle.RetryCancel)
        ElseIf P = "" Then
            MsgBox("POR FAVOR INGRESE EL NUMERO DE TELEFONO", MsgBoxStyle.RetryCancel)
        ElseIf G = "" Then
            MsgBox("POR FAVOR DIGITE EL SALARIO DEL EMPLEADO", MsgBoxStyle.RetryCancel)
        ElseIf H = "" Then
            MsgBox("POR FAVOR SELECCIONE LA CIUDAD", MsgBoxStyle.RetryCancel)
        ElseIf I = "" Then
            MsgBox("POR FAVOR SELECCIONE LA SU CARGO A OCUPAR", MsgBoxStyle.RetryCancel)
        ElseIf j = "" Then
            MsgBox("POR FAVOR DIGITE SU USUARIO", MsgBoxStyle.RetryCancel)
        ElseIf k = "" Then
            MsgBox("POR FAVOR DIGITE SU CONTRASEÑA", MsgBoxStyle.RetryCancel)
        Else
            instancia.GUARDAREMPLEADO(TXT_NOMBRE.Text, TXT_APELLIDOS.Text, TXT_identificacion.Text, TXT_telefonoparticular.Text, TXT_telefonomovil.Text, TXT_direccion.Text, TXT_ciudad.Text, TXT_coreo.Text, TXT_salario.Text)
            instancia.GUARDAR_USUSRIO_empleado(REGISTRAR.TXT_NOMBRE_USUSRIO.Text, REGISTRAR.TXT_CONTRASEÑA_USURIO.Text, TXT_codigo.Text, ComboBox1.Text)
        End If
    End Sub

    Private Sub BTN_GUARDAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR.MouseEnter
        BTN_GUARDAR.Height = 69
        BTN_GUARDAR.Width = 65
    End Sub

    Private Sub BTN_GUARDAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR.MouseLeave
        BTN_GUARDAR.Height = 66
        BTN_GUARDAR.Width = 62
    End Sub

    Private Sub BTN_ELIMINAR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        instancia.ELIMINAREMPLEADO(TXT_codigo.Text)
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
        BTN_ANTERIOR.Enabled = True
        BTN_SIGUENTE.Enabled = True
        BTN_PRIMERA.Enabled = True
        BTN_ULTIMO.Enabled = True
        Me.Hide()
        ADMINISTRADOR.Show()
        TXT_NOMBRE.Text = ""
        TXT_APELLIDOS.Text = ""
        TXT_identificacion.Text = ""
        TXT_telefonoparticular.Text = ""
        TXT_telefonomovil.Text = ""
        TXT_direccion.Text = ""
        TXT_ciudad.Text = ""
        TXT_codigo.Text = ""
        TXT_coreo.Text = ""
        TXT_salario.Text = ""
        REGISTRAR.Close()
    End Sub

    Private Sub BTN_ULTIMO_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ULTIMO.MouseEnter
        BTN_ULTIMO.Height = 47
        BTN_ULTIMO.Width = 46
    End Sub

    Private Sub BTN_ULTIMO_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ULTIMO.MouseLeave
        BTN_ULTIMO.Height = 44
        BTN_ULTIMO.Width = 43
    End Sub

    Private Sub BTN_SIGUENTE_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SIGUENTE.MouseEnter
        BTN_SIGUENTE.Height = 47
        BTN_SIGUENTE.Width = 46
    End Sub

    Private Sub BTN_SIGUENTE_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SIGUENTE.MouseLeave
        BTN_SIGUENTE.Height = 44
        BTN_SIGUENTE.Width = 43
    End Sub

    Private Sub BTN_ANTERIOR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ANTERIOR.MouseEnter
        BTN_ANTERIOR.Height = 47
        BTN_ANTERIOR.Width = 46
    End Sub

    Private Sub BTN_ANTERIOR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ANTERIOR.MouseLeave
        BTN_ANTERIOR.Height = 44
        BTN_ANTERIOR.Width = 43
    End Sub
    Private Sub BTN_PRIMERA_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_PRIMERA.MouseEnter
        BTN_PRIMERA.Height = 47
        BTN_PRIMERA.Width = 46
    End Sub

    Private Sub BTN_PRIMERA_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_PRIMERA.MouseLeave
        BTN_PRIMERA.Height = 44
        BTN_PRIMERA.Width = 43
    End Sub

    Private Sub BTN_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.Click
        BUSCAR_EMPLEADO.Visible = True
        BUSCAR_EMPLEADO.Location = New System.Drawing.Point(146, 155)
        BTN_ANTERIOR.Enabled = False
        BTN_SIGUENTE.Enabled = False
        BTN_PRIMERA.Enabled = False
        BTN_ULTIMO.Enabled = False
        TXT_NOMBRE.Text = ""
        TXT_APELLIDOS.Text = ""
        TXT_identificacion.Text = ""
        TXT_telefonoparticular.Text = ""
        TXT_telefonomovil.Text = ""
        TXT_direccion.Text = ""
        TXT_ciudad.Text = ""
        TXT_codigo.Text = ""
        TXT_coreo.Text = ""
        TXT_salario.Text = ""
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

    Private Sub ComboBox1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        instancia.VALIDAR_TEXTOYNUMEROS(ComboBox1, e)
    End Sub

    Private Sub TXT_NOMBRE_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_NOMBRE.KeyPress
        instancia.VALIDAR_TEXTO(TXT_NOMBRE, e)
    End Sub

    Private Sub TXT_APELLIDOS_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_APELLIDOS.KeyPress
        instancia.VALIDAR_TEXTO(TXT_APELLIDOS, e)
    End Sub

    Private Sub TXT_identificacion_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_identificacion.KeyPress
        instancia.VALIDAR_NUMEROS(TXT_identificacion, e)
    End Sub



    Private Sub TXT_telefonoparticular_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_telefonoparticular.KeyPress
        instancia.VALIDAR_NUMEROS(TXT_telefonoparticular, e)
    End Sub

    Private Sub TXT_telefonomovil_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_telefonomovil.KeyPress
        instancia.VALIDAR_NUMEROS(TXT_telefonomovil, e)
    End Sub
    Private Sub TXT_salario_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_salario.KeyPress
        instancia.VALIDAR_NUMEROS(TXT_salario, e)
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        OpenFileDialog1.ShowDialog()
        Label1.Text = OpenFileDialog1.FileName.ToString
        PictureBox1.Image = System.Drawing.Image.FromFile(Label1.Text)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim a As String
        a = ComboBox1.Text
        If a = "" Then
            PictureBox1.BackgroundImage = My.Resources.User_2
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf a = "SECCION CAJA" Then
            PictureBox1.BackgroundImage = My.Resources.IMG_SECCION_CAJA1
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf a = "SUPERVISOR" Then
            PictureBox1.BackgroundImage = My.Resources.CELADORES1
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf a = "ATENCION AL CLIENTE" Then
            PictureBox1.BackgroundImage = My.Resources.IMG_ATENCIONCLIENTE1
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        End If
        '        SECCION(CAJA)
        'ATENCION AL CLIENTE
        '        SUPERVISOR()
    End Sub

    Private Sub AGRGAPERSONAL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BUSCAR_EMPLEADO.Visible = False
        ComboBox1.Text = REGISTRAR.CNX_CARGO.Text
    End Sub

    Private Sub BTN_ACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.Click
        Dim B As String = Me.TXT_codigo_buscar.Text
        If B = "" Then
            MsgBox("INGRESE EL CODIGO A BUSCAR", MsgBoxStyle.Exclamation)
        Else
            instancia.BUSCAREMPLEADO(TXT_codigo_buscar.Text)
            BUSCAR_EMPLEADO.Visible = False
            Me.BTN_ANTERIOR.Enabled = False
            Me.BTN_SIGUENTE.Enabled = False
            Me.BTN_PRIMERA.Enabled = False
            Me.BTN_ULTIMO.Enabled = False
            TXT_identificacion.Enabled = False
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

    Private Sub BTN_SALIR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SALIR.Click
        BUSCAR_EMPLEADO.Visible = False
        TXT_identificacion.Enabled = True
    End Sub
    Private Sub BTN_SALIR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SALIR.MouseEnter
        BTN_SALIR.Height = 47
        BTN_SALIR.Width = 45
    End Sub

    Private Sub BTN_SALIR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SALIR.MouseLeave
        BTN_SALIR.Height = 43
        BTN_SALIR.Width = 41
    End Sub
End Class
