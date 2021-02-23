Imports System.Data.SqlClient

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
			ConnBRDJKT = New SqlConnection("Data Source = AERYICE-PC666\SQLEXPRESS ; Initial Catalog = BRDJKT ; Integrated Security = True")
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
		Me.btEditUpdate.Image = Global.Entahlah.My.Resources.Resources.edit_property_30px

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
			Me.btEditUpdate.Image = Global.Entahlah.My.Resources.Resources.data_backup_30px
			pnCari.Show()

			pnInput.SendToBack()
			pnDGV.Show()
			rbData.Checked = True
			tbCariData.Focus()

		Else
			btEditUpdate.Text = "Edit"
			Me.btEditUpdate.Image = Global.Entahlah.My.Resources.Resources.edit_property_30px

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
		End If
		tbCIP.Focus()
	End Sub


	Private Sub tbCariIsbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCariIsbn.KeyPress
		If e.KeyChar = Chr(13) Then
			btCari.PerformClick()
		End If

	End Sub

	Private Sub btSimpan_Click(sender As Object, e As EventArgs) Handles btSimpan.Click
		Call konekINV()
		Dim Simpan As String = "INSERT INTO tanpaCIP (CIP,ISBN,Kode,Judul,Qty,Petugas,Tanggal_Input) VALUES ('" & tbCIP.Text & "','" & tbCariIsbn.Text & "','" & tbKode.Text & "','" & tbJudul.Text & "'," & tbQty.Text & ",'" & tbPetugas.Text & "','" & dtpTanggal.Value & "')"
		Cmd = New SqlCommand(Simpan, ConnINV)
		Cmd.ExecuteNonQuery()
		Call bersihkanTextBox()

	End Sub

	Private Sub tbCIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCIP.KeyPress
		If e.KeyChar = Chr(13) Then
			tbQty.Focus()
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
		End If
	End Sub
End Class
