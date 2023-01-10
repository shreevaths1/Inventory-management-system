<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Product_Record
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ProductDataSet = New Inventory_Managment.ProductDataSet()
        Me.ProductDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNITNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNITINSTOCKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNITPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATEGORYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REORDERLEVELDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUPPLIERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTTableAdapter = New Inventory_Managment.ProductDataSetTableAdapters.PRODUCTTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(206, 459)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 28)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!)
        Me.Button3.Location = New System.Drawing.Point(392, 459)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 28)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!)
        Me.Button2.Location = New System.Drawing.Point(556, 459)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 28)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!)
        Me.Button1.Location = New System.Drawing.Point(682, 459)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 28)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODUCTIDDataGridViewTextBoxColumn, Me.PRODUCTCODEDataGridViewTextBoxColumn, Me.PRODUCTNAMEDataGridViewTextBoxColumn, Me.UNITNAMEDataGridViewTextBoxColumn, Me.UNITINSTOCKDataGridViewTextBoxColumn, Me.UNITPRICEDataGridViewTextBoxColumn, Me.CATEGORYDataGridViewTextBoxColumn, Me.REORDERLEVELDataGridViewTextBoxColumn, Me.USERIDDataGridViewTextBoxColumn, Me.SUPPLIERIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(48, 232)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(723, 208)
        Me.DataGridView1.TabIndex = 19
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(268, 106)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(146, 20)
        Me.TextBox3.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(268, 145)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(146, 20)
        Me.TextBox2.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(268, 185)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 20)
        Me.TextBox1.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 21)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Search by Category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(50, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Search by Product ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Search by Product Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 38)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Search Product Record"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(48, 459)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 28)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "Add"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ProductDataSet
        '
        Me.ProductDataSet.DataSetName = "ProductDataSet"
        Me.ProductDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductDataSetBindingSource
        '
        Me.ProductDataSetBindingSource.DataMember = "PRODUCT"
        Me.ProductDataSetBindingSource.DataSource = Me.ProductDataSet
        '
        'PRODUCTIDDataGridViewTextBoxColumn
        '
        Me.PRODUCTIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_ID"
        Me.PRODUCTIDDataGridViewTextBoxColumn.HeaderText = "PRODUCT_ID"
        Me.PRODUCTIDDataGridViewTextBoxColumn.Name = "PRODUCTIDDataGridViewTextBoxColumn"
        '
        'PRODUCTCODEDataGridViewTextBoxColumn
        '
        Me.PRODUCTCODEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_CODE"
        Me.PRODUCTCODEDataGridViewTextBoxColumn.HeaderText = "PRODUCT_CODE"
        Me.PRODUCTCODEDataGridViewTextBoxColumn.Name = "PRODUCTCODEDataGridViewTextBoxColumn"
        '
        'PRODUCTNAMEDataGridViewTextBoxColumn
        '
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_NAME"
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.HeaderText = "PRODUCT_NAME"
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.Name = "PRODUCTNAMEDataGridViewTextBoxColumn"
        '
        'UNITNAMEDataGridViewTextBoxColumn
        '
        Me.UNITNAMEDataGridViewTextBoxColumn.DataPropertyName = "UNIT_NAME"
        Me.UNITNAMEDataGridViewTextBoxColumn.HeaderText = "UNIT_NAME"
        Me.UNITNAMEDataGridViewTextBoxColumn.Name = "UNITNAMEDataGridViewTextBoxColumn"
        '
        'UNITINSTOCKDataGridViewTextBoxColumn
        '
        Me.UNITINSTOCKDataGridViewTextBoxColumn.DataPropertyName = "UNIT_IN_STOCK"
        Me.UNITINSTOCKDataGridViewTextBoxColumn.HeaderText = "UNIT_IN_STOCK"
        Me.UNITINSTOCKDataGridViewTextBoxColumn.Name = "UNITINSTOCKDataGridViewTextBoxColumn"
        '
        'UNITPRICEDataGridViewTextBoxColumn
        '
        Me.UNITPRICEDataGridViewTextBoxColumn.DataPropertyName = "UNIT_PRICE"
        Me.UNITPRICEDataGridViewTextBoxColumn.HeaderText = "UNIT_PRICE"
        Me.UNITPRICEDataGridViewTextBoxColumn.Name = "UNITPRICEDataGridViewTextBoxColumn"
        '
        'CATEGORYDataGridViewTextBoxColumn
        '
        Me.CATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY"
        Me.CATEGORYDataGridViewTextBoxColumn.HeaderText = "CATEGORY"
        Me.CATEGORYDataGridViewTextBoxColumn.Name = "CATEGORYDataGridViewTextBoxColumn"
        '
        'REORDERLEVELDataGridViewTextBoxColumn
        '
        Me.REORDERLEVELDataGridViewTextBoxColumn.DataPropertyName = "REORDER_LEVEL"
        Me.REORDERLEVELDataGridViewTextBoxColumn.HeaderText = "REORDER_LEVEL"
        Me.REORDERLEVELDataGridViewTextBoxColumn.Name = "REORDERLEVELDataGridViewTextBoxColumn"
        '
        'USERIDDataGridViewTextBoxColumn
        '
        Me.USERIDDataGridViewTextBoxColumn.DataPropertyName = "USER_ID"
        Me.USERIDDataGridViewTextBoxColumn.HeaderText = "USER_ID"
        Me.USERIDDataGridViewTextBoxColumn.Name = "USERIDDataGridViewTextBoxColumn"
        '
        'SUPPLIERIDDataGridViewTextBoxColumn
        '
        Me.SUPPLIERIDDataGridViewTextBoxColumn.DataPropertyName = "SUPPLIER_ID"
        Me.SUPPLIERIDDataGridViewTextBoxColumn.HeaderText = "SUPPLIER_ID"
        Me.SUPPLIERIDDataGridViewTextBoxColumn.Name = "SUPPLIERIDDataGridViewTextBoxColumn"
        '
        'PRODUCTTableAdapter
        '
        Me.PRODUCTTableAdapter.ClearBeforeFill = True
        '
        'Product_Record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 499)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Product_Record"
        Me.Text = "Product Record"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents PRODUCTIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNITNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNITINSTOCKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNITPRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CATEGORYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REORDERLEVELDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUPPLIERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDataSetBindingSource As BindingSource
    Friend WithEvents ProductDataSet As ProductDataSet
    Friend WithEvents PRODUCTTableAdapter As ProductDataSetTableAdapters.PRODUCTTableAdapter
End Class
