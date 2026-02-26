using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuForms
{
    internal class DetalleOrden
    {
        public List<Producto> Productos { get; set; }

        public DetalleOrden()
        {
            Productos = new List<Producto>();
        }
        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

           public decimal CalcularTotal()
            {
                return Productos.Sum(p => p.Precio);
        }


    }
}
