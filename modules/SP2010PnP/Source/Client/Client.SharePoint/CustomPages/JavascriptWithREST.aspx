﻿<%@ Page language="C#" MasterPageFile="~masterurl/default.master"    Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=14.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c"  %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>


<asp:Content ContentPlaceHolderId="PlaceHolderPageTitle" runat="server">
	<SharePoint:FieldValue id="PageTitle" FieldName="Title" runat="server"/>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderPageImage" runat="server"><img src="/_layouts/images/blank.gif" width='1' height='1' alt="" /></asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderPageTitleInTitleArea" runat="server">
		<SharePoint:FieldValue id="PageTitle2" FieldName="Title" runat="server"/>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderTitleAreaClass" runat="server">
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderAdditionalPageHead" runat="server">
	<meta name="CollaborationServer" content="SharePoint Team Web Site" />
<style type="text/css">
.s4-nothome {
	display:none;
}
</style>

</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderSearchArea" runat="server">
	<SharePoint:DelegateControl runat="server"
		ControlId="SmallSearchInputBox" />
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderLeftActions" runat="server">
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderPageDescription" runat="server"/>
<asp:Content ContentPlaceHolderId="PlaceHolderBodyAreaClass" runat="server">
<style type="text/css">
.ms-bodyareaframe {
	padding: 0px;
}
</style>
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderMain" runat="server">
<script type="text/javascript" src="http://ajax.microsoft.com/ajax/jquery/jquery-1.4.2.min.js"></script>
<script type="text/javascript" src="../Lists/CustomScripts/RestScripts.js"></script>
<script type="text/javascript" src="../Lists/CustomScripts/clientCommon.js"></script>
	<table cellspacing="0" border="0" width="100%">
	  <tr>
	   <td class="ms-webpartpagedescription"><SharePoint:ProjectProperty Property="Description" runat="server"/></td>
	  </tr>
	  <tr>
        <td style="width:100%">
         <table width="100%" cellpadding="0" cellspacing="0" style="padding: 5px 10px 10px 10px;">
		  <tr>
		   <td valign="top" width="100%">
			   <WebPartPages:WebPartZone runat="server" FrameType="TitleBarOnly" ID="Main" Title="loc:Left" />
			   &#160;
		    </td>
           </tr>
		 </table>
         <table>
            <tr>
                <td><input id="skuTextBox" type="text" /></td>
                <td style="text-align:left"><input id="Button1" type="button" value="Find Parts" /></td>
            </tr>
            <tr><td colspan="2"><div id="ContentDiv"></div></td></tr>
            <tr><td colspan="2"><div id="divSuppliers"><div id="divSupplierResults"></div></div></td></tr>
            <tr>
                <td colspan="2"><div id="divLocations"><div id="divPartLocations"></div><div id="divLocationAdd" style="display:none"><input id="hidLocationId" type="hidden" /><input id="hidPartId" type="hidden" />
                <table>
                    <tr>
                        <td>Bin #</td>
                        <td><input id="binText" type="text" /></td>
                    </tr>
                    <tr>
                        <td>Quantity</td>
                        <td><input id="quantityText" type="text" /></td>
                    </tr>
                    <tr>
                        <td><input id="buttonSave" type="button" value="Save" /></td>
                    </tr>
                </table></div>
                <input id="buttonNew" type="button" value="New Location" style="display:none" /></div></td></tr>
         </table>
        </td>
	  </tr>
	</table>
</asp:Content>