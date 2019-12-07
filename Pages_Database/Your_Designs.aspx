<%@ Page Title="" Language="C#" MasterPageFile="~/Pages.Master" AutoEventWireup="true" CodeBehind="Your_Designs.aspx.cs" Inherits="Pages_Database.Your_Designs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <h2>All Your Designs</h2>
    <div>
        <asp:Label for="page_search" runat="server">Search:</asp:Label>
        <asp:TextBox ID="page_search" runat="server"></asp:TextBox>
        <asp:Button runat="server" Text="Go"/>
        <div id="sql_debugger_design" runat="server"></div>
    </div>
    <div>
        <div class="listitem">
            <div class="col6first">BUSINESS NAME</div>
            <div class="col6">TAGLINE</div>
            <div class="col6">TITLE</div>
            <div class="col6">SUBTITLE</div>
            <div class="col6">DESCRIPTION</div>
            <div class="col6last">ACTION</div>
        </div>
        <div id="pages_result" runat="server">

        </div>
    </div>
</asp:Content>
