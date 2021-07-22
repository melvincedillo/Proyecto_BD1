
namespace Rentadora
{
    partial class fmrEmpleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_empleado = new System.Windows.Forms.Button();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dpFecha_ingreso = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cH_Extras = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cSueldo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cIdentidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cS_Apellido = new System.Windows.Forms.TextBox();
            this.cP_Apellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cS_Nombre = new System.Windows.Forms.TextBox();
            this.cP_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(115, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREAR EMPLEADO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.add_empleado);
            this.panel1.Controls.Add(this.cbSucursal);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbSexo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dpFecha_ingreso);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cH_Extras);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cSueldo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cIdentidad);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cS_Apellido);
            this.panel1.Controls.Add(this.cP_Apellido);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cS_Nombre);
            this.panel1.Controls.Add(this.cP_Nombre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cNombreEmpleado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 846);
            this.panel1.TabIndex = 1;
            // 
            // add_empleado
            // 
            this.add_empleado.BackColor = System.Drawing.Color.SandyBrown;
            this.add_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_empleado.Location = new System.Drawing.Point(204, 746);
            this.add_empleado.Name = "add_empleado";
            this.add_empleado.Size = new System.Drawing.Size(166, 51);
            this.add_empleado.TabIndex = 23;
            this.add_empleado.Text = "Crear Empleado";
            this.add_empleado.UseVisualStyleBackColor = false;
            // 
            // cbSucursal
            // 
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(139, 241);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(250, 28);
            this.cbSucursal.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(234, 667);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Sucursal";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO"});
            this.cbSexo.Location = new System.Drawing.Point(47, 544);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 28);
            this.cbSexo.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(61, 521);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Sexo";
            // 
            // dpFecha_ingreso
            // 
            this.dpFecha_ingreso.Location = new System.Drawing.Point(204, 611);
            this.dpFecha_ingreso.Name = "dpFecha_ingreso";
            this.dpFecha_ingreso.Size = new System.Drawing.Size(257, 26);
            this.dpFecha_ingreso.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(61, 616);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fecha Ingreso";
            // 
            // cH_Extras
            // 
            this.cH_Extras.Location = new System.Drawing.Point(398, 544);
            this.cH_Extras.Name = "cH_Extras";
            this.cH_Extras.Size = new System.Drawing.Size(125, 26);
            this.cH_Extras.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(400, 521);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Horas Extras";
            // 
            // cSueldo
            // 
            this.cSueldo.Location = new System.Drawing.Point(204, 544);
            this.cSueldo.Name = "cSueldo";
            this.cSueldo.Size = new System.Drawing.Size(151, 26);
            this.cSueldo.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(234, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Sueldo";
            // 
            // cIdentidad
            // 
            this.cIdentidad.Location = new System.Drawing.Point(121, 463);
            this.cIdentidad.Name = "cIdentidad";
            this.cIdentidad.Size = new System.Drawing.Size(320, 26);
            this.cIdentidad.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Identidad";
            // 
            // cS_Apellido
            // 
            this.cS_Apellido.Location = new System.Drawing.Point(287, 382);
            this.cS_Apellido.Name = "cS_Apellido";
            this.cS_Apellido.Size = new System.Drawing.Size(214, 26);
            this.cS_Apellido.TabIndex = 10;
            // 
            // cP_Apellido
            // 
            this.cP_Apellido.Location = new System.Drawing.Point(28, 382);
            this.cP_Apellido.Name = "cP_Apellido";
            this.cP_Apellido.Size = new System.Drawing.Size(214, 26);
            this.cP_Apellido.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Segundo Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Primer Apellido";
            // 
            // cS_Nombre
            // 
            this.cS_Nombre.Location = new System.Drawing.Point(287, 298);
            this.cS_Nombre.Name = "cS_Nombre";
            this.cS_Nombre.Size = new System.Drawing.Size(214, 26);
            this.cS_Nombre.TabIndex = 6;
            // 
            // cP_Nombre
            // 
            this.cP_Nombre.Location = new System.Drawing.Point(28, 298);
            this.cP_Nombre.Name = "cP_Nombre";
            this.cP_Nombre.Size = new System.Drawing.Size(214, 26);
            this.cP_Nombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Segundo Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Primer Nombre";
            // 
            // cNombreEmpleado
            // 
            this.cNombreEmpleado.Location = new System.Drawing.Point(47, 198);
            this.cNombreEmpleado.Name = "cNombreEmpleado";
            this.cNombreEmpleado.Size = new System.Drawing.Size(394, 26);
            this.cNombreEmpleado.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Empleado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dgvEmpleados);
            this.panel2.Location = new System.Drawing.Point(583, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 846);
            this.panel2.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightCoral;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(217, 73);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(517, 47);
            this.label13.TabIndex = 24;
            this.label13.Text = "INFORMACION EMPLEADOS";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(42, 241);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 62;
            this.dgvEmpleados.RowTemplate.Height = 28;
            this.dgvEmpleados.Size = new System.Drawing.Size(842, 537);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // fmrEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 846);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fmrEmpleados";
            this.Text = "fmrEmpleados";
            this.Load += new System.EventHandler(this.fmrEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button add_empleado;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dpFecha_ingreso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cH_Extras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cSueldo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cIdentidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cS_Apellido;
        private System.Windows.Forms.TextBox cP_Apellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cS_Nombre;
        private System.Windows.Forms.TextBox cP_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cNombreEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
    }
}