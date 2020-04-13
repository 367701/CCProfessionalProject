<%@ Page Title="Highlights" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Highlights.aspx.cs" Inherits="ProfessionalProject.Highlights" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="header-quarter"></div>
    <div class="container body-content">
        <div class="row" style="margin-top: 20px;">
        <div class="col-md-2">

        </div>
        <div class="col-md-8">
             <div class="gallery_product col-lg-4 col-md-4 col-sm-4 col-xs-6">
                <img src="http://fakeimg.pl/365x365/" class="img-responsive">
                 <div class="highlight-body">

                 </div>
            </div>

            <div class="gallery_product col-lg-4 col-md-4 col-sm-4 col-xs-6">
                <img src="http://fakeimg.pl/365x365/" class="img-responsive">
            </div>

            <div class="gallery_product col-lg-4 col-md-4 col-sm-4 col-xs-6">
                <img src="http://fakeimg.pl/365x365/" class="img-responsive">
            </div>

            <div class="gallery_product col-lg-4 col-md-4 col-sm-4 col-xs-6">
                <img src="http://fakeimg.pl/365x365/" class="img-responsive">
            </div>

            <div class="gallery_product col-lg-4 col-md-4 col-sm-4 col-xs-6">
                <img src="http://fakeimg.pl/365x365/" class="img-responsive">
            </div>

            <div class="gallery_product col-lg-4 col-md-4 col-sm-4 col-xs-6">
                <img src="http://fakeimg.pl/365x365/" class="img-responsive">
            </div>
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
