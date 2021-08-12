
namespace Rentadora
{
    partial class fmrPago
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelTarjeta = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tarj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exp = new System.Windows.Forms.TextBox();
            this.cod = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.efectivo = new System.Windows.Forms.RadioButton();
            this.tarjeta = new System.Windows.Forms.RadioButton();
            this.Total = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelTarjeta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 284);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.PanelTarjeta);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.Total);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 278);
            this.panel2.TabIndex = 0;
            // 
            // PanelTarjeta
            // 
            this.PanelTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelTarjeta.Controls.Add(this.label2);
            this.PanelTarjeta.Controls.Add(this.label4);
            this.PanelTarjeta.Controls.Add(this.tarj);
            this.PanelTarjeta.Controls.Add(this.label3);
            this.PanelTarjeta.Controls.Add(this.exp);
            this.PanelTarjeta.Controls.Add(this.cod);
            this.PanelTarjeta.Location = new System.Drawing.Point(9, 125);
            this.PanelTarjeta.Name = "PanelTarjeta";
            this.PanelTarjeta.Size = new System.Drawing.Size(529, 100);
            this.PanelTarjeta.TabIndex = 13;
            this.PanelTarjeta.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "N° Tarjeta: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Codigo: ";
            // 
            // tarj
            // 
            this.tarj.Location = new System.Drawing.Point(170, 23);
            this.tarj.MaxLength = 19;
            this.tarj.Name = "tarj";
            this.tarj.Size = new System.Drawing.Size(235, 20);
            this.tarj.TabIndex = 7;
            this.tarj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tarj_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Expira: ";
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(143, 53);
            this.exp.MaxLength = 5;
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(91, 20);
            this.exp.TabIndex = 9;
            this.exp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.exp_KeyDown);
            // 
            // cod
            // 
            this.cod.Location = new System.Drawing.Point(314, 53);
            this.cod.MaxLength = 4;
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(91, 20);
            this.cod.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.efectivo);
            this.groupBox1.Controls.Add(this.tarjeta);
            this.groupBox1.Location = new System.Drawing.Point(43, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 47);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de pago";
            // 
            // efectivo
            // 
            this.efectivo.AutoSize = true;
            this.efectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efectivo.Location = new System.Drawing.Point(89, 17);
            this.efectivo.Name = "efectivo";
            this.efectivo.Size = new System.Drawing.Size(107, 24);
            this.efectivo.TabIndex = 2;
            this.efectivo.TabStop = true;
            this.efectivo.Text = "EFECTIVO";
            this.efectivo.UseVisualStyleBackColor = true;
            this.efectivo.CheckedChanged += new System.EventHandler(this.efectivo_CheckedChanged);
            // 
            // tarjeta
            // 
            this.tarjeta.AutoSize = true;
            this.tarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarjeta.Location = new System.Drawing.Point(293, 17);
            this.tarjeta.Name = "tarjeta";
            this.tarjeta.Size = new System.Drawing.Size(98, 24);
            this.tarjeta.TabIndex = 4;
            this.tarjeta.TabStop = true;
            this.tarjeta.Text = "TARJETA";
            this.tarjeta.UseVisualStyleBackColor = true;
            this.tarjeta.CheckedChanged += new System.EventHandler(this.tarjeta_CheckedChanged);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(149, 53);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(45, 16);
            this.Total.TabIndex = 5;
            this.Total.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(219, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 39);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "METODO DE PAGO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rentadora.Properties.Resources.logo__1_;
            this.pictureBox1.Location = new System.Drawing.Point(153, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // fmrPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 284);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrPago";
            this.Load += new System.EventHandler(this.fmrPago_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelTarjeta.ResumeLayout(false);
            this.PanelTarjeta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton efectivo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.RadioButton tarjeta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel PanelTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tarj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox exp;
        private System.Windows.Forms.TextBox cod;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}