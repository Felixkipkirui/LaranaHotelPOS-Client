﻿Public Class TransaparentBG
    Dim _child As Form = Nothing

    Public Sub ShowForm(Child As Form)
        InitializeComponent()
        _child = Child
        Me.MaximizedBounds = WorkingArea
        Me.WindowState = FormWindowState.Maximized
        Me.ShowDialog()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        _child.ShowDialog()
        Me.Dispose()

    End Sub
End Class