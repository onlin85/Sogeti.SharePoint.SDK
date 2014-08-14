﻿<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ManageManufacturers.ascx.cs" Inherits="DataModels.SharePointList.PartsMgmnt.ControlTemplates.ManageManufacturers" %>

<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<table width="100%">
    <tr>
        <td valign="top"  style="width:200px">
            <table width="100%">
    <tr>
        <td colspan="2">
            <asp:label runat="server" id="SearchLabel" text="Search By Manufacturer Name"></asp:label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:textbox id="ManufacturerSearchTextBox" runat="server"></asp:textbox>
        </td>
        <td>
            <asp:button id="GoButton" runat="server" text="Go" />
        </td>
    </tr>
          <tr>
            <td colspan="2" align="right">
                <asp:hyperlink runat="server" id="AddNewHyperlink">Add New Manufacturer</asp:hyperlink>
            </td>
        </tr>
</table>
        </td>
        <td valign="top">
            <asp:updatepanel runat="server" id="ManufacturerResultUpdatePanel" childrenastriggers="false"
    updatemode="Conditional">
    <contenttemplate>
        <asp:gridview runat="server" ID="ManufacturerResultsGridView" 
            AutoGenerateColumns="False" EnableModelValidation="True" 
            DataKeyNames="ManufacturerId">
            <Columns>
            <asp:BoundField DataField="ManufacturerId" Visible="False"></asp:BoundField>
                <asp:TemplateField HeaderText="Manufacturer Name">
                    <ItemTemplate>
                        <asp:HyperLink ID="ManufacturerNameHyperLink" runat="server" NavigateUrl="" 
                            Text='<%# Eval("ManufacturerName") %>'></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:ButtonField CommandName="Select" HeaderText="Machines" Text="Machines">
                </asp:ButtonField>
            </Columns>
             <HeaderStyle Wrap="False" />
            <RowStyle Wrap="False" />
        </asp:gridview>
    </contenttemplate>
</asp:updatepanel>
        </td>
    </tr>
    <tr>
    <td></td>
        <td valign="top">
           <asp:updatepanel runat="server" id="MachineResultsUpdatePanel" childrenastriggers="false"
    updatemode="Conditional">
 <contenttemplate>
 <table>
 <tr>
    <td>            
        <asp:gridview runat="server" id="MachineResultsGridView" 
    AutoGenerateColumns="False" DataKeyNames="Id"
    EnableModelValidation="True" >
    <Columns>
        <asp:BoundField DataField="Id" Visible="False"></asp:BoundField>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:HyperLink ID="MachineNameHyperLink" runat="server" NavigateUrl="" Text="Edit/Delete"></asp:HyperLink>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="MachineName" HeaderText="Machine Name"></asp:BoundField>
        <asp:BoundField DataField="Manufacturer" HeaderText="Manufacturer"></asp:BoundField>
        <asp:BoundField DataField="Model" HeaderText="Model No"></asp:BoundField>
      
    </Columns>
            <HeaderStyle Wrap="False" />
            <RowStyle Wrap="False" />
</asp:gridview></td></tr></table>
 
            </contenttemplate>
            </asp:updatepanel>
            </td>       
    </tr>
</table>