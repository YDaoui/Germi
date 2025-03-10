Imports MySql.Data.MySqlClient
Imports System.IO
Imports MaterialSkin
Imports System.Data




'Imports MaterialSkin.Controls

Public Class Demande

    Dim conn As New MySqlConnection

    Dim myconnection As String = "server=localhost;userid=root;password="YDaoui2303";database=germaroc"
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrimage() As Byte
    Dim sql As String



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysqlconn As MySqlConnection
        mysqlconn = New MySqlConnection


        Liste_PanierCommandeDetails.Columns.Add("Désignation", 350, HorizontalAlignment.Center)

        Liste_PanierCommandeDetails.Columns.Add("Prix", 125)

        Liste_PanierDeCommande.Columns.Add("Id_Panier", 0)
        Liste_PanierDeCommande.Columns.Add("Id_Commande", 0)
        Liste_PanierDeCommande.Columns.Add("Code Barre", 180)
        Liste_PanierDeCommande.Columns.Add("Unités", 100)
        Liste_PanierDeCommande.Columns.Add("Commentaire", 166)
        '  Liste_PanierDeCommande.Columns.Add("Désignation", 150)
        '  Liste_PanierDeCommande.Columns.Add("Prix", 80)

        Liste_Action.Columns.Add("Total", 100)
        Liste_Action.Columns.Add("Avance", 100)
        Liste_Action.Columns.Add("Reste", 100)
        Liste_Action.Columns.Add("Action", 150)
        Liste_Action.Columns.Add("Livraison", 150)
        Liste_Action.Columns.Add("Commentaire", 156)
        Liste_Action.Columns.Add("Date Action", 161)

        '  liste_PanierColumnHeadersdefautcellstyle.font =
        'New Font("tahoma", 20, FontStyle.Bold)
        Liste_Panier.Columns.Add("CodeBarre", 100)
        Liste_Panier.Columns.Add("Désignation", 265)
        Liste_Panier.Columns.Add("Prix", 60)
        Liste_Panier.Columns.Add("Unités", 80)
        Liste_Panier.Columns.Add("Total", 60)




        liste_Commande.Columns.Add("Date", 150)
        liste_Commande.Columns.Add("Canal", 100)
        liste_Commande.Columns.Add("Total", 80)
        liste_Commande.Columns.Add("Id_Commande", 20)


        Liste_CommandeAction.Columns.Add("Reste", 105)
        Liste_CommandeAction.Columns.Add("Paiement", 150)
        Liste_CommandeAction.Columns.Add("Livraison", 150)
        Liste_CommandeAction.Columns.Add("Date Action", 162)

        Autosearsh()
        btn_ajouter_panier.Visible = True
        Radio_Liv_Prevue.Select()

        Dim skinmanager As MaterialSkin.MaterialSkinManager = MaterialSkinManager.Instance


        skinmanager.AddFormToManage(Me)


        skinmanager.Theme = MaterialSkinManager.Themes.DARK
        skinmanager.ColorScheme = New ColorScheme(Primary.Grey600, Primary.Grey800, Primary.Teal400, Accent.Teal400, TextShade.BLACK)

        Combo_Canal.Items.Add("FaceBook")
        Combo_Canal.Items.Add("Instagram")
        Combo_Canal.Items.Add("Autre")
        Combo_Canal.Text = "Autre"
        ' txt_Statut.Text = "Autre"


        Dim conn As New MySqlConnection

        Dim myconnection As String = "server=localhost;userid=root;password=;database=germaroc"
        Dim cmd As New MySqlCommand


        Try

            mysqlconn.Open()


            cmd.CommandText = "Select * from article" ' where compte ='Dirécte Energie' and profil = 'Agent' and roa = 'Raid'"

            cmd.CommandType = CommandType.Text
            cmd.Connection = mysqlconn
            Dim dr As MySqlDataReader = cmd.ExecuteReader()


            While dr.Read

                Combo_des.Items.Add(dr.Item(2))



            End While


            dr.Close()

            cmd.CommandText = "select * from Guest"
            cmd.CommandType = CommandType.Text
            cmd.Connection = mysqlconn
            Dim ds As MySqlDataReader = cmd.ExecuteReader()

            While ds.Read

                Combo_Guest.Items.Add(ds.Item(1)) ' & "              " & ds.Item(3))

            End While

            ds.Close()
            Combo_Guest.Items.Add("Nouveau")
            cmd.ExecuteNonQuery()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

            mysqlconn.Close()

        Finally
            mysqlconn.Dispose()


        End Try




    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_des.SelectedIndexChanged
        Txt_Unites.Text = ""
        Dim mysqlconn As MySqlConnection
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString =
              "server=localhost;userid=root;password=;database=germaroc"
        Try
            mysqlconn.Open()
            Dim cmd As New MySqlCommand
            cmd.CommandText = "select * from article where designation ='" + Combo_des.Text + "'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = mysqlconn
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            dr.Read()
            txt_Prix.Text = dr(5).ToString
            txt_Stock.Text = dr(6)
            txt_Marge.Text = dr(9)
            Txt_codbare.Text = dr(0)
            txt_prix_vente.Text = dr(10).ToString
            Dim img() As Byte
            img = dr(11)
            If img.Length = 0 Then
                MsgBox("Aucune Image à afficher !")
                PictureBox2.Image = Nothing

                MaterialRaisedButton1.Visible = True
                MaterialRaisedButton2.Visible = True

            Else
                MaterialRaisedButton1.Visible = False
                MaterialRaisedButton2.Visible = False


                Dim ms As New MemoryStream(img)
                PictureBox2.Image = Image.FromStream(ms)
            End If
            dr.Close()
            cmd.ExecuteNonQuery()
            GroupBoxArticle.Visible = True


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

            mysqlconn.Close()
            GroupBoxArticle.Visible = False


        Finally
            mysqlconn.Dispose()

            '  GroupBoxArticle.Visible = False


        End Try


        Txt_Unites.Text = "1"
    End Sub
    Sub Autosearsh()
        Dim mysqlconn As MySqlConnection
        mysqlconn = New MySqlConnection
        On Error Resume Next

        mysqlconn.ConnectionString =
                   "server=localhost;userid=root;password=;database=germaroc"
        mysqlconn.Open()

        Dim cmd As New MySqlCommand("Select  * From article", mysqlconn)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cmd)

        da.Fill(ds, "designation")
        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1

            col.Add(ds.Tables(0).Rows(i)("designation").ToString)
        Next
        mysqlconn.Close()
        Combo_des.AutoCompleteSource = AutoCompleteSource.CustomSource
        Combo_des.AutoCompleteCustomSource = col
        Combo_des.AutoCompleteMode = AutoCompleteMode.Suggest


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        End
    End Sub


    Private Sub liste_Commande_SelectedIndexChanged(sender As Object, e As EventArgs) Handles liste_Commande.SelectedIndexChanged

        '  Liste_CommandeAction.Items.Clear()
        Liste_PanierDeCommande.Items.Clear()
        Liste_PanierCommandeDetails.Items.Clear()

        '  Dim index As Integer
        Dim mysqlconn As MySqlConnection
        mysqlconn = New MySqlConnection

        mysqlconn.ConnectionString =
                   "server=localhost;userid=root;password=;database=germaroc"
        Try
            mysqlconn.Open()
            Dim lv As ListView = liste_Commande
            If lv.SelectedItems.Count > 0 Then

                Dim index As Integer = liste_Commande.SelectedItems(0).Index
                Dim Text As String = liste_Commande.SelectedItems(0).SubItems(3).Text

                txt_id_cmd.Text = Text.ToString


                Dim cmd1 As New MySqlCommand
                cmd1.CommandText = "select * from Panier where id_commande ='" + Text + "' "
                Liste_PanierDeCommande.Items.Clear()
                cmd1.CommandType = CommandType.Text
                cmd1.Connection = mysqlconn
                Dim dr1 As MySqlDataReader = cmd1.ExecuteReader()
                While dr1.Read
                    Dim element As New ListViewItem
                    Liste_PanierDeCommande.Items.Add(New ListViewItem({dr1.Item(0).ToString, dr1.Item(1).ToString, dr1.Item(2).ToString, dr1.Item(3).ToString, dr1.Item(4).ToString}))
                End While
                dr1.Close()
                cmd1.ExecuteNonQuery()
                Liste_PanierDeCommande.Visible = True
                Liste_PanierCommandeDetails.Items.Clear()
                Dim id_searsh As String
                For i As Integer = 0 To Liste_PanierDeCommande.Items.Count - 1
                    id_searsh = Liste_PanierDeCommande.Items(i).SubItems(2).Text
                    Dim cmd As New MySqlCommand
                    cmd.CommandText = "select * from article where codbare ='" + id_searsh.ToString + "'"
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = mysqlconn
                    Dim dr As MySqlDataReader = cmd.ExecuteReader()
                    dr.Read()
                    Liste_PanierCommandeDetails.Items.Add(New ListViewItem({dr.Item(2).ToString, dr.Item(10).ToString}))
                    dr.Close()
                    cmd.ExecuteNonQuery()
                Next
                Liste_PanierCommandeDetails.Visible = True
                Liste_Action.Items.Clear()
                Dim cmd2 As New MySqlCommand
                cmd2.CommandText = "select * from Action where id_commande ='" + Text + "' "
                cmd2.CommandType = CommandType.Text
                cmd2.Connection = mysqlconn
                Dim dr2 As MySqlDataReader = cmd2.ExecuteReader()
                While dr2.Read
                    Liste_Action.Items.Add(New ListViewItem({dr2.Item(2).ToString, dr2.Item(3).ToString, dr2.Item(4).ToString, dr2.Item(5).ToString, dr2.Item(6).ToString, dr2.Item(7).ToString, dr2.Item(8).ToString}))
                End While
                dr2.Close()
                cmd2.ExecuteNonQuery()

                GroupBox4.Visible = True
        Liste_Action.Visible = True
        End If

        Catch ex As MySqlException
        MessageBox.Show(ex.Message)
        mysqlconn.Close()
        Finally
        mysqlconn.Dispose()
        End Try
    End Sub






    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Try

            Dim ofd As FileDialog = New OpenFileDialog()

            ofd.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

            If ofd.ShowDialog() = DialogResult.OK Then

                imgpath = ofd.FileName

                PictureBox2.ImageLocation = imgpath

            End If

            ofd = Nothing



        Catch ex As Exception
            MsgBox(ex.Message.ToString())

        End Try


    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Try
            Dim mstream As New System.IO.MemoryStream()
            PictureBox2.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length

            mstream.Close()
            conn.ConnectionString = myconnection
            conn.Open()

            sql = "UPDATE article SET Img = @img WHERE codbare = '" + Txt_codbare.Text + "' "
            cmd.Connection = conn
            cmd.CommandText = sql

            cmd.Parameters.AddWithValue("@img", arrimage)
            Dim r As Integer
            r = cmd.ExecuteNonQuery()
            If r > 0 Then
                MsgBox("Student Record hass been Saved!")
            Else
                MsgBox("No record has been saved!")
            End If
            cmd.Parameters.Clear()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub



    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton4.Click
        Dim Total As Double
        Total = 0
        For i As Integer = 0 To Liste_Panier.Items.Count - 1 '- 1
            Dim Text As String = Liste_Panier.Items(i).SubItems(4).Text
            Total = Total + Text
        Next

        Dim myconnection As New MySqlConnection
        myconnection.ConnectionString = "server=localhost;Database=germaroc;Userid=root;Pwd=;"

        myconnection.Open()

        Dim cmd As MySqlCommand
        Dim cmd2 As MySqlCommand
        Dim cmdd As MySqlCommand

        Try
            ' Dim Act As String = Now
            cmd = myconnection.CreateCommand
            cmd.CommandText = " insert into Commande(Id_Guest,Date_Commande,Canal,Total)VALUE ( @Id_Guest,@Date_Commande,@Canal,@Total) "
            cmd.Parameters.AddWithValue("@ID_guest", txt_Id_Guest.Text)
            cmd.Parameters.AddWithValue("@Date_Commande", Now) 'And Txt_Prenom.Text)
            cmd.Parameters.AddWithValue("@Canal", Combo_Canal.Text)
            cmd.Parameters.AddWithValue("@Total", Total)
            '  cmd.Parameters.ToString("@id_commande", txt_id_cmd)
            cmd.ExecuteNonQuery()


            Dim cmd1 As MySqlCommand
            cmd1 = myconnection.CreateCommand
            cmd1.CommandText = "select max(id_commande) from commande where id_guest = '" + txt_Id_Guest.Text + "'" ' where compte ='Dirécte Energie' and profil = 'Agent' and roa = 'Raid'"

            cmd1.CommandType = CommandType.Text
            cmd1.Connection = myconnection

            Dim ds As MySqlDataReader = cmd1.ExecuteReader()
            ds.Read()
            txt_id_cmd.Text = ds(0)
            ds.Close()
            cmd1.ExecuteNonQuery()

            cmdd = myconnection.CreateCommand
            cmdd.CommandText = " insert into Action(Id_Commande,Total,Avance,Reste,Action,Livraison,Commentaire,DateAction)VALUE ( @Id_Commande,@Total,@Avance,@Reste,@Action,@Livraison,@Commentaire,@DateAction) "
            cmdd.Parameters.AddWithValue("@Id_Commande", txt_id_cmd.Text)

            cmdd.Parameters.AddWithValue("@Total", Total)
            cmdd.Parameters.AddWithValue("@Avance", "")
            Total = Total - (Total * 2)
            cmdd.Parameters.AddWithValue("@Reste", Total)
            cmdd.Parameters.AddWithValue("@Action", "Achat") 'And Txt_Prenom.Text)
            If Radio_Liv_Prevue.Checked = True Then
                cmdd.Parameters.AddWithValue("@Livraison", "Livraison Prévue")
            Else
                cmdd.Parameters.AddWithValue("@Livraison", "Livraison à l'Achat")
            End If
            cmdd.Parameters.AddWithValue("@Commentaire", txt_Commentaire.Text)
            cmdd.Parameters.AddWithValue("@DateAction", Now)
            cmdd.ExecuteNonQuery()
            Dim T As Integer
            For j As Integer = 0 To Liste_Panier.Items.Count - 1 '- 1
                MsgBox(Liste_Panier.Items(j).SubItems(3).ToString)
                cmd2 = myconnection.CreateCommand

                cmd2.CommandText = " insert into Panier(Id_Commande,Codbare,Unites,commentaire)VALUE ( @Id_Commande,@Codbare,@Unites,@commentaire) "
                cmd2.Parameters.AddWithValue("@Id_Commande", txt_id_cmd.Text.ToString())
                cmd2.Parameters.AddWithValue("@Codbare", Liste_Panier.Items(j).SubItems(0).Text.ToString())
                cmd2.Parameters.AddWithValue("@Unites", Liste_Panier.Items(j).SubItems(3).Text.ToString)
                cmd2.Parameters.AddWithValue("@Commentaire", txt_Commentaire.Text.ToString())
                cmd2.ExecuteNonQuery()

            Next
            Dim R As Integer
            Dim Ref As String
            For R = 0 To Liste_Panier.Items.Count - 1
                Ref = Liste_Panier.Items(R).SubItems(0).Text.ToString
                Dim cmd4 As New MySqlCommand
                cmd4.CommandText = "select * from article where codbare ='" + Ref + "'"
                cmd4.CommandType = CommandType.Text
                cmd4.Connection = myconnection
                Dim drS As MySqlDataReader = cmd4.ExecuteReader()
                Dim stok As Integer
                stok = 0
                drS.Read()
                stok = drS(6).ToString
                stok = stok - Liste_Panier.Items(R).SubItems(3).Text

                drS.Close()
                cmd4.ExecuteNonQuery()
                Dim cmdS As MySqlCommand
                cmdS = myconnection.CreateCommand
                cmdS.CommandType = CommandType.Text
                cmdS.CommandText = " update article set stock ='" + stok.ToString + "'where codbare =  '" + Ref.ToString + " '"
                cmdS.ExecuteNonQuery()
            Next
            MsgBox("Mise a jour faite : !")


        Catch ex As MySqlException
        MessageBox.Show(ex.Message)
        myconnection.Close()
        Finally
        myconnection.Dispose()
        End Try
    End Sub


    Private Sub MaterialRaisedButton7_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton7.Click
        DataGridView1.Rows.Clear()
        DataGridView1.Visible = False
        GroupBox2.Visible = False
        liste_Panier.Clear()
        liste_Panier.Items.Clear()
        liste_Panier.Columns.Add("CodeBarre", 120)
        liste_Panier.Columns.Add("Désignation", 300)
        liste_Panier.Columns.Add("Prix", 80)
        liste_Panier.Columns.Add("Unités", 50)
        Liste_Panier.Columns.Add("Total", 100)



    End Sub

    Private Sub MaterialRaisedButton6_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton6.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
            Dim Total As Double
            For i As Integer = 0 To DataGridView1.RowCount - 1
                Total += DataGridView1.Rows(i).Cells(4).Value

            Next
            txt_Total.Text = Total.ToString

        Next
    End Sub

    Private Sub MaterialRaisedButton8_Click(sender As Object, e As EventArgs)
        New_Guest.Show()

    End Sub



    Private Sub MaterialRaisedButton5_Click_1(sender As Object, e As EventArgs) Handles MaterialRaisedButton5.Click
        NewProduit.Show()
    End Sub

    Private Sub MaterialRaisedButton3_Click_1(sender As Object, e As EventArgs) Handles btn_ajouter_panier.Click
        Dim tot As Integer

        If txt_Id_Guest.Text = "" Or Txt_codbare.Text = "" Or Combo_des.Text = "" Or txt_Prix.Text = "" Or Txt_Unites.Text = "" Then
            MsgBox("Merci de compléter la saisie !")
        ElseIf txt_Stock.Text = "0" Or txt_Stock.Text.ToString - Txt_Unites.Text.ToString < 0 Then
            MsgBox("En rupture de Stock !")
        Else
            Dim item As ListViewItem
            If liste_Panier.Items.Count = 0 Then
                tot = txt_prix_vente.Text.ToString * Txt_Unites.Text.ToString
                Dim element As ListViewItem
                Liste_Panier.Items.Add(New ListViewItem({Txt_codbare.Text, Combo_des.Text, txt_prix_vente.Text.ToString, Txt_Unites.Text, tot.ToString}))
                tot = 0
            Else
                With liste_Panier
                    item = .FindItemWithText(Combo_des.Text, True, 0, True)
                    If Not item Is Nothing Then
                        MsgBox("Article déja ajouté !")
                        MsgBox(item.Text)
                    Else
                        tot = txt_prix_vente.Text.ToString * Txt_Unites.Text.ToString
                        Liste_Panier.Items.Add(New ListViewItem({Txt_codbare.Text, Combo_des.Text, txt_prix_vente.Text.ToString, Txt_Unites.Text, tot.ToString}))
                        tot = 0
                    End If
                End With
            End If
            Dim Total_Panier As Double = 0
            For i As Integer = 0 To Liste_Panier.Items.Count - 1 '- 1


                Dim Text As String = Liste_Panier.Items(i).SubItems(4).Text

                Total_Panier = Total_Panier + Text


            Next

            txt_Total.Text = total_Panier

            Liste_Panier.Visible = True
            GroupBox2.Visible = True
            '




        End If
        '  End If
    End Sub

    Private Sub btn_quitter_Click(sender As Object, e As EventArgs)
        End
        Dim Iexite As DialogResult
        Iexite = MessageBox.Show("Confirmation", "System down", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Iexite = DialogResult.Yes Then

        End If

    End Sub

    Private Sub Combo_Guest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_Guest.SelectedIndexChanged
        Dim mysqlconn As MySqlConnection
        mysqlconn = New MySqlConnection


        mysqlconn.ConnectionString =
                   "server=localhost;userid=root;password=;database=germaroc"

        Liste_PanierDeCommande.Items.Clear()
        Liste_Action.Items.Clear()
        Liste_PanierCommandeDetails.Items.Clear()
        liste_Commande.Items.Clear()
        Liste_CommandeAction.Items.Clear()

        GroupBox4.Visible = False

        Liste_PanierDeCommande.Visible = False
        Liste_Action.Visible = False
        Liste_PanierCommandeDetails.Visible = False
        liste_Commande.Visible = False
        Liste_CommandeAction.Visible = False


        Try
            mysqlconn.Open()
            Dim cmd As New MySqlCommand
            Dim cmd1 As New MySqlCommand

            cmd.CommandText = "select * from Guest WHERE nom = '" + Combo_Guest.Text + "'" ' where compte ='Dirécte Energie' and profil = 'Agent' and roa = 'Raid'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = mysqlconn

            Dim ds As MySqlDataReader = cmd.ExecuteReader()
            ds.Read()
            txt_Id_Guest.Text = ds(0)
            ds.Close()
            cmd.ExecuteNonQuery()

            cmd1.CommandText = "select * from commande where id_Guest ='" + txt_Id_Guest.Text + "' "


            cmd1.CommandType = CommandType.Text
            cmd1.Connection = mysqlconn
            Dim dr1 As MySqlDataReader = cmd1.ExecuteReader()



            While dr1.Read

                Dim element As New ListViewItem
                Liste_Commande.Items.Add(New ListViewItem({dr1.Item(2).ToString, dr1.Item(3).ToString, dr1.Item(4).ToString, dr1.Item(0).ToString}))


            End While

            dr1.Close()

            cmd1.ExecuteNonQuery()

            Dim id_searsh As String
            Dim id_searsh_action As String
            Dim cmd2 As New MySqlCommand

            For i As Integer = 0 To liste_Commande.Items.Count - 1 '- 1
                id_searsh = liste_Commande.Items(i).SubItems(3).Text

                ' mysqlconn.Open()
                ' MsgBox(id_searsh)
                cmd2.CommandText = "select max(Id_Action)from Action where id_commande ='" + id_searsh + "' "
                cmd2.CommandType = CommandType.Text
                cmd2.Connection = mysqlconn
                Dim dr As MySqlDataReader = cmd2.ExecuteReader()

                dr.Read()
                id_searsh_action = dr(0).ToString
                dr.Close()
                cmd2.ExecuteNonQuery()


                ' MsgBox(id_searsh_action)
                Dim cmd3 As New MySqlCommand
                cmd3.CommandText = "select *from Action where id_Action ='" + id_searsh_action + "' "
                cmd3.CommandType = CommandType.Text
                cmd3.Connection = mysqlconn
                Dim dr2 As MySqlDataReader = cmd3.ExecuteReader()

                dr2.Read()

                Dim element1 As New ListViewItem
                Liste_CommandeAction.Items.Add(New ListViewItem({dr2.Item(4).ToString, dr2.Item(5).ToString, dr2.Item(6).ToString, dr2.Item(8).ToString}))

                dr2.Close()
                cmd3.ExecuteNonQuery()



            Next

            ' id_searsh = Nothing


            Dim Total As Double
            Total = 0

            For j As Integer = 0 To Liste_CommandeAction.Items.Count - 1 '- 1

                Dim Text As String = Liste_CommandeAction.Items(j).SubItems(0).Text
                Total = Total + Text


            Next
            If Total < 0 Then



                Label_Solde.ForeColor = Color.Red
                txt_Solde.ForeColor = Color.Red
            Else
                Label_Solde.ForeColor = Color.White
                txt_Solde.ForeColor = Color.White
            End If

            txt_Solde.Text = Total

            Liste_CommandeAction.Visible = True


            liste_Commande.Visible = True
            Liste_CommandeAction.Visible = True

            GroupBoxGuest.Visible = True

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

            mysqlconn.Close()
            GroupBoxGuest.Visible = False

        Finally
            mysqlconn.Dispose()

        End Try



    End Sub

    Private Sub btn_reglement_Click(sender As Object, e As EventArgs)


        Dim Total, Reste, Avance As Double
        'MsgBox(txt_cmd_Action.Text)

        If txt_Avance.Text = "0" Or txt_Avance.Text = "" Then
            MsgBox("Merci de mettre une avance ")
            btn_reglement.Visible = False
        Else


            For i As Integer = 0 To DatagridCommande.RowCount - 2
                '4 reste 
                ' MsgBox(DatagridCommande.Rows(i).Cells(4).Value)
                '5 Action 
                '  MsgBox(DatagridCommande.Rows(i).Cells(5).Value)

                '3 Id_Commande 
                If DatagridCommande.Rows(i).Cells(3).Value = txt_cmd_Action.Text Then
                    ' MsgBox(DatagridCommande.Rows(i).Cells(4).Value)
                    Reste = DatagridCommande.Rows(i).Cells(4).Value.ToString
                    Avance = txt_Avance.Text.ToString
                    Total = Reste + Avance

                    If Total >= 0 Then
                        MsgBox(Total)
                    Else
                        MsgBox(Total)
                    End If
                End If



                'mysqlconn.ConnectionString =
                '                   "server=localhost;userid=root;password=;database=germaroc"
                '       Try

                ' mysqlconn.Open()
            Next


            '   cmd.CommandText = "select * from Action where id_commande ='" + txt_cmd_Action.Text + "' "
            '  cmd.CommandType = CommandType.Text
            ' cmd.Connection = mysqlconn

            ' cmd = mysqlconn.CreateCommand
            ' cmd.CommandText = " insert into Action(Id_Commande,Total,Avance,Reste,Action,Livraison,Commentaire,DateAction)VALUE ( @Id_Commande,@Total,@Avance,@Reste,@Action,@Livraison,@Commentaire,@DateAction) "
            ' cmd.Parameters.AddWithValue("@Id_Commande", txt_cmd_Action.Text)

            ' cmd.Parameters.AddWithValue("@Total", DataGridAction.Rows(i).Cells(2).Value) 'And Txt_Prenom.Text)
            ' cmd.Parameters.AddWithValue("@Avance", txt_Avance.Text)
            'MsgBox(DataGridAction.Rows(i).Cells(4).Value.ToString)

            ' reste += DataGridAction.Rows(i).Cells(4).Value
            ' reste = reste + txt_Avance.Text.ToString

            '  MsgBox(reste)
            ' If reste >= 0 Then

            ' cmd.Parameters.AddWithValue("@Reste", "")
            'cmd.Parameters.AddWithValue("@Action", "Payée")

            'If Radio_Liv_Prevue.Checked = True Then
            'cmd.Parameters.AddWithValue("@Livraison", "Livraison Prévue")
            'Else
            'cmd.Parameters.AddWithValue("@Livraison", "Livrée au Réglement")
        End If
        '                  cmd.Parameters.AddWithValue("@Commentaire", Txt_Commentaire_regelement.Text)
        ' cmd.Parameters.AddWithValue("@DateAction", Now)
        'cmd.ExecuteNonQuery()
        'txt_Avance.Text = reste
        'Else
        '                cmd.Parameters.AddWithValue("@Action", "En Avance")
        'cmd.Parameters.AddWithValue("@Reste", reste.ToString)
        'If Radio_Liv_Prevue.Checked = True Then
        'cmd.Parameters.AddWithValue("@Livraison", "Livraison Prévue")
        'Else
        'cmd.Parameters.AddWithValue("@Livraison", "Livrée suite à une Avance")
        'End If
        'cmd.Parameters.AddWithValue("@Commentaire", Txt_Commentaire_regelement.Text)
        'cmd.Parameters.AddWithValue("@DateAction", Now)
        'cmd.ExecuteNonQuery()
        'txt_Avance.Text = 0
        'cmd1 = mysqlconn.CreateCommand
        'cmd1.CommandText = " insert into Action(Id_Commande,Total,Avance,Reste,Action,Livraison,Commentaire,DateAction)VALUE ( @Id_Commande,@Total,@Avance,@Reste,@Action,@Livraison,@Commentaire,@DateAction) "
        'cmd1.Parameters.AddWithValue("@Id_Commande", txt_cmd_Action.Text)

        'cmd1.Parameters.AddWithValue("@Total", DataGridAction.Rows(i).Cells(2).Value) 'And Txt_Prenom.Text)
        'cmd1.Parameters.AddWithValue("@Avance", "")
        'cmd1.Parameters.AddWithValue("@Reste", reste.ToString)
        'cmd1.Parameters.AddWithValue("@Action", "Paiement En Cours")
        'cmd1.Parameters.AddWithValue("@Livraison", "")


        'cmd1.Parameters.AddWithValue("@Commentaire", Txt_Commentaire_regelement.Text)
        'cmd1.Parameters.AddWithValue("@DateAction", Now)
        'cmd1.ExecuteNonQuery()

        'End If
        'Catch ex As MySqlException
        'MessageBox.Show(ex.Message)

        'mysqlconn.Close()

        'Finally
        'mysqlconn.Dispose()


        'End Try

        btn_reglement.Visible = True



    End Sub

    Private Sub btn_quitter_Click_1(sender As Object, e As EventArgs) Handles btn_quitter.Click
        End
    End Sub

    Private Sub MaterialRaisedButton8_Click_1(sender As Object, e As EventArgs) Handles MaterialRaisedButton8.Click
        New_Guest.Show()
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        ' Form5.Show()
    End Sub

    Private Sub liste_Panier_SelectedIndexChanged(sender As Object, e As EventArgs)


        Dim conn As New MySqlConnection

        Dim myconnection As String = "server=localhost;userid=root;password=;database=germaroc"
        Dim cmd As New MySqlCommand


        Try


            Dim SelectedIndex As Int32 = Liste_Panier.SelectedIndices(0)
            If Not SelectedIndex = -1 Then
                If Liste_Panier.SelectedItems(0).SubItems(0).Text IsNot Nothing Then
                    Dim Text As String = Liste_Panier.SelectedItems(0).SubItems(2).Text
                    MsgBox(Text)

                End If
                ' Else
                ' SelectedIndex = SelectedIndex - 1

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub MaterialRaisedButton9_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton9.Click
        Try
            '   Dim SelectedIndex As Int32 = liste_Panier.SelectedIndices(1)
            For i As Integer = 0 To Liste_Panier.Items.Count - 1 '- 1

                ' liste_Panier.Items.Count
                Dim Text As String = Liste_Panier.Items(i).SubItems(2).Text

                MsgBox(Text)

            Next

            ' If Not SelectedIndex = -1 Then
            'If liste_Panier.SelectedItems(0).SubItems(0).Text IsNot Nothing Then
            ' Dim Text As String = liste_Panier.SelectedItems(0).SubItems(2).Text
            '  MsgBox(Text)

            'End If
            ' Else
            ' SelectedIndex = SelectedIndex - 1

            '  End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub txt_Avance_Click(sender As Object, e As EventArgs) Handles txt_Avance.Click

    End Sub

    Private Sub txt_Avance_LostFocus(sender As Object, e As EventArgs) Handles txt_Avance.LostFocus
        btn_reglement.Visible = True
        Btn_Livraison.Visible = True


    End Sub

    Private Sub btn_reglement_Click_1(sender As Object, e As EventArgs) Handles btn_reglement.Click
        If txt_Avance.Text <> "" And txt_Avance.Text <> "0" Or Radio_Liv_Achat.Checked = True Then
            Dim i, j As Integer
            Dim mysqlconn As New MySqlConnection
            mysqlconn.ConnectionString = "server=localhost;Database=germaroc;Userid=root;Pwd=;"

            mysqlconn.Open()
            Dim cmd, cmd1 As New MySqlCommand
            '  Dim cmd1 As New MySqlCommand

            cmd.CommandText = "select max(Id_Action) from Action WHERE Id_Commande = '" + txt_id_cmd.Text + "'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = mysqlconn
            Dim ID, StatutAV, StatutAP, Action, Livraison As String
            Dim Reste, avance, Solde, Total As Double

            Dim ds As MySqlDataReader = cmd.ExecuteReader()
            ds.Read()
            ID = ds(0).ToString()
            ds.Close()
            cmd.ExecuteNonQuery()
            '  For i = 0 To Liste_CommandeAction.Items.Count - 1
            cmd1.CommandText = "select * from Action WHERE Id_Action = '" + ID + "'"
            cmd1.CommandType = CommandType.Text
            cmd1.Connection = mysqlconn
            Dim ds1 As MySqlDataReader = cmd1.ExecuteReader()
            ds1.Read()

            'Total
            Total = ds1(2).ToString
            'Avance
            If txt_Avance.Text <> "" Then
                avance = txt_Avance.Text
            Else
                avance = "0"
            End If

            ' reste
            Reste = ds1(4).ToString()
            ' Solde
            Livraison = ds1(6).ToString()
            StatutAV = ds1(5).ToString()
            ds1.Close()
            cmd1.ExecuteNonQuery()
            If StatutAV.ToString() <> "Payée" And StatutAV.ToString() <> "Annuler" Then
                Reste = Reste + txt_Avance.Text.ToString
                '                
                If Reste >= 0 Then
                    Action = "Payée"
                    cmd = mysqlconn.CreateCommand
                    cmd.CommandText = " insert into Action(Id_Commande,Total,Avance,Reste,Action,Livraison,Commentaire,DateAction)VALUE ( @Id_Commande,@Total,@Avance,@Reste,@Action,@Livraison,@Commentaire,@DateAction) "
                    cmd.Parameters.AddWithValue("@Id_Commande", txt_id_cmd.Text.ToString())
                    cmd.Parameters.AddWithValue("@Total", Total.ToString())
                    cmd.Parameters.AddWithValue("@Avance", avance.ToString())
                    cmd.Parameters.AddWithValue("@Reste", "0")
                    cmd.Parameters.AddWithValue("@Action", Action.ToString())
                    If Radio_Liv_Prevue.Checked = True Then
                        cmd.Parameters.AddWithValue("@Livraison", "Livraison Prévue")
                    Else
                        cmd.Parameters.AddWithValue("@Livraison", "Livrée")
                    End If
                    If Txt_Commentaire_regelement.Text <> "" Then
                        cmd.Parameters.AddWithValue("@Commentaire", Txt_Commentaire_regelement.Text.ToString())
                    Else
                        cmd.Parameters.AddWithValue("@Commentaire", "Rien A Signaler")
                    End If
                    cmd.Parameters.AddWithValue("@DateAction", Now)
                    cmd.ExecuteNonQuery()
                    txt_Avance.Text = Reste.ToString
                Else
                    Action = "Paiement En Cours"
                    cmd = mysqlconn.CreateCommand
                    cmd.CommandText = " insert into Action(Id_Commande,Total,Avance,Reste,Action,Livraison,Commentaire,DateAction)VALUE ( @Id_Commande,@Total,@Avance,@Reste,@Action,@Livraison,@Commentaire,@DateAction) "
                    cmd.Parameters.AddWithValue("@Id_Commande", txt_id_cmd.Text.ToString())
                    cmd.Parameters.AddWithValue("@Total", Total.ToString())
                    cmd.Parameters.AddWithValue("@Avance", avance.ToString())
                    cmd.Parameters.AddWithValue("@Reste", Reste.ToString())
                    cmd.Parameters.AddWithValue("@Action", Action.ToString())
                    If Radio_Liv_Prevue.Checked = True Then
                        cmd.Parameters.AddWithValue("@Livraison", "Livraison Prévue")
                    Else
                        cmd.Parameters.AddWithValue("@Livraison", "Livrée")
                    End If
                    cmd.Parameters.AddWithValue("@Commentaire", Txt_Commentaire_regelement.Text.ToString())
                    cmd.Parameters.AddWithValue("@DateAction", Now)
                    cmd.ExecuteNonQuery()

                    txt_Avance.Text = "0"

                End If

                ' txt_Avance.Text = Reste.ToString()

            End If
            ' MsgBox(StatutAV.ToString())
            'MsgBox(avance.ToString())
            ' MsgBox(Total.ToString())
            MsgBox(Reste.ToString())
            'MsgBox(StatutAP)
            'MsgBox(Livraison.ToString())




        Else
            MsgBox("Aucune Action A faire !")

                ' Combo_des.ResetText()



            End If
        ' End If

    End Sub

    Private Sub MaterialRaisedButton10_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton10.Click
        Stock.Show()

    End Sub


End Class
