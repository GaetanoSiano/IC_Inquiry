<%@ Page Title="IC History" Language="vb" AutoEventWireup="false" MasterPageFile="~/IC.Master" CodeBehind="IC_Hist.aspx.vb" Inherits="IC_Inquiry.IC_Hist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div>
            <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="sdsItems" ClientInstanceName="grid" Width="100%" KeyFieldName="ITEMNO" Theme="MaterialCompact" EnableTheming="True" Font-Size="Small">
                <ClientSideEvents ToolbarItemClick="OnToolbarItemClick" />
            <SettingsContextMenu Enabled="True">
            </SettingsContextMenu>
                <SettingsCustomizationDialog Enabled="True" />
            <SettingsPager PageSize="50">
            </SettingsPager>
            <Settings ShowFilterRow="True" ShowFilterRowMenu="True" ShowGroupPanel="True"  ShowVerticalScrollBar="true" VerticalScrollableHeight="0" ShowFilterBar="Visible" />
            <SettingsBehavior EnableCustomizationWindow="True" />
            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
            <SettingsSearchPanel CustomEditorID="tbToolbarSearch" />
                <Columns>
                    <dx:GridViewDataTextColumn FieldName="ITEMNO" VisibleIndex="0" Caption="Item No." ToolTip="Item Number">
                        <Settings AutoFilterCondition="Contains" />
                        <DataItemTemplate>
                            <a id="clickElement"  onclick='OnMoreInfoClick( "/CRM/CustomPages/Accpac/IC_ItemDetail.asp?SID=<%# Session("SID") %>&Key0=58&Key58=<%# Container.KeyValue%>&J=Accpac/IC_ItemDetail.asp&LOCATION=&DDTLNO=&DATABASE=<%# Eval("AUDTORG").ToString()%>&ITEMNUM=<%# Container.KeyValue%>&T=ServiceCustomer")'><%# Eval("FMTITEMNO").ToString()%></a>
                        </DataItemTemplate>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="FMTITEMNO" VisibleIndex="1" Visible="False" Caption="Item Fmt">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ITEMDESC" VisibleIndex="2" Caption="Description" ToolTip="Item Description">
                        <Settings AutoFilterCondition="Contains" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="INACTIVE" VisibleIndex="3" Visible="False" Caption="InActive">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DATEINACTV" VisibleIndex="4" Visible="False" Caption="InActive Dt." ToolTip="InActive Date">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="STOCKUNIT" VisibleIndex="6" Visible="False" Caption="Stock Unit">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="STOCKITEM" VisibleIndex="7" Visible="False" Caption="Stock Item">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DEFPRICLST" VisibleIndex="8" Visible="False" Caption="Def. Price Lst" ToolTip="Default Price List">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DEFUNITPRICE" ReadOnly="True" VisibleIndex="9" Caption="Def. Price" ToolTip="Default Price" Visible="False">
                        <PropertiesTextEdit DisplayFormatString="N2">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="UNITWGT" VisibleIndex="10" Visible="False" Caption="Unit Wgt." ToolTip="Unit Weight">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="PICKINGSEQ" VisibleIndex="11" Visible="False" Caption="Picking Seq." ToolTip="Default Picking Sequence">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="COMMENT1" VisibleIndex="12" Visible="False" Caption="Comment 1">
                        <Settings AutoFilterCondition="Contains" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="COMMENT2" VisibleIndex="13" Visible="False" Caption="Comment 2">
                        <Settings AutoFilterCondition="Contains" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="COMMENT3" VisibleIndex="14" Visible="False" Caption="Comment 3">
                        <Settings AutoFilterCondition="Contains" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="COMMENT4" VisibleIndex="15" Visible="False" Caption="Comment 4">
                        <Settings AutoFilterCondition="Contains" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="COMMODIM" VisibleIndex="16" Visible="False" Caption="Commodity No." ToolTip="Commodity Number">
                        <Settings AutoFilterCondition="Contains" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="SELLABLE" VisibleIndex="17" Visible="False" Caption="Sellable">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="KITTING" VisibleIndex="18" Visible="False" Caption="Kitting Itm." ToolTip="Kitting Item">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="COLOR" ReadOnly="True" VisibleIndex="19" Visible="False" Caption="Color">
                        <Settings AutoFilterCondition="Contains" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataCheckColumn FieldName="DANGEROUS" ReadOnly="True" VisibleIndex="20" Visible="False" Caption="Dangerous">
                    </dx:GridViewDataCheckColumn>
                    <dx:GridViewDataCheckColumn FieldName="EXTWARRANTY" ReadOnly="True" VisibleIndex="21" Visible="False" Caption="Ext Warranty">
                    </dx:GridViewDataCheckColumn>
                    <dx:GridViewDataTextColumn FieldName="ITEMTYPE" ReadOnly="True" VisibleIndex="22" Visible="False" Caption="Item Type">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn FieldName="CATEGORY" VisibleIndex="5" Caption="Category">
                        <PropertiesComboBox DataSourceID="sdsCATEGORIES" EnableFocusedStyle="False" TextField="CATDESC" ValueField="CATEGORY" ValueType="System.String">
                        </PropertiesComboBox>
                        <Settings AllowAutoFilter="False" AllowHeaderFilter="True" SortMode="DisplayText" />
                        <SettingsHeaderFilter Mode="CheckedList">
                        </SettingsHeaderFilter>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataTextColumn Caption="Location" FieldName="LOCATION" VisibleIndex="23">
                    </dx:GridViewDataTextColumn>

                    <dx:GridViewDataTextColumn Caption="Fiscal Year" FieldName="FISCYEAR" VisibleIndex="24">
                        <Settings AllowAutoFilter="False" AllowHeaderFilter="True" />
                        <SettingsHeaderFilter Mode="CheckedList">
                        </SettingsHeaderFilter>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Fiscal Period" FieldName="FISCPERIOD" VisibleIndex="25">
                        <Settings AllowAutoFilter="False" AllowHeaderFilter="True" />
                        <SettingsHeaderFilter Mode="CheckedList">
                        </SettingsHeaderFilter>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn Caption="Date" FieldName="TRANSDATE" ReadOnly="True" VisibleIndex="26">
                        <Settings AllowAutoFilter="False" AllowHeaderFilter="True" />
                        <SettingsHeaderFilter Mode="DateRangePicker">
                        </SettingsHeaderFilter>
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataTextColumn Caption="User" FieldName="AUDTUSER" VisibleIndex="27">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Doc. No." FieldName="DOCNUM" VisibleIndex="28">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Module" FieldName="app" VisibleIndex="29">
                        <Settings AllowAutoFilter="False" AllowHeaderFilter="True" />
                        <SettingsHeaderFilter Mode="CheckedList">
                        </SettingsHeaderFilter>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Qty" FieldName="QUANTITY" VisibleIndex="31">
                        <PropertiesTextEdit DisplayFormatString="N0">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Unit" FieldName="UNIT" VisibleIndex="32">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Cost" FieldName="HOMEEXTCST" VisibleIndex="33" Name="Cost" Visible="False">
                        <PropertiesTextEdit DisplayFormatString="N2">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>

                    <dx:GridViewDataComboBoxColumn Caption="Trans. Type" FieldName="TRANSTYPE" VisibleIndex="30">
                        <PropertiesComboBox ValueType="System.Int32">
                            <Items>
                                <dx:ListEditItem Text="Receipt" Value="1" />
                                <dx:ListEditItem Text="Receipt Adjustment" Value="2" />
                                <dx:ListEditItem Text="Receipt Return" Value="3" />
                                <dx:ListEditItem Text="Shipment" Value="4" />
                                <dx:ListEditItem Text="Shipment Return" Value="5" />
                                <dx:ListEditItem Text="Adjustment Quantity Increase" Value="6" />
                                <dx:ListEditItem Text="Adjustment Quantity Decrease" Value="7" />
                                <dx:ListEditItem Text="Adjustment Cost Increase" Value="8" />
                                <dx:ListEditItem Text="Adjustment Cost Decrease" Value="9" />
                                <dx:ListEditItem Text="Adjustment Both Increase" Value="10" />
                                <dx:ListEditItem Text="Adjustment Both Decrease" Value="11" />
                                <dx:ListEditItem Text="Stock Transfer From" Value="12" />
                                <dx:ListEditItem Text="Stock Transfer To" Value="13" />
                                <dx:ListEditItem Text="Master Item Assembly" Value="14" />
                                <dx:ListEditItem Text="Component Item Assembly" Value="15" />
                                <dx:ListEditItem Text="Invoice" Value="16" />
                                <dx:ListEditItem Text="Credit Note" Value="17" />
                                <dx:ListEditItem Text="Debit Note" Value="18" />
                                <dx:ListEditItem Text="Shipment Adjustment" Value="19" />
                                <dx:ListEditItem Text="Internal Usage" Value="20" />
                            </Items>
                        </PropertiesComboBox>
                        <Settings AllowAutoFilter="False" AllowHeaderFilter="True" />
                        <SettingsHeaderFilter Mode="CheckedList">
                        </SettingsHeaderFilter>
                    </dx:GridViewDataComboBoxColumn>

                </Columns>
                <Toolbars>
                    <dx:GridViewToolbar ItemAlign="Right">
                        <Items>
                            <dx:GridViewToolbarItem BeginGroup="True" Command="ShowCustomizationDialog">
                            </dx:GridViewToolbarItem>
                            <dx:GridViewToolbarItem Text="Export to" Image-IconID="actions_download_16x16office2013" BeginGroup="true">
                                <Items>
                                    <dx:GridViewToolbarItem Name="ExportToPDF" Text="PDF" Image-IconID="export_exporttopdf_16x16office2013" >
