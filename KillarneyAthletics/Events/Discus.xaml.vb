Imports System.Xml

Class Discus
    Dim submitted = False
    Dim invalid = False
    Dim longjumpArray(12) As String
    Dim currentFile As String = "G:\discus.xml"
    Dim time As String = DateTime.Now.ToString("dd/MM/yy HH:mm")
    Dim datareset As Boolean = False
    Dim errorPlacing As String = "Placings: Invalid"

    Class Competitor
        Public Sub New(ByVal name As String, ByVal result As Double, ByVal placing As Integer, ByVal points As Integer)
            ' Set fields.
            Me._name = name
            Me._result = result
            Me._placing = placing
            Me._points = points
        End Sub

        ' Storage of employee data.
        Public _name As String
        Public _result As Double
        Public _placing As Integer
        Public _points As Integer
    End Class

    Public Sub WriteXML()

        Try
            Dim competitors(2) As Competitor
            competitors(0) = New Competitor(Comp1Name.Text, Comp1Result.Text, comp1Placing.Text, comp1Points.Text)
            competitors(1) = New Competitor(comp2Name.Text, comp2Result.Text, comp2Placing.Text, comp2Points.Text)
            competitors(2) = New Competitor(comp3Name.Text, comp3Result.Text, comp3Placing.Text, comp3Points.Text)

            Dim count As Integer = 1

            Dim settings As XmlWriterSettings = New XmlWriterSettings()

            Using writer As XmlWriter = XmlWriter.Create(currentFile, settings)

                writer.WriteStartDocument()
                writer.WriteStartElement("CompetitorDetails")

                Dim competitor As Competitor

                For Each competitor In competitors

                    writer.WriteStartElement("Competitor")
                    writer.WriteAttributeString("id", count)

                    writer.WriteElementString("Name", competitor._name)
                    writer.WriteElementString("Result", competitor._result.ToString)
                    writer.WriteElementString("Placing", competitor._placing.ToString)
                    writer.WriteElementString("Points", competitor._points.ToString)
                    writer.WriteEndElement()

                    count += 1

                Next

                writer.WriteEndElement()
                writer.WriteEndDocument()

            End Using

            Dim loadhistory As String = history.Items.Add("Saved - " + time)

        Catch ex As Exception

            If comp1placingLabel.Content = errorPlacing Then
                MessageBox.Show("Please fix one or more of the errors consiting within the competitors placings.")
            ElseIf comp2placingLabel.Content = errorPlacing Then
                MessageBox.Show("Please fix one or more of the errors consiting within the competitors placings.")
            ElseIf comp3placingLabel.Content = errorPlacing Then
                MessageBox.Show("Please fix one or more of the errors consiting within the competitors placings.")
            Else
                MessageBox.Show(ex.Message)

            End If

        End Try


    End Sub

    Public Sub ParseXML()
        Dim m_xmlr As XmlTextReader
        m_xmlr = New XmlTextReader(currentFile)
        m_xmlr.WhitespaceHandling = WhitespaceHandling.None
        m_xmlr.Read()
        m_xmlr.Read()

        While Not m_xmlr.EOF

            m_xmlr.Read()

            If Not m_xmlr.IsStartElement() Then

                Exit While

            End If

            Dim idAttribute = m_xmlr.GetAttribute("id")
            m_xmlr.Read()
            Dim NameValue = m_xmlr.ReadElementString("Name")
            Dim ResultValue = m_xmlr.ReadElementString("Result")
            Dim PlacingValue = m_xmlr.ReadElementString("Placing")
            Dim PointsValue = m_xmlr.ReadElementString("Points")

            If idAttribute = 1 Then
                Comp1Name.Text = NameValue
                Comp1Result.Text = ResultValue
                comp1Placing.Text = PlacingValue
                comp1Points.Text = PointsValue
            ElseIf idAttribute = 2 Then
                comp2Name.Text = NameValue
                comp2Result.Text = ResultValue
                comp2Placing.Text = PlacingValue
                comp2Points.Text = PointsValue
            Else
                comp3Name.Text = NameValue
                comp3Result.Text = ResultValue
                comp3Placing.Text = PlacingValue
                comp3Points.Text = PointsValue
            End If

        End While

        m_xmlr.Close()

        history.Items.Add("Load - " + time)

    End Sub

    Private Sub validationfalse1()
        invalid = False
        comp1placingLabel.Content = "Placinf:"
    End Sub

    Private Sub validationfalse2()
        invalid = False
        comp2placingLabel.Content = "Placinf:"
    End Sub

    Private Sub validationfalse3()
        invalid = False
        comp3placingLabel.Content = "Placinf:"
    End Sub

    Private Sub comp1Placing_KeyUp(sender As Object, e As KeyEventArgs) Handles comp1Placing.KeyUp

        If comp1Placing.Text = "1" Then

            comp1Points.Text = "3"
            validationfalse1()

        ElseIf comp1Placing.Text = "2" Then

            comp1Points.Text = "2"
            validationfalse1()

        ElseIf comp1Placing.Text = "3" Then

            comp1Points.Text = "1"
            validationfalse1()

        ElseIf comp1Placing.Text <> "1" <> "2" <> "3" Then

            comp1placingLabel.Content = errorPlacing
            invalid = False
            comp1Points.Clear()

        End If
    End Sub

    Private Sub comp2Placing_KeyUp(sender As Object, e As KeyEventArgs) Handles comp2Placing.KeyUp

        If comp2Placing.Text = "1" Then

            comp2Points.Text = "3"
            validationfalse2()

        ElseIf comp2Placing.Text = "2" Then

            comp2Points.Text = "2"
            validationfalse2()

        ElseIf comp2Placing.Text = "3" Then

            comp1Points.Text = "1"
            validationfalse2()

        ElseIf comp2Placing.Text <> "1" <> "2" <> "3" Then

            comp2placingLabel.Content = errorPlacing
            invalid = False
            comp2Points.Clear()

        End If
    End Sub

    Private Sub comp3Placing_KeyUp(sender As Object, e As KeyEventArgs) Handles comp3Placing.KeyUp

        If comp3Placing.Text = "1" Then

            comp3Points.Text = "3"
            validationfalse3()

        ElseIf comp3Placing.Text = "2" Then

            comp3Points.Text = "2"
            validationfalse3()

        ElseIf comp3Placing.Text = "3" Then

            comp3Points.Text = "1"
            validationfalse3()

        ElseIf comp3Placing.Text <> "1" <> "2" <> "3" Then

            comp3placingLabel.Content = errorPlacing
            invalid = False
            comp3Points.Clear()

        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As RoutedEventArgs) Handles BackButton.Click



        If MessageBox.Show("Are you sure you want to exit? You still have submitted data in the form.", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) = MessageBoxResult.Yes Then

            NavigationService.Navigate(New MainMenu)

        End If


    End Sub

    Private Sub LongJump_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded

        If My.Computer.FileSystem.FileExists(currentFile) Then

            ParseXML()

        End If

    End Sub

    Private Sub Submit_Click(sender As Object, e As RoutedEventArgs) Handles Submit.Click

        If invalid = True Then

            MessageBox.Show("One or more of the boxes in the form are invalid, please fix this issue before submitting again", "Question", MessageBoxButton.OK, MessageBoxImage.Warning)

        Else

            WriteXML()

        End If

    End Sub

    Private Sub Reset_Click(sender As Object, e As RoutedEventArgs) Handles Reset.Click

        If MessageBox.Show("Are you sure you want to reset all entered data, including locally stored data?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) = MessageBoxResult.Yes Then

            Comp1Name.Clear()
            Comp1Result.Clear()
            comp1Placing.Clear()
            comp1Points.Clear()
            comp2Name.Clear()
            comp2Result.Clear()
            comp2Placing.Clear()
            comp2Points.Clear()
            comp3Name.Clear()
            comp3Result.Clear()
            comp3Placing.Clear()
            comp3Points.Clear()

            validationfalse1()
            validationfalse2()
            validationfalse3()

            If My.Computer.FileSystem.FileExists(currentFile) Then

                My.Computer.FileSystem.DeleteFile(currentFile)

            End If

            history.Items.Add("Reset - " + time)

        Else

        End If
    End Sub
End Class
