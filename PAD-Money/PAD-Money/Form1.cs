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
    public partial class frmMain : Form
    {
        public string CH_CON = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        public OleDbConnection connec;
        private DataSet ds;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnBudgetMois_Click(object sender, EventArgs e)
        {
            FrmBudgetMois frm = new FrmBudgetMois(connec);
            frm.ShowDialog();
        }

        private void btnOuvrirBase_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                connec = new OleDbConnection(CH_CON + ofd.FileName);
                try
                {
                    connec.Open();
                    ds = new DataSet();
                    DataTable schema = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                    OleDbDataAdapter da = new OleDbDataAdapter();
                    //import de la base de donnée en local
                    for (int i = 0; i < schema.Rows.Count; i++)
                    {
                        //on récupère le nom des tables
                        String requete = "SELECT * FROM [" + schema.Rows[i].ItemArray[2]+"]";
                        OleDbCommand com = new OleDbCommand(requete, connec);
                        da.SelectCommand = com;
                        da.Fill(ds, schema.Rows[i].ItemArray[2].ToString());

                    }
                }
                catch(Exception erreur)
                {
                    MessageBox.Show(erreur.Message);
                }
                finally
                {
                    if(connec.State == ConnectionState.Open)
                    {
                        connec.Close();
                    }
                }
            }
        }

        private void btnBudgetPrevi_Click(object sender, EventArgs e)
        {
            FrmBudgetPrevi frm = new FrmBudgetPrevi(connec, ds);
            frm.ShowDialog();
        }
    }
}
