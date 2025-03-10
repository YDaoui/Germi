Imports MySql.Data.MySqlClient
Imports System.IO
Imports MaterialSkin



Public Class NewProduit
    Dim conn As New MySqlConnection

    Dim myconnection As String = "server=localhost;userid=root;password=;database=germaroc"
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrimage() As Byte
    Dim sql As String

    Private Sub NewProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load





        Dim skinmanager As MaterialSkin.MaterialSkinManager = MaterialSkinManager.Instance


        skinmanager.AddFormToManage(Me)


        skinmanager.Theme = MaterialSkinManager.Themes.DARK
        skinmanager.ColorScheme = New ColorScheme(Primary.Red400, Primary.Grey800, Primary.Teal400, Accent.Teal400, TextShade.BLACK)
        btn_Searsh.Text = "Searsh"


    End Sub

    Private Sub MaterialRaisedButton9_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton9.Click
        Me.Close()

    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles btn_Browse.Click
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

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Try
            Dim mstream As New System.IO.MemoryStream()
            PictureBox2.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length

            mstream.Close()
            conn.ConnectionString = myconnection
            conn.Open()

            sql = "UPDATE article SET Img = @img WHERE codbare = '" + txt_codebarre.Text + "' "
            cmd.Connection = conn
            cmd.CommandText = sql

            cmd.Parameters.AddWithValue("@img", arrimage)
            Dim r As Integer
            r = cmd.ExecuteNonQuery()
            If r > 0 Then
                MsgBox("Picture has been Saved!")
            Else
                MsgBox("No PiCture been saved!")
            End If
            cmd.Parameters.Clear()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub

    Private Sub txt_codebarre_Click(sender As Object, e As EventArgs) Handles txt_codebarre.Click

    End Sub

    Private Sub txt_codebarre_LostFocus(sender As Object, e As EventArgs) Handles txt_codebarre.LostFocus
        If txt_codebarre.Text <> Nothing Then
            btn_Searsh.Visible = True
            Btn_Update.Visible = True
        Else
            btn_Searsh.Visible = False
            Btn_Update.Visible = False
        End If
    End Sub



    Private Sub Txt_des_LostFocus(sender As Object, e As EventArgs) Handles Txt_des.LostFocus

    End Sub

    Private Sub btn_Searsh_Click(sender As Object, e As EventArgs) Handles btn_Searsh.Click
        If btn_Searsh.Text = "Searsh" Then

            Dim mysqlconn As MySqlConnection
            mysqlconn = New MySqlConnection
            mysqlconn.ConnectionString =
              "server=localhost;userid=root;password=;database=germaroc"
            Try
                mysqlconn.Open()
                Dim cmd As New MySqlCommand
                cmd.CommandText = "select * from article where codbare ='" + txt_codebarre.Text + "'"
                cmd.CommandType = CommandType.Text
                cmd.Connection = mysqlconn
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                dr.Read()
                Txt_Prix.Text = dr(10).ToString
                Txt_Stock.Text = dr(6)
                Txt_Marque.Text = dr(3)
                Txt_Marge.Text = dr(9)
                Txt_Pack.Text = dr(1)
                Txt_des.Text = dr(2).ToString
                Txt_Des_Alm.Text = dr(4).ToString
                Txt_Calibre.Text = dr(7).ToString
                Txt_Achat.Text = dr(8).ToString
                Txt_Prix.Text = dr(5).ToString
                txt_Prix_vente.Text = dr(10).ToString

                'Txt_codbare.Text = dr(0)
                Dim img() As Byte
                img = dr(11)
                If img.Length = 0 Then
                    MsgBox("Aucune Image à afficher !")
                    PictureBox2.Image = Nothing
                    btn_Browse.Visible = True
                    btn_Save.Visible = True
                Else
                    Dim ms As New MemoryStream(img)
                    PictureBox2.Image = Image.FromStream(ms)
                    btn_Browse.Visible = False
                    btn_Save.Visible = False
                End If
                dr.Close()
                cmd.ExecuteNonQuery()

            Catch ex As MySqlException
                MsgBox("Produit Introuvable !")
                btn_Searsh.Text = "Ajouter"
                'ex.Message
                mysqlconn.Close()

            Finally
                mysqlconn.Dispose()



            End Try
            ' btn_Searsh.Text = "Searsh"
        Else
        End If

    End Sub



    Private Sub MaterialRaisedButton1_Click_2(sender As Object, e As EventArgs) Handles Btn_Update.Click
        If Txt_Unites.Text = "" Then
            MsgBox("Merci de mettre les unités à ajouter !")
        Else


            Dim mysqlconn As MySqlConnection


            mysqlconn = New MySqlConnection
            mysqlconn.ConnectionString =
                  "server=localhost;userid=root;password=;database=germaroc"
            Try
                mysqlconn.Open()
                Dim cmd As New MySqlCommand
                cmd.CommandText = "select * from article where codbare ='" + txt_codebarre.Text + "'"
                cmd.CommandType = CommandType.Text
                cmd.Connection = mysqlconn
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                Dim stok As Integer
                stok = 0

                dr.Read()
                '  Txt_Prix.Text = dr(10).ToString
                stok = dr(6).ToString

                stok = stok + Txt_Unites.Text

                dr.Close()
                cmd.ExecuteNonQuery()


                Dim R As Integer
                Dim Ref As String
                ' For R = 0 To DataGridView1.RowCount - 1
                'DataGridView1.Rows(T).Cells(0).Value = Ref.ToString
                Dim cmdS As MySqlCommand
                cmdS = mysqlconn.CreateCommand

                cmdS.CommandType = CommandType.Text
                cmdS.CommandText = " update article set stock ='" + stok.ToString + "'where codbare =  '" + txt_codebarre.Text + " '"

                ' Next
                cmdS.ExecuteNonQuery()
                MsgBox("Mise a jour faite : !")


            Catch ex As MySqlException
                MsgBox("Mise a jour non faite : !")
                ' btn_Searsh.Text = "Ajouter"
                'ex.Message
                mysqlconn.Close()

            Finally
                mysqlconn.Dispose()



            End Try


        End If

    End Sub
End Class