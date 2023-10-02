using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMSXDB;

namespace CMSXBLL.Repositorio
{
    public interface IUnidadeRepositorio
    {
        void MakeConnection(dynamic prop);
        void CriaNovaUnidade();
        List<Unidade> ListaUnidade();
        List<Unidade> Helper(IEnumerable<unidades> appdata);
    }
}
