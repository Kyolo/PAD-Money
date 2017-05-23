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
    public partial class FrmBudgetMois : Form
    {
        private OleDbConnection connec;
        DataSet ds;
        public FrmBudgetMois(OleDbConnection connec, DataSet ds)
        {
            this.connec = connec;
            this.ds = ds;
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            String description = txtDescription.Text;
            int montant = int.Parse(txtMontant.Text);
            DateTime depense = dtpDepense.Value;
            String type = cbbType.Text;
            bool recette = true;
            if (cbPercu.Checked==true)
            {
                recette = false;
            }

        }
        private void generationdyna()
        {
            int x = 623;
            int y = 38;
            DataTable personne = new DataTable();
            personne = ds.Tables["Personne"];
            foreach (DataRow row in personne.Rows)
            {
                ComboBox nom = new ComboBox();
                nom.AutoSize = true;
                nom.Location = new System.Drawing.Point(x, y);
                nom.Size = new System.Drawing.Size(98, 21);
                nom.TabIndex = 14;
                nom.Text =row["nomPersonne"].ToString();
                y += 10;
            }
        }
    }
}
/*
private void remplitCbo_b(ComboBox cbo, String tableName, String colName, String champCache)
{
    cbo.DataSource = ds.Tables[tableName];
    cbo.DisplayMember = colName;

    cbo.ValueMember = champCache;
}
*/