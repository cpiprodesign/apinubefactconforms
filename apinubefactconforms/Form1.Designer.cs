
namespace apinubefactconforms
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtunidad = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcandidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvalorunitario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpreciounitario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttipoigv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtigv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtanticipo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txttipocomprobante = new System.Windows.Forms.Label();
            this.txtJsonOutput = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorunitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciounitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoigv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "unidad";
            // 
            // txtunidad
            // 
            this.txtunidad.Location = new System.Drawing.Point(94, 6);
            this.txtunidad.Name = "txtunidad";
            this.txtunidad.Size = new System.Drawing.Size(100, 20);
            this.txtunidad.TabIndex = 1;
            this.txtunidad.Text = "NIU";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(256, 6);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 3;
            this.txtcodigo.Text = "001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "codigo";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(94, 32);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(262, 20);
            this.txtdescripcion.TabIndex = 5;
            this.txtdescripcion.Text = "laptop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "descripcion";
            // 
            // txtcandidad
            // 
            this.txtcandidad.Location = new System.Drawing.Point(94, 58);
            this.txtcandidad.Name = "txtcandidad";
            this.txtcandidad.Size = new System.Drawing.Size(93, 20);
            this.txtcandidad.TabIndex = 7;
            this.txtcandidad.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "cantidad";
            // 
            // txtvalorunitario
            // 
            this.txtvalorunitario.Location = new System.Drawing.Point(266, 58);
            this.txtvalorunitario.Name = "txtvalorunitario";
            this.txtvalorunitario.Size = new System.Drawing.Size(90, 20);
            this.txtvalorunitario.TabIndex = 9;
            this.txtvalorunitario.Text = "500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "valor unitario";
            // 
            // txtpreciounitario
            // 
            this.txtpreciounitario.Location = new System.Drawing.Point(94, 84);
            this.txtpreciounitario.Name = "txtpreciounitario";
            this.txtpreciounitario.Size = new System.Drawing.Size(90, 20);
            this.txtpreciounitario.TabIndex = 11;
            this.txtpreciounitario.Text = "590";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "precio unitario";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(94, 110);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(90, 20);
            this.txtsubtotal.TabIndex = 13;
            this.txtsubtotal.Text = "500";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sub total";
            // 
            // txttipoigv
            // 
            this.txttipoigv.Location = new System.Drawing.Point(266, 110);
            this.txttipoigv.Name = "txttipoigv";
            this.txttipoigv.Size = new System.Drawing.Size(90, 20);
            this.txttipoigv.TabIndex = 15;
            this.txttipoigv.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tipo de igv";
            // 
            // txtigv
            // 
            this.txtigv.Location = new System.Drawing.Point(94, 136);
            this.txtigv.Name = "txtigv";
            this.txtigv.Size = new System.Drawing.Size(90, 20);
            this.txtigv.TabIndex = 17;
            this.txtigv.Text = "90";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "igv";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(266, 136);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(90, 20);
            this.txttotal.TabIndex = 19;
            this.txttotal.Text = "590";
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = " total";
            // 
            // txtanticipo
            // 
            this.txtanticipo.Location = new System.Drawing.Point(94, 162);
            this.txtanticipo.Name = "txtanticipo";
            this.txtanticipo.Size = new System.Drawing.Size(90, 20);
            this.txtanticipo.TabIndex = 21;
            this.txtanticipo.Text = "false";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Anticipo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Additem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(30, 242);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(272, 95);
            this.lstItems.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "generar factura";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(514, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "NIU";
            // 
            // txttipocomprobante
            // 
            this.txttipocomprobante.AutoSize = true;
            this.txttipocomprobante.Location = new System.Drawing.Point(426, 13);
            this.txttipocomprobante.Name = "txttipocomprobante";
            this.txttipocomprobante.Size = new System.Drawing.Size(69, 13);
            this.txttipocomprobante.TabIndex = 26;
            this.txttipocomprobante.Text = "comprobante";
            // 
            // txtJsonOutput
            // 
            this.txtJsonOutput.Location = new System.Drawing.Point(429, 102);
            this.txtJsonOutput.Multiline = true;
            this.txtJsonOutput.Name = "txtJsonOutput";
            this.txtJsonOutput.Size = new System.Drawing.Size(221, 64);
            this.txtJsonOutput.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Enviar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(419, 193);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(304, 103);
            this.txtOutput.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnidadMedida,
            this.codigo,
            this.descripcion,
            this.cantidad,
            this.valorunitario,
            this.preciounitario,
            this.subtotal,
            this.tipoigv,
            this.igv,
            this.total});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 364);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(807, 159);
            this.dataGridView1.TabIndex = 31;
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.HeaderText = "unidadmedida";
            this.UnidadMedida.Name = "UnidadMedida";
            // 
            // codigo
            // 
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // valorunitario
            // 
            this.valorunitario.HeaderText = "valorunitario";
            this.valorunitario.Name = "valorunitario";
            // 
            // preciounitario
            // 
            this.preciounitario.HeaderText = "preciounitario";
            this.preciounitario.Name = "preciounitario";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "subtotal";
            this.subtotal.Name = "subtotal";
            // 
            // tipoigv
            // 
            this.tipoigv.HeaderText = "tipoigv";
            this.tipoigv.Name = "tipoigv";
            // 
            // igv
            // 
            this.igv.HeaderText = "igv";
            this.igv.Name = "igv";
            // 
            // total
            // 
            this.total.HeaderText = "total";
            this.total.Name = "total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 523);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtJsonOutput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txttipocomprobante);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtanticipo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtigv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txttipoigv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtpreciounitario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtvalorunitario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcandidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtunidad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtunidad;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcandidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtvalorunitario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpreciounitario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttipoigv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtigv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtanticipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txttipocomprobante;
        private System.Windows.Forms.TextBox txtJsonOutput;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorunitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciounitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoigv;
        private System.Windows.Forms.DataGridViewTextBoxColumn igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}

