using Junio19.Dal;
using Junio19.Models;
using Junio19.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Junio19.Service
{
    public class ActoresService
    {
        public static actor Factory(TextBox txtId, TextBox txtNombre, TextBox txtApellido, TextBox txtEdad)
        {
            var nuevoActor = new actor();
            nuevoActor.actor_id = Convert.ToInt32(txtId.Text);
            nuevoActor.first_name = txtNombre.Text;
            nuevoActor.last_name = txtApellido.Text;           

            return nuevoActor;
        }
    }
}