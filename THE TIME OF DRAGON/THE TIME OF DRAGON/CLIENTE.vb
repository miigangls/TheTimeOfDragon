Public Class CLIENTE
    Dim INT As New DATOS
    Private Sub BTN_NUEVO_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_NUEVO.MouseEnter
        BTN_NUEVO.Height = 74
        BTN_NUEVO.Width = 65
    End Sub

    Private Sub BTN_NUEVO_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_NUEVO.MouseLeave
        BTN_NUEVO.Height = 70
        BTN_NUEVO.Width = 62
    End Sub

    Private Sub BTN_BUSCAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.MouseEnter
        BTN_BUSCAR.Height = 74
        BTN_BUSCAR.Width = 65
    End Sub

    Private Sub BTN_BUSCAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.MouseLeave
        BTN_BUSCAR.Height = 70
        BTN_BUSCAR.Width = 62
    End Sub

    Private Sub BTN_MODIFICAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_MODIFICAR.MouseEnter
        BTN_MODIFICAR.Height = 74
        BTN_MODIFICAR.Width = 65
    End Sub

    Private Sub BTN_MODIFICAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_MODIFICAR.MouseLeave
        BTN_MODIFICAR.Height = 70
        BTN_MODIFICAR.Width = 62
    End Sub

    Private Sub BTN_ELIMINAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.MouseEnter
        BTN_ELIMINAR.Height = 74
        BTN_ELIMINAR.Width = 65
    End Sub

    Private Sub BTN_ELIMINAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.MouseLeave
        BTN_ELIMINAR.Height = 70
        BTN_ELIMINAR.Width = 62
    End Sub

    Private Sub BTN_ATRAS_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.MouseEnter
        BTN_ATRAS.Height = 45
        BTN_ATRAS.Width = 46
    End Sub

    Private Sub BTN_ATRAS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.MouseLeave
        BTN_ATRAS.Height = 41
        BTN_ATRAS.Width = 43
    End Sub

    Private Sub BTN_GUARDAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR.MouseEnter
        BTN_GUARDAR.Height = 74
        BTN_GUARDAR.Width = 65
    End Sub

    Private Sub BTN_GUARDAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR.MouseLeave
        BTN_GUARDAR.Height = 70
        BTN_GUARDAR.Width = 62
    End Sub

    Private Sub BTN_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR.Click
        'Dim A As String = TXT_codigo.Text
        'Dim B As String = TXT_NOMBRE.Text
        'Dim C As String = TXT_APELLIDOS.Text
        'Dim D As String = TXT_identificacion.Text
        'Dim P As String = TXT_telefonoparticular.Text
        'Dim F As String = TXT_telefonomovil.Text
        'Dim G As String = TXT_ciudad.Text
        'If A = "" And B = "" And C = "" And D = "" And P = "" And F = "" And G = "" And H = "" And I = "" And j = "" And k = "" Then
        '    MsgBox("PRO FAVOR LLENE LOS CAMPOS", MsgBoxStyle.RetryCancel)
        'ElseIf A = "" Then
        '    MsgBox("POR FAVOR INGRESE EL CÓDIGO", MsgBoxStyle.RetryCancel)
        'ElseIf B = "" Then
        '    MsgBox("POR FAVOR INGRESE EL NOMBRE", MsgBoxStyle.RetryCancel)
        'ElseIf C = "" Then
        '    MsgBox("POR FAVOR INGRESE EL APELLIDO", MsgBoxStyle.RetryCancel)
        'ElseIf P = "" Then
        '    MsgBox("POR FAVOR INGRESE EL NUMERO DE TELEFONO", MsgBoxStyle.RetryCancel)
        'ElseIf G = "" Then
        '    MsgBox("POR FAVOR DIGITE EL SALARIO DEL EMPLEADO", MsgBoxStyle.RetryCancel)
        'ElseIf H = "" Then
        '    MsgBox("POR FAVOR SELECCIONE LA CIUDAD", MsgBoxStyle.RetryCancel)
        'ElseIf I = "" Then
        '    MsgBox("POR FAVOR SELECCIONE LA SU CARGO A OCUPAR", MsgBoxStyle.RetryCancel)
        'ElseIf j = "" Then
        '    MsgBox("POR FAVOR DIGITE SU USUARIO", MsgBoxStyle.RetryCancel)
        'ElseIf k = "" Then
        '    MsgBox("POR FAVOR DIGITE SU CONTRASEÑA", MsgBoxStyle.RetryCancel)
        'Else



















        INT.GUARDARCLIENTE(TXT_NOMBRE.Text, TXT_APELLIDOS.Text, TXT_identificacion.Text, TXT_telefonoparticular.Text, TXT_telefonomovil.Text, TXT_direccion.Text, TXT_ciudad.Text)

        'End If
    End Sub

    Private Sub BTN_NUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_NUEVO.Click
        TXT_NOMBRE.Text = ""
        TXT_APELLIDOS.Text = ""
        TXT_identificacion.Text = ""
        TXT_telefonoparticular.Text = ""
        TXT_telefonomovil.Text = ""
        TXT_direccion.Text = ""
        TXT_ciudad.Text = ""
        TXT_codigo.Text = INT.nuevoCLIENTE
    End Sub

    Private Sub BTN_ATRAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.Click
        TXT_NOMBRE.Text = ""
        TXT_APELLIDOS.Text = ""
        TXT_identificacion.Text = ""
        TXT_telefonoparticular.Text = ""
        TXT_telefonomovil.Text = ""
        TXT_direccion.Text = ""
        TXT_ciudad.Text = ""
        TXT_codigo.Text = ""
    End Sub

    Private Sub BTN_AYUDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_AYUDA.Click
        AYODA.Show()
    End Sub

    Private Sub BTN_ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.Click
        INT.ELIMINARCLIENTE(TXT_codigo.Text)
        TXT_NOMBRE.Text = ""
        TXT_APELLIDOS.Text = ""
        TXT_identificacion.Text = ""
        TXT_telefonoparticular.Text = ""
        TXT_telefonomovil.Text = ""
        TXT_direccion.Text = ""
        TXT_ciudad.Text = ""
        TXT_codigo.Text = ""
    End Sub

    Private Sub BTN_MODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_MODIFICAR.Click
        INT.actualizarCLIENTE(TXT_NOMBRE.Text, TXT_APELLIDOS.Text, TXT_identificacion.Text, TXT_telefonoparticular.Text, TXT_telefonomovil.Text, TXT_direccion.Text, TXT_ciudad.Text, TXT_codigo.Text)
    End Sub


    Private Sub BTN_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.Click
        Panel1.Visible = True
    End Sub

    Private Sub CLIENTE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Visible = False
    End Sub

    Private Sub BTN_ACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.Click
        INT.BUSCARCLIENTE(TextBox1.Text)
        TextBox1.Text = ""
        Panel1.Visible = False
        TXT_identificacion.Enabled = False
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
        INT.SALIR()
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

    Private Sub TXT_NOMBRE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_NOMBRE.KeyPress
        INT.VALIDAR_TEXTO(TXT_NOMBRE, e)
    End Sub

    Private Sub TXT_APELLIDOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_APELLIDOS.KeyPress
        INT.VALIDAR_TEXTO(TXT_APELLIDOS, e)
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        INT.VALIDAR_NUMEROS(TextBox1, e)
    End Sub

    Private Sub TXT_identificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_identificacion.KeyPress
        INT.VALIDAR_NUMEROS(TXT_identificacion, e)
    End Sub

    Private Sub TXT_telefonoparticular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_telefonoparticular.KeyPress
        INT.VALIDAR_NUMEROS(TXT_telefonoparticular, e)
    End Sub

    Private Sub TXT_telefonomovil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_telefonomovil.KeyPress
        INT.VALIDAR_NUMEROS(TXT_telefonomovil, e)
    End Sub
End Class