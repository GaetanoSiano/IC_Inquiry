<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EditOptionalPrices.aspx.vb" Inherits="IC_Inquiry.EditOptionalPrices" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <dx:ASPxFormLayout ID="frmEditPrice" runat="server" ColCount="2" ColumnCount="2" DataSourceID="sdsSN">
                <Items>
                    <dx:LayoutItem Caption="Item" ColSpan="1" FieldName="ITEMNO">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="ITEMNO" runat="server" Width="170px">
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ColSpan="1" FieldName="SERIALNUM">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="SERIALNUM" runat="server" Width="170px">
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ColSpan="1" FieldName="C880USDDATE">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxDateEdit ID="C880USDDATE" runat="server">
                                </dx:ASPxDateEdit>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ColSpan="1" FieldName="C880USD002">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="C880USD002" runat="server">
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ColSpan="1" FieldName="C880USD005">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxSpinEdit ID="C880USD005" runat="server" Width="170px" DecimalPlaces="2" DisplayFormatString="N2">
                                </dx:ASPxSpinEdit>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ColSpan="1" FieldName="C880USD010">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxSpinEdit ID="C880USD010" runat="server" Width="170px" DecimalPlaces="2" DisplayFormatString="N2">
                                </dx:ASPxSpinEdit>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ColSpan="1" FieldName="C880USD020">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxSpinEdit ID="C880USD020" runat="server" Width="170px" DecimalPlaces="2" DisplayFormatString="N2">
                                </dx:ASPxSpinEdit>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ColSpan="1" FieldName="C880USD030">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxSpinEdit ID="C880USD030" runat="server" Width="170px" DecimalPlaces="2" DisplayFormatString="N2">
                                </dx:ASPxSpinEdit>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ColSpan="1" FieldName="C880USD040">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxSpinEdit ID="C880USD040" runat="server" Width="170px" DecimalPlaces="2" DisplayFormatString="N2">
                                </dx:ASPxSpinEdit>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ColSpan="1" FieldName="C880USD050">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxSpinEdit ID="C880USD050" runat="server" Width="170px" DecimalPlaces="2" DisplayFormatString="N2">
                                </dx:ASPxSpinEdit>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ColSpan="1" FieldName="C880USD060">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxSpinEdit ID="C880USD060" runat="server" Width="170px" DecimalPlaces="2" DisplayFormatString="N2">
                                </dx:ASPxSpinEdit>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ColSpan="1" FieldName="C880USD070">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxSpinEdit ID="C880USD070" runat="server" Width="170px" DecimalPlaces="2" DisplayFormatString="N2">
                                </dx:ASPxSpinEdit>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ColSpan="1" ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxButton ID="btnEdit" runat="server" Text="Update">
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:ASPxFormLayout>
            <asp:SqlDataSource ID="sdsSN" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT ITEMNO, SERIALNUM, ITEMNUM, SERIALNUMF, [880USDDATE] AS C880USDDATE, [880USD002] AS C880USD002, [880USD005] AS C880USD005, [880USD010] AS C880USD010, [880USD020] AS C880USD020, [880USD030] AS C880USD030, [880USD040] AS C880USD040, [880USD050] AS C880USD050, [880USD060] AS C880USD060, [880USD070] AS C880USD070 FROM vSN WHERE (ITEMNO = @ITEMNO) AND (SERIALNUM = @SERIALNUM)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="ITEMNO" QueryStringField="itemno" />
                    <asp:QueryStringParameter Name="SERIALNUM" QueryStringField="sn" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
