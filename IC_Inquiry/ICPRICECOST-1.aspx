<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ICPRICECOST.aspx.vb" Inherits="IC_Inquiry.ICPRICECOST" %>

<%@ Register Src="~/ICILOC.ascx" TagPrefix="uc1" TagName="ICILOC" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <script type="text/javascript">


        function UpdateGridHeight() {
            //grid.SetHeight(0);
            //var containerHeight = ASPxClientUtils.GetDocumentClientHeight();
            //if (document.body.scrollHeight > containerHeight)
            //    containerHeight = document.body.scrollHeight;
            //grid.SetHeight(containerHeight  - 10);
            var height = Math.max(0, document.documentElement.clientHeight);
            grid.SetHeight(height - 25);
        }
    </script>


</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:ICILOC runat="server" ID="ICILOC" />
        </div>
    </form>                        
    <script type="text/javascript">

                            ASPxClientControl.GetControlCollection().ControlsInitialized.AddHandler(function (s, e) {
                                UpdateGridHeight();
                            });

                            ASPxClientControl.GetControlCollection().BrowserWindowResized.AddHandler(function (s, e) {
                                UpdateGridHeight();
                            });

    </script>
</body>
</html>
