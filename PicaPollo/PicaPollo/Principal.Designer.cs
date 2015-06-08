namespace PicaPollo
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarOQuitarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarOQuitarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despacharMercancíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarOQuitarProductosToolStripMenuItem,
            this.agregarOQuitarEmpleadosToolStripMenuItem,
            this.despacharMercancíaToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // agregarOQuitarProductosToolStripMenuItem
            // 
            this.agregarOQuitarProductosToolStripMenuItem.Name = "agregarOQuitarProductosToolStripMenuItem";
            this.agregarOQuitarProductosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.agregarOQuitarProductosToolStripMenuItem.Text = "Agregar o Quitar Productos";
            this.agregarOQuitarProductosToolStripMenuItem.Click += new System.EventHandler(this.agregarOQuitarProductosToolStripMenuItem_Click);
            // 
            // agregarOQuitarEmpleadosToolStripMenuItem
            // 
            this.agregarOQuitarEmpleadosToolStripMenuItem.Name = "agregarOQuitarEmpleadosToolStripMenuItem";
            this.agregarOQuitarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.agregarOQuitarEmpleadosToolStripMenuItem.Text = "Agregar o Quitar Empleados";
            this.agregarOQuitarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.agregarOQuitarEmpleadosToolStripMenuItem_Click);
            // 
            // despacharMercancíaToolStripMenuItem
            // 
            this.despacharMercancíaToolStripMenuItem.Name = "despacharMercancíaToolStripMenuItem";
            this.despacharMercancíaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.despacharMercancíaToolStripMenuItem.Text = "Despachar Mercancía";
            this.despacharMercancíaToolStripMenuItem.Click += new System.EventHandler(this.despacharMercancíaToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 311);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "PicaPollo X Project";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarOQuitarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarOQuitarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despacharMercancíaToolStripMenuItem;
    }
}

