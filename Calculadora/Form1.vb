
''' <summary>
''' Calculadora
''' </summary>
Public Class Calculadora

    'Variable en donde se mantendrá siempre el resultado
    Public Const operacion As Decimal = 0
    Dim ValoresPermitidos() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "+", "-", "*", "/"}

    Private Sub btnNum9_Click(sender As Object, e As EventArgs) Handles btnNum9.Click
        txtOperacion.Text += "9"
    End Sub

    Private Sub btnNum8_Click(sender As Object, e As EventArgs) Handles btnNum8.Click
        txtOperacion.Text += "8"
    End Sub

    Private Sub btnNum7_Click(sender As Object, e As EventArgs) Handles btnNum7.Click
        txtOperacion.Text += "7"
    End Sub
    Private Sub btnNum6_Click(sender As Object, e As EventArgs) Handles btnNum6.Click
        txtOperacion.Text += "6"
    End Sub

    Private Sub btnNum5_Click(sender As Object, e As EventArgs) Handles btnNum5.Click
        txtOperacion.Text += "5"
    End Sub

    Private Sub btnNum4_Click(sender As Object, e As EventArgs) Handles btnNum4.Click
        txtOperacion.Text += "4"
    End Sub

    Private Sub btnNum3_Click(sender As Object, e As EventArgs) Handles btnNum3.Click
        txtOperacion.Text += "3"
    End Sub

    Private Sub btnNum2_Click(sender As Object, e As EventArgs) Handles btnNum2.Click
        txtOperacion.Text += "2"
    End Sub

    Private Sub btnNum1_Click(sender As Object, e As EventArgs) Handles btnNum1.Click
        txtOperacion.Text += "1"
    End Sub

    Private Sub btnNum0_Click(sender As Object, e As EventArgs) Handles btnNum0.Click
        txtOperacion.Text += "0"
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtOperacion.Text = String.Empty
    End Sub

    Private Sub txtOperacion_TextChanged(sender As Object, e As EventArgs) Handles txtOperacion.TextChanged
        txtOperacion.SelectionStart = txtOperacion.Text.Length
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        txtOperacion.Text += "+"
    End Sub

    Private Sub txtOperacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOperacion.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then

        End If
        Dim valor As String = ValoresPermitidos.Where(Function(x) x = e.KeyChar).FirstOrDefault
        If Not String.IsNullOrEmpty(valor) Then
            txtOperacion.Text += valor
        End If
    End Sub


End Class
