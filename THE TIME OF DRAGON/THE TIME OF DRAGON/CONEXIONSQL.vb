Imports System
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Odbc

Public Class CONEXIONSQL

    '
    '"Data Source=.;AttachDbFilename=F:\TENICA\PROYECTO\BASE DE DATOS\miguel.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
    'data source =.;initial catalog =miguel; integrated security = true
    Public CON As New SqlConnection("data source =.\SQLEXPRESS;initial catalog = cool_steps; integrated security = true")
    Sub conectar()
        Try
            CON.Open()
        Catch ex As Exception
            MsgBox("error al conexion" & ex.ToString)
        End Try
    End Sub
End Class
Class DATOS
    Inherits CONEXIONSQL
    Public inst As New CONEXIONSQL
    Public comando As SqlCommand
    Public leer As SqlDataReader
    Public da As SqlDataAdapter
    Public ds As New DataSet
    Public table As DataTable
    Dim FILA As Integer
    Dim b As String
    'DATOS DE EMPLEADO
    Function mostrarEMPLEADO()
        conectar()
        table = New DataTable
        comando = New SqlCommand("select * from EMPLEADO", CON)
        leer = comando.ExecuteReader
        table.Load(leer, LoadOption.OverwriteChanges)
        FILA = table.Rows.Count + 1
        CON.Close()
        Return table
    End Function
    Sub GUARDAREMPLEADO(ByVal NOMBRE As String, ByVal apellido As String, ByVal identificacion As Int64, ByVal telefonoparticular As Int64, ByVal telefonomovil As Int64, ByVal direcion As String, ByVal ciudad As String, ByVal correo As String, ByVal salario As Int64)
        Try
            Cursor.Current = Cursors.WaitCursor
            conectar()
            comando = New SqlCommand("insert into empleado values( '" & NOMBRE & "','" & apellido & "'," & identificacion & "," & telefonoparticular & "," & telefonomovil & ",'" & direcion & "','" & ciudad & "','" & correo & "','" & salario & "')", CON)
            comando.ExecuteNonQuery()
            MsgBox("Los datos han sidos guardados", MessageBoxButtons.OK)
            Cursor.Current = Cursors.Arrow
        Catch ex As Exception
            MsgBox("Se ha producido un error al guardar" & ex.ToString, MessageBoxButtons.OK)
        End Try
        CON.Close()
    End Sub
    Sub GUARDAR_USUSRIO_empleado(ByVal NOMBRE_USURIO As String, ByVal CONTRASEÑA As String, ByVal CODIGO_EMPLEADO As String, ByVal CARGO As String)
        Try
            conectar()
            comando = New SqlCommand("insert into usuario values('" & NOMBRE_USURIO & "','" & CONTRASEÑA & "'," & CODIGO_EMPLEADO & ",'" & CARGO & "')", CON)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Se ha producido un error al guardar" & ex.ToString, MessageBoxButtons.OK)
        End Try
        CON.Close()
    End Sub
    Sub actualizarEMPLEADO(ByVal NOMBRE As String, ByVal apellido As String, ByVal identificacion As Decimal, ByVal telefonoparticular As Decimal, ByVal telefonomovil As Decimal, ByVal direcion As String, ByVal ciudad As String, ByVal correo As String, ByVal salario As Integer, ByVal codigo As Integer)
        Try
            conectar()
            comando = New SqlCommand("update empleado set nom_emp ='" & NOMBRE & "',ape_emp ='" & apellido & "',ide_emp ='" & identificacion & "',tel_emp ='" & telefonoparticular & "',tel_movil_empl ='" & telefonomovil & "',dir_emp ='" & direcion & "',ciu_emp ='" & ciudad & "',cor_emp ='" & correo & "',sal_emp ='" & salario & "' where codi_emp ='" & codigo & "'", CON)
            comando.ExecuteNonQuery()
            MsgBox("Datos  modificar los datos")
        Catch ex As Exception
            MsgBox("Error al modificar los datos" & ex.ToString)
        End Try
        CON.Close()
    End Sub
    Function nuevoEMPLEADO()
        conectar()
        table = New DataTable
        comando = New SqlCommand("select * from EMPLEADO", CON)
        leer = comando.ExecuteReader
        table.Load(leer, LoadOption.OverwriteChanges)
        FILA = table.Rows.Count + 1
        CON.Close()
        Return FILA
    End Function

    ' INGRESO DEL EMPLEADO
    Sub INGRESO_DE_EMPLEADO(ByVal l As String, ByVal usuario As String, ByVal CODIGO As String)
        l = EMPLEADO.ComboBox1.Text
        usuario = EMPLEADO.TXT_USUARIO.Text
        CODIGO = EMPLEADO.TXT_codigo.Text
        Try
            Select Case l
                Case Is = "SUPERVISOR "
                    conectar()
                    comando = New SqlCommand("select * from usuario where car_emp LIKE '" & l & "' AND nom_usu = '" & usuario & "' AND cod_con_usu  ='" & CODIGO & "'", CON)
                    leer = comando.ExecuteReader
                    If (leer.Read) Then
                        EMPLEADO.Close()
                        MsgBox("CODIGO Y CARGO CORECTO", MsgBoxStyle.OkCancel)
                        SUPERVISOR.Show()
                    Else
                        MsgBox("ERROR DE CODIGO O CARGO", MsgBoxStyle.OkCancel)
                    End If
                Case Is = "SECCION CAJA"
                    conectar()
                    comando = New SqlCommand("select * from usuario where car_emp LIKE '" & l & "' AND nom_usu = '" & usuario & "' AND cod_con_usu  ='" & CODIGO & "'", CON)
                    leer = comando.ExecuteReader
                    If (leer.Read) Then
                        EMPLEADO.Close()
                        MsgBox("CODIGO Y CARGO CORECTO", MsgBoxStyle.OkCancel)
                        SECCION_CAJA.Show()
                    Else
                        MsgBox("ERROR DE CODIGO O CARGO", MsgBoxStyle.OkCancel)
                    End If
                Case Is = "ATENCION AL CLIENTE"
                    conectar()
                    comando = New SqlCommand("select * from usuario where car_emp LIKE '" & l & "' AND nom_usu = '" & usuario & "' AND cod_con_usu  ='" & CODIGO & "'", CON)
                    leer = comando.ExecuteReader
                    If (leer.Read) Then
                        EMPLEADO.Close()
                        MsgBox("CODIGO Y CARGO CORECTO")
                        SECCION_ATENCION_AL_CLIENTE.Show()
                    Else
                        MsgBox("ERROR DE CODIGO O CARGO", MsgBoxStyle.OkCancel)
                    End If

            End Select
        Catch ex As Exception
            MsgBox("ERROR AL CONECTAR" & ex.ToString, MsgBoxStyle.Exclamation)

        End Try
        CON.Close()
    End Sub
    Sub ELIMINAREMPLEADO(ByVal CODIGO As Integer)
        Try
            conectar()
            comando = New SqlCommand("delete from empleado where codi_emp=" & CODIGO, CON)
            comando.ExecuteNonQuery()
            MsgBox("DATOS ELIMINADOS", MsgBoxStyle.OkCancel)
        Catch ex As Exception
            MsgBox("Error al eliminar" & ex.ToString, MsgBoxStyle.OkCancel)
        End Try
        CON.Close()
    End Sub
    Sub BUSCAREMPLEADO(ByVal CODIGO As Integer)
        Try
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select * from EMPLEADO where codi_emp=" & CODIGO, CON)
            leer = comando.ExecuteReader
            If (leer.Read) Then
                MsgBox("LOS DATOS FUERON ENCONTRADOS EXITOSAMENTE ", MsgBoxStyle.RetryCancel)
                BUSCAREMPLEADO_CARGARDATOS(CODIGO)
            Else
                MsgBox("DATO NO EXIXTE", MsgBoxStyle.OkCancel)
            End If

        Catch ex As Exception
            MsgBox("Error al consultar")
        End Try
        CON.Close()
    End Sub
    Sub BUSCAREMPLEADO_CARGARDATOS(ByVal CODIGO As Integer)
        CON.Close()
        Try
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select * from EMPLEADO where codi_emp=" & CODIGO, CON)
            leer = comando.ExecuteReader
            table.Load(leer, LoadOption.OverwriteChanges)
            AGRGAPERSONAL.TXT_codigo.Text = table.Rows(0)("codi_emp").ToString
            AGRGAPERSONAL.TXT_NOMBRE.Text = table.Rows(0)("nom_emp").ToString
            AGRGAPERSONAL.TXT_APELLIDOS.Text = table.Rows(0)("ape_emp").ToString
            'AGRGAPERSONAL.ComboBox1.Text = table.Rows(0)("car_emp").ToString
            AGRGAPERSONAL.TXT_identificacion.Text = table.Rows(0)("ide_emp").ToString
            AGRGAPERSONAL.TXT_telefonoparticular.Text = table.Rows(0)("tel_emp").ToString
            AGRGAPERSONAL.TXT_telefonomovil.Text = table.Rows(0)("tel_movil_empl").ToString
            AGRGAPERSONAL.TXT_direccion.Text = table.Rows(0)("dir_emp").ToString
            AGRGAPERSONAL.TXT_ciudad.Text = table.Rows(0)("ciu_emp").ToString
            AGRGAPERSONAL.TXT_coreo.Text = table.Rows(0)("cor_emp").ToString
            AGRGAPERSONAL.TXT_salario.Text = table.Rows(0)("sal_emp").ToString
            table = New DataTable
            comando = New SqlCommand("select usuario.car_emp from usuario inner join dbo.empleado on usuario.codi_emp = dbo.empleado.codi_emp where EMPLEADO.codi_emp = " & CODIGO, CON)
            leer = comando.ExecuteReader
            table.Load(leer, LoadOption.OverwriteChanges)
            AGRGAPERSONAL.ComboBox1.Text = table.Rows(0)("car_emp").ToString
        Catch ex As Exception
            MsgBox("Error al consultar" & ex.ToString, MessageBoxButtons.OK)
        End Try
        CON.Close()
    End Sub

    'SALIR
    Sub SALIR()
        If (MsgBox("DESEA SALIR", MsgBoxStyle.YesNo, Title:="SALIR") = MsgBoxResult.Yes) Then
            End
        End If
    End Sub

    'VALIDACIONES
    Sub VALIDAR_TEXTO(ByVal TXT As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not Char.IsLetter(e.KeyChar) And e.KeyChar <> Microsoft.VisualBasic.ChrW(8)) And (Not Char.IsSeparator(e.KeyChar) And e.KeyChar <> Microsoft.VisualBasic.ChrW(8)) Then
            e.Handled = True
        End If
    End Sub
    Sub VALIDAR_NUMEROS(ByVal TXT As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not Char.IsNumber(e.KeyChar) And e.KeyChar <> Microsoft.VisualBasic.ChrW(8)) Then
            e.Handled = True
        End If
    End Sub
    Sub VALIDAR_TEXTOYNUMEROS(ByVal CBX As ComboBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not Char.IsLetter(e.KeyChar) And e.KeyChar <> Microsoft.VisualBasic.ChrW(8)) And (Not Char.IsSeparator(e.KeyChar) And e.KeyChar <> Microsoft.VisualBasic.ChrW(8)) And (Not Char.IsPunctuation(e.KeyChar) And e.KeyChar <> Microsoft.VisualBasic.ChrW(8)) And (Not Char.IsNumber(e.KeyChar) And e.KeyChar <> Microsoft.VisualBasic.ChrW(8)) Then
            e.Handled = True
        End If
    End Sub
    Sub navegarempleado(ByVal f As Integer)
        Try
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select * from EMPLEADO", CON)
            leer = comando.ExecuteReader
            table.Load(leer, LoadOption.OverwriteChanges)
            Dim dr As DataRow = table.Rows(f)
            AGRGAPERSONAL.TXT_codigo.Text = dr("codi_emp").ToString
            AGRGAPERSONAL.TXT_NOMBRE.Text = dr("nom_emp").ToString
            AGRGAPERSONAL.TXT_APELLIDOS.Text = dr("ape_emp").ToString
            AGRGAPERSONAL.ComboBox1.Text = dr("car_emp").ToString
            AGRGAPERSONAL.TXT_identificacion.Text = dr("ide_emp").ToString
            AGRGAPERSONAL.TXT_telefonoparticular.Text = dr("tel_emp").ToString
            AGRGAPERSONAL.TXT_telefonomovil.Text = dr("tel_movil_empl").ToString
            AGRGAPERSONAL.TXT_direccion.Text = dr("dir_emp").ToString
            AGRGAPERSONAL.TXT_ciudad.Text = dr("ciu_emp").ToString
            AGRGAPERSONAL.TXT_coreo.Text = dr("cor_emp").ToString
            AGRGAPERSONAL.TXT_salario.Text = dr("sal_emp").ToString
        Catch ex As Exception
            MsgBox("Error al consultar", MsgBoxStyle.OkCancel)
        End Try

        CON.Close()
    End Sub
    Public Function PrimeraEMPLEADO() As DataRow
        FILA = 0
        navegarempleado(FILA)
        Return table.Rows(FILA)
    End Function
    Public Function UltimaEMPLEADO() As DataRow
        FILA = table.Rows.Count - 1
        navegarempleado(FILA)
        Return table.Rows(FILA)
    End Function
    Public Function SiguienteEMPLEADO() As DataRow
        FILA += 1
        If FILA > table.Rows.Count - 1 Then
            FILA = table.Rows.Count - 1
        End If
        navegarempleado(FILA)
        Return table.Rows(FILA)
    End Function
    Public Function AnteriorEMPLEADO() As DataRow
        FILA -= 1
        If FILA < 0 Then
            FILA = 0
        End If
        navegarempleado(FILA)
        Return table.Rows(FILA)
    End Function

    'DATOS DE PROVEEDOR
    Sub GUARDARPROVEEDOR(ByVal RAZONSOCIAL As String, ByVal INT As Int64, ByVal telefonoparticular As Int64, ByVal telefonoFAX As Int64, ByVal direcion As String, ByVal ciudad As String, ByVal imagen As String, ByVal PAGINAWEP As String)
        Try
            Cursor.Current = Cursors.WaitCursor
            conectar()
            comando = New SqlCommand("insert into PROVEEDOR values( '" & RAZONSOCIAL & "'," & INT & "," & telefonoparticular & "," & telefonoFAX & ",'" & direcion & "','" & ciudad & "','" & imagen & "','" & PAGINAWEP & "')", CON)
            comando.ExecuteNonQuery()
            MsgBox("Los datos han sidos guardados", MessageBoxButtons.OK)
            Cursor.Current = Cursors.Arrow
        Catch ex As Exception
            MsgBox("Se ha producido un error al guardar" & ex.ToString, MessageBoxButtons.OK)
        End Try
        CON.Close()
    End Sub
    Sub actualizarPROVEEDOR(ByVal RAZONSOCIAL As String, ByVal INT As Decimal, ByVal telefonoparticular As Integer, ByVal telefonoFAX As Decimal, ByVal direcion As String, ByVal ciudad As String, ByVal imagen As String, ByVal PAGINAWEP As String, ByVal CODIGO As Integer)
        Try
            conectar()
            comando = New SqlCommand("update PROVEEDOR set raz_prov ='" & RAZONSOCIAL & "',nit_prov ='" & INT & "',tele_prov ='" & telefonoparticular & "',tele_fax ='" & telefonoFAX & "',dir_prov ='" & direcion & "',cui_prov ='" & ciudad & "',imge_prov ='" & imagen & "',web_prov ='" & PAGINAWEP & "' where codi_prov ='" & CODIGO & "'", CON)
            comando.ExecuteNonQuery()
            MsgBox("Datos modificar ", MsgBoxStyle.OkCancel)
        Catch ex As Exception
            MsgBox("Error al modificar los datos" & ex.ToString, MsgBoxStyle.OkCancel)
        End Try
        CON.Close()
    End Sub
    Function nuevoPROVEEDOR()
        conectar()
        table = New DataTable
        comando = New SqlCommand("select * from PROVEEDOR", CON)
        leer = comando.ExecuteReader
        table.Load(leer, LoadOption.OverwriteChanges)
        b = table.Rows.Count + 1
        CON.Close()
        Return b
    End Function
    Function BUSCARPROVEEDOR(ByVal CODIGO As Integer)
        Try
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select * from PROVEEDOR where codi_prov=" & CODIGO, CON)
            leer = comando.ExecuteReader
            If (leer.Read) Then
                MsgBox("LOS DATOS FUERON ENCONTRADOS EXITOSAMENTE ", MsgBoxStyle.OkOnly)
                BUSCARPROVEEDOR_CARGARDATOS(CODIGO)
            Else
                MsgBox("DATO NO EXIXTE", MsgBoxStyle.OkCancel)
            End If
        Catch ex As Exception
            MsgBox("Error al consultar" & ex.ToString, MsgBoxStyle.OkCancel)
        End Try
        CON.Close()
        Return table
    End Function

    Function CARGAR_COMPRA_PROVEEDOR(ByVal CODIGO_PROVEEDOR As Int64)
        Try
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select producto.nom_pro,producto.pre_pro,detalle_compra.can_decom,(producto.pre_pro*detalle_compra.can_decom) as total from compra inner join proveedor on compra.codi_prov=proveedor.codi_prov inner join detalle_compra on compra.codi_comp=detalle_compra.codi_comp inner join producto on detalle_compra.codi_pro=producto.codi_pro where proveedor.codi_prov  =" & CODIGO_PROVEEDOR, CON)
            leer = comando.ExecuteReader
            table.Load(leer, LoadOption.OverwriteChanges)
        Catch ex As Exception
            MsgBox("ERROR AL CONECTAR " & ex.ToString, MsgBoxStyle.Exclamation)
        End Try
        CON.Close()
        Return table
    End Function
    Sub BUSCARPROVEEDOR_CARGARDATOS(ByVal CODIGO As Integer)
        CON.Close()
        Try
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select * from PROVEEDOR where codi_prov=" & CODIGO, CON)
            leer = comando.ExecuteReader
            table.Load(leer, LoadOption.OverwriteChanges)
            AGREGAR_PROVEEDOR.TXT_codigo.Text = table.Rows(0)("codi_prov").ToString
            AGREGAR_PROVEEDOR.TXT_RAZON_SOCIAL.Text = table.Rows(0)("raz_prov").ToString
            AGREGAR_PROVEEDOR.TXT_NIT.Text = table.Rows(0)("nit_prov").ToString
            AGREGAR_PROVEEDOR.TXT_telefonoparticular.Text = table.Rows(0)("tele_prov").ToString
            AGREGAR_PROVEEDOR.TXT_telefonofax.Text = table.Rows(0)("tele_fax").ToString
            AGREGAR_PROVEEDOR.TXT_direccion.Text = table.Rows(0)("dir_prov").ToString
            AGREGAR_PROVEEDOR.TXT_ciudad.Text = table.Rows(0)("cui_prov").ToString
            AGREGAR_PROVEEDOR.PictureBox1.Image = Image.FromFile(table.Rows(0)("imge_prov").ToString)
            AGREGAR_PROVEEDOR.LBL_IMGEN.Text = table.Rows(0)("imge_prov").ToString
            AGREGAR_PROVEEDOR.TXT_PAGINAWEP.Text = table.Rows(0)("web_prov").ToString
        Catch ex As Exception
            MsgBox("Error al consultar" & ex.ToString, MsgBoxStyle.OkCancel)
        End Try
        CON.Close()
    End Sub
    Sub ELIMINARPROVEEDOR(ByVal CODIGO As Integer)
        Try
            conectar()
            comando = New SqlCommand("delete from PROVEEDOR where codi_prov=" & CODIGO, CON)
            comando.ExecuteNonQuery()
            MsgBox("DATOS ELIMINADOS")
        Catch ex As Exception
            MsgBox("Error al eliminar" & ex.ToString)
        End Try
        CON.Close()
    End Sub
    Function mostrarPROVEEDOR()
        CON.Open()
        table = New DataTable
        comando = New SqlCommand("select * from PROVEEDOR", CON)
        leer = comando.ExecuteReader
        table.Load(leer, LoadOption.OverwriteChanges)
        b = table.Rows.Count + 1
        CON.Close()
        Return table
    End Function
    Sub navegarproveedor(ByVal f As Integer)
        Try
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select * from PROVEEDOR", CON)
            leer = comando.ExecuteReader
            table.Load(leer, LoadOption.OverwriteChanges)
            Dim dr As DataRow = table.Rows(f)
            AGREGAR_PROVEEDOR.TXT_codigo.Text = dr("codi_prov").ToString
            AGREGAR_PROVEEDOR.TXT_RAZON_SOCIAL.Text = dr("raz_prov").ToString
            AGREGAR_PROVEEDOR.TXT_NIT.Text = dr("nit_prov").ToString
            AGREGAR_PROVEEDOR.TXT_telefonoparticular.Text = dr("tele_prov").ToString
            AGREGAR_PROVEEDOR.TXT_telefonofax.Text = dr("tele_fax").ToString
            AGREGAR_PROVEEDOR.TXT_direccion.Text = dr("dir_prov").ToString
            AGREGAR_PROVEEDOR.TXT_ciudad.Text = dr("cui_prov").ToString
            AGREGAR_PROVEEDOR.TXT_PAGINAWEP.Text = dr("web_prov").ToString
            AGREGAR_PROVEEDOR.PictureBox1.Image = Image.FromFile(dr("imge_prov").ToString)
        Catch ex As Exception
            MsgBox("Error al navegar" & ex.ToString, MsgBoxStyle.MsgBoxRtlReading)
        End Try
        CON.Close()
    End Sub
    Public Function Primeraproveedor() As DataRow
        FILA = 0
        navegarproveedor(FILA)
        Return table.Rows(FILA)
    End Function
    Public Function Ultimaproveedor() As DataRow
        FILA = table.Rows.Count - 1
        navegarproveedor(FILA)
        Return table.Rows(FILA)
    End Function
    Public Function Siguienteproveedor() As DataRow
        FILA += 1
        If FILA > table.Rows.Count - 1 Then
            FILA = table.Rows.Count - 1
        End If
        navegarproveedor(FILA)
        Return table.Rows(FILA)
    End Function
    Public Function Anteriorproveedor() As DataRow
        FILA -= 1
        If FILA < 0 Then
            FILA = 0
        End If
        navegarproveedor(FILA)
        Return table.Rows(FILA)
    End Function

    'DATOS CLIENTE
    Function mostrarCLIENTE()
        conectar()
        table = New DataTable
        comando = New SqlCommand("select * from cliente", CON)
        leer = comando.ExecuteReader
        table.Load(leer, LoadOption.OverwriteChanges)
        FILA = table.Rows.Count + 1
        CON.Close()
        Return table
    End Function
    Sub GUARDARCLIENTE(ByVal NOMBRE As String, ByVal apellido As String, ByVal identificacion As Int64, ByVal telefonoparticular As Int64, ByVal telefonomovil As Int64, ByVal direcion As String, ByVal ciudad As String)
        Try
            Cursor.Current = Cursors.WaitCursor
            conectar()
            comando = New SqlCommand("insert into cliente values( '" & NOMBRE & "','" & apellido & "'," & identificacion & "," & telefonoparticular & "," & telefonomovil & ",'" & direcion & "','" & ciudad & "')", CON)
            comando.ExecuteNonQuery()
            MsgBox("Los datos han sidos guardados", MessageBoxButtons.OK)
            Cursor.Current = Cursors.Arrow
        Catch ex As Exception
            MsgBox("Se ha producido un error al guardar" & ex.ToString, MessageBoxButtons.OK)
        End Try
        CON.Close()
    End Sub
    Sub actualizarCLIENTE(ByVal NOMBRE As String, ByVal apellido As String, ByVal identificacion As Decimal, ByVal telefonoparticular As Decimal, ByVal telefonomovil As Decimal, ByVal direcion As String, ByVal ciudad As String, ByVal codigo As Integer)
        Try
            conectar()
            comando = New SqlCommand("update cliente set nom_cli ='" & NOMBRE & "',ape_cli ='" & apellido & "',id_cli ='" & identificacion & "',tel_cli ='" & telefonoparticular & "',tel_movil_cli ='" & telefonomovil & "',direc_cli ='" & direcion & "',ciu_cli ='" & ciudad & "' where codi_cli ='" & codigo & "'", CON)
            comando.ExecuteNonQuery()
            MsgBox("Datos  modificar los datos")
        Catch ex As Exception
            MsgBox("Error al modificar los datos" & ex.ToString)
        End Try
        CON.Close()
    End Sub
    Function nuevoCLIENTE()
        conectar()
        table = New DataTable
        comando = New SqlCommand("select * from cliente", CON)
        leer = comando.ExecuteReader
        table.Load(leer, LoadOption.OverwriteChanges)
        FILA = table.Rows.Count + 1
        CON.Close()
        Return FILA
    End Function
    Sub ELIMINARCLIENTE(ByVal CODIGO As Integer)
        Try
            conectar()
            comando = New SqlCommand("delete from cliente where codi_cli=" & CODIGO, CON)
            comando.ExecuteNonQuery()
            MsgBox("DATOS ELIMINADOS", MsgBoxStyle.OkCancel)
        Catch ex As Exception
            MsgBox("Error al eliminar" & ex.ToString, MsgBoxStyle.OkCancel)
        End Try
        CON.Close()
    End Sub
    Sub BUSCARCLIENTE(ByVal CODIGO As Integer)
        Try
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select * from cliente where codi_cli=" & CODIGO, CON)
            leer = comando.ExecuteReader
            If (leer.Read) Then
                MsgBox("LOS DATOS FUERON ENCONTRADOS EXITOSAMENTE ", MsgBoxStyle.OkCancel)
                BUSCARCLIENTE_CARGARDATOS(CODIGO)
            Else
                MsgBox("DATO NO EXIXTE", MsgBoxStyle.OkCancel)
            End If
        Catch ex As Exception
            MsgBox("Error al consultar" & ex.ToString, MsgBoxStyle.RetryCancel)
        End Try
        CON.Close()
    End Sub
    Sub BUSCARCLIENTE_CARGARDATOS(ByVal CODIGO As Integer)
        CON.Close()
        Try
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select * from cliente where codi_cli=" & CODIGO, CON)
            leer = comando.ExecuteReader
            table.Load(leer, LoadOption.OverwriteChanges)
            CLIENTE.TXT_codigo.Text = table.Rows(0)("codi_cli").ToString
            CLIENTE.TXT_NOMBRE.Text = table.Rows(0)("nom_cli").ToString
            CLIENTE.TXT_APELLIDOS.Text = table.Rows(0)("ape_cli").ToString
            CLIENTE.TXT_identificacion.Text = table.Rows(0)("id_cli").ToString
            CLIENTE.TXT_telefonoparticular.Text = table.Rows(0)("tel_cli").ToString
            CLIENTE.TXT_telefonomovil.Text = table.Rows(0)("tel_movil_cli").ToString
            CLIENTE.TXT_direccion.Text = table.Rows(0)("direc_cli").ToString
            CLIENTE.TXT_ciudad.Text = table.Rows(0)("ciu_cli").ToString
        Catch ex As Exception
            MsgBox("Error al consultar" & ex.ToString, MsgBoxStyle.Question)
        End Try
        CON.Close()
    End Sub

    'DATOS DE PRODUCTO
    Function mostrar_PRODUCTO()
        conectar()
        table = New DataTable
        comando = New SqlCommand("select * from producto", CON)
        leer = comando.ExecuteReader
        table.Load(leer, LoadOption.OverwriteChanges)
        FILA = table.Rows.Count + 1
        CON.Close()
        Return table
    End Function
    Sub GUARDAR_PRODUCTO(ByVal NOMBRE As String, ByVal CODIGO_VARRAS As Int64, ByVal MARCA As String, ByVal SEXO As String, ByVal TIPO As String, ByVal presio As Int64, ByVal imagen As String, ByVal CANTIDAD As Int64)
        Try
            Cursor.Current = Cursors.WaitCursor
            conectar()
            comando = New SqlCommand("insert into producto values('" & NOMBRE & "'," & CODIGO_VARRAS & ",'" & MARCA & "','" & SEXO & "','" & TIPO & "'," & presio & ",'" & imagen & "'," & CANTIDAD & ")", CON)
            comando.ExecuteNonQuery()
            MsgBox("Los datos han sidos guardados", MessageBoxButtons.YesNoCancel)
            Cursor.Current = Cursors.Arrow
        Catch ex As Exception
            MsgBox("Se ha producido un error al guardar" & ex.ToString, MsgBoxStyle.RetryCancel)
        End Try
        CON.Close()
    End Sub
    Sub GUARDAR_PRO_COL(ByVal CODIGO_PRODUCTO As Integer, ByVal CODIG_COLOR As Integer)
        Try
            conectar()
            comando = New SqlCommand("insert into pro_col values(" & CODIGO_PRODUCTO & "," & CODIG_COLOR & ")", CON)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Se ha producido un error al guardar" & ex.ToString, MsgBoxStyle.RetryCancel)
        End Try
        CON.Close()
    End Sub
    Sub GUARDAR_PRO_TAL(ByVal CODIGO_PRODUCTO As Integer, ByVal CODIG_TALLAS As Integer, ByVal CANTIDADA As Int64)
        Try
            conectar()
            comando = New SqlCommand("insert into pro_tal values(" & CODIGO_PRODUCTO & "," & CODIG_TALLAS & "," & CANTIDADA & ")", CON)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Se ha producido un error al guardar" & ex.ToString, MessageBoxButtons.OK)
        End Try
        CON.Close()
    End Sub
    Sub actualizar_PRODUCTO(ByVal NOMBRE As String, ByVal CODIGO_VARRAS As Int64, ByVal MARCA As String, ByVal SEXO As String, ByVal TIPO As String, ByVal presio As Int64, ByVal imagen As String, ByVal CANTIDAD As Integer, ByVal CODIGO As Integer)
        Try
            conectar()
            comando = New SqlCommand("update producto set nom_pro ='" & NOMBRE & "',cdb_pro ='" & CODIGO_VARRAS & "',mar_pro ='" & MARCA & "',sec_pro ='" & SEXO & "',Tipo_pro ='" & TIPO & "',pre_pro ='" & presio & "',imge_pro ='" & imagen & "',can_pro ='" & CANTIDAD & "' where codi_pro ='" & CODIGO & "'", CON)
            comando.ExecuteNonQuery()
            MsgBox("LOS DATOS FUERON ACTUALIZADOS CON EXITO", MsgBoxStyle.YesNoCancel)
        Catch ex As Exception
            MsgBox("Error al modificar los datos" & ex.ToString)
        End Try
        CON.Close()
    End Sub
    Sub ACTUALIZAR_PRO_TALL(ByVal CODIGO_PRODUCTO As Int64, ByVal CODIG_TALL As Int64, ByVal CANTIDADA As Integer)
        Try
            conectar()
            comando = New SqlCommand("insert into pro_tal values(" & CODIGO_PRODUCTO & "," & CODIG_TALL & "," & CANTIDADA & ")", CON)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Se ha producido un error al guardar" & ex.ToString, MessageBoxButtons.OK)
        End Try
        CON.Close()
    End Sub
    Sub ELIMINAR_pro_tal(ByVal CODIGO As Integer)
        Try
            conectar()
            comando = New SqlCommand("delete from pro_tal where codi_pro= " & CODIGO, CON)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al eliminar" & ex.ToString, MsgBoxStyle.OkCancel)
        End Try
        CON.Close()
    End Sub
    Sub ACTUALIZAR_PRO_COL(ByVal CODIGO_PRODUCTO As Int64, ByVal CODIG_COLOR As Int64)
        Try
            conectar()
            comando = New SqlCommand("insert into pro_col values(" & CODIGO_PRODUCTO & "," & CODIG_COLOR & ")", CON)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Se ha producido un error al guardar" & ex.ToString, MessageBoxButtons.OK)
        End Try
        CON.Close()
    End Sub
    Sub ELIMINAR_pro_col(ByVal CODIGO As Integer)
        Try
            conectar()
            comando = New SqlCommand("delete from pro_col where codi_pro=" & CODIGO, CON)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al eliminar" & ex.ToString, MsgBoxStyle.OkCancel)
        End Try
        CON.Close()
    End Sub
    Function nuevo_PRODUCTO()
        conectar()
        table = New DataTable
        comando = New SqlCommand("select * from producto", CON)
        leer = comando.ExecuteReader
        table.Load(leer, LoadOption.OverwriteChanges)
        FILA = table.Rows.Count + 1
        CON.Close()
        Return FILA
    End Function
    Sub ELIMINAR_PRODUCTO(ByVal CODIGO As Integer)
        Try
            conectar()
            comando = New SqlCommand("delete from producto where codi_pro=" & CODIGO, CON)
            comando.ExecuteNonQuery()
            MsgBox("DATOS ELIMINADOS", MsgBoxStyle.OkCancel)
        Catch ex As Exception
            MsgBox("Error al eliminar" & ex.ToString, MsgBoxStyle.OkCancel)
        End Try
        CON.Close()
    End Sub
    Sub BUSCAR_PRODUCTO(ByVal CODIGO As Int64)
        Try
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select * from producto where codi_pro= " & CODIGO, CON)
            leer = comando.ExecuteReader
            'table.Load(leer, LoadOption.OverwriteChanges)
            'AGREGAR_PRODUCTO.TXT_codigo.Text = table.Rows(0)("codi_pro").ToString
            'AGREGAR_PRODUCTO.TXT_NOMBRE.Text = table.Rows(0)("nom_pro").ToString
            'AGREGAR_PRODUCTO.TXT_CODIGODEVARRAS.Text = table.Rows(0)("cdb_pro").ToString
            'AGREGAR_PRODUCTO.CNX_MARCAS.Text = table.Rows(0)("mar_pro").ToString
            'AGREGAR_PRODUCTO.COM_SEXO.Text = table.Rows(0)("sec_pro").ToString
            'AGREGAR_PRODUCTO.CNX_TIPO.Text = table.Rows(0)("Tipo_pro").ToString
            'AGREGAR_PRODUCTO.TXT_PRESIO.Text = table.Rows(0)("pre_pro").ToString
            'AGREGAR_PRODUCTO.PictureBox1.Image = Image.FromFile(table.Rows(0)("imge_pro").ToString)
            'AGREGAR_PRODUCTO.TXTR_CANTIDAD.Text = table.Rows(0)("can_pro").ToString
            ''BUSCAR EN  PRO_COL
            'table = New DataTable
            'comando = New SqlCommand("select color.nom_col as color from color inner join dbo.pro_col on color.codi_col = dbo.pro_col.codi_col where codi_pro = " & CODIGO, CON)
            'leer = comando.ExecuteReader
            'table.Load(leer, LoadOption.OverwriteChanges)
            'For index As Integer = 0 To table.Rows.Count - 1

            '    For index1 As Integer = 0 To AGREGAR_PRODUCTO.DataGridView1.Rows.Count - 1

            '        If AGREGAR_PRODUCTO.DataGridView1.Item("COLORES", index1).Value = table.Rows(index)("color") Then
            '            AGREGAR_PRODUCTO.DataGridView1.Item("BUTON", index1).Value = True
            '        End If
            '    Next
            '    'AGREGAR_PRODUCTO.DataGridView1.Item("BUTON", table.Rows(index)("codi_col") - 1).Value = True
            'Next
            'table = New DataTable
            'comando = New SqlCommand("select tallas.nom_tal as tallas from tallas inner join dbo.pro_tal on tallas.codi_tal = dbo.pro_tal.codi_tal where codi_pro =" & CODIGO, CON)
            'leer = comando.ExecuteReader
            'table.Load(leer, LoadOption.OverwriteChanges)
            'For index As Integer = 0 To table.Rows.Count - 1
            '    For index1 As Integer = 0 To AGREGAR_PRODUCTO.DataGridView2.Rows.Count - 1
            '        If AGREGAR_PRODUCTO.DataGridView2.Item("TALLAS", index1).Value = table.Rows(index)("tallas") Then
            '            AGREGAR_PRODUCTO.DataGridView2.Item("BUTON_TALL", index1).Value = True
            '        End If
            '    Next
            'Next
            If (leer.Read) Then
                MsgBox("LOS DATOS FUERON ENCONTRADOS EXITOSAMENTE ", MsgBoxStyle.RetryCancel)
                BUSCAR_PRODUCTO_CARGARLOSDATOS(CODIGO)
            Else
                MsgBox("DATO NO EXIXTE", MsgBoxStyle.OkCancel)
            End If
        Catch ex As Exception
            MsgBox("Error al consultar" & ex.ToString, MessageBoxButtons.RetryCancel)
        End Try
        CON.Close()
    End Sub
    Sub BUSCAR_PRODUCTO_CARGARLOSDATOS(ByVal CODIGO As Integer)
        CON.Close()
        Try
            CON.Open()
            'BUSCAR EN  PRO_COL
            table = New DataTable
            comando = New SqlCommand("select color.nom_col as color from color inner join dbo.pro_col on color.codi_col = dbo.pro_col.codi_col where codi_pro = " & CODIGO, CON)
            leer = comando.ExecuteReader
            table.Load(leer, LoadOption.OverwriteChanges)
            For index As Integer = 0 To table.Rows.Count - 1

                For index1 As Integer = 0 To AGREGAR_PRODUCTO.DataGridView1.Rows.Count - 1

                    If AGREGAR_PRODUCTO.DataGridView1.Item("COLORES", index1).Value = table.Rows(index)("color") Then
                        AGREGAR_PRODUCTO.DataGridView1.Item("BUTON", index1).Value = True
                    End If
                Next
                'AGREGAR_PRODUCTO.DataGridView1.Item("BUTON", table.Rows(index)("codi_col") - 1).Value = True
            Next
            table = New DataTable
            comando = New SqlCommand("select tallas.nom_tal as tallas from tallas inner join dbo.pro_tal on tallas.codi_tal = dbo.pro_tal.codi_tal where codi_pro =" & CODIGO, CON)
            leer = comando.ExecuteReader
            table.Load(leer, LoadOption.OverwriteChanges)
            For index As Integer = 0 To table.Rows.Count - 1
                For index1 As Integer = 0 To AGREGAR_PRODUCTO.DataGridView2.Rows.Count - 1
                    If AGREGAR_PRODUCTO.DataGridView2.Item("TALLAS", index1).Value = table.Rows(index)("tallas") Then
                        AGREGAR_PRODUCTO.DataGridView2.Item("BUTON_TALL", index1).Value = True
                    End If
                Next
            Next
            table = New DataTable
            comando = New SqlCommand("select * from producto where codi_pro =" & CODIGO, CON)
            leer = comando.ExecuteReader
            table.Load(leer, LoadOption.OverwriteChanges)
            AGREGAR_PRODUCTO.TXT_codigo.Text = table.Rows(0)("codi_pro").ToString
            AGREGAR_PRODUCTO.TXT_NOMBRE.Text = table.Rows(0)("nom_pro").ToString
            AGREGAR_PRODUCTO.TXT_CODIGODEVARRAS.Text = table.Rows(0)("cdb_pro").ToString
            AGREGAR_PRODUCTO.CNX_MARCAS.Text = table.Rows(0)("mar_pro").ToString
            AGREGAR_PRODUCTO.COM_SEXO.Text = table.Rows(0)("sec_pro").ToString
            AGREGAR_PRODUCTO.CNX_TIPO.Text = table.Rows(0)("Tipo_pro").ToString
            AGREGAR_PRODUCTO.TXT_PRESIO.Text = table.Rows(0)("pre_pro").ToString
            AGREGAR_PRODUCTO.TXTR_CANTIDAD.Text = table.Rows(0)("can_pro").ToString
            AGREGAR_PRODUCTO.PictureBox1.Image = Image.FromFile(table.Rows(0)("imge_pro").ToString)
            AGREGAR_PRODUCTO.LBL_IMGEN.Text = table.Rows(0)("imge_pro").ToString
        Catch ex As Exception
            MsgBox("Error al consultar" & ex.ToString, MessageBoxButtons.OK)
        End Try
        CON.Close()
    End Sub
    Function CONSULTAR_COLORES()
        conectar()
        table = New DataTable
        comando = New SqlCommand("select * from color ", CON)
        leer = comando.ExecuteReader
        table.Load(leer, LoadOption.OverwriteChanges)
        CON.Close()
        Return table
    End Function
    Function CONSULTAR_TALLAS()
        conectar()
        table = New DataTable
        comando = New SqlCommand("select * from tallas", CON)
        leer = comando.ExecuteReader
        table.Load(leer, LoadOption.OverwriteChanges)
        FILA = table.Rows.Count + 1
        CON.Close()
        Return table
    End Function
    'DATOS FACTURA
    Sub BUSCARCLIENTEfactura(ByVal CODIGO As Integer)
        Try
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select * from cliente where codi_cli=" & CODIGO, CON)
            leer = comando.ExecuteReader
            If (leer.Read) Then
                MsgBox("LOS DATOS FUERON ENCONTRADOS EXITOSAMENTE ", MsgBoxStyle.OkCancel)
                BUSCARCLIENTEfactura_cargardatos(CODIGO)
            Else
                MsgBox("DATO NO EXIXTE", MsgBoxStyle.OkCancel)
            End If

        Catch ex As Exception
            MsgBox("Error al consultar" & ex.ToString)
        End Try
        CON.Close()
    End Sub
    Sub BUSCARCLIENTEfactura_cargardatos(ByVal CODIGO As Integer)
        Try
            CON.Close()
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select * from cliente where codi_cli=" & CODIGO, CON)
            leer = comando.ExecuteReader
            table.Load(leer, LoadOption.OverwriteChanges)
            FACTURA_SECCION_CAJA.codigo_cliente.Text = table.Rows(0)("codi_cli").ToString
            FACTURA_SECCION_CAJA.nombre.Text = table.Rows(0)("nom_cli").ToString
            FACTURA_SECCION_CAJA.apellido.Text = table.Rows(0)("ape_cli").ToString
            FACTURA_SECCION_CAJA.identificacion.Text = table.Rows(0)("id_cli").ToString
            FACTURA_SECCION_CAJA.telefonoparticular.Text = table.Rows(0)("tel_cli").ToString
            FACTURA_SECCION_CAJA.telefonomovil.Text = table.Rows(0)("tel_movil_cli").ToString
            FACTURA_SECCION_CAJA.direccion.Text = table.Rows(0)("direc_cli").ToString
            FACTURA_SECCION_CAJA.cidad.Text = table.Rows(0)("ciu_cli").ToString
        Catch ex As Exception
            MsgBox("Error al consultar" & ex.ToString)
        End Try
        CON.Close()
    End Sub
    Function nuevoFACTURA()
        conectar()
        table = New DataTable
        comando = New SqlCommand("select * from factura", CON)
        leer = comando.ExecuteReader
        table.Load(leer, LoadOption.OverwriteChanges)
        FILA = table.Rows.Count + 1
        CON.Close()
        Return FILA
    End Function
    Sub BUSCAR_PRODUCTO_FACTURA(ByVal CODIGO As Int64)
        CON.Close()
        Try
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select * from producto where codi_pro =" & CODIGO, CON)
            leer = comando.ExecuteReader
            table.Load(leer, LoadOption.OverwriteChanges)
        Catch ex As Exception
            MsgBox("Error al consultar" & ex.ToString)
        End Try
        CON.Close()
    End Sub
    Function BUSCAR_PRODUCTO_FACTURA_cargardatos(ByVal CODIGO As Int64)
        Try
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select * from producto where codi_pro =" & CODIGO, CON)
            leer = comando.ExecuteReader
            If (leer.Read) Then
                MsgBox("LOS DATOS FUERON ENCONTRADOS EXITOSAMENTE ", MsgBoxStyle.YesNo)
                BUSCAR_PRODUCTO_FACTURA(CODIGO)
            Else
                MsgBox("DATO NO EXIXTE", MsgBoxStyle.OkCancel)
            End If
        Catch ex As Exception
            MsgBox("Error al consultar" & ex.ToString)
        End Try
        CON.Close()
        Return table
    End Function
    Sub actualizar_PRODUCTO_FACTURA(ByVal CANTIDAD As Integer, ByVal CODIGO As Integer)
        Try
            conectar()
            comando = New SqlCommand("update producto set can_pro = can_pro - " & CANTIDAD & " where codi_pro =" & CODIGO, CON)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al modificar los datos" & ex.ToString)
        End Try
        CON.Close()
    End Sub
    Sub actualizar_PRO_TALL_FAC(ByVal CANTIDAD As Integer, ByVal TALLAS As Integer, ByVal CODIGO As Integer)
        Try
            conectar()
            comando = New SqlCommand("update pro_tal set can_tal = can_tal - " & CANTIDAD & " where  codi_tal =" & TALLAS & " and  codi_pro =" & CODIGO, CON)
            comando.ExecuteNonQuery()
            'MsgBox("DATOS MODIFICADOS")
        Catch ex As Exception
            MsgBox("Error al modificar los datos" & ex.ToString)
        End Try
        CON.Close()
    End Sub
    Function mostrarFACTURA()
        conectar()
        table = New DataTable
        comando = New SqlCommand("select * from factura", CON)
        leer = comando.ExecuteReader
        table.Load(leer, LoadOption.OverwriteChanges)
        FILA = table.Rows.Count + 1
        CON.Close()
        Return table
    End Function
    Sub GUARDAR_FACTURA(ByVal FECHA As String, ByVal CODIGO_EMPLEADO As Int64, ByVal CODIGO_CLIENTE As Int64)
        Try
            conectar()
            comando = New SqlCommand("insert into factura values( '" & FECHA & "'," & CODIGO_EMPLEADO & "," & CODIGO_CLIENTE & ")", CON)
            comando.ExecuteNonQuery()
            MsgBox("Los datos han sidos guardados", MessageBoxButtons.OK)
        Catch ex As Exception
            MsgBox("Se ha producido un error al guardar" & ex.ToString, MessageBoxButtons.OK)
        End Try
        CON.Close()
    End Sub
    Sub GUARDAR_DETALLE_FACTURA(ByVal CANTIDAD As Int64, ByVal CODIGO_FACTURA As Int64, ByVal CODIGO_PRODUCTO As Integer)
        Try
            conectar()
            comando = New SqlCommand("insert into detalle_factura values(" & CANTIDAD & "," & CODIGO_FACTURA & "," & CODIGO_PRODUCTO & ")", CON)
            comando.ExecuteNonQuery()
            'MsgBox("Los datos han sidos guardados", MessageBoxButtons.OK)
        Catch ex As Exception
            MsgBox("Se ha producido un error al guardar" & ex.ToString, MessageBoxButtons.OK)
        End Try
        CON.Close()
    End Sub

    'COMPRA 
    Sub GUARDAR_COMPRA(ByVal FECHA As String, ByVal CODIGO_PROVEEDOR As Int64, ByVal CODIGO_EMPLEADO As Int64)
        Try
            conectar()
            comando = New SqlCommand("insert into compra values( '" & FECHA & "'," & CODIGO_PROVEEDOR & "," & CODIGO_EMPLEADO & ")", CON)
            comando.ExecuteNonQuery()
            MsgBox("Los datos han sidos guardados", MessageBoxButtons.OK)
            Cursor.Current = Cursors.Arrow
        Catch ex As Exception
            MsgBox("Se ha producido un error al guardar" & ex.ToString, MessageBoxButtons.OK)
        End Try
        CON.Close()
    End Sub
    Sub GUARDAR_DETALLE_COMPRA(ByVal CANTIDAD As Int64, ByVal CODIGO_FACTURA As Int64, ByVal CODIGO_PRODUCTO As Int64)
        Try
            conectar()
            comando = New SqlCommand("insert into detalle_compra values(" & CANTIDAD & "," & CODIGO_FACTURA & "," & CODIGO_PRODUCTO & ")", CON)
            comando.ExecuteNonQuery()
            'MsgBox("Los datos han sidos guardados", MessageBoxButtons.OK)
        Catch ex As Exception
            MsgBox("Se ha producido un error al guardar" & ex.ToString, MessageBoxButtons.OK)
        End Try
        CON.Close()
    End Sub
    Function nuevacompra()
        conectar()
        table = New DataTable
        comando = New SqlCommand("select * from compra", CON)
        leer = comando.ExecuteReader
        table.Load(leer, LoadOption.OverwriteChanges)
        FILA = table.Rows.Count + 1
        CON.Close()
        Return FILA
    End Function
    Sub BUSCAR_PRODUCTO_COMPRA(ByVal CODIGO As Int64)
        CON.Close()
        Try
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select * from producto where codi_pro =" & CODIGO, CON)
            leer = comando.ExecuteReader
            table.Load(leer, LoadOption.OverwriteChanges)
        Catch ex As Exception
            MsgBox("Error al consultar" & ex.ToString)
        End Try
        CON.Close()
    End Sub
    Function BUSCAR_PRODUCTO_COMPRA_cargardatos(ByVal CODIGO As Int64)
        CON.Close()
        Try
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select * from producto where codi_pro =" & CODIGO, CON)
            leer = comando.ExecuteReader
            'table = New DataTable
            'comando = New SqlCommand("select * from producto where codi_pro =" & CODIGO, CON)
            'leer = comando.ExecuteReader
            If (leer.Read) Then
                MsgBox("LOS DATOS FUERON ENCONTRADOS EXITOSAMENTE ", MsgBoxStyle.YesNo)
                BUSCAR_PRODUCTO_FACTURA(CODIGO)
            Else
                MsgBox("DATO NO EXIXTE", MsgBoxStyle.OkCancel)
            End If
        Catch ex As Exception
            MsgBox("Error al consultar" & ex.ToString)
        End Try
        CON.Close()
        Return table

    End Function
    Sub actualizar_PRODUCTO_COMPRA(ByVal CANTIDAD As Integer, ByVal PRESIO As Integer, ByVal CODIGO As Integer)
        Try
            conectar()
            comando = New SqlCommand("update producto set can_pro = can_pro + " & CANTIDAD & ",pre_pro =" & PRESIO & " where codi_pro =" & CODIGO, CON)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al modificar los datos" & ex.ToString)
        End Try
        CON.Close()
    End Sub
    Sub actualizar_PRO_TALL_COMPRA(ByVal CANTIDAD As Integer, ByVal TALLAS As Integer, ByVal CODIGO As Integer)
        Try
            conectar()
            comando = New SqlCommand("update pro_tal set can_tal = can_tal + " & CANTIDAD & " where codi_tal = " & TALLAS & " where codi_pro =" & CODIGO, CON)
            comando.ExecuteNonQuery()
            MsgBox("DATOS MODIFICADOS")
        Catch ex As Exception
            MsgBox("Error al modificar los datos" & ex.ToString)
        End Try
        CON.Close()
    End Sub
    Function mostrarCOMPRA()
        conectar()
        table = New DataTable
        comando = New SqlCommand("select * from compra", CON)
        leer = comando.ExecuteReader
        table.Load(leer, LoadOption.OverwriteChanges)
        FILA = table.Rows.Count + 1
        CON.Close()
        Return table
    End Function
    Sub BUSCARPROVEEDOR_compra(ByVal CODIGO As Integer)
        Try
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select * from PROVEEDOR where codi_prov=" & CODIGO, CON)
            leer = comando.ExecuteReader
            If (leer.Read) Then
                MsgBox("LOS DATOS FUERON ENCONTRADOS EXITOSAMENTE ", MsgBoxStyle.OkOnly)
                BUSCARPROVEEDOR_CARGARDATOS_compra(CODIGO)
            Else
                MsgBox("DATO NO EXIXTE", MsgBoxStyle.OkCancel)
            End If
        Catch ex As Exception
            MsgBox("Error al consultar" & ex.ToString, MsgBoxStyle.OkCancel)
        End Try
        CON.Close()
    End Sub
    Sub BUSCARPROVEEDOR_CARGARDATOS_compra(ByVal CODIGO As Integer)
        CON.Close()
        Try
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select * from PROVEEDOR where codi_prov =" & CODIGO, CON)
            leer = comando.ExecuteReader
            table.Load(leer, LoadOption.OverwriteChanges)
            PEDIDOS.codigo_proveedor.Text = table.Rows(0)("codi_prov").ToString
            PEDIDOS.razon_social.Text = table.Rows(0)("raz_prov").ToString
            PEDIDOS.nit.Text = table.Rows(0)("nit_prov").ToString
            PEDIDOS.telefonoparticular.Text = table.Rows(0)("tele_prov").ToString
            PEDIDOS.telefono_fax.Text = table.Rows(0)("tele_fax").ToString
            PEDIDOS.direccion.Text = table.Rows(0)("dir_prov").ToString
            PEDIDOS.cidad.Text = table.Rows(0)("cui_prov").ToString
            PEDIDOS.PictureBox1.Image = Image.FromFile(table.Rows(0)("imge_prov").ToString)
            PEDIDOS.wep.Text = table.Rows(0)("web_prov").ToString
        Catch ex As Exception
            MsgBox("Error al consultar" & ex.ToString, MsgBoxStyle.OkCancel)
        End Try
        CON.Close()
    End Sub

    'USUARIO
    Sub GUARDAR_USUSRIO(ByVal NOMBRE_USURIO As String, ByVal CONTRASEÑA As String, ByVal CODIGO_EMPLEADO As String, ByVal CARGO As String)
        Try
            Cursor.Current = Cursors.WaitCursor
            conectar()
            comando = New SqlCommand("insert into usuario values('" & NOMBRE_USURIO & "','" & CONTRASEÑA & "'," & CODIGO_EMPLEADO & ",'" & CARGO & "')", CON)
            comando.ExecuteNonQuery()
            MsgBox("Los datos han sidos guardados", MessageBoxButtons.OK)
            Cursor.Current = Cursors.Arrow
        Catch ex As Exception
            MsgBox("Se ha producido un error al guardar" & ex.ToString, MessageBoxButtons.OK)
        End Try
        CON.Close()
    End Sub
    Sub actualizar_USURIO(ByVal CONTRASEÑA As String, ByVal NOMBRE_USURIO As String)
        Try
            conectar()
            comando = New SqlCommand("update usuario set cod_con_usu =" & CONTRASEÑA & "where nom_usu =" & NOMBRE_USURIO, CON)
            comando.ExecuteNonQuery()
            MsgBox("Datos  modificar los datos")
        Catch ex As Exception
            MsgBox("Error al modificar los datos" & ex.ToString)
        End Try
        CON.Close()
    End Sub
    Sub GUARDAREMPLEADO_regiatro(ByVal NOMBRE As String, ByVal apellido As String, ByVal identificacion As Int64, ByVal telefonoparticular As Int64, ByVal telefonomovil As Int64, ByVal direcion As String, ByVal ciudad As String, ByVal correo As String, ByVal salario As Int64)
        Try
            conectar()
            comando = New SqlCommand("insert into empleado values( '" & NOMBRE & "','" & apellido & "'," & identificacion & "," & telefonoparticular & "," & telefonomovil & ",'" & direcion & "','" & ciudad & "','" & correo & "','" & salario & "')", CON)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Se ha producido un error al guardar" & ex.ToString, MessageBoxButtons.OK)
        End Try
        CON.Close()
    End Sub
    Sub INGRESO_DE_ADMINISTRADOR(ByVal l As String, ByVal usuario As String, ByVal CODIGO As String)
        Try
            l = INGRESAR.ComboBox1.Text
            usuario = INGRESAR.TXT_USUARIO.Text
            CODIGO = INGRESAR.TXT_INGRECECONTRACEÑA.Text
            Select Case l
                Case Is = "ADMINISTRADOR"
                    conectar()
                    'select * from usuario where car_emp LIKE 'ADMINISTRADOR' AND nom_usu LIKE 'Miguel' AND cod_con_usu ='Miguel'
                    comando = New SqlCommand("select * from usuario where car_emp LIKE '" & l & "' AND nom_usu = '" & usuario & "' AND cod_con_usu  ='" & CODIGO & "'", CON)
                    'select * from usuario where car_emp LIKE 'ADMINISTRADOR' AND nom_usu = 'Miguel' AND cod_con_usu ='Miguel'
                    leer = comando.ExecuteReader
                    If (leer.Read) Then
                        MsgBox("CONTRASEÑA Y USUSRIOS CORECTOS", MsgBoxStyle.OkCancel)
                        INGRESAR.BTN_ACEPTAR.Cursor = Cursors.WaitCursor
                        For X = 1 To 100 Step 1.0
                            INGRESAR.ProgressBar1.Value = X
                            INGRESAR.Label5.Text = X
                            Application.DoEvents()
                            System.Threading.Thread.Sleep(2)
                        Next
                        INGRESAR.Close()
                        ADMINISTRADOR.Show()
                        INGRESAR.Timer1.Start()
                    Else
                        MsgBox("ERROR CONTRASEÑA Y USUSRIOS CORECTOS", MsgBoxStyle.OkCancel)
                    End If
            End Select
        Catch ex As Exception
            MsgBox("error" & ex.ToString, MsgBoxStyle.RetryCancel)
        End Try

        CON.Close()
    End Sub
    Sub INGRESAR_cargardatos(ByVal CODIGO As Integer)
        Try
            CON.Close()
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select empleado.car_emp as empleado from empleado inner join dbo.usuario on empleado.codi_emp = dbo.usuario.cod_con_usu where cod_con_usu =" & CODIGO, CON)
            leer = comando.ExecuteReader
        Catch ex As Exception
            MsgBox("Error al consultar" & ex.ToString)
        End Try
        CON.Close()
    End Sub
    Sub BUSCAR_PRODUCTO_PRODUCTOS(ByVal CODIGO As Int64)
        Try
            CON.Open()
            table = New DataTable
            comando = New SqlCommand("select * from producto where codi_pro= " & CODIGO, CON)
            leer = comando.ExecuteReader
            If (leer.Read) Then
                MsgBox("LOS DATOS FUERON ENCONTRADOS EXITOSAMENTE ", MsgBoxStyle.RetryCancel)
                BUSCAR_PRODUCTO_CARGARLOSDATOS_PRODUCTOS(CODIGO)
            Else
                MsgBox("DATO NO EXIXTE", MsgBoxStyle.OkCancel)
            End If
        Catch ex As Exception
            MsgBox("Error al consultar" & ex.ToString, MessageBoxButtons.RetryCancel)
        End Try
        CON.Close()
    End Sub
    Sub BUSCAR_PRODUCTO_CARGARLOSDATOS_PRODUCTOS(ByVal CODIGO As Integer)
        CON.Close()
        Try
            CON.Open()
            'BUSCAR EN  PRO_COL
            table = New DataTable
            comando = New SqlCommand("select color.nom_col as color from color inner join dbo.pro_col on color.codi_col = dbo.pro_col.codi_col where codi_pro = " & CODIGO, CON)
            leer = comando.ExecuteReader
            table.Load(leer, LoadOption.OverwriteChanges)
            For index As Integer = 0 To table.Rows.Count - 1

                For index1 As Integer = 0 To Productos.DataGridView1.Rows.Count - 1

                    If Productos.DataGridView1.Item("COLORES", index1).Value = table.Rows(index)("color") Then
                        Productos.DataGridView1.Item("BUTON", index1).Value = True
                    End If
                Next
                'AGREGAR_PRODUCTO.DataGridView1.Item("BUTON", table.Rows(index)("codi_col") - 1).Value = True
            Next
            table = New DataTable
            comando = New SqlCommand("select tallas.nom_tal as tallas from tallas inner join dbo.pro_tal on tallas.codi_tal = dbo.pro_tal.codi_tal where codi_pro =" & CODIGO, CON)
            leer = comando.ExecuteReader
            table.Load(leer, LoadOption.OverwriteChanges)
            For index As Integer = 0 To table.Rows.Count - 1
                For index1 As Integer = 0 To Productos.DataGridView2.Rows.Count - 1
                    If Productos.DataGridView2.Item("TALLAS", index1).Value = table.Rows(index)("tallas") Then
                        Productos.DataGridView2.Item("BUTON_TALL", index1).Value = True
                    End If
                Next
            Next
            table = New DataTable
            comando = New SqlCommand("select * from producto where codi_pro =" & CODIGO, CON)
            leer = comando.ExecuteReader
            table.Load(leer, LoadOption.OverwriteChanges)
            Productos.TXT_COD.Text = table.Rows(0)("codi_pro").ToString
            Productos.TXT_NOMB.Text = table.Rows(0)("nom_pro").ToString
            Productos.TXT_CODB.Text = table.Rows(0)("cdb_pro").ToString
            Productos.TXT_MRC.Text = table.Rows(0)("mar_pro").ToString
            Productos.TXT_CANT.Text = table.Rows(0)("can_pro").ToString
            Productos.TXT_TIP.Text = table.Rows(0)("Tipo_pro").ToString
            Productos.TXT_PREC.Text = table.Rows(0)("pre_pro").ToString
            Productos.TXT_SEX.Text = table.Rows(0)("sec_pro").ToString
            Productos.PictureBox1.Image = Image.FromFile(table.Rows(0)("imge_pro").ToString)
            'Productos.LBL_IMGEN.Text = table.Rows(0)("imge_pro").ToString
        Catch ex As Exception
            MsgBox("Error al consultar" & ex.ToString, MessageBoxButtons.OK)
        End Try
        CON.Close()
    End Sub
End Class





