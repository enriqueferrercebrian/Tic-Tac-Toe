Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class TicTacToe

    Dim newButton As Button



    Private Sub TicTacToe_Load(sender As Object, e As EventArgs) Handles Me.Load

        PrepareGameTable()

    End Sub


    Private Sub PrepareGameTable()
        Dim positionX As Integer
        Dim positionY As Integer
        Dim buttonsList As New ArrayList



        For index = 1 To 9 Step 1

            newButton = New Button
            newButton.Width = Panel1.Width / 3
            newButton.Height = Panel1.Height / 3
            newButton.Tag = index

            Select Case index
                Case 1 To 3
                    newButton.Left = positionX
                    newButton.Top = positionY
                    positionX += newButton.Width
                Case 4 To 6
                    positionY = newButton.Height
                    If positionX > ((Panel1.Width / 3) * 2.5) Then
                        positionX = 0
                    End If
                    newButton.Left = positionX
                    newButton.Top = positionY
                    positionX += newButton.Width
                Case 7 To 9
                    positionY = newButton.Height * 2
                    If positionX > ((Panel1.Width / 3) * 2.5) Then
                        positionX = 0
                    End If
                    newButton.Left = positionX
                    newButton.Top = positionY
                    positionX += newButton.Width
            End Select
            buttonsList.Add(newButton)
            newButton.Parent = Panel1
            AddHandler newButton.Click, AddressOf Buttons_Click


        Next

    End Sub

    Private Sub Buttons_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        MsgBox(btn.Tag)
    End Sub


    Private Sub modeChange()




    End Sub

    Private Sub help_Click(sender As Object, e As EventArgs) Handles help.Click
        Dim help = New Help
        help.Show()

    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click


        MsgBox("Se va a cerrar el formulario y el programa")

        End

    End Sub
End Class
