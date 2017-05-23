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

        public FrmBudgetPrevi(OleDbConnection connec, DataSet ds)
        {
            this.connec = connec;
            this.ds = ds;           
            InitializeComponent();
            remplirCbbPoste();
            remplirCbbPeriode();
        }

        private void FrmBudgetPrevi_Load(object sender, EventArgs e)
        {

        }

        private void remplirCbbPoste()
        {
            DataTable table = new DataTable();
            table = ds.Tables["Poste"];
            cbbPoste.DataSource = table;
            cbbPoste.DisplayMember = "libPoste";
            cbbPoste.ValueMember = "codePoste";
        }

        private void remplirCbbPeriode()
        {
            DataTable table = new DataTable();
            table = ds.Tables["Periodicite"];
            cbbPeriode.DataSource = table;
            cbbPeriode.DisplayMember = "libPer";
            cbbPeriode.ValueMember = "codePer";
        }

        private void cbbPoste_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtMontantPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool virgule = false;

            if(char.IsDigit(e.KeyChar) || e.KeyChar =='.' || e.KeyChar ==',' || e.KeyChar == Keys.Control)
            {
                if((e.KeyChar == '.' || e.KeyChar == ',') && virgule)
                {
                    e.Handled = true;
                }
                else if ((e.KeyChar == '.' || e.KeyChar == ',') && !virgule)
                {
                    virgule = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
