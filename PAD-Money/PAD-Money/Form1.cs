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
    public partial class FrmMenu : Form
    {
        public const string CH_CON = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        private OleDbConnection connec;
        private DataSet ds;

        private FrmBudgetMois budgetMois = null;

        private FrmBudgetPrevi budgetprevi = null;

        private static NotifyIcon notification = null;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }


        //*********************************************************************** */
        // Ouverture des volets
        //*********************************************************************** */

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


        //*********************************************************************** */
        // Ouverture de la bdd
        //*********************************************************************** */

        private void btnOuvrirBase_Click(object sender, EventArgs e) {

            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK) {
                connec = new OleDbConnection(CH_CON + ofd.FileName);
                try {

                    connec.Open();
                    ds = new DataSet();
                    //On récupère le schéma de la bdd
                    DataTable schema = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                    OleDbDataAdapter da = new OleDbDataAdapter();
                    //import de la base de donnée en local
                    for (int i = 0; i < schema.Rows.Count; i++) {
                        //on récupère le nom des tables
                        String requete = "SELECT * FROM [" + schema.Rows[i].ItemArray[2]+"]";
                        OleDbCommand com = new OleDbCommand(requete, connec);
                        da.SelectCommand = com;
                        //On remplit le DataSet via le DataAdapter
                        da.Fill(ds, schema.Rows[i].ItemArray[2].ToString());

                    }
                    
                    //On active les boutons pour accéders aux budgets
                    this.btnBudgetMois.Enabled = true;
                    this.btnBudgetPrevi.Enabled = true;

                    //On supprime les Form qu'on a stocker pour qu'ils se mettent à jour
                    this.budgetMois = null;
                    this.budgetprevi = null;
                } catch(Exception erreur) {
                    MessageBox.Show("Erreur en remplissant la table :\n"+erreur.Message);
                } finally {
                    if(connec.State == ConnectionState.Open) {
                        connec.Close();
                    }
                }
            }
        }


        //*********************************************************************** */
        // Gestion de l'aide/tooltip
        //*********************************************************************** */

        private void btnKillToast_Click(object sender, EventArgs e) {
         
            if (notification != null) {
                notification.Dispose();
                notification = null;
            }
        }

        private void btnAide_Click(object sender, EventArgs e){

            if (notification == null) {
                //On crée l'icone qui servira à la notification
                notification = new NotifyIcon() {
                    Visible = true,//Est visible
                    Icon = System.Drawing.SystemIcons.Information,//Donne les icones d'informations
                    BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info,
                    BalloonTipTitle = "Aide de PAD-Money",
                };
                //On rajoute un context menu pour pouvoir facilement enlever l'icone de notification
                ContextMenu menu = new ContextMenu();
                MenuItem item = new MenuItem("Enlever", new EventHandler(btnKillToast_Click));
                menu.MenuItems.Add(item);
                notification.ContextMenu = menu;
            }
            FrmMenu.showBaloonTip("Vous avez activé l'aide !");
        }

        public static void showBaloonTip(String message){
            //On affiche que si le NotifyIcon est là (et donc que l'aide est activée)
            if(notification != null){
                notification.BalloonTipText = message;
                notification.ShowBalloonTip(5);
            }
        }


        //*********************************************************************** */
        // Autres methodes utiles
        //*********************************************************************** */

        ~FrmMenu(){
            if (notification != null) {
                notification.Dispose();
                notification = null;
            }
        }

    }
}
