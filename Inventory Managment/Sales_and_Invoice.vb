Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types
Public Class Sales_and_Invoice
    Dim conn As New OracleConnection(conn_str)
    Dim com As New OracleCommand
    Private Sub Sales_and_Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InvoiceDataSet.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.InvoiceDataSet.DataTable1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Sales_Entry.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim dt As DataTable = New DataTable()

        Dim da As New OracleDataAdapter()
        conn.Open()
        com = conn.CreateCommand
        com.CommandText = "SELECT        INVUSER.INVOICE.INVOICE_ID, INVUSER.INVOICE.CUST_ID, INVUSER.INVOICE.USER_ID, INVUSER.INVOICE.PRODUCT_ID, INVUSER.INVOICE.PAYMENT_TYPE, INVUSER.INVOICE.QUANTITY, 
                                                     INVUSER.INVOICE.TOTAL_AMOUNT, INVUSER.INVOICE.BANK_ACCOUNT_NAME, INVUSER.INVOICE.BACK_ACCOUNT_NUMBER, INVUSER.INVOICE.DATE_RECORDED, INVUSER.CUSTOMER.CUST_NAME, 
                                                     INVUSER.CUSTOMER.CONTACT, INVUSER.PRODUCT.PRODUCT_CODE, INVUSER.PRODUCT.PRODUCT_NAME, INVUSER.PRODUCT.CATEGORY, INVUSER.PRODUCT.UNIT_PRICE
                            FROM            INVUSER.INVOICE INNER JOIN
                                                     INVUSER.CUSTOMER ON INVUSER.CUSTOMER.CUST_ID = INVUSER.INVOICE.CUST_ID INNER JOIN
                                                     INVUSER.PRODUCT ON INVUSER.PRODUCT.PRODUCT_ID = INVUSER.INVOICE.PRODUCT_ID INNER JOIN
                                                     INVUSER.USERS ON INVUSER.USERS.USER_ID = INVUSER.INVOICE.USER_ID  
                            where Invoice_Id like '%" + TextBox1.Text + "%'"
        com.CommandType = CommandType.Text
        da.SelectCommand = com
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim dt As DataTable = New DataTable()

        Dim da As New OracleDataAdapter()
        conn.Open()
        com = conn.CreateCommand
        com.CommandText = "SELECT        INVUSER.INVOICE.INVOICE_ID, INVUSER.INVOICE.CUST_ID, INVUSER.INVOICE.USER_ID, INVUSER.INVOICE.PRODUCT_ID, INVUSER.INVOICE.PAYMENT_TYPE, INVUSER.INVOICE.QUANTITY, 
                                                     INVUSER.INVOICE.TOTAL_AMOUNT, INVUSER.INVOICE.BANK_ACCOUNT_NAME, INVUSER.INVOICE.BACK_ACCOUNT_NUMBER, INVUSER.INVOICE.DATE_RECORDED, INVUSER.CUSTOMER.CUST_NAME, 
                                                     INVUSER.CUSTOMER.CONTACT, INVUSER.PRODUCT.PRODUCT_CODE, INVUSER.PRODUCT.PRODUCT_NAME, INVUSER.PRODUCT.CATEGORY, INVUSER.PRODUCT.UNIT_PRICE
                            FROM            INVUSER.INVOICE INNER JOIN
                                                     INVUSER.CUSTOMER ON INVUSER.CUSTOMER.CUST_ID = INVUSER.INVOICE.CUST_ID INNER JOIN
                                                     INVUSER.PRODUCT ON INVUSER.PRODUCT.PRODUCT_ID = INVUSER.INVOICE.PRODUCT_ID INNER JOIN
                                                     INVUSER.USERS ON INVUSER.USERS.USER_ID = INVUSER.INVOICE.USER_ID  
                            where INVUSER.INVOICE.CUST_ID like '%" + TextBox2.Text + "%'"
        com.CommandType = CommandType.Text
        da.SelectCommand = com
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim dt As DataTable = New DataTable()

        Dim da As New OracleDataAdapter()
        conn.Open()
        com = conn.CreateCommand
        com.CommandText = "SELECT        INVUSER.INVOICE.INVOICE_ID, INVUSER.INVOICE.CUST_ID, INVUSER.INVOICE.USER_ID, INVUSER.INVOICE.PRODUCT_ID, INVUSER.INVOICE.PAYMENT_TYPE, INVUSER.INVOICE.QUANTITY, 
                                                     INVUSER.INVOICE.TOTAL_AMOUNT, INVUSER.INVOICE.BANK_ACCOUNT_NAME, INVUSER.INVOICE.BACK_ACCOUNT_NUMBER, INVUSER.INVOICE.DATE_RECORDED, INVUSER.CUSTOMER.CUST_NAME, 
                                                     INVUSER.CUSTOMER.CONTACT, INVUSER.PRODUCT.PRODUCT_CODE, INVUSER.PRODUCT.PRODUCT_NAME, INVUSER.PRODUCT.CATEGORY, INVUSER.PRODUCT.UNIT_PRICE
                            FROM            INVUSER.INVOICE INNER JOIN
                                                     INVUSER.CUSTOMER ON INVUSER.CUSTOMER.CUST_ID = INVUSER.INVOICE.CUST_ID INNER JOIN
                                                     INVUSER.PRODUCT ON INVUSER.PRODUCT.PRODUCT_ID = INVUSER.INVOICE.PRODUCT_ID INNER JOIN
                                                     INVUSER.USERS ON INVUSER.USERS.USER_ID = INVUSER.INVOICE.USER_ID  
                            where INVUSER.PRODUCT.PRODUCT_ID like '%" + TextBox3.Text + "%'"
        com.CommandType = CommandType.Text
        da.SelectCommand = com
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim dt As DataTable = New DataTable()

        Dim da As New OracleDataAdapter()
        conn.Open()
        com = conn.CreateCommand
        com.CommandText = "SELECT        INVUSER.INVOICE.INVOICE_ID, INVUSER.INVOICE.CUST_ID, INVUSER.INVOICE.USER_ID, INVUSER.INVOICE.PRODUCT_ID, INVUSER.INVOICE.PAYMENT_TYPE, INVUSER.INVOICE.QUANTITY, 
                                                     INVUSER.INVOICE.TOTAL_AMOUNT, INVUSER.INVOICE.BANK_ACCOUNT_NAME, INVUSER.INVOICE.BACK_ACCOUNT_NUMBER, INVUSER.INVOICE.DATE_RECORDED, INVUSER.CUSTOMER.CUST_NAME, 
                                                     INVUSER.CUSTOMER.CONTACT, INVUSER.PRODUCT.PRODUCT_CODE, INVUSER.PRODUCT.PRODUCT_NAME, INVUSER.PRODUCT.CATEGORY, INVUSER.PRODUCT.UNIT_PRICE
                            FROM            INVUSER.INVOICE INNER JOIN
                                                     INVUSER.CUSTOMER ON INVUSER.CUSTOMER.CUST_ID = INVUSER.INVOICE.CUST_ID INNER JOIN
                                                     INVUSER.PRODUCT ON INVUSER.PRODUCT.PRODUCT_ID = INVUSER.INVOICE.PRODUCT_ID INNER JOIN
                                                     INVUSER.USERS ON INVUSER.USERS.USER_ID = INVUSER.INVOICE.USER_ID  
                            where INVUSER.INVOICE.DATE_RECORDED like '%" + TextBox4.Text + "%'"
        com.CommandType = CommandType.Text
        da.SelectCommand = com
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Dim dt As DataTable = New DataTable()

        Dim da As New OracleDataAdapter()
        conn.Open()
        com = conn.CreateCommand
        com.CommandText = "SELECT        INVUSER.INVOICE.INVOICE_ID, INVUSER.INVOICE.CUST_ID, INVUSER.INVOICE.USER_ID, INVUSER.INVOICE.PRODUCT_ID, INVUSER.INVOICE.PAYMENT_TYPE, INVUSER.INVOICE.QUANTITY, 
                                                     INVUSER.INVOICE.TOTAL_AMOUNT, INVUSER.INVOICE.BANK_ACCOUNT_NAME, INVUSER.INVOICE.BACK_ACCOUNT_NUMBER, INVUSER.INVOICE.DATE_RECORDED, INVUSER.CUSTOMER.CUST_NAME, 
                                                     INVUSER.CUSTOMER.CONTACT, INVUSER.PRODUCT.PRODUCT_CODE, INVUSER.PRODUCT.PRODUCT_NAME, INVUSER.PRODUCT.CATEGORY, INVUSER.PRODUCT.UNIT_PRICE
                            FROM            INVUSER.INVOICE INNER JOIN
                                                     INVUSER.CUSTOMER ON INVUSER.CUSTOMER.CUST_ID = INVUSER.INVOICE.CUST_ID INNER JOIN
                                                     INVUSER.PRODUCT ON INVUSER.PRODUCT.PRODUCT_ID = INVUSER.INVOICE.PRODUCT_ID INNER JOIN
                                                     INVUSER.USERS ON INVUSER.USERS.USER_ID = INVUSER.INVOICE.USER_ID  
                            where INVUSER.CUSTOMER.CUST_NAME like '%" + TextBox5.Text + "%'"
        com.CommandType = CommandType.Text
        da.SelectCommand = com
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim dt As DataTable = New DataTable()

        Dim da As New OracleDataAdapter()
        conn.Open()
        com = conn.CreateCommand
        com.CommandText = "SELECT        INVUSER.INVOICE.INVOICE_ID, INVUSER.INVOICE.CUST_ID, INVUSER.INVOICE.USER_ID, INVUSER.INVOICE.PRODUCT_ID, INVUSER.INVOICE.PAYMENT_TYPE, INVUSER.INVOICE.QUANTITY, 
                                                     INVUSER.INVOICE.TOTAL_AMOUNT, INVUSER.INVOICE.BANK_ACCOUNT_NAME, INVUSER.INVOICE.BACK_ACCOUNT_NUMBER, INVUSER.INVOICE.DATE_RECORDED, INVUSER.CUSTOMER.CUST_NAME, 
                                                     INVUSER.CUSTOMER.CONTACT, INVUSER.PRODUCT.PRODUCT_CODE, INVUSER.PRODUCT.PRODUCT_NAME, INVUSER.PRODUCT.CATEGORY, INVUSER.PRODUCT.UNIT_PRICE
                            FROM            INVUSER.INVOICE INNER JOIN
                                                     INVUSER.CUSTOMER ON INVUSER.CUSTOMER.CUST_ID = INVUSER.INVOICE.CUST_ID INNER JOIN
                                                     INVUSER.PRODUCT ON INVUSER.PRODUCT.PRODUCT_ID = INVUSER.INVOICE.PRODUCT_ID INNER JOIN
                                                     INVUSER.USERS ON INVUSER.USERS.USER_ID = INVUSER.INVOICE.USER_ID  
                            where INVUSER.PRODUCT.CATEGORY like '%" + TextBox6.Text + "%'"
        com.CommandType = CommandType.Text
        da.SelectCommand = com
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Dim dt As DataTable = New DataTable()

        Dim da As New OracleDataAdapter()
        conn.Open()
        com = conn.CreateCommand
        com.CommandText = "SELECT        INVUSER.INVOICE.INVOICE_ID, INVUSER.INVOICE.CUST_ID, INVUSER.INVOICE.USER_ID, INVUSER.INVOICE.PRODUCT_ID, INVUSER.INVOICE.PAYMENT_TYPE, INVUSER.INVOICE.QUANTITY, 
                                                     INVUSER.INVOICE.TOTAL_AMOUNT, INVUSER.INVOICE.BANK_ACCOUNT_NAME, INVUSER.INVOICE.BACK_ACCOUNT_NUMBER, INVUSER.INVOICE.DATE_RECORDED, INVUSER.CUSTOMER.CUST_NAME, 
                                                     INVUSER.CUSTOMER.CONTACT, INVUSER.PRODUCT.PRODUCT_CODE, INVUSER.PRODUCT.PRODUCT_NAME, INVUSER.PRODUCT.CATEGORY, INVUSER.PRODUCT.UNIT_PRICE
                            FROM            INVUSER.INVOICE INNER JOIN
                                                     INVUSER.CUSTOMER ON INVUSER.CUSTOMER.CUST_ID = INVUSER.INVOICE.CUST_ID INNER JOIN
                                                     INVUSER.PRODUCT ON INVUSER.PRODUCT.PRODUCT_ID = INVUSER.INVOICE.PRODUCT_ID INNER JOIN
                                                     INVUSER.USERS ON INVUSER.USERS.USER_ID = INVUSER.INVOICE.USER_ID  
                            where INVUSER.PRODUCT.PRODUCT_NAME like '%" + TextBox7.Text + "%'"
        com.CommandType = CommandType.Text
        da.SelectCommand = com
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub
End Class