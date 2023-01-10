<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales_and_Invoice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.InvoiceDataSet = New Inventory_Managment.InvoiceDataSet()
        Me.InvoiceDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVOICEIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAYMENTTYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALAMOUNTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BANKACCOUNTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BACKACCOUNTNUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATERECORDEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATEGORYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNITPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTable1TableAdapter = New Inventory_Managment.InvoiceDataSetTableAdapters.DataTable1TableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales And Invoice"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.INVOICEIDDataGridViewTextBoxColumn, Me.CUSTIDDataGridViewTextBoxColumn, Me.USERIDDataGridViewTextBoxColumn, Me.PRODUCTIDDataGridViewTextBoxColumn, Me.PAYMENTTYPEDataGridViewTextBoxColumn, Me.QUANTITYDataGridViewTextBoxColumn, Me.TOTALAMOUNTDataGridViewTextBoxColumn, Me.BANKACCOUNTNAMEDataGridViewTextBoxColumn, Me.BACKACCOUNTNUMBERDataGridViewTextBoxColumn, Me.DATERECORDEDDataGridViewTextBoxColumn, Me.CUSTNAMEDataGridViewTextBoxColumn, Me.CONTACTDataGridViewTextBoxColumn, Me.PRODUCTCODEDataGridViewTextBoxColumn, Me.PRODUCTNAMEDataGridViewTextBoxColumn, Me.CATEGORYDataGridViewTextBoxColumn, Me.UNITPRICEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InvoiceDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 223)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(810, 213)
        Me.DataGridView1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(209, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(188, 26)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Search By Invoice Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Search By Customer Id"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(209, 107)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(188, 26)
        Me.TextBox2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Search By Product Id"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(209, 143)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(188, 26)
        Me.TextBox3.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(423, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Search By date"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(634, 75)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(188, 26)
        Me.TextBox4.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(423, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Search By Customer Name"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(634, 107)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(188, 26)
        Me.TextBox5.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(423, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Search By Category"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(634, 143)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(188, 26)
        Me.TextBox6.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(423, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Search By Product Name"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(634, 175)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(188, 26)
        Me.TextBox7.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(34, 466)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 42)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(122, 466)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 42)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'InvoiceDataSet
        '
        Me.InvoiceDataSet.DataSetName = "InvoiceDataSet"
        Me.InvoiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvoiceDataSetBindingSource
        '
        Me.InvoiceDataSetBindingSource.DataMember = "DataTable1"
        Me.InvoiceDataSetBindingSource.DataSource = Me.InvoiceDataSet
        '
        'INVOICEIDDataGridViewTextBoxColumn
        '
        Me.INVOICEIDDataGridViewTextBoxColumn.DataPropertyName = "INVOICE_ID"
        Me.INVOICEIDDataGridViewTextBoxColumn.HeaderText = "INVOICE_ID"
        Me.INVOICEIDDataGridViewTextBoxColumn.Name = "INVOICEIDDataGridViewTextBoxColumn"
        '
        'CUSTIDDataGridViewTextBoxColumn
        '
        Me.CUSTIDDataGridViewTextBoxColumn.DataPropertyName = "CUST_ID"
        Me.CUSTIDDataGridViewTextBoxColumn.HeaderText = "CUST_ID"
        Me.CUSTIDDataGridViewTextBoxColumn.Name = "CUSTIDDataGridViewTextBoxColumn"
        '
        'USERIDDataGridViewTextBoxColumn
        '
        Me.USERIDDataGridViewTextBoxColumn.DataPropertyName = "USER_ID"
        Me.USERIDDataGridViewTextBoxColumn.HeaderText = "USER_ID"
        Me.USERIDDataGridViewTextBoxColumn.Name = "USERIDDataGridViewTextBoxColumn"
        '
        'PRODUCTIDDataGridViewTextBoxColumn
        '
        Me.PRODUCTIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_ID"
        Me.PRODUCTIDDataGridViewTextBoxColumn.HeaderText = "PRODUCT_ID"
        Me.PRODUCTIDDataGridViewTextBoxColumn.Name = "PRODUCTIDDataGridViewTextBoxColumn"
        '
        'PAYMENTTYPEDataGridViewTextBoxColumn
        '
        Me.PAYMENTTYPEDataGridViewTextBoxColumn.DataPropertyName = "PAYMENT_TYPE"
        Me.PAYMENTTYPEDataGridViewTextBoxColumn.HeaderText = "PAYMENT_TYPE"
        Me.PAYMENTTYPEDataGridViewTextBoxColumn.Name = "PAYMENTTYPEDataGridViewTextBoxColumn"
        '
        'QUANTITYDataGridViewTextBoxColumn
        '
        Me.QUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.Name = "QUANTITYDataGridViewTextBoxColumn"
        '
        'TOTALAMOUNTDataGridViewTextBoxColumn
        '
        Me.TOTALAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_AMOUNT"
        Me.TOTALAMOUNTDataGridViewTextBoxColumn.HeaderText = "TOTAL_AMOUNT"
        Me.TOTALAMOUNTDataGridViewTextBoxColumn.Name = "TOTALAMOUNTDataGridViewTextBoxColumn"
        '
        'BANKACCOUNTNAMEDataGridViewTextBoxColumn
        '
        Me.BANKACCOUNTNAMEDataGridViewTextBoxColumn.DataPropertyName = "BANK_ACCOUNT_NAME"
        Me.BANKACCOUNTNAMEDataGridViewTextBoxColumn.HeaderText = "BANK_ACCOUNT_NAME"
        Me.BANKACCOUNTNAMEDataGridViewTextBoxColumn.Name = "BANKACCOUNTNAMEDataGridViewTextBoxColumn"
        '
        'BACKACCOUNTNUMBERDataGridViewTextBoxColumn
        '
        Me.BACKACCOUNTNUMBERDataGridViewTextBoxColumn.DataPropertyName = "BACK_ACCOUNT_NUMBER"
        Me.BACKACCOUNTNUMBERDataGridViewTextBoxColumn.HeaderText = "BACK_ACCOUNT_NUMBER"
        Me.BACKACCOUNTNUMBERDataGridViewTextBoxColumn.Name = "BACKACCOUNTNUMBERDataGridViewTextBoxColumn"
        '
        'DATERECORDEDDataGridViewTextBoxColumn
        '
        Me.DATERECORDEDDataGridViewTextBoxColumn.DataPropertyName = "DATE_RECORDED"
        Me.DATERECORDEDDataGridViewTextBoxColumn.HeaderText = "DATE_RECORDED"
        Me.DATERECORDEDDataGridViewTextBoxColumn.Name = "DATERECORDEDDataGridViewTextBoxColumn"
        '
        'CUSTNAMEDataGridViewTextBoxColumn
        '
        Me.CUSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUST_NAME"
        Me.CUSTNAMEDataGridViewTextBoxColumn.HeaderText = "CUST_NAME"
        Me.CUSTNAMEDataGridViewTextBoxColumn.Name = "CUSTNAMEDataGridViewTextBoxColumn"
        '
        'CONTACTDataGridViewTextBoxColumn
        '
        Me.CONTACTDataGridViewTextBoxColumn.DataPropertyName = "CONTACT"
        Me.CONTACTDataGridViewTextBoxColumn.HeaderText = "CONTACT"
        Me.CONTACTDataGridViewTextBoxColumn.Name = "CONTACTDataGridViewTextBoxColumn"
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
        'CATEGORYDataGridViewTextBoxColumn
        '
        Me.CATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY"
        Me.CATEGORYDataGridViewTextBoxColumn.HeaderText = "CATEGORY"
        Me.CATEGORYDataGridViewTextBoxColumn.Name = "CATEGORYDataGridViewTextBoxColumn"
        '
        'UNITPRICEDataGridViewTextBoxColumn
        '
        Me.UNITPRICEDataGridViewTextBoxColumn.DataPropertyName = "UNIT_PRICE"
        Me.UNITPRICEDataGridViewTextBoxColumn.HeaderText = "UNIT_PRICE"
        Me.UNITPRICEDataGridViewTextBoxColumn.Name = "UNITPRICEDataGridViewTextBoxColumn"
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(34, 175)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 42)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Sales_and_Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 520)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Sales_and_Invoice"
        Me.Text = "Sales and Invoice"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents INVOICEIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSTIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PAYMENTTYPEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QUANTITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALAMOUNTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BANKACCOUNTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BACKACCOUNTNUMBERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATERECORDEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONTACTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CATEGORYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNITPRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InvoiceDataSetBindingSource As BindingSource
    Friend WithEvents InvoiceDataSet As InvoiceDataSet
    Friend WithEvents DataTable1TableAdapter As InvoiceDataSetTableAdapters.DataTable1TableAdapter
    Friend WithEvents Button3 As Button
End Class
