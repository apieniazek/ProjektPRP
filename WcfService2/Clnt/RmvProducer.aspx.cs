using Clnt.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clnt
{
    public partial class RmvProducer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            foreach (var item in sc.wyswietlProducent(id))
            {
                lbProducent.Text = "Usuwasz producenta: " + item.Nazwa;
            }
            sc.Close();
        }

        protected void btnUsun_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            sc.usunProducenta(id);
            sc.Close();
            Response.Redirect("Producer.aspx");
        }

        protected void btnAnuluj_Click(object sender, EventArgs e)
        {
            Response.Redirect("Producer.aspx");
        }
    }
}