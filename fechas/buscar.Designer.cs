namespace fechas
{
    partial class buscar
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
            this.btbuscarr = new System.Windows.Forms.Button();
            this.txtnomcompr = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnfvacio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpfhasta = new System.Windows.Forms.DateTimePicker();
            this.dtpfdesde = new System.Windows.Forms.DateTimePicker();
            this.dtpfnulos = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btbuscarr
            // 
            this.btbuscarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbuscarr.Location = new System.Drawing.Point(689, 12);
            this.btbuscarr.Name = "btbuscarr";
            this.btbuscarr.Size = new System.Drawing.Size(108, 58);
            this.btbuscarr.TabIndex = 0;
            this.btbuscarr.Text = "Buscar";
            this.btbuscarr.UseVisualStyleBackColor = true;
            this.btbuscarr.Click += new System.EventHandler(this.btbuscarr_Click);
            // 
            // txtnomcompr
            // 
            this.txtnomcompr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomcompr.Location = new System.Drawing.Point(155, 28);
            this.txtnomcompr.Name = "txtnomcompr";
            this.txtnomcompr.Size = new System.Drawing.Size(121, 26);
            this.txtnomcompr.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(155, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 304);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(12, 513);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(84, 34);
            this.btnaceptar.TabIndex = 3;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(745, 513);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(84, 34);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnfvacio
            // 
            this.btnfvacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfvacio.Location = new System.Drawing.Point(12, 111);
            this.btnfvacio.Name = "btnfvacio";
            this.btnfvacio.Size = new System.Drawing.Size(125, 58);
            this.btnfvacio.TabIndex = 5;
            this.btnfvacio.Text = "Compromisos impagos";
            this.btnfvacio.UseVisualStyleBackColor = true;
            this.btnfvacio.Click += new System.EventHandler(this.btnfvacio_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Nombre del compromiso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpfhasta
            // 
            this.dtpfhasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfhasta.Location = new System.Drawing.Point(494, 143);
            this.dtpfhasta.Name = "dtpfhasta";
            this.dtpfhasta.Size = new System.Drawing.Size(303, 26);
            this.dtpfhasta.TabIndex = 8;
            this.dtpfhasta.ValueChanged += new System.EventHandler(this.dtpfhasta_ValueChanged);
            // 
            // dtpfdesde
            // 
            this.dtpfdesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfdesde.Location = new System.Drawing.Point(494, 93);
            this.dtpfdesde.Name = "dtpfdesde";
            this.dtpfdesde.Size = new System.Drawing.Size(303, 26);
            this.dtpfdesde.TabIndex = 9;
            this.dtpfdesde.ValueChanged += new System.EventHandler(this.fdesde_ValueChanged);
            // 
            // dtpfnulos
            // 
            this.dtpfnulos.CustomFormat = " ";
            this.dtpfnulos.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfnulos.Location = new System.Drawing.Point(800, 211);
            this.dtpfnulos.Name = "dtpfnulos";
            this.dtpfnulos.Size = new System.Drawing.Size(29, 20);
            this.dtpfnulos.TabIndex = 10;
            this.dtpfnulos.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hasta";
            this.label2.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 56);
            this.button2.TabIndex = 13;
            this.button2.Text = "reporte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 559);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpfnulos);
            this.Controls.Add(this.dtpfdesde);
            this.Controls.Add(this.dtpfhasta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnfvacio);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtnomcompr);
            this.Controls.Add(this.btbuscarr);
            this.Name = "buscar";
            this.Text = "buscar";
            this.Load += new System.EventHandler(this.buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbuscarr;
        private System.Windows.Forms.TextBox txtnomcompr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnfvacio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpfhasta;
        private System.Windows.Forms.DateTimePicker dtpfdesde;
        private System.Windows.Forms.DateTimePicker dtpfnulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}