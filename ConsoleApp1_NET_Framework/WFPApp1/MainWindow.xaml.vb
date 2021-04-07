Class MainWindow
    Private Sub TextBox_TextChanged(sender As Object, e As TextChangedEventArgs)

    End Sub

    Private Sub btn_Click(sender As Object, e As RoutedEventArgs) Handles btn.Click
        txtBlock1.Text = DateTime.Now.DayOfWeek.ToString
    End Sub

    'Private Sub txtBox1_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtBox1.TextChanged
    '    txtBlock1.Text = txtBox1.Text
    'End Sub

    Private Sub txtBox1_TouchEnter(sender As Object, e As TouchEventArgs) Handles txtBox1.TouchEnter

    End Sub
End Class
