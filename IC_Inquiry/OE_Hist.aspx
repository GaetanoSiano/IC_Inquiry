<%@ Page Title="OE History" Language="vb" AutoEventWireup="false" MasterPageFile="~/IC.Master" CodeBehind="OE_Hist.aspx.vb" Inherits="IC_Inquiry.OE_Hist" %>
<%@ Register assembly="DevExpress.Web.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Data.Linq" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="EntityServerModeDataSource2" ClientInstanceName="grid" Width="100%" KeyFieldName="ID" Theme="MaterialCompact" EnableTheming="True" Font-Size="Small">
        <ClientSideEvents ToolbarItemClick="OnToolbarItemClick" />
        <SettingsContextMenu Enabled="True">
        </SettingsContextMenu>
        <SettingsCustomizationDialog Enabled="True" />
        <SettingsPager PageSize="50">
        </SettingsPager>
        <Settings ShowFilterRow="True" ShowFilterRowMenu="True" ShowGroupPanel="True"  ShowVerticalScrollBar="true" VerticalScrollableHeight="0" ShowFilterBar="Visible" AutoFilterCondition="Contains" />
        <SettingsBehavior EnableCustomizationWindow="True" />
        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
        <SettingsSearchPanel CustomEditorID="tbToolbarSearch" />
        <Columns>
            <dx:GridViewDataTextColumn FieldName="ID" VisibleIndex="0" ReadOnly="True" ShowInCustomizationForm="False" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="CUSTOMER" VisibleIndex="11">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="ITEM" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="YR" VisibleIndex="5" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="PR" VisibleIndex="6" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="TRANDATE" VisibleIndex="7">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn FieldName="LINENO" VisibleIndex="10" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="TRANNUM" VisibleIndex="8">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="ORDDATE" VisibleIndex="13" Visible="False">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn FieldName="ORDNUMBER" VisibleIndex="14" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="SHIPDATE" VisibleIndex="25" Visible="False">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn FieldName="SALESPER" VisibleIndex="16" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="TERRITORY" VisibleIndex="17" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="TRANLOC" VisibleIndex="4">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="CATEGORY" VisibleIndex="18" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="QTYSOLD" VisibleIndex="3">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="SCURN" VisibleIndex="19" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="FCSTSALES" VisibleIndex="20" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="FAMTSALES" VisibleIndex="21" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="FRETSALES" VisibleIndex="22" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="PONUMBER" VisibleIndex="15" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="FAMTTRAN" VisibleIndex="23" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="SHINUMBER" VisibleIndex="24" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="NAMECUST" VisibleIndex="12">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="ITEMDESC" VisibleIndex="2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataComboBoxColumn FieldName="TRANTYPE" VisibleIndex="9">
                <PropertiesComboBox ValueType="System.Int32">
                    <Items>
                        <dx:ListEditItem Text="Invoice" Value="1" />
                        <dx:ListEditItem Text="Credit Note" Value="2" />
                        <dx:ListEditItem Text="Debit Note" Value="3" />
                    </Items>
                </PropertiesComboBox>
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
                                <Image IconID="export_exporttopdf_16x16office2013">
                                </Image>
                            </dx:GridViewToolbarItem>
                            <dx:GridViewToolbarItem Name="ExportToXLSX" Text="XLSX" Image-IconID="export_exporttoxlsx_16x16office2013" >
                                <Image IconID="export_exporttoxlsx_16x16office2013">
                                </Image>
                            </dx:GridViewToolbarItem>
                            <dx:GridViewToolbarItem Name="ExportToXLS" Text="XLS" Image-IconID="export_exporttoxls_16x16office2013" >
                                <Image IconID="export_exporttoxls_16x16office2013">
                                </Image>
                            </dx:GridViewToolbarItem>
                        </Items>
                        <Image IconID="actions_download_16x16office2013">
                        </Image>
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
    <dx:EntityServerModeDataSource ID="EntityServerModeDataSource2" runat="server" ContextTypeName="IC_Inquiry.CRMXEntities" TableName="vOESHPDETAILS" />
    <dx:ASPxGridViewExporter runat="server" ExportedRowType="All" ID="Exporter">
    </dx:ASPxGridViewExporter>
</asp:Content>
