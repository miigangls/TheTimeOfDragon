Public Class FACTURA_SECCION_CAJA
    Dim int As New DATOS
    Private Sub Btn_agregarcliente_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_agregarcliente.MouseEnter
        Btn_agregarcliente.Height = 79
        Btn_agregarcliente.Width = 65
    End Sub
    Private Sub Btn_agregarcliente_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_agregarcliente.MouseLeave
        Btn_agregarcliente.Height = 75
        Btn_agregarcliente.Width = 61
    End Sub
    Private Sub BTN_BUSCAR_CLIENTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR_CLIENTE.Click
        Panel1.Visible = True
        Panel1.Location = New System.Drawing.Point(145, 3)
    End Sub
    Private Sub BTN_BUSCAR_CLIENTE_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR_CLIENTE.MouseEnter
        BTN_BUSCAR_CLIENTE.Height = 79
        BTN_BUSCAR_CLIENTE.Width = 65
    End Sub
    Private Sub BTN_BUSCAR_CLIENTE_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR_CLIENTE.MouseLeave
        BTN_BUSCAR_CLIENTE.Height = 75
        BTN_BUSCAR_CLIENTE.Width = 61
    End Sub
    Private Sub BTN_BUSCAR_PRODUCTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR_PRODUCTO.Click
        ElCalculator1.Visible = True
    End Sub
    Private Sub BTN_BUSCAR_PRODUCTO_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR_PRODUCTO.MouseEnter
        BTN_BUSCAR_PRODUCTO.Height = 89
        BTN_BUSCAR_PRODUCTO.Width = 65
    End Sub
    Private Sub BTN_BUSCAR_PRODUCTO_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR_PRODUCTO.MouseLeave
        BTN_BUSCAR_PRODUCTO.Height = 85
        BTN_BUSCAR_PRODUCTO.Width = 61
    End Sub
    Private Sub BTN_NUEVAFACTURA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_NUEVAFACTURA.Click
        TXT_NUM_FACTURA.Text = int.nuevoFACTURA
        nombre.Text = ""
        apellido.Text = ""
        telefonoparticular.Text = ""
        telefonomovil.Text = ""
        identificacion.Text = ""
        direccion.Text = ""
        cidad.Text = ""
        dgdDetalle.Rows.Clear()

    End Sub
    Private Sub BTN_SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SALIR.Click
        int.SALIR()
    End Sub
    Private Sub BTN_SALIR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SALIR.MouseEnter
        BTN_SALIR.Height = 49
        BTN_SALIR.Width = 46
    End Sub
    Private Sub BTN_SALIR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_SALIR.MouseLeave
        BTN_SALIR.Height = 45
        BTN_SALIR.Width = 42
    End Sub
    Private Sub BTN_ATRAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.Click
        Me.Hide()
        SECCION_CAJA.Show()
        TXT_NUM_FACTURA.Text = int.nuevoFACTURA
        nombre.Text = ""
        apellido.Text = ""
        telefonoparticular.Text = ""
        telefonomovil.Text = ""
        identificacion.Text = ""
        direccion.Text = ""
        cidad.Text = ""
        dgdDetalle.Rows.Clear()
    End Sub
    Private Sub BTN_ATRAS_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.MouseEnter
        BTN_ATRAS.Height = 49
        BTN_ATRAS.Width = 46
    End Sub
    Private Sub BTN_ATRAS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ATRAS.MouseLeave
        BTN_ATRAS.Height = 45
        BTN_ATRAS.Width = 42
    End Sub
    Private Sub BTN_NUEVAFACTURA_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_NUEVAFACTURA.MouseEnter
        BTN_NUEVAFACTURA.Height = 79
        BTN_NUEVAFACTURA.Width = 65
    End Sub
    Private Sub BTN_NUEVAFACTURA_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_NUEVAFACTURA.MouseLeave
        BTN_NUEVAFACTURA.Height = 75
        BTN_NUEVAFACTURA.Width = 61
    End Sub

    Private Sub BTN_EXEL_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_EXEL.MouseEnter
        BTN_EXEL.Height = 80
        BTN_EXEL.Width = 67
    End Sub
    Private Sub BTN_EXEL_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_EXEL.MouseLeave
        BTN_EXEL.Height = 76
        BTN_EXEL.Width = 63
        '63, 76
    End Sub
    Private Sub Btn_agregarcliente_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_agregarcliente.Click
        CLIENTE.Show()
    End Sub
    Private Sub FACTURA_SECCION_CAJA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MiguelDataSet.tallas' Puede moverla o quitarla según sea necesario.

        TXT_FECHA.Text = Format(Now(), "MM'/'dd'/'yyyy")
        CNX_MARCAS.DataSource = int.mostrarEMPLEADO
        CNX_MARCAS.ValueMember = "codi_emp"
        CNX_MARCAS.DisplayMember = "nom_emp"
        Me.TALLAS.DataSource = int.CONSULTAR_TALLAS
        Me.TALLAS.ValueMember = "codi_tal"
        Me.TALLAS.DisplayMember = "nom_tal"
    End Sub

    Private Sub BTN_GUARDAR_FACTURA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR_FACTURA.Click
        int.GUARDAR_FACTURA(TXT_FECHA.Text, codigo_cliente.Text, CNX_MARCAS.SelectedValue)
        For D As Integer = 0 To dgdDetalle.RowCount - 2
            int.actualizar_PRODUCTO_FACTURA(dgdDetalle.Item("CANTIDAD", D).Value, dgdDetalle.Item("CODIGO", D).Value)
            'int.actualizar_PRO_TALL_FAC(dgdDetalle.Item("CANTIDAD", D).Value, dgdDetalle.Item("TALLAS", D).Value, dgdDetalle.Item("CODIGO", D).Value)
            int.GUARDAR_DETALLE_FACTURA(dgdDetalle.Item("CANTIDAD", D).Value, TXT_NUM_FACTURA.Text, dgdDetalle.Item("CODIGO", D).Value)
        Next
    End Sub
    Private Sub BTN_GUARDAR_FACTURA_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR_FACTURA.MouseEnter
        BTN_GUARDAR_FACTURA.Height = 79
        BTN_GUARDAR_FACTURA.Width = 65
    End Sub
    Private Sub BTN_GUARDAR_FACTURA_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR_FACTURA.MouseLeave
        BTN_GUARDAR_FACTURA.Height = 75
        BTN_GUARDAR_FACTURA.Width = 61
    End Sub

    Private Sub BTN_ACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.Click
        Dim a As String = TextBox1.Text
        If a = "" Then
            MsgBox("DIGITE AL CODIGO", MsgBoxStyle.RetryCancel)
        Else
            int.BUSCARCLIENTEfactura(TextBox1.Text)
            Panel1.Visible = False
            TextBox1.Text = ""
        End If
    End Sub
    Private Sub BTN_ACEPTAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.MouseEnter
        BTN_ACEPTAR.Height = 47
        BTN_ACEPTAR.Width = 45
    End Sub

    Private Sub BTN_ACEPTAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.MouseLeave
        BTN_ACEPTAR.Height = 43
        BTN_ACEPTAR.Width = 41
    End Sub
    Private Sub SALIRPANEL_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles SALIRPANEL.MouseEnter
        BTN_SALIR.Height = 47
        BTN_SALIR.Width = 45
    End Sub

    Private Sub SALIRPANEL_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SALIRPANEL.MouseLeave
        BTN_SALIR.Height = 43
        BTN_SALIR.Width = 41
    End Sub

    Private Sub SALIRPANEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRPANEL.Click
        Panel1.Visible = False
    End Sub
    Private Sub dgdDetalle_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdDetalle.CellEndEdit
        If (dgdDetalle.Item("codigo", e.RowIndex).Value) = 0 Then
            MsgBox("INGRESAR el numero")
        ElseIf e.ColumnIndex = 0 Then
            Dim tablaProducto As New DataTable
            tablaProducto = int.BUSCAR_PRODUCTO_FACTURA_cargardatos(dgdDetalle.Item("CODIGO", e.RowIndex).Value)
            If tablaProducto.Rows.Count <> 0 Then
                dgdDetalle.Rows.Insert(e.RowIndex, tablaProducto.Rows(0)("codi_pro"), tablaProducto.Rows(0)("nom_pro"), tablaProducto.Rows(0)("pre_pro"))
            End If
            'ElseIf e.ColumnIndex = 0 Then
            '    Dim tablaPro_tall As New DataTable
            '    tablaPro_tall = int.BUSCAR_PRO_TAL_FACTURA_cargardatos(dgdDetalle.Item("TALLAS", e.RowIndex).Value, dgdDetalle.Item("CODIGO", e.RowIndex).Value)
            '    If tablaPro_tall.Rows.Count <> 0 Then
            '        dgdDetalle.Rows.Insert(e.RowIndex, tablaPro_tall.Rows(0)("codi_pro"), tablaPro_tall.Rows(0)("nom_pro"), tablaPro_tall.Rows(0)("pre_pro"))
            '    End If
        End If

    End Sub

    Private Sub BTN_CALCULADORA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CALCULATOR_TOTAL()
    End Sub
    Sub CALCULATOR_TOTAL()
        Dim subtotal As Integer
        ' Dim ttotal As Integer
        For h = 0 To dgdDetalle.RowCount - 1
            subtotal = subtotal + (dgdDetalle.Item("PRECIO", h).Value * dgdDetalle.Item("CANTIDAD", h).Value)
            dgdDetalle.Item("SUM_TOTAL", h).Value = subtotal
            dgdDetalle.Item("IVA", h).Value = subtotal * 0.16
            'dgdDetalle.Item("TOTAL", h).Value = subtotal + (subtotal * 0.16)
        Next
        TEXT_TOTAL.Text = subtotal + (subtotal * 0.16)
        'ttotal = ttotal + subtotal
        'lbl_iva.Text = "IVA 16% $ " & subtotal
        'tottla.Text = "TOTAL$ " & subtotal + (subtotal * 0.16)
    End Sub
    Sub TRAERLOSPRODUCTOS()

    End Sub
    Private Sub dgdDetalle_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdDetalle.CellClick
        If e.ColumnIndex = 7 Then

            dgdDetalle.Rows.RemoveAt(e.RowIndex)
            CALCULATOR_TOTAL()

        End If

    End Sub

    Private Sub dgdDetalle_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdDetalle.CellEnter
        CALCULATOR_TOTAL()
    End Sub

    Private Sub BTN_ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.Click
        Me.Hide()
        SECCION_CAJA.Show()
        TXT_NUM_FACTURA.Text = int.nuevoFACTURA
        nombre.Text = ""
        apellido.Text = ""
        telefonoparticular.Text = ""
        telefonomovil.Text = ""
        identificacion.Text = ""
        direccion.Text = ""
        cidad.Text = ""
        dgdDetalle.Rows.Clear()
    End Sub

    Private Sub BTN_ELIMINAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.MouseEnter
        BTN_ELIMINAR.Height = 80
        BTN_ELIMINAR.Width = 67
    End Sub

    Private Sub BTN_ELIMINAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.MouseLeave
        BTN_ELIMINAR.Height = 76
        BTN_ELIMINAR.Width = 63
    End Sub

    Private Sub BTN_IMPRIMIR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_IMPRIMIR.Click
        'AxCommonDialog1.ShowPrinter()
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub BTN_IMPRIMIR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_IMPRIMIR.MouseEnter
        BTN_IMPRIMIR.Height = 80
        BTN_IMPRIMIR.Width = 63
    End Sub

    Private Sub BTN_IMPRIMIR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_IMPRIMIR.MouseLeave
        BTN_IMPRIMIR.Height = 76
        BTN_IMPRIMIR.Width = 59
        ', 
    End Sub

    Private Sub ElDataGridView1_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdDetalle.CellEndEdit

    End Sub

    Private Sub BTN_BUSCAR_PRODUCTO_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR_PRODUCTO.DoubleClick
        ElCalculator1.Visible = False
    End Sub
End Class
