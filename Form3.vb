Imports Newtonsoft.Json

Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.Rows.Clear()
        Dim x = 0

        For Each task As String In My.Settings.task_list
            Dim r = {x + 1, My.Settings.task_list(x), Format(Form1.dates(x + 1), "MM/dd/yy"), WeekdayName(Weekday(Form1.dates(x + 1))), My.Settings.task_users(x)}
            DataGridView1.Rows.Add(r)
            x = x + 1
        Next
    End Sub

    Private Sub RemoveAllSubtasksFromTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveAllSubtasksFromTaskToolStripMenuItem.Click

        Dim tIDinput As Object
        tIDinput = InputBox("Please enter the Task Id# you wish to remove all subtasks from.", "Task ID #", "0")

        If IsNumeric(tIDinput) Then

            tIDinput = Convert.ToInt32(tIDinput)
            ActionPack.getAllSubTasks(tIDinput)
            Dim fullresult As ReturnSubs = JsonConvert.DeserializeObject(Of ReturnSubs)(GlobalVariables.updata)

            For Each Line As Object In fullresult.result

                Dim listResults As SubsResult = Line
                Dim sId = Convert.ToInt32(listResults.id)

                ActionPack.removeSubtask(sId)

            Next

        End If
    End Sub

    Private Sub SendToTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendToTaskToolStripMenuItem.Click

        Dim tIDinput As Object
        tIDinput = InputBox("Please enter the Task Id# you wish to add these subtasks too.", "Task ID #", "0")

        If IsNumeric(tIDinput) Then

            tIDinput = Convert.ToInt32(tIDinput)

            For Each row As DataGridViewRow In DataGridView1.Rows

                If Not row.IsNewRow Then

                    Dim sId = Convert.ToInt32(row.Cells(0).Value)
                    Dim sTitle = row.Cells(1).Value.ToString
                    Dim sDd = ActionPack.TimeToUnix(Convert.ToDateTime(row.Cells(2).Value.ToString))
                    Dim uId = ActionPack.GetUser(row.Cells(4).Value.ToString)

                    ActionPack.createSubtask(sTitle, tIDinput, uId, sDd)

                End If

            Next

        End If

    End Sub
End Class