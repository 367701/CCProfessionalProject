﻿<%@ Page Title="Team" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Team.aspx.cs" Inherits="ProfessionalProject.Team" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="header-quarter"></div>
    <div class="container body-content">
        <div class="row">
            <div class="col-md-3">

            </div>
            <div class="col-md-6">
                <div class="team-nav">
                    <ul>
                        <li><a href="#" class="active"><img src="Images/logo.png" /><br />Full Team</a></li>
                        <li><a href="#"><img src="Images/overwatch.png" /><br />Overwatch</a></li>
                        <li><a href="#"><img src="Images/rocket-league.png" /><br />Rocket League</a></li>
                        <li><a href="#"><img src="Images/lol.png" /><br />League Of Legends</a></li>
                    </ul>
                </div>
            </div>
            <div class="col-md-3">

            </div>
        </div>
        <div class="row">
            <div class="col-md-2">

            </div>
            <div class="col-md-8">
                <div class="event-box">
                    <p class="event-header">Test</p>
                    <p class="event-date"><span>Date: </span>03/04/2020 15:00 - 16:30</p>
                    <p class="event-description"><span>Description: </span>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean ullamcorper libero sit amet posuere fermentum. Vestibulum vel mauris erat. Proin pretium nec leo faucibus porttitor. Proin ut varius orci, et.</p>
                </div>
                <div class="event-box">
                    <p class="event-header">Test</p>
                    <p class="event-date"><span>Date: </span>03/04/2020 15:00 - 16:30</p>
                    <p class="event-description"><span>Description: </span>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean ullamcorper libero sit amet posuere fermentum. Vestibulum vel mauris erat. Proin pretium nec leo faucibus porttitor. Proin ut varius orci, et.</p>
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