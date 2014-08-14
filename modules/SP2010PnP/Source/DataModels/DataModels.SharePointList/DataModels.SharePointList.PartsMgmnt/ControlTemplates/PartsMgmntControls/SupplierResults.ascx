﻿<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SupplierResults.ascx.cs" Inherits="DataModels.SharePointList.PartsMgmnt.PartsMgmntControls.SupplierResults" %>
<asp:updatepanel runat="server" id="SupplierResultUpdatePanel" childrenastriggers="false"
    updatemode="Conditional">
    <contenttemplate>
        <asp:gridview runat="server" ID="SupplierResultsGridView" 
            AutoGenerateColumns="False" EnableModelValidation="True" 
            DataKeyNames="Id">
            <Columns>
            <asp:BoundField DataField="Id" Visible="False"></asp:BoundField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HyperLink ID="SupplierNameHyperLink" runat="server" NavigateUrl="" 
                            Text='Edit / Delete'></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField ShowHeader="False">
            <ItemTemplate>
                <asp:LinkButton ID="SelectLinkButton" runat="server" CausesValidation="false" 
                    CommandName="Select" Text="Add Supplier"></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
                <asp:BoundField DataField="SupplierName" HeaderText="Supplier Name"></asp:BoundField>
                <asp:BoundField DataField="DUNS" HeaderText="DUNS">
                </asp:BoundField>
                <asp:ButtonField CommandName="ViewParts" HeaderText="Parts" Text="Parts">
                </asp:ButtonField>
            </Columns>
            <HeaderStyle Wrap="False" />
            <RowStyle Wrap="False" />
        </asp:gridview>
    </contenttemplate>
</asp:updatepanel>