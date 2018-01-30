<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RmvGenre.aspx.cs" Inherits="Clnt.RmvGenre" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/main.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            float: left;
            width: 41%;
        }
    </style>
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
            <asp:Label ID="lbNazwa" runat="server" Height="50px" Width="100%"></asp:Label>                 
        </h2> 
             <div class="frm">
                <div class="auto-style1">
                    Jesteś pewien?<br />
        <asp:Button ID="btnUsun" CssClass="btn" runat="server" Text="Tak" OnClick="btnUsun_Click" /> &nbsp<asp:Button ID="btnAnuluj"  CssClass="btn" runat="server" Text="Nie" OnClick="btnAnuluj_Click"  />
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
