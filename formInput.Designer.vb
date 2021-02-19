<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formInput
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
		Me.components = New System.ComponentModel.Container()
		Me.pnWindows = New System.Windows.Forms.Panel()
		Me.lbHeader = New System.Windows.Forms.Label()
		Me.tmLabel = New System.Windows.Forms.Timer(Me.components)
		Me.gbInputBuku = New System.Windows.Forms.GroupBox()
		Me.tbCariIsbn = New System.Windows.Forms.TextBox()
		Me.lbISBN = New System.Windows.Forms.Label()
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		Me.gbScan = New System.Windows.Forms.GroupBox()
		Me.gbDataBuku = New System.Windows.Forms.GroupBox()
		Me.lbCIP = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.tbKode = New System.Windows.Forms.TextBox()
		Me.lbKode = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.lbJudul = New System.Windows.Forms.Label()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.lbQty = New System.Windows.Forms.Label()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.lbPetugas = New System.Windows.Forms.Label()
		Me.gbCRUD = New System.Windows.Forms.GroupBox()
		Me.gbMenu = New System.Windows.Forms.GroupBox()
		Me.rbInput = New System.Windows.Forms.RadioButton()
		Me.rbData = New System.Windows.Forms.RadioButton()
		Me.pnInput = New System.Windows.Forms.Panel()
		Me.pnDGV = New System.Windows.Forms.Panel()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.btDelete = New System.Windows.Forms.Button()
		Me.btEditUpdate = New System.Windows.Forms.Button()
		Me.btSimpan = New System.Windows.Forms.Button()
		Me.btCari = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.btMaximize = New System.Windows.Forms.Button()
		Me.btMinimize = New System.Windows.Forms.Button()
		Me.pnWindows.SuspendLayout()
		Me.gbInputBuku.SuspendLayout()
		Me.gbScan.SuspendLayout()
		Me.gbDataBuku.SuspendLayout()
		Me.gbCRUD.SuspendLayout()
		Me.gbMenu.SuspendLayout()
		Me.pnInput.SuspendLayout()
		Me.pnDGV.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'pnWindows
		'
		Me.pnWindows.BackColor = System.Drawing.Color.Azure
		Me.pnWindows.Controls.Add(Me.Button1)
		Me.pnWindows.Controls.Add(Me.btMaximize)
		Me.pnWindows.Controls.Add(Me.btMinimize)
		Me.pnWindows.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnWindows.Location = New System.Drawing.Point(0, 0)
		Me.pnWindows.Name = "pnWindows"
		Me.pnWindows.Size = New System.Drawing.Size(800, 32)
		Me.pnWindows.TabIndex = 0
		'
		'lbHeader
		'
		Me.lbHeader.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lbHeader.AutoSize = True
		Me.lbHeader.Font = New System.Drawing.Font("Lucida Console", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbHeader.Location = New System.Drawing.Point(129, 47)
		Me.lbHeader.Name = "lbHeader"
		Me.lbHeader.Size = New System.Drawing.Size(521, 35)
		Me.lbHeader.TabIndex = 1
		Me.lbHeader.Text = "Form Input Buku Non CIP"
		'
		'tmLabel
		'
		Me.tmLabel.Enabled = True
		Me.tmLabel.Interval = 350
		'
		'gbInputBuku
		'
		Me.gbInputBuku.BackColor = System.Drawing.Color.LightBlue
		Me.gbInputBuku.Controls.Add(Me.gbMenu)
		Me.gbInputBuku.Controls.Add(Me.gbCRUD)
		Me.gbInputBuku.Controls.Add(Me.gbDataBuku)
		Me.gbInputBuku.Controls.Add(Me.gbScan)
		Me.gbInputBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.gbInputBuku.Location = New System.Drawing.Point(12, 85)
		Me.gbInputBuku.Name = "gbInputBuku"
		Me.gbInputBuku.Size = New System.Drawing.Size(776, 353)
		Me.gbInputBuku.TabIndex = 2
		Me.gbInputBuku.TabStop = False
		'
		'tbCariIsbn
		'
		Me.tbCariIsbn.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbCariIsbn.Location = New System.Drawing.Point(117, 27)
		Me.tbCariIsbn.Name = "tbCariIsbn"
		Me.tbCariIsbn.Size = New System.Drawing.Size(168, 28)
		Me.tbCariIsbn.TabIndex = 1
		'
		'lbISBN
		'
		Me.lbISBN.AutoSize = True
		Me.lbISBN.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbISBN.Location = New System.Drawing.Point(6, 30)
		Me.lbISBN.Name = "lbISBN"
		Me.lbISBN.Size = New System.Drawing.Size(108, 24)
		Me.lbISBN.TabIndex = 0
		Me.lbISBN.Text = "ISBN : "
		'
		'gbScan
		'
		Me.gbScan.Controls.Add(Me.btCari)
		Me.gbScan.Controls.Add(Me.tbCariIsbn)
		Me.gbScan.Controls.Add(Me.lbISBN)
		Me.gbScan.Location = New System.Drawing.Point(6, 19)
		Me.gbScan.Name = "gbScan"
		Me.gbScan.Size = New System.Drawing.Size(324, 76)
		Me.gbScan.TabIndex = 2
		Me.gbScan.TabStop = False
		Me.gbScan.Text = "Scan Buku"
		'
		'gbDataBuku
		'
		Me.gbDataBuku.Controls.Add(Me.pnInput)
		Me.gbDataBuku.Controls.Add(Me.pnDGV)
		Me.gbDataBuku.Location = New System.Drawing.Point(6, 101)
		Me.gbDataBuku.Name = "gbDataBuku"
		Me.gbDataBuku.Size = New System.Drawing.Size(764, 246)
		Me.gbDataBuku.TabIndex = 3
		Me.gbDataBuku.TabStop = False
		Me.gbDataBuku.Text = "Data Buku"
		'
		'lbCIP
		'
		Me.lbCIP.AutoSize = True
		Me.lbCIP.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbCIP.Location = New System.Drawing.Point(8, 19)
		Me.lbCIP.Name = "lbCIP"
		Me.lbCIP.Size = New System.Drawing.Size(164, 24)
		Me.lbCIP.TabIndex = 3
		Me.lbCIP.Text = "CIP      : "
		'
		'TextBox1
		'
		Me.TextBox1.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox1.Location = New System.Drawing.Point(178, 14)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(57, 31)
		Me.TextBox1.TabIndex = 3
		'
		'tbKode
		'
		Me.tbKode.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbKode.Location = New System.Drawing.Point(178, 51)
		Me.tbKode.Name = "tbKode"
		Me.tbKode.Size = New System.Drawing.Size(89, 31)
		Me.tbKode.TabIndex = 4
		'
		'lbKode
		'
		Me.lbKode.AutoSize = True
		Me.lbKode.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbKode.Location = New System.Drawing.Point(8, 54)
		Me.lbKode.Name = "lbKode"
		Me.lbKode.Size = New System.Drawing.Size(164, 24)
		Me.lbKode.TabIndex = 5
		Me.lbKode.Text = "Kode     : "
		'
		'TextBox2
		'
		Me.TextBox2.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox2.Location = New System.Drawing.Point(178, 88)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(279, 31)
		Me.TextBox2.TabIndex = 6
		'
		'lbJudul
		'
		Me.lbJudul.AutoSize = True
		Me.lbJudul.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbJudul.Location = New System.Drawing.Point(8, 88)
		Me.lbJudul.Name = "lbJudul"
		Me.lbJudul.Size = New System.Drawing.Size(164, 24)
		Me.lbJudul.TabIndex = 7
		Me.lbJudul.Text = "Judul    : "
		'
		'TextBox3
		'
		Me.TextBox3.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox3.Location = New System.Drawing.Point(178, 126)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(43, 31)
		Me.TextBox3.TabIndex = 8
		'
		'lbQty
		'
		Me.lbQty.AutoSize = True
		Me.lbQty.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbQty.Location = New System.Drawing.Point(8, 122)
		Me.lbQty.Name = "lbQty"
		Me.lbQty.Size = New System.Drawing.Size(164, 24)
		Me.lbQty.TabIndex = 9
		Me.lbQty.Text = "Qty      : "
		'
		'TextBox4
		'
		Me.TextBox4.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox4.Location = New System.Drawing.Point(178, 163)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(140, 31)
		Me.TextBox4.TabIndex = 10
		'
		'lbPetugas
		'
		Me.lbPetugas.AutoSize = True
		Me.lbPetugas.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbPetugas.Location = New System.Drawing.Point(8, 156)
		Me.lbPetugas.Name = "lbPetugas"
		Me.lbPetugas.Size = New System.Drawing.Size(164, 24)
		Me.lbPetugas.TabIndex = 11
		Me.lbPetugas.Text = "Petugas  : "
		'
		'gbCRUD
		'
		Me.gbCRUD.Controls.Add(Me.btDelete)
		Me.gbCRUD.Controls.Add(Me.btEditUpdate)
		Me.gbCRUD.Controls.Add(Me.btSimpan)
		Me.gbCRUD.Location = New System.Drawing.Point(336, 19)
		Me.gbCRUD.Name = "gbCRUD"
		Me.gbCRUD.Size = New System.Drawing.Size(326, 76)
		Me.gbCRUD.TabIndex = 4
		Me.gbCRUD.TabStop = False
		Me.gbCRUD.Text = "CRUD"
		'
		'gbMenu
		'
		Me.gbMenu.Controls.Add(Me.rbData)
		Me.gbMenu.Controls.Add(Me.rbInput)
		Me.gbMenu.Location = New System.Drawing.Point(668, 19)
		Me.gbMenu.Name = "gbMenu"
		Me.gbMenu.Size = New System.Drawing.Size(102, 76)
		Me.gbMenu.TabIndex = 5
		Me.gbMenu.TabStop = False
		Me.gbMenu.Text = "Menu"
		'
		'rbInput
		'
		Me.rbInput.AutoSize = True
		Me.rbInput.Location = New System.Drawing.Point(9, 19)
		Me.rbInput.Name = "rbInput"
		Me.rbInput.Size = New System.Drawing.Size(49, 17)
		Me.rbInput.TabIndex = 0
		Me.rbInput.TabStop = True
		Me.rbInput.Text = "Input"
		Me.rbInput.UseVisualStyleBackColor = True
		'
		'rbData
		'
		Me.rbData.AutoSize = True
		Me.rbData.Location = New System.Drawing.Point(9, 42)
		Me.rbData.Name = "rbData"
		Me.rbData.Size = New System.Drawing.Size(90, 17)
		Me.rbData.TabIndex = 1
		Me.rbData.TabStop = True
		Me.rbData.Text = "DataGridView"
		Me.rbData.UseVisualStyleBackColor = True
		'
		'pnInput
		'
		Me.pnInput.Controls.Add(Me.TextBox2)
		Me.pnInput.Controls.Add(Me.TextBox4)
		Me.pnInput.Controls.Add(Me.lbCIP)
		Me.pnInput.Controls.Add(Me.lbPetugas)
		Me.pnInput.Controls.Add(Me.TextBox1)
		Me.pnInput.Controls.Add(Me.TextBox3)
		Me.pnInput.Controls.Add(Me.lbKode)
		Me.pnInput.Controls.Add(Me.lbQty)
		Me.pnInput.Controls.Add(Me.tbKode)
		Me.pnInput.Controls.Add(Me.lbJudul)
		Me.pnInput.Location = New System.Drawing.Point(6, 16)
		Me.pnInput.Name = "pnInput"
		Me.pnInput.Size = New System.Drawing.Size(752, 221)
		Me.pnInput.TabIndex = 12
		'
		'pnDGV
		'
		Me.pnDGV.Controls.Add(Me.DataGridView1)
		Me.pnDGV.Location = New System.Drawing.Point(6, 19)
		Me.pnDGV.Name = "pnDGV"
		Me.pnDGV.Size = New System.Drawing.Size(745, 221)
		Me.pnDGV.TabIndex = 12
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(739, 209)
		Me.DataGridView1.TabIndex = 0
		'
		'btDelete
		'
		Me.btDelete.BackgroundImage = Global.Entahlah.My.Resources.Resources.delete_bin_30px
		Me.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btDelete.Location = New System.Drawing.Point(222, 21)
		Me.btDelete.Name = "btDelete"
		Me.btDelete.Size = New System.Drawing.Size(98, 34)
		Me.btDelete.TabIndex = 2
		Me.btDelete.Text = "Delete"
		Me.btDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btDelete.UseVisualStyleBackColor = True
		'
		'btEditUpdate
		'
		Me.btEditUpdate.BackgroundImage = Global.Entahlah.My.Resources.Resources.delete_bin_30px
		Me.btEditUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btEditUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btEditUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btEditUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btEditUpdate.Location = New System.Drawing.Point(101, 20)
		Me.btEditUpdate.Name = "btEditUpdate"
		Me.btEditUpdate.Size = New System.Drawing.Size(115, 34)
		Me.btEditUpdate.TabIndex = 1
		Me.btEditUpdate.Text = "Edit"
		Me.btEditUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btEditUpdate.UseVisualStyleBackColor = True
		'
		'btSimpan
		'
		Me.btSimpan.BackgroundImage = Global.Entahlah.My.Resources.Resources.save_30px
		Me.btSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btSimpan.Location = New System.Drawing.Point(6, 21)
		Me.btSimpan.Name = "btSimpan"
		Me.btSimpan.Size = New System.Drawing.Size(80, 34)
		Me.btSimpan.TabIndex = 0
		Me.btSimpan.Text = "Save"
		Me.btSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btSimpan.UseVisualStyleBackColor = True
		'
		'btCari
		'
		Me.btCari.BackgroundImage = Global.Entahlah.My.Resources.Resources.search_30px
		Me.btCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btCari.FlatAppearance.BorderSize = 0
		Me.btCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btCari.Location = New System.Drawing.Point(291, 27)
		Me.btCari.Name = "btCari"
		Me.btCari.Size = New System.Drawing.Size(33, 28)
		Me.btCari.TabIndex = 2
		Me.btCari.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.LightBlue
		Me.Button1.BackgroundImage = Global.Entahlah.My.Resources.Resources.close_window_32px1
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(768, 0)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(32, 32)
		Me.Button1.TabIndex = 3
		Me.Button1.UseVisualStyleBackColor = False
		'
		'btMaximize
		'
		Me.btMaximize.BackColor = System.Drawing.Color.LightBlue
		Me.btMaximize.BackgroundImage = Global.Entahlah.My.Resources.Resources.maximize_window_32px
		Me.btMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btMaximize.Location = New System.Drawing.Point(730, 0)
		Me.btMaximize.Name = "btMaximize"
		Me.btMaximize.Size = New System.Drawing.Size(32, 32)
		Me.btMaximize.TabIndex = 2
		Me.btMaximize.UseVisualStyleBackColor = False
		'
		'btMinimize
		'
		Me.btMinimize.BackColor = System.Drawing.Color.LightBlue
		Me.btMinimize.BackgroundImage = Global.Entahlah.My.Resources.Resources.minimize_window_32px
		Me.btMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btMinimize.Location = New System.Drawing.Point(692, 0)
		Me.btMinimize.Name = "btMinimize"
		Me.btMinimize.Size = New System.Drawing.Size(32, 32)
		Me.btMinimize.TabIndex = 1
		Me.btMinimize.UseVisualStyleBackColor = False
		'
		'formInput
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Aqua
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.gbInputBuku)
		Me.Controls.Add(Me.lbHeader)
		Me.Controls.Add(Me.pnWindows)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "formInput"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form Input"
		Me.pnWindows.ResumeLayout(False)
		Me.gbInputBuku.ResumeLayout(False)
		Me.gbScan.ResumeLayout(False)
		Me.gbScan.PerformLayout()
		Me.gbDataBuku.ResumeLayout(False)
		Me.gbCRUD.ResumeLayout(False)
		Me.gbMenu.ResumeLayout(False)
		Me.gbMenu.PerformLayout()
		Me.pnInput.ResumeLayout(False)
		Me.pnInput.PerformLayout()
		Me.pnDGV.ResumeLayout(False)
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents pnWindows As Panel
	Friend WithEvents btMinimize As Button
	Friend WithEvents btMaximize As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents lbHeader As Label
	Friend WithEvents tmLabel As Timer
	Friend WithEvents gbInputBuku As GroupBox
	Friend WithEvents tbCariIsbn As TextBox
	Friend WithEvents lbISBN As Label
	Friend WithEvents gbScan As GroupBox
	Friend WithEvents btCari As Button
	Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
	Friend WithEvents gbDataBuku As GroupBox
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents lbCIP As Label
	Friend WithEvents gbCRUD As GroupBox
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents lbPetugas As Label
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents lbQty As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents lbJudul As Label
	Friend WithEvents tbKode As TextBox
	Friend WithEvents lbKode As Label
	Friend WithEvents gbMenu As GroupBox
	Friend WithEvents rbData As RadioButton
	Friend WithEvents rbInput As RadioButton
	Friend WithEvents pnInput As Panel
	Friend WithEvents pnDGV As Panel
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents btSimpan As Button
	Friend WithEvents btEditUpdate As Button
	Friend WithEvents btDelete As Button
End Class
