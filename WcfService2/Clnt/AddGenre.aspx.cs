using Clnt.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clnt
{
    public partial class AddGenre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnZapisz_Click1(object sender, EventArgs e)
        {
            Page.Validate("addgenre");
            if (Page.IsValid)
            {
                Service1Client sc = new Service1Client();
                Gatunek gt = new Gatunek();
                gt.Nazwa = tbGatunek.Text;
                sc.dodajGatunek(gt);
                sc.Close();
                Response.Redirect("~/Genre.aspx");
            }
        }

        protected void btnAnuluj_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Genre.aspx");
        }
    }
}