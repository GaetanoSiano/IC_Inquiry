Imports DevExpress.Web

Public Class EditOptionalPrices
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

    Protected Sub frmEditPrice_E1_Click(sender As Object, e As EventArgs) Handles btnEdit.Click


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
        Catch ex As Exception

            Throw New Exception(ex.InnerException.Message)


        End Try
    End Sub
End Class