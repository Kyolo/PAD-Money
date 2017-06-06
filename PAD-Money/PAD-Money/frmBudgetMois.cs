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
        DataTable transaction;
        public FrmBudgetMois(OleDbConnection connec, DataSet ds)
        {
            this.connec = connec;
            this.ds = ds;
            InitializeComponent();
            generationdyna();
            type();
            codeTransa();
            transaction = ds.Tables["Transaction"].Select("codeTransaction = " + cbbTransactionExistantes.SelectedValue).CopyToDataTable();
           
            //Onglet Supprimer à changer de place plus tard

            lblDate2.Text = transaction.Rows[0]["dateTransaction"].ToString();
            lblDescription2.Text = transaction.Rows[0]["description"].ToString();
            lblMontant2.Text = transaction.Rows[0]["montant"].ToString();
            lblType2.Text = transaction.Rows[0]["type"].ToString();
            if (transaction.Rows[0]["recetteON"].ToString() == "True")
            {
                lblRorP.Text = "Recette";
            }
            else lblRorP.Text = "Perçu";

          

        }

        //ajoute pas grand chose pour le moment mais ça viendra
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            String description = txtDescription.Text;
            float montant = float.Parse(txtMontant.Text);
            DateTime depense = dtpDepense.Value;
            String typeString = cbbType.Text;
            DataTable Type = ds.Tables["TypeTransaction"].Select("upper (libtype) = upper(" + typeString + ")").CopyToDataTable();
            long codeTypeLong = (long)Type.Rows[0]["codeType"];
            bool recette = true;
            bool percu = true;
            if (cbPercu.Checked==true)
            {
                percu = true;
            }
            if (cbRecette.Checked==true)
            {
                recette = true;
            }
            long[] listBenef;
            for (int i=0; i<flpPersonne.Controls.Count; i++)
            {
                
            }

            //BDDUtil.ajouterTransaction(depense, description, montant, recette, percu, codeTypeLong,   )
        }


        // Permet de récuperer les types de transactions présents dans la base de donnée 
        private void type()
        {
            DataTable type = new DataTable();
            type = ds.Tables["TypeTransaction"];
            cbbType.DataSource = type;
            cbbType.DisplayMember = "libType";
            cbbType.ValueMember = "codeType";
        }

        // Permet de récuperer le code de la transaction afin de pouvoir la modifier/ la supprimer
        private void codeTransa()
        {
            DataTable code = ds.Tables["Transaction"];
            cbbTransactionExistantes.DataSource = code;
            cbbTransactionExistantes.DisplayMember = "codeTransaction";
            cbbTransactionExistantes.ValueMember = "codeTransaction";
            cbbChoixtransacModif.DataSource = code;
            cbbChoixtransacModif.DisplayMember = "codeTransaction";
            cbbChoixtransacModif.ValueMember = "codeTransaction";
        }


        //Generation dynamique despnj de la famille
        private void generationdyna()
        {
            int x = 623;
            int y = 38;
            DataTable personne = new DataTable();
            personne = ds.Tables["Personne"];
            foreach (DataRow row in personne.Rows)
            {
                CheckBox nom = new CheckBox();
                nom.AutoSize = true;
                nom.Location = new System.Drawing.Point(x, y);
                nom.Size = new System.Drawing.Size(98, 21);
                nom.Text =row["nomPersonne"].ToString() + " " + row["pnPersonne"].ToString();
                flpPersonne.Controls.Add(nom);
                y += 20;
            }
        }


        //inutile, je supprimerai plus tard
        private void TabAjout_Selecting(object sender, TabControlCancelEventArgs e){}

        //inutile, je supprimerai plus tard
        private void lblDate2_Click(object sender, EventArgs e) {}


        //Onglet "modifier", recuperation des données de la table
        private void cbbChoixtransacModif_SelectedValueChanged(object sender, EventArgs e)
        {
            transaction = ds.Tables["Transaction"].Select("codeTransaction = " + cbbTransactionExistantes.SelectedValue).CopyToDataTable();
            txbDescriptionModif.Text = (transaction.Rows[0]["description"]).ToString();
            txbMontantModif.Text = transaction.Rows[0]["montant"].ToString();
            cbbTypeModif.Text = transaction.Rows[0]["type"].ToString();
            cbPercuModif.Checked = (bool)transaction.Rows[0]["PercuON"];
            cbRecuModif.Checked = (bool)transaction.Rows[0]["recetteON"];
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