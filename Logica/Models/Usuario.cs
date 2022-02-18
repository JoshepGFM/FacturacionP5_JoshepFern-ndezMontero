using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {

        public int IDUsuario { get; set; }

        public String Nombre { get; set; }

        public String NombreUsuario { get; set; }

        public String Telefono { get; set; }

        public String CorreoDeRespaldo { get; set; }

        public String Contrasennia { get; set; }

        public String Cedula { get; set; }

        public bool Activo { get; set; }

        UsuarioRol MiRol { get; set; }

        public Usuario()
        {
            MiRol = new UsuarioRol();
        }

        public bool Agregar(string pNombre, string pNombreUsuario, string pTelefono, string pCorreoDeRespaldo, string pContrasennia, string pCedula)
        {
            bool R = false;

            Nombre = pNombre;
            NombreUsuario = pNombreUsuario;
            Telefono = pTelefono;
            CorreoDeRespaldo = pCorreoDeRespaldo;
            Contrasennia = pContrasennia;
            Cedula = pCedula;

            //TODO: Ejecutar el SP para El insert en tabla cliente

            return R;
        }

        public bool Editar(int pIDUsuario, string pNombre, string pNombreUsuario, string pTelefono, string pCorreoDeRespaldo, string pContrasennia, string pCedula)
        {
            bool R = false;

            return R;
        }

        public bool Eliminar(int pIDUsuario)
        {
            bool R = false;


            return R;
        }

        public bool ConsultaPorCedula(string pCedula)
        {
            bool R = false;


            return R;
        }

        public bool ConsultaPorEmail(string pCorreoDeRespaldo)
        {
            bool R = false;


            return R;
        }

        public bool ConsultaPorID(int pIDUsuario)
        {
            bool R = false;


            return R;
        }

        public DataTable ListarActivos(bool VerActivos = true)
        {
            DataTable R = new DataTable();


            return R;

        }

        public DataTable Listarinactivos(bool VerInactivos = true)
        {
            DataTable R = new DataTable();


            return R;

        }
    }
}
