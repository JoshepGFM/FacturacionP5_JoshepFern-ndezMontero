using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class UnidadMedia
    {
        public int IDUnidad { get; set; }

        public string Unidad { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            //TODO:Escribir Codigo para llenar R con los 
            //datos necesarios

            return R;
        }
    }
}
