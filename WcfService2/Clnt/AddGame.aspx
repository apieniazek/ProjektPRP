<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddGame.aspx.cs" Inherits="Clnt.AddGame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/main.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            float: left;
            width: 37%;
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
            <asp:Label ID="lbTytul" runat="server" Height="50px" Width="100%">Dodaj grę: </asp:Label>                  
        </h2> 
            <div class="frm">
                <div class="auto-style1">
                     Tytuł:&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:RequiredFieldValidator ID="rfvTytul" runat="server" ControlToValidate="tbTytul" EnableClientScript="False" ErrorMessage="Tytul wymagany" ForeColor="Red" ValidationGroup="addvalidation"></asp:RequiredFieldValidator>
                     <br /><asp:TextBox  ID="tbTytul" runat="server" Height="25px" Width="200px"></asp:TextBox><br />
                     <br />
                     Rok wydania:&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbRokWyd" EnableClientScript="False" ErrorMessage="Rok wymagany" ForeColor="Red" ValidationGroup="addvalidation"></asp:RequiredFieldValidator>
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br /><asp:TextBox ID="tbRokWyd" runat="server" Height="25px" Width="200px"></asp:TextBox>
                    
                     <br /><br />
                    Link do okładki:<br /><asp:TextBox ID="tbOkladka" runat="server"  Height="25px" Width="494px" MaxLength="200"></asp:TextBox><br /><br />
                    Opis:<br /><asp:TextBox ID="tbOpis" runat="server"  Height="100px" Width="800px" MaxLength="1200" TextMode="MultiLine"></asp:TextBox><br /><br />
                    Ocena wg Gry-Online: &nbsp; &nbsp;<asp:DropDownList ID="ddlOcenaGryOnline" runat="server">
                        <asp:ListItem Value="1" Text="1" />
                        <asp:ListItem Value="2" Text="2" />
                        <asp:ListItem Value="3" Text="3" />
                        <asp:ListItem Value="4" Text="4" />
                        <asp:ListItem Value="5" Text="5" />
                        <asp:ListItem Value="6" Text="6" />
                        <asp:ListItem Value="7" Text="7" />
                        <asp:ListItem Value="8" Text="8" />
                        <asp:ListItem Value="9" Text="9" />
                        <asp:ListItem Value="10" Text="10" />
                    </asp:DropDownList><br /><br />
                    Ocena wg Eurogamer.pl: &nbsp; &nbsp;<asp:DropDownList ID="ddlEurogamer" runat="server">
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3">3</asp:ListItem>
                        <asp:ListItem Value="4">4</asp:ListItem>
                        <asp:ListItem Value="5">5</asp:ListItem>
                        <asp:ListItem Value="6">6</asp:ListItem>
                        <asp:ListItem Value="7">7</asp:ListItem>
                        <asp:ListItem Value="8">8</asp:ListItem>
                        <asp:ListItem Value="9">9</asp:ListItem>
                        <asp:ListItem Value="10">10</asp:ListItem>
                    </asp:DropDownList><br /><br />
                    Moja ocena: &nbsp; &nbsp; <asp:DropDownList ID="ddlMojaOcena" runat="server">
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3">3</asp:ListItem>
                        <asp:ListItem Value="4">4</asp:ListItem>
                        <asp:ListItem Value="5">5</asp:ListItem>
                        <asp:ListItem Value="6">6</asp:ListItem>
                        <asp:ListItem Value="7">7</asp:ListItem>
                        <asp:ListItem Value="8">8</asp:ListItem>
                        <asp:ListItem Value="9">9</asp:ListItem>
                        <asp:ListItem Value="10">10</asp:ListItem>
                    </asp:DropDownList> <br /><br />
                    <asp:Button ID="btnZapisz" cssclass="btn" runat="server" Text="Zapisz" OnClick="btnZapisz_Click" CommandName="submit" ValidationGroup="addvalidation" /> 
                    <asp:Button ID="btnAnuluj" class="btn"  runat="server" Text="Anuluj" OnClick="btnAnuluj_Click" />
                </div>
                <div class="element2">
                    Producent:<br /><asp:DropDownList ID="ddlProducent" runat="server" Height="25px" Width="200px">
                    </asp:DropDownList><br /><br />
                     Kraj:&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvKraj" runat="server" ControlToValidate="tbKraj" EnableClientScript="False" ErrorMessage="Kraj wymagany" ForeColor="Red" ValidationGroup="addvalidation"></asp:RequiredFieldValidator>
                    <br /><asp:TextBox ID="tbKraj" runat="server"  Height="25px" Width="200px"></asp:TextBox>
                     
                </div>
                <div class="element3">
                     Gatunek:<br /><asp:DropDownList ID="ddlGatunek" runat="server" Height="25px" Width="200px">
                    </asp:DropDownList><br /><br />
                    Platforma:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:CheckBoxList ID="cblPlatforma" runat="server">
                    <asp:ListItem Value="1">PC</asp:ListItem>
                    <asp:ListItem Value="2">PS4</asp:ListItem>
                    <asp:ListItem Value="4">XBOX</asp:ListItem>
                    </asp:CheckBoxList>
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