<Image IconID="export_exporttopdf_16x16office2013"></Image>
                                    </dx:GridViewToolbarItem>
                                    <dx:GridViewToolbarItem Name="ExportToXLSX" Text="XLSX" Image-IconID="export_exporttoxlsx_16x16office2013" >
<Image IconID="export_exporttoxlsx_16x16office2013"></Image>
                                    </dx:GridViewToolbarItem>
                                    <dx:GridViewToolbarItem Name="ExportToXLS" Text="XLS" Image-IconID="export_exporttoxls_16x16office2013" >
<Image IconID="export_exporttoxls_16x16office2013"></Image>
                                    </dx:GridViewToolbarItem>
                                </Items>

<Image IconID="actions_download_16x16office2013"></Image>
                            </dx:GridViewToolbarItem>
                            <dx:GridViewToolbarItem BeginGroup="true">

                                <Template>
                                    <dx:ASPxButtonEdit ID="tbToolbarSearch" runat="server" NullText="Search..." Height="100%">
                                        <Buttons>
                                            <dx:SpinButtonExtended Image-IconID="find_find_16x16gray" />
                                        </Buttons>
                                    </dx:ASPxButtonEdit>
                                </Template>
                            </dx:GridViewToolbarItem>
                        </Items>
                    </dx:GridViewToolbar>
                </Toolbars>
                <FormatConditions>
                    <dx:GridViewFormatConditionHighlight Expression="[QTYONHAND] &lt; 0" ShowInColumn="Qty. On Hand">
                    </dx:GridViewFormatConditionHighlight>
                </FormatConditions>
            </dx:ASPxGridView>
            <asp:SqlDataSource ID="sdsCATEGORIES" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT * FROM [vCATEGORIES]"></asp:SqlDataSource>
    <dx:ASPxGridViewExporter runat="server" ExportedRowType="All" ID="Exporter"></dx:ASPxGridViewExporter>

            <asp:SqlDataSource ID="sdsItems" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT * FROM [vICHIST]"></asp:SqlDataSource>

            <asp:SqlDataSource ID="sdsItemsNoCost" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT * FROM [vICHIST]"></asp:SqlDataSource>
        </div>
</asp:Content>
