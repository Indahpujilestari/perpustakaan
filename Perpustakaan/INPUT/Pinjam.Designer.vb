<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pinjam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pinjam))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tcari = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbl_pinjam = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsimpan = New System.Windows.Forms.ToolStripButton()
        Me.tdelete = New System.Windows.Forms.ToolStripButton()
        Me.tbatal = New System.Windows.Forms.ToolStripButton()
        Me.tback = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtanggalkembali = New System.Windows.Forms.DateTimePicker()
        Me.dtanggalpinjam = New System.Windows.Forms.DateTimePicker()
        Me.bcaribuku = New System.Windows.Forms.Button()
        Me.bcarianggota = New System.Windows.Forms.Button()
        Me.tjudulbuku = New System.Windows.Forms.TextBox()
        Me.tidbuku = New System.Windows.Forms.TextBox()
        Me.tnama = New System.Windows.Forms.TextBox()
        Me.tidanggota = New System.Windows.Forms.TextBox()
        Me.tidpinjam = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.tbl_pinjam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tcari)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(-1, 394)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1373, 51)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'tcari
        '
        Me.tcari.Location = New System.Drawing.Point(951, 19)
        Me.tcari.Name = "tcari"
        Me.tcari.Size = New System.Drawing.Size(190, 20)
        Me.tcari.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(870, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Cari :"
        '
        'tbl_pinjam
        '
        Me.tbl_pinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tbl_pinjam.Location = New System.Drawing.Point(-1, 439)
        Me.tbl_pinjam.Name = "tbl_pinjam"
        Me.tbl_pinjam.Size = New System.Drawing.Size(1373, 312)
        Me.tbl_pinjam.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Location = New System.Drawing.Point(-1, 364)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1373, 43)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsimpan, Me.tdelete, Me.tbatal, Me.tback})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1367, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsimpan
        '
        Me.tsimpan.Image = CType(resources.GetObject("tsimpan.Image"), System.Drawing.Image)
        Me.tsimpan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsimpan.Name = "tsimpan"
        Me.tsimpan.Size = New System.Drawing.Size(67, 22)
        Me.tsimpan.Text = "Simpan"
        '
        'tdelete
        '
        Me.tdelete.Image = CType(resources.GetObject("tdelete.Image"), System.Drawing.Image)
        Me.tdelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tdelete.Name = "tdelete"
        Me.tdelete.Size = New System.Drawing.Size(60, 22)
        Me.tdelete.Text = "Delete"
        '
        'tbatal
        '
        Me.tbatal.Image = CType(resources.GetObject("tbatal.Image"), System.Drawing.Image)
        Me.tbatal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbatal.Name = "tbatal"
        Me.tbatal.Size = New System.Drawing.Size(53, 22)
        Me.tbatal.Text = "Batal"
        '
        'tback
        '
        Me.tback.Image = CType(resources.GetObject("tback.Image"), System.Drawing.Image)
        Me.tback.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tback.Name = "tback"
        Me.tback.Size = New System.Drawing.Size(52, 22)
        Me.tback.Text = "Back"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.Perpustakaan_sebagai_Sumber_Ilmu_Pengetahuan1
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.dtanggalkembali)
        Me.GroupBox1.Controls.Add(Me.dtanggalpinjam)
        Me.GroupBox1.Controls.Add(Me.bcaribuku)
        Me.GroupBox1.Controls.Add(Me.bcarianggota)
        Me.GroupBox1.Controls.Add(Me.tjudulbuku)
        Me.GroupBox1.Controls.Add(Me.tidbuku)
        Me.GroupBox1.Controls.Add(Me.tnama)
        Me.GroupBox1.Controls.Add(Me.tidanggota)
        Me.GroupBox1.Controls.Add(Me.tidpinjam)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1373, 380)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1199, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 33)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Cetak"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 64)
        Me.Panel1.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(497, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(384, 33)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "INPUT DATA PEMINJAMAN"
        '
        'dtanggalkembali
        '
        Me.dtanggalkembali.Location = New System.Drawing.Point(628, 276)
        Me.dtanggalkembali.Name = "dtanggalkembali"
        Me.dtanggalkembali.Size = New System.Drawing.Size(273, 20)
        Me.dtanggalkembali.TabIndex = 18
        '
        'dtanggalpinjam
        '
        Me.dtanggalpinjam.Location = New System.Drawing.Point(628, 250)
        Me.dtanggalpinjam.Name = "dtanggalpinjam"
        Me.dtanggalpinjam.Size = New System.Drawing.Size(273, 20)
        Me.dtanggalpinjam.TabIndex = 17
        '
        'bcaribuku
        '
        Me.bcaribuku.Location = New System.Drawing.Point(791, 198)
        Me.bcaribuku.Name = "bcaribuku"
        Me.bcaribuku.Size = New System.Drawing.Size(110, 46)
        Me.bcaribuku.TabIndex = 16
        Me.bcaribuku.Text = "Cari Buku"
        Me.bcaribuku.UseVisualStyleBackColor = True
        '
        'bcarianggota
        '
        Me.bcarianggota.Location = New System.Drawing.Point(791, 146)
        Me.bcarianggota.Name = "bcarianggota"
        Me.bcarianggota.Size = New System.Drawing.Size(110, 46)
        Me.bcarianggota.TabIndex = 15
        Me.bcarianggota.Text = "Cari Anggota"
        Me.bcarianggota.UseVisualStyleBackColor = True
        '
        'tjudulbuku
        '
        Me.tjudulbuku.Location = New System.Drawing.Point(628, 224)
        Me.tjudulbuku.Name = "tjudulbuku"
        Me.tjudulbuku.Size = New System.Drawing.Size(157, 20)
        Me.tjudulbuku.TabIndex = 12
        '
        'tidbuku
        '
        Me.tidbuku.Location = New System.Drawing.Point(628, 198)
        Me.tidbuku.Name = "tidbuku"
        Me.tidbuku.Size = New System.Drawing.Size(157, 20)
        Me.tidbuku.TabIndex = 11
        '
        'tnama
        '
        Me.tnama.Location = New System.Drawing.Point(628, 172)
        Me.tnama.Name = "tnama"
        Me.tnama.Size = New System.Drawing.Size(157, 20)
        Me.tnama.TabIndex = 10
        '
        'tidanggota
        '
        Me.tidanggota.Location = New System.Drawing.Point(628, 146)
        Me.tidanggota.Name = "tidanggota"
        Me.tidanggota.Size = New System.Drawing.Size(157, 20)
        Me.tidanggota.TabIndex = 9
        '
        'tidpinjam
        '
        Me.tidpinjam.Location = New System.Drawing.Point(628, 120)
        Me.tidpinjam.Name = "tidpinjam"
        Me.tidpinjam.Size = New System.Drawing.Size(273, 20)
        Me.tidpinjam.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(482, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Tanggal Kembali :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(482, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tanggal Peminjaman :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(482, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Judul Buku :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(482, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Id Buku :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(482, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(482, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Id Anggota :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(482, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id Pinjam :"
        '
        'Pinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.tbl_pinjam)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Pinjam"
        Me.Text = "Pinjem"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.tbl_pinjam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tbl_pinjam As System.Windows.Forms.DataGridView
    Friend WithEvents tjudulbuku As System.Windows.Forms.TextBox
    Friend WithEvents tidbuku As System.Windows.Forms.TextBox
    Friend WithEvents tnama As System.Windows.Forms.TextBox
    Friend WithEvents tidanggota As System.Windows.Forms.TextBox
    Friend WithEvents tidpinjam As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tcari As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtanggalkembali As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtanggalpinjam As System.Windows.Forms.DateTimePicker
    Friend WithEvents bcaribuku As System.Windows.Forms.Button
    Friend WithEvents bcarianggota As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsimpan As System.Windows.Forms.ToolStripButton
    Friend WithEvents tdelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbatal As System.Windows.Forms.ToolStripButton
    Friend WithEvents tback As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
