Public Class fmbackupbase

    Private Sub btnbackup_Click(sender As Object, e As EventArgs) Handles btnbackup.Click
        Try
            Dim fun As New fbackup
            If fun.backupbase Then
                MessageBox.Show("Backup Generado Satifactoriamente", "Backup BD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("El Backup no puede ser Generado", "Backup BD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()
    End Sub

End Class