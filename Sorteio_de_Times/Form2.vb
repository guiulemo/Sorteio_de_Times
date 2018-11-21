Imports System.ComponentModel

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.CancelButton = Form1.BtnCancel
        InterromperProcesso = False
    End Sub

    Private Sub Timer3_Tick_1(sender As Object, e As EventArgs) Handles Timer3.Tick
        ContRegr.Text = ProgressBar1.Value
        ProgressBar1.Increment(-1)
        My.Computer.Audio.Play(My.Resources.heartbeat0, AudioPlayMode.Background)
        If ProgressBar1.Value = 0 Then
            Timer3.Enabled = False
            Wait(1)
            ContRegr.Visible = False
            BlocoDr.Visible = True
            Form1.Timer2.Enabled = True
            ProgressBar1.Value = 3
            ContRegr.Text = Nothing
        End If
    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        InterromperProcesso = True
        BlocoDr.Visible = False
        Form1.Timer2.Enabled = False
        ModDrTxtC.Text = Nothing
        ModDrTxtJ.Text = Nothing
        ContAuxJog.Text = Nothing
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Alt And e.KeyCode = Keys.F4 Then
            e.Handled = True
        End If
    End Sub
End Class