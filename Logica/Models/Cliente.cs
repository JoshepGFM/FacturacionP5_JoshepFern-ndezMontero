using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Cliente
    {
        public int IDCliente { get; set; }
        public String Nombre { get; set; }

        public String Cedula { get; set; }

        public String Telefono { get; set; }

        public String Email { get; set; }

        public bool Activo { get; set; }

        //Atributo Compuestos

        ClienteTipo MiTipo { get; set; }

        //constructor de la clase para instaciar el atributo compuesto simple
        public Cliente()
        {
            //dentro de este ctor instaciamos los objetos compuestos

            MiTipo = new ClienteTipo();

        }

        //operaciones de la clase 

        public bool Agregar(String pNombre, String pCedula, string pTelefono = "", string pEmail = "")
        {
            bool R = false;

            Nombre = pNombre;
            Cedula = pCedula;
            Telefono = pTelefono;
            Email = pEmail;

            //TODO: Ejecutar el SP para El insert en tabla cliente

            return R;
        }
        public bool Editar(int pIDCliente, String pNombre, String pCedula, string pTelefono = "", string pEmail = "")
        {

            bool R = false;



            return R;

        }

        public bool Eliminar(int pIDCliente)
        {

            bool R = false;



            return R;
        }

        public bool ConsultarPorCedula(String pCedula)
        {
            bool R = false;


            return R;

        }


        public bool ConsultarID(String pIDCliente)
        {
            bool R = false;


            return R;

        }

        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();


            return R;

        }
    }
}
