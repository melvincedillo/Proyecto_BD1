
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
            this.salir = new System.Windows.Forms.Button();
            this.Pform = new System.Windows.Forms.Panel();
            this.Pcabeza = new System.Windows.Forms.Panel();
            this.Plateral = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Pcabeza.SuspendLayout();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salir.Location = new System.Drawing.Point(952, 3);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(45, 45);
            this.salir.TabIndex = 0;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Pform
            // 
            this.Pform.Location = new System.Drawing.Point(200, 51);
            this.Pform.Name = "Pform";
            this.Pform.Size = new System.Drawing.Size(1000, 550);
            this.Pform.TabIndex = 1;
            // 
            // Pcabeza
            // 
            this.Pcabeza.BackColor = System.Drawing.Color.Green;
            this.Pcabeza.Controls.Add(this.label1);
            this.Pcabeza.Controls.Add(this.salir);
            this.Pcabeza.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pcabeza.Location = new System.Drawing.Point(200, 0);
            this.Pcabeza.Name = "Pcabeza";
            this.Pcabeza.Size = new System.Drawing.Size(1000, 53);
            this.Pcabeza.TabIndex = 2;
            // 
            // Plateral
            // 
            this.Plateral.BackColor = System.Drawing.Color.Black;
            this.Plateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.Plateral.Location = new System.Drawing.Point(0, 0);
            this.Plateral.Name = "Plateral";
            this.Plateral.Size = new System.Drawing.Size(200, 600);
            this.Plateral.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA RENTADORA DE AUTOS";
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.Pcabeza);
            this.Controls.Add(this.Plateral);
            this.Controls.Add(this.Pform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrPrincipal";
            this.Pcabeza.ResumeLayout(false);
            this.Pcabeza.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Panel Pform;
        private System.Windows.Forms.Panel Pcabeza;
        private System.Windows.Forms.Panel Plateral;
        private System.Windows.Forms.Label label1;
    }
}