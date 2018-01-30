<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FindGame.aspx.cs" Inherits="Clnt.FindGame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/main.css" rel="stylesheet" />
    </head>
<body>
<div id="container">
    <div id="header_logo">
        	<h1>Baza gier</h1>
        </div>
        <div id="header_menu">
        	<ul>
            	<li><a href="Default.aspx">Strona główna</a></li>
                <li><a href="Producer.aspx">Producent</a></li>
                <li><a href="Genre.aspx">Gatunek</a></li>
            </ul>
        </div>
    <div id="boxy">
        <form id="form1" runat="server">
        <h2>
            <asp:Label ID="lbTytul" runat="server" Height="50px" Width="100%">Wyszukiwanie:</asp:Label>                 
        </h2> 
            <div class="frm">
                <div class="element1">
                    Tytuł:<br />
            <asp:TextBox ID="tbTytul" runat="server" Width="213px"></asp:TextBox>
            <br />
            <br />
            Producent:<br />
            <asp:DropDownList ID="ddlProducent" runat="server" Height="16px" Width="219px">
            </asp:DropDownList>
            <br /><br />
            Gatunek:<br />
            <asp:DropDownList ID="ddlGatunek" runat="server" Height="16px" Width="219px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btnSzukaj" CssClass="btn" runat="server" OnClick="btnSzukaj_Click" Text="Szukaj" />
                </div>
            </div>            
    </form>
    
    </div>
    <div id="footer">
    © 2018 Baza Gier
    </div>
    
    </div>
</body>
</html>