Public Class EMPLEADO
    Dim INT As New DATOS
   
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim A As String
        A = ComboBox1.Text
        If A = "SECCION CAJA" Then
            PictureBox2.BackgroundImage = My.Resources.IMG_SECCION_CAJA1
            PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
            GroupBox1.Size = New System.Drawing.Size(272, 517)
            BTN_ACEPTAR.Location = New System.Drawing.Point(81, 406)
            BTN_SALIR.Location = New System.Drawing.Point(145, 406)
            Label1.Location = New System.Drawing.Point(45, 314)
            Label3.Location = New System.Drawing.Point(107, 197)
            Label4.Location = New System.Drawing.Point(99, 258)
            Label5.Location = New System.Drawing.Point(78, 461)
            Label6.Location = New System.Drawing.Point(24, 489)
            PictureBox2.Location = New System.Drawing.Point(68, 52)
            Me.Size = New System.Drawing.Size(309, 584)

            ComboBox1.Location = New System.Drawing.Point(27, 218)
            TXT_codigo.Location = New System.Drawing.Point(48, 353)
            TXT_USUARIO.Location = New System.Drawing.Point(48, 278)
            PictureBox2.Visible = True
        ElseIf A = "SUPERVISOR " Then
            PictureBox2.BackgroundImage = My.Resources.CELADORES1
            PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
            GroupBox1.Size = New System.Drawing.Size(272, 517)
            BTN_ACEPTAR.Location = New System.Drawing.Point(81, 406)
            BTN_SALIR.Location = New System.Drawing.Point(145, 406)
            Label1.Location = New System.Drawing.Point(45, 314)
            Label3.Location = New System.Drawing.Point(107, 197)
            Label4.Location = New System.Drawing.Point(99, 258)
            Label5.Location = New System.Drawing.Point(78, 461)
            Label6.Location = New System.Drawing.Point(24, 489)
            PictureBox2.Location = New System.Drawing.Point(68, 52)
            Me.Size = New System.Drawing.Size(309, 584)
            ComboBox1.Location = New System.Drawing.Point(27, 218)
            TXT_codigo.Location = New System.Drawing.Point(48, 353)
            TXT_USUARIO.Location = New System.Drawing.Point(48, 278)
            PictureBox2.Visible = True
        ElseIf A = "ATENCION AL CLIENTE" Then
            PictureBox2.BackgroundImage = My.Resources.IMG_ATENCIONCLIENTE1
            PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
            GroupBox1.Size = New System.Drawing.Size(272, 517)
            BTN_ACEPTAR.Location = New System.Drawing.Point(81, 406)
            BTN_SALIR.Location = New System.Drawing.Point(145, 406)
            Label1.Location = New System.Drawing.Point(45, 314)
            Label3.Location = New System.Drawing.Point(107, 197)
            Label4.Location = New System.Drawing.Point(99, 258)
            Label5.Location = New System.Drawing.Point(78, 461)
            Label6.Location = New System.Drawing.Point(24, 489)
            PictureBox2.Location = New System.Drawing.Point(68, 52)
            Me.Size = New System.Drawing.Size(309, 584)
            ComboBox1.Location = New System.Drawing.Point(27, 218)
            TXT_codigo.Location = New System.Drawing.Point(48, 353)
            TXT_USUARIO.Location = New System.Drawing.Point(48, 278)
            PictureBox2.Visible = True
       
        End If
    End Sub
    Private Sub BTN_ACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.Click
        Dim A As String = TXT_codigo.Text
        Dim b As String = TXT_USUARIO.Text
        If A = "" And b = "" Then
            MsgBox("DIGITE EL USUARIO Y CODIGO", MsgBoxStyle.RetryCancel)
        ElseIf b = "" Then
            MsgBox("DIGITE EL USUARIO", MsgBoxStyle.RetryCancel)
        ElseIf A = "" Then
            MsgBox("DIGITE EL CODIGO", MsgBoxStyle.RetryCancel)
        Else
            INT.INGRESO_DE_EMPLEADO(ComboBox1.Text, TXT_USUARIO.Text, TXT_codigo.Text)
        End If
    End Sub
    Private Sub BTN_ACEPTAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.MouseEnter
        BTN_ACEPTAR.Height = 44
        BTN_ACEPTAR.Width = 47
    End Sub
    Private Sub BTN_ACEPTAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.MouseLeave
        BTN_ACEPTAR.Height = 41
        BTN_ACEPTAR.Width = 43
    End Sub
    Private Sub BTN_ATRAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.Click
        Me.Hide()
        INGRESAR.Show()
        GroupBox1.Size = New System.Drawing.Size(272, 189)
        Label3.Location = New System.Drawing.Point(98, 67)
        Me.Size = New System.Drawing.Size(309, 254)
        ComboBox1.Location = New System.Drawing.Point(27, 101)
        PictureBox2.Visible = False
    End Sub
    Private Sub BTN_ATRAS_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.MouseEnter
        BTN_ATRAS.Height = 44
        BTN_ATRAS.Width = 43
    End Sub
    Private Sub BTN_ATRAS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.MouseLeave
        BTN_ATRAS.Height = 41
        BTN_ATRAS.Width = 40
    End Sub
    Private Sub BTN_AYUDA_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_AYUDA.MouseEnter
        BTN_AYUDA.Height = 52
        BTN_AYUDA.Width = 50
    End Sub
    Private Sub BTN_AYUDA_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_AYUDA.MouseLeave
        BTN_AYUDA.Height = 49
        BTN_AYUDA.Width = 47
    End Sub
    Private Sub BTN_SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SALIR.Click
        INT.SALIR()
    End Sub
    Private Sub BTN_SALIR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SALIR.MouseEnter
        BTN_SALIR.Height = 44
        BTN_SALIR.Width = 47
    End Sub
    Private Sub BTN_SALIR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SALIR.MouseLeave
        BTN_SALIR.Height = 41
        BTN_SALIR.Width = 43
    End Sub

    Private Sub BTN_AYUDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_AYUDA.Click
        AYODA.Show()
    End Sub

    Private Sub EMPLEADO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox2.Visible = False
        Label5.Text = Format(Now(), "hh:mm:ss tt")
        Label6.Text = Format(Now(), "dddd, dd' de 'MMMM' de 'yyyy")
    End Sub
End Class