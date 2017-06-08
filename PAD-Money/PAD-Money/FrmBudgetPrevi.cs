using System;
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
        private DataRow dr;
        private string currentTag;

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
            clbRevenu.Items.Clear();
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
            BDDUtil.ajouterPostePonctuel(txtIntitul.Text,txtCom.Text,flpEcheance.Controls.Cast<PrelevementControl>().ToArray<PrelevementControl>());          
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
            string[] tab = new string[1];
            long[] tab2;     
            for(int i = 0; i < clbRevenu.Items.Count;i++)
            {
                if (clbRevenu.GetItemChecked(i))
                {
                    tab[0] = clbRevenu.Items[i].ToString();
                    tab2 = BDDUtil.getCodeFromNames(tab);
                    BDDUtil.ajouterPosteRevenu(cbbRevenu.Text, float.Parse(txtMontantRevenu.Text), tab2[0],dtpRevenu.Value.Day);
                }
            }
        }

        private void rdbPF_CheckedChanged(object sender, EventArgs e)
        {
            if(((RadioButton)sender).Checked)
            {
                currentTag = ((RadioButton)sender).Tag.ToString();
                remplirDgv(currentTag);
            }
        }

        private void remplirDgv(string table)
        {
            DataTable res = new DataTable();
            if(table == "PostePeriodique")
            {
                res.Columns.Add("Code");
                res.Columns.Add("Description");
                res.Columns.Add("Periodicite");
                res.Columns.Add("Montant");

                foreach(DataRow row in ds.Tables["PostePeriodique"].Rows)
                {
                    DataRow r = res.NewRow();
                    r["Code"] = row["codePoste"];
                    r["Description"] = getLibPoste(row["codePoste"].ToString());
                    r["Montant"] = row["montant"];
                    r["Periodicite"] = getLibPeriodicite(row["typePer"].ToString());
                    res.Rows.Add(r);
                }

            }

            else if(table == "PostePonctuel")
            {
                res.Columns.Add("Poste");
                res.Columns.Add("Description");
                res.Columns.Add("Echeances");
                res.Columns.Add("Montant");
                foreach (DataRow row in ds.Tables["PostePonctuel"].Rows)
                {
                    DataRow r = res.NewRow();
                    r["Poste"] = row["codePoste"];
                    r["Description"] = getLibPoste(row["codePoste"].ToString());
                    r["Echeances"] = getNbEcheanceMontant(row["codePoste"].ToString())[0];
                    r["Montant"] = getNbEcheanceMontant(row["codePoste"].ToString())[1];
                    res.Rows.Add(r);
                }

            }

            else if(table == "PosteRevenu")
            {
                res.Columns.Add("Poste");
                res.Columns.Add("Description");
                res.Columns.Add("Beneficiaire");
                res.Columns.Add("Montant");
                foreach (DataRow row in ds.Tables["PosteRevenu"].Rows)
                {
                    DataRow r = res.NewRow();
                    r["Poste"] = row["codePoste"];
                    r["Description"] = getLibPoste(row["codePoste"].ToString());
                    r["Beneficiaire"] = getBeneficaire(int.Parse(row["codePersonne"].ToString()));
                    r["Montant"] = row["montant"];
                    res.Rows.Add(r);
                }
            }
            dgvRecap.DataSource = res;
        }

        private string getLibPoste(string code)
        {
            string res = string.Empty;
            foreach(DataRow r in ds.Tables["Poste"].Rows)
            {
                if(r["codePoste"].ToString() == code)
                {
                    res = r["libPoste"].ToString();
                    break;
                }
            }
            return res;
        }

        private string getLibPeriodicite(string typePer)
        {
            string res = string.Empty;
            foreach(DataRow r in ds.Tables["Periodicite"].Rows)
            {
                if(r["codePer"].ToString() == typePer)
                {
                    res = r["libPer"].ToString();
                }
            }
            return res;
        }

        private int[] getNbEcheanceMontant(string code)
        {
            int[] res = { 0, 0};
            foreach(DataRow r in ds.Tables["Echeances"].Rows)
            {
                if(r["codePoste"].ToString() == code)
                {
                    res[0]++;
                    res[1] += (int)r["montantEcheance"];
                }
            }
            return res;
        }

        private string getBeneficaire(int codePers)
        {
            string res = string.Empty;
            foreach(DataRow r in ds.Tables["Personne"].Rows)
            {
                if(int.Parse(r["codePersonne"].ToString()) == codePers)
                {
                    res = r["nomPersonne"].ToString();// + " " + r["pnPersonne"];
                }
            }
            return res;
        }

        private void dgvRecap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != dgvRecap.RowCount-1)
            {
                DataRowView currentDataRowView = (DataRowView)dgvRecap.CurrentRow.DataBoundItem;
                DataRow row = currentDataRowView.Row;
                if (rdbPF.Checked || rdbR.Checked)
                {
                    dgvRecap.ContextMenuStrip = cms;
                    cms.Show(dgvRecap.PointToClient(Cursor.Position));
                }
                dr = row;
            }           
        }

        private void cms_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Text == "Modifier")
            {
                frmModifier frm;
                if (rdbPF.Checked)
                {
                    frm = new frmModifier(ds, false, dr);
                }
                else
                {
                    frm = new frmModifier(ds, true, dr);
                }
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    remplirDgv(currentTag);
                }
            }
            else if(e.ClickedItem.Text == "Supprimer")
            {
                BDDUtil.supprimerPoste((long)dr[0]);
                remplirDgv(currentTag);
            }
        }

        private void rdbCal_CheckedChanged(object sender, EventArgs e)
        {
            if(((RadioButton)sender).Checked)
            {

            }
        }
    }
}
