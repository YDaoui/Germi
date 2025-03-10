<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Guest
    Inherits MaterialSkin.Controls.MaterialForm


    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MaterialRaisedButton3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_Nom = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_Prenom = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_Tel = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_Age = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_Adresse = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_Commentaire = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'MaterialRaisedButton3
        '
        Me.MaterialRaisedButton3.AutoSize = True
        Me.MaterialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton3.Depth = 0
        Me.MaterialRaisedButton3.Icon = Nothing
        Me.MaterialRaisedButton3.Location = New System.Drawing.Point(699, 84)
        Me.MaterialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton3.Name = "MaterialRaisedButton3"
        Me.MaterialRaisedButton3.Primary = True
        Me.MaterialRaisedButton3.Size = New System.Drawing.Size(81, 36)
        Me.MaterialRaisedButton3.TabIndex = 36
        Me.MaterialRaisedButton3.Text = "Ajouter"
        Me.MaterialRaisedButton3.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.AutoSize = True
        Me.MaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Icon = Nothing
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(698, 160)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(82, 36)
        Me.MaterialRaisedButton1.TabIndex = 37
        Me.MaterialRaisedButton1.Text = "Annuler"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.AutoSize = True
        Me.MaterialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Icon = Nothing
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(670, 243)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(110, 36)
        Me.MaterialRaisedButton2.TabIndex = 38
        Me.MaterialRaisedButton2.Text = "Enregistrer"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(40, 143)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(61, 19)
        Me.MaterialLabel5.TabIndex = 48
        Me.MaterialLabel5.Text = "Prénom"
        '
        'txt_Nom
        '
        Me.txt_Nom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nom.Depth = 0
        Me.txt_Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nom.Hint = ""
        Me.txt_Nom.Location = New System.Drawing.Point(113, 92)
        Me.txt_Nom.MaxLength = 32767
        Me.txt_Nom.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_Nom.Name = "txt_Nom"
        Me.txt_Nom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Nom.SelectedText = ""
        Me.txt_Nom.SelectionLength = 0
        Me.txt_Nom.SelectionStart = 0
        Me.txt_Nom.Size = New System.Drawing.Size(170, 23)
        Me.txt_Nom.TabIndex = 50
        Me.txt_Nom.TabStop = False
        Me.txt_Nom.UseSystemPasswordChar = False
        '
        'txt_Prenom
        '
        Me.txt_Prenom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Prenom.Depth = 0
        Me.txt_Prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Prenom.Hint = ""
        Me.txt_Prenom.Location = New System.Drawing.Point(113, 143)
        Me.txt_Prenom.MaxLength = 32767
        Me.txt_Prenom.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_Prenom.Name = "txt_Prenom"
        Me.txt_Prenom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Prenom.SelectedText = ""
        Me.txt_Prenom.SelectionLength = 0
        Me.txt_Prenom.SelectionStart = 0
        Me.txt_Prenom.Size = New System.Drawing.Size(170, 23)
        Me.txt_Prenom.TabIndex = 51
        Me.txt_Prenom.TabStop = False
        Me.txt_Prenom.UseSystemPasswordChar = False
        '
        'txt_Tel
        '
        Me.txt_Tel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Tel.Depth = 0
        Me.txt_Tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tel.Hint = ""
        Me.txt_Tel.Location = New System.Drawing.Point(441, 85)
        Me.txt_Tel.MaxLength = 32767
        Me.txt_Tel.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_Tel.Name = "txt_Tel"
        Me.txt_Tel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Tel.SelectedText = ""
        Me.txt_Tel.SelectionLength = 0
        Me.txt_Tel.SelectionStart = 0
        Me.txt_Tel.Size = New System.Drawing.Size(170, 23)
        Me.txt_Tel.TabIndex = 52
        Me.txt_Tel.TabStop = False
        Me.txt_Tel.UseSystemPasswordChar = False
        '
        'txt_Age
        '
        Me.txt_Age.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Age.Depth = 0
        Me.txt_Age.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Age.Hint = ""
        Me.txt_Age.Location = New System.Drawing.Point(441, 139)
        Me.txt_Age.MaxLength = 32767
        Me.txt_Age.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_Age.Name = "txt_Age"
        Me.txt_Age.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Age.SelectedText = ""
        Me.txt_Age.SelectionLength = 0
        Me.txt_Age.SelectionStart = 0
        Me.txt_Age.Size = New System.Drawing.Size(170, 23)
        Me.txt_Age.TabIndex = 53
        Me.txt_Age.TabStop = False
        Me.txt_Age.UseSystemPasswordChar = False
        '
        'txt_Adresse
        '
        Me.txt_Adresse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Adresse.Depth = 0
        Me.txt_Adresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Adresse.Hint = ""
        Me.txt_Adresse.Location = New System.Drawing.Point(113, 199)
        Me.txt_Adresse.MaxLength = 32767
        Me.txt_Adresse.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_Adresse.Name = "txt_Adresse"
        Me.txt_Adresse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Adresse.SelectedText = ""
        Me.txt_Adresse.SelectionLength = 0
        Me.txt_Adresse.SelectionStart = 0
        Me.txt_Adresse.Size = New System.Drawing.Size(498, 23)
        Me.txt_Adresse.TabIndex = 54
        Me.txt_Adresse.TabStop = False
        Me.txt_Adresse.UseSystemPasswordChar = False
        '
        'txt_Commentaire
        '
        Me.txt_Commentaire.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Commentaire.Depth = 0
        Me.txt_Commentaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Commentaire.Hint = ""
        Me.txt_Commentaire.Location = New System.Drawing.Point(113, 251)
        Me.txt_Commentaire.MaxLength = 32767
        Me.txt_Commentaire.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_Commentaire.Name = "txt_Commentaire"
        Me.txt_Commentaire.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Commentaire.SelectedText = ""
        Me.txt_Commentaire.SelectionLength = 0
        Me.txt_Commentaire.SelectionStart = 0
        Me.txt_Commentaire.Size = New System.Drawing.Size(498, 23)
        Me.txt_Commentaire.TabIndex = 55
        Me.txt_Commentaire.TabStop = False
        Me.txt_Commentaire.UseSystemPasswordChar = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(1, 92)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(106, 19)
        Me.MaterialLabel1.TabIndex = 56
        Me.MaterialLabel1.Text = "Nom Prénom :"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(29, 199)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(72, 19)
        Me.MaterialLabel2.TabIndex = 57
        Me.MaterialLabel2.Text = "Adresse :"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(1, 251)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(100, 19)
        Me.MaterialLabel3.TabIndex = 58
        Me.MaterialLabel3.Text = "Commentaire"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(392, 139)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(43, 19)
        Me.MaterialLabel4.TabIndex = 59
        Me.MaterialLabel4.Text = "Age :"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(347, 89)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(88, 19)
        Me.MaterialLabel6.TabIndex = 60
        Me.MaterialLabel6.Text = "TéléPhone :"
        '
        'New_Guest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 321)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.txt_Commentaire)
        Me.Controls.Add(Me.txt_Adresse)
        Me.Controls.Add(Me.txt_Age)
        Me.Controls.Add(Me.txt_Tel)
        Me.Controls.Add(Me.txt_Prenom)
        Me.Controls.Add(Me.txt_Nom)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialRaisedButton2)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.MaterialRaisedButton3)
        Me.Name = "New_Guest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nouveau Guest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialRaisedButton3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_Nom As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_Prenom As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_Tel As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_Age As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_Adresse As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_Commentaire As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
End Class
