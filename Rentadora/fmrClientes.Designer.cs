﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.mnid = new System.Windows.Forms.Label();
            this.drid = new System.Windows.Forms.Label();
            this.clid = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.add_cliente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editar_cliente = new System.Windows.Forms.Button();
            this.delete_cliente = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.Location = new System.Drawing.Point(16, 122);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 62;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(448, 253);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
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
            this.cbMunicipio.SelectedIndexChanged += new System.EventHandler(this.cbMunicipio_SelectedIndexChanged);
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
            this.panel1.Controls.Add(this.mnid);
            this.panel1.Controls.Add(this.drid);
            this.panel1.Controls.Add(this.clid);
            this.panel1.Controls.Add(this.cancelar);
            this.panel1.Controls.Add(this.aceptar);
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
            this.panel1.Size = new System.Drawing.Size(391, 481);
            this.panel1.TabIndex = 21;
            // 
            // mnid
            // 
            this.mnid.AutoSize = true;
            this.mnid.Location = new System.Drawing.Point(337, 122);
            this.mnid.Name = "mnid";
            this.mnid.Size = new System.Drawing.Size(36, 13);
            this.mnid.TabIndex = 27;
            this.mnid.Text = "SEXO";
            this.mnid.Click += new System.EventHandler(this.mnid_Click);
            // 
            // drid
            // 
            this.drid.AutoSize = true;
            this.drid.Location = new System.Drawing.Point(337, 92);
            this.drid.Name = "drid";
            this.drid.Size = new System.Drawing.Size(36, 13);
            this.drid.TabIndex = 26;
            this.drid.Text = "SEXO";
            // 
            // clid
            // 
            this.clid.AutoSize = true;
            this.clid.Location = new System.Drawing.Point(337, 58);
            this.clid.Name = "clid";
            this.clid.Size = new System.Drawing.Size(36, 13);
            this.clid.TabIndex = 25;
            this.clid.Text = "SEXO";
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.Red;
            this.cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cancelar.Location = new System.Drawing.Point(59, 464);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(82, 38);
            this.cancelar.TabIndex = 24;
            this.cancelar.Text = "CANCELAR";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.aceptar.Location = new System.Drawing.Point(230, 464);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(77, 38);
            this.aceptar.TabIndex = 23;
            this.aceptar.Text = "ACEPTAR";
            this.aceptar.UseVisualStyleBackColor = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
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
            // add_cliente
            // 
            this.add_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.add_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.add_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.add_cliente.Location = new System.Drawing.Point(147, 464);
            this.add_cliente.Name = "add_cliente";
            this.add_cliente.Size = new System.Drawing.Size(77, 38);
            this.add_cliente.TabIndex = 21;
            this.add_cliente.Text = "AGREGAR";
            this.add_cliente.UseVisualStyleBackColor = false;
            this.add_cliente.Click += new System.EventHandler(this.add_cliente_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.editar_cliente);
            this.panel2.Controls.Add(this.delete_cliente);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.dgvClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(391, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 481);
            this.panel2.TabIndex = 22;
            // 
            // editar_cliente
            // 
            this.editar_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.editar_cliente.BackgroundImage = global::Rentadora.Properties.Resources.png_transparent_human_figure_human_behavior_neck_microphone_hand_male_user_edit_microphone_hand_smiley_thumbnail;
            this.editar_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editar_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.editar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar_cliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.editar_cliente.Location = new System.Drawing.Point(220, 464);
            this.editar_cliente.Name = "editar_cliente";
            this.editar_cliente.Size = new System.Drawing.Size(63, 63);
            this.editar_cliente.TabIndex = 24;
            this.editar_cliente.UseVisualStyleBackColor = false;
            this.editar_cliente.Click += new System.EventHandler(this.editar_cliente_Click);
            // 
            // delete_cliente
            // 
            this.delete_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.delete_cliente.BackgroundImage = global::Rentadora.Properties.Resources.unnamed;
            this.delete_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.delete_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_cliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.delete_cliente.Location = new System.Drawing.Point(314, 464);
            this.delete_cliente.Name = "delete_cliente";
            this.delete_cliente.Size = new System.Drawing.Size(63, 63);
            this.delete_cliente.TabIndex = 23;
            this.delete_cliente.UseVisualStyleBackColor = false;
            this.delete_cliente.Click += new System.EventHandler(this.delete_cliente_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(106, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(407, 24);
            this.label12.TabIndex = 23;
            this.label12.Text = "LISTADO DE CLIENTES EN EL SISTEMA";
            // 
            // fmrClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 481);
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
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button delete_cliente;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button editar_cliente;
        private System.Windows.Forms.Label drid;
        private System.Windows.Forms.Label clid;
        private System.Windows.Forms.Label mnid;
    }
}