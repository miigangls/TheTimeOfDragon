Public Class ADMINISTRADOR
    Dim int As New DATOS
    Private Sub ADMINISTRADOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label22.Text = Format(Now(), "hh:mm:ss tt")
        Label17.Text = Format(Now(), "dddd, dd' de 'MMMM' de 'yyyy")
    End Sub
    Private Sub BTN_SALIR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SALIR.MouseEnter
        BTN_SALIR.Height = 44
        BTN_SALIR.Width = 47
    End Sub

    Private Sub BTN_SALIR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SALIR.MouseLeave
        BTN_SALIR.Height = 41
        BTN_SALIR.Width = 43
    End Sub

    Private Sub BTN_ATRAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.Click
        Me.Hide()
        INGRESAR.Show()
    End Sub

    Private Sub BTN_ATRAS_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.MouseEnter
        BTN_ATRAS.Height = 44
        BTN_ATRAS.Width = 43
    End Sub

    Private Sub BTN_ATRAS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.MouseLeave
        BTN_ATRAS.Height = 41
        BTN_ATRAS.Width = 40
    End Sub

    Private Sub BTN_AYUDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_AYUDA.Click

        AYODA.Show()
    End Sub

    Private Sub BTN_AYUDA_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_AYUDA.MouseEnter
        BTN_AYUDA.Height = 49
        BTN_AYUDA.Width = 49
    End Sub

    Private Sub BTN_AYUDA_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_AYUDA.MouseLeave
        BTN_AYUDA.Height = 46
        BTN_AYUDA.Width = 46
    End Sub
    Private Sub BTN_SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SALIR.Click
        int.SALIR()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_NAVEGADOR.Click
        PAGUINA_WEP.Show()
    End Sub
    Private Sub PictureBox5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_NAVEGADOR.MouseEnter
        BTN_NAVEGADOR.Height = 71
        BTN_NAVEGADOR.Width = 73
    End Sub
    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_NAVEGADOR.MouseLeave
        BTN_NAVEGADOR.Height = 67
        BTN_NAVEGADOR.Width = 69
    End Sub

    Private Sub BTN_BUSCAR_EMPLE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR_EMPLE.Click
        'Me.Hide()
        AGRGAPERSONAL.Show()
        AGRGAPERSONAL.BUSCAR_EMPLEADO.Visible = True
    End Sub

    Private Sub BTN_AGRAGR_EMPLE_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_AGRAGR_EMPLE.Click
        'Me.Hide()
        REGISTRAR.Size = New System.Drawing.Size(400, 207)
        REGISTRAR.GroupBox1.Size = New System.Drawing.Size(365, 98)
        AGRGAPERSONAL.Show()
        REGISTRAR.Show()
        REGISTRAR.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub BTN_AGRAGR_EMPLE_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_AGRAGR_EMPLE.MouseEnter
        BTN_AGRAGR_EMPLE.Height = 109
        BTN_AGRAGR_EMPLE.Width = 104
    End Sub

    Private Sub BTN_AGRAGR_EMPLE_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_AGRAGR_EMPLE.MouseLeave
        BTN_AGRAGR_EMPLE.Height = 105
        BTN_AGRAGR_EMPLE.Width = 100
    End Sub

    Private Sub BTN_BUSCAR_EMPLE_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR_EMPLE.MouseEnter
        BTN_BUSCAR_EMPLE.Height = 109
        BTN_BUSCAR_EMPLE.Width = 104
    End Sub

    Private Sub BTN_BUSCAR_EMPLE_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR_EMPLE.MouseLeave
        BTN_BUSCAR_EMPLE.Height = 105
        BTN_BUSCAR_EMPLE.Width = 100
    End Sub

    Private Sub BTN_MOSTRAR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_MOSTRAR.Click
        Me.Hide()
        MOSTRAR.Show()
    End Sub

    Private Sub BTN_MOSTRAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_MOSTRAR.MouseEnter
        BTN_MOSTRAR.Height = 109
        BTN_MOSTRAR.Width = 104
    End Sub

    Private Sub BTN_MOSTRAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_MOSTRAR.MouseLeave
        BTN_MOSTRAR.Height = 105
        BTN_MOSTRAR.Width = 100
    End Sub
    Private Sub BTN_AGREGARPROVEEDOR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_AGREGARPROVEEDOR.Click
        Me.Hide()
        AGREGAR_PROVEEDOR.Show()
    End Sub

    Private Sub BTN_AGREGARPROVEEDOR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_AGREGARPROVEEDOR.MouseEnter
        BTN_AGREGARPROVEEDOR.Height = 87
        BTN_AGREGARPROVEEDOR.Width = 82
    End Sub

    Private Sub BTN_AGREGARPROVEEDOR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_AGREGARPROVEEDOR.MouseLeave
        BTN_AGREGARPROVEEDOR.Height = 83
        BTN_AGREGARPROVEEDOR.Width = 78
    End Sub

    Private Sub BTN_MOSTRARPROVEEDOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_MOSTRARPROVEEDOR.Click
        MOSTRAR.Show()
    End Sub

    Private Sub BTN_MOSTRARPROVEEDOR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_MOSTRARPROVEEDOR.MouseEnter
        BTN_MOSTRARPROVEEDOR.Height = 87
        BTN_MOSTRARPROVEEDOR.Width = 83
    End Sub

    Private Sub BTN_MOSTRARPROVEEDOR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_MOSTRARPROVEEDOR.MouseLeave
        BTN_MOSTRARPROVEEDOR.Height = 83
        BTN_MOSTRARPROVEEDOR.Width = 79
    End Sub

    Private Sub BTN_BUSCARPROVEEDOR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCARPROVEEDOR.Click
        Me.Hide()
        AGREGAR_PROVEEDOR.Show()
        AGREGAR_PROVEEDOR.BUSCAR_PROVEEDOR.Visible = True
    End Sub

    Private Sub BTN_BUSCARPROVEEDOR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_BUSCARPROVEEDOR.MouseEnter
        BTN_BUSCARPROVEEDOR.Height = 87
        BTN_BUSCARPROVEEDOR.Width = 82
    End Sub

    Private Sub BTN_BUSCARPROVEEDOR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_BUSCARPROVEEDOR.MouseLeave
        BTN_BUSCARPROVEEDOR.Height = 83
        BTN_BUSCARPROVEEDOR.Width = 78
    End Sub
    Private Sub BTN_PEDIDO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PEDIDO.Click
        PEDIDOS.Show()
    End Sub

    Private Sub BTN_PEDIDO_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_PEDIDO.MouseEnter
        BTN_PEDIDO.Height = 87
        BTN_PEDIDO.Width = 82
    End Sub

    Private Sub BTN_PEDIDO_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_PEDIDO.MouseLeave
        BTN_PEDIDO.Height = 83
        BTN_PEDIDO.Width = 78
    End Sub

    Private Sub BTN_PRODUCTOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PRODUCTOS.Click
        AGREGAR_PRODUCTO.Show()
        AGREGAR_PRODUCTO.CNX_MARCAS.DataSource = int.mostrarPROVEEDOR
        AGREGAR_PRODUCTO.CNX_MARCAS.ValueMember = "codi_prov"
        AGREGAR_PRODUCTO.CNX_MARCAS.DisplayMember = "raz_prov"
    End Sub

    Private Sub BTN_PRODUCTOS_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_PRODUCTOS.MouseEnter
        BTN_PRODUCTOS.Height = 87
        BTN_PRODUCTOS.Width = 92
    End Sub

    Private Sub BTN_PRODUCTOS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_PRODUCTOS.MouseLeave
        BTN_PRODUCTOS.Height = 83
        BTN_PRODUCTOS.Width = 88
    End Sub

    Private Sub BTN_ESTADISTICAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ESTADISTICAS.Click

    End Sub

    Private Sub BTN_ESTADISTICAS_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ESTADISTICAS.MouseEnter
        BTN_ESTADISTICAS.Height = 87
        BTN_ESTADISTICAS.Width = 92
    End Sub

    Private Sub BTN_ESTADISTICAS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ESTADISTICAS.MouseLeave
        BTN_ESTADISTICAS.Height = 83
        BTN_ESTADISTICAS.Width = 88
    End Sub

    Private Sub BTN_CLIENTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_CLIENTE.Click
        CLIENTE.Show()
    End Sub

    Private Sub BTN_CLIENTE_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_CLIENTE.MouseEnter
        BTN_CLIENTE.Height = 87
        BTN_CLIENTE.Width = 92
    End Sub

    Private Sub BTN_CLIENTE_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_CLIENTE.MouseLeave
        BTN_CLIENTE.Height = 83
        BTN_CLIENTE.Width = 88
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label22.Text = Format(Now(), "hh:mm:ss tt")
        Label17.Text = Format(Now(), "dddd, dd' de 'MMMM' de 'yyyy")
    End Sub
    Private Sub BTN_PRO_MUJER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PRO_MUJER.Click
        'Productos.TXT_SEXO.Text = "MUJERES"
        Productos.Show()
        Productos.BUSCAR_PRODUCTOS.Visible = True
    End Sub

    Private Sub BTN_PRO_MUJER_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_PRO_MUJER.MouseEnter
        BTN_PRO_MUJER.Height = 87
        'BTN_PRO_MUJER.Width = 82
    End Sub

    Private Sub BTN_PRO_MUJER_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_PRO_MUJER.MouseLeave
        BTN_PRO_MUJER.Height = 83
        BTN_PRO_MUJER.Width = 78
    End Sub

    Private Sub BTN_PRO_HOMBRES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PRO_HOMBRES.Click
        'Productos.TXT_SEXO.Text = "HOMBRES"
        Productos.Show()
        Productos.BUSCAR_PRODUCTOS.Visible = True
    End Sub

    Private Sub BTN_PRO_HOMBRES_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_PRO_HOMBRES.MouseEnter
        BTN_PRO_HOMBRES.Height = 87
        BTN_PRO_HOMBRES.Width = 82
    End Sub

    Private Sub BTN_PRO_HOMBRES_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_PRO_HOMBRES.MouseLeave
        BTN_PRO_HOMBRES.Height = 83
        BTN_PRO_HOMBRES.Width = 78
    End Sub

    Private Sub BTN_PRO_NIÑOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PRO_NIÑOS.Click
        'Productos.TXT_SEXO.Text = "UNI SEX"
        Productos.Show()
        Productos.BUSCAR_PRODUCTOS.Visible = True
    End Sub

    Private Sub BTN_PRO_NIÑOS_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_PRO_NIÑOS.MouseEnter
        BTN_PRO_NIÑOS.Height = 87
        BTN_PRO_NIÑOS.Width = 92
    End Sub

    Private Sub BTN_PRO_NIÑOS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_PRO_NIÑOS.MouseLeave
        BTN_PRO_NIÑOS.Height = 83
        BTN_PRO_NIÑOS.Width = 88
    End Sub
    Private Sub BTN_MUSICA_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_MUSICA.MouseEnter
        BTN_MUSICA.Height = 71
        BTN_MUSICA.Width = 73
    End Sub

    Private Sub BTN_MUSICA_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_MUSICA.MouseLeave
        BTN_MUSICA.Height = 67
        BTN_MUSICA.Width = 69
    End Sub

    Private Sub BTN_ANUNCIOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ANUNCIOS.Click
        JUEGOS.Visible = True
    End Sub

    Private Sub BTN_ANUNCIOS_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ANUNCIOS.MouseEnter
        BTN_ANUNCIOS.Height = 71
        BTN_ANUNCIOS.Width = 73
    End Sub

    Private Sub BTN_ANUNCIOS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ANUNCIOS.MouseLeave
        BTN_ANUNCIOS.Height = 67
        BTN_ANUNCIOS.Width = 69
    End Sub

    Private Sub BTN_MUSICA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_MUSICA.Click
        'MUSICA.Show()
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "C:\Program Files\Windows Media Player\wmplayer.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
        Me.Show()
    End Sub

    Private Sub BTN_SALIR_JUEGOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SALIR_JUEGOS.Click
        JUEGOS.Visible = False
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'Me.Dispose()
        'C:\Program Files\Windows Media Player
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "F:\TENICA\PROYECTO\Juegos\Pac-Man.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
        Me.Show()
        JUEGOS.Visible = True
        JUEGOS.Location = New System.Drawing.Point(169, 82)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        'Me.Dispose()
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "F:\TENICA\PROYECTO\Juegos\Luxor 3.EXE"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
        Me.Show()
        JUEGOS.Visible = True
        JUEGOS.Location = New System.Drawing.Point(169, 82)
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "C:\Program Files\Microsoft Games\Chess\Chess.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
        Me.Show()
        JUEGOS.Visible = True
        'JUEGOS.Location = New System.Drawing.Point(169, 82)
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "C:\Program Files\Microsoft Games\Hearts\Hearts.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
        Me.Show()
        JUEGOS.Visible = True
    End Sub

    Private Sub PictureBox5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "C:\Program Files\Microsoft Games\FreeCell\FreeCell.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
        Me.Show()
        JUEGOS.Visible = True
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "C:\Program Files\Microsoft Games\Minesweeper\Minesweeper.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
        Me.Show()
        JUEGOS.Visible = True
    End Sub
End Class
