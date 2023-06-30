namespace Mantenedor_de_almacenamiento
{
    partial class FormSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalida));
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.txtIdSalida = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.txtProducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSalida = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAnula = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(177, 287);
            this.dtpSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(265, 22);
            this.dtpSalida.TabIndex = 12;
            // 
            // txtIdSalida
            // 
            this.txtIdSalida.BackColor = System.Drawing.Color.Orange;
            this.txtIdSalida.Location = new System.Drawing.Point(177, 39);
            this.txtIdSalida.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdSalida.Name = "txtIdSalida";
            this.txtIdSalida.Size = new System.Drawing.Size(156, 22);
            this.txtIdSalida.TabIndex = 11;
            this.txtIdSalida.TextChanged += new System.EventHandler(this.txtIdSalida_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.BackgroundImage = global::Mantenedor_de_almacenamiento.Properties.Resources.unnamed_removebg_preview1;
            this.btnAgregar.Location = new System.Drawing.Point(885, 482);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 55);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.BackgroundImage = global::Mantenedor_de_almacenamiento.Properties.Resources.unnamed_removebg_preview1;
            this.btnSalir.Location = new System.Drawing.Point(634, 257);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(142, 55);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cbDestino
            // 
            this.cbDestino.BackColor = System.Drawing.Color.Orange;
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(177, 192);
            this.cbDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(160, 24);
            this.cbDestino.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbProductos);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpSalida);
            this.groupBox1.Controls.Add(this.txtIdSalida);
            this.groupBox1.Controls.Add(this.cbDestino);
            this.groupBox1.Location = new System.Drawing.Point(13, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(613, 339);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Salida";
            // 
            // txtDoc
            // 
            this.txtDoc.BackColor = System.Drawing.Color.Orange;
            this.txtDoc.Location = new System.Drawing.Point(177, 245);
            this.txtDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(156, 22);
            this.txtDoc.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Documento de Salida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Destino:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.Orange;
            this.txtCantidad.Location = new System.Drawing.Point(177, 142);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(156, 22);
            this.txtCantidad.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cantidad a Salir:";
            // 
            // cbProductos
            // 
            this.cbProductos.BackColor = System.Drawing.Color.Orange;
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(177, 86);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(156, 24);
            this.cbProductos.TabIndex = 15;
            // 
            // txtProducto
            // 
            this.txtProducto.AutoSize = true;
            this.txtProducto.Location = new System.Drawing.Point(25, 89);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(64, 16);
            this.txtProducto.TabIndex = 14;
            this.txtProducto.Text = "Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id Salida:";
            // 
            // dgvSalida
            // 
            this.dgvSalida.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalida.Location = new System.Drawing.Point(13, 427);
            this.dgvSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSalida.Name = "dgvSalida";
            this.dgvSalida.RowHeadersWidth = 51;
            this.dgvSalida.Size = new System.Drawing.Size(864, 250);
            this.dgvSalida.TabIndex = 15;
            this.dgvSalida.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalida_CellContentDoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.BackgroundImage = global::Mantenedor_de_almacenamiento.Properties.Resources.unnamed_removebg_preview1;
            this.btnNuevo.Location = new System.Drawing.Point(634, 119);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(142, 57);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAnula
            // 
            this.btnAnula.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnula.BackgroundImage = global::Mantenedor_de_almacenamiento.Properties.Resources.unnamed_removebg_preview1;
            this.btnAnula.Location = new System.Drawing.Point(634, 188);
            this.btnAnula.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnula.Name = "btnAnula";
            this.btnAnula.Size = new System.Drawing.Size(142, 56);
            this.btnAnula.TabIndex = 17;
            this.btnAnula.Text = "Anula";
            this.btnAnula.UseVisualStyleBackColor = false;
            this.btnAnula.Click += new System.EventHandler(this.btnAnula_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResta.BackgroundImage = global::Mantenedor_de_almacenamiento.Properties.Resources.unnamed_removebg_preview1;
            this.btnResta.Location = new System.Drawing.Point(885, 545);
            this.btnResta.Margin = new System.Windows.Forms.Padding(4);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(142, 55);
            this.btnResta.TabIndex = 18;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // FormSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Mantenedor_de_almacenamiento.Properties.Resources.Form_Salidas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 741);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnAnula);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSalida);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSalida";
            this.Text = "FormSalida";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.TextBox txtIdSalida;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSalida;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAnula;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label txtProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label label5;
    }
}