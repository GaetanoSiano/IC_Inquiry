﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PrintView.aspx.vb" Inherits="IC_Inquiry.PrintView" %>

<%@ Register assembly="DevExpress.XtraReports.v18.2.Web.WebForms, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type ="text/html" id="categoryID-custom-editor"> 
    <div data-bind="dxDateBox: {value: new Date(), pickerType: 'calendar' }"> </div> 
    </script> 

</script> 
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxWebDocumentViewer ID="ASPxWebDocumentViewer1" runat="server" ClientInstanceName="webDocumentViewer" DisableHttpHandlerValidation="False">
                <ClientSideEvents CustomizeParameterEditors="function(s, e) {
     if (e.parameter.name == &quot;PO_TRANSDATE&quot;) {
            e.info.editor = { header: 'categoryID-custom-editor' };
        }     	
}" />
            </dx:ASPxWebDocumentViewer>
        </div>
    </form>
</body>
</html>
