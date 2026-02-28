using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuForms
{
    public partial class Form1 : Form
    {
        List<Producto> PedidoActual = new List<Producto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flpComidas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BotonPlatillo_Click(object sender, EventArgs e)
        {
            // 1. Sabemos qué botón presionaron
            Button botonPresionado = (Button)sender;

            // 2. Sacamos los datos del platillo
            Producto platilloSeleccionado = (Producto)botonPresionado.Tag;

            // 3. Lo metemos a la orden de la mesa
            PedidoActual.Add(platilloSeleccionado);

            // 4. Lo imprimimos en tu nuevo ListBox
            lstCuenta.Items.Add($"- {platilloSeleccionado.Nombre} ... ${platilloSeleccionado.Precio}");


            decimal total = 0;
            foreach (Producto item in PedidoActual)
            {
                // Asegúrate de que el Precio en tu clase Producto sea de tipo decimal
                total += item.Precio;
            }

            lblTotal.Text = $"Total: ${total}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Producto> Menu = new List<Producto>();

            // 2. Agregamos los productos (Ojo a la letra 'm' en los precios)
            Menu.Add(new Producto { Nombre = "Tacos de Bistec", Categoria = "Comidas", Precio = 90.00m });
            Menu.Add(new Producto { Nombre = "Hamburguesa", Categoria = "Comidas", Precio = 120.00m });

            Menu.Add(new Producto { Nombre = "Refresco", Precio = 25.00m, Categoria = "Bebidas" });
            Menu.Add(new Producto { Nombre = "Cerveza", Precio = 45.00m, Categoria = "Bebidas" });

            Menu.Add(new Producto { Nombre = "Flan Napolitano", Precio = 40.00m, Categoria = "Postres" });
            Menu.Add(new Producto { Nombre = "Helado", Precio = 35.00m, Categoria = "Postres" });
            foreach (Producto platillo in Menu)
            {
                Button btnNuevo = new Button();
                btnNuevo.Text = $"{platillo.Nombre}\n${platillo.Precio}";
                btnNuevo.Size = new Size(110, 80);
                btnNuevo.BackColor = Color.LightSkyBlue;
                btnNuevo.Font = new Font("Segoe UI", 9, FontStyle.Bold);


                btnNuevo.Tag = platillo;

                // Le decimos qué va a pasar cuando le den clic
                btnNuevo.Click += BotonPlatillo_Click;

                // El Enrutador: ¿A qué pestaña mandamos este botón?
                if (platillo.Categoria == "Comidas")
                {
                    // Lo mandamos al panel de comidas, NO al tabControl
                    flpComidas.Controls.Add(btnNuevo);
                }
                else if (platillo.Categoria == "Bebidas")
                {
                    // Lo mandamos al panel de bebidas
                    flpBebidas.Controls.Add(btnNuevo);
                }
                else if (platillo.Categoria == "Postres")
                {
                    // Lo mandamos al panel de postres
                    flpPostres.Controls.Add(btnNuevo);
                }
        ;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Vender_Click(object sender, EventArgs e)
        {
            
            if (PedidoActual == null || PedidoActual.Count == 0)
            {
                MessageBox.Show("No hay productos en la orden.");
                return;
            }

            decimal total = PedidoActual.Where(p => p != null).Sum(p => p.Precio);

            MessageBox.Show($"¡Gracias por tu compra! Tu orden ha sido registrada.\nSu Total es: {total}");

          
            PedidoActual.Clear();
            lstCuenta.Items.Clear();
            lblTotal.Text = "Total: $0.00";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
