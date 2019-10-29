<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anggota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Anggota))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tcari = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lsimpan = New System.Windows.Forms.ToolStripButton()
        Me.lupdate = New System.Windows.Forms.ToolStripButton()
        Me.ldelete = New System.Windows.Forms.ToolStripButton()
        Me.lbatal = New System.Windows.Forms.ToolStripButton()
        Me.lback = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbl_anggota = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cjk = New System.Windows.Forms.ComboBox()
        Me.cprodi = New System.Windows.Forms.ComboBox()
        Me.cangkatan = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.talamat = New System.Windows.Forms.TextBox()
        Me.tnama = New System.Windows.Forms.TextBox()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.tbl_anggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1368, 50)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(545, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(341, 33)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "INPUT DATA ANGGOTA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(351, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Cari :"
        '
        'tcari
        '
        Me.tcari.Location = New System.Drawing.Point(423, 19)
        Me.tcari.Name = "tcari"
        Me.tcari.Size = New System.Drawing.Size(244, 20)
        Me.tcari.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 354)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1377, 53)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lsimpan, Me.lupdate, Me.ldelete, Me.lbatal, Me.lback})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1371, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lsimpan
        '
        Me.lsimpan.Image = CType(resources.GetObject("lsimpan.Image"), System.Drawing.Image)
        Me.lsimpan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.lsimpan.Name = "lsimpan"
        Me.lsimpan.Size = New System.Drawing.Size(67, 22)
        Me.lsimpan.Text = "Simpan"
        '
        'lupdate
        '
        Me.lupdate.Image = CType(resources.GetObject("lupdate.Image"), System.Drawing.Image)
        Me.lupdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.lupdate.Name = "lupdate"
        Me.lupdate.Size = New System.Drawing.Size(65, 22)
        Me.lupdate.Text = "Update"
        '
        'ldelete
        '
        Me.ldelete.Image = CType(resources.GetObject("ldelete.Image"), System.Drawing.Image)
        Me.ldelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ldelete.Name = "ldelete"
        Me.ldelete.Size = New System.Drawing.Size(60, 22)
        Me.ldelete.Text = "Delete"
        '
        'lbatal
        '
        Me.lbatal.Image = CType(resources.GetObject("lbatal.Image"), System.Drawing.Image)
        Me.lbatal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.lbatal.Name = "lbatal"
        Me.lbatal.Size = New System.Drawing.Size(53, 22)
        Me.lbatal.Text = "Batal"
        '
        'lback
        '
        Me.lback.Image = CType(resources.GetObject("lback.Image"), System.Drawing.Image)
        Me.lback.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.lback.Name = "lback"
        Me.lback.Size = New System.Drawing.Size(52, 22)
        Me.lback.Text = "Back"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbl_anggota)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.tcari)
        Me.GroupBox3.Location = New System.Drawing.Point(1, 394)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1368, 351)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'tbl_anggota
        '
        Me.tbl_anggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tbl_anggota.Location = New System.Drawing.Point(0, 62)
        Me.tbl_anggota.Name = "tbl_anggota"
        Me.tbl_anggota.Size = New System.Drawing.Size(1368, 289)
        Me.tbl_anggota.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.Perpustakaan_sebagai_Sumber_Ilmu_Pengetahuan1
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cjk)
        Me.GroupBox1.Controls.Add(Me.cprodi)
        Me.GroupBox1.Controls.Add(Me.cangkatan)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.talamat)
        Me.GroupBox1.Controls.Add(Me.tnama)
        Me.GroupBox1.Controls.Add(Me.tid)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1368, 322)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1247, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 44)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Cetak"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cjk
        '
        Me.cjk.FormattingEnabled = True
        Me.cjk.Items.AddRange(New Object() {"L", "P"})
        Me.cjk.Location = New System.Drawing.Point(632, 183)
        Me.cjk.Name = "cjk"
        Me.cjk.Size = New System.Drawing.Size(268, 21)
        Me.cjk.TabIndex = 13
        '
        'cprodi
        '
        Me.cprodi.FormattingEnabled = True
        Me.cprodi.Items.AddRange(New Object() {"S1TI", "S1DKV", "D3MI", "D3TI"})
        Me.cprodi.Location = New System.Drawing.Point(632, 237)
        Me.cprodi.Name = "cprodi"
        Me.cprodi.Size = New System.Drawing.Size(268, 21)
        Me.cprodi.TabIndex = 12
        '
        'cangkatan
        '
        Me.cangkatan.FormattingEnabled = True
        Me.cangkatan.Items.AddRange(New Object() {"2015", "2016", "2017"})
        Me.cangkatan.Location = New System.Drawing.Point(632, 210)
        Me.cangkatan.Name = "cangkatan"
        Me.cangkatan.Size = New System.Drawing.Size(268, 21)
        Me.cangkatan.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(477, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Prodi :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(476, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Angkatan :"
        '
        'talamat
        '
        Me.talamat.Location = New System.Drawing.Point(632, 157)
        Me.talamat.Name = "talamat"
        Me.talamat.Size = New System.Drawing.Size(268, 20)
        Me.talamat.TabIndex = 6
        '
        'tnama
        '
        Me.tnama.Location = New System.Drawing.Point(632, 130)
        Me.tnama.Name = "tnama"
        Me.tnama.Size = New System.Drawing.Size(268, 20)
        Me.tnama.TabIndex = 5
        '
        'tid
        '
        Me.tid.Location = New System.Drawing.Point(632, 105)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(268, 20)
        Me.tid.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(476, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(477, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(476, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Anggota :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(476, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Anggota :"
        '
        'Anggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Anggota"
        Me.Text = "Anggota"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.tbl_anggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tcari As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents talamat As System.Windows.Forms.TextBox
    Friend WithEvents tnama As System.Windows.Forms.TextBox
    Friend WithEvents tid As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lsimpan As System.Windows.Forms.ToolStripButton
    Friend WithEvents lupdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ldelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbatal As System.Windows.Forms.ToolStripButton
    Friend WithEvents lback As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cprodi As System.Windows.Forms.ComboBox
    Friend WithEvents cangkatan As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbl_anggota As System.Windows.Forms.DataGridView
    Friend WithEvents cjk As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
