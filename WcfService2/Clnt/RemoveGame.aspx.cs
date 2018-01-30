using Clnt.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clnt
{
    public partial class RemoveGame : System.Web.UI.Page
    {
        public static int m_iOcenaId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                Service1Client sc = new Service1Client();
                foreach (var item in sc.wyswietlGre(id))
                {
                    lbTytul.Text = "Usuwasz grę: " + item.tytul;
                }
                sc.Close();
            }
        }

        protected void btnUsun_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            foreach (var item in sc.wyswietlGre(id))
            {
                m_iOcenaId = item.id_oceny;
            }
            sc.usunOcene(m_iOcenaId);
            sc.usunGre(id);
            sc.Close();
            Response.Redirect("~/Default.aspx");
        }

        protected void btnAnuluj_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}