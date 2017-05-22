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

        public FrmBudgetPrevi(OleDbConnection connec)
        {
            this.connec = connec;
            InitializeComponent();
        }
    }
}
