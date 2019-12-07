<%@ Page Title="" Language="C#" MasterPageFile="~/Pages.Master" AutoEventWireup="true" CodeBehind="Show_Page.aspx.cs" Inherits="Pages_Database.Show_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div class="show_page">
        <a class="back" href="Your_Designs.aspx">Back</a>
            <asp:Button  OnClientClick="if(!confirm('Are you sure you want to delete this?')) return false;" OnClick="Delete_Page" Text="Delete" runat="server"  />
            <a class="show_edit" href="Update_Page.aspx?pageid=<%= Request.QueryString["pageid"] %>">Edit</a>
    </div>
    <div id="page_show" runat="server">
        <h2>Details for <span id="show_page_title" runat="server"></span></h2>
        <!--Business Name: <span id="page_businessname" runat="server"></span><br />-->
        <span class="show_titles">Tagline:</span> <span id="page_tagline" runat="server"></span><br />
        Title:<span id="page_title" runat="server"></span><br />
        Subtitle:<span id="page_subtitle" runat="server"></span><br />
        Description: <span id="page_description" runat="server"></span>
    </div>
</asp:Content>
