<%@ Page Title="" Language="C#" MasterPageFile="~/Pages.Master" AutoEventWireup="true" CodeBehind="New_Page.aspx.cs" Inherits="Pages_Database.New_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <!--This page is used to add a new page into the database-->
    <div class="new_page_container">
        <div>
            <h2 class="create_page">Create Page</h2>
        </div>
        <div>
            <label>Business Name</label>
            <asp:TextBox runat="server" ID="business_name" CssClass="new_businessname"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="business_name" ErrorMessage="Please enter your business name"></asp:RequiredFieldValidator>
            <!--Required field validators are used to control validate on user input whether they are entering the details or not-->
        </div>
        <div>
            <label>Tag line</label>
            <asp:TextBox runat="server" ID="tag_line" CssClass="new_tagline"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="tag_line" ErrorMessage="Please enter the tagline"></asp:RequiredFieldValidator>
        </div>
        <div>
            <label>Title</label>
            <asp:TextBox runat="server" ID="page_title" CssClass="new_title"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="page_title" ErrorMessage="Please enter your page title"></asp:RequiredFieldValidator>
        </div>
        <div>
            <label>Subtitle</label>
            <asp:TextBox runat="server" ID="page_subtitle" CssClass="new_subtitle"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="page_subtitle" ErrorMessage="Please enter subtitle of your page"></asp:RequiredFieldValidator>
        </div>
        <div>
            <label>Description</label>
            <asp:TextBox runat="server" ID="page_description" TextMode="MultiLine" CssClass="new_description"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="page_description" ErrorMessage="Please enter description of your blog"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Button ID="publish_page" runat="server" Text="Publish" OnClick="Add_Page" />
            <!--onclick event is triggered and it will call Add_Page function-->
        </div>
    </div>
</asp:Content>
