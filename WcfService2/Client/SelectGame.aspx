<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SelectGame.aspx.cs" Inherits="Client.SelectGame" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <h2>
            <p>&nbsp;&nbsp;<asp:Label ID="lbTytul" runat="server" Height="50px" Width="100%"></asp:Label>  </p>                   
        </h2>   
    <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Justify"  Direction="LeftToRight" Width="100%">
        <asp:Literal ID="lOpis" runat="server"></asp:Literal>
        </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" HorizontalAlign="center" Width="100%">
        <br />
        <br />
        <img id="link" runat="server" />
    </asp:Panel>
    <p<asp:Label ID="lbOc" runat="server"><b>Ocena:</b></asp:Label><br />
          <asp:Label ID="lblGr" runat="server">wg serwisu gry-online: </asp:Label> <asp:Label ID="lbGry" runat="server"></asp:Label><br /> <asp:Label ID="lblEu" runat="server">wg serwisu eurogamer: </asp:Label> <asp:Label ID="lbEuro" runat="server"></asp:Label><br /> </p> </asp:Content>
