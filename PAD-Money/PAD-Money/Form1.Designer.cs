namespace PAD_Money
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBudgetMois = new System.Windows.Forms.Button();
            this.btnBudgetPrevi = new System.Windows.Forms.Button();
            this.btnAide = new System.Windows.Forms.Button();
            this.btnOuvrirBase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBudgetMois
            // 
            this.btnBudgetMois.Location = new System.Drawing.Point(20, 20);
            this.btnBudgetMois.Name = "btnBudgetMois";
            this.btnBudgetMois.Size = new System.Drawing.Size(75, 23);
            this.btnBudgetMois.TabIndex = 0;
            this.btnBudgetMois.Text = "Budget du mois";
            this.btnBudgetMois.UseVisualStyleBackColor = true;
            this.btnAide.Enabled = false;
            this.btnBudgetMois.Click += new System.EventHandler(this.btnBudgetMois_Click);
            // 
            // btnBudgetPrevi
            // 
            this.btnBudgetPrevi.Location = new System.Drawing.Point(105, 20);
            this.btnBudgetPrevi.Name = "btnBudgetPrevi";
            this.btnBudgetPrevi.Size = new System.Drawing.Size(75, 23);
            this.btnBudgetPrevi.TabIndex = 1;
            this.btnBudgetPrevi.Text = "Budget Previsionnel";
            this.btnBudgetPrevi.UseVisualStyleBackColor = true;
            this.btnAide.Enabled = false;
            this.btnBudgetPrevi.Click += new System.EventHandler(this.btnBudgetPrevi_Click);
            // 
            // btnAide
            // 
            this.btnAide.Location = new System.Drawing.Point(68, 106);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(75, 23);
            this.btnAide.TabIndex = 2;
            this.btnAide.Text = "Aide (NYI WIP)";
            this.btnAide.Enabled = false;
            this.btnAide.UseVisualStyleBackColor = true;
            // 
            // btnOuvrirBase
            // 
            this.btnOuvrirBase.Location = new System.Drawing.Point(68, 63);
            this.btnOuvrirBase.Name = "btnOuvrirBase";
            this.btnOuvrirBase.Size = new System.Drawing.Size(75, 23);
            this.btnOuvrirBase.TabIndex = 3;
            this.btnOuvrirBase.Text = "Ouvrir la base de donnée";
            this.btnOuvrirBase.UseVisualStyleBackColor = true;
            this.btnOuvrirBase.Click += new System.EventHandler(this.btnOuvrirBase_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 149);
            this.Controls.Add(this.btnOuvrirBase);
            this.Controls.Add(this.btnAide);
            this.Controls.Add(this.btnBudgetPrevi);
            this.Controls.Add(this.btnBudgetMois);
            this.Name = "frmMain";
            this.Text = "PAD_Money";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBudgetMois;
        private System.Windows.Forms.Button btnBudgetPrevi;
        private System.Windows.Forms.Button btnAide;
        private System.Windows.Forms.Button btnOuvrirBase;
    }
}

