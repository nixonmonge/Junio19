using Junio19.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Junio19
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario

            string texto = TextBox1.Text;
            string texto2 = TextBox2.Text;
            List<actor> listado = ActoresDAL.ListarPorNombre(texto, texto2);
            GridView1.DataSource = listado;
            GridView1.DataBind();

        }
    }
}