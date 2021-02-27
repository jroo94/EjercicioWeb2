Public Class Form1
    Private Sub txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSegundoNumero.KeyPress, txtPrimerNumero.KeyPress
        If Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        If Not FlValidaAntesDeCalcular() Then Exit Sub

        lblResultado.Text = txtPrimerNumero.Text / txtSegundoNumero.Text
        lblResiduo.Text = txtPrimerNumero.Text Mod txtSegundoNumero.Text

        If (txtPrimerNumero.Text Mod txtSegundoNumero.Text) = 0 Then
            lblMensaje.Text = "El número " & txtPrimerNumero.Text & " es divisible entre el número " & txtSegundoNumero.Text
        Else
            lblMensaje.Text = "El número " & txtPrimerNumero.Text & " no es divisible entre el número " & txtSegundoNumero.Text
        End If

    End Sub

    Private Function FlValidaAntesDeCalcular() As Boolean
        If txtPrimerNumero.Text = "" OrElse txtSegundoNumero.Text = "" Then
            MessageBox.Show("Favor de capturar ambos números.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        Return True
    End Function

End Class
