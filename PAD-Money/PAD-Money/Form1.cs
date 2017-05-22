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
        public string CH_CON = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        public OleDbConnection connec;

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
            }
        }

        private void btnBudgetPrevi_Click(object sender, EventArgs e)
        {
            FrmBudgetPrevi frm = new FrmBudgetPrevi(connec);
            frm.ShowDialog();
        }
    }
}
