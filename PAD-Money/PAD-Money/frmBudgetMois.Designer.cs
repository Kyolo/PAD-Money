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
            this.TabBudgetMois = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TabTransac = new System.Windows.Forms.TabPage();
            this.btnAjouterType = new System.Windows.Forms.Button();
            this.flpPersonne = new System.Windows.Forms.FlowLayoutPanel();
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
            this.tabSuppression = new System.Windows.Forms.TabPage();
            this.lblRorP = new System.Windows.Forms.Label();
            this.lblType2 = new System.Windows.Forms.Label();
            this.lblMontant2 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.btnSupp = new System.Windows.Forms.Button();
            this.cbbTransactionExistantes = new System.Windows.Forms.ComboBox();
            this.TabModif = new System.Windows.Forms.TabPage();
            this.cbPercuModif = new System.Windows.Forms.CheckBox();
            this.cbRecuModif = new System.Windows.Forms.CheckBox();
            this.cbbChoixtransacModif = new System.Windows.Forms.ComboBox();
            this.btnAjouterInModif = new System.Windows.Forms.Button();
            this.flpListePersonneInModif = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTyp = new System.Windows.Forms.Label();
            this.dtmDateModif = new System.Windows.Forms.DateTimePicker();
            this.txbMontantModif = new System.Windows.Forms.TextBox();
            this.txbDescriptionModif = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouterPersonneInModif = new System.Windows.Forms.Button();
            this.lblMont = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblDatedep = new System.Windows.Forms.Label();
            this.cbbTypeModif = new System.Windows.Forms.ComboBox();
            this.TabRecapitulatif = new System.Windows.Forms.TabPage();
            this.lblFinPer = new System.Windows.Forms.Label();
            this.lblDebPer = new System.Windows.Forms.Label();
            this.dtpFinPer = new System.Windows.Forms.DateTimePicker();
            this.dtpDebPer = new System.Windows.Forms.DateTimePicker();
            this.btnPDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPerca = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TabBudgetMois.SuspendLayout();
            this.TabTransac.SuspendLayout();
            this.tabSuppression.SuspendLayout();
            this.TabModif.SuspendLayout();
            this.TabRecapitulatif.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabBudgetMois
            // 
            this.TabBudgetMois.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabBudgetMois.Controls.Add(this.tabPage1);
            this.TabBudgetMois.Controls.Add(this.TabTransac);
            this.TabBudgetMois.Controls.Add(this.tabSuppression);
            this.TabBudgetMois.Controls.Add(this.TabModif);
            this.TabBudgetMois.Controls.Add(this.TabRecapitulatif);
            this.TabBudgetMois.Location = new System.Drawing.Point(-2, 1);
            this.TabBudgetMois.Margin = new System.Windows.Forms.Padding(4);
            this.TabBudgetMois.Name = "TabBudgetMois";
            this.TabBudgetMois.SelectedIndex = 0;
            this.TabBudgetMois.Size = new System.Drawing.Size(1577, 632);
            this.TabBudgetMois.TabIndex = 0;
            this.TabBudgetMois.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabAjout_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1569, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Affichage 1 à 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TabTransac
            // 
            this.TabTransac.BackColor = System.Drawing.Color.DimGray;
            this.TabTransac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TabTransac.Controls.Add(this.btnAjouterType);
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
            this.TabTransac.Controls.Add(this.label1);
            this.TabTransac.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabTransac.Location = new System.Drawing.Point(4, 28);
            this.TabTransac.Margin = new System.Windows.Forms.Padding(4);
            this.TabTransac.Name = "TabTransac";
            this.TabTransac.Padding = new System.Windows.Forms.Padding(4);
            this.TabTransac.Size = new System.Drawing.Size(1569, 600);
            this.TabTransac.TabIndex = 1;
            this.TabTransac.Text = "Ajout d\'une transaction";
            // 
            // btnAjouterType
            // 
            this.btnAjouterType.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterType.Location = new System.Drawing.Point(514, 214);
            this.btnAjouterType.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterType.Name = "btnAjouterType";
            this.btnAjouterType.Size = new System.Drawing.Size(139, 42);
            this.btnAjouterType.TabIndex = 15;
            this.btnAjouterType.Text = "Ajouter un type";
            this.btnAjouterType.UseVisualStyleBackColor = true;
            this.btnAjouterType.Click += new System.EventHandler(this.btnAjouterType_Click);
            // 
            // flpPersonne
            // 
            this.flpPersonne.AutoScroll = true;
            this.flpPersonne.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flpPersonne.Location = new System.Drawing.Point(711, 46);
            this.flpPersonne.Name = "flpPersonne";
            this.flpPersonne.Size = new System.Drawing.Size(229, 175);
            this.flpPersonne.TabIndex = 14;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(34, 217);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(49, 22);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Type";
            // 
            // dtpDepense
            // 
            this.dtpDepense.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark;
            this.dtpDepense.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDepense.Location = new System.Drawing.Point(226, 47);
            this.dtpDepense.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDepense.Name = "dtpDepense";
            this.dtpDepense.Size = new System.Drawing.Size(270, 23);
            this.dtpDepense.TabIndex = 12;
            // 
            // txtMontant
            // 
            this.txtMontant.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtMontant.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontant.Location = new System.Drawing.Point(226, 158);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(270, 27);
            this.txtMontant.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtDescription.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescription.Location = new System.Drawing.Point(226, 102);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(270, 27);
            this.txtDescription.TabIndex = 10;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjouter.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(65, 403);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(183, 74);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter la transaction";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAjouterPers
            // 
            this.btnAjouterPers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPers.Location = new System.Drawing.Point(898, 232);
            this.btnAjouterPers.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterPers.Name = "btnAjouterPers";
            this.btnAjouterPers.Size = new System.Drawing.Size(161, 87);
            this.btnAjouterPers.TabIndex = 8;
            this.btnAjouterPers.Text = "Ajouter une personne";
            this.btnAjouterPers.UseVisualStyleBackColor = true;
            // 
            // cbPercu
            // 
            this.cbPercu.AutoSize = true;
            this.cbPercu.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPercu.Location = new System.Drawing.Point(169, 310);
            this.cbPercu.Margin = new System.Windows.Forms.Padding(4);
            this.cbPercu.Name = "cbPercu";
            this.cbPercu.Size = new System.Drawing.Size(79, 26);
            this.cbPercu.TabIndex = 7;
            this.cbPercu.Text = "Perçu";
            this.cbPercu.UseVisualStyleBackColor = true;
            // 
            // cbRecette
            // 
            this.cbRecette.AutoSize = true;
            this.cbRecette.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRecette.Location = new System.Drawing.Point(38, 310);
            this.cbRecette.Margin = new System.Windows.Forms.Padding(4);
            this.cbRecette.Name = "cbRecette";
            this.cbRecette.Size = new System.Drawing.Size(90, 26);
            this.cbRecette.TabIndex = 6;
            this.cbRecette.Text = "Recette";
            this.cbRecette.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbRecette.UseVisualStyleBackColor = true;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.Location = new System.Drawing.Point(34, 155);
            this.lblMontant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(79, 22);
            this.lblMontant.TabIndex = 4;
            this.lblMontant.Text = "Montant";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(34, 99);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(104, 22);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDate.Location = new System.Drawing.Point(34, 46);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new System.Windows.Forms.Padding(1);
            this.lblDate.Size = new System.Drawing.Size(160, 24);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date de la dépense";
            // 
            // cbbType
            // 
            this.cbbType.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbbType.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(226, 213);
            this.cbbType.Margin = new System.Windows.Forms.Padding(4);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(270, 31);
            this.cbbType.TabIndex = 1;
            // 
            // tabSuppression
            // 
            this.tabSuppression.BackColor = System.Drawing.Color.DimGray;
            this.tabSuppression.Controls.Add(this.label10);
            this.tabSuppression.Controls.Add(this.label9);
            this.tabSuppression.Controls.Add(this.label8);
            this.tabSuppression.Controls.Add(this.label7);
            this.tabSuppression.Controls.Add(this.label6);
            this.tabSuppression.Controls.Add(this.lblPerca);
            this.tabSuppression.Controls.Add(this.label2);
            this.tabSuppression.Controls.Add(this.lblRorP);
            this.tabSuppression.Controls.Add(this.lblType2);
            this.tabSuppression.Controls.Add(this.lblMontant2);
            this.tabSuppression.Controls.Add(this.lblDescription2);
            this.tabSuppression.Controls.Add(this.lblDate2);
            this.tabSuppression.Controls.Add(this.btnSupp);
            this.tabSuppression.Controls.Add(this.cbbTransactionExistantes);
            this.tabSuppression.Location = new System.Drawing.Point(4, 28);
            this.tabSuppression.Margin = new System.Windows.Forms.Padding(4);
            this.tabSuppression.Name = "tabSuppression";
            this.tabSuppression.Padding = new System.Windows.Forms.Padding(4);
            this.tabSuppression.Size = new System.Drawing.Size(1569, 600);
            this.tabSuppression.TabIndex = 2;
            this.tabSuppression.Text = "Suppression d\'une transaction";
            // 
            // lblRorP
            // 
            this.lblRorP.AutoSize = true;
            this.lblRorP.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRorP.Location = new System.Drawing.Point(225, 362);
            this.lblRorP.Name = "lblRorP";
            this.lblRorP.Size = new System.Drawing.Size(79, 29);
            this.lblRorP.TabIndex = 6;
            this.lblRorP.Text = "label1";
            // 
            // lblType2
            // 
            this.lblType2.AutoSize = true;
            this.lblType2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType2.Location = new System.Drawing.Point(225, 310);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(79, 29);
            this.lblType2.TabIndex = 5;
            this.lblType2.Text = "label4";
            // 
            // lblMontant2
            // 
            this.lblMontant2.AutoSize = true;
            this.lblMontant2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant2.Location = new System.Drawing.Point(225, 256);
            this.lblMontant2.Name = "lblMontant2";
            this.lblMontant2.Size = new System.Drawing.Size(79, 29);
            this.lblMontant2.TabIndex = 4;
            this.lblMontant2.Text = "label3";
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription2.Location = new System.Drawing.Point(225, 203);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(79, 29);
            this.lblDescription2.TabIndex = 3;
            this.lblDescription2.Text = "label2";
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate2.Location = new System.Drawing.Point(225, 152);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(79, 29);
            this.lblDate2.TabIndex = 2;
            this.lblDate2.Text = "label1";
            this.lblDate2.Click += new System.EventHandler(this.lblDate2_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.Location = new System.Drawing.Point(539, 131);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(171, 70);
            this.btnSupp.TabIndex = 1;
            this.btnSupp.Text = "Supprimer la transaction";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // cbbTransactionExistantes
            // 
            this.cbbTransactionExistantes.BackColor = System.Drawing.Color.DarkGray;
            this.cbbTransactionExistantes.FormattingEnabled = true;
            this.cbbTransactionExistantes.Location = new System.Drawing.Point(230, 73);
            this.cbbTransactionExistantes.Name = "cbbTransactionExistantes";
            this.cbbTransactionExistantes.Size = new System.Drawing.Size(208, 24);
            this.cbbTransactionExistantes.TabIndex = 0;
            // 
            // TabModif
            // 
            this.TabModif.BackColor = System.Drawing.Color.DimGray;
            this.TabModif.Controls.Add(this.label4);
            this.TabModif.Controls.Add(this.cbPercuModif);
            this.TabModif.Controls.Add(this.cbRecuModif);
            this.TabModif.Controls.Add(this.cbbChoixtransacModif);
            this.TabModif.Controls.Add(this.btnAjouterInModif);
            this.TabModif.Controls.Add(this.flpListePersonneInModif);
            this.TabModif.Controls.Add(this.lblTyp);
            this.TabModif.Controls.Add(this.dtmDateModif);
            this.TabModif.Controls.Add(this.txbMontantModif);
            this.TabModif.Controls.Add(this.txbDescriptionModif);
            this.TabModif.Controls.Add(this.btnModifier);
            this.TabModif.Controls.Add(this.btnAjouterPersonneInModif);
            this.TabModif.Controls.Add(this.lblMont);
            this.TabModif.Controls.Add(this.lblDesc);
            this.TabModif.Controls.Add(this.lblDatedep);
            this.TabModif.Controls.Add(this.cbbTypeModif);
            this.TabModif.Controls.Add(this.label3);
            this.TabModif.Location = new System.Drawing.Point(4, 28);
            this.TabModif.Margin = new System.Windows.Forms.Padding(4);
            this.TabModif.Name = "TabModif";
            this.TabModif.Padding = new System.Windows.Forms.Padding(4);
            this.TabModif.Size = new System.Drawing.Size(1569, 600);
            this.TabModif.TabIndex = 3;
            this.TabModif.Text = "Modification d\'une transaction";
            this.TabModif.Click += new System.EventHandler(this.TabModif_Click);
            // 
            // cbPercuModif
            // 
            this.cbPercuModif.AutoSize = true;
            this.cbPercuModif.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPercuModif.Location = new System.Drawing.Point(174, 314);
            this.cbPercuModif.Name = "cbPercuModif";
            this.cbPercuModif.Size = new System.Drawing.Size(79, 26);
            this.cbPercuModif.TabIndex = 32;
            this.cbPercuModif.Text = "Perçu";
            this.cbPercuModif.UseVisualStyleBackColor = true;
            // 
            // cbRecuModif
            // 
            this.cbRecuModif.AutoSize = true;
            this.cbRecuModif.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRecuModif.Location = new System.Drawing.Point(29, 314);
            this.cbRecuModif.Name = "cbRecuModif";
            this.cbRecuModif.Size = new System.Drawing.Size(72, 26);
            this.cbRecuModif.TabIndex = 31;
            this.cbRecuModif.Text = "Reçu";
            this.cbRecuModif.UseVisualStyleBackColor = true;
            // 
            // cbbChoixtransacModif
            // 
            this.cbbChoixtransacModif.BackColor = System.Drawing.Color.DarkGray;
            this.cbbChoixtransacModif.FormattingEnabled = true;
            this.cbbChoixtransacModif.Location = new System.Drawing.Point(229, 38);
            this.cbbChoixtransacModif.Name = "cbbChoixtransacModif";
            this.cbbChoixtransacModif.Size = new System.Drawing.Size(181, 24);
            this.cbbChoixtransacModif.TabIndex = 30;
            this.cbbChoixtransacModif.SelectedValueChanged += new System.EventHandler(this.cbbChoixtransacModif_SelectedValueChanged);
            // 
            // btnAjouterInModif
            // 
            this.btnAjouterInModif.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterInModif.Location = new System.Drawing.Point(520, 231);
            this.btnAjouterInModif.Name = "btnAjouterInModif";
            this.btnAjouterInModif.Size = new System.Drawing.Size(81, 32);
            this.btnAjouterInModif.TabIndex = 29;
            this.btnAjouterInModif.Text = "Ajouter un type";
            this.btnAjouterInModif.UseVisualStyleBackColor = true;
            this.btnAjouterInModif.Click += new System.EventHandler(this.btnAjouterInModif_Click);
            // 
            // flpListePersonneInModif
            // 
            this.flpListePersonneInModif.AutoScroll = true;
            this.flpListePersonneInModif.BackColor = System.Drawing.Color.DarkGray;
            this.flpListePersonneInModif.Location = new System.Drawing.Point(690, 48);
            this.flpListePersonneInModif.Name = "flpListePersonneInModif";
            this.flpListePersonneInModif.Size = new System.Drawing.Size(229, 167);
            this.flpListePersonneInModif.TabIndex = 28;
            // 
            // lblTyp
            // 
            this.lblTyp.AutoSize = true;
            this.lblTyp.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTyp.Location = new System.Drawing.Point(25, 240);
            this.lblTyp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTyp.Name = "lblTyp";
            this.lblTyp.Size = new System.Drawing.Size(49, 22);
            this.lblTyp.TabIndex = 27;
            this.lblTyp.Text = "Type";
            // 
            // dtmDateModif
            // 
            this.dtmDateModif.Location = new System.Drawing.Point(229, 108);
            this.dtmDateModif.Margin = new System.Windows.Forms.Padding(4);
            this.dtmDateModif.Name = "dtmDateModif";
            this.dtmDateModif.Size = new System.Drawing.Size(270, 22);
            this.dtmDateModif.TabIndex = 26;
            // 
            // txbMontantModif
            // 
            this.txbMontantModif.BackColor = System.Drawing.Color.DarkGray;
            this.txbMontantModif.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMontantModif.Location = new System.Drawing.Point(229, 188);
            this.txbMontantModif.Margin = new System.Windows.Forms.Padding(4);
            this.txbMontantModif.Name = "txbMontantModif";
            this.txbMontantModif.Size = new System.Drawing.Size(270, 27);
            this.txbMontantModif.TabIndex = 25;
            // 
            // txbDescriptionModif
            // 
            this.txbDescriptionModif.BackColor = System.Drawing.Color.DarkGray;
            this.txbDescriptionModif.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescriptionModif.Location = new System.Drawing.Point(229, 147);
            this.txbDescriptionModif.Margin = new System.Windows.Forms.Padding(4);
            this.txbDescriptionModif.Name = "txbDescriptionModif";
            this.txbDescriptionModif.Size = new System.Drawing.Size(270, 27);
            this.txbDescriptionModif.TabIndex = 24;
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(29, 457);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(134, 30);
            this.btnModifier.TabIndex = 23;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouterPersonneInModif
            // 
            this.btnAjouterPersonneInModif.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPersonneInModif.Location = new System.Drawing.Point(894, 231);
            this.btnAjouterPersonneInModif.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterPersonneInModif.Name = "btnAjouterPersonneInModif";
            this.btnAjouterPersonneInModif.Size = new System.Drawing.Size(114, 60);
            this.btnAjouterPersonneInModif.TabIndex = 22;
            this.btnAjouterPersonneInModif.Text = "Ajouter une personne";
            this.btnAjouterPersonneInModif.UseVisualStyleBackColor = true;
            // 
            // lblMont
            // 
            this.lblMont.AutoSize = true;
            this.lblMont.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMont.Location = new System.Drawing.Point(22, 193);
            this.lblMont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMont.Name = "lblMont";
            this.lblMont.Size = new System.Drawing.Size(79, 22);
            this.lblMont.TabIndex = 19;
            this.lblMont.Text = "Montant";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(25, 152);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(104, 22);
            this.lblDesc.TabIndex = 18;
            this.lblDesc.Text = "Description";
            // 
            // lblDatedep
            // 
            this.lblDatedep.AutoSize = true;
            this.lblDatedep.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatedep.Location = new System.Drawing.Point(25, 108);
            this.lblDatedep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatedep.Name = "lblDatedep";
            this.lblDatedep.Size = new System.Drawing.Size(158, 22);
            this.lblDatedep.TabIndex = 17;
            this.lblDatedep.Text = "Date de la dépense";
            // 
            // cbbTypeModif
            // 
            this.cbbTypeModif.BackColor = System.Drawing.Color.DarkGray;
            this.cbbTypeModif.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeModif.FormattingEnabled = true;
            this.cbbTypeModif.Location = new System.Drawing.Point(229, 231);
            this.cbbTypeModif.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTypeModif.Name = "cbbTypeModif";
            this.cbbTypeModif.Size = new System.Drawing.Size(270, 31);
            this.cbbTypeModif.TabIndex = 16;
            // 
            // TabRecapitulatif
            // 
            this.TabRecapitulatif.BackColor = System.Drawing.Color.DimGray;
            this.TabRecapitulatif.Controls.Add(this.label5);
            this.TabRecapitulatif.Controls.Add(this.lblFinPer);
            this.TabRecapitulatif.Controls.Add(this.lblDebPer);
            this.TabRecapitulatif.Controls.Add(this.dtpFinPer);
            this.TabRecapitulatif.Controls.Add(this.dtpDebPer);
            this.TabRecapitulatif.Controls.Add(this.btnPDF);
            this.TabRecapitulatif.Location = new System.Drawing.Point(4, 28);
            this.TabRecapitulatif.Margin = new System.Windows.Forms.Padding(4);
            this.TabRecapitulatif.Name = "TabRecapitulatif";
            this.TabRecapitulatif.Padding = new System.Windows.Forms.Padding(4);
            this.TabRecapitulatif.Size = new System.Drawing.Size(1569, 600);
            this.TabRecapitulatif.TabIndex = 4;
            this.TabRecapitulatif.Text = "Récapitulatif";
            // 
            // lblFinPer
            // 
            this.lblFinPer.AutoSize = true;
            this.lblFinPer.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinPer.Location = new System.Drawing.Point(51, 205);
            this.lblFinPer.Name = "lblFinPer";
            this.lblFinPer.Size = new System.Drawing.Size(206, 22);
            this.lblFinPer.TabIndex = 5;
            this.lblFinPer.Text = "Fin de la période désirée";
            // 
            // lblDebPer
            // 
            this.lblDebPer.AutoSize = true;
            this.lblDebPer.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebPer.Location = new System.Drawing.Point(51, 99);
            this.lblDebPer.Name = "lblDebPer";
            this.lblDebPer.Size = new System.Drawing.Size(225, 22);
            this.lblDebPer.TabIndex = 4;
            this.lblDebPer.Text = "Début de la période désirée";
            // 
            // dtpFinPer
            // 
            this.dtpFinPer.Location = new System.Drawing.Point(324, 205);
            this.dtpFinPer.Name = "dtpFinPer";
            this.dtpFinPer.Size = new System.Drawing.Size(200, 22);
            this.dtpFinPer.TabIndex = 3;
            // 
            // dtpDebPer
            // 
            this.dtpDebPer.Location = new System.Drawing.Point(324, 99);
            this.dtpDebPer.Name = "dtpDebPer";
            this.dtpDebPer.Size = new System.Drawing.Size(200, 22);
            this.dtpDebPer.TabIndex = 2;
            // 
            // btnPDF
            // 
            this.btnPDF.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Location = new System.Drawing.Point(55, 303);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(225, 76);
            this.btnPDF.TabIndex = 0;
            this.btnPDF.Text = "Créer le PFD";
            this.btnPDF.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(422, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 250);
            this.label1.TabIndex = 16;
            this.label1.Text = "€ $ £";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(438, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 250);
            this.label2.TabIndex = 17;
            this.label2.Text = "€ $ £";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(435, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(540, 250);
            this.label3.TabIndex = 33;
            this.label3.Text = "€ $ £";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 34;
            this.label4.Text = "Transaction :";
            // 
            // lblPerca
            // 
            this.lblPerca.AutoSize = true;
            this.lblPerca.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerca.Location = new System.Drawing.Point(30, 362);
            this.lblPerca.Name = "lblPerca";
            this.lblPerca.Size = new System.Drawing.Size(79, 29);
            this.lblPerca.TabIndex = 18;
            this.lblPerca.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Type :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Montant :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "Description :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 29);
            this.label9.TabIndex = 22;
            this.label9.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FloralWhite;
            this.label5.Location = new System.Drawing.Point(430, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(540, 250);
            this.label5.TabIndex = 34;
            this.label5.Text = "€ $ £";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Transaction :";
            // 
            // FrmBudgetMois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 568);
            this.Controls.Add(this.TabBudgetMois);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmBudgetMois";
            this.Text = "frmBudgetMois";
            this.TabBudgetMois.ResumeLayout(false);
            this.TabTransac.ResumeLayout(false);
            this.TabTransac.PerformLayout();
            this.tabSuppression.ResumeLayout(false);
            this.tabSuppression.PerformLayout();
            this.TabModif.ResumeLayout(false);
            this.TabModif.PerformLayout();
            this.TabRecapitulatif.ResumeLayout(false);
            this.TabRecapitulatif.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabBudgetMois;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage TabTransac;
        private System.Windows.Forms.TabPage tabSuppression;
        private System.Windows.Forms.TabPage TabModif;
        private System.Windows.Forms.TabPage TabRecapitulatif;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAjouterPers;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpDepense;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.CheckBox cbPercu;
        private System.Windows.Forms.CheckBox cbRecette;
        private System.Windows.Forms.FlowLayoutPanel flpPersonne;
        private System.Windows.Forms.Button btnAjouterType;
        private System.Windows.Forms.ComboBox cbbTransactionExistantes;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Label lblType2;
        private System.Windows.Forms.Label lblMontant2;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Label lblRorP;
        private System.Windows.Forms.ComboBox cbbChoixtransacModif;
        private System.Windows.Forms.Button btnAjouterInModif;
        private System.Windows.Forms.FlowLayoutPanel flpListePersonneInModif;
        private System.Windows.Forms.Label lblTyp;
        private System.Windows.Forms.DateTimePicker dtmDateModif;
        private System.Windows.Forms.TextBox txbMontantModif;
        private System.Windows.Forms.TextBox txbDescriptionModif;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouterPersonneInModif;
        private System.Windows.Forms.Label lblMont;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblDatedep;
        private System.Windows.Forms.ComboBox cbbTypeModif;
        private System.Windows.Forms.CheckBox cbPercuModif;
        private System.Windows.Forms.CheckBox cbRecuModif;
        private System.Windows.Forms.DateTimePicker dtpDebPer;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label lblFinPer;
        private System.Windows.Forms.Label lblDebPer;
        private System.Windows.Forms.DateTimePicker dtpFinPer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPerca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
    }
}