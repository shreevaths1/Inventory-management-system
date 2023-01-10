<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase_History
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PurchasedDataSet = New Inventory_Managment.PurchasedDataSet()
        Me.PurchasedDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDERDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECIEVEDDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PURCHASE_ORDERTableAdapter = New Inventory_Managment.PurchasedDataSetTableAdapters.PURCHASE_ORDERTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasedDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 38)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Search Purchase History"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(240, 74)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(146, 20)
        Me.TextBox3.TabIndex = 35
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(240, 115)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 20)
        Me.TextBox1.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(22, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 21)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Search by Order Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 21)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Search by Order ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ORDERIDDataGridViewTextBoxColumn, Me.PRODUCTIDDataGridViewTextBoxColumn, Me.USERIDDataGridViewTextBoxColumn, Me.QUANTITYDataGridViewTextBoxColumn, Me.SUBTOTALDataGridViewTextBoxColumn, Me.ORDERDATEDataGridViewTextBoxColumn, Me.RECIEVEDDATEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PurchasedDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 169)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(746, 150)
        Me.DataGridView1.TabIndex = 36
        '
        'PurchasedDataSet
        '
        Me.PurchasedDataSet.DataSetName = "PurchasedDataSet"
        Me.PurchasedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PurchasedDataSetBindingSource
        '
        Me.PurchasedDataSetBindingSource.DataMember = "PURCHASE_ORDER"
        Me.PurchasedDataSetBindingSource.DataSource = Me.PurchasedDataSet
        '
        'ORDERIDDataGridViewTextBoxColumn
        '
        Me.ORDERIDDataGridViewTextBoxColumn.DataPropertyName = "ORDER_ID"
        Me.ORDERIDDataGridViewTextBoxColumn.HeaderText = "ORDER_ID"
        Me.ORDERIDDataGridViewTextBoxColumn.Name = "ORDERIDDataGridViewTextBoxColumn"
        '
        'PRODUCTIDDataGridViewTextBoxColumn
        '
        Me.PRODUCTIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_ID"
        Me.PRODUCTIDDataGridViewTextBoxColumn.HeaderText = "PRODUCT_ID"
        Me.PRODUCTIDDataGridViewTextBoxColumn.Name = "PRODUCTIDDataGridViewTextBoxColumn"
        '
        'USERIDDataGridViewTextBoxColumn
        '
        Me.USERIDDataGridViewTextBoxColumn.DataPropertyName = "USER_ID"
        Me.USERIDDataGridViewTextBoxColumn.HeaderText = "USER_ID"
        Me.USERIDDataGridViewTextBoxColumn.Name = "USERIDDataGridViewTextBoxColumn"
        '
        'QUANTITYDataGridViewTextBoxColumn
        '
        Me.QUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.Name = "QUANTITYDataGridViewTextBoxColumn"
        '
        'SUBTOTALDataGridViewTextBoxColumn
        '
        Me.SUBTOTALDataGridViewTextBoxColumn.DataPropertyName = "SUB_TOTAL"
        Me.SUBTOTALDataGridViewTextBoxColumn.HeaderText = "SUB_TOTAL"
        Me.SUBTOTALDataGridViewTextBoxColumn.Name = "SUBTOTALDataGridViewTextBoxColumn"
        '
        'ORDERDATEDataGridViewTextBoxColumn
        '
        Me.ORDERDATEDataGridViewTextBoxColumn.DataPropertyName = "ORDER_DATE"
        Me.ORDERDATEDataGridViewTextBoxColumn.HeaderText = "ORDER_DATE"
        Me.ORDERDATEDataGridViewTextBoxColumn.Name = "ORDERDATEDataGridViewTextBoxColumn"
        '
        'RECIEVEDDATEDataGridViewTextBoxColumn
        '
        Me.RECIEVEDDATEDataGridViewTextBoxColumn.DataPropertyName = "RECIEVED_DATE"
        Me.RECIEVEDDATEDataGridViewTextBoxColumn.HeaderText = "RECIEVED_DATE"
        Me.RECIEVEDDATEDataGridViewTextBoxColumn.Name = "RECIEVEDDATEDataGridViewTextBoxColumn"
        '
        'PURCHASE_ORDERTableAdapter
        '
        Me.PURCHASE_ORDERTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(436, 74)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 28)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(16, 341)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 28)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(111, 341)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 28)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Purchase_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 376)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Purchase_History"
        Me.Text = "Purchase_History"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasedDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ORDERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QUANTITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ORDERDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RECIEVEDDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchasedDataSetBindingSource As BindingSource
    Friend WithEvents PurchasedDataSet As PurchasedDataSet
    Friend WithEvents PURCHASE_ORDERTableAdapter As PurchasedDataSetTableAdapters.PURCHASE_ORDERTableAdapter
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
