Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types
Public Class Sales_Entry
    Dim conn As New OracleConnection(conn_str)


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Sales_and_Invoice.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim emptyTextBoxes =
       From txt In Me.Controls.OfType(Of TextBox)()
       Where txt.Text.Length = 0
       Select txt.Name

        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following fields: {0}",
                    String.Join(",", emptyTextBoxes)))
        End If

        If Account_no.Text.Length > 12 Or Account_no.Text.Length < 12 Then
            MsgBox("Invalid Account Number")
            Return
        End If

        If Not IsNumeric(Total_Amount.Text) Then
            MsgBox("Invalid Total Amount")
            Return
        End If

        If Not (emptyTextBoxes.Any) Then

            Dim dr As OracleDataReader
            Dim ds As DataTable = New DataTable()
            Dim com As New OracleCommand
            conn.Open()
            com = conn.CreateCommand
            com.CommandText = "insert into invoice(cust_id,user_id,product_id,payment_type,quantity,total_amount,bank_account_name,back_account_number,date_recorded) values('" + ComboBox1.SelectedValue.ToString + "'," + Login.LoggedInUserId + ",'" + ComboBox2.SelectedValue.ToString + "','" + ComboBox3.SelectedItem + "'," + quantity.Text + "," + Total_Amount.Text + ",'" + Account_name.Text + "'," + Account_no.Text + ",'" + date_recorded.Text + "')"
            'MsgBox(com.CommandText)
            com.CommandType = CommandType.Text
            dr = com.ExecuteReader()
            MsgBox("Sales Details Inserted Successfully..")
            conn.Close()

            conn.Open()
            com = conn.CreateCommand
            com.CommandText = "update product 
                       set unit_in_stock = unit_in_stock - '" + quantity.Value.ToString + "'" +
                       "where Product_id = '" + ComboBox2.SelectedValue.ToString + "'"
            'MsgBox(com.CommandText)
            com.CommandType = CommandType.Text
            dr = com.ExecuteReader()

            conn.Close()

            Sales_and_Invoice.Show()
            conn.Open()
            com = conn.CreateCommand
            com.CommandText = "SELECT        INVUSER.INVOICE.INVOICE_ID, INVUSER.INVOICE.CUST_ID, INVUSER.INVOICE.USER_ID, INVUSER.INVOICE.PRODUCT_ID, INVUSER.INVOICE.PAYMENT_TYPE, INVUSER.INVOICE.QUANTITY, 
                                                        INVUSER.INVOICE.TOTAL_AMOUNT, INVUSER.INVOICE.BANK_ACCOUNT_NAME, INVUSER.INVOICE.BACK_ACCOUNT_NUMBER, INVUSER.INVOICE.DATE_RECORDED, INVUSER.CUSTOMER.CUST_NAME, 
                                                        INVUSER.CUSTOMER.CONTACT, INVUSER.PRODUCT.PRODUCT_CODE, INVUSER.PRODUCT.PRODUCT_NAME, INVUSER.PRODUCT.CATEGORY, INVUSER.PRODUCT.UNIT_PRICE
                            FROM            INVUSER.INVOICE INNER JOIN
                                                        INVUSER.CUSTOMER ON INVUSER.CUSTOMER.CUST_ID = INVUSER.INVOICE.CUST_ID INNER JOIN
                                                        INVUSER.PRODUCT ON INVUSER.PRODUCT.PRODUCT_ID = INVUSER.INVOICE.PRODUCT_ID INNER JOIN
                                                        INVUSER.USERS ON INVUSER.USERS.USER_ID = INVUSER.INVOICE.USER_ID"
            com.CommandType = CommandType.Text
            dr = com.ExecuteReader()
            ds.Load(dr)
            Sales_and_Invoice.DataGridView1.DataSource = ds

            Me.Close()

        End If
    End Sub

    Private Sub Sales_Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim com As New OracleCommand
        Dim dr As OracleDataReader
        Dim ds1 As DataTable = New DataTable()
        conn.Open()
        com = conn.CreateCommand
        com.CommandText = "select -1 as cust_id,'Select' as cust_name from customer UNION select distinct cust_id,cust_name from customer"
        com.CommandType = CommandType.Text
        dr = com.ExecuteReader()
        ds1.Load(dr)
        conn.Close()

        Dim com2 As New OracleCommand
        Dim dr2 As OracleDataReader
        Dim ds2 As DataTable = New DataTable()
        conn.Open()
        com2 = conn.CreateCommand
        com2.CommandText = "select -1 as product_id,'Select' as product_name from product UNION select distinct product_id,product_name from product"
        com2.CommandType = CommandType.Text
        dr2 = com2.ExecuteReader()
        ds2.Load(dr2)
        conn.Close()

        If ds1.Rows.Count > 0 Then
            Me.ComboBox1.DataSource = ds1
            Me.ComboBox1.DisplayMember = "cust_name"
            Me.ComboBox1.ValueMember = "cust_id"
        Else
            MsgBox("No customer data found. Contact administrator!", MsgBoxStyle.Exclamation)
        End If

        If ds2.Rows.Count > 0 Then
            Me.ComboBox2.DataSource = ds2
            Me.ComboBox2.DisplayMember = "product_name"
            Me.ComboBox2.ValueMember = "product_id"
        Else
            MsgBox("No product data found. Contact administrator!", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class