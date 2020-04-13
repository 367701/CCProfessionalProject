<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProfessionalProject.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="header-quarter"></div>
    <div class="container body-content"> 
        <div class="row">
        
            <div class="col-md-4">
            
            </div>
            <div class="col-md-4" >
                <div class="login-form">
                    <div class="box">
                        <div class="avatar"></div>
                        <h2 class="text-center">Sign In</h2>
                        <div class="form-group">
                            <input class="form-control" placeholder="Email / Username" type="text" data-val="true" data-val-required="The Username field is required." runat="server" id="loginData_Username" name="loginData.Username" value="" />
                        </div>
                        <div class="form-group">
                            <input placeholder="Password" class="form-control" type="password" data-val="true" data-val-required="The Password field is required." runat="server" id="loginData_Password" name="loginData.Password" />
                        </div>
                        <div class="form-group">
                            <div class="checkbox">
                                <label><input type="checkbox" runat="server" data-val="true" id="loginData_RememberMe" name="loginData.RememberMe" value="false"> Remember me</label>
                            </div>
                        </div>
                        <div class="form-group">
                            <button type="submit" runat="server" onserverclick="Login_ServerClick" class="btn btn-primary btn-lg btn-block">Sign In</button>
                        </div>
                        <!--
                        <div style="text-align: center;">
                            <a href="Register.aspx" class="signup-link">Don't have an account? Sign up now.</a>
                        </div>-->
                        <div class="text-danger validation-summary-valid" data-valmsg-summary="true">
                            <ul><li runat="server" id="Message"></li></ul>
                        </div>
                    </div>
                 </div>
            </div>
            <div class="col-md-4">
            
            </div>
        </div>
    </div>
</asp:Content>
