using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Producto
    {
        public int IDProducto { get; set; }

        public string CodigoBarras { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal CantidadEnStock { get; set; }
        public decimal PrecioUsuario { get; set; }

        //atributos compuestos

        UnidadMedia MiUnidadMedida { get; set; }
        ProductoCategoria MiCategoria { get; set; }
        Impuesto MiImpuesto { get; set; }

        public Producto()
        {
            MiUnidadMedida = new UnidadMedia();
            MiCategoria = new ProductoCategoria();
            MiImpuesto = new Impuesto();
        }

        //funciones y metodos
        public bool Agregar()
        {
            bool R = false;

            return R;
        }

        public bool Editar()
        {
            bool R = false;

            return R;
        }
        public bool Eliminar()
        {
            bool R = false;

            return R;
        }
        public bool ConsultarPorCodigoDeBarras()
        {
            bool R = false;

            return R;
        }
        public bool ComsultarPorID()
        {
            bool R = false;

            return R;
        }

        public DataTable Listar(bool VerActivo = true)
        {
            DataTable R = new DataTable();

            return R;
        }
    }
}
