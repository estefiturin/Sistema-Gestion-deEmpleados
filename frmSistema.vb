Public Class frmSistemas
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        frmAcercade.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ListadoGeneralDeEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoGeneralDeEmpleadoToolStripMenuItem.Click
        frmListadodeEmpleados.Show()
    End Sub

    Private Sub AgregarNuevoEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNuevoEmpleadoToolStripMenuItem.Click
        frmAgregarEmpleado.Show()
    End Sub

    Private Sub ListadoDeEmpleadosDeUnaCategoríaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeEmpleadosDeUnaCategoríaToolStripMenuItem.Click
        frmListadoCategoria.Show()
    End Sub

    Private Sub ListadoDeEmpleadosConSueldoMayorAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeEmpleadosConSueldoMayorAToolStripMenuItem.Click
        frmConSueldoMayorA.Show()
    End Sub

    Private Sub ConsultaDeDatosDeUnEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeDatosDeUnEmpleadoToolStripMenuItem.Click
        frmConsultaDatos.Show()
    End Sub

    Private Sub BúsquedaDeUnEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BúsquedaDeUnEmpleadoToolStripMenuItem.Click
        frmBusqueda.Show()
    End Sub
End Class
