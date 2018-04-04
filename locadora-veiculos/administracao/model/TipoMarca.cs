using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administracao.Common.model
{
    public class TipoMarca
    {
        public Int32 cdTipoMarca { get; set; }
        public String nmTipoMarca { get; set; }
        public Boolean ckAtivo { get; set; }

        public TipoMarca() { }

        public TipoMarca(int _cdTipoMarca, string _nmTipoMarca, bool _ckAtivo) 
        {
            this.cdTipoMarca = _cdTipoMarca;
            this.nmTipoMarca = _nmTipoMarca;
            this.ckAtivo = _ckAtivo;
        }
    }
}
