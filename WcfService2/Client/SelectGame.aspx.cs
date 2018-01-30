using Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class SelectGame : System.Web.UI.Page
    {
       
        
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            Service1Client sc = new Service1Client();
            foreach(var item in sc.wyswietlGre(id))
            {
                lbTytul.Text = item.tytul;
                lOpis.Text = item.opis;
                link.Attributes["src"] = item.link_okladka;
                lbGry.Text = item.gry_online_pl.ToString();
                lbEuro.Text = item.eurogamer_com.ToString();
            }
            
            sc.Close();
            //Console.WriteLine(GetUniqueIDRelativeTo(dupa));
            
        }
    }
}