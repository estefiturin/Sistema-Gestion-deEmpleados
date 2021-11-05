Public Class frmAgregarEmpleado
    Private Sub cmdCargar_Click(sender As Object, e As EventArgs) Handles cmdCargar.Click
        If IND < 100 Then
            empleado(IND).codigo = txtCodigo.Text
            empleado(IND).nombre = txtNombre.Text
            empleado(IND).categoria = txtCategoria.Text
            empleado(IND).sueldo = txtSueldo.Text

            IND = IND + 1

            MessageBox.Show("Datos cargados")
        Else
            MessageBox.Show("Error!")

        End If

        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtCategoria.Text = ""
        txtSueldo.Text = ""

    End Sub
    Private Sub DatosControl() ' Para controlar que los txt tengan datos'
        If txtCodigo.Text <> "" And txtNombre.Text <> "" And txtCategoria.Text <> "" And txtSueldo.Text <> "" Then
            cmdCargar.Enabled = True
        Else
            cmdCargar.Enabled = False
        End If

    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        DatosControl()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        DatosControl()
    End Sub

    Private Sub txtCategoria_TextChanged(sender As Object, e As EventArgs) Handles txtCategoria.TextChanged
        DatosControl()
    End Sub

    Private Sub txtSueldo_TextChanged(sender As Object, e As EventArgs) Handles txtSueldo.TextChanged
        DatosControl()
    End Sub
End Class