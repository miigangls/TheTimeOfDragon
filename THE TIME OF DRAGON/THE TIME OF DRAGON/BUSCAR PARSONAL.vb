Public Class BUSCAR_PERSONAL
    Dim INT As New manipulacion
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        AGRGAPERSONAL.Show()
    End Sub

    Private Sub BTN_ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.Click
        INT.ELIMINAR(TXT_codigo.Text)
    End Sub

    Private Sub BTN_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.Click
        INT.BUSCAR(TXT_codigo.Text)
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinK_ATRAS.LinkClicked
        Me.Hide()
        ADMINISTRADOR.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinK_CERRAR.LinkClicked
        INT.SALIR()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        MOSTRAR.Show()
    End Sub
End Class