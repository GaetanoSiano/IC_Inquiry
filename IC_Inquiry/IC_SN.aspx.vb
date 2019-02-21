Imports System.IO
Imports DevExpress.Web
Imports DevExpress.Web.Data
Imports DevExpress.XtraReports.UI

Public Class IC_SN
    Inherits System.Web.UI.Page

    Private Const GridId As String = "Grid1"
    Private ResetLayout As Boolean = False


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack And Not IsCallback Then

        End If

        If Not IsPostBack And Not IsCallback Then

            Session("IC_SN_InitialLayout") = ASPxGridView1.SaveClientLayout()

            Dim layout As LayoutGroup = ASPxGridView1.EditFormLayoutProperties.FindItemOrGroupByName("600")
            If Session("per_600") Then

                layout.Visible = True

            Else
                layout.Visible = False

            End If

          '  If Session("per_880") Is Nothing Then Session("per_880") = False


            ASPxGridView1.Toolbars(0).Items.FindByName("Price").Visible = if(Session("per_880"),False)

            'If Session("per_880") Then

             

            'Else
            '    layout.Visible = False

            'End If



            If Session("UserId") Is Nothing Then
                Dim UserId As Short = 1
                If Not String.IsNullOrEmpty(Request.QueryString("UserId")) Then UserId = Request.QueryString("UserId")

                Session("UserId") = UserId

                With ASPxGridView1.SettingsCookies
                    .StoreFiltering = False
                    .StoreSearchPanelFiltering = False
                    .StoreColumnsWidth = True
                    .StoreControlWidth = True
                End With


            End If




            'Load Column Captions
            For Each column As GridViewColumn In ASPxGridView1.Columns
                If TypeOf column Is GridViewDataColumn Then
                    Dim dataColumn As GridViewDataColumn = CType(column, GridViewDataColumn)
                    Dim colName As String = ""
                    Dim regex As Regex = New Regex("^C\d")
                    Dim match As Match = regex.Match(dataColumn.FieldName)
                    If match.Success Then
                        colName = dataColumn.FieldName.ToString.Remove(0, 1)
                    Else
                        colName = dataColumn.FieldName
                    End If
                    If dataColumn.FieldName.StartsWith("C") Then

                    End If
                    Dim opt As vCSOPTFH = LoadTranslation(colName)
                    If opt IsNot Nothing Then
                        ASPxGridView1.Columns(dataColumn.FieldName).Caption = opt.FDESC
                    End If

                    ' column.MinWidth = 200
                End If


            Next column



            'Load Edit Price Columns
            For each c As LayoutItem in  frmEditPrice.Items 

                Debug.WriteLine(c.GetType)

                Dim colName As String = ""
                Dim regex As Regex = New Regex("^C\d")
                Dim match As Match = regex.Match(c.FieldName)
                If match.Success Then
                    colName = c.FieldName.ToString.Remove(0, 1)
                Else
                    colName = c.FieldName
                End If

                Dim opt As vCSOPTFH = LoadTranslation(colName)
                If opt IsNot Nothing Then
                    c.Caption = opt.FDESC
                End If


            Next

        End If
    End Sub

    Private Sub SetCostVisibility(isVisible As Boolean)

        '*** Control Columns based on Type
        For Each col As DevExpress.Web.GridViewColumn In ASPxGridView1.Columns
            If col.Name.StartsWith("Cost") Then
                col.Visible = isVisible
                col.ShowInCustomizationForm = isVisible
            End If

        Next

    End Sub

    Private Function LoadTranslation(OPTFIELD As String) As vCSOPTFH
        Using dx As New IC_Inquiry.CRMXEntities
            Return dx.vCSOPTFHs.Where(Function(p) p.OPTFIELD = OPTFIELD).FirstOrDefault
            'Dim translations As vCSOPTFH = dx.vCSOPTFHs.Where(Function(p) p.OPTFIELD = OPTFIELD).FirstOrDefault
            'If translations IsNot Nothing Then
            '    Return translations.FDESC
            'Else
            '    Return OPTFIELD
            'End If
        End Using
    End Function



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
            Case "ResetLayout"
                ASPxGridView1.LoadClientLayout(Session("initialLayout"))
            Case "Print"
                Print()
            Case "Price"

                If ASPxGridView1.Selection.Count > 0 Then
                    If ASPxGridView1.GetSelectedFieldValues("ITEMNO").Count > 0 Then _
                        Session("itemno") = ASPxGridView1.GetSelectedFieldValues("ITEMNO")(0)
                    if ASPxGridView1.GetSelectedFieldValues("SERIALNUM").Count > 0 Then _
                        Session("sn") = ASPxGridView1.GetSelectedFieldValues("SERIALNUM")(0)

                    popPrice.ShowOnPageLoad = True
                End If





        End Select
    End Sub

    Private Sub ASPxGridView1_ClientLayout(sender As Object, e As ASPxClientLayoutArgs) Handles ASPxGridView1.ClientLayout

        If e.LayoutMode = ClientLayoutMode.Saving Then
            'Store the user layout in a sesstion
            Dim userLayout As New UserGridLayout
            userLayout.GridName = Path.GetFileNameWithoutExtension(Page.AppRelativeVirtualPath)
            userLayout.UserId = Session("UserId")
            userLayout.LayoutData = e.LayoutData.ToString
            Session("UserGridLayout") = userLayout
        End If


        'If e.LayoutMode = ClientLayoutMode.Loading Then
        '    e.LayoutData = LoadLayout(Session("UserId"), GridId)
        '    Debug.WriteLine(e.LayoutData.ToString)

        '    Using context = New IC_Inquiry.CRMXEntities
        '        Dim currentUser = context.vUserPers.Find(Session("UserId"))
        '        If currentUser IsNot Nothing Then
        '            SetCostVisibility(currentUser.user_IC_ShowCost)
        '        End If
        '    End Using

        'ElseIf e.LayoutMode = ClientLayoutMode.Saving Then
        '    'Store the user layout in a sesstion
        '    Dim userLayout As New UserGridLayout
        '    userLayout.GridName = Path.GetFileNameWithoutExtension(Page.AppRelativeVirtualPath)
        '    userLayout.UserId = Session("UserId")
        '    userLayout.LayoutData = e.LayoutData.ToString
        '    Session("UserGridLayout") = userLayout


        '    Using context = New IC_Inquiry.CRMXEntities
        '        Dim currentUser = context.vUserPers.Find(Session("UserId"))
        '        If currentUser IsNot Nothing Then
        '            SetCostVisibility(currentUser.user_IC_ShowCost)
        '        End If
        '    End Using


        '    'Old default layout
        '    Dim l As New GridLayout
        '    l.UserId = Session("UserId")
        '    l.Name = GridId
        '    l.Layout = e.LayoutData.ToString
        '    UpdateLayout(l)
        '    Debug.WriteLine(e.LayoutData.ToString)
        'End If


    End Sub

    Private Sub Print()

        Dim lst As New List(Of vSN)
        For i As Integer = 0 To ASPxGridView1.VisibleRowCount - 1
            lst.Add(ASPxGridView1.GetRow(i))
        Next



        Session("PrintList") = lst


        Dim url As String = "PrintView.aspx"
        Dim s As String = "window.open('" & url + "', 'popup_window', 'width=800,height=600,left=100,top=100,resizable=yes,menubar=no,titlebar=no,toolbar=no');"
        ClientScript.RegisterStartupScript(Me.GetType(), "script", s, True)




    End Sub

    ''' <summary>
    ''' Save Layout to database table
    ''' </summary>
    ''' <param name="newLayoutValues"></param>
    ''' <returns>GridLayout Object</returns>
    'Public Function UpdateLayout(newLayoutValues As GridLayout) As GridLayout
    '    Using context = New IC_Inquiry.CRMXEntities
    '        Dim entity = context.GridLayouts.Find(newLayoutValues.UserId, newLayoutValues.Name)

    '        If entity Is Nothing Then
    '            context.GridLayouts.Add(newLayoutValues)
    '        Else
    '            context.Entry(entity).CurrentValues.SetValues(newLayoutValues)
    '        End If


    '        context.SaveChanges()
    '        Return entity
    '    End Using
    'End Function


    ''' <summary>
    ''' Get Layout schema from database
    ''' </summary>
    ''' <param name="userid"></param>
    ''' <param name="name"></param>
    ''' <returns>layout as string</returns>
    'Public Function LoadLayout(userid As Short, name As String) As String
    '    Using context = New IC_Inquiry.CRMXEntities
    '        Dim entity = context.GridLayouts.Find(userid, name)

    '        If entity IsNot Nothing Then
    '            Return entity.Layout
    '        Else
    '            Return ""
    '        End If

    '        'Hide COst Columns



    '    End Using
    'End Function

    Private Sub ASPxGridView1_RowUpdating(sender As Object, e As ASPxDataUpdatingEventArgs) Handles ASPxGridView1.RowUpdating
        Debug.Print("test Row Updating")



        Dim C800TRESVDATE As String = e.NewValues("C800TRESVDATE")
        Dim C810TRESVSLP As String = e.NewValues("C810TRESVSLP")
        Dim C850TRESVNOTE As String = e.NewValues("C850TRESVNOTE")
        Dim C900NOTES As String = e.NewValues("C900NOTES")


        Dim C600DESPATCH As String = e.NewValues("C600DESPATCH")
        Dim C605FACTRYREF As String = e.NewValues("C605FACTRYREF")
        Dim C608DOCSDATE As String = e.NewValues("C608DOCSDATE")
        Dim C610CONTAINER As String = e.NewValues("C610CONTAINER")
        Dim C620BL As String = e.NewValues("C620BL")
        Dim C630ISF As String = e.NewValues("C630ISF")
        Dim C640CARRIER As String = e.NewValues("C640CARRIER")
        Dim C640CARRIER2 As String = e.NewValues("C640CARRIER2")
        Dim C640CARRIER3 As String = e.NewValues("C640CARRIER3")
        Dim C645VESSEL As String = e.NewValues("C645VESSEL")
        Dim C645VESSEL2 As String = e.NewValues("C645VESSEL2")
        Dim C645VESSEL3 As String = e.NewValues("C645VESSEL3")
        Dim C648VOYAGE As String = e.NewValues("C648VOYAGE")
        Dim C650PORTORIG As String = e.NewValues("C650PORTORIG")
        Dim C660CF214 As String = e.NewValues("C660CF214")
        Dim C665IT7512IN As String = e.NewValues("C665IT7512IN")
        Dim C670IMPORTENT As String = e.NewValues("C670IMPORTENT")






        Dim SERIALNUM As String = e.Keys(0)
        Dim ITEMNO As String = ASPxGridView1.GetRowValuesByKeyValue(SERIALNUM, "ITEMNO")



        If Not String.IsNullOrEmpty(C800TRESVDATE) Then
            C800TRESVDATE = CDate(C800TRESVDATE).ToString("yyyyMMdd")
        Else
            C800TRESVDATE = 0
        End If

        If Not String.IsNullOrEmpty(C608DOCSDATE) Then
            C608DOCSDATE = CDate(C608DOCSDATE).ToString("yyyyMMdd")
        Else
            C608DOCSDATE = 0
        End If


        If String.IsNullOrEmpty(C810TRESVSLP) Then C810TRESVSLP = " "
        If String.IsNullOrEmpty(C850TRESVNOTE) Then C850TRESVNOTE = " "
        If String.IsNullOrEmpty(C900NOTES) Then C900NOTES = " "


        If String.IsNullOrEmpty(C600DESPATCH) Then C600DESPATCH = " "
        If String.IsNullOrEmpty(C605FACTRYREF) Then C605FACTRYREF = " "
        'If String.IsNullOrEmpty(C608DOCSDATE) Then C608DOCSDATE = " "
        If String.IsNullOrEmpty(C610CONTAINER) Then C610CONTAINER = " "
        If String.IsNullOrEmpty(C620BL) Then C620BL = " "
        If String.IsNullOrEmpty(C630ISF) Then C630ISF = " "
        If String.IsNullOrEmpty(C640CARRIER) Then C640CARRIER = " "
        If String.IsNullOrEmpty(C640CARRIER2) Then C640CARRIER2 = " "

        If String.IsNullOrEmpty(C640CARRIER3) Then C640CARRIER3 = " "
        If String.IsNullOrEmpty(C645VESSEL) Then C645VESSEL = " "
        If String.IsNullOrEmpty(C645VESSEL2) Then C645VESSEL2 = " "
        If String.IsNullOrEmpty(C645VESSEL3) Then C645VESSEL3 = " "
        If String.IsNullOrEmpty(C648VOYAGE) Then C648VOYAGE = " "
        If String.IsNullOrEmpty(C650PORTORIG) Then C650PORTORIG = " "
        If String.IsNullOrEmpty(C660CF214) Then C660CF214 = " "
        If String.IsNullOrEmpty(C665IT7512IN) Then C665IT7512IN = " "
        If String.IsNullOrEmpty(C670IMPORTENT) Then C670IMPORTENT = " "



        Try
            Using context = New IC_Inquiry.CRMXEntities
                context.prUpdateOptValue(ITEMNO, SERIALNUM, "800TRESVDATE", C800TRESVDATE, 20180203)
                context.prUpdateOptValue(ITEMNO, SERIALNUM, "810TRESVSLP", C810TRESVSLP, 20180203)
                context.prUpdateOptValue(ITEMNO, SERIALNUM, "850TRESVNOTE", C850TRESVNOTE, 20180203)
                context.prUpdateOptValue(ITEMNO, SERIALNUM, "900NOTES", C900NOTES, 20180203)


                If Session("per_600") Then
                    context.prUpdateOptValue(ITEMNO, SERIALNUM, "600DESPATCH", C600DESPATCH, 20180203)
                    context.prUpdateOptValue(ITEMNO, SERIALNUM, "610CONTAINER", C610CONTAINER, 20180203)
                    context.prUpdateOptValue(ITEMNO, SERIALNUM, "605FACTRYREF", C605FACTRYREF, 20180203)
                    context.prUpdateOptValue(ITEMNO, SERIALNUM, "608DOCSDATE", C608DOCSDATE, 20180203)
                    context.prUpdateOptValue(ITEMNO, SERIALNUM, "620BL", C620BL, 20180203)
                    context.prUpdateOptValue(ITEMNO, SERIALNUM, "630ISF", C630ISF, 20180203)
                    context.prUpdateOptValue(ITEMNO, SERIALNUM, "640CARRIER", C640CARRIER, 20180203)
                    context.prUpdateOptValue(ITEMNO, SERIALNUM, "640CARRIER2", C640CARRIER2, 20180203)
                    context.prUpdateOptValue(ITEMNO, SERIALNUM, "640CARRIER3", C640CARRIER3, 20180203)
                    context.prUpdateOptValue(ITEMNO, SERIALNUM, "645VESSEL", C645VESSEL, 20180203)
                    context.prUpdateOptValue(ITEMNO, SERIALNUM, "645VESSEL2", C645VESSEL2, 20180203)
                    context.prUpdateOptValue(ITEMNO, SERIALNUM, "645VESSEL3", C645VESSEL3, 20180203)
                    context.prUpdateOptValue(ITEMNO, SERIALNUM, "648VOYAGE", C648VOYAGE, 20180203)
                    context.prUpdateOptValue(ITEMNO, SERIALNUM, "650PORTORIG", C650PORTORIG, 20180203)
                    context.prUpdateOptValue(ITEMNO, SERIALNUM, "660CF214", C660CF214, 20180203)
                    context.prUpdateOptValue(ITEMNO, SERIALNUM, "665IT7512IN", C665IT7512IN, 20180203)
                    context.prUpdateOptValue(ITEMNO, SERIALNUM, "670IMPORTENT", C670IMPORTENT, 20180203)

                End If



            End Using
        Catch ex As Exception

            Throw New Exception(ex.InnerException.Message)


        End Try




        e.Cancel = True
        ASPxGridView1.CancelEdit()


    End Sub

    Private Sub ASPxGridView1_RowUpdated(sender As Object, e As ASPxDataUpdatedEventArgs) Handles ASPxGridView1.RowUpdated
        Debug.Print("test Row Updated")

    End Sub

    Private Sub ASPxGridView1_CellEditorInitialize(sender As Object, e As ASPxGridViewEditorEventArgs) Handles ASPxGridView1.CellEditorInitialize
        e.Editor.Visible = Not e.Editor.ReadOnly

    End Sub

    Private Sub ASPxGridView1_CustomErrorText(sender As Object, e As ASPxGridViewCustomErrorTextEventArgs) Handles ASPxGridView1.CustomErrorText
        e.ErrorText = e.Exception.Message
    End Sub

    Private Sub ASPxGridView1_CustomCallback(sender As Object, e As ASPxGridViewCustomCallbackEventArgs) Handles ASPxGridView1.CustomCallback
        Dim LayoutId = 0
        If e.Parameters = "Session" Then
            LayoutId = Session("ActiveLayoutId")
        Else
            LayoutId = e.Parameters
        End If
        Dim pageName As String = Path.GetFileNameWithoutExtension(Page.AppRelativeVirtualPath)
        LayoutHelper.LoadLayout(Session("UserId"), LayoutId, Session("IC_SN_InitialLayout"), ASPxGridView1, pageName)

    End Sub

    Protected Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        popPrice.ShowOnPageLoad = False

        
        Dim hasUpdates As Boolean
        Try
            Using context = New IC_Inquiry.CRMXEntities


                If C880USD002.Value IsNot Nothing Then
                    context.prUpdateOptValue(ITEMNO.Value, SERIALNUM.Value, "880USD002", C880USD002.Value.ToString,
                                             Now.ToString("yyyyMMdd"))
                    hasUpdates = True
                End If

                If C880USD005.Value IsNot Nothing Then
                    context.prUpdateOptValue(ITEMNO.Value, SERIALNUM.Value, "880USD005", C880USD005.Value,
                                             Now.ToString("yyyyMMdd"))
                    hasUpdates = True
                End If
                If C880USD010.Value IsNot Nothing Then
                    context.prUpdateOptValue(ITEMNO.Value, SERIALNUM.Value, "880USD010", C880USD010.Value,
                                             Now.ToString("yyyyMMdd"))
                    hasUpdates = True
                End If

                If C880USD020.Value IsNot Nothing Then
                    context.prUpdateOptValue(ITEMNO.Value, SERIALNUM.Value, "880USD020", C880USD020.Value,
                                             Now.ToString("yyyyMMdd"))
                    hasUpdates = True
                End If

                If C880USD030.Value IsNot Nothing Then
                    context.prUpdateOptValue(ITEMNO.Value, SERIALNUM.Value, "880USD030", C880USD030.Value,
                                             Now.ToString("yyyyMMdd"))
                    hasUpdates = True
                End If

                If C880USD040.Value IsNot Nothing Then
                    context.prUpdateOptValue(ITEMNO.Value, SERIALNUM.Value, "880USD040", C880USD040.Value,
                                             Now.ToString("yyyyMMdd"))
                    hasUpdates = True
                End If

                If C880USD050.Value IsNot Nothing Then
                    context.prUpdateOptValue(ITEMNO.Value, SERIALNUM.Value, "880USD050", C880USD050.Value,
                                             Now.ToString("yyyyMMdd"))
                    hasUpdates = True
                End If

                If C880USD060.Value IsNot Nothing Then
                    context.prUpdateOptValue(ITEMNO.Value, SERIALNUM.Value, "880USD060", C880USD060.Value,
                                             Now.ToString("yyyyMMdd"))
                    hasUpdates = True
                End If

                If C880USD070.Value IsNot Nothing Then
                    context.prUpdateOptValue(ITEMNO.Value, SERIALNUM.Value, "880USD070", C880USD070.Value,
                                             Now.ToString("yyyyMMdd"))
                    hasUpdates = True
                End If


                If hasUpdates Then _
                    context.prUpdateOptValue(ITEMNO.Value, SERIALNUM.Value, "880USDDATE", Now.ToString("yyyyMMdd"),
                                             Now.ToString("yyyyMMdd"))




            End Using

            ASPxGridView1.DataBind

        Catch ex As Exception

            Throw New Exception(ex.InnerException.Message)


        End Try
    End Sub
End Class