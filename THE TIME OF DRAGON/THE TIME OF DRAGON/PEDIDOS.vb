Public Class PEDIDOS
    Dim int As New DATOS
    Private Sub PEDIDOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TXT_FECHA.Text = Format(Now(), "MM'/'dd'/'yyyy")
        'CNX_MARCAS.DataSource = int.mostrarPROVEEDOR
        'CNX_MARCAS.ValueMember = "codi_prov"
        'CNX_MARCAS.DisplayMember = "raz_prov"
        Me.TALLAS.DataSource = int.CONSULTAR_TALLAS
        Me.TALLAS.ValueMember = "codi_tal"
        Me.TALLAS.DisplayMember = "nom_tal"
        CNX_MARCAS.DataSource = int.mostrarEMPLEADO
        CNX_MARCAS.ValueMember = "codi_emp"
        CNX_MARCAS.DisplayMember = "nom_emp"
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
        TXT_NUM_FACTURA.Text = int.nuevacompra
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
        ADMINISTRADOR.Show()
        TXT_NUM_FACTURA.Text = ""
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
        BTN_NUEVAFACTURA.Height = 81
        BTN_NUEVAFACTURA.Width = 65
    End Sub
    Private Sub BTN_NUEVAFACTURA_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_NUEVAFACTURA.MouseLeave
        BTN_NUEVAFACTURA.Height = 77
        BTN_NUEVAFACTURA.Width = 61
    End Sub
    Private Sub BTN_IMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BTN_EXEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_EXEL.Click

    End Sub
    Private Sub BTN_EXEL_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_EXEL.MouseEnter
        BTN_EXEL.Height = 80
        BTN_EXEL.Width = 65
    End Sub
    Private Sub BTN_EXEL_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_EXEL.MouseLeave
        BTN_EXEL.Height = 76
        BTN_EXEL.Width = 61
    End Sub
    Private Sub Btn_agregarcliente_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CLIENTE.Show()
    End Sub

    Private Sub BTN_GUARDAR_FACTURA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR_FACTURA.Click
        int.GUARDAR_COMPRA(TXT_FECHA.Text, codigo_proveedor.Text, CNX_MARCAS.SelectedValue)
        For D As Integer = 0 To dgdDetalle.RowCount - 2
            int.actualizar_PRODUCTO_COMPRA(dgdDetalle.Item("CANTIDAD", D).Value, dgdDetalle.Item("PRECIO", D).Value, dgdDetalle.Item("CODIGO", D).Value)
            'int.actualizar_PRO_TALL_COMPRA(dgdDetalle.Item("CANTIDAD", D).Value, dgdDetalle.Item("TALLAS", D).Value, dgdDetalle.Item("CODIGO", D).Value)
            int.GUARDAR_DETALLE_COMPRA(dgdDetalle.Item("CANTIDAD", D).Value, TXT_NUM_FACTURA.Text, dgdDetalle.Item("CODIGO", D).Value)
        Next
    End Sub
    Private Sub BTN_GUARDAR_FACTURA_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR_FACTURA.MouseEnter
        BTN_GUARDAR_FACTURA.Height = 81
        BTN_GUARDAR_FACTURA.Width = 65
    End Sub
    Private Sub BTN_GUARDAR_FACTURA_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR_FACTURA.MouseLeave
        BTN_GUARDAR_FACTURA.Height = 77
        BTN_GUARDAR_FACTURA.Width = 61
    End Sub
    Private Sub SALIRPANEL_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        BTN_SALIR.Height = 47
        BTN_SALIR.Width = 45
    End Sub

    Private Sub SALIRPANEL_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        BTN_SALIR.Height = 43
        BTN_SALIR.Width = 41
    End Sub

    'Private Sub SALIRPANEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Panel1.Visible = False
    'End Sub
    Private Sub dgdDetalle_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdDetalle.CellEndEdit
        If (dgdDetalle.Item("codigo", e.RowIndex).Value) = 0 Then
            MsgBox("INGRESAR el numero")
        ElseIf e.ColumnIndex = 0 Then
            Dim tablaProducto As New DataTable
            tablaProducto = int.BUSCAR_PRODUCTO_COMPRA_cargardatos(dgdDetalle.Item("CODIGO", e.RowIndex).Value)
            If tablaProducto.Rows.Count <> 0 Then
                dgdDetalle.Rows.Insert(e.RowIndex, tablaProducto.Rows(0)("codi_pro"), tablaProducto.Rows(0)("nom_pro"))
            End If
        End If
    End Sub

    Private Sub BTN_CALCULADORA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CALCULATOR_TOTAL()
    End Sub
    Sub CALCULATOR_TOTAL()
        Dim subtotal As Integer
        For h = 0 To dgdDetalle.RowCount - 1
            subtotal = subtotal + (dgdDetalle.Item("PRECIO", h).Value * dgdDetalle.Item("CANTIDAD", h).Value)
            dgdDetalle.Item("SUM_TOTAL", h).Value = subtotal
            dgdDetalle.Item("IVA", h).Value = subtotal * 0.16
        Next
        TEXT_TOTAL.Text = subtotal + (subtotal * 0.16)
    End Sub
    Sub TRAERLOSPRODUCTOS()

    End Sub
    Private Sub dgdDetalle_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdDetalle.CellClick
        If e.ColumnIndex = 7 Then
            Cursor = Cursors.Default
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
        TXT_NUM_FACTURA.Text = ""
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

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview

        PrintForm1.Print()

    End Sub

    Private Sub BTN_IMPRIMIR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_IMPRIMIR.MouseEnter
        BTN_IMPRIMIR.Height = 80
        BTN_IMPRIMIR.Width = 65
    End Sub

    Private Sub BTN_IMPRIMIR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_IMPRIMIR.MouseLeave
        BTN_IMPRIMIR.Height = 76
        BTN_IMPRIMIR.Width = 61
    End Sub

    Private Sub BTN_ACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.Click
        Dim b As String = TextBox1.Text
        If b = "" Then
            MsgBox("DIGITE EL CODIGO ", MsgBoxStyle.Exclamation)
        Else
            int.BUSCARPROVEEDOR_compra(TextBox1.Text)
            TextBox1.Text = ""
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Btn_agregarcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AGREGAR_PROVEEDOR.Show()
    End Sub

    Private Sub BTN_BUSCAR_CLIENTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR_CLIENTE.Click
        Panel1.Visible = True
    End Sub
    Private Sub SALIRPANEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRPANEL.Click
        Panel1.Visible = False
        TextBox1.Text = ""
    End Sub

    
    Private Sub BTN_BUSCAR_CLIENTE_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR_CLIENTE.MouseEnter
        BTN_BUSCAR_CLIENTE.Height = 80
        BTN_BUSCAR_CLIENTE.Width = 65
    End Sub
    Private Sub BTN_BUSCAR_CLIENTE_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR_CLIENTE.MouseLeave
        BTN_BUSCAR_CLIENTE.Height = 76
        BTN_BUSCAR_CLIENTE.Width = 61
    End Sub

    Private Sub BTN_ACEPTAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.MouseEnter
        BTN_ACEPTAR.Height = 45
        BTN_ACEPTAR.Width = 47
    End Sub

    Private Sub BTN_ACEPTAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.MouseLeave
        BTN_ACEPTAR.Height = 41
        BTN_ACEPTAR.Width = 43
    End Sub

    Private Sub SALIRPANEL_MouseEnter1(ByVal sender As Object, ByVal e As System.EventArgs) Handles SALIRPANEL.MouseEnter
        SALIRPANEL.Height = 45
        SALIRPANEL.Width = 47
    End Sub

    Private Sub SALIRPANEL_MouseLeave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles SALIRPANEL.MouseLeave
        SALIRPANEL.Height = 41
        SALIRPANEL.Width = 43
    End Sub

    Private Sub BTN_BUSCAR_PRODUCTO_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR_PRODUCTO.DoubleClick
        ElCalculator1.Visible = False
    End Sub
End Class