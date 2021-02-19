Public Class formInput
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Me.Close()
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmLabel.Tick
		lbHeader.Visible = Not lbHeader.Visible
	End Sub

	Private Sub formInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load


	End Sub

	Private Sub rbInput_CheckedChanged(sender As Object, e As EventArgs) Handles rbInput.CheckedChanged
		pnInput.Show()
		pnDGV.SendToBack()
	End Sub

	Private Sub rbData_CheckedChanged(sender As Object, e As EventArgs) Handles rbData.CheckedChanged
		pnDGV.Show()
		pnInput.SendToBack()

	End Sub

	Private Sub btEditUpdate_Click(sender As Object, e As EventArgs) Handles btEditUpdate.Click
		If btEditUpdate.Text = "Edit" Then
			btEditUpdate.Text = "Update"
		Else
			btEditUpdate.Text = "Edit"
		End If

	End Sub
End Class
