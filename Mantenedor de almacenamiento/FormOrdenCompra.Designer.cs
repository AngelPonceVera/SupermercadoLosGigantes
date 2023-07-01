namespace Mantenedor_de_almacenamiento
{
    partial class FormOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenCompra));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.txtCotizacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpOrden = new System.Windows.Forms.DateTimePicker();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAnula = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarReq = new System.Windows.Forms.Button();
            this.txtRequerimiento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.dgvOrdenCompra = new System.Windows.Forms.DataGridView();
            this.gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro Orden de Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Orden de Compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nro de Cotizacion:";
            // 
            // txtOrden
            // 
            this.txtOrden.BackColor = System.Drawing.Color.Orange;
            this.txtOrden.Location = new System.Drawing.Point(224, 37);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(250, 22);
            this.txtOrden.TabIndex = 3;
            // 
            // txtCotizacion
            // 
            this.txtCotizacion.BackColor = System.Drawing.Color.Orange;
            this.txtCotizacion.Location = new System.Drawing.Point(225, 158);
            this.txtCotizacion.Name = "txtCotizacion";
            this.txtCotizacion.Size = new System.Drawing.Size(249, 22);
            this.txtCotizacion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Proveedor:";
            // 
            // dtpOrden
            // 
            this.dtpOrden.Location = new System.Drawing.Point(225, 97);
            this.dtpOrden.Name = "dtpOrden";
            this.dtpOrden.Size = new System.Drawing.Size(249, 22);
            this.dtpOrden.TabIndex = 7;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.BackgroundImage = global::Mantenedor_de_almacenamiento.Properties.Resources.unnamed_removebg_preview1;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(627, 186);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(143, 54);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAnula
            // 
            this.btnAnula.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnula.BackgroundImage = global::Mantenedor_de_almacenamiento.Properties.Resources.unnamed_removebg_preview1;
            this.btnAnula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnula.Location = new System.Drawing.Point(627, 246);
            this.btnAnula.Name = "btnAnula";
            this.btnAnula.Size = new System.Drawing.Size(143, 55);
            this.btnAnula.TabIndex = 10;
            this.btnAnula.Text = "Anula";
            this.btnAnula.UseVisualStyleBackColor = false;
            this.btnAnula.Click += new System.EventHandler(this.btnAnula_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.BackgroundImage = global::Mantenedor_de_almacenamiento.Properties.Resources.unnamed_removebg_preview1;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(627, 307);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(143, 56);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.cbProveedor);
            this.gbDetalle.Controls.Add(this.txtCantidad);
            this.gbDetalle.Controls.Add(this.label7);
            this.gbDetalle.Controls.Add(this.txtProducto);
            this.gbDetalle.Controls.Add(this.label6);
            this.gbDetalle.Controls.Add(this.btnBuscarReq);
            this.gbDetalle.Controls.Add(this.txtRequerimiento);
            this.gbDetalle.Controls.Add(this.label5);
            this.gbDetalle.Controls.Add(this.txtCotizacion);
            this.gbDetalle.Controls.Add(this.dtpOrden);
            this.gbDetalle.Controls.Add(this.label1);
            this.gbDetalle.Controls.Add(this.label4);
            this.gbDetalle.Controls.Add(this.label2);
            this.gbDetalle.Controls.Add(this.label3);
            this.gbDetalle.Controls.Add(this.txtOrden);
            this.gbDetalle.Location = new System.Drawing.Point(12, 105);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(609, 411);
            this.gbDetalle.TabIndex = 12;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle de Orden Compra";
//            this.gbDetalle.Enter += new System.EventHandler(this.gbDetalle_Enter);
            // 
            // cbProveedor
            // 
            this.cbProveedor.BackColor = System.Drawing.Color.Orange;
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(224, 218);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(250, 24);
            this.cbProveedor.TabIndex = 16;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtCantidad.Location = new System.Drawing.Point(410, 354);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(179, 22);
            this.txtCantidad.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(324, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cantidad:";
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtProducto.Location = new System.Drawing.Point(105, 354);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(179, 22);
            this.txtProducto.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Producto:";
            // 
            // btnBuscarReq
            // 
            this.btnBuscarReq.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarReq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarReq.Location = new System.Drawing.Point(472, 288);
            this.btnBuscarReq.Name = "btnBuscarReq";
            this.btnBuscarReq.Size = new System.Drawing.Size(102, 34);
            this.btnBuscarReq.TabIndex = 13;
            this.btnBuscarReq.Text = "Buscar";
            this.btnBuscarReq.UseVisualStyleBackColor = false;
            this.btnBuscarReq.Click += new System.EventHandler(this.btnBuscarReq_Click);
            // 
            // txtRequerimiento
            // 
            this.txtRequerimiento.BackColor = System.Drawing.Color.Orange;
            this.txtRequerimiento.Location = new System.Drawing.Point(202, 294);
            this.txtRequerimiento.Name = "txtRequerimiento";
            this.txtRequerimiento.Size = new System.Drawing.Size(250, 22);
            this.txtRequerimiento.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nro Requerimiento:";
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuma.BackgroundImage = global::Mantenedor_de_almacenamiento.Properties.Resources.unnamed_removebg_preview1;
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(828, 594);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(143, 56);
            this.btnSuma.TabIndex = 13;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResta.BackgroundImage = global::Mantenedor_de_almacenamiento.Properties.Resources.unnamed_removebg_preview1;
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(828, 656);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(143, 56);
            this.btnResta.TabIndex = 14;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // dgvOrdenCompra
            // 
            this.dgvOrdenCompra.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenCompra.Location = new System.Drawing.Point(12, 522);
            this.dgvOrdenCompra.Name = "dgvOrdenCompra";
            this.dgvOrdenCompra.RowHeadersWidth = 51;
            this.dgvOrdenCompra.RowTemplate.Height = 24;
            this.dgvOrdenCompra.Size = new System.Drawing.Size(810, 284);
            this.dgvOrdenCompra.TabIndex = 15;
            this.dgvOrdenCompra.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenCompra_CellContentDoubleClick);
            // 
            // FormOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Mantenedor_de_almacenamiento.Properties.Resources.Form_Compras;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 872);
            this.Controls.Add(this.dgvOrdenCompra);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAnula);
            this.Controls.Add(this.btnNuevo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrdenCompra";
            this.Text = "FormOrdenCompra";
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.TextBox txtCotizacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpOrden;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAnula;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarReq;
        private System.Windows.Forms.TextBox txtRequerimiento;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.DataGridView dgvOrdenCompra;
        private System.Windows.Forms.ComboBox cbProveedor;
    }
}