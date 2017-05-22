Public Class MOSTRAR
    Dim INT As New DATOS
    Private Sub LinK_ATRAS_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinK_ATRAS.LinkClicked
        Me.Hide()
        ADMINISTRADOR.Show()
    End Sub

    Private Sub LinK_CERRAR_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinK_CERRAR.LinkClicked
        INT.SALIR()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        ADMINISTRADOR.Show()
    End Sub

    Private Sub MOSTRAR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ElDataGridView1.DataSource = INT.mostrarEMPLEADO()
        ElDataGridView2.DataSource = INT.mostrarPROVEEDOR()
        ElDataGridView3.DataSource = INT.mostrarCLIENTE()
        ElDataGridView4.DataSource = INT.mostrar_PRODUCTO()
        ElDataGridView5.DataSource = INT.mostrarFACTURA
        ElDataGridView6.DataSource = INT.mostrarCOMPRA
    End Sub

End Class