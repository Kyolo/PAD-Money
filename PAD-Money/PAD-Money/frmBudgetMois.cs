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
            //btnAjouter.ImageAlign = ContentAlignment.TopCenter;
            /////////
            this.connec = connec;
            this.ds = ds;
            InitializeComponent();
            generationdyna1();
            generationdyna2();
            type();
            codeTransa();
            afficher_sup();
            transaction = ds.Tables["Transaction"].Select("codeTransaction = '" + cbbTransactionExistantes.SelectedValue + "'").CopyToDataTable();




        }

        //affiche les elements de l'onglet "supprimer"
        private void afficher_sup()
        {
            string res = transaction.Rows[0]["type"].ToString();
            DataTable TypeFin = ds.Tables["TypeTransaction"].Select("codeType = '" + res + "'").CopyToDataTable();
            lblDate2.Text = transaction.Rows[0]["dateTransaction"].ToString();
            lblDescription2.Text = transaction.Rows[0]["description"].ToString();
            lblMontant2.Text = transaction.Rows[0]["montant"].ToString();

            lblType2.Text = TypeFin.Rows[0]["libType"].ToString();
            if (transaction.Rows[0]["recetteON"].ToString() == "True")
            {
                lblRorP.Text = "Recette";
            }
            else lblRorP.Text = "Pas recette";
            if (transaction.Rows[0]["percuON"].ToString() == "True")
            {
                lblPerca.Text = "Perçu";
            }
            lblPerca.Text = "Pas perçu";
        }

        //ajoute une transaction dans la base de données
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            String description = txtDescription.Text;
            float montant = float.Parse(txtMontant.Text);
            DateTime depense = dtpDepense.Value;
            String typeString = cbbType.Text;
            DataTable Type = ds.Tables["TypeTransaction"].Select("libtype ='" + typeString + "'").CopyToDataTable();
            int[] listBenef = null;
            int codeTypeLong = (int)Type.Rows[0]["codeType"];
            bool recette = true;
            bool percu = true;
            if (cbPercu.Checked == true)
            {
                percu = true;
            }
            if (cbRecette.Checked == true)
            {
                recette = true;
            }
            for (int i = 0; i < flpPersonne.Controls.Count; i++)
            {
                if (((CheckBox)flpPersonne.Controls[i]).Checked == true)
                {
                    String[] res = new String[] { flpPersonne.Controls[i].Text };
                    listBenef = BDDUtil.getCodeFromNames(res);
                }

            }
            BDDUtil.ajouterTransaction(depense, description, montant, recette, percu, codeTypeLong, listBenef);
            //  BDDUtil.ajouterTransaction(;
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


        //Generation dynamique des pnj de la famille dans "ajouter"
        private void generationdyna1()
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
                nom.Text = row["nomPersonne"].ToString() + " " + row["pnPersonne"].ToString();
                flpPersonne.Controls.Add(nom);
                y += 20;
            }
        }

        //genere dynamiquement les personnes pour l'onglet "modifier"
        private void generationdyna2()
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
                nom.Text = row["nomPersonne"].ToString() + " " + row["pnPersonne"].ToString();
                flpListePersonneInModif.Controls.Add(nom);
                y += 20;
            }
        }


        //inutile, je supprimerai plus tard
        // private void TabAjout_Selecting(object sender, TabControlCancelEventArgs e){}

        //inutile, je supprimerai plus tard
        // private void lblDate2_Click(object sender, EventArgs e) {}


        //Onglet "modifier", recuperation des données de la table
        private void cbbChoixtransacModif_SelectedValueChanged(object sender, EventArgs e)
        {
            transaction = ds.Tables["Transaction"].Select("codeTransaction = '" + cbbTransactionExistantes.SelectedValue + "'").CopyToDataTable();
            String res = transaction.Rows[0]["type"].ToString();
            DataTable transactionFin = ds.Tables["TypeTransaction"].Select("codeType = '" + res + "'").CopyToDataTable();
            txbDescriptionModif.Text = (transaction.Rows[0]["description"]).ToString();
            txbMontantModif.Text = transaction.Rows[0]["montant"].ToString();
            DataTable type = new DataTable();
            type = ds.Tables["TypeTransaction"];
            cbbTypeModif.DataSource = type;
            cbbTypeModif.DisplayMember = "libType";
            cbbTypeModif.ValueMember = "codeType";
            cbPercuModif.Checked = (bool)transaction.Rows[0]["PercuON"];
            cbRecuModif.Checked = (bool)transaction.Rows[0]["recetteON"];
        }

        //ajoute un nouveau type via la table "ajouter"
        private void btnAjouterType_Click(object sender, EventArgs e)
        {
            DataTable Type = ds.Tables["Transaction"];
            if (cbbType.Text != Type.Rows[0]["type"].ToString())
            {
                string nvxType = cbbType.Text;
                BDDUtil.ajouterTypeTransaction(nvxType);
            }
        }

        //supprime une transaction
        private void btnSupp_Click(object sender, EventArgs e)
        {

            BDDUtil.supprimerTransaction(int.Parse(cbbTransactionExistantes.Text));
        }

        //Modifie une transaction
        private void btnModifier_Click(object sender, EventArgs e)
        {
            // BDDUtil.modifyLine("Transaction", )
        }

        //Ajoute de nouveaux types via l'onglet "modifier"
        private void btnAjouterInModif_Click(object sender, EventArgs e)
        {
            DataTable Type = ds.Tables["Transaction"];
            if (cbbType.Text != Type.Rows[0]["type"].ToString())
            {
                string nvxType = cbbTypeModif.Text;
                BDDUtil.ajouterTypeTransaction(nvxType);
            }
        }

        //ajoute des gens à la liste des gens
        private void ajouterPersonneGlob()
        {
            string prenom = txbPrenom.Text;
            string nom = txbNom.Text;
            string[] NP = new string[] { nom + " " + prenom };
            DataTable Personne = ds.Tables["Personne"];
            if (BDDUtil.getCodeFromNames(NP) != Personne.Rows[0]["codePersonne"])
            {
                BDDUtil.ajouterPersonne(nom, prenom);
            }
        }

        private void ajouterPersonneModif()
        {
            string prenom = txbPrenom1.Text;
            string nom = txbNom2.Text;
            string[] NP = new string[] { nom + " " + prenom };
            DataTable Personne = ds.Tables["Personne"].Select("codePersonne= '" + BDDUtil.getCodeFromNames(NP)[0] + "'").CopyToDataTable();
            if (BDDUtil.getCodeFromNames(NP) != Personne.Rows[0]["codePersonne"])
            {
                BDDUtil.ajouterPersonne(nom, prenom);
            }
        }

        //crée un PDF
        private void btnPDF_Click(object sender, EventArgs e)
        {
            transaction = ds.Tables["Transaction"].Select("codeTransaction = '" + cbbTransactionExistantes.SelectedValue + "'").CopyToDataTable();
            //  DataRow[] tabTransaction = new DataRow()[transaction.Rows.Count];


            if (dtpFinPer.Value >= dtpDebPer.Value)
            {
                while ((DateTime)transaction.Rows[0]["dateTransaction"] < dtpFinPer.Value) ;
                {
                    if ((DateTime)transaction.Rows[0]["dateTransaction"] > dtpDebPer.Value) ;
                    {

                    }
                }

            }
        }
        //ajoute un personne via l'onglet ajouter"
        private void btnAjouterPers_Click(object sender, EventArgs e)
        {
            supprimerGens();
            ajouterPersonneGlob();
            regeneAgain();
        }

        //supprimme l'affichage des gens
        private void supprimerGens()
        {
            flpListePersonneInModif.Controls.Clear();
            flpPersonne.Controls.Clear();
        }


        //reregenere les gens
        private void regeneAgain()
        {
            generationdyna1();
            generationdyna2();
        }

        //ajoute une personne via l'onglet "modifier"
        private void btnAjouterPersonneInModif_Click(object sender, EventArgs e)
        {
            supprimerGens();
            ajouterPersonneModif();
            regeneAgain();
        }

        private void dataBinding()
        {

        }

        private void TabModif_Click(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
    }
}