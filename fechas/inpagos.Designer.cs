namespace fechas
{
    partial class inpagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inpagos));
            this.btnpagar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtforpago = new System.Windows.Forms.ComboBox();
            this.txtinplazo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfdecaducidad = new System.Windows.Forms.DateTimePicker();
            this.txtfpago = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtinpago = new System.Windows.Forms.TextBox();
            this.lbcompromiso = new System.Windows.Forms.Label();
            this.lbcuota = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpagar
            // 
            this.btnpagar.Location = new System.Drawing.Point(666, 359);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(74, 53);
            this.btnpagar.TabIndex = 0;
            this.btnpagar.Text = "Pagar";
            this.btnpagar.UseVisualStyleBackColor = true;
            this.btnpagar.Click += new System.EventHandler(this.btnpagar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 53);
            this.button2.TabIndex = 11;
            this.button2.Text = "Selecionar Compromiso";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtforpago
            // 
            this.txtforpago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtforpago.FormattingEnabled = true;
            this.txtforpago.Location = new System.Drawing.Point(156, 225);
            this.txtforpago.Name = "txtforpago";
            this.txtforpago.Size = new System.Drawing.Size(121, 21);
            this.txtforpago.TabIndex = 57;
            // 
            // txtinplazo
            // 
            this.txtinplazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtinplazo.FormattingEnabled = true;
            this.txtinplazo.Location = new System.Drawing.Point(157, 73);
            this.txtinplazo.Name = "txtinplazo";
            this.txtinplazo.Size = new System.Drawing.Size(121, 21);
            this.txtinplazo.TabIndex = 56;
            this.txtinplazo.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Forma de pago:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Valor de cuota:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Fecha de caducidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Fecha de plazo:";
            this.label3.Visible = false;
            // 
            // txtfdecaducidad
            // 
            this.txtfdecaducidad.CustomFormat = " ";
            this.txtfdecaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfdecaducidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtfdecaducidad.Location = new System.Drawing.Point(157, 122);
            this.txtfdecaducidad.Name = "txtfdecaducidad";
            this.txtfdecaducidad.Size = new System.Drawing.Size(121, 20);
            this.txtfdecaducidad.TabIndex = 49;
            // 
            // txtfpago
            // 
            this.txtfpago.CustomFormat = " ";
            this.txtfpago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfpago.Location = new System.Drawing.Point(156, 275);
            this.txtfpago.Name = "txtfpago";
            this.txtfpago.Size = new System.Drawing.Size(121, 20);
            this.txtfpago.TabIndex = 48;
            this.txtfpago.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nombre del compromiso:";
            // 
            // txtinpago
            // 
            this.txtinpago.Location = new System.Drawing.Point(156, 176);
            this.txtinpago.Name = "txtinpago";
            this.txtinpago.Size = new System.Drawing.Size(121, 20);
            this.txtinpago.TabIndex = 45;
            this.txtinpago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbcompromiso
            // 
            this.lbcompromiso.AutoSize = true;
            this.lbcompromiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcompromiso.Location = new System.Drawing.Point(225, 29);
            this.lbcompromiso.Name = "lbcompromiso";
            this.lbcompromiso.Size = new System.Drawing.Size(12, 16);
            this.lbcompromiso.TabIndex = 58;
            this.lbcompromiso.Text = " ";
            // 
            // lbcuota
            // 
            this.lbcuota.AutoSize = true;
            this.lbcuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcuota.Location = new System.Drawing.Point(532, 29);
            this.lbcuota.Name = "lbcuota";
            this.lbcuota.Size = new System.Drawing.Size(0, 16);
            this.lbcuota.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 53);
            this.button1.TabIndex = 60;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(657, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 82);
            this.button3.TabIndex = 61;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // inpagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 424);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbcuota);
            this.Controls.Add(this.lbcompromiso);
            this.Controls.Add(this.txtforpago);
            this.Controls.Add(this.txtinplazo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfdecaducidad);
            this.Controls.Add(this.txtfpago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtinpago);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnpagar);
            this.Name = "inpagos";
            this.Text = "inpagos";
            this.Load += new System.EventHandler(this.inpagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpagar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox txtforpago;
        private System.Windows.Forms.ComboBox txtinplazo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtfdecaducidad;
        private System.Windows.Forms.DateTimePicker txtfpago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtinpago;
        private System.Windows.Forms.Label lbcompromiso;
        private System.Windows.Forms.Label lbcuota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}