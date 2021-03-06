﻿Imports System.Data.SqlClient
Public Class Transaction

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conn As New SqlConnection
        conn.ConnectionString = "Data Source=.\sqlexpress;" & _
        "Initial Catalog=Northwind;Integrated Security=True"

        ' INSERT
        Dim sqlins As String = "insert into customers" & _
        "(customerid, CompanyName)values(@newcustid, @newconame)"

        ' DELETE
        Dim sqldel As String = "delete from customers" & _
        "where customerid = @oldcustid "
        
        ' Open connection
        conn.Open() '

        ' Begin transaction
        Dim sqltrans As SqlTransaction = conn.BeginTransaction()

        Try
            ' create insert command
            Dim cmdins As SqlCommand = conn.CreateCommand()
            cmdins.CommandText = sqlins
            cmdins.Transaction = sqltrans
            cmdins.Parameters.Add("@newcustid", System.Data.SqlDbType.NVarChar, 5)
            cmdins.Parameters.Add("@newconame", System.Data.SqlDbType.NVarChar, 30)

            ' create delete command
            Dim cmddel As SqlCommand = conn.CreateCommand()
            cmddel.CommandText = sqldel
            cmddel.Transaction = sqltrans
            cmddel.Parameters.Add("@oldcustid", System.Data.SqlDbType.NVarChar, 5)

            ' add customer
            cmdins.Parameters("@newcustid").Value = TextBox1.Text
            cmdins.Parameters("@newconame").Value = TextBox2.Text
            cmdins.ExecuteNonQuery()

            ' delete customer
            cmddel.Parameters("@oldcustid").Value = TextBox3.Text
            cmddel.ExecuteNonQuery()

            'Commit transaction
            sqltrans.Commit()

            ' No exception, transaction committed, give message
            MessageBox.Show("Transaction committed")
        Catch ex As System.Data.SqlClient.SqlException
            'Roll back transaction
            sqltrans.Rollback()

            MessageBox.Show("Transaction rolled back" + ControlChars.Lf + _
                            ex.Message, "Rollback Transaction")
        Catch ex As System.Exception
            MessageBox.Show("System Error" + ControlChars.Lf + ex.Message, "Error")
        Finally
            ' Close connection
            conn.Close()
        End Try
    End Sub
End Class
