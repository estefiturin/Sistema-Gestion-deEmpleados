Public Class frmConsultaDatos
    Private Sub frmConsultaDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        While i < IND
            cmbEmpleado.Items.Add(empleado(i).nombre)

            i = i + 1

        End While
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim i As Integer = cmbEmpleado.SelectedIndex
        lblCodigo.Text = empleado(i).codigo
        lblCategoria.Text = empleado(i).categoria
        lblSueldo.Text = empleado(i).sueldo
    End Sub
End Class