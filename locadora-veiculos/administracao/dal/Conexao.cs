using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administracao
{
    public class Conexao
    {
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        protected void abrirConexao()
        {
            try
            {
                Con = new SqlConnection("Data Source=VMSEPLAN-0218/SQLEXPRESS;Initial Catalog=db-locacaoveiculos;Integrated Security=True");
                Con.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        protected void fecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}

