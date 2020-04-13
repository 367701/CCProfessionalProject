<%@ Page Title="Highlights" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Highlights.aspx.cs" Inherits="ProfessionalProject.Highlights" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="header-quarter"></div>
    <div class="container body-content">
        <div class="row" style="margin-top: 20px;">
        <div class="col-md-2">

        </div>
        <div class="col-md-8 gallery_container">
             <%=content %>
        </div>
        <div class="col-md-2">

        </div>
        </div>
        <hr />
        <footer>
            <p style="color: white;">&copy; <%: DateTime.Now.Year %> - My ASP.NET Application</p>
        </footer>
    </div>
</asp:Content>
