Imports System
Imports System.Data
Imports System.Data.SqlClient

Module CommandParameters
    Sub Main()

        'set up rudimentary data
        Dim fname As String = "Zachariah"
        Dim lname As String = "Zinn"

        'create connection
        Dim conn As SqlConnection = New SqlConnection _
        ("Data Source=.\sqlexpress;" & _
         "Integrated Security=True;" & _
         "database=northwind")

        'define scalar query
        Dim sqlqry As String = "select count(*)from employees"

        Dim vals As String = "('" & fname & "'," & "'" & lname & "')"
        Dim sqlins As String = "insert into employees" & _
        "(firstname,lastname)values" & vals


        'define insert statement
        Dim sqlins As String = "insert into employees " & _
        "(firstname,lastname)values(@fname,@lname)"

        'define delete statement
        Dim sqldel As String = "delete from employees " & _
        "where firstname = @fname " & _
        "and lastname = @lname"

        'create commands 
        Dim cmdqry As SqlCommand = New SqlCommand(sqlqry, conn)
        Dim cmdnon As SqlCommand = New SqlCommand(sqlins, conn)
        cmdnon.Prepare()

        'add parameters to the command for statements
        cmdnon.Parameters.Add("@fname", SqlDbType.NVarChar, 10)
        cmdnon.Parameters.Add("@lname", SqlDbType.NVarChar, 20)

        Try
            'Open connection
            conn.Open()

            'execute query to get number of employees
            Console.WriteLine("Before INSERT: Number of employees {0}" _
            , cmdqry.ExecuteScalar())

            'execute nonquery to insert an employee
            cmdnon.Parameters("@fname").Value = fname
            cmdnon.Parameters("@lname").Value = lname
            Console.WriteLine("Executing statement {0}" _
            , cmdnon.CommandText)

            cmdnon.ExecuteNonQuery()

            Console.WriteLine("After INSERT: Number of employees {0}" _
           , cmdqry.ExecuteScalar())

            'execute nonquery to delete an employee
            cmdnon.CommandText = sqldel
            Console.WriteLine("Executing statement {0}" _
             , cmdnon.CommandText)
            cmdnon.ExecuteNonQuery()
            Console.WriteLine("After DELETE: Number of employees {0}" _
            , cmdqry.ExecuteScalar())

        Catch ex As SqlException
            Console.WriteLine(ex)

        Finally
            ' Close connection
            conn.Close()
            Console.WriteLine("Connection closed.")
        End Try
    End Sub
End Module
