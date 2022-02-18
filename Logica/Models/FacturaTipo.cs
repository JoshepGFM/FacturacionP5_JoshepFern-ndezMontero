using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class FacturaTipo
    {
        //En una estructura estandar de clase, primero se escriben los atributos simples.
        //luego los atributos compuestos, despues las operaciones(metodos y funciones)
        //normalmente, ademas se puede escribir un constructor si es necesario.

        //1.Atributos

        private int iDFacturaTipo;
        public int IDFacturaTipo
        {
            get { return iDFacturaTipo; }
            set { iDFacturaTipo = value; }
        }

        //Otra opcion para escribir una propiedad es por medio de la forma 

        public String Tipo { get; set; }

        //ahora escribimos las operaciones

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            //TODO: Escribir Codogo para llenar R con los 
            //datos necesarios

            return R;
        }
    }
}
