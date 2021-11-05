Public Class frmListadoCategoria


	Private Sub cmdListar_Click(sender As Object, e As EventArgs) Handles cmdListar.Click

		Dim i As Integer = 0
		Dim total As Decimal = 0
		Dim cantidad As Integer = 0
		dgvCategoria.Rows.Clear()

		While i < IND
			If empleado(i).categoria = txtCategoria.Text Then
				dgvCategoria.Rows.Add(empleado(i).codigo, empleado(i).nombre, empleado(i).categoria, empleado(i).sueldo)
				total = total + empleado(i).sueldo
				cantidad = cantidad + 1

			End If
			i = i + 1
		End While
		lblSueldos.Text = total
		lblEmpleados.Text = cantidad


	End Sub
End Class