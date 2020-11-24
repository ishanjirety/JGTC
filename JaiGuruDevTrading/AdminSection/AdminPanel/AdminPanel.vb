﻿Public Class AdminPanel
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
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        PanelContent.Controls.Clear()
        With SetAccountingYear
            .TopLevel = False
            PanelContent.Controls.Add(SetAccountingYear)
            .BringToFront()
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PanelContent.Controls.Clear()
        With MessageBody
            .TopLevel = False
            PanelContent.Controls.Add(MessageBody)
            .BringToFront()
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PanelContent.Controls.Clear()
        With DepriciationMethod
            .TopLevel = False
            PanelContent.Controls.Add(DepriciationMethod)
            .BringToFront()
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub
End Class