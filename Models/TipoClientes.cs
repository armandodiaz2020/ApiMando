using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class TipoClientes
    {
        public int id { get; set; }

        public string tipo_cliente
        {
            get; set;
        }
        public object IdTipoCliente { get; internal set; }
        public object Nombre { get; internal set; }
    }
}