Public Class Params
    Public Property task_id As Integer
End Class

Public Class RemoveSubParam
    Public Property subtask_id As Integer
End Class

Public Class UserParams
    Public Property username As String
End Class

Public Class Body
    Public Property jsonrpc As String
    Public Property method As String
    Public Property id As Integer
    Public Property params As Params
End Class

Public Class AllUsrBody
    Public Property jsonrpc As String
    Public Property method As String
    Public Property id As Integer
End Class

Public Class RemoveSubBody
    Public Property jsonrpc As String
    Public Property method As String
    Public Property id As Integer
    Public Property params As RemoveSubParam
End Class

Public Class UserBody
    Public Property jsonrpc As String
    Public Property method As String
    Public Property id As Integer
    Public Property params As UserParams
End Class

Public Class Result
    Public Property id As String
    Public Property title As String
    Public Property description As String
    Public Property date_creation As String
    Public Property color_id As String
    Public Property project_id As String
    Public Property column_id As String
    Public Property owner_id As String
    Public Property position As String
    Public Property is_active As String
    Public Property date_completed As String
    Public Property score As String
    Public Property date_due As String
    Public Property category_id As String
    Public Property creator_id As String
    Public Property date_modification As String
    Public Property reference As String
    Public Property date_started As String
    Public Property time_spent As String
    Public Property time_estimated As String
    Public Property swimlane_id As String
    Public Property date_moved As String
    Public Property recurrence_status As String
    Public Property recurrence_trigger As String
    Public Property recurrence_factor As String
    Public Property recurrence_timeframe As String
    Public Property recurrence_basedate As String
    Public Property recurrence_parent As Object
    Public Property recurrence_child As Object
    Public Property priority As String
    Public Property external_provider As Object
    Public Property external_uri As Object
    Public Property url As String
    Public Property color As Color
End Class

Public Class SubsResult
    Public Property id As String
    Public Property title As String
    Public Property status As String
    Public Property time_estimated As String
    Public Property time_spent As String
    Public Property task_id As String
    Public Property user_id As String
    Public Property username As String
    Public Property name As String
    Public Property status_name As String
End Class

Public Class UserResult
    Public Property id As String
    Public Property username As String
    Public Property password As String
    Public Property role As String
    Public Property is_ldap_user As String
    Public Property name As String
    Public Property email As String
    Public Property google_id As Object
    Public Property github_id As Object
    Public Property notifications_enabled As String
End Class

Public Class UserReturn
    Public Property jsonrpc As String
    Public Property id As Integer
    Public Property result As UserResult
End Class

Public Class AllUsersReturn
    Public Property jsonrpc As String
    Public Property id As Integer
    Public Property result As UserResult()
End Class


Public Class Color
    Public Property name As String
    Public Property background As String
    Public Property border As String
End Class

Public Class ReturnBody
    Public Property jsonrpc As String
    Public Property result As Result()
    Public Property id As Integer
End Class

Public Class ReturnSubs
    Public Property jsonrpc As String
    Public Property result As SubsResult()
    Public Property id As Integer
End Class

Public Class ParamsUpdate
    Public Property id As Integer
    Public Property reference As String
End Class

Public Class SubCreate
    Public Property task_id As Integer
    Public Property title As String
    Public Property user_id As Integer
    Public Property time_estimated As Integer
    Public Property time_spent As Integer
    Public Property status As Integer
    Public Property due_date As Integer
End Class

Public Class BodyUpdate
    Public Property jsonrpc As String
    Public Property method As String
    Public Property id As Integer
    Public Property params As ParamsUpdate
End Class

Public Class SubtaskUpdate
    Public Property jsonrpc As String
    Public Property method As String
    Public Property id As Integer
    Public Property params As SubCreate
End Class

Public Class UploadImages
    Public Property jsonrpc As String
    Public Property method As String
    Public Property id As Integer
    Public Property params As Object()
End Class

Public Class FilesReturn
    Public Property jsonrpc As String
    Public Property id As Integer
    Public Property result As FilesInfo()
End Class

Public Class Blob
    Public Property jsonrpc As String
    Public Property id As Integer
    Public Property result As String
End Class

Public Class FilesInfo
    Public Property id As String
    Public Property name As String
    Public Property path As String
    Public Property is_image As String
    Public Property task_id As String
    Public Property datea As String
    Public Property user_id As String
    Public Property size As String
    Public Property username As Object
    Public Property user_name As Object
End Class

Public Class TaskParams
    Public Property owner_id As Integer
    Public Property creator_id As Integer
    Public Property date_due As String
    Public Property description As String
    Public Property category_id As Integer
    Public Property score As Integer
    Public Property title As String
    Public Property project_id As Integer
    Public Property color_id As String
    Public Property column_id As Integer
    Public Property recurrence_status As Integer
    Public Property recurrence_trigger As Integer
    Public Property recurrence_factor As Integer
    Public Property recurrence_timeframe As Integer
    Public Property recurrence_basedate As Integer
End Class

Public Class Task
    Public Property jsonrpc As String
    Public Property method As String
    Public Property id As Integer
    Public Property params As TaskParams
End Class

Public Class CommentParams
    Public Property task_id As Integer
    Public Property user_id As Integer
    Public Property content As String
End Class

Public Class CommentSend
    Public Property jsonrpc As String
    Public Property method As String
    Public Property id As Integer
    Public Property params As CommentParams
End Class

Public Class CommentResult
    Public Property id As String
    Public Property date_creation As String
    Public Property task_id As String
    Public Property user_id As String
    Public Property comment As String
    Public Property username As String
    Public Property name As Object
End Class

Public Class CommentReturn
    Public Property jsonrpc As String
    Public Property id As Integer
    Public Property result As CommentResult()
End Class

Public Class CParams
    Public Property task_id As Integer
End Class

Public Class CBody
    Public Property jsonrpc As String
    Public Property method As String
    Public Property id As Integer
    Public Property params As CParams
End Class

Public Class GlobalVariables
    Public Shared CommentData As String
    Public Shared Results As New Result
    Public Shared updata As String
    Public Shared filedata As String
    Public Shared folderpath As String
    Public Shared folderpathDD As String
    Public Shared foundNetPath As Boolean
    Public Shared blobdata As String
End Class