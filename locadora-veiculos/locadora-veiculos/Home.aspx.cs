using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace locadora_veiculos
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcessar(object sender, EventArgs e)
        {
            string opcao = ddlMenu.SelectedValue;

            switch(opcao)
            {
                case "0":
                    lblMensagem.Text = "Selecione uma opção válida!";
                    break;

                case "1":
                    Response.Redirect("/");
                    break;

                case "2":
                    Response.Redirect("/");
                    break;
            }
        }
    }
}