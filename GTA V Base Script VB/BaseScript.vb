Imports GTA
Imports System.Windows.Forms

Public Class BaseScript
    Inherits Script

    'Load
    Public Sub New()

        Interval = 1

    End Sub

    'Update (Runs every 'Interval')
    Public Sub Update(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Tick

    End Sub

    Private Sub OnKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    Private Sub OnKeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

    End Sub

End Class
