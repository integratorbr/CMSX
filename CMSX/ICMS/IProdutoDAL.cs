using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CMSXEF;

namespace ICMS
{
    public interface IProdutoDAL
    {
        int NumParms { get; set; }
        void CriaProduto();
        void MakeConnection(dynamic prop);
        IEnumerable<produto> ListaProduto();
        DataTable ListaProdutoPorId();
        DataTable ListaProdutoRelacionado();
        void EditaProduto();
        void InativaProduto();
    }
}
