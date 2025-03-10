<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.Combo_Livraison = New System.Windows.Forms.ComboBox()
        Me.Combo_Marque = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_Total = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_Stock = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton8 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.liste_Stock = New MaterialSkin.Controls.MaterialListView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaterialLabel3)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel2)
        Me.GroupBox1.Controls.Add(Me.Combo_Livraison)
        Me.GroupBox1.Controls.Add(Me.Combo_Marque)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel1)
        Me.GroupBox1.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.GroupBox1.Controls.Add(Me.MaterialRaisedButton2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(126, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1149, 94)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Suivie"
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
        Me.MaterialLabel3.Visible = False
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
        Me.MaterialLabel2.Size = New System.Drawing.Size(68, 19)
        Me.MaterialLabel2.TabIndex = 65
        Me.MaterialLabel2.Text = "Marque :"
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
        Me.Combo_Livraison.Visible = False
        '
        'Combo_Marque
        '
        Me.Combo_Marque.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Combo_Marque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Combo_Marque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Marque.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Combo_Marque.FormattingEnabled = True
        Me.Combo_Marque.Location = New System.Drawing.Point(152, 13)
        Me.Combo_Marque.Name = "Combo_Marque"
        Me.Combo_Marque.Size = New System.Drawing.Size(286, 28)
        Me.Combo_Marque.TabIndex = 63
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
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(268, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 61
        Me.MaterialSingleLineTextField1.TabStop = False
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.AutoSize = True
        Me.MaterialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Icon = Nothing
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(932, 25)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(84, 36)
        Me.MaterialRaisedButton2.TabIndex = 53
        Me.MaterialRaisedButton2.Text = "Afficher"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MaterialLabel4)
        Me.GroupBox2.Controls.Add(Me.txt_Total)
        Me.GroupBox2.Controls.Add(Me.MaterialLabel6)
        Me.GroupBox2.Controls.Add(Me.txt_Stock)
        Me.GroupBox2.Controls.Add(Me.MaterialRaisedButton1)
        Me.GroupBox2.Controls.Add(Me.MaterialRaisedButton8)
        Me.GroupBox2.Controls.Add(Me.liste_Stock)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(126, 189)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1149, 607)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Panier "
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(686, 42)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(52, 19)
        Me.MaterialLabel4.TabIndex = 64
        Me.MaterialLabel4.Text = "Total :"
        '
        'txt_Total
        '
        Me.txt_Total.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Total.Depth = 0
        Me.txt_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Hint = ""
        Me.txt_Total.Location = New System.Drawing.Point(780, 38)
        Me.txt_Total.MaxLength = 32767
        Me.txt_Total.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Total.SelectedText = ""
        Me.txt_Total.SelectionLength = 0
        Me.txt_Total.SelectionStart = 0
        Me.txt_Total.Size = New System.Drawing.Size(50, 23)
        Me.txt_Total.TabIndex = 63
        Me.txt_Total.TabStop = False
        Me.txt_Total.UseSystemPasswordChar = False
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(234, 42)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(60, 19)
        Me.MaterialLabel6.TabIndex = 62
        Me.MaterialLabel6.Text = "Stock  :"
        '
        'txt_Stock
        '
        Me.txt_Stock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Stock.Depth = 0
        Me.txt_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Stock.Hint = ""
        Me.txt_Stock.Location = New System.Drawing.Point(328, 38)
        Me.txt_Stock.MaxLength = 32767
        Me.txt_Stock.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_Stock.Name = "txt_Stock"
        Me.txt_Stock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Stock.SelectedText = ""
        Me.txt_Stock.SelectionLength = 0
        Me.txt_Stock.SelectionStart = 0
        Me.txt_Stock.Size = New System.Drawing.Size(50, 23)
        Me.txt_Stock.TabIndex = 61
        Me.txt_Stock.TabStop = False
        Me.txt_Stock.UseSystemPasswordChar = False
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.AutoSize = True
        Me.MaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Icon = Nothing
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(1041, 25)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(84, 36)
        Me.MaterialRaisedButton1.TabIndex = 53
        Me.MaterialRaisedButton1.Text = "Afficher"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton8
        '
        Me.MaterialRaisedButton8.AutoSize = True
        Me.MaterialRaisedButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton8.Depth = 0
        Me.MaterialRaisedButton8.Icon = Nothing
        Me.MaterialRaisedButton8.Location = New System.Drawing.Point(1041, 536)
        Me.MaterialRaisedButton8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton8.Name = "MaterialRaisedButton8"
        Me.MaterialRaisedButton8.Primary = True
        Me.MaterialRaisedButton8.Size = New System.Drawing.Size(73, 36)
        Me.MaterialRaisedButton8.TabIndex = 52
        Me.MaterialRaisedButton8.Text = "Fermer"
        Me.MaterialRaisedButton8.UseVisualStyleBackColor = True
        '
        'liste_Stock
        '
        Me.liste_Stock.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.liste_Stock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.liste_Stock.Depth = 0
        Me.liste_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.liste_Stock.FullRowSelect = True
        Me.liste_Stock.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.liste_Stock.HideSelection = False
        Me.liste_Stock.Location = New System.Drawing.Point(53, 78)
        Me.liste_Stock.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.liste_Stock.MouseState = MaterialSkin.MouseState.OUT
        Me.liste_Stock.Name = "liste_Stock"
        Me.liste_Stock.OwnerDraw = True
        Me.liste_Stock.Size = New System.Drawing.Size(979, 441)
        Me.liste_Stock.TabIndex = 44
        Me.liste_Stock.UseCompatibleStateImageBehavior = False
        Me.liste_Stock.View = System.Windows.Forms.View.Details
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1391, 779)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Combo_Livraison As ComboBox
    Friend WithEvents Combo_Marque As ComboBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_Stock As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton8 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents liste_Stock As MaterialSkin.Controls.MaterialListView
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_Total As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
