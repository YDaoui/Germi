Imports MySql.Data.MySqlClient
Imports System.IO
Imports MaterialSkin


Public Class Stock


    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New MySqlConnection

        Dim myconnection As String = "server=localhost;userid=root;password=;database=germaroc"
        Dim cmd As New MySqlCommand

        Dim skinmanager As MaterialSkin.MaterialSkinManager = MaterialSkinManager.Instance

        skinmanager.AddFormToManage(Me)


        skinmanager.Theme = MaterialSkinManager.Themes.DARK
        skinmanager.ColorScheme = New ColorScheme(Primary.Red400, Primary.Grey800, Primary.Teal400, Accent.Teal400, TextShade.BLACK)

        liste_Stock.Columns.Add("Code Barre", 150)
        liste_Stock.Columns.Add("Marque", 150)
        liste_Stock.Columns.Add("Désignation", 360)
        liste_Stock.Columns.Add("Prix de Vente", 120)

        liste_Stock.Columns.Add("Stock", 80)
        liste_Stock.Columns.Add("Calibre", 120)

        Dim mysqlconn As MySqlConnection
        mysqlconn = New MySqlConnection

        mysqlconn.ConnectionString =
               "server=localhost;userid=root;password=;database=germaroc"
        Try

            mysqlconn.Open()

            cmd.CommandText = "select * from Article"
            cmd.CommandType = CommandType.Text
            cmd.Connection = mysqlconn
            Dim ds As MySqlDataReader = cmd.ExecuteReader()

            While ds.Read

                If Combo_Marque.Items.Contains(ds.Item(3).ToString) Then

                Else

                    Combo_Marque.Items.Add(ds.Item(3)) ' & "              " & ds.Item(3))
                End If

            End While

            ds.Close()

            cmd.ExecuteNonQuery()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

            mysqlconn.Close()

        Finally
            mysqlconn.Dispose()


        End Try



    End Sub

    Private Sub MaterialRaisedButton8_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton8.Click
        Me.Close()

    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click




        Dim mysqlconn As MySqlConnection
        mysqlconn = New MySqlConnection


        mysqlconn.ConnectionString =
                   "server=localhost;userid=root;password=;database=germaroc"
        Try
            mysqlconn.Open()
            Dim cmd As New MySqlCommand
            Dim cmd1 As New MySqlCommand

            cmd.CommandText = "select * from Article " ' WHERE Id_commande = '" + txt_Tel.Text + "'" ' where compte ='Dirécte Energie' and profil = 'Agent' and roa = 'Raid'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = mysqlconn

            Dim ds As MySqlDataReader = cmd.ExecuteReader()
            ' liste_article.Clear()

            While ds.Read()

                Dim element As New ListViewItem
                liste_Stock.Items.Add(New ListViewItem({ds(0).ToString, ds(3).ToString, ds(2).ToString, ds(10).ToString, ds(6).ToString, ds(7).ToString}))





            End While
            ds.Close()
            cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

            mysqlconn.Close()



        Finally
            mysqlconn.Dispose()
            '  GroupBoxGuest.Visible = False




        End Try

        Dim total, total1 As Double
        total = 0
        total1 = 0

        For i As Integer = 0 To liste_Stock.Items.Count - 1 Step +1

            total += CInt(liste_Stock.Items(i).SubItems(4).Text)
            total1 += CInt(liste_Stock.Items(i).SubItems(3).Text)
        Next


        txt_Stock.Text = total

        txt_Total.Text = total1
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click


    End Sub

    Private Sub liste_Stock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles liste_Stock.SelectedIndexChanged
        Dim mysqlconn As MySqlConnection
        mysqlconn = New MySqlConnection

        mysqlconn.ConnectionString =
                   "server=localhost;userid=root;password=;database=germaroc"
        Try
            mysqlconn.Open()

            If liste_Stock.SelectedItems.Count > 0 Then
                Dim Text As String
                Text = (liste_Stock.SelectedItems(0).SubItems(0).Text)
                NewProduit.Show()

                Dim cmd1 As New MySqlCommand
                cmd1.CommandText = "select * from Article where Codbare ='" + Text + "' "

                cmd1.CommandType = CommandType.Text
                cmd1.Connection = mysqlconn
                Dim dr As MySqlDataReader = cmd1.ExecuteReader()
                dr.Read()



                NewProduit.Txt_Prix.Text = dr(10).ToString
                    NewProduit.Txt_Stock.Text = dr(6)
                    NewProduit.Txt_Marque.Text = dr(3)
                    NewProduit.Txt_Marge.Text = dr(9)
                    NewProduit.Txt_Pack.Text = dr(1)
                    NewProduit.Txt_des.Text = dr(2).ToString
                    NewProduit.Txt_Des_Alm.Text = dr(4).ToString
                    NewProduit.Txt_Calibre.Text = dr(7).ToString
                    NewProduit.Txt_Achat.Text = dr(8).ToString
                    NewProduit.Txt_Prix.Text = dr(5).ToString
                    NewProduit.txt_Prix_vente.Text = dr(10).ToString
                Dim img() As Byte
                img = dr(11)
                If img.Length = 0 Then
                    MsgBox("Aucune Image à afficher !")
                    NewProduit.PictureBox2.Image = Nothing

                    MaterialRaisedButton1.Visible = True
                    MaterialRaisedButton2.Visible = True

                Else
                    MaterialRaisedButton1.Visible = False
                    MaterialRaisedButton2.Visible = False


                    Dim ms As New MemoryStream(img)
                    NewProduit.PictureBox2.Image = Image.FromStream(ms)
                End If
                If NewProduit.Txt_Stock.Text = 0 Then
                    MsgBox("Attention :  Stock épuisé ! ")
                Else
                    MsgBox(dr(6).ToString, vbInformation, vbYes)

                End If
                '  MsgBox("Aucune Image à afficher !")

                ' GroupBox1.Visible = False

                dr.Close()
                cmd1.ExecuteNonQuery()
            End If


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

                mysqlconn.Close()



        Finally
            mysqlconn.Dispose()
            '  GroupBoxGuest.Visible = False




        End Try

    End Sub

    Private Sub Combo_Marque_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_Marque.SelectedIndexChanged

        liste_Stock.Items.Clear()


        Dim mysqlconn As MySqlConnection
        mysqlconn = New MySqlConnection


        mysqlconn.ConnectionString =
                   "server=localhost;userid=root;password=;database=germaroc"
        Try
            mysqlconn.Open()
            Dim cmd As New MySqlCommand
            Dim cmd1 As New MySqlCommand

            cmd.CommandText = "select * from Article WHERE marque = '" + Combo_Marque.Text + "'" ' where compte ='Dirécte Energie' and profil = 'Agent' and roa = 'Raid'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = mysqlconn

            Dim ds As MySqlDataReader = cmd.ExecuteReader()
            ' liste_article.Clear()

            While ds.Read()

                Dim element As New ListViewItem
                liste_Stock.Items.Add(New ListViewItem({ds(0).ToString, ds(3).ToString, ds(2).ToString, ds(10).ToString, ds(6).ToString, ds(7).ToString}))





            End While
            ds.Close()
            cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

            mysqlconn.Close()



        Finally
            mysqlconn.Dispose()
            '  GroupBoxGuest.Visible = False




        End Try

        Dim total, total1 As Double
        total = 0
        total1 = 0

        For i As Integer = 0 To liste_Stock.Items.Count - 1 Step +1

            total += CInt(liste_Stock.Items(i).SubItems(4).Text)
            total1 += CInt(liste_Stock.Items(i).SubItems(3).Text)
        Next


        txt_Stock.Text = total

        txt_Total.Text = total1
    End Sub
End Class