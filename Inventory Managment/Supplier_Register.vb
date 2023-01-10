Imports System.Text.RegularExpressions
Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types
Public Class Supplier_Register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim regex As Regex = New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        Dim isvalid As Boolean = regex.IsMatch(Email.Text.Trim)

        Dim emptyTextBoxes =
        From txt In Me.Controls.OfType(Of TextBox)()
        Where txt.Text.Length = 0
        Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                    String.Join(",", emptyTextBoxes)))
        End If

        If Not IsNumeric(Contact.Text) Then
            MsgBox("Invalid Phone number")
            Return
        End If


        If Contact.Text.Length > 10 Then
            MsgBox("Invalid Phone number")
            Return
        End If

        If Not isvalid Then
            MsgBox("Invalid Email Address")
            Return
        End If


        If Not (emptyTextBoxes.Any) Then
            Dim conn As New OracleConnection(conn_str)
            Dim com As New OracleCommand
            conn.Open()
            com = conn.CreateCommand
            com.CommandText = "select * from supplier where suppler_contact = " + Contact.Text
            com.CommandType = CommandType.Text
            Dim dr As OracleDataReader = com.ExecuteReader()
            Dim ds As DataTable = New DataTable()
            ds.Load(dr)

            conn.Close()
            MsgBox(ds.Rows.Count)

            MsgBox(com.CommandText.ToString)



            'Insert into cust(Username, Password, Email, Contact, City) values('john','john123','john@gmail.com',7574637847,'Bangalore')
            If ds.Rows.Count <> 0 Then

                conn.Open()
                com = conn.CreateCommand
                com.CommandText = "update supplier
                       set supplier_name = '" + Supplier_Name.Text + "', suppler_contact = " + Contact.Text + ", supplier_address = '" + Address.Text + "' , Supplier_email = '" + Email.Text + "'" +
                       "where Suppler_contact = " + Contact.Text
                com.CommandType = CommandType.Text
                dr = com.ExecuteReader()
                MsgBox("Supplier Details Updated Successfully..")
                conn.Close()

                Dim ds1 As DataTable = New DataTable()
                View_Suppliers.Show()
                conn.Open()
                com = conn.CreateCommand
                com.CommandText = "select * from supplier"
                com.CommandType = CommandType.Text
                dr = com.ExecuteReader()
                ds1.Load(dr)
                Product_Record.DataGridView1.DataSource = ds1
                Me.Close()

            Else
                conn.Open()
                com = conn.CreateCommand
                com.CommandText = "insert into supplier(Supplier_Name,Supplier_Email,Suppler_Contact,Supplier_Address) values('" + Supplier_Name.Text + "','" + Email.Text + "'," + Contact.Text + ",'" + Address.Text + "')"
                com.CommandType = CommandType.Text
                com.ExecuteReader()
                MsgBox("Supplier Details Inserted Successfully..")
                conn.Close()

                View_Suppliers.Show()
                conn.Open()
                Dim dt As DataTable = New DataTable()
                Dim da As New OracleDataAdapter()

                com = conn.CreateCommand
                com.CommandText = "select * from supplier"
                com.CommandType = CommandType.Text
                da.SelectCommand = com
                da.Fill(dt)
                View_Suppliers.DataGridView1.DataSource = dt
                conn.Close()
                Me.Close()
            End If

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        View_Suppliers.Show()
        Me.Close()
    End Sub
End Class