Public Class frmListadodeEmpleados
    Private Sub cmdListar_Click(sender As Object, e As EventArgs) Handles cmdListar.Click
        dgvListado.Rows.Clear()
        Dim total As Decimal = 0
        Dim cantidad As Integer = 0
        Dim i As Integer = 0
        While i < IND
            dgvListado.Rows.Add(empleado(i).codigo, empleado(i).nombre, empleado(i).categoria, empleado(i).sueldo)
            total = total + empleado(i).sueldo
            cantidad = cantidad + 1
            i = i + 1
        End While

        lblCantidadEmp.Text = cantidad
        lblSueldo.Text = total
    End Sub
End Class