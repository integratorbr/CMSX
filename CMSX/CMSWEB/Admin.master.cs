﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : BaseMasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["USUARIO"]==null)
        {
            //Response.Redirect("Default.aspx");
        }
    }
}
