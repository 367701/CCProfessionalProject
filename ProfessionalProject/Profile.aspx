<%@ Page Title="Profile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="ProfessionalProject.Profile" %>

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
                        <h2 class="text-center">Profile</h2>
                        <div class="form-group">
                            <p>Name:</p>
                            <asp:TextBox AutoPostBack="true" CssClass="form-control" type="text" runat="server" id="Fullname" name="Fullname" value=""></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <p>IGN:</p>
                            <asp:TextBox AutoPostBack="true" CssClass="form-control" type="text" runat="server" id="IGN"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <p>Game:</p>
                            <asp:DropDownList AutoPostBack="true" CssClass="form-control" runat="server" ID="Game">
                                <asp:ListItem>Overwatch</asp:ListItem>
                                <asp:ListItem>Rocket League</asp:ListItem>
                                <asp:ListItem>League Of Legends</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <p>Biography:</p>
                            <asp:TextBox AutoPostBack="true" CssClass="form-control" type="text" runat="server" id="Biography" name="Biography" Rows="3"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <button type="submit" runat="server" onserverclick="Update_ServerClick" class="btn btn-primary btn-lg btn-block">Update Profile</button>
                        </div>
                        <!--
                        <div style="text-align: center;">
                            <a href="Register.aspx" class="signup-link">Don't have an account? Sign up now.</a>
                        </div>-->
                        <div class="text-danger validation-summary-valid" data-valmsg-summary="true">
                            <ul><li runat="server" style="color: green" id="Message"></li></ul>
                        </div>
                    </div>
                 </div>
            </div>
            <div class="col-md-4">
            
            </div>
        </div>
    </div>
</asp:Content>
