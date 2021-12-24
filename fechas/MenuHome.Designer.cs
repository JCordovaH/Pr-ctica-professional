namespace fechas
{
    partial class MenuHome
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuinfo = new System.Windows.Forms.ToolStrip();
            this.lbuserr = new System.Windows.Forms.ToolStripLabel();
            this.lbfecha = new System.Windows.Forms.ToolStripLabel();
            this.lbhora = new System.Windows.Forms.ToolStripLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.lbtestusu = new System.Windows.Forms.Label();
            this.menuinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 103);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ingresar Fechas de los compromisos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 84);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ingresar Compromisos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuinfo
            // 
            this.menuinfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbuserr,
            this.lbfecha,
            this.lbhora});
            this.menuinfo.Location = new System.Drawing.Point(0, 0);
            this.menuinfo.Name = "menuinfo";
            this.menuinfo.Size = new System.Drawing.Size(538, 25);
            this.menuinfo.TabIndex = 2;
            this.menuinfo.Text = "toolStrip1";
            // 
            // lbuserr
            // 
            this.lbuserr.Name = "lbuserr";
            this.lbuserr.Size = new System.Drawing.Size(86, 22);
            this.lbuserr.Text = "toolStripLabel1";
            // 
            // lbfecha
            // 
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(86, 22);
            this.lbfecha.Text = "toolStripLabel1";
            // 
            // lbhora
            // 
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(86, 22);
            this.lbhora.Text = "toolStripLabel2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(418, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "cerrar seccion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbtestusu
            // 
            this.lbtestusu.AutoSize = true;
            this.lbtestusu.Location = new System.Drawing.Point(23, 48);
            this.lbtestusu.Name = "lbtestusu";
            this.lbtestusu.Size = new System.Drawing.Size(35, 13);
            this.lbtestusu.TabIndex = 4;
            this.lbtestusu.Text = "label1";
            // 
            // MenuHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 356);
            this.Controls.Add(this.lbtestusu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.menuinfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MenuHome";
            this.Text = "MenuHome";
            this.Load += new System.EventHandler(this.MenuHome_Load);
            this.menuinfo.ResumeLayout(false);
            this.menuinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip menuinfo;
        private System.Windows.Forms.ToolStripLabel lbuserr;
        private System.Windows.Forms.ToolStripLabel lbfecha;
        private System.Windows.Forms.ToolStripLabel lbhora;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbtestusu;
    }
}