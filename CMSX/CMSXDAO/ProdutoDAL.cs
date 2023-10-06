using System.Data;
using ICMSX;
using CMSXData;
using CMSXData.Models;

namespace CMSXDAO
{
    public class ProdutoDAL : IProdutoDAL 
    {


        private IDbConnection conn;
        private IDbCommand cmd;
        private IDataParameter[] parms;
        private IDataFactory _factory;
        public int NumParms { get; set; }
        private dynamic _localProps;

        public ProdutoDAL(IDataFactory factory)
        {
            _factory = factory;
        }

        public void MakeConnection(dynamic prop)
        {
            var data = _factory.GetConnection(prop.banco, prop.parms);
            conn = data.Key;
            cmd = data.Value.Key;
            parms = data.Value.Value;
            _localProps = prop;
        }

        public void CriaProduto()
        {
            throw new NotImplementedException();
        }

        public void EditaProduto()
        {
            throw new NotImplementedException();
        }

        public void InativaProduto()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produto> ListaProduto()
        {
            string appid = _localProps.appid;
            CmsxDbContext db = new CmsxDbContext();
            IEnumerable<Produto> lst = from prod in db.Produtos
                                       where prod.Aplicacaoid == appid
                                       select prod;
            return lst;
        }

        public DataTable ListaProdutoPorId()
        { 
            throw new NotImplementedException();
        }

        public DataTable ListaProdutoRelacionado()
        {
            throw new NotImplementedException();
        }
    }
}
