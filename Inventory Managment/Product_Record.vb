Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types
Public Class Product_Record
    Dim conn As New OracleConnection(conn_str)
    Dim com As New OracleCommand
    Dim dr As OracleDataReader
    Dim da As New OracleDataAdapter()
    Dim ds As DataTable = New DataTable()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Product_Entry.Show()
        Me.Hide()
    End Sub


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim dt As DataTable = New DataTable()
        conn.Open()
        com = conn.CreateCommand
        com.CommandText = "select * from product where Product_Name like '%" + TextBox3.Text + "%'"
        com.CommandType = CommandType.Text
        da.SelectCommand = com
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim dt As DataTable = New DataTable()
        conn.Open()
        com = conn.CreateCommand
        com.CommandText = "select * from product where Category like '%" + TextBox2.Text + "%'"
        com.CommandType = CommandType.Text
        da.SelectCommand = com
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim dt As DataTable = New DataTable()
        conn.Open()
        com = conn.CreateCommand
        com.CommandText = "select * from product where Product_Id like '%" + TextBox1.Text + "%'"
        com.CommandType = CommandType.Text
        da.SelectCommand = com
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView1.SelectedRows.Count = 1 Then

            Dim index2 = DataGridView1.SelectedRows(0).Index
            Dim dataGridViewRow2 = DataGridView1.Rows.Item(index2)
            Dim dataGridViewCell2 As String = dataGridViewRow2.Cells.Item(0).Value


            Product_Entry.Show()
            Me.Hide()

            conn.Open()

            com = conn.CreateCommand
            com.CommandText = "select * from product where Product_Id = " + dataGridViewCell2
            com.CommandType = CommandType.Text
            dr = com.ExecuteReader()
            ds.Load(dr)
            Me.DataGridView1.DataSource = ds
            conn.Close()



            Dim row As DataRow = ds.Rows(0)
            Product_Entry.Product_Code.Text = row(1).ToString
            Product_Entry.Product_Name.Text = row(2).ToString
            Product_Entry.Unit_Name.Text = row(3).ToString
            Product_Entry.Unit_In_Stock.Text = row(4).ToString
            Product_Entry.Unit_Price.Text = row(5).ToString
            Product_Entry.Category.Text = row(6).ToString
            Product_Entry.Reorder_Level.Text = row(7).ToString
            Product_Entry.ComboBox1.SelectedValue = row(9)
        Else
            MsgBox("Select Entire Row to Update", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count = 1 Then

            Dim index = DataGridView1.SelectedRows(0).Index
            Dim dataGridViewRow = DataGridView1.Rows.Item(index)
            Dim dataGridViewCell As String = dataGridViewRow.Cells.Item(0).Value
            Dim rowdeleted = False
            MessageBox.Show(String.Format("{0}", dataGridViewCell))
            If MessageBox.Show(String.Format("Do you want to delete Product Id: {0}", dataGridViewCell), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                conn.Open()
                com = conn.CreateCommand
                com.CommandText = "DELETE FROM product WHERE Product_Id = " + dataGridViewCell
                com.CommandType = CommandType.Text
                dr = com.ExecuteReader()
                MsgBox("Product Details Deleted Successfully..")
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

    Private Sub Product_Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductDataSet.PRODUCT' table. You can move, or remove it, as needed.
        Me.PRODUCTTableAdapter.Fill(Me.ProductDataSet.PRODUCT)

    End Sub
End Class
