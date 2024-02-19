<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyLibrary.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">ASP.NET</h1>
            <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
            <p><a href="http://www.asp.net" class="btn btn-primary btn-md">Learn more &raquo;</a></p>
        </section>
        
        <h2>My simple custom section</h2>
        <p>
            Param 1 :
            <asp:Label runat="server" ID="lblMyCustomSectionParam1"></asp:Label>
        </p>
        
        <p>
            Param 2 :
            <asp:Label runat="server" ID="lblMyCustomSectionParam2"></asp:Label>
        </p>
        
        <h2>My partner custom section</h2>
        <p>_Name
            Partner 1 :_Name
            <asp:Label runat="server" ID="lblMyPartnerSectionPartner1_Name"></asp:Label>
            <asp:Label runat="server" ID="lblMyPartnerSectionPartner1_Param1"></asp:Label>
            <asp:Label runat="server" ID="lblMyPartnerSectionPartner1_Param2"></asp:Label>
        </p>
        
        <p>
            Param 2 :
            <asp:Label runat="server" ID="lblMyPartnerSectionPartner2_Name"></asp:Label>
            <asp:Label runat="server" ID="lblMyPartnerSectionPartner2_ClientId"></asp:Label>
            <asp:Label runat="server" ID="lblMyPartnerSectionPartner2_ClientSecret"></asp:Label>
            <asp:Label runat="server" ID="lblMyPartnerSectionPartner2_Param1"></asp:Label>
        </p>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Getting started</h2>
                <p>
                    ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
                A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle">Get more libraries</h2>
                <p>
                    NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle">Web Hosting</h2>
                <p>
                    You can easily find a web hosting company that offers the right mix of features and price for your applications.
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
                </p>
            </section>
        </div>
    </main>

</asp:Content>
