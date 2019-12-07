<%@ Page Title="" Language="C#" MasterPageFile="~/Pages.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Pages_Database.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div id="home_content">
        <img src="page_hanging.jpg" alt="background image of home page" class="image_home"/>
        <div>
            <p class="design_text">Design & Innovate</p>
             <div class="search_bar">
                <asp:label for="search_page" runat="server">Search:</asp:label>
               <asp:TextBox ID="search_page" runat="server"></asp:TextBox>
               <asp:Button Text="Go" runat="server"/>
                <div id="sql_debugger" runat="server" class="debugger_text"></div>
            </div>
        </div>
    </div>
    <div class="listview"> 
        <div class="homelistitem" id="home_listitem" runat="server">
            <div class="col6first">BUSINESS NAME</div>
            <div class="col6">TAGLINE</div>
            <div class="col6">TITLE</div>
            <div class="col6">SUBTITLE</div>
            <div class="col6">DESCRIPTION</div>
            <div class="col6last">ACTION</div>
        </div>
        <div id="pages_home_result" runat="server">

        </div>
    </div>
</asp:Content>