<%@ Page Title="" Language="C#" MasterPageFile="~/Pages.Master" AutoEventWireup="true" CodeBehind="Update_Page.aspx.cs" Inherits="Pages_Database.Update_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div id="pages" runat="server">
        
        <h2>Updating Page <span id="page_title" runat="server"></span></h2>
        <div class="editrow">
            <label>Business Name</label>
            <asp:TextBox runat="server" ID="business_name" CssClass="update_business"></asp:TextBox>
        </div>
        <div class="editrow">
            <label>Tagline</label>
            <asp:TextBox runat="server" ID="tag_line" CssClass="update_tagline"></asp:TextBox>
        </div>
        <div class="editrow">
            <label>Title</label>
            <asp:TextBox runat="server" ID="title_page" CssClass="update_title"></asp:TextBox>
        </div>
        <div class="editrow">
            <label>Subtitle</label>
            <asp:TextBox runat="server" ID="subtitle_page" CssClass="update_subtitle"></asp:TextBox>
        </div>
        <div class="editrow">
            <label>Description</label>
            <asp:TextBox runat="server" ID="description_page" CssClass="update_description"></asp:TextBox>
        </div>
        <asp:Button Text="Update Page"  OnClick="UpdatePage" runat="server"/>
        <a class="cancel_button" href="Show_Page.aspx?pageid=<%= Request.QueryString["pageid"] %>">Cancel</a>
        
    </div>
</asp:Content>
