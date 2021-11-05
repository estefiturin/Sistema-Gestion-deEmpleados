<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConSueldoMayorA
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
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblSueldo = New System.Windows.Forms.Label()
        Me.cmdListar = New System.Windows.Forms.Button()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(83, 35)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Importe:"
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvEmpleados.Location = New System.Drawing.Point(35, 71)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.Size = New System.Drawing.Size(444, 150)
        Me.dgvEmpleados.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Categoría"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Sueldo"
        Me.Column4.Name = "Column4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Importe total de sueldos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad de Empleados:"
        '
        'lblCantidad
        '
        Me.lblCantidad.BackColor = System.Drawing.Color.LightGray
        Me.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCantidad.Location = New System.Drawing.Point(173, 275)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(73, 22)
        Me.lblCantidad.TabIndex = 9
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSueldo
        '
        Me.lblSueldo.BackColor = System.Drawing.Color.LightGray
        Me.lblSueldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSueldo.Location = New System.Drawing.Point(173, 240)
        Me.lblSueldo.Name = "lblSueldo"
        Me.lblSueldo.Size = New System.Drawing.Size(73, 22)
        Me.lblSueldo.TabIndex = 10
        Me.lblSueldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdListar
        '
        Me.cmdListar.Location = New System.Drawing.Point(404, 257)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(75, 23)
        Me.cmdListar.TabIndex = 11
        Me.cmdListar.Text = "Listar"
        Me.cmdListar.UseVisualStyleBackColor = True
        '
        'frmConSueldoMayorA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 314)
        Me.Controls.Add(Me.cmdListar)
        Me.Controls.Add(Me.lblSueldo)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvEmpleados)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtImporte)
        Me.Name = "frmConSueldoMayorA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado general de empleados con sueldo mayor a..."
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtImporte As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblSueldo As Label
    Friend WithEvents cmdListar As Button
End Class
