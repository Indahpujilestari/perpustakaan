<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bbatal = New System.Windows.Forms.Button()
        Me.blogin = New System.Windows.Forms.Button()
        Me.clevel = New System.Windows.Forms.ComboBox()
        Me.tpas = New System.Windows.Forms.TextBox()
        Me.tuser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.Perpustakaan_sebagai_Sumber_Ilmu_Pengetahuan1
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1380, 710)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "[ Silahkan Login ]"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.bbatal)
        Me.Panel1.Controls.Add(Me.blogin)
        Me.Panel1.Controls.Add(Me.clevel)
        Me.Panel1.Controls.Add(Me.tpas)
        Me.Panel1.Controls.Add(Me.tuser)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(487, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 267)
        Me.Panel1.TabIndex = 0
        '
        'bbatal
        '
        Me.bbatal.Location = New System.Drawing.Point(224, 171)
        Me.bbatal.Name = "bbatal"
        Me.bbatal.Size = New System.Drawing.Size(93, 23)
        Me.bbatal.TabIndex = 7
        Me.bbatal.Text = "Batal"
        Me.bbatal.UseVisualStyleBackColor = True
        '
        'blogin
        '
        Me.blogin.Location = New System.Drawing.Point(73, 171)
        Me.blogin.Name = "blogin"
        Me.blogin.Size = New System.Drawing.Size(89, 23)
        Me.blogin.TabIndex = 6
        Me.blogin.Text = "Login"
        Me.blogin.UseVisualStyleBackColor = True
        '
        'clevel
        '
        Me.clevel.FormattingEnabled = True
        Me.clevel.Items.AddRange(New Object() {"Anggota", "Admin"})
        Me.clevel.Location = New System.Drawing.Point(196, 122)
        Me.clevel.Name = "clevel"
        Me.clevel.Size = New System.Drawing.Size(121, 21)
        Me.clevel.TabIndex = 5
        '
        'tpas
        '
        Me.tpas.Location = New System.Drawing.Point(196, 95)
        Me.tpas.Name = "tpas"
        Me.tpas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tpas.Size = New System.Drawing.Size(121, 20)
        Me.tpas.TabIndex = 4
        '
        'tuser
        '
        Me.tuser.Location = New System.Drawing.Point(196, 66)
        Me.tuser.Name = "tuser"
        Me.tuser.Size = New System.Drawing.Size(121, 20)
        Me.tuser.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(79, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Level User :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(79, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(79, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(580, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 33)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "FORM LOGIN"
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 707)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Login"
        Me.Text = "Form_Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bbatal As System.Windows.Forms.Button
    Friend WithEvents blogin As System.Windows.Forms.Button
    Friend WithEvents clevel As System.Windows.Forms.ComboBox
    Friend WithEvents tpas As System.Windows.Forms.TextBox
    Friend WithEvents tuser As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
