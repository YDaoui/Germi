<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialCheckBox1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.txt_USER = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_MOTDEPASSE = New MaterialSkin.Controls.MaterialSingleLineTextField()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(129, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Mot de passe :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(202, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Login :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 67)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(507, 100)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(118, 30)
        Me.MaterialRaisedButton2.TabIndex = 35
        Me.MaterialRaisedButton2.Text = "Valider"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(507, 144)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(118, 30)
        Me.MaterialRaisedButton1.TabIndex = 36
        Me.MaterialRaisedButton1.Text = "Quitter"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'MaterialCheckBox1
        '
        Me.MaterialCheckBox1.AutoSize = True
        Me.MaterialCheckBox1.Depth = 0
        Me.MaterialCheckBox1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox1.Location = New System.Drawing.Point(306, 186)
        Me.MaterialCheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox1.Name = "MaterialCheckBox1"
        Me.MaterialCheckBox1.Ripple = True
        Me.MaterialCheckBox1.Size = New System.Drawing.Size(180, 30)
        Me.MaterialCheckBox1.TabIndex = 37
        Me.MaterialCheckBox1.Text = "Afficher le mot de passe"
        Me.MaterialCheckBox1.UseVisualStyleBackColor = True
        '
        'txt_USER
        '
        Me.txt_USER.Depth = 0
        Me.txt_USER.Hint = ""
        Me.txt_USER.Location = New System.Drawing.Point(282, 107)
        Me.txt_USER.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_USER.Name = "txt_USER"
        Me.txt_USER.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_USER.SelectedText = ""
        Me.txt_USER.SelectionLength = 0
        Me.txt_USER.SelectionStart = 0
        Me.txt_USER.Size = New System.Drawing.Size(174, 23)
        Me.txt_USER.TabIndex = 38
        Me.txt_USER.UseSystemPasswordChar = False
        '
        'txt_MOTDEPASSE
        '
        Me.txt_MOTDEPASSE.Depth = 0
        Me.txt_MOTDEPASSE.Hint = ""
        Me.txt_MOTDEPASSE.Location = New System.Drawing.Point(282, 148)
        Me.txt_MOTDEPASSE.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_MOTDEPASSE.Name = "txt_MOTDEPASSE"
        Me.txt_MOTDEPASSE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_MOTDEPASSE.SelectedText = ""
        Me.txt_MOTDEPASSE.SelectionLength = 0
        Me.txt_MOTDEPASSE.SelectionStart = 0
        Me.txt_MOTDEPASSE.Size = New System.Drawing.Size(174, 23)
        Me.txt_MOTDEPASSE.TabIndex = 39
        Me.txt_MOTDEPASSE.UseSystemPasswordChar = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(667, 225)
        Me.Controls.Add(Me.txt_MOTDEPASSE)
        Me.Controls.Add(Me.txt_USER)
        Me.Controls.Add(Me.MaterialCheckBox1)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.MaterialRaisedButton2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Authentification"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialCheckBox1 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents txt_USER As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_MOTDEPASSE As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
