<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Assignee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendToTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveAllSubtasksFromTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tnum, Me.tdesc, Me.tdate, Me.tday, Me.Assignee})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(543, 476)
        Me.DataGridView1.TabIndex = 0
        '
        'tnum
        '
        Me.tnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tnum.HeaderText = "#"
        Me.tnum.Name = "tnum"
        Me.tnum.ReadOnly = True
        Me.tnum.Width = 39
        '
        'tdesc
        '
        Me.tdesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tdesc.HeaderText = "Milestone"
        Me.tdesc.Name = "tdesc"
        Me.tdesc.ReadOnly = True
        '
        'tdate
        '
        Me.tdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tdate.HeaderText = "Date"
        Me.tdate.Name = "tdate"
        Me.tdate.ReadOnly = True
        Me.tdate.Width = 55
        '
        'tday
        '
        Me.tday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tday.HeaderText = "Day"
        Me.tday.Name = "tday"
        Me.tday.ReadOnly = True
        Me.tday.Width = 51
        '
        'Assignee
        '
        Me.Assignee.HeaderText = "Assignee"
        Me.Assignee.Name = "Assignee"
        Me.Assignee.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(567, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendToTaskToolStripMenuItem, Me.RemoveAllSubtasksFromTaskToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'SendToTaskToolStripMenuItem
        '
        Me.SendToTaskToolStripMenuItem.Name = "SendToTaskToolStripMenuItem"
        Me.SendToTaskToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.SendToTaskToolStripMenuItem.Text = "Send to a Task..."
        '
        'RemoveAllSubtasksFromTaskToolStripMenuItem
        '
        Me.RemoveAllSubtasksFromTaskToolStripMenuItem.Name = "RemoveAllSubtasksFromTaskToolStripMenuItem"
        Me.RemoveAllSubtasksFromTaskToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.RemoveAllSubtasksFromTaskToolStripMenuItem.Text = "Remove all Subtasks from a Task..."
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 515)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form3"
        Me.Text = "Milestoner - Schedule"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SendToTaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveAllSubtasksFromTaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tnum As DataGridViewTextBoxColumn
    Friend WithEvents tdesc As DataGridViewTextBoxColumn
    Friend WithEvents tdate As DataGridViewTextBoxColumn
    Friend WithEvents tday As DataGridViewTextBoxColumn
    Friend WithEvents Assignee As DataGridViewTextBoxColumn
End Class
