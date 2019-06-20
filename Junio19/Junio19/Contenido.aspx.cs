using Junio19.Dal;
using Junio19.Models;
using Junio19.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Junio19
{
    public partial class Contenido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = ActoresDAL.ListarTodo();
            GridView1.DataBind();
        }


    }
}