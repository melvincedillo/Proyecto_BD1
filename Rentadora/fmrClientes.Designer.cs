
namespace Rentadora
{
    partial class fmrClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.cbMunicipio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cP_nombre = new System.Windows.Forms.TextBox();
            this.cS_nombre = new System.Windows.Forms.TextBox();
            this.cP_apellido = new System.Windows.Forms.TextBox();
            this.cS_apellido = new System.Windows.Forms.TextBox();
            this.cIdentidad = new System.Windows.Forms.TextBox();
            this.cRtn = new System.Windows.Forms.TextBox();
            this.cSexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.add_cliente = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowDrop = true;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.Location = new System.Drawing.Point(16, 184);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(561, 249);
            this.dgvClientes.TabIndex = 0;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(38, 317);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(143, 21);
            this.cbDepartamento.TabIndex = 1;
            this.cbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbDepartamento_SelectedIndexChanged);
            // 
            // cbMunicipio
            // 
            this.cbMunicipio.FormattingEnabled = true;
            this.cbMunicipio.Location = new System.Drawing.Point(204, 317);
            this.cbMunicipio.Name = "cbMunicipio";
            this.cbMunicipio.Size = new System.Drawing.Size(143, 21);
            this.cbMunicipio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DEPARTAMENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MUNICIPIO";
            // 
            // cDireccion
            // 
            this.cDireccion.Location = new System.Drawing.Point(38, 369);
            this.cDireccion.Multiline = true;
            this.cDireccion.Name = "cDireccion";
            this.cDireccion.Size = new System.Drawing.Size(309, 75);
            this.cDireccion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DOMICILIO";
            // 
            // cP_nombre
            // 
            this.cP_nombre.Location = new System.Drawing.Point(38, 138);
            this.cP_nombre.Name = "cP_nombre";
            this.cP_nombre.Size = new System.Drawing.Size(100, 20);
            this.cP_nombre.TabIndex = 7;
            // 
            // cS_nombre
            // 
            this.cS_nombre.Location = new System.Drawing.Point(147, 138);
            this.cS_nombre.Name = "cS_nombre";
            this.cS_nombre.Size = new System.Drawing.Size(100, 20);
            this.cS_nombre.TabIndex = 8;
            // 
            // cP_apellido
            // 
            this.cP_apellido.Location = new System.Drawing.Point(38, 184);
            this.cP_apellido.Name = "cP_apellido";
            this.cP_apellido.Size = new System.Drawing.Size(100, 20);
            this.cP_apellido.TabIndex = 9;
            // 
            // cS_apellido
            // 
            this.cS_apellido.Location = new System.Drawing.Point(147, 184);
            this.cS_apellido.Name = "cS_apellido";
            this.cS_apellido.Size = new System.Drawing.Size(100, 20);
            this.cS_apellido.TabIndex = 10;
            // 
            // cIdentidad
            // 
            this.cIdentidad.Location = new System.Drawing.Point(38, 85);
            this.cIdentidad.Name = "cIdentidad";
            this.cIdentidad.Size = new System.Drawing.Size(143, 20);
            this.cIdentidad.TabIndex = 11;
            // 
            // cRtn
            // 
            this.cRtn.Location = new System.Drawing.Point(38, 234);
            this.cRtn.Name = "cRtn";
            this.cRtn.Size = new System.Drawing.Size(173, 20);
            this.cRtn.TabIndex = 12;
            // 
            // cSexo
            // 
            this.cSexo.FormattingEnabled = true;
            this.cSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cSexo.Location = new System.Drawing.Point(247, 234);
            this.cSexo.Name = "cSexo";
            this.cSexo.Size = new System.Drawing.Size(100, 21);
            this.cSexo.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "NUMERO DE IDENTIDAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "PRIMER NOMBRE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "SEGUNDO NOMBRE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "PRIMER APELLIDO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "SEGUNDO APELLIDO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "NUMERO DE RTN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(244, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "SEXO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.add_cliente);
            this.panel1.Controls.Add(this.cIdentidad);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cbDepartamento);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbMunicipio);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cDireccion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cP_nombre);
            this.panel1.Controls.Add(this.cSexo);
            this.panel1.Controls.Add(this.cS_nombre);
            this.panel1.Controls.Add(this.cRtn);
            this.panel1.Controls.Add(this.cP_apellido);
            this.panel1.Controls.Add(this.cS_apellido);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 550);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(391, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 550);
            this.panel2.TabIndex = 22;
            // 
            // add_cliente
            // 
            this.add_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.add_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.add_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cliente.Location = new System.Drawing.Point(114, 473);
            this.add_cliente.Name = "add_cliente";
            this.add_cliente.Size = new System.Drawing.Size(133, 34);
            this.add_cliente.TabIndex = 21;
            this.add_cliente.Text = "AGREGAR CLIENTE";
            this.add_cliente.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(23, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(324, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "DATOS PERSONALES CLIENTE";
            // 
            // fmrClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrClientes";
            this.Text = "fmrClientes";
            this.Load += new System.EventHandler(this.fmrClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.ComboBox cbMunicipio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cP_nombre;
        private System.Windows.Forms.TextBox cS_nombre;
        private System.Windows.Forms.TextBox cP_apellido;
        private System.Windows.Forms.TextBox cS_apellido;
        private System.Windows.Forms.TextBox cIdentidad;
        private System.Windows.Forms.TextBox cRtn;
        private System.Windows.Forms.ComboBox cSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_cliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
    }
}