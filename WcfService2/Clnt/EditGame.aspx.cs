using Clnt.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clnt
{
    public partial class EditGame : System.Web.UI.Page
    {
        public static int m_iIdOcena;
        public static int m_iIdGatunek = 0;
        public static int m_iIdProducent = 0;

        void zaznaczPlatforme(int pl)
        {
            if (pl == 1)
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
            if(!Page.IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                Service1Client sc = new Service1Client();
                foreach (var item in sc.wyswietlGre(id))
                {
                    lbTytul.Text = "Edytujesz grę: " + item.tytul;
                    tbTytul.Text = item.tytul;
                    tbRokWyd.Text = item.rok_wydania.ToShortDateString();
                    tbKraj.Text = item.kraj;
                    zaznaczPlatforme(item.platforma);
                    tbOkladka.Text = item.link_okladka;
                    tbOpis.Text = item.opis;
                    ocena(ddlOcenaGryOnline, item.gry_online_pl);
                    ocena(ddlEurogamer, item.eurogamer_com);
                    ocena(ddlMojaOcena, item.moja_ocena);
                    m_iIdOcena = item.id_oceny;
                    m_iIdGatunek = item.id_gatunek;
                    m_iIdProducent = item.id_producent;
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

        protected void btnZapisz_Click1(object sender, EventArgs e)
        {
            double a;
            double b;
            double c;
            int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            Oceny oc = new Oceny();
            oc.Gry_online_pl = int.Parse(ddlOcenaGryOnline.SelectedValue);
            oc.Eurogamer = int.Parse(ddlEurogamer.SelectedValue);
            oc.Moja_ocena = int.Parse(ddlMojaOcena.SelectedValue);
            a = double.Parse(ddlOcenaGryOnline.Text);
            b = double.Parse(ddlEurogamer.Text);
            c = double.Parse(ddlMojaOcena.Text);
            oc.Srednia_ocena = System.Math.Round(sc.sredniaocena(a, b, c), 2);
            oc.Id_oceny = m_iIdOcena;
            sc.edytujOcene(oc);
            Gry gr = new Gry();
            gr.Id = id;
            gr.Gatunek_Id = int.Parse(ddlGatunek.SelectedValue);
            gr.Ocena_Id = m_iIdOcena;
            gr.Producent_Id = int.Parse(ddlProducent.SelectedValue);
            gr.Tytul = tbTytul.Text;
            gr.Kraj = tbKraj.Text;
            gr.link_okladka = tbOkladka.Text;
            gr.opis = tbOpis.Text;
            gr.Platforma = ustawPlatforma(cblPlatforma);
            gr.Rok_wydania = DateTime.Parse(tbRokWyd.Text);
            sc.edytujGre(gr);
            sc.Close();
            Response.Redirect("~/Default.aspx");
        }

        protected void btnAnuluj_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}