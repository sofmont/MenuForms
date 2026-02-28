namespace MenuForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabComida = new System.Windows.Forms.TabPage();
            this.flpComidas = new System.Windows.Forms.FlowLayoutPanel();
            this.tabBebidas = new System.Windows.Forms.TabPage();
            this.flpBebidas = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPostres = new System.Windows.Forms.TabPage();
            this.flpPostres = new System.Windows.Forms.FlowLayoutPanel();
            this.lstCuenta = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Vender = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabComida.SuspendLayout();
            this.tabBebidas.SuspendLayout();
            this.tabPostres.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabComida);
            this.tabControl1.Controls.Add(this.tabBebidas);
            this.tabControl1.Controls.Add(this.tabPostres);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(405, 338);
            this.tabControl1.TabIndex = 0;
            // 
            // tabComida
            // 
            this.tabComida.Controls.Add(this.flpComidas);
            this.tabComida.Location = new System.Drawing.Point(4, 34);
            this.tabComida.Name = "tabComida";
            this.tabComida.Padding = new System.Windows.Forms.Padding(3);
            this.tabComida.Size = new System.Drawing.Size(397, 300);
            this.tabComida.TabIndex = 0;
            this.tabComida.Text = "Comidas";
            this.tabComida.UseVisualStyleBackColor = true;
            // 
            // flpComidas
            // 
            this.flpComidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpComidas.Location = new System.Drawing.Point(3, 3);
            this.flpComidas.Name = "flpComidas";
            this.flpComidas.Size = new System.Drawing.Size(391, 294);
            this.flpComidas.TabIndex = 0;
            this.flpComidas.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // tabBebidas
            // 
            this.tabBebidas.Controls.Add(this.flpBebidas);
            this.tabBebidas.Location = new System.Drawing.Point(4, 22);
            this.tabBebidas.Name = "tabBebidas";
            this.tabBebidas.Padding = new System.Windows.Forms.Padding(3);
            this.tabBebidas.Size = new System.Drawing.Size(397, 312);
            this.tabBebidas.TabIndex = 1;
            this.tabBebidas.Text = "Bebidas";
            this.tabBebidas.UseVisualStyleBackColor = true;
            // 
            // flpBebidas
            // 
            this.flpBebidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBebidas.Location = new System.Drawing.Point(3, 3);
            this.flpBebidas.Name = "flpBebidas";
            this.flpBebidas.Size = new System.Drawing.Size(391, 306);
            this.flpBebidas.TabIndex = 0;
            this.flpBebidas.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // tabPostres
            // 
            this.tabPostres.Controls.Add(this.flpPostres);
            this.tabPostres.Location = new System.Drawing.Point(4, 22);
            this.tabPostres.Name = "tabPostres";
            this.tabPostres.Padding = new System.Windows.Forms.Padding(3);
            this.tabPostres.Size = new System.Drawing.Size(397, 312);
            this.tabPostres.TabIndex = 2;
            this.tabPostres.Text = "Postres";
            this.tabPostres.UseVisualStyleBackColor = true;
            // 
            // flpPostres
            // 
            this.flpPostres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPostres.ForeColor = System.Drawing.Color.Black;
            this.flpPostres.Location = new System.Drawing.Point(3, 3);
            this.flpPostres.Name = "flpPostres";
            this.flpPostres.Size = new System.Drawing.Size(391, 306);
            this.flpPostres.TabIndex = 0;
            // 
            // lstCuenta
            // 
            this.lstCuenta.FormattingEnabled = true;
            this.lstCuenta.Location = new System.Drawing.Point(467, 93);
            this.lstCuenta.Name = "lstCuenta";
            this.lstCuenta.Size = new System.Drawing.Size(199, 95);
            this.lstCuenta.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(464, 191);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 2;
            // 
            // Vender
            // 
            this.Vender.BackColor = System.Drawing.Color.Lime;
            this.Vender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vender.ForeColor = System.Drawing.Color.Black;
            this.Vender.Location = new System.Drawing.Point(488, 247);
            this.Vender.Name = "Vender";
            this.Vender.Size = new System.Drawing.Size(158, 42);
            this.Vender.TabIndex = 3;
            this.Vender.Text = "Hacer Venta";
            this.Vender.UseVisualStyleBackColor = false;
            this.Vender.Click += new System.EventHandler(this.Vender_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(678, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vender);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstCuenta);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabComida.ResumeLayout(false);
            this.tabBebidas.ResumeLayout(false);
            this.tabPostres.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBebidas;
        private System.Windows.Forms.TabPage tabPostres;
        private System.Windows.Forms.TabPage tabComida;
        private System.Windows.Forms.FlowLayoutPanel flpComidas;
        private System.Windows.Forms.FlowLayoutPanel flpBebidas;
        private System.Windows.Forms.FlowLayoutPanel flpPostres;
        private System.Windows.Forms.ListBox lstCuenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button Vender;
        private System.Windows.Forms.Label label1;
    }
}

