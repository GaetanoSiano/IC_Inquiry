<%@ Page Title="OE Orders" Language="vb" AutoEventWireup="false" MasterPageFile="~/IC.Master" CodeBehind="OE_Orders.aspx.vb" Inherits="IC_Inquiry.OE_Orders" %>
<%@ Register assembly="DevExpress.Web.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Data.Linq" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="EntityServerModeDataSource1" ClientInstanceName="grid" Width="100%" KeyFieldName="ID" Theme="MaterialCompact" EnableTheming="True" Font-Size="Small">
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
        <dx:GridViewDataTextColumn FieldName="ORDUNIQ" VisibleIndex="1" Visible="False" ShowInCustomizationForm="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ORDNUMBER" VisibleIndex="2">
            <DataItemTemplate>
                <a href="#" id="clickElement" onclick='OnOrderNoClick( <%# Eval("OETYPE")%>,<%# Eval("ORDUNIQ")%>,<%# Eval("COMPANYID")%>,<%# Eval("OPPOID")%>, <%# Session("SID") %>);return false;'><%# Eval("ORDNUMBER").ToString()%></a>
                
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CUSTOMER" VisibleIndex="8">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CUSTGROUP" VisibleIndex="9">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="BILNAME" VisibleIndex="10">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="BILPHONE" VisibleIndex="11" Visible="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="BILCONTACT" VisibleIndex="12" Visible="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="SHIPTO" VisibleIndex="13" Visible="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="SHPNAME" VisibleIndex="14" Visible="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="SHPPHONE" VisibleIndex="15" Visible="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="SHPCONTACT" VisibleIndex="16" Visible="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="PONUMBER" VisibleIndex="17">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="DESC" VisibleIndex="19" Visible="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="SALESPER1" VisibleIndex="20" Visible="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="SALESPER2" VisibleIndex="21" Visible="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="SALESPER3" VisibleIndex="22" Visible="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="SALESPER4" VisibleIndex="23" Visible="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="SALESPER5" VisibleIndex="24" Visible="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="OPPOID" VisibleIndex="25" ShowInCustomizationForm="False" Visible="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="COMPANYID" VisibleIndex="26" ShowInCustomizationForm="False" Visible="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="SHINUMBER" VisibleIndex="3">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="INVNUMBER" VisibleIndex="4">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataDateColumn FieldName="ORDDATE" VisibleIndex="5">
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataDateColumn FieldName="SHIDATE" VisibleIndex="6">
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataDateColumn FieldName="INVDATE" VisibleIndex="7">
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataComboBoxColumn FieldName="OETYPE" VisibleIndex="18">
            <PropertiesComboBox ValueType="System.Int32">
                <Items>
                    <dx:ListEditItem Text="Active" Value="1" />
                    <dx:ListEditItem Text="Standing" Value="2" />
                    <dx:ListEditItem Text="Future" Value="3" />
                    <dx:ListEditItem Text="Quote" Value="4" />
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
<dx:EntityServerModeDataSource ID="EntityServerModeDataSource1" runat="server" ContextTypeName="IC_Inquiry.CRMXEntities" TableName="vORDERS" />
    <dx:ASPxGridViewExporter runat="server" ExportedRowType="All" ID="Exporter"></dx:ASPxGridViewExporter>

            </asp:Content>
