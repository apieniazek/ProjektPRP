<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Producer.aspx.cs" Inherits="Clnt.Producer" %>

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
         <p>
            <asp:GridView ID="gvProducent" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AutoGenerateColumns="False">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Id_producent" HeaderText="Id_producent" Visible="False" />
                    <asp:BoundField DataField="nazwa" HeaderText="Nazwa" >
                    <ControlStyle Width="300px" />
                    <HeaderStyle Width="300px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Zalozyciel" HeaderText="Założyciel">
                    <HeaderStyle Width="150px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Rok_zalozenia" DataFormatString="{0:yyyy-MM-dd}" HeaderText="Rok założenia">
                    <HeaderStyle Width="150px" />
                    </asp:BoundField>
                    <asp:HyperLinkField DataNavigateUrlFields="Id_producent" DataNavigateUrlFormatString="~/EditProducer.aspx?id={0}" Text="Edytuj">
                    <ControlStyle ForeColor="#003300" Width="50px" />
                    <ItemStyle ForeColor="#003300" />
                    </asp:HyperLinkField>
                    <asp:HyperLinkField Text="Usuń" DataNavigateUrlFields="Id_producent" DataNavigateUrlFormatString="~/RmvProducer.aspx?id={0}" >
                    <ControlStyle ForeColor="Red" Width="50px" />
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
            <asp:Button ID="btnDodaj" CssClass="btn" runat="server" Text="Dodaj producenta" OnClick="btnDodaj_Click" />    
    </form>
    
    </div>
    <div id="footer">
    © 2018 Baza Gier
    </div>
    
    </div>
</body>
</html>
