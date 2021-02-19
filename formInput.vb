Public Class formInput
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Me.Close()
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmLabel.Tick
		lbHeader.Visible = Not lbHeader.Visible
	End Sub

	Private Sub formInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		rbInput.Checked = True
		btEditUpdate.Text = "Edit"
		Me.btEditUpdate.Image = Global.Entahlah.My.Resources.Resources.edit_property_30px

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

		Else
			btEditUpdate.Text = "Edit"
			Me.btEditUpdate.Image = Global.Entahlah.My.Resources.Resources.edit_property_30px
		End If

	End Sub

	Private Sub rbISBN_CheckedChanged(sender As Object, e As EventArgs) Handles rbISBN.CheckedChanged
		lbISBN_CIP_Judul.Text = "ISBN  "
	End Sub

	Private Sub rbCIP_CheckedChanged(sender As Object, e As EventArgs) Handles rbCIP.CheckedChanged
		lbISBN_CIP_Judul.Text = "CIP   "
	End Sub

	Private Sub rbJudul_CheckedChanged(sender As Object, e As EventArgs) Handles rbJudul.CheckedChanged
		lbISBN_CIP_Judul.Text = "Judul  "
	End Sub

	Private Sub pnCari_Paint(sender As Object, e As PaintEventArgs) Handles pnCari.Paint

	End Sub

	Private Sub btCari_Click(sender As Object, e As EventArgs) Handles btCari.Click

	End Sub
End Class
