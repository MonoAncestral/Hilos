﻿namespace Hilos
{
    partial class recibo
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbFecha = new System.Windows.Forms.Label();
            this.tbHora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "TURNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Asesoría comercial";
            // 
            // tbFecha
            // 
            this.tbFecha.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFecha.Location = new System.Drawing.Point(54, 236);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(138, 23);
            this.tbFecha.TabIndex = 4;
            this.tbFecha.Text = "10/10/2012";
            this.tbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHora
            // 
            this.tbHora.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHora.Location = new System.Drawing.Point(54, 268);
            this.tbHora.Name = "tbHora";
            this.tbHora.Size = new System.Drawing.Size(138, 23);
            this.tbHora.TabIndex = 5;
            this.tbHora.Text = "05:14 A.M.";
            this.tbHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 57);
            this.label2.TabIndex = 6;
            this.label2.Text = "02222";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hilos.Properties.Resources._8335___Meowth_128;
            this.pictureBox1.Location = new System.Drawing.Point(71, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // recibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(252, 318);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHora);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "recibo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "recibo";
            this.Load += new System.EventHandler(this.recibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label tbFecha;
        public System.Windows.Forms.Label tbHora;
        public System.Windows.Forms.Label label2;
    }
}