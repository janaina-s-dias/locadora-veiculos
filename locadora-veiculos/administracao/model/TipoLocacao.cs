using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administracao.Common.model
{
    public class TipoLocacao
    {
        public Int32 cdTipoLocacao { get; set; }
        public String nmTipoLocacao { get; set; }
        public Boolean ckAtivo { get; set; }

        public TipoLocacao() { }

        public TipoLocacao(int _cdTipoLocacao, String _nmTipoLocacao, bool _ckAtivo) 
        {
            this.cdTipoLocacao = _cdTipoLocacao;
            this.nmTipoLocacao = _nmTipoLocacao;
            this.ckAtivo = _ckAtivo;
        }


    }
}
