<%@ Page Title="IC Serial Nos" Language="vb" AutoEventWireup="false" MasterPageFile="~/IC.Master" CodeBehind="IC_SN.aspx.vb" Inherits="IC_Inquiry.IC_SN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<%-- ver 1 --%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div>

                <dx:ASPxPopupControl ID="popPrice" runat="server" AllowDragging="True" ClientInstanceName="popPrice" CloseOnEscape="True" EnableClientSideAPI="True" Modal="True" HeaderText="Price Info" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Theme="MaterialCompact">
                    <ContentCollection>
<dx:PopupControlContentControl runat="server">
<dx:ASPxFormLayout ID="frmEditPrice" runat="server" ColCount="2" ColumnCount="2" DataSourceID="sdsSN">
                <Items>
                    <dx:LayoutItem Caption="Item" ColSpan="1" FieldName="ITEMNO">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="ITEMNO" runat="server" Width="170px" ReadOnly="True">
                                    <ReadOnlyStyle BackColor="#E4E4E4">
                                    </ReadOnlyStyle>
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ColSpan="1" FieldName="SERIALNUM">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="SERIALNUM" runat="server" Width="170px" ReadOnly="True">
                                    <ReadOnlyStyle BackColor="#E4E4E4">
                                    </ReadOnlyStyle>
                                </dx:ASPxTextBox>
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
                    <dx:LayoutItem ColSpan="1" FieldName="C880USDDATE">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxDateEdit ID="C880USDDATE" runat="server" ReadOnly="False">
                                    <ReadOnlyStyle BackColor="#E4E4E4">
                                    </ReadOnlyStyle>
                                </dx:ASPxDateEdit>
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
                        </dx:PopupControlContentControl>
</ContentCollection>
                </dx:ASPxPopupControl>

            <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1" ClientInstanceName="grid" Theme="MaterialCompact" EnableTheming="True" Font-Size="Small" Width="100%" KeyFieldName="SERIALNUM">
                <ClientSideEvents ToolbarItemClick="OnToolbarItemClick" />
            <SettingsContextMenu Enabled="True">
            </SettingsContextMenu>
                <SettingsAdaptivity>
                    <AdaptiveDetailLayoutProperties>
                        <Items>
                            <dx:GridViewColumnLayoutItem ColumnName="ITEMNUM">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="010FGWSN">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="SERIALNUMF">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="020ENGINESN">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="030ALTSN">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="100FREQUENCY">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="110VOLTAGE">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="160ENCLTYPE">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="170PRODPROMI">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="200CTRLPANEL">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="210LIFTPOINT">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="230BATTERY">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="240SILENCER">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="410ETAPORT">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="800TRESVDATE">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="810TRESVSLP">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="850TRESVNOTE">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="900NOTES">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="LOCATION">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="ST">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="RESVFORORD_DESC">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="STATUS_DESC">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="PO_TRANSDATE">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="PO_PONUMBER">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="PO_INVDATE">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="SO_ORDNUMBER">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="SO_CUSTOMER">
                            </dx:GridViewColumnLayoutItem>
                            <dx:GridViewColumnLayoutItem ColumnName="SO_ORDDATE">
                            </dx:GridViewColumnLayoutItem>
                        </Items>
                    </AdaptiveDetailLayoutProperties>
                </SettingsAdaptivity>
                <SettingsCustomizationDialog Enabled="True" />
            <SettingsPager PageSize="50">
            </SettingsPager>
                <SettingsEditing Mode="PopupEditForm">
                </SettingsEditing>
            <Settings ShowFilterRow="True" ShowFilterRowMenu="True" ShowGroupPanel="True"    ShowFilterBar="Visible" VerticalScrollBarMode="Auto" HorizontalScrollBarMode="Auto" />
            <SettingsBehavior EnableCustomizationWindow="True" AllowEllipsisInText="True" AllowSelectByRowClick="True" AllowSelectSingleRowOnly="True" />
                <SettingsResizing ColumnResizeMode="Control" />
                <SettingsCookies CookiesID="Test" Enabled="True" StoreControlWidth="True" />
                <SettingsCommandButton>
                    <UpdateButton ButtonType="Image" RenderMode="Image">
                        <Image IconID="actions_saveas_16x16devav">
                        </Image>
                    </UpdateButton>
                    <CancelButton ButtonType="Image" RenderMode="Image">
                        <Image IconID="actions_close_16x16office2013">
                        </Image>
                    </CancelButton>
                    <EditButton ButtonType="Image" RenderMode="Image">
                        <Image IconID="comments_editcomment_16x16">
                        </Image>
                    </EditButton>
                </SettingsCommandButton>
            <SettingsDataSecurity AllowDelete="False" AllowInsert="False" />
                <SettingsPopup>
                    <EditForm HorizontalAlign="WindowCenter" Modal="True" VerticalAlign="WindowCenter">
                    </EditForm>
                </SettingsPopup>
            <SettingsSearchPanel CustomEditorID="tbToolbarSearch" />
                <EditFormLayoutProperties>
                    <Items>
                        <dx:GridViewColumnLayoutItem ColumnName="C800TRESVDATE">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColumnName="C810TRESVSLP">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColumnName="C850TRESVNOTE">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColumnName="C900NOTES">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewLayoutGroup Caption="600 Series" ColCount="3" Name="600">
                            <Items>
                                <dx:GridViewColumnLayoutItem ColumnName="C600DESPATCH" Name="600">
                                </dx:GridViewColumnLayoutItem>
                                <dx:GridViewColumnLayoutItem ColumnName="C605FACTRYREF" Name="600">
                                </dx:GridViewColumnLayoutItem>
                                <dx:GridViewColumnLayoutItem ColumnName="C608DOCSDATE" Name="600">
                                </dx:GridViewColumnLayoutItem>
                                <dx:GridViewColumnLayoutItem ColumnName="C610CONTAINER" Name="600">
                                </dx:GridViewColumnLayoutItem>
                                <dx:GridViewColumnLayoutItem ColumnName="C620BL" Name="600">
                                </dx:GridViewColumnLayoutItem>
                                <dx:GridViewColumnLayoutItem ColumnName="C630ISF" Name="600">
                                </dx:GridViewColumnLayoutItem>
                                <dx:GridViewColumnLayoutItem ColumnName="C640CARRIER" Name="600">
                                </dx:GridViewColumnLayoutItem>
                                <dx:GridViewColumnLayoutItem ColumnName="C640CARRIER2" Name="600">
                                </dx:GridViewColumnLayoutItem>
                                <dx:GridViewColumnLayoutItem ColumnName="C640CARRIER3" Name="600">
                                </dx:GridViewColumnLayoutItem>
                                <dx:GridViewColumnLayoutItem ColumnName="C645VESSEL">
                                </dx:GridViewColumnLayoutItem>
                                <dx:GridViewColumnLayoutItem ColumnName="C645VESSEL2">
                                </dx:GridViewColumnLayoutItem>
                                <dx:GridViewColumnLayoutItem ColumnName="C645VESSEL3">
                                </dx:GridViewColumnLayoutItem>
                                <dx:GridViewColumnLayoutItem ColumnName="C648VOYAGE">
                                </dx:GridViewColumnLayoutItem>
                                <dx:GridViewColumnLayoutItem ColumnName="C650PORTORIG">
                                </dx:GridViewColumnLayoutItem>
                                <dx:GridViewColumnLayoutItem ColumnName="C660CF214">
                                </dx:GridViewColumnLayoutItem>
                                <dx:GridViewColumnLayoutItem ColumnName="C665IT7512IN">
                                </dx:GridViewColumnLayoutItem>
                                <dx:GridViewColumnLayoutItem ColumnName="C670IMPORTENT">
                                </dx:GridViewColumnLayoutItem>
                            </Items>
                            <SettingsItemCaptions Location="Top" />
                        </dx:GridViewLayoutGroup>
                        <dx:EditModeCommandLayoutItem HorizontalAlign="Right">
                        </dx:EditModeCommandLayoutItem>
                    </Items>
                </EditFormLayoutProperties>
                <Columns>
                    <dx:GridViewDataTextColumn FieldName="ITEMNUM" VisibleIndex="1" Caption="Item" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="SERIALNUMF" VisibleIndex="3" Caption="Serial Number" Width="100px" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                        <HeaderStyle Wrap="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C010FGWSN" VisibleIndex="2" Caption="Larne GSN" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="C020ENGINESN" ShowInCustomizationForm="True" Caption="Engine S/N" ToolTip="Engine Serial Number" VisibleIndex="34" Visible="False" ReadOnly="True">
<Settings AutoFilterCondition="Contains"></Settings>
    <EditFormSettings Visible="False" />
</dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="C030ALTSN" ShowInCustomizationForm="True" Caption="Alt" VisibleIndex="14" ReadOnly="True">
<Settings AutoFilterCondition="Contains"></Settings>
    <EditFormSettings Visible="False" />
</dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C100FREQUENCY" VisibleIndex="13" Caption="Freq" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C110VOLTAGE" VisibleIndex="15" Caption="Voltage" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C120PHASE" VisibleIndex="33" Visible="False" Caption="Phase" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C150ENCLOSURE" VisibleIndex="50" Visible="False" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C160ENCLTYPE" VisibleIndex="25" Caption="Encl" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C180ENGINE" VisibleIndex="51" Visible="False" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="C185ENGINEBR" ShowInCustomizationForm="True" Visible="False" VisibleIndex="52" ReadOnly="True">
<Settings AutoFilterCondition="Contains"></Settings>
    <EditFormSettings Visible="False" />
</dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C190LENGTHDEP" Visible="False" VisibleIndex="53" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="C195LENGTHDEP" ShowInCustomizationForm="True" Visible="False" VisibleIndex="54" ReadOnly="True">
<Settings AutoFilterCondition="Contains"></Settings>
    <EditFormSettings Visible="False" />
</dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C196WIDTH" Visible="False" VisibleIndex="55" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C197HEIGHT" Visible="False" VisibleIndex="56" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C198VOLUME" Visible="False" VisibleIndex="57" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C210LIFTPOINT" VisibleIndex="27" Caption="Lift Pt" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C220ALTERNATO" Visible="False" VisibleIndex="58" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C230BATTERY" VisibleIndex="26" Caption="Batt" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C240SILENCER" VisibleIndex="28" Caption="Silc" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C260EPA" Visible="False" VisibleIndex="59" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C270FUELTANK" Visible="False" VisibleIndex="60" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C280NEL1" Visible="False" VisibleIndex="61" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C900NOTES" VisibleIndex="8">
                        <PropertiesTextEdit MaxLength="60">
                        </PropertiesTextEdit>
                        <Settings AutoFilterCondition="Contains" />
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="LOCATION" VisibleIndex="29" Caption="Location" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ST" ReadOnly="True" VisibleIndex="17" Caption="ST">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="RESVFORORD" Visible="False" VisibleIndex="67" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="RESVFORORD_DESC" ReadOnly="True" VisibleIndex="0" Caption="Status">
                        <Settings AllowAutoFilter="False" AllowHeaderFilter="True" />
                        <SettingsHeaderFilter Mode="CheckedList">
                        </SettingsHeaderFilter>
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="STATUS_DESC" ReadOnly="True" VisibleIndex="68" Visible="False">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="STATUS" Visible="False" VisibleIndex="69" ReadOnly="True">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="PO_DOCNUM" Visible="False" VisibleIndex="70" Caption="P/O No." ReadOnly="True">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn FieldName="PO_TRANSDATE" VisibleIndex="19" Caption="PO Date" ReadOnly="True">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataTextColumn FieldName="PO_RCPNUMBER" Visible="False" VisibleIndex="71" Caption="P/O Rcp. No." ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="PO_PONUMBER" VisibleIndex="18" Caption="PO" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="PO_VDCODE" Visible="False" VisibleIndex="72" Caption="P/O Vend." ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="PO_VDNAME" Visible="False" VisibleIndex="73" Caption="P/O Vend. Name" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="PO_INVNUMBER" Visible="False" VisibleIndex="74" Caption="P/O Inv. No." ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn FieldName="PO_INVDATE" VisibleIndex="21" Caption="Disp.Lrn" ReadOnly="True">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataTextColumn FieldName="SO_ORDUNIQ" Visible="False" VisibleIndex="75" ShowInCustomizationForm="False" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="SO_LINENUM" Visible="False" VisibleIndex="76" ShowInCustomizationForm="False" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="SO_ORDNUMBER" VisibleIndex="30" Caption="S/O No." ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="SO_CUSTOMER" VisibleIndex="31" Caption="S/O Cust" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="SO_BILNAME" Visible="False" VisibleIndex="77" Caption="S/O Bill Name" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="SO_SHPNAME" Visible="False" VisibleIndex="78" Caption="S/O Ship Name" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn FieldName="SO_ORDDATE" VisibleIndex="32" Caption="S/O Date" ReadOnly="True">
                        <PropertiesDateEdit DisplayFormatString="d">
                        </PropertiesDateEdit>
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataDateColumn FieldName="C400PRODPROMI" Visible="False" VisibleIndex="62" Caption="C400PRODPROMI" ReadOnly="True">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataDateColumn FieldName="C410ETAPORT" VisibleIndex="23" Caption="ETA Port" ReadOnly="True">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataDateColumn FieldName="C420INSHOP" Visible="False" VisibleIndex="63" ReadOnly="True">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataDateColumn FieldName="C430OKTOSHIP" Visible="False" VisibleIndex="64" ReadOnly="True">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataDateColumn FieldName="C440PICKUP" Visible="False" VisibleIndex="65" ReadOnly="True">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataDateColumn FieldName="C450STARTUP" Visible="False" VisibleIndex="66" ReadOnly="True">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataTextColumn VisibleIndex="11" Caption="List Price" FieldName="LISTPRICE" ReadOnly="True">
                        <PropertiesTextEdit DisplayFormatString="n2">
                        </PropertiesTextEdit>
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn VisibleIndex="12" Caption="Stone G" FieldName="C250STONEGUAR" ReadOnly="True">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C200CTRLPANEL" VisibleIndex="16" Caption="C. Pan" ReadOnly="True">
                        <Settings AutoFilterCondition="Contains" />
                        <Settings AutoFilterCondition="Contains" />
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn VisibleIndex="22"  FieldName="C600DESPATCH" Name="600DESPATCH">
                        <PropertiesTextEdit MaxLength="20">
                        </PropertiesTextEdit>
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Category" FieldName="CATEGORY" ShowInCustomizationForm="True" VisibleIndex="9" ReadOnly="True">
                        <PropertiesComboBox DataSourceID="sdsCATEGORIES" TextField="CATEGORY" ValueField="CATEGORY">
                        </PropertiesComboBox>
                        <Settings AllowAutoFilter="False" AllowHeaderFilter="True" />
                        <SettingsHeaderFilter Mode="CheckedList">
                        </SettingsHeaderFilter>
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Account Set" FieldName="CNTLACCT" ShowInCustomizationForm="True" VisibleIndex="10" ReadOnly="True">
                        <PropertiesComboBox DataSourceID="sdsACCTSETS" TextField="CNTLACCT" ValueField="CNTLACCT">
                        </PropertiesComboBox>
                        <Settings AllowAutoFilter="False" AllowHeaderFilter="True" />
                        <SettingsHeaderFilter Mode="CheckedList">
                        </SettingsHeaderFilter>
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataDateColumn Caption="Arrival Wrh" FieldName="ARRIVALDATE" VisibleIndex="24" ReadOnly="True">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataTextColumn Caption="140KVA" FieldName="C143KVA" ShowInCustomizationForm="True" ToolTip="kVA Prime 50Hz" Visible="False" VisibleIndex="35" ReadOnly="True">
                        <PropertiesTextEdit DisplayFormatString="g">
                        </PropertiesTextEdit>
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="130KW" FieldName="C130KW" ShowInCustomizationForm="True" ToolTip="Kilowatts Prime 50Hz" Visible="False" VisibleIndex="36" ReadOnly="True">
                        <PropertiesTextEdit DisplayFormatString="g">
                        </PropertiesTextEdit>
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="133KW" FieldName="C133KW" ShowInCustomizationForm="True" ToolTip="Kilowatts Standby 50Hz" Visible="False" VisibleIndex="37" ReadOnly="True">
                        <PropertiesTextEdit DisplayFormatString="g">
                        </PropertiesTextEdit>
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="136KW" FieldName="C136KW" ShowInCustomizationForm="True" ToolTip="Kilowatts Prime 60Hz" Visible="False" VisibleIndex="38" ReadOnly="True">
                        <PropertiesTextEdit DisplayFormatString="g">
                        </PropertiesTextEdit>
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="139KW" FieldName="C139KW" ShowInCustomizationForm="True" ToolTip="Kilowatts Standby 60Hz" Visible="False" VisibleIndex="39" ReadOnly="True">
                        <PropertiesTextEdit DisplayFormatString="g">
                        </PropertiesTextEdit>
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="143KVA" FieldName="C146KVA" ShowInCustomizationForm="True" ToolTip="kVA Standby 50Hz" Visible="False" VisibleIndex="42" ReadOnly="True">
                        <PropertiesTextEdit DisplayFormatString="g">
                        </PropertiesTextEdit>
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C140KVA" ShowInCustomizationForm="True" Visible="False" VisibleIndex="46" ReadOnly="True">
                        <PropertiesTextEdit DisplayFormatString="g">
                        </PropertiesTextEdit>
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C149KVA" ShowInCustomizationForm="True" Visible="False" VisibleIndex="48" ReadOnly="True">
                        <PropertiesTextEdit DisplayFormatString="g">
                        </PropertiesTextEdit>
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ITEMNO" ReadOnly="True" ShowInCustomizationForm="False" Visible="False" VisibleIndex="80">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="SERIALNUM" ReadOnly="True" ShowInCustomizationForm="False" Visible="False" VisibleIndex="81">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn Caption="P. Prom" FieldName="C170PRODPROMI" ReadOnly="True" VisibleIndex="20">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataTextColumn Caption="Total Cost" FieldName="ASSETCOST" MinWidth="100" Name="Cost" VisibleIndex="82" Visible="False">
                        <PropertiesTextEdit DisplayFormatString="N2">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewCommandColumn ShowEditButton="True" ShowInCustomizationForm="True" VisibleIndex="4" Width="75px">
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataDateColumn Caption="Rsv. Date" FieldName="C800TRESVDATE" ShowInCustomizationForm="True" VisibleIndex="5">
                        <PropertiesDateEdit>
                            <ClearButton DisplayMode="Always">
                            </ClearButton>
                        </PropertiesDateEdit>
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Rsv. Salesperson" FieldName="C810TRESVSLP" ShowInCustomizationForm="True" VisibleIndex="6">
                        <PropertiesComboBox DataSourceID="sdsRESVSLP" TextField="RESVSLPNAME" ValueField="RESVSLP">
                            <ClientSideEvents KeyUp="function(s, e) {
    if(e.htmlEvent.keyCode==46) {
    s.SetSelectedIndex(-1);&nbsp;
    s.HideDropDown();
&nbsp;&nbsp;}
}" />
                            <ClearButton DisplayMode="Always">
                            </ClearButton>
                        </PropertiesComboBox>
                        <Settings AutoFilterCondition="Contains" />
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataTextColumn Caption="Rsv. Note" FieldName="C850TRESVNOTE" ShowInCustomizationForm="True" VisibleIndex="7">
                        <PropertiesTextEdit MaxLength="60">
                        </PropertiesTextEdit>
                        <Settings AutoFilterCondition="Contains" />
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C610CONTAINER" Visible="False" VisibleIndex="84" Name="610CONTAINER">
                        <PropertiesTextEdit MaxLength="20">
                        </PropertiesTextEdit>
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C620BL" Visible="False" VisibleIndex="85" Name="620BL">
                        <PropertiesTextEdit MaxLength="20">
                        </PropertiesTextEdit>
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C191WIDTH" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="99">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C192HEIGHT" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="100">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C501OPTION1" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="101">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C501OPTION2" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="102">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C501OPTION3" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="103">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C501OPTION4" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="104">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C501OPTION5" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="105">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C550VENDORVIN" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="106">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C605FACTRYREF" Name="605FACTRYREF" ShowInCustomizationForm="True" Visible="False" VisibleIndex="83">
                        <PropertiesTextEdit MaxLength="20">
                        </PropertiesTextEdit>
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn FieldName="C608DOCSDATE" Name="608DOCSDATE" ShowInCustomizationForm="True" Visible="False" VisibleIndex="86">
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataTextColumn FieldName="C630ISF" Name="630ISF" ShowInCustomizationForm="True" Visible="False" VisibleIndex="87">
                        <PropertiesTextEdit MaxLength="20">
                        </PropertiesTextEdit>
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn FieldName="C640CARRIER" Name="640CARRIER" ShowInCustomizationForm="True" Visible="False" VisibleIndex="88">
                        <PropertiesComboBox DataSourceID="sds640CARRIERS" TextField="OPTVALUE" ValueField="OPTVALUE">
                            <ClearButton DisplayMode="Always">
                            </ClearButton>
                        </PropertiesComboBox>
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn FieldName="C640CARRIER2" Name="640CARRIER2" ShowInCustomizationForm="True" Visible="False" VisibleIndex="89">
                        <PropertiesComboBox DataSourceID="sds640CARRIERS2" TextField="OPTVALUE" ValueField="OPTVALUE">
                            <ClearButton DisplayMode="Always">
                            </ClearButton>
                        </PropertiesComboBox>
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataTextColumn FieldName="C645VESSEL" Visible="False" VisibleIndex="91">
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C645VESSEL2" Visible="False" VisibleIndex="92">
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C645VESSEL3" Visible="False" VisibleIndex="93">
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C648VOYAGE" Visible="False" VisibleIndex="94">
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C660CF214" Visible="False" VisibleIndex="96">
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C665IT7512IN" Visible="False" VisibleIndex="97">
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C670IMPORTENT" Visible="False" VisibleIndex="98">
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C700BOOKINGNO" ReadOnly="True" Visible="False" VisibleIndex="107">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C710IE7512" ReadOnly="True" Visible="False" VisibleIndex="108">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C713TE7512" ReadOnly="True" Visible="False" VisibleIndex="109">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C716IT7512OUT" ReadOnly="True" Visible="False" VisibleIndex="110">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C730CONTAINER" ReadOnly="True" Visible="False" VisibleIndex="112">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C735SEALNO" ReadOnly="True" Visible="False" VisibleIndex="113">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C744VESSELNAM" ReadOnly="True" Visible="False" VisibleIndex="115">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C748VOYAGE" ReadOnly="True" Visible="False" VisibleIndex="116">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C750EXPORTBL" ReadOnly="True" Visible="False" VisibleIndex="118">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn FieldName="C640CARRIER3" Visible="False" VisibleIndex="90">
                        <PropertiesComboBox DataSourceID="sds640CARRIERS3" TextField="OPTVALUE" ValueField="OPTVALUE">
                            <ClearButton DisplayMode="Always">
                            </ClearButton>
                        </PropertiesComboBox>
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn FieldName="C650PORTORIG" Visible="False" VisibleIndex="95">
                        <PropertiesComboBox DataSourceID="sds650PORTORIGS" TextField="VDESC" ValueField="OPTVALUE">
                            <ClearButton DisplayMode="Always">
                            </ClearButton>
                        </PropertiesComboBox>
                        <HeaderStyle BackColor="#FFFFCC" />
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn FieldName="C720PORTLOAD" ReadOnly="True" Visible="False" VisibleIndex="111">
                        <PropertiesComboBox DataSourceID="sds720PORTLOADS" TextField="VDESC" ValueField="OPTVALUE">
                            <ClearButton DisplayMode="Always">
                            </ClearButton>
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn FieldName="C740OCEANCARR" ReadOnly="True" Visible="False" VisibleIndex="114">
                        <PropertiesComboBox DataSourceID="sds740OCEANCARRS" TextField="OPTVALUE" ValueField="OPTVALUE">
                            <ClearButton DisplayMode="Always">
                            </ClearButton>
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn FieldName="C760PORTDEST" ReadOnly="True" Visible="False" VisibleIndex="117">
                        <PropertiesComboBox DataSourceID="sds760PORTDESTS" TextField="VDESC" ValueField="OPTVALUE">
                            <ClearButton DisplayMode="Always">
                            </ClearButton>
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataTextColumn Caption="S/O Salesperson" FieldName="SALESPER1" Visible="False" VisibleIndex="79">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C193WEIGHTKG" Visible="False" VisibleIndex="119">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C199WEIGHITEM" Visible="False" VisibleIndex="120">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C221ALTMODEL" Visible="False" VisibleIndex="121">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C300COUNTRYOR" Visible="False" VisibleIndex="122">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="C301COOSERIAL" Visible="False" VisibleIndex="123">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn FieldName="C951CUSTSECT1" Visible="False" VisibleIndex="125">
                        <PropertiesComboBox DataSourceID="sds951CUSTSECT1" TextField="VDESC" ValueField="OPTVALUE">
                        </PropertiesComboBox>
                        <Settings AllowAutoFilter="False" AllowHeaderFilter="True" />
                        <SettingsHeaderFilter Mode="CheckedList">
                        </SettingsHeaderFilter>
                    </dx:GridViewDataComboBoxColumn>
                <dx:GridViewDataTextColumn FieldName="C880USDDATE" Visible="False" VisibleIndex="137">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="C880USD002" Visible="False" VisibleIndex="138">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="C880USD005" Visible="False" VisibleIndex="129">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="C880USD010" Visible="False" VisibleIndex="130">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="C880USD020" Visible="False" VisibleIndex="131">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="C880USD030" Visible="False" VisibleIndex="132">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="C880USD040" Visible="False" VisibleIndex="133">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="C880USD050" Visible="False" VisibleIndex="134">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="C880USD060" Visible="False" VisibleIndex="135">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="C880USD070" Visible="False" VisibleIndex="136">
                </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn FieldName="C952CUSTSECT2" Visible="False" VisibleIndex="126">
                        <PropertiesComboBox DataSourceID="sdsC952CUSTSECT2" TextField="VDESC" ValueField="OPTVALUE">
                        </PropertiesComboBox>
                        <Settings AllowAutoFilter="False" AllowHeaderFilter="True" />
                        <SettingsHeaderFilter Mode="CheckedList">
                        </SettingsHeaderFilter>
                    </dx:GridViewDataComboBoxColumn>
                <dx:GridViewDataTextColumn FieldName="C123AMPS" Visible="False" VisibleIndex="127">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="C124AMPSGEN" Visible="False" VisibleIndex="128">
                </dx:GridViewDataTextColumn>
                </Columns>
                <Toolbars>
                    <dx:GridViewToolbar ItemAlign="Right">
                        <Items>
                            <dx:GridViewToolbarItem BeginGroup="True" Command="ShowCustomizationDialog" ToolTip="Customize">
                            </dx:GridViewToolbarItem>
                            <dx:GridViewToolbarItem Name="ResetLayout" Text="Reset Layout" Visible="False" >
                            </dx:GridViewToolbarItem>
                            <dx:GridViewToolbarItem Name="Price" Text="Update Price" BeginGroup="True">
                                <Image IconID="businessobjects_bo_price_svg_16x16" ToolTip="Update Price">
                                </Image>
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
                                    <dx:GridViewToolbarItem Name="ExportToCSV" Text="CSV">
                                        <Image IconID="export_exporttocsv_16x16office2013">
                                        </Image>
                                    </dx:GridViewToolbarItem>
                                </Items>

