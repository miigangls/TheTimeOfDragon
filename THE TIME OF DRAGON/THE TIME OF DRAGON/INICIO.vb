Public Class INICIO
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If CARGAR.Value < 100 Then
            CARGAR.Value = CARGAR.Value + 20
        Else
            Timer1.Enabled = False
            INGRESAR.Show()
            Me.Hide()
        End If
        Label1.Text = Format(Now(), "hh:mm:ss tt")
        Label2.Text = Format(Now(), "dddd, dd' de 'MMMM' de 'yyyy")
    End Sub

    Private Sub INICIO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = Format(Now(), "hh:mm:ss tt")
        Label2.Text = Format(Now(), "dddd, dd' de 'MMMM' de 'yyyy")
    End Sub
End Class
