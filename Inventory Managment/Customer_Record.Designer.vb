<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Record
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.REORDERLEVELDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATEGORYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNITINSTOCKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNITNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UNITPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CustomerDataSet = New Inventory_Managment.CustomerDataSet()
        Me.CustomerDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUSTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMERTableAdapter = New Inventory_Managment.CustomerDataSetTableAdapters.CUSTOMERTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(259, 71)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(146, 20)
        Me.TextBox3.TabIndex = 31
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(259, 112)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 20)
        Me.TextBox1.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(41, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 21)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Search by Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 21)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Search by Name"
        '
        'REORDERLEVELDataGridViewTextBoxColumn
        '
        Me.REORDERLEVELDataGridViewTextBoxColumn.DataPropertyName = "REORDER_LEVEL"
        Me.REORDERLEVELDataGridViewTextBoxColumn.HeaderText = "REORDER_LEVEL"
        Me.REORDERLEVELDataGridViewTextBoxColumn.Name = "REORDERLEVELDataGridViewTextBoxColumn"
        '
        'CATEGORYDataGridViewTextBoxColumn
        '
        Me.CATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY"
        Me.CATEGORYDataGridViewTextBoxColumn.HeaderText = "CATEGORY"
        Me.CATEGORYDataGridViewTextBoxColumn.Name = "CATEGORYDataGridViewTextBoxColumn"
        '
        'UNITINSTOCKDataGridViewTextBoxColumn
        '
        Me.UNITINSTOCKDataGridViewTextBoxColumn.DataPropertyName = "UNIT_IN_STOCK"
        Me.UNITINSTOCKDataGridViewTextBoxColumn.HeaderText = "UNIT_IN_STOCK"
        Me.UNITINSTOCKDataGridViewTextBoxColumn.Name = "UNITINSTOCKDataGridViewTextBoxColumn"
        '
        'UNITNAMEDataGridViewTextBoxColumn
        '
        Me.UNITNAMEDataGridViewTextBoxColumn.DataPropertyName = "UNIT_NAME"
        Me.UNITNAMEDataGridViewTextBoxColumn.HeaderText = "UNIT_NAME"
        Me.UNITNAMEDataGridViewTextBoxColumn.Name = "UNITNAMEDataGridViewTextBoxColumn"
        '
        'PRODUCTNAMEDataGridViewTextBoxColumn
        '
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_NAME"
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.HeaderText = "PRODUCT_NAME"
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.Name = "PRODUCTNAMEDataGridViewTextBoxColumn"
        '
        'PRODUCTCODEDataGridViewTextBoxColumn
        '
        Me.PRODUCTCODEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_CODE"
        Me.PRODUCTCODEDataGridViewTextBoxColumn.HeaderText = "PRODUCT_CODE"
        Me.PRODUCTCODEDataGridViewTextBoxColumn.Name = "PRODUCTCODEDataGridViewTextBoxColumn"
        '
        'PRODUCTIDDataGridViewTextBoxColumn
        '
        Me.PRODUCTIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_ID"
        Me.PRODUCTIDDataGridViewTextBoxColumn.HeaderText = "PRODUCT_ID"
        Me.PRODUCTIDDataGridViewTextBoxColumn.Name = "PRODUCTIDDataGridViewTextBoxColumn"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(45, 370)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 28)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!)
        Me.Button2.Location = New System.Drawing.Point(166, 370)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 28)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!)
        Me.Button1.Location = New System.Drawing.Point(372, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 28)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UNITPRICEDataGridViewTextBoxColumn
        '
        Me.UNITPRICEDataGridViewTextBoxColumn.DataPropertyName = "UNIT_PRICE"
        Me.UNITPRICEDataGridViewTextBoxColumn.HeaderText = "UNIT_PRICE"
        Me.UNITPRICEDataGridViewTextBoxColumn.Name = "UNITPRICEDataGridViewTextBoxColumn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 38)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Search Customer Record"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CUSTIDDataGridViewTextBoxColumn, Me.CUSTNAMEDataGridViewTextBoxColumn, Me.CONTACTDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(24, 164)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(737, 189)
        Me.DataGridView1.TabIndex = 36
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!)
        Me.Button3.Location = New System.Drawing.Point(261, 370)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 28)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CustomerDataSet
        '
        Me.CustomerDataSet.DataSetName = "CustomerDataSet"
        Me.CustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerDataSetBindingSource
        '
        Me.CustomerDataSetBindingSource.DataMember = "CUSTOMER"
        Me.CustomerDataSetBindingSource.DataSource = Me.CustomerDataSet
        '
        'CUSTIDDataGridViewTextBoxColumn
        '
        Me.CUSTIDDataGridViewTextBoxColumn.DataPropertyName = "CUST_ID"
        Me.CUSTIDDataGridViewTextBoxColumn.HeaderText = "CUST_ID"
        Me.CUSTIDDataGridViewTextBoxColumn.Name = "CUSTIDDataGridViewTextBoxColumn"
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
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'Customer_Record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 428)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Customer_Record"
        Me.Text = "Customer Record"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents REORDERLEVELDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CATEGORYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNITINSTOCKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNITNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents UNITPRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents CUSTIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONTACTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerDataSetBindingSource As BindingSource
    Friend WithEvents CustomerDataSet As CustomerDataSet
    Friend WithEvents CUSTOMERTableAdapter As CustomerDataSetTableAdapters.CUSTOMERTableAdapter
End Class
