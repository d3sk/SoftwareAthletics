Class MainMenu

    Dim longjump As String = "G:\longjump.xml"
    Dim javelin As String = "G:\javelin.xml"
    Dim discus As String = "G:\discus.xml"
    Dim fifteenM As String = "G:\1500m.xml"
    Dim twoM As String = "G:\200m.xml"

    Private Sub _200MButton_Click(sender As Object, e As RoutedEventArgs) Handles _200MButton.Click

        NavigationService.Navigate(New TwoHundredM)

    End Sub

    Private Sub _1500MButton_Click(sender As Object, e As RoutedEventArgs) Handles _1500MButton.Click

        NavigationService.Navigate(New FifteenM)

    End Sub

    Private Sub DiscusButton_Click(sender As Object, e As RoutedEventArgs) Handles DiscusButton.Click

        NavigationService.Navigate(New Discus)

    End Sub

    Private Sub JavelinButton_Click(sender As Object, e As RoutedEventArgs) Handles JavelinButton.Click

        NavigationService.Navigate(New Javelin)

    End Sub

    Private Sub LongJumpButton_Click(sender As Object, e As RoutedEventArgs) Handles LongJumpButton.Click

        NavigationService.Navigate(New LongJump)

    End Sub

    Public Sub FinalFormCheck()
        If My.Computer.FileSystem.FileExists(longjump) And My.Computer.FileSystem.FileExists(javelin) And My.Computer.FileSystem.FileExists(discus) And My.Computer.FileSystem.FileExists(fifteenM) And My.Computer.FileSystem.FileExists(twoM) Then
            FinalFormBtn.IsEnabled = True
        End If
    End Sub

    Public Sub MainMenu_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded

        FinalFormCheck()
    End Sub

    Private Sub FinalFormBtn_Click(sender As Object, e As RoutedEventArgs) Handles FinalFormBtn.Click
        NavigationService.Navigate(New FinalForm)
    End Sub
End Class
