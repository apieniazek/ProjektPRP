<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditGame.aspx.cs" Inherits="Client.EditGame" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <h2>
            &nbsp;<p>&nbsp;&nbsp;<asp:Label ID="lbTytul" runat="server" Height="50px" Width="100%"></asp:Label>  </p>                   
        </h2>   
    <div>
        
        
        
        <table style="width:100%;">
            <tr>
                <td style="width: 162px">Tytuł:</td>
                <td width="10">&nbsp;</td>
                <td><asp:TextBox  ID="tbTytul" runat="server" Height="25px" Width="200px" OnTextChanged="tbTytul_TextChanged"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="rfvTytul" runat="server" ControlToValidate="tbTytul" ErrorMessage="pole tytuł nie może być puste" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 162px"></td>
                <td width="10">&nbsp;</td>
                <td></td>
            </tr>
            <tr>
                <td style="width: 162px">Producent:</td>
                <td width="10">&nbsp;</td>
                <td>
                    <asp:DropDownList ID="ddlProducent" runat="server" Height="25px" Width="200px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 162px"></td>
                <td width="10">&nbsp;</td>
                <td></td>
            </tr>
            <tr>
                <td style="width: 162px">Gatunek:</td>
                <td width="10">&nbsp;</td>
                <td> <asp:DropDownList ID="ddlGatunek" runat="server" Height="25px" Width="200px">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 162px"></td>
                <td width="10">&nbsp;</td>
                <td></td>
            </tr>
            <tr>
                <td style="width: 162px">Rok wydania:</td>
                <td width="10">&nbsp;</td>
                <td><asp:TextBox ID="tbRokWyd" runat="server" Height="25px" Width="200px" Enabled="False"></asp:TextBox>&nbsp;
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kalendarz" />
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" OnSelectionChanged="Calendar1_SelectionChanged" Visible="False" Width="220px">
                        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                        <WeekendDayStyle BackColor="#CCCCFF" />
                    </asp:Calendar>
                </td>
                
            </tr>
            <tr>
                <td style="width: 162px"></td>
                <td width="10">&nbsp;</td>
                <td></td>
            </tr>
            <tr>
                <td style="width: 162px">Kraj:</td>
                <td width="10">&nbsp;</td>
                <td><asp:TextBox ID="tbKraj" runat="server"  Height="25px" Width="200px"></asp:TextBox><asp:RequiredFieldValidator ID="rfvTytul0" runat="server" ControlToValidate="tbKraj" ErrorMessage="pole kraj nie może być puste" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 162px"></td>
                <td width="10">&nbsp;</td>
                <td></td>
            </tr>
            <tr>
                
                <td style="width: 162px; height: 68px;">Platforma:</td>
                <td width="10" style="height: 68px"></td>
                <td style="height: 68px">
                <asp:CheckBoxList ID="cblPlatforma" runat="server">
                    <asp:ListItem Value="1">PC</asp:ListItem>
                    <asp:ListItem Value="2">PS4</asp:ListItem>
                    <asp:ListItem Value="4">XBOX</asp:ListItem>
                    </asp:CheckBoxList></td>
            </tr>
            <tr>
                <td style="width: 162px"></td>
                <td width="10">&nbsp;</td>
                <td></td>
            </tr>
            <tr>
                <td style="width: 162px">Link do okładki:</td>
                <td width="10">&nbsp;</td>
                <td><asp:TextBox ID="tbOkladka" runat="server"  Height="25px" Width="494px" MaxLength="200"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 162px"></td>
                <td width="10">&nbsp;</td>
                <td></td>
            </tr>
            <tr>
                <td style="width: 162px">Opis:</td>
                
                <td width="10">&nbsp;</td>
                <td width="700">
                <asp:TextBox ID="tbOpis" runat="server"  Height="100px" Width="700px" MaxLength="1200" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 162px"></td>
                <td width="10">&nbsp;</td>
                <td></td>
            </tr>
            <tr>
                <td style="width: 162px">Ocena wg Gry-Online:</td>
                <td width="10">&nbsp;</td>
                <td>
                    <asp:DropDownList ID="ddlOcenaGryOnline" runat="server" OnSelectedIndexChanged="ddlOcenaGryOnline_SelectedIndexChanged">
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
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 162px">Ocena wg Eurogamer.pl:</td>
                <td width="10">&nbsp;</td>
                <td>
                    <asp:DropDownList ID="ddlEurogamer" runat="server">
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
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 162px"></td>
                <td width="10">&nbsp;</td>
                <td><asp:Button ID="btnZapisz" runat="server" Text="Zapisz" OnClick="btnZapisz_Click" CommandName="submit" /> &nbsp<asp:Button ID="btnAnuluj" runat="server" Text="Anuluj" OnClick="btnAnuluj_Click" /></td>
                
            </tr>
        </table>
        <br />
         </div>
</asp:Content>
