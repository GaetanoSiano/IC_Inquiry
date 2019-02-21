Imports System.IO
Imports System.Xml
Imports DevExpress.Web

Public Class Helper


    Private Shared Function LoadXmlCaptions(filename As String) As List(Of FieldInfo)
        Dim lst As New List(Of FieldInfo)

        Dim fieldname As String
        Dim fieldtype As String
        Dim fielddesc As String

        Dim appdatafolder = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, "App_Data") & "\"

        Dim reader As New XmlTextReader(appdatafolder & filename)
        While reader.Read()


            If reader.NodeType = XmlNodeType.Element AndAlso reader.Name = "fieldname" Then

                Debug.WriteLine(String.Format("Name: {0}, Type: {1}, Desc: {2}", fieldname, fieldtype, fielddesc))
                If Not String.IsNullOrEmpty(fieldname) Then
                    Dim fi As New FieldInfo
                    fi.TableName = "ICITEM"
                    fi.FieldName = fieldname
                    fi.FieldType = fieldtype
                    fi.FieldDesc = fielddesc

                    lst.Add(fi)
                End If
                fieldname = ""
                fieldtype = ""
                fielddesc = ""

                If reader.Read AndAlso reader.NodeType = XmlNodeType.Text Then
                    fieldname = reader.Value
                End If
            End If



            If reader.NodeType = XmlNodeType.Element AndAlso reader.Name = "fieldtype" Then
                If reader.Read AndAlso reader.NodeType = XmlNodeType.Text Then
                    fieldtype = reader.Value
                End If
            End If

            If reader.NodeType = XmlNodeType.Element AndAlso reader.Name = "fielddesc" Then
                If reader.Read AndAlso reader.NodeType = XmlNodeType.Text Then
                    fielddesc = reader.Value
                End If
            End If





        End While

        Debug.WriteLine(lst.Count)
        Return lst

    End Function


    Public Shared Sub LoadColumnCaptions(ByRef grid As ASPxGridView, TableName As String)

        Dim lst As List(Of FieldInfo) = LoadXmlCaptions(TableName)


        For Each column As GridViewColumn In grid.Columns
            If TypeOf column Is GridViewDataColumn Then
                Dim dataColumn As GridViewDataColumn = CType(column, GridViewDataColumn)
                Dim colName As String = dataColumn.FieldName




                Dim fi As FieldInfo = lst.Find(Function(p) p.FieldName = colName)

                If fi IsNot Nothing Then
                    grid.Columns(dataColumn.FieldName).Caption = fi.FieldDesc
                End If

                ' column.MinWidth = 200
            End If


        Next column
    End Sub


End Class


Public Class FieldInfo

    Public Property TableName As String
    Public Property FieldName As String
    Public Property FieldType As String
    Public Property FieldDesc As String


End Class
