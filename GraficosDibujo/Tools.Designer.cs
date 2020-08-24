namespace GraficosDibujo
{
    partial class Tools
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
            this.btnLinea = new System.Windows.Forms.Button();
            this.btnCurva = new System.Windows.Forms.Button();
            this.btnElipse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkCerrada = new System.Windows.Forms.CheckBox();
            this.BoundsPanel = new System.Windows.Forms.Panel();
            this.numericAlto = new System.Windows.Forms.NumericUpDown();
            this.numericAncho = new System.Windows.Forms.NumericUpDown();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.btnPoligono = new System.Windows.Forms.Button();
            this.colorLinea = new System.Windows.Forms.ColorDialog();
            this.chkRelleno = new System.Windows.Forms.CheckBox();
            this.colorRelleno = new System.Windows.Forms.ColorDialog();
            this.btnColorLinea = new System.Windows.Forms.Button();
            this.numericGrosor = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnBajar = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOcultar = new System.Windows.Forms.Button();
            this.BoundsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAlto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAncho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGrosor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLinea
            // 
            this.btnLinea.Location = new System.Drawing.Point(12, 12);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(63, 34);
            this.btnLinea.TabIndex = 0;
            this.btnLinea.Text = "Linea";
            this.btnLinea.UseVisualStyleBackColor = true;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // btnCurva
            // 
            this.btnCurva.Location = new System.Drawing.Point(81, 12);
            this.btnCurva.Name = "btnCurva";
            this.btnCurva.Size = new System.Drawing.Size(71, 34);
            this.btnCurva.TabIndex = 1;
            this.btnCurva.Text = "L. Curva";
            this.btnCurva.UseVisualStyleBackColor = true;
            this.btnCurva.Click += new System.EventHandler(this.btnCurva_Click);
            // 
            // btnElipse
            // 
            this.btnElipse.Location = new System.Drawing.Point(225, 12);
            this.btnElipse.Name = "btnElipse";
            this.btnElipse.Size = new System.Drawing.Size(61, 34);
            this.btnElipse.TabIndex = 2;
            this.btnElipse.Text = "Elipse";
            this.btnElipse.UseVisualStyleBackColor = true;
            this.btnElipse.Click += new System.EventHandler(this.btnElipse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ancho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Alto";
            // 
            // chkCerrada
            // 
            this.chkCerrada.AutoSize = true;
            this.chkCerrada.Enabled = false;
            this.chkCerrada.Location = new System.Drawing.Point(243, 64);
            this.chkCerrada.Name = "chkCerrada";
            this.chkCerrada.Size = new System.Drawing.Size(63, 17);
            this.chkCerrada.TabIndex = 13;
            this.chkCerrada.Text = "Cerrada";
            this.chkCerrada.UseVisualStyleBackColor = true;
            this.chkCerrada.CheckedChanged += new System.EventHandler(this.chkCerrada_CheckedChanged);
            // 
            // BoundsPanel
            // 
            this.BoundsPanel.Controls.Add(this.numericAlto);
            this.BoundsPanel.Controls.Add(this.numericAncho);
            this.BoundsPanel.Controls.Add(this.numericY);
            this.BoundsPanel.Controls.Add(this.numericX);
            this.BoundsPanel.Controls.Add(this.label4);
            this.BoundsPanel.Controls.Add(this.label1);
            this.BoundsPanel.Controls.Add(this.label2);
            this.BoundsPanel.Controls.Add(this.label3);
            this.BoundsPanel.Enabled = false;
            this.BoundsPanel.Location = new System.Drawing.Point(12, 130);
            this.BoundsPanel.Name = "BoundsPanel";
            this.BoundsPanel.Size = new System.Drawing.Size(165, 98);
            this.BoundsPanel.TabIndex = 14;
            // 
            // numericAlto
            // 
            this.numericAlto.Enabled = false;
            this.numericAlto.Location = new System.Drawing.Point(81, 64);
            this.numericAlto.Name = "numericAlto";
            this.numericAlto.Size = new System.Drawing.Size(59, 20);
            this.numericAlto.TabIndex = 22;
            this.numericAlto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAlto.ValueChanged += new System.EventHandler(this.numericAlto_ValueChanged);
            // 
            // numericAncho
            // 
            this.numericAncho.Enabled = false;
            this.numericAncho.Location = new System.Drawing.Point(4, 64);
            this.numericAncho.Name = "numericAncho";
            this.numericAncho.Size = new System.Drawing.Size(59, 20);
            this.numericAncho.TabIndex = 21;
            this.numericAncho.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAncho.ValueChanged += new System.EventHandler(this.numericAncho_ValueChanged);
            // 
            // numericY
            // 
            this.numericY.Enabled = false;
            this.numericY.Location = new System.Drawing.Point(81, 18);
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(59, 20);
            this.numericY.TabIndex = 20;
            this.numericY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericY.ValueChanged += new System.EventHandler(this.numericY_ValueChanged);
            // 
            // numericX
            // 
            this.numericX.Enabled = false;
            this.numericX.Location = new System.Drawing.Point(4, 18);
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(59, 20);
            this.numericX.TabIndex = 19;
            this.numericX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericX.ValueChanged += new System.EventHandler(this.numericX_ValueChanged);
            // 
            // btnPoligono
            // 
            this.btnPoligono.Location = new System.Drawing.Point(158, 12);
            this.btnPoligono.Name = "btnPoligono";
            this.btnPoligono.Size = new System.Drawing.Size(61, 34);
            this.btnPoligono.TabIndex = 15;
            this.btnPoligono.Text = "Poligono";
            this.btnPoligono.UseVisualStyleBackColor = true;
            this.btnPoligono.Click += new System.EventHandler(this.btnPoligono_Click);
            // 
            // chkRelleno
            // 
            this.chkRelleno.AutoSize = true;
            this.chkRelleno.Enabled = false;
            this.chkRelleno.Location = new System.Drawing.Point(243, 87);
            this.chkRelleno.Name = "chkRelleno";
            this.chkRelleno.Size = new System.Drawing.Size(62, 17);
            this.chkRelleno.TabIndex = 16;
            this.chkRelleno.Text = "Relleno";
            this.chkRelleno.UseVisualStyleBackColor = true;
            this.chkRelleno.CheckedChanged += new System.EventHandler(this.chkRelleno_CheckedChanged);
            // 
            // btnColorLinea
            // 
            this.btnColorLinea.Enabled = false;
            this.btnColorLinea.Location = new System.Drawing.Point(16, 90);
            this.btnColorLinea.Name = "btnColorLinea";
            this.btnColorLinea.Size = new System.Drawing.Size(164, 20);
            this.btnColorLinea.TabIndex = 17;
            this.btnColorLinea.Text = "Color Linea";
            this.btnColorLinea.UseVisualStyleBackColor = true;
            this.btnColorLinea.Click += new System.EventHandler(this.btnColorLinea_Click);
            // 
            // numericGrosor
            // 
            this.numericGrosor.Enabled = false;
            this.numericGrosor.Location = new System.Drawing.Point(57, 64);
            this.numericGrosor.Name = "numericGrosor";
            this.numericGrosor.Size = new System.Drawing.Size(120, 20);
            this.numericGrosor.TabIndex = 18;
            this.numericGrosor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericGrosor.ValueChanged += new System.EventHandler(this.numericGrosor_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(13, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Grosor";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(262, 493);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(44, 38);
            this.btnCargar.TabIndex = 29;
            this.btnCargar.Text = "Load";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(212, 492);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(44, 38);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Save";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 492);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(168, 34);
            this.btnRegresar.TabIndex = 27;
            this.btnRegresar.Text = "EliminarUltimo";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // btnBajar
            // 
            this.btnBajar.Location = new System.Drawing.Point(260, 329);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(44, 38);
            this.btnBajar.TabIndex = 33;
            this.btnBajar.Text = "Bajar";
            this.btnBajar.UseVisualStyleBackColor = true;
            this.btnBajar.Click += new System.EventHandler(this.btnBajar_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(261, 285);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(44, 38);
            this.btnSubir.TabIndex = 32;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 259);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(229, 180);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Figura";
            this.columnHeader1.Width = 71;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Linea";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Relleno";
            // 
            // btnOcultar
            // 
            this.btnOcultar.Location = new System.Drawing.Point(252, 373);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(59, 38);
            this.btnOcultar.TabIndex = 34;
            this.btnOcultar.Text = "Ocultar";
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 538);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.btnBajar);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericGrosor);
            this.Controls.Add(this.btnColorLinea);
            this.Controls.Add(this.chkRelleno);
            this.Controls.Add(this.btnPoligono);
            this.Controls.Add(this.BoundsPanel);
            this.Controls.Add(this.chkCerrada);
            this.Controls.Add(this.btnElipse);
            this.Controls.Add(this.btnCurva);
            this.Controls.Add(this.btnLinea);
            this.Name = "Tools";
            this.Text = "Tools";
            this.BoundsPanel.ResumeLayout(false);
            this.BoundsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAlto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAncho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGrosor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.Button btnCurva;
        private System.Windows.Forms.Button btnElipse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkCerrada;
        private System.Windows.Forms.Panel BoundsPanel;
        private System.Windows.Forms.Button btnPoligono;
        private System.Windows.Forms.ColorDialog colorLinea;
        private System.Windows.Forms.CheckBox chkRelleno;
        private System.Windows.Forms.ColorDialog colorRelleno;
        private System.Windows.Forms.Button btnColorLinea;
        private System.Windows.Forms.NumericUpDown numericGrosor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericAlto;
        private System.Windows.Forms.NumericUpDown numericAncho;
        private System.Windows.Forms.NumericUpDown numericY;
        private System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnBajar;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnOcultar;
    }
}