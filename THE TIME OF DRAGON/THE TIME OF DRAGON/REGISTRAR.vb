Public Class REGISTRAR
    Dim int As New DATOS
    'Private Sub BTN_ACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    int.GUARDAR_USUSRIO(TXT_NOMBRE_USUSRIO.Text, TXT_CONTRASEÑA_USURIO.Text, AGRGAPERSONAL.TXT_codigo.Text)
    'End Sub

    Private Sub BTN_SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        INGRESAR.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Panel1.Location = New System.Drawing.Point(2, 12)
        Panel1.Visible = True
        btn_actualizar_contr.Location = New System.Drawing.Point(142, 163)
        btn_actualizar_usurio.Visible = False
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'int.ELIMINAR_ususario(TXT_NOMBRE_USUSRIO.Text)
        int.actualizar_USURIO(TextBox4.Text, TextBox2.Text)


    End Sub

    Private Sub REGISTRAR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Visible = False
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel1.Visible = False
    End Sub

    Private Sub PictureBox3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SALIR.Click
        Me.Close()
        INGRESAR.Show()
        INGRESAR.BTN_REGISTRAR.Visible = False
        AGRGAPERSONAL.Close()
    End Sub

    Private Sub BTN_ACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.Click
        Dim A As String = TXT_NOMBRE_USUSRIO.Text
        Dim B As String = TXT_CONTRASEÑA_USURIO.Text
        Dim C As String = CNX_CARGO.Text
        Dim D As String = AGRGAPERSONAL.TXT_codigo.Text
        Dim P As String = AGRGAPERSONAL.TXT_NOMBRE.Text
        Dim G As String = AGRGAPERSONAL.TXT_APELLIDOS.Text
        Dim H As String = AGRGAPERSONAL.TXT_identificacion.Text
        Dim I As String = AGRGAPERSONAL.TXT_telefonoparticular.Text
        Dim J As String = AGRGAPERSONAL.TXT_telefonomovil.Text
        Dim K As String = AGRGAPERSONAL.TXT_salario.Text
        Dim L As String = AGRGAPERSONAL.TXT_ciudad.Text
        Dim M As String = AGRGAPERSONAL.ComboBox1.Text
        If A = "" And B = "" And C = "" And D = "" And P = "" And G = "" And H = "" And I = "" And J = "" And K = "" And L = "" And M = "" Then
            MsgBox("PRO FAVOR LLENE LOS CAMPOS", MsgBoxStyle.MsgBoxRtlReading)
        ElseIf A = "" Then
            MsgBox("DIGITE AL USURIO", MsgBoxStyle.RetryCancel)
        ElseIf B = "" Then
            MsgBox("DIGITE AL CONTRASEÑA", MsgBoxStyle.RetryCancel)
        ElseIf B = "" Then
            MsgBox("DIGITE AL CARGO", MsgBoxStyle.RetryCancel)
        ElseIf D = "" Then
            MsgBox("PRO FAVOR ESCRIBA EL CÓDIGO", MsgBoxStyle.RetryCancel)
        ElseIf P = "" Then
            MsgBox("PRO FAVOR ESCRIBA EL NOMBRE", MsgBoxStyle.RetryCancel)
        ElseIf G = "" Then
            MsgBox("PRO FAVOR ESCRIBA EL APELLIDO", MsgBoxStyle.RetryCancel)
        ElseIf H = "" Then
            MsgBox("PRO FAVOR ESCRIBA EL NUMERO DE TELEFONO", MsgBoxStyle.RetryCancel)
        ElseIf I = "" Then
            MsgBox("PRO FAVOR ESCRIBA EL NUMERO DE CELULAR", MsgBoxStyle.RetryCancel)
        ElseIf J = "" Then
            MsgBox("PRO FAVOR SELECCIONE LA CIUDAD", MsgBoxStyle.RetryCancel)
        ElseIf K = "" Then
            MsgBox("PRO FAVOR ESCRIBA EL SALARIO", MsgBoxStyle.RetryCancel)
        ElseIf K = "" Then
            MsgBox("PRO FAVOR SELECCIONE LA SU CARGO A OCUPAR", MsgBoxStyle.RetryCancel)
        Else
            int.GUARDAREMPLEADO_regiatro(AGRGAPERSONAL.TXT_NOMBRE.Text, AGRGAPERSONAL.TXT_APELLIDOS.Text, AGRGAPERSONAL.TXT_identificacion.Text, AGRGAPERSONAL.TXT_telefonoparticular.Text, AGRGAPERSONAL.TXT_telefonomovil.Text, AGRGAPERSONAL.TXT_direccion.Text, AGRGAPERSONAL.TXT_ciudad.Text, AGRGAPERSONAL.TXT_coreo.Text, AGRGAPERSONAL.TXT_salario.Text)
            int.GUARDAR_USUSRIO(TXT_NOMBRE_USUSRIO.Text, TXT_CONTRASEÑA_USURIO.Text, AGRGAPERSONAL.TXT_codigo.Text, CNX_CARGO.Text)
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

    Private Sub BTN_SALIR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SALIR.MouseEnter
        BTN_SALIR.Height = 44
        BTN_SALIR.Width = 47
    End Sub

    Private Sub BTN_SALIR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SALIR.MouseLeave
        BTN_SALIR.Height = 41
        BTN_SALIR.Width = 43
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Panel1.Visible = True
        btn_actualizar_usurio.Location = New System.Drawing.Point(142, 163)
        btn_actualizar_contr.Visible = False
    End Sub
End Class