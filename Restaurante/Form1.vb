Public Class Form1
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If cmb_tipo.SelectedItem = "Menu 1" Then
            txt_sub.Text = 2
        End If
    End Sub
End Class
