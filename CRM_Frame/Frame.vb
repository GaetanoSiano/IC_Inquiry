Imports Sage
Imports Sage.CRM.UI
Imports Sage.CRM.WebObject
Public Class Frame
    Inherits Web



    Public Overrides Sub BuildContents()


        AddContent(HTML.Form)

        AddHeaderScript("$(document).ready(function() {$('#TabsPlaceHolderDiv').remove().contents(); });")
        'AddHeaderScript("$(document).ready(function() {$('#er_new').remove().contents(); });")
        AddHeaderScript("$(document).ready(function() {$('#EWARE_TOP').height(0); $('#EWARE_TOP').css('min-height', '0px'); });")

        'AddHeaderScript("$(document).ready(function() {$('#EWARE_TOP').remove().contents(); });")

        '  $('#RightButtonPanel').remove().contents(); $('#_icTable').remove().contents();
        ''$('#TabsPlaceHolderDiv').remove().contents(); 
        GetTabs("")
        Dim qrPath As String = Dispatch.QueryField("path")

        Dim vpMainPanel As New VerticalPanel

        Dim ParameterString As String = "?SID=" & Dispatch.EitherField("SID")
        ParameterString += "&UserId=" & CurrentUser.UserId

        Dim HttpsOn = Dispatch.ServerVariable("HTTPS")
        Dim SERVER_PORT = Dispatch.ServerVariable("SERVER_PORT")
        Dim URL = Dispatch.ServerVariable("ALL_HTTP")


        Dim PortString As String = ""
        If SERVER_PORT <> "80" Or SERVER_PORT <> "443" Then
            PortString += ":" + SERVER_PORT
        End If

        Dim HttpProtocol As String
        If HttpsOn = "off" Or HttpsOn = "OFF" Then
            HttpProtocol = "http://"
        Else
            HttpProtocol = "https://"
        End If
        Dim Path As String = HttpProtocol & Dispatch.Host & PortString
        If qrPath IsNot Nothing Then
            Path += qrPath
        Else
            Path += "/ic/ICITEMS.aspx"
        End If





        Path += ParameterString


        '        AddHeaderScript("iFrameResize({log:true, checkOrigin: false})")

        Dim iFrameHTML As String = "<IFRAME ID=""FRAME1"" FRAMEBORDER=""0"" MARGINHEIGHT=""10px"" MARGINWIDTH=""10px"" SCROLLING=""NO"" ALLOWTRANSPARENCY=""TRUE"" WIDTH=99% HEIGHT=99% src=""" & Path & """></IFrame>"
        ' AddHeaderScript("$(document).ready(function() { $('#EWARE_TOP').remove().contents();  });")
        AddHeaderScript("$(document).ready(function() { $('#EWARE_MID').html('" + iFrameHTML + "');}); ")


        Dim screenIFrame As New ContentBox
        'screenIFrame.Title = "Tickets"
        Dim ht As New HTMLString
        ht.Html = iFrameHTML
        screenIFrame.Inner = ht


        vpMainPanel.Add(screenIFrame)

        vpMainPanel.AddAttribute("width", "100%")

        AddContent(vpMainPanel)


    End Sub


End Class

