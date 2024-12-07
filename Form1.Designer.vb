<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnback = New System.Windows.Forms.Button()
        Me.Password = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.Label()
        Me.buttonl = New System.Windows.Forms.Button()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Linen
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(806, 25)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(90, 43)
        Me.btnback.TabIndex = 24
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Password.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Password.Location = New System.Drawing.Point(597, 245)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(128, 29)
        Me.Password.TabIndex = 20
        Me.Password.Text = "Password"
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Username.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Username.Location = New System.Drawing.Point(599, 124)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(137, 29)
        Me.Username.TabIndex = 19
        Me.Username.Text = "UserName"
        '
        'buttonl
        '
        Me.buttonl.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.buttonl.Location = New System.Drawing.Point(607, 420)
        Me.buttonl.Name = "buttonl"
        Me.buttonl.Size = New System.Drawing.Size(102, 36)
        Me.buttonl.TabIndex = 18
        Me.buttonl.Text = "Log In"
        Me.buttonl.UseVisualStyleBackColor = False
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(538, 318)
        Me.textBox2.MaximumSize = New System.Drawing.Size(250, 30)
        Me.textBox2.Multiline = True
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(250, 30)
        Me.textBox2.TabIndex = 17
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(538, 180)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(258, 32)
        Me.textBox1.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 141)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(309, 315)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 569)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.buttonl)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnback As Button
    Private WithEvents Password As Label
    Private WithEvents Username As Label
    Private WithEvents buttonl As Button
    Private WithEvents textBox2 As TextBox
    Private WithEvents textBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
