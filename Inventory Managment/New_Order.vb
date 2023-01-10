Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types
Public Class New_Order
    Dim conn As New OracleConnection(conn_str)
    Public Shared price As Long

    Private Sub New_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim com As New OracleCommand
        Dim dr As OracleDataReader
        Dim ds1 As DataTable = New DataTable()
        conn.Open()
        com = conn.CreateCommand
        com.CommandText = "select -1 as product_id,'Select' as product_name from product UNION select distinct product_id,product_name from product"
        com.CommandType = CommandType.Text
        dr = com.ExecuteReader()
        ds1.Load(dr)
        conn.Close()

        If ds1.Rows.Count > 0 Then
            Me.ComboBox1.DataSource = ds1
            Me.ComboBox1.DisplayMember = "product_name"
            Me.ComboBox1.ValueMember = "product_id"
        Else
            MsgBox("No product data found. Contact administrator!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim rowView As DataRowView = Me.ComboBox1.SelectedItem
        Dim com As New OracleCommand
        Dim dr As OracleDataReader
        Dim ds1 As DataTable = New DataTable()
        'MsgBox(rowView.Row.Item(0).ToString)
        If Not rowView.Row.Item(0).ToString = -1 Then

            conn.Open()
            com = conn.CreateCommand
            com.CommandText = "select *  from product where product_id = '" + rowView.Row.Item(0).ToString + "'"
            'MsgBox(com.CommandText)
            com.CommandType = CommandType.Text
            dr = com.ExecuteReader()
            ds1.Load(dr)
            conn.Close()

            If ds1.Rows.Count > 0 Then
                Dim row As DataRow = ds1.Rows(0)
                price = row(5)
                TextBox1.Text = row(5).ToString

            Else
                MsgBox("No product data found. Contact administrator!", MsgBoxStyle.Exclamation)
            End If


        End If
    End Sub

    Private Sub quantityBox_ValueChanged(sender As Object, e As EventArgs) Handles quantityBox.ValueChanged

        'MsgBox(price)
        TextBox4.Text = quantityBox.Value * price
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim com As New OracleCommand
        Dim dr As OracleDataReader
        conn.Open()
        com = conn.CreateCommand
        'MsgBox(order_date.Text)
        com.CommandText = "insert into purchase_order(product_id,user_id,quantity,sub_total,order_date) values('" + ComboBox1.SelectedValue.ToString + "'," + Login.LoggedInUserId + ",'" + quantityBox.Value.ToString + "'," + TextBox4.Text + ",'" + order_date.Text + "')"
        'MsgBox(com.CommandText)
        com.CommandType = CommandType.Text
        dr = com.ExecuteReader()
        MsgBox("Your Order Has Been Placed Successfully..")
        conn.Close()

        Me.Close()
        Admin.Show()
    End Sub
End Class