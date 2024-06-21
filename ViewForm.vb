Public Class ViewForm
    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Enable the form to handle key events
        Me.KeyPreview = True

        ' Load default values if no new data is entered
        If String.IsNullOrEmpty(FormData.Namelabel1) Then FormData.Namelabel1 = "John Doe"
        If String.IsNullOrEmpty(FormData.Email) Then FormData.Email = "johndoe@gmail.com"
        If String.IsNullOrEmpty(FormData.Phone) Then FormData.Phone = "9876543210"
        If String.IsNullOrEmpty(FormData.Github) Then FormData.Github = "https://github.com/john_doe/my_slidely_task/"
        If String.IsNullOrEmpty(FormData.Stopwatch) Then FormData.Stopwatch = "00:01:19"

        ' Load data into text areas
        namearea.Text = FormData.Namelabel1
        emailarea.Text = FormData.Email
        phonearea.Text = FormData.Phone
        githbarea.Text = FormData.Github
        stopwatcharea.Text = FormData.Stopwatch

        ' Set read-only properties
        namearea.ReadOnly = True
        emailarea.ReadOnly = True
        phonearea.ReadOnly = True
        githbarea.ReadOnly = True
        stopwatcharea.ReadOnly = True
    End Sub

    Private Sub previous_btn_Click(sender As Object, e As EventArgs) Handles previous_btn.Click
        ' Navigate to MainForm
        Dim mainForm As New MainForm()
        mainForm.Show()
        Me.Close()
    End Sub

    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        ' Navigate to CreateForm
        Dim createForm As New CreateForm()
        createForm.Show()
        Me.Close()
    End Sub

    Private Sub ViewForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Handle keyboard shortcuts
        If e.Control AndAlso e.KeyCode = Keys.P Then
            previous_btn.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            next_btn.PerformClick()
        End If
    End Sub
End Class
