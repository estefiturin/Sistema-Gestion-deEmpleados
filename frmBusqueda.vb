Public Class frmBusqueda
    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim i As Integer = 0
        While i < IND And empleado(i).codigo <> txtCodigo.Text
            i = i + 1
        End While
        If i = IND Then
            MessageBox.Show("Cliente no exisite")
            lblCodigo.Text = ""
            lblCategoria.Text = ""
            lblSueldo.Text = ""
        Else
            lblCodigo.Text = empleado(i).codigo
            lblCategoria.Text = empleado(i).categoria
            lblSueldo.Text = empleado(i).sueldo

        End If
    End Sub







End Class