Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types

Public Class Login
    Public Shared LoggedInUserId As String
    Public Shared LoggedInUsername As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Username.Text = ""
        Password.Text = ""
        ComboBox1.SelectedIndex = -1
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Registration.Show()
        Me.Hide()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim emptyTextBoxes =
        From txt In Me.Controls.OfType(Of TextBox)()
        Where txt.Text.Length = 0
        Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                    String.Join(",", emptyTextBoxes)))

        ElseIf ComboBox1.SelectedIndex = -1 Then
            MsgBox("Choose Role", MsgBoxStyle.Information)
        End If

        If ComboBox1.SelectedItem = "Admin" Then
            Dim conn As New OracleConnection(conn_str)
            conn.Open()
            Dim com As New OracleCommand
            com = conn.CreateCommand
            com.CommandText = "select * from users where Username = '" + Username.Text + "' and Password = '" + Password.Text + "' and designation = '" + ComboBox1.SelectedItem + "'"
            com.CommandType = CommandType.Text
            Dim dr As OracleDataReader = com.ExecuteReader()
            If dr.Read() Then

                LoggedInUserId = dr.Item("User_id")
                LoggedInUsername = dr.Item("Username")
                Dim Username As String = dr.Item("Username")
                Dim Password As String = dr.Item("Password")
                conn.Close()

                MsgBox("Welcome " & Me.Username.Text)
                Admin.Show()
                Me.Hide()

            Else
                MsgBox("Username or Password is Invalid!", MsgBoxStyle.Exclamation)
                Me.Username.Text = ""
                Me.Password.Text = ""

            End If
            'conn.Close()

        ElseIf ComboBox1.SelectedItem = "Employee" Then
            Dim conn As New OracleConnection(conn_str)
            conn.Open()
            Dim com As New OracleCommand
            com = conn.CreateCommand
            com.CommandText = "select * from users where Username = '" + Username.Text + "' and Password = '" + Password.Text + "' and designation = '" + ComboBox1.SelectedItem + "'"
            com.CommandType = CommandType.Text
            Dim dr As OracleDataReader = com.ExecuteReader()
            If dr.Read() Then

                LoggedInUserId = dr.Item("User_id")
                LoggedInUsername = dr.Item("Username")
                Dim Username As String = dr.Item("Username")
                Dim Password As String = dr.Item("Password")
                conn.Close()

                MsgBox("Welcome " & Me.Username.Text)
                Admin.Show()
                Me.Hide()

            Else
                MsgBox("Username or Password is Invalid!", MsgBoxStyle.Exclamation)
                Me.Username.Text = ""
                Me.Password.Text = ""

            End If
            'conn.Close()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class