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
    public partial class frmMain : Form
    {
        public const string CH_CON = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        private OleDbConnection connec;
        private DataSet ds;

        private FrmBudgetMois budgetMois = null;

        private FrmBudgetPrevi budgetprevi = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnBudgetMois_Click(object sender, EventArgs e)
        {
            if(budgetMois == null)
                budgetMois = new FrmBudgetMois(connec,ds);
            budgetMois.ShowDialog();
        }

        private void btnBudgetPrevi_Click(object sender, EventArgs e)
        {
            //On stock les formulaire en locale pour ne pas avoir à le remplir à chaques fois qu'on les affiches
            if(budgetprevi == null)
                budgetprevi = new FrmBudgetPrevi(connec,ds);
            budgetprevi.ShowDialog();
        }


        private void btnOuvrirBase_Click(object sender, EventArgs e) {

            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK) {
                connec = new OleDbConnection(CH_CON + ofd.FileName);
                try {
                    connec.Open();
                    ds = new DataSet();
                    DataTable schema = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                    OleDbDataAdapter da = new OleDbDataAdapter();
                    //import de la base de donnée en local
                    for (int i = 0; i < schema.Rows.Count; i++) {
                        //on récupère le nom des tables
                        String requete = "SELECT * FROM [" + schema.Rows[i].ItemArray[2]+"]";
                        OleDbCommand com = new OleDbCommand(requete, connec);
                        da.SelectCommand = com;
                        da.Fill(ds, schema.Rows[i].ItemArray[2].ToString());

                    }
                }
                catch(Exception erreur) {
                    MessageBox.Show("Erreur en remplissant la table :\n"+erreur.Message);
                }
                finally {
                    if(connec.State == ConnectionState.Open) {
                        connec.Close();
                    }
                }
            }
        }

    }
}
