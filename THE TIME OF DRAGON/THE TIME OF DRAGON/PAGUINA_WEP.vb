Public Class PAGUINA_WEP
    Private Sub BTN_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WebBrowser1.GoHome()
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        WebBrowser1.GoBack()
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        WebBrowser1.GoForward()
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        WebBrowser1.GoSearch()
    End Sub

    Private Sub PAGUINA_WEP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As String
        a = CTX_NAVEGAR.Text
        If a = "http://www.google.com.co/" Then
            WebBrowser1.GoHome()
        Else
            MsgBox("EROOR EN PAGUINA PRINCIPAL ")
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        WebBrowser1.Navigate(CTX_NAVEGAR.Text)
    End Sub
End Class
