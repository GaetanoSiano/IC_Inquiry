Imports System.IO
Imports DevExpress.Web

Public Class LayoutHelper

    Public Shared Sub LoadLayout(currentUserId As Integer, layoutID As Integer, initialLayout As String, ByRef grid As ASPxGridView, pageName As String)
        Using x = New IC_Inquiry.CRMXEntities

            ' Dim currentUserId As Integer = Session("UserId")



            Dim layouts As List(Of UserGridLayout) = x.UserGridLayouts.Where(Function(p) p.UserId = currentUserId And p.GridName = pageName).ToList
            For Each ly In layouts
                ly.Active = False
            Next
            x.SaveChanges()


            Dim lytID As Integer = layoutID
            If lytID <= 0 Then
                grid.LoadClientLayout(initialLayout)
            Else

                Dim lytUser As UserGridLayout = x.UserGridLayouts.Where(Function(p) p.ID = lytID).SingleOrDefault
                If lytUser IsNot Nothing Then
                    grid.LoadClientLayout(lytUser.LayoutData)

                    lytUser.Active = True
                    x.SaveChanges()

                End If


            End If


        End Using
    End Sub

End Class
