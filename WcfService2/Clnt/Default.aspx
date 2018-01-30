<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Clnt.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/main.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 917px;
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
    <div id="header_main">
    <div id="header_main_image">
    	<div id="header_main_text">
            <p>
            Serwis poświęcony grom na platformy PC, PS4, XBOX.
            </p>
        </div>
        </div>
	</div>
    <div id="boxy">
        <form id="form1" runat="server" class="auto-style1">
            <p>
            <asp:GridView ID="gvGry" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AutoGenerateColumns="False" OnSelectedIndexChanged="gvGry_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" Visible="False" />
                    <asp:HyperLinkField DataTextField="tytul" HeaderText="Tytuł" DataNavigateUrlFields="id" DataNavigateUrlFormatString="~/SelectGame.aspx?id={0}" />
                    <asp:BoundField DataField="nazwa" HeaderText="Producent" />
                    <asp:BoundField DataField="nazwa_gatunku" HeaderText="Gatunek" />
                    <asp:BoundField DataField="rok_wydania" DataFormatString="{0:yyyy-MM-dd}" HeaderText="Rok wydania" />
                    <asp:BoundField DataField="kraj" HeaderText="Kraj" />
                    <asp:BoundField DataField="platformas" HeaderText="Platforma" />
                    <asp:BoundField DataField="Srednia_ocena" HeaderText="Średnia ocena" />
                    <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="~/EditGame.aspx?id={0}" Text="Edytuj">
                    <ControlStyle ForeColor="#003300" />
                    <ItemStyle ForeColor="#003300" />
                    </asp:HyperLinkField>
                    <asp:HyperLinkField Text="Usuń" DataNavigateUrlFields="id" DataNavigateUrlFormatString="~/RemoveGame.aspx?id={0}" >
                    <ControlStyle ForeColor="Red" />
                    </asp:HyperLinkField>
                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
        </p>
            <asp:Button ID="btnDodaj" CssClass="btn" runat="server" Text="Dodaj nową grę" OnClick="btnDodaj_Click" />

        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFind" CssClass="btn" runat="server" OnClick="btnFind_Click" Text="Filtruj" />
        </form>
    
    </div>
    <div id="footer">
    © 2018 Baza Gier
    </div>
    
    </div>
</body>
</html>
