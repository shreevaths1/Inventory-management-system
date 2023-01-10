Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types
Public Class Purchase_History
    Dim conn As New OracleConnection(conn_str)
    Dim com As New OracleCommand

    Private Sub Purchase_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PurchasedDataSet.PURCHASE_ORDER' table. You can move, or remove it, as needed.
        Me.PURCHASE_ORDERTableAdapter.Fill(Me.PurchasedDataSet.PURCHASE_ORDER)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim dt As DataTable = New DataTable()

        Dim da As New OracleDataAdapter()
        conn.Open()
        com = conn.CreateCommand
        com.CommandText = "select * from purchase_order  
                            where order_id like '%" + TextBox3.Text + "%'"
        com.CommandType = CommandType.Text
        da.SelectCommand = com
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim dt As DataTable = New DataTable()

        Dim da As New OracleDataAdapter()
        conn.Open()
        com = conn.CreateCommand
        com.CommandText = "select * from purchase_order  
                            where order_date like '%" + TextBox1.Text + "%'"
        com.CommandType = CommandType.Text
        da.SelectCommand = com
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count = 1 Then
            Dim dr As OracleDataReader

            Dim ds As DataTable = New DataTable()
            Dim index2 = DataGridView1.SelectedRows(0).Index
            Dim dataGridViewRow2 = DataGridView1.Rows.Item(index2)
            Dim dataGridViewCell2 As String = dataGridViewRow2.Cells.Item(0).Value
            Stock_Recieved.Show()
            Me.Close()

            conn.Open()

            com = conn.CreateCommand
            com.CommandText = "select order_id,product_id,quantity from purchase_order where order_Id = " + dataGridViewCell2
            com.CommandType = CommandType.Text
            dr = com.ExecuteReader()
            ds.Load(dr)
            Me.DataGridView1.DataSource = ds
            conn.Close()



            Dim row As DataRow = ds.Rows(0)
            Stock_Recieved.TextBox1.Text = row(0).ToString
            Stock_Recieved.TextBox2.Text = row(1).ToString
            Stock_Recieved.TextBox4.Text = row(2).ToString

        Else
            MsgBox("Select Entire Row to Update", MsgBoxStyle.Information)
        End If
    End Sub
End Class