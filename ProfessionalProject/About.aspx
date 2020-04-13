<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ProfessionalProject.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="header-quarter"></div>
    <div class="container body-content">
        <h2>About Us</h2>
        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non nulla eu dui blandit aliquam vitae ullamcorper elit. Sed at turpis eget lorem faucibus fringilla eu nec arcu. Vestibulum dignissim fermentum felis, pharetra pretium ipsum accumsan ut. Cras posuere malesuada quam a suscipit. Sed rutrum tristique risus quis lobortis. Vivamus dolor mauris, auctor in feugiat vitae, tristique sed nulla. Phasellus volutpat dapibus diam, nec auctor nisi rutrum quis.</p>
        <p>Vivamus risus odio, feugiat id posuere ac, molestie pulvinar leo. Mauris pulvinar dignissim tempor. Sed sit amet turpis ac risus finibus dictum. Quisque et turpis et tellus porttitor cursus at in arcu. Fusce metus nulla, iaculis eu erat a, tincidunt viverra orci. Aenean dapibus tortor nec mi finibus, id mollis lectus elementum. Quisque nec ipsum sollicitudin, efficitur lorem sed, interdum est. Proin a iaculis risus, vel lacinia erat. In hac habitasse platea dictumst. Integer venenatis eros eget ante tristique, non condimentum urna dictum. Maecenas nec maximus nunc, sed eleifend est. Nam nec ornare dolor. Sed nec blandit ligula. Morbi rhoncus massa ipsum, vitae molestie augue porta ut.</p>
        <hr />
        <footer>
            <p style="color: white;">&copy; <%: DateTime.Now.Year %> - My ASP.NET Application</p>
        </footer>
    </div>
</asp:Content>
