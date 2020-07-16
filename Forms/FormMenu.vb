Public Class FormMenu
    Private Sub InputSiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputSiswaToolStripMenuItem.Click
        FormInputSiswa.Show()
    End Sub

    Private Sub InputGuruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputGuruToolStripMenuItem.Click
        FormInputGuru.Show()
    End Sub

    Private Sub InputStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputStaffToolStripMenuItem.Click
        FormInputStaff.Show()
    End Sub
End Class