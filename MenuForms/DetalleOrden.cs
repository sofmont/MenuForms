using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuForms
{
    internal class DetalleOrden
    {
        public List<Producto> Productos { get; set; }=new List<Producto>();

        public DetalleOrden(List<Producto> PedidoCliente)
        {
            Productos = PedidoCliente;
              
        }
        
        public int CantidadArticulos
        {
            get { return Productos.Count; }
        }

        
        public decimal CalcularTotalFinal()
        {
            decimal totalSuma = 0;
            foreach (Producto item in Productos)
            {
             
                totalSuma += (decimal)item.Precio;
            }
            return totalSuma;
        }

       
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("=== RESTAURANTE ===");
            sb.AppendLine("TICKET DE COMPRA");
            sb.AppendLine("-------------------");

            // Imprimimos la lista de todo lo que pidieron
            foreach (Producto item in Productos)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("-------------------");
            sb.AppendLine($"Artículos totales: {CantidadArticulos}");
            sb.AppendLine($"TOTAL A PAGAR: ${CalcularTotalFinal()}");

            return sb.ToString();
        }


    }
}
