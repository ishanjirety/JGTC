Public Class AdminPanel
    Private Sub Btn_Usr_Click(sender As Object, e As EventArgs) Handles Btn_Usr.Click
        PanelContent.Controls.Clear()
        With UserManagement
            .TopLevel = False
            PanelContent.Controls.Add(UserManagement)
            .BringToFront()
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Btn_Create_Click(sender As Object, e As EventArgs) Handles Btn_Create.Click
        PanelContent.Controls.Clear()
        With UserCreationvb
            .TopLevel = False
            PanelContent.Controls.Add(UserCreationvb)
            .BringToFront()
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub Btn_logs_Click(sender As Object, e As EventArgs) Handles Btn_logs.Click
        PanelContent.Controls.Clear()
        With Logs
            .TopLevel = False
            PanelContent.Controls.Add(Logs)
            .BringToFront()
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub Btn_roles_Click(sender As Object, e As EventArgs) Handles Btn_roles.Click
        PanelContent.Controls.Clear()
        With GrantRoles
            .TopLevel = False
            PanelContent.Controls.Add(GrantRoles)
            .BringToFront()
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub PanelContent_Paint(sender As Object, e As PaintEventArgs) Handles PanelContent.Paint

    End Sub

    Private Sub Btn_Truncate_Click(sender As Object, e As EventArgs) Handles Btn_Truncate.Click
    End Sub
End Class