using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Detalle_factura
    {

        public int id { get; set; }

        public int idfactura
        {
            get; set;
        }
        public int idproducto
        {
            get; set;
        }
        public string descripcion
        {
            get; set;
        }
        public int cantidad
        {
            get; set;
        }
        public float precio
        {
            get; set;
        }
        public float monto
        {
            get; set;
        }
    }
}
