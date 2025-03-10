<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Suivi
    Inherits MaterialSkin.Controls.MaterialForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.list_action = New System.Windows.Forms.ListView()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_Tel = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialRaisedButton8 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.Combo_Livraison = New System.Windows.Forms.ComboBox()
        Me.Combo_Paiement = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.list_action)
        Me.GroupBox2.Controls.Add(Me.MaterialLabel6)
        Me.GroupBox2.Controls.Add(Me.txt_Tel)
        Me.GroupBox2.Controls.Add(Me.MaterialRaisedButton8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(39, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1087, 475)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Panier "
        '
        'list_action
        '
        Me.list_action.HideSelection = False
        Me.list_action.Location = New System.Drawing.Point(6, 91)
        Me.list_action.Name = "list_action"
        Me.list_action.Size = New System.Drawing.Size(1029, 160)
        Me.list_action.TabIndex = 63
        Me.list_action.UseCompatibleStateImageBehavior = False
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(256, 34)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(88, 19)
        Me.MaterialLabel6.TabIndex = 62
        Me.MaterialLabel6.Text = "TéléPhone :"
        '
        'txt_Tel
        '
        Me.txt_Tel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Tel.Depth = 0
        Me.txt_Tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tel.Hint = ""
        Me.txt_Tel.Location = New System.Drawing.Point(350, 30)
        Me.txt_Tel.MaxLength = 32767
        Me.txt_Tel.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_Tel.Name = "txt_Tel"
        Me.txt_Tel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Tel.SelectedText = ""
        Me.txt_Tel.SelectionLength = 0
        Me.txt_Tel.SelectionStart = 0
        Me.txt_Tel.Size = New System.Drawing.Size(206, 23)
        Me.txt_Tel.TabIndex = 61
        Me.txt_Tel.TabStop = False
        Me.txt_Tel.UseSystemPasswordChar = False
        '
        'MaterialRaisedButton8
        '
        Me.MaterialRaisedButton8.AutoSize = True
        Me.MaterialRaisedButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton8.Depth = 0
        Me.MaterialRaisedButton8.Icon = Nothing
        Me.MaterialRaisedButton8.Location = New System.Drawing.Point(943, 416)
        Me.MaterialRaisedButton8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton8.Name = "MaterialRaisedButton8"
        Me.MaterialRaisedButton8.Primary = True
        Me.MaterialRaisedButton8.Size = New System.Drawing.Size(73, 36)
        Me.MaterialRaisedButton8.TabIndex = 52
        Me.MaterialRaisedButton8.Text = "Fermer"
        Me.MaterialRaisedButton8.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaterialFlatButton1)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel3)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel2)
        Me.GroupBox1.Controls.Add(Me.Combo_Livraison)
        Me.GroupBox1.Controls.Add(Me.Combo_Paiement)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel1)
        Me.GroupBox1.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(39, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1087, 94)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Suivie"
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Icon = Nothing
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(892, 45)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(181, 36)
        Me.MaterialFlatButton1.TabIndex = 67
        Me.MaterialFlatButton1.Text = "MaterialFlatButton1"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(67, 64)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(78, 19)
        Me.MaterialLabel3.TabIndex = 66
        Me.MaterialLabel3.Text = "Livraison :"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(67, 17)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(80, 19)
        Me.MaterialLabel2.TabIndex = 65
        Me.MaterialLabel2.Text = "Paiement :"
        '
        'Combo_Livraison
        '
        Me.Combo_Livraison.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Combo_Livraison.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Combo_Livraison.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Livraison.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Combo_Livraison.FormattingEnabled = True
        Me.Combo_Livraison.Location = New System.Drawing.Point(152, 60)
        Me.Combo_Livraison.Name = "Combo_Livraison"
        Me.Combo_Livraison.Size = New System.Drawing.Size(286, 28)
        Me.Combo_Livraison.TabIndex = 64
        '
        'Combo_Paiement
        '
        Me.Combo_Paiement.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Combo_Paiement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Combo_Paiement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Paiement.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Combo_Paiement.FormattingEnabled = True
        Me.Combo_Paiement.Location = New System.Drawing.Point(152, 13)
        Me.Combo_Paiement.Name = "Combo_Paiement"
        Me.Combo_Paiement.Size = New System.Drawing.Size(286, 28)
        Me.Combo_Paiement.TabIndex = 63
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(527, 22)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(88, 19)
        Me.MaterialLabel1.TabIndex = 62
        Me.MaterialLabel1.Text = "TéléPhone :"
        '
        'MaterialSingleLineTextField1
        '
        Me.MaterialSingleLineTextField1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialSingleLineTextField1.Hint = ""
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(635, 25)
        Me.MaterialSingleLineTextField1.MaxLength = 32767
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(206, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 61
        Me.MaterialSingleLineTextField1.TabStop = False
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'Suivi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 657)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Suivi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Suivi Paiements et Livraisons"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MaterialRaisedButton8 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_Tel As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Combo_Livraison As ComboBox
    Friend WithEvents Combo_Paiement As ComboBox
    Friend WithEvents list_action As ListView
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
End Class
