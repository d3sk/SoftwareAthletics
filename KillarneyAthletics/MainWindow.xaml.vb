Class MainWindow
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        My.Computer.Audio.Play("G:\startup.wav", AudioPlayMode.WaitToComplete)
        NavFrame.NavigationService.Navigate(New MainMenu)
    End Sub
End Class