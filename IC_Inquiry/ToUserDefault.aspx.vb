Public Class ToUserDefault
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim UserId As Short = 1
        If Not String.IsNullOrEmpty(Request.QueryString("UserId")) Then UserId = Request.QueryString("UserId")

        Session("UserId") = UserId

        Using context = New IC_Inquiry.CRMXEntities
            Dim usr = context.vUserPers.Find(UserId)
            Dim d As String = Request.ServerVariables("QUERY_STRING")
            If d.Length > 1 Then d = "?" & d
            If usr IsNot Nothing Then
                If String.IsNullOrEmpty(usr.user_IC_DefaultPage) Then
                    Response.Redirect("IC_SN.aspx" & d)
                Else
                    Response.Redirect(String.Format("{0}.aspx{1}", usr.user_IC_DefaultPage, d))
                End If
            Else
                Response.Redirect("IC_SN.aspx" & d)
            End If


        End Using
    End Sub

End Class