Imports Newtonsoft.Json

Public Class ActionPack

    Shared Sub getAllSubTasks(taskID As Integer)
        Dim user As String = My.Settings.username
        Dim pass As String = My.Settings.password
        Dim uri As String = My.Settings.webhook
        Dim client As New Net.WebClient With {
            .UseDefaultCredentials = True,
            .Credentials = New Net.NetworkCredential(user, pass)
        }

        client.Headers.Add("content-type", "application/json")

        Dim Data As New Body With {
            .jsonrpc = "2.0",
            .method = "getAllSubtasks",
            .id = 133280317,
            .params = New Params With {.task_id = taskID}
        }

        GlobalVariables.updata = client.UploadString(uri, "POST", JsonConvert.SerializeObject(Data))

        Console.WriteLine(GlobalVariables.updata)

    End Sub

    Shared Sub removeSubtask(subtaskID As Integer)
        Dim user As String = My.Settings.username
        Dim pass As String = My.Settings.password
        Dim uri As String = My.Settings.webhook
        Dim client As New Net.WebClient With {
            .UseDefaultCredentials = True,
            .Credentials = New Net.NetworkCredential(user, pass)
        }

        client.Headers.Add("content-type", "application/json")

        Dim Data As New RemoveSubBody With {
            .jsonrpc = "2.0",
            .method = "removeSubtask",
            .id = 1382487306,
            .params = New RemoveSubParam With {.subtask_id = subtaskID}
        }

        GlobalVariables.updata = client.UploadString(uri, "POST", JsonConvert.SerializeObject(Data))

        Console.WriteLine(GlobalVariables.updata)

    End Sub

    Shared Function GetUser(username As String) As Integer
        Dim user As String = My.Settings.username
        Dim pass As String = My.Settings.password
        Dim uri As String = My.Settings.webhook
        Dim client As New Net.WebClient With {
            .UseDefaultCredentials = True,
            .Credentials = New Net.NetworkCredential(user, pass)
        }

        client.Headers.Add("content-type", "application/json")

        Dim Data As New UserBody With {
       .jsonrpc = "2.0",
       .method = "getUserByName",
       .id = 1769674782,
       .params = New UserParams With {.username = username}
        }

        GlobalVariables.updata = client.UploadString(My.Settings.webhook, "POST", JsonConvert.SerializeObject(Data))

        Console.WriteLine(GlobalVariables.updata)
        Dim userresult As UserReturn = JsonConvert.DeserializeObject(Of UserReturn)(GlobalVariables.updata)
        Return userresult.result.id
    End Function

    Shared Function GetAllUsers() As AllUsersReturn
        Dim user As String = My.Settings.username
        Dim pass As String = My.Settings.password
        Dim uri As String = My.Settings.webhook
        Dim client As New Net.WebClient With {
            .UseDefaultCredentials = True,
            .Credentials = New Net.NetworkCredential(user, pass)
        }

        client.Headers.Add("content-type", "application/json")

        Dim Data As New AllUsrBody With {
       .jsonrpc = "2.0",
       .method = "getAllUsers",
       .id = 1769674783
        }

        GlobalVariables.updata = client.UploadString(My.Settings.webhook, "POST", JsonConvert.SerializeObject(Data))

        Console.WriteLine(GlobalVariables.updata)
        Dim alluserresult As AllUsersReturn = JsonConvert.DeserializeObject(Of AllUsersReturn)(GlobalVariables.updata)
        Return alluserresult
    End Function

    Shared Sub createSubtask(subTitle As String, taskID As Integer, userID As Integer, subDue As Integer)
        Dim user As String = My.Settings.username
        Dim pass As String = My.Settings.password
        Dim uri As String = My.Settings.webhook
        Dim client As New Net.WebClient With {
            .UseDefaultCredentials = True,
            .Credentials = New Net.NetworkCredential(user, pass)
        }

        client.Headers.Add("content-type", "application/json")

        Dim Data As New SubtaskUpdate With {
            .jsonrpc = "2.0",
            .method = "createSubtaskdd",
            .id = 1406803059,
            .params = New SubCreate With {.task_id = taskID, .title = subTitle, .user_id = userID, .time_estimated = 0, .time_spent = 0, .status = 0, .due_date = subDue}
        }
        Console.WriteLine(JsonConvert.SerializeObject(Data))
        GlobalVariables.updata = client.UploadString(uri, "POST", JsonConvert.SerializeObject(Data))

        Console.WriteLine(GlobalVariables.updata)

    End Sub

    Shared Function UnixToTime(ByVal strUnixTime As String) As Date
        UnixToTime = DateAdd(DateInterval.Second, Val(strUnixTime), #1/1/1970#)
        If UnixToTime.IsDaylightSavingTime = True Then
            UnixToTime = DateAdd(DateInterval.Hour, 1, UnixToTime)
        End If
    End Function

    Shared Function TimeToUnix(dateToConvert As Date) As Integer
        Dim tSpan = dateToConvert.Subtract(#1/1/1970#)
        TimeToUnix = tSpan.TotalDays * 86400
    End Function

End Class
