﻿namespace PAD_Money
{
    partial class frmModifier
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
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.cbbBP = new System.Windows.Forms.ComboBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.lblPoste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(197, 39);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(278, 39);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(12, 15);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(56, 18);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "lblCode";
            // 
            // cbbBP
            // 
            this.cbbBP.BackColor = System.Drawing.Color.DarkGray;
            this.cbbBP.FormattingEnabled = true;
            this.cbbBP.Location = new System.Drawing.Point(172, 12);
            this.cbbBP.Name = "cbbBP";
            this.cbbBP.Size = new System.Drawing.Size(100, 21);
            this.cbbBP.TabIndex = 4;
            // 
            // txtMontant
            // 
            this.txtMontant.BackColor = System.Drawing.Color.DarkGray;
            this.txtMontant.Location = new System.Drawing.Point(278, 12);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(59, 20);
            this.txtMontant.TabIndex = 5;
            // 
            // lblPoste
            // 
            this.lblPoste.AutoSize = true;
            this.lblPoste.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoste.Location = new System.Drawing.Point(12, 42);
            this.lblPoste.Name = "lblPoste";
            this.lblPoste.Size = new System.Drawing.Size(46, 18);
            this.lblPoste.TabIndex = 6;
            this.lblPoste.Text = "label1";
            // 
            // frmModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(359, 69);
            this.Controls.Add(this.lblPoste);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.cbbBP);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Name = "frmModifier";
            this.Text = "Modifier";
            this.Load += new System.EventHandler(this.frmModifier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ComboBox cbbBP;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label lblPoste;
    }
}