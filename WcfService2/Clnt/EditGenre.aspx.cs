using Clnt.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clnt
{
    public partial class EditGenre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                Service1Client sc = new Service1Client();
                foreach (var item in sc.wyswietlGatunek(id))
                {
                    tbGatunek.Text = item.Nazwa;
                }
                sc.Close();
            }
        }

        protected void btnZapisz_Click1(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            Gatunek gt = new Gatunek();
            gt.Id_gatunek = id;
            gt.Nazwa = tbGatunek.Text;
            sc.edytujGatunek(gt);
            sc.Close();
            Response.Redirect("Genre.aspx");
        }

        protected void btnAnuluj_Click(object sender, EventArgs e)
        {
            Response.Redirect("Genre.aspx");
        }
    }
}