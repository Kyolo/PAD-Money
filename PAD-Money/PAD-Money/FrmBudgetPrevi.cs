﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAD_Money
{
    public partial class FrmBudgetPrevi : Form
    {
        private OleDbConnection connec;
        private DataSet ds;

        public FrmBudgetPrevi(OleDbConnection connec, DataSet ds)
        {
            this.connec = connec;
            this.ds = ds;           
            InitializeComponent();
            remplirCbbPoste(cbbPoste);
            remplirCbbPoste(cbbRevenu);
            remplirCbbPeriode();
        }

        private void FrmBudgetPrevi_Load(object sender, EventArgs e)
        {

        }

        private void remplirCbbPoste(ComboBox cbb)
        {
            DataTable table = new DataTable();
            table = ds.Tables["Poste"];
            cbb.DataSource = table;
            cbb.DisplayMember = "libPoste";
            cbb.ValueMember = "codePoste";
            
        }

        private void remplirCbbPeriode()
        {
            DataTable table = new DataTable();
            table = ds.Tables["Periodicite"];
            cbbPeriode.DataSource = table;
            cbbPeriode.DisplayMember = "libPer";
            cbbPeriode.ValueMember = "codePer";
        }

        private void remplirClbRevenu()
        {
            clbRevenu.Controls.Clear();
            DataTable table = new DataTable();
            table = ds.Tables["Personne"];
            foreach(DataRow row in table.Rows)
            {
                clbRevenu.Items.Add(row["nomPersonne"] + " " + row["pnPersonne"], false);
            }
        }

        private void cbbPoste_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtMontantPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool virgule = false;
            if(txtMontantPF.Text.Contains('.'))
            {
                virgule = true;
            }
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ',' ||  char.IsControl(e.KeyChar))
            {
                if ((e.KeyChar == '.' || e.KeyChar == ',') && virgule)
                {
                    e.Handled = true;
                }
                if(e.KeyChar == ',' && !virgule)
                {
                    e.Handled = true;
                    txtMontantPF.Text += '.';
                }               
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnValiderPF_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["PostePeriodique"].NewRow();
            row["codePoste"] = cbbPoste.SelectedValue;
            row["montant"] = txtMontantPF.Text;
            row["typePer"] = cbbPeriode.SelectedValue;
            row["jourDuMois"] = dtpPF.Value.Day;
            BDDUtil.addLine("PostePeriodique", row);
        }

        private void txtMontantPP_KeyPress(object sender, KeyPressEventArgs e)
        {           
            bool virgule = false;
            if (txtMontantPF.Text.Contains('.'))
            {
                virgule = true;
            }
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ',' || char.IsControl(e.KeyChar))
            {
                if ((e.KeyChar == '.' || e.KeyChar == ',') && virgule)
                {
                    e.Handled = true;
                }
                if (e.KeyChar == ',' && !virgule)
                {
                    e.Handled = true;
                    txtMontantPF.Text += '.';
                }
            }
            else
            {
                e.Handled = true;
            }

            if(e.KeyChar == (char)Keys.Enter)
            {
                if (verifPP())
                {
                    afficherPP();
                }
            }
        }

        private bool verifPP()
        {
            bool res = false;
            bool verif = false;
            Control[] tab = {txtIntitul,txtPrelevPP,txtMontantPP};
            foreach(Control c in tab)
            {
                if(((TextBox)c).Text == string.Empty)
                {
                    verif = true;
                    epIntitulPP.SetError(c, "Champ obligatoire");
                }
                else
                {
                    epIntitulPP.SetError(c, string.Empty);
                }
            }
            if(!verif)
            {
                res = true;
            }
            return res;
        } // verifie si les champs necessaires sont utilisables

        private void afficherPP()
        {
            flpEcheance.Controls.Clear();
            int nombreEcheance = int.Parse(txtPrelevPP.Text);
            float montant = (float)Math.Round(float.Parse(txtMontantPP.Text) / nombreEcheance,2);
            for (int i = 0; i < int.Parse(txtPrelevPP.Text); i++)
            {
                if (i == nombreEcheance - 1)
                {
                    // ajustement du dernier montant en fonction des arrondissements
                    montant += (float)Math.Round(float.Parse(txtMontantPP.Text) - (montant * nombreEcheance),2); 
                    PrelevementControl ctrl = new PrelevementControl(DateTime.Now.AddMonths(i), i + 1, montant);
                    flpEcheance.Controls.Add(ctrl);
                }
                else
                {
                    // ajout d'un DateTimePicker à la date d'aujourd'hui plus i mois, d'un Label indiquant le numero
                    // d'echeance et d'une TextBox comportant le montant a payer chaque mois
                    PrelevementControl ctrl = new PrelevementControl(DateTime.Now.AddMonths(i), i + 1, montant);
                    flpEcheance.Controls.Add(ctrl);
                }
            }
        }

        private void btnCalculPP_Click(object sender, EventArgs e)
        {
            if (verifPP())
            {
                afficherPP();
            }
        }

        private void btnValiderPP_Click(object sender, EventArgs e)
        {
            //BDDUtil.ajouterPostePonctuel(txtIntitul.Text,txtDescription.Text,flpEcheance.Controls.Cast<PrelevementControl>().ToArray<PrelevementControl>());          
        }

        private void tabBudgetPrevi_Selected(object sender, TabControlEventArgs e)
        {
            if(tabBudgetPrevi.SelectedTab == tabBudgetPrevi.TabPages["tabPage3"])
            {
                remplirClbRevenu();
            }
        }

        private void btnValiderRevenu_Click(object sender, EventArgs e)
        {
            
            foreach(Control c in clbRevenu.Items)
            {
                if(((CheckBox)c).Checked)
                {
                    //BDDUtil.ajouterPosteRevenu(cbbRevenu.SelectedItem,int.Parse(lblMontantRevenu.Text),c.Text;
                }
            }
        }
    }
}
