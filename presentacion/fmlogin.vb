Public Class fmlogin
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblhora.Text = TimeOfDay
    End Sub
    Private Sub fmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblhora.Text = TimeOfDay
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Try
            Dim dts As New vusuario
            Dim func As New fusuario

            dts.glogin = txtlogin.Text
            dts.gpassword = txtpassword.Text

            If func.validar_usuario(dts) = True Then
                fminicio.Show()
                Me.Hide()
            Else
                MsgBox("Sus datos son incorrectos, ingrese nuevamente sus datos", MsgBoxStyle.Exclamation, "Acceso denegado al sistema")
                txtpassword.Clear()
                txtpassword.Focus()


            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    
    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtpassword.Text <> "" And txtlogin.Text <> "" Then
                Me.btningresar.Focus()
            End If
        End If
    End Sub


    Private Sub txtlogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlogin.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtlogin.Text <> "" Then
                Me.txtpassword.Focus()
            End If
        End If
    End Sub


End Class


