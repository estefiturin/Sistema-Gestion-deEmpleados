Public Class frmConSueldoMayorA
    Private Sub cmdListar_Click(sender As Object, e As EventArgs) Handles cmdListar.Click
        Dim i As Integer = 0
        Dim total As Decimal = 0
        Dim cantidad As Integer = 0
        dgvEmpleados.Rows.Clear()
        While i < IND
            If empleado(i).sueldo > txtImporte.Text Then
                dgvEmpleados.Rows.Add(empleado(i).codigo, empleado(i).nombre, empleado(i).categoria, empleado(i).sueldo)
                total = total + empleado(i).sueldo
                cantidad = cantidad + 1

            End If
            i = i + 1
        End While
        lblSueldo.Text = total
        lblCantidad.Text = cantidad

    End Sub
End Class