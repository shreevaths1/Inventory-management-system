Imports System.Text.RegularExpressions
Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types
Public Class Registration
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Customer_Record.Show()
        Me.Hide()
    End Sub

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
            conn.Open()
            'Insert into cust(Username, Password, Email, Contact, City) values('john','john123','john@gmail.com',7574637847,'Bangalore')
            Dim com As New OracleCommand
            com = conn.CreateCommand
            com.CommandText = "insert into customer(Cust_Name,Email,Contact,Address) values('" + Cust_Name.Text + "','" + Email.Text + "'," + Contact.Text + ",'" + Address.Text + "')"
            com.CommandType = CommandType.Text
            com.ExecuteReader()
            MsgBox("Customer Details Inserted Successfully..")
            conn.Close()
            Customer_Record.Show()

            Dim dr As OracleDataReader
            Dim ds As DataTable = New DataTable()
            conn.Open()
            com = conn.CreateCommand
            com.CommandText = "select * from customer"
            com.CommandType = CommandType.Text
            dr = com.ExecuteReader()
            ds.Load(dr)
            Customer_Record.DataGridView1.DataSource = ds


            Me.Close()
        End If


    End Sub
End Class