<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.namelabel1 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        Me.github = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.Label()
        Me.togglestopwatch_btn = New System.Windows.Forms.Button()
        Me.Submitform = New System.Windows.Forms.Button()
        Me.stopwatchtimer = New System.Windows.Forms.RichTextBox()
        Me.namewrite = New System.Windows.Forms.RichTextBox()
        Me.githubwrite = New System.Windows.Forms.RichTextBox()
        Me.phonewrite = New System.Windows.Forms.RichTextBox()
        Me.emailwrite = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(495, 29)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Ashish kumar, Task 2 - Sildely Form App"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'namelabel1
        '
        Me.namelabel1.AutoSize = True
        Me.namelabel1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namelabel1.Location = New System.Drawing.Point(46, 151)
        Me.namelabel1.Name = "namelabel1"
        Me.namelabel1.Size = New System.Drawing.Size(79, 33)
        Me.namelabel1.TabIndex = 1
        Me.namelabel1.Text = "Name"
        Me.namelabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(45, 211)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(80, 33)
        Me.email.TabIndex = 2
        Me.email.Text = "Email"
        '
        'github
        '
        Me.github.AutoSize = True
        Me.github.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.github.Location = New System.Drawing.Point(12, 332)
        Me.github.Name = "github"
        Me.github.Size = New System.Drawing.Size(158, 33)
        Me.github.TabIndex = 3
        Me.github.Text = "Github Link "
        '
        'phone
        '
        Me.phone.AutoSize = True
        Me.phone.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone.Location = New System.Drawing.Point(12, 268)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(146, 33)
        Me.phone.TabIndex = 4
        Me.phone.Text = "Phone Num"
        '
        'togglestopwatch_btn
        '
        Me.togglestopwatch_btn.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.togglestopwatch_btn.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.togglestopwatch_btn.Location = New System.Drawing.Point(12, 424)
        Me.togglestopwatch_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.togglestopwatch_btn.Name = "togglestopwatch_btn"
        Me.togglestopwatch_btn.Size = New System.Drawing.Size(291, 59)
        Me.togglestopwatch_btn.TabIndex = 5
        Me.togglestopwatch_btn.Text = "TOGGLE STOPWATCH(CTRL+T)"
        Me.togglestopwatch_btn.UseVisualStyleBackColor = False
        '
        'Submitform
        '
        Me.Submitform.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Submitform.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submitform.Location = New System.Drawing.Point(12, 512)
        Me.Submitform.Name = "Submitform"
        Me.Submitform.Size = New System.Drawing.Size(486, 77)
        Me.Submitform.TabIndex = 7
        Me.Submitform.Text = "SUBMIT (CTRL + S)"
        Me.Submitform.UseVisualStyleBackColor = False
        '
        'stopwatchtimer
        '
        Me.stopwatchtimer.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.stopwatchtimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stopwatchtimer.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopwatchtimer.Location = New System.Drawing.Point(318, 424)
        Me.stopwatchtimer.Name = "stopwatchtimer"
        Me.stopwatchtimer.Size = New System.Drawing.Size(180, 59)
        Me.stopwatchtimer.TabIndex = 8
        Me.stopwatchtimer.Text = ""
        '
        'namewrite
        '
        Me.namewrite.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namewrite.Location = New System.Drawing.Point(194, 151)
        Me.namewrite.Name = "namewrite"
        Me.namewrite.Size = New System.Drawing.Size(304, 40)
        Me.namewrite.TabIndex = 9
        Me.namewrite.Text = ""
        '
        'githubwrite
        '
        Me.githubwrite.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.githubwrite.Location = New System.Drawing.Point(194, 325)
        Me.githubwrite.Name = "githubwrite"
        Me.githubwrite.Size = New System.Drawing.Size(304, 40)
        Me.githubwrite.TabIndex = 10
        Me.githubwrite.Text = ""
        '
        'phonewrite
        '
        Me.phonewrite.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phonewrite.Location = New System.Drawing.Point(194, 268)
        Me.phonewrite.Name = "phonewrite"
        Me.phonewrite.Size = New System.Drawing.Size(304, 40)
        Me.phonewrite.TabIndex = 11
        Me.phonewrite.Text = ""
        '
        'emailwrite
        '
        Me.emailwrite.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailwrite.Location = New System.Drawing.Point(194, 211)
        Me.emailwrite.Name = "emailwrite"
        Me.emailwrite.Size = New System.Drawing.Size(304, 40)
        Me.emailwrite.TabIndex = 12
        Me.emailwrite.Text = ""
        '
        'CreateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 648)
        Me.Controls.Add(Me.emailwrite)
        Me.Controls.Add(Me.phonewrite)
        Me.Controls.Add(Me.githubwrite)
        Me.Controls.Add(Me.namewrite)
        Me.Controls.Add(Me.stopwatchtimer)
        Me.Controls.Add(Me.Submitform)
        Me.Controls.Add(Me.togglestopwatch_btn)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.github)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.namelabel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "CreateForm"
        Me.Text = "CreateForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents namelabel1 As Label
    Friend WithEvents email As Label
    Friend WithEvents github As Label
    Friend WithEvents phone As Label
    Friend WithEvents togglestopwatch_btn As Button
    Friend WithEvents Submitform As Button
    Friend WithEvents stopwatchtimer As RichTextBox
    Friend WithEvents namewrite As RichTextBox
    Friend WithEvents githubwrite As RichTextBox
    Friend WithEvents phonewrite As RichTextBox
    Friend WithEvents emailwrite As RichTextBox
End Class
