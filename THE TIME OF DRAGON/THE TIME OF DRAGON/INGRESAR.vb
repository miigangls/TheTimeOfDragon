Public Class INGRESAR
    Dim A As String
    Dim INT As New DATOS

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        INT.VALIDAR_TEXTOYNUMEROS(ComboBox1, e)
    End Sub
    Private Sub INGRESAR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = Label3.Text + My.Computer.Clock.LocalTime.Date
        BTN_ACEPTAR.Visible = False
        BTN_SALIR.Visible = False
    End Sub

    Private Sub TXT_INGRECECONTRACEÑA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        INT.VALIDAR_NUMEROS(TXT_INGRECECONTRACEÑA, e)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.Click
        Dim A As String
        Dim b As String = TXT_USUARIO.Text
        Dim c As String = TXT_INGRECECONTRACEÑA.Text
        A = ComboBox1.Text
        If  A = "ADMINISTRADOR" Then
            If b = "" And c = "" Then
                MsgBox("POR FAVOR INGRESA TU NUMBRE DE USUARIOY CONTRASEÑA")
            ElseIf b = "" Then
                MsgBox("POR FAVOR INGRESA TU NUMBRE DE USUARIO")
            ElseIf c = "" Then
                MsgBox("POR FAVOR INGRESA TU CONTRASEÑA")
            Else
                INT.INGRESO_DE_ADMINISTRADOR(ComboBox1.Text, TXT_USUARIO.Text, TXT_INGRECECONTRACEÑA.Text)
            End If
        ElseIf A = "EMPLEADO" Then
            BTN_ACEPTAR.Cursor = Cursors.WaitCursor
            For X = 1 To 100
                ProgressBar1.Value = X
                Label5.Text = X
                Application.DoEvents()
                System.Threading.Thread.Sleep(10)
            Next
            Me.Close()
            EMPLEADO.Show()
            Timer1.Start()
        End If
        Dim instancia = New CONEXIONSQL()
        instancia.conectar()
    End Sub

    Private Sub ComboBox1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress

        INT.VALIDAR_TEXTOYNUMEROS(ComboBox1, e)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        A = ComboBox1.Text
        If A = "ADMINISTRADOR" Then
            TXT_INGRECECONTRACEÑA.Visible = True
            TXT_USUARIO.Visible = True
            Label2.Visible = True
            Label1.Visible = True
            ProgressBar1.Visible = True
            Label5.Visible = True
            Label4.Visible = True
            PictureBox1.BackgroundImage = My.Resources.User_2
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
            Me.Size = New System.Drawing.Size(312, 533)
            GroupBox1.Size = New System.Drawing.Size(272, 471)
            BTN_REGISTRAR.Location = New System.Drawing.Point(221, 20)
            BTN_ACEPTAR.Location = New System.Drawing.Point(81, 350)
            BTN_SALIR.Location = New System.Drawing.Point(161, 350)
            Label5.Location = New System.Drawing.Point(37, 409)
            ProgressBar1.Location = New System.Drawing.Point(89, 409)
            Label3.Location = New System.Drawing.Point(77, 449)
            Label4.Location = New System.Drawing.Point(96, 210)
            PictureBox1.Location = New System.Drawing.Point(81, 30)
            Label2.Location = New System.Drawing.Point(78, 157)
            ComboBox1.Location = New System.Drawing.Point(55, 175)
            Label1.Location = New System.Drawing.Point(80, 276)
            TXT_INGRECECONTRACEÑA.Location = New System.Drawing.Point(55, 309)
            TXT_USUARIO.Location = New System.Drawing.Point(55, 241)
            BTN_ACEPTAR.Visible = True
            BTN_SALIR.Visible = True
        ElseIf A = "EMPLEADO" Then
            TXT_INGRECECONTRACEÑA.Visible = False
            TXT_USUARIO.Visible = False
            Label2.Visible = False
            Label1.Visible = False
            ProgressBar1.Visible = False
            Label5.Visible = False
            Label4.Visible = False
            PictureBox1.BackgroundImage = My.Resources.IMG_EMPLEADO
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
            BTN_ACEPTAR.Location = New System.Drawing.Point(80, 213)
            BTN_SALIR.Location = New System.Drawing.Point(163, 213)
            Label5.Location = New System.Drawing.Point(43, 267)
            ProgressBar1.Location = New System.Drawing.Point(86, 267)
            Me.Size = New System.Drawing.Size(321, 380)
            GroupBox1.Size = New System.Drawing.Size(271, 322)
            Label3.Location = New System.Drawing.Point(94, 294)
            ComboBox1.Location = New System.Drawing.Point(54, 172)
            Label2.Location = New System.Drawing.Point(83, 154)
            BTN_ACEPTAR.Visible = True
            BTN_SALIR.Visible = True
        ElseIf A <> "ADMINISTRADOR" Or A <> "EMPLEADO" Then
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
            BTN_ACEPTAR.Visible = False
            BTN_SALIR.Visible = False
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SALIR.Click
        INT.SALIR()
    End Sub

    Private Sub BTN_ACEPTAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.MouseEnter
        BTN_ACEPTAR.Height = 44
        BTN_ACEPTAR.Width = 47
    End Sub

    Private Sub BTN_ACEPTAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.MouseLeave
        BTN_ACEPTAR.Height = 41
        BTN_ACEPTAR.Width = 43
    End Sub

    Private Sub BTN_SALIR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SALIR.MouseEnter
        BTN_SALIR.Height = 44
        BTN_SALIR.Width = 47
    End Sub

    Private Sub BTN_SALIR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SALIR.MouseLeave
        BTN_SALIR.Height = 41
        BTN_SALIR.Width = 43
    End Sub
    Private Sub PictureBox2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_REGISTRAR.Click
        Me.Hide()
        AGRGAPERSONAL.Show()
        REGISTRAR.Show()
        AGRGAPERSONAL.BTN_GUARDAR.Enabled = False
        AGRGAPERSONAL.BTN_ATRAS.Enabled = False
        AGRGAPERSONAL.BTN_ACEPTAR.Enabled = False
        AGRGAPERSONAL.BTN_AYUDA.Enabled = False
        AGRGAPERSONAL.BTN_BUSCAR.Enabled = False
        AGRGAPERSONAL.BTN_BUSCAR.Enabled = False
        AGRGAPERSONAL.BTN_ELIMINAR.Enabled = False
        AGRGAPERSONAL.BTN_MODIFICAR.Enabled = False
        AGRGAPERSONAL.BTN_ULTIMO.Enabled = False
        AGRGAPERSONAL.BTN_PRIMERA.Enabled = False
        AGRGAPERSONAL.BTN_SALIR.Enabled = False
        AGRGAPERSONAL.BUSCAR_EMPLEADO.Enabled = False
        AGRGAPERSONAL.BTN_SIGUENTE.Enabled = False
        AGRGAPERSONAL.BTN_ANTERIOR.Enabled = False
        AGRGAPERSONAL.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub
    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_REGISTRAR.MouseEnter
        BTN_REGISTRAR.Height = 44
        BTN_REGISTRAR.Width = 47
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_REGISTRAR.MouseLeave
        BTN_REGISTRAR.Height = 41
        BTN_REGISTRAR.Width = 43
    End Sub
End Class