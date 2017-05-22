namespace PAD_Money
{
    partial class FrmBudgetMois
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
            this.TabAjout = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TabTransac = new System.Windows.Forms.TabPage();
            this.tabSuppression = new System.Windows.Forms.TabPage();
            this.TabModif = new System.Windows.Forms.TabPage();
            this.TabRecapitulatif = new System.Windows.Forms.TabPage();
            this.cbbDatedep = new System.Windows.Forms.ComboBox();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblRecette = new System.Windows.Forms.Label();
            this.cbRecette = new System.Windows.Forms.CheckBox();
            this.cbPercu = new System.Windows.Forms.CheckBox();
            this.TabAjout.SuspendLayout();
            this.TabTransac.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabAjout
            // 
            this.TabAjout.Controls.Add(this.tabPage1);
            this.TabAjout.Controls.Add(this.TabTransac);
            this.TabAjout.Controls.Add(this.tabSuppression);
            this.TabAjout.Controls.Add(this.TabModif);
            this.TabAjout.Controls.Add(this.TabRecapitulatif);
            this.TabAjout.Location = new System.Drawing.Point(12, 12);
            this.TabAjout.Name = "TabAjout";
            this.TabAjout.SelectedIndex = 0;
            this.TabAjout.Size = new System.Drawing.Size(1169, 502);
            this.TabAjout.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1161, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Affichage 1 à 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TabTransac
            // 
            this.TabTransac.Controls.Add(this.cbPercu);
            this.TabTransac.Controls.Add(this.cbRecette);
            this.TabTransac.Controls.Add(this.lblRecette);
            this.TabTransac.Controls.Add(this.lblMontant);
            this.TabTransac.Controls.Add(this.lblDescription);
            this.TabTransac.Controls.Add(this.lblDate);
            this.TabTransac.Controls.Add(this.cbbType);
            this.TabTransac.Controls.Add(this.cbbDatedep);
            this.TabTransac.Location = new System.Drawing.Point(4, 25);
            this.TabTransac.Name = "TabTransac";
            this.TabTransac.Padding = new System.Windows.Forms.Padding(3);
            this.TabTransac.Size = new System.Drawing.Size(1161, 473);
            this.TabTransac.TabIndex = 1;
            this.TabTransac.Text = "Ajout d\'une transaction";
            this.TabTransac.UseVisualStyleBackColor = true;
            // 
            // tabSuppression
            // 
            this.tabSuppression.Location = new System.Drawing.Point(4, 25);
            this.tabSuppression.Name = "tabSuppression";
            this.tabSuppression.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuppression.Size = new System.Drawing.Size(1161, 473);
            this.tabSuppression.TabIndex = 2;
            this.tabSuppression.Text = "Suppression d\'une transaction";
            this.tabSuppression.UseVisualStyleBackColor = true;
            // 
            // TabModif
            // 
            this.TabModif.Location = new System.Drawing.Point(4, 25);
            this.TabModif.Name = "TabModif";
            this.TabModif.Padding = new System.Windows.Forms.Padding(3);
            this.TabModif.Size = new System.Drawing.Size(1161, 473);
            this.TabModif.TabIndex = 3;
            this.TabModif.Text = "Modification d\'une transaction";
            this.TabModif.UseVisualStyleBackColor = true;
            // 
            // TabRecapitulatif
            // 
            this.TabRecapitulatif.Location = new System.Drawing.Point(4, 25);
            this.TabRecapitulatif.Name = "TabRecapitulatif";
            this.TabRecapitulatif.Padding = new System.Windows.Forms.Padding(3);
            this.TabRecapitulatif.Size = new System.Drawing.Size(1161, 473);
            this.TabRecapitulatif.TabIndex = 4;
            this.TabRecapitulatif.Text = "Récapitulatif";
            this.TabRecapitulatif.UseVisualStyleBackColor = true;
            // 
            // cbbDatedep
            // 
            this.cbbDatedep.FormattingEnabled = true;
            this.cbbDatedep.Location = new System.Drawing.Point(268, 65);
            this.cbbDatedep.Name = "cbbDatedep";
            this.cbbDatedep.Size = new System.Drawing.Size(183, 24);
            this.cbbDatedep.TabIndex = 0;
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(268, 131);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(183, 24);
            this.cbbType.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(16, 34);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(132, 17);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date de la dépense";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(27, 104);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(27, 155);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(59, 17);
            this.lblMontant.TabIndex = 4;
            this.lblMontant.Text = "Montant";
            // 
            // lblRecette
            // 
            this.lblRecette.AutoSize = true;
            this.lblRecette.Location = new System.Drawing.Point(27, 212);
            this.lblRecette.Name = "lblRecette";
            this.lblRecette.Size = new System.Drawing.Size(57, 17);
            this.lblRecette.TabIndex = 5;
            this.lblRecette.Text = "Recette";
            // 
            // cbRecette
            // 
            this.cbRecette.AutoSize = true;
            this.cbRecette.Location = new System.Drawing.Point(212, 241);
            this.cbRecette.Name = "cbRecette";
            this.cbRecette.Size = new System.Drawing.Size(79, 21);
            this.cbRecette.TabIndex = 6;
            this.cbRecette.Text = "Recette";
            this.cbRecette.UseVisualStyleBackColor = true;
            // 
            // cbPercu
            // 
            this.cbPercu.AutoSize = true;
            this.cbPercu.Location = new System.Drawing.Point(531, 226);
            this.cbPercu.Name = "cbPercu";
            this.cbPercu.Size = new System.Drawing.Size(67, 21);
            this.cbPercu.TabIndex = 7;
            this.cbPercu.Text = "Perçu";
            this.cbPercu.UseVisualStyleBackColor = true;
            // 
            // FrmBudgetMois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 526);
            this.Controls.Add(this.TabAjout);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBudgetMois";
            this.Text = "frmBudgetMois";
            this.TabAjout.ResumeLayout(false);
            this.TabTransac.ResumeLayout(false);
            this.TabTransac.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabAjout;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage TabTransac;
        private System.Windows.Forms.TabPage tabSuppression;
        private System.Windows.Forms.TabPage TabModif;
        private System.Windows.Forms.TabPage TabRecapitulatif;
        private System.Windows.Forms.CheckBox cbPercu;
        private System.Windows.Forms.CheckBox cbRecette;
        private System.Windows.Forms.Label lblRecette;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.ComboBox cbbDatedep;
    }
}