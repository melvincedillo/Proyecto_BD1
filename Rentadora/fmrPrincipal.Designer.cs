
namespace Rentadora
{
    partial class fmrPrincipal
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
            this.Pcabeza = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Plateral = new System.Windows.Forms.Panel();
            this.contrato = new System.Windows.Forms.Button();
            this.cliente = new System.Windows.Forms.Button();
            this.solicitud = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textNameUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.historial = new System.Windows.Forms.Button();
            this.empleados = new System.Windows.Forms.Button();
            this.auto = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.Button();
            this.flecha = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pcabeza.SuspendLayout();
            this.Plateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pcabeza
            // 
            this.Pcabeza.BackColor = System.Drawing.Color.White;
            this.Pcabeza.Controls.Add(this.pictureBox2);
            this.Pcabeza.Controls.Add(this.salir);
            this.Pcabeza.Controls.Add(this.label1);
            this.Pcabeza.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pcabeza.Location = new System.Drawing.Point(200, 0);
            this.Pcabeza.Name = "Pcabeza";
            this.Pcabeza.Size = new System.Drawing.Size(1000, 50);
            this.Pcabeza.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(106, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA RENTADORA DE AUTOS";
            // 
            // Plateral
            // 
            this.Plateral.BackColor = System.Drawing.Color.Black;
            this.Plateral.Controls.Add(this.auto);
            this.Plateral.Controls.Add(this.empleados);
            this.Plateral.Controls.Add(this.cliente);
            this.Plateral.Controls.Add(this.historial);
            this.Plateral.Controls.Add(this.flecha);
            this.Plateral.Controls.Add(this.contrato);
            this.Plateral.Controls.Add(this.solicitud);
            this.Plateral.Controls.Add(this.label4);
            this.Plateral.Controls.Add(this.textNameUser);
            this.Plateral.Controls.Add(this.label3);
            this.Plateral.Controls.Add(this.pictureBox1);
            this.Plateral.Controls.Add(this.label2);
            this.Plateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.Plateral.Location = new System.Drawing.Point(0, 0);
            this.Plateral.Name = "Plateral";
            this.Plateral.Size = new System.Drawing.Size(200, 600);
            this.Plateral.TabIndex = 3;
            // 
            // contrato
            // 
            this.contrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contrato.FlatAppearance.BorderSize = 0;
            this.contrato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contrato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrato.ForeColor = System.Drawing.Color.White;
            this.contrato.Location = new System.Drawing.Point(33, 322);
            this.contrato.Name = "contrato";
            this.contrato.Size = new System.Drawing.Size(125, 32);
            this.contrato.TabIndex = 5;
            this.contrato.Text = "Contrato";
            this.contrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contrato.UseVisualStyleBackColor = true;
            this.contrato.Click += new System.EventHandler(this.contrato_Click);
            // 
            // cliente
            // 
            this.cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cliente.FlatAppearance.BorderSize = 0;
            this.cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.ForeColor = System.Drawing.Color.White;
            this.cliente.Location = new System.Drawing.Point(33, 284);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(124, 32);
            this.cliente.TabIndex = 4;
            this.cliente.Text = "Clientes";
            this.cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cliente.UseVisualStyleBackColor = true;
            this.cliente.Click += new System.EventHandler(this.cliente_Click);
            // 
            // solicitud
            // 
            this.solicitud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solicitud.FlatAppearance.BorderSize = 0;
            this.solicitud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.solicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solicitud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solicitud.ForeColor = System.Drawing.Color.White;
            this.solicitud.Location = new System.Drawing.Point(32, 398);
            this.solicitud.Name = "solicitud";
            this.solicitud.Size = new System.Drawing.Size(125, 32);
            this.solicitud.TabIndex = 0;
            this.solicitud.Text = "Solicitudes";
            this.solicitud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.solicitud.UseVisualStyleBackColor = true;
            this.solicitud.Click += new System.EventHandler(this.solicitud_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "______________";
            // 
            // textNameUser
            // 
            this.textNameUser.AutoSize = true;
            this.textNameUser.BackColor = System.Drawing.Color.Transparent;
            this.textNameUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNameUser.ForeColor = System.Drawing.Color.Red;
            this.textNameUser.Location = new System.Drawing.Point(52, 152);
            this.textNameUser.Name = "textNameUser";
            this.textNameUser.Size = new System.Drawing.Size(40, 18);
            this.textNameUser.TabIndex = 2;
            this.textNameUser.Text = "user";
            this.textNameUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(33, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "BIENVENIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(61, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "MENÚ";
            // 
            // historial
            // 
            this.historial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historial.FlatAppearance.BorderSize = 0;
            this.historial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historial.ForeColor = System.Drawing.Color.White;
            this.historial.Location = new System.Drawing.Point(33, 360);
            this.historial.Name = "historial";
            this.historial.Size = new System.Drawing.Size(125, 32);
            this.historial.TabIndex = 6;
            this.historial.Text = "Historial";
            this.historial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historial.UseVisualStyleBackColor = true;
            this.historial.Click += new System.EventHandler(this.historial_Click);
            // 
            // empleados
            // 
            this.empleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empleados.FlatAppearance.BorderSize = 0;
            this.empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empleados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleados.ForeColor = System.Drawing.Color.White;
            this.empleados.Location = new System.Drawing.Point(32, 436);
            this.empleados.Name = "empleados";
            this.empleados.Size = new System.Drawing.Size(125, 32);
            this.empleados.TabIndex = 7;
            this.empleados.Text = "Empleados";
            this.empleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empleados.UseVisualStyleBackColor = true;
            this.empleados.Click += new System.EventHandler(this.empleados_Click);
            // 
            // auto
            // 
            this.auto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auto.FlatAppearance.BorderSize = 0;
            this.auto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.auto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auto.ForeColor = System.Drawing.Color.White;
            this.auto.Location = new System.Drawing.Point(32, 474);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(124, 32);
            this.auto.TabIndex = 8;
            this.auto.Text = "Autos";
            this.auto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.auto.UseVisualStyleBackColor = true;
            this.auto.Click += new System.EventHandler(this.auto_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Rentadora.Properties.Resources.cars_crashing_clip_art_car_vector_logo_png_288492_free_car_vector_png_920_595;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // salir
            // 
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.ForeColor = System.Drawing.Color.Transparent;
            this.salir.Image = global::Rentadora.Properties.Resources.Salir;
            this.salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.salir.Location = new System.Drawing.Point(930, -6);
            this.salir.Name = "salir";
            this.salir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.salir.Size = new System.Drawing.Size(69, 59);
            this.salir.TabIndex = 0;
            this.salir.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // flecha
            // 
            this.flecha.Image = global::Rentadora.Properties.Resources.Flecha;
            this.flecha.Location = new System.Drawing.Point(163, 282);
            this.flecha.Name = "flecha";
            this.flecha.Size = new System.Drawing.Size(37, 34);
            this.flecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flecha.TabIndex = 0;
            this.flecha.TabStop = false;
            this.flecha.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rentadora.Properties.Resources.Administrador;
            this.pictureBox1.Location = new System.Drawing.Point(33, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.Pcabeza);
            this.Controls.Add(this.Plateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrPrincipal";
            this.Pcabeza.ResumeLayout(false);
            this.Pcabeza.PerformLayout();
            this.Plateral.ResumeLayout(false);
            this.Plateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Panel Pcabeza;
        private System.Windows.Forms.Panel Plateral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textNameUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button contrato;
        private System.Windows.Forms.Button cliente;
        private System.Windows.Forms.Button solicitud;
        private System.Windows.Forms.PictureBox flecha;
        private System.Windows.Forms.Button historial;
        private System.Windows.Forms.Button empleados;
        private System.Windows.Forms.Button auto;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}