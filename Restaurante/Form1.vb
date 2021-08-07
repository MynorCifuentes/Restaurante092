Public Class Form1

    Const precio1 As Double = 24.99
    Const precio2 As Double = 19.99
    Const precio3 As Double = 34.99
    Const precio4 As Double = 39.99
    Dim subtotal As Double = 0
    Dim subtotal2 As Double = 0
    Const agrandado As Double = 3.0
    Const descuento As Double = 0.03
    Dim opcion As Integer
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If cmb_tipo.SelectedItem = "Menu 1" Then
            subtotal = precio1 * txt_cantidad.Text


            opcion = MsgBox("Desea agrandar su menu", vbQuestion + vbYesNo + vbDefaultButton2, "Restaurante Baby ❤")
            If opcion = vbYes Then
                subtotal2 = subtotal2 + subtotal + agrandado
            Else
                subtotal2 = subtotal2 + subtotal
            End If

            txt_sub.Text = subtotal2
        ElseIf cmb_tipo.SelectedItem = "Menu 2" Then
            subtotal = precio2 * txt_cantidad.Text
            opcion = MsgBox("Desea agrandar su menu", vbQuestion + vbYesNo + vbDefaultButton2, "Restaurante Baby ❤")
            If opcion = vbYes Then
                subtotal2 = subtotal2 + subtotal + agrandado
            Else
                subtotal2 = subtotal2 + subtotal
            End If
            txt_sub.Text = subtotal2
        ElseIf cmb_tipo.SelectedItem = "Menu 3" Then
            subtotal = precio3 * txt_cantidad.Text
            opcion = MsgBox("Desea agrandar su menu", vbQuestion + vbYesNo + vbDefaultButton2, "Restaurante Baby ❤")
            If opcion = vbYes Then
                subtotal2 = subtotal2 + subtotal + agrandado
            Else
                subtotal2 = subtotal2 + subtotal
            End If
            txt_sub.Text = subtotal2
        ElseIf cmb_tipo.SelectedItem = "Menu 4" Then
            subtotal = precio4 * txt_cantidad.Text
            opcion = MsgBox("Desea agrandar su menu", vbQuestion + vbYesNo + vbDefaultButton2, "Restaurante Baby ❤")
            If opcion = vbYes Then
                subtotal2 = subtotal2 + subtotal + agrandado
            Else
                subtotal2 = subtotal2 + subtotal
            End If
            txt_sub.Text = subtotal2
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        txt_total.Text = txt_sub.Text
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        txt_total.Text = txt_sub.Text - txt_sub.Text * descuento
    End Sub
End Class
