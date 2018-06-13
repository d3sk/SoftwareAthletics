Imports System.Xml
Imports System.Media
Imports System.Threading

Class FinalForm

    Dim longjump As Object = "G:\longjump.xml"
    Dim javelin As Object = "G:\javelin.xml"
    Dim discus As Object = "G:\discus.xml"
    Dim fifteenM As Object = "G:\1500m.xml"
    Dim twoM As String = "G:\200m.xml"
    Dim CurrentFileArray(4) As String
    Dim points1 As Integer
    Dim points2 As Integer
    Dim points3 As Integer

    Public Sub parsexml()
        Try
            points1 = 0
            points2 = 0
            points3 = 0
            CurrentFileArray(0) = twoM
            CurrentFileArray(1) = fifteenM
            CurrentFileArray(2) = discus
            CurrentFileArray(3) = javelin
            CurrentFileArray(4) = longjump
            Dim xmld As XmlDocument
            Dim nodelist As XmlNodeList
            Dim node As XmlNode
            xmld = New XmlDocument()

            For i = 0 To CurrentFileArray.Length - 1
                Dim file As String = CurrentFileArray(i).ToString()
                xmld.Load(file)

                nodelist = xmld.SelectNodes("/CompetitorDetails/Competitor")

                For Each node In nodelist

                    Dim idAttribute = node.Attributes.GetNamedItem("id").Value


                    If idAttribute = 1 Then

                        If file = twoM Then
                            Dim nameValue = node.ChildNodes.Item(0).InnerText
                            Comp1Name.Text = nameValue

                            Dim twoMPlacing = node.ChildNodes.Item(2).InnerText
                            comp1200m.Text = twoMPlacing

                            If twoMPlacing = 1 Then
                                points1 += 3
                            ElseIf twoMPlacing = 2 Then
                                points1 += 2
                            Else
                                points1 += 1
                            End If

                        End If

                        If file = fifteenM Then
                            Dim fifteenMPlacing = node.ChildNodes.Item(2).InnerText
                            comp11500m.Text = fifteenMPlacing

                            If fifteenMPlacing = 1 Then
                                points1 += 3
                            ElseIf fifteenMPlacing = 2 Then
                                points1 += 2
                            Else
                                points1 += 1
                            End If
                        End If

                        If file = discus Then
                            Dim discusPlacing = node.ChildNodes.Item(2).InnerText
                            comp1Discus.Text = discusPlacing
                            If discusPlacing = 1 Then
                                points1 += 3
                            ElseIf discusPlacing = 2 Then
                                points1 += 2
                            Else
                                points1 += 1
                            End If
                        End If

                        If file = javelin Then
                            Dim javelinPlacing = node.ChildNodes.Item(2).InnerText
                            comp1Javelin.Text = javelinPlacing
                            If javelinPlacing = 1 Then
                                points1 += 3
                            ElseIf javelinPlacing = 2 Then
                                points1 += 2
                            Else
                                points1 += 1
                            End If
                        End If

                        If file = longjump Then
                            Dim longjumpPlacing = node.ChildNodes.Item(2).InnerText
                            comp1LongJump.Text = longjumpPlacing
                            If longjumpPlacing = 1 Then
                                points1 += 3
                            ElseIf longjumpPlacing = 2 Then
                                points1 += 2
                            Else
                                points1 += 1
                            End If
                        End If

                        comp1Points.Text = points1


                    ElseIf idAttribute = 2 Then

                        If file = twoM Then
                            Dim nameValue = node.ChildNodes.Item(0).InnerText
                            comp2Name.Text = nameValue
                            Dim twoMPlacing = node.ChildNodes.Item(2).InnerText
                            comp2200m.Text = twoMPlacing

                            If twoMPlacing = 1 Then
                                points2 += 3
                            ElseIf twoMPlacing = 2 Then
                                points2 += 2
                            Else
                                points2 += 1
                            End If
                        End If

                        If file = fifteenM Then
                            Dim fifteenMPlacing = node.ChildNodes.Item(2).InnerText
                            comp21500m.Text = fifteenMPlacing
                            If fifteenMPlacing = 1 Then
                                points2 += 3
                            ElseIf fifteenMPlacing = 2 Then
                                points2 += 2
                            Else
                                points2 += 1
                            End If
                        End If

                        If file = discus Then
                            Dim discusPlacing = node.ChildNodes.Item(2).InnerText
                            comp2Discus.Text = discusPlacing

                            If discusPlacing = 1 Then
                                points2 += 3
                            ElseIf discusPlacing = 2 Then
                                points2 += 2
                            Else
                                points2 += 1
                            End If
                        End If

                        If file = javelin Then
                            Dim javelinPlacing = node.ChildNodes.Item(2).InnerText
                            comp2Javelin.Text = javelinPlacing

                            If javelinPlacing = 1 Then
                                points2 += 3
                            ElseIf javelinPlacing = 2 Then
                                points2 += 2
                            Else
                                points2 += 1
                            End If
                        End If

                        If file = longjump Then
                            Dim longjumpPlacing = node.ChildNodes.Item(2).InnerText
                            comp2LongJump.Text = longjumpPlacing
                            If longjumpPlacing = 1 Then
                                points2 += 3
                            ElseIf longjumpPlacing = 2 Then
                                points2 += 2
                            Else
                                points2 += 1
                            End If
                        End If

                        comp2Points.Text = points2

                    ElseIf idAttribute = 3 Then

                        If file = twoM Then
                            Dim nameValue = node.ChildNodes.Item(0).InnerText
                            comp3Name.Text = nameValue
                            Dim twoMPlacing = node.ChildNodes.Item(2).InnerText
                            comp3200m.Text = twoMPlacing

                            If twoMPlacing = 1 Then
                                points3 += 3
                            ElseIf twoMPlacing = 2 Then
                                points3 += 2
                            Else
                                points3 += 1
                            End If
                        End If

                        If file = fifteenM Then
                            Dim fifteenMPlacing = node.ChildNodes.Item(2).InnerText
                            comp31500m.Text = fifteenMPlacing
                            If fifteenMPlacing = 1 Then
                                points3 += 3
                            ElseIf fifteenMPlacing = 2 Then
                                points3 += 2
                            Else
                                points3 += 1
                            End If

                        End If

                        If file = discus Then
                            Dim discusPlacing = node.ChildNodes.Item(2).InnerText
                            comp3Discus.Text = discusPlacing

                            If discusPlacing = 1 Then
                                points3 += 3
                            ElseIf discusPlacing = 2 Then
                                points3 += 2
                            Else
                                points3 += 1
                            End If
                        End If

                        If file = javelin Then
                            Dim javelinPlacing = node.ChildNodes.Item(2).InnerText
                            comp3Javelin.Text = javelinPlacing

                            If javelinPlacing = 1 Then
                                points3 += 3
                            ElseIf javelinPlacing = 2 Then
                                points3 += 2
                            Else
                                points3 += 1
                            End If
                        End If

                        If file = longjump Then
                            Dim longjumpPlacing = node.ChildNodes.Item(2).InnerText
                            comp3LongJump.Text = longjumpPlacing
                            If longjumpPlacing = 1 Then
                                points3 += 3
                            ElseIf longjumpPlacing = 2 Then
                                points3 += 2
                            Else
                                points3 += 1
                            End If
                        End If
                        comp3Points.Text = points3
                    End If
                Next
            Next
        Catch errorVariable As Exception
            Console.Write(errorVariable.ToString())
        End Try
    End Sub

    Public Sub allocatePlacings()

        If points1 > points2 And points1 > points3 Then

            comp1Placing.Text = 1

            If points2 > points3 Then

                comp2Placing.Text = 2
                comp3Placing.Text = 3

            Else

                comp3Placing.Text = 2
                comp2Placing.Text = 3

            End If

        ElseIf points2 > points1 And points2 > points3 Then

            comp2Placing.Text = 1

            If points1 > points3 Then

                comp1Placing.Text = 2
                comp3Placing.Text = 3

            Else

                comp3Placing.Text = 2
                comp1Placing.Text = 3

            End If

        ElseIf points3 > points1 And points3 > points2 Then

            comp3Placing.Text = 1

            If points2 > points1 Then

                comp2Placing.Text = 2
                comp1Placing.Text = 3

            Else

                comp1Placing.Text = 2
                comp2Placing.Text = 3

            End If

        ElseIf points1 = points2 And points1 <> points3 Then

            If points1 > points3 Then

                comp3Placing.Text = 3

                If comp1200m.Text > comp2200m.Text Then

                    comp1Placing.Text = 1
                    comp2Placing.Text = 2

                ElseIf comp1200m.Text < comp2200m.Text Then

                    comp1Placing.Text = 2
                    comp2Placing.Text = 1

                End If

            ElseIf points1 < points3 Then

                comp3Placing.Text = 1

            End If

        End If

    End Sub

    Private Sub FinalForm_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim player As New SoundPlayer("G:\stellar.WAV")
        player.Play()
        parsexml()
        allocatePlacings()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As RoutedEventArgs) Handles BackButton.Click

        If MessageBox.Show("Are you sure you want to exit? You still have submitted data in the form.", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) = MessageBoxResult.Yes Then

            NavigationService.Navigate(New MainMenu)

        End If

    End Sub

End Class
