<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.ViewForm_btn = New System.Windows.Forms.Button()
        Me.CreateForm_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(41, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(454, 22)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Ashish kumar, Slidely Task 2 - Sildely Form App"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ViewForm_btn
        '
        Me.ViewForm_btn.BackColor = System.Drawing.SystemColors.Info
        Me.ViewForm_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ViewForm_btn.FlatAppearance.BorderSize = 2
        Me.ViewForm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ViewForm_btn.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewForm_btn.Location = New System.Drawing.Point(29, 127)
        Me.ViewForm_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.ViewForm_btn.Name = "ViewForm_btn"
        Me.ViewForm_btn.Size = New System.Drawing.Size(487, 72)
        Me.ViewForm_btn.TabIndex = 1
        Me.ViewForm_btn.Text = "View Submission (CTRL + X)"
        Me.ViewForm_btn.UseVisualStyleBackColor = False
        '
        'CreateForm_btn
        '
        Me.CreateForm_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CreateForm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CreateForm_btn.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateForm_btn.Location = New System.Drawing.Point(29, 228)
        Me.CreateForm_btn.Name = "CreateForm_btn"
        Me.CreateForm_btn.Size = New System.Drawing.Size(487, 70)
        Me.CreateForm_btn.TabIndex = 2
        Me.CreateForm_btn.Text = "Create New Submission (CTRL + N)"
        Me.CreateForm_btn.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 351)
        Me.Controls.Add(Me.CreateForm_btn)
        Me.Controls.Add(Me.ViewForm_btn)
        Me.Controls.Add(Me.TextBox1)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ViewForm_btn As Button
    Friend WithEvents CreateForm_btn As Button
End Class
