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
        
        public Producto() { }
   
        public Producto(string nombre, decimal precio,string categoria)
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
