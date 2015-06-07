namespace PicaPollo
{
    partial class Productos
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.bAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombreProd = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProductos.Location = new System.Drawing.Point(0, 221);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(746, 163);
            this.dgvProductos.TabIndex = 0;
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(507, 157);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(207, 46);
            this.bAgregar.TabIndex = 1;
            this.bAgregar.Text = "Agregar Producto";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del Producto";
            // 
            // tbNombreProd
            // 
            this.tbNombreProd.Location = new System.Drawing.Point(473, 48);
            this.tbNombreProd.Name = "tbNombreProd";
            this.tbNombreProd.Size = new System.Drawing.Size(241, 20);
            this.tbNombreProd.TabIndex = 3;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(473, 83);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(241, 20);
            this.tbPrecio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio por Unidad/Libra";
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(12, 157);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(195, 46);
            this.bEliminar.TabIndex = 6;
            this.bEliminar.Text = "Eliminar Producto";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 384);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombreProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.dgvProductos);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombreProd;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bEliminar;
    }
}