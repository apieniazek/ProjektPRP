using Clnt.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clnt
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int i = 0;
                string tytul = "";
                int p = 0;
                int g = 0;

                try
                {
                    
                    i = int.Parse(Request.QueryString["i"]);                    
                    tytul = Request.QueryString["tytul"];                    
                    p = int.Parse(Request.QueryString["prod"]);                    
                    g = int.Parse(Request.QueryString["gatunek"]);
                }
                catch (Exception ex) { }
                Service1Client sc = new Service1Client();
                gvGry.DataSource = sc.wyswietlGry(i,tytul,p,g);
                gvGry.DataBind();
                sc.Close();
            }
        }

        protected void btnDodaj_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AddGame.aspx");
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FindGame.aspx");
        }

        protected void gvGry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}