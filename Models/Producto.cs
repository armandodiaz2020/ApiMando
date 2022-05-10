using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Producto
    {
        public int id { get; set; }

        public string nombre
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
    }
}

