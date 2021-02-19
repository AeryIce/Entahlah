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
		Me.gbMenu = New System.Windows.Forms.GroupBox()
		Me.rbData = New System.Windows.Forms.RadioButton()
		Me.rbInput = New System.Windows.Forms.RadioButton()
		Me.gbCRUD = New System.Windows.Forms.GroupBox()
		Me.gbDataBuku = New System.Windows.Forms.GroupBox()
		Me.pnInput = New System.Windows.Forms.Panel()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.lbCIP = New System.Windows.Forms.Label()
		Me.lbPetugas = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.lbKode = New System.Windows.Forms.Label()
		Me.lbQty = New System.Windows.Forms.Label()
		Me.tbKode = New System.Windows.Forms.TextBox()
		Me.lbJudul = New System.Windows.Forms.Label()
		Me.pnDGV = New System.Windows.Forms.Panel()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.gbScan = New System.Windows.Forms.GroupBox()
		Me.tbCariIsbn = New System.Windows.Forms.TextBox()
		Me.lbISBN = New System.Windows.Forms.Label()
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		Me.gbLapor = New System.Windows.Forms.GroupBox()
		Me.lbLaporCIP = New System.Windows.Forms.Label()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.btDelete = New System.Windows.Forms.Button()
		Me.btEditUpdate = New System.Windows.Forms.Button()
		Me.btSimpan = New System.Windows.Forms.Button()
		Me.btCetak = New System.Windows.Forms.Button()
		Me.btEmailLapor = New System.Windows.Forms.Button()
		Me.btCari = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.btMaximize = New System.Windows.Forms.Button()
		Me.btMinimize = New System.Windows.Forms.Button()
		Me.pnCari = New System.Windows.Forms.Panel()
		Me.gbCariData = New System.Windows.Forms.GroupBox()
		Me.lbISBN_CIP_Judul = New System.Windows.Forms.Label()
		Me.tbCariData = New System.Windows.Forms.TextBox()
		Me.rbISBN = New System.Windows.Forms.RadioButton()
		Me.rbCIP = New System.Windows.Forms.RadioButton()
		Me.rbJudul = New System.Windows.Forms.RadioButton()
		Me.pnScanBuku = New System.Windows.Forms.Panel()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.pnWindows.SuspendLayout()
		Me.gbInputBuku.SuspendLayout()
		Me.gbMenu.SuspendLayout()
		Me.gbCRUD.SuspendLayout()
		Me.gbDataBuku.SuspendLayout()
		Me.pnInput.SuspendLayout()
		Me.pnDGV.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbScan.SuspendLayout()
		Me.gbLapor.SuspendLayout()
		Me.pnCari.SuspendLayout()
		Me.gbCariData.SuspendLayout()
		Me.pnScanBuku.SuspendLayout()
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
		Me.gbInputBuku.Controls.Add(Me.pnScanBuku)
		Me.gbInputBuku.Controls.Add(Me.gbMenu)
		Me.gbInputBuku.Controls.Add(Me.gbCRUD)
		Me.gbInputBuku.Controls.Add(Me.gbDataBuku)
		Me.gbInputBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.gbInputBuku.Location = New System.Drawing.Point(12, 85)
		Me.gbInputBuku.Name = "gbInputBuku"
		Me.gbInputBuku.Size = New System.Drawing.Size(776, 353)
		Me.gbInputBuku.TabIndex = 2
		Me.gbInputBuku.TabStop = False
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
		'gbDataBuku
		'
		Me.gbDataBuku.Controls.Add(Me.pnDGV)
		Me.gbDataBuku.Controls.Add(Me.pnInput)
		Me.gbDataBuku.Location = New System.Drawing.Point(6, 101)
		Me.gbDataBuku.Name = "gbDataBuku"
		Me.gbDataBuku.Size = New System.Drawing.Size(764, 246)
		Me.gbDataBuku.TabIndex = 3
		Me.gbDataBuku.TabStop = False
		Me.gbDataBuku.Text = "Data Buku"
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
		'TextBox2
		'
		Me.TextBox2.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox2.Location = New System.Drawing.Point(178, 88)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(279, 31)
		Me.TextBox2.TabIndex = 6
		'
		'TextBox4
		'
		Me.TextBox4.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox4.Location = New System.Drawing.Point(178, 163)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(140, 31)
		Me.TextBox4.TabIndex = 10
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
		'TextBox1
		'
		Me.TextBox1.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox1.Location = New System.Drawing.Point(178, 14)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(57, 31)
		Me.TextBox1.TabIndex = 3
		'
		'TextBox3
		'
		Me.TextBox3.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox3.Location = New System.Drawing.Point(178, 126)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(43, 31)
		Me.TextBox3.TabIndex = 8
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
		'tbKode
		'
		Me.tbKode.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbKode.Location = New System.Drawing.Point(178, 51)
		Me.tbKode.Name = "tbKode"
		Me.tbKode.Size = New System.Drawing.Size(89, 31)
		Me.tbKode.TabIndex = 4
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
		'pnDGV
		'
		Me.pnDGV.Controls.Add(Me.pnCari)
		Me.pnDGV.Controls.Add(Me.gbLapor)
		Me.pnDGV.Controls.Add(Me.DataGridView1)
		Me.pnDGV.Location = New System.Drawing.Point(6, 19)
		Me.pnDGV.Name = "pnDGV"
		Me.pnDGV.Size = New System.Drawing.Size(745, 221)
		Me.pnDGV.TabIndex = 12
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(3, 0)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(582, 209)
		Me.DataGridView1.TabIndex = 0
		'
		'gbScan
		'
		Me.gbScan.Controls.Add(Me.tbCariIsbn)
		Me.gbScan.Controls.Add(Me.btCari)
		Me.gbScan.Controls.Add(Me.lbISBN)
		Me.gbScan.Location = New System.Drawing.Point(3, 3)
		Me.gbScan.Name = "gbScan"
		Me.gbScan.Size = New System.Drawing.Size(313, 70)
		Me.gbScan.TabIndex = 2
		Me.gbScan.TabStop = False
		Me.gbScan.Text = "Scan Buku"
		'
		'tbCariIsbn
		'
		Me.tbCariIsbn.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbCariIsbn.Location = New System.Drawing.Point(105, 29)
		Me.tbCariIsbn.Name = "tbCariIsbn"
		Me.tbCariIsbn.Size = New System.Drawing.Size(145, 28)
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
		'gbLapor
		'
		Me.gbLapor.Controls.Add(Me.btCetak)
		Me.gbLapor.Controls.Add(Me.btEmailLapor)
		Me.gbLapor.Controls.Add(Me.TextBox5)
		Me.gbLapor.Controls.Add(Me.lbLaporCIP)
		Me.gbLapor.Location = New System.Drawing.Point(594, 0)
		Me.gbLapor.Name = "gbLapor"
		Me.gbLapor.Size = New System.Drawing.Size(144, 212)
		Me.gbLapor.TabIndex = 1
		Me.gbLapor.TabStop = False
		Me.gbLapor.Text = "Lapor"
		'
		'lbLaporCIP
		'
		Me.lbLaporCIP.AutoSize = True
		Me.lbLaporCIP.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbLaporCIP.Location = New System.Drawing.Point(7, 23)
		Me.lbLaporCIP.Name = "lbLaporCIP"
		Me.lbLaporCIP.Size = New System.Drawing.Size(81, 19)
		Me.lbLaporCIP.TabIndex = 0
		Me.lbLaporCIP.Text = "CIP : "
		'
		'TextBox5
		'
		Me.TextBox5.Location = New System.Drawing.Point(79, 22)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(59, 20)
		Me.TextBox5.TabIndex = 1
		'
		'btDelete
		'
		Me.btDelete.BackgroundImage = Global.Entahlah.My.Resources.Resources.delete_bin_30px
		Me.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btDelete.Location = New System.Drawing.Point(221, 21)
		Me.btDelete.Name = "btDelete"
		Me.btDelete.Size = New System.Drawing.Size(98, 34)
		Me.btDelete.TabIndex = 2
		Me.btDelete.Text = "Delete"
		Me.btDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btDelete.UseVisualStyleBackColor = True
		'
		'btEditUpdate
		'
		Me.btEditUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btEditUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btEditUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btEditUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btEditUpdate.Location = New System.Drawing.Point(96, 21)
		Me.btEditUpdate.Name = "btEditUpdate"
		Me.btEditUpdate.Size = New System.Drawing.Size(115, 34)
		Me.btEditUpdate.TabIndex = 1
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
		'btCetak
		'
		Me.btCetak.BackgroundImage = Global.Entahlah.My.Resources.Resources.print_24px
		Me.btCetak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btCetak.Location = New System.Drawing.Point(36, 123)
		Me.btCetak.Name = "btCetak"
		Me.btCetak.Size = New System.Drawing.Size(84, 33)
		Me.btCetak.TabIndex = 3
		Me.btCetak.Text = "Cetak"
		Me.btCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btCetak.UseVisualStyleBackColor = True
		'
		'btEmailLapor
		'
		Me.btEmailLapor.BackgroundImage = Global.Entahlah.My.Resources.Resources.send_email_24px
		Me.btEmailLapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btEmailLapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btEmailLapor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btEmailLapor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btEmailLapor.Location = New System.Drawing.Point(36, 75)
		Me.btEmailLapor.Name = "btEmailLapor"
		Me.btEmailLapor.Size = New System.Drawing.Size(84, 33)
		Me.btEmailLapor.TabIndex = 2
		Me.btEmailLapor.Text = "Lapor"
		Me.btEmailLapor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btEmailLapor.UseVisualStyleBackColor = True
		'
		'btCari
		'
		Me.btCari.BackgroundImage = Global.Entahlah.My.Resources.Resources.search_30px
		Me.btCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btCari.FlatAppearance.BorderSize = 0
		Me.btCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btCari.Location = New System.Drawing.Point(267, 29)
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
		'pnCari
		'
		Me.pnCari.Controls.Add(Me.gbCariData)
		Me.pnCari.Location = New System.Drawing.Point(21, 33)
		Me.pnCari.Name = "pnCari"
		Me.pnCari.Size = New System.Drawing.Size(324, 76)
		Me.pnCari.TabIndex = 3
		'
		'gbCariData
		'
		Me.gbCariData.Controls.Add(Me.Button2)
		Me.gbCariData.Controls.Add(Me.rbJudul)
		Me.gbCariData.Controls.Add(Me.rbCIP)
		Me.gbCariData.Controls.Add(Me.rbISBN)
		Me.gbCariData.Controls.Add(Me.tbCariData)
		Me.gbCariData.Controls.Add(Me.lbISBN_CIP_Judul)
		Me.gbCariData.Location = New System.Drawing.Point(6, 8)
		Me.gbCariData.Name = "gbCariData"
		Me.gbCariData.Size = New System.Drawing.Size(318, 65)
		Me.gbCariData.TabIndex = 0
		Me.gbCariData.TabStop = False
		Me.gbCariData.Text = "Cari Data"
		'
		'lbISBN_CIP_Judul
		'
		Me.lbISBN_CIP_Judul.AutoSize = True
		Me.lbISBN_CIP_Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbISBN_CIP_Judul.Location = New System.Drawing.Point(6, 28)
		Me.lbISBN_CIP_Judul.Name = "lbISBN_CIP_Judul"
		Me.lbISBN_CIP_Judul.Size = New System.Drawing.Size(12, 16)
		Me.lbISBN_CIP_Judul.TabIndex = 0
		Me.lbISBN_CIP_Judul.Text = "."
		'
		'tbCariData
		'
		Me.tbCariData.Location = New System.Drawing.Point(51, 25)
		Me.tbCariData.Name = "tbCariData"
		Me.tbCariData.Size = New System.Drawing.Size(150, 20)
		Me.tbCariData.TabIndex = 1
		'
		'rbISBN
		'
		Me.rbISBN.AutoSize = True
		Me.rbISBN.Location = New System.Drawing.Point(258, 25)
		Me.rbISBN.Name = "rbISBN"
		Me.rbISBN.Size = New System.Drawing.Size(50, 17)
		Me.rbISBN.TabIndex = 2
		Me.rbISBN.TabStop = True
		Me.rbISBN.Text = "ISBN"
		Me.rbISBN.UseVisualStyleBackColor = True
		'
		'rbCIP
		'
		Me.rbCIP.AutoSize = True
		Me.rbCIP.Location = New System.Drawing.Point(258, 8)
		Me.rbCIP.Name = "rbCIP"
		Me.rbCIP.Size = New System.Drawing.Size(42, 17)
		Me.rbCIP.TabIndex = 3
		Me.rbCIP.TabStop = True
		Me.rbCIP.Text = "CIP"
		Me.rbCIP.UseVisualStyleBackColor = True
		'
		'rbJudul
		'
		Me.rbJudul.AutoSize = True
		Me.rbJudul.Location = New System.Drawing.Point(258, 42)
		Me.rbJudul.Name = "rbJudul"
		Me.rbJudul.Size = New System.Drawing.Size(50, 17)
		Me.rbJudul.TabIndex = 4
		Me.rbJudul.TabStop = True
		Me.rbJudul.Text = "Judul"
		Me.rbJudul.UseVisualStyleBackColor = True
		'
		'pnScanBuku
		'
		Me.pnScanBuku.Controls.Add(Me.gbScan)
		Me.pnScanBuku.Location = New System.Drawing.Point(12, 19)
		Me.pnScanBuku.Name = "pnScanBuku"
		Me.pnScanBuku.Size = New System.Drawing.Size(318, 76)
		Me.pnScanBuku.TabIndex = 6
		'
		'Button2
		'
		Me.Button2.BackgroundImage = Global.Entahlah.My.Resources.Resources.search_30px
		Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Location = New System.Drawing.Point(207, 17)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(31, 34)
		Me.Button2.TabIndex = 5
		Me.Button2.UseVisualStyleBackColor = True
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
		Me.gbMenu.ResumeLayout(False)
		Me.gbMenu.PerformLayout()
		Me.gbCRUD.ResumeLayout(False)
		Me.gbDataBuku.ResumeLayout(False)
		Me.pnInput.ResumeLayout(False)
		Me.pnInput.PerformLayout()
		Me.pnDGV.ResumeLayout(False)
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbScan.ResumeLayout(False)
		Me.gbScan.PerformLayout()
		Me.gbLapor.ResumeLayout(False)
		Me.gbLapor.PerformLayout()
		Me.pnCari.ResumeLayout(False)
		Me.gbCariData.ResumeLayout(False)
		Me.gbCariData.PerformLayout()
		Me.pnScanBuku.ResumeLayout(False)
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
	Friend WithEvents gbLapor As GroupBox
	Friend WithEvents btEmailLapor As Button
	Friend WithEvents TextBox5 As TextBox
	Friend WithEvents lbLaporCIP As Label
	Friend WithEvents btCetak As Button
	Friend WithEvents pnCari As Panel
	Friend WithEvents gbCariData As GroupBox
	Friend WithEvents rbJudul As RadioButton
	Friend WithEvents rbCIP As RadioButton
	Friend WithEvents rbISBN As RadioButton
	Friend WithEvents tbCariData As TextBox
	Friend WithEvents lbISBN_CIP_Judul As Label
	Friend WithEvents pnScanBuku As Panel
	Friend WithEvents Button2 As Button
End Class
