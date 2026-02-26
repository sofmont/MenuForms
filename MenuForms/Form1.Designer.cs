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
            this.tabBebidas = new System.Windows.Forms.TabPage();
            this.tabPostres = new System.Windows.Forms.TabPage();
            this.flpBebidas = new System.Windows.Forms.FlowLayoutPanel();
            this.flpComidas = new System.Windows.Forms.FlowLayoutPanel();
            this.tabComida = new System.Windows.Forms.TabPage();
            this.flpPostres = new System.Windows.Forms.FlowLayoutPanel();
            this.lstCuenta = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabBebidas.SuspendLayout();
            this.tabPostres.SuspendLayout();
            this.tabComida.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabComida);
            this.tabControl1.Controls.Add(this.tabBebidas);
            this.tabControl1.Controls.Add(this.tabPostres);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(405, 381);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBebidas
            // 
            this.tabBebidas.Controls.Add(this.flpBebidas);
            this.tabBebidas.Location = new System.Drawing.Point(4, 22);
            this.tabBebidas.Name = "tabBebidas";
            this.tabBebidas.Padding = new System.Windows.Forms.Padding(3);
            this.tabBebidas.Size = new System.Drawing.Size(397, 355);
            this.tabBebidas.TabIndex = 1;
            this.tabBebidas.Text = "Bebidas";
            this.tabBebidas.UseVisualStyleBackColor = true;
            // 
            // tabPostres
            // 
            this.tabPostres.Controls.Add(this.flpPostres);
            this.tabPostres.Location = new System.Drawing.Point(4, 22);
            this.tabPostres.Name = "tabPostres";
            this.tabPostres.Padding = new System.Windows.Forms.Padding(3);
            this.tabPostres.Size = new System.Drawing.Size(397, 355);
            this.tabPostres.TabIndex = 2;
            this.tabPostres.Text = "Postres";
            this.tabPostres.UseVisualStyleBackColor = true;
            // 
            // flpBebidas
            // 
            this.flpBebidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBebidas.Location = new System.Drawing.Point(3, 3);
            this.flpBebidas.Name = "flpBebidas";
            this.flpBebidas.Size = new System.Drawing.Size(391, 349);
            this.flpBebidas.TabIndex = 0;
            this.flpBebidas.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // flpComidas
            // 
            this.flpComidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpComidas.Location = new System.Drawing.Point(3, 3);
            this.flpComidas.Name = "flpComidas";
            this.flpComidas.Size = new System.Drawing.Size(391, 349);
            this.flpComidas.TabIndex = 0;
            this.flpComidas.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // tabComida
            // 
            this.tabComida.Controls.Add(this.flpComidas);
            this.tabComida.Location = new System.Drawing.Point(4, 22);
            this.tabComida.Name = "tabComida";
            this.tabComida.Padding = new System.Windows.Forms.Padding(3);
            this.tabComida.Size = new System.Drawing.Size(397, 355);
            this.tabComida.TabIndex = 0;
            this.tabComida.Text = "Comidas";
            this.tabComida.UseVisualStyleBackColor = true;
            // 
            // flpPostres
            // 
            this.flpPostres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPostres.ForeColor = System.Drawing.Color.Red;
            this.flpPostres.Location = new System.Drawing.Point(3, 3);
            this.flpPostres.Name = "flpPostres";
            this.flpPostres.Size = new System.Drawing.Size(391, 349);
            this.flpPostres.TabIndex = 0;
            // 
            // lstCuenta
            // 
            this.lstCuenta.FormattingEnabled = true;
            this.lstCuenta.Location = new System.Drawing.Point(467, 78);
            this.lstCuenta.Name = "lstCuenta";
            this.lstCuenta.Size = new System.Drawing.Size(199, 95);
            this.lstCuenta.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(464, 189);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 461);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstCuenta);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBebidas.ResumeLayout(false);
            this.tabPostres.ResumeLayout(false);
            this.tabComida.ResumeLayout(false);
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
    }
}

