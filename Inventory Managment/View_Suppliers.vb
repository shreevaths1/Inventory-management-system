Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types
Public Class View_Suppliers
    Dim conn As New OracleConnection(conn_str)
    Dim com As New OracleCommand
    Private Sub View_Suppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SupplierDataSet.SUPPLIER' table. You can move, or remove it, as needed.
        Me.SUPPLIERTableAdapter.Fill(Me.SupplierDataSet.SUPPLIER)

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
        com.CommandText = "select * from supplier where Supplier_Name like '%" + TextBox3.Text + "%'"
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
        com.CommandText = "select * from supplier where Supplier_Id like '%" + TextBox1.Text + "%'"
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
            MessageBox.Show(String.Format("{0}", dataGridViewCell))
            If MessageBox.Show(String.Format("Do you want to delete Supplier Id: {0}", dataGridViewCell), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                conn.Open()
                com = conn.CreateCommand
                com.CommandText = "DELETE FROM supplier WHERE Supplier_Id = " + dataGridViewCell
                com.CommandType = CommandType.Text
                dr = com.ExecuteReader()
                MsgBox("Supplier Details Deleted Successfully..")
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
        Supplier_Register.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If DataGridView1.SelectedRows.Count = 1 Then
            Dim dr As OracleDataReader
            Dim ds As DataTable = New DataTable()
            Dim index2 = DataGridView1.SelectedRows(0).Index
            Dim dataGridViewRow2 = DataGridView1.Rows.Item(index2)
            Dim dataGridViewCell2 As String = dataGridViewRow2.Cells.Item(0).Value


            Supplier_Register.Show()
            Me.Close()

            conn.Open()

            com = conn.CreateCommand
            com.CommandText = "select * from supplier where supplier_Id = " + dataGridViewCell2
            com.CommandType = CommandType.Text
            dr = com.ExecuteReader()
            ds.Load(dr)
            Me.DataGridView1.DataSource = ds
            conn.Close()



            Dim row As DataRow = ds.Rows(0)
            Supplier_Register.Supplier_Name.Text = row(1).ToString
            Supplier_Register.Contact.Text = row(2).ToString
            Supplier_Register.Address.Text = row(3).ToString
            Supplier_Register.Email.Text = row(4).ToString

        Else
            MsgBox("Select Entire Row to Update", MsgBoxStyle.Information)
        End If
    End Sub
End Class