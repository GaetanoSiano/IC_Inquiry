Imports System.IO
Imports DevExpress.Data
Imports DevExpress.Web
Imports DevExpress.Web.Data

Public Class IC_Items
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If Not IsPostBack Then
            Session("IC_Items_InitialLayout") = ASPxGridView1.SaveClientLayout()

            Using context = New IC_Inquiry.CRMXEntities
                Dim UserId As Short = Session("UserId")
                Dim entity = context.vUserPers.Find(UserId)
                If entity IsNot Nothing Then
                    If entity.user_IC_ShowCost = 0 Then
                        ASPxGridView1.DataSourceID = "sdsItemsNoCost"
                        ASPxGridView1.DataBind()
                    End If
                    SetCostVisibility(entity.user_IC_ShowCost)
                End If
            End Using
        End If


    End Sub




    Private Sub ASPxGridView1_ToolbarItemClick(source As Object, e As ASPxGridViewToolbarItemClickEventArgs) Handles ASPxGridView1.ToolbarItemClick
        Exporter.FileName = Page.Title
        Select Case e.Item.Name
            Case "ExportToPDF"
                Exporter.Landscape = True
                Exporter.LeftMargin = 0.25
                Exporter.RightMargin = 0.25
                Exporter.WritePdfToResponse()
            Case "ExportToXLS"
                Exporter.WriteXlsToResponse()
            Case "ExportToXLSX"
                Exporter.WriteXlsxToResponse()
            Case "ExportToCSV"
                Exporter.WriteCsvToResponse()
            Case Else
        End Select
    End Sub

    Private Sub SetCostVisibility(isVisible As Boolean)



        '*** Control Columns based on Type
        For Each col As DevExpress.Web.GridViewColumn In ASPxGridView1.Columns
            If col.Name.StartsWith("Cost") Then
                col.Visible = isVisible
                col.VisibleIndex = -1
                col.SetColVisible(False)
                col.SetColVisibleIndex(-1)

                col.ShowInCustomizationForm = isVisible
            End If

        Next

    End Sub

    Private Sub ASPxGridView1_ClientLayout(sender As Object, e As ASPxClientLayoutArgs) Handles ASPxGridView1.ClientLayout



        If e.LayoutMode = ClientLayoutMode.Saving Then
            'Store the user layout in a sesstion
            Dim userLayout As New UserGridLayout
            userLayout.GridName = Path.GetFileNameWithoutExtension(Page.AppRelativeVirtualPath)
            userLayout.UserId = Session("UserId")
            userLayout.LayoutData = e.LayoutData.ToString
            Session("UserGridLayout") = userLayout
        Else

        End If

    End Sub

    Private Sub ASPxGridView1_CustomCallback(sender As Object, e As ASPxGridViewCustomCallbackEventArgs) Handles ASPxGridView1.CustomCallback
        Dim LayoutId = 0
        If e.Parameters = "Session" Then
            LayoutId = Session("ActiveLayoutId")
        Else
            LayoutId = e.Parameters
        End If

        Dim pageName As String = Path.GetFileNameWithoutExtension(Page.AppRelativeVirtualPath)
        LayoutHelper.LoadLayout(Session("UserId"), LayoutId, Session("IC_Items_InitialLayout"), ASPxGridView1, pageName)
    End Sub
End Class