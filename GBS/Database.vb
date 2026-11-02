
Imports Microsoft.Data.SqlClient

Module Database

    Public connectionString As String =
        "Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=GBStationDB;Integrated Security=True"

    Public Sub CreateDatabase()


        Try
            Using con As New SqlConnection(
                "Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True")

                con.Open()

                Dim sql As String =
                    "IF DB_ID('GBStationDB') IS NULL CREATE DATABASE GBStationDB"

                Using cmd As New SqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                End Using

            End Using

            Using con As New SqlConnection(connectionString)

                con.Open()


                ' Create Products table
                Dim sql1 As String =
    "IF OBJECT_ID('Products','U') IS NULL " &
    "CREATE TABLE Products (" &
    "ProductID INT IDENTITY(1,1) PRIMARY KEY, " &
    "ProductName VARCHAR(100), " &
    "Category VARCHAR(50), " &
    "Price DECIMAL(10,2), " &
    "Quantity INT)"

                Using cmd As New SqlCommand(sql1, con)
                    cmd.ExecuteNonQuery()
                End Using

                ' Create Customers table
                Dim sql2 As String =
    "IF OBJECT_ID('Customers','U') IS NULL " &
    "CREATE TABLE Customers (" &
    "CustomerID INT IDENTITY(1,1) PRIMARY KEY, " &
    "CustomerName VARCHAR(100), " &
    "Phone VARCHAR(20))"

                Using cmd As New SqlCommand(sql2, con)
                    cmd.ExecuteNonQuery()
                End Using


            End Using

            MsgBox("Database created successfully!")

        Catch ex As Exception

            MsgBox("Database Error: " & ex.Message)

        End Try

    End Sub

End Module