<Image IconID="actions_download_16x16office2013"></Image>
                            </dx:GridViewToolbarItem>
                            <dx:GridViewToolbarItem Name="Print" Text="Print">
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
                <Styles>
                    <Header Wrap="True">
                    </Header>
                </Styles>
            </dx:ASPxGridView>
            <asp:SqlDataSource ID="sdsCATEGORIES" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT * FROM [vCATEGORIES]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="sdsRESVSLP" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT [RESVSLP], [RESVSLPNAME] FROM [vRESVSLP]"></asp:SqlDataSource>
    &nbsp;<dx:ASPxGridViewExporter runat="server" ExportedRowType="All" ID="Exporter"></dx:ASPxGridViewExporter>

                <asp:SqlDataSource ID="sds640CARRIERS" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT * FROM [vCSOPTFD] WHERE ([OPTFIELD] = @OPTFIELD) ORDER BY [SORTEDVAL]">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="640CARRIER" Name="OPTFIELD" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="sds640CARRIERS2" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT * FROM [vCSOPTFD] WHERE ([OPTFIELD] = @OPTFIELD) ORDER BY [SORTEDVAL]">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="640CARRIER2" Name="OPTFIELD" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="sds640CARRIERS3" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT * FROM [vCSOPTFD] WHERE ([OPTFIELD] = @OPTFIELD) ORDER BY [SORTEDVAL]">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="640CARRIER3" Name="OPTFIELD" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="sds650PORTORIGS" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT * FROM [vCSOPTFD] WHERE ([OPTFIELD] = @OPTFIELD) ORDER BY [SORTEDVAL]">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="650PORTORIG" Name="OPTFIELD" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="sds720PORTLOADS" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT * FROM [vCSOPTFD] WHERE ([OPTFIELD] = @OPTFIELD) ORDER BY [SORTEDVAL]">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="720PORTLOAD" Name="OPTFIELD" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="sds740OCEANCARRS" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT * FROM [vCSOPTFD] WHERE ([OPTFIELD] = @OPTFIELD) ORDER BY [SORTEDVAL]">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="740OCEANCARR" Name="OPTFIELD" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="sds760PORTDESTS" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT * FROM [vCSOPTFD] WHERE ([OPTFIELD] = @OPTFIELD) ORDER BY [SORTEDVAL]">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="760PORTDEST" Name="OPTFIELD" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>

                <asp:SqlDataSource ID="sds951CUSTSECT1" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT * FROM [vCSOPTFD] WHERE ([OPTFIELD] = @OPTFIELD) ORDER BY [SORTEDVAL]">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="951CUSTSECT1" Name="OPTFIELD" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>

               <asp:SqlDataSource ID="sdsC952CUSTSECT2" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT * FROM [vCSOPTFD] WHERE ([OPTFIELD] = @OPTFIELD) ORDER BY [SORTEDVAL]">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="952CUSTSECT2" Name="OPTFIELD" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>

            <asp:SqlDataSource ID="sdsACCTSETS" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT * FROM vACCTSETS"></asp:SqlDataSource>

            <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="IC_Inquiry.CRMXEntities" EntityTypeName="" TableName="vSNs">
            </asp:LinqDataSource>

            <asp:SqlDataSource ID="sdsItems" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT * FROM [vSN]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="sdsARSAP" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT * FROM [vARSAP]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="sdsSN" runat="server" ConnectionString="<%$ ConnectionStrings:CRMXConnectionString %>" SelectCommand="SELECT ITEMNO, SERIALNUM, ITEMNUM, SERIALNUMF, [880USDDATE] AS C880USDDATE, [880USD002] AS C880USD002, [880USD005] AS C880USD005, [880USD010] AS C880USD010, [880USD020] AS C880USD020, [880USD030] AS C880USD030, [880USD040] AS C880USD040, [880USD050] AS C880USD050, [880USD060] AS C880USD060, [880USD070] AS C880USD070 FROM vSN WHERE (ITEMNO = @ITEMNO) AND (SERIALNUM = @SERIALNUM)">
                <SelectParameters>
                    <asp:SessionParameter Name="ITEMNO" SessionField="itemno" />
                    <asp:SessionParameter Name="SERIALNUM" SessionField="sn" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
</asp:Content>
