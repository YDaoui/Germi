Imports MySql.Data.MySqlClient
Imports MaterialSkin

Public Class Form3


    Dim mysqlconn As New MySqlConnection

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim skinmanager As MaterialSkin.MaterialSkinManager = MaterialSkinManager.Instance


        '  skinmanager.AddFormToManage(Me)

        skinmanager.Theme = MaterialSkinManager.Themes.LIGHT
        skinmanager.ColorScheme = New ColorScheme(Primary.Red400, Primary.Grey800, Primary.Teal400, Accent.Teal400, TextShade.BLACK)

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        Dim connection As New MySqlConnection("datasource = localhost;port=3306; Database = germaroc;username=root;pasword=")
        'connection.Open()

        Dim Commande As New MySqlCommand("select * from users where login = @login and PSW = @PSW", connection)

        Commande.Parameters.Add("@ login", SqlDbType.VarChar).Value = Txt_USER.Text
        Commande.Parameters.Add("@ PSW", SqlDbType.VarChar).Value = Txt_MOTDEPASSE.Text
        ' Commande.Parameters.Add("@ login", SqlDbType.VarChar).Value = Txt_USER.Text

        Dim adapter As New MySqlDataAdapter

        Dim table As New DataTable

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Le nom d'utilisateur ou le mot de passe sont invalides")

        Else

            MessageBox.Show("Connexion réussie")



            Me.Hide()



        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        If Txt_MOTDEPASSE.UseSystemPasswordChar = True Then

            Txt_MOTDEPASSE.UseSystemPasswordChar = False

        Else
            Txt_MOTDEPASSE.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)



        ' Me.Close()

        Demande.Show()

    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click

        If Txt_USER.Text = "" Or Txt_MOTDEPASSE.Text = "" Then

            MsgBox("Merci de saisir vos identifiants", vbInformation, "Controle de Saisie")

        Else
            Try

                mysqlconn.ConnectionString = "server=localhost;Database=germaroc;Userid=root;Pwd=;"

                mysqlconn.Open()

                Dim cmd As MySqlCommand

                Dim query As String

                query = "select * from Users where Login ='" + txt_USER.Text + "'and PSW ='" + txt_MOTDEPASSE.Text + "'"
                cmd = New MySqlCommand(query, mysqlconn)


                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim ds As DataSet = New DataSet

                da.Fill(ds)
                Dim a As Integer

                a = ds.Tables(0).Rows.Count
                If a = 0 Then
                    MsgBox("Nom d'utilisateur ou mot de passe incorrect")
                    Txt_USER.Text = ""
                    Txt_MOTDEPASSE.Text = ""
                Else


                    MessageBox.Show("identifiants non lahoma yasser")
                    mysqlconn.Close()
                    ' Demande.Close()
                    Me.Hide()
                    Demande.Show()



                End If

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
                mysqlconn.Close()
            Finally
                mysqlconn.Dispose()

            End Try

        End If
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        End
    End Sub

    Private Sub MaterialCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox1.CheckedChanged
        If MaterialCheckBox1.Checked = True Then
            Txt_MOTDEPASSE.PasswordChar = ""
        Else
            Txt_MOTDEPASSE.PasswordChar = "*"
        End If
    End Sub
End Class