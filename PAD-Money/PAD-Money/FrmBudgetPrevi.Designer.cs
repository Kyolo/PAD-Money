﻿namespace PAD_Money
{
    partial class FrmBudgetPrevi
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
            this.components = new System.ComponentModel.Container();
            this.tabBudgetPrevi = new System.Windows.Forms.TabControl();
            this.tbpPF = new System.Windows.Forms.TabPage();
            this.txtPostePF = new System.Windows.Forms.TextBox();
            this.grbMontantPF = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontantPF = new System.Windows.Forms.TextBox();
            this.dtpPF = new System.Windows.Forms.DateTimePicker();
            this.btnValiderPF = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPostePF = new System.Windows.Forms.Label();
            this.cbbPeriode = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMontantPP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValiderPP = new System.Windows.Forms.Button();
            this.btnCalculPP = new System.Windows.Forms.Button();
            this.txtIntitul = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPrelevPP = new System.Windows.Forms.TextBox();
            this.lblNbPrelevPP = new System.Windows.Forms.Label();
            this.grbEcheance = new System.Windows.Forms.GroupBox();
            this.flpEcheance = new System.Windows.Forms.FlowLayoutPanel();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.lblDescripPP = new System.Windows.Forms.Label();
            this.lblIntitulePP = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtPosteR = new System.Windows.Forms.TextBox();
            this.clbRevenu = new System.Windows.Forms.CheckedListBox();
            this.grbRevenu = new System.Windows.Forms.GroupBox();
            this.lblMontantRevenu = new System.Windows.Forms.Label();
            this.txtMontantRevenu = new System.Windows.Forms.TextBox();
            this.dtpRevenu = new System.Windows.Forms.DateTimePicker();
            this.btnValiderRevenu = new System.Windows.Forms.Button();
            this.lblDateRevenu = new System.Windows.Forms.Label();
            this.lblBeneRevenu = new System.Windows.Forms.Label();
            this.lblPosteRevenu = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grbChoix = new System.Windows.Forms.GroupBox();
            this.rdbPF = new System.Windows.Forms.RadioButton();
            this.rdbPP = new System.Windows.Forms.RadioButton();
            this.rdbR = new System.Windows.Forms.RadioButton();
            this.rdbCal = new System.Windows.Forms.RadioButton();
            this.dgvRecap = new System.Windows.Forms.DataGridView();
            this.epIntitulPP = new System.Windows.Forms.ErrorProvider(this.components);
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabBudgetPrevi.SuspendLayout();
            this.tbpPF.SuspendLayout();
            this.grbMontantPF.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbEcheance.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grbRevenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grbChoix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIntitulPP)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBudgetPrevi
            // 
            this.tabBudgetPrevi.Controls.Add(this.tbpPF);
            this.tabBudgetPrevi.Controls.Add(this.tabPage2);
            this.tabBudgetPrevi.Controls.Add(this.tabPage3);
            this.tabBudgetPrevi.Controls.Add(this.tabPage1);
            this.tabBudgetPrevi.Location = new System.Drawing.Point(3, -1);
            this.tabBudgetPrevi.Name = "tabBudgetPrevi";
            this.tabBudgetPrevi.SelectedIndex = 0;
            this.tabBudgetPrevi.Size = new System.Drawing.Size(788, 430);
            this.tabBudgetPrevi.TabIndex = 1;
            this.tabBudgetPrevi.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabBudgetPrevi_Selected);
            // 
            // tbpPF
            // 
            this.tbpPF.BackColor = System.Drawing.Color.DimGray;
            this.tbpPF.Controls.Add(this.txtPostePF);
            this.tbpPF.Controls.Add(this.grbMontantPF);
            this.tbpPF.Controls.Add(this.dtpPF);
            this.tbpPF.Controls.Add(this.btnValiderPF);
            this.tbpPF.Controls.Add(this.label3);
            this.tbpPF.Controls.Add(this.label2);
            this.tbpPF.Controls.Add(this.lblPostePF);
            this.tbpPF.Controls.Add(this.cbbPeriode);
            this.tbpPF.Location = new System.Drawing.Point(4, 22);
            this.tbpPF.Name = "tbpPF";
            this.tbpPF.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPF.Size = new System.Drawing.Size(780, 404);
            this.tbpPF.TabIndex = 0;
            this.tbpPF.Text = "Poste fixe";
            // 
            // txtPostePF
            // 
            this.txtPostePF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostePF.Location = new System.Drawing.Point(124, 100);
            this.txtPostePF.Name = "txtPostePF";
            this.txtPostePF.Size = new System.Drawing.Size(183, 26);
            this.txtPostePF.TabIndex = 13;
            // 
            // grbMontantPF
            // 
            this.grbMontantPF.Controls.Add(this.label4);
            this.grbMontantPF.Controls.Add(this.txtMontantPF);
            this.grbMontantPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMontantPF.Location = new System.Drawing.Point(87, 214);
            this.grbMontantPF.Name = "grbMontantPF";
            this.grbMontantPF.Size = new System.Drawing.Size(233, 100);
            this.grbMontantPF.TabIndex = 12;
            this.grbMontantPF.TabStop = false;
            this.grbMontantPF.Text = "Montant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 63);
            this.label4.TabIndex = 13;
            this.label4.Text = "€";
            // 
            // txtMontantPF
            // 
            this.txtMontantPF.BackColor = System.Drawing.Color.DarkGray;
            this.txtMontantPF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMontantPF.Location = new System.Drawing.Point(37, 47);
            this.txtMontantPF.Name = "txtMontantPF";
            this.txtMontantPF.Size = new System.Drawing.Size(72, 26);
            this.txtMontantPF.TabIndex = 7;
            this.txtMontantPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontantPF_KeyPress);
            // 
            // dtpPF
            // 
            this.dtpPF.Location = new System.Drawing.Point(511, 108);
            this.dtpPF.Name = "dtpPF";
            this.dtpPF.Size = new System.Drawing.Size(233, 20);
            this.dtpPF.TabIndex = 11;
            // 
            // btnValiderPF
            // 
            this.btnValiderPF.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderPF.Location = new System.Drawing.Point(624, 355);
            this.btnValiderPF.Name = "btnValiderPF";
            this.btnValiderPF.Size = new System.Drawing.Size(120, 30);
            this.btnValiderPF.TabIndex = 10;
            this.btnValiderPF.Text = "Valider";
            this.btnValiderPF.UseVisualStyleBackColor = true;
            this.btnValiderPF.Click += new System.EventHandler(this.btnValiderPF_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jour du mois :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Périodicité :";
            // 
            // lblPostePF
            // 
            this.lblPostePF.AutoSize = true;
            this.lblPostePF.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostePF.Location = new System.Drawing.Point(51, 99);
            this.lblPostePF.Name = "lblPostePF";
            this.lblPostePF.Size = new System.Drawing.Size(58, 18);
            this.lblPostePF.TabIndex = 2;
            this.lblPostePF.Text = "Poste :";
            // 
            // cbbPeriode
            // 
            this.cbbPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPeriode.FormattingEnabled = true;
            this.cbbPeriode.Location = new System.Drawing.Point(511, 167);
            this.cbbPeriode.Name = "cbbPeriode";
            this.cbbPeriode.Size = new System.Drawing.Size(140, 24);
            this.cbbPeriode.TabIndex = 1;
            this.cbbPeriode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbPoste_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnValiderPP);
            this.tabPage2.Controls.Add(this.btnCalculPP);
            this.tabPage2.Controls.Add(this.txtIntitul);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.txtPrelevPP);
            this.tabPage2.Controls.Add(this.lblNbPrelevPP);
            this.tabPage2.Controls.Add(this.grbEcheance);
            this.tabPage2.Controls.Add(this.txtCom);
            this.tabPage2.Controls.Add(this.lblDescripPP);
            this.tabPage2.Controls.Add(this.lblIntitulePP);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Poste ponctuel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMontantPP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(87, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Montant";
            // 
            // txtMontantPP
            // 
            this.txtMontantPP.BackColor = System.Drawing.Color.DarkGray;
            this.txtMontantPP.Location = new System.Drawing.Point(37, 48);
            this.txtMontantPP.Name = "txtMontantPP";
            this.txtMontantPP.Size = new System.Drawing.Size(72, 26);
            this.txtMontantPP.TabIndex = 14;
            this.txtMontantPP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontantPP_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 63);
            this.label1.TabIndex = 13;
            this.label1.Text = "€";
            // 
            // btnValiderPP
            // 
            this.btnValiderPP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderPP.Location = new System.Drawing.Point(624, 368);
            this.btnValiderPP.Name = "btnValiderPP";
            this.btnValiderPP.Size = new System.Drawing.Size(120, 30);
            this.btnValiderPP.TabIndex = 26;
            this.btnValiderPP.Text = "Valider";
            this.btnValiderPP.UseVisualStyleBackColor = true;
            this.btnValiderPP.Click += new System.EventHandler(this.btnValiderPP_Click);
            // 
            // btnCalculPP
            // 
            this.btnCalculPP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculPP.Location = new System.Drawing.Point(87, 320);
            this.btnCalculPP.Name = "btnCalculPP";
            this.btnCalculPP.Size = new System.Drawing.Size(166, 29);
            this.btnCalculPP.TabIndex = 25;
            this.btnCalculPP.Text = "Calculer les échéances";
            this.btnCalculPP.UseVisualStyleBackColor = true;
            this.btnCalculPP.Click += new System.EventHandler(this.btnCalculPP_Click);
            // 
            // txtIntitul
            // 
            this.txtIntitul.BackColor = System.Drawing.Color.DarkGray;
            this.txtIntitul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntitul.Location = new System.Drawing.Point(240, 24);
            this.txtIntitul.Name = "txtIntitul";
            this.txtIntitul.Size = new System.Drawing.Size(183, 22);
            this.txtIntitul.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(783, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtPrelevPP
            // 
            this.txtPrelevPP.BackColor = System.Drawing.Color.DarkGray;
            this.txtPrelevPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrelevPP.Location = new System.Drawing.Point(356, 97);
            this.txtPrelevPP.Name = "txtPrelevPP";
            this.txtPrelevPP.Size = new System.Drawing.Size(67, 22);
            this.txtPrelevPP.TabIndex = 22;
            this.txtPrelevPP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontantPP_KeyPress);
            // 
            // lblNbPrelevPP
            // 
            this.lblNbPrelevPP.AutoSize = true;
            this.lblNbPrelevPP.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbPrelevPP.Location = new System.Drawing.Point(63, 101);
            this.lblNbPrelevPP.Name = "lblNbPrelevPP";
            this.lblNbPrelevPP.Size = new System.Drawing.Size(190, 18);
            this.lblNbPrelevPP.TabIndex = 21;
            this.lblNbPrelevPP.Text = "Nombre de prélèvement :";
            // 
            // grbEcheance
            // 
            this.grbEcheance.Controls.Add(this.flpEcheance);
            this.grbEcheance.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEcheance.Location = new System.Drawing.Point(445, 26);
            this.grbEcheance.Name = "grbEcheance";
            this.grbEcheance.Size = new System.Drawing.Size(299, 323);
            this.grbEcheance.TabIndex = 20;
            this.grbEcheance.TabStop = false;
            this.grbEcheance.Text = "Echéances prévues";
            // 
            // flpEcheance
            // 
            this.flpEcheance.AutoScroll = true;
            this.flpEcheance.Location = new System.Drawing.Point(8, 19);
            this.flpEcheance.Name = "flpEcheance";
            this.flpEcheance.Size = new System.Drawing.Size(285, 298);
            this.flpEcheance.TabIndex = 24;
            // 
            // txtCom
            // 
            this.txtCom.BackColor = System.Drawing.Color.DarkGray;
            this.txtCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCom.Location = new System.Drawing.Point(240, 63);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(183, 22);
            this.txtCom.TabIndex = 17;
            // 
            // lblDescripPP
            // 
            this.lblDescripPP.AutoSize = true;
            this.lblDescripPP.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripPP.Location = new System.Drawing.Point(63, 67);
            this.lblDescripPP.Name = "lblDescripPP";
            this.lblDescripPP.Size = new System.Drawing.Size(105, 18);
            this.lblDescripPP.TabIndex = 15;
            this.lblDescripPP.Text = "Description :";
            // 
            // lblIntitulePP
            // 
            this.lblIntitulePP.AutoSize = true;
            this.lblIntitulePP.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntitulePP.Location = new System.Drawing.Point(63, 28);
            this.lblIntitulePP.Name = "lblIntitulePP";
            this.lblIntitulePP.Size = new System.Drawing.Size(144, 18);
            this.lblIntitulePP.TabIndex = 12;
            this.lblIntitulePP.Text = "Intitulé du poste :";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.txtPosteR);
            this.tabPage3.Controls.Add(this.clbRevenu);
            this.tabPage3.Controls.Add(this.grbRevenu);
            this.tabPage3.Controls.Add(this.dtpRevenu);
            this.tabPage3.Controls.Add(this.btnValiderRevenu);
            this.tabPage3.Controls.Add(this.lblDateRevenu);
            this.tabPage3.Controls.Add(this.lblBeneRevenu);
            this.tabPage3.Controls.Add(this.lblPosteRevenu);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(780, 404);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Revenu";
            // 
            // txtPosteR
            // 
            this.txtPosteR.BackColor = System.Drawing.Color.DarkGray;
            this.txtPosteR.Location = new System.Drawing.Point(120, 119);
            this.txtPosteR.Name = "txtPosteR";
            this.txtPosteR.Size = new System.Drawing.Size(183, 20);
            this.txtPosteR.TabIndex = 43;
            // 
            // clbRevenu
            // 
            this.clbRevenu.BackColor = System.Drawing.Color.DarkGray;
            this.clbRevenu.FormattingEnabled = true;
            this.clbRevenu.Location = new System.Drawing.Point(488, 171);
            this.clbRevenu.Name = "clbRevenu";
            this.clbRevenu.Size = new System.Drawing.Size(233, 169);
            this.clbRevenu.TabIndex = 42;
            // 
            // grbRevenu
            // 
            this.grbRevenu.Controls.Add(this.lblMontantRevenu);
            this.grbRevenu.Controls.Add(this.txtMontantRevenu);
            this.grbRevenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRevenu.Location = new System.Drawing.Point(87, 214);
            this.grbRevenu.Name = "grbRevenu";
            this.grbRevenu.Size = new System.Drawing.Size(233, 100);
            this.grbRevenu.TabIndex = 41;
            this.grbRevenu.TabStop = false;
            this.grbRevenu.Text = "Montant";
            // 
            // lblMontantRevenu
            // 
            this.lblMontantRevenu.AutoSize = true;
            this.lblMontantRevenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantRevenu.Location = new System.Drawing.Point(133, 16);
            this.lblMontantRevenu.Name = "lblMontantRevenu";
            this.lblMontantRevenu.Size = new System.Drawing.Size(57, 63);
            this.lblMontantRevenu.TabIndex = 13;
            this.lblMontantRevenu.Text = "€";
            // 
            // txtMontantRevenu
            // 
            this.txtMontantRevenu.BackColor = System.Drawing.Color.DarkGray;
            this.txtMontantRevenu.Location = new System.Drawing.Point(37, 48);
            this.txtMontantRevenu.Name = "txtMontantRevenu";
            this.txtMontantRevenu.Size = new System.Drawing.Size(72, 22);
            this.txtMontantRevenu.TabIndex = 7;
            this.txtMontantRevenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontantPP_KeyPress_1);
            // 
            // dtpRevenu
            // 
            this.dtpRevenu.Location = new System.Drawing.Point(488, 119);
            this.dtpRevenu.Name = "dtpRevenu";
            this.dtpRevenu.Size = new System.Drawing.Size(233, 20);
            this.dtpRevenu.TabIndex = 40;
            // 
            // btnValiderRevenu
            // 
            this.btnValiderRevenu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderRevenu.Location = new System.Drawing.Point(624, 355);
            this.btnValiderRevenu.Name = "btnValiderRevenu";
            this.btnValiderRevenu.Size = new System.Drawing.Size(120, 30);
            this.btnValiderRevenu.TabIndex = 39;
            this.btnValiderRevenu.Text = "Valider";
            this.btnValiderRevenu.UseVisualStyleBackColor = true;
            this.btnValiderRevenu.Click += new System.EventHandler(this.btnValiderRevenu_Click);
            // 
            // lblDateRevenu
            // 
            this.lblDateRevenu.AutoSize = true;
            this.lblDateRevenu.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRevenu.Location = new System.Drawing.Point(358, 121);
            this.lblDateRevenu.Name = "lblDateRevenu";
            this.lblDateRevenu.Size = new System.Drawing.Size(115, 18);
            this.lblDateRevenu.TabIndex = 37;
            this.lblDateRevenu.Text = "Jour du mois :";
            // 
            // lblBeneRevenu
            // 
            this.lblBeneRevenu.AutoSize = true;
            this.lblBeneRevenu.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneRevenu.Location = new System.Drawing.Point(358, 171);
            this.lblBeneRevenu.Name = "lblBeneRevenu";
            this.lblBeneRevenu.Size = new System.Drawing.Size(109, 18);
            this.lblBeneRevenu.TabIndex = 36;
            this.lblBeneRevenu.Text = "Bénéficiaire :";
            // 
            // lblPosteRevenu
            // 
            this.lblPosteRevenu.AutoSize = true;
            this.lblPosteRevenu.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosteRevenu.Location = new System.Drawing.Point(56, 121);
            this.lblPosteRevenu.Name = "lblPosteRevenu";
            this.lblPosteRevenu.Size = new System.Drawing.Size(58, 18);
            this.lblPosteRevenu.TabIndex = 35;
            this.lblPosteRevenu.Text = "Poste :";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(783, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 23);
            this.button4.TabIndex = 32;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.grbChoix);
            this.tabPage1.Controls.Add(this.dgvRecap);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 404);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Vue d\'ensemble";
            // 
            // grbChoix
            // 
            this.grbChoix.BackColor = System.Drawing.Color.DimGray;
            this.grbChoix.Controls.Add(this.rdbPF);
            this.grbChoix.Controls.Add(this.rdbPP);
            this.grbChoix.Controls.Add(this.rdbR);
            this.grbChoix.Controls.Add(this.rdbCal);
            this.grbChoix.Location = new System.Drawing.Point(6, 6);
            this.grbChoix.Name = "grbChoix";
            this.grbChoix.Size = new System.Drawing.Size(738, 72);
            this.grbChoix.TabIndex = 1;
            this.grbChoix.TabStop = false;
            this.grbChoix.Tag = "PostePeriodique";
            // 
            // rdbPF
            // 
            this.rdbPF.AutoSize = true;
            this.rdbPF.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPF.Location = new System.Drawing.Point(6, 31);
            this.rdbPF.Name = "rdbPF";
            this.rdbPF.Size = new System.Drawing.Size(105, 22);
            this.rdbPF.TabIndex = 0;
            this.rdbPF.TabStop = true;
            this.rdbPF.Tag = "PostePeriodique";
            this.rdbPF.Text = "postes fixe";
            this.rdbPF.UseVisualStyleBackColor = true;
            this.rdbPF.CheckedChanged += new System.EventHandler(this.rdbPF_CheckedChanged);
            // 
            // rdbPP
            // 
            this.rdbPP.AutoSize = true;
            this.rdbPP.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPP.Location = new System.Drawing.Point(149, 31);
            this.rdbPP.Name = "rdbPP";
            this.rdbPP.Size = new System.Drawing.Size(138, 22);
            this.rdbPP.TabIndex = 1;
            this.rdbPP.TabStop = true;
            this.rdbPP.Tag = "PostePonctuel";
            this.rdbPP.Text = "postes ponctuel";
            this.rdbPP.UseVisualStyleBackColor = true;
            this.rdbPP.CheckedChanged += new System.EventHandler(this.rdbPF_CheckedChanged);
            // 
            // rdbR
            // 
            this.rdbR.AutoSize = true;
            this.rdbR.BackColor = System.Drawing.Color.DimGray;
            this.rdbR.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbR.Location = new System.Drawing.Point(340, 31);
            this.rdbR.Name = "rdbR";
            this.rdbR.Size = new System.Drawing.Size(81, 22);
            this.rdbR.TabIndex = 2;
            this.rdbR.TabStop = true;
            this.rdbR.Tag = "PosteRevenu";
            this.rdbR.Text = "revenus";
            this.rdbR.UseVisualStyleBackColor = false;
            this.rdbR.CheckedChanged += new System.EventHandler(this.rdbPF_CheckedChanged);
            // 
            // rdbCal
            // 
            this.rdbCal.AutoSize = true;
            this.rdbCal.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCal.Location = new System.Drawing.Point(472, 31);
            this.rdbCal.Name = "rdbCal";
            this.rdbCal.Size = new System.Drawing.Size(200, 22);
            this.rdbCal.TabIndex = 3;
            this.rdbCal.TabStop = true;
            this.rdbCal.Text = "Calendrier previsionnel";
            this.rdbCal.UseVisualStyleBackColor = true;
            this.rdbCal.CheckedChanged += new System.EventHandler(this.rdbCal_CheckedChanged);
            // 
            // dgvRecap
            // 
            this.dgvRecap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecap.Location = new System.Drawing.Point(6, 84);
            this.dgvRecap.Name = "dgvRecap";
            this.dgvRecap.Size = new System.Drawing.Size(738, 301);
            this.dgvRecap.TabIndex = 0;
            this.dgvRecap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecap_CellClick);
            // 
            // epIntitulPP
            // 
            this.epIntitulPP.ContainerControl = this;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(130, 48);
            this.cms.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cms_ItemClicked);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // FrmBudgetPrevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.tabBudgetPrevi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmBudgetPrevi";
            this.Text = "FrmBudgetPrevi";
            this.Load += new System.EventHandler(this.FrmBudgetPrevi_Load);
            this.tabBudgetPrevi.ResumeLayout(false);
            this.tbpPF.ResumeLayout(false);
            this.tbpPF.PerformLayout();
            this.grbMontantPF.ResumeLayout(false);
            this.grbMontantPF.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbEcheance.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.grbRevenu.ResumeLayout(false);
            this.grbRevenu.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.grbChoix.ResumeLayout(false);
            this.grbChoix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIntitulPP)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBudgetPrevi;
        private System.Windows.Forms.TabPage tbpPF;
        private System.Windows.Forms.TextBox txtMontantPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPostePF;
        private System.Windows.Forms.ComboBox cbbPeriode;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtPrelevPP;
        private System.Windows.Forms.Label lblNbPrelevPP;
        private System.Windows.Forms.GroupBox grbEcheance;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.Label lblDescripPP;
        private System.Windows.Forms.Label lblIntitulePP;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnValiderPF;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flpEcheance;
        private System.Windows.Forms.TextBox txtIntitul;
        private System.Windows.Forms.DateTimePicker dtpPF;
        private System.Windows.Forms.GroupBox grbMontantPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider epIntitulPP;
        private System.Windows.Forms.Button btnValiderPP;
        private System.Windows.Forms.Button btnCalculPP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontantPP;
        private System.Windows.Forms.GroupBox grbRevenu;
        private System.Windows.Forms.Label lblMontantRevenu;
        private System.Windows.Forms.TextBox txtMontantRevenu;
        private System.Windows.Forms.DateTimePicker dtpRevenu;
        private System.Windows.Forms.Button btnValiderRevenu;
        private System.Windows.Forms.Label lblDateRevenu;
        private System.Windows.Forms.Label lblBeneRevenu;
        private System.Windows.Forms.Label lblPosteRevenu;
        private System.Windows.Forms.CheckedListBox clbRevenu;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grbChoix;
        private System.Windows.Forms.DataGridView dgvRecap;
        private System.Windows.Forms.RadioButton rdbPF;
        private System.Windows.Forms.RadioButton rdbPP;
        private System.Windows.Forms.RadioButton rdbR;
        private System.Windows.Forms.RadioButton rdbCal;
        private System.Windows.Forms.TextBox txtPostePF;
        private System.Windows.Forms.TextBox txtPosteR;
    }
}