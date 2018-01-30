using Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class EditGame : System.Web.UI.Page
    {
        int iIdOcena = 0;
        int iIdGatunek = 0;
        int iIdProducent = 0;
        string sGryOnline;
        string sEurogamer;
        string aaa;

        void zaznaczPlatforme(int pl)
        {
            if(pl == 1)
            {
                cblPlatforma.Items.FindByValue("1").Selected = true;
            }
            else
            if (pl == 2)
            {
                cblPlatforma.Items.FindByValue("2").Selected = true;
            }
            else
            if (pl == 3)
            {
                cblPlatforma.Items.FindByValue("1").Selected = true;
                cblPlatforma.Items.FindByValue("2").Selected = true;
            }
            else
            if (pl == 4)
            {
                cblPlatforma.Items.FindByValue("4").Selected = true;
            }
            else
            if (pl == 5)
            {
                cblPlatforma.Items.FindByValue("1").Selected = true;
                cblPlatforma.Items.FindByValue("4").Selected = true;
            }
            else
            if (pl == 6)
            {
                cblPlatforma.Items.FindByValue("2").Selected = true;
                cblPlatforma.Items.FindByValue("4").Selected = true;
            }
            else
            if (pl == 7)
            {
                cblPlatforma.Items.FindByValue("1").Selected = true;
                cblPlatforma.Items.FindByValue("2").Selected = true;
                cblPlatforma.Items.FindByValue("4").Selected = true;
            }
        }
        void ocena(DropDownList ddl, int o)
        {
            ddl.SelectedValue = o.ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            foreach (var item in sc.wyswietlGre(id))
            {
                lbTytul.Text = item.tytul;
                tbTytul.Text = item.tytul;
                tbRokWyd.Text = item.rok_wydania.ToShortDateString();
                tbKraj.Text = item.kraj;
                zaznaczPlatforme(item.platforma);
                tbOkladka.Text = item.link_okladka;
                tbOpis.Text = item.opis;
                ocena(ddlOcenaGryOnline, item.gry_online_pl);
                ocena(ddlEurogamer, item.eurogamer_com);
                iIdOcena = item.id_oceny;
                iIdGatunek = item.id_gatunek;
                iIdProducent = item.id_producent;
            }
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            tbRokWyd.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        protected void btnAnuluj_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void btnZapisz_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            Oceny oc = new Oceny();
            oc.Gry_online_pl = int.Parse(ddlOcenaGryOnline.SelectedValue);
            oc.Eurogamer = int.Parse(ddlEurogamer.SelectedValue);
            oc.Id_oceny = iIdOcena;
            sc.edytujOcene(oc);
        }

        protected void ddlOcenaGryOnline_SelectedIndexChanged(object sender, EventArgs e)
        {
            var container = Master.FindControl("MainContent");
            var control = container.FindControl("tbTytul");
            TextBox TextBox1 = (TextBox)control;
            sGryOnline = TextBox1.Text;
        }

        protected void tbTytul_TextChanged(object sender, EventArgs e)
        {
            var container = Master.FindControl("MainContent");
            sGryOnline = ((TextBox)container.FindControl("tbTytul")).Text;
        }
    }
}