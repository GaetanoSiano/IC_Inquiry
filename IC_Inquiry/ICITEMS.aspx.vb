Imports DevExpress.Web.Data

Public Class ICITEMS
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub ASPxGridView1_ToolbarItemClick(source As Object, e As ASPxGridViewToolbarItemClickEventArgs) Handles ASPxGridView1.ToolbarItemClick
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
            Case Else
        End Select
    End Sub
End Class