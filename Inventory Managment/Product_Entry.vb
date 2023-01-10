Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types

Public Class Product_Entry
    Dim conn As New OracleConnection(conn_str)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim emptyTextBoxes =
       From txt In Me.Controls.OfType(Of TextBox)()
       Where txt.Text.Length = 0
       Select txt.Name

        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following fields: {0}",
                    String.Join(",", emptyTextBoxes)))
        End If

        If Not IsNumeric(Reorder_Level.Text) Then
            MsgBox("Invalid Reorder Level")
            Return
        End If

        If Not IsNumeric(Unit_In_Stock.Text) Then
            MsgBox("Invalid Unit in Stock")
            Return
        End If

        If Not IsNumeric(Unit_Price.Text) Then
            MsgBox("Invalid Unit Price")
            Return
        End If

        If Not (emptyTextBoxes.Any) Then

            Dim com As New OracleCommand
            conn.Open()
            com = conn.CreateCommand
            com.CommandText = "select * from product where Product_Code = '" + Product_Code.Text + "'"
            com.CommandType = CommandType.Text
            Dim dr As OracleDataReader = com.ExecuteReader()
            Dim ds As DataTable = New DataTable()
            ds.Load(dr)

            conn.Close()
            MsgBox(ds.Rows.Count)

            MsgBox(com.CommandText.ToString)


            If ds.Rows.Count <> 0 Then
                'Code for update statement
                If ComboBox1.SelectedValue = -1 Then
                    MsgBox("Choose a Supplier")

                Else
                    conn.Open()
                    com = conn.CreateCommand
                    com.CommandText = "update product 
                       set Product_Code = '" + Product_Code.Text + "', Product_Name = '" + Product_Name.Text + "', Unit_Name = '" + Unit_Name.Text + "' , Unit_In_Stock = " + Unit_In_Stock.Text + ", Unit_Price = " + Unit_Price.Text + ", Category ='" + Category.Text + "', Reorder_Level= " + Reorder_Level.Text + ", Supplier_Id= '" + ComboBox1.SelectedValue.ToString + "'" +
                       "where Product_Code = '" + Product_Code.Text + "'"
                    com.CommandType = CommandType.Text
                    dr = com.ExecuteReader()
                    MsgBox("Product Details Updated Successfully..")
                    conn.Close()

                    Dim ds1 As DataTable = New DataTable()
                    Product_Record.Show()
                    conn.Open()
                    com = conn.CreateCommand
                    com.CommandText = "select * from product"
                    com.CommandType = CommandType.Text
                    dr = com.ExecuteReader()
                    ds1.Load(dr)
                    Product_Record.DataGridView1.DataSource = ds1
                    Me.Close()
                End If

            Else




                    conn.Open()

                com = conn.CreateCommand
                com.CommandText = "insert into product(product_code,product_name,unit_name,unit_in_stock,unit_price,category,reorder_level,user_id,supplier_id) values('" + Product_Code.Text + "','" + Product_Name.Text + "','" + Unit_Name.Text + "'," + Unit_In_Stock.Text + "," + Unit_Price.Text + ",'" + Category.Text + "'," + Reorder_Level.Text + "," + Login.LoggedInUserId + ",'" + ComboBox1.SelectedValue.ToString + "')"
                MsgBox(com.CommandText)
                com.CommandType = CommandType.Text
                dr = com.ExecuteReader()
                MsgBox("Product Details Inserted Successfully..")
                conn.Close()

                Product_Record.Show()
                conn.Open()
                com = conn.CreateCommand
                com.CommandText = "select * from product"
                com.CommandType = CommandType.Text
                dr = com.ExecuteReader()
                ds.Load(dr)
                Product_Record.DataGridView1.DataSource = ds

                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Product_Record.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


    End Sub

    Private Sub Product_Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim com As New OracleCommand
        Dim dr As OracleDataReader
        Dim ds1 As DataTable = New DataTable()
        conn.Open()
        com = conn.CreateCommand
        com.CommandText = "select -1 as supplier_id,'Select' as supplier_name from supplier UNION select distinct supplier_id,supplier_name from supplier"
        com.CommandType = CommandType.Text
        dr = com.ExecuteReader()
        ds1.Load(dr)
        conn.Close()

        If ds1.Rows.Count > 0 Then
            Me.ComboBox1.DataSource = ds1
            Me.ComboBox1.DisplayMember = "supplier_name"
            Me.ComboBox1.ValueMember = "supplier_id"
        Else
            MsgBox("No supplier data found. Contact administrator!", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class