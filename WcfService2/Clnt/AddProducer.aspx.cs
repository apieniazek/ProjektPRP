using Clnt.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clnt
{
    public partial class ProducerAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnZapisz_Click1(object sender, EventArgs e)
        {
            Page.Validate("addproducer");
            if (Page.IsValid)
            {


                Service1Client sc = new Service1Client();
                Producent pr = new Producent();
                pr.Nazwa = tbProducent.Text;
                pr.Zalozyciel = tbZalozyciel.Text;
                pr.Rok_zalozenia = DateTime.Parse(tbRokZal.Text);
                sc.dodajProducenta(pr);
                sc.Close();
                Response.Redirect("~/Producer.aspx");
            }
        }

        protected void btnAnuluj_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Producer.aspx");
        }

    }
}