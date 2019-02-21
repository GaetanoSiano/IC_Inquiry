Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Public Class PrintView
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            ASPxWebDocumentViewer1.OpenReport(GetReport)
        End If

    End Sub


    Private Function GetReport() As XtraReport

        Dim r As New rptSNs
        r.DataSource = Nothing
        Dim lst As List(Of vSN) = Session("PrintList")
        r.DataSource = lst

        r.FillDataSource()


        Return r

    End Function

End Class