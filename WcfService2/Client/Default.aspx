<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Client._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Baza Gier</h1>
        <p class="lead">Serwis poświęcony grom na platformy PC, PS4, XBOX</p>
        <p>
            <asp:GridView ID="gvGry" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AutoGenerateColumns="False">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" Visible="False" />
                    <asp:HyperLinkField DataTextField="tytul" HeaderText="Tytuł" DataNavigateUrlFields="id" DataNavigateUrlFormatString="~/SelectGame.aspx?id={0}" >
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:HyperLinkField>
                    <asp:BoundField DataField="nazwa" HeaderText="Producent" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="nazwa_gatunku" HeaderText="Gatunek" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="rok_wydania" DataFormatString="{0:yyyy-MM-dd}" HeaderText="Rok wydania" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="kraj" HeaderText="Kraj" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="platformas" HeaderText="Platforma" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="~/EditGame.aspx?id={0}" Text="Edytuj">
                    <ControlStyle ForeColor="#003300" />
                    <ItemStyle ForeColor="#003300" HorizontalAlign="Center" />
                    </asp:HyperLinkField>
                    <asp:HyperLinkField Text="Usuń">
                    <ControlStyle ForeColor="Red" />
                    <ItemStyle ForeColor="Red" HorizontalAlign="Center" />
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
    </div>

    <div class="row">
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>
