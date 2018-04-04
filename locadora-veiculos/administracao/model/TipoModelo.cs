using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacao.Common.model
{
    public class TipoModelo
    {
        public Int32 cdTipoModelo { get; set; }
        public String nmTipoModelo { get; set; }
        public Boolean ckAtivo { get; set; }

        public TipoModelo() { }

        public TipoModelo(int _cdTipoModelo, string _nmTipoModelo, bool _ckAtivo) 
        {
            this.cdTipoModelo = _cdTipoModelo;
            this.nmTipoModelo = _nmTipoModelo;
            this.ckAtivo = _ckAtivo;
        }
    }
}
