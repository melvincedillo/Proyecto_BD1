
namespace Rentadora
{
    partial class fmrAutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vCosto_renta = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cSeguro = new System.Windows.Forms.TextBox();
            this.cb_Version = new System.Windows.Forms.ComboBox();
            this.cbTipo_Vehiculo = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.cbCombustible = new System.Windows.Forms.ComboBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.add_auto = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dpFecha_Adq = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cCosto_Vehiculo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAutos = new System.Windows.Forms.DataGridView();
            this.idAuto = new System.Windows.Forms.Label();
            this.delete_auto = new System.Windows.Forms.Button();
            this.editar_auto = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.vCosto_renta);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cSeguro);
            this.panel1.Controls.Add(this.cb_Version);
            this.panel1.Controls.Add(this.cbTipo_Vehiculo);
            this.panel1.Controls.Add(this.cbColor);
            this.panel1.Controls.Add(this.cbMarca);
            this.panel1.Controls.Add(this.cbModelo);
            this.panel1.Controls.Add(this.cbCombustible);
            this.panel1.Controls.Add(this.cancelar);
            this.panel1.Controls.Add(this.aceptar);
            this.panel1.Controls.Add(this.add_auto);
            this.panel1.Controls.Add(this.cbEstado);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dpFecha_Adq);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cCosto_Vehiculo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cPlaca);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 846);
            this.panel1.TabIndex = 2;
            // 
            // vCosto_renta
            // 
            this.vCosto_renta.Location = new System.Drawing.Point(286, 543);
            this.vCosto_renta.Name = "vCosto_renta";
            this.vCosto_renta.Size = new System.Drawing.Size(169, 26);
            this.vCosto_renta.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(282, 520);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "Valor coste de renta";
            // 
            // cSeguro
            // 
            this.cSeguro.Location = new System.Drawing.Point(308, 632);
            this.cSeguro.Name = "cSeguro";
            this.cSeguro.Size = new System.Drawing.Size(169, 26);
            this.cSeguro.TabIndex = 32;
            // 
            // cb_Version
            // 
            this.cb_Version.FormattingEnabled = true;
            this.cb_Version.Location = new System.Drawing.Point(33, 382);
            this.cb_Version.Name = "cb_Version";
            this.cb_Version.Size = new System.Drawing.Size(210, 28);
            this.cb_Version.TabIndex = 31;
            this.cb_Version.SelectedIndexChanged += new System.EventHandler(this.cbVersion_SelectedIndexChanged);
            // 
            // cbTipo_Vehiculo
            // 
            this.cbTipo_Vehiculo.FormattingEnabled = true;
            this.cbTipo_Vehiculo.Location = new System.Drawing.Point(286, 468);
            this.cbTipo_Vehiculo.Name = "cbTipo_Vehiculo";
            this.cbTipo_Vehiculo.Size = new System.Drawing.Size(210, 28);
            this.cbTipo_Vehiculo.TabIndex = 30;
            this.cbTipo_Vehiculo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_Vehiculo_SelectedIndexChanged);
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(286, 382);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(210, 28);
            this.cbColor.TabIndex = 29;
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(286, 297);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(210, 28);
            this.cbMarca.TabIndex = 28;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(33, 297);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(210, 28);
            this.cbModelo.TabIndex = 27;
            this.cbModelo.SelectedIndexChanged += new System.EventHandler(this.cbModelo_SelectedIndexChanged);
            // 
            // cbCombustible
            // 
            this.cbCombustible.FormattingEnabled = true;
            this.cbCombustible.Location = new System.Drawing.Point(33, 468);
            this.cbCombustible.Name = "cbCombustible";
            this.cbCombustible.Size = new System.Drawing.Size(210, 28);
            this.cbCombustible.TabIndex = 26;
            this.cbCombustible.SelectedIndexChanged += new System.EventHandler(this.cbCombustible_SelectedIndexChanged);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.Firebrick;
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(68, 778);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(122, 51);
            this.cancelar.TabIndex = 25;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.BackColor = System.Drawing.Color.SandyBrown;
            this.aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.Location = new System.Drawing.Point(369, 778);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(126, 51);
            this.aceptar.TabIndex = 24;
            this.aceptar.Text = "Actualizar Empleado";
            this.aceptar.UseVisualStyleBackColor = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // add_auto
            // 
            this.add_auto.BackColor = System.Drawing.Color.SandyBrown;
            this.add_auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_auto.Location = new System.Drawing.Point(218, 778);
            this.add_auto.Name = "add_auto";
            this.add_auto.Size = new System.Drawing.Size(110, 51);
            this.add_auto.TabIndex = 23;
            this.add_auto.Text = "Crear Empleado";
            this.add_auto.UseVisualStyleBackColor = false;
            this.add_auto.Click += new System.EventHandler(this.add_auto_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(33, 632);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(172, 28);
            this.cbEstado.TabIndex = 22;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(303, 609);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Seguro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(282, 445);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Tipo Vehiculo";
            // 
            // dpFecha_Adq
            // 
            this.dpFecha_Adq.Location = new System.Drawing.Point(266, 192);
            this.dpFecha_Adq.Name = "dpFecha_Adq";
            this.dpFecha_Adq.Size = new System.Drawing.Size(313, 26);
            this.dpFecha_Adq.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 609);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Estado Disponibilidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Version";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(282, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(282, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Combustible";
            // 
            // cCosto_Vehiculo
            // 
            this.cCosto_Vehiculo.Location = new System.Drawing.Point(33, 543);
            this.cCosto_Vehiculo.Name = "cCosto_Vehiculo";
            this.cCosto_Vehiculo.Size = new System.Drawing.Size(169, 26);
            this.cCosto_Vehiculo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Costo Adquisicion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Adquisicion";
            // 
            // cPlaca
            // 
            this.cPlaca.Location = new System.Drawing.Point(33, 192);
            this.cPlaca.Name = "cPlaca";
            this.cPlaca.Size = new System.Drawing.Size(154, 26);
            this.cPlaca.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa del Vehiculo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(148, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREAR AUTOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.dgvAutos);
            this.panel2.Controls.Add(this.idAuto);
            this.panel2.Controls.Add(this.delete_auto);
            this.panel2.Controls.Add(this.editar_auto);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(586, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 846);
            this.panel2.TabIndex = 3;
            // 
            // dgvAutos
            // 
            this.dgvAutos.AllowUserToAddRows = false;
            this.dgvAutos.AllowUserToDeleteRows = false;
            this.dgvAutos.AllowUserToOrderColumns = true;
            this.dgvAutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAutos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAutos.Location = new System.Drawing.Point(24, 169);
            this.dgvAutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAutos.Name = "dgvAutos";
            this.dgvAutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAutos.RowHeadersVisible = false;
            this.dgvAutos.RowHeadersWidth = 62;
            this.dgvAutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutos.Size = new System.Drawing.Size(872, 495);
            this.dgvAutos.TabIndex = 4;
            this.dgvAutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutos_CellClick_1);
            // 
            // idAuto
            // 
            this.idAuto.AutoSize = true;
            this.idAuto.Location = new System.Drawing.Point(51, 131);
            this.idAuto.Name = "idAuto";
            this.idAuto.Size = new System.Drawing.Size(55, 20);
            this.idAuto.TabIndex = 26;
            this.idAuto.Text = "idAuto";
            // 
            // delete_auto
            // 
            this.delete_auto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.delete_auto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.delete_auto.BackgroundImage = global::Rentadora.Properties.Resources.unnamed;
            this.delete_auto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_auto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.delete_auto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_auto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.delete_auto.Location = new System.Drawing.Point(447, 723);
            this.delete_auto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delete_auto.Name = "delete_auto";
            this.delete_auto.Size = new System.Drawing.Size(94, 97);
            this.delete_auto.TabIndex = 26;
            this.delete_auto.UseVisualStyleBackColor = false;
            this.delete_auto.Click += new System.EventHandler(this.delete_auto_Click);
            // 
            // editar_auto
            // 
            this.editar_auto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.editar_auto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.editar_auto.BackgroundImage = global::Rentadora.Properties.Resources.png_transparent_human_figure_human_behavior_neck_microphone_hand_male_user_edit_microphone_hand_smiley_thumbnail;
            this.editar_auto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editar_auto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.editar_auto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar_auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar_auto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.editar_auto.Location = new System.Drawing.Point(298, 723);
            this.editar_auto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editar_auto.Name = "editar_auto";
            this.editar_auto.Size = new System.Drawing.Size(94, 97);
            this.editar_auto.TabIndex = 25;
            this.editar_auto.UseVisualStyleBackColor = false;
            this.editar_auto.Click += new System.EventHandler(this.editar_auto_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightGray;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(218, 72);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(419, 47);
            this.label13.TabIndex = 24;
            this.label13.Text = "INFORMACION AUTOS";
            // 
            // fmrAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 846);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fmrAutos";
            this.Text = "fmrAutos";
            this.Load += new System.EventHandler(this.fmrAutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button add_auto;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dpFecha_Adq;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cCosto_Vehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label idAuto;
        private System.Windows.Forms.Button delete_auto;
        private System.Windows.Forms.Button editar_auto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cSeguro;
        private System.Windows.Forms.ComboBox cb_Version;
        private System.Windows.Forms.ComboBox cbTipo_Vehiculo;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.ComboBox cbCombustible;
        private System.Windows.Forms.DataGridView dgvAutos;
        private System.Windows.Forms.TextBox vCosto_renta;
        private System.Windows.Forms.Label label14;
    }
}