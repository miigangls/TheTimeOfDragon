Public Class AYODA


    Private Sub AYUDA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        INFORMAIÓN.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = ""
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
        Me.Show()
    End Sub
End Class