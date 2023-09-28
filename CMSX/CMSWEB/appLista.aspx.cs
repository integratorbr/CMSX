using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMSBLL;
using CMSBLL.Repositorio;
using System.Dynamic;

public partial class appLista : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        _obj.parms = 0;

        ListaAplicacao();
    }

    protected void ListaAplicacao()
    {

        _apprepo.MakeConnection(_obj);
        listaApp.DataSource = _apprepo.ListaAplicacao();
        listaApp.DataBind();
    }

}