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
            cbbDescription.DataSource = ds.Tables["Poste"];
            cbbDescription.ValueMember = "codePoste";
            cbbDescription.DisplayMember = "libPoste";

            cbbBP.DataSource = ds.Tables["Periodicite"];
            cbbBP.ValueMember = "codePer";
            cbbBP.DisplayMember = "libPer";

            lblCode.Text = row[0].ToString();
            cbbDescription.Text = row[1].ToString();
            cbbBP.Text = row[2].ToString();
            txtMontant.Text = row[3].ToString();
        }

        private void afficherR()
        {
            cbbDescription.DataSource = ds.Tables["Poste"];
            cbbDescription.ValueMember = "codePoste";
            cbbDescription.DisplayMember = "libPoste";

            cbbBP.DataSource = ds.Tables["Personne"];
            cbbBP.ValueMember = "codePersonne";
            cbbBP.DisplayMember = "nomPersonne"+" "+"pnPersonne";

            lblCode.Text = row[0].ToString();
            cbbDescription.Text = row[1].ToString();
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
                Dictionary<string, object> dico = new Dictionary<string, object>();
                dico.Add("codePersonne",cbbBP.ValueMember);
                dico.Add("montant", txtMontant.Text);
                dico.Add("codePoste", cbbDescription.ValueMember);
                BDDUtil.modifyLine("PosteRevenu", "codePoste", row[0], dico);
            }
            else
            {
                Dictionary<string, object> dico = new Dictionary<string, object>();
                dico.Add("typePer", cbbBP.ValueMember);
                dico.Add("montant", txtMontant.Text);
                dico.Add("codePoste", cbbDescription.ValueMember);
                BDDUtil.modifyLine("PostePeriodique", "codePoste", row[0], dico);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
