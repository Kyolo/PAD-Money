namespace PAD_Money
{
    partial class frmEcheance
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
            this.lblPoste = new System.Windows.Forms.Label();
            this.lblAchat = new System.Windows.Forms.Label();
            this.flpEcheance = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPoste
            // 
            this.lblPoste.AutoSize = true;
            this.lblPoste.Location = new System.Drawing.Point(38, 26);
            this.lblPoste.Name = "lblPoste";
            this.lblPoste.Size = new System.Drawing.Size(35, 13);
            this.lblPoste.TabIndex = 0;
            this.lblPoste.Text = "label1";
            // 
            // lblAchat
            // 
            this.lblAchat.AutoSize = true;
            this.lblAchat.Location = new System.Drawing.Point(38, 65);
            this.lblAchat.Name = "lblAchat";
            this.lblAchat.Size = new System.Drawing.Size(35, 13);
            this.lblAchat.TabIndex = 1;
            this.lblAchat.Text = "label2";
            // 
            // flpEcheance
            // 
            this.flpEcheance.Location = new System.Drawing.Point(12, 110);
            this.flpEcheance.Name = "flpEcheance";
            this.flpEcheance.Size = new System.Drawing.Size(260, 105);
            this.flpEcheance.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(197, 226);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Retour";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmEcheance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.flpEcheance);
            this.Controls.Add(this.lblAchat);
            this.Controls.Add(this.lblPoste);
            this.Name = "frmEcheance";
            this.Text = "Echeances";
            this.Load += new System.EventHandler(this.frmEcheance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoste;
        private System.Windows.Forms.Label lblAchat;
        private System.Windows.Forms.FlowLayoutPanel flpEcheance;
        private System.Windows.Forms.Button btnOk;
    }
}