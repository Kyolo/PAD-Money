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
        BindingSource bs1 = new BindingSource();

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

            transaction = ds.Tables["Transaction"].Select("codeTransaction = '" + cbbTransactionExistantes.SelectedValue + "'").CopyToDataTable();
            initSup();




            remplir();
        }

        //affiche les elements de l'onglet "supprimer"

        private void initSup()
        {

            lblDate2.Text = transaction.Rows[0]["dateTransaction"].ToString();
            lblDescription2.Text = transaction.Rows[0]["description"].ToString();
            lblMontant2.Text = transaction.Rows[0]["montant"].ToString();

            lblType2.Text = getLibTransac(int.Parse(transaction.Rows[0]["codeTransaction"].ToString()));
            if (transaction.Rows[0]["recetteON"].ToString() == "True")
            {
                lblRorP.Text = "Recette";
            }
            else lblRorP.Text = "Pas recette";
            if (transaction.Rows[0]["percuON"].ToString() == "True")
            {
                lblPerca.Text = "Perçu";
            }
            else
            {
                lblPerca.Text = "Pas perçu";
            }
            cbbTransactionExistantes.SelectedIndex = 0;
        }
        private void afficher_sup()
        {
            /*if (cbbTransactionExistantes.Text != string.Empty)
            {

                string res = transaction.Rows[0]["codeTransaction"].ToString();
                DataTable TypeFin = ds.Tables["TypeTransaction"].Select("codeType = '" + res + "'").CopyToDataTable();
                
            }*/
            int code = int.Parse(cbbTransactionExistantes.SelectedValue.ToString());
            foreach (DataRow row in ds.Tables["Transaction"].Rows)
            {
                if (code == int.Parse(row["codeTransaction"].ToString()))
                {
                    lblDate2.Text = row["dateTransaction"].ToString();
                    lblDescription2.Text = row["description"].ToString();
                    lblMontant2.Text = row["montant"].ToString();
                    lblType2.Text = getLibTransac(int.Parse(row["type"].ToString()));

                    if (row["recetteON"].ToString() == "True")
                    {
                        lblRorP.Text = "Recette";
                    }

                    else
                    {
                        lblRorP.Text = "Pas recette";
                    }

                    if (row["percuON"].ToString() == "True")
                    {
                        lblPerca.Text = "Perçu";
                    }

                    else
                    {
                        lblPerca.Text = "Pas perçu";
                    }
                }
            }
        }

        private string getLibTransac(int code)
        {
            string res = string.Empty;
            foreach (DataRow row in ds.Tables["TypeTransaction"].Rows)
            {
                if (code == int.Parse(row["codeType"].ToString()))
                {
                    res = row["libType"].ToString();
                }
            }
            return res;
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
            bool recette = false;
            bool percu = false;
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
            Dictionary<String, object> dico = new Dictionary<String, object>();
            dico.Add("dateTransaction", dtmDateModif.Value.Date);
            dico.Add("description", txbDescriptionModif.Text);
            dico.Add("montant", float.Parse(txbMontantModif.Text));
            dico.Add("RecetteOn", cbRecuModif.Checked);
            dico.Add("PercuOn", cbPercuModif.Checked);
            dico.Add("type", int.Parse(cbbTypeModif.SelectedValue.ToString()));
            BDDUtil.modifyLine("Transaction", "codeTransaction", int.Parse(cbbChoixtransacModif.SelectedValue.ToString()), dico);
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
            string prenom = txbPrenom1.Text;
            string nom = txbNom2.Text;
            string[] NP = new string[] { nom + " " + prenom };
            DataTable Personne = ds.Tables["Personne"];
            if (BDDUtil.getCodeFromNames(NP) != Personne.Rows[0]["codePersonne"])
            {
                BDDUtil.ajouterPersonne(nom, prenom);
            }
        }

        private void ajouterPersonneModif()
        {
            string prenom = txbPrenom.Text;
            string nom = txbNom.Text;
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
                //while ((DateTime)transaction.Rows[0]["dateTransaction"] < dtpFinPer.Value) ;

                if ((DateTime)transaction.Rows[0]["dateTransaction"] > dtpDebPer.Value && (DateTime)transaction.Rows[0]["dateTransaction"] < dtpFinPer.Value)
                {
                    //On prend les deux tables de bases
                    DataTable tabTrans = ds.Tables["Transaction"];
                    DataTable tabType = ds.Tables["TypeTransaction"];

                    DataTable togive = tabTrans.Copy();
                    //on rajoute une nouvelle colonne
                    togive.Columns.Add(new DataColumn("libType", tabType.Columns[1].DataType));

                    foreach (DataRow nrow in togive.Rows)
                    {
                        //On donne le nom du type
                        foreach (DataRow oldrow in tabType.Rows)
                        {
                            if (nrow["type"].Equals(oldrow["codeType"]))
                            {
                                nrow["libType"] = oldrow["libType"];
                            }
                        }
                    }

                    //On retire la colonne du codeType
                    togive.Columns.Remove(togive.Columns["type"]);
                    DateTime start = dtpDebPer.Value;
                    DateTime stop = dtpFinPer.Value;
                    Printer rappor = Printer.createReport(start, stop, togive.Select("#" + start.Day + "/" + start.Month + "/" + start.Year + "# < dateTransaction AND dateTransaction < #" + stop.Day + "/" + stop.Month + "/" + stop.Year + "#"), new Font(new FontFamily("Consolas"), 10));
                    rappor.showPreview();
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

        private void cbbTransactionExistantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            afficher_sup();
        }

        private void btnAjouterPersonneInModif_Click_1(object sender, EventArgs e)
        {
            supprimerGens();
            ajouterPersonneModif();
            regeneAgain();
        }

        private void remplir()
        {
            DataTable modele = new DataTable();
            modele.Columns.Add("codeTransaction");
            modele.Columns.Add("dateTransaction");
            modele.Columns.Add("description");
            modele.Columns.Add("montant");
            modele.Columns.Add("recetteON");
            modele.Columns.Add("percuON");
            modele.Columns.Add("type");
            modele.Columns.Add("libType");
            foreach(DataRow fin in ds.Tables["Transaction"].Rows)
            {
                DataRow onycroit = modele.NewRow();
                onycroit["codeTransaction"] = fin["codeTransaction"];
                onycroit["dateTransaction"] = fin["dateTransaction"];
                onycroit["description"] = fin["description"];
                onycroit["montant"] = fin["montant"];

                if ((bool)fin["recetteON"] == true)
                {
                    onycroit["recetteON"] = "oui";
                }
                else onycroit["recetteON"] = "non";

                if ((bool)fin["percuON"] == true)
                {
                    onycroit["percuON"] = "oui";
                }
                else onycroit["percuON"] = "non";

                onycroit["type"] = fin["type"];
                foreach (DataRow r in ds.Tables["TypeTransaction"].Rows)
                {
                    if (int.Parse(fin["type"].ToString())== int.Parse(r["codeType"].ToString()))
                    {
                        onycroit["libType"] = r["libType"];
                    }
                }
                modele.Rows.Add(onycroit);
            }
            dgvFinal.DataSource = modele;
        }

        //data binding
        private void FrmBudgetMois_Load(object sender, EventArgs e)
        {
            DataSet dset = new DataSet();
            dset = ds;
            dset.Relations.Add("fk_transaction_dt", dset.Tables["TypeTransaction"].Columns["codeType"], dset.Tables["Transaction"].Columns["Type"]);
            BindingSource bs2 = new BindingSource();
            bs1.DataSource = dset;
            bs1.DataMember = "TypeTransaction";
            bs2.DataSource = bs1;
            bs2.DataMember = "fk_transaction_dt";
            lblDescrtion1v1.DataBindings.Add(new Binding("Text", bs2, "description", true));
            lblMontant1v1.DataBindings.Add(new Binding("Text", bs2, "montant", true));
            lblType1v1.DataBindings.Add(new Binding("Text", bs1, "libType", true));
            cbPercu1v1.DataBindings.Add(new Binding("Checked", bs2, "percuON", true));
            cbRecette1v1.DataBindings.Add(new Binding("Checked", bs2, "recetteON", true));
            dtp1v1.DataBindings.Add(new Binding("Value", bs2, "dateTransaction", true));

            dset = ds;
            dset.Relations.Add("fk_Personne_dt", dset.Tables["Personne"].Columns["codePersonne"], dset.Tables["Beneficiaires"].Columns["codePersonne"]);
           //fonctionnel si beneficiaire non null, à priori
            /*dset.Relations.Add("fk_Benef_dt", dset.Tables["Beneficiaires"].Columns["codeTransaction"], dset.Tables["Transaction"].Columns["codeTransaction"]);
            BindingSource bs3 = new BindingSource();
            BindingSource bs4 = new BindingSource();
            BindingSource bs5 = new BindingSource();
            bs3.DataSource = dset;
            bs3.DataMember = "Personne";
            bs4.DataSource = bs3;
            bs4.DataMember = "fk_Personne_dt";
            bs5.DataSource = bs4;
            bs5.DataMember = "fk_Benef_dt";

            int x = 50;
            int y = 50;
            DataTable personne = new DataTable();
            personne = ds.Tables["Personne"];
            foreach (DataRow row in personne.Rows)
            {
                CheckBox nom = new CheckBox();
                nom.AutoSize = true;
                nom.Location = new System.Drawing.Point(x, y);
                nom.Size = new System.Drawing.Size(98, 21);
                nom.DataBindings.Add(new Binding("Text", bs5, "pnPersonne", true));
                flowLayoutPanel1.Controls.Add(nom);
                y += 20;

            }*/
        }
        private int val = 0;

        private void btnFirst_Click(object sender, EventArgs e)
        {
            int btn = int.Parse(((Button)sender).Tag.ToString());
            switch (btn)
            {
                case 1:
                    val = 1;
                    break;
                case 2:
                    val--;
                        if(val<1)
                    {
                        val = 1;
                    }
                    break;
                case 3:
                    val++;
                    if(val>ds.Tables["Transaction"].Rows.Count)
                    {
                        val = ds.Tables["Transaction"].Rows.Count;
                    }
                    break;
                case 4:
                    val = ds.Tables["Transaction"].Rows.Count;
                    break;
                default:
                    break;
            }
            lblNumPage.Text = val.ToString();
        }

        private void txtMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool virgule = false;
            if (((TextBox)sender).Text.Contains('.'))
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
                    ((TextBox)sender).Text += '.';
                }
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}