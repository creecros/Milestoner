Public Class Form1

    Public Shared dates As New Microsoft.VisualBasic.Collection()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            calc_forward()
        Else
            calc_back()
        End If
    End Sub

    Public Function weekend_forward(day_check As Date) As Date
        If WeekdayName(Weekday(day_check)) = "Sunday" Then
            day_check = day_check.AddDays(1)
        ElseIf WeekdayName(Weekday(day_check)) = "Saturday" Then
            day_check = day_check.AddDays(2)
        End If
        Return day_check
    End Function

    Public Sub calc_forward()

        dates.Clear()

        Dim start As Date = weekend_forward(MonthCalendar1.SelectionRange.Start)
        Dim x = 0

        For Each task As Integer In My.Settings.task_duration
            Dim loc As Integer = My.Settings.task_depend(x)
            If x = 0 Then
                start = weekend_forward(start.AddDays(task))
            Else
                start = weekend_forward(dates(loc).AddDays(task))
            End If
            x += 1
            dates.Add(start)
        Next

        Form3.Show()

    End Sub

    Public Sub calc_back()

        Dim x = 0

        For Each duration As Integer In My.Settings.task_duration
            x = x + duration
        Next

        Dim start As Date = weekend_forward(MonthCalendar1.SelectionRange.Start)
        start = start.AddDays(-x)

        Dim d = 1
        Dim selection As Date = MonthCalendar1.SelectionRange.Start
        Dim temp_date As Date = selection.AddDays(100)

        Do

            dates.Clear()
            x = 0

            For Each task As Integer In My.Settings.task_duration

                Dim loc As Integer = My.Settings.task_depend(x)

                If x = 0 Then
                    start = weekend_forward(start.AddDays(task))
                Else
                    start = weekend_forward(dates(loc).AddDays(task))
                End If

                x += 1
                dates.Add(start)

                If dates.Count = My.Settings.task_list.Count Then
                    temp_date = dates(x)
                End If

            Next

            If temp_date <> selection Then
                start = weekend_forward(MonthCalendar1.SelectionRange.Start.AddDays(-d))
                d += 1
            End If

        Loop Until temp_date - selection <= selection - selection

        Form3.Show()

    End Sub

    Private Sub TaskStepsSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskStepsSetupToolStripMenuItem.Click
        Form2.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        If My.Settings.task_depend(1) = 0 Then
            My.Settings.task_depend = My.Settings.task_depend_default
            My.Settings.task_duration = My.Settings.task_duration_default
            My.Settings.task_list = My.Settings.task_list_default
        End If
    End Sub

    Private Sub CredentialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CredentialsToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub UpdateUserListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateUserListToolStripMenuItem.Click

        Dim users = ActionPack.GetAllUsers()
        If users IsNot Nothing Then
            My.Settings.users_list.Clear()

            For Each usr As Object In users.result

                Dim listResults As UserResult = usr
                Dim usrnm = listResults.username
                My.Settings.users_list.Add(usrnm)
            Next
            My.Settings.Save()
            MessageBox.Show("Your user list has been updated.")
        Else
            MessageBox.Show("No users have been updated, something went wrong.")
        End If

    End Sub
End Class
