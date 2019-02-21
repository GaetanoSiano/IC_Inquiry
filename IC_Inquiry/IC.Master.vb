Imports System.IO
Imports DevExpress.Web

Public Class IC
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not String.IsNullOrEmpty(Request.QueryString("SID")) Then Session("SID") = Request.QueryString("SID")
        If Not String.IsNullOrEmpty(Request.QueryString("UserId")) Then Session("UserId") = Request.QueryString("UserId")


        If Session("UserId") Is Nothing Then
            Dim UserId As Short = 1
            ' If Not String.IsNullOrEmpty(Request.QueryString("UserId")) Then UserId = Request.QueryString("UserId")

            Session("UserId") = UserId


        End If

        If Not IsPostBack Then
            MyPageTitle.Text = Page.Title

            LoadMenu()

            Dim UserId As Short = Session("UserId")
            Dim x As New IC_Inquiry.CRMXEntities
            ASPxComboBox1.DataSourceID = String.Empty
            Dim pagename As String = Path.GetFileNameWithoutExtension(Page.AppRelativeVirtualPath)
            ASPxComboBox1.DataSource = x.UserGridLayouts.Where(Function(p) p.GridName = pagename And p.UserId = UserId).ToList



            ASPxComboBox1.DataBind()



        End If
        'Using context = New IC_Inquiry.CRMXEntities
        '    Dim x As New GridLayout
        '    x.Layout = ""
        '    x.LayoutName = "tst"
        '    x.Name = "grid1"
        '    x.UserId = 2

        '    context.GridLayouts.Add(x)
        '    context.SaveChanges()

        'End Using






    End Sub


    Private Sub SetActiveLayout()
        Dim currentUserId As Integer = Session("UserId")
        Dim pagename As String = Path.GetFileNameWithoutExtension(Page.AppRelativeVirtualPath)
        Dim cstype As Type = Me.GetType()
        Using dx = New IC_Inquiry.CRMXEntities

            Dim userLayout As UserGridLayout = dx.UserGridLayouts.Where(Function(p) p.UserId = currentUserId And p.GridName = pagename And p.Active = True).SingleOrDefault
            If userLayout IsNot Nothing Then
                ASPxComboBox1.SelectedIndex = ASPxComboBox1.Items.FindByValue(userLayout.ID).Index
                Page.ClientScript.RegisterStartupScript(cstype, "ChangeSelected", "grid.PerformCallback('Session');", True)

                Session("ActiveLayoutId") = userLayout.ID
            Else
                Page.ClientScript.RegisterStartupScript(cstype, "ChangeSelected", "grid.PerformCallback('Session');", True)
                Session("ActiveLayoutId") = -1
            End If
        End Using

        Page.ClientScript.RegisterStartupScript(cstype, "ShowHideProfileButtons", "ShowHideProfileButtons() ;", True)
    End Sub


    Private Sub LoadMenu()

        Using context = New IC_Inquiry.CRMXEntities
            Dim UserId As Short = Session("UserId")
            Dim entity = context.vUserPers.Find(UserId)

            If entity IsNot Nothing Then

                Session("per_600") = entity.user_per_600
                Session("per_880") = entity.user_per_880

                For Each mnu As MenuItem In ASPxMenu1.Items

                    If mnu.Name = "IC" Then

                        For Each mnyIC As MenuItem In mnu.Items
                            If entity.user_IC_History And mnyIC.Name = "IC_History" Then
                                mnyIC.Visible = True
                            ElseIf entity.user_IC_Items And mnyIC.Name = "IC_Items" Then
                                mnyIC.Visible = True
                            ElseIf entity.user_IC_Price And mnyIC.Name = "IC_Price" Then
                                mnyIC.Visible = True
                            ElseIf entity.user_IC_SN And mnyIC.Name = "IC_SN" Then
                                mnyIC.Visible = True
                            End If

                        Next
                    End If



                Next


            End If


        End Using
    End Sub



    Private Sub layoutCallback_Callback(source As Object, e As CallbackEventArgs) Handles layoutCallback.Callback
        'If e.Parameter = "ADD" Then
        '    Using context = New IC_Inquiry.CRMXEntities
        '        Dim x As New UserGridLayout
        '        x.LayoutData = ""
        '        x.LayoutName = txtLayoutName.Value
        '        x.GridName = "grid1"
        '        x.UserId = 1

        '        context.UserGridLayouts.Add(x)
        '        context.SaveChanges()

        '        ASPxComboBox1.DataSource = context.UserGridLayouts.ToList
        '        ASPxComboBox1.DataBind()

        '    End Using

        'End If


    End Sub

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using context = New IC_Inquiry.CRMXEntities
            Dim pagename As String = Path.GetFileNameWithoutExtension(Page.AppRelativeVirtualPath)
            Dim currentUserId As Integer = Session("UserId")

            Dim layouts As List(Of UserGridLayout) = context.UserGridLayouts.Where(Function(p) p.UserId = currentUserId And p.GridName = pagename).ToList
            For Each ly In layouts
                ly.Active = False
            Next
            context.SaveChanges()

            Dim x As UserGridLayout = Session("UserGridLayout")
            x.LayoutName = txtLayoutName.Value
            x.Active = True

            context.UserGridLayouts.Add(x)
            context.SaveChanges()

            Dim UserId As Short = Session("UserId")
            ASPxComboBox1.DataSourceID = String.Empty
            ASPxComboBox1.DataSource = context.UserGridLayouts.Where(Function(p) p.GridName = pagename And p.UserId = UserId).ToList
            ASPxComboBox1.DataBind()


            ASPxComboBox1.SelectedIndex = ASPxComboBox1.Items.FindByValue(x.ID).Index



        End Using
    End Sub

    Protected Sub ASPxMenu1_ItemClick(source As Object, e As MenuItemEventArgs) Handles ASPxMenu1.ItemClick

    End Sub

    Private Sub ASPxComboBox1_DataBound(sender As Object, e As EventArgs) Handles ASPxComboBox1.DataBound
        '// Get the Active Layout for that user and page
        SetActiveLayout()
    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Using context = New IC_Inquiry.CRMXEntities
            'Dim pagename As String = Path.GetFileNameWithoutExtension(Page.AppRelativeVirtualPath)
            'Dim currentUserId As Integer = Session("UserId")

            'Dim layouts As List(Of UserGridLayout) = context.UserGridLayouts.Where(Function(p) p.UserId = currentUserId).ToList
            'For Each ly In layouts
            '    ly.Active = False
            'Next
            'context.SaveChanges()
            Dim pagename As String = Path.GetFileNameWithoutExtension(Page.AppRelativeVirtualPath)
            Dim ExistingLayout As UserGridLayout = Session("UserGridLayout")
            Dim lytID As Integer = ASPxComboBox1.Value
            Dim layoutToUpdate As UserGridLayout = context.UserGridLayouts.Where(Function(p) p.ID = lytID).SingleOrDefault

            If layoutToUpdate IsNot Nothing Then
                layoutToUpdate.LayoutName = txtLayoutName.Value
                layoutToUpdate.LayoutData = ExistingLayout.LayoutData
                context.SaveChanges()

                'Refresh the combo
                Dim UserId As Short = Session("UserId")
                ASPxComboBox1.DataSourceID = String.Empty
                ASPxComboBox1.DataSource = context.UserGridLayouts.Where(Function(p) p.GridName = pagename And p.UserId = UserId).ToList
                ASPxComboBox1.DataBind()


            End If



            'ASPxComboBox1.SelectedIndex = ASPxComboBox1.Items.FindByValue(x.ID).Index



        End Using
    End Sub

    Protected Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Using context = New IC_Inquiry.CRMXEntities

            Dim currentUserId As Integer = Session("UserId")
            Dim pagename As String = Path.GetFileNameWithoutExtension(Page.AppRelativeVirtualPath)
            Dim layouts As List(Of UserGridLayout) = context.UserGridLayouts.Where(Function(p) p.UserId = currentUserId And p.GridName = pagename).ToList
            For Each ly In layouts
                ly.Active = False
            Next
            context.SaveChanges()


            Dim lytID As Integer = ASPxComboBox1.Value
            Dim layoutToUpdate As UserGridLayout = context.UserGridLayouts.Where(Function(p) p.ID = lytID).SingleOrDefault

            If layoutToUpdate IsNot Nothing Then

                context.UserGridLayouts.Remove(layoutToUpdate)
                context.SaveChanges()

                'Refresh the combo
                Dim UserId As Short = Session("UserId")
                ASPxComboBox1.DataSourceID = String.Empty
                ASPxComboBox1.DataSource = context.UserGridLayouts.Where(Function(p) p.GridName = pagename And p.UserId = UserId).ToList
                ASPxComboBox1.DataBind()


            End If



            ASPxComboBox1.SelectedIndex = -1



        End Using
    End Sub

    Private Sub ASPxTimer1_Tick(sender As Object, e As EventArgs) Handles ASPxTimer1.Tick
        Session("RefreshTime") = Now
        Debug.WriteLine("RefreshTime" & Now.ToLongTimeString)
    End Sub




    'Private Sub ASPxFormLayout1_E2_Click(sender As Object, e As EventArgs) Handles ASPxFormLayout1_E2.Click

    'End Sub
End Class