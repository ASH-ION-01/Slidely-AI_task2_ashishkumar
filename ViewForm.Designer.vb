<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.namelabel2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.namearea = New System.Windows.Forms.TextBox()
        Me.phonearea = New System.Windows.Forms.TextBox()
        Me.githbarea = New System.Windows.Forms.TextBox()
        Me.stopwatcharea = New System.Windows.Forms.TextBox()
        Me.emailarea = New System.Windows.Forms.TextBox()
        Me.previous_btn = New System.Windows.Forms.Button()
        Me.next_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(13, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(495, 27)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Ashish kumar, Task 2 - Sildely Form App"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'namelabel2
        '
        Me.namelabel2.AutoSize = True
        Me.namelabel2.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namelabel2.Location = New System.Drawing.Point(12, 405)
        Me.namelabel2.Name = "namelabel2"
        Me.namelabel2.Size = New System.Drawing.Size(193, 33)
        Me.namelabel2.TabIndex = 2
        Me.namelabel2.Text = "Stopwatch Time"
        Me.namelabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Github Link"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Phone Num"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 33)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 33)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'namearea
        '
        Me.namearea.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.namearea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.namearea.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namearea.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.namearea.Location = New System.Drawing.Point(204, 130)
        Me.namearea.Name = "namearea"
        Me.namearea.ReadOnly = True
        Me.namearea.Size = New System.Drawing.Size(303, 36)
        Me.namearea.TabIndex = 18
        Me.namearea.Text = "John Doe"
        Me.namearea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'phonearea
        '
        Me.phonearea.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.phonearea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.phonearea.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phonearea.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.phonearea.Location = New System.Drawing.Point(204, 265)
        Me.phonearea.Name = "phonearea"
        Me.phonearea.ReadOnly = True
        Me.phonearea.Size = New System.Drawing.Size(303, 36)
        Me.phonearea.TabIndex = 19
        Me.phonearea.Text = "9876543210"
        Me.phonearea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'githbarea
        '
        Me.githbarea.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.githbarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.githbarea.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.githbarea.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.githbarea.Location = New System.Drawing.Point(204, 336)
        Me.githbarea.Name = "githbarea"
        Me.githbarea.ReadOnly = True
        Me.githbarea.Size = New System.Drawing.Size(303, 36)
        Me.githbarea.TabIndex = 20
        Me.githbarea.Text = "https://github.com/john_doe/my_slidely_taks/"
        Me.githbarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'stopwatcharea
        '
        Me.stopwatcharea.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.stopwatcharea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stopwatcharea.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopwatcharea.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.stopwatcharea.Location = New System.Drawing.Point(205, 405)
        Me.stopwatcharea.Name = "stopwatcharea"
        Me.stopwatcharea.ReadOnly = True
        Me.stopwatcharea.Size = New System.Drawing.Size(303, 36)
        Me.stopwatcharea.TabIndex = 21
        Me.stopwatcharea.Text = "00:01:19"
        Me.stopwatcharea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'emailarea
        '
        Me.emailarea.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.emailarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.emailarea.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailarea.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.emailarea.Location = New System.Drawing.Point(204, 198)
        Me.emailarea.Name = "emailarea"
        Me.emailarea.ReadOnly = True
        Me.emailarea.Size = New System.Drawing.Size(303, 36)
        Me.emailarea.TabIndex = 22
        Me.emailarea.Text = "johndoe@gmail.com"
        Me.emailarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'previous_btn
        '
        Me.previous_btn.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.previous_btn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previous_btn.Location = New System.Drawing.Point(18, 513)
        Me.previous_btn.Name = "previous_btn"
        Me.previous_btn.Size = New System.Drawing.Size(243, 62)
        Me.previous_btn.TabIndex = 23
        Me.previous_btn.Text = "PREVIOUS (CTRL + P)"
        Me.previous_btn.UseVisualStyleBackColor = False
        '
        'next_btn
        '
        Me.next_btn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.next_btn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.next_btn.Location = New System.Drawing.Point(267, 513)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(240, 62)
        Me.next_btn.TabIndex = 25
        Me.next_btn.Text = "NEXT (CTRL + N)"
        Me.next_btn.UseVisualStyleBackColor = False
        '
        'ViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 637)
        Me.Controls.Add(Me.next_btn)
        Me.Controls.Add(Me.previous_btn)
        Me.Controls.Add(Me.emailarea)
        Me.Controls.Add(Me.stopwatcharea)
        Me.Controls.Add(Me.githbarea)
        Me.Controls.Add(Me.phonearea)
        Me.Controls.Add(Me.namearea)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.namelabel2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "ViewForm"
        Me.Text = "ViewForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents namelabel2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents namearea As TextBox
    Friend WithEvents phonearea As TextBox
    Friend WithEvents githbarea As TextBox
    Friend WithEvents stopwatcharea As TextBox
    Friend WithEvents emailarea As TextBox
    Friend WithEvents previous_btn As Button
    Friend WithEvents next_btn As Button
End Class
