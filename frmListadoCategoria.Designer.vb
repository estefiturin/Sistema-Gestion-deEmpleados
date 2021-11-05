<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoCategoria
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.dgvCategoria = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblEmpleados = New System.Windows.Forms.Label()
        Me.lblSueldos = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdListar = New System.Windows.Forms.Button()
        CType(Me.dgvCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresar categoría:"
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(258, 33)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(100, 20)
        Me.txtCategoria.TabIndex = 1
        '
        'dgvCategoria
        '
        Me.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvCategoria.Location = New System.Drawing.Point(33, 73)
        Me.dgvCategoria.Name = "dgvCategoria"
        Me.dgvCategoria.Size = New System.Drawing.Size(440, 150)
        Me.dgvCategoria.TabIndex = 2
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
        'lblEmpleados
        '
        Me.lblEmpleados.BackColor = System.Drawing.Color.LightGray
        Me.lblEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmpleados.Location = New System.Drawing.Point(696, 137)
        Me.lblEmpleados.Name = "lblEmpleados"
        Me.lblEmpleados.Size = New System.Drawing.Size(73, 22)
        Me.lblEmpleados.TabIndex = 7
        Me.lblEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSueldos
        '
        Me.lblSueldos.BackColor = System.Drawing.Color.LightGray
        Me.lblSueldos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSueldos.Location = New System.Drawing.Point(696, 89)
        Me.lblSueldos.Name = "lblSueldos"
        Me.lblSueldos.Size = New System.Drawing.Size(73, 22)
        Me.lblSueldos.TabIndex = 8
        Me.lblSueldos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvCategoria)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCategoria)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 243)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(564, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Importe total de sueldos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(565, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cantidad de empleados:"
        '
        'cmdListar
        '
        Me.cmdListar.Location = New System.Drawing.Point(694, 182)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(75, 23)
        Me.cmdListar.TabIndex = 12
        Me.cmdListar.Text = "Listar"
        Me.cmdListar.UseVisualStyleBackColor = True
        '
        'frmListadoCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 273)
        Me.Controls.Add(Me.cmdListar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblSueldos)
        Me.Controls.Add(Me.lblEmpleados)
        Me.Name = "frmListadoCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de empleados de una categoría"
        CType(Me.dgvCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents dgvCategoria As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents lblEmpleados As Label
    Friend WithEvents lblSueldos As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdListar As Button
End Class
