<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSistemas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarNuevoEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoGeneralDeEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeEmpleadosDeUnaCategoríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeEmpleadosConSueldoMayorAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeDatosDeUnEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BúsquedaDeUnEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.EmpleadoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(657, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.EmpleadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarNuevoEmpleadoToolStripMenuItem, Me.ListadoGeneralDeEmpleadoToolStripMenuItem, Me.ListadoDeEmpleadosDeUnaCategoríaToolStripMenuItem, Me.ListadoDeEmpleadosConSueldoMayorAToolStripMenuItem, Me.ConsultaDeDatosDeUnEmpleadoToolStripMenuItem, Me.BúsquedaDeUnEmpleadoToolStripMenuItem})
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'AgregarNuevoEmpleadoToolStripMenuItem
        '
        Me.AgregarNuevoEmpleadoToolStripMenuItem.Name = "AgregarNuevoEmpleadoToolStripMenuItem"
        Me.AgregarNuevoEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(305, 22)
        Me.AgregarNuevoEmpleadoToolStripMenuItem.Text = "Agregar nuevo empleado..."
        '
        'ListadoGeneralDeEmpleadoToolStripMenuItem
        '
        Me.ListadoGeneralDeEmpleadoToolStripMenuItem.Name = "ListadoGeneralDeEmpleadoToolStripMenuItem"
        Me.ListadoGeneralDeEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(305, 22)
        Me.ListadoGeneralDeEmpleadoToolStripMenuItem.Text = "Listado general de empleado..."
        '
        'ListadoDeEmpleadosDeUnaCategoríaToolStripMenuItem
        '
        Me.ListadoDeEmpleadosDeUnaCategoríaToolStripMenuItem.Name = "ListadoDeEmpleadosDeUnaCategoríaToolStripMenuItem"
        Me.ListadoDeEmpleadosDeUnaCategoríaToolStripMenuItem.Size = New System.Drawing.Size(305, 22)
        Me.ListadoDeEmpleadosDeUnaCategoríaToolStripMenuItem.Text = "Listado de empleados de una categoría…"
        '
        'ListadoDeEmpleadosConSueldoMayorAToolStripMenuItem
        '
        Me.ListadoDeEmpleadosConSueldoMayorAToolStripMenuItem.Name = "ListadoDeEmpleadosConSueldoMayorAToolStripMenuItem"
        Me.ListadoDeEmpleadosConSueldoMayorAToolStripMenuItem.Size = New System.Drawing.Size(305, 22)
        Me.ListadoDeEmpleadosConSueldoMayorAToolStripMenuItem.Text = "Listado de empleados con sueldo mayor a…"
        '
        'ConsultaDeDatosDeUnEmpleadoToolStripMenuItem
        '
        Me.ConsultaDeDatosDeUnEmpleadoToolStripMenuItem.Name = "ConsultaDeDatosDeUnEmpleadoToolStripMenuItem"
        Me.ConsultaDeDatosDeUnEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(305, 22)
        Me.ConsultaDeDatosDeUnEmpleadoToolStripMenuItem.Text = "Consulta de datos de un empleado…."
        '
        'BúsquedaDeUnEmpleadoToolStripMenuItem
        '
        Me.BúsquedaDeUnEmpleadoToolStripMenuItem.Name = "BúsquedaDeUnEmpleadoToolStripMenuItem"
        Me.BúsquedaDeUnEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(305, 22)
        Me.BúsquedaDeUnEmpleadoToolStripMenuItem.Text = "Búsqueda de un empleado…"
        '
        'frmSistemas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(657, 340)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSistemas"
        Me.Text = "Sistema de Gestión de Empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarNuevoEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoGeneralDeEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeEmpleadosDeUnaCategoríaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeEmpleadosConSueldoMayorAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeDatosDeUnEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BúsquedaDeUnEmpleadoToolStripMenuItem As ToolStripMenuItem
End Class
