Imports MySql.Data.MySqlClient
Imports System.IO
Imports MaterialSkin


Public Class New_Guest

    Dim myconnection As New MySqlConnection





    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub New_Guest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Age.Text = "3"
        MaterialRaisedButton3.Visible = True

        Dim skinmanager As MaterialSkin.MaterialSkinManager = MaterialSkinManager.Instance


        skinmanager.AddFormToManage(Me)

        skinmanager.Theme = MaterialSkinManager.Themes.DARK
        skinmanager.ColorScheme = New ColorScheme(Primary.Blue400, Primary.Grey800, Primary.Teal400, Accent.Teal400, TextShade.BLACK)

    End Sub

    Private Sub Txt_Prenom_TextChanged(sender As Object, e As EventArgs)
        '  txt_nom_pren.Text = txt_Nom.Text & "  " & txt_Prenom.Text

    End Sub

    Private Sub Txt_Adresse_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click

    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        txt_Nom.Text = ""
        ' txt_nom_pren.Text = ""
        txt_Adresse.Text = ""
        txt_Prenom.Text = ""
        txt_Age.Text = ""
        txt_Adresse.Text = ""
        txt_Commentaire.Text = ""

        Me.Close()
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        If txt_Adresse.Text = "" Or txt_Tel.Text = "" Then
            MsgBox("Merci de mettre au moins le Num de Tél et l'Adresse !")
        Else

            myconnection.ConnectionString = "server=localhost;Database=germaroc;Userid=root;Pwd=;"

            myconnection.Open()

            Dim cmd As MySqlCommand

            Try

                cmd = myconnection.CreateCommand
                cmd.CommandText = " insert into Guest(nom,Age,Tel,Adresse,Commentaire)VALUE ( @nom, @Age, @Tel, @Adresse, @Commentaire) "
                cmd.Parameters.AddWithValue("@nom", txt_Nom.Text)
                cmd.Parameters.AddWithValue("@Age", txt_Age.Text) 'And Txt_Prenom.Text)
                cmd.Parameters.AddWithValue("@Tel", txt_Tel.Text)
                cmd.Parameters.AddWithValue("@Adresse", txt_Adresse.Text)
                cmd.Parameters.AddWithValue("@Commentaire", txt_Commentaire.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Ajout Guest")
                Me.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)

                myconnection.Close()

            Finally
                myconnection.Dispose()


            End Try

        End If
    End Sub
End Class