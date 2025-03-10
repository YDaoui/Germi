Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        '   Public Class Form1
        ' Imports MySql.Data.MySqlClient


        ' Dim con As New MySqlconnection


        ' Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim mysqlconn As MySqlConnection
        mysqlconn = New MySqlConnection

        mysqlconn.ConnectionString =
          "server=localhost;userid=root;password=;database=germaroc"
        Try

            mysqlconn.Open()

            Dim cmd As New MySqlCommand
            cmd.CommandText = "select * from users"

            cmd.CommandType = CommandType.Text
            cmd.Connection = mysqlconn
            Dim dr As MySqlDataReader = cmd.ExecuteReader()


            While dr.Read
                ' ComboBox1.Items.Add(dr.Item(3))

            End While


            dr.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

            mysqlconn.Close()

        Finally
            mysqlconn.Dispose()


        End Try




    End Sub
End Class

End Sub
End Class