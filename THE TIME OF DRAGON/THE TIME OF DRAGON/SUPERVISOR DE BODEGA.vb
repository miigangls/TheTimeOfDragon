Public Class SUPERVISOR
    Dim int As New DATOS
    Private Sub SUPERVISOR_DE_BODEGA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BTN_SALIR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SALIR.MouseEnter
        BTN_SALIR.Height = 44
        BTN_SALIR.Width = 47
    End Sub

    Private Sub BTN_SALIR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SALIR.MouseLeave
        BTN_SALIR.Height = 41
        BTN_SALIR.Width = 43
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
    Private Sub BTN_AYUDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_AYUDA.Click
        AYODA.Show()
    End Sub
    Private Sub BTN_ATRAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.Click
        Me.Hide()
        EMPLEADO.Show()
    End Sub

    Private Sub BTN_MUSICA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_MUSICA.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "C:\Program Files\Windows Media Player\wmplayer.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
        Me.Show()
    End Sub

    Private Sub BTN_FACTURA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_FACTURA.Click
        AGRGAPERSONAL.Show()
        EMPLEADO.BTN_ATRAS.Enabled = True
    End Sub
    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'Me.Dispose()
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "G:\TENICA\Juegos\Pac-Man.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
        Me.Show()
        JUEGOS.Visible = True
        JUEGOS.Location = New System.Drawing.Point(169, 82)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        'Me.Dispose()
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "G:\TENICA\Juegos\Luxor 3.EXE"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
        Me.Show()
        JUEGOS.Visible = True
        JUEGOS.Location = New System.Drawing.Point(169, 82)
    End Sub

    Private Sub BTN_JUEGOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_JUEGOS.Click
        JUEGOS.Visible = True
        JUEGOS.Location = New System.Drawing.Point(169, 82)
    End Sub
End Class