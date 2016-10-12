Imports System.Data.SqlClient

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conn As SqlConnection = New SqlConnection _
        ("Data Source=.\sqlexpress;" & _
         "Integrated Security=True;" & _
         "database=northwind")

        'create command
        Dim cmd As SqlCommand = conn.CreateCommand

        'Specify that a stored procedure is to be executed
        cmd.CommandType = CommandType.StoredProcedure

        'Deliberately fail to specify the procedure
        'cmd.CommandText = "sp_Select_All_Employees"

        Try
            'Open connection
            conn.Open()

            'Create data reader
            Dim dr As SqlDataReader = cmd.ExecuteReader

            'Close reader
            dr.Close()

        Catch ex As System.Data.SqlClient.SqlException
            Dim str As String
            str = "Source: " + ex.Source.ToString
            str += ControlChars.NewLine + "Exception Message: " + ex.Message
            MessageBox.Show(str, "Database Exception")

        Catch ex As Exception
            Dim str As String
            str = "Source: " + ex.Source.ToString
            str += ControlChars.NewLine + "Exception Message: " + ex.Message
            MessageBox.Show(str, "non-Database Exception")
        
        Finally
            If conn.State = ConnectionState.Open Then
                MessageBox.Show("Finally block Closing the connection", "Finally")
                conn.Close()
            End If
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim conn As SqlConnection = New SqlConnection _
        ("Data Source=.\sqlexpress;" & _
         "Integrated Security=True;" & _
         "database=northwind")

        'create command
        Dim cmd As SqlCommand = conn.CreateCommand

        'Specify that a stored procedure is to be executed
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Select_No_Employees"

        Try
            'Open connection
            conn.Open()

            'Create data reader
            Dim dr As SqlDataReader = cmd.ExecuteReader

            'Access nonexistent column
            Dim str As String = dr.GetValue(20).ToString

            'Close reader
            dr.Close()

        Catch ex As System.InvalidOperationException
            Dim str As String
            str = "Source: " + ex.Source.ToString
            str += ControlChars.NewLine + "Exception Message: " + ex.Message
            str += ControlChars.NewLine + ControlChars.NewLine
            str += "Stack Trace: " + ex.StackTrace
            MessageBox.Show(str, "Specific Exception")

        Catch ex As System.Data.SqlClient.SqlException
            Dim str As String
            str = "Source: " + ex.Source.ToString
            str += ControlChars.NewLine + "Exception Message: " + ex.Message
            MessageBox.Show(str, "Database Exception")

        Catch ex As Exception
            Dim str As String
            str = "Source: " + ex.Source.ToString
            str += ControlChars.NewLine + "Exception Message: " + ex.Message
            MessageBox.Show(str, "non-Database Exception")

        Finally
            If conn.State = ConnectionState.Open Then
                MessageBox.Show("Finally block Closing the connection", "Finally")
                conn.Close()
            End If
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim conn As SqlConnection = New SqlConnection _
                ("Data Source=.\sqlexpress;" & _
                 "Integrated Security=True;" & _
                 "database=northwind")

        'create command
        Dim cmd As SqlCommand = conn.CreateCommand

        'Specify that a stored procedure is to be executed
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DbException_1"

        Try
            'Open connection
            conn.Open()

            'Execute stored procedure
            cmd.ExecuteNonQuery()

        Catch ex As System.Data.SqlClient.SqlException
            Dim str As String
            str = "Source: " + ex.Source.ToString
            str += ControlChars.NewLine + "Number: " + ex.Number.ToString
            str += ControlChars.NewLine + "Message: " + ex.Message
            str += ControlChars.NewLine + "Class: " + ex.Class.ToString
            str += ControlChars.NewLine + "Procedure: " + ex.Procedure
            str += ControlChars.NewLine + "Line Number: " + ex.LineNumber.ToString
            str += ControlChars.NewLine + "Server: " + ex.Server
            MessageBox.Show(str, "Database Exception")

        Catch ex As System.Exception
            Dim str As String
            str = "Source: " + ex.Source.ToString
            str += ControlChars.NewLine + "Exception Message: " + ex.Message
            MessageBox.Show(str, "General Exception")

        Finally
            If conn.State = ConnectionState.Open Then
                MessageBox.Show("Finally block Closing the connection", "Finally")
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim conn As SqlConnection = New SqlConnection _
                ("Data Source=.\sqlexpress;" & _
                 "Integrated Security=True;" & _
                 "database=northwind")

        'create command
        Dim cmd As SqlCommand = conn.CreateCommand

        'Specify that a stored procedure is to be executed
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DbException_2"

        Try
            'Open connection
            conn.Open()

            'Execute stored procedure
            cmd.ExecuteNonQuery()

        Catch ex As System.Data.SqlClient.SqlException
            Dim str As String
            str = "Source: " + ex.Source.ToString
            str += ControlChars.NewLine + "Number: " + ex.Number.ToString
            str += ControlChars.NewLine + "Message: " + ex.Message
            str += ControlChars.NewLine + "Class: " + ex.Class.ToString
            str += ControlChars.NewLine + "Procedure: " + ex.Procedure
            str += ControlChars.NewLine + "Line Number: " + ex.LineNumber.ToString
            str += ControlChars.NewLine + "Server: " + ex.Server
            MessageBox.Show(str, "Database Exception")

        Catch ex As System.Exception
            Dim str As String
            str = "Source: " + ex.Source.ToString
            str += ControlChars.NewLine + "Exception Message: " + ex.Message
            MessageBox.Show(str, "General Exception")

        Finally
            If conn.State = ConnectionState.Open Then
                MessageBox.Show("Finally block Closing the connection", "Finally")
                conn.Close()
            End If
        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim conn As SqlConnection = New SqlConnection _
            ("Data Source=.\sqlexpress;" & _
             "Integrated Security=True;" & _
             "database=northwnd")

        'create command
        Dim cmd As SqlCommand = conn.CreateCommand

        'Specify that a stored procedure is to be executed
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DbException_2"

        Try
            'Open connection
            conn.Open()

            'Execute stored procedure
            cmd.ExecuteNonQuery()

        Catch ex As System.Data.SqlClient.SqlException
            Dim str As String
            Dim i As Integer
            For i = 0 To ex.Errors.Count - 1 Step i + 1
                str += ControlChars.NewLine & "Index #".ToString & i & ControlChars.NewLine & _
                "Exception: " & ex.Errors(i).ToString() & ControlChars.NewLine & _
                "Number: " & ex.Errors(i).Number.ToString() & ControlChars.NewLine
            Next

            MessageBox.Show(str, "Database Exception")

        Catch ex As System.Exception
            Dim str As String
            str = "Source: " + ex.Source.ToString
            str += ControlChars.NewLine + "Exception Message: " + ex.Message
            MessageBox.Show(str, "ADO.NET Exception")

        Finally
            If conn.State = ConnectionState.Open Then
                MessageBox.Show("Finally block Closing the connection", "Finally")
            End If
            conn.Close()
        End Try
    End Sub
End Class
