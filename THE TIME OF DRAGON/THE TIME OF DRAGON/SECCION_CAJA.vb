Public Class SECCION_CAJA
    Dim int As New DATOS
    Private Sub BTN_FACTURA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_FACTURA.Click
        FACTURA_SECCION_CAJA.Show()
    End Sub

    Private Sub BTN_FACTURA_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_FACTURA.MouseEnter
        BTN_FACTURA.Height = 137
        BTN_FACTURA.Width = 143
    End Sub

    Private Sub BTN_FACTURA_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_FACTURA.MouseLeave
        BTN_FACTURA.Height = 133
        BTN_FACTURA.Width = 139
    End Sub

    Private Sub BTN_JUEGOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_JUEGOS.Click
        JUEGOS.Visible = True
        JUEGOS.Location = New System.Drawing.Point(169, 82)
    End Sub

    Private Sub BTN_JUEGOS_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_JUEGOS.MouseEnter
        BTN_JUEGOS.Height = 137
        BTN_JUEGOS.Width = 143
    End Sub

    Private Sub BTN_JUEGOS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_JUEGOS.MouseLeave
        BTN_JUEGOS.Height = 133
        BTN_JUEGOS.Width = 139
    End Sub

    Private Sub BTN_MUSICA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_MUSICA.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "C:\Program Files\Windows Media Player\wmplayer.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
        Me.Show()
    End Sub

    Private Sub BTN_MUSICA_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_MUSICA.MouseEnter
        BTN_MUSICA.Height = 137
        BTN_MUSICA.Width = 143
    End Sub

    Private Sub BTN_MUSICA_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_MUSICA.MouseLeave
        BTN_MUSICA.Height = 133
        BTN_MUSICA.Width = 139
    End Sub
    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label6.Text = Format(Now(), "hh:mm:ss tt")
        Label2.Text = Format(Now(), "dddd, dd' de 'MMMM' de 'yyyy")
    End Sub

    Private Sub SECCION_CAJA_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label6.Text = Format(Now(), "hh:mm:ss tt")
        Label2.Text = Format(Now(), "dddd, dd' de 'MMMM' de 'yyyy")
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
        EMPLEADO.Show()
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
        Int.SALIR()
    End Sub


    Private Sub BTN_SALIR_JUEGOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        'Me.Dispose()
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "F:\TENICA\PROYECTO\Juegos\Luxor 3.EXE"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
        Me.Show()
        JUEGOS.Visible = True
        JUEGOS.Location = New System.Drawing.Point(169, 82)
    End Sub
End Class