Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Enable the form to handle key events
        Me.KeyPreview = True
    End Sub

    Private Sub ViewForm_btn_Click(sender As Object, e As EventArgs) Handles ViewForm_btn.Click
        ' Open the View Submissions form
        Dim viewForm As New ViewForm()
        viewForm.Show()
    End Sub

    Private Sub CreateForm_btn_Click(sender As Object, e As EventArgs) Handles CreateForm_btn.Click
        ' Open the Create New Submission form
        Dim createForm As New CreateForm()
        createForm.Show()
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Handle keyboard shortcuts
        If e.Control AndAlso e.KeyCode = Keys.X Then
            ViewForm_btn.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            CreateForm_btn.PerformClick()
        End If
    End Sub
End Class


