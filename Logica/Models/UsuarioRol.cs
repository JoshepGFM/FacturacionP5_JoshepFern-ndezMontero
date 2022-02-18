using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class UsuarioRol
    {

        public int IDUsuarioRol { get; set; }

        public String Rol { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            //TODO:Escribir Codigo para llenar R con los 
            //datos necesarios

            return R;
        }


    }
}
