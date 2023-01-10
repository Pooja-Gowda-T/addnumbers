Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim result As Integer = Int32.Parse(Text1.Text) + Int32.Parse(Text2.Text)
        tb.Text = result.ToString()
    End Sub


End Class
