<%@ Page Title="Apply" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Apply.aspx.cs" Inherits="ProfessionalProject.Apply" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="header-quarter"></div>
    <div class="container body-content">
        <div class="row">
        <div class="col-md-2">

        </div>
        <div class="col-md-8">
            <div class="login-form">
                    <div class="box">
                        <div class="avatar"></div>
                        <h2 class="text-center">Apply to become a member</h2>
                        <div class="col-md-6 form-column">
                            <div class="form-group form-item">
                                <input class="form-control" runat="server" id="Fullname" placeholder="Full Name" type="text" data-val="true" data-val-required="The Username field is required." value="" />
                            </div>
                        </div>
                        <div class="col-md-6 form-column">
                            <div class="form-group form-item">
                                <input class="form-control" runat="server" id="Email" placeholder="College Email Address" type="text" data-val="true" data-val-required="The Username field is required." value="" />
                            </div>
                        </div>
                        <div class="col-md-12 form-column">
                            <div class="form-group form-item">
                                <textarea runat="server" id="About" placeholder="Tell us about yourself (optional)" class="form-control" type="text" data-val="true" data-val-required="The Password field is required."></textarea>
                            </div>
                        </div>
                        <div class="form-group">
                            <button runat="server" onserverclick="Submit_ServerClick" type="submit" class="btn btn-primary btn-lg btn-block">Apply</button>
                        </div>
                        <!--
                        <div style="text-align: center;">
                            <a href="Register.aspx" class="signup-link">Don't have an account? Sign up now.</a>
                        </div>-->
                        <p class="success" runat="server" id="Message"></p>
                        <div class="text-danger validation-summary-valid" data-valmsg-summary="true">
                            <ul><li style="display:none"></li></ul>
                        </div>
                    </div>
                 </div>
        </div>
        <div class="col-md-2">

        </div>
        </div>
    </div>
</asp:Content>
