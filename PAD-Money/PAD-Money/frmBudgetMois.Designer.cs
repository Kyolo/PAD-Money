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
            this.lblType = new System.Windows.Forms.Label();
            this.dtpDepense = new System.Windows.Forms.DateTimePicker();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAjouterPers = new System.Windows.Forms.Button();
            this.cbPercu = new System.Windows.Forms.CheckBox();
            this.cbRecette = new System.Windows.Forms.CheckBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.cbbDatedep = new System.Windows.Forms.ComboBox();
            this.tabSuppression = new System.Windows.Forms.TabPage();
            this.TabModif = new System.Windows.Forms.TabPage();
            this.TabRecapitulatif = new System.Windows.Forms.TabPage();
            this.flpPersonne = new System.Windows.Forms.FlowLayoutPanel();
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
            this.TabAjout.Location = new System.Drawing.Point(-2, 1);
            this.TabAjout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabAjout.Name = "TabAjout";
            this.TabAjout.SelectedIndex = 0;
            this.TabAjout.Size = new System.Drawing.Size(1577, 632);
            this.TabAjout.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1551, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Affichage 1 à 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TabTransac
            // 
            this.TabTransac.BackColor = System.Drawing.Color.DarkGreen;
            this.TabTransac.Controls.Add(this.flpPersonne);
            this.TabTransac.Controls.Add(this.lblType);
            this.TabTransac.Controls.Add(this.dtpDepense);
            this.TabTransac.Controls.Add(this.txtMontant);
            this.TabTransac.Controls.Add(this.txtDescription);
            this.TabTransac.Controls.Add(this.btnAjouter);
            this.TabTransac.Controls.Add(this.btnAjouterPers);
            this.TabTransac.Controls.Add(this.cbPercu);
            this.TabTransac.Controls.Add(this.cbRecette);
            this.TabTransac.Controls.Add(this.lblMontant);
            this.TabTransac.Controls.Add(this.lblDescription);
            this.TabTransac.Controls.Add(this.lblDate);
            this.TabTransac.Controls.Add(this.cbbType);
            this.TabTransac.Controls.Add(this.cbbDatedep);
            this.TabTransac.Location = new System.Drawing.Point(4, 25);
            this.TabTransac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabTransac.Name = "TabTransac";
            this.TabTransac.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabTransac.Size = new System.Drawing.Size(1569, 603);
            this.TabTransac.TabIndex = 1;
            this.TabTransac.Text = "Ajout d\'une transaction";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(24, 126);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Type";
            // 
            // dtpDepense
            // 
            this.dtpDepense.Location = new System.Drawing.Point(252, 36);
            this.dtpDepense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDepense.Name = "dtpDepense";
            this.dtpDepense.Size = new System.Drawing.Size(270, 22);
            this.dtpDepense.TabIndex = 12;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(252, 96);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(270, 22);
            this.txtMontant.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDescription.Location = new System.Drawing.Point(252, 66);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(270, 22);
            this.txtDescription.TabIndex = 10;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(27, 299);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 28);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAjouterPers
            // 
            this.btnAjouterPers.Location = new System.Drawing.Point(1013, 73);
            this.btnAjouterPers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouterPers.Name = "btnAjouterPers";
            this.btnAjouterPers.Size = new System.Drawing.Size(248, 77);
            this.btnAjouterPers.TabIndex = 8;
            this.btnAjouterPers.Text = "Ajouter une personne";
            this.btnAjouterPers.UseVisualStyleBackColor = true;
            // 
            // cbPercu
            // 
            this.cbPercu.AutoSize = true;
            this.cbPercu.Location = new System.Drawing.Point(187, 186);
            this.cbPercu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPercu.Name = "cbPercu";
            this.cbPercu.Size = new System.Drawing.Size(67, 21);
            this.cbPercu.TabIndex = 7;
            this.cbPercu.Text = "Perçu";
            this.cbPercu.UseVisualStyleBackColor = true;
            // 
            // cbRecette
            // 
            this.cbRecette.AutoSize = true;
            this.cbRecette.Location = new System.Drawing.Point(24, 186);
            this.cbRecette.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRecette.Name = "cbRecette";
            this.cbRecette.Size = new System.Drawing.Size(79, 21);
            this.cbRecette.TabIndex = 6;
            this.cbRecette.Text = "Recette";
            this.cbRecette.UseVisualStyleBackColor = true;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(24, 96);
            this.lblMontant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(59, 17);
            this.lblMontant.TabIndex = 4;
            this.lblMontant.Text = "Montant";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(24, 71);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(24, 41);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(132, 17);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date de la dépense";
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(252, 126);
            this.cbbType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(270, 24);
            this.cbbType.TabIndex = 1;
            // 
            // cbbDatedep
            // 
            this.cbbDatedep.FormattingEnabled = true;
            this.cbbDatedep.Location = new System.Drawing.Point(865, 390);
            this.cbbDatedep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbDatedep.Name = "cbbDatedep";
            this.cbbDatedep.Size = new System.Drawing.Size(243, 24);
            this.cbbDatedep.TabIndex = 0;
            // 
            // tabSuppression
            // 
            this.tabSuppression.Location = new System.Drawing.Point(4, 25);
            this.tabSuppression.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSuppression.Name = "tabSuppression";
            this.tabSuppression.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSuppression.Size = new System.Drawing.Size(1551, 589);
            this.tabSuppression.TabIndex = 2;
            this.tabSuppression.Text = "Suppression d\'une transaction";
            this.tabSuppression.UseVisualStyleBackColor = true;
            // 
            // TabModif
            // 
            this.TabModif.Location = new System.Drawing.Point(4, 25);
            this.TabModif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabModif.Name = "TabModif";
            this.TabModif.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabModif.Size = new System.Drawing.Size(1551, 589);
            this.TabModif.TabIndex = 3;
            this.TabModif.Text = "Modification d\'une transaction";
            this.TabModif.UseVisualStyleBackColor = true;
            // 
            // TabRecapitulatif
            // 
            this.TabRecapitulatif.Location = new System.Drawing.Point(4, 25);
            this.TabRecapitulatif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabRecapitulatif.Name = "TabRecapitulatif";
            this.TabRecapitulatif.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabRecapitulatif.Size = new System.Drawing.Size(1551, 589);
            this.TabRecapitulatif.TabIndex = 4;
            this.TabRecapitulatif.Text = "Récapitulatif";
            this.TabRecapitulatif.UseVisualStyleBackColor = true;
            // 
            // flpPersonne
            // 
            this.flpPersonne.AutoScroll = true;
            this.flpPersonne.Location = new System.Drawing.Point(750, 67);
            this.flpPersonne.Name = "flpPersonne";
            this.flpPersonne.Size = new System.Drawing.Size(229, 100);
            this.flpPersonne.TabIndex = 14;
            // 
            // FrmBudgetMois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 568);
            this.Controls.Add(this.TabAjout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.CheckBox cbPercu;
        private System.Windows.Forms.CheckBox cbRecette;
        private System.Windows.Forms.FlowLayoutPanel flpPersonne;
    }
}