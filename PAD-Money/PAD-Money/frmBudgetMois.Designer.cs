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
            this.TabModif = new System.Windows.Forms.TabPage();
            this.TabRecapitulatif = new System.Windows.Forms.TabPage();
            this.cbbTransactionExistantes = new System.Windows.Forms.ComboBox();
            this.btnSupp = new System.Windows.Forms.Button();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.lblMontant2 = new System.Windows.Forms.Label();
            this.lblType2 = new System.Windows.Forms.Label();
            this.lblRorP = new System.Windows.Forms.Label();
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
            this.cbbChoixtransacModif = new System.Windows.Forms.ComboBox();
            this.rdbRecetteModif = new System.Windows.Forms.RadioButton();
            this.rdbPercuModif = new System.Windows.Forms.RadioButton();
            this.rdbRecette = new System.Windows.Forms.RadioButton();
            this.rdbPercu = new System.Windows.Forms.RadioButton();
            this.TabAjout.SuspendLayout();
            this.TabTransac.SuspendLayout();
            this.tabSuppression.SuspendLayout();
            this.TabModif.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabAjout
            // 
            this.TabAjout.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabAjout.Controls.Add(this.tabPage1);
            this.TabAjout.Controls.Add(this.TabTransac);
            this.TabAjout.Controls.Add(this.tabSuppression);
            this.TabAjout.Controls.Add(this.TabModif);
            this.TabAjout.Controls.Add(this.TabRecapitulatif);
            this.TabAjout.Location = new System.Drawing.Point(-2, 1);
            this.TabAjout.Margin = new System.Windows.Forms.Padding(4);
            this.TabAjout.Name = "TabAjout";
            this.TabAjout.SelectedIndex = 0;
            this.TabAjout.Size = new System.Drawing.Size(1577, 632);
            this.TabAjout.TabIndex = 0;
            this.TabAjout.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabAjout_Selecting);
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
            this.TabTransac.BackColor = System.Drawing.Color.DarkGreen;
            this.TabTransac.Controls.Add(this.rdbPercu);
            this.TabTransac.Controls.Add(this.rdbRecette);
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
            this.btnAjouterType.Location = new System.Drawing.Point(543, 127);
            this.btnAjouterType.Name = "btnAjouterType";
            this.btnAjouterType.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterType.TabIndex = 15;
            this.btnAjouterType.Text = "ajouter";
            this.btnAjouterType.UseVisualStyleBackColor = true;
            // 
            // flpPersonne
            // 
            this.flpPersonne.AutoScroll = true;
            this.flpPersonne.Location = new System.Drawing.Point(750, 67);
            this.flpPersonne.Name = "flpPersonne";
            this.flpPersonne.Size = new System.Drawing.Size(229, 100);
            this.flpPersonne.TabIndex = 14;
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
            this.dtpDepense.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDepense.Name = "dtpDepense";
            this.dtpDepense.Size = new System.Drawing.Size(270, 22);
            this.dtpDepense.TabIndex = 12;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(252, 96);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(270, 22);
            this.txtMontant.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(252, 66);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(270, 15);
            this.txtDescription.TabIndex = 10;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(27, 299);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnAjouterPers.Margin = new System.Windows.Forms.Padding(4);
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
            this.cbPercu.Margin = new System.Windows.Forms.Padding(4);
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
            this.cbRecette.Margin = new System.Windows.Forms.Padding(4);
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
            this.cbbType.Margin = new System.Windows.Forms.Padding(4);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(270, 24);
            this.cbbType.TabIndex = 1;
            // 
            // tabSuppression
            // 
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
            this.tabSuppression.UseVisualStyleBackColor = true;
            // 
            // TabModif
            // 
            this.TabModif.Controls.Add(this.rdbPercuModif);
            this.TabModif.Controls.Add(this.rdbRecetteModif);
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
            this.TabModif.Location = new System.Drawing.Point(4, 28);
            this.TabModif.Margin = new System.Windows.Forms.Padding(4);
            this.TabModif.Name = "TabModif";
            this.TabModif.Padding = new System.Windows.Forms.Padding(4);
            this.TabModif.Size = new System.Drawing.Size(1569, 600);
            this.TabModif.TabIndex = 3;
            this.TabModif.Text = "Modification d\'une transaction";
            this.TabModif.UseVisualStyleBackColor = true;
            // 
            // TabRecapitulatif
            // 
            this.TabRecapitulatif.Location = new System.Drawing.Point(4, 28);
            this.TabRecapitulatif.Margin = new System.Windows.Forms.Padding(4);
            this.TabRecapitulatif.Name = "TabRecapitulatif";
            this.TabRecapitulatif.Padding = new System.Windows.Forms.Padding(4);
            this.TabRecapitulatif.Size = new System.Drawing.Size(1569, 600);
            this.TabRecapitulatif.TabIndex = 4;
            this.TabRecapitulatif.Text = "Récapitulatif";
            this.TabRecapitulatif.UseVisualStyleBackColor = true;
            // 
            // cbbTransactionExistantes
            // 
            this.cbbTransactionExistantes.FormattingEnabled = true;
            this.cbbTransactionExistantes.Location = new System.Drawing.Point(135, 73);
            this.cbbTransactionExistantes.Name = "cbbTransactionExistantes";
            this.cbbTransactionExistantes.Size = new System.Drawing.Size(208, 24);
            this.cbbTransactionExistantes.TabIndex = 0;
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(566, 410);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(109, 52);
            this.btnSupp.TabIndex = 1;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Location = new System.Drawing.Point(132, 162);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(46, 17);
            this.lblDate2.TabIndex = 2;
            this.lblDate2.Text = "label1";
            this.lblDate2.Click += new System.EventHandler(this.lblDate2_Click);
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Location = new System.Drawing.Point(132, 206);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(46, 17);
            this.lblDescription2.TabIndex = 3;
            this.lblDescription2.Text = "label2";
            // 
            // lblMontant2
            // 
            this.lblMontant2.AutoSize = true;
            this.lblMontant2.Location = new System.Drawing.Point(132, 256);
            this.lblMontant2.Name = "lblMontant2";
            this.lblMontant2.Size = new System.Drawing.Size(46, 17);
            this.lblMontant2.TabIndex = 4;
            this.lblMontant2.Text = "label3";
            // 
            // lblType2
            // 
            this.lblType2.AutoSize = true;
            this.lblType2.Location = new System.Drawing.Point(132, 302);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(46, 17);
            this.lblType2.TabIndex = 5;
            this.lblType2.Text = "label4";
            // 
            // lblRorP
            // 
            this.lblRorP.AutoSize = true;
            this.lblRorP.Location = new System.Drawing.Point(132, 357);
            this.lblRorP.Name = "lblRorP";
            this.lblRorP.Size = new System.Drawing.Size(46, 17);
            this.lblRorP.TabIndex = 6;
            this.lblRorP.Text = "label1";
            // 
            // btnAjouterInModif
            // 
            this.btnAjouterInModif.Location = new System.Drawing.Point(544, 190);
            this.btnAjouterInModif.Name = "btnAjouterInModif";
            this.btnAjouterInModif.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterInModif.TabIndex = 29;
            this.btnAjouterInModif.Text = "ajouter";
            this.btnAjouterInModif.UseVisualStyleBackColor = true;
            // 
            // flpListePersonneInModif
            // 
            this.flpListePersonneInModif.AutoScroll = true;
            this.flpListePersonneInModif.Location = new System.Drawing.Point(751, 130);
            this.flpListePersonneInModif.Name = "flpListePersonneInModif";
            this.flpListePersonneInModif.Size = new System.Drawing.Size(229, 100);
            this.flpListePersonneInModif.TabIndex = 28;
            // 
            // lblTyp
            // 
            this.lblTyp.AutoSize = true;
            this.lblTyp.Location = new System.Drawing.Point(25, 189);
            this.lblTyp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTyp.Name = "lblTyp";
            this.lblTyp.Size = new System.Drawing.Size(40, 17);
            this.lblTyp.TabIndex = 27;
            this.lblTyp.Text = "Type";
            // 
            // dtmDateModif
            // 
            this.dtmDateModif.Location = new System.Drawing.Point(253, 99);
            this.dtmDateModif.Margin = new System.Windows.Forms.Padding(4);
            this.dtmDateModif.Name = "dtmDateModif";
            this.dtmDateModif.Size = new System.Drawing.Size(270, 22);
            this.dtmDateModif.TabIndex = 26;
            // 
            // txbMontantModif
            // 
            this.txbMontantModif.Location = new System.Drawing.Point(253, 159);
            this.txbMontantModif.Margin = new System.Windows.Forms.Padding(4);
            this.txbMontantModif.Name = "txbMontantModif";
            this.txbMontantModif.Size = new System.Drawing.Size(270, 22);
            this.txbMontantModif.TabIndex = 25;
            // 
            // txbDescriptionModif
            // 
            this.txbDescriptionModif.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txbDescriptionModif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDescriptionModif.Location = new System.Drawing.Point(253, 129);
            this.txbDescriptionModif.Margin = new System.Windows.Forms.Padding(4);
            this.txbDescriptionModif.Name = "txbDescriptionModif";
            this.txbDescriptionModif.Size = new System.Drawing.Size(270, 15);
            this.txbDescriptionModif.TabIndex = 24;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(28, 362);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 28);
            this.btnModifier.TabIndex = 23;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouterPersonneInModif
            // 
            this.btnAjouterPersonneInModif.Location = new System.Drawing.Point(1014, 136);
            this.btnAjouterPersonneInModif.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterPersonneInModif.Name = "btnAjouterPersonneInModif";
            this.btnAjouterPersonneInModif.Size = new System.Drawing.Size(248, 77);
            this.btnAjouterPersonneInModif.TabIndex = 22;
            this.btnAjouterPersonneInModif.Text = "Ajouter une personne";
            this.btnAjouterPersonneInModif.UseVisualStyleBackColor = true;
            // 
            // lblMont
            // 
            this.lblMont.AutoSize = true;
            this.lblMont.Location = new System.Drawing.Point(25, 159);
            this.lblMont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMont.Name = "lblMont";
            this.lblMont.Size = new System.Drawing.Size(59, 17);
            this.lblMont.TabIndex = 19;
            this.lblMont.Text = "Montant";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(25, 134);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(79, 17);
            this.lblDesc.TabIndex = 18;
            this.lblDesc.Text = "Description";
            // 
            // lblDatedep
            // 
            this.lblDatedep.AutoSize = true;
            this.lblDatedep.Location = new System.Drawing.Point(25, 104);
            this.lblDatedep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatedep.Name = "lblDatedep";
            this.lblDatedep.Size = new System.Drawing.Size(132, 17);
            this.lblDatedep.TabIndex = 17;
            this.lblDatedep.Text = "Date de la dépense";
            // 
            // cbbTypeModif
            // 
            this.cbbTypeModif.FormattingEnabled = true;
            this.cbbTypeModif.Location = new System.Drawing.Point(253, 189);
            this.cbbTypeModif.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTypeModif.Name = "cbbTypeModif";
            this.cbbTypeModif.Size = new System.Drawing.Size(270, 24);
            this.cbbTypeModif.TabIndex = 16;
            // 
            // cbbChoixtransacModif
            // 
            this.cbbChoixtransacModif.FormattingEnabled = true;
            this.cbbChoixtransacModif.Location = new System.Drawing.Point(105, 37);
            this.cbbChoixtransacModif.Name = "cbbChoixtransacModif";
            this.cbbChoixtransacModif.Size = new System.Drawing.Size(208, 24);
            this.cbbChoixtransacModif.TabIndex = 30;
            this.cbbChoixtransacModif.SelectedValueChanged += new System.EventHandler(this.cbbChoixtransacModif_SelectedValueChanged);
            // 
            // rdbRecetteModif
            // 
            this.rdbRecetteModif.AutoSize = true;
            this.rdbRecetteModif.Location = new System.Drawing.Point(25, 304);
            this.rdbRecetteModif.Name = "rdbRecetteModif";
            this.rdbRecetteModif.Size = new System.Drawing.Size(78, 21);
            this.rdbRecetteModif.TabIndex = 31;
            this.rdbRecetteModif.TabStop = true;
            this.rdbRecetteModif.Text = "Recette";
            this.rdbRecetteModif.UseVisualStyleBackColor = true;
            // 
            // rdbPercuModif
            // 
            this.rdbPercuModif.AutoSize = true;
            this.rdbPercuModif.Location = new System.Drawing.Point(188, 304);
            this.rdbPercuModif.Name = "rdbPercuModif";
            this.rdbPercuModif.Size = new System.Drawing.Size(66, 21);
            this.rdbPercuModif.TabIndex = 32;
            this.rdbPercuModif.TabStop = true;
            this.rdbPercuModif.Text = "Perçu";
            this.rdbPercuModif.UseVisualStyleBackColor = true;
            // 
            // rdbRecette
            // 
            this.rdbRecette.AutoSize = true;
            this.rdbRecette.Location = new System.Drawing.Point(24, 230);
            this.rdbRecette.Name = "rdbRecette";
            this.rdbRecette.Size = new System.Drawing.Size(78, 21);
            this.rdbRecette.TabIndex = 16;
            this.rdbRecette.TabStop = true;
            this.rdbRecette.Text = "Recette";
            this.rdbRecette.UseVisualStyleBackColor = true;
            // 
            // rdbPercu
            // 
            this.rdbPercu.AutoSize = true;
            this.rdbPercu.Location = new System.Drawing.Point(187, 230);
            this.rdbPercu.Name = "rdbPercu";
            this.rdbPercu.Size = new System.Drawing.Size(66, 21);
            this.rdbPercu.TabIndex = 17;
            this.rdbPercu.TabStop = true;
            this.rdbPercu.Text = "Perçu";
            this.rdbPercu.UseVisualStyleBackColor = true;
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
            this.tabSuppression.ResumeLayout(false);
            this.tabSuppression.PerformLayout();
            this.TabModif.ResumeLayout(false);
            this.TabModif.PerformLayout();
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
        private System.Windows.Forms.RadioButton rdbPercuModif;
        private System.Windows.Forms.RadioButton rdbRecetteModif;
        private System.Windows.Forms.RadioButton rdbPercu;
        private System.Windows.Forms.RadioButton rdbRecette;
    }
}