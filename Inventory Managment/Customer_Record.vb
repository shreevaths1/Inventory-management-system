Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types
Public Class Customer_Record
    Dim conn As New OracleConnection(conn_str)
    Dim com As New OracleCommand

    Private Sub Customer_Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerDataSet.CUSTOMER' table. You can move, or remove it, as needed.
        Me.CUSTOMERTableAdapter.Fill(Me.CustomerDataSet.CUSTOMER)



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
        com.CommandText = "select * from customer where cust_name like '%" + TextBox3.Text + "%'"
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
        com.CommandText = "select * from customer where Cust_Id like '%" + TextBox1.Text + "%'"
        com.CommandType = CommandType.Text
        da.SelectCommand = com
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dr As OracleDataReader
        If DataGridView1.SelectedRows.Count = 1 Then

            Dim index = DataGridView1.SelectedRows(0).Index
            Dim dataGridViewRow = DataGridView1.Rows.Item(index)
            Dim dataGridViewCell As String = dataGridViewRow.Cells.Item(0).Value
            Dim rowdeleted = False
            'MessageBox.Show(String.Format("{0}", dataGridViewCell))
            If MessageBox.Show(String.Format("Do you want to delete Customer Id: {0}", dataGridViewCell), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                conn.Open()
                com = conn.CreateCommand
                com.CommandText = "DELETE FROM customer WHERE Cust_Id = " + dataGridViewCell
                com.CommandType = CommandType.Text
                dr = com.ExecuteReader()
                MsgBox("Customer Details Deleted Successfully..")
                conn.Close()
                rowdeleted = True

            Else

            End If

            If rowdeleted = True Then
                DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            End If
        Else
            MsgBox("Select Entire Row to Delete", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Registration.Show()
        Me.Hide()
    End Sub
End Class