using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuForms
{
    internal class Producto
    {
       
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
   
        public Producto(string nombre, string categoria, decimal precio, int stock)
        {
       
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
            
        }
        public override string ToString()
        {
            return $"- {Nombre} - {Categoria} - ${Precio}";
        }
    }
}
