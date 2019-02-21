<%@ Page Title="IC Price" Language="vb" AutoEventWireup="false" MasterPageFile="~/IC.Master" CodeBehind="IC_PriceCost.aspx.vb" Inherits="IC_Inquiry.IC_PriceCost" %>
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
                    <dx:GridViewDataTextColumn FieldName="ITEM" VisibleIndex="23" Visible="False">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="QTYONHAND" VisibleIndex="25" Caption="Qty. On Hand">
                        <PropertiesTextEdit DisplayFormatString="N0">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="QTYCOMMIT" VisibleIndex="26" Caption="Qty Committed">
                        <PropertiesTextEdit DisplayFormatString="N0">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="QTYONORDER" VisibleIndex="27" Caption="Qty. On P/O" ToolTip="Qty. On Purchase Order">
                        <PropertiesTextEdit DisplayFormatString="N0">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="QTYSALORDR" VisibleIndex="28" Caption="Qty. On O/E" ToolTip="Qty. On Sales Order">
                        <PropertiesTextEdit DisplayFormatString="N0">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="TOTALCOST" VisibleIndex="29" Caption="Total Cost" Name="Cost" Visible="False">
                        <PropertiesTextEdit DisplayFormatString="N2">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="COST1" VisibleIndex="33" Visible="False" Caption="Cost 1" Name="Cost">
                        <PropertiesTextEdit DisplayFormatString="N2">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="COST2" VisibleIndex="34" Visible="False" Caption="Cost 2" Name="Cost">
                        <PropertiesTextEdit DisplayFormatString="N2">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="RECENTCOST" VisibleIndex="35" Visible="False" Caption="Recent Cost" Name="Cost">
                        <PropertiesTextEdit DisplayFormatString="N2">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="LASTCOST" VisibleIndex="36" Visible="False" Caption="Last Cost" Name="Cost">
                        <PropertiesTextEdit DisplayFormatString="N2">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="V1_VENDCOST" VisibleIndex="38" Visible="False" Caption="Vend 1 Cost" Name="Cost">
                        <PropertiesTextEdit DisplayFormatString="N2">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="V2_VENDCOST" VisibleIndex="40" Visible="False" Caption="Vend 2 Cost" Name="Cost">
                        <PropertiesTextEdit DisplayFormatString="N2">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="V3_VENDCOST" VisibleIndex="42" Visible="False" Caption="Vend 3 Cost" Name="Cost">
                        <PropertiesTextEdit DisplayFormatString="N2">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn FieldName="CATEGORY" VisibleIndex="5" Caption="Category">
                        <PropertiesComboBox DataSourceID="sdsCATEGORIES" EnableFocusedStyle="False" TextField="CATDESC" ValueField="CATEGORY" ValueType="System.String">
                        </PropertiesComboBox>
                        <Settings AllowAutoFilter="False" AllowHeaderFilter="True" SortMode="DisplayText" />
                        <SettingsHeaderFilter Mode="CheckedList">
                        </SettingsHeaderFilter>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataTextColumn Caption="Location" FieldName="LOCATION" VisibleIndex="24">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Vend 3 No." FieldName="V3_VENDNUM" Visible="False" VisibleIndex="41">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Unit Cost" FieldName="UNITCOST" ReadOnly="True" VisibleIndex="30" Name="Cost" Visible="False">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Vend 1 No." FieldName="V1_VENDNUM" Visible="False" VisibleIndex="37">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Vend 2 No." FieldName="V2_VENDNUM" Visible="False" VisibleIndex="39">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Unit Price" FieldName="UNITPRICE" VisibleIndex="32">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Price List" FieldName="PRICELIST" VisibleIndex="31">
                    </dx:GridViewDataTextColumn>
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

            <asp:SqlDataSource ID="sdsItems" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT * FROM [vICPRICECOST]"></asp:SqlDataSource>

            <asp:SqlDataSource ID="sdsItemsNoCost" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT UNITPRICE, PRICELIST, ITEMNO, FMTITEMNO, ITEMDESC, INACTIVE, DATEINACTV, CATEGORY, STOCKUNIT, STOCKITEM, DEFPRICLST, DEFUNITPRICE, UNITWGT, PICKINGSEQ, COMMENT1, COMMENT2, COMMENT3, COMMENT4, COMMODIM, SELLABLE, KITTING, COLOR, DANGEROUS, EXTWARRANTY, ITEMTYPE, AUDTORG, CNTLACCT, LOCITEMNO, LOCATION, QTYONHAND, QTYCOMMIT, QTYONORDER, QTYSALORDR, 0 AS TOTALCOST, 0 AS COST1, 0 AS COST2, 0 AS RECENTCOST, 0 AS LASTCOST, 0 AS UNITCOST, V1_VENDNUM, V1_VENDNAME, V1_COSTUNIT, 0 AS V1_VENDCOST, V2_VENDNUM, V2_VENDNAME, V2_COSTUNIT, 0 AS V2_VENDCOST, V3_VENDNUM, V3_VENDNAME, V3_COSTUNIT, 0 AS V3_VENDCOST FROM vICPRICECOST"></asp:SqlDataSource>
        </div>
</asp:Content>
