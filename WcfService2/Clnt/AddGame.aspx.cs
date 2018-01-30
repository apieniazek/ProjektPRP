using Clnt.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clnt
{
    public partial class AddGame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Service1Client sc = new Service1Client();
                foreach (var item in sc.wyswietlProducentow())
                {
                    ListItem li = new ListItem();
                    li.Value = item.Id_producent.ToString();
                    li.Text = item.Nazwa.Trim();
                    ddlProducent.Items.Add(li);
                }
                foreach (var item in sc.wyswietlGatunki())
                {
                    ListItem li = new ListItem();
                    li.Value = item.Id_gatunek.ToString();
                    li.Text = item.Nazwa.Trim();
                    ddlGatunek.Items.Add(li);
                }
                sc.Close();
            }
        }

        int ustawPlatforma(CheckBoxList cbl)
        {
            int iResult = -1;
            if (cbl.Items.FindByValue("1").Selected == true)
                iResult = 1;
            if (cbl.Items.FindByValue("2").Selected == true)
                iResult = 2;
            if (cbl.Items.FindByValue("1").Selected == true & cbl.Items.FindByValue("2").Selected == true)
                iResult = 3;
            if (cbl.Items.FindByValue("4").Selected == true)
                iResult = 4;
            if (cbl.Items.FindByValue("1").Selected == true & cbl.Items.FindByValue("4").Selected == true)
                iResult = 5;
            if (cbl.Items.FindByValue("2").Selected == true & cbl.Items.FindByValue("4").Selected == true)
                iResult = 6;
            if (cbl.Items.FindByValue("1").Selected == true & cbl.Items.FindByValue("2").Selected == true & cbl.Items.FindByValue("4").Selected == true)
                iResult = 7;
            return iResult;
        }

        protected void btnZapisz_Click(object sender, EventArgs e)
        {
            Page.Validate("addvalidation");
            if (Page.IsValid)
            {


                double a;
                double b;
                double c;
                Service1Client sc = new Service1Client();
                Oceny oc = new Oceny();
                oc.Gry_online_pl = int.Parse(ddlOcenaGryOnline.SelectedValue);
                oc.Eurogamer = int.Parse(ddlEurogamer.SelectedValue);
                oc.Moja_ocena = int.Parse(ddlMojaOcena.SelectedValue);
                a = double.Parse(ddlOcenaGryOnline.Text);
                b = double.Parse(ddlEurogamer.Text);
                c = double.Parse(ddlMojaOcena.Text);
                oc.Srednia_ocena = System.Math.Round(sc.sredniaocena(a, b, c), 2);
                sc.dodajOcene(oc);
                Gry gr = new Gry();
                gr.Gatunek_Id = int.Parse(ddlGatunek.SelectedValue);
                gr.Ocena_Id = sc.pobierzOcenaId();
                gr.Producent_Id = int.Parse(ddlProducent.SelectedValue);
                gr.Tytul = tbTytul.Text;
                gr.Kraj = tbKraj.Text;
                gr.link_okladka = tbOkladka.Text;
                gr.opis = tbOpis.Text;
                gr.Platforma = ustawPlatforma(cblPlatforma);
                gr.Rok_wydania = DateTime.Parse(tbRokWyd.Text);
                sc.dodajGre(gr);
                sc.Close();
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void btnAnuluj_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}