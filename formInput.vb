Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Text


Public Class formInput

	Public ConnBRDJKT As SqlConnection
	Public ConnINV As SqlConnection
	Public Cmd As SqlCommand
	Public Dr As SqlDataReader
	Public Da As SqlDataAdapter
	Public Ds As DataSet

	Sub bersihkanTextBox()
		tbCIP.Text = ""
		tbCariIsbn.Text = ""
		tbKode.Text = ""
		tbJudul.Text = ""
		tbQty.Text = ""
		tbPetugas.Text = ""
	End Sub
	Sub konekBRDJKT()
		Try
			ConnBRDJKT = New SqlConnection("Server = SRV4 ; Initial Catalog = BRDJKT ; User ID = sa; Password = ")
			ConnBRDJKT.Open()
			Me.lbStatusBRDJKT.Text = "BRDJKT Connect"
		Catch ex As Exception
			Me.lbStatusBRDJKT.Text = "BRDJKT Not Connect"

		End Try
	End Sub

	Sub konekINV()
		Try
			ConnINV = New SqlConnection("Data Source = AERYICE-PC666\SQLEXPRESS ; Initial Catalog = INV; Integrated Security = True")
			ConnINV.Open()
			Me.lbStatusINV.Text = "INV Connect"
		Catch ex As Exception
			Me.lbStatusINV.Text = "INV Not Connect"
		End Try
	End Sub



	Private Sub formInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call KonekBRDJKT()
		Call konekINV()
		pnScanBuku.Show()
		gbCariData.Show()

		Me.ActiveControl = tbCariIsbn

		tbJudul.Enabled = False
		tbKode.Enabled = False
		rbInput.Checked = True
		btEditUpdate.Text = "Edit"
		Me.btEditUpdate.Image = Global.NonCIP.My.Resources.Resources.edit_property_30px

		rtbWeb.Visible = False
		tbWeb.Visible = False
		TbPotong.Visible = False

	End Sub
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Me.Close()
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmLabel.Tick
		lbHeader.Visible = Not lbHeader.Visible
	End Sub


	Private Sub rbInput_CheckedChanged(sender As Object, e As EventArgs) Handles rbInput.CheckedChanged
		pnInput.Show()
		pnScanBuku.Show()
		pnCari.SendToBack()
		pnDGV.SendToBack()
		lbISBN.Text = "ISBN :"
	End Sub

	Private Sub rbData_CheckedChanged(sender As Object, e As EventArgs) Handles rbData.CheckedChanged
		pnScanBuku.SendToBack()
		pnCari.Show()
		pnDGV.Show()
		pnInput.SendToBack()
		rbCIP.Checked = True


	End Sub

	Private Sub btEditUpdate_Click(sender As Object, e As EventArgs) Handles btEditUpdate.Click
		If btEditUpdate.Text = "Edit" Then
			btEditUpdate.Text = "Update"
			Me.btEditUpdate.Image = Global.NonCIP.My.Resources.Resources.data_backup_30px
			pnCari.Show()

			pnInput.SendToBack()
			pnDGV.Show()
			rbData.Checked = True
			tbCariData.Focus()

		Else
			btEditUpdate.Text = "Edit"
			Me.btEditUpdate.Image = Global.NonCIP.My.Resources.Resources.edit_property_30px

			pnScanBuku.Show()
			pnInput.Show()
			pnDGV.SendToBack()
			rbInput.Checked = True
			tbCariIsbn.Focus()
		End If

	End Sub

	Private Sub rbISBN_CheckedChanged(sender As Object, e As EventArgs) Handles rbISBN.CheckedChanged
		lbISBN_CIP_Judul.Text = "ISBN  "
		tbCariData.Focus()
	End Sub

	Private Sub rbCIP_CheckedChanged(sender As Object, e As EventArgs) Handles rbCIP.CheckedChanged
		lbISBN_CIP_Judul.Text = "CIP   "
		tbCariData.Focus()
	End Sub

	Private Sub rbJudul_CheckedChanged(sender As Object, e As EventArgs) Handles rbJudul.CheckedChanged
		lbISBN_CIP_Judul.Text = "Judul  "
		tbCariData.Focus()
	End Sub

	Private Sub btCari_Click(sender As Object, e As EventArgs) Handles btCari.Click

		Call konekBRDJKT()
		Cmd = New SqlCommand("SELECT OPTFLD4 , [DESC] FROM ICITEM WHERE ITEMNO = '" & tbCariIsbn.Text & "' ", ConnBRDJKT)
		Dr = Cmd.ExecuteReader
		Dr.Read()
		If Dr.HasRows Then
			tbKode.Text = Dr.Item("OPTFLD4")
			tbJudul.Text = Dr.Item("DESC")
			tbCIP.Focus()
			ConnBRDJKT.Close()
		Else
			Dim Str As IO.Stream
			Dim SrRead As IO.StreamReader
			Try
				Dim Request As WebRequest = WebRequest.Create("https://www.bookdepository.com/search?searchTerm='" & tbCariIsbn.Text & "' &search=Find+book")
				Dim Resp As WebResponse = Request.GetResponse()
				Str = Resp.GetResponseStream
				SrRead = New IO.StreamReader(Str)

				rtbWeb.Text = SrRead.ReadToEnd()


				Dim Words As New List(Of String)
				Dim StartIndex As Integer = 0
				While StartIndex > -1
					StartIndex = rtbWeb.Text.IndexOf("<h1 itemprop=""name"">", StartIndex)
					If StartIndex > -1 Then
						Dim EndIndex As Integer = rtbWeb.Text.IndexOf("</h1>", StartIndex)
						If EndIndex > -5 Then
							Words.Add(rtbWeb.Text.Substring(StartIndex + 20, EndIndex - StartIndex - 1))

						End If
						StartIndex = EndIndex

					End If

				End While

				'rtbWeb.Text = String.Join(Environment.NewLine, Words.ToArray).ToString
				tbWeb.Text = String.Join(Environment.NewLine, Words.ToArray).ToString
				TbPotong.Text = tbWeb.Text.Substring(0, tbWeb.Text.Length - 19)

				tbJudul.Text = TbPotong.Text
				tbCIP.Focus()


			Catch ex As Exception

			End Try


		End If

	End Sub


	Private Sub tbCariIsbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCariIsbn.KeyPress
		If e.KeyChar = Chr(13) Then
			btCari.PerformClick()
		End If

	End Sub

	Private Sub btSimpan_Click(sender As Object, e As EventArgs) Handles btSimpan.Click
		Call konekINV()
		Dim JudulBaru As String = tbJudul.Text
		JudulBaru = JudulBaru.Replace("'", "''")
		If tbCIP.Text = "" Then
			MsgBox("Kolom CIP Tidak boleh kosong", MsgBoxStyle.Critical)
			tbCIP.Focus()
		Else
			Dim Simpan As String = "INSERT INTO tanpaCIP (CIP,ISBN,Kode,Judul,Qty,Petugas,Tanggal_Input) VALUES ('" & tbCIP.Text & "','" & tbCariIsbn.Text & "','" & tbKode.Text & "','" & JudulBaru & "'," & tbQty.Text & ",'" & tbPetugas.Text & "','" & dtpTanggal.Value & "')"
			Cmd = New SqlCommand(Simpan, ConnINV)
			Cmd.ExecuteNonQuery()
			Call bersihkanTextBox()
		End If
		tbKode.Enabled = False
		tbJudul.Enabled = False


	End Sub

	Private Sub tbCIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCIP.KeyPress
		If e.KeyChar = Chr(13) Then
			If tbKode.Text = "" Then
				tbKode.Focus()
			ElseIf tbJudul.Text = "" Then
				tbJudul.Focus()
			Else
				tbQty.Focus()

			End If


		End If


	End Sub

	Private Sub tbQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbQty.KeyPress
		If e.KeyChar = Chr(13) Then
			tbPetugas.Focus()
		End If
	End Sub

	Private Sub tbPetugas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPetugas.KeyPress
		If e.KeyChar = Chr(13) Then
			btSimpan.PerformClick()
			tbCariIsbn.Focus()
		End If
	End Sub



	Private Sub tbKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbKode.KeyPress
		If e.KeyChar = Chr(13) Then
			tbJudul.Focus()
		End If

	End Sub

	Private Sub tbJudul_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbJudul.KeyPress
		If e.KeyChar = Chr(13) Then
			tbQty.Focus()
		End If

	End Sub



End Class
