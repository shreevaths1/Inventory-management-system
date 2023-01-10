<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class View_Suppliers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SUPPLIERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUPPLIERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUPPLERCONTACTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUPPLIERADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUPPLIEREMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New Inventory_Managment.SupplierDataSet()
        Me.SUPPLIERTableAdapter = New Inventory_Managment.SupplierDataSetTableAdapters.SUPPLIERTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 38)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Search Supplier Record"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(230, 63)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(146, 20)
        Me.TextBox3.TabIndex = 35
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(230, 104)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 20)
        Me.TextBox1.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 21)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Search by Supplier ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 21)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Search by Name"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SUPPLIERIDDataGridViewTextBoxColumn, Me.SUPPLIERNAMEDataGridViewTextBoxColumn, Me.SUPPLERCONTACTDataGridViewTextBoxColumn, Me.SUPPLIERADDRESSDataGridViewTextBoxColumn, Me.SUPPLIEREMAILDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SupplierDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 145)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(546, 150)
        Me.DataGridView1.TabIndex = 36
        '
        'SUPPLIERIDDataGridViewTextBoxColumn
        '
        Me.SUPPLIERIDDataGridViewTextBoxColumn.DataPropertyName = "SUPPLIER_ID"
        Me.SUPPLIERIDDataGridViewTextBoxColumn.HeaderText = "SUPPLIER_ID"
        Me.SUPPLIERIDDataGridViewTextBoxColumn.Name = "SUPPLIERIDDataGridViewTextBoxColumn"
        '
        'SUPPLIERNAMEDataGridViewTextBoxColumn
        '
        Me.SUPPLIERNAMEDataGridViewTextBoxColumn.DataPropertyName = "SUPPLIER_NAME"
        Me.SUPPLIERNAMEDataGridViewTextBoxColumn.HeaderText = "SUPPLIER_NAME"
        Me.SUPPLIERNAMEDataGridViewTextBoxColumn.Name = "SUPPLIERNAMEDataGridViewTextBoxColumn"
        '
        'SUPPLERCONTACTDataGridViewTextBoxColumn
        '
        Me.SUPPLERCONTACTDataGridViewTextBoxColumn.DataPropertyName = "SUPPLER_CONTACT"
        Me.SUPPLERCONTACTDataGridViewTextBoxColumn.HeaderText = "SUPPLER_CONTACT"
        Me.SUPPLERCONTACTDataGridViewTextBoxColumn.Name = "SUPPLERCONTACTDataGridViewTextBoxColumn"
        '
        'SUPPLIERADDRESSDataGridViewTextBoxColumn
        '
        Me.SUPPLIERADDRESSDataGridViewTextBoxColumn.DataPropertyName = "SUPPLIER_ADDRESS"
        Me.SUPPLIERADDRESSDataGridViewTextBoxColumn.HeaderText = "SUPPLIER_ADDRESS"
        Me.SUPPLIERADDRESSDataGridViewTextBoxColumn.Name = "SUPPLIERADDRESSDataGridViewTextBoxColumn"
        '
        'SUPPLIEREMAILDataGridViewTextBoxColumn
        '
        Me.SUPPLIEREMAILDataGridViewTextBoxColumn.DataPropertyName = "SUPPLIER_EMAIL"
        Me.SUPPLIEREMAILDataGridViewTextBoxColumn.HeaderText = "SUPPLIER_EMAIL"
        Me.SUPPLIEREMAILDataGridViewTextBoxColumn.Name = "SUPPLIEREMAILDataGridViewTextBoxColumn"
        '
        'SupplierDataSetBindingSource
        '
        Me.SupplierDataSetBindingSource.DataMember = "SUPPLIER"
        Me.SupplierDataSetBindingSource.DataSource = Me.SupplierDataSet
        '
        'SupplierDataSet
        '
        Me.SupplierDataSet.DataSetName = "SupplierDataSet"
        Me.SupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SUPPLIERTableAdapter
        '
        Me.SUPPLIERTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!)
        Me.Button3.Location = New System.Drawing.Point(202, 320)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 28)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(12, 320)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 28)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!)
        Me.Button2.Location = New System.Drawing.Point(107, 320)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 28)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!)
        Me.Button1.Location = New System.Drawing.Point(392, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 28)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!)
        Me.Button5.Location = New System.Drawing.Point(297, 320)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 28)
        Me.Button5.TabIndex = 42
        Me.Button5.Text = "Update"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'View_Suppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "View_Suppliers"
        Me.Text = "View_Suppliers"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SUPPLIERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUPPLIERNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUPPLERCONTACTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUPPLIERADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUPPLIEREMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierDataSetBindingSource As BindingSource
    Friend WithEvents SupplierDataSet As SupplierDataSet
    Friend WithEvents SUPPLIERTableAdapter As SupplierDataSetTableAdapters.SUPPLIERTableAdapter
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
End Class
