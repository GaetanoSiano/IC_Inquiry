<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ICILOC.ascx.vb" Inherits="IC_Inquiry.ICILOC" %>


<dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="sdsCRMX" ClientInstanceName="grid" Width="100%" KeyFieldName="ITEMNO">
    <SettingsContextMenu Enabled="True">
    </SettingsContextMenu>
    <SettingsPager PageSize="50">
    </SettingsPager>
    <Settings ShowFilterRow="True" ShowFilterRowMenu="True" ShowGroupPanel="True"  ShowVerticalScrollBar="true" VerticalScrollableHeight="0" ShowFilterBar="Visible" />
    <SettingsBehavior EnableCustomizationWindow="True" />
    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
    <SettingsSearchPanel Visible="True" />
    <Columns>
        <dx:GridViewDataTextColumn FieldName="ITEMNO" VisibleIndex="0">
            <DataItemTemplate>
                <a id="clickElement" target="_top" href="/CRM/CustomPages/ServiceCustomer/ServiceCustomerSummary.asp?SID=<%# Request.QueryString("SID") %>&Key0=58&Key58=<%# Container.KeyValue%>&J=ServiceCustomer/ServiceCustomerSummary.asp&E=ServiceCustomer&cust_ServiceCustomerID=<%# Container.KeyValue%>&T=ServiceCustomer"><%# Eval("FMTITEMNO").ToString()%></a>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FMTITEMNO" VisibleIndex="1">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ITEMDESC" VisibleIndex="2">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="PRICELIST" VisibleIndex="3">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="QTYUNIT" VisibleIndex="4">
            <PropertiesTextEdit DisplayFormatString="N0">
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="UNITPRICE" VisibleIndex="5">
            <PropertiesTextEdit DisplayFormatString="N2">
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="LOCATION" VisibleIndex="6">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="QTYONHAND" ReadOnly="True" VisibleIndex="7">
            <PropertiesTextEdit DisplayFormatString="N0">
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="QTYCOMMIT" VisibleIndex="8">
            <PropertiesTextEdit DisplayFormatString="N0">
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="QTYONORDER" VisibleIndex="9">
            <PropertiesTextEdit DisplayFormatString="N0">
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="QTYSALORDR" VisibleIndex="10">
            <PropertiesTextEdit DisplayFormatString="N0">
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TOTALCOST" VisibleIndex="11">
            <PropertiesTextEdit DisplayFormatString="N2">
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="COST1" VisibleIndex="12">
            <PropertiesTextEdit DisplayFormatString="N2">
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="COST2" VisibleIndex="13">
            <PropertiesTextEdit DisplayFormatString="N2">
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="RECENTCOST" VisibleIndex="14">
            <PropertiesTextEdit DisplayFormatString="N2">
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="LASTCOST" VisibleIndex="15">
            <PropertiesTextEdit DisplayFormatString="N2">
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="UNITCOST" ReadOnly="True" VisibleIndex="16">
            <PropertiesTextEdit DisplayFormatString="N2">
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="V1_VENDNUM" Visible="False" VisibleIndex="17">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="V1_VENDNAME" Visible="False" VisibleIndex="18">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="V1_COSTUNIT" Visible="False" VisibleIndex="19">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="V1_VENDCOST" ReadOnly="True" Visible="False" VisibleIndex="20">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="V2_VENDNUM" Visible="False" VisibleIndex="21">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="V2_VENDNAME" Visible="False" VisibleIndex="22">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="V2_COSTUNIT" Visible="False" VisibleIndex="23">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="V2_VENDCOST" ReadOnly="True" Visible="False" VisibleIndex="24">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="V3_VENDNUM" Visible="False" VisibleIndex="25">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="V3_VENDNAME" Visible="False" VisibleIndex="26">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="V3_COSTUNIT" Visible="False" VisibleIndex="27">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="V3_VENDCOST" ReadOnly="True" Visible="False" VisibleIndex="28">
        </dx:GridViewDataTextColumn>
    </Columns>
</dx:ASPxGridView>
<asp:SqlDataSource ID="sdsCRMX" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT * FROM [vICPRICECOST]"></asp:SqlDataSource>

