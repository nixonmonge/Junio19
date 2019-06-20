using Junio19.Dal;
using Junio19.Models;
using Junio19.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Junio19.Dal
{
    public class ActoresDAL
    {
        public static List<actor> ListarTodo()
        {
            var listado = new List<actor>();
            using (var modelo = new Model1())
            {
                listado = modelo.actor // Tabla
                    .Where(a=>a.first_name!="") // Filtro
                    .OrderBy( a=>a.first_name) // Ordenamiento
                    .ToList(); // Listar Datos

                // LINQ
               listado = (from a in modelo.actor
                          where a.first_name!=""
                          orderby a.first_name
                          select a).ToList();
            }
            return listado;

        }

        public static List<actor> ListarPorNombre(string nombre, string apellido)
        {
            var resultado = new List<actor>();
            using (var grupo = new Model1())
            {
                //forma 1
                resultado = grupo.actor
                    .Where(fila => fila.first_name == nombre )
                    .Where(fila => fila.last_name == apellido)
                    .ToList();
                //forma 2
                resultado = grupo.actor
                    .Where(fila => fila.first_name == nombre &&
                      fila.last_name == apellido
                    ).ToList();


            }

                return resultado;
        }


    }
}