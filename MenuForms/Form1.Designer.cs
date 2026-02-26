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
            this.flpPostres = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flpComidas = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flpBebidas = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPostres.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpPostres
            // 
            this.flpPostres.AccessibleDescription = "";
            this.flpPostres.Controls.Add(this.tabPage1);
            this.flpPostres.Controls.Add(this.tabPage2);
            this.flpPostres.Controls.Add(this.tabPage3);
            this.flpPostres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPostres.Location = new System.Drawing.Point(0, 0);
            this.flpPostres.Name = "flpPostres";
            this.flpPostres.SelectedIndex = 0;
            this.flpPostres.Size = new System.Drawing.Size(800, 450);
            this.flpPostres.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flpComidas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Comidas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flpComidas
            // 
            this.flpComidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpComidas.Location = new System.Drawing.Point(3, 3);
            this.flpComidas.Name = "flpComidas";
            this.flpComidas.Size = new System.Drawing.Size(786, 418);
            this.flpComidas.TabIndex = 1;
            this.flpComidas.Paint += new System.Windows.Forms.PaintEventHandler(this.flpComidas_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flpBebidas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bebidas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flpBebidas
            // 
            this.flpBebidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBebidas.Location = new System.Drawing.Point(3, 3);
            this.flpBebidas.Name = "flpBebidas";
            this.flpBebidas.Size = new System.Drawing.Size(786, 418);
            this.flpBebidas.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Postre";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(7, 7);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(378, 245);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpPostres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flpPostres.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl flpPostres;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel flpComidas;
        private System.Windows.Forms.FlowLayoutPanel flpBebidas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}

