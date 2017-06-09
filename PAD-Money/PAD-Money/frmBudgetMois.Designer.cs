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
            this.lblMontant1v1 = new System.Windows.Forms.Label();
            this.lblType1v1 = new System.Windows.Forms.Label();
            this.lblDescrtion1v1 = new System.Windows.Forms.Label();
            this.lblNumPage = new System.Windows.Forms.Label();
            this.dtp1v1 = new System.Windows.Forms.DateTimePicker();
            this.cbPercu1v1 = new System.Windows.Forms.CheckBox();
            this.cbRecette1v1 = new System.Windows.Forms.CheckBox();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TabTransac = new System.Windows.Forms.TabPage();
            this.txbNom2 = new System.Windows.Forms.TextBox();
            this.btnAjouterType = new System.Windows.Forms.Button();
            this.txbPrenom1 = new System.Windows.Forms.TextBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabSuppression = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPerca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRorP = new System.Windows.Forms.Label();
            this.lblType2 = new System.Windows.Forms.Label();
            this.lblMontant2 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.btnSupp = new System.Windows.Forms.Button();
            this.cbbTransactionExistantes = new System.Windows.Forms.ComboBox();
            this.TabModif = new System.Windows.Forms.TabPage();
            this.txbPrenom = new System.Windows.Forms.TextBox();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label3 = new System.Windows.Forms.Label();
            this.TabRecapitulatif = new System.Windows.Forms.TabPage();
            this.lblFinPer = new System.Windows.Forms.Label();
            this.lblDebPer = new System.Windows.Forms.Label();
            this.dtpFinPer = new System.Windows.Forms.DateTimePicker();
            this.dtpDebPer = new System.Windows.Forms.DateTimePicker();
            this.btnPDF = new System.Windows.Forms.Button();
            this.dgvFinal = new System.Windows.Forms.DataGridView();
            this.TabBudgetMois.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TabTransac.SuspendLayout();
            this.tabSuppression.SuspendLayout();
            this.TabModif.SuspendLayout();
            this.TabRecapitulatif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinal)).BeginInit();
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
            this.TabBudgetMois.Name = "TabBudgetMois";
            this.TabBudgetMois.SelectedIndex = 0;
            this.TabBudgetMois.Size = new System.Drawing.Size(1183, 514);
            this.TabBudgetMois.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage1.Controls.Add(this.lblMontant1v1);
            this.tabPage1.Controls.Add(this.lblType1v1);
            this.tabPage1.Controls.Add(this.lblDescrtion1v1);
            this.tabPage1.Controls.Add(this.lblNumPage);
            this.tabPage1.Controls.Add(this.dtp1v1);
            this.tabPage1.Controls.Add(this.cbPercu1v1);
            this.tabPage1.Controls.Add(this.cbRecette1v1);
            this.tabPage1.Controls.Add(this.btnDernier);
            this.tabPage1.Controls.Add(this.btnSuivant);
            this.tabPage1.Controls.Add(this.btnPrecedent);
            this.tabPage1.Controls.Add(this.btnFirst);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1175, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Affichage 1 à 1";
            // 
            // lblMontant1v1
            // 
            this.lblMontant1v1.AutoSize = true;
            this.lblMontant1v1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant1v1.Location = new System.Drawing.Point(502, 69);
            this.lblMontant1v1.Name = "lblMontant1v1";
            this.lblMontant1v1.Size = new System.Drawing.Size(53, 18);
            this.lblMontant1v1.TabIndex = 10;
            this.lblMontant1v1.Text = "label14";
            // 
            // lblType1v1
            // 
            this.lblType1v1.AutoSize = true;
            this.lblType1v1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType1v1.Location = new System.Drawing.Point(31, 69);
            this.lblType1v1.Name = "lblType1v1";
            this.lblType1v1.Size = new System.Drawing.Size(53, 18);
            this.lblType1v1.TabIndex = 9;
            this.lblType1v1.Text = "label13";
            // 
            // lblDescrtion1v1
            // 
            this.lblDescrtion1v1.AutoSize = true;
            this.lblDescrtion1v1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrtion1v1.Location = new System.Drawing.Point(31, 98);
            this.lblDescrtion1v1.Name = "lblDescrtion1v1";
            this.lblDescrtion1v1.Size = new System.Drawing.Size(53, 18);
            this.lblDescrtion1v1.TabIndex = 8;
            this.lblDescrtion1v1.Text = "label12";
            // 
            // lblNumPage
            // 
            this.lblNumPage.AutoSize = true;
            this.lblNumPage.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPage.Location = new System.Drawing.Point(31, 38);
            this.lblNumPage.Name = "lblNumPage";
            this.lblNumPage.Size = new System.Drawing.Size(53, 18);
            this.lblNumPage.TabIndex = 7;
            this.lblNumPage.Text = "label11";
            // 
            // dtp1v1
            // 
            this.dtp1v1.Location = new System.Drawing.Point(592, 24);
            this.dtp1v1.Name = "dtp1v1";
            this.dtp1v1.Size = new System.Drawing.Size(200, 20);
            this.dtp1v1.TabIndex = 6;
            // 
            // cbPercu1v1
            // 
            this.cbPercu1v1.AutoSize = true;
            this.cbPercu1v1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPercu1v1.Location = new System.Drawing.Point(617, 133);
            this.cbPercu1v1.Name = "cbPercu1v1";
            this.cbPercu1v1.Size = new System.Drawing.Size(63, 22);
            this.cbPercu1v1.TabIndex = 5;
            this.cbPercu1v1.Text = "Perçu";
            this.cbPercu1v1.UseVisualStyleBackColor = true;
            // 
            // cbRecette1v1
            // 
            this.cbRecette1v1.AutoSize = true;
            this.cbRecette1v1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRecette1v1.Location = new System.Drawing.Point(617, 98);
            this.cbRecette1v1.Name = "cbRecette1v1";
            this.cbRecette1v1.Size = new System.Drawing.Size(72, 22);
            this.cbRecette1v1.TabIndex = 4;
            this.cbRecette1v1.Text = "Recette";
            this.cbRecette1v1.UseVisualStyleBackColor = true;
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(539, 409);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(75, 23);
            this.btnDernier.TabIndex = 3;
            this.btnDernier.Tag = "4";
            this.btnDernier.Text = ">>";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(380, 409);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(75, 23);
            this.btnSuivant.TabIndex = 2;
            this.btnSuivant.Tag = "3";
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(234, 409);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(75, 23);
            this.btnPrecedent.TabIndex = 1;
            this.btnPrecedent.Tag = "2";
            this.btnPrecedent.Text = "<";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(90, 409);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Tag = "1";
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 170);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(756, 233);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // TabTransac
            // 
            this.TabTransac.BackColor = System.Drawing.Color.DimGray;
            this.TabTransac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TabTransac.Controls.Add(this.txbNom2);
            this.TabTransac.Controls.Add(this.btnAjouterType);
            this.TabTransac.Controls.Add(this.txbPrenom1);
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
            this.TabTransac.Location = new System.Drawing.Point(4, 25);
            this.TabTransac.Name = "TabTransac";
            this.TabTransac.Padding = new System.Windows.Forms.Padding(3);
            this.TabTransac.Size = new System.Drawing.Size(1175, 485);
            this.TabTransac.TabIndex = 1;
            this.TabTransac.Text = "Ajout d\'une transaction";
            // 
            // txbNom2
            // 
            this.txbNom2.BackColor = System.Drawing.Color.DarkGray;
            this.txbNom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNom2.Location = new System.Drawing.Point(551, 216);
            this.txbNom2.Margin = new System.Windows.Forms.Padding(2);
            this.txbNom2.Name = "txbNom2";
            this.txbNom2.Size = new System.Drawing.Size(102, 20);
            this.txbNom2.TabIndex = 2;
            // 
            // btnAjouterType
            // 
            this.btnAjouterType.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterType.Location = new System.Drawing.Point(386, 174);
            this.btnAjouterType.Name = "btnAjouterType";
            this.btnAjouterType.Size = new System.Drawing.Size(104, 34);
            this.btnAjouterType.TabIndex = 15;
            this.btnAjouterType.Text = "Ajouter un type";
            this.btnAjouterType.UseVisualStyleBackColor = true;
            this.btnAjouterType.Click += new System.EventHandler(this.btnAjouterType_Click);
            // 
            // txbPrenom1
            // 
            this.txbPrenom1.BackColor = System.Drawing.Color.Silver;
            this.txbPrenom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrenom1.Location = new System.Drawing.Point(551, 184);
            this.txbPrenom1.Margin = new System.Windows.Forms.Padding(2);
            this.txbPrenom1.Name = "txbPrenom1";
            this.txbPrenom1.Size = new System.Drawing.Size(102, 20);
            this.txbPrenom1.TabIndex = 1;
            // 
            // flpPersonne
            // 
            this.flpPersonne.AutoScroll = true;
            this.flpPersonne.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flpPersonne.Location = new System.Drawing.Point(533, 37);
            this.flpPersonne.Margin = new System.Windows.Forms.Padding(2);
            this.flpPersonne.Name = "flpPersonne";
            this.flpPersonne.Size = new System.Drawing.Size(172, 142);
            this.flpPersonne.TabIndex = 14;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(26, 176);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 18);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Type";
            // 
            // dtpDepense
            // 
            this.dtpDepense.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark;
            this.dtpDepense.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDepense.Location = new System.Drawing.Point(170, 38);
            this.dtpDepense.Name = "dtpDepense";
            this.dtpDepense.Size = new System.Drawing.Size(204, 20);
            this.dtpDepense.TabIndex = 12;
            // 
            // txtMontant
            // 
            this.txtMontant.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtMontant.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontant.Location = new System.Drawing.Point(170, 128);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(204, 23);
            this.txtMontant.TabIndex = 11;
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontant_KeyPress);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtDescription.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescription.Location = new System.Drawing.Point(170, 83);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(204, 23);
            this.txtDescription.TabIndex = 10;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjouter.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(49, 327);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(137, 60);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter la transaction";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAjouterPers
            // 
            this.btnAjouterPers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPers.Location = new System.Drawing.Point(674, 188);
            this.btnAjouterPers.Name = "btnAjouterPers";
            this.btnAjouterPers.Size = new System.Drawing.Size(121, 71);
            this.btnAjouterPers.TabIndex = 8;
            this.btnAjouterPers.Text = "Ajouter une personne";
            this.btnAjouterPers.UseVisualStyleBackColor = true;
            this.btnAjouterPers.Click += new System.EventHandler(this.btnAjouterPers_Click);
            // 
            // cbPercu
            // 
            this.cbPercu.AutoSize = true;
            this.cbPercu.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPercu.Location = new System.Drawing.Point(127, 252);
            this.cbPercu.Name = "cbPercu";
            this.cbPercu.Size = new System.Drawing.Size(63, 22);
            this.cbPercu.TabIndex = 7;
            this.cbPercu.Text = "Perçu";
            this.cbPercu.UseVisualStyleBackColor = true;
            // 
            // cbRecette
            // 
            this.cbRecette.AutoSize = true;
            this.cbRecette.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRecette.Location = new System.Drawing.Point(28, 252);
            this.cbRecette.Name = "cbRecette";
            this.cbRecette.Size = new System.Drawing.Size(72, 22);
            this.cbRecette.TabIndex = 6;
            this.cbRecette.Text = "Recette";
            this.cbRecette.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbRecette.UseVisualStyleBackColor = true;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.Location = new System.Drawing.Point(26, 126);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(64, 18);
            this.lblMontant.TabIndex = 4;
            this.lblMontant.Text = "Montant";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(26, 80);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 18);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDate.Location = new System.Drawing.Point(26, 37);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new System.Windows.Forms.Padding(1);
            this.lblDate.Size = new System.Drawing.Size(130, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date de la dépense";
            // 
            // cbbType
            // 
            this.cbbType.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbbType.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(170, 173);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(204, 26);
            this.cbbType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(316, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 200);
            this.label1.TabIndex = 16;
            this.label1.Text = "€ $ £";
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
            this.tabSuppression.Location = new System.Drawing.Point(4, 25);
            this.tabSuppression.Name = "tabSuppression";
            this.tabSuppression.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuppression.Size = new System.Drawing.Size(1175, 485);
            this.tabSuppression.TabIndex = 2;
            this.tabSuppression.Text = "Suppression d\'une transaction";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 21);
            this.label10.TabIndex = 23;
            this.label10.Text = "Transaction :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 124);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Description :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Montant :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Type :";
            // 
            // lblPerca
            // 
            this.lblPerca.AutoSize = true;
            this.lblPerca.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerca.Location = new System.Drawing.Point(22, 294);
            this.lblPerca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerca.Name = "lblPerca";
            this.lblPerca.Size = new System.Drawing.Size(63, 24);
            this.lblPerca.TabIndex = 18;
            this.lblPerca.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(328, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 200);
            this.label2.TabIndex = 17;
            this.label2.Text = "€ $ £";
            // 
            // lblRorP
            // 
            this.lblRorP.AutoSize = true;
            this.lblRorP.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRorP.Location = new System.Drawing.Point(169, 294);
            this.lblRorP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRorP.Name = "lblRorP";
            this.lblRorP.Size = new System.Drawing.Size(63, 24);
            this.lblRorP.TabIndex = 6;
            this.lblRorP.Text = "label1";
            // 
            // lblType2
            // 
            this.lblType2.AutoSize = true;
            this.lblType2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType2.Location = new System.Drawing.Point(169, 252);
            this.lblType2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(63, 24);
            this.lblType2.TabIndex = 5;
            this.lblType2.Text = "label4";
            // 
            // lblMontant2
            // 
            this.lblMontant2.AutoSize = true;
            this.lblMontant2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant2.Location = new System.Drawing.Point(169, 208);
            this.lblMontant2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontant2.Name = "lblMontant2";
            this.lblMontant2.Size = new System.Drawing.Size(63, 24);
            this.lblMontant2.TabIndex = 4;
            this.lblMontant2.Text = "label3";
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription2.Location = new System.Drawing.Point(169, 165);
            this.lblDescription2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(63, 24);
            this.lblDescription2.TabIndex = 3;
            this.lblDescription2.Text = "label2";
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate2.Location = new System.Drawing.Point(169, 124);
            this.lblDate2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(63, 24);
            this.lblDate2.TabIndex = 2;
            this.lblDate2.Text = "label1";
            // 
            // btnSupp
            // 
            this.btnSupp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.Location = new System.Drawing.Point(404, 106);
            this.btnSupp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(128, 57);
            this.btnSupp.TabIndex = 1;
            this.btnSupp.Text = "Supprimer la transaction";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // cbbTransactionExistantes
            // 
            this.cbbTransactionExistantes.BackColor = System.Drawing.Color.DarkGray;
            this.cbbTransactionExistantes.FormattingEnabled = true;
            this.cbbTransactionExistantes.Location = new System.Drawing.Point(172, 59);
            this.cbbTransactionExistantes.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTransactionExistantes.Name = "cbbTransactionExistantes";
            this.cbbTransactionExistantes.Size = new System.Drawing.Size(157, 21);
            this.cbbTransactionExistantes.TabIndex = 0;
            this.cbbTransactionExistantes.SelectionChangeCommitted += new System.EventHandler(this.cbbTransactionExistantes_SelectedIndexChanged);
            // 
            // TabModif
            // 
            this.TabModif.BackColor = System.Drawing.Color.DimGray;
            this.TabModif.Controls.Add(this.txbPrenom);
            this.TabModif.Controls.Add(this.txbNom);
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
            this.TabModif.Location = new System.Drawing.Point(4, 25);
            this.TabModif.Name = "TabModif";
            this.TabModif.Padding = new System.Windows.Forms.Padding(3);
            this.TabModif.Size = new System.Drawing.Size(1175, 485);
            this.TabModif.TabIndex = 3;
            this.TabModif.Text = "Modification d\'une transaction";
            this.TabModif.Click += new System.EventHandler(this.TabModif_Click);
            // 
            // txbPrenom
            // 
            this.txbPrenom.BackColor = System.Drawing.Color.DarkGray;
            this.txbPrenom.Location = new System.Drawing.Point(518, 219);
            this.txbPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.txbPrenom.Name = "txbPrenom";
            this.txbPrenom.Size = new System.Drawing.Size(110, 20);
            this.txbPrenom.TabIndex = 36;
            // 
            // txbNom
            // 
            this.txbNom.BackColor = System.Drawing.Color.DarkGray;
            this.txbNom.Location = new System.Drawing.Point(518, 192);
            this.txbNom.Margin = new System.Windows.Forms.Padding(2);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(110, 20);
            this.txbNom.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Transaction :";
            // 
            // cbPercuModif
            // 
            this.cbPercuModif.AutoSize = true;
            this.cbPercuModif.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPercuModif.Location = new System.Drawing.Point(130, 255);
            this.cbPercuModif.Margin = new System.Windows.Forms.Padding(2);
            this.cbPercuModif.Name = "cbPercuModif";
            this.cbPercuModif.Size = new System.Drawing.Size(63, 22);
            this.cbPercuModif.TabIndex = 32;
            this.cbPercuModif.Text = "Perçu";
            this.cbPercuModif.UseVisualStyleBackColor = true;
            // 
            // cbRecuModif
            // 
            this.cbRecuModif.AutoSize = true;
            this.cbRecuModif.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRecuModif.Location = new System.Drawing.Point(22, 255);
            this.cbRecuModif.Margin = new System.Windows.Forms.Padding(2);
            this.cbRecuModif.Name = "cbRecuModif";
            this.cbRecuModif.Size = new System.Drawing.Size(58, 22);
            this.cbRecuModif.TabIndex = 31;
            this.cbRecuModif.Text = "Reçu";
            this.cbRecuModif.UseVisualStyleBackColor = true;
            // 
            // cbbChoixtransacModif
            // 
            this.cbbChoixtransacModif.BackColor = System.Drawing.Color.DarkGray;
            this.cbbChoixtransacModif.FormattingEnabled = true;
            this.cbbChoixtransacModif.Location = new System.Drawing.Point(172, 31);
            this.cbbChoixtransacModif.Margin = new System.Windows.Forms.Padding(2);
            this.cbbChoixtransacModif.Name = "cbbChoixtransacModif";
            this.cbbChoixtransacModif.Size = new System.Drawing.Size(137, 21);
            this.cbbChoixtransacModif.TabIndex = 30;
            this.cbbChoixtransacModif.SelectionChangeCommitted += new System.EventHandler(this.cbbChoixtransacModif_SelectedValueChanged);
            // 
            // btnAjouterInModif
            // 
            this.btnAjouterInModif.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterInModif.Location = new System.Drawing.Point(390, 188);
            this.btnAjouterInModif.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouterInModif.Name = "btnAjouterInModif";
            this.btnAjouterInModif.Size = new System.Drawing.Size(61, 26);
            this.btnAjouterInModif.TabIndex = 29;
            this.btnAjouterInModif.Text = "Ajouter un type";
            this.btnAjouterInModif.UseVisualStyleBackColor = true;
            this.btnAjouterInModif.Click += new System.EventHandler(this.btnAjouterInModif_Click);
            // 
            // flpListePersonneInModif
            // 
            this.flpListePersonneInModif.AutoScroll = true;
            this.flpListePersonneInModif.BackColor = System.Drawing.Color.DarkGray;
            this.flpListePersonneInModif.Location = new System.Drawing.Point(518, 39);
            this.flpListePersonneInModif.Margin = new System.Windows.Forms.Padding(2);
            this.flpListePersonneInModif.Name = "flpListePersonneInModif";
            this.flpListePersonneInModif.Size = new System.Drawing.Size(172, 136);
            this.flpListePersonneInModif.TabIndex = 28;
            // 
            // lblTyp
            // 
            this.lblTyp.AutoSize = true;
            this.lblTyp.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTyp.Location = new System.Drawing.Point(19, 195);
            this.lblTyp.Name = "lblTyp";
            this.lblTyp.Size = new System.Drawing.Size(39, 18);
            this.lblTyp.TabIndex = 27;
            this.lblTyp.Text = "Type";
            // 
            // dtmDateModif
            // 
            this.dtmDateModif.Location = new System.Drawing.Point(172, 88);
            this.dtmDateModif.Name = "dtmDateModif";
            this.dtmDateModif.Size = new System.Drawing.Size(204, 20);
            this.dtmDateModif.TabIndex = 26;
            // 
            // txbMontantModif
            // 
            this.txbMontantModif.BackColor = System.Drawing.Color.DarkGray;
            this.txbMontantModif.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMontantModif.Location = new System.Drawing.Point(172, 153);
            this.txbMontantModif.Name = "txbMontantModif";
            this.txbMontantModif.Size = new System.Drawing.Size(204, 23);
            this.txbMontantModif.TabIndex = 25;
            this.txbMontantModif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontant_KeyPress);
            // 
            // txbDescriptionModif
            // 
            this.txbDescriptionModif.BackColor = System.Drawing.Color.DarkGray;
            this.txbDescriptionModif.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescriptionModif.Location = new System.Drawing.Point(172, 119);
            this.txbDescriptionModif.Name = "txbDescriptionModif";
            this.txbDescriptionModif.Size = new System.Drawing.Size(204, 23);
            this.txbDescriptionModif.TabIndex = 24;
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(22, 371);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 24);
            this.btnModifier.TabIndex = 23;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouterPersonneInModif
            // 
            this.btnAjouterPersonneInModif.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPersonneInModif.Location = new System.Drawing.Point(670, 188);
            this.btnAjouterPersonneInModif.Name = "btnAjouterPersonneInModif";
            this.btnAjouterPersonneInModif.Size = new System.Drawing.Size(86, 49);
            this.btnAjouterPersonneInModif.TabIndex = 22;
            this.btnAjouterPersonneInModif.Text = "Ajouter une personne";
            this.btnAjouterPersonneInModif.UseVisualStyleBackColor = true;
            this.btnAjouterPersonneInModif.Click += new System.EventHandler(this.btnAjouterPersonneInModif_Click_1);
            // 
            // lblMont
            // 
            this.lblMont.AutoSize = true;
            this.lblMont.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMont.Location = new System.Drawing.Point(16, 157);
            this.lblMont.Name = "lblMont";
            this.lblMont.Size = new System.Drawing.Size(64, 18);
            this.lblMont.TabIndex = 19;
            this.lblMont.Text = "Montant";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(19, 124);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(83, 18);
            this.lblDesc.TabIndex = 18;
            this.lblDesc.Text = "Description";
            // 
            // lblDatedep
            // 
            this.lblDatedep.AutoSize = true;
            this.lblDatedep.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatedep.Location = new System.Drawing.Point(19, 88);
            this.lblDatedep.Name = "lblDatedep";
            this.lblDatedep.Size = new System.Drawing.Size(128, 18);
            this.lblDatedep.TabIndex = 17;
            this.lblDatedep.Text = "Date de la dépense";
            // 
            // cbbTypeModif
            // 
            this.cbbTypeModif.BackColor = System.Drawing.Color.DarkGray;
            this.cbbTypeModif.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeModif.FormattingEnabled = true;
            this.cbbTypeModif.Location = new System.Drawing.Point(172, 188);
            this.cbbTypeModif.Name = "cbbTypeModif";
            this.cbbTypeModif.Size = new System.Drawing.Size(204, 26);
            this.cbbTypeModif.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(326, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(432, 200);
            this.label3.TabIndex = 33;
            this.label3.Text = "€ $ £";
            // 
            // TabRecapitulatif
            // 
            this.TabRecapitulatif.BackColor = System.Drawing.Color.DimGray;
            this.TabRecapitulatif.Controls.Add(this.dgvFinal);
            this.TabRecapitulatif.Controls.Add(this.lblFinPer);
            this.TabRecapitulatif.Controls.Add(this.lblDebPer);
            this.TabRecapitulatif.Controls.Add(this.dtpFinPer);
            this.TabRecapitulatif.Controls.Add(this.dtpDebPer);
            this.TabRecapitulatif.Controls.Add(this.btnPDF);
            this.TabRecapitulatif.Location = new System.Drawing.Point(4, 25);
            this.TabRecapitulatif.Name = "TabRecapitulatif";
            this.TabRecapitulatif.Padding = new System.Windows.Forms.Padding(3);
            this.TabRecapitulatif.Size = new System.Drawing.Size(1175, 485);
            this.TabRecapitulatif.TabIndex = 4;
            this.TabRecapitulatif.Text = "Récapitulatif";
            // 
            // lblFinPer
            // 
            this.lblFinPer.AutoSize = true;
            this.lblFinPer.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinPer.Location = new System.Drawing.Point(240, 409);
            this.lblFinPer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinPer.Name = "lblFinPer";
            this.lblFinPer.Size = new System.Drawing.Size(167, 18);
            this.lblFinPer.TabIndex = 5;
            this.lblFinPer.Text = "Fin de la période désirée";
            // 
            // lblDebPer
            // 
            this.lblDebPer.AutoSize = true;
            this.lblDebPer.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebPer.Location = new System.Drawing.Point(240, 370);
            this.lblDebPer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDebPer.Name = "lblDebPer";
            this.lblDebPer.Size = new System.Drawing.Size(182, 18);
            this.lblDebPer.TabIndex = 4;
            this.lblDebPer.Text = "Début de la période désirée";
            // 
            // dtpFinPer
            // 
            this.dtpFinPer.Location = new System.Drawing.Point(447, 409);
            this.dtpFinPer.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFinPer.Name = "dtpFinPer";
            this.dtpFinPer.Size = new System.Drawing.Size(151, 20);
            this.dtpFinPer.TabIndex = 3;
            // 
            // dtpDebPer
            // 
            this.dtpDebPer.Location = new System.Drawing.Point(447, 370);
            this.dtpDebPer.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDebPer.Name = "dtpDebPer";
            this.dtpDebPer.Size = new System.Drawing.Size(151, 20);
            this.dtpDebPer.TabIndex = 2;
            // 
            // btnPDF
            // 
            this.btnPDF.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Location = new System.Drawing.Point(28, 365);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(169, 62);
            this.btnPDF.TabIndex = 0;
            this.btnPDF.Text = "Créer le PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // dgvFinal
            // 
            this.dgvFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinal.Location = new System.Drawing.Point(10, 18);
            this.dgvFinal.Name = "dgvFinal";
            this.dgvFinal.Size = new System.Drawing.Size(782, 304);
            this.dgvFinal.TabIndex = 6;
            // 
            // FrmBudgetMois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 462);
            this.Controls.Add(this.TabBudgetMois);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmBudgetMois";
            this.Text = "frmBudgetMois";
            this.Load += new System.EventHandler(this.FrmBudgetMois_Load);
            this.TabBudgetMois.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TabTransac.ResumeLayout(false);
            this.TabTransac.PerformLayout();
            this.tabSuppression.ResumeLayout(false);
            this.tabSuppression.PerformLayout();
            this.TabModif.ResumeLayout(false);
            this.TabModif.PerformLayout();
            this.TabRecapitulatif.ResumeLayout(false);
            this.TabRecapitulatif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinal)).EndInit();
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbPrenom;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.TextBox txbNom2;
        private System.Windows.Forms.TextBox txbPrenom1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblMontant1v1;
        private System.Windows.Forms.Label lblType1v1;
        private System.Windows.Forms.Label lblDescrtion1v1;
        private System.Windows.Forms.Label lblNumPage;
        private System.Windows.Forms.DateTimePicker dtp1v1;
        private System.Windows.Forms.CheckBox cbPercu1v1;
        private System.Windows.Forms.CheckBox cbRecette1v1;
        private System.Windows.Forms.DataGridView dgvFinal;
    }
}