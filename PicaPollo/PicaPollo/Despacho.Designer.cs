﻿namespace PicaPollo
{
    partial class Despacho
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
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.bFacturar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.gbFacturacion = new System.Windows.Forms.GroupBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bAgregarCodigo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCajero = new System.Windows.Forms.ComboBox();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.gbFacturacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AllowUserToDeleteRows = false;
            this.dgvFactura.AllowUserToResizeColumns = false;
            this.dgvFactura.AllowUserToResizeRows = false;
            this.dgvFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.Total});
            this.dgvFactura.Location = new System.Drawing.Point(230, 19);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvFactura.Size = new System.Drawing.Size(534, 229);
            this.dgvFactura.TabIndex = 0;
            this.dgvFactura.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellValidated);
            this.dgvFactura.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_RowLeave);
            this.dgvFactura.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_RowLeave);
            this.dgvFactura.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvFactura_RowsAdded);
            this.dgvFactura.Validated += new System.EventHandler(this.dgvFactura_Validated);
            // 
            // bFacturar
            // 
            this.bFacturar.Location = new System.Drawing.Point(579, 278);
            this.bFacturar.Name = "bFacturar";
            this.bFacturar.Size = new System.Drawing.Size(187, 44);
            this.bFacturar.TabIndex = 1;
            this.bFacturar.Text = "Facturar";
            this.bFacturar.UseVisualStyleBackColor = true;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(384, 278);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(189, 44);
            this.bLimpiar.TabIndex = 2;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            // 
            // gbFacturacion
            // 
            this.gbFacturacion.Controls.Add(this.tbTotal);
            this.gbFacturacion.Controls.Add(this.label3);
            this.gbFacturacion.Controls.Add(this.bBuscar);
            this.gbFacturacion.Controls.Add(this.bAgregarCodigo);
            this.gbFacturacion.Controls.Add(this.label2);
            this.gbFacturacion.Controls.Add(this.tbCodigo);
            this.gbFacturacion.Controls.Add(this.dgvFactura);
            this.gbFacturacion.Controls.Add(this.bLimpiar);
            this.gbFacturacion.Controls.Add(this.bFacturar);
            this.gbFacturacion.Enabled = false;
            this.gbFacturacion.Location = new System.Drawing.Point(12, 58);
            this.gbFacturacion.Name = "gbFacturacion";
            this.gbFacturacion.Size = new System.Drawing.Size(772, 328);
            this.gbFacturacion.TabIndex = 3;
            this.gbFacturacion.TabStop = false;
            this.gbFacturacion.Text = "Facturas";
            // 
            // tbTotal
            // 
            this.tbTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbTotal.Location = new System.Drawing.Point(623, 248);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(141, 20);
            this.tbTotal.TabIndex = 8;
            this.tbTotal.Text = "0.00";
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total";
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(23, 171);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(181, 151);
            this.bBuscar.TabIndex = 6;
            this.bBuscar.Text = "Buscar un Producto";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // bAgregarCodigo
            // 
            this.bAgregarCodigo.Location = new System.Drawing.Point(129, 92);
            this.bAgregarCodigo.Name = "bAgregarCodigo";
            this.bAgregarCodigo.Size = new System.Drawing.Size(75, 23);
            this.bAgregarCodigo.TabIndex = 5;
            this.bAgregarCodigo.Text = "Agregar";
            this.bAgregarCodigo.UseVisualStyleBackColor = true;
            this.bAgregarCodigo.Click += new System.EventHandler(this.bAgregarCodigo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(23, 92);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cajero";
            // 
            // cbCajero
            // 
            this.cbCajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCajero.FormattingEnabled = true;
            this.cbCajero.Location = new System.Drawing.Point(187, 22);
            this.cbCajero.Name = "cbCajero";
            this.cbCajero.Size = new System.Drawing.Size(121, 21);
            this.cbCajero.TabIndex = 5;
            this.cbCajero.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "Id";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Width = 30;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 225;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 65;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 70;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Despacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 398);
            this.Controls.Add(this.cbCajero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbFacturacion);
            this.Name = "Despacho";
            this.Text = "Despacho";
            this.Load += new System.EventHandler(this.Despacho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.gbFacturacion.ResumeLayout(false);
            this.gbFacturacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Button bFacturar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.GroupBox gbFacturacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCajero;
        private System.Windows.Forms.Button bAgregarCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}