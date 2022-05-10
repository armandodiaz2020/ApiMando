using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Cliente
    {
        public int id { get; set; }

        public string tipo_cliente
        {
            get; set;
        }
        public string nombre
        {
            get; set;
        }
        public string apellido
        {
            get; set;
        }
        public string correo
        {
            get; set;
        }
        public string telefono
        {
            get; set;
        }

    }
}
