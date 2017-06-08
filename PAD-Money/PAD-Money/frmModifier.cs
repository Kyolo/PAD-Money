using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAD_Money
{
    public partial class frmModifier : Form
    {

        private DataSet ds;
        private bool revenu;
        private DataRow row;

        public frmModifier(DataSet d,bool a,DataRow r)
        {
            InitializeComponent();
            ds = d;
            revenu = a;
            row = r;
        }

        private void frmModifier_Load(object sender, EventArgs e)
        {
            if(revenu)
            {
                
                afficherR();
            }
            else
            {
                afficherP();
            }
        }

        private void afficherP()
        {
            lblPoste.Text = row[1].ToString();

            cbbBP.DataSource = ds.Tables["Periodicite"];
            cbbBP.ValueMember = "codePer";
            cbbBP.DisplayMember = "libPer";

            lblCode.Text = row[0].ToString();
            cbbBP.Text = row[2].ToString();
            txtMontant.Text = row[3].ToString();
        }

        private void afficherR()
        {
            DataTable t = new DataTable();
            t.Columns.Add("codePersonne");
            t.Columns.Add("nomPersonne");
            foreach(DataRow r in ds.Tables["Personne"].Rows)
            {
                DataRow nrow = t.NewRow();
                nrow[0] = r["codePersonne"];
                nrow[1] = r["nomPersonne"] + " " + r["pnPersonne"];
                t.Rows.Add(nrow);
            }
            lblPoste.Text = row[1].ToString();

            cbbBP.DataSource = t;
            cbbBP.ValueMember = "codePersonne";
            cbbBP.DisplayMember = "nomPersonne";

            int i = 0;
            foreach(DataRow r in ds.Tables["Personne"].Rows)
            {
                //cbbBP.Items[i] += " " + r["pnPersonne"];
            }

            lblCode.Text = row[0].ToString();
            cbbBP.Text = row[2].ToString();
            txtMontant.Text = row[3].ToString();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(revenu)
            {
                Dictionary<String, object> dico = new Dictionary<String, object>();
                dico.Add("codePersonne",cbbBP.SelectedValue);
                dico.Add("montant", float.Parse(txtMontant.Text));
                dico.Add("codePoste", int.Parse(row[0].ToString()));
                BDDUtil.modifyLine("PosteRevenu", "codePoste", int.Parse(row[0].ToString()), dico);
            }
            else
            {
                Dictionary<String, object> dico = new Dictionary<String, object>();
                dico.Add("typePer", cbbBP.SelectedValue);
                dico.Add("montant", float.Parse(txtMontant.Text));
                dico.Add("codePoste", int.Parse(row[0].ToString()));
                BDDUtil.modifyLine("PostePeriodique", "codePoste", int.Parse(row[0].ToString()), dico);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
