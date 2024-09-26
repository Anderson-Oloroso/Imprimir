<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoCuenta
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
        Me.dgvCuentas = New System.Windows.Forms.DataGridView()
        Me.dgvcCodTipoCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnImprimir = New System.Windows.Forms.Button()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCuentas
        '
        Me.dgvCuentas.AllowUserToAddRows = False
        Me.dgvCuentas.AllowUserToDeleteRows = False
        Me.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcCodTipoCuenta, Me.dgvcNombre, Me.dgvcDescripcion})
        Me.dgvCuentas.Location = New System.Drawing.Point(12, 12)
        Me.dgvCuentas.Name = "dgvCuentas"
        Me.dgvCuentas.ReadOnly = True
        Me.dgvCuentas.Size = New System.Drawing.Size(783, 340)
        Me.dgvCuentas.TabIndex = 0
        '
        'dgvcCodTipoCuenta
        '
        Me.dgvcCodTipoCuenta.HeaderText = "Cod_Tipo de Cuenta"
        Me.dgvcCodTipoCuenta.Name = "dgvcCodTipoCuenta"
        Me.dgvcCodTipoCuenta.ReadOnly = True
        Me.dgvcCodTipoCuenta.Width = 90
        '
        'dgvcNombre
        '
        Me.dgvcNombre.HeaderText = "Nombre"
        Me.dgvcNombre.Name = "dgvcNombre"
        Me.dgvcNombre.ReadOnly = True
        Me.dgvcNombre.Width = 250
        '
        'dgvcDescripcion
        '
        Me.dgvcDescripcion.HeaderText = "Descripción"
        Me.dgvcDescripcion.Name = "dgvcDescripcion"
        Me.dgvcDescripcion.ReadOnly = True
        Me.dgvcDescripcion.Width = 400
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(359, 364)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmTipoCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 399)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.dgvCuentas)
        Me.Name = "frmTipoCuenta"
        Me.Text = "Cuenta"
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCuentas As DataGridView
    Friend WithEvents dgvcCodTipoCuenta As DataGridViewTextBoxColumn
    Friend WithEvents dgvcNombre As DataGridViewTextBoxColumn
    Friend WithEvents dgvcDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents btnImprimir As Button
End Class
