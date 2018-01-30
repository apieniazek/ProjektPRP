using Clnt.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clnt
{
    public partial class SelectGame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                Service1Client sc = new Service1Client();
                foreach (var item in sc.wyswietlGre(id))
                {
                    lbTytul.Text = item.tytul;
                    lOpis.Text = item.opis;
                    link.Attributes["src"] = item.link_okladka;
                    lbGry.Text = item.gry_online_pl.ToString();
                    lbEuro.Text = item.eurogamer_com.ToString();
                    lbMojaOcena.Text = item.moja_ocena.ToString();
                }

                sc.Close();
            }
        }

        protected void btnCofnij_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}