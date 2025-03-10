Imports MySql.Data.MySqlClient
Imports System.IO
Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class Suivi





    Dim conn As New MySqlConnection

    Dim myconnection As String = "server=localhost;userid=root;password=;database=germaroc"
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrimage() As Byte
    Dim sql As String


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim skinmanager As MaterialSkin.MaterialSkinManager = MaterialSkinManager.Instance


        skinmanager.AddFormToManage(Me)


        skinmanager.Theme = MaterialSkinManager.Themes.DARK


        skinmanager.ColorScheme = New ColorScheme(Primary.Blue600, Primary.Grey800, Primary.Teal400, Accent.Teal400, TextShade.BLACK)
        ' List_Action.Columns.Add("Total", 100)
        ' list_action.Columns.Add("Avance", 100)
        '  list_action.Columns.Add("Reste", 100)
        '  list_action.Columns.Add("Action", 155)
        '  list_action.Columns.Add("Livraison", 160)
        '  list_action.Columns.Add("Commentaire", 220)
        '  list_action.Columns.Add("Date Action", 160)



        Combo_Livraison.Items.Add("Livraison Prévue")
        Combo_Livraison.Items.Add("Livrée")
        Combo_Paiement.Items.Add("Achat")
        Combo_Paiement.Items.Add("Paiement En Cours")
        Combo_Paiement.Items.Add("Payée")
        Combo_Paiement.Items.Add("Annulée")


    End Sub



    Private Sub MaterialRaisedButton8_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton8.Click
        Me.Close()

    End Sub



    Private Sub Combo_Paiement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_Paiement.SelectedIndexChanged


    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Dim mysqlconn As MySqlConnection
        mysqlconn = New MySqlConnection


        mysqlconn.ConnectionString =
                   "server=localhost;userid=root;password=;database=germaroc"


        Try
            mysqlconn.Open()
            Dim cmd As New MySqlCommand
            Dim cmd1 As New MySqlCommand

            cmd.CommandText = "select * from action" ' WHERE action = '" + Combo_Paiement.Text + "'" ' where compte ='Dirécte Energie' and profil = 'Agent' and roa = 'Raid'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = mysqlconn

            Dim dr1 As MySqlDataReader = cmd.ExecuteReader()



            While dr1.Read
                MsgBox(dr1.Item(2).ToString)

                Dim element As New ListViewItem
                list_action.Items.Add(New ListViewItem({dr1.Item(2).ToString, dr1.Item(3).ToString, dr1.Item(4).ToString, dr1.Item(5).ToString, dr1.Item(6).ToString, dr1.Item(7).ToString, dr1.Item(8).ToString}))
1
            End While

            dr1.Close()
            list_action.Visible = True

            cmd.ExecuteNonQuery()





        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

            mysqlconn.Close()
            ' GroupBoxGuest.Visible = False
            '
        Finally
            mysqlconn.Dispose()

        End Try

    End Sub
End Class