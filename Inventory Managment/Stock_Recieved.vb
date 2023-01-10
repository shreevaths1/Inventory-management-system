Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types
Public Class Stock_Recieved
    Dim conn As New OracleConnection(conn_str)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Purchase_History.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dr As OracleDataReader
        Dim ds As DataTable = New DataTable()
        Dim com As New OracleCommand
        conn.Open()
        com = conn.CreateCommand
        com.CommandText = "update purchase_order 
                       set recieved_date = '" + recieved_date.Text + "'" +
                       "where order_id = '" + TextBox1.Text + "'"
        MsgBox(com.CommandText)
        com.CommandType = CommandType.Text
        dr = com.ExecuteReader()
        MsgBox("Data has been updated Successfully..")
        conn.Close()

        conn.Open()
        com = conn.CreateCommand
        com.CommandText = "update product 
                       set unit_in_stock = unit_in_stock + " + TextBox4.Text +
                       "where product_id = '" + TextBox2.Text + "'"
        MsgBox(com.CommandText)
        com.CommandType = CommandType.Text
        dr = com.ExecuteReader()
        MsgBox("Data has been updated Successfully..")
        conn.Close()
        Me.Close()
        Purchase_History.Show()
    End Sub
End Class