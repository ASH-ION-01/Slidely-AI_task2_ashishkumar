Public Class CreateForm
    Private isStopwatchRunning As Boolean = False
    Private startTime As DateTime
    Private WithEvents Timer1 As New Timer()

    Private Sub CreateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        ' Configure Timer1
        Timer1.Interval = 1000 ' 1 second interval
    End Sub

    Private Sub Submitform_Click(sender As Object, e As EventArgs) Handles Submitform.Click
        ' Store data (assuming FormData is a class or structure holding these properties)
        FormData.Namelabel1 = namewrite.Text
        FormData.Email = emailwrite.Text
        FormData.Phone = phonewrite.Text
        FormData.Github = githubwrite.Text
        FormData.Stopwatch = stopwatchtimer.Text

        ' Show submission alert
        MessageBox.Show("Data submitted successfully!", "Submission", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Navigate to ViewForm
        Dim viewForm As New ViewForm()
        viewForm.Show()
        Me.Close()
    End Sub

    Private Sub togglestopwatch_btn_Click(sender As Object, e As EventArgs) Handles togglestopwatch_btn.Click
        If Not isStopwatchRunning Then
            ' Start stopwatch
            isStopwatchRunning = True
            startTime = DateTime.Now
            togglestopwatch_btn.Text = "Stop Stopwatch"
            ' Start the timer to update UI every second
            Timer1.Start()
        Else
            ' Stop stopwatch
            isStopwatchRunning = False
            togglestopwatch_btn.Text = "Start Stopwatch"
            ' Stop the timer
            Timer1.Stop()
            ' Calculate elapsed time
            Dim elapsedTime As TimeSpan = DateTime.Now - startTime
            ' Display elapsed time formatted as HH:mm:ss
            stopwatchtimer.Text = elapsedTime.ToString("hh\:mm\:ss")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update stopwatch timer continuously
        Dim elapsedTime As TimeSpan = DateTime.Now - startTime
        stopwatchtimer.Text = elapsedTime.ToString("hh\:mm\:ss")
    End Sub

    Private Sub namewrite_TextChanged(sender As Object, e As EventArgs) Handles namewrite.TextChanged
        ' Handle text changed event for name field if needed
    End Sub

    Private Sub CreateForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Handle keyboard shortcuts
        If e.Control AndAlso e.KeyCode = Keys.T Then
            togglestopwatch_btn.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            Submitform.PerformClick()
        End If
    End Sub
End Class
