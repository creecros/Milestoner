Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.Rows.Clear()

        Dim x = 0
        Dim u = My.Settings.users_list.Count
        Dim usr_list(u) As String

        My.Settings.users_list.CopyTo(usr_list, 0)
        userCombo.DataSource = My.Settings.users_list

        For Each task As String In My.Settings.task_list
            Dim r = {x + 1, My.Settings.task_list(x), My.Settings.task_duration(x), My.Settings.task_depend(x), My.Settings.task_users(x)}
            DataGridView1.Rows.Add(r)
            x = x + 1
        Next



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim x = 0

        My.Settings.task_depend.Clear()
        My.Settings.task_duration.Clear()
        My.Settings.task_list.Clear()
        My.Settings.task_users.Clear()

        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                My.Settings.task_list.Add(row.Cells(1).Value.ToString)
                My.Settings.task_duration.Add(row.Cells(2).Value.ToString)
                My.Settings.task_depend.Add(row.Cells(3).Value.ToString)
                My.Settings.task_users.Add(row.Cells(4).Value.ToString)
            End If
        Next

        My.Settings.Save()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.task_list = My.Settings.task_list_default
        My.Settings.task_depend = My.Settings.task_depend_default
        My.Settings.task_duration = My.Settings.task_duration_default
        My.Settings.Save()
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        Form2_Load(e, e) 'Load everything in your form load event again    
    End Sub


End Class