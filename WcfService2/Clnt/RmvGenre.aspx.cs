using Clnt.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clnt
{
    public partial class RmvGenre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            foreach (var item in sc.wyswietlGatunek(id))
            {
                lbNazwa.Text = "Usuwasz gatunek: " + item.Nazwa;
            }
            sc.Close();
        }

        protected void btnUsun_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            sc.usunGatunek(id);
            sc.Close();
            Response.Redirect("Genre.aspx");
        }

        protected void btnAnuluj_Click(object sender, EventArgs e)
        {
            Response.Redirect("Genre.aspx");
        }
    }
}