using Clnt.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clnt
{
    public partial class EditProducer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                Service1Client sc = new Service1Client();
                foreach (var item in sc.wyswietlProducent(id))
                {
                    tbProducent.Text = item.Nazwa;
                    tbZalozyciel.Text = item.Zalozyciel;
                    tbRokZal.Text = item.Rok_zalozenia.ToShortDateString();
                }
                sc.Close();
            }            
        }

        protected void btnZapisz_Click1(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            Producent pr = new Producent();
            pr.Id_producent = id;
            pr.Nazwa = tbProducent.Text;
            pr.Zalozyciel = tbZalozyciel.Text;
            pr.Rok_zalozenia = DateTime.Parse(tbRokZal.Text);
            sc.edytujProducenta(pr);
            sc.Close();
            Response.Redirect("Producer.aspx");
        }

        protected void btnAnuluj_Click(object sender, EventArgs e)
        {
            Response.Redirect("Producer.aspx");
        }

    }
}