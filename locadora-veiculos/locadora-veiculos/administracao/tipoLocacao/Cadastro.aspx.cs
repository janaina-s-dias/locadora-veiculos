using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using administracao.Common.model;
using administracao.Common.dal;


namespace locadora_veiculos.administracao
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { }

        protected void btnCadastrar(object sender, EventArgs e)
        {
            try
            {
                TipoLocacao tl = new TipoLocacao();
                tl.nmTipoLocacao = txtNomeTipoLocacao.Text;

                TipoLocacaoDAL tld = new TipoLocacaoDAL();

                tld.Gravar(tl);

                lblMensagem.Text = "Gravado com sucesso!";

                txtNomeTipoLocacao.Text = String.Empty;
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }

        }
    }
}