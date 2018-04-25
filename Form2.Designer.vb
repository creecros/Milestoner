<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.taskNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.task = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taskDuration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taskDepend = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userCombo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.taskNum, Me.task, Me.taskDuration, Me.taskDepend, Me.userCombo})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(495, 603)
        Me.DataGridView1.TabIndex = 1
        '
        'taskNum
        '
        Me.taskNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.taskNum.HeaderText = "#"
        Me.taskNum.Name = "taskNum"
        Me.taskNum.ReadOnly = True
        Me.taskNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.taskNum.Width = 21
        '
        'task
        '
        Me.task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.task.HeaderText = "Tasks/Steps..."
        Me.task.MinimumWidth = 250
        Me.task.Name = "task"
        Me.task.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'taskDuration
        '
        Me.taskDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.taskDuration.HeaderText = "Duration"
        Me.taskDuration.Name = "taskDuration"
        Me.taskDuration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.taskDuration.Width = 53
        '
        'taskDepend
        '
        Me.taskDepend.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.taskDepend.HeaderText = "Depends on"
        Me.taskDepend.Name = "taskDepend"
        Me.taskDepend.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.taskDepend.Width = 71
        '
        'userCombo
        '
        Me.userCombo.HeaderText = "Assignee"
        Me.userCombo.Name = "userCombo"
        Me.userCombo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.userCombo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 621)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(95, 621)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Defaults"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 656)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Milestoner - Setup"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents taskNum As DataGridViewTextBoxColumn
    Friend WithEvents task As DataGridViewTextBoxColumn
    Friend WithEvents taskDuration As DataGridViewTextBoxColumn
    Friend WithEvents taskDepend As DataGridViewTextBoxColumn
    Friend WithEvents userCombo As DataGridViewComboBoxColumn
End Class
