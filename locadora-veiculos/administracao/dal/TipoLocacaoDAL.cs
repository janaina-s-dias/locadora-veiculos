using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using administracao.Common.model;
using System.Data.SqlClient;

namespace administracao.Common.dal
{
    public class TipoLocacaoDAL : Conexao
    {

        #region Gravar
        public void Gravar (TipoLocacao tipoloc)
        {
            try
            {
                abrirConexao();
                Cmd = new SqlCommand("Insert into tbLocacao (nmTipoLocacao) values (@nome)", Con);

                Cmd.Parameters.AddWithValue("@nome", tipoloc.nmTipoLocacao);
                //Cmd.Parameters.AddWithValue("@ativo", tipoloc.ckAtivo);

                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao gravar: " + ex.Message);
            }

            finally 
            {
                fecharConexao();
            }
        }

        #endregion

        #region Alterar
        public void Atualizar(TipoLocacao tipoloc)
        {
            try
            {
                abrirConexao();
                Cmd = new SqlCommand("Update tbLocacao set nmTipoLocacao = @nome, dsAtivoTipoLocacao = @ativo where cdTipoLocacao = @codigo", Con);

                Cmd.Parameters.AddWithValue("@nome", tipoloc.nmTipoLocacao);
                Cmd.Parameters.AddWithValue("@ativo", tipoloc.ckAtivo);
                Cmd.Parameters.AddWithValue("@codigo", tipoloc.cdTipoLocacao);

                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar: " + ex.Message);
            }

            finally
            {
                fecharConexao();
            }
        }

        #endregion

        #region Pesquisa por Código
        public TipoLocacao PesquisarCodigo(int _cdTipoLocacao)
        {
            try
            {
                abrirConexao();
                Cmd = new SqlCommand("Select * from tbLocacao where cdTipoLocacao = @codigo", Con);

                Cmd.Parameters.AddWithValue("@codigo", _cdTipoLocacao);

                TipoLocacao tipoloc = null;

                if(Dr.Read())
                {

                    tipoloc = new TipoLocacao();

                    tipoloc.cdTipoLocacao = Convert.ToInt32(Dr["cdTipoLocacao"]);
                    tipoloc.nmTipoLocacao = Convert.ToString(Dr["nmTipoLocacao"]);
                    tipoloc.ckAtivo = Convert.ToBoolean(Dr["ckAtivo"]);

                }

                return tipoloc;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Pesquisar: " + ex.Message);
            }

            finally
            {
                fecharConexao();
            }
        }

        #endregion

        #region Listar
        public List<TipoLocacao> Listar()
        {
            try
            {
                abrirConexao();
                Cmd = new SqlCommand("Select * from tbLocacao", Con);

                Cmd.ExecuteReader();

                List<TipoLocacao> lista = new List<TipoLocacao>();

                while (Dr.Read())
                {
                    TipoLocacao tipoloc = new TipoLocacao();

                    tipoloc.cdTipoLocacao = Convert.ToInt32(Dr["cdTipoLocacao"]);
                    tipoloc.nmTipoLocacao = Convert.ToString(Dr["nmTipoLocacao"]);
                    tipoloc.ckAtivo = Convert.ToBoolean(Dr["ckAtivo"]);

                    lista.Add(tipoloc);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Listar: " + ex.Message);
            }

            finally
            {
                fecharConexao();
            }
        }

        #endregion


    }
}
