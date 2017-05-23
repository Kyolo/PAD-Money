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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAjouterPers = new System.Windows.Forms.Button();
            this.lblRecette = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.cbbDatedep = new System.Windows.Forms.ComboBox();
            this.tabSuppression = new System.Windows.Forms.TabPage();
            this.TabModif = new System.Windows.Forms.TabPage();
            this.TabRecapitulatif = new System.Windows.Forms.TabPage();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.dtpDepense = new System.Windows.Forms.DateTimePicker();
            this.lblType = new System.Windows.Forms.Label();
            this.cbNom = new System.Windows.Forms.CheckBox();
            this.cbPercu = new System.Windows.Forms.CheckBox();
            this.cbRecette = new System.Windows.Forms.CheckBox();
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
            this.TabTransac.Controls.Add(this.cbNom);
            this.TabTransac.Controls.Add(this.lblType);
            this.TabTransac.Controls.Add(this.dtpDepense);
            this.TabTransac.Controls.Add(this.txtMontant);
            this.TabTransac.Controls.Add(this.txtDescription);
            this.TabTransac.Controls.Add(this.btnAjouter);
            this.TabTransac.Controls.Add(this.btnAjouterPers);
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
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(216, 360);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAjouterPers
            // 
            this.btnAjouterPers.Location = new System.Drawing.Point(600, 173);
            this.btnAjouterPers.Name = "btnAjouterPers";
            this.btnAjouterPers.Size = new System.Drawing.Size(222, 72);
            this.btnAjouterPers.TabIndex = 8;
            this.btnAjouterPers.Text = "Ajouter une personne";
            this.btnAjouterPers.UseVisualStyleBackColor = true;
            // 
            // lblRecette
            // 
            this.lblRecette.AutoSize = true;
            this.lblRecette.Location = new System.Drawing.Point(18, 351);
            this.lblRecette.Name = "lblRecette";
            this.lblRecette.Size = new System.Drawing.Size(57, 17);
            this.lblRecette.TabIndex = 5;
            this.lblRecette.Text = "Recette";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(16, 131);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(59, 17);
            this.lblMontant.TabIndex = 4;
            this.lblMontant.Text = "Montant";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(16, 81);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
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
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(268, 173);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(202, 24);
            this.cbbType.TabIndex = 1;
            // 
            // cbbDatedep
            // 
            this.cbbDatedep.FormattingEnabled = true;
            this.cbbDatedep.Location = new System.Drawing.Point(649, 317);
            this.cbbDatedep.Name = "cbbDatedep";
            this.cbbDatedep.Size = new System.Drawing.Size(183, 24);
            this.cbbDatedep.TabIndex = 0;
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
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(269, 81);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(201, 22);
            this.txtDescription.TabIndex = 10;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(269, 131);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(200, 22);
            this.txtMontant.TabIndex = 11;
            // 
            // dtpDepense
            // 
            this.dtpDepense.Location = new System.Drawing.Point(270, 34);
            this.dtpDepense.Name = "dtpDepense";
            this.dtpDepense.Size = new System.Drawing.Size(200, 22);
            this.dtpDepense.TabIndex = 12;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(16, 186);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Type";
            // 
            // cbNom
            // 
            this.cbNom.AutoSize = true;
            this.cbNom.Location = new System.Drawing.Point(623, 38);
            this.cbNom.Name = "cbNom";
            this.cbNom.Size = new System.Drawing.Size(98, 21);
            this.cbNom.TabIndex = 14;
            this.cbNom.Text = "checkBox1";
            this.cbNom.UseVisualStyleBackColor = true;
            // 
            // cbPercu
            // 
            this.cbPercu.AutoSize = true;
            this.cbPercu.Location = new System.Drawing.Point(321, 266);
            this.cbPercu.Name = "cbPercu";
            this.cbPercu.Size = new System.Drawing.Size(67, 21);
            this.cbPercu.TabIndex = 7;
            this.cbPercu.Text = "Perçu";
            this.cbPercu.UseVisualStyleBackColor = true;
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
            // FrmBudgetMois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 526);
            this.Controls.Add(this.TabAjout);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label lblRecette;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.ComboBox cbbDatedep;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAjouterPers;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpDepense;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.CheckBox cbNom;
        private System.Windows.Forms.CheckBox cbPercu;
        private System.Windows.Forms.CheckBox cbRecette;
    }
}