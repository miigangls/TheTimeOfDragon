Public Class Productos
    Dim int As New DATOS

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
    Private Sub BTN_ACEPTAR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.Click
        Dim A As String = TXT_NOMBRE_BUSCAR.Text
        If A = "" Then
            MsgBox("INGRESE EL NOMBRE", MsgBoxStyle.Exclamation)
        Else
            int.BUSCAR_PRODUCTO_PRODUCTOS(TXT_NOMBRE_BUSCAR.SelectedValue)
            BUSCAR_PRODUCTOS.Visible = False
        End If
    End Sub

    Private Sub Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = int.CONSULTAR_COLORES
        DataGridView2.DataSource = int.CONSULTAR_TALLAS
        TXT_NOMBRE_BUSCAR.DataSource = int.mostrar_PRODUCTO
        TXT_NOMBRE_BUSCAR.ValueMember = "codi_pro"
        TXT_NOMBRE_BUSCAR.DisplayMember = "nom_pro"
    End Sub

    Private Sub BTN_SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SALIR.Click
        BUSCAR_PRODUCTOS.Visible = False
    End Sub
    Private Sub BTN_ATRAS_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.MouseEnter
        BTN_ATRAS.Height = 47
        BTN_ATRAS.Width = 46
    End Sub

    Private Sub BTN_ATRAS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.MouseLeave
        BTN_ATRAS.Height = 44
        BTN_ATRAS.Width = 43
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

    Private Sub BTN_ATRAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.Click
        Me.Hide()
        TXT_NOMB.Text = ""
        TXT_COD.Text = ""
        TXT_CODB.Text = ""
        TXT_MRC.Text = ""
        TXT_PREC.Text = ""
        TXT_SEX.Text = ""
        TXT_TIP.Text = ""
        PictureBox1.Image = PictureBox1.Tag
        PictureBox1.BackgroundImage = PictureBox1.Tag
        DataGridView1.DataSource = int.CONSULTAR_COLORES
        DataGridView2.DataSource = int.CONSULTAR_TALLAS
        TXT_NOMBRE_BUSCAR.DataSource = int.mostrar_PRODUCTO
        TXT_NOMBRE_BUSCAR.ValueMember = "codi_pro"
        TXT_NOMBRE_BUSCAR.DisplayMember = "nom_pro"
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        BUSCAR_PRODUCTOS.Visible = True
    End Sub
End Class